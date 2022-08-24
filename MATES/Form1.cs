using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.AudioFormat;
using System.Speech.Recognition;
using System.Speech.Synthesis;


namespace MATES
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer Voice = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }
        Random Num1x = new Random();
        Random Num2z = new Random();
        Random SignoResult = new Random();
        int signoR;
        int num1d;
        int num2d;
        int resultado;
        int Coins;
        private void Form1_Load(object sender, EventArgs e)
        {
            num1d = Num1x.Next(1, 10);
            num2d = Num2z.Next(1, 6);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1.Text = num1d.ToString();
            num2.Text = num2d.ToString();
            resultado = num1d + num2d;
            


        }

        private void num1_Click(object sender, EventArgs e)
        {
            
            if (txtNum.Text == resultado.ToString())
            {
                Voice.Speak("Respuesta Correcta, SIGUE ASI");
                MessageBox.Show("Respuesta Correcta");
              
                num1d = Num1x.Next(1, 11);
                num2d = Num2z.Next(1, 9);
                signoR = SignoResult.Next(1, 4);

                num1.Text = num1d.ToString();
                num2.Text = num2d.ToString();
                if(signoR == 1)
                {
                    signo.Text = "x";
                    resultado = num1d * num2d;
                }
                if (signoR == 2)
                {
                    signo.Text = "+";
                    resultado = num1d + num2d;
                }
                if (signoR == 3 || signoR == 4)
                {
                    signo.Text = "-";
                    resultado = num1d - num2d;
                }
             
                Coins++;
                Coin.Text = Coins.ToString();
                txtNum.Text = "";
                if(Coins > 9)
                {
                    hability.Visible = true;
                }
                else if (Coins < 9)
                {
                    hability.Visible = false;
                }
               
            }
            else if(txtNum.Text != resultado.ToString())
            {
                Voice.Speak("Respuesta incorrecta, vuelve a intentarlo ");
                MessageBox.Show("Respuesta incorrecta");
               

            }
        }
        int PosX = 0;
        int PosY = 0;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            {
                if (e.Button != MouseButtons.Left)
                {
                    PosX = e.X;
                    PosY = e.Y;
                }
                else
                {
                    Left = Left + (e.X - PosX);
                    Top = Top + (e.Y - PosY);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Voice.Speak("Este juego se trata de adivinar el resultado de la suma, puedes obtener monedas cada acierto que hagas, pronto se agregaran mas funciones y una Tienda para comprar ventajas y aciertos gratis, Juego desarrollado por Steven121x");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Coins > 9)
            {
                Coins -= 10;
                hability.Visible = false;
                txtNum.Text = resultado.ToString();
               
                if (Coins < 9)
                {
                    hability.Visible = false;
                }

                
            }
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Coins = 999;
            Coin.Text = Coins.ToString();
            if (Coins > 1)
            {
                hability.Visible = true;
            }
            else if (Coins > 0)
            {
                hability.Visible = false;
            }
        }
    }
}
