namespace Cyberlab
{
    partial class CadastroTI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroTI));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.TxbLogin = new System.Windows.Forms.TextBox();
            this.TxbSenha = new System.Windows.Forms.TextBox();
            this.TxbEmail = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(348, 226);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(177, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(177, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(248, 133);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 3;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(248, 162);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(100, 20);
            this.txbTelefone.TabIndex = 4;
            // 
            // TxbLogin
            // 
            this.TxbLogin.Location = new System.Drawing.Point(248, 74);
            this.TxbLogin.Name = "TxbLogin";
            this.TxbLogin.Size = new System.Drawing.Size(100, 20);
            this.TxbLogin.TabIndex = 5;
            // 
            // TxbSenha
            // 
            this.TxbSenha.Location = new System.Drawing.Point(248, 103);
            this.TxbSenha.Name = "TxbSenha";
            this.TxbSenha.PasswordChar = '*';
            this.TxbSenha.Size = new System.Drawing.Size(100, 20);
            this.TxbSenha.TabIndex = 6;
            // 
            // TxbEmail
            // 
            this.TxbEmail.Location = new System.Drawing.Point(248, 191);
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Size = new System.Drawing.Size(100, 20);
            this.TxbEmail.TabIndex = 7;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.ForeColor = System.Drawing.Color.Cornsilk;
            this.Login.Location = new System.Drawing.Point(177, 81);
            this.Login.Name = "Login";
            this.Login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Login.Size = new System.Drawing.Size(33, 13);
            this.Login.TabIndex = 8;
            this.Login.Text = "Login";
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.BackColor = System.Drawing.Color.Transparent;
            this.Senha.ForeColor = System.Drawing.Color.Cornsilk;
            this.Senha.Location = new System.Drawing.Point(177, 110);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(38, 13);
            this.Senha.TabIndex = 9;
            this.Senha.Text = "Senha";
            this.Senha.Click += new System.EventHandler(this.Senha_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.ForeColor = System.Drawing.Color.Cornsilk;
            this.Email.Location = new System.Drawing.Point(177, 198);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(35, 13);
            this.Email.TabIndex = 10;
            this.Email.Text = "E-mail";
            // 
            // tiBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.TxbEmail);
            this.Controls.Add(this.TxbSenha);
            this.Controls.Add(this.TxbLogin);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tiBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tiBD";
            this.Load += new System.EventHandler(this.tiBD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox TxbLogin;
        private System.Windows.Forms.TextBox TxbSenha;
        private System.Windows.Forms.TextBox TxbEmail;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Label Email;
    }
}