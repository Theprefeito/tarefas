//inicio do programa onde será inserido e verificado se o valor das notas são válidos(se são >=0 ou <=100) 
Console.WriteLine("Digite o valor da nota 1");
int nota1 = int.Parse(Console.ReadLine());
if(nota1 <0 || nota1 >100 ){
    Console.WriteLine("Valor Inválido.");
    return;
}

    Console.WriteLine("Digite o valor da nota 2");
int nota2 = int.Parse(Console.ReadLine());
if(nota2 <0 || nota2 >100 ){
    Console.WriteLine("Valor Inválido.");
    return;
}

Console.WriteLine("Digite o valor da nota 3");
int nota3 = int.Parse(Console.ReadLine());
if(nota3 <0 || nota3 >100){
    Console.WriteLine("Valor Inválido.");
    return;
}


Console.WriteLine("Digite o valor da nota 4");
int nota4 = int.Parse(Console.ReadLine());
if(nota4 <0 || nota4 >100 ){
    Console.WriteLine("Valor Inválido.");
    return;
}


//aqui será realizado o cálculo da média.
float media = (2*nota1 + 2*nota2 + 3*nota3 + 3*nota4) / 10f;
media = (float)Math.Round(media);
Console.WriteLine($"Média da disciplina: {media}");

if(media >= 60){
    Console.WriteLine("Aprovado");
    return;
}
else{
    Console.WriteLine("Recuperação");
    float previsao = 120 - media;
    Console.WriteLine($"Precisa tirar {previsao} para passar");
}


Console.WriteLine("Digite o valor da prova final.");
int provaFinal = int.Parse(Console.ReadLine());

float mediafinal = (media = provaFinal) / 2f;
mediafinal = (float)Math.Round(mediafinal);
Console.WriteLine("Média Final: " + mediafinal);

if(provaFinal >= 60){
    Console.WriteLine($"Parabéns! com a nota {mediafinal} Você será aprovado!");

}
else if(mediafinal < 60){
    Console.WriteLine($"Que pena! com a nota {mediafinal} você não será aprovado.");
}
