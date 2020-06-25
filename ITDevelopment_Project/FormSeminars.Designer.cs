namespace ITDevelopment_Project
{
    partial class FormSeminars
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
            this.labelDate = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.listViewSeminar = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameSeminar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxAddress_House = new System.Windows.Forms.TextBox();
            this.labelAddress_House = new System.Windows.Forms.Label();
            this.textBoxAddress_Street = new System.Windows.Forms.TextBox();
            this.labelAddress_Street = new System.Windows.Forms.Label();
            this.textBoxAddress_City = new System.Windows.Forms.TextBox();
            this.labelAddress_City = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxTypeSeminar = new System.Windows.Forms.ComboBox();
            this.dateTimePickerSeminar = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelDate.Location = new System.Drawing.Point(12, 272);
            this.labelDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(142, 19);
            this.labelDate.TabIndex = 53;
            this.labelDate.Text = "Дата проведения:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ITDevelopment_Project.Properties.Resources._2_вариант;
            this.pictureBoxLogo.Location = new System.Drawing.Point(670, 309);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(170, 40);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 52;
            this.pictureBoxLogo.TabStop = false;
            // 
            // listViewSeminar
            // 
            this.listViewSeminar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listViewSeminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewSeminar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NameSeminar,
            this.Address,
            this.Date});
            this.listViewSeminar.Font = new System.Drawing.Font("Roboto Light", 10F);
            this.listViewSeminar.FullRowSelect = true;
            this.listViewSeminar.GridLines = true;
            this.listViewSeminar.HideSelection = false;
            this.listViewSeminar.Location = new System.Drawing.Point(231, 45);
            this.listViewSeminar.Margin = new System.Windows.Forms.Padding(14, 3, 3, 3);
            this.listViewSeminar.Name = "listViewSeminar";
            this.listViewSeminar.Size = new System.Drawing.Size(609, 196);
            this.listViewSeminar.TabIndex = 51;
            this.listViewSeminar.UseCompatibleStateImageBehavior = false;
            this.listViewSeminar.View = System.Windows.Forms.View.Details;
            this.listViewSeminar.SelectedIndexChanged += new System.EventHandler(this.listViewSeminar_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // NameSeminar
            // 
            this.NameSeminar.Text = "Семинар";
            this.NameSeminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameSeminar.Width = 434;
            // 
            // Address
            // 
            this.Address.Text = "Адрес проведения";
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Address.Width = 192;
            // 
            // Date
            // 
            this.Date.Text = "Дата проведения";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Width = 117;
            // 
            // textBoxAddress_House
            // 
            this.textBoxAddress_House.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress_House.Font = new System.Drawing.Font("Roboto Light", 16F);
            this.textBoxAddress_House.Location = new System.Drawing.Point(12, 234);
            this.textBoxAddress_House.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.textBoxAddress_House.Multiline = true;
            this.textBoxAddress_House.Name = "textBoxAddress_House";
            this.textBoxAddress_House.Size = new System.Drawing.Size(202, 30);
            this.textBoxAddress_House.TabIndex = 46;
            // 
            // labelAddress_House
            // 
            this.labelAddress_House.AutoSize = true;
            this.labelAddress_House.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelAddress_House.Location = new System.Drawing.Point(12, 210);
            this.labelAddress_House.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.labelAddress_House.Name = "labelAddress_House";
            this.labelAddress_House.Size = new System.Drawing.Size(45, 19);
            this.labelAddress_House.TabIndex = 45;
            this.labelAddress_House.Text = "Дом:";
            // 
            // textBoxAddress_Street
            // 
            this.textBoxAddress_Street.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress_Street.Font = new System.Drawing.Font("Roboto Light", 16F);
            this.textBoxAddress_Street.Location = new System.Drawing.Point(12, 172);
            this.textBoxAddress_Street.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.textBoxAddress_Street.Multiline = true;
            this.textBoxAddress_Street.Name = "textBoxAddress_Street";
            this.textBoxAddress_Street.Size = new System.Drawing.Size(202, 30);
            this.textBoxAddress_Street.TabIndex = 44;
            // 
            // labelAddress_Street
            // 
            this.labelAddress_Street.AutoSize = true;
            this.labelAddress_Street.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelAddress_Street.Location = new System.Drawing.Point(12, 148);
            this.labelAddress_Street.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.labelAddress_Street.Name = "labelAddress_Street";
            this.labelAddress_Street.Size = new System.Drawing.Size(54, 19);
            this.labelAddress_Street.TabIndex = 43;
            this.labelAddress_Street.Text = "Улица";
            // 
            // textBoxAddress_City
            // 
            this.textBoxAddress_City.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress_City.Font = new System.Drawing.Font("Roboto Light", 16F);
            this.textBoxAddress_City.Location = new System.Drawing.Point(12, 110);
            this.textBoxAddress_City.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.textBoxAddress_City.Multiline = true;
            this.textBoxAddress_City.Name = "textBoxAddress_City";
            this.textBoxAddress_City.Size = new System.Drawing.Size(202, 30);
            this.textBoxAddress_City.TabIndex = 42;
            // 
            // labelAddress_City
            // 
            this.labelAddress_City.AutoSize = true;
            this.labelAddress_City.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelAddress_City.Location = new System.Drawing.Point(12, 86);
            this.labelAddress_City.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.labelAddress_City.Name = "labelAddress_City";
            this.labelAddress_City.Size = new System.Drawing.Size(55, 19);
            this.labelAddress_City.TabIndex = 41;
            this.labelAddress_City.Text = "Город:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelFirstName.Location = new System.Drawing.Point(12, 21);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(78, 19);
            this.labelFirstName.TabIndex = 39;
            this.labelFirstName.Text = "Семинар:";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold);
            this.buttonDel.ForeColor = System.Drawing.Color.White;
            this.buttonDel.Location = new System.Drawing.Point(583, 251);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(170, 40);
            this.buttonDel.TabIndex = 38;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(407, 251);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(170, 40);
            this.buttonEdit.TabIndex = 37;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(231, 251);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 40);
            this.buttonAdd.TabIndex = 36;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxTypeSeminar
            // 
            this.comboBoxTypeSeminar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.comboBoxTypeSeminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTypeSeminar.Font = new System.Drawing.Font("Roboto Light", 16F);
            this.comboBoxTypeSeminar.FormattingEnabled = true;
            this.comboBoxTypeSeminar.Items.AddRange(new object[] {
            "Внедрение коммуникационной платформы для управления бизнес-процессами",
            "Приложения для мобильной работы",
            "Внедрение системы автоматизации управления бизнес-процессами"});
            this.comboBoxTypeSeminar.Location = new System.Drawing.Point(12, 45);
            this.comboBoxTypeSeminar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.comboBoxTypeSeminar.Name = "comboBoxTypeSeminar";
            this.comboBoxTypeSeminar.Size = new System.Drawing.Size(202, 33);
            this.comboBoxTypeSeminar.TabIndex = 55;
            // 
            // dateTimePickerSeminar
            // 
            this.dateTimePickerSeminar.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.dateTimePickerSeminar.Location = new System.Drawing.Point(12, 296);
            this.dateTimePickerSeminar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.dateTimePickerSeminar.Name = "dateTimePickerSeminar";
            this.dateTimePickerSeminar.Size = new System.Drawing.Size(202, 30);
            this.dateTimePickerSeminar.TabIndex = 56;
            // 
            // FormSeminars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(852, 361);
            this.Controls.Add(this.dateTimePickerSeminar);
            this.Controls.Add(this.comboBoxTypeSeminar);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.listViewSeminar);
            this.Controls.Add(this.textBoxAddress_House);
            this.Controls.Add(this.labelAddress_House);
            this.Controls.Add(this.textBoxAddress_Street);
            this.Controls.Add(this.labelAddress_Street);
            this.Controls.Add(this.textBoxAddress_City);
            this.Controls.Add(this.labelAddress_City);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormSeminars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Семинары";
            this.Load += new System.EventHandler(this.FormSeminars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ListView listViewSeminar;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NameSeminar;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.TextBox textBoxAddress_House;
        private System.Windows.Forms.Label labelAddress_House;
        private System.Windows.Forms.TextBox textBoxAddress_Street;
        private System.Windows.Forms.Label labelAddress_Street;
        private System.Windows.Forms.TextBox textBoxAddress_City;
        private System.Windows.Forms.Label labelAddress_City;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxTypeSeminar;
        private System.Windows.Forms.DateTimePicker dateTimePickerSeminar;
    }
}