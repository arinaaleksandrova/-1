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

    public partial class Patien : Form
    {
        private readonly checkUser _user;
        DataBase dataBase = new DataBase();

        int selectedRow;
        public Patien(checkUser user)
        {
            _user = user;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void IsAdmin()
        {
            
            button_save.Enabled = _user.IsAdmin;
            button1.Enabled = _user.IsAdmin;
            button_refresh.Enabled = _user.IsAdmin;
            button_delete.Enabled = _user.IsAdmin;

        }
        private void CreateColumns()
        {
            bd.Columns.Add("id", "id");
            bd.Columns.Add("surname", "Фамилия");
            bd.Columns.Add("name", "Имя");
            bd.Columns.Add("otch", "Отчество");
            bd.Columns.Add("diag", "Диагноз");
            bd.Columns.Add("IsNew", String.Empty);
        }
    
        private void ReadSingLeRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Patient";

            SqlCommand command = new SqlCommand(queryString, dataBase.qetConnetion());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingLeRow(dgw, reader);
            }
            reader.Close();
        }



        private void Patients_Load(object sender, EventArgs e)
        {
            CreateColumns();
            bd.Columns[5].Visible = false;
            RefreshDataGrid(bd);
        }

        private void bd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = bd.Rows[selectedRow];

                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_surname.Text = row.Cells[1].Value.ToString();
                textBox_name.Text = row.Cells[2].Value.ToString();
                textBox_otch.Text = row.Cells[3].Value.ToString();
                textBox_diag.Text = row.Cells[4].Value.ToString();
            }
        }

        private void pictureBox_reset_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(bd);
        }

        private void pictureBox_edit_Click(object sender, EventArgs e)
        {
           Glav patients = new Glav (_user);
            patients.ShowDialog();
            this.Close();
        }

        private void Update()
        {
            dataBase.openConnection();

            for (int index = 0; index < bd.Rows.Count; index++)
            {
                var rowStat = (RowState)bd.Rows[index].Cells[5].Value;

                if (rowStat == RowState.Existed)
                    continue;

                if (rowStat == RowState.Deleted)
                {
                    var id = Convert.ToInt32(bd.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Patient where id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.qetConnetion());
                    command.ExecuteNonQuery();
                }
                if (rowStat == RowState.Modified)
                {
                    var id = bd.Rows[index].Cells[0].Value.ToString();
                    var surname = bd.Rows[index].Cells[1].Value.ToString();
                    var name = bd.Rows[index].Cells[2].Value.ToString();
                    var otechestvo = bd.Rows[index].Cells[3].Value.ToString();
                    var Diagnosis = bd.Rows[index].Cells[4].Value.ToString();



                    var changeQuery = $"update Patient set surname = '{surname}', name = '{name}', otch = '{otechestvo}', diag = '{Diagnosis}', where id = '{id}'";


                    var command = new SqlCommand(changeQuery, dataBase.qetConnetion());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }

        private void Poisk(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Patient where concat (ID, surname, name, otch, diag) like '%" + textBox_Poisk.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.qetConnetion());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingLeRow(dgw, read); ;
            }

            read.Close();
        }
        private void Change()
        {
            var selectedRowIndex = bd.CurrentCell.RowIndex;

            var id = textBox_id.Text;
            var surname = textBox_surname.Text;
            var name = textBox_name.Text;
            var otechestvo = textBox_otch.Text;
            var Diagnosis = textBox_diag.Text;

            if (bd.Rows[selectedRowIndex].Cells[0].Value.ToString() != String.Empty)
            {
                bd.Rows[selectedRowIndex].SetValues(id, surname, name, otechestvo, Diagnosis);
                bd.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
            }

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void deleteRow()
        {
            int index = bd.CurrentCell.RowIndex;

            bd.Rows[index].Visible = false;

            if (bd.Rows[index].Cells[0].Value.ToString() == String.Empty)
            {
                bd.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            bd.Rows[index].Cells[5].Value = RowState.Deleted;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dob2 add = new Dob2();
            add.ShowDialog();
        }

        private void textBox_Poisk_TextChanged(object sender, EventArgs e)
        {
            Poisk(bd);
        }

        private void pictureBox_edit_Click_1(object sender, EventArgs e)
        {

            Glav form = new Glav(_user);
            this.Hide();
            form.Show();
        }

        private void textBox_surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

