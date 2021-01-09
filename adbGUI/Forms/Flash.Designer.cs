namespace adbGUI.Forms
{
    partial class Flash
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
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_Flash = new System.Windows.Forms.Button();
			this.btn_FlashBrowse = new System.Windows.Forms.Button();
			this.txt_FlashToPartition = new System.Windows.Forms.TextBox();
			this.txt_FlashImageFile = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.groupBox7.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox7
			// 
			this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox7.Controls.Add(this.label1);
			this.groupBox7.Controls.Add(this.label5);
			this.groupBox7.Controls.Add(this.btn_Flash);
			this.groupBox7.Controls.Add(this.btn_FlashBrowse);
			this.groupBox7.Controls.Add(this.txt_FlashToPartition);
			this.groupBox7.Controls.Add(this.txt_FlashImageFile);
			this.groupBox7.Location = new System.Drawing.Point(10, 10);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(503, 97);
			this.groupBox7.TabIndex = 6;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Flash Image";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Image File";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 55);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "To Partition";
			// 
			// btn_Flash
			// 
			this.btn_Flash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Flash.Location = new System.Drawing.Point(346, 68);
			this.btn_Flash.Name = "btn_Flash";
			this.btn_Flash.Size = new System.Drawing.Size(152, 22);
			this.btn_Flash.TabIndex = 4;
			this.btn_Flash.Text = "Flash";
			this.btn_Flash.UseVisualStyleBackColor = true;
			this.btn_Flash.Click += new System.EventHandler(this.Btn_Flash_Click);
			// 
			// btn_FlashBrowse
			// 
			this.btn_FlashBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_FlashBrowse.Location = new System.Drawing.Point(346, 31);
			this.btn_FlashBrowse.Name = "btn_FlashBrowse";
			this.btn_FlashBrowse.Size = new System.Drawing.Size(152, 22);
			this.btn_FlashBrowse.TabIndex = 4;
			this.btn_FlashBrowse.Text = "Browse...";
			this.btn_FlashBrowse.UseVisualStyleBackColor = true;
			this.btn_FlashBrowse.Click += new System.EventHandler(this.Btn_FlashBrowse_Click);
			// 
			// txt_FlashToPartition
			// 
			this.txt_FlashToPartition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_FlashToPartition.Location = new System.Drawing.Point(6, 70);
			this.txt_FlashToPartition.Name = "txt_FlashToPartition";
			this.txt_FlashToPartition.Size = new System.Drawing.Size(333, 20);
			this.txt_FlashToPartition.TabIndex = 5;
			// 
			// txt_FlashImageFile
			// 
			this.txt_FlashImageFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_FlashImageFile.Location = new System.Drawing.Point(6, 32);
			this.txt_FlashImageFile.Name = "txt_FlashImageFile";
			this.txt_FlashImageFile.Size = new System.Drawing.Size(333, 20);
			this.txt_FlashImageFile.TabIndex = 3;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// Flash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(523, 118);
			this.Controls.Add(this.groupBox7);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.MaximizeBox = false;
			this.Name = "Flash";
			this.Text = "Flash";
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_FlashBrowse;
        private System.Windows.Forms.TextBox txt_FlashToPartition;
        private System.Windows.Forms.TextBox txt_FlashImageFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btn_Flash;
    }
}