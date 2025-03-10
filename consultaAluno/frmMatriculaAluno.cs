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
    public partial class frmMatriculaAluno: Form
    {
        public class ComboboxItem
        {
            public string Text { get; set; } //Armazena o texto visível do ítem no Combobox
            public object Value { get; set; } //Armazena um valor associado ao item
            public override string ToString() //Retorna a propriedade Text quando o objeto é convertido para string.
                                              //Isso faz com que o texto correto seja exibido no Combobox automaticamente.
            {
                return Text;
            }
        }
        private string connectionString = conexao.IniciarCon;
        public frmMatriculaAluno()
        {
            InitializeComponent();
            CarregarAluno();
            CarregarCursos();
            CarregarUnidades();
        }
        private void CarregarAluno()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT idAluno, nomeAluno FROM alunos", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbAlunos.Items.Add(new ComboboxItem
                    {
                        Text = reader["nomeAluno"].ToString(),
                        Value = reader["idAluno"]
                    });
                }
            }
        }
        private void CarregarCursos()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT idCurso, nomeCurso FROM cursos", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbCursos.Items.Add(new ComboboxItem
                    {
                        Text = reader["nomeCurso"].ToString(),
                        Value = reader["idCurso"]
                    });
                }
            }
        }
        private void CarregarUnidades()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT idUnidade, nomeUnidade FROM unidades", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbUnidade.Items.Add(new ComboboxItem
                    {
                        Text = reader["nomeUnidade"].ToString(),
                        Value = reader["idUnidade"]
                    });
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbAlunos.SelectedItem == null || cmbCursos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um aluno e um curso.");
                return;
            }
            int idAluno = (int)(cmbAlunos.SelectedItem as ComboboxItem).Value;
            int idCurso = (int)(cmbCursos.SelectedItem as ComboboxItem).Value;
            DateTime dataMatricula = dtpDataMatricula.Value;
            string statusMatricula = cmbStatusMatricula.SelectedItem.ToString();
            int idUnidade = (int)(cmbUnidade.SelectedItem as ComboboxItem).Value;

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO matriculas (idAluno, idCurso, dataMatricula, statusMatricula, idUnidade)" +
                                                "VALUES (@idAluno, @idCurso, @dataMatricula, @statusMatricula, @idUnid)", cn);
                cmd.Parameters.AddWithValue("@idAluno", idAluno);
                cmd.Parameters.AddWithValue("@idCurso", idCurso);
                cmd.Parameters.AddWithValue("@dataMatricula", dataMatricula);
                cmd.Parameters.AddWithValue("@statusMatricula", statusMatricula);
                cmd.Parameters.AddWithValue("@idUnid", idUnidade);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Matrícula realizada com sucesso!");
        }

    }
}
