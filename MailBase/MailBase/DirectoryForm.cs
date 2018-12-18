using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Threading;

namespace MailBase
{
    public partial class MailingDB : Form
    {
        public SQLiteConnection m_dbConnection;
        public bool groupEmail = true;
        public bool mailingBreak = false;
        DateTime now = DateTime.Now;
        DateTime nextEmail = new DateTime();
        Thread mailing;

        public void InitializeDB()
        {
            string curFile = @"Users_DB.sqlite";

            if (!File.Exists(curFile))
            {
                SQLiteConnection.CreateFile("Users_DB.sqlite");
                m_dbConnection = new SQLiteConnection("Data Source=Users_DB.sqlite;Version=3;");
                m_dbConnection.Open();

                string sql = "create table public_datas (ID VARCHAR(50) PRIMARY KEY, name VARCHAR(50) NOT NULL, phone VARCHAR(50) NOT NULL, email VARCHAR(320) NOT NULL)";

                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
                m_dbConnection.Close();
            }
            else
            {
                m_dbConnection = new SQLiteConnection("Data Source=Users_DB.sqlite;Version=3;");
            }
        }

        public void InitializeDataGridView()
        {
            //dataGridView1 = new DataGridView();
            DataGridViewRolloverCellColumn newCol =
                new DataGridViewRolloverCellColumn();

            newCol.HeaderText = "ID";
            newCol.Name = "ID";
            newCol.Visible = true;
            newCol.Width = 80;
            newCol.ReadOnly = true;

            dataGridView1.Columns.Add(newCol);

            newCol =
                new DataGridViewRolloverCellColumn();
            newCol.HeaderText = "Name";
            newCol.Name = "Name";
            newCol.Visible = true;
            newCol.Width = 120;
            newCol.ReadOnly = true;

            dataGridView1.Columns.Add(newCol);

            newCol =
                new DataGridViewRolloverCellColumn();
            newCol.HeaderText = "Phone";
            newCol.Name = "Phone";
            newCol.Visible = true;
            newCol.Width = 70;
            newCol.ReadOnly = true;

            dataGridView1.Columns.Add(newCol);

            newCol =
                new DataGridViewRolloverCellColumn();
            newCol.HeaderText = "Email";
            newCol.Name = "Email";
            newCol.Visible = true;
            newCol.Width = 200;
            newCol.ReadOnly = true;

            dataGridView1.Columns.Add(newCol);
        }

        public MailingDB()
        {
            InitializeComponent();
            InitializeDB();
            InitializeDataGridView();
            _textBox_login.Text = "spamapptester";
            _textBox_password.Text = "spamapp123";
            _textBox_password.PasswordChar = '*';
            mailing = new Thread(Mailing);
        }

        private void OnLogoClick(object sender, EventArgs e)
        {
            MessageBox.Show("Written by Kuba Kowalczykowski\nFinal project for Web Applications Subject", "Mailing System");
        }

        private void MailingDB_Load(object sender, EventArgs e)
        {

        }

        private void _btnNewReset_Click(object sender, EventArgs e)
        {
            _textLabelID.Text = "Selected ID";
            _textBoxName.Text = "";
            _textBox_Phone.Text = "";
            _textBox_Email.Text = "";
        }

        private void _btnInsert_Click(object sender, EventArgs e)
        {
            if (_textBoxName.Text != "" && _textBox_Phone.Text != "" && _textBox_Email.Text != "")
            {
                var regexItem1 = new Regex("^[a-zA-Z0-9 ]*$");
                var regexItem2 = new Regex("^[0-9]*$");
                var regexItem3 = new Regex("^[@a-zA-Z0-9 ]*$");

                m_dbConnection.Open();
                string sql2 = "select * from public_datas order by ID desc";
                SQLiteCommand command2 = new SQLiteCommand(sql2, m_dbConnection);
                SQLiteDataReader reader = command2.ExecuteReader();
                dataGridView1.Rows.Clear();
                bool duplicate = false;
                while (reader.Read())
                {
                    if (reader["email"].ToString() == _textBox_Email.Text) duplicate = true;
                }
                m_dbConnection.Close();

                if (!regexItem1.IsMatch(_textBoxName.Text))
                {
                    MessageBox.Show("Incorrect name, please use: a-z, A-Z, 0-9");
                }
                else if (duplicate)
                {
                    MessageBox.Show("Duplicate email");
                }
                else if (!regexItem2.IsMatch(_textBox_Phone.Text))
                {
                    MessageBox.Show("Incorrect phone, please use: 0-9");
                }
                else if (_textBox_Phone.Text.Length != 9)
                {
                    MessageBox.Show("Phone length not correct");
                }
                else if (regexItem3.IsMatch(_textBox_Email.Text))
                {
                    MessageBox.Show("Incorrect email, please use: @, a-z, A-Z, 0-9");
                }
                else if (!_textBox_Email.Text.Contains("@"))
                {
                    MessageBox.Show("No @ in email");
                }
                else
                {
                    m_dbConnection.Open();
                    Guid g = Guid.NewGuid();

                    string sql = "INSERT INTO public_datas VALUES ('" + g + "', '" + _textBoxName.Text + "', '" + _textBox_Phone.Text + "', '" + _textBox_Email.Text + "')";
                    //Console.WriteLine(sql);
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                    m_dbConnection.Close();

                    _textLabelID.Text = "Selected ID";
                    _textBoxName.Text = "";
                    _textBox_Phone.Text = "";
                    _textBox_Email.Text = "";
                }
            }
            UpdateTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void _btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            m_dbConnection.Open();
            string sql = "DELETE FROM public_datas WHERE email = '" + _textBox_Email.Text + "'";
            //Console.WriteLine(sql);
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
            UpdateTable();
        }

        public void UpdateTable()
        {
            m_dbConnection.Open();
            string sql = "select * from public_datas order by ID desc";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                //Console.WriteLine("ID: " + reader["ID"] + "\tName: " + reader["name"] + "\tPhone: " + reader["phone"] + "\tEmail: " + reader["email"]);
                dataGridView1.Rows.Add(new object[]
                {
                    reader["ID"],
                    reader["name"],
                    reader["phone"],
                    reader["email"]
                });
            }
            m_dbConnection.Close();

            try
            {
                _textLabelID.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                _textBoxName.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                _textBox_Phone.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                _textBox_Email.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                _textLabelID.Text = "Selected ID";
                _textBoxName.Text = "";
                _textBox_Phone.Text = "";
                _textBox_Email.Text = "";
            }
            //Console.WriteLine("------------------------------------------------------------------------");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine("CELL CLICK.");
            _textLabelID.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            _textBoxName.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            _textBox_Phone.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            _textBox_Email.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();

        }

        private void _btnSendEmailEveryone_Click(object sender, EventArgs e)
        {
            groupEmail = true;
            DatabaseLayout(false);
            EmailLayout(true);
            _textBox_Subject.Text = "DATE - That's not a spam mail, NAME!";
            _textBox_MailText.Text = "Hey NAME! I'm currently testing my spamapp. Your identification number is: ID. Welcome! DATE";
        }

        public void EmailLayout(bool type)
        {
            _textBox_MailText.Visible = type;
            _buttonBack.Visible = type;
            _buttonSendGroupSend.Visible = type;
            _textBox_Subject.Visible = type;
            _textLabelSubject.Visible = type;
            _btn_attachment.Visible = type;
            _textLabel_path.Visible = type;
        }

        public void AutomationLayout(bool type)
        {
            _textLabel_Time.Visible = type;
            _textBox_Time.Visible = type;
            _textLabel_TimeLeft.Visible = type;
            _buttonSendGroupSend.Visible = false;
            _btnStartAuto.Visible = type;


        }

        private void _buttonBack_Click(object sender, EventArgs e)
        {
            _textLabel_path.Text = "path";
            mailing.Abort();
            _textLabel_autosending.Visible = false;
            m_dbConnection.Close();
            mailingBreak = false;
            EmailLayout(false);
            AutomationLayout(false);
            DatabaseLayout(true);
        }
        public void DatabaseLayout(bool type)
        {
            _btnStartAuto.Visible = false;
            _textBox_Phone.Visible = type;
            _textBoxName.Visible = type;
            _textBox_Email.Visible = type;
            _textLabelID.Visible = type;
            _textLabelName.Visible = type;
            _textLabel_Email.Visible = type;
            _textLabel_ID.Visible = type;
            _textLabel_Phone.Visible = type;
            dataGridView1.Visible = type;
            _btnDelete.Visible = type;
            _btnInsert.Visible = type;
            _btnNewReset.Visible = type;
            _btnPDF.Visible = type;
            _btnSendEmailEveryone.Visible = type;
            _btnSendMailTo.Visible = type;
            _btnAutomation.Visible = type;
            _btnUpdate.Visible = type;
        }

        private void _buttonSendSend_Click(object sender, EventArgs e)
        {
            _textLabel_progress.Visible = true;
            this.Update();
            if (groupEmail == true)
            {
                m_dbConnection.Open();
                string sql = "select * from public_datas order by ID desc";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        var mail = new MailMessage();
                        var SmtpServer = new SmtpClient("smtp.gmail.com");

                        mail.From = new MailAddress(_textBox_login.Text + "@gmail.com");
                        mail.To.Add(reader["email"].ToString());

                        string message = _textBox_MailText.Text;
                        message = Regex.Replace(message, "NAME", reader["name"].ToString());
                        //Console.WriteLine(message);
                        message = Regex.Replace(message, "ID", reader["id"].ToString());
                        //Console.WriteLine(message);
                        message = Regex.Replace(message, "PHONE", reader["phone"].ToString());
                        //Console.WriteLine(message);
                        message = Regex.Replace(message, "DATE", DateTime.Now.ToString());
                        string subject = _textBox_Subject.Text;
                        subject = Regex.Replace(subject, "NAME", reader["name"].ToString());
                        subject = Regex.Replace(subject, "ID", reader["id"].ToString());
                        subject = Regex.Replace(subject, "PHONE", reader["phone"].ToString());
                        subject = Regex.Replace(subject, "DATE", DateTime.Now.ToString());

                        mail.Subject = subject;
                        mail.Body = message;

                        if (_textLabel_path.Text != "path")
                        {
                            Attachment atc = new Attachment(_textLabel_path.Text);
                            mail.Attachments.Add(atc);
                        }

                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential(_textBox_login.Text, _textBox_password.Text);
                        SmtpServer.EnableSsl = true;

                        SmtpServer.Send(mail);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                m_dbConnection.Close();
                _textLabel_progress.Visible = false;
            }
            else
            {
                _textLabel_progress.Visible = true;
                this.Update();
                try
                {
                    var mail = new MailMessage();
                    var SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress(_textBox_login.Text + "@gmail.com");
                    mail.To.Add(_textBox_Email.Text);

                    string message = _textBox_MailText.Text;
                    message = Regex.Replace(message, "NAME", _textBoxName.Text);
                    //Console.WriteLine(message);
                    message = Regex.Replace(message, "ID", _textLabelID.Text);
                    //Console.WriteLine(message);
                    message = Regex.Replace(message, "PHONE", _textBox_Phone.Text);
                    //Console.WriteLine(message);
                    message = Regex.Replace(message, "DATE", DateTime.Now.ToString());
                    string subject = _textBox_Subject.Text;
                    subject = Regex.Replace(subject, "NAME", _textBoxName.Text);
                    subject = Regex.Replace(subject, "ID", _textLabelID.Text);
                    subject = Regex.Replace(subject, "PHONE", _textBox_Phone.Text);
                    subject = Regex.Replace(subject, "DATE", DateTime.Now.ToString());

                    mail.Subject = subject;
                    mail.Body = message;

                    if (_textLabel_path.Text != "path")
                    {
                        Attachment atc = new Attachment(_textLabel_path.Text);
                        mail.Attachments.Add(atc);
                    }

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(_textBox_login.Text, _textBox_password.Text);
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                _textLabel_progress.Visible = false;
            }

            _textLabel_path.Text = "path";
            EmailLayout(false);
            DatabaseLayout(true);
        }

        private void _btnSendMailTo_Click(object sender, EventArgs e)
        {
            groupEmail = false;


            DatabaseLayout(false);
            EmailLayout(true);


            _textBox_Subject.Text = "DATE - That's not a spam mail, NAME!";
            _textBox_MailText.Text = "Hey NAME! I'm currently testing my spamapp. Your identification number is: ID. Welcome! DATE";
        }

        private void _btnPDF_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("MailingDB.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 2, 2, 30, 30);
            iTextSharp.text.pdf.PdfWriter writier = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);

            doc.Open();
           

            m_dbConnection.Open();
            string sql = "select * from public_datas order by ID desc";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            dataGridView1.Rows.Clear();
            int i = 0;
            while (reader.Read())
            {
                //Console.WriteLine("ID: " + reader["ID"] + "\tName: " + reader["name"] + "\tPhone: " + reader["phone"] + "\tEmail: " + reader["email"]);
                doc.Add(new iTextSharp.text.Paragraph(
                    reader["ID"].ToString() + " | " +
                    reader["name"].ToString() + " | " +
                    reader["phone"].ToString() + " | " +
                    reader["email"].ToString()
                ));
                i++;
                if (i > 42)
                { doc.NewPage(); i = 0; }
            }
            m_dbConnection.Close();
            doc.Close();
        }

        private void _btnAutomation_Click(object sender, EventArgs e)
        {
            DatabaseLayout(false);
            EmailLayout(true);
            AutomationLayout(true);
            _textBox_Subject.Text = "DATE - That's not a spam mail, NAME!";
            _textBox_MailText.Text = "Hey NAME! I'm currently testing my spamapp. Your identification number is: ID. Welcome! DATE";
        }

        private void _btnStartAuto_Click(object sender, EventArgs e)
        {
           
            var regexItem1 = new Regex("^[0-9]*$");
            if (_textBox_Time.Text == "")
            {
                MessageBox.Show("Incorrect time, use: 0-9");
            }
            else if (!regexItem1.IsMatch(_textBox_Time.Text))
            {
                MessageBox.Show("Incorrect time, use: 0-9");
            } 
            else
            {
                _textLabel_autosending.Visible = true;
                mailingBreak = true;
                mailing = new Thread(Mailing);
                mailing.Start();
            }
        }

        public void Mailing()
        {
            while (mailingBreak != false)
            {
                DateTime now = DateTime.Now;
                Console.WriteLine("sending email");
                Console.WriteLine(now + " " + nextEmail);
                m_dbConnection.Open();
                string sql = "select * from public_datas order by ID desc";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        var mail = new MailMessage();
                        var SmtpServer = new SmtpClient("smtp.gmail.com");

                        mail.From = new MailAddress(_textBox_login.Text + "@gmail.com");
                        mail.To.Add(reader["email"].ToString());

                        string message = _textBox_MailText.Text;
                        message = Regex.Replace(message, "NAME", reader["name"].ToString());
                        //Console.WriteLine(message);
                        message = Regex.Replace(message, "ID", reader["id"].ToString());
                        //Console.WriteLine(message);
                        message = Regex.Replace(message, "PHONE", reader["phone"].ToString());
                        //Console.WriteLine(message);
                        message = Regex.Replace(message, "DATE", DateTime.Now.ToString());
                        string subject = _textBox_Subject.Text;
                        subject = Regex.Replace(subject, "NAME", reader["name"].ToString());
                        subject = Regex.Replace(subject, "ID", reader["id"].ToString());
                        subject = Regex.Replace(subject, "PHONE", reader["phone"].ToString());
                        subject = Regex.Replace(subject, "DATE", DateTime.Now.ToString());

                        mail.Subject = subject;
                        mail.Body = message;

                        if (_textLabel_path.Text != "path")
                        {
                            Attachment atc = new Attachment(_textLabel_path.Text);
                            mail.Attachments.Add(atc);
                        }

                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential(_textBox_login.Text, _textBox_password.Text);
                        SmtpServer.EnableSsl = true;

                        SmtpServer.Send(mail);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                m_dbConnection.Close();


                nextEmail = now;
                nextEmail = nextEmail.AddMinutes(double.Parse(_textBox_Time.Text));
                Console.WriteLine(now + " " + nextEmail);
                while(nextEmail >= now)
                {
                    now = DateTime.Now;
                }
            }
        }

        private void _btn_attachment_Click(object sender, EventArgs e)
        {
            OpenFileDialog FBD = new OpenFileDialog();
            if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _textLabel_path.Text = FBD.FileName;
            }
        }
    }

    public class DataGridViewRolloverCell : DataGridViewTextBoxCell
    {
        protected override void Paint(
            Graphics graphics,
            Rectangle clipBounds,
            Rectangle cellBounds,
            int rowIndex,
            DataGridViewElementStates cellState,
            object value,
            object formattedValue,
            string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            // Call the base class method to paint the default cell appearance.
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState,
                value, formattedValue, errorText, cellStyle,
                advancedBorderStyle, paintParts);

            // Retrieve the client location of the mouse pointer.
            Point cursorPosition =
                this.DataGridView.PointToClient(Cursor.Position);

            // If the mouse pointer is over the current cell, draw a custom border.
            if (cellBounds.Contains(cursorPosition))
            {
                Rectangle newRect = new Rectangle(cellBounds.X + 1,
                    cellBounds.Y + 1, cellBounds.Width - 4,
                    cellBounds.Height - 4);
                graphics.DrawRectangle(Pens.Red, newRect);
            }
        }

        // Force the cell to repaint itself when the mouse pointer enters it.
        protected override void OnMouseEnter(int rowIndex)
        {
            this.DataGridView.InvalidateCell(this);
        }

        // Force the cell to repaint itself when the mouse pointer leaves it.
        protected override void OnMouseLeave(int rowIndex)
        {
            this.DataGridView.InvalidateCell(this);
        }

    }

    public class DataGridViewRolloverCellColumn : DataGridViewColumn
    {
        public DataGridViewRolloverCellColumn()
        {
            this.CellTemplate = new DataGridViewRolloverCell();
        }
    }
}
