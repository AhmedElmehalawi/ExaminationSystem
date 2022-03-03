namespace Examination_System
{
    partial class StdExamResult
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
            this.StdExamResGrid = new System.Windows.Forms.DataGridView();
            this.Backbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StdExamResGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StdExamResGrid
            // 
            this.StdExamResGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.StdExamResGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StdExamResGrid.GridColor = System.Drawing.Color.LimeGreen;
            this.StdExamResGrid.Location = new System.Drawing.Point(99, 108);
            this.StdExamResGrid.Name = "StdExamResGrid";
            this.StdExamResGrid.RowHeadersWidth = 51;
            this.StdExamResGrid.RowTemplate.Height = 24;
            this.StdExamResGrid.Size = new System.Drawing.Size(1139, 605);
            this.StdExamResGrid.TabIndex = 1;
            this.StdExamResGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StdExamResGrid_CellContentClick);
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(1245, 51);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(75, 23);
            this.Backbtn.TabIndex = 2;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(90, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Students Results";
            // 
            // StdExamResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.StdExamResGrid);
            this.Name = "StdExamResult";
            this.Text = "StdExamResult";
            this.Load += new System.EventHandler(this.StdExamResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StdExamResGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StdExamResGrid;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label label1;
    }
}