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
    public partial class Naryad : Form
    {
        public Naryad()
        {
            InitializeComponent();
        }

        private void ремонтBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ремонтBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.microsoft_Access_База_данныхDataSet);

        }

        private void Naryad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Ремонт". При необходимости она может быть перемещена или удалена.
            this.ремонтTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Ремонт);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
