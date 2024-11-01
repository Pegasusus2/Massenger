using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Механик". При необходимости она может быть перемещена или удалена.
            this.механикTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Механик);
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Avto avto = new Avto();
            avto.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner owner = new Owner();
            owner.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Master master = new Master();
            master.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mechanic mechanic = new Mechanic();
            mechanic.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Remont remont = new Remont();
            remont.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Plan plan = new Plan();
            plan.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            War war = new War();
            war.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Kategory kategory = new Kategory();
            kategory.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Postoyznik postoyznik = new Postoyznik();
            postoyznik.Show();
            this.Hide();
        }
    }
}
