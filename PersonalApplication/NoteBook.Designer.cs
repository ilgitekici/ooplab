namespace Personal_Organizer_Application
{
    partial class NoteBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteBook));
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.lblList = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtNote.Location = new System.Drawing.Point(203, 15);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(521, 261);
            this.txtNote.TabIndex = 0;
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblNotes.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(83, 17);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(112, 31);
            this.lblNotes.TabIndex = 1;
            this.lblNotes.Text = "NOTLAR:";
            // 
            // dgv_list
            // 
            this.dgv_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgv_list.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_list.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_list.Location = new System.Drawing.Point(0, 328);
            this.dgv_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.RowHeadersWidth = 51;
            this.dgv_list.Size = new System.Drawing.Size(1192, 289);
            this.dgv_list.TabIndex = 2;
            this.dgv_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_CellContentClick);
            this.dgv_list.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_CellContentClick);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(529, 295);
            this.lblList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(116, 31);
            this.lblList.TabIndex = 3;
            this.lblList.Text = "LISTELER:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1096, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "Güncelle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1001, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Sil";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(883, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Ekle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(778, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Liste";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Thistle;
            this.BtnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.BackgroundImage")));
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUpdate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnUpdate.Location = new System.Drawing.Point(1077, 94);
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
            this.BtnDelete.BackColor = System.Drawing.Color.Thistle;
            this.BtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.BackgroundImage")));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDelete.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnDelete.Location = new System.Drawing.Point(961, 94);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(103, 82);
            this.BtnDelete.TabIndex = 56;
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Thistle;
            this.BtnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdd.BackgroundImage")));
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdd.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnAdd.Location = new System.Drawing.Point(853, 94);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(95, 82);
            this.BtnAdd.TabIndex = 55;
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnList
            // 
            this.BtnList.BackColor = System.Drawing.Color.Thistle;
            this.BtnList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnList.BackgroundImage")));
            this.BtnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnList.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnList.Location = new System.Drawing.Point(748, 94);
            this.BtnList.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(92, 82);
            this.BtnList.TabIndex = 54;
            this.BtnList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnList.UseVisualStyleBackColor = false;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(16, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 47);
            this.btnBack.TabIndex = 62;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // NoteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1192, 617);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.dgv_list);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNote);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NoteBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteBook";
            this.Load += new System.EventHandler(this.NoteBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button btnBack;
    }
}