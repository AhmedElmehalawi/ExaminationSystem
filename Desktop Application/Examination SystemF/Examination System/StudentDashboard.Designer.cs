namespace Examination_System
{
    partial class StudentDashboard
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
            this.label10 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.RadioButton();
            this.b = new System.Windows.Forms.RadioButton();
            this.c = new System.Windows.Forms.RadioButton();
            this.d = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btu1 = new System.Windows.Forms.Button();
            this.btu2 = new System.Windows.Forms.Button();
            this.btu3 = new System.Windows.Forms.Button();
            this.crsname = new System.Windows.Forms.ComboBox();
            this.mcqcombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tfCombo = new System.Windows.Forms.ComboBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.label10.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(3, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 37);
            this.label10.TabIndex = 1;
            this.label10.Text = "Course Name";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(25, 46);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(35, 22);
            this.a.TabIndex = 11;
            this.a.TabStop = true;
            this.a.Text = "a";
            this.a.UseVisualStyleBackColor = true;
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(25, 99);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(35, 22);
            this.b.TabIndex = 12;
            this.b.TabStop = true;
            this.b.Text = "b";
            this.b.UseVisualStyleBackColor = true;
            this.b.CheckedChanged += new System.EventHandler(this.b_CheckedChanged);
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(25, 144);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(35, 22);
            this.c.TabIndex = 13;
            this.c.TabStop = true;
            this.c.Text = "c";
            this.c.UseVisualStyleBackColor = true;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(25, 193);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(35, 22);
            this.d.TabIndex = 14;
            this.d.TabStop = true;
            this.d.Text = "d";
            this.d.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Examination_System.Properties.Resources._2;
            this.groupBox1.Controls.Add(this.groupBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(18, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 391);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox
            // 
            this.groupBox.BackgroundImage = global::Examination_System.Properties.Resources._21;
            this.groupBox.Controls.Add(this.a);
            this.groupBox.Controls.Add(this.b);
            this.groupBox.Controls.Add(this.d);
            this.groupBox.Controls.Add(this.c);
            this.groupBox.Location = new System.Drawing.Point(0, 135);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(919, 256);
            this.groupBox.TabIndex = 16;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Answers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Questions";
            // 
            // btu1
            // 
            this.btu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.btu1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold);
            this.btu1.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btu1.Location = new System.Drawing.Point(677, 20);
            this.btu1.Name = "btu1";
            this.btu1.Size = new System.Drawing.Size(102, 38);
            this.btu1.TabIndex = 17;
            this.btu1.Text = "Start";
            this.btu1.UseVisualStyleBackColor = false;
            this.btu1.Click += new System.EventHandler(this.btu1_Click);
            // 
            // btu2
            // 
            this.btu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.btu2.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold);
            this.btu2.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btu2.Location = new System.Drawing.Point(635, 546);
            this.btu2.Name = "btu2";
            this.btu2.Size = new System.Drawing.Size(158, 38);
            this.btu2.TabIndex = 18;
            this.btu2.Text = "Next";
            this.btu2.UseVisualStyleBackColor = false;
            this.btu2.Click += new System.EventHandler(this.btu2_Click);
            // 
            // btu3
            // 
            this.btu3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.btu3.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold);
            this.btu3.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btu3.Location = new System.Drawing.Point(87, 548);
            this.btu3.Name = "btu3";
            this.btu3.Size = new System.Drawing.Size(158, 38);
            this.btu3.TabIndex = 19;
            this.btu3.Text = "Previos";
            this.btu3.UseVisualStyleBackColor = false;
            this.btu3.Click += new System.EventHandler(this.btu3_Click);
            // 
            // crsname
            // 
            this.crsname.FormattingEnabled = true;
            this.crsname.Items.AddRange(new object[] {
            "SQL",
            "JavaScript"});
            this.crsname.Location = new System.Drawing.Point(166, 32);
            this.crsname.Name = "crsname";
            this.crsname.Size = new System.Drawing.Size(121, 21);
            this.crsname.TabIndex = 22;
            // 
            // mcqcombo
            // 
            this.mcqcombo.FormattingEnabled = true;
            this.mcqcombo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.mcqcombo.Location = new System.Drawing.Point(307, 32);
            this.mcqcombo.Name = "mcqcombo";
            this.mcqcombo.Size = new System.Drawing.Size(121, 21);
            this.mcqcombo.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label3.Location = new System.Drawing.Point(327, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "MCQ Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label4.Location = new System.Drawing.Point(458, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "TFQ Number";
            // 
            // tfCombo
            // 
            this.tfCombo.FormattingEnabled = true;
            this.tfCombo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.tfCombo.Location = new System.Drawing.Point(447, 32);
            this.tfCombo.Name = "tfCombo";
            this.tfCombo.Size = new System.Drawing.Size(121, 21);
            this.tfCombo.TabIndex = 28;
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.submitbtn.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold);
            this.submitbtn.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.submitbtn.Location = new System.Drawing.Point(390, 548);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(142, 36);
            this.submitbtn.TabIndex = 29;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Examination_System.Properties.Resources.New_Age_On_Screen_Evaluation_Tool_For_Faculty;
            this.ClientSize = new System.Drawing.Size(1028, 651);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.tfCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mcqcombo);
            this.Controls.Add(this.crsname);
            this.Controls.Add(this.btu3);
            this.Controls.Add(this.btu2);
            this.Controls.Add(this.btu1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentDashboard_FormClosing);
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton a;
        private System.Windows.Forms.RadioButton b;
        private System.Windows.Forms.RadioButton c;
        private System.Windows.Forms.RadioButton d;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btu1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btu2;
        private System.Windows.Forms.Button btu3;
        private System.Windows.Forms.ComboBox crsname;
        private System.Windows.Forms.ComboBox mcqcombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tfCombo;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button submitbtn;
    }
}