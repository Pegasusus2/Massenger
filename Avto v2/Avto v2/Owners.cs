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
    public partial class Owners : Form
    {
        public Owners()
        {
            InitializeComponent();
        }

        private void владелецBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.владелецBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.microsoft_Access_База_данныхDataSet);

        }

        private void Owners_Load(object sender, EventArgs e)
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
