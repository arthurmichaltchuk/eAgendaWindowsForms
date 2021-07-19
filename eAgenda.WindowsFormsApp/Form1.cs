using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsFormsApp
{
    public partial class Form1 : Form
    {
        Tarefa tarefa = new Tarefa();
        Contato contato = new Contato();
        Compromisso compromisso = new Compromisso();
        ControladorTarefa controladorTarefa = new ControladorTarefa();
        ControladorContato controladorContato = new ControladorContato();
        ControladorCompromisso controladorCompromisso = new ControladorCompromisso();

        public Form1()
        {           
            InitializeComponent();

            //TAREFAS
            alimentarPrioridade();
            gerarTabelaTarefasPendentes();
            MudarTabelaTarefa();

            //CONTATOS
            gerarTabelaContato();
            alimentarCargos();

            //COMPROMISSO
            gerarTabelaCompromissoTodos();
            alimentarContatos();

            //TAB
            ConfigurarTabelas();
        }

        //TAB ATUAL
        bool emTelaTarefas = true;
        bool emTelaContatos = false;
        bool emTelaCompromissos = false;

        private void tcMenu_Selected(object sender, TabControlEventArgs e)
        {
            if (tcMenu.SelectedTab == tcMenu.TabPages["tabTarefas"])
            {
                emTelaTarefas = true;
                emTelaContatos = false;
                emTelaCompromissos = false;
            }
            else if (tcMenu.SelectedTab == tcMenu.TabPages["tabContatos"])
            {
                emTelaTarefas = false;
                emTelaContatos = true;
                emTelaCompromissos = false;
            }
            else if (tcMenu.SelectedTab == tcMenu.TabPages["tabCompromissos"])
            {
                emTelaTarefas = false;
                emTelaContatos = false;
                emTelaCompromissos = true;
            }
        }

        private void AtualizarTabelaAtual()
        {
            if (emTelaTarefas)
            {
                if (seletorDeTabelaTarefa == false)
                    gerarTabelaTarefasPendentes();
                else
                    gerarTabelaTarefasConcluidos();
            }
            else if (emTelaContatos)
            {
                gerarTabelaContato();
                alimentarCargos();
            }
            else if (emTelaCompromissos)
            {
                gerarTabelaCompromissoTodos();
                alimentarContatos();
            }
        }

        private void ConfigurarTabelas()
        {
            dataGridTarefa.Columns[0].HeaderText = "ID";
            dataGridTarefa.Columns[1].HeaderText = "Título";
            dataGridTarefa.Columns[2].HeaderText = "Prioridade";
            dataGridTarefa.Columns[3].HeaderText = "Data de Criação";
            dataGridTarefa.Columns[4].HeaderText = "Percentual Concluído";
            dataGridTarefa.Columns[5].HeaderText = "Data de Conclusão";

            dataGridContato.Columns[0].HeaderText = "ID";
            dataGridContato.Columns[1].HeaderText = "Nome";
            dataGridContato.Columns[2].HeaderText = "Email";
            dataGridContato.Columns[3].HeaderText = "Telefone";
            dataGridContato.Columns[4].HeaderText = "Cargo";
            dataGridContato.Columns[5].HeaderText = "Empresa";

            dataGridCompromisso.Columns[0].HeaderText = "ID";
            dataGridCompromisso.Columns[1].HeaderText = "Assunto";
            dataGridCompromisso.Columns[2].HeaderText = "Local ou Link";
            dataGridCompromisso.Columns[3].Visible = false;
            dataGridCompromisso.Columns[4].HeaderText = "Data";
            dataGridCompromisso.Columns[5].HeaderText = "Hora de início";
            dataGridCompromisso.Columns[6].HeaderText = "Hora de Término";
            dataGridCompromisso.Columns[7].HeaderText = "Contato";

        }

        //ID
        int id;
        private void dataGridTarefa_SelectionChanged(object sender, EventArgs e)
        {
            if (emTelaTarefas)
            {
                if (dataGridTarefa.SelectedRows.Count > 1)
                {
                    btnEditar.ForeColor = Color.Silver;
                    btnExcluir.ForeColor = Color.Silver;
                }
                else if (dataGridTarefa.SelectedRows.Count == 0)
                {
                    btnExcluir.ForeColor = Color.Silver;
                    btnEditar.ForeColor = Color.Silver;
                }
                else if (dataGridTarefa.SelectedCells.Count > 1)
                {
                    int selectedrowindex = dataGridTarefa.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridTarefa.Rows[selectedrowindex];
                    id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                    btnExcluir.ForeColor = Color.Black;
                    btnEditar.ForeColor = Color.Black;
                }                
            }
        }

        private void dataGridContato_SelectionChanged(object sender, EventArgs e)
        {
            if (emTelaContatos)
            {
                if (dataGridContato.SelectedRows.Count > 1)
                {
                    btnEditar.ForeColor = Color.Silver;
                    btnExcluir.ForeColor = Color.Silver;
                }
                else if (dataGridContato.SelectedRows.Count == 0)
                {
                    btnEditar.ForeColor = Color.Silver;
                    btnExcluir.ForeColor = Color.Silver;
                }
                else if (dataGridContato.SelectedCells.Count > 1)
                {
                    int selectedrowindex = dataGridContato.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridContato.Rows[selectedrowindex];
                    id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                    btnEditar.ForeColor = Color.Black;
                    btnExcluir.ForeColor = Color.Black;
                }
            }
        }

        private void dataGridCompromisso_SelectionChanged(object sender, EventArgs e)
        {
            if (emTelaCompromissos)
            {
                if (dataGridCompromisso.SelectedRows.Count > 1)
                {
                    btnEditar.ForeColor = Color.Silver;
                    btnExcluir.ForeColor = Color.Silver;
                }
                else if (dataGridCompromisso.SelectedRows.Count == 0)
                {
                    btnEditar.ForeColor = Color.Silver;
                    btnExcluir.ForeColor = Color.Silver;
                }
                else if (dataGridCompromisso.SelectedCells.Count > 1)
                {
                    int selectedrowindex = dataGridCompromisso.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridCompromisso.Rows[selectedrowindex];
                    id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                    btnEditar.ForeColor = Color.Black;
                    btnExcluir.ForeColor = Color.Black;
                }
            }
        }

        //BOTOES
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (btnGravar.ForeColor == Color.Silver)
                labelFooter.Text = "Gravar não disponível!";
            if (emTelaTarefas)
            {
                string titulo = txtTitulo.Text;

                DateTime dataCriacao = DTCriacao.Value;
                PrioridadeEnum prioridade;


                if (txtPrioridade.SelectedItem != null)
                    prioridade = (PrioridadeEnum)txtPrioridade.SelectedItem;
                else
                    prioridade = PrioridadeEnum.Baixa;

                Tarefa tarefaGravar = new Tarefa(titulo, dataCriacao, prioridade);

                string resultadoValidacao = tarefa.Validar(titulo, dataCriacao);
                if (resultadoValidacao == "ESTA_VALIDO")
                {
                    controladorTarefa.InserirNovo(tarefaGravar);
                    labelFooter.Text = "Gravado com sucesso!";
                }
                else
                {
                    MessageBox.Show("Erro! "+ resultadoValidacao);
                    labelFooter.Text = "Erro ao gravar!";
                }

                AtualizarTabelaAtual();
                LimparSelecaoTarefa();
            }
            else if (emTelaContatos)
            {
                string nome = txtNome.Text;
                string telefone = txtTelefone.Text;
                string cargo = cbCargo.Text;
                string email = txtEmail.Text;
                string empresa = txtEmpresa.Text;

                Contato contatoGravar = new Contato(nome, email, telefone, empresa, cargo);

                string resultadoValidacao = contato.Validar(email, telefone);
                if (resultadoValidacao == "ESTA_VALIDO")
                {
                    controladorContato.InserirNovo(contatoGravar);
                    labelFooter.Text = "Gravado com sucesso!";
                }
                else
                {
                    MessageBox.Show("Erro! " + resultadoValidacao);
                    labelFooter.Text = "Erro ao gravar!";
                }

                AtualizarTabelaAtual();
                LimparSelecaoContato();
            }
            else if (emTelaCompromissos)
            {
                string assunto = txtAssunto.Text;
                DateTime data = dtCompromisso.Value;
                string local = txtLocal.Text;
                Contato contato = EncontrarContato(cbContatosCompromisso.Text);

                string resultadoValidacao = compromisso.Validar(assunto, data, dtInicio.Text, dtFim.Text);
                if (resultadoValidacao == "ESTA_VALIDO")
                {
                    TimeSpan horaInicio = TransformarEmTimeSpan(dtInicio.Text);
                    TimeSpan horaFim = TransformarEmTimeSpan(dtFim.Text);
                    Compromisso compromissoGravar = new Compromisso(assunto, local, local, data, horaInicio, horaFim, contato);

                    controladorCompromisso.InserirNovo(compromissoGravar);
                    labelFooter.Text = "Gravado com sucesso!";
                }
                else
                {
                    MessageBox.Show("Erro! " + resultadoValidacao);
                    labelFooter.Text = "Erro ao gravar!";
                }

                AtualizarTabelaAtual();
                LimparSelecaoCompromisso();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.ForeColor == Color.Silver)
                labelFooter.Text = "Editar não disponível!";
            else if (emTelaTarefas)
            {
                if (btnEditar.Text == "Cancelar")
                {
                    LimparSelecaoTarefa();
                    btnEditar.Text = "Editar";
                    labelFooter.Text = "Cancelamento realizado com sucesso!";
                }
                else if (btnEditar.ForeColor == Color.Black)
                {
                    DTCriacao.Enabled = false;
                    labelDataCriacao.ForeColor = Color.Silver;
                    btnExcluir.ForeColor = Color.Silver;
                    labelPConcluido.Visible = true;
                    cmbPorcentagem.Visible = true;
                    cbConcluirTarefa.Visible = true;
                    bntConcluido.Visible = true;

                    var item = controladorTarefa.SelecionarPorId(id);

                    txtTitulo.Text = item.Titulo;
                    DTCriacao.Value = item.DataCriacao;
                    txtPrioridade.SelectedItem = item.Prioridade;
                    cmbPorcentagem.Value = item.Percentual;

                    labelFooter.Text = "Editando...";
                    btnEditar.Text = "Cancelar";
                }
                else
                    MessageBox.Show("Selecione UMA linha para editar...");
            }
            else if (emTelaContatos)
            {
                if (btnEditar.Text == "Cancelar")
                {
                    LimparSelecaoContato();
                    btnEditar.Text = "Editar";
                    labelFooter.Text = "Cancelamento realizado com sucesso!";
                }
                else if (btnEditar.ForeColor == Color.Black)
                {
                    btnExcluir.ForeColor = Color.Silver;
                    bntConcluido.Visible = true;

                    var item = controladorContato.SelecionarPorId(id);

                    txtNome.Text = item.Nome;
                    txtTelefone.Text = item.Telefone;
                    cbCargo.Text = item.Cargo;
                    txtEmail.Text = item.Email;
                    txtEmpresa.Text = item.Empresa;

                    labelFooter.Text = "Editando...";
                    btnEditar.Text = "Cancelar";
                }
                else
                    MessageBox.Show("Selecione UMA linha para editar...");
            }
            else if (emTelaCompromissos)
            {
                if (btnEditar.Text == "Cancelar")
                {
                    LimparSelecaoCompromisso();
                    btnEditar.Text = "Editar";
                    labelFooter.Text = "Cancelamento realizado com sucesso!";
                }
                else if (btnEditar.ForeColor == Color.Black)
                {
                    btnExcluir.ForeColor = Color.Silver;
                    bntConcluido.Visible = true;

                    var item = controladorCompromisso.SelecionarPorId(id);

                    txtAssunto.Text = item.Assunto;
                    dtCompromisso.Value = item.Data;
                    txtLocal.Text = item.Local;
                    cbContatosCompromisso.Text = item.Contato.Nome;
                    dtInicio.Text = item.HoraInicio.ToString(@"hh\:mm");
                    dtFim.Text = item.HoraTermino.ToString(@"hh\:mm"); ;

                    labelFooter.Text = "Editando...";
                    btnEditar.Text = "Cancelar";
                }
                else
                    MessageBox.Show("Selecione UMA linha para editar...");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (btnExcluir.ForeColor == Color.Silver)
                labelFooter.Text = "Excluir não disponível!";
            else if (emTelaTarefas)
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir a tarefa?", "Alerta!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    controladorTarefa.Excluir(id);
                    labelFooter.Text = "Excluído com sucesso!";
                    AtualizarTabelaAtual();
                }
                else if (dialogResult == DialogResult.No)
                    labelFooter.Text = "Erro! exclusão cancelada...";
            }
            else if (emTelaContatos)
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir o contato?", "Alerta!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    controladorContato.Excluir(id);
                    labelFooter.Text = "Excluído com sucesso!";
                    AtualizarTabelaAtual();
                }
                else if (dialogResult == DialogResult.No)
                    labelFooter.Text = "Erro! exclusão cancelada...";
            }
            else if (emTelaCompromissos)
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir o compromisso?", "Alerta!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    controladorCompromisso.Excluir(id);
                    labelFooter.Text = "Excluído com sucesso!";
                    AtualizarTabelaAtual();
                }
                else if (dialogResult == DialogResult.No)
                    labelFooter.Text = "Erro! exclusão cancelada...";
            }
        }

        private void bntConcluido_Click(object sender, EventArgs e)
        {
            if (emTelaTarefas)
            {
                string titulo = txtTitulo.Text;
                int porcentagem = Convert.ToInt32(cmbPorcentagem.Value);
                PrioridadeEnum prioridade;
                if (txtPrioridade.SelectedItem != null)
                    prioridade = (PrioridadeEnum)txtPrioridade.SelectedItem;
                else
                    prioridade = PrioridadeEnum.Baixa;

                var item = controladorTarefa.SelecionarPorId(id);
                DTCriacao.Value = item.DataCriacao;

                Tarefa tarefaEditar = new Tarefa(titulo, item.DataCriacao, prioridade, porcentagem);

                string resultadoValidacao = tarefa.Validar(titulo, item.DataCriacao);
                if (resultadoValidacao == "ESTA_VALIDO")
                {
                    controladorTarefa.Editar(id, tarefaEditar);
                    labelFooter.Text = "Editado com sucesso!";
                }
                else
                {
                    MessageBox.Show("Erro! "+ resultadoValidacao);
                    labelFooter.Text = "Erro ao editar!";
                }

                if (cbConcluirTarefa.Checked)
                    controladorTarefa.AtualizarPercentual(id, 100);

                labelFooter.Text = "Editado com sucesso!";
                btnEditar.Text = "Editar";

                LimparSelecaoTarefa();
                AtualizarTabelaAtual();
            }
            else if (emTelaContatos)
            {
                string nome = txtNome.Text;
                string telefone = txtTelefone.Text;
                string cargo = cbCargo.Text;
                string email = txtEmail.Text;
                string empresa = txtEmpresa.Text;

                Contato contatoGravar = new Contato(nome, email, telefone, empresa, cargo);

                string resultadoValidacao = contato.Validar(email, telefone);

                if (resultadoValidacao == "ESTA_VALIDO")
                {
                    controladorContato.Editar(id, contatoGravar);
                    labelFooter.Text = "Editado com sucesso!";
                }
                else
                {
                    MessageBox.Show("Erro! " + resultadoValidacao);
                    labelFooter.Text = "Erro ao editar!";
                }

                labelFooter.Text = "Editado com sucesso!";
                btnEditar.Text = "Editar";

                LimparSelecaoContato();
                AtualizarTabelaAtual();
            }
            else if (emTelaCompromissos)
            {
                string assunto = txtAssunto.Text;
                DateTime data = dtCompromisso.Value;
                string local = txtLocal.Text;
                Contato contato = EncontrarContato(cbContatosCompromisso.Text);

                string resultadoValidacao = compromisso.Validar(assunto, data, dtInicio.Text, dtFim.Text);
                if (resultadoValidacao == "ESTA_VALIDO")
                {
                    TimeSpan horaInicio = TransformarEmTimeSpan(dtInicio.Text);
                    TimeSpan horaFim = TransformarEmTimeSpan(dtFim.Text);
                    Compromisso compromissoGravar = new Compromisso(assunto, local, local, data, horaInicio, horaFim, contato);

                    controladorCompromisso.Editar(id, compromissoGravar);
                    labelFooter.Text = "Editado com sucesso!";
                }
                else
                {
                    MessageBox.Show("Erro! " + resultadoValidacao);
                    labelFooter.Text = "Erro ao editar!";
                }

                labelFooter.Text = "Editado com sucesso!";
                btnEditar.Text = "Editar";

                LimparSelecaoCompromisso();
                AtualizarTabelaAtual();
            }
        }

        //TAREFAS
        bool seletorDeTabelaTarefa = false;

        private void alimentarPrioridade()
        {
            txtPrioridade.Items.Clear();

            PrioridadeEnum[] prioridades = new PrioridadeEnum[]
            {
                PrioridadeEnum.Alta,
                PrioridadeEnum.Normal,
                PrioridadeEnum.Baixa
            };

            foreach (var item in prioridades)
            {
                txtPrioridade.Items.Add(item);
            }
        }

        private void gerarTabelaTarefasPendentes()
        {
            dataGridTarefa.DataSource = controladorTarefa.SelecionarTodasTarefasPendentes();
        }

        private void gerarTabelaTarefasConcluidos()
        {
            dataGridTarefa.DataSource = controladorTarefa.SelecionarTodasTarefasConcluidas();
        }

        private void MudarTabela_Click(object sender, EventArgs e)
        {
            labelFooter.Text = "Mudando tabela...";
            MudarTabelaTarefa();
        }

        private void MudarTabelaTarefa()
        {
            if (seletorDeTabelaTarefa == false)
            {
                dataGridTarefa.Columns[4].Visible = false;
                dataGridTarefa.Columns[5].Visible = true;
                gerarTabelaTarefasConcluidos();

                labelInformativo.Text = "Todas as tarefas concluídas:";
                MudarTabela.Text = "Mostrar Tarefas Pendentes";
                seletorDeTabelaTarefa = true;
            }
            else if (seletorDeTabelaTarefa == true)
            {
                dataGridTarefa.Columns[4].Visible = true;
                dataGridTarefa.Columns[5].Visible = false;
                gerarTabelaTarefasPendentes();

                labelInformativo.Text = "Todas as tarefas pendentes:";
                MudarTabela.Text = "Mostrar Tarefas Concluídas";
                seletorDeTabelaTarefa = false;
            }
        }

        private void LimparSelecaoTarefa()
        {
            txtTitulo.Text = "";
            DTCriacao.Value = DateTime.Now;
            txtPrioridade.SelectedItem = "";
            cmbPorcentagem.Value = 0;

            labelPConcluido.Visible = false;
            cmbPorcentagem.Visible = false;
            cbConcluirTarefa.Visible = false;
            bntConcluido.Visible = false;
            btnExcluir.ForeColor = Color.Black;

            DTCriacao.Enabled = true;
            labelDataCriacao.ForeColor = Color.Black;
        }

        private void cbConcluirTarefa_Click(object sender, EventArgs e)
        {

            if (cbConcluirTarefa.Checked)
            {
                cmbPorcentagem.ForeColor = Color.Silver;
                labelPConcluido.ForeColor = Color.Silver;
            }
            else
            {
                labelPConcluido.ForeColor = Color.Black;
                cmbPorcentagem.ForeColor = Color.Black;

            }
        }

        //CONTATOS

        private void gerarTabelaContato()
        {
            dataGridContato.DataSource = controladorContato.SelecionarTodos();
        }

        private void LimparSelecaoContato()
        {
            txtNome.Text = "";
            txtTelefone.Text = "";
            cbCargo.Text = "";
            txtEmail.Text = "";
            txtEmpresa.Text = "";

            bntConcluido.Visible = false;
            btnExcluir.ForeColor = Color.Black;
        }

        private void alimentarCargos()
        {
            List<Contato> contatos = controladorContato.SelecionarTodos();
            List<string> cargos = new List<string>();
            cbCargo.Items.Clear();


            foreach (var itemCargo in contatos)
            {
                cargos.Add(itemCargo.Cargo);
            }

            for (int i = 0; i < cargos.Count; i++)
            {
                for (int j = 0; j < cargos.Count; j++)
                {
                    if (cargos[i] == cargos[j] && j != i)
                    {
                        cargos.RemoveAt(j);
                    }
                }
            }

            foreach (var item in cargos)
            {
                cbCargo.Items.Add(item);
            }
        }

        //COMPROMISSO
        private void gerarTabelaCompromissoTodos()
        {
            List<Compromisso> compromissos = controladorCompromisso.SelecionarTodos();

            //foreach (var item in compromissos)
            //{
            //    DataRow registro = CompromissosDT.NewRow();

            //    registro["ID"] = item.Id;
            //    registro["Assunto"] = item.Assunto;
            //    registro["Local ou Link"] = item.Local;
            //    registro["Data"] = item.Data;
            //    registro["Hora de início"] = item.HoraInicio;
            //    registro["Hora de Término"] = item.HoraTermino;
            //    registro["Contato"] = item.Contato.Nome;

            //    CompromissosDT.Rows.Add(registro);
            //}

            dataGridCompromisso.DataSource = compromissos;
        }

        private void gerarTabelaCompromissoFuturos(DateTime dtFiltroInicio, DateTime dtFiltroFim)
        {
            dataGridCompromisso.DataSource = controladorCompromisso.SelecionarCompromissosFuturos(dtFiltroInicio, dtFiltroFim);
        }

        private void MudarTabelaCompromissos_Click(object sender, EventArgs e)
        {
            if (MudarTabelaCompromissos.Text == "Filtrar")
            {
                dtFiltroInicio.Visible = false;
                dtFiltroFim.Visible = false;
                labelFiltro.Visible = false;
                gerarTabelaCompromissoFuturos(dtFiltroInicio.Value, dtFiltroFim.Value);
                MudarTabelaCompromissos.Text = "Limpar filtro";
                labelInformativoCompromisso.Text = "Compromissos filtrados:";
                
                btnGravar.ForeColor = Color.Black;
                btnExcluir.ForeColor = Color.Black;
            }
            else if (MudarTabelaCompromissos.Text == "Limpar filtro")
            {
                labelInformativoCompromisso.Text = "Todos os compromissos:";
                MudarTabelaCompromissos.Text = "Filtrar por Data";
                gerarTabelaCompromissoTodos();
            }
            else if (MudarTabelaCompromissos.Text == "Filtrar por Data")
            {
                btnGravar.ForeColor = Color.Silver;
                btnEditar.ForeColor = Color.Silver;
                btnExcluir.ForeColor = Color.Silver;
                MudarTabelaCompromissos.Text = "Filtrar";
                dtFiltroInicio.Visible = true;
                dtFiltroFim.Visible = true;
                labelFiltro.Visible = true;
            }
        }

        private void alimentarContatos()
        {
            List<Contato> contatos = controladorContato.SelecionarTodos();

            cbContatosCompromisso.Items.Clear();

            foreach (var item in contatos)
            {
                cbContatosCompromisso.Items.Add(item.Nome);
            }
        }

        private void LimparSelecaoCompromisso()
        {
            txtAssunto.Text = "";
            dtCompromisso.Value = DateTime.Now;
            txtLocal.Text = "";
            cbContatosCompromisso.Text = "";
            dtInicio.Text = "";
            dtFim.Text = "";

            bntConcluido.Visible = false;
            btnExcluir.ForeColor = Color.Black;
        }

        private TimeSpan TransformarEmTimeSpan(string tempo)
        {
            string[] horario = tempo.Split(':');
            int hora = Convert.ToInt32(horario[0]);
            int minuto = Convert.ToInt32(horario[1]);

            return new TimeSpan(hora, minuto, 0);
        }

        private Contato EncontrarContato(string nomeContato)
        {
            List<Contato> contatos = controladorContato.SelecionarTodos();

            foreach (var item in contatos)
            {
                if (nomeContato == item.Nome)
                {
                    return controladorContato.SelecionarPorId(item.Id);
                }
            }
            return null;
        }
    }
}
