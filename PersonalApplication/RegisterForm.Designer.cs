﻿namespace Personal_Organizer_Application
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblNewKayıt = new System.Windows.Forms.Label();
            this.lblnewPassword = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblSurname = new System.Windows.Forms.Label();
            this.LnlName = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblPhoto = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.MTxtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.BtnImagePath = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LblPath = new System.Windows.Forms.Label();
            this.PicPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(200, 628);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(177, 51);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Kaydol";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNewKayıt
            // 
            this.lblNewKayıt.AutoSize = true;
            this.lblNewKayıt.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewKayıt.Location = new System.Drawing.Point(39, 179);
            this.lblNewKayıt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewKayıt.Name = "lblNewKayıt";
            this.lblNewKayıt.Size = new System.Drawing.Size(154, 31);
            this.lblNewKayıt.TabIndex = 1;
            this.lblNewKayıt.Text = "Kullanıcı Adı:";
            // 
            // lblnewPassword
            // 
            this.lblnewPassword.AutoSize = true;
            this.lblnewPassword.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewPassword.Location = new System.Drawing.Point(119, 223);
            this.lblnewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnewPassword.Name = "lblnewPassword";
            this.lblnewPassword.Size = new System.Drawing.Size(74, 31);
            this.lblnewPassword.TabIndex = 2;
            this.lblnewPassword.Text = "Şifre:";
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(200, 176);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(217, 34);
            this.txtNewName.TabIndex = 1;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(200, 223);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(217, 34);
            this.txtNewPass.TabIndex = 2;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(392, 628);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(0, 29);
            this.lblState.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 39);
            this.label1.TabIndex = 20;
            this.label1.Text = "HESAP OLUŞTUR";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(200, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 112);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(200, 315);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(217, 34);
            this.TxtSurname.TabIndex = 4;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(200, 271);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(217, 34);
            this.TxtName.TabIndex = 3;
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSurname.Location = new System.Drawing.Point(107, 318);
            this.LblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(85, 31);
            this.LblSurname.TabIndex = 25;
            this.LblSurname.Text = "Soyad:";
            // 
            // LnlName
            // 
            this.LnlName.AutoSize = true;
            this.LnlName.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnlName.Location = new System.Drawing.Point(143, 271);
            this.LnlName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LnlName.Name = "LnlName";
            this.LnlName.Size = new System.Drawing.Size(50, 31);
            this.LnlName.TabIndex = 24;
            this.LnlName.Text = "Ad:";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(200, 408);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(217, 73);
            this.TxtAddress.TabIndex = 6;
            this.TxtAddress.UseSystemPasswordChar = true;
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress.Location = new System.Drawing.Point(107, 408);
            this.LblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(83, 31);
            this.LblAddress.TabIndex = 31;
            this.LblAddress.Text = "Adres:";
            // 
            // LblPhoneNumber
            // 
            this.LblPhoneNumber.AutoSize = true;
            this.LblPhoneNumber.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhoneNumber.Location = new System.Drawing.Point(100, 360);
            this.LblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            this.LblPhoneNumber.Size = new System.Drawing.Size(92, 31);
            this.LblPhoneNumber.TabIndex = 30;
            this.LblPhoneNumber.Text = "Tel No:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(200, 487);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(217, 34);
            this.TxtEmail.TabIndex = 7;
            // 
            // LblPhoto
            // 
            this.LblPhoto.AutoSize = true;
            this.LblPhoto.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhoto.Location = new System.Drawing.Point(123, 534);
            this.LblPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPhoto.Name = "LblPhoto";
            this.LblPhoto.Size = new System.Drawing.Size(69, 31);
            this.LblPhoto.TabIndex = 37;
            this.LblPhoto.Text = "Foto:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(104, 487);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(88, 31);
            this.LblEmail.TabIndex = 36;
            this.LblEmail.Text = "E-Mail:";
            // 
            // MTxtPhoneNumber
            // 
            this.MTxtPhoneNumber.Location = new System.Drawing.Point(200, 360);
            this.MTxtPhoneNumber.Mask = "(999) 000-0000";
            this.MTxtPhoneNumber.Name = "MTxtPhoneNumber";
            this.MTxtPhoneNumber.Size = new System.Drawing.Size(217, 34);
            this.MTxtPhoneNumber.TabIndex = 5;
            // 
            // BtnImagePath
            // 
            this.BtnImagePath.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnImagePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImagePath.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImagePath.Location = new System.Drawing.Point(200, 534);
            this.BtnImagePath.Name = "BtnImagePath";
            this.BtnImagePath.Size = new System.Drawing.Size(96, 42);
            this.BtnImagePath.TabIndex = 8;
            this.BtnImagePath.Text = "Seç";
            this.BtnImagePath.UseVisualStyleBackColor = false;
            this.BtnImagePath.Click += new System.EventHandler(this.BtnImagePath_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LblPath
            // 
            this.LblPath.AutoSize = true;
            this.LblPath.Location = new System.Drawing.Point(392, 527);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(0, 29);
            this.LblPath.TabIndex = 42;
            this.LblPath.Visible = false;
            // 
            // PicPhoto
            // 
            this.PicPhoto.Location = new System.Drawing.Point(332, 534);
            this.PicPhoto.Name = "PicPhoto";
            this.PicPhoto.Size = new System.Drawing.Size(85, 80);
            this.PicPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPhoto.TabIndex = 43;
            this.PicPhoto.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(472, 723);
            this.Controls.Add(this.PicPhoto);
            this.Controls.Add(this.LblPath);
            this.Controls.Add(this.BtnImagePath);
            this.Controls.Add(this.MTxtPhoneNumber);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblPhoto);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblPhoneNumber);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblSurname);
            this.Controls.Add(this.LnlName);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.lblnewPassword);
            this.Controls.Add(this.lblNewKayıt);
            this.Controls.Add(this.btnRegister);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.KayıtFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblNewKayıt;
        private System.Windows.Forms.Label lblnewPassword;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Label LnlName;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblPhoneNumber;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblPhoto;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.MaskedTextBox MTxtPhoneNumber;
        private System.Windows.Forms.Button BtnImagePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LblPath;
        private System.Windows.Forms.PictureBox PicPhoto;
    }
}