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
    public partial class War : Form
    {
        public War()
        {
            InitializeComponent();
        }

        private void War_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Механик_Запрос". При необходимости она может быть перемещена или удалена.
            this.механик_ЗапросTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Механик_Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Категория_итог". При необходимости она может быть перемещена или удалена.
            this.категория_итогTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Категория_итог);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
