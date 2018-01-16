namespace App.View
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtXdSenha = new System.Windows.Forms.TextBox();
            this.txtXdUsuario = new System.Windows.Forms.TextBox();
            this.txtXdNomeBase = new System.Windows.Forms.TextBox();
            this.txtXdPorta = new System.Windows.Forms.TextBox();
            this.txtXdServidor = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnTestMysqlConnection = new System.Windows.Forms.Button();
            this.btnSaveConfigs = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTestApiConnection = new System.Windows.Forms.Button();
            this.txtApiToken = new System.Windows.Forms.TextBox();
            this.txtApiUser = new System.Windows.Forms.TextBox();
            this.txtApiUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTestMysqlConnection);
            this.groupBox1.Controls.Add(this.txtXdSenha);
            this.groupBox1.Controls.Add(this.txtXdUsuario);
            this.groupBox1.Controls.Add(this.txtXdNomeBase);
            this.groupBox1.Controls.Add(this.txtXdPorta);
            this.groupBox1.Controls.Add(this.txtXdServidor);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(15, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONEXÃO - MYSQL";
            // 
            // txtXdSenha
            // 
            this.txtXdSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXdSenha.Location = new System.Drawing.Point(106, 151);
            this.txtXdSenha.Name = "txtXdSenha";
            this.txtXdSenha.PasswordChar = '*';
            this.txtXdSenha.Size = new System.Drawing.Size(255, 20);
            this.txtXdSenha.TabIndex = 20;
            // 
            // txtXdUsuario
            // 
            this.txtXdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXdUsuario.Location = new System.Drawing.Point(106, 119);
            this.txtXdUsuario.Name = "txtXdUsuario";
            this.txtXdUsuario.Size = new System.Drawing.Size(255, 20);
            this.txtXdUsuario.TabIndex = 19;
            // 
            // txtXdNomeBase
            // 
            this.txtXdNomeBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXdNomeBase.Location = new System.Drawing.Point(106, 89);
            this.txtXdNomeBase.Name = "txtXdNomeBase";
            this.txtXdNomeBase.Size = new System.Drawing.Size(255, 20);
            this.txtXdNomeBase.TabIndex = 18;
            // 
            // txtXdPorta
            // 
            this.txtXdPorta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXdPorta.Location = new System.Drawing.Point(106, 60);
            this.txtXdPorta.Name = "txtXdPorta";
            this.txtXdPorta.Size = new System.Drawing.Size(255, 20);
            this.txtXdPorta.TabIndex = 17;
            // 
            // txtXdServidor
            // 
            this.txtXdServidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXdServidor.Location = new System.Drawing.Point(106, 31);
            this.txtXdServidor.Name = "txtXdServidor";
            this.txtXdServidor.Size = new System.Drawing.Size(255, 20);
            this.txtXdServidor.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(20, 154);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Senha";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(20, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Usuário";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(20, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Nome da Base";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(20, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Porta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(20, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Servidor";
            // 
            // btnTestMysqlConnection
            // 
            this.btnTestMysqlConnection.Location = new System.Drawing.Point(263, 187);
            this.btnTestMysqlConnection.Name = "btnTestMysqlConnection";
            this.btnTestMysqlConnection.Size = new System.Drawing.Size(98, 23);
            this.btnTestMysqlConnection.TabIndex = 21;
            this.btnTestMysqlConnection.Text = "Testar Conexão";
            this.btnTestMysqlConnection.UseVisualStyleBackColor = true;
            this.btnTestMysqlConnection.Click += new System.EventHandler(this.btnTestMysqlConnection_Click);
            // 
            // btnSaveConfigs
            // 
            this.btnSaveConfigs.Location = new System.Drawing.Point(326, 435);
            this.btnSaveConfigs.Name = "btnSaveConfigs";
            this.btnSaveConfigs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveConfigs.TabIndex = 5;
            this.btnSaveConfigs.Text = "Gravar";
            this.btnSaveConfigs.UseVisualStyleBackColor = true;
            this.btnSaveConfigs.Click += new System.EventHandler(this.btnSaveConfigs_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTestApiConnection);
            this.groupBox2.Controls.Add(this.txtApiToken);
            this.groupBox2.Controls.Add(this.txtApiUser);
            this.groupBox2.Controls.Add(this.txtApiUrl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(15, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 167);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONEXÃO - API";
            // 
            // btnTestApiConnection
            // 
            this.btnTestApiConnection.Location = new System.Drawing.Point(263, 125);
            this.btnTestApiConnection.Name = "btnTestApiConnection";
            this.btnTestApiConnection.Size = new System.Drawing.Size(98, 23);
            this.btnTestApiConnection.TabIndex = 21;
            this.btnTestApiConnection.Text = "Testar Conexão";
            this.btnTestApiConnection.UseVisualStyleBackColor = true;
            this.btnTestApiConnection.Click += new System.EventHandler(this.btnTestApiConnection_Click);
            // 
            // txtApiToken
            // 
            this.txtApiToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApiToken.Location = new System.Drawing.Point(106, 89);
            this.txtApiToken.Name = "txtApiToken";
            this.txtApiToken.Size = new System.Drawing.Size(255, 20);
            this.txtApiToken.TabIndex = 18;
            // 
            // txtApiUser
            // 
            this.txtApiUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApiUser.Location = new System.Drawing.Point(106, 60);
            this.txtApiUser.Name = "txtApiUser";
            this.txtApiUser.Size = new System.Drawing.Size(255, 20);
            this.txtApiUser.TabIndex = 17;
            // 
            // txtApiUrl
            // 
            this.txtApiUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApiUrl.Location = new System.Drawing.Point(106, 31);
            this.txtApiUrl.Name = "txtApiUrl";
            this.txtApiUrl.Size = new System.Drawing.Size(255, 20);
            this.txtApiUrl.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(20, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Token";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(20, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Usuário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(20, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Url";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(423, 498);
            this.tabControlMain.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnSaveConfigs);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(415, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CONEXÃO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 498);
            this.Controls.Add(this.tabControlMain);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INSIDE AUTOMAÇÃO";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtXdSenha;
        private System.Windows.Forms.TextBox txtXdUsuario;
        private System.Windows.Forms.TextBox txtXdNomeBase;
        private System.Windows.Forms.TextBox txtXdPorta;
        private System.Windows.Forms.TextBox txtXdServidor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnTestMysqlConnection;
        private System.Windows.Forms.Button btnSaveConfigs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTestApiConnection;
        private System.Windows.Forms.TextBox txtApiToken;
        private System.Windows.Forms.TextBox txtApiUser;
        private System.Windows.Forms.TextBox txtApiUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
    }
}