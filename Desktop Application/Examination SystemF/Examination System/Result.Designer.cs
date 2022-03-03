namespace Examination_System
{
    partial class Result
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
            this.resLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalbtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            this.resLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.resLabel.Location = new System.Drawing.Point(167, 230);
            this.resLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(32, 24);
            this.resLabel.TabIndex = 2;
            this.resLabel.Text = "10";
            this.resLabel.Click += new System.EventHandler(this.resLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(221, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "from ";
            // 
            // totalbtn
            // 
            this.totalbtn.AutoSize = true;
            this.totalbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            this.totalbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.totalbtn.Location = new System.Drawing.Point(290, 230);
            this.totalbtn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalbtn.Name = "totalbtn";
            this.totalbtn.Size = new System.Drawing.Size(32, 24);
            this.totalbtn.TabIndex = 4;
            this.totalbtn.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(82, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Result is";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(16, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Score = ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Examination_System.Properties.Resources.result;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.totalbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}