
namespace BtnExcluir
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            Salvar = new ToolStripMenuItem();
            lstContato = new ListView();
            btnExcluir = new Button();
            btnNovo = new Button();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            btnCarregarContato = new Button();
            txtCategoria = new TextBox();
            cbTexto = new ComboBox();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, Salvar });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(110, 48);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(109, 22);
            toolStripMenuItem1.Text = "Excluir";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // Salvar
            // 
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(109, 22);
            Salvar.Text = "Salvar";
            Salvar.Click += Salvar_Click;
            // 
            // lstContato
            // 
            lstContato.Location = new Point(228, 12);
            lstContato.Name = "lstContato";
            lstContato.Size = new Size(549, 82);
            lstContato.TabIndex = 1;
            lstContato.UseCompatibleStateImageBehavior = false;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(39, 66);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(107, 63);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(39, 150);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(107, 63);
            btnNovo.TabIndex = 4;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(296, 106);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(277, 23);
            txtNome.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(296, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(277, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(296, 190);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(277, 23);
            txtTelefone.TabIndex = 7;
            // 
            // btnCarregarContato
            // 
            btnCarregarContato.Location = new Point(39, 238);
            btnCarregarContato.Name = "btnCarregarContato";
            btnCarregarContato.Size = new Size(107, 63);
            btnCarregarContato.TabIndex = 8;
            btnCarregarContato.Text = "Carregar";
            btnCarregarContato.UseVisualStyleBackColor = true;
            btnCarregarContato.Click += btnCarregarContato_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(296, 259);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(277, 23);
            txtCategoria.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 352);
            Controls.Add(txtCategoria);
            Controls.Add(btnCarregarContato);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(lstContato);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ListView lstContato;
        private Button btnExcluir;
        private ToolStripMenuItem Salvar;
        private Button btnNovo;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private Button btnCarregarContato;
        private TextBox txtCategoria;
    }
}
