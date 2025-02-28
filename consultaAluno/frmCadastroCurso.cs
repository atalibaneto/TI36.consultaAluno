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
    public partial class frmCadastroCurso : Form
    {
        public frmCadastroCurso()
        {
            InitializeComponent();
        }

        private void btnSalvarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "INSERT INTO cursos (nomeCurso, descricaoCurso, dataInicioCurso, dataFimCurso, cargaHorariaCurso) VALUES (@nomeC, @descricaoC, @dataIniC, @dataFimC, @cargaH)";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@nomeC", txtNome.Text);
                        cmd.Parameters.AddWithValue("@descricaoC", txtDesc.Text);
                        cmd.Parameters.AddWithValue("@dataIniC", txtInicio.Text);
                        cmd.Parameters.AddWithValue("@dataFimC", txtTermino.Text);
                        cmd.Parameters.AddWithValue("@cargaH", txtCargaHoraria.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Salvo com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Dados não salvos.\n\n" + ex.Message);
            }
        }
    }
}
