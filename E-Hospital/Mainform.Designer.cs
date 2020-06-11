namespace E_Hospital
{
    partial class MainForm
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
            this.lblFullname = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.checkBoxSex = new System.Windows.Forms.CheckedListBox();
            this.lblHomeAddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearchAnotherUser = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.dataListOf = new System.Windows.Forms.DataGridView();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblEHospital = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataListOf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFullname
            // 
            this.lblFullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFullname.AutoSize = true;
            this.lblFullname.BackColor = System.Drawing.SystemColors.Menu;
            this.lblFullname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFullname.Location = new System.Drawing.Point(103, 108);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(52, 13);
            this.lblFullname.TabIndex = 0;
            this.lblFullname.Text = "Full name";
            // 
            // txtFullname
            // 
            this.txtFullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFullname.Location = new System.Drawing.Point(191, 106);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(199, 20);
            this.txtFullname.TabIndex = 1;
            // 
            // lblSex
            // 
            this.lblSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSex.AutoSize = true;
            this.lblSex.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSex.Location = new System.Drawing.Point(103, 245);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(25, 13);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "Sex";
            // 
            // checkBoxSex
            // 
            this.checkBoxSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxSex.FormattingEnabled = true;
            this.checkBoxSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.checkBoxSex.Location = new System.Drawing.Point(191, 236);
            this.checkBoxSex.Name = "checkBoxSex";
            this.checkBoxSex.Size = new System.Drawing.Size(199, 34);
            this.checkBoxSex.TabIndex = 4;
            // 
            // lblHomeAddress
            // 
            this.lblHomeAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHomeAddress.AutoSize = true;
            this.lblHomeAddress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHomeAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHomeAddress.Location = new System.Drawing.Point(103, 134);
            this.lblHomeAddress.Name = "lblHomeAddress";
            this.lblHomeAddress.Size = new System.Drawing.Size(76, 13);
            this.lblHomeAddress.TabIndex = 5;
            this.lblHomeAddress.Text = "Home Address";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(103, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telephone";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmail.Location = new System.Drawing.Point(103, 186);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(399, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Notes";
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHomeAddress.Location = new System.Drawing.Point(191, 132);
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(199, 20);
            this.txtHomeAddress.TabIndex = 9;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelephone.Location = new System.Drawing.Point(191, 158);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(199, 20);
            this.txtTelephone.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(191, 184);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNotes.Location = new System.Drawing.Point(440, 106);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(341, 158);
            this.txtNotes.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Location = new System.Drawing.Point(787, 106);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Location = new System.Drawing.Point(787, 147);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Location = new System.Drawing.Point(787, 188);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSearchAnotherUser
            // 
            this.btnSearchAnotherUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchAnotherUser.BackColor = System.Drawing.Color.LightPink;
            this.btnSearchAnotherUser.Location = new System.Drawing.Point(653, 40);
            this.btnSearchAnotherUser.Name = "btnSearchAnotherUser";
            this.btnSearchAnotherUser.Size = new System.Drawing.Size(128, 23);
            this.btnSearchAnotherUser.TabIndex = 21;
            this.btnSearchAnotherUser.Text = "Search Another User";
            this.btnSearchAnotherUser.UseVisualStyleBackColor = false;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignOut.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSignOut.Location = new System.Drawing.Point(653, 69);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(128, 23);
            this.btnSignOut.TabIndex = 22;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDateOfBirth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDateOfBirth.Location = new System.Drawing.Point(103, 215);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(66, 13);
            this.lblDateOfBirth.TabIndex = 23;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // dtDateOfBirth
            // 
            this.dtDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtDateOfBirth.CustomFormat = "MMMM dd yyyy ";
            this.dtDateOfBirth.Location = new System.Drawing.Point(191, 210);
            this.dtDateOfBirth.Name = "dtDateOfBirth";
            this.dtDateOfBirth.Size = new System.Drawing.Size(199, 20);
            this.dtDateOfBirth.TabIndex = 26;
            // 
            // dataListOf
            // 
            this.dataListOf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListOf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListOf.Location = new System.Drawing.Point(106, 301);
            this.dataListOf.Name = "dataListOf";
            this.dataListOf.Size = new System.Drawing.Size(756, 240);
            this.dataListOf.TabIndex = 27;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPostalCode.Location = new System.Drawing.Point(191, 276);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(199, 20);
            this.txtPostalCode.TabIndex = 29;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.BackColor = System.Drawing.SystemColors.Menu;
            this.lblPostalCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPostalCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPostalCode.Location = new System.Drawing.Point(103, 278);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(64, 13);
            this.lblPostalCode.TabIndex = 28;
            this.lblPostalCode.Text = "Postal Code";
            // 
            // lblEHospital
            // 
            this.lblEHospital.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEHospital.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEHospital.Font = new System.Drawing.Font("Ravie", 30F);
            this.lblEHospital.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEHospital.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEHospital.Location = new System.Drawing.Point(182, 31);
            this.lblEHospital.Name = "lblEHospital";
            this.lblEHospital.Size = new System.Drawing.Size(318, 61);
            this.lblEHospital.TabIndex = 30;
            this.lblEHospital.Text = "E-Hospital";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(930, 590);
            this.Controls.Add(this.lblEHospital);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.dataListOf);
            this.Controls.Add(this.dtDateOfBirth);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnSearchAnotherUser);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtHomeAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHomeAddress);
            this.Controls.Add(this.checkBoxSex);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.lblFullname);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataListOf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.CheckedListBox checkBoxSex;
        private System.Windows.Forms.Label lblHomeAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearchAnotherUser;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtDateOfBirth;
        private System.Windows.Forms.DataGridView dataListOf;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblEHospital;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}