using System;

class Program
{
    // Declaration d'une variable globale
    //static int essai = 0;


    // fonction de saisie
    static int saisie(string message)
    {
        int essai = 0;  
        bool correct = false;
        while (!correct)
        {
            try
            {
                //Console.Write("Entrez un essai = ");
                Console.Write($"{message} = ");
                essai = int.Parse(Console.ReadLine());
                correct = true;
            }
            catch
            {
                Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
            }
        }
      return essai;
    }
    public static void Main(string[] args)
    {
        // déclaration
        int valeur = 0, essai = 0, nbre = 1;
        
        // saisie du nombre à chercher
        valeur = saisie("Entrez le nombre à chercher");
        
        Console.Clear();
        // saisie du premier essai
        essai = saisie("Entrez un essai");
      
        // boucle sur les essais
        while (essai != valeur)
        {
            // test de l’essai par rapport à la valeur à chercher
            if (essai > valeur)
            {
                Console.WriteLine(" --> trop grand !");
            }
            else
            {
                Console.WriteLine(" --> trop petit !");
            }
            // saisie d’un nouvel essai
            essai = saisie("Entrez un essai");
          
            // compteur d’essais
            nbre++;
        }
        // valeur trouvée
        Console.WriteLine("Vous avez trouvé en " + nbre + " fois !");
        Console.ReadLine();
    }
}