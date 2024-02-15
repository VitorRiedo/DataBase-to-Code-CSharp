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
                    TestarConexao();
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

        private void TestarConexao()
        {
            DbConfig dbConfig = new DbConfig(); 

            dbConfig.host =txtHost.Text;
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
                    throw ex;
                } 
            }
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
