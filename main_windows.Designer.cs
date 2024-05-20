namespace Medicine_312
{
    partial class main_windows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_windows));
            this.bd = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox_poisk = new System.Windows.Forms.TextBox();
            this.pictureBox_poisk = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.pictureBox_reset = new System.Windows.Forms.PictureBox();
            this.pictureBox_clear = new System.Windows.Forms.PictureBox();
            this.pictureBox_edit = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_ypravlenie = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bd)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_poisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_edit)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bd
            // 
            this.bd.AllowUserToAddRows = false;
            this.bd.AllowUserToDeleteRows = false;
            this.bd.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bd.Location = new System.Drawing.Point(9, 121);
            this.bd.Margin = new System.Windows.Forms.Padding(2);
            this.bd.Name = "bd";
            this.bd.ReadOnly = true;
            this.bd.RowHeadersWidth = 51;
            this.bd.RowTemplate.Height = 24;
            this.bd.Size = new System.Drawing.Size(890, 275);
            this.bd.TabIndex = 45;
            this.bd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bd_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.textBox_poisk);
            this.panel1.Controls.Add(this.pictureBox_poisk);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(11, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 67);
            this.panel1.TabIndex = 35;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.Image = global::Medicine_312.Properties.Resources.plus;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 48;
            this.pictureBox4.TabStop = false;
            // 
            // textBox_poisk
            // 
            this.textBox_poisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_poisk.Location = new System.Drawing.Point(743, 13);
            this.textBox_poisk.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_poisk.Multiline = true;
            this.textBox_poisk.Name = "textBox_poisk";
            this.textBox_poisk.Size = new System.Drawing.Size(132, 30);
            this.textBox_poisk.TabIndex = 24;
            this.textBox_poisk.TextChanged += new System.EventHandler(this.textBox_poisk_TextChanged);
            // 
            // pictureBox_poisk
            // 
            this.pictureBox_poisk.Image = global::Medicine_312.Properties.Resources.lupa;
            this.pictureBox_poisk.Location = new System.Drawing.Point(698, 2);
            this.pictureBox_poisk.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_poisk.Name = "pictureBox_poisk";
            this.pictureBox_poisk.Size = new System.Drawing.Size(41, 50);
            this.pictureBox_poisk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_poisk.TabIndex = 12;
            this.pictureBox_poisk.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(149, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(469, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "ФКУ “ГБ МСЭ по Забайкальскому краю”";
            // 
            // button_refresh
            // 
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_refresh.Location = new System.Drawing.Point(397, 400);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(143, 30);
            this.button_refresh.TabIndex = 21;
            this.button_refresh.Text = "Изменить";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.Location = new System.Drawing.Point(98, 400);
            this.button_delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(143, 30);
            this.button_delete.TabIndex = 20;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(250, 400);
            this.button_save.Margin = new System.Windows.Forms.Padding(2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(143, 30);
            this.button_save.TabIndex = 22;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(544, 400);
            this.button_add.Margin = new System.Windows.Forms.Padding(2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(143, 30);
            this.button_add.TabIndex = 18;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // pictureBox_reset
            // 
            this.pictureBox_reset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_reset.Image = global::Medicine_312.Properties.Resources.app;
            this.pictureBox_reset.Location = new System.Drawing.Point(859, 398);
            this.pictureBox_reset.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_reset.Name = "pictureBox_reset";
            this.pictureBox_reset.Size = new System.Drawing.Size(40, 32);
            this.pictureBox_reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_reset.TabIndex = 11;
            this.pictureBox_reset.TabStop = false;
            this.pictureBox_reset.Click += new System.EventHandler(this.pictureBox_reset_Click);
            // 
            // pictureBox_clear
            // 
            this.pictureBox_clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_clear.Image = global::Medicine_312.Properties.Resources.Clear;
            this.pictureBox_clear.Location = new System.Drawing.Point(50, 398);
            this.pictureBox_clear.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_clear.Name = "pictureBox_clear";
            this.pictureBox_clear.Size = new System.Drawing.Size(44, 32);
            this.pictureBox_clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_clear.TabIndex = 10;
            this.pictureBox_clear.TabStop = false;
            // 
            // pictureBox_edit
            // 
            this.pictureBox_edit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_edit.Image = global::Medicine_312.Properties.Resources.exit;
            this.pictureBox_edit.Location = new System.Drawing.Point(10, 398);
            this.pictureBox_edit.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_edit.Name = "pictureBox_edit";
            this.pictureBox_edit.Size = new System.Drawing.Size(36, 32);
            this.pictureBox_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_edit.TabIndex = 49;
            this.pictureBox_edit.TabStop = false;
            this.pictureBox_edit.Click += new System.EventHandler(this.pictureBox_edit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // управлениеToolStripMenuItem
            // 
            this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.управлениеToolStripMenuItem.Text = "Управление";
            this.управлениеToolStripMenuItem.Click += new System.EventHandler(this.управлениеToolStripMenuItem_Click);
            // 
            // textBox_ypravlenie
            // 
            this.textBox_ypravlenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ypravlenie.Location = new System.Drawing.Point(710, 3);
            this.textBox_ypravlenie.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ypravlenie.Multiline = true;
            this.textBox_ypravlenie.Name = "textBox_ypravlenie";
            this.textBox_ypravlenie.Size = new System.Drawing.Size(178, 21);
            this.textBox_ypravlenie.TabIndex = 52;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(102, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 31);
            this.panel3.TabIndex = 61;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(46, 1);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 30);
            this.textBox2.TabIndex = 46;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(276, 1);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 30);
            this.textBox3.TabIndex = 37;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(546, 0);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(131, 30);
            this.textBox4.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(218, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Товар";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(436, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Количество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(8, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Id";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(691, 400);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 30);
            this.button1.TabIndex = 62;
            this.button1.Text = "Пациеты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // main_windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Medicine_312.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox_ypravlenie);
            this.Controls.Add(this.pictureBox_edit);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.pictureBox_reset);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.pictureBox_clear);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.bd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main_windows";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.main_windows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_poisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_edit)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView bd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_poisk;
        private System.Windows.Forms.PictureBox pictureBox_poisk;
        private System.Windows.Forms.PictureBox pictureBox_reset;
        private System.Windows.Forms.PictureBox pictureBox_clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox_edit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_ypravlenie;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}