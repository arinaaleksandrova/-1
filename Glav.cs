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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Glav : Form
    {

        private readonly checkUser _user;
        DataBase dataBase = new DataBase();

        int selectedRow;
        public Glav(checkUser user)
        {
            _user = user;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void IsAdmin()
        {
            управлениеToolStripMenuItem.Enabled = _user.IsAdmin;
            button_save.Enabled = _user.IsAdmin;
            button_add.Enabled = _user.IsAdmin;
            button_refresh.Enabled = _user.IsAdmin;
            button_delete.Enabled = _user.IsAdmin;
            
        }

        private void CreateColumns()
        {
            bd.Columns.Add("id", "id");
            bd.Columns.Add("name_tovar", "Название товара");
            bd.Columns.Add("kol", "Количество товара");
            bd.Columns.Add("IsNew", String.Empty);
        }


        private void ReadSingLeRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Tovar";

            SqlCommand command = new SqlCommand(queryString, dataBase.qetConnetion());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingLeRow(dgw, reader);
            }
            reader.Close();
        }


        private void main_windows_Load(object sender, EventArgs e)
        {
            IsAdmin();
            bd.Columns[3].Visible = false;
            RefreshDataGrid(bd);
         
        }

        private void bd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = bd.Rows[selectedRow];

                textBox2.Text = row.Cells[0].Value.ToString();
                textBox3.Text = row.Cells[1].Value.ToString();
                textBox4.Text = row.Cells[2].Value.ToString();
            }
        }

        private void pictureBox_reset_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(bd);
           
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Dob add = new Dob();
            add.ShowDialog();
        }

        private void pictureBox_edit_Click(object sender, EventArgs e)
        {
           avtopiz form = new avtopiz();
            this.Hide();
            form.Show();
           
        }

        private void Update()
        {
            dataBase.openConnection();

            for (int index = 0; index < bd.Rows.Count; index++)
            {
                var rowState = (RowState)bd.Rows[index].Cells[3].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(bd.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Tovar where id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.qetConnetion());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified)
                {
                    var id = bd.Rows[index].Cells[0].Value.ToString();
                    var tovar = bd.Rows[index].Cells[1].Value.ToString();
                    var kol = bd.Rows[index].Cells[2].Value.ToString();
                    

                    var changeQuery = $"update Tovar set name_tovar = '{tovar}', kol = '{kol}' where id = '{id}'";


                    var command = new SqlCommand(changeQuery, dataBase.qetConnetion());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }
        private void Change()
        {
            var selectedRowIndex = bd.CurrentCell.RowIndex;

            var id = textBox2.Text;
            var tovar = textBox3.Text;
            var kol = textBox4.Text;
            if (bd.Rows[selectedRowIndex].Cells[0].Value.ToString() != String.Empty)
            {
                bd.Rows[selectedRowIndex].SetValues(id, tovar, kol);
                bd.Rows[selectedRowIndex].Cells[3].Value = RowState.Modified;
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
                bd.Rows[index].Cells[3].Value = RowState.Deleted;
                return;
            }
            bd.Rows[index].Cells[3].Value = RowState.Deleted;
        }

        private void Poisk(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Tovar where concat (id, name_tovar, kol) like '%" + textBox_poisk.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.qetConnetion());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingLeRow(dgw, read); ;
            }

            read.Close();
        }
        private void textBox_poisk_TextChanged(object sender, EventArgs e)
        {
            Poisk(bd);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void управлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patien patients = new Patien(_user);
            patients.ShowDialog();
           
        }

        private void Glav_Load(object sender, EventArgs e)
        {
            управлениеToolStripMenuItem1.Text = $"{_user.Login} : {_user.Status}";
            IsAdmin();
            CreateColumns();
            bd.Columns[3].Visible = false;
            RefreshDataGrid(bd);
        }

      
        private void управлениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
