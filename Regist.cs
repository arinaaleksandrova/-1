using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Medicine_312
{
    public partial class Regist : Form
    {
        DataBase dataBase = new DataBase();
        public Regist()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nam = textBox_name.Text;
            var fam = textBox_surname.Text;
            var otc = textBox_otchestvo.Text;
            var log = textBox_login.Text;
            var par = textBox_password.Text;

            string querystring = $"insert into login(login, password, name, surname,otechestvo, Admin ) values ('{log}', '{par}', '{nam}', '{fam}', '{otc}', 0 )";

            SqlCommand command = new SqlCommand(querystring, dataBase.qetConnetion());

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно зарегистрирован!", "Успешно");
                avtopiz form1 = new avtopiz();
                this.Hide();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не зарегистрирован!");
            }
            dataBase.closeConnection();
        }

        private Boolean proverUser()
        {
            var nam = textBox_name.Text;
            var fam = textBox_surname.Text;
            var otc = textBox_otchestvo.Text;
            var log = textBox_login.Text;
            var par = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id, login, password, name, surname, otechestvo, Admin from login where login = '{log}' and password = '{par}' and name = '{nam}' and surname = '{fam}' and otechestvo = '{otc}' ";

            SqlCommand command = new SqlCommand(querystring, dataBase.qetConnetion());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже зарегистрирован!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void pictureBox_clear_Click(object sender, EventArgs e)
        {
            textBox_name.Text = "";
            textBox_surname.Text = "";
            textBox_otchestvo.Text = "";
            textBox_login.Text = "";
            textBox_password.Text = "";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            avtopiz form = new avtopiz();
            form.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Regist_Load(object sender, EventArgs e)
        {

        }
    }
}
