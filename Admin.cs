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
    public partial class Admin : Form
    {
        DataBase dataBase = new DataBase();
        public Admin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("login", "Логин");
            dataGridView1.Columns.Add("password", "Пароль");
            var checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText = "Admin";
            dataGridView1.Columns.Add(checkColumn);
        }

        private void ReadSingleRow(IDataRecord record)
        {
            dataGridView1.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetBoolean(6));
        }

        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();

            string queryString = $"select * from login";

            SqlCommand command = new SqlCommand(queryString, dataBase.qetConnetion());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(reader);
            }
            reader.Close();

            dataBase.closeConnection();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                var isadmin = dataGridView1.Rows[index].Cells[3].Value.ToString();

                var changeQuery = $"update login set Admin = '{isadmin}' where id = '{id}'";

                var command = new SqlCommand(changeQuery, dataBase.qetConnetion());
                command.ExecuteNonQuery();
            }
            dataBase.closeConnection();

            RefreshDataGrid();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);
            var deleteQuery = $"delete from login where id = {id}";

            var command = new SqlCommand(deleteQuery, dataBase.qetConnetion());
            command.ExecuteNonQuery();

            dataBase.closeConnection();

            RefreshDataGrid();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
