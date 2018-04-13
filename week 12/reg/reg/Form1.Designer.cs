namespace reg
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.email1 = new System.Windows.Forms.TextBox();
            this.pass1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email2 = new System.Windows.Forms.TextBox();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Label();
            this.wrong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // email1
            // 
            this.email1.Location = new System.Drawing.Point(149, 98);
            this.email1.Name = "email1";
            this.email1.Size = new System.Drawing.Size(334, 31);
            this.email1.TabIndex = 1;
            this.email1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pass1
            // 
            this.pass1.Location = new System.Drawing.Point(149, 159);
            this.pass1.Name = "pass1";
            this.pass1.Size = new System.Drawing.Size(334, 31);
            this.pass1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Auth";
            // 
            // email2
            // 
            this.email2.Location = new System.Drawing.Point(149, 332);
            this.email2.Name = "email2";
            this.email2.Size = new System.Drawing.Size(334, 31);
            this.email2.TabIndex = 4;
            // 
            // pass2
            // 
            this.pass2.Location = new System.Drawing.Point(149, 398);
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(334, 31);
            this.pass2.TabIndex = 5;
            // 
            // ok
            // 
            this.ok.AutoSize = true;
            this.ok.Location = new System.Drawing.Point(144, 491);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(42, 25);
            this.ok.TabIndex = 6;
            this.ok.Text = "OK";
            this.ok.Visible = false;
            // 
            // wrong
            // 
            this.wrong.AutoSize = true;
            this.wrong.Location = new System.Drawing.Point(408, 491);
            this.wrong.Name = "wrong";
            this.wrong.Size = new System.Drawing.Size(75, 25);
            this.wrong.TabIndex = 7;
            this.wrong.Text = "Wrong";
            this.wrong.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Email";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 163);
            this.button1.TabIndex = 12;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 165);
            this.button2.TabIndex = 13;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 574);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wrong);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.pass2);
            this.Controls.Add(this.email2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.email1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email1;
        private System.Windows.Forms.TextBox pass1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email2;
        private System.Windows.Forms.TextBox pass2;
        private System.Windows.Forms.Label ok;
        private System.Windows.Forms.Label wrong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

