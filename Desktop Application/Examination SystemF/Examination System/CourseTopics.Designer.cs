namespace Examination_System
{
    partial class CourseTopics
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
            this.CrsTopicGrid = new System.Windows.Forms.DataGridView();
            this.Backbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CrsTopicGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CrsTopicGrid
            // 
            this.CrsTopicGrid.BackgroundColor = System.Drawing.Color.White;
            this.CrsTopicGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CrsTopicGrid.GridColor = System.Drawing.Color.LimeGreen;
            this.CrsTopicGrid.Location = new System.Drawing.Point(39, 93);
            this.CrsTopicGrid.Name = "CrsTopicGrid";
            this.CrsTopicGrid.RowHeadersWidth = 51;
            this.CrsTopicGrid.RowTemplate.Height = 24;
            this.CrsTopicGrid.Size = new System.Drawing.Size(1181, 622);
            this.CrsTopicGrid.TabIndex = 0;
            this.CrsTopicGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CrsTopicGrid_CellContentClick);
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(1269, 52);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(75, 23);
            this.Backbtn.TabIndex = 5;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(40, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(548, 50);
            this.label2.TabIndex = 8;
            this.label2.Text = "Courses Topics From Database";
            // 
            // CourseTopics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.CrsTopicGrid);
            this.Name = "CourseTopics";
            this.Text = "CourseTopics";
            this.Load += new System.EventHandler(this.CourseTopics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CrsTopicGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CrsTopicGrid;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label label2;
    }
}