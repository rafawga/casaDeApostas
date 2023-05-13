using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace cachorro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Dog[] vetorDog = new Dog[4];
            
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            Dog dog3 = new Dog();
            Dog dog4 = new Dog();

            vetorDog[0] = dog1;
            vetorDog[1] = dog2;
            vetorDog[2] = dog3;
            vetorDog[3] = dog4;

            Random random = new Random();

            for (int i = 0; i < 4; i++)
            {
                int randomNumber = random.Next(10, 30);
                vetorDog[i].max = randomNumber;
            }

            for (int i = 0; i < 4; i++)
            {
                int randomNumber = random.Next(10, 30);
                vetorDog[i].acel = randomNumber;
            }


            dog1.startX = 650;
            dog1.startY = 100;
            vel1.Text = dog1.max.ToString();
            acel1.Text = dog1.acel.ToString();
            dog2.startX = 650;
            dog2.startY = 100;
            vel2.Text = dog2.max.ToString();
            acel2.Text = dog2.acel.ToString();
            dog3.startX = 650;
            dog3.startY = 100;
            vel3.Text = dog3.max.ToString();
            acel3.Text = dog3.acel.ToString();
            dog4.startX = 650;
            dog4.startY = 100;
            vel4.Text = dog4.max.ToString();
            acel4.Text = dog4.acel.ToString();
            InitializeComponent();

            startCorrida(vetorDog, dog1);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        void criarPessoas()
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.nome = "Joao";
            pessoa1.dinheiro = 50;

            Pessoa pessoa2 = new Pessoa();
            pessoa2.nome = "Lucas";
            pessoa2.dinheiro = 75;

            Pessoa pessoa3 = new Pessoa();
            pessoa3.nome = "Pedro";
            pessoa3.dinheiro = 100;

            nome1.Text = pessoa1.nome;
            dinheiro1.Text = pessoa1.dinheiro.ToString();
            nome2.Text = pessoa2.nome;
            dinheiro2.Text = pessoa2.dinheiro.ToString();
            nome3.Text = pessoa3.nome;
            dinheiro3.Text = pessoa3.dinheiro.ToString();
        }

   

        void startCorrida(Dog[] vetorDog, Dog dog)
        {
            bool corrida = true;
            while (corrida == true)
            {
                for(int i = 0; i < 4; i++)
                {
                    if (vetorDog[i].startX == 1200)
                    {
                        corrida = false;
                    }
                }

                Point P = dog1.Location;
                P.X +=  dog.acel;



            }
        }


        private void vel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
