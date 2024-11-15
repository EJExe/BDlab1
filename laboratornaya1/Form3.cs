using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BLL;
using BLL.Services;
using Interfaces.Models.Models;

namespace laboratornaya1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OkeyButtonTar_Click(object sender, EventArgs e)
        {
            TARIFF order = new TARIFF()
            {
                Name = textBox1NAME.Text,
                typeoftariff = textBox2TYPE.Text,
                Price = Convert.ToInt32(textBox3PRICE.Text),
            };

            DBDataOperation service = new DBDataOperation(); 
            bool result = service.MakeTar(order,textBox1NAME.Text);
            if (result)
            {
                order.Name = textBox1NAME.Text;
                order.Price = Convert.ToInt32(textBox3PRICE.Text);
                service.CreateTARIFF(order);
                MessageBox.Show("Success");
                DialogResult = DialogResult.OK;
                Close();
            }
            else MessageBox.Show("Failed");
        }

        private void CancelButtonTar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBox3PRICE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
