namespace adbGUI.Forms
{
    partial class Density
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
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btn_resetDpi = new System.Windows.Forms.Button();
            this.btn_showDpi = new System.Windows.Forms.Button();
            this.btn_setDpi = new System.Windows.Forms.Button();
            this.txt_phoneDpi = new System.Windows.Forms.TextBox();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btn_resetDpi);
            this.groupBox9.Controls.Add(this.btn_showDpi);
            this.groupBox9.Controls.Add(this.btn_setDpi);
            this.groupBox9.Controls.Add(this.txt_phoneDpi);
            this.groupBox9.Location = new System.Drawing.Point(12, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(349, 49);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Change DPI";
            // 
            // btn_resetDpi
            // 
            this.btn_resetDpi.Location = new System.Drawing.Point(186, 19);
            this.btn_resetDpi.Name = "btn_resetDpi";
            this.btn_resetDpi.Size = new System.Drawing.Size(75, 23);
            this.btn_resetDpi.TabIndex = 31;
            this.btn_resetDpi.Text = "Reset";
            this.btn_resetDpi.UseVisualStyleBackColor = true;
            this.btn_resetDpi.Click += new System.EventHandler(this.Btn_resetDpi_Click);
            // 
            // btn_showDpi
            // 
            this.btn_showDpi.Location = new System.Drawing.Point(267, 19);
            this.btn_showDpi.Name = "btn_showDpi";
            this.btn_showDpi.Size = new System.Drawing.Size(75, 23);
            this.btn_showDpi.TabIndex = 30;
            this.btn_showDpi.Text = "Show current DPI";
            this.btn_showDpi.UseVisualStyleBackColor = true;
            this.btn_showDpi.Click += new System.EventHandler(this.Btn_showDpi_Click);
            // 
            // btn_setDpi
            // 
            this.btn_setDpi.Location = new System.Drawing.Point(105, 19);
            this.btn_setDpi.Name = "btn_setDpi";
            this.btn_setDpi.Size = new System.Drawing.Size(75, 23);
            this.btn_setDpi.TabIndex = 29;
            this.btn_setDpi.Text = "Set";
            this.btn_setDpi.UseVisualStyleBackColor = true;
            this.btn_setDpi.Click += new System.EventHandler(this.Btn_setDpi_Click);
            // 
            // txt_phoneDpi
            // 
            this.txt_phoneDpi.Location = new System.Drawing.Point(6, 21);
            this.txt_phoneDpi.Name = "txt_phoneDpi";
            this.txt_phoneDpi.Size = new System.Drawing.Size(93, 20);
            this.txt_phoneDpi.TabIndex = 28;
            this.txt_phoneDpi.Text = "480";
            // 
            // Density
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 73);
            this.Controls.Add(this.groupBox9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Density";
            this.ShowIcon = false;
            this.Text = "DpiChange";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DpiChange_KeyDown);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btn_resetDpi;
        private System.Windows.Forms.Button btn_showDpi;
        private System.Windows.Forms.Button btn_setDpi;
        private System.Windows.Forms.TextBox txt_phoneDpi;
    }
}