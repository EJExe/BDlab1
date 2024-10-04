using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace laboratornaya1
{
    public partial class Form1 : Form
    {
        #region Строка подключения к БД

        private string connectionString;

        #endregion

        #region Объекты NpgsqlDataAdapter

        private SqlDataAdapter userAdapter;
        private SqlDataAdapter tariffAdapter;
        private SqlDataAdapter callAdapter;
        private SqlDataAdapter typeOfCallAdapter;
        private SqlDataAdapter typeUserAdapter;
        private SqlDataAdapter SpravochnikTariffAdapter;

        #endregion

        #region Объекты NpgsqlCommandBuilder

        private SqlCommandBuilder userBuilder;
        private SqlCommandBuilder tariffBuilder;
        private SqlCommandBuilder callBuilder;
        private SqlCommandBuilder typeOfCallBuilder;
        private SqlCommandBuilder typeUserBuilder;
        private SqlCommandBuilder SpravochnikTariffBuilder;

        #endregion

        #region Объект DataSet

        private DataSet dataSet = new DataSet();

        #endregion
        public Form1()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection1"].ConnectionString;

            userAdapter = new SqlDataAdapter("Select * from \"User\";", connectionString);
            tariffAdapter = new SqlDataAdapter("Select * from \"tariff\";", connectionString);
            callAdapter = new SqlDataAdapter("Select * from \"call\";", connectionString);
            typeOfCallAdapter = new SqlDataAdapter("Select * from \"type_of_call\";", connectionString);
            typeUserAdapter = new SqlDataAdapter("Select * from \"TypeUser\";", connectionString);
            SpravochnikTariffAdapter = new SqlDataAdapter("Select * from \"SpravochnikTariff\";", connectionString);

            userBuilder = new SqlCommandBuilder(userAdapter);
            callBuilder = new SqlCommandBuilder(callAdapter);
            tariffBuilder = new SqlCommandBuilder(tariffAdapter);
            typeOfCallBuilder = new SqlCommandBuilder(typeOfCallAdapter);
            typeUserBuilder = new SqlCommandBuilder(typeUserAdapter);
            SpravochnikTariffBuilder = new SqlCommandBuilder(SpravochnikTariffAdapter);

            userAdapter.Fill(dataSet, "User");
            tariffAdapter.Fill(dataSet, "tariff");
            callAdapter.Fill(dataSet, "call");
            typeOfCallAdapter.Fill(dataSet, "type_of_call");
            typeUserAdapter.Fill(dataSet, "TypeUser");
            SpravochnikTariffAdapter.Fill(dataSet, "SpravochnikTariff");

            dataGridViewUser.DataSource = dataSet.Tables["User"];
            dataGridViewTariff.DataSource = dataSet.Tables["tariff"];
            dataGridViewCall.DataSource = dataSet.Tables["call"];
            dataGridViewTypeOfCall.DataSource = dataSet.Tables["type_of_call"];
            dataGridViewTypeUser.DataSource = dataSet.Tables["TypeUser"];
            dataGridViewSpravochnikTariff.DataSource = dataSet.Tables["SpravochnikTariff"];

            //FillUserCombobox();
            FillReportCombobox();
            FillTariffComboBox();
        }

        private void FillReportCombobox() // комбобокс который ничего не делает 
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                // Используем команду для более явного и безопасного запроса
                using (var sqlCommand = new SqlCommand("select ID_User, FIO from [User]", sqlConnection))
                {
                    sqlConnection.Open();

                    // Используем SqlDataReader для чтен    ия данных
                    using (var reader = sqlCommand.ExecuteReader())
                    {
                        // Создаем список для хранения данных
                        List<KeyValuePair<int, string>> userList = new List<KeyValuePair<int, string>>();

                        // Читаем данные из reader
                        while (reader.Read())
                        {
                            // Извлекаем значения из колонок
                            int id = reader.GetInt32(0);
                            string fio = reader.GetString(1);

                            // Добавляем данные в список
                            userList.Add(new KeyValuePair<int, string>(id, fio));
                        }

                        // Связываем комбобокс с данными
                        comboBoxUserReport.DataSource = userList;
                        comboBoxUserReport.DisplayMember = "Value";
                        comboBoxUserReport.ValueMember = "Key";
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e) {} // не юзать 

        private void SaveCALL_Click(object sender, EventArgs e) // кнопка сохранения для таблицы call
        {
            callAdapter.Update(dataSet, "call");
        }

        private void buttonUserSave_Click(object sender, EventArgs e)// кнопка сохранения для таблицы user
        {
            userAdapter.Update(dataSet, "User");
        }

        private void buttonADD_Click(object sender, EventArgs e) // добавление новой строки для таблицы user // tables[0] - 0 указывает на таблицу ( тк она 1 в tabcontrole ) 
        {
            DataRow row = dataSet.Tables[0].NewRow();
            dataSet.Tables[0].Rows.Add(row);
        }

        private void comboBoxUserReport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FillTariffComboBox() // Метод заполняет comboBox1 списком тарифов из таблицы “Тарифы”.
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                using (var sqlCommand = new SqlCommand("SELECT ID_Tariff, Name FROM Tariff", sqlConnection))
                {
                    sqlConnection.Open();
                    using (var reader = sqlCommand.ExecuteReader())
                    {
                        comboBox1.Items.Clear();
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Метод вызывается при изменении выбранного элемента в comboBox1.
        {
            if (comboBox1.SelectedItem != null)
            {
                KeyValuePair<int, string> selectedTariff = (KeyValuePair<int, string>)comboBox1.SelectedItem;
                FillDataGridView(selectedTariff.Key);
            }
        }

        private void FillDataGridView(int tariffId) // вызов обычной процедуры 
//Метод выполняет SQL-запрос, который:
//Выбирает ID_Пользователя и Имя из таблицы “Пользователи”.
//Использует INNER JOIN для соединения таблиц “Пользователи” и “Привязка_Тарифов” по ID_Пользователя.
//Фильтрует записи, где ID_Тарифа в таблице “Привязка_Тарифов” соответствует выбранному tariffId.
//Загружает полученные данные в DataTable и присваивает его в качестве DataSource для dataGridView1.
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                using (var sqlCommand = new SqlCommand("SELECT [User].ID_User, [User].FIO FROM [User] " +
                                                      "INNER JOIN tariff ON [User].[ID_Tariff(FK)] = tariff.ID_Tariff " +
                                                      "WHERE tariff.ID_Tariff = @tariffId", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@tariffId", tariffId);
                    sqlConnection.Open();
                    using (var reader = sqlCommand.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) // вызов влож. процедуры 
        {
            DateTime data1 = dateTimePicker1.Value.Date;
            DateTime data2 = dateTimePicker2.Value.Date;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("GetCallsByTimeRange", connection);
                sqlAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlAdapter.SelectCommand.Parameters.Add(new SqlParameter("@StartTime", SqlDbType.Date));
                sqlAdapter.SelectCommand.Parameters.Add(new SqlParameter("@EndTime", SqlDbType.Date));
                sqlAdapter.SelectCommand.Parameters["@StartTime"].Value = data1;
                sqlAdapter.SelectCommand.Parameters["@EndTime"].Value = data2;


                DataSet dataSet = new DataSet();
                sqlAdapter.Fill(dataSet, "report2");

                dataGridViewVlojProc.DataSource = dataSet.Tables["report2"];
            }
        }

        private void buttonTariffsave_Click(object sender, EventArgs e)
        {
            tariffAdapter.Update(dataSet, "tariff");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonADDcall_Click(object sender, EventArgs e) // добавление новой строки для таблицы call 
        {
            DataRow row = dataSet.Tables[2].NewRow();
            dataSet.Tables[2].Rows.Add(row);
        }

        private void buttonRemoveCall_Click(object sender, EventArgs e) // удаление последней строки в call 
        {
            dataSet.Tables[2].Rows[dataSet.Tables[2].Rows.Count - 1].Delete();
        }

        private void buttonRemoveUser_Click(object sender, EventArgs e) // удаление последней строки в user 
        {
            dataSet.Tables[0].Rows[dataSet.Tables[0].Rows.Count - 1].Delete();
        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
