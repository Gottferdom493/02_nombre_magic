using System;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace nombre_magique
{
    class Program
    {
        // Demander nombre -> Toute la fonction 

        
        
        // retourner la valeur (int)

        static void Main(string[] args)
        {

            // tester si ce nombre est valide entre pas
            // reboucler tant que le nombre n'est pas validé
            int num = 0;
            while (num <= 0) 
            {
                try
                {
                    // Afficher : Rentrez un nombre
                    Console.WriteLine();
                    Console.WriteLine("Rentrez un nombre : ");
                    string str_num = Console.ReadLine();
                    num = int.Parse(str_num);
                    Console.WriteLine("tu as choisi le nombre " + num);

                    // Considérer que 0 est invalide
                    if (num == 0)
                    {
                        Console.WriteLine("Erreur : Tu ne peux pas utiliser le 0 ");
                    }
                    else if (num < 0)
                    {
                        Console.WriteLine("Erreur : Tu ne peux pas utiliser de nombre négatif ");
                    }
                    else
                    {
                        Console.WriteLine("Ton nombre est valide " + num);
                    }
                }

                catch 
                {
                    Console.WriteLine("Le nombre que tu as écrie est: " + num);
                }
            }

        }
    }
}