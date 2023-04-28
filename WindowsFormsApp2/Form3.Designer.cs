namespace WindowsFormsApp2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.First = new System.Windows.Forms.Button();
            this.Sec = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Sixth = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Third = new System.Windows.Forms.Button();
            this.Sev = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Teal;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(-7, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(326, 32);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Cyan;
            this.button4.Location = new System.Drawing.Point(319, -2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "_";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Cyan;
            this.button3.Location = new System.Drawing.Point(345, -2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "%Percent Calculator%";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // First
            // 
            this.First.BackColor = System.Drawing.SystemColors.Control;
            this.First.Cursor = System.Windows.Forms.Cursors.Hand;
            this.First.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.First.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First.Location = new System.Drawing.Point(26, 86);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(142, 40);
            this.First.TabIndex = 12;
            this.First.Text = "button1";
            this.First.UseVisualStyleBackColor = false;
            // 
            // Sec
            // 
            this.Sec.BackColor = System.Drawing.SystemColors.Control;
            this.Sec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sec.Location = new System.Drawing.Point(212, 86);
            this.Sec.Name = "Sec";
            this.Sec.Size = new System.Drawing.Size(142, 40);
            this.Sec.TabIndex = 13;
            this.Sec.Text = "button2";
            this.Sec.UseVisualStyleBackColor = false;
            // 
            // Four
            // 
            this.Four.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Four.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Four.Location = new System.Drawing.Point(26, 132);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(142, 40);
            this.Four.TabIndex = 14;
            this.Four.Text = "button5";
            this.Four.UseVisualStyleBackColor = true;
            // 
            // Sixth
            // 
            this.Sixth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sixth.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sixth.Location = new System.Drawing.Point(26, 178);
            this.Sixth.Name = "Sixth";
            this.Sixth.Size = new System.Drawing.Size(142, 40);
            this.Sixth.TabIndex = 15;
            this.Sixth.Text = "button6";
            this.Sixth.UseVisualStyleBackColor = true;
            // 
            // Five
            // 
            this.Five.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Five.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Five.Location = new System.Drawing.Point(212, 132);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(142, 40);
            this.Five.TabIndex = 16;
            this.Five.Text = "button7";
            this.Five.UseVisualStyleBackColor = true;
            // 
            // Third
            // 
            this.Third.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Third.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Third.Location = new System.Drawing.Point(212, 178);
            this.Third.Name = "Third";
            this.Third.Size = new System.Drawing.Size(142, 40);
            this.Third.TabIndex = 17;
            this.Third.Text = "button8";
            this.Third.UseVisualStyleBackColor = true;
            // 
            // Sev
            // 
            this.Sev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sev.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sev.Location = new System.Drawing.Point(110, 224);
            this.Sev.Name = "Sev";
            this.Sev.Size = new System.Drawing.Size(162, 40);
            this.Sev.TabIndex = 18;
            this.Sev.Text = "button9";
            this.Sev.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Azure;
            this.radioButton1.Location = new System.Drawing.Point(58, 289);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 23);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "English";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.Azure;
            this.radioButton2.Location = new System.Drawing.Point(244, 289);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 23);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ukrainian";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Azure;
            this.label10.Location = new System.Drawing.Point(20, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 22);
            this.label10.TabIndex = 21;
            this.label10.Text = ".";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(375, 327);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Sev);
            this.Controls.Add(this.Third);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Sixth);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Sec);
            this.Controls.Add(this.First);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button First;
        private System.Windows.Forms.Button Sec;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Sixth;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Third;
        private System.Windows.Forms.Button Sev;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label10;
    }
}