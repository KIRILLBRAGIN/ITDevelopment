namespace ITDevelopment_Project
{
    partial class FormDepartament
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.listViewDepartament = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountPersonal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Manager = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxManager = new System.Windows.Forms.TextBox();
            this.labelManager = new System.Windows.Forms.Label();
            this.textBoxNameCompany = new System.Windows.Forms.TextBox();
            this.labelNameCompany = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ITDevelopment_Project.Properties.Resources._2_вариант;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 158);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(170, 40);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 42;
            this.pictureBoxLogo.TabStop = false;
            // 
            // listViewDepartament
            // 
            this.listViewDepartament.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listViewDepartament.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewDepartament.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NameCompany,
            this.CountPersonal,
            this.Manager});
            this.listViewDepartament.Font = new System.Drawing.Font("Roboto Light", 10F);
            this.listViewDepartament.FullRowSelect = true;
            this.listViewDepartament.GridLines = true;
            this.listViewDepartament.HideSelection = false;
            this.listViewDepartament.Location = new System.Drawing.Point(231, 43);
            this.listViewDepartament.Margin = new System.Windows.Forms.Padding(14, 3, 3, 3);
            this.listViewDepartament.Name = "listViewDepartament";
            this.listViewDepartament.Size = new System.Drawing.Size(537, 109);
            this.listViewDepartament.TabIndex = 41;
            this.listViewDepartament.UseCompatibleStateImageBehavior = false;
            this.listViewDepartament.View = System.Windows.Forms.View.Details;
            this.listViewDepartament.SelectedIndexChanged += new System.EventHandler(this.listViewDepartament_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // NameCompany
            // 
            this.NameCompany.Text = "Название отдела";
            this.NameCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameCompany.Width = 161;
            // 
            // CountPersonal
            // 
            this.CountPersonal.Text = "Количество сотрудников";
            this.CountPersonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CountPersonal.Width = 170;
            // 
            // Manager
            // 
            this.Manager.Text = "Руководитель";
            this.Manager.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Manager.Width = 141;
            // 
            // textBoxManager
            // 
            this.textBoxManager.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxManager.Font = new System.Drawing.Font("Roboto Light", 16F);
            this.textBoxManager.Location = new System.Drawing.Point(12, 105);
            this.textBoxManager.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.textBoxManager.Multiline = true;
            this.textBoxManager.Name = "textBoxManager";
            this.textBoxManager.Size = new System.Drawing.Size(202, 30);
            this.textBoxManager.TabIndex = 40;
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelManager.Location = new System.Drawing.Point(12, 81);
            this.labelManager.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(115, 19);
            this.labelManager.TabIndex = 39;
            this.labelManager.Text = "Руководитель:";
            // 
            // textBoxNameCompany
            // 
            this.textBoxNameCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNameCompany.Font = new System.Drawing.Font("Roboto Light", 16F);
            this.textBoxNameCompany.Location = new System.Drawing.Point(12, 43);
            this.textBoxNameCompany.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.textBoxNameCompany.Multiline = true;
            this.textBoxNameCompany.Name = "textBoxNameCompany";
            this.textBoxNameCompany.Size = new System.Drawing.Size(202, 30);
            this.textBoxNameCompany.TabIndex = 38;
            // 
            // labelNameCompany
            // 
            this.labelNameCompany.AutoSize = true;
            this.labelNameCompany.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelNameCompany.Location = new System.Drawing.Point(12, 19);
            this.labelNameCompany.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.labelNameCompany.Name = "labelNameCompany";
            this.labelNameCompany.Size = new System.Drawing.Size(139, 19);
            this.labelNameCompany.TabIndex = 37;
            this.labelNameCompany.Text = "Название отдела:";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold);
            this.buttonDel.ForeColor = System.Drawing.Color.White;
            this.buttonDel.Location = new System.Drawing.Point(583, 158);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(170, 40);
            this.buttonDel.TabIndex = 36;
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
            this.buttonEdit.Location = new System.Drawing.Point(407, 158);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(170, 40);
            this.buttonEdit.TabIndex = 35;
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
            this.buttonAdd.Location = new System.Drawing.Point(231, 158);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 40);
            this.buttonAdd.TabIndex = 34;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormDepartament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(779, 221);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.listViewDepartament);
            this.Controls.Add(this.textBoxManager);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.textBoxNameCompany);
            this.Controls.Add(this.labelNameCompany);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormDepartament";
            this.Text = "Отделы";
            this.Load += new System.EventHandler(this.FormDepartament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ListView listViewDepartament;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NameCompany;
        private System.Windows.Forms.ColumnHeader CountPersonal;
        private System.Windows.Forms.ColumnHeader Manager;
        private System.Windows.Forms.TextBox textBoxManager;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.TextBox textBoxNameCompany;
        private System.Windows.Forms.Label labelNameCompany;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
    }
}