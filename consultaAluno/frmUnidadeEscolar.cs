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
    public partial class frmUnidadeEscolar: Form
    {
        public frmUnidadeEscolar()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "INSERT INTO unidades (nomeUnidade) VALUES (@nomeUnid)";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@nomeUnid", txtUnidadeEscolar.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Salvo com Sucesso!");

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
