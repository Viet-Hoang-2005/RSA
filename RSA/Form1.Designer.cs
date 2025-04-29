namespace RSA
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
            this.label05 = new System.Windows.Forms.Label();
            this.label06 = new System.Windows.Forms.Label();
            this.label07 = new System.Windows.Forms.Label();
            this.label08 = new System.Windows.Forms.Label();
            this.button04 = new System.Windows.Forms.Button();
            this.textBox03 = new System.Windows.Forms.TextBox();
            this.textBox04 = new System.Windows.Forms.TextBox();
            this.textBox05 = new System.Windows.Forms.TextBox();
            this.textBox06 = new System.Windows.Forms.TextBox();
            this.button05 = new System.Windows.Forms.Button();
            this.button03 = new System.Windows.Forms.Button();
            this.button07 = new System.Windows.Forms.Button();
            this.button06 = new System.Windows.Forms.Button();
            this.label03 = new System.Windows.Forms.Label();
            this.label04 = new System.Windows.Forms.Label();
            this.textBox01 = new System.Windows.Forms.TextBox();
            this.textBox02 = new System.Windows.Forms.TextBox();
            this.button02 = new System.Windows.Forms.Button();
            this.label09 = new System.Windows.Forms.Label();
            this.textBox09 = new System.Windows.Forms.TextBox();
            this.label02 = new System.Windows.Forms.Label();
            this.textBox07 = new System.Windows.Forms.TextBox();
            this.button01 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox08 = new System.Windows.Forms.TextBox();
            this.label01 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label05
            // 
            this.label05.AutoSize = true;
            this.label05.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label05.Location = new System.Drawing.Point(36, 183);
            this.label05.Name = "label05";
            this.label05.Size = new System.Drawing.Size(128, 18);
            this.label05.TabIndex = 0;
            this.label05.Text = "Modulus n = p * q:";
            // 
            // label06
            // 
            this.label06.AutoSize = true;
            this.label06.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label06.Location = new System.Drawing.Point(36, 226);
            this.label06.Name = "label06";
            this.label06.Size = new System.Drawing.Size(144, 18);
            this.label06.TabIndex = 0;
            this.label06.Text = "phi(n) = (p - 1)(q - 1):";
            // 
            // label07
            // 
            this.label07.AutoSize = true;
            this.label07.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label07.Location = new System.Drawing.Point(36, 271);
            this.label07.Name = "label07";
            this.label07.Size = new System.Drawing.Size(91, 18);
            this.label07.TabIndex = 0;
            this.label07.Text = "Public key e:";
            // 
            // label08
            // 
            this.label08.AutoSize = true;
            this.label08.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label08.Location = new System.Drawing.Point(36, 312);
            this.label08.Name = "label08";
            this.label08.Size = new System.Drawing.Size(96, 18);
            this.label08.TabIndex = 0;
            this.label08.Text = "Private key d:";
            // 
            // button04
            // 
            this.button04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button04.Location = new System.Drawing.Point(39, 442);
            this.button04.Name = "button04";
            this.button04.Size = new System.Drawing.Size(313, 27);
            this.button04.TabIndex = 1;
            this.button04.Text = "Encrypt";
            this.button04.UseVisualStyleBackColor = true;
            this.button04.Click += new System.EventHandler(this.button04_Click);
            // 
            // textBox03
            // 
            this.textBox03.Location = new System.Drawing.Point(192, 178);
            this.textBox03.Name = "textBox03";
            this.textBox03.Size = new System.Drawing.Size(474, 23);
            this.textBox03.TabIndex = 2;
            // 
            // textBox04
            // 
            this.textBox04.Location = new System.Drawing.Point(192, 221);
            this.textBox04.Name = "textBox04";
            this.textBox04.Size = new System.Drawing.Size(474, 23);
            this.textBox04.TabIndex = 2;
            // 
            // textBox05
            // 
            this.textBox05.Location = new System.Drawing.Point(192, 266);
            this.textBox05.Name = "textBox05";
            this.textBox05.Size = new System.Drawing.Size(474, 23);
            this.textBox05.TabIndex = 2;
            // 
            // textBox06
            // 
            this.textBox06.Location = new System.Drawing.Point(192, 307);
            this.textBox06.Name = "textBox06";
            this.textBox06.Size = new System.Drawing.Size(474, 23);
            this.textBox06.TabIndex = 2;
            // 
            // button05
            // 
            this.button05.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button05.Location = new System.Drawing.Point(379, 442);
            this.button05.Name = "button05";
            this.button05.Size = new System.Drawing.Size(287, 27);
            this.button05.TabIndex = 1;
            this.button05.Text = "Decrypt";
            this.button05.UseVisualStyleBackColor = true;
            this.button05.Click += new System.EventHandler(this.button5_Click);
            // 
            // button03
            // 
            this.button03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button03.Location = new System.Drawing.Point(39, 128);
            this.button03.Name = "button03";
            this.button03.Size = new System.Drawing.Size(627, 27);
            this.button03.TabIndex = 1;
            this.button03.Text = "Calculate";
            this.button03.UseVisualStyleBackColor = true;
            this.button03.Click += new System.EventHandler(this.button03_Click);
            // 
            // button07
            // 
            this.button07.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button07.Location = new System.Drawing.Point(557, 648);
            this.button07.Name = "button07";
            this.button07.Size = new System.Drawing.Size(109, 27);
            this.button07.TabIndex = 1;
            this.button07.Text = "Save";
            this.button07.UseVisualStyleBackColor = true;
            this.button07.Click += new System.EventHandler(this.button07_Click);
            // 
            // button06
            // 
            this.button06.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button06.Location = new System.Drawing.Point(438, 648);
            this.button06.Name = "button06";
            this.button06.Size = new System.Drawing.Size(109, 27);
            this.button06.TabIndex = 1;
            this.button06.Text = "Delete All";
            this.button06.UseVisualStyleBackColor = true;
            this.button06.Click += new System.EventHandler(this.button06_Click);
            // 
            // label03
            // 
            this.label03.AutoSize = true;
            this.label03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label03.Location = new System.Drawing.Point(36, 51);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(20, 18);
            this.label03.TabIndex = 0;
            this.label03.Text = "p:";
            // 
            // label04
            // 
            this.label04.AutoSize = true;
            this.label04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label04.Location = new System.Drawing.Point(36, 88);
            this.label04.Name = "label04";
            this.label04.Size = new System.Drawing.Size(20, 18);
            this.label04.TabIndex = 0;
            this.label04.Text = "q:";
            // 
            // textBox01
            // 
            this.textBox01.Location = new System.Drawing.Point(74, 48);
            this.textBox01.Name = "textBox01";
            this.textBox01.Size = new System.Drawing.Size(473, 23);
            this.textBox01.TabIndex = 2;
            this.textBox01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox02_KeyPress);
            // 
            // textBox02
            // 
            this.textBox02.Location = new System.Drawing.Point(74, 88);
            this.textBox02.Name = "textBox02";
            this.textBox02.Size = new System.Drawing.Size(473, 23);
            this.textBox02.TabIndex = 2;
            this.textBox02.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox03_KeyPress);
            // 
            // button02
            // 
            this.button02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button02.Location = new System.Drawing.Point(581, 48);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(85, 63);
            this.button02.TabIndex = 3;
            this.button02.Text = "Generate prime number";
            this.button02.UseVisualStyleBackColor = true;
            this.button02.Click += new System.EventHandler(this.button02_Click);
            // 
            // label09
            // 
            this.label09.AutoSize = true;
            this.label09.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label09.Location = new System.Drawing.Point(36, 531);
            this.label09.Name = "label09";
            this.label09.Size = new System.Drawing.Size(54, 18);
            this.label09.TabIndex = 5;
            this.label09.Text = "Result:";
            // 
            // textBox09
            // 
            this.textBox09.Location = new System.Drawing.Point(39, 552);
            this.textBox09.Multiline = true;
            this.textBox09.Name = "textBox09";
            this.textBox09.Size = new System.Drawing.Size(627, 90);
            this.textBox09.TabIndex = 4;
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label02.Location = new System.Drawing.Point(36, 359);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(40, 18);
            this.label02.TabIndex = 8;
            this.label02.Text = "Text:";
            // 
            // textBox07
            // 
            this.textBox07.Location = new System.Drawing.Point(39, 382);
            this.textBox07.Multiline = true;
            this.textBox07.Name = "textBox07";
            this.textBox07.Size = new System.Drawing.Size(627, 54);
            this.textBox07.TabIndex = 7;
            // 
            // button01
            // 
            this.button01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button01.Location = new System.Drawing.Point(557, 349);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(109, 27);
            this.button01.TabIndex = 6;
            this.button01.Text = "Open files";
            this.button01.UseVisualStyleBackColor = true;
            this.button01.Click += new System.EventHandler(this.button01_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Number:";
            // 
            // textBox08
            // 
            this.textBox08.Location = new System.Drawing.Point(39, 498);
            this.textBox08.Name = "textBox08";
            this.textBox08.Size = new System.Drawing.Size(627, 23);
            this.textBox08.TabIndex = 9;
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label01.Location = new System.Drawing.Point(327, 9);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(53, 25);
            this.label01.TabIndex = 0;
            this.label01.Text = "RSA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 698);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox08);
            this.Controls.Add(this.label02);
            this.Controls.Add(this.textBox07);
            this.Controls.Add(this.button01);
            this.Controls.Add(this.label09);
            this.Controls.Add(this.textBox09);
            this.Controls.Add(this.button02);
            this.Controls.Add(this.textBox02);
            this.Controls.Add(this.textBox04);
            this.Controls.Add(this.textBox06);
            this.Controls.Add(this.textBox01);
            this.Controls.Add(this.textBox05);
            this.Controls.Add(this.textBox03);
            this.Controls.Add(this.button06);
            this.Controls.Add(this.button05);
            this.Controls.Add(this.button07);
            this.Controls.Add(this.button03);
            this.Controls.Add(this.button04);
            this.Controls.Add(this.label08);
            this.Controls.Add(this.label07);
            this.Controls.Add(this.label06);
            this.Controls.Add(this.label05);
            this.Controls.Add(this.label04);
            this.Controls.Add(this.label03);
            this.Controls.Add(this.label01);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "RSA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label05;
        private System.Windows.Forms.Label label06;
        private System.Windows.Forms.Label label07;
        private System.Windows.Forms.Label label08;
        private System.Windows.Forms.Button button04;
        private System.Windows.Forms.TextBox textBox03;
        private System.Windows.Forms.TextBox textBox04;
        private System.Windows.Forms.TextBox textBox05;
        private System.Windows.Forms.TextBox textBox06;
        private System.Windows.Forms.Button button05;
        private System.Windows.Forms.Button button03;
        private System.Windows.Forms.Button button07;
        private System.Windows.Forms.Button button06;
        private System.Windows.Forms.Label label03;
        private System.Windows.Forms.Label label04;
        private System.Windows.Forms.TextBox textBox01;
        private System.Windows.Forms.TextBox textBox02;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Label label09;
        private System.Windows.Forms.TextBox textBox09;
        private System.Windows.Forms.Label label02;
        private System.Windows.Forms.TextBox textBox07;
        private System.Windows.Forms.Button button01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox08;
        private System.Windows.Forms.Label label01;
    }
}

