namespace adbGUI.Forms
{
    partial class SetProp
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
            this.btn_setProp = new System.Windows.Forms.Button();
            this.txt_setPropKey = new System.Windows.Forms.TextBox();
            this.txt_setPropValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_setProp
            // 
            this.btn_setProp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_setProp.Location = new System.Drawing.Point(503, 23);
            this.btn_setProp.Name = "btn_setProp";
            this.btn_setProp.Size = new System.Drawing.Size(75, 23);
            this.btn_setProp.TabIndex = 0;
            this.btn_setProp.Text = "Set";
            this.btn_setProp.UseVisualStyleBackColor = true;
            this.btn_setProp.Click += new System.EventHandler(this.Btn_setProp_Click);
            // 
            // txt_setPropKey
            // 
            this.txt_setPropKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_setPropKey.Location = new System.Drawing.Point(12, 25);
            this.txt_setPropKey.Name = "txt_setPropKey";
            this.txt_setPropKey.Size = new System.Drawing.Size(356, 20);
            this.txt_setPropKey.TabIndex = 1;
            // 
            // txt_setPropValue
            // 
            this.txt_setPropValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_setPropValue.Location = new System.Drawing.Point(374, 25);
            this.txt_setPropValue.Name = "txt_setPropValue";
            this.txt_setPropValue.Size = new System.Drawing.Size(123, 20);
            this.txt_setPropValue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Value";
            // 
            // SetProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 57);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_setPropValue);
            this.Controls.Add(this.txt_setPropKey);
            this.Controls.Add(this.btn_setProp);
            this.MaximumSize = new System.Drawing.Size(1000, 90);
            this.MinimumSize = new System.Drawing.Size(600, 90);
            this.Name = "SetProp";
            this.ShowInTaskbar = false;
            this.Text = "SetProp";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_setProp;
        private System.Windows.Forms.TextBox txt_setPropKey;
        private System.Windows.Forms.TextBox txt_setPropValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}