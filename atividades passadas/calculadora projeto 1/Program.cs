
void soma(float a, float b){

    float x = a + b;
    Console.WriteLine($"{a} + {b} = {x}");

}


void subtracao(float a, float b){

    float x = a - b;
    Console.WriteLine($"{a} - {b} = {x}");
    
}


void multiplicacao(float a, float b){

    float x = a * b;
    Console.WriteLine($"{a} x {b} = {x}");

}


void divisao(float a, float b){

    float x = a / b;
    Console.WriteLine($"{a} / {b} = {x}");
if(b == 0){
    Console.WriteLine("error when divided by zero");
    return;
}

}

//global variables  
float a;
float b;

void DigitarAeB(string op){
    Console.WriteLine(op);
    Console.WriteLine($"Type the value of A: ");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine($"Type the value of B: ");
    b = float.Parse(Console.ReadLine());

}

Console.WriteLine("--- CALCULADOIDA ---");
Console.WriteLine("1 - soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("5 - sair");
Console.WriteLine("--------------------");
Console.WriteLine("Digite a opção desejada: ");

int opcao = int.Parse(Console.ReadLine());

if(opcao == 1){
    DigitarAeB("Soma");
    soma(a,b);
}
else if(opcao == 2){
    DigitarAeB("Subtração");
    subtracao(a,b);
}

if(opcao == 3){
    DigitarAeB("Multiplicação");
    multiplicacao(a,b);
}
else if(opcao == 4){
    DigitarAeB("Divisão");
    divisao(a,b);
}
else if(opcao == 5){
    DigitarAeB("Saindo");
    return;
}
else{
    Console.WriteLine("Opção inválida");
}
