using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorAniversarios.Models;

namespace GerenciadorAniversarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ExibirAniversariantes();
        }
        private void lbAniversariantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var aniversarianteSelecionado = (Aniversariante)lbAniversariantes.SelectedItem;

            txtID.Text = aniversarianteSelecionado.AniversarianteId.ToString();
            txtNome.Text = aniversarianteSelecionado.Nome;
            txtSobrenome.Text = aniversarianteSelecionado.Sobrenome;
        }
        public bool ValidaAcao()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
                return false;
            else
                return true;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidaAcao())
            {
                var aniversariante = (Aniversariante)lbAniversariantes.SelectedItem;
                Form2 frm = new Form2(aniversariante, Acao.Operacao.edit);
                frm.ShowDialog();
                ExibirAniversariantes();
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ValidaAcao())
            {
                var aniversariante = (Aniversariante)lbAniversariantes.SelectedItem;
                Form2 frm = new Form2(aniversariante, Acao.Operacao.del);
                frm.ShowDialog();
                ExibirAniversariantes();
            }
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (ValidaAcao())
            {
                var aniversariante = new Aniversariante();
                Form2 frm = new Form2(aniversariante, Acao.Operacao.add);
                frm.ShowDialog();
                ExibirAniversariantes();
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar?", "Encerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
        private void ExibirAniversariantes()
        {
            List<Aniversariante> aniversariantes;
            lbAniversariantes.Items.Clear();

            using (var ctx = new ApplicationDBContext())
            {
                aniversariantes = ctx.Aniversariantes.ToList();
            }
            foreach (var aniversariante in aniversariantes)
                lbAniversariantes.Items.Add(aniversariante);
        }
    }
   

}
