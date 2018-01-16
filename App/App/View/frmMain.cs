using App.Common;
using App.Data;
using App.Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace App.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// EVENTO chamado ao abrir a aplicação        
        /// </summary>        
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadMysqlFields();
        }

        private void LoadMysqlFields()
        {
            txtXdServidor.Text = Program.ConfigBE.XdServidor;
            txtXdPorta.Text = Program.ConfigBE.XdPorta;
            txtXdNomeBase.Text = Program.ConfigBE.XdNomeBase;
            txtXdUsuario.Text = Program.ConfigBE.XdUsuario;
            txtXdSenha.Text = Program.ConfigBE.XdSenha;

            txtApiUrl.Text = Program.ConfigBE.ApiUrl;
            txtApiUser.Text = Program.ConfigBE.ApiUser;
            txtApiToken.Text = Program.ConfigBE.ApiToken;
        }

        private void btnSaveConfigs_Click(object sender, EventArgs e)
        {
            SaveConfigs();
        }

        /// <summary>
        /// Carrega as configurações na variável global e grava no arquivo Config.xml
        /// </summary>
        private void SaveConfigs()
        {
            Program.ConfigBE.XdServidor = txtXdServidor.Text;
            Program.ConfigBE.XdPorta = txtXdPorta.Text;
            Program.ConfigBE.XdNomeBase = txtXdNomeBase.Text;
            Program.ConfigBE.XdUsuario = txtXdUsuario.Text;
            Program.ConfigBE.XdSenha = txtXdSenha.Text;

            Program.ConfigBE.ApiUrl = txtApiUrl.Text;
            Program.ConfigBE.ApiUser = txtApiUser.Text;
            Program.ConfigBE.ApiToken = txtApiToken.Text;

            Serialize.SerializeToXmlUft8<ConfiguracaoBE>(Constants.CONFIG_FILE_NAME, Program.ConfigBE);
        }

        private void btnTestMysqlConnection_Click(object sender, EventArgs e)
        {
            try
            {
                SaveConfigs();

                var con = new ConexaoDA();
                con.Open(Program.ConfigBE);

                MessageBox.Show("CONEXÃO MYSQL: realizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler base de dados MYSQL. [" + ex.Message + "]", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTestApiConnection_Click(object sender, EventArgs e)
        {
            try
            {
                SaveConfigs();

                var html = WebApi.ExecutarResquisicaoGET(Constants.API_FUNCTION_TEST_CONNECTION);

                if (html.Equals("SUCESSO"))
                    MessageBox.Show("CONEXÃO API: realizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                else
                    MessageBox.Show("CONEXÃO API: não foi possível conexão. [" + html + "]", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao chamar API MYSQL. [" + ex.Message + "]", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
