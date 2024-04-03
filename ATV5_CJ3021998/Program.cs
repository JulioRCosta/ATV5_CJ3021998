int a, temp;

int soma = 0;

for (a = 0; a < 3; a++) ;
Console.WriteLine("Digite um valor");
temp = int.Parse(Console.ReadLine());
if (temp < 0)
{
    break;
}
soma = temp;
Console.WriteLine("A média é {0}", soma/3);


//Exercício 1

int num, cod;

Console.WriteLine("Dê um determinado número");
cod = int.Parse(Console.ReadLine());
num = 0;
while (num<cod)
{
    Console.WriteLine(num);
    num++;
}


//Exercício 2

int cod2;

Console.WriteLine("Dê um determinado número");
cod2 = int.Parse(Console.ReadLine());
int num1 = 0;
while (num1<cod2)
{
    num1++;
    if (num1 % 2 == 0)
      
    {

        Console.WriteLine(num1);
    }
}


// Exercício 3

int z;

Console.WriteLine("Dê qualquer valor inteiro");
z = int.Parse(Console.ReadLine());
if (z < 1000) 
    
{
    int w = 0;
    while (w <= z)
    {
        w++;

        if (w % 2 == 0)
        {
            Console.WriteLine(w);
        }
    }

}


// Exercício 4

int cor = 0;

while(cor < 200)
{
    cor++;

    Console.WriteLine("Digite um valor");

    int cor2 = int.Parse(Console.ReadLine());

    if(cor2 > 0)

    {
        Console.WriteLine(cor2);

        cor += cor2;

    }

    Console.WriteLine("A soma dos números é {0}", cor);

} 

//Exercício 5

Console.WriteLine("Digite um número inteiro");
int nmr = int.Parse(Console.ReadLine());

Console.WriteLine("Os divisores de {0} são: ", nmr);
int i = 1;
while (i <= nmr)
{
    i++;
    if (nmr % i == 0)
    {
        Console.WriteLine(i);
    }
}
