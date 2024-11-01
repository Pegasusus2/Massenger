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
    public partial class Mechanic : Form
    {
        public Mechanic()
        {
            InitializeComponent();
        }

        private void Mechanic_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Механик". При необходимости она может быть перемещена или удалена.
            this.механикTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Механик);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}
