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
    public partial class Dob2 : Form
    {
        private readonly checkUser _user;
        DataBase dataBase = new DataBase();
        public Dob2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var Surname = textBox_fam.Text;
            var Name = textBox_name.Text;
            var Otch = textBox_fm.Text;
            var Diagn = textBox_dia.Text;
            var addQuery = $"insert into Patient (surname, name, otch, diag) values ('{Surname}', '{Name}', '{Otch}', '{Diagn}')";
            var command = new SqlCommand(addQuery, dataBase.qetConnetion());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись успешно создана!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataBase.closeConnection();
        }

        private void pictureBox_steret_Click(object sender, EventArgs e)
        {
            textBox_fam.Text = "";
            textBox_name.Text = "";
            textBox_fm.Text = "";
            textBox_dia.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Patien patients = new Patien(_user);
            this.Hide();
            patients.ShowDialog();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_fam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
