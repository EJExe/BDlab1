using BLL;
using BLL.Models;
using BLL.Services;
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
        
        UsersService usersService = new UsersService();
        ReportService reportService = new ReportService();
        DBDataOperation operation = new DBDataOperation();
        List<USER> users;
        List<TARIFF> tARIFF;


        //OperatorMobileConnectionContext dbcontext = new OperatorMobileConnectionContext();
        //List<User> allUsers;
        //List<tariff> allTarifs;
        //List<User> allUsersFilt;


        

        public Form1()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            //allTarifs = dbcontext.tariff.ToList();
            //allUsers = dbcontext.User.ToList();

            //comboBoxUserPick.DataSource = allUsers;
            //comboBoxUserPick.DisplayMember = "FIO";
            //comboBoxUserPick.ValueMember = "ID_User";
            loadTar();
            loadUsers();
            
            
        }

        private void loadUsers()
        {
            users = usersService.GetUsers();
            bindingSource1.DataSource = users;
        }
        private void loadTar()
        {
            tARIFF = operation.GetTARIFFS();
            bindingSource3.DataSource = tARIFF;
            DataGridViewComboBoxColumn combo = ((DataGridViewComboBoxColumn)dataGridViewUs.Columns["id_tariff_fkDataGridViewComboBoxColumn"]);
            combo.DataSource = tARIFF;
            combo.DisplayMember = "Name";
            combo.ValueMember = "ID_Tariff";
            Ordersdatagrid.DataSource = operation.GetTARIFFS();
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

        //private void buttonSort_Click(object sender, EventArgs e)
        //{
        //    int selectedUser = (int)comboBoxUserPick.SelectedValue;

        //    // Фильтрация данных
        //    allUsersFilt = allUsers.Where(h => h.ID_User == selectedUser).ToList();

        //    // Обновление DataGridView
        //    dataGridViewUs.DataSource = allUsersFilt;
        //}



        public class SPResult
        {
            public int ID_Call { get; set; }
            public int Amount { get; set; }
            public DateTime Time_of_start { get; set; }

        }
      

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewUs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveUs_Click(object sender, EventArgs e)
        {
            bool res = Validate();
            if (res)
            {
                usersService.Save();
            }
        }

        private void ADDBUTTON_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();

            f.comboBox1.DataSource = tARIFF;
            f.comboBox1.DisplayMember = "Name";
            f.comboBox1.ValueMember = "ID_Tariff";

            DialogResult result = f.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            USER us = new USER();
            us.ID_tariff = users.Count() + 1;
            us.ID_tariff = (int)f.comboBox1.SelectedValue;
            us.phone_number = f.textBox2.Text;
            us.fio = f.textBox1.Text;
            usersService.CreateUser(us);
            users = usersService.GetUsers();
            loadUsers();
            MessageBox.Show("New ADD");
        }

        private void UPDATEBUTTON_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridViewUs);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewUs[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                USER contr = users.Where(i => i.ID_user == id).FirstOrDefault();
                if (contr != null)
                {
                    Form2 f = new Form2();
                    f.comboBox1.DataSource = tARIFF;
                    f.comboBox1.DisplayMember = "Name";
                    f.comboBox1.ValueMember = "ID_Tariff";

                    f.comboBox1.SelectedValue = contr.ID_tariff;
                    f.textBox1.Text = contr.fio;
                    f.textBox2.Text = contr.phone_number;

                    DialogResult result = f.ShowDialog(this);

                    if (result == DialogResult.Cancel)
                        return;
                    contr.ID_tariff = (int)f.comboBox1.SelectedValue;
                    contr.fio = f.textBox1.Text;
                    contr.phone_number = f.textBox2.Text;
                    usersService.UpdateUsers(contr);
                    loadUsers();
                    MessageBox.Show("Объект обновлен");
                }
            }
            else
                MessageBox.Show("Ни один объект не выбран!");
        }

        private void DELETEBUTTON_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridViewUs);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewUs[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                usersService.DeleteUser(id);
                bindingSource1.DataSource = usersService.GetUsers();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewReps.DataSource = ReportService.ExecuteSP(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewReps.DataSource = ReportService.ReportTar();
        }

        private void AddTarButton_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            if (f.ShowDialog() == DialogResult.OK)
                Ordersdatagrid.DataSource = operation.GetTARIFFS();
        }
    }
    
}
