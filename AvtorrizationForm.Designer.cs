
namespace ProizvodstvennayaPrakrtika
{
    partial class AvtorrizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvtorrizationForm));
            this.ExitPicture = new System.Windows.Forms.PictureBox();
            this.AvtorizationButton = new Guna.UI2.WinForms.Guna2Button();
            this.MainRegisterPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.HedaerPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.FunctionPanel = new System.Windows.Forms.Panel();
            this.ChangeFormOnRegistration = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPicture)).BeginInit();
            this.MainRegisterPanel.SuspendLayout();
            this.HedaerPanel.SuspendLayout();
            this.FunctionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitPicture
            // 
            this.ExitPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitPicture.Image = ((System.Drawing.Image)(resources.GetObject("ExitPicture.Image")));
            this.ExitPicture.Location = new System.Drawing.Point(772, 0);
            this.ExitPicture.Name = "ExitPicture";
            this.ExitPicture.Size = new System.Drawing.Size(28, 26);
            this.ExitPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitPicture.TabIndex = 9;
            this.ExitPicture.TabStop = false;
            this.ExitPicture.Click += new System.EventHandler(this.ExitPicture_Click);
            // 
            // AvtorizationButton
            // 
            this.AvtorizationButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AvtorizationButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AvtorizationButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AvtorizationButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AvtorizationButton.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.AvtorizationButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvtorizationButton.ForeColor = System.Drawing.Color.White;
            this.AvtorizationButton.Location = new System.Drawing.Point(311, 309);
            this.AvtorizationButton.Name = "AvtorizationButton";
            this.AvtorizationButton.Size = new System.Drawing.Size(180, 45);
            this.AvtorizationButton.TabIndex = 3;
            this.AvtorizationButton.Text = "Авторизоваться";
            this.AvtorizationButton.Click += new System.EventHandler(this.AvtorizationButton_Click);
            // 
            // MainRegisterPanel
            // 
            this.MainRegisterPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainRegisterPanel.Controls.Add(this.HedaerPanel);
            this.MainRegisterPanel.Controls.Add(this.FunctionPanel);
            this.MainRegisterPanel.Controls.Add(this.ChangeFormOnRegistration);
            this.MainRegisterPanel.Controls.Add(this.passwordLabel);
            this.MainRegisterPanel.Controls.Add(this.LoginLabel);
            this.MainRegisterPanel.Controls.Add(this.PasswordTextBox);
            this.MainRegisterPanel.Controls.Add(this.LoginTextBox);
            this.MainRegisterPanel.Controls.Add(this.AvtorizationButton);
            this.MainRegisterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainRegisterPanel.FillColor = System.Drawing.Color.White;
            this.MainRegisterPanel.Location = new System.Drawing.Point(0, 0);
            this.MainRegisterPanel.Name = "MainRegisterPanel";
            this.MainRegisterPanel.ShadowColor = System.Drawing.Color.Black;
            this.MainRegisterPanel.Size = new System.Drawing.Size(800, 450);
            this.MainRegisterPanel.TabIndex = 4;
            this.MainRegisterPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainRegisterPanel_MouseMove);
            // 
            // HedaerPanel
            // 
            this.HedaerPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.HedaerPanel.Controls.Add(this.HeaderLabel);
            this.HedaerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HedaerPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HedaerPanel.Location = new System.Drawing.Point(0, 27);
            this.HedaerPanel.Name = "HedaerPanel";
            this.HedaerPanel.Size = new System.Drawing.Size(800, 81);
            this.HedaerPanel.TabIndex = 11;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderLabel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(800, 81);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Авторизация";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HeaderLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderLabel_MouseMove_1);
            // 
            // FunctionPanel
            // 
            this.FunctionPanel.Controls.Add(this.ExitPicture);
            this.FunctionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FunctionPanel.Location = new System.Drawing.Point(0, 0);
            this.FunctionPanel.Name = "FunctionPanel";
            this.FunctionPanel.Size = new System.Drawing.Size(800, 27);
            this.FunctionPanel.TabIndex = 10;
            this.FunctionPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FunctionPanel_MouseMove);
            // 
            // ChangeFormOnRegistration
            // 
            this.ChangeFormOnRegistration.AutoSize = true;
            this.ChangeFormOnRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeFormOnRegistration.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeFormOnRegistration.Location = new System.Drawing.Point(337, 359);
            this.ChangeFormOnRegistration.Name = "ChangeFormOnRegistration";
            this.ChangeFormOnRegistration.Size = new System.Drawing.Size(132, 18);
            this.ChangeFormOnRegistration.TabIndex = 8;
            this.ChangeFormOnRegistration.Text = "У меня нет аккаунта";
            this.ChangeFormOnRegistration.Click += new System.EventHandler(this.ChangeFormOnRegistration_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(279, 239);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(103, 18);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Введите пароль";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(279, 159);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(95, 18);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "Введите логин";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(267, 250);
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(274, 36);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextBox_KeyPress);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.Location = new System.Drawing.Point(267, 171);
            this.LoginTextBox.Multiline = true;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(274, 36);
            this.LoginTextBox.TabIndex = 4;
            this.LoginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginTextBox_KeyPress);
            // 
            // AvtorrizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainRegisterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AvtorrizationForm";
            this.Text = "AvtorrizationForm";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AvtorrizationForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.ExitPicture)).EndInit();
            this.MainRegisterPanel.ResumeLayout(false);
            this.MainRegisterPanel.PerformLayout();
            this.HedaerPanel.ResumeLayout(false);
            this.FunctionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button AvtorizationButton;
        private Guna.UI2.WinForms.Guna2ShadowPanel MainRegisterPanel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label ChangeFormOnRegistration;
        private System.Windows.Forms.PictureBox ExitPicture;
        private System.Windows.Forms.Panel HedaerPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Panel FunctionPanel;
    }
}