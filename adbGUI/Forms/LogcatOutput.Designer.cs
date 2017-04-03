namespace adbGUI.Forms
{
    partial class LogcatOutput
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtb_console = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rtb_console);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 367);
            this.panel1.TabIndex = 13;
            // 
            // rtb_console
            // 
            this.rtb_console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_console.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_console.HideSelection = false;
            this.rtb_console.Location = new System.Drawing.Point(0, 0);
            this.rtb_console.Name = "rtb_console";
            this.rtb_console.ReadOnly = true;
            this.rtb_console.Size = new System.Drawing.Size(688, 365);
            this.rtb_console.TabIndex = 11;
            this.rtb_console.Text = "";
            this.rtb_console.WordWrap = false;
            // 
            // LogcatOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 367);
            this.Controls.Add(this.panel1);
            this.Name = "LogcatOutput";
            this.ShowIcon = false;
            this.Text = "LogcatOutput";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogcatOutput_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RichTextBox rtb_console;
    }
}