namespace Student_Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.reg = new System.Windows.Forms.TextBox();
            this.Phno = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.admission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(76, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT REGISTRATION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9.8F);
            this.label2.Location = new System.Drawing.Point(111, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9.8F);
            this.label3.Location = new System.Drawing.Point(26, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Register number : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 9.8F);
            this.label4.Location = new System.Drawing.Point(43, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone number : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 9.8F);
            this.label5.Location = new System.Drawing.Point(111, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email : ";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(195, 124);
            this.nametxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(222, 26);
            this.nametxt.TabIndex = 5;
            this.nametxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.nametxt.Leave += new System.EventHandler(this.nameValidation);
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(195, 180);
            this.reg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(222, 26);
            this.reg.TabIndex = 6;
            this.reg.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.reg.Leave += new System.EventHandler(this.regValidation);
            // 
            // Phno
            // 
            this.Phno.Location = new System.Drawing.Point(195, 239);
            this.Phno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Phno.Name = "Phno";
            this.Phno.Size = new System.Drawing.Size(222, 26);
            this.Phno.TabIndex = 7;
            this.Phno.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.Phno.Leave += new System.EventHandler(this.phonoValidation);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(195, 300);
            this.email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(222, 26);
            this.email.TabIndex = 8;
            this.email.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.email.Leave += new System.EventHandler(this.EmailValidation);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.Location = new System.Drawing.Point(43, 85);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(19, 25);
            this.error.TabIndex = 9;
            this.error.Text = " ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(211, 490);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // admission
            // 
            this.admission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.admission.Location = new System.Drawing.Point(195, 417);
            this.admission.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.admission.Name = "admission";
            this.admission.Size = new System.Drawing.Size(109, 32);
            this.admission.TabIndex = 11;
            this.admission.Text = "Admission";
            this.admission.UseVisualStyleBackColor = true;
            this.admission.Click += new System.EventHandler(this.admission_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(504, 531);
            this.Controls.Add(this.admission);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Phno);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox reg;
        private System.Windows.Forms.TextBox Phno;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button admission;
    }
}

