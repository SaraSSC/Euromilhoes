using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuromilhoesForm
{
    public partial class Form1 : Form

    {
           
        public Form1()
        {
            InitializeComponent();

            cBLChave.ItemCheck += (s, e) =>
            {
                if (cBLChave.CheckedItems.Count >= 5 && e.NewValue == CheckState.Checked)
                {
                    e.NewValue = CheckState.Unchecked;
                }
            };

            cLBEstrela.ItemCheck += (s, e) =>
            {
                if (cLBEstrela.CheckedItems.Count >= 2 && e.NewValue == CheckState.Checked)
                {
                    e.NewValue = CheckState.Unchecked;
                }
            };
        }
        private void GerarChaveEComparar()
        {
            Random rand = new Random();
            List<int> chaveNumeros = new List<int>();
            List<int> chaveEstrelas = new List<int>();

            // Gerar 5 números únicos para a chave
            while (chaveNumeros.Count < 5)
            {
                int num = rand.Next(1, 51); // números de 1 a 50
                if (!chaveNumeros.Contains(num))
                {
                    chaveNumeros.Add(num);
                }
            }

            // Gerar 2 estrelas únicas para a chave
            while (chaveEstrelas.Count < 2)
            {
                int estrela = rand.Next(1, 10); // estrelas de 1 a 9
                if (!chaveEstrelas.Contains(estrela))
                {
                    chaveEstrelas.Add(estrela);
                }
            }

            // Obter a aposta do usuário
            
            List<int> apostaNumeros = cBLChave.CheckedItems.Cast<string>().Select(int.Parse).ToList();
            List<int> apostaEstrelas = cLBEstrela.CheckedItems.Cast<string>().Select(int.Parse).ToList();


            // Comparar a aposta com a chave e determinar o prêmio
            int acertosNumeros = apostaNumeros.Intersect(chaveNumeros).Count();
            int acertosEstrelas = apostaEstrelas.Intersect(chaveEstrelas).Count();

            string premio;
            if (acertosNumeros == 5 && acertosEstrelas == 2)
            {
                premio = "1º Prêmio";
            }
            else if (acertosNumeros == 5 && acertosEstrelas == 1)
            {
                premio = "2º Prêmio";
            }
            else if (acertosNumeros == 5)
            {
                premio = "3º Prêmio";
            }
            else if (acertosNumeros == 4 && acertosEstrelas == 2)
            {
                premio = "4º Prêmio";
            }
            else if (acertosNumeros == 4 && acertosEstrelas == 1)
            {
                premio = "5º Prêmio";
            }
            else if (acertosNumeros == 4)
            {
                premio = "6º Prêmio";
            }
            else
            {
                premio = "Sem prêmio";
            }

            // Exibir o resultado
            
            MessageBox.Show( $"Você acertou {acertosNumeros} números\n e {acertosEstrelas} estrelas.\n {premio}!\n");
            

            // Exibir as chaves e as estrelas que foram geradas
            string chaveNumerosStr = string.Join(", ", chaveNumeros);
            string chaveEstrelasStr = string.Join(", ", chaveEstrelas);
            lblResultChaves.Text = $"Chaves geradas: {chaveNumerosStr}| Estrelas: {chaveEstrelasStr} ";
        }

        private void btnGerarChave_Click(object sender, EventArgs e)
        {
            // Verificar se o usuário selecionou 5 números e 2 estrelas
            if (cBLChave.CheckedItems.Count != 5)
            {
                MessageBox.Show("Por favor, selecione exatamente 5 números.");
                return;
            }
            if (cLBEstrela.CheckedItems.Count != 2)
            {
                MessageBox.Show("Por favor, selecione exatamente 2 estrelas.");
                return;
            }

            GerarChaveEComparar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblResultChaves_Click(object sender, EventArgs e)
        {

        }

        private void lblResultEstrelas_Click(object sender, EventArgs e)
        {

        }

        private void cBLChave_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cLBEstrela_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGerarChave_Click_1(object sender, EventArgs e)
        {
            GerarChaveEComparar();
        }
    }
}
