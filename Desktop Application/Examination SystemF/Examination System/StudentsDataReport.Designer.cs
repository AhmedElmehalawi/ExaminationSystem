namespace Examination_System
{
    partial class StudentsDataReport
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
            this.StdDataGrid = new System.Windows.Forms.DataGridView();
            this.Backbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StdDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StdDataGrid
            // 
            this.StdDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.StdDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StdDataGrid.GridColor = System.Drawing.Color.LimeGreen;
            this.StdDataGrid.Location = new System.Drawing.Point(98, 103);
            this.StdDataGrid.Name = "StdDataGrid";
            this.StdDataGrid.RowHeadersWidth = 51;
            this.StdDataGrid.RowTemplate.Height = 24;
            this.StdDataGrid.Size = new System.Drawing.Size(1091, 603);
            this.StdDataGrid.TabIndex = 0;
            this.StdDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(1233, 50);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(75, 23);
            this.Backbtn.TabIndex = 3;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(89, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "Students Data From Database";
            // 
            // StudentsDataReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.StdDataGrid);
            this.Name = "StudentsDataReport";
            this.Text = "StudentsDataReport";
            this.Load += new System.EventHandler(this.StudentsDataReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StdDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StdDataGrid;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label label2;
    }
}