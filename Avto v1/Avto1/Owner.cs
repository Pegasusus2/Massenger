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
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
        }

        private void Owner_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Владелец". При необходимости она может быть перемещена или удалена.
            this.владелецTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Владелец);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
