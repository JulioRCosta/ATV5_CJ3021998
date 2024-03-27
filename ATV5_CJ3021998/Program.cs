/*
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
for (num = 0; num < cod; num++)
{
    Console.WriteLine(num);
}


//Exercício 2

int num1, cod2, par;

Console.WriteLine("Dê um determinado número");
cod2 = int.Parse(Console.ReadLine());

for (par = 0; par <= cod2; par++)
{
    if (par % 2 == 0)
    {
        Console.WriteLine(par);
    }
}


// Exercício 3

int mil, att;

Console.WriteLine("Dê qual valor");
att = int.Parse(Console.ReadLine());
for ( mil = 1000;  att<=mil  ; mil--)
{
    if (mil % 2==0)
    {
        Console.WriteLine(mil);
    }

}
*/

// Exercício 4

int n, c;

Console.WriteLine("Atribua um número");
n = int.Parse(Console.ReadLine());

for (c = 200; c>+n; c--)
{
    if (c <= 0)
    {
        Console.WriteLine(c);
    }
}