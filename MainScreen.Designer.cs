namespace ExamSERAFIN_July2019
{
    partial class MainScreen
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
            this.BTNinsert = new System.Windows.Forms.Button();
            this.BTNmodify = new System.Windows.Forms.Button();
            this.BTNcloseApp = new System.Windows.Forms.Button();
            this.DataGridEXAM = new System.Windows.Forms.DataGridView();
            this.TeamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoachName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressLine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressLine2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BTNdelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEXAM)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNinsert
            // 
            this.BTNinsert.Location = new System.Drawing.Point(39, 420);
            this.BTNinsert.Name = "BTNinsert";
            this.BTNinsert.Size = new System.Drawing.Size(203, 23);
            this.BTNinsert.TabIndex = 1;
            this.BTNinsert.Text = "Insert NEW Team";
            this.BTNinsert.UseVisualStyleBackColor = true;
            this.BTNinsert.Click += new System.EventHandler(this.BTNinsert_Click);
            // 
            // BTNmodify
            // 
            this.BTNmodify.Location = new System.Drawing.Point(287, 420);
            this.BTNmodify.Name = "BTNmodify";
            this.BTNmodify.Size = new System.Drawing.Size(203, 23);
            this.BTNmodify.TabIndex = 3;
            this.BTNmodify.Text = "Modify Data From Teams";
            this.BTNmodify.UseVisualStyleBackColor = true;
            // 
            // BTNcloseApp
            // 
            this.BTNcloseApp.Location = new System.Drawing.Point(769, 420);
            this.BTNcloseApp.Name = "BTNcloseApp";
            this.BTNcloseApp.Size = new System.Drawing.Size(203, 23);
            this.BTNcloseApp.TabIndex = 4;
            this.BTNcloseApp.Text = "Close the Aplication";
            this.BTNcloseApp.UseVisualStyleBackColor = true;
            this.BTNcloseApp.Click += new System.EventHandler(this.BTNcloseApp_Click);
            // 
            // DataGridEXAM
            // 
            this.DataGridEXAM.AllowUserToAddRows = false;
            this.DataGridEXAM.AllowUserToDeleteRows = false;
            this.DataGridEXAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEXAM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamId,
            this.TeamName,
            this.CoachName,
            this.DirectorName,
            this.AddressLine1,
            this.AddressLine2,
            this.PostCode,
            this.City,
            this.ContactNumber,
            this.EmailAddress,
            this.CreatedBy});
            this.DataGridEXAM.Location = new System.Drawing.Point(287, 26);
            this.DataGridEXAM.Name = "DataGridEXAM";
            this.DataGridEXAM.ReadOnly = true;
            this.DataGridEXAM.Size = new System.Drawing.Size(1145, 284);
            this.DataGridEXAM.TabIndex = 5;
            this.DataGridEXAM.SelectionChanged += new System.EventHandler(this.DataGridEXAM_SelectionChanged);
            // 
            // TeamId
            // 
            this.TeamId.DataPropertyName = "TeamId";
            this.TeamId.HeaderText = "TeamId";
            this.TeamId.Name = "TeamId";
            this.TeamId.ReadOnly = true;
            // 
            // TeamName
            // 
            this.TeamName.DataPropertyName = "TeamName";
            this.TeamName.HeaderText = "TeamName";
            this.TeamName.Name = "TeamName";
            this.TeamName.ReadOnly = true;
            // 
            // CoachName
            // 
            this.CoachName.DataPropertyName = "CoachName";
            this.CoachName.HeaderText = "CoachName";
            this.CoachName.Name = "CoachName";
            this.CoachName.ReadOnly = true;
            // 
            // DirectorName
            // 
            this.DirectorName.DataPropertyName = "DirectorName";
            this.DirectorName.HeaderText = "Director Name";
            this.DirectorName.Name = "DirectorName";
            this.DirectorName.ReadOnly = true;
            // 
            // AddressLine1
            // 
            this.AddressLine1.DataPropertyName = "AddressLine1";
            this.AddressLine1.HeaderText = "AddressLine1";
            this.AddressLine1.Name = "AddressLine1";
            this.AddressLine1.ReadOnly = true;
            // 
            // AddressLine2
            // 
            this.AddressLine2.DataPropertyName = "AddressLine2";
            this.AddressLine2.HeaderText = "AddressLine2";
            this.AddressLine2.Name = "AddressLine2";
            this.AddressLine2.ReadOnly = true;
            // 
            // PostCode
            // 
            this.PostCode.DataPropertyName = "PostCode";
            this.PostCode.HeaderText = "PostCode";
            this.PostCode.Name = "PostCode";
            this.PostCode.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // ContactNumber
            // 
            this.ContactNumber.DataPropertyName = "ContactNumber";
            this.ContactNumber.HeaderText = "ContactNumber";
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            // 
            // EmailAddress
            // 
            this.EmailAddress.DataPropertyName = "EmailAddress";
            this.EmailAddress.HeaderText = "EmailAddress";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            // 
            // CreatedBy
            // 
            this.CreatedBy.DataPropertyName = "CreatedBy";
            this.CreatedBy.HeaderText = "CreatedBy";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(114, 110);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(114, 136);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(156, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(114, 162);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(156, 20);
            this.textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(114, 188);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(156, 20);
            this.textBox7.TabIndex = 12;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(114, 214);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(156, 20);
            this.textBox8.TabIndex = 13;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(114, 240);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(156, 20);
            this.textBox9.TabIndex = 14;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(114, 266);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(156, 20);
            this.textBox10.TabIndex = 15;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(114, 294);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(156, 20);
            this.textBox11.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "TeamId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "TeamName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "CoachName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "DirectorName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "AddressLine1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "AddressLine2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "PostCode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "ContactNumber";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "EmailAddress";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "CreatedBy";
            // 
            // BTNdelete
            // 
            this.BTNdelete.Location = new System.Drawing.Point(534, 420);
            this.BTNdelete.Name = "BTNdelete";
            this.BTNdelete.Size = new System.Drawing.Size(172, 23);
            this.BTNdelete.TabIndex = 28;
            this.BTNdelete.Text = "Delete Team";
            this.BTNdelete.UseVisualStyleBackColor = true;
            this.BTNdelete.Click += new System.EventHandler(this.BTNdelete_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 479);
            this.Controls.Add(this.BTNdelete);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DataGridEXAM);
            this.Controls.Add(this.BTNcloseApp);
            this.Controls.Add(this.BTNmodify);
            this.Controls.Add(this.BTNinsert);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tournament Management System";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEXAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNinsert;
        private System.Windows.Forms.Button BTNmodify;
        private System.Windows.Forms.Button BTNcloseApp;
        private System.Windows.Forms.DataGridView DataGridEXAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoachName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressLine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressLine2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BTNdelete;
    }
}

