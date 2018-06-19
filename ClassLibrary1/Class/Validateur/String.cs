using System;

namespace Outils.Class.Validateur
{
    /// <summary>
    /// Valide des objets de type string.
    /// </summary>
    public static class String
    {
        /// <summary>
        /// Vérification que le string est non null.
        /// </summary>
        /// <param name="nomParametre">Nom du paramètre.</param>
        public static void NonNull(this string s,  string nomParametre)
        {
            if(s == null)
            {
                throw new ArgumentNullException($"Le paramètre {nomParametre} est null");
            }
        }

        /// <summary>
        /// Renvoi une exeption si le paramètre n'est pas renseigné.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="nomParametre"></param>
        public static void Obligatoire(this string s, string nomParametre)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                throw new ArgumentException($"Le paramètre {nomParametre} doit-être renseigné.");
            }
        }
    }
}
