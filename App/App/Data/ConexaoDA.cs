using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using App.Model;

namespace App.Data
{
    public class ConexaoDA
    {
        private MySqlConnection _connection;
        private string _connectionString;

        public void Open(ConfiguracaoBE configBE)
        {
            _connectionString = "Server=<<SERVER>>;Database=<<DATABASENAME>>;User ID=<<USERNAME>>;Password=<<PASSWORD>>;Pooling=true;Port=<<PORT>>;Allow User Variables = True;DefaultCommandTimeout=0;convertzerodatetime=true;";
            _connectionString = _connectionString.Replace("<<SERVER>>", configBE.XdServidor);
            _connectionString = _connectionString.Replace("<<PORT>>", configBE.XdPorta);
            _connectionString = _connectionString.Replace("<<DATABASENAME>>", configBE.XdNomeBase);
            _connectionString = _connectionString.Replace("<<USERNAME>>", configBE.XdUsuario);
            _connectionString = _connectionString.Replace("<<PASSWORD>>", configBE.XdSenha);

            _connection = new MySqlConnection(_connectionString);

            try
            {
                _connection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Close()
        {
            try
            {
                _connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ExecuteNonQuery(string sql)
        {
            int retorno = 0;

            try
            {
                //_connection.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = _connection;
                command.CommandText = sql;
                retorno = command.ExecuteNonQuery();

                if (retorno == 1) return true;
                else return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro em ExecuteNonQuery. [" + ex.Message + "]");

                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public MySqlDataReader ExecuteQuery(string sql)
        {
            try
            {
                //_connection.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = _connection;
                command.CommandText = sql;

                MySqlDataReader reader = command.ExecuteReader();
                return reader;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro em ExecuteQuery. [" + ex.Message + "]");
                return null;
            }
        }

    }
}
