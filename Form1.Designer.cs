namespace Agenda
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
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.ComboBox cmbTipoTelefone;
        private System.Windows.Forms.TextBox txtNumeroTelefone;
        private System.Windows.Forms.CheckBox chkPrincipal;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox lstContatos;

        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAno = new TextBox();
            cmbTipoTelefone = new ComboBox();
            txtNumeroTelefone = new TextBox();
            chkPrincipal = new CheckBox();
            btnAdicionar = new Button();
            btnPesquisar = new Button();
            btnAlterar = new Button();
            btnRemover = new Button();
            btnListar = new Button();
            lstContatos = new ListBox();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 12);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(200, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 38);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(12, 64);
            txtDia.Name = "txtDia";
            txtDia.PlaceholderText = "Dia";
            txtDia.Size = new Size(50, 23);
            txtDia.TabIndex = 2;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(68, 64);
            txtMes.Name = "txtMes";
            txtMes.PlaceholderText = "Mês";
            txtMes.Size = new Size(50, 23);
            txtMes.TabIndex = 3;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(124, 64);
            txtAno.Name = "txtAno";
            txtAno.PlaceholderText = "Ano";
            txtAno.Size = new Size(88, 23);
            txtAno.TabIndex = 4;
            // 
            // cmbTipoTelefone
            // 
            cmbTipoTelefone.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoTelefone.FormattingEnabled = true;
            cmbTipoTelefone.Items.AddRange(new object[] { "Residencial", "Móvel" });
            cmbTipoTelefone.Location = new Point(12, 90);
            cmbTipoTelefone.Name = "cmbTipoTelefone";
            cmbTipoTelefone.Size = new Size(200, 23);
            cmbTipoTelefone.TabIndex = 5;
            // 
            // txtNumeroTelefone
            // 
            txtNumeroTelefone.Location = new Point(12, 116);
            txtNumeroTelefone.Name = "txtNumeroTelefone";
            txtNumeroTelefone.PlaceholderText = "Número de Telefone";
            txtNumeroTelefone.Size = new Size(200, 23);
            txtNumeroTelefone.TabIndex = 6;
            // 
            // chkPrincipal
            // 
            chkPrincipal.AutoSize = true;
            chkPrincipal.Location = new Point(12, 142);
            chkPrincipal.Name = "chkPrincipal";
            chkPrincipal.Size = new Size(72, 19);
            chkPrincipal.TabIndex = 7;
            chkPrincipal.Text = "Principal";
            chkPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(12, 165);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 8;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(93, 165);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(174, 165);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 10;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(255, 165);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 11;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(336, 165);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 12;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // lstContatos
            // 
            lstContatos.FormattingEnabled = true;
            lstContatos.ItemHeight = 15;
            lstContatos.Location = new Point(12, 194);
            lstContatos.Name = "lstContatos";
            lstContatos.Size = new Size(634, 139);
            lstContatos.TabIndex = 13;
            // 
            // Form1
            // 
            ClientSize = new Size(658, 353);
            Controls.Add(lstContatos);
            Controls.Add(btnListar);
            Controls.Add(btnRemover);
            Controls.Add(btnAlterar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnAdicionar);
            Controls.Add(chkPrincipal);
            Controls.Add(txtNumeroTelefone);
            Controls.Add(cmbTipoTelefone);
            Controls.Add(txtAno);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Agenda de Contatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
