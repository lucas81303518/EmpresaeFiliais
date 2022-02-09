using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaeFiliais.Views
{
    public partial class CadastroEmpresa : Form
    {
        MySqlConnection Conexao;
        MySqlCommand Comando;
        MySqlDataReader Dr;

        public string strSQL;
        public bool Edit = false; //Variavel de controle 
        public int _getId;//Variavel para guardar o Id da empresa  
        public string _getNomeFantasia;

        public CadastroEmpresa()
        {
            InitializeComponent();
        }
        private void Connection()//Método de conexão com banco
        {
            Conexao = new MySqlConnection("Server=localhost;Database=Empresas;Uid=root;Pwd=root;");
        }
        public void newEmpresa()
        {
            try
            {
                Connection();

                strSQL = "INSERT INTO Empresa(Cnpj, Situacao, NomeFantasia, Telefone, Capital, Cep, Uf, Cidade, Rua," +
                    " Numero) Values(@Cnpj, @Situacao, @NomeFantasia, @Telefone, @Capital, @Cep, @Uf, @Cidade, @Rua," +
                    " @Numero)";

                Comando = new MySqlCommand(strSQL, Conexao);
                Comando.Parameters.AddWithValue("@Cnpj", txtCnpj.Text);
                if (rbAtivo.Checked)
                {
                    rbAtivo.Text = "Sim";
                    Comando.Parameters.AddWithValue("@Situacao", rbAtivo.Text);
                }
                else
                {
                    rbInativo.Text = "Não";
                    Comando.Parameters.AddWithValue("@Situacao", rbInativo.Text);
                }
                Comando.Parameters.AddWithValue("@NomeFantasia", txtNomeFantasia.Text);
                Comando.Parameters.AddWithValue("@Telefone", txtTel.Text);
                Comando.Parameters.AddWithValue("@Capital", Convert.ToDouble(txtCapital.Text));
                Comando.Parameters.AddWithValue("@Cep", txtCep.Text);
                Comando.Parameters.AddWithValue("@Uf", txtUf.Text);
                Comando.Parameters.AddWithValue("@Cidade", txtCidade.Text);
                Comando.Parameters.AddWithValue("@Rua", txtLogradouro.Text);
                Comando.Parameters.AddWithValue("@Numero", txtNumero.Text);

                Conexao.Open();
                Comando.ExecuteNonQuery();

                MessageBox.Show($"Empresa {txtNomeFantasia.Text} cadastrada com sucesso", "Parabéns!!",
                                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
            }
            catch (Exception Ex)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (txtCnpj.Text == "")
                    {
                        MessageBox.Show("Campo CNPJ não preenchido!!", "Atenção", MessageBoxButtons.OK,
                                                                                  MessageBoxIcon.Exclamation);
                        txtCnpj.Focus();
                        break;
                    }
                    else if (txtNomeFantasia.Text == "")
                    {
                        MessageBox.Show("Campo Nome Fansatia não preenchido!!", "Atenção", MessageBoxButtons.OK,
                                                                                  MessageBoxIcon.Exclamation);
                        txtNomeFantasia.Focus();
                        break;
                    }
                    if (txtTel.Text == "")
                    {
                        MessageBox.Show("Campo Telefone não preenchido!!", "Atenção", MessageBoxButtons.OK,
                                                                                  MessageBoxIcon.Exclamation);
                        txtTel.Focus();
                        break;
                    }
                    if (txtCapital.Text == "")
                    {
                        MessageBox.Show("Campo Capital não preenchido!!", "Atenção", MessageBoxButtons.OK,
                                                                                  MessageBoxIcon.Exclamation);
                        txtCapital.Focus();
                        break;
                    }
                    if (txtCep.Text == "")
                    {
                        MessageBox.Show("Campo Cep não preenchido!!", "Atenção", MessageBoxButtons.OK,
                                                                                  MessageBoxIcon.Exclamation);
                        txtCep.Focus();
                        break;
                    }
                    if (txtUf.Text == "")
                    {
                        MessageBox.Show("Campo UF não preenchido!!", "Atenção", MessageBoxButtons.OK,
                                                                                  MessageBoxIcon.Exclamation);
                        txtUf.Focus();
                        break;
                    }
                    if (txtCidade.Text == "")
                    {
                        MessageBox.Show("Campo Cidade não preenchido!!", "Atenção", MessageBoxButtons.OK,
                                                                                  MessageBoxIcon.Exclamation);
                        txtCidade.Focus();
                        break;
                    }
                    if (txtLogradouro.Text == "")
                    {
                        MessageBox.Show("Campo Rua não preenchido!!", "Atenção", MessageBoxButtons.OK,
                                                                                  MessageBoxIcon.Exclamation);
                        txtLogradouro.Focus();
                        break;
                    }
                    if (txtNumero.Text == "")
                    {
                        MessageBox.Show("Campo Número não preenchido!!", "Atenção", MessageBoxButtons.OK,
                                                                                  MessageBoxIcon.Exclamation);
                        txtNumero.Focus();
                        break;
                    }
                }
            }
            finally
            {
                Conexao.Close();
                Conexao = null;
                Comando = null;
            }
        }
        public void updateEmpresa()
        {
            DialogResult dialogResult = new DialogResult();
            try
            {
                Connection();

                if (txtNomeFantasia.Text != "")
                {
                    dialogResult = MessageBox.Show($"Deseja alterar a empresa {_getNomeFantasia} ?", "ATENÇAO!!",
                                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {

                        strSQL = "UPDATE Empresa SET CNPJ = @CNPJ, Situacao = @Situacao, NomeFantasia = @NomeFantasia," +
                            "Telefone = @Telefone, Capital = @Capital, Cep = @Cep, Uf = @Uf, Cidade = @Cidade, Rua = @Rua," +
                            "Numero = @Numero Where idEmpresa = @id";
                        Comando = new MySqlCommand(strSQL, Conexao);
                        Comando.Parameters.AddWithValue("@id", _getId);
                        Comando.Parameters.AddWithValue("@Cnpj", txtCnpj.Text);
                        if (rbAtivo.Checked)
                        {
                            rbAtivo.Text = "Sim";
                            Comando.Parameters.AddWithValue("@Situacao", rbAtivo.Text);
                        }
                        else
                        {
                            rbInativo.Text = "Não";
                            Comando.Parameters.AddWithValue("@Situacao", rbInativo.Text);
                        }
                        Comando.Parameters.AddWithValue("@NomeFantasia", txtNomeFantasia.Text);
                        Comando.Parameters.AddWithValue("@Telefone", txtTel.Text);
                        Comando.Parameters.AddWithValue("@Capital", Convert.ToDouble(txtCapital.Text));
                        Comando.Parameters.AddWithValue("@Cep", txtCep.Text);
                        Comando.Parameters.AddWithValue("@Uf", txtUf.Text);
                        Comando.Parameters.AddWithValue("@Cidade", txtCidade.Text);
                        Comando.Parameters.AddWithValue("@Rua", txtLogradouro.Text);
                        Comando.Parameters.AddWithValue("@Numero", txtNumero.Text);

                        Conexao.Open();
                        Comando.ExecuteNonQuery();

                        MessageBox.Show($"Empresa {_getNomeFantasia} editada com sucesso", "Parabéns!!",
                                                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                    }
                    else
                    {
                     
                    }                    
                }
            }
            catch (Exception Ex)
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
        private void btnSalvarEmpresa_Click(object sender, EventArgs e)
        {
            if (!Edit)
            {
                // Aqui estara Incluindo uma nova empresa
                newEmpresa();
            }
            else
            {
                //Aqui estara Editando uma empresa existente
                updateEmpresa();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
        public void getEdit(bool edit)
        {
            Edit = edit;
        }
        public void getIdNomeFantasia(int id, string nome)
        {
            _getId = id;
            _getNomeFantasia = nome;
        }
        public void getSelecionado()
        {
            try
            {
                Connection();

                strSQL = "SELECT * FROM Empresa WHERE idEmpresa = @Id";

                Comando = new MySqlCommand(strSQL, Conexao);
                Comando.Parameters.AddWithValue("@Id", _getId);

                Conexao.Open();
                Dr = Comando.ExecuteReader();

                while (Dr.Read())
                {
                    txtCnpj.Text = Convert.ToString(Dr["CNPJ"]);
                    txtNomeFantasia.Text = Convert.ToString(Dr["NomeFantasia"]);
                    txtTel.Text = Convert.ToString(Dr["Telefone"]);
                    txtCapital.Text = Convert.ToString(Dr["Capital"]);
                    txtCep.Text = Convert.ToString(Dr["Cep"]);
                    txtUf.Text = Convert.ToString(Dr["UF"]);
                    txtCidade.Text = Convert.ToString(Dr["Cidade"]);
                    txtLogradouro.Text = Convert.ToString(Dr["Rua"]);
                    txtNumero.Text = Convert.ToString(Dr["Numero"]);
                }
            }
            catch (Exception Ex)
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
        
    }
}
