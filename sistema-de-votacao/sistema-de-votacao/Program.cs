class Program
{
    static void votacao()
    {
        int votos = 1;
        int candidatoA = 0;
        int candidatoB = 0;
        int nulo = 0;

        for (; votos > 0;)
        {
            Console.WriteLine("Escolha seu voto 0=Encerrar 1=Candidato A 2=Candidato B 3=Nulo");
            votos = Convert.ToInt32(Console.ReadLine());

            switch (votos){
                case 0:
                    Console.WriteLine("Encerrado");
                    votos = 0;
                    break;
                case 1:
                    Console.WriteLine("Votou no Candidato A");
                    candidatoA++;
                    
                    break;
                case 2:
                    Console.WriteLine("Votou no Candidato B");
                    candidatoB++;
                    
                    break;
                case 3:
                    Console.WriteLine("Votou no Candidato B");
                    nulo++;
                    
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break ;
            }
          
                Console.WriteLine($"\nContabilização de votos Candidato A:{candidatoA} \nContabilização de votos Candidato B:{candidatoB} \nContabilização de votos Nulo:{nulo}");
          
        }
    }
    static void Main()
    {
        votacao();
    }
}
