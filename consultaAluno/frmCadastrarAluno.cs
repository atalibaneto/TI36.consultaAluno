﻿using System;
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
    public partial class frmCadastrarAluno : Form
    {
        public frmCadastrarAluno()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection (conexao.IniciarCon)) //cria uma nova conexão com o banco
                {
                    cn.Open ();//Abre a conexão com o banco de dados. Sem isso, não é possível executar comandos SQL
                    //Define a consulta SQL que será executada
                    var sql = "INSERT INTO alunos (nomeAluno, dataNascAluno, emailAluno, telefoneAluno, anoAluno)" +
                        "VALUES (@nome, @data, @email, @tel, @ano)";
                    //Cria um objeto SqlCommand que representa o comando SQL a ser executado.
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        //Adiciona os valores dos parâmetros ao comando SQL. Cada parâmetro é associado a um valor obtido dos controles do formulário (txtNome.Text, txtData.Trxt, etc.).
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@data", txtData.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                        cmd.Parameters.AddWithValue("@ano", txtAno.Text);
                        cmd.ExecuteNonQuery(); //Executa o comando SQL no banco de dados.

                        MessageBox.Show("Salvo com sucesso"); //Se o comando SQL for executado com sucesso, uma mensagem é exibida ao usuário.
                    }
                }
            }
            //Se ocorrer algum erro durante a execução do código no bloco try, o controle será passado para o bloco catch.
            catch (Exception ex) // Exception ex: Captura a exceção gerada.
            {
                MessageBox.Show("Dados não salvos.\n\n" + ex.Message);//exibe uma mensagem de erro ao usuário, incluindo a mensagem da exeção (ex. Message).
            }
        }
    }
}
//os blocos try e catch são usados para tratamento de exeções, ou seja, para lidar com os erros que podem ocorrer durante a execução do código.