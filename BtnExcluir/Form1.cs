using System.Collections.Generic;


namespace BtnExcluir
{
    public partial class Form1 : Form
    {
        public int? id_contato_selecioando = 10;
        private List<string> dadosBanco;
        private List<int> idCategoria;

        public Form1()
        {
            InitializeComponent();
            SelectBanco();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou no menu");
        }

        private void btnExcluir_Click(object sender, EventArgs e) { }

        private void zerar_forms()
        {
            id_contato_selecioando = null;
            txtNome.Text = "";
            txtTelefone.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtNome.Focus();

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        { //tableControl

        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            excluir_contato();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            zerar_forms();
        }

        public void excluir_contato()
        {
            MessageBox.Show("Deseja Excluir o Contato?",
                    "Excluindo Contato?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
             );

        }

        public void SelectBanco()
        {
            // SELECT                      // SELECT CATEGORIA FROM Categoria;
            dadosBanco = new List<string> {"Limpeza", "Sanitizante", "Alimento", "Jardinagem"};
               
            idCategoria = new List<int> { 1, 2, 3, 4 };

        }

        private void btnCarregarContato_Click(object sender, EventArgs e)
        {
            string Categoria = txtCategoria.Text.Trim().ToUpper();

            if (dadosBanco.Contains(Categoria, StringComparer.OrdinalIgnoreCase))
            {
                MessageBox.Show("Valor já existe");

            } else
            {
                MessageBox.Show("Valor não existe - Cadastrar");

                // FUNÇÃO INSERT


            }

        }
    }
}
