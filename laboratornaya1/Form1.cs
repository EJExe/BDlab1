using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace laboratornaya1
{
    public partial class Form1 : Form
    {
        OperatorMobileConnectionContext dbcontext = new OperatorMobileConnectionContext();
        List<User> allUsers;
        List<tariff> allTarifs;
        List<User> allUsersFilt;

        public Form1()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            allTarifs = dbcontext.tariff.ToList();
            allUsers = dbcontext.User.ToList();

            loadUsers();

            comboBoxUserPick.DataSource = allUsers;
            comboBoxUserPick.DisplayMember = "FIO";
            comboBoxUserPick.ValueMember = "ID_User";

            //comboBox1.DataSource = allTarifs;
            //comboBox1.DisplayMember = "Name";
            //comboBox1.ValueMember = "ID_Tariff";

            DataGridViewComboBoxColumn combo = ((DataGridViewComboBoxColumn)dataGridViewUSERS.Columns["id_tariff_fkDataGridViewComboBoxColumn"]);
            combo.DataSource = allTarifs;
            combo.DisplayMember = "Name";
            combo.ValueMember = "ID_Tariff";
            
        }

        private void loadUsers()
        {
            dbcontext.User.Load(); 
            allUsers = dbcontext.User.ToList();
            dataGridViewUSERS.AutoGenerateColumns = false;
            dataGridViewUSERS.DataSource = allUsers;
        }

        private int getSelectedRow(DataGridView dataGridView)
        {
            int index = -1;
            if (dataGridView.SelectedRows.Count > 0 || dataGridView.SelectedCells.Count == 1)
            {
                if (dataGridView.SelectedRows.Count > 0)
                    index = dataGridView.SelectedRows[0].Index;
                else index = dataGridView.SelectedCells[0].RowIndex;
            }
            return index;
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e) { }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }

        private void dataGridViewUSERS_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        

        private void buttonGetReport1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();

            f.comboBox1.DataSource = allTarifs;
            f.comboBox1.DisplayMember = "Name";
            f.comboBox1.ValueMember = "ID_Tariff";

            DialogResult result = f.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            User us = new User();
            us.ID_User = allUsers.Count() + 1;
            us.ID_Tariff_FK_ = (int)f.comboBox1.SelectedValue;
            us.Phone_Number = f.textBox2.Text;
            us.FIO = f.textBox1.Text;
            us.Login = f.textBox1.Text;
            dbcontext.User.Add(us);
            dbcontext.SaveChanges();
            loadUsers();
            MessageBox.Show("New ADD");
        }

        private void button1_Click(object sender, EventArgs e) //кнопка апд
        {
            int index = getSelectedRow(dataGridViewUSERS);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewUSERS[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                User contr = dbcontext.User.Where(i => i.ID_User == id).FirstOrDefault();
                if (contr != null)
                {
                    Form2 f = new Form2();
                    f.comboBox1.DataSource = allTarifs;
                    f.comboBox1.DisplayMember = "Name";
                    f.comboBox1.ValueMember = "ID_Tariff";

                    f.comboBox1.SelectedValue = contr.ID_Tariff_FK_;
                    f.textBox1.Text = contr.FIO;
                    f.textBox2.Text = contr.Phone_Number;

                    DialogResult result = f.ShowDialog(this);

                    if (result == DialogResult.Cancel)
                        return;
                    contr.ID_Tariff_FK_ = (int)f.comboBox1.SelectedValue;
                    contr.FIO = f.textBox1.Text;
                    contr.Phone_Number = f.textBox2.Text;

                    dbcontext.SaveChanges();
                    loadUsers();
                    MessageBox.Show("Объект обновлен");
                }
            }
            else
                MessageBox.Show("Ни один объект не выбран!");
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            int selectedUser = (int)comboBoxUserPick.SelectedValue;

            // Фильтрация данных
            allUsersFilt = allUsers.Where(h => h.ID_User == selectedUser).ToList();

            // Обновление DataGridView
            dataGridViewUSERS.DataSource = allUsersFilt;
        }

        

        public class SPResult
        {
            public int ID_Call { get; set; }
            public int Amount { get; set; }
            public DateTime Time_of_start { get; set; }

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            var request = dbcontext.tariff
            .Join(dbcontext.User, c => c.ID_Tariff, em => em.ID_Tariff_FK_, (c, em) => new { tariff = c, User = em })
            .Where(x => x.User.ID_Tariff_FK_ == x.tariff.ID_Tariff)
            .GroupBy(x => x.tariff.Name)
            .Select(g => new { name = g.Key, quantity = g.Count() })
            .ToList();

            dataGridView1.DataSource = request;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;

            SqlParameter param1 = new SqlParameter("@StartTime", date1);
            SqlParameter param2 = new SqlParameter("@EndTime", date2);

            var result = dbcontext.Database.SqlQuery<SPResult>("GetCallsByTimeRange @StartTime,@EndTime", new object[] { param1, param2 }).ToList();
            var data = result.GroupBy(i => new { i.ID_Call, i.Time_of_start }).ToDictionary(i => i.Key, i => i.Select(j => j.Amount))
                .Select(i => new {
                    i.Key.ID_Call,
                    i.Key.Time_of_start,
                    Phones = String.Join(",", i.Value.Select(j => j).ToArray())
                }).ToList();

            dataGridView1.DataSource = data;
        }

    }
    
}
