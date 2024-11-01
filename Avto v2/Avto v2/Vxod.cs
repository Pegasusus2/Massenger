using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Avto_v2
{
    public partial class Vxod : Form
    {
        DataBase1 database = new DataBase1();
        public Vxod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSend.text = login.Text;
            var passUser = password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable tabel = new DataTable();

            string querystring = $"select id, login, pass from register " +
                $"where login = '{DataSend.text}' " +
                $"and pass = '{passUser}' ";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(tabel);

            if (tabel.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!");
                Form1 osnova = new Form1();
                this.Hide();
                osnova.Show();
            }

            else
            {
                MessageBox.Show("Такого аккаунта не существует!");
            }

        }

        private void Vxod_Load(object sender, System.EventArgs e)
        {
            Console.WriteLine(login.Text);
            Console.WriteLine(password.Text);
        }

        private void Vxod_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Механик". При необходимости она может быть перемещена или удалена.
            this.механикTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Механик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Microsoft_Access_База_данных__2_DataSet.Механик". При необходимости она может быть перемещена или удалена.

            // TODO: данная строка кода позволяет загрузить данные в таблицу "forPersonalDataSet.personak". При необходимости она может быть перемещена или удалена.
            this.personakTableAdapter.Fill(this.forPersonalDataSet.personak);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
