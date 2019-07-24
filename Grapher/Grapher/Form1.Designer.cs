namespace Grapher
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.FunctionTB = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Accuracy = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Zoom = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Angle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(119, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 357);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FunctionTB
            // 
            this.FunctionTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FunctionTB.Location = new System.Drawing.Point(244, 13);
            this.FunctionTB.Name = "FunctionTB";
            this.FunctionTB.Size = new System.Drawing.Size(134, 26);
            this.FunctionTB.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(212, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(26, 19);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "z = ";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox3.Location = new System.Drawing.Point(25, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(88, 19);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Accuracy";
            // 
            // Accuracy
            // 
            this.Accuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Accuracy.Location = new System.Drawing.Point(13, 134);
            this.Accuracy.Name = "Accuracy";
            this.Accuracy.Size = new System.Drawing.Size(100, 26);
            this.Accuracy.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox5.Location = new System.Drawing.Point(25, 191);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(74, 19);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Zoom";
            // 
            // Zoom
            // 
            this.Zoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Zoom.Location = new System.Drawing.Point(13, 216);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(100, 26);
            this.Zoom.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox4.Location = new System.Drawing.Point(25, 278);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(86, 19);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Angle (rad)";
            // 
            // Angle
            // 
            this.Angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Angle.Location = new System.Drawing.Point(13, 303);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(100, 26);
            this.Angle.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(734, 451);
            this.Controls.Add(this.Angle);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Zoom);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Accuracy);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.FunctionTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FunctionTB;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox Accuracy;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox Zoom;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox Angle;
    }
}

