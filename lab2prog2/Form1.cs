using CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2prog2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (JobContext dbc = new JobContext())
            {
                dbc.Jobs.Select(i => i).ToList();
                //Можно сразу добавить данные:
                dbc.Jobs.Add(new Job() { Owner = "PostMelone", Name = "MeloneMushic" });
                dbc.SaveChanges();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
