int idade;

Console.Write("Qual a sua idade: ");

idade = Convert.ToInt32(Console.ReadLine());

if(idade >= 18 && idade <= 69)
{
    Console.WriteLine("Voce pode ser doador de sangue ");
}
else
{
    Console.WriteLine("Voce nao pode ser doador de sangue ");
}