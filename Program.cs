using System;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace nombre_magique
{
    class Program
    {
        static int DemanderNombre()
        {
            // tester si ce nombre est valide entre pas
            // reboucler tant que le nombre n'est pas validé
            int num = 0;
            while (num <= 0)
            {
                Console.WriteLine();
                Console.Write("Rentrez un nombre : ");
                string str_num = Console.ReadLine();
                Console.WriteLine("tu as choisi le nombre " + num);

                try
                {
                num = int.Parse(str_num);
                    // Afficher : Rentrez un nombre

                    // Considérer que 0 est invalide
                    if (num == 0)
                    {
                        Console.WriteLine("Erreur : Tu ne peux pas utiliser le 0 ");
                    }
                    else if (num < 0)
                    {
                        Console.WriteLine("Erreur : Tu ne peux pas utiliser de nombre négatif ");
                    }
                    else // retourner la valeur validé (int)
                    {
                        Console.WriteLine("Ton nombre est valide " + num);
                    }
                }

                catch
                {
                    Console.WriteLine("Le nombre que tu as écrie est: " + num);
                }
            }
            return num;
        }
        static void Main(string[] args)
        {
           int num = DemanderNombre();
           

        }
    }
}