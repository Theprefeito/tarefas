
Console.WriteLine("Digite seu nome");

var nome = Console.ReadLine();

Console.WriteLine("Olá " + nome + ", digite o valor de A:");

var a = int.Parse(Console.ReadLine());
Console.WriteLine("Digite agora o valor de B:");
var b = int.Parse(Console.ReadLine());

int c = a + b;

Console.WriteLine("A soma de A e B é: " + c);



Console.WriteLine("Digite um número: ");

//int num = int.Parse(Console.ReadLine()); 

//bool par = num % 2 == 0;

bool par = c % 2 == 0;

if(par){
    Console.WriteLine("É par");
}
else{
    Console.WriteLine("É impar");
}
