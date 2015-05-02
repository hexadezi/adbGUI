namespace adbGUI
{
      partial class Viewer
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
                  System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewer));
                  this.txt_output = new System.Windows.Forms.TextBox();
                  this.button1 = new System.Windows.Forms.Button();
                  this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
                  this.SuspendLayout();
                  // 
                  // txt_output
                  // 
                  this.txt_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                  this.txt_output.BackColor = System.Drawing.Color.White;
                  this.txt_output.BorderStyle = System.Windows.Forms.BorderStyle.None;
                  this.txt_output.Cursor = System.Windows.Forms.Cursors.IBeam;
                  this.txt_output.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.txt_output.Location = new System.Drawing.Point(0, -1);
                  this.txt_output.Multiline = true;
                  this.txt_output.Name = "txt_output";
                  this.txt_output.ReadOnly = true;
                  this.txt_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                  this.txt_output.Size = new System.Drawing.Size(841, 550);
                  this.txt_output.TabIndex = 0;
                  // 
                  // button1
                  // 
                  this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
                  this.button1.Location = new System.Drawing.Point(0, 548);
                  this.button1.Name = "button1";
                  this.button1.Size = new System.Drawing.Size(842, 21);
                  this.button1.TabIndex = 1;
                  this.button1.Text = "Save to";
                  this.button1.UseVisualStyleBackColor = true;
                  this.button1.Click += new System.EventHandler(this.button1_Click);
                  // 
                  // Viewer
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(842, 569);
                  this.Controls.Add(this.button1);
                  this.Controls.Add(this.txt_output);
                  this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                  this.Name = "Viewer";
                  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                  this.Text = "Output Viewer";
                  this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Viewer_FormClosing);
                  this.ResumeLayout(false);
                  this.PerformLayout();

            }

            #endregion

            public System.Windows.Forms.TextBox txt_output;
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.SaveFileDialog saveFileDialog1;

      }
}