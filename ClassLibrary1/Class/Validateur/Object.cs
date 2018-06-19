using System;

namespace Outils.Class.Validateur
{
    /// <summary>
    /// Valide des objets.
    /// </summary>
    public static class Object
    {
        /// <summary>
        /// Retourne une exception si le paramètre est null.
        /// </summary>
        /// <typeparam name="T">N'importe quel type.</typeparam>
        /// <param name="t">Paramètre.</param>
        /// <param name="nomParametre">Nom du paramètre.</param>
        public static void NonNull<T>(this T t,  string nomParametre)
        {
            if(t == null)
            {
                throw new ArgumentNullException($"Le paramètre {nomParametre} est null");
            }
        }
    }
}
