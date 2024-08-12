/*void Escreva(string msg = "coloque alguma coisa no código"){

Console.WriteLine(msg);
}

Escreva("olá de novo");
Escreva("Olá de novo de novo");
Escreva();
*/

/*
void Escreva(string msg = "coloque alguma coisa no código"){

Console.WriteLine(msg);
}



void MostrarIdade(string nome, int idade)
{
    Escreva($" {nome} tem {idade} ano/anos de idade");
}

MostrarIdade("Fulano", 16);
MostrarIdade("Cicrano", 14);




void CalcularIdade(string nome, int ano){
int idade = 2024 - ano;
MostrarIdade(nome, idade);
}

CalcularIdade("Fulaninho", 2014);
*/

int MaiorEntre(int a, int b){
    if(a >= b){
        return a;
    }
    else{
        return b;
    }
}

Console.WriteLine(MaiorEntre(200,99));
Console.WriteLine(MaiorEntre(7,15));
Console.WriteLine(MaiorEntre(10,10));
