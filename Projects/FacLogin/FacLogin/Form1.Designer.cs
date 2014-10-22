namespace FacLogin
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
            this.dept = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.reg = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.desig = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dept
            // 
            this.dept.Location = new System.Drawing.Point(184, 138);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(100, 20);
            this.dept.TabIndex = 0;
            this.dept.TextChanged += new System.EventHandler(this.dept_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(184, 60);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DESIGNATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DEPARTMENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "EMAIL-ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(184, 177);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 9;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(184, 210);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 20);
            this.pass.TabIndex = 10;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(194, 260);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(75, 23);
            this.reg.TabIndex = 11;
            this.reg.Text = "Register";
            this.reg.UseVisualStyleBackColor = true;
            this.reg.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Confirm Password";
            // 
            // pass2
            // 
            this.pass2.Location = new System.Drawing.Point(407, 214);
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(100, 20);
            this.pass2.TabIndex = 13;
            // 
            // desig
            // 
            this.desig.Location = new System.Drawing.Point(184, 96);
            this.desig.Name = "desig";
            this.desig.Size = new System.Drawing.Size(100, 20);
            this.desig.TabIndex = 14;
            this.desig.TextChanged += new System.EventHandler(this.desig_TextChanged);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(167, 19);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(200, 13);
            this.header.TabIndex = 15;
            this.header.Text = "DELHI TECHNOLOGICAL UNIVERSITY";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.desig);
            this.Controls.Add(this.pass2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dept);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dept;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pass2;
        private System.Windows.Forms.TextBox desig;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button button1;
    }
}

