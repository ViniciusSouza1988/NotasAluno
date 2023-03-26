int Nota1Trimestre = 0;
Console.WriteLine("Nota 1 Trimestre é: ");
Nota1Trimestre = Convert.ToInt32(Console.ReadLine());

int Nota2Trimestre = 0;
Console.WriteLine("Nota 1 Trimestre é: ");
Nota2Trimestre = Convert.ToInt32(Console.ReadLine());

int Nota3Trimestre = 0;
Console.WriteLine("Nota 1 Trimestre é: ");
Nota3Trimestre = Convert.ToInt32(Console.ReadLine());

int Nota4Trimestre = 0;
Console.WriteLine("Nota 1 Trimestre é: ");
Nota4Trimestre = Convert.ToInt32(Console.ReadLine());

int NotaFinal = (Nota1Trimestre + Nota2Trimestre + Nota3Trimestre + Nota4Trimestre) / 4;

Console.WriteLine("A nota média foi:" + NotaFinal);

if (NotaFinal >= 70)
{
    Console.WriteLine("O aluno foi APROVADO");
}
else
{
    Console.WriteLine("O aluno foi REPROVADO");
}
    


