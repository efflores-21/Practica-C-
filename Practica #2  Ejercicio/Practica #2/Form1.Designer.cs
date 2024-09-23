namespace Practica__2
{
    partial class Form1
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
            this.btnFumar = new System.Windows.Forms.Button();
            this.btnNoFumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFumar
            // 
            this.btnFumar.Location = new System.Drawing.Point(11, 12);
            this.btnFumar.Name = "btnFumar";
            this.btnFumar.Size = new System.Drawing.Size(75, 23);
            this.btnFumar.TabIndex = 0;
            this.btnFumar.Text = "Fumar";
            this.btnFumar.UseVisualStyleBackColor = true;
            this.btnFumar.Click += new System.EventHandler(this.btnFumar_Click);
            // 
            // btnNoFumar
            // 
            this.btnNoFumar.Location = new System.Drawing.Point(92, 12);
            this.btnNoFumar.Name = "btnNoFumar";
            this.btnNoFumar.Size = new System.Drawing.Size(75, 23);
            this.btnNoFumar.TabIndex = 1;
            this.btnNoFumar.Text = "NoFumar";
            this.btnNoFumar.UseVisualStyleBackColor = true;
            this.btnNoFumar.Click += new System.EventHandler(this.btnNoFumar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 67);
            this.Controls.Add(this.btnNoFumar);
            this.Controls.Add(this.btnFumar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFumar;
        private System.Windows.Forms.Button btnNoFumar;
    }
}

