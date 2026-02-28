using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProgramacao
{
    public class Aula3
    {

        //Switch


        public void AvaliaçãoSwitch()
        {

            int nota;
            Console.WriteLine("Informe sua nota:");
            nota = int.Parse(Console.ReadLine());

            switch (nota)
            {
                case >= 7:
                    Console.WriteLine("Aprovado");
                    break;


                case >= 5:
                    Console.WriteLine("Recuperação");
                    break;



                default:
                    Console.WriteLine("Reprovado");
                    break;

            }
        }

        public void CategoriaIdade()
        {
            int nota;
            Console.WriteLine("Informe sua idade");
            nota = int.Parse(Console.ReadLine());

            switch (nota)
            {
                case >= 60:
                    Console.WriteLine("Idoso");
                    break;


                case >= 30:
                    Console.WriteLine("Adulto");
                    break;

                case >= 20:
                    Console.WriteLine("Jovem");
                    break;

                case >= 10:
                    Console.WriteLine("Adolescente");
                    break;


                    default:
                    Console.WriteLine("Criança");
                    break;





            }

        }

    }
}

