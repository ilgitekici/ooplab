namespace Personal_Organizer_Application
{
    partial class Management
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RegisterNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUserType = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsertypes = new System.Windows.Forms.TextBox();
            this.LblRegisterno = new System.Windows.Forms.Label();
            this.TxtRegisterNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnLists = new System.Windows.Forms.Button();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegisterNo});
            this.dataGridView1.Location = new System.Drawing.Point(67, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 409);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // RegisterNo
            // 
            this.RegisterNo.HeaderText = "RegisterNo";
            this.RegisterNo.MinimumWidth = 6;
            this.RegisterNo.Name = "RegisterNo";
            this.RegisterNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(4, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 47);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.Location = new System.Drawing.Point(1115, 113);
            this.LblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(125, 25);
            this.LblUserName.TabIndex = 9;
            this.LblUserName.Text = "Kullanıcı Adı:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(1181, 150);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(59, 25);
            this.LblPassword.TabIndex = 10;
            this.LblPassword.Text = "Şifre:";
            // 
            // LblUserType
            // 
            this.LblUserType.AutoSize = true;
            this.LblUserType.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserType.Location = new System.Drawing.Point(1113, 184);
            this.LblUserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUserType.Name = "LblUserType";
            this.LblUserType.Size = new System.Drawing.Size(127, 25);
            this.LblUserType.TabIndex = 11;
            this.LblUserType.Text = "Kullanıcı Tipi:";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUsername.Location = new System.Drawing.Point(1248, 117);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(132, 29);
            this.TxtUsername.TabIndex = 12;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword.Location = new System.Drawing.Point(1248, 150);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(132, 29);
            this.TxtPassword.TabIndex = 13;
            // 
            // TxtUsertypes
            // 
            this.TxtUsertypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUsertypes.Location = new System.Drawing.Point(1248, 183);
            this.TxtUsertypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtUsertypes.Name = "TxtUsertypes";
            this.TxtUsertypes.Size = new System.Drawing.Size(132, 29);
            this.TxtUsertypes.TabIndex = 14;
            // 
            // LblRegisterno
            // 
            this.LblRegisterno.AutoSize = true;
            this.LblRegisterno.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegisterno.Location = new System.Drawing.Point(1148, 80);
            this.LblRegisterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRegisterno.Name = "LblRegisterno";
            this.LblRegisterno.Size = new System.Drawing.Size(92, 25);
            this.LblRegisterno.TabIndex = 15;
            this.LblRegisterno.Text = "Kayıt No:";
            // 
            // TxtRegisterNo
            // 
            this.TxtRegisterNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtRegisterNo.Location = new System.Drawing.Point(1248, 80);
            this.TxtRegisterNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtRegisterNo.Name = "TxtRegisterNo";
            this.TxtRegisterNo.Size = new System.Drawing.Size(132, 29);
            this.TxtRegisterNo.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1391, 335);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "Güncelle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1271, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 60;
            this.label6.Text = "Sil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1173, 335);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Liste";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.LightGray;
            this.BtnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.BackgroundImage")));
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUpdate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnUpdate.Location = new System.Drawing.Point(1363, 247);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(96, 82);
            this.BtnUpdate.TabIndex = 57;
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.LightGray;
            this.BtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.BackgroundImage")));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDelete.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnDelete.Location = new System.Drawing.Point(1247, 247);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(103, 82);
            this.BtnDelete.TabIndex = 56;
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnLists
            // 
            this.BtnLists.BackColor = System.Drawing.Color.LightGray;
            this.BtnLists.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLists.BackgroundImage")));
            this.BtnLists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLists.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLists.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnLists.Location = new System.Drawing.Point(1141, 247);
            this.BtnLists.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BtnLists.Name = "BtnLists";
            this.BtnLists.Size = new System.Drawing.Size(92, 82);
            this.BtnLists.TabIndex = 54;
            this.BtnLists.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnLists.UseVisualStyleBackColor = false;
            this.BtnLists.Click += new System.EventHandler(this.BtnLists_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Personal_Organizer_Application.User);
            // 
            // loginFormBindingSource
            // 
            this.loginFormBindingSource.DataSource = typeof(Personal_Organizer_Application.LoginForm);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1477, 473);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnLists);
            this.Controls.Add(this.TxtRegisterNo);
            this.Controls.Add(this.LblRegisterno);
            this.Controls.Add(this.TxtUsertypes);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.LblUserType);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource loginFormBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblUserType;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsertypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterNo;
        private System.Windows.Forms.Label LblRegisterno;
        private System.Windows.Forms.TextBox TxtRegisterNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnLists;
    }
}