namespace Mimir
{
    partial class Instructions
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
            this.lbl_version.Location = new System.Drawing.Point(78, 401);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(13, 13);
            this.lbl_version.TabIndex = 7;
            this.lbl_version.Text = "v";
            this.lbl_version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Version";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(476, 387);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(97, 40);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "&Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // rchtxbx_instructions
            // 
            this.rchtxbx_instructions.BackColor = System.Drawing.Color.White;
            this.rchtxbx_instructions.Location = new System.Drawing.Point(12, 12);
            this.rchtxbx_instructions.Name = "rchtxbx_instructions";
            this.rchtxbx_instructions.ReadOnly = true;
            this.rchtxbx_instructions.Size = new System.Drawing.Size(562, 369);
            this.rchtxbx_instructions.TabIndex = 4;
            this.rchtxbx_instructions.Text = "";
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 440);
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

        #endregion

        private System.Windows.Forms.RichTextBox rchtxbx_instructions;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_version;
    }
}