class Program
{
    static void Main(string[] args)
    {
        List<string> Nomes = new List<string> { "Ana", "Pedro", "Maria", "João", "Carolina", "Lucas", "Gabriela", "André", "Mariana", "Rafael", "Juliana", "Fernando", "Camila", "Gustavo", "Isabela", "Rodrigo", "Natália", "Daniel", "Larissa", "Felipe" };

        Nomes.Sort();

        string nomeProcurado = "Rodrigo";

        int inicio = 0;
        int fim = Nomes.Count - 1; // ajustando o valor do fim para o índice correto

        int resultado = PesquisaBinaria(Nomes, nomeProcurado, inicio, fim);

        if (resultado == -1)
        {
            Console.WriteLine("Nome não encontrado");
        }
        else
        {
            Console.WriteLine($"O nome '{nomeProcurado}' foi encontrado na posição {resultado}");
        }
    }

    static int PesquisaBinaria(List<string> Nomes, string nomeProcurado, int inicio, int fim)
    {
        if (inicio <= fim)
        {
            int meio = (inicio + fim) / 2;

            if (Nomes[meio].CompareTo(nomeProcurado) < 0)
            {
                return PesquisaBinaria(Nomes, nomeProcurado, meio + 1, fim);
            }
            else if (Nomes[meio].CompareTo(nomeProcurado) > 0)
            {
                return PesquisaBinaria(Nomes, nomeProcurado, inicio, meio - 1);
            }
            else
            {
                return meio;
            }
        }

        return -1; // Retorna -1 se o elemento não for encontrado
    }
}