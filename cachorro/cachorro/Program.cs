using System.ComponentModel;
Thread.Sleep(1000);
Dog[] Dogs = criarCachorros();
Pessoa[] Pessoas = criarPessoas();
int tamanho = 50;

string[] pos = new string[tamanho];

for (int a = 0; a < pos.Length - 1; a++)
{
    pos[a] = " ";
}
pos[tamanho - 1] = "|CHEGADA|";


Random Random = new Random();
bool finished = true;

while (finished)
{
    Thread.Sleep(200);
    Console.Clear();

    for (int i = 0; i < Dogs.Length; i++)
    {


        if (Dogs[i].pos == tamanho)
        {
            Dogs[i].winner = true;
            finished = false;
        }

        int prob = Random.Next(1, 101);

        if (prob > 50)
        {
            Dogs[i].pos += 1;
        }

        for (int j = 0; j < pos.Length; j++)
        {
            if (j == Dogs[i].pos)
            {
                Console.Write(Dogs[i].nome);
            }

            else
            {
                Console.Write(pos[j]);
            }

        }


        Console.WriteLine();

    }
}

Console.Clear();
foreach (var item in Dogs)
{
    if (item.winner)
    {
        Console.WriteLine("PARABENSSSSSSSS");
        Console.WriteLine($"CHORRO {item.nome} VENCEUUUUU");
    }
}


Pessoa[] criarPessoas()
{
    Pessoa[] vetorPessoa = new Pessoa[3];

    Pessoa pessoa1 = new Pessoa();
    pessoa1.nome = "Joao";
    pessoa1.dinheiro = 50;

    Pessoa pessoa2 = new Pessoa();
    pessoa2.nome = "Lucas";
    pessoa2.dinheiro = 75;

    Pessoa pessoa3 = new Pessoa();
    pessoa3.nome = "Pedro";
    pessoa3.dinheiro = 100;

    vetorPessoa[0] = pessoa1;
    vetorPessoa[1] = pessoa2;
    vetorPessoa[2] = pessoa3;

    return vetorPessoa;
}
Dog[] criarCachorros()
{

    Dog[] vetorDog = new Dog[4];

    Dog dog1 = new Dog();
    dog1.nome = "R";
    Dog dog2 = new Dog();
    dog2.nome = "V";
    Dog dog3 = new Dog();
    dog3.nome = "S";
    Dog dog4 = new Dog();
    dog4.nome = "M";


    vetorDog[0] = dog1;
    vetorDog[1] = dog2;
    vetorDog[2] = dog3;
    vetorDog[3] = dog4;


    return vetorDog;
}


public class Pessoa
{
    public string nome { get; set; }
    public int dinheiro { get; set; }
}


public class Dog
{
    public int acel { get; set; }
    public int max { get; set; }
    public int pos { get; set; } = 0;
    public string nome { get; set; }
    public bool winner { get; set; } = false;

}
