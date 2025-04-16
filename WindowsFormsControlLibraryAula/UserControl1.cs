using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsControlLibraryAula
{
    public partial class UserControl1: UserControl
    {
        MySqlConnection Conexao;

        // padrão: host user senha
        private string data_source = "datasource=localhost;username=root;password=12102021;database=aulas";
        public UserControl1()
        {
            InitializeComponent();

            // configurações
            lstContatos.View = View.Details;
            lstContatos.LabelEdit = true;
            lstContatos.AllowColumnReorder = true;
            lstContatos.FullRowSelect = true;
            lstContatos.GridLines = true;


            // Posição dos Cabeçalhos a serem exibidos na tela
            lstContatos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lstContatos.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lstContatos.Columns.Add("Email", 150, HorizontalAlignment.Left);
            lstContatos.Columns.Add("Telefone", 150, HorizontalAlignment.Left);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                // Criar a conexão com o MySQL
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                // SQL que desejamos executar - marcadores
                cmd.CommandText =
                    "INSERT INTO contato " +
                    "(nome, email, telefone) " +
                    "VALUES" +
                    "(@nome, @email, @telefone)";

                // são os valores encontrados dentro dos meus textsBox
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);

                cmd.ExecuteNonQuery();

                /* string sql = "INSERT INTO contato (nome, email, telefone) VALUES ('" + txtNome.Text + "','" + txtEmail.Text + "','" + txtTelefone.Text + "')";

                // Executar Comando Insert
                MySqlCommand insert = new MySqlCommand(sql, Conexao);

                Conexao.Open();
                insert.ExecuteReader(); */


                // Mostrando a Mensagem para o Usuário
                //MessageBox.Show("Dados Inseridos com Sucesso!!!");

                MessageBox.Show(
                    "Contato Inserido com Sucesso ", 
                    "Sucesso ", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

            }
            catch (MySqlException ex)

            {
                MessageBox.Show("Error " + "has occured: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } catch (Exception ex) 
            {
                MessageBox.Show("Has occured: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string q = "%" + txtBuscar.Text + "%";

                // Criar a conexão com o MySQL
                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * FROM contato WHERE nome LIKE @q OR email LIKE @q";


                Conexao.Open();

                // Buscar as informações
                MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                buscar.Parameters.AddWithValue("@q", q);

                // armazena as informacoes que temos na busca para mostrar na tela
                MySqlDataReader reader = buscar.ExecuteReader();


                lstContatos.Items.Clear();

                while(reader.Read())
                {
                    string[] row =
                    {
                        // obtendo as informações do banco de dados (vetor de strings)
                        reader.GetInt32(0).ToString(), // id
                        reader.GetString(1),           // nome
                        reader.GetString(2),           // email
                        reader.GetString(3),           // telefone
                    };

                    var linha_list_view = new ListViewItem(row);
                    lstContatos.Items.Add(linha_list_view);
                }


            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                Conexao.Close();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
