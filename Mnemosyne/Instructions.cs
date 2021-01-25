using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using CryptoStuffNamespace;

namespace Mnemosyne
{
    public partial class Instructions : Form
    {
        private Label lbl_version;
        private Label label1;
        private Button btn_close;
        private RichTextBox rchtxbx_instructions;

        // Get the password.
        string Password = "password";


        public Instructions()
        {
            InitializeComponent();

            //if (File.Exists("instructions.rtf"))
            //{
            //    //rchtxbx_instructions.Text = File.ReadAllText("instructions.txt");

            //    rchtxbx_instructions.LoadFile("instructions.rtf");
            //}
            //else
            //{
            //    rchtxbx_instructions.Text = "Files called instructions.rtf is missing.";
            //}




            if (File.Exists("Notes.dat"))
            {
                try
                {
                    rchtxbx_instructions.Rtf = File.ReadAllBytes("Notes.dat").Decrypt(Password);
                }
                catch
                {
                    MessageBox.Show("Invalid password");
                    Close();
                    return;
                }
            }


            lbl_version.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.lbl_version = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.rchtxbx_instructions = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(77, 400);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(13, 13);
            this.lbl_version.TabIndex = 11;
            this.lbl_version.Text = "v";
            this.lbl_version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Version";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(475, 386);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(97, 40);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "&Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // rchtxbx_instructions
            // 
            this.rchtxbx_instructions.BackColor = System.Drawing.Color.White;
            this.rchtxbx_instructions.Location = new System.Drawing.Point(11, 11);
            this.rchtxbx_instructions.Name = "rchtxbx_instructions";
            this.rchtxbx_instructions.ReadOnly = true;
            this.rchtxbx_instructions.Size = new System.Drawing.Size(562, 369);
            this.rchtxbx_instructions.TabIndex = 8;
            this.rchtxbx_instructions.Text = "";
            // 
            // Instructions
            // 
            this.ClientSize = new System.Drawing.Size(588, 439);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.rchtxbx_instructions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Instructions";
            this.Text = "Instructions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Instructions_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Instructions_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllBytes("Notes.dat", rchtxbx_instructions.Rtf.Encrypt(Password));
        }

        
       

    }
}
