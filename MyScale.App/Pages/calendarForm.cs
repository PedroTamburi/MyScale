using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Globalization; // Necessário para AM/PM funcionar em qualquer PC

namespace MyScale.App.Pages
{
    public partial class calendarForm : Form
    {
        public DateTime DataInicioEscolhida { get; private set; }
        public DateTime DataFimEscolhida { get; private set; }
        public DateTime DataBaseEscolhida { get; private set; }

        private int _mesAtual;
        private int _anoAtual;

        //guarda o dia selecionado
        private int _diaSelecionado = 0;
        public calendarForm()
        {
            InitializeComponent();

            _mesAtual = DateTime.Now.Month;
            _anoAtual = DateTime.Now.Year;

            ConfigurarGrid();
            GerarCalendario(_mesAtual, _anoAtual);
            CarregarHorarios();
        }

        #region Metodos
        private void ConfigurarGrid()
        {
            gridCalendario.Columns.Clear();

            string[] diasSemana = { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sáb" };

            foreach (var dia in diasSemana)
            {
                gridCalendario.Columns.Add(dia, dia);
            }

            gridCalendario.RowTemplate.Height = 50;
            gridCalendario.ScrollBars = ScrollBars.None;
            gridCalendario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int alturaDisponivel = gridCalendario.Height - gridCalendario.ColumnHeadersHeight;
            gridCalendario.RowTemplate.Height = alturaDisponivel / 6;
            gridCalendario.AllowUserToResizeRows = false;

            gridCalendario.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCalendario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void GerarCalendario(int mes, int ano)
        {
            // atualiza o label do mes e ano
            lblMesAno.Text = $"{new DateTime(ano, mes, 1):MMMM yyyy}".ToUpper();

            gridCalendario.Rows.Clear();
            gridCalendario.Rows.Add(6);

            DateTime primeiroDiaDoMes = new DateTime(ano, mes, 1);

            int diaSemanaInicio = (int)primeiroDiaDoMes.DayOfWeek;

            int totalDiasMes = DateTime.DaysInMonth(ano, mes);

            int diaAtual = 1;

            for (int i = 0; i < 6; i++) // Semanas
            {
                for (int j = 0; j < 7; j++) // Dias da semana
                {
                    if ((i == 0 && j < diaSemanaInicio) || diaAtual > totalDiasMes)
                    {
                        gridCalendario.Rows[i].Cells[j].Value = ""; // Célula vazia
                        gridCalendario.Rows[i].Cells[j].Style.BackColor = Color.WhiteSmoke; // Cor de "inativo"
                    }
                    else
                    {
                        bool ehHoje = (diaAtual == DateTime.Now.Day && mes == DateTime.Now.Month && ano == DateTime.Now.Year);

                        if (ehHoje)
                        {
                            gridCalendario.Rows[i].Cells[j].Value = "Hoje";

                            gridCalendario.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
                            gridCalendario.Rows[i].Cells[j].Style.Font = new Font(gridCalendario.Font, FontStyle.Bold);
                        }
                        else
                        {
                            gridCalendario.Rows[i].Cells[j].Value = diaAtual;

                            gridCalendario.Rows[i].Cells[j].Style.BackColor = Color.White;
                            gridCalendario.Rows[i].Cells[j].Style.Font = new Font(gridCalendario.Font, FontStyle.Regular);
                        }

                        diaAtual++;
                    }
                }
            }
            gridCalendario.ClearSelection();
        }
        private void CarregarHorarios()
        {
            comboInicio.Items.Clear();
            comboFim.Items.Clear();

            for (int i = 0; i < 24; i++)
            {
                DateTime hora = new DateTime(2000, 1, 1, i, 0, 0);

                string textoHora = hora.ToString("HH:mm");

                comboInicio.Items.Add(textoHora);
                comboFim.Items.Add(textoHora);
            }
        }
        #endregion

        #region eventos
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            _mesAtual--;
            if (_mesAtual < 1) { _mesAtual = 12; _anoAtual--; }
            GerarCalendario(_mesAtual, _anoAtual);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            _mesAtual++;
            if (_mesAtual > 12) { _mesAtual = 1; _anoAtual++; }
            GerarCalendario(_mesAtual, _anoAtual);
        }

        private void gridCalendario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var valorCelula = gridCalendario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

            //vazio
            if (string.IsNullOrEmpty(valorCelula)) return;

            if (valorCelula == "Hoje")
            {
                _diaSelecionado = DateTime.Now.Day;
            }
            else if (int.TryParse(valorCelula, out int dia))
            {
                _diaSelecionado = dia;
            }
            else
            {
                return;
            }

            gridCalendario.ClearSelection();
            gridCalendario.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // verifica se um dia foi selecionado
            if (_diaSelecionado == 0)
            {
                MessageBox.Show("Selecione um dia no calendário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // verifica se uma hora foi selecionada
            if (comboInicio.SelectedIndex < 0 || comboFim.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o horário de INÍCIO e FIM do plantão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // converte as horas selecionadas para TimeSpan
            TimeSpan.TryParse(comboInicio.Text, out TimeSpan horaInicio);
            TimeSpan.TryParse(comboFim.Text, out TimeSpan horaFim);

            // verifica se a hora final é maior que a inicial
            if (horaFim <= horaInicio)
            {
                MessageBox.Show("O horário final deve ser maior que o inicial!", "Erro no Horário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Data Base (Dia escolhido)
            DateTime dataBase = new DateTime(_anoAtual, _mesAtual, _diaSelecionado);

            // Data Inicio Completa (Dia + Hora Inicio)
            DateTime dataInicioCompleta = dataBase.Add(horaInicio);

            // Data Fim Completa (Dia + Hora Fim)
            DateTime dataFimCompleta = dataBase.Add(horaFim);

            // verifica se a data é no passado
            if (dataInicioCompleta < DateTime.Now)
            {
                MessageBox.Show("Não é possível agendar um plantão no passado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // calcula a duração
            TimeSpan duracao = horaFim - horaInicio;

            var resposta = MessageBox.Show(
                $"Confirma o agendamento do plantão?\n\n" +
                $"Data: {dataBase:dd/MM/yyyy}\n" +
                $"Horário: Das {horaInicio:hh\\:mm} às {horaFim:hh\\:mm}\n" +
                $"Duração: {duracao.TotalHours} horas",
                "Confirmar Plantão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                //salva 
                this.DataInicioEscolhida = dataInicioCompleta;
                this.DataFimEscolhida = dataFimCompleta;
                this.DataBaseEscolhida = dataBase;

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }
        #endregion
    }
}
