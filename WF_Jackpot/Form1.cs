using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Jackpot
{
    public partial class Form1 : Form
    {
        int cont = 7, resgate;
        double premio = 0.25;
        string ganhou = "Parabéns, ganhou";
        string perdeu = "Ops,não foi dessa vez...";
        string seventents = "Mais 7 tentativas para você";
        string firststep = "1- O apostador insere uma moeda na máquina; 2- A máquina libera 7 tentativas; 3- Se o jogador fizer uma combinação de qualquer fruta, ele acumula 0,25 centavos de prêmio em cada combinação; 4- Toda vez que o jogador acumular 0,25 terá a opção de continuar apostando ou retirar o prêmio; 5- Se o jogador acumular 0,25 e optar por continuar apostando, ganhará mais 7 tentativas; 6- O jogo termina se o jogador retirar o prêmio ou se esgotar todas as suas tentativas; 7- Se esgotar todas as tentativas, todo o prêmio é perdido; 8- Se o jogador fizer uma combinação do número 7, ele ganha mais 7 tentativas, porém, não ganha os 0,25 centavos";
       // int val1, val2, val3;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbimagem2_Click(object sender, EventArgs e)
        {

        }

        private void lbtentativas_Click(object sender, EventArgs e)
        {

        }

        private void lbpremio_Click(object sender, EventArgs e)
        {

        }

        private void lbtentativas_Click_1(object sender, EventArgs e)
        {

        }

        private void btnmoeda_Click(object sender, EventArgs e)
        {

            lbtentativas.Text = "" + cont--;

            Random sorteia = new Random();

            /*val1 = sorteia.Next(8);
            val2 = sorteia.Next(8);
            val3 = sorteia.Next(8);*/


            pb1.Load("img//" + sorteia.Next(8) + ".jpg");
            pb2.Load("img//" + sorteia.Next(8) + ".jpg");
            pb3.Load("img//" + sorteia.Next(8) + ".jpg");

            /*if(val1 >=0 && val2 == val1 && val3 == val1)
            {
                pb1.Load("img//" + val1 + ".jpg");
                pb2.Load("img//" + val2 + ".jpg");
                pb3.Load("img//" + val3 + ".jpg");

                
            }*/

            //private void Compara() { }
            if (pb1 == pb2 && pb2 == pb1)
            {
                // Esse comando não funciona
                if (cont == 0 && premio >= 0.25)
                {

                    cont = 7;

                    DialogResult result;
                    result = MessageBox.Show(Text = "" + seventents);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {

                        this.Close();
                    }//mais 7 tentativas
                }
            } 
            else
            {

                if (cont == 0 && premio == 0.00)
                {
                    lbpremio.Text = "R$" + premio;

                    DialogResult result;
                    result = MessageBox.Show(Text = "" + perdeu);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                    cont = 7;
                    lbtentativas.Text = "" + cont;

                }//perdeu
            }

           /* if (val1 == 7 && val2 == val1 && val3 == val1)
            {
                pb1.Load("img//7.jpg");
                pb2.Load("img//7.jpg");
                pb3.Load("img//7.jpg");
            }*/

            if (pb1==pb2 && pb2 == pb1) { // Esse comando não funciona
                DialogResult result;
                result = MessageBox.Show(Text = "" + seventents);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    this.Close();
                };
                cont = 7;
            }
        }// Mais 7 sentativas
        

        private void pb1_Click(object sender, EventArgs e)
        {
            
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            
        }

        private void lbpremio_Click_1(object sender, EventArgs e)
        {
            lbpremio.Text = "R$"+ premio;
        }

        private void btninfo_Click(object sender, EventArgs e)//IGNORA:
        {
            DialogResult result;
            result = MessageBox.Show(Text = "" + firststep);
            if (result == System.Windows.Forms.DialogResult.OK)
            {

               this.Close();
            };
        }

        private void btnresgatar_Click(object sender, EventArgs e)
        {
            
            resgate = 1;
            if (cont >= 0 && resgate == 1 && premio >= 0.25)
            {

                DialogResult result;
                result = MessageBox.Show(Text = "" + ganhou + " R$" + premio);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                   
                    this.Close();
                };

                premio = 0.00;
                cont = 7;

            }//ganhou
        }
    }
}
