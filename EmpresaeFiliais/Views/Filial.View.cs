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

namespace EmpresaeFiliais.Views
{
    public partial class Filial : Form
    {
        public int _getIdPai;

        public int _getIdFilho;
        public string _getNomeFilho;

        public bool Edit = false;//Variável de controle
        string strSQL;

        MySqlConnection Conexao;
        MySqlCommand Comando;
        MySqlDataAdapter Da;
        public Filial()
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

                strSQL = "SELECT * FROM Filial Where FK_EmpresaId = @id";

                DataTable Dt = new DataTable();

                Da = new MySqlDataAdapter(strSQL, Conexao);
                Da.SelectCommand.Parameters.AddWithValue("@id", _getIdPai);
                Da.Fill(Dt);

                DgvFilial.DataSource = Dt;
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
        private void criarFilial_Click(object sender, EventArgs e)
        {
            CadastroFilial cadastroFilial = new CadastroFilial();
            cadastroFilial.getIdPai(_getIdPai);
            cadastroFilial.Show();
        }

        private void editarFilial_Click(object sender, EventArgs e)
        {
            Edit = true;

            CadastroFilial cadastroFilial = new CadastroFilial();
            cadastroFilial.getIdPai(_getIdPai);
            cadastroFilial.getIdNomeFantasiaFilial(_getIdFilho, _getNomeFilho);
            cadastroFilial.getEdit(Edit);

            if (_getIdFilho != 0)
            {
                cadastroFilial.Show();
                cadastroFilial.getSelecionado();
            }
            else
            {
                MessageBox.Show("Selecione a filial para editar.", "Atenção!!", MessageBoxButtons.OK,
                                                                           MessageBoxIcon.Exclamation);
            }
        }

        private void atualizarFilial_Click(object sender, EventArgs e)
        {
            Exibir();
        }

        private void Filial_Load(object sender, EventArgs e)
        {
            Exibir();
        }
        public void getIdEmpresaPai(int id)
        {
            _getIdPai = id;
        }

        private void DgvFilial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _getIdFilho = Convert.ToInt32(DgvFilial.CurrentRow.Cells[0].Value);
            _getNomeFilho = DgvFilial.CurrentRow.Cells[3].Value.ToString();
            DgvFilial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
