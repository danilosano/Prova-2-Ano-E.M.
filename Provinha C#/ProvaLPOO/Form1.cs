using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaDoCapeta
{
    public partial class Form1 : Form
    {
        string botao1 = "0", botao2 = "0", botao3 = "0", botao4 = "0", botao5 = "0", botao6 = "0", botao7 = "0", botao8 = "0", botao9 = "0", botao10 = "0";
        public Form1()
        {
            InitializeComponent();
        }

        private void responder(object sender, EventArgs e)
        {
            if (Convert.ToInt32(num_questao.Text) == 1)
            {
                if (botao1 == "0")
                {
                    if (radioButton1.Checked)
                    {
                        radioButton1.BackColor = Color.Red;
                        botao1 = "1";
                    }
                    else if (radioButton2.Checked)
                    {
                        radioButton2.BackColor = Color.Red;
                        botao1 = "1";
                    }
                    else if (radioButton3.Checked)
                    {
                        radioButton3.BackColor = Color.Red;
                        botao1 = "1";
                    }
                    else if (radioButton4.Checked)
                    {
                        acertos.Text = Convert.ToString(Convert.ToInt32(acertos.Text) + 1);
                        radioButton4.BackColor = Color.Green;
                        botao1 = "1";
                    }
                }
                else
                {
                    MessageBox.Show("Já respondeu");
                }
            }
            if (Convert.ToInt32(num_questao.Text) == 2)
            {
                if (botao2 == "0")
                {
                    if (radioButton1.Checked)
                    {
                        radioButton1.BackColor = Color.Red;
                        radioButton4.BackColor = Color.Green;
                        botao2 = "1";
                    }
                    else if (radioButton2.Checked)
                    {
                        radioButton2.BackColor = Color.Red;
                        radioButton4.BackColor = Color.Green;
                        botao2 = "1";
                    }
                    else if (radioButton3.Checked)
                    {
                        radioButton3.BackColor = Color.Red;
                        radioButton4.BackColor = Color.Green;
                        botao2 = "1";
                    }
                    else if (radioButton4.Checked)
                    {
                        acertos.Text = Convert.ToString(Convert.ToInt32(acertos.Text) + 1);
                        radioButton4.BackColor = Color.Green;
                        botao2 = "1";
                    }
                }
                else
                {
                    MessageBox.Show("Já respondeu");
                }
            }
            if (Convert.ToInt32(num_questao.Text) == 3)
            {
                if (botao3 == "0")
                {
                    if (radioButton1.Checked)
                    {
                        radioButton1.BackColor = Color.Red;
                        radioButton3.BackColor = Color.Green;
                        botao3 = "1";
                    }
                    else if (radioButton2.Checked)
                    {
                        radioButton2.BackColor = Color.Red;
                        radioButton3.BackColor = Color.Green;
                        botao3 = "1";
                    }
                    else if (radioButton3.Checked)
                    {
                        acertos.Text = Convert.ToString(Convert.ToInt32(acertos.Text) + 1);
                        radioButton3.BackColor = Color.Green;
                        botao3 = "1";
                    }
                    else if (radioButton4.Checked)
                    {
                        radioButton4.BackColor = Color.Red;
                        radioButton3.BackColor = Color.Green;
                        botao3 = "1";
                    }
                }
                else
                {
                    MessageBox.Show("Já respondeu");
                }
            }
            if (Convert.ToInt32(num_questao.Text) == 4)
            {
                if (botao4 == "0")
                {
                    if (radioButton1.Checked)
                    {
                        radioButton1.BackColor = Color.Red;
                        radioButton4.BackColor = Color.Green;
                        botao4 = "1";
                    }
                    else if (radioButton2.Checked)
                    {
                        radioButton2.BackColor = Color.Red;
                        radioButton4.BackColor = Color.Green;
                        botao4 = "1";
                    }
                    else if (radioButton3.Checked)
                    {
                        radioButton4.BackColor = Color.Green;
                        radioButton3.BackColor = Color.Red;
                        botao4 = "1";
                    }
                    else if (radioButton4.Checked)
                    {
                        radioButton4.BackColor = Color.Green;
                        acertos.Text = Convert.ToString(Convert.ToInt32(acertos.Text) + 1);
                        botao4 = "1";
                    }
                }
                else
                {
                    MessageBox.Show("Já respondeu");
                }
            }
            if (Convert.ToInt32(num_questao.Text) == 5)
            {
                if (botao5 == "0")
                {
                    if (radioButton1.Checked)
                    {
                        radioButton1.BackColor = Color.Green;
                        acertos.Text = Convert.ToString(Convert.ToInt32(acertos.Text) + 1);
                        botao5 = "1";
                    }
                    else if (radioButton2.Checked)
                    {
                        radioButton2.BackColor = Color.Red;
                        radioButton1.BackColor = Color.Green;
                        botao5 = "1";
                    }
                    else if (radioButton3.Checked)
                    {
                        radioButton1.BackColor = Color.Green;
                        radioButton3.BackColor = Color.Red;
                        botao5 = "1";
                    }
                    else if (radioButton4.Checked)
                    {
                        radioButton4.BackColor = Color.Red;
                        radioButton1.BackColor = Color.Green;
                        botao5 = "1";
                    }
                }
                else
                {
                    MessageBox.Show("Já respondeu");
                }
            }
            if (Convert.ToInt32(num_questao.Text) == 6)
            {
                if (botao6 == "0")
                {
                    if (radioButton1.Checked)
                    {
                        radioButton1.BackColor = Color.Red;
                        radioButton3.BackColor = Color.Green;
                        botao6 = "1";
                    }
                    else if (radioButton2.Checked)
                    {
                        radioButton2.BackColor = Color.Red;
                        radioButton3.BackColor = Color.Green;
                        botao6 = "1";
                    }
                    else if (radioButton3.Checked)
                    {
                        acertos.Text = Convert.ToString(Convert.ToInt32(acertos.Text) + 1);
                        radioButton3.BackColor = Color.Green;
                        botao6 = "1";
                    }
                    else if (radioButton4.Checked)
                    {
                        radioButton4.BackColor = Color.Red;
                        radioButton3.BackColor = Color.Green;
                        botao6 = "1";
                    }
                }
                else
                {
                    MessageBox.Show("Já respondeu");
                }
            }
            if (Convert.ToInt32(num_questao.Text) == 7)
            {
                if (botao7 == "0")
                {
                    if (radioButton1.Checked)
                    {
                        radioButton1.BackColor = Color.Green;
                        acertos.Text = Convert.ToString(Convert.ToInt32(acertos.Text) + 1);
                        botao7 = "1";
                    }
                    else if (radioButton2.Checked)
                    {
                        radioButton2.BackColor = Color.Red;
                        radioButton1.BackColor = Color.Green;
                        botao7 = "1";
                    }
                    else if (radioButton3.Checked)
                    {
                        radioButton1.BackColor = Color.Green;
                        radioButton3.BackColor = Color.Red;
                        botao7 = "1";
                    }
                    else if (radioButton4.Checked)
                    {
                        radioButton4.BackColor = Color.Red;
                        radioButton1.BackColor = Color.Green;
                        botao7 = "1";
                    }
                }
                else
                {
                    MessageBox.Show("Já respondeu");
                }
            }
            if (Convert.ToInt32(num_questao.Text) == 8)
            {
                if (botao8 == "0")
                {
                    if (radioButton1.Checked)
                    {
                        radioButton1.BackColor = Color.Green;
                        acertos.Text = Convert.ToString(Convert.ToInt32(acertos.Text) + 1);
                        botao8 = "1";
                    }
                    else if (radioButton2.Checked)
                    {
                        radioButton2.BackColor = Color.Red;
                        radioButton1.BackColor = Color.Green;
                        botao8 = "1";
                    }
                    else if (radioButton3.Checked)
                    {
                        radioButton1.BackColor = Color.Green;
                        radioButton3.BackColor = Color.Red;
                        botao8 = "1";
                    }
                    else if (radioButton4.Checked)
                    {
                        radioButton4.BackColor = Color.Red;
                        radioButton1.BackColor = Color.Green;
                        botao8 = "1";
                    }
                }
                else
                {
                    MessageBox.Show("Já respondeu");
                }
            }
            if (Convert.ToInt32(num_questao.Text) == 9)
            {
                if (botao9 == "0")
                {
                    if (radioButton1.Checked)
                    {
                        radioButton1.BackColor = Color.Red;
                        radioButton4.BackColor = Color.Green;
                        botao9 = "1";
                    }
                    else if (radioButton2.Checked)
                    {
                        radioButton2.BackColor = Color.Red;
                        radioButton4.BackColor = Color.Green;
                        botao9 = "1";
                    }
                    else if (radioButton3.Checked)
                    {
                        radioButton4.BackColor = Color.Green;
                        radioButton3.BackColor = Color.Red;
                        botao9 = "1";
                    }
                    else if (radioButton4.Checked)
                    {
                        radioButton4.BackColor = Color.Green;
                        acertos.Text = Convert.ToString(Convert.ToInt32(acertos.Text) + 1);
                        botao9 = "1";
                    }
                }
                else
                {
                    MessageBox.Show("Já respondeu");
                }
            }
            if (Convert.ToInt32(num_questao.Text) == 10)
            {
                if (botao10 == "0")
                {
                    if (radioButton1.Checked)
                    {
                        radioButton1.BackColor = Color.Red;
                        radioButton4.BackColor = Color.Green;
                        botao10 = "1";
                    }
                    else if (radioButton2.Checked)
                    {
                        radioButton2.BackColor = Color.Red;
                        radioButton4.BackColor = Color.Green;
                        botao10 = "1";
                    }
                    else if (radioButton3.Checked)
                    {
                        radioButton4.BackColor = Color.Green;
                        radioButton3.BackColor = Color.Red;
                        botao10 = "1";
                    }
                    else if (radioButton4.Checked)
                    {
                        radioButton4.BackColor = Color.Green;
                        acertos.Text = Convert.ToString(Convert.ToInt32(acertos.Text) + 1);
                        botao10 = "1";
                    }
                }
                else
                {
                    MessageBox.Show("Já respondeu");
                }
            }
        }
        private void aumentar(object sender, EventArgs e)
        {
            num_questao.Text = Convert.ToString(Convert.ToInt32(num_questao.Text) + 1);
            if (Convert.ToInt32(num_questao.Text) == 11)
            {
                num_questao.Text = Convert.ToString(1);
            }
            if (Convert.ToInt32(num_questao.Text) == 1)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Qual destes jogadores não é Alemão?";
                radioButton1.Text = "Marco Reus";
                radioButton2.Text = "Mario Götze";
                radioButton3.Text = "Marcel Schmelzer";
                radioButton4.Text = "Robert Lewandowski";
            }
            if (Convert.ToInt32(num_questao.Text) == 2)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Quantas copas do mundo o brasil venceu?";
                radioButton1.Text = "6";
                radioButton2.Text = "4";
                radioButton3.Text = "3";
                radioButton4.Text = "5";
            }
            if (Convert.ToInt32(num_questao.Text) == 3)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Qual jogador recebeu o prêmio de melhor jogador do mundo em 2007?";
                radioButton1.Text = "Cristiano Ronaldo";
                radioButton2.Text = "Neymar";
                radioButton3.Text = "Kaká";
                radioButton4.Text = "Lionel Messi";
            }
            if (Convert.ToInt32(num_questao.Text) == 4)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Qual time brasileiro tem mais títulos Internacionais?";
                radioButton1.Text = "Flamengo";
                radioButton2.Text = "Vasco";
                radioButton3.Text = "Corinthians";
                radioButton4.Text = "São Paulo";
            }
            if (Convert.ToInt32(num_questao.Text) == 5)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Quem é o jogador mais valioso do mundo?";
                radioButton1.Text = "Neymar Jr.";
                radioButton2.Text = "Lionel Messi";
                radioButton3.Text = "Lukaku";
                radioButton4.Text = "Cristiano Ronaldo";
            }
            if (Convert.ToInt32(num_questao.Text) == 6)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Qual é o clube de futebol mais antigo do brasil?";
                radioButton1.Text = "Flamengo";
                radioButton2.Text = "Vasco";
                radioButton3.Text = "Sport Club Rio Grande";
                radioButton4.Text = "Corinthians";
            }
            if (Convert.ToInt32(num_questao.Text) == 7)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Qual o Goleiro que marcou mais gols na história do futebol?";
                radioButton1.Text = "Rogerio Ceni";
                radioButton2.Text = "Chilavert";
                radioButton3.Text = "René Higuita";
                radioButton4.Text = "Jorge Campos";
            }
            if (Convert.ToInt32(num_questao.Text) == 8)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Onde foi sediada a primeira copa do mundo?";
                radioButton1.Text = "Uruguai";
                radioButton2.Text = "Estados Unidos";
                radioButton3.Text = "Espanha";
                radioButton4.Text = "Brasil";
            }
            if (Convert.ToInt32(num_questao.Text) == 9)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Qual a única equipe que JUNINHO PERNAMBUCANO passou sem conquistar nenhum título?";
                radioButton1.Text = "Sport";
                radioButton2.Text = "Vasco";
                radioButton3.Text = "Lyon";
                radioButton4.Text = "New York Red Bulls";
            }
            if (Convert.ToInt32(num_questao.Text) == 10)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Quais destes jogadores NUNCA atuou pelo Chelsea?";
                radioButton1.Text = "Robben";
                radioButton2.Text = "Shevchenko";
                radioButton3.Text = "Belleti";
                radioButton4.Text = "Xabi Alonso";
            }
        }

        private void diminuir(object sender, EventArgs e)
        {
            num_questao.Text = Convert.ToString(Convert.ToInt32(num_questao.Text) - 1);
            if (Convert.ToInt32(num_questao.Text) == 0)
            {
                num_questao.Text = Convert.ToString(10);
            }
            if (Convert.ToInt32(num_questao.Text) == 1)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Qual destes jogadores não é Alemão?";
                radioButton1.Text = "Marco Reus";
                radioButton2.Text = "Mario Götze";
                radioButton3.Text = "Marcel Schmelzer";
                radioButton4.Text = "Robert Lewandowski";
            }
            if (Convert.ToInt32(num_questao.Text) == 2)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Quantas copas do mundo o brasil venceu?";
                radioButton1.Text = "6";
                radioButton2.Text = "4";
                radioButton3.Text = "3";
                radioButton4.Text = "5";
            }
            if (Convert.ToInt32(num_questao.Text) == 3)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Qual jogador recebeu o prêmio de melhor jogador do mundo em 2007?";
                radioButton1.Text = "Cristiano Ronaldo";
                radioButton2.Text = "Neymar";
                radioButton3.Text = "Kaká";
                radioButton4.Text = "Lionel Messi";
            }
            if (Convert.ToInt32(num_questao.Text) == 4)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Qual time brasileiro tem mais títulos Internacionais?";
                radioButton1.Text = "Flamengo";
                radioButton2.Text = "Vasco";
                radioButton3.Text = "Corinthians";
                radioButton4.Text = "São Paulo";
            }
            if (Convert.ToInt32(num_questao.Text) == 5)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Quem é o jogador mais valioso do mundo?";
                radioButton1.Text = "Neymar Jr.";
                radioButton2.Text = "Lionel Messi";
                radioButton3.Text = "Lukaku";
                radioButton4.Text = "Cristiano Ronaldo";
            }
            if (Convert.ToInt32(num_questao.Text) == 6)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Qual é o clube de futebol mais antigo do brasil?";
                radioButton1.Text = "Flamengo";
                radioButton2.Text = "Vasco";
                radioButton3.Text = "Sport Club Rio Grande";
                radioButton4.Text = "Corinthians";
            }
            if (Convert.ToInt32(num_questao.Text) == 7)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Qual o Goleiro que marcou mais gols na história do futebol?";
                radioButton1.Text = "Rogerio Ceni";
                radioButton2.Text = "Chilavert";
                radioButton3.Text = "René Higuita";
                radioButton4.Text = "Jorge Campos";
            }
            if (Convert.ToInt32(num_questao.Text) == 8)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Onde foi sediada a primeira copa do mundo?";
                radioButton1.Text = "Uruguai";
                radioButton2.Text = "Estados Unidos";
                radioButton3.Text = "Espanha";
                radioButton4.Text = "Brasil";
            }
            if (Convert.ToInt32(num_questao.Text) == 9)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Qual a única equipe que JUNINHO PERNAMBUCANO passou sem conquistar nenhum título?";
                radioButton1.Text = "Sport";
                radioButton2.Text = "Vasco";
                radioButton3.Text = "Lyon";
                radioButton4.Text = "New York Red Bulls";
            }
            if (Convert.ToInt32(num_questao.Text) == 10)
            {
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                enunciado.Text = "Quais destes jogadores NUNCA atuou pelo Chelsea?";
                radioButton1.Text = "Robben";
                radioButton2.Text = "Shevchenko";
                radioButton3.Text = "Belleti";
                radioButton4.Text = "Xabi Alonso";
            }
        }
    }
}
