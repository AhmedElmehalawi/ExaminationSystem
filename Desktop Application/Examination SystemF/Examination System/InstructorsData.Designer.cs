namespace Examination_System
{
    partial class InstructorsData
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
            this.Backbtn = new System.Windows.Forms.Button();
            this.InsDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(1249, 61);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(75, 23);
            this.Backbtn.TabIndex = 4;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // InsDataGrid
            // 
            this.InsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.InsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InsDataGrid.GridColor = System.Drawing.Color.LimeGreen;
            this.InsDataGrid.Location = new System.Drawing.Point(160, 128);
            this.InsDataGrid.Name = "InsDataGrid";
            this.InsDataGrid.RowHeadersWidth = 51;
            this.InsDataGrid.RowTemplate.Height = 24;
            this.InsDataGrid.Size = new System.Drawing.Size(1031, 593);
            this.InsDataGrid.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(151, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(571, 50);
            this.label2.TabIndex = 7;
            this.label2.Text = "Instructors Data From Database";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // InstructorsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InsDataGrid);
            this.Controls.Add(this.Backbtn);
            this.Name = "InstructorsData";
            this.Text = "InstructorsData";
            this.Load += new System.EventHandler(this.InstructorsData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.DataGridView InsDataGrid;
        private System.Windows.Forms.Label label2;
    }
}