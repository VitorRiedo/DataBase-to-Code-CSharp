namespace DataBase_to_Code_CSharp
{
    partial class formPrincipal
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lbHost = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkVisualizarPassword = new System.Windows.Forms.CheckBox();
            this.lbNomeBase = new System.Windows.Forms.Label();
            this.txtNomeBase = new System.Windows.Forms.TextBox();
            this.lbDescStatus = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(89, 175);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(133, 23);
            this.btnConectar.TabIndex = 11;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(89, 45);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(133, 20);
            this.txtHost.TabIndex = 1;
            this.txtHost.Text = "localhost";
            // 
            // lbHost
            // 
            this.lbHost.AutoSize = true;
            this.lbHost.Location = new System.Drawing.Point(14, 48);
            this.lbHost.Name = "lbHost";
            this.lbHost.Size = new System.Drawing.Size(29, 13);
            this.lbHost.TabIndex = 2;
            this.lbHost.Text = "Host";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(14, 74);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(32, 13);
            this.lbPort.TabIndex = 4;
            this.lbPort.Text = "Porta";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(89, 71);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(133, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "5432";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(14, 100);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(43, 13);
            this.lbUser.TabIndex = 6;
            this.lbUser.Text = "Usuário";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(89, 97);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(133, 20);
            this.txtUser.TabIndex = 5;
            this.txtUser.Text = "postgres";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(14, 126);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(38, 13);
            this.lbPassword.TabIndex = 8;
            this.lbPassword.Text = "Senha";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(89, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(133, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // chkVisualizarPassword
            // 
            this.chkVisualizarPassword.AutoSize = true;
            this.chkVisualizarPassword.Location = new System.Drawing.Point(228, 125);
            this.chkVisualizarPassword.Name = "chkVisualizarPassword";
            this.chkVisualizarPassword.Size = new System.Drawing.Size(70, 17);
            this.chkVisualizarPassword.TabIndex = 9;
            this.chkVisualizarPassword.Text = "Visualizar";
            this.chkVisualizarPassword.UseVisualStyleBackColor = true;
            this.chkVisualizarPassword.CheckedChanged += new System.EventHandler(this.chkVisualizarPassword_CheckedChanged);
            // 
            // lbNomeBase
            // 
            this.lbNomeBase.AutoSize = true;
            this.lbNomeBase.Location = new System.Drawing.Point(14, 152);
            this.lbNomeBase.Name = "lbNomeBase";
            this.lbNomeBase.Size = new System.Drawing.Size(69, 13);
            this.lbNomeBase.TabIndex = 11;
            this.lbNomeBase.Text = "Nome Banco";
            // 
            // txtNomeBase
            // 
            this.txtNomeBase.Location = new System.Drawing.Point(89, 149);
            this.txtNomeBase.Name = "txtNomeBase";
            this.txtNomeBase.Size = new System.Drawing.Size(133, 20);
            this.txtNomeBase.TabIndex = 10;
            this.txtNomeBase.Text = "ret_frota";
            // 
            // lbDescStatus
            // 
            this.lbDescStatus.AutoSize = true;
            this.lbDescStatus.Location = new System.Drawing.Point(14, 19);
            this.lbDescStatus.Name = "lbDescStatus";
            this.lbDescStatus.Size = new System.Drawing.Size(88, 13);
            this.lbDescStatus.TabIndex = 12;
            this.lbDescStatus.Text = "Status Conexão: ";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbStatus.Location = new System.Drawing.Point(108, 19);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(77, 13);
            this.lbStatus.TabIndex = 13;
            this.lbStatus.Text = "Desconectado";
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 209);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbDescStatus);
            this.Controls.Add(this.lbNomeBase);
            this.Controls.Add(this.txtNomeBase);
            this.Controls.Add(this.chkVisualizarPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lbHost);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnConectar);
            this.Name = "formPrincipal";
            this.Text = "Configuração";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lbHost;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkVisualizarPassword;
        private System.Windows.Forms.Label lbNomeBase;
        private System.Windows.Forms.TextBox txtNomeBase;
        private System.Windows.Forms.Label lbDescStatus;
        private System.Windows.Forms.Label lbStatus;
    }
}

