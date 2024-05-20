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
    public partial class Dob : Form
    {
        private readonly checkUser _user;
        DataBase dataBase = new DataBase();
        public Dob()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var tovar = textBox_tovar.Text;
            var kol = textBox_kol.Text;
                var addQuery = $"insert into Tovar (name_tovar, kol) values ('{tovar}', '{kol}')";
                var command = new SqlCommand(addQuery, dataBase.qetConnetion());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataBase.closeConnection();
        }

        private void pictureBox_steret_Click(object sender, EventArgs e)
        {
            textBox_tovar.Text = "";
            textBox_kol.Text = "";
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Glav glav = new Glav(_user);
            this.Hide();
            glav.Show();
           
        }
    }
}
