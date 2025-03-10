namespace consultaAluno
{
    partial class frmBuscarAluno
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAddCurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarAluno = new System.Windows.Forms.TextBox();
            this.btnBuscarAluno = new System.Windows.Forms.Button();
            this.btnAtualizarAluno = new System.Windows.Forms.Button();
            this.btnMatricularAluno = new System.Windows.Forms.Button();
            this.btnAddUnidade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Consultar todos alunos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 333);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(670, 453);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(118, 38);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar Aluno";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAddCurso
            // 
            this.btnAddCurso.Location = new System.Drawing.Point(670, 497);
            this.btnAddCurso.Name = "btnAddCurso";
            this.btnAddCurso.Size = new System.Drawing.Size(118, 38);
            this.btnAddCurso.TabIndex = 3;
            this.btnAddCurso.Text = "Adicionar curso";
            this.btnAddCurso.UseVisualStyleBackColor = true;
            this.btnAddCurso.Click += new System.EventHandler(this.btnAddCurso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aluno:";
            // 
            // txtBuscarAluno
            // 
            this.txtBuscarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarAluno.Location = new System.Drawing.Point(89, 60);
            this.txtBuscarAluno.Name = "txtBuscarAluno";
            this.txtBuscarAluno.Size = new System.Drawing.Size(383, 26);
            this.txtBuscarAluno.TabIndex = 5;
            // 
            // btnBuscarAluno
            // 
            this.btnBuscarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAluno.Location = new System.Drawing.Point(478, 60);
            this.btnBuscarAluno.Name = "btnBuscarAluno";
            this.btnBuscarAluno.Size = new System.Drawing.Size(87, 26);
            this.btnBuscarAluno.TabIndex = 6;
            this.btnBuscarAluno.Text = "Buscar";
            this.btnBuscarAluno.UseVisualStyleBackColor = true;
            this.btnBuscarAluno.Click += new System.EventHandler(this.btnBuscarAluno_Click);
            // 
            // btnAtualizarAluno
            // 
            this.btnAtualizarAluno.Location = new System.Drawing.Point(159, 561);
            this.btnAtualizarAluno.Name = "btnAtualizarAluno";
            this.btnAtualizarAluno.Size = new System.Drawing.Size(141, 55);
            this.btnAtualizarAluno.TabIndex = 7;
            this.btnAtualizarAluno.Text = "Atualizar Aluno";
            this.btnAtualizarAluno.UseVisualStyleBackColor = true;
            this.btnAtualizarAluno.Click += new System.EventHandler(this.btnAtualizarAluno_Click);
            // 
            // btnMatricularAluno
            // 
            this.btnMatricularAluno.Location = new System.Drawing.Point(670, 578);
            this.btnMatricularAluno.Name = "btnMatricularAluno";
            this.btnMatricularAluno.Size = new System.Drawing.Size(118, 38);
            this.btnMatricularAluno.TabIndex = 8;
            this.btnMatricularAluno.Text = "Matricular Aluno";
            this.btnMatricularAluno.UseVisualStyleBackColor = true;
            this.btnMatricularAluno.Click += new System.EventHandler(this.btnMatricularAluno_Click);
            // 
            // btnAddUnidade
            // 
            this.btnAddUnidade.Location = new System.Drawing.Point(670, 541);
            this.btnAddUnidade.Name = "btnAddUnidade";
            this.btnAddUnidade.Size = new System.Drawing.Size(118, 31);
            this.btnAddUnidade.TabIndex = 9;
            this.btnAddUnidade.Text = "Adicionar Unidade";
            this.btnAddUnidade.UseVisualStyleBackColor = true;
            this.btnAddUnidade.Click += new System.EventHandler(this.btnAddUnidade_Click);
            // 
            // frmBuscarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.btnAddUnidade);
            this.Controls.Add(this.btnMatricularAluno);
            this.Controls.Add(this.btnAtualizarAluno);
            this.Controls.Add(this.btnBuscarAluno);
            this.Controls.Add(this.txtBuscarAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCurso);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "frmBuscarAluno";
            this.Text = "Buscar Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAddCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarAluno;
        private System.Windows.Forms.Button btnBuscarAluno;
        private System.Windows.Forms.Button btnAtualizarAluno;
        private System.Windows.Forms.Button btnMatricularAluno;
        private System.Windows.Forms.Button btnAddUnidade;
    }
}

