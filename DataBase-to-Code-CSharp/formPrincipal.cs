using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_to_Code_CSharp
{
    public partial class formPrincipal : Form
    {
        const string strConectado = "Conectado";
        const string strDesconectado = "Desconectado";

        DbConfig dbConfig = new DbConfig();

        public formPrincipal()
        {
            InitializeComponent();

            MudarStatusLbConexao(StatusConexao.stDesconectado);
        }

        private void chkVisualizarPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkVisualizarPassword.Checked;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if(lbStatus.Text == strDesconectado)
            {
                try
                {
                    ConfigurarConexaoAoBanco();
                    MudarStatusLbConexao(StatusConexao.stConectado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao tentar Conectar com a Base[{txtNomeBase.Text}]: {ex.Message}");
                }
            }
            else
            if (lbStatus.Text == strConectado)
            {
                try
                {

                    MudarStatusLbConexao(StatusConexao.stDesconectado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao tentar Desconectar da Base[{txtNomeBase.Text}]: {ex.Message}");
                }
            }
        }

        private void MudarStatusLbConexao(StatusConexao statusConexao)
        {
            if(statusConexao == StatusConexao.stConectado)
            {
                lbStatus.Text = strConectado;
                lbStatus.ForeColor = Color.Green;
            }
            else
            if(statusConexao == StatusConexao.stDesconectado)
            {
                lbStatus.Text = strDesconectado;
                lbStatus.ForeColor = Color.Red;
            }
        }

        private void ConfigurarConexaoAoBanco()
        {
            dbConfig.host = txtHost.Text;
            dbConfig.port = txtPort.Text;
            dbConfig.user = txtUser.Text;
            dbConfig.password = txtPassword.Text;
            dbConfig.nomeBanco = txtNomeBase.Text;

            var strConexao = dbConfig.getStringConexaoDB;

            using (NpgsqlConnection connection = new NpgsqlConnection(strConexao))
            {
                try
                {
                    connection.Open();
                    connection.Close();
                }
                catch(Exception ex)
                {
                    DesconfigurarConexaoAoBanco();
                    throw ex;
                } 
            }
        }

        private void DesconfigurarConexaoAoBanco()
        {
            dbConfig.host = "";
            dbConfig.port = "";
            dbConfig.user = "";
            dbConfig.password  = "";
            dbConfig.nomeBanco = "";
        }

        private void btnBuscarTabelas_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbConfig.getStringConexaoDB))
                {
                    connection.Open();

                    // Consulta para obter todas as tabelas
                    string query = $"SELECT table_name as \"Tabela\", COUNT(column_name) as \"Nº Colunas\" " +
                                   $"  FROM information_schema.columns " +
                                   $" WHERE table_schema = 'public' " +
                                   $" GROUP BY table_name" +
                                   $" ORDER BY table_name";

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        if (dsPrincipal.Tables.Count > 0)
                        {
                            dsPrincipal.Tables[0].Clear();
                        }

                        adapter.Fill(dsPrincipal);

                        // Vincula o DataSet à DataGridView
                        dataGridPrincipal.DataSource = dsPrincipal.Tables[0];
                        dataGridPrincipal.AutoGenerateColumns = true;
                        dataGridPrincipal.Refresh();

                        dataGridPrincipal.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Buscar Tabelas da Base[{txtNomeBase.Text}]: {ex.Message}");
            }
        }

        private void getColunasTabela(string nomeTabela)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbConfig.getStringConexaoDB))
                {
                    connection.Open();

                    // Consulta para obter informações detalhadas sobre as colunas da tabela específica
                    string query = $"SELECT " +
                                   $"     column_name as \"Nome da Coluna\"" +
                                   $"    ,data_type as \"Tipo de Dados\"" +
                                   //$"    ,is_nullable as \"É Nulo?\"" + 
                                   //$"    ,column_default as \"Valor Padrão\"" +
                                   //$"    ,numeric_precision as \"Precisão Numérica\"" +
                                   //$"    ,numeric_scale as \"Escala Numérica\"" +
                                   //$"    ,ordinal_position as \"Posição\"" +
                                   //$"    ,character_maximum_length as \"Tamanho Máximo\"" +
                                   $"FROM information_schema.columns " +
                                   $"WHERE table_name = '{nomeTabela}' " +
                                   $"ORDER BY column_name";

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        if (dsColunas.Tables.Count > 0)
                        {
                            dsColunas.Tables[0].Clear();
                        }

                        adapter.Fill(dsColunas);

                        // Vincula o DataSet à DataGridView
                        dataGridColunas.DataSource = dsColunas.Tables[0];
                        dataGridColunas.AutoGenerateColumns = true;
                        dataGridColunas.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Buscar Colunas da Tabelas[{nomeTabela}]: {ex.Message}");
            }
        }

        private void dataGridPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridPrincipal.CurrentRow;

            string tableName = selectedRow.Cells[0].Value.ToString();
            getColunasTabela(tableName);
        }
    }

    public class DbConfig
    {
        public string host = "localhost";
        public string port = "5432";
        public string user = "postgres";
        public string password = "";
        public string nomeBanco = "";
        public string ApplicationName = "";

        public string getStringConexaoDB => $"Host={host}; Port={port}; User Id={user}; Password={password}; Database={nomeBanco}; ApplicationName={ApplicationName}";
    }

    enum StatusConexao
    {
        stConectado,
        stDesconectado
    }
}
