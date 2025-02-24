using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consultaAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    //MessageBox.Show("Conectado ao Banco de Dados");
                    var sqlQuery = "SELECT * FROM alunos"; //sqlQuery armazena a consulta SQL que será executada
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    //SqlDataAdapter é uma classe usada para preencher o DataTable com dados do banco
                    //sqlQuery - consulta SQL que será executada
                    //cn - é a conexão com o banco
                    {
                        using (DataTable dt = new DataTable())
                        /*DataTable dt = new DataTable() - cria uma instância de DataTable que é uma
                         * tabela em memória para armazenar os dados recuperados do banco*/
                        {
                            da.Fill(dt); /*Método Fill do SqlDataAdapter executa a consultaSQL (sqlQuery)
                            e preenche a DataTable (dt) com resultados da consulta*/
                            dataGridView1.DataSource = dt;
                            //faz com que os dados dos alunos sejam exibidos no dataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar\n\n"+ ex.Message);
            }
        }
    }
}
