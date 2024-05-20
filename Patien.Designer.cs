namespace Medicine_312
{
    partial class Patien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patien));
            this.button_delete = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.bd = new System.Windows.Forms.DataGridView();
            this.textBox_otch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox_reset = new System.Windows.Forms.PictureBox();
            this.textBox_Poisk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox_edit = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_diag = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Khaki;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.ForeColor = System.Drawing.Color.Red;
            this.button_delete.Location = new System.Drawing.Point(208, 501);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(200, 37);
            this.button_delete.TabIndex = 54;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Khaki;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.ForeColor = System.Drawing.Color.Red;
            this.button_save.Location = new System.Drawing.Point(3, 501);
            this.button_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(200, 37);
            this.button_save.TabIndex = 56;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.Khaki;
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_refresh.ForeColor = System.Drawing.Color.Red;
            this.button_refresh.Location = new System.Drawing.Point(413, 501);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(200, 37);
            this.button_refresh.TabIndex = 55;
            this.button_refresh.Text = "Изменить";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // bd
            // 
            this.bd.AllowUserToAddRows = false;
            this.bd.AllowUserToDeleteRows = false;
            this.bd.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bd.Location = new System.Drawing.Point(48, 202);
            this.bd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bd.Name = "bd";
            this.bd.ReadOnly = true;
            this.bd.RowHeadersWidth = 51;
            this.bd.RowTemplate.Height = 24;
            this.bd.Size = new System.Drawing.Size(735, 246);
            this.bd.TabIndex = 58;
            this.bd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bd_CellContentClick);
            // 
            // textBox_otch
            // 
            this.textBox_otch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_otch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(81)))), ((int)(((byte)(140)))));
            this.textBox_otch.Location = new System.Drawing.Point(1057, 348);
            this.textBox_otch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_otch.Multiline = true;
            this.textBox_otch.Name = "textBox_otch";
            this.textBox_otch.Size = new System.Drawing.Size(175, 36);
            this.textBox_otch.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(913, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Отчество:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(81)))), ((int)(((byte)(140)))));
            this.textBox_name.Location = new System.Drawing.Point(1056, 306);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(175, 36);
            this.textBox_name.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(977, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Имя:";
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(81)))), ((int)(((byte)(140)))));
            this.textBox_id.Location = new System.Drawing.Point(1056, 228);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(175, 31);
            this.textBox_id.TabIndex = 46;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(81)))), ((int)(((byte)(140)))));
            this.textBox_surname.Location = new System.Drawing.Point(1056, 265);
            this.textBox_surname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_surname.Multiline = true;
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(175, 36);
            this.textBox_surname.TabIndex = 37;
            this.textBox_surname.TextChanged += new System.EventHandler(this.textBox_surname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(917, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Фамилия:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(1001, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 25);
            this.label7.TabIndex = 47;
            this.label7.Text = "Id:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(620, 498);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 37);
            this.button1.TabIndex = 61;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox_reset
            // 
            this.pictureBox_reset.BackColor = System.Drawing.Color.White;
            this.pictureBox_reset.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_reset.Image")));
            this.pictureBox_reset.Location = new System.Drawing.Point(1125, 496);
            this.pictureBox_reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_reset.Name = "pictureBox_reset";
            this.pictureBox_reset.Size = new System.Drawing.Size(53, 39);
            this.pictureBox_reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_reset.TabIndex = 52;
            this.pictureBox_reset.TabStop = false;
            this.pictureBox_reset.Click += new System.EventHandler(this.pictureBox_reset_Click);
            // 
            // textBox_Poisk
            // 
            this.textBox_Poisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Poisk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(81)))), ((int)(((byte)(140)))));
            this.textBox_Poisk.Location = new System.Drawing.Point(1055, 171);
            this.textBox_Poisk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Poisk.Multiline = true;
            this.textBox_Poisk.Name = "textBox_Poisk";
            this.textBox_Poisk.Size = new System.Drawing.Size(176, 36);
            this.textBox_Poisk.TabIndex = 58;
            this.textBox_Poisk.TextChanged += new System.EventHandler(this.textBox_Poisk_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(332, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(548, 46);
            this.label3.TabIndex = 65;
            this.label3.Text = "Нерчинско-Заводская ЦРБ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Medicine_312.Properties.Resources.hocpital;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 165);
            this.panel1.TabIndex = 67;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(957, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 68;
            this.label4.Text = "Поиск:";
            // 
            // pictureBox_edit
            // 
            this.pictureBox_edit.BackColor = System.Drawing.Color.White;
            this.pictureBox_edit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_edit.Image")));
            this.pictureBox_edit.Location = new System.Drawing.Point(1184, 496);
            this.pictureBox_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_edit.Name = "pictureBox_edit";
            this.pictureBox_edit.Size = new System.Drawing.Size(48, 39);
            this.pictureBox_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_edit.TabIndex = 69;
            this.pictureBox_edit.TabStop = false;
            this.pictureBox_edit.Click += new System.EventHandler(this.pictureBox_edit_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(929, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 56;
            this.label8.Text = "Диагноз:";
            // 
            // textBox_diag
            // 
            this.textBox_diag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_diag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(81)))), ((int)(((byte)(140)))));
            this.textBox_diag.Location = new System.Drawing.Point(1056, 390);
            this.textBox_diag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_diag.Multiline = true;
            this.textBox_diag.Name = "textBox_diag";
            this.textBox_diag.Size = new System.Drawing.Size(175, 36);
            this.textBox_diag.TabIndex = 52;
            // 
            // Patien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1255, 528);
            this.Controls.Add(this.pictureBox_edit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_Poisk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_diag);
            this.Controls.Add(this.textBox_otch);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.pictureBox_reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.bd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1273, 575);
            this.MinimumSize = new System.Drawing.Size(1273, 575);
            this.Name = "Patien";
            this.Text = "Нерчинско-Заводская ЦРБ";
            this.Load += new System.EventHandler(this.Patients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.PictureBox pictureBox_reset;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.DataGridView bd;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_otch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Poisk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox_edit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_diag;
    }
}