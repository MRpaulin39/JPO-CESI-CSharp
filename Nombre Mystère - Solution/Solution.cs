namespace Nombre_Mystère_Solution
{
    /// <summary>
    /// Ce fichier contient la solution au développement du jeu "Nombre Mystère"
    /// </summary>
    public class Solution
    {
        #region Propriétés
        private readonly int _numeroMinimum;
        private readonly int _numeroMaximum;
        private int _numeroATrouver = -1;
        private int _nombreDeTentative = 0;
        public bool _partieTerminee = false;

        #endregion

        #region Constructeur
        public Solution(int numeroMinimum = 0, int numeroMaximum = 100)
        {
            _numeroMinimum = numeroMinimum;
            _numeroMaximum = numeroMaximum;

            LancerUnePartie();
        }
        #endregion

        #region Méthodes publiques
        /// <summary>
        /// Permet de faire une tentative
        /// </summary>
        /// <param name="numero">Numéro à tester</param>
        /// <returns>Renvoi le message pour l'utilisateur</returns>
        public string FaireUneTentative(int numero)
        {
            _nombreDeTentative++;

            if (numero < _numeroATrouver)
            {
                return "C'est plus !";
            }
            else if (numero > _numeroATrouver)
            {
                return "C'est moins !";
            }
            else
            {
                //On termine la partie
                _partieTerminee = true;
                return $"Bonne réponse ! Le bon nombre était {_numeroATrouver}, vous avez trouvé la réponse en {_nombreDeTentative} coups";
            }
        }
        #endregion

        #region Méthodes privées
        /// <summary>
        /// Permet de lancer une partie
        /// </summary>
        private void LancerUnePartie()
        {
            GenererUnNombreAleatoire();

            Console.Clear();
            Console.WriteLine("-------------------\n\rUne partie viens de commencer !\n\r-------------------");

        }

        /// <summary>
        /// Fonction permettant la génération d'un nombre aléatoire
        /// </summary>
        private void GenererUnNombreAleatoire()
        {
            Random random = new Random();
            _numeroATrouver = random.Next(_numeroMinimum, _numeroMaximum);
        }
        #endregion
    }
}
