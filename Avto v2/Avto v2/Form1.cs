using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avto_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Kategori ka = new Kategori();
            ka.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Postoyanik pos = new Postoyanik();
            pos.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Srok srok = new Srok();
            srok.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            War war = new War();
            war.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Avto avto = new Avto();
            avto.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owners owners = new Owners();
            owners.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AvtoMaster am = new AvtoMaster();
            am.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mecaniks mecaniks = new Mecaniks();
            mecaniks.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Naryad naryad = new Naryad();
            naryad.Show();
            this.Close();
        }
    }
}
