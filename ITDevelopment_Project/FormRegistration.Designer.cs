namespace ITDevelopment_Project
{
    partial class FormRegistration
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
            this.labelCreate = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonReg = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.textBoxRepeatPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCreate
            // 
            this.labelCreate.AutoSize = true;
            this.labelCreate.Font = new System.Drawing.Font("Roboto Black", 14F, System.Drawing.FontStyle.Bold);
            this.labelCreate.Location = new System.Drawing.Point(10, 88);
            this.labelCreate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(297, 23);
            this.labelCreate.TabIndex = 67;
            this.labelCreate.Text = "Создайте свою учетную запись";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Roboto Light", 16F);
            this.textBoxPassword.Location = new System.Drawing.Point(12, 265);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(305, 30);
            this.textBoxPassword.TabIndex = 66;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Roboto Light", 16F);
            this.textBoxLogin.Location = new System.Drawing.Point(12, 205);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(305, 30);
            this.textBoxLogin.TabIndex = 65;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelPassword.Location = new System.Drawing.Point(10, 243);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(68, 19);
            this.labelPassword.TabIndex = 64;
            this.labelPassword.Text = "Пароль:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelLogin.Location = new System.Drawing.Point(10, 183);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(57, 19);
            this.labelLogin.TabIndex = 63;
            this.labelLogin.Text = "Логин:";
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReg.Font = new System.Drawing.Font("Roboto Black", 14F, System.Drawing.FontStyle.Bold);
            this.buttonReg.ForeColor = System.Drawing.Color.White;
            this.buttonReg.Location = new System.Drawing.Point(38, 378);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(255, 50);
            this.buttonReg.TabIndex = 62;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            this.buttonReg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonReg_KeyDown);
            this.buttonReg.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonReg_KeyUp);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ITDevelopment_Project.Properties.Resources._2_вариант;
            this.pictureBoxLogo.Location = new System.Drawing.Point(48, 22);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(219, 44);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 61;
            this.pictureBoxLogo.TabStop = false;
            // 
            // textBoxRepeatPassword
            // 
            this.textBoxRepeatPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRepeatPassword.Font = new System.Drawing.Font("Roboto Light", 16F);
            this.textBoxRepeatPassword.Location = new System.Drawing.Point(12, 325);
            this.textBoxRepeatPassword.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.textBoxRepeatPassword.Multiline = true;
            this.textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            this.textBoxRepeatPassword.Size = new System.Drawing.Size(305, 30);
            this.textBoxRepeatPassword.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.label1.Location = new System.Drawing.Point(10, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 68;
            this.label1.Text = "Повторите пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.label2.Location = new System.Drawing.Point(10, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 70;
            this.label2.Text = "Должность:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.Font = new System.Drawing.Font("Roboto Light", 16F);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Менеджер",
            "Системный администратор",
            "Бухгалтер",
            "Супервайзер",
            "Заказчик пиццы",
            "Студент на практике"});
            this.comboBoxType.Location = new System.Drawing.Point(12, 142);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(305, 33);
            this.comboBoxType.TabIndex = 71;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(329, 451);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRepeatPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCreate);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreate;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox textBoxRepeatPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxType;
    }
}