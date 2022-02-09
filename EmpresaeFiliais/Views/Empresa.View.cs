using EmpresaeFiliais.Views;
using MySql.Data.MySqlClient;
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

namespace EmpresaeFiliais
{
    public partial class Empresa : Form
    {
        public int _getId;
        public string _getNome;
        public bool Edit = false;//Variável de controle

        MySqlConnection Conexao;
        MySqlCommand Comando;
        MySqlDataAdapter Da;

        string strSQL;
        public Empresa()
        {
            InitializeComponent();
        }
        private void Connection()//Método de conexão com banco
        {
            Conexao = new MySqlConnection("Server=localhost;Database=Empresas;Uid=root;Pwd=root;");
        }
        private void Exibir()
        {
            try
            {
                Connection();

                strSQL = "SELECT * FROM Empresa";

                DataTable Dt = new DataTable();

                Da = new MySqlDataAdapter(strSQL, Conexao);

                Da.Fill(Dt);

                DgvEmpresa.DataSource = Dt;
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Conexao.Close();
                Conexao = null;
                Comando = null;
            }

        }
        private void criarEmpresa_Click(object sender, EventArgs e)
        {
            CadastroEmpresa cadastroEmpresa = new CadastroEmpresa();
            cadastroEmpresa.Show();
        }

        private void editarEmpresa_Click(object sender, EventArgs e)
        {
            Edit = true;

            CadastroEmpresa cadastroEmpresa = new CadastroEmpresa();
            cadastroEmpresa.getIdNomeFantasia(_getId, _getNome);
            cadastroEmpresa.getEdit(Edit);

            if (_getId != 0)
            {
                cadastroEmpresa.Show();
                cadastroEmpresa.getSelecionado();
            }
            else
            {
                MessageBox.Show("Selecione a empresa para editar.", "Atenção!!", MessageBoxButtons.OK,
                                                                           MessageBoxIcon.Exclamation);
            }
        }

        private void Empresa_Load(object sender, EventArgs e)
        {
            Exibir();
        }

        private void DgvEmpresa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Organizando Células que tem o tipo float para R$
            for (int i = 0; i < DgvEmpresa.Columns.Count; i++)
            {
                if (DgvEmpresa.Columns[i].ValueType == typeof(float))
                {
                    DgvEmpresa.Columns[i].DefaultCellStyle.Format = "C2";
                }
            }
        }

        private void atualizarEmpresa_Click(object sender, EventArgs e)
        {
            Exibir();
        }

        private void DgvEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _getId = Convert.ToInt32(DgvEmpresa.CurrentRow.Cells[0].Value);
            _getNome = DgvEmpresa.CurrentRow.Cells[3].Value.ToString();
            DgvEmpresa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void mostrarFiliais_Click(object sender, EventArgs e)
        {
            Filial filial = new Filial();

            if (_getId != 0)
            {
                filial.getIdEmpresaPai(_getId);
                filial.Show();
            }
            else
            {
                MessageBox.Show("Selecione a empresa para ver as filiais.", "Atenção!!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
