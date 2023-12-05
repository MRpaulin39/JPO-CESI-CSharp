/*
    Création du jeu "Nombre Mystère"

Le but du jeu "Nombre Mystère" est de faire deviner au joueur à nombre aléatoire choisi par le jeu en un minimum de coup.

Le principe de base est le suivant :
    - Le programme choisi un nombre au hasard (exemple : entre 0 et 100)
    - L'utilisateur Entre un nombre
    - Le programme vérifie la réponse et offre à l'utilisateur trois réponses possible : 
        - C'est plus !
        - C'est moins !
        - Bonne réponse ! Le bon nombre était X, vous avez trouvé la réponse en Y coups
    - Une fois la réponse trouvée, le programme demande à l'utilisateur s'il veux recommencer une partie

Saurez-vous relever le challenge ?

*/


using Nombre_Mystère_Solution;

bool fermerLeJeu = false;

while (!fermerLeJeu)
{
    Console.WriteLine("Tapez '1' pour lancer une partie ou bien '2' pour arrêter le jeu :");

    switch (Console.ReadLine())
    {
        case "1":
            //Lancement d'une partie
            Solution solutionAuJeu = new Solution();

            //Tans que la partie n'est pas terminée, on continue la partie
            while (!solutionAuJeu._partieTerminee)
            {
                Console.WriteLine("Entrer un nombre :");
                string tentativeUtilisateur = Console.ReadLine();

                //On essaye de convertir la valeur entrée par l'utilisateur en int
                if (int.TryParse(tentativeUtilisateur, out int nombreChoisi))
                {
                    //Si la valeur entrée est valide, on essaye la valeur
                    Console.WriteLine(solutionAuJeu.FaireUneTentative(nombreChoisi));
                }
                else
                {
                    //Si la valeur entrée n'est pas valide, alors on affiche un message d'erreur
                    Console.WriteLine("Veuillez entrer un nombre entier");
                }
            }

            //Une fois la partie terminée, on attend que l'utilisateur appuie sur une touche supplémentaire
            Console.WriteLine("Appuyer sur une touche pour continuer...");
            Console.ReadKey();

            //On nettoie la console
            Console.Clear();

            break;
        case "2":
            //Fermeture de l'application
            fermerLeJeu = true;

            break;

        default:
            Console.WriteLine("Veuillez choisir une option proposée");

            break;
    }

}

