using System;

namespace cs_1._9_AvisoFesta2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declara variável inteira para controle do loop
            int j = 1; //inicializa variável de controle do loop
            
            while (j <= 5)
            {//início do loop
                //escreve a frase
                Console.WriteLine("Hoje vai ter festa na casa da Fabi");
                //incrementa variável de controle do loop (contador)
                j++; // Mesmo que j = j + 1;
            }//fim do loop            
        }
    }
}
