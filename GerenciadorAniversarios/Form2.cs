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
    public partial class Form2 : Form
    {
        Acao.Operacao _valor;
        public Form2(Aniversariante aniversariante, Acao.Operacao valor)
        {
            _valor = valor;
            InitializeComponent();
            ExibirAniversariante(aniversariante);

        }
        private void ExibirAniversariante(Aniversariante aniversariante)
        {
            txtID.Text = aniversariante.AniversarianteId.ToString();
            txtNome.Text = aniversariante.Nome;
            txtEmail.Text = aniversariante.Sobrenome;
            txtNome.Focus();
        }

        private void btnConfirmar_Click(object sender, System.EventArgs e)
        {
            var codigo = Convert.ToInt32(txtID.Text);

            if (_valor == Acao.Operacao.edit)
            {
                using (var context = new ApplicationDBContext())
                {
                    var aniversariante = context.Aniversariantes.First(a => a.AniversarianteId == codigo);
                    aniversariante.Nome = txtNome.Text;
                    aniversariante.Sobrenome = txtEmail.Text;
                    context.SaveChanges();
                }
            }
            else if (_valor == Acao.Operacao.del)
            {
                using (var context = new ApplicationDBContext())
                {
                    var aniversariante = context.Aniversariantes.First(a => a.AniversarianteId == codigo);
                    context.Remove(aniversariante);
                    context.SaveChanges();
                }
            }
            else if (_valor == Acao.Operacao.add)
            {
                using (var context = new ApplicationDBContext())
                {
                    Aniversariante aniversariante = new Aniversariante();
                    aniversariante.Nome = txtNome.Text;
                    aniversariante.Sobrenome = txtEmail.Text;
                    context.Add(aniversariante);
                    context.SaveChanges();
                }
            }
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
