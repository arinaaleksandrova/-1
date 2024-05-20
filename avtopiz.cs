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
    public partial class avtopiz : Form
    {
        DataBase dataBase = new DataBase();
        public avtopiz()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Regist registrati = new Regist();
            registrati.ShowDialog();
            Hide();
        }

   

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            pictureBox2.Visible = false;
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id, login, password, Admin from login where login = '{loginUser}' and password = '{passUser}' ";

            SqlCommand command = new SqlCommand(querystring, dataBase.qetConnetion());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                var userez = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[3]));

                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Glav main = new Glav(userez);
                this.Hide();
                main.ShowDialog();
            }
            else
                MessageBox.Show("Такого аккаунта не существует", "Аккаунта не существует.", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void pictureBox_clear_Click(object sender, EventArgs e)
        {
            textBox_login.Text = "";
            textBox_password.Text = "";
        }

        private void pictureBox_open_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            pictureBox_zz.Visible = true;
            pictureBox_zo.Visible = false;
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            pictureBox_zz.Visible = false;
            pictureBox_zo.Visible = true;
        
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_zo_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            pictureBox_zz.Visible = true;
            pictureBox_zo.Visible = false;
        }

        private void pictureBox_zz_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            pictureBox_zz.Visible = false;
            pictureBox_zo.Visible = true;
        }

        private void avtopiz_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.list-org.com/company/822623?ysclid=lw6c5omkny837104095");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
