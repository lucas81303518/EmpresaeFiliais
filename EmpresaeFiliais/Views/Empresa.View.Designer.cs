
namespace EmpresaeFiliais
{
    partial class Empresa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvEmpresa = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.criarEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarFiliais = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpresa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvEmpresa
            // 
            this.DgvEmpresa.AllowUserToAddRows = false;
            this.DgvEmpresa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvEmpresa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvEmpresa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvEmpresa.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvEmpresa.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvEmpresa.GridColor = System.Drawing.Color.LightGray;
            this.DgvEmpresa.Location = new System.Drawing.Point(12, 78);
            this.DgvEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvEmpresa.MultiSelect = false;
            this.DgvEmpresa.Name = "DgvEmpresa";
            this.DgvEmpresa.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEmpresa.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvEmpresa.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DgvEmpresa.Size = new System.Drawing.Size(679, 226);
            this.DgvEmpresa.TabIndex = 13;
            this.DgvEmpresa.TabStop = false;
            this.DgvEmpresa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpresa_CellClick);
            this.DgvEmpresa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvEmpresa_CellFormatting);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarEmpresa,
            this.editarEmpresa,
            this.mostrarFiliais,
            this.atualizarEmpresa});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 25);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // criarEmpresa
            // 
            this.criarEmpresa.Name = "criarEmpresa";
            this.criarEmpresa.Size = new System.Drawing.Size(108, 21);
            this.criarEmpresa.Text = "Nova empresa";
            this.criarEmpresa.Click += new System.EventHandler(this.criarEmpresa_Click);
            // 
            // editarEmpresa
            // 
            this.editarEmpresa.Name = "editarEmpresa";
            this.editarEmpresa.Size = new System.Drawing.Size(109, 21);
            this.editarEmpresa.Text = "Editar empresa";
            this.editarEmpresa.Click += new System.EventHandler(this.editarEmpresa_Click);
            // 
            // mostrarFiliais
            // 
            this.mostrarFiliais.Name = "mostrarFiliais";
            this.mostrarFiliais.Size = new System.Drawing.Size(99, 21);
            this.mostrarFiliais.Text = "Mostrar Filiais";
            this.mostrarFiliais.Click += new System.EventHandler(this.mostrarFiliais_Click);
            // 
            // atualizarEmpresa
            // 
            this.atualizarEmpresa.Name = "atualizarEmpresa";
            this.atualizarEmpresa.Size = new System.Drawing.Size(72, 21);
            this.atualizarEmpresa.Text = "Atualizar";
            this.atualizarEmpresa.Click += new System.EventHandler(this.atualizarEmpresa_Click);
            // 
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 317);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DgvEmpresa);
            this.Name = "Empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.Empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpresa)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEmpresa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem criarEmpresa;
        public System.Windows.Forms.ToolStripMenuItem editarEmpresa;
        public System.Windows.Forms.ToolStripMenuItem mostrarFiliais;
        private System.Windows.Forms.ToolStripMenuItem atualizarEmpresa;
    }
}

