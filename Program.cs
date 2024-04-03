List<string> Nomes = ["Ana", "Pedro", "Maria", "João", "Carolina", "Lucas", "Gabriela", "André", "Mariana", "Rafael", "Juliana", "Fernando", "Camila", "Gustavo", "Isabela", "Rodrigo", "Natália", "Daniel", "Larissa", "Felipe"];

Nomes.Sort();

int qtdLista = Nomes.Count;
string nomeProcurado = "Rodrigo";

PesquisaBinaria(Nomes, qtdLista, nomeProcurado);

int PesquisaBinaria(List<string> Nomes, int max, string nomeProcurado)
{
    double meio = max - 1 / 2;
    int metade = (int)Math.Floor(meio);

    Console.WriteLine("Máximo: " + max);
    Console.WriteLine("Meio: " + metade);
    Console.WriteLine("===================");
    Console.WriteLine("0: " + Nomes[0]);
    Console.WriteLine("1: " + Nomes[1]);
    Console.WriteLine("2: " + Nomes[2]);
    Console.WriteLine("3: " + Nomes[3]);
    Console.WriteLine("4: " + Nomes[4]);
    Console.WriteLine("5: " + Nomes[5]);
    Console.WriteLine("6: " + Nomes[6]);
    Console.WriteLine("7: " + Nomes[7]);
    Console.WriteLine("8: " + Nomes[8]);
    Console.WriteLine("9: " + Nomes[9]);
    Console.WriteLine("10: " + Nomes[10]);
    Console.WriteLine("11: " + Nomes[11]);
    Console.WriteLine("12: " + Nomes[12]);
    Console.WriteLine("13: " + Nomes[13]);
    Console.WriteLine("14: " + Nomes[14]);
    Console.WriteLine("15: " + Nomes[15]);
    Console.WriteLine("16: " + Nomes[16]);
    Console.WriteLine("17: " + Nomes[17]);
    Console.WriteLine("18: " + Nomes[18]);
    Console.WriteLine("19: " + Nomes[19]);

    if (Nomes[meio].CompareTo(nomeProcurado) > 0)
    {

    }
    else if (Nomes[meio].CompareTo(nomeProcurado) < 0)
    {

    }
    else
    {

    }

    return 1;
}