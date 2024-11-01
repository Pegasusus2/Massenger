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
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }

        private void Kategori_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Категория_Итог". При необходимости она может быть перемещена или удалена.
            this.категория_ИтогTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Категория_Итог);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
