
namespace CadastroPessoas
{
    partial class FrameVisualizar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameVisualizar));
            this.dataGridViewPrincipal = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nASCIMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFuncionariosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tbFuncionariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBSistemaCadastroDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbFuncionariosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionariosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSistemaCadastroDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionariosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPrincipal
            // 
            this.dataGridViewPrincipal.AllowUserToAddRows = false;
            this.dataGridViewPrincipal.AllowUserToDeleteRows = false;
            this.dataGridViewPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPrincipal.AutoGenerateColumns = false;
            this.dataGridViewPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrincipal.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.tELEFONEDataGridViewTextBoxColumn,
            this.sALARIODataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.nASCIMENTODataGridViewTextBoxColumn,
            this.cIDADEDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn});
            this.dataGridViewPrincipal.DataSource = this.tbFuncionariosBindingSource3;
            this.dataGridViewPrincipal.Location = new System.Drawing.Point(10, 88);
            this.dataGridViewPrincipal.Name = "dataGridViewPrincipal";
            this.dataGridViewPrincipal.ReadOnly = true;
            this.dataGridViewPrincipal.Size = new System.Drawing.Size(743, 344);
            this.dataGridViewPrincipal.TabIndex = 1;
            this.dataGridViewPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrincipal_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sexo";
            this.dataGridViewTextBoxColumn3.HeaderText = "sexo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tELEFONEDataGridViewTextBoxColumn
            // 
            this.tELEFONEDataGridViewTextBoxColumn.DataPropertyName = "TELEFONE";
            this.tELEFONEDataGridViewTextBoxColumn.HeaderText = "TELEFONE";
            this.tELEFONEDataGridViewTextBoxColumn.Name = "tELEFONEDataGridViewTextBoxColumn";
            this.tELEFONEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sALARIODataGridViewTextBoxColumn
            // 
            this.sALARIODataGridViewTextBoxColumn.DataPropertyName = "SALARIO";
            this.sALARIODataGridViewTextBoxColumn.HeaderText = "SALARIO";
            this.sALARIODataGridViewTextBoxColumn.Name = "sALARIODataGridViewTextBoxColumn";
            this.sALARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nASCIMENTODataGridViewTextBoxColumn
            // 
            this.nASCIMENTODataGridViewTextBoxColumn.DataPropertyName = "NASCIMENTO";
            this.nASCIMENTODataGridViewTextBoxColumn.HeaderText = "NASCIMENTO";
            this.nASCIMENTODataGridViewTextBoxColumn.Name = "nASCIMENTODataGridViewTextBoxColumn";
            this.nASCIMENTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cIDADEDataGridViewTextBoxColumn
            // 
            this.cIDADEDataGridViewTextBoxColumn.DataPropertyName = "CIDADE";
            this.cIDADEDataGridViewTextBoxColumn.HeaderText = "CIDADE";
            this.cIDADEDataGridViewTextBoxColumn.Name = "cIDADEDataGridViewTextBoxColumn";
            this.cIDADEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            this.eSTADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            this.cEPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbFuncionariosBindingSource3
            // 
            this.tbFuncionariosBindingSource3.DataMember = "tb_Funcionarios";
            // 
            // dB_SistemaCadastroDataSet
            // 
            // 
            // tbFuncionariosBindingSource1
            // 
            this.tbFuncionariosBindingSource1.DataMember = "tb_Funcionarios";
            this.tbFuncionariosBindingSource1.DataSource = this.dBSistemaCadastroDataSetBindingSource;
            // 
            // tbFuncionariosBindingSource
            // 
            this.tbFuncionariosBindingSource.DataMember = "tb_Funcionarios";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.White;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(527, 443);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(115, 41);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(648, 443);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 41);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(283, 32);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(31, 29);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pesquisar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(403, 443);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 41);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbFuncionariosBindingSource2
            // 
            this.tbFuncionariosBindingSource2.DataMember = "tb_Funcionarios";
            this.tbFuncionariosBindingSource2.DataSource = this.dBSistemaCadastroDataSetBindingSource;
            // 
            // tb_FuncionariosTableAdapter
            // 
            // 
            // FrameVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dataGridViewPrincipal);
            this.Name = "FrameVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionariosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionariosBindingSource1)).EndInit();
          
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionariosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPrincipal;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource tbFuncionariosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dBSistemaCadastroDataSetBindingSource;
        private System.Windows.Forms.BindingSource tbFuncionariosBindingSource1;
        private System.Windows.Forms.BindingSource tbFuncionariosBindingSource2;
        private System.Windows.Forms.BindingSource tbFuncionariosBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nASCIMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
    }
}

