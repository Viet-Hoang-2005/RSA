namespace RSA
{
    partial class RSA
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
            this.tbResult = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.tbText = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPhiN = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPrivateKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbN = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPublicKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbQ = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbP = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbCalculate = new Guna.UI2.WinForms.Guna2Button();
            this.btnEncrypt = new Guna.UI2.WinForms.Guna2Button();
            this.btnDecrypt = new Guna.UI2.WinForms.Guna2Button();
            this.btnOpenFileText = new Guna.UI2.WinForms.Guna2Button();
            this.tbNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbGenerate = new Guna.UI2.WinForms.Guna2Button();
            this.tbFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label01 = new System.Windows.Forms.Label();
            this.label03 = new System.Windows.Forms.Label();
            this.label04 = new System.Windows.Forms.Label();
            this.label05 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrivateKey = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbResult
            // 
            this.tbResult.AutoScroll = true;
            this.tbResult.BorderRadius = 10;
            this.tbResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbResult.DefaultText = "";
            this.tbResult.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbResult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbResult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbResult.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbResult.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbResult.ForeColor = System.Drawing.Color.Black;
            this.tbResult.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbResult.Location = new System.Drawing.Point(123, 606);
            this.tbResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.PlaceholderText = "";
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResult.SelectedText = "";
            this.tbResult.Size = new System.Drawing.Size(896, 175);
            this.tbResult.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderThickness = 1;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.LightBlue;
            this.btnSave.Location = new System.Drawing.Point(751, 788);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 47);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save file";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Location = new System.Drawing.Point(888, 788);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 47);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete All";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbText
            // 
            this.tbText.AutoScroll = true;
            this.tbText.BorderRadius = 10;
            this.tbText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbText.DefaultText = "";
            this.tbText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbText.ForeColor = System.Drawing.Color.Black;
            this.tbText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbText.Location = new System.Drawing.Point(123, 377);
            this.tbText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.PlaceholderText = "";
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbText.SelectedText = "";
            this.tbText.Size = new System.Drawing.Size(896, 100);
            this.tbText.TabIndex = 12;
            // 
            // tbPhiN
            // 
            this.tbPhiN.BorderRadius = 10;
            this.tbPhiN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhiN.DefaultText = "";
            this.tbPhiN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPhiN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPhiN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhiN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhiN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhiN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPhiN.ForeColor = System.Drawing.Color.Black;
            this.tbPhiN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhiN.Location = new System.Drawing.Point(123, 286);
            this.tbPhiN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPhiN.Name = "tbPhiN";
            this.tbPhiN.PlaceholderText = "";
            this.tbPhiN.SelectedText = "";
            this.tbPhiN.Size = new System.Drawing.Size(354, 33);
            this.tbPhiN.TabIndex = 13;
            // 
            // tbPrivateKey
            // 
            this.tbPrivateKey.BorderRadius = 10;
            this.tbPrivateKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrivateKey.DefaultText = "";
            this.tbPrivateKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrivateKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrivateKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrivateKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrivateKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrivateKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPrivateKey.ForeColor = System.Drawing.Color.Black;
            this.tbPrivateKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrivateKey.Location = new System.Drawing.Point(665, 286);
            this.tbPrivateKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPrivateKey.Name = "tbPrivateKey";
            this.tbPrivateKey.PlaceholderText = "";
            this.tbPrivateKey.SelectedText = "";
            this.tbPrivateKey.Size = new System.Drawing.Size(354, 33);
            this.tbPrivateKey.TabIndex = 13;
            // 
            // tbN
            // 
            this.tbN.BorderRadius = 10;
            this.tbN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbN.DefaultText = "";
            this.tbN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbN.ForeColor = System.Drawing.Color.Black;
            this.tbN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbN.Location = new System.Drawing.Point(123, 234);
            this.tbN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbN.Name = "tbN";
            this.tbN.PlaceholderText = "";
            this.tbN.SelectedText = "";
            this.tbN.Size = new System.Drawing.Size(354, 33);
            this.tbN.TabIndex = 13;
            // 
            // tbPublicKey
            // 
            this.tbPublicKey.BorderRadius = 10;
            this.tbPublicKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPublicKey.DefaultText = "";
            this.tbPublicKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPublicKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPublicKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPublicKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPublicKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPublicKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPublicKey.ForeColor = System.Drawing.Color.Black;
            this.tbPublicKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPublicKey.Location = new System.Drawing.Point(665, 234);
            this.tbPublicKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPublicKey.Name = "tbPublicKey";
            this.tbPublicKey.PlaceholderText = "";
            this.tbPublicKey.SelectedText = "";
            this.tbPublicKey.Size = new System.Drawing.Size(354, 33);
            this.tbPublicKey.TabIndex = 13;
            // 
            // tbQ
            // 
            this.tbQ.BorderRadius = 10;
            this.tbQ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbQ.DefaultText = "";
            this.tbQ.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbQ.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbQ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQ.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQ.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbQ.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbQ.ForeColor = System.Drawing.Color.Black;
            this.tbQ.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbQ.Location = new System.Drawing.Point(123, 123);
            this.tbQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbQ.Name = "tbQ";
            this.tbQ.PlaceholderText = "";
            this.tbQ.SelectedText = "";
            this.tbQ.Size = new System.Drawing.Size(550, 33);
            this.tbQ.TabIndex = 13;
            this.tbQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQ_KeyPress);
            // 
            // tbP
            // 
            this.tbP.BorderRadius = 10;
            this.tbP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbP.DefaultText = "";
            this.tbP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbP.ForeColor = System.Drawing.Color.Black;
            this.tbP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbP.Location = new System.Drawing.Point(123, 73);
            this.tbP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbP.Name = "tbP";
            this.tbP.PlaceholderText = "";
            this.tbP.SelectedText = "";
            this.tbP.Size = new System.Drawing.Size(550, 33);
            this.tbP.TabIndex = 13;
            this.tbP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbP_KeyPress);
            // 
            // tbCalculate
            // 
            this.tbCalculate.Animated = true;
            this.tbCalculate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.tbCalculate.BorderRadius = 10;
            this.tbCalculate.BorderThickness = 1;
            this.tbCalculate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tbCalculate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tbCalculate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tbCalculate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tbCalculate.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbCalculate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbCalculate.ForeColor = System.Drawing.Color.Black;
            this.tbCalculate.HoverState.FillColor = System.Drawing.Color.LightBlue;
            this.tbCalculate.Location = new System.Drawing.Point(123, 179);
            this.tbCalculate.Name = "tbCalculate";
            this.tbCalculate.Size = new System.Drawing.Size(896, 33);
            this.tbCalculate.TabIndex = 10;
            this.tbCalculate.Text = "Calculate";
            this.tbCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Animated = true;
            this.btnEncrypt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnEncrypt.BorderRadius = 10;
            this.btnEncrypt.BorderThickness = 1;
            this.btnEncrypt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEncrypt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEncrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEncrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEncrypt.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEncrypt.ForeColor = System.Drawing.Color.Black;
            this.btnEncrypt.HoverState.FillColor = System.Drawing.Color.LightBlue;
            this.btnEncrypt.Location = new System.Drawing.Point(123, 484);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(131, 47);
            this.btnEncrypt.TabIndex = 14;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Animated = true;
            this.btnDecrypt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnDecrypt.BorderRadius = 10;
            this.btnDecrypt.BorderThickness = 1;
            this.btnDecrypt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrypt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDecrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDecrypt.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDecrypt.ForeColor = System.Drawing.Color.Black;
            this.btnDecrypt.HoverState.FillColor = System.Drawing.Color.LightBlue;
            this.btnDecrypt.Location = new System.Drawing.Point(270, 484);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(131, 47);
            this.btnDecrypt.TabIndex = 15;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnOpenFileText
            // 
            this.btnOpenFileText.Animated = true;
            this.btnOpenFileText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnOpenFileText.BorderRadius = 10;
            this.btnOpenFileText.BorderThickness = 1;
            this.btnOpenFileText.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFileText.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFileText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenFileText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpenFileText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenFileText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpenFileText.ForeColor = System.Drawing.Color.Black;
            this.btnOpenFileText.HoverState.FillColor = System.Drawing.Color.LightBlue;
            this.btnOpenFileText.Location = new System.Drawing.Point(917, 337);
            this.btnOpenFileText.Name = "btnOpenFileText";
            this.btnOpenFileText.Size = new System.Drawing.Size(102, 33);
            this.btnOpenFileText.TabIndex = 16;
            this.btnOpenFileText.Text = "Open file";
            this.btnOpenFileText.Click += new System.EventHandler(this.tbOpenFileText_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.BorderRadius = 10;
            this.tbNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNumber.DefaultText = "";
            this.tbNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNumber.ForeColor = System.Drawing.Color.Black;
            this.tbNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNumber.Location = new System.Drawing.Point(123, 554);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.PlaceholderText = "";
            this.tbNumber.SelectedText = "";
            this.tbNumber.Size = new System.Drawing.Size(896, 33);
            this.tbNumber.TabIndex = 13;
            // 
            // tbGenerate
            // 
            this.tbGenerate.Animated = true;
            this.tbGenerate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.tbGenerate.BorderRadius = 10;
            this.tbGenerate.BorderThickness = 1;
            this.tbGenerate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tbGenerate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tbGenerate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tbGenerate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tbGenerate.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbGenerate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbGenerate.ForeColor = System.Drawing.Color.Black;
            this.tbGenerate.HoverState.FillColor = System.Drawing.Color.LightBlue;
            this.tbGenerate.Location = new System.Drawing.Point(917, 73);
            this.tbGenerate.Name = "tbGenerate";
            this.tbGenerate.Size = new System.Drawing.Size(102, 83);
            this.tbGenerate.TabIndex = 15;
            this.tbGenerate.Text = "Generate prime number";
            this.tbGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbFrom
            // 
            this.tbFrom.BorderRadius = 5;
            this.tbFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFrom.DefaultText = "";
            this.tbFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbFrom.ForeColor = System.Drawing.Color.Black;
            this.tbFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFrom.Location = new System.Drawing.Point(829, 73);
            this.tbFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.PlaceholderText = "";
            this.tbFrom.SelectedText = "";
            this.tbFrom.Size = new System.Drawing.Size(68, 33);
            this.tbFrom.TabIndex = 13;
            // 
            // tbTo
            // 
            this.tbTo.BorderRadius = 5;
            this.tbTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTo.DefaultText = "";
            this.tbTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbTo.ForeColor = System.Drawing.Color.Black;
            this.tbTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTo.Location = new System.Drawing.Point(829, 123);
            this.tbTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTo.Name = "tbTo";
            this.tbTo.PlaceholderText = "";
            this.tbTo.SelectedText = "";
            this.tbTo.Size = new System.Drawing.Size(68, 33);
            this.tbTo.TabIndex = 13;
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label01.Location = new System.Drawing.Point(536, 21);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(55, 31);
            this.label01.TabIndex = 17;
            this.label01.Text = "RSA";
            // 
            // label03
            // 
            this.label03.AutoSize = true;
            this.label03.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label03.Location = new System.Drawing.Point(58, 73);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(21, 20);
            this.label03.TabIndex = 18;
            this.label03.Text = "p:";
            // 
            // label04
            // 
            this.label04.AutoSize = true;
            this.label04.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label04.Location = new System.Drawing.Point(57, 123);
            this.label04.Name = "label04";
            this.label04.Size = new System.Drawing.Size(21, 20);
            this.label04.TabIndex = 19;
            this.label04.Text = "q:";
            // 
            // label05
            // 
            this.label05.AutoSize = true;
            this.label05.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label05.Location = new System.Drawing.Point(58, 234);
            this.label05.Name = "label05";
            this.label05.Size = new System.Drawing.Size(20, 20);
            this.label05.TabIndex = 20;
            this.label05.Text = "n:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(57, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "phi(n):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(554, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Public key e:";
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.AutoSize = true;
            this.lblPrivateKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrivateKey.Location = new System.Drawing.Point(554, 286);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(96, 20);
            this.lblPrivateKey.TabIndex = 21;
            this.lblPrivateKey.Text = "Private key d:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(58, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Text:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(58, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Num:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(58, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Result:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(764, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "From:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(777, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "To:";
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 857);
            this.Controls.Add(this.lblPrivateKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label05);
            this.Controls.Add(this.label04);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label03);
            this.Controls.Add(this.label01);
            this.Controls.Add(this.btnOpenFileText);
            this.Controls.Add(this.tbGenerate);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.tbPublicKey);
            this.Controls.Add(this.tbPrivateKey);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.tbQ);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.tbPhiN);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.tbCalculate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbResult);
            this.Name = "RSA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA";
            this.Load += new System.EventHandler(this.RSA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbResult;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2TextBox tbText;
        private Guna.UI2.WinForms.Guna2TextBox tbPhiN;
        private Guna.UI2.WinForms.Guna2TextBox tbPrivateKey;
        private Guna.UI2.WinForms.Guna2TextBox tbN;
        private Guna.UI2.WinForms.Guna2TextBox tbPublicKey;
        private Guna.UI2.WinForms.Guna2TextBox tbQ;
        private Guna.UI2.WinForms.Guna2TextBox tbP;
        private Guna.UI2.WinForms.Guna2Button tbCalculate;
        private Guna.UI2.WinForms.Guna2Button btnEncrypt;
        private Guna.UI2.WinForms.Guna2Button btnDecrypt;
        private Guna.UI2.WinForms.Guna2Button btnOpenFileText;
        private Guna.UI2.WinForms.Guna2TextBox tbNumber;
        private Guna.UI2.WinForms.Guna2Button tbGenerate;
        private Guna.UI2.WinForms.Guna2TextBox tbFrom;
        private Guna.UI2.WinForms.Guna2TextBox tbTo;
        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.Label label03;
        private System.Windows.Forms.Label label04;
        private System.Windows.Forms.Label label05;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrivateKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}