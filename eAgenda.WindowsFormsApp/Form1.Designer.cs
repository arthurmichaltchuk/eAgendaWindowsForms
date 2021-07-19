
namespace eAgenda.WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.tabTarefas = new System.Windows.Forms.TabPage();
            this.cbConcluirTarefa = new System.Windows.Forms.CheckBox();
            this.MudarTabela = new System.Windows.Forms.Button();
            this.dataGridTarefa = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPrioridade = new System.Windows.Forms.ComboBox();
            this.cmbPorcentagem = new System.Windows.Forms.NumericUpDown();
            this.labelInformativo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DTCriacao = new System.Windows.Forms.DateTimePicker();
            this.labelPConcluido = new System.Windows.Forms.Label();
            this.labelDataCriacao = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.tabContatos = new System.Windows.Forms.TabPage();
            this.dataGridContato = new System.Windows.Forms.DataGridView();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabCompromissos = new System.Windows.Forms.TabPage();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.MaskedTextBox();
            this.dtInicio = new System.Windows.Forms.MaskedTextBox();
            this.dtFiltroFim = new System.Windows.Forms.DateTimePicker();
            this.dtFiltroInicio = new System.Windows.Forms.DateTimePicker();
            this.MudarTabelaCompromissos = new System.Windows.Forms.Button();
            this.dataGridCompromisso = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.dtCompromisso = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbContatosCompromisso = new System.Windows.Forms.ComboBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.labelInformativoCompromisso = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.footer = new System.Windows.Forms.StatusStrip();
            this.labelFooter = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGravar = new System.Windows.Forms.Button();
            this.bntConcluido = new System.Windows.Forms.Button();
            this.tcMenu.SuspendLayout();
            this.tabTarefas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTarefa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPorcentagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabContatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabCompromissos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompromisso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMenu
            // 
            this.tcMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMenu.Controls.Add(this.tabTarefas);
            this.tcMenu.Controls.Add(this.tabContatos);
            this.tcMenu.Controls.Add(this.tabCompromissos);
            this.tcMenu.Location = new System.Drawing.Point(12, 111);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(958, 427);
            this.tcMenu.TabIndex = 7;
            this.tcMenu.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcMenu_Selected);
            // 
            // tabTarefas
            // 
            this.tabTarefas.Controls.Add(this.cbConcluirTarefa);
            this.tabTarefas.Controls.Add(this.MudarTabela);
            this.tabTarefas.Controls.Add(this.dataGridTarefa);
            this.tabTarefas.Controls.Add(this.label16);
            this.tabTarefas.Controls.Add(this.txtPrioridade);
            this.tabTarefas.Controls.Add(this.cmbPorcentagem);
            this.tabTarefas.Controls.Add(this.labelInformativo);
            this.tabTarefas.Controls.Add(this.pictureBox2);
            this.tabTarefas.Controls.Add(this.DTCriacao);
            this.tabTarefas.Controls.Add(this.labelPConcluido);
            this.tabTarefas.Controls.Add(this.labelDataCriacao);
            this.tabTarefas.Controls.Add(this.txtTitulo);
            this.tabTarefas.Controls.Add(this.labelTitulo);
            this.tabTarefas.Location = new System.Drawing.Point(4, 25);
            this.tabTarefas.Name = "tabTarefas";
            this.tabTarefas.Padding = new System.Windows.Forms.Padding(3);
            this.tabTarefas.Size = new System.Drawing.Size(950, 398);
            this.tabTarefas.TabIndex = 0;
            this.tabTarefas.Text = "Tarefas";
            this.tabTarefas.UseVisualStyleBackColor = true;
            // 
            // cbConcluirTarefa
            // 
            this.cbConcluirTarefa.AutoSize = true;
            this.cbConcluirTarefa.BackColor = System.Drawing.Color.White;
            this.cbConcluirTarefa.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.cbConcluirTarefa.Location = new System.Drawing.Point(680, 82);
            this.cbConcluirTarefa.Name = "cbConcluirTarefa";
            this.cbConcluirTarefa.Size = new System.Drawing.Size(144, 25);
            this.cbConcluirTarefa.TabIndex = 35;
            this.cbConcluirTarefa.Text = "Concluir Tarefa";
            this.cbConcluirTarefa.UseVisualStyleBackColor = false;
            this.cbConcluirTarefa.Visible = false;
            this.cbConcluirTarefa.Click += new System.EventHandler(this.cbConcluirTarefa_Click);
            // 
            // MudarTabela
            // 
            this.MudarTabela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MudarTabela.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MudarTabela.ForeColor = System.Drawing.Color.Black;
            this.MudarTabela.Location = new System.Drawing.Point(485, 146);
            this.MudarTabela.Name = "MudarTabela";
            this.MudarTabela.Size = new System.Drawing.Size(439, 31);
            this.MudarTabela.TabIndex = 33;
            this.MudarTabela.Text = "Mostrar Tarefas Concluídas";
            this.MudarTabela.UseVisualStyleBackColor = true;
            this.MudarTabela.Click += new System.EventHandler(this.MudarTabela_Click);
            // 
            // dataGridTarefa
            // 
            this.dataGridTarefa.AllowUserToAddRows = false;
            this.dataGridTarefa.AllowUserToDeleteRows = false;
            this.dataGridTarefa.AllowUserToResizeColumns = false;
            this.dataGridTarefa.AllowUserToResizeRows = false;
            this.dataGridTarefa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridTarefa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTarefa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTarefa.Location = new System.Drawing.Point(33, 187);
            this.dataGridTarefa.Name = "dataGridTarefa";
            this.dataGridTarefa.ReadOnly = true;
            this.dataGridTarefa.RowHeadersVisible = false;
            this.dataGridTarefa.RowHeadersWidth = 51;
            this.dataGridTarefa.RowTemplate.Height = 24;
            this.dataGridTarefa.RowTemplate.ReadOnly = true;
            this.dataGridTarefa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTarefa.ShowEditingIcon = false;
            this.dataGridTarefa.Size = new System.Drawing.Size(890, 193);
            this.dataGridTarefa.TabIndex = 32;
            this.dataGridTarefa.SelectionChanged += new System.EventHandler(this.dataGridTarefa_SelectionChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label16.Location = new System.Drawing.Point(665, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 21);
            this.label16.TabIndex = 31;
            this.label16.Text = "Prioridade:";
            // 
            // txtPrioridade
            // 
            this.txtPrioridade.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.txtPrioridade.FormattingEnabled = true;
            this.txtPrioridade.Items.AddRange(new object[] {
            "Alta",
            "Média",
            "Baixa"});
            this.txtPrioridade.Location = new System.Drawing.Point(788, 34);
            this.txtPrioridade.Name = "txtPrioridade";
            this.txtPrioridade.Size = new System.Drawing.Size(127, 29);
            this.txtPrioridade.TabIndex = 30;
            this.txtPrioridade.Text = "Baixa";
            // 
            // cmbPorcentagem
            // 
            this.cmbPorcentagem.BackColor = System.Drawing.Color.White;
            this.cmbPorcentagem.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.cmbPorcentagem.Location = new System.Drawing.Point(423, 80);
            this.cmbPorcentagem.Name = "cmbPorcentagem";
            this.cmbPorcentagem.Size = new System.Drawing.Size(84, 28);
            this.cmbPorcentagem.TabIndex = 14;
            this.cmbPorcentagem.Visible = false;
            // 
            // labelInformativo
            // 
            this.labelInformativo.AutoSize = true;
            this.labelInformativo.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.labelInformativo.Location = new System.Drawing.Point(30, 150);
            this.labelInformativo.Name = "labelInformativo";
            this.labelInformativo.Size = new System.Drawing.Size(222, 21);
            this.labelInformativo.TabIndex = 13;
            this.labelInformativo.Text = "Todas as tarefas concluídas:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(890, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // DTCriacao
            // 
            this.DTCriacao.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.DTCriacao.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTCriacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTCriacao.Location = new System.Drawing.Point(499, 34);
            this.DTCriacao.Name = "DTCriacao";
            this.DTCriacao.Size = new System.Drawing.Size(133, 28);
            this.DTCriacao.TabIndex = 8;
            // 
            // labelPConcluido
            // 
            this.labelPConcluido.AutoSize = true;
            this.labelPConcluido.BackColor = System.Drawing.Color.White;
            this.labelPConcluido.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.labelPConcluido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPConcluido.Location = new System.Drawing.Point(80, 84);
            this.labelPConcluido.Name = "labelPConcluido";
            this.labelPConcluido.Size = new System.Drawing.Size(170, 21);
            this.labelPConcluido.TabIndex = 4;
            this.labelPConcluido.Text = "Percentual Concluído:";
            this.labelPConcluido.Visible = false;
            // 
            // labelDataCriacao
            // 
            this.labelDataCriacao.AutoSize = true;
            this.labelDataCriacao.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataCriacao.Location = new System.Drawing.Point(354, 38);
            this.labelDataCriacao.Name = "labelDataCriacao";
            this.labelDataCriacao.Size = new System.Drawing.Size(112, 21);
            this.labelDataCriacao.TabIndex = 2;
            this.labelDataCriacao.Text = "Data Criação:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(121, 34);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(200, 28);
            this.txtTitulo.TabIndex = 1;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(30, 38);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(58, 21);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Título:";
            // 
            // tabContatos
            // 
            this.tabContatos.Controls.Add(this.dataGridContato);
            this.tabContatos.Controls.Add(this.txtEmpresa);
            this.tabContatos.Controls.Add(this.label8);
            this.tabContatos.Controls.Add(this.cbCargo);
            this.tabContatos.Controls.Add(this.txtEmail);
            this.tabContatos.Controls.Add(this.txtTelefone);
            this.tabContatos.Controls.Add(this.label3);
            this.tabContatos.Controls.Add(this.pictureBox3);
            this.tabContatos.Controls.Add(this.label4);
            this.tabContatos.Controls.Add(this.label5);
            this.tabContatos.Controls.Add(this.label6);
            this.tabContatos.Controls.Add(this.txtNome);
            this.tabContatos.Controls.Add(this.label7);
            this.tabContatos.Location = new System.Drawing.Point(4, 25);
            this.tabContatos.Name = "tabContatos";
            this.tabContatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabContatos.Size = new System.Drawing.Size(950, 398);
            this.tabContatos.TabIndex = 1;
            this.tabContatos.Text = "Contatos";
            this.tabContatos.UseVisualStyleBackColor = true;
            // 
            // dataGridContato
            // 
            this.dataGridContato.AllowUserToAddRows = false;
            this.dataGridContato.AllowUserToDeleteRows = false;
            this.dataGridContato.AllowUserToResizeColumns = false;
            this.dataGridContato.AllowUserToResizeRows = false;
            this.dataGridContato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridContato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContato.Location = new System.Drawing.Point(33, 187);
            this.dataGridContato.Name = "dataGridContato";
            this.dataGridContato.ReadOnly = true;
            this.dataGridContato.RowHeadersVisible = false;
            this.dataGridContato.RowHeadersWidth = 51;
            this.dataGridContato.RowTemplate.Height = 24;
            this.dataGridContato.RowTemplate.ReadOnly = true;
            this.dataGridContato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridContato.ShowEditingIcon = false;
            this.dataGridContato.Size = new System.Drawing.Size(890, 193);
            this.dataGridContato.TabIndex = 33;
            this.dataGridContato.SelectionChanged += new System.EventHandler(this.dataGridContato_SelectionChanged);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.Location = new System.Drawing.Point(588, 80);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(334, 28);
            this.txtEmpresa.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(471, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 30;
            this.label8.Text = "Empresa:";
            // 
            // cbCargo
            // 
            this.cbCargo.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(731, 34);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(193, 29);
            this.cbCargo.TabIndex = 29;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(124, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(311, 28);
            this.txtEmail.TabIndex = 28;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.txtTelefone.Location = new System.Drawing.Point(461, 34);
            this.txtTelefone.Mask = "(00)00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(157, 28);
            this.txtTelefone.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label3.Location = new System.Drawing.Point(30, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Todos os contatos:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(34, 123);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(890, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label4.Location = new System.Drawing.Point(637, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cargo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label5.Location = new System.Drawing.Point(359, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "E-mail:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(124, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 28);
            this.txtNome.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nome:";
            // 
            // tabCompromissos
            // 
            this.tabCompromissos.Controls.Add(this.labelFiltro);
            this.tabCompromissos.Controls.Add(this.dtFim);
            this.tabCompromissos.Controls.Add(this.dtInicio);
            this.tabCompromissos.Controls.Add(this.dtFiltroFim);
            this.tabCompromissos.Controls.Add(this.dtFiltroInicio);
            this.tabCompromissos.Controls.Add(this.MudarTabelaCompromissos);
            this.tabCompromissos.Controls.Add(this.dataGridCompromisso);
            this.tabCompromissos.Controls.Add(this.label15);
            this.tabCompromissos.Controls.Add(this.dtCompromisso);
            this.tabCompromissos.Controls.Add(this.label9);
            this.tabCompromissos.Controls.Add(this.cbContatosCompromisso);
            this.tabCompromissos.Controls.Add(this.txtLocal);
            this.tabCompromissos.Controls.Add(this.labelInformativoCompromisso);
            this.tabCompromissos.Controls.Add(this.pictureBox4);
            this.tabCompromissos.Controls.Add(this.label11);
            this.tabCompromissos.Controls.Add(this.label12);
            this.tabCompromissos.Controls.Add(this.label13);
            this.tabCompromissos.Controls.Add(this.txtAssunto);
            this.tabCompromissos.Controls.Add(this.label14);
            this.tabCompromissos.Location = new System.Drawing.Point(4, 25);
            this.tabCompromissos.Name = "tabCompromissos";
            this.tabCompromissos.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompromissos.Size = new System.Drawing.Size(950, 398);
            this.tabCompromissos.TabIndex = 2;
            this.tabCompromissos.Text = "Compromissos";
            this.tabCompromissos.UseVisualStyleBackColor = true;
            // 
            // labelFiltro
            // 
            this.labelFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.labelFiltro.Location = new System.Drawing.Point(512, 150);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(36, 21);
            this.labelFiltro.TabIndex = 55;
            this.labelFiltro.Text = "Até";
            this.labelFiltro.Visible = false;
            // 
            // dtFim
            // 
            this.dtFim.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.dtFim.Location = new System.Drawing.Point(860, 80);
            this.dtFim.Mask = "90:00";
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(58, 28);
            this.dtFim.TabIndex = 54;
            this.dtFim.ValidatingType = typeof(System.DateTime);
            // 
            // dtInicio
            // 
            this.dtInicio.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.dtInicio.Location = new System.Drawing.Point(586, 80);
            this.dtInicio.Mask = "00:00";
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(58, 28);
            this.dtInicio.TabIndex = 53;
            this.dtInicio.ValidatingType = typeof(System.DateTime);
            // 
            // dtFiltroFim
            // 
            this.dtFiltroFim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFiltroFim.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.dtFiltroFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFiltroFim.Location = new System.Drawing.Point(566, 146);
            this.dtFiltroFim.Name = "dtFiltroFim";
            this.dtFiltroFim.Size = new System.Drawing.Size(108, 28);
            this.dtFiltroFim.TabIndex = 52;
            this.dtFiltroFim.Visible = false;
            // 
            // dtFiltroInicio
            // 
            this.dtFiltroInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFiltroInicio.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.dtFiltroInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFiltroInicio.Location = new System.Drawing.Point(383, 146);
            this.dtFiltroInicio.Name = "dtFiltroInicio";
            this.dtFiltroInicio.Size = new System.Drawing.Size(111, 28);
            this.dtFiltroInicio.TabIndex = 51;
            this.dtFiltroInicio.Visible = false;
            // 
            // MudarTabelaCompromissos
            // 
            this.MudarTabelaCompromissos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MudarTabelaCompromissos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MudarTabelaCompromissos.ForeColor = System.Drawing.Color.Black;
            this.MudarTabelaCompromissos.Location = new System.Drawing.Point(696, 145);
            this.MudarTabelaCompromissos.Name = "MudarTabelaCompromissos";
            this.MudarTabelaCompromissos.Size = new System.Drawing.Size(227, 31);
            this.MudarTabelaCompromissos.TabIndex = 50;
            this.MudarTabelaCompromissos.Text = "Filtrar por Data";
            this.MudarTabelaCompromissos.UseVisualStyleBackColor = true;
            this.MudarTabelaCompromissos.Click += new System.EventHandler(this.MudarTabelaCompromissos_Click);
            // 
            // dataGridCompromisso
            // 
            this.dataGridCompromisso.AllowUserToAddRows = false;
            this.dataGridCompromisso.AllowUserToDeleteRows = false;
            this.dataGridCompromisso.AllowUserToResizeColumns = false;
            this.dataGridCompromisso.AllowUserToResizeRows = false;
            this.dataGridCompromisso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCompromisso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCompromisso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompromisso.Location = new System.Drawing.Point(33, 187);
            this.dataGridCompromisso.Name = "dataGridCompromisso";
            this.dataGridCompromisso.ReadOnly = true;
            this.dataGridCompromisso.RowHeadersVisible = false;
            this.dataGridCompromisso.RowHeadersWidth = 51;
            this.dataGridCompromisso.RowTemplate.Height = 24;
            this.dataGridCompromisso.RowTemplate.ReadOnly = true;
            this.dataGridCompromisso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCompromisso.ShowEditingIcon = false;
            this.dataGridCompromisso.Size = new System.Drawing.Size(890, 193);
            this.dataGridCompromisso.TabIndex = 49;
            this.dataGridCompromisso.SelectionChanged += new System.EventHandler(this.dataGridCompromisso_SelectionChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(682, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 21);
            this.label15.TabIndex = 47;
            this.label15.Text = "Hora de Término:";
            // 
            // dtCompromisso
            // 
            this.dtCompromisso.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.dtCompromisso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCompromisso.Location = new System.Drawing.Point(464, 34);
            this.dtCompromisso.Name = "dtCompromisso";
            this.dtCompromisso.Size = new System.Drawing.Size(133, 28);
            this.dtCompromisso.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(429, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 21);
            this.label9.TabIndex = 43;
            this.label9.Text = "Hora de Início:";
            // 
            // cbContatosCompromisso
            // 
            this.cbContatosCompromisso.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.cbContatosCompromisso.FormattingEnabled = true;
            this.cbContatosCompromisso.Location = new System.Drawing.Point(725, 34);
            this.cbContatosCompromisso.Name = "cbContatosCompromisso";
            this.cbContatosCompromisso.Size = new System.Drawing.Size(193, 29);
            this.cbContatosCompromisso.Sorted = true;
            this.cbContatosCompromisso.TabIndex = 42;
            // 
            // txtLocal
            // 
            this.txtLocal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocal.Location = new System.Drawing.Point(158, 80);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(200, 28);
            this.txtLocal.TabIndex = 41;
            // 
            // labelInformativoCompromisso
            // 
            this.labelInformativoCompromisso.AutoSize = true;
            this.labelInformativoCompromisso.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.labelInformativoCompromisso.Location = new System.Drawing.Point(30, 150);
            this.labelInformativoCompromisso.Name = "labelInformativoCompromisso";
            this.labelInformativoCompromisso.Size = new System.Drawing.Size(194, 21);
            this.labelInformativoCompromisso.TabIndex = 38;
            this.labelInformativoCompromisso.Text = "Todos os compromissos:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(34, 123);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(890, 10);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label11.Location = new System.Drawing.Point(624, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 21);
            this.label11.TabIndex = 36;
            this.label11.Text = "Contato:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label12.Location = new System.Drawing.Point(385, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 21);
            this.label12.TabIndex = 35;
            this.label12.Text = "Data:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 21);
            this.label13.TabIndex = 34;
            this.label13.Text = "Local ou Link:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssunto.Location = new System.Drawing.Point(158, 34);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(200, 28);
            this.txtAssunto.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(30, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 21);
            this.label14.TabIndex = 32;
            this.label14.Text = "Assunto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Silver;
            this.btnEditar.Location = new System.Drawing.Point(354, 544);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(280, 70);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Silver;
            this.btnExcluir.Location = new System.Drawing.Point(688, 544);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(280, 70);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(99)))), ((int)(((byte)(248)))));
            this.footer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.footer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelFooter});
            this.footer.Location = new System.Drawing.Point(0, 627);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(982, 26);
            this.footer.TabIndex = 9;
            this.footer.Text = "statusStrip1";
            // 
            // labelFooter
            // 
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(101, 20);
            this.labelFooter.Text = "Aguardando...";
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGravar.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.Black;
            this.btnGravar.Location = new System.Drawing.Point(12, 544);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(280, 70);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // bntConcluido
            // 
            this.bntConcluido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bntConcluido.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntConcluido.ForeColor = System.Drawing.Color.Black;
            this.bntConcluido.Location = new System.Drawing.Point(12, 544);
            this.bntConcluido.Name = "bntConcluido";
            this.bntConcluido.Size = new System.Drawing.Size(280, 70);
            this.bntConcluido.TabIndex = 12;
            this.bntConcluido.Text = "Concluído";
            this.bntConcluido.UseVisualStyleBackColor = true;
            this.bntConcluido.Visible = false;
            this.bntConcluido.Click += new System.EventHandler(this.bntConcluido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.bntConcluido);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.tcMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGravar);
            this.Name = "Form1";
            this.Text = "e-Agenda";
            this.tcMenu.ResumeLayout(false);
            this.tabTarefas.ResumeLayout(false);
            this.tabTarefas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTarefa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPorcentagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabContatos.ResumeLayout(false);
            this.tabContatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabCompromissos.ResumeLayout(false);
            this.tabCompromissos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompromisso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMenu;
        private System.Windows.Forms.TabPage tabTarefas;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox txtPrioridade;
        private System.Windows.Forms.NumericUpDown cmbPorcentagem;
        private System.Windows.Forms.Label labelInformativo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker DTCriacao;
        private System.Windows.Forms.Label labelPConcluido;
        private System.Windows.Forms.Label labelDataCriacao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TabPage tabContatos;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabCompromissos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtCompromisso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbContatosCompromisso;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label labelInformativoCompromisso;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.StatusStrip footer;
        private System.Windows.Forms.ToolStripStatusLabel labelFooter;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DataGridView dataGridTarefa;
        private System.Windows.Forms.Button MudarTabela;
        private System.Windows.Forms.Button bntConcluido;
        private System.Windows.Forms.CheckBox cbConcluirTarefa;
        private System.Windows.Forms.DataGridView dataGridContato;
        private System.Windows.Forms.DataGridView dataGridCompromisso;
        private System.Windows.Forms.Button MudarTabelaCompromissos;
        private System.Windows.Forms.DateTimePicker dtFiltroFim;
        private System.Windows.Forms.DateTimePicker dtFiltroInicio;
        private System.Windows.Forms.MaskedTextBox dtInicio;
        private System.Windows.Forms.MaskedTextBox dtFim;
        private System.Windows.Forms.Label labelFiltro;
    }
}

