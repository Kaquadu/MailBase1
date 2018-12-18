namespace MailBase
{
    partial class MailingDB
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this._imgLogo = new System.Windows.Forms.PictureBox();
            this._textLabel_ID = new System.Windows.Forms.Label();
            this._textLabel_Phone = new System.Windows.Forms.Label();
            this._textLabel_Email = new System.Windows.Forms.Label();
            this._textBox_Phone = new System.Windows.Forms.TextBox();
            this._textBox_Email = new System.Windows.Forms.TextBox();
            this._btnNewReset = new System.Windows.Forms.Button();
            this._btnInsert = new System.Windows.Forms.Button();
            this._btnUpdate = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            this._btnSendMailTo = new System.Windows.Forms.Button();
            this._btnPDF = new System.Windows.Forms.Button();
            this._btnSendEmailEveryone = new System.Windows.Forms.Button();
            this._textLabelID = new System.Windows.Forms.Label();
            this._textBoxName = new System.Windows.Forms.TextBox();
            this._textLabelName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._textBox_MailText = new System.Windows.Forms.TextBox();
            this._buttonBack = new System.Windows.Forms.Button();
            this._buttonSendGroupSend = new System.Windows.Forms.Button();
            this._textBox_Subject = new System.Windows.Forms.TextBox();
            this._textLabelSubject = new System.Windows.Forms.Label();
            this._btnAutomation = new System.Windows.Forms.Button();
            this._textBox_Time = new System.Windows.Forms.TextBox();
            this._textLabel_Time = new System.Windows.Forms.Label();
            this._btnStartAuto = new System.Windows.Forms.Button();
            this._textLabel_TimeLeft = new System.Windows.Forms.Label();
            this._textBox_login = new System.Windows.Forms.TextBox();
            this._textBox_password = new System.Windows.Forms.TextBox();
            this._textLabel_login = new System.Windows.Forms.Label();
            this._textLabel_password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._textLabel_progress = new System.Windows.Forms.Label();
            this._textLabel_autosending = new System.Windows.Forms.Label();
            this._btn_attachment = new System.Windows.Forms.Button();
            this._textLabel_path = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // _imgLogo
            // 
            this._imgLogo.Image = global::MailBase.Properties.Resources.mail_base;
            this._imgLogo.Location = new System.Drawing.Point(22, 12);
            this._imgLogo.Name = "_imgLogo";
            this._imgLogo.Size = new System.Drawing.Size(199, 68);
            this._imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._imgLogo.TabIndex = 0;
            this._imgLogo.TabStop = false;
            this._imgLogo.Click += new System.EventHandler(this.OnLogoClick);
            // 
            // _textLabel_ID
            // 
            this._textLabel_ID.AutoSize = true;
            this._textLabel_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._textLabel_ID.Location = new System.Drawing.Point(33, 128);
            this._textLabel_ID.Name = "_textLabel_ID";
            this._textLabel_ID.Size = new System.Drawing.Size(29, 18);
            this._textLabel_ID.TabIndex = 1;
            this._textLabel_ID.Text = "ID:";
            // 
            // _textLabel_Phone
            // 
            this._textLabel_Phone.AutoSize = true;
            this._textLabel_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._textLabel_Phone.Location = new System.Drawing.Point(32, 177);
            this._textLabel_Phone.Name = "_textLabel_Phone";
            this._textLabel_Phone.Size = new System.Drawing.Size(65, 20);
            this._textLabel_Phone.TabIndex = 3;
            this._textLabel_Phone.Text = "Phone:";
            // 
            // _textLabel_Email
            // 
            this._textLabel_Email.AutoSize = true;
            this._textLabel_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._textLabel_Email.Location = new System.Drawing.Point(34, 203);
            this._textLabel_Email.Name = "_textLabel_Email";
            this._textLabel_Email.Size = new System.Drawing.Size(58, 20);
            this._textLabel_Email.TabIndex = 4;
            this._textLabel_Email.Text = "Email:";
            // 
            // _textBox_Phone
            // 
            this._textBox_Phone.Location = new System.Drawing.Point(131, 179);
            this._textBox_Phone.Name = "_textBox_Phone";
            this._textBox_Phone.Size = new System.Drawing.Size(200, 20);
            this._textBox_Phone.TabIndex = 9;
            // 
            // _textBox_Email
            // 
            this._textBox_Email.Location = new System.Drawing.Point(131, 205);
            this._textBox_Email.Name = "_textBox_Email";
            this._textBox_Email.Size = new System.Drawing.Size(200, 20);
            this._textBox_Email.TabIndex = 10;
            // 
            // _btnNewReset
            // 
            this._btnNewReset.Location = new System.Drawing.Point(450, 138);
            this._btnNewReset.Name = "_btnNewReset";
            this._btnNewReset.Size = new System.Drawing.Size(104, 23);
            this._btnNewReset.TabIndex = 14;
            this._btnNewReset.Text = "New / Reset";
            this._btnNewReset.UseVisualStyleBackColor = true;
            this._btnNewReset.Click += new System.EventHandler(this._btnNewReset_Click);
            // 
            // _btnInsert
            // 
            this._btnInsert.Location = new System.Drawing.Point(450, 164);
            this._btnInsert.Name = "_btnInsert";
            this._btnInsert.Size = new System.Drawing.Size(104, 23);
            this._btnInsert.TabIndex = 15;
            this._btnInsert.Text = "Insert";
            this._btnInsert.UseVisualStyleBackColor = true;
            this._btnInsert.Click += new System.EventHandler(this._btnInsert_Click);
            // 
            // _btnUpdate
            // 
            this._btnUpdate.Location = new System.Drawing.Point(450, 189);
            this._btnUpdate.Name = "_btnUpdate";
            this._btnUpdate.Size = new System.Drawing.Size(104, 23);
            this._btnUpdate.TabIndex = 16;
            this._btnUpdate.Text = "Update Table";
            this._btnUpdate.UseVisualStyleBackColor = true;
            this._btnUpdate.Click += new System.EventHandler(this._btnUpdate_Click);
            // 
            // _btnDelete
            // 
            this._btnDelete.Location = new System.Drawing.Point(450, 215);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(104, 23);
            this._btnDelete.TabIndex = 17;
            this._btnDelete.Text = "Delete";
            this._btnDelete.UseVisualStyleBackColor = true;
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // _btnSendMailTo
            // 
            this._btnSendMailTo.Location = new System.Drawing.Point(58, 497);
            this._btnSendMailTo.Name = "_btnSendMailTo";
            this._btnSendMailTo.Size = new System.Drawing.Size(116, 23);
            this._btnSendMailTo.TabIndex = 18;
            this._btnSendMailTo.Text = "Send Email To...";
            this._btnSendMailTo.UseVisualStyleBackColor = true;
            this._btnSendMailTo.Click += new System.EventHandler(this._btnSendMailTo_Click);
            // 
            // _btnPDF
            // 
            this._btnPDF.Location = new System.Drawing.Point(302, 496);
            this._btnPDF.Name = "_btnPDF";
            this._btnPDF.Size = new System.Drawing.Size(116, 23);
            this._btnPDF.TabIndex = 19;
            this._btnPDF.Text = "Export to PDF";
            this._btnPDF.UseVisualStyleBackColor = true;
            this._btnPDF.Click += new System.EventHandler(this._btnPDF_Click);
            // 
            // _btnSendEmailEveryone
            // 
            this._btnSendEmailEveryone.Location = new System.Drawing.Point(180, 497);
            this._btnSendEmailEveryone.Name = "_btnSendEmailEveryone";
            this._btnSendEmailEveryone.Size = new System.Drawing.Size(116, 23);
            this._btnSendEmailEveryone.TabIndex = 20;
            this._btnSendEmailEveryone.Text = "Send Group Email";
            this._btnSendEmailEveryone.UseVisualStyleBackColor = true;
            this._btnSendEmailEveryone.Click += new System.EventHandler(this._btnSendEmailEveryone_Click);
            // 
            // _textLabelID
            // 
            this._textLabelID.AutoSize = true;
            this._textLabelID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._textLabelID.Location = new System.Drawing.Point(128, 128);
            this._textLabelID.Name = "_textLabelID";
            this._textLabelID.Size = new System.Drawing.Size(63, 13);
            this._textLabelID.TabIndex = 23;
            this._textLabelID.Text = "Selected ID";
            this._textLabelID.Click += new System.EventHandler(this.label1_Click);
            // 
            // _textBoxName
            // 
            this._textBoxName.Location = new System.Drawing.Point(131, 152);
            this._textBoxName.Name = "_textBoxName";
            this._textBoxName.Size = new System.Drawing.Size(200, 20);
            this._textBoxName.TabIndex = 24;
            // 
            // _textLabelName
            // 
            this._textLabelName.AutoSize = true;
            this._textLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._textLabelName.Location = new System.Drawing.Point(32, 152);
            this._textLabelName.Name = "_textLabelName";
            this._textLabelName.Size = new System.Drawing.Size(60, 20);
            this._textLabelName.TabIndex = 25;
            this._textLabelName.Text = "Name:";
            this._textLabelName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 248);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // _textBox_MailText
            // 
            this._textBox_MailText.Location = new System.Drawing.Point(36, 243);
            this._textBox_MailText.Multiline = true;
            this._textBox_MailText.Name = "_textBox_MailText";
            this._textBox_MailText.Size = new System.Drawing.Size(518, 249);
            this._textBox_MailText.TabIndex = 27;
            this._textBox_MailText.Visible = false;
            // 
            // _buttonBack
            // 
            this._buttonBack.Location = new System.Drawing.Point(58, 526);
            this._buttonBack.Name = "_buttonBack";
            this._buttonBack.Size = new System.Drawing.Size(116, 23);
            this._buttonBack.TabIndex = 28;
            this._buttonBack.Text = "Back";
            this._buttonBack.UseVisualStyleBackColor = true;
            this._buttonBack.Visible = false;
            this._buttonBack.Click += new System.EventHandler(this._buttonBack_Click);
            // 
            // _buttonSendGroupSend
            // 
            this._buttonSendGroupSend.Location = new System.Drawing.Point(302, 525);
            this._buttonSendGroupSend.Name = "_buttonSendGroupSend";
            this._buttonSendGroupSend.Size = new System.Drawing.Size(116, 23);
            this._buttonSendGroupSend.TabIndex = 29;
            this._buttonSendGroupSend.Text = "Send";
            this._buttonSendGroupSend.UseVisualStyleBackColor = true;
            this._buttonSendGroupSend.Visible = false;
            this._buttonSendGroupSend.Click += new System.EventHandler(this._buttonSendSend_Click);
            // 
            // _textBox_Subject
            // 
            this._textBox_Subject.Location = new System.Drawing.Point(131, 153);
            this._textBox_Subject.Name = "_textBox_Subject";
            this._textBox_Subject.Size = new System.Drawing.Size(313, 20);
            this._textBox_Subject.TabIndex = 30;
            this._textBox_Subject.Visible = false;
            // 
            // _textLabelSubject
            // 
            this._textLabelSubject.AutoSize = true;
            this._textLabelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._textLabelSubject.Location = new System.Drawing.Point(32, 150);
            this._textLabelSubject.Name = "_textLabelSubject";
            this._textLabelSubject.Size = new System.Drawing.Size(75, 20);
            this._textLabelSubject.TabIndex = 31;
            this._textLabelSubject.Text = "Subject:";
            this._textLabelSubject.Visible = false;
            // 
            // _btnAutomation
            // 
            this._btnAutomation.Location = new System.Drawing.Point(424, 496);
            this._btnAutomation.Name = "_btnAutomation";
            this._btnAutomation.Size = new System.Drawing.Size(116, 23);
            this._btnAutomation.TabIndex = 32;
            this._btnAutomation.Text = "Automation";
            this._btnAutomation.UseVisualStyleBackColor = true;
            this._btnAutomation.Click += new System.EventHandler(this._btnAutomation_Click);
            // 
            // _textBox_Time
            // 
            this._textBox_Time.Location = new System.Drawing.Point(147, 179);
            this._textBox_Time.Name = "_textBox_Time";
            this._textBox_Time.Size = new System.Drawing.Size(89, 20);
            this._textBox_Time.TabIndex = 34;
            this._textBox_Time.Visible = false;
            // 
            // _textLabel_Time
            // 
            this._textLabel_Time.AutoSize = true;
            this._textLabel_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._textLabel_Time.Location = new System.Drawing.Point(34, 179);
            this._textLabel_Time.Name = "_textLabel_Time";
            this._textLabel_Time.Size = new System.Drawing.Size(107, 20);
            this._textLabel_Time.TabIndex = 35;
            this._textLabel_Time.Text = "Time period:";
            this._textLabel_Time.Visible = false;
            // 
            // _btnStartAuto
            // 
            this._btnStartAuto.Location = new System.Drawing.Point(302, 525);
            this._btnStartAuto.Name = "_btnStartAuto";
            this._btnStartAuto.Size = new System.Drawing.Size(116, 23);
            this._btnStartAuto.TabIndex = 38;
            this._btnStartAuto.Text = "Start";
            this._btnStartAuto.UseVisualStyleBackColor = true;
            this._btnStartAuto.Visible = false;
            this._btnStartAuto.Click += new System.EventHandler(this._btnStartAuto_Click);
            // 
            // _textLabel_TimeLeft
            // 
            this._textLabel_TimeLeft.AutoSize = true;
            this._textLabel_TimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._textLabel_TimeLeft.Location = new System.Drawing.Point(242, 179);
            this._textLabel_TimeLeft.Name = "_textLabel_TimeLeft";
            this._textLabel_TimeLeft.Size = new System.Drawing.Size(35, 18);
            this._textLabel_TimeLeft.TabIndex = 37;
            this._textLabel_TimeLeft.Text = "min";
            this._textLabel_TimeLeft.Visible = false;
            // 
            // _textBox_login
            // 
            this._textBox_login.Location = new System.Drawing.Point(432, 23);
            this._textBox_login.Name = "_textBox_login";
            this._textBox_login.Size = new System.Drawing.Size(122, 20);
            this._textBox_login.TabIndex = 39;
            // 
            // _textBox_password
            // 
            this._textBox_password.Location = new System.Drawing.Point(432, 49);
            this._textBox_password.Name = "_textBox_password";
            this._textBox_password.Size = new System.Drawing.Size(122, 20);
            this._textBox_password.TabIndex = 40;
            // 
            // _textLabel_login
            // 
            this._textLabel_login.AutoSize = true;
            this._textLabel_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._textLabel_login.Location = new System.Drawing.Point(368, 21);
            this._textLabel_login.Name = "_textLabel_login";
            this._textLabel_login.Size = new System.Drawing.Size(58, 20);
            this._textLabel_login.TabIndex = 41;
            this._textLabel_login.Text = "Login:";
            // 
            // _textLabel_password
            // 
            this._textLabel_password.AutoSize = true;
            this._textLabel_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._textLabel_password.ForeColor = System.Drawing.SystemColors.ControlText;
            this._textLabel_password.Location = new System.Drawing.Point(335, 47);
            this._textLabel_password.Name = "_textLabel_password";
            this._textLabel_password.Size = new System.Drawing.Size(91, 20);
            this._textLabel_password.TabIndex = 42;
            this._textLabel_password.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Location = new System.Drawing.Point(357, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Your login n\' password for gmail account";
            // 
            // _textLabel_progress
            // 
            this._textLabel_progress.AutoSize = true;
            this._textLabel_progress.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._textLabel_progress.ForeColor = System.Drawing.Color.Red;
            this._textLabel_progress.Location = new System.Drawing.Point(205, 502);
            this._textLabel_progress.Name = "_textLabel_progress";
            this._textLabel_progress.Size = new System.Drawing.Size(179, 13);
            this._textLabel_progress.TabIndex = 44;
            this._textLabel_progress.Text = "SENDING EMAILS, PLEASE WAIT!";
            this._textLabel_progress.Visible = false;
            // 
            // _textLabel_autosending
            // 
            this._textLabel_autosending.AutoSize = true;
            this._textLabel_autosending.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._textLabel_autosending.ForeColor = System.Drawing.Color.Red;
            this._textLabel_autosending.Location = new System.Drawing.Point(231, 220);
            this._textLabel_autosending.Name = "_textLabel_autosending";
            this._textLabel_autosending.Size = new System.Drawing.Size(120, 13);
            this._textLabel_autosending.TabIndex = 45;
            this._textLabel_autosending.Text = "Auto-sending is running!";
            this._textLabel_autosending.Visible = false;
            // 
            // _btn_attachment
            // 
            this._btn_attachment.Location = new System.Drawing.Point(180, 526);
            this._btn_attachment.Name = "_btn_attachment";
            this._btn_attachment.Size = new System.Drawing.Size(116, 23);
            this._btn_attachment.TabIndex = 46;
            this._btn_attachment.Text = "Attachment";
            this._btn_attachment.UseVisualStyleBackColor = true;
            this._btn_attachment.Visible = false;
            this._btn_attachment.Click += new System.EventHandler(this._btn_attachment_Click);
            // 
            // _textLabel_path
            // 
            this._textLabel_path.AutoSize = true;
            this._textLabel_path.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._textLabel_path.ForeColor = System.Drawing.Color.Black;
            this._textLabel_path.Location = new System.Drawing.Point(64, 564);
            this._textLabel_path.Name = "_textLabel_path";
            this._textLabel_path.Size = new System.Drawing.Size(28, 13);
            this._textLabel_path.TabIndex = 47;
            this._textLabel_path.Text = "path";
            this._textLabel_path.Visible = false;
            // 
            // MailingDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(591, 586);
            this.Controls.Add(this._textLabel_path);
            this.Controls.Add(this._btn_attachment);
            this.Controls.Add(this._textLabel_autosending);
            this.Controls.Add(this._textLabel_progress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._textLabel_password);
            this.Controls.Add(this._textLabel_login);
            this.Controls.Add(this._textBox_password);
            this.Controls.Add(this._textBox_login);
            this.Controls.Add(this._btnStartAuto);
            this.Controls.Add(this._textLabel_TimeLeft);
            this.Controls.Add(this._textLabel_Time);
            this.Controls.Add(this._textBox_Time);
            this.Controls.Add(this._btnAutomation);
            this.Controls.Add(this._textLabelSubject);
            this.Controls.Add(this._textBox_Subject);
            this.Controls.Add(this._buttonSendGroupSend);
            this.Controls.Add(this._buttonBack);
            this.Controls.Add(this._textBox_MailText);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this._textLabelName);
            this.Controls.Add(this._textBoxName);
            this.Controls.Add(this._textLabelID);
            this.Controls.Add(this._btnSendEmailEveryone);
            this.Controls.Add(this._btnPDF);
            this.Controls.Add(this._btnSendMailTo);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._btnUpdate);
            this.Controls.Add(this._btnInsert);
            this.Controls.Add(this._btnNewReset);
            this.Controls.Add(this._textBox_Email);
            this.Controls.Add(this._textBox_Phone);
            this.Controls.Add(this._textLabel_Email);
            this.Controls.Add(this._textLabel_Phone);
            this.Controls.Add(this._textLabel_ID);
            this.Controls.Add(this._imgLogo);
            this.Name = "MailingDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mailing Database";
            this.Load += new System.EventHandler(this.MailingDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this._imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _imgLogo;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private System.Windows.Forms.Label _textLabel_ID;
        private System.Windows.Forms.Label _textLabel_Phone;
        private System.Windows.Forms.Label _textLabel_Email;
        private System.Windows.Forms.TextBox _textBox_Phone;
        private System.Windows.Forms.TextBox _textBox_Email;
        private System.Windows.Forms.Button _btnNewReset;
        private System.Windows.Forms.Button _btnInsert;
        private System.Windows.Forms.Button _btnUpdate;
        private System.Windows.Forms.Button _btnDelete;
        private System.Windows.Forms.Button _btnSendMailTo;
        private System.Windows.Forms.Button _btnPDF;
        private System.Windows.Forms.Button _btnSendEmailEveryone;
        private System.Windows.Forms.Label _textLabelID;
        private System.Windows.Forms.TextBox _textBoxName;
        private System.Windows.Forms.Label _textLabelName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox _textBox_MailText;
        private System.Windows.Forms.Button _buttonBack;
        private System.Windows.Forms.Button _buttonSendGroupSend;
        private System.Windows.Forms.TextBox _textBox_Subject;
        private System.Windows.Forms.Label _textLabelSubject;
        private System.Windows.Forms.Button _btnAutomation;
        private System.Windows.Forms.TextBox _textBox_Time;
        private System.Windows.Forms.Label _textLabel_Time;
        private System.Windows.Forms.Button _btnStartAuto;
        private System.Windows.Forms.Label _textLabel_TimeLeft;
        private System.Windows.Forms.TextBox _textBox_login;
        private System.Windows.Forms.TextBox _textBox_password;
        private System.Windows.Forms.Label _textLabel_login;
        private System.Windows.Forms.Label _textLabel_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _textLabel_progress;
        private System.Windows.Forms.Label _textLabel_autosending;
        private System.Windows.Forms.Button _btn_attachment;
        private System.Windows.Forms.Label _textLabel_path;
    }
}

