using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aktie
{
    /// <summary>
    /// Statisk klasse til managing af flere aktieobjekter
    /// </summary>
    public static class AktieManager
    {
        /// <summary>
        ///  List af alle aktieobjekter
        /// </summary>
        public static List<Aktie> Aktier { get; private set; } = new List<Aktie>();
        /// <summary>
        /// Tiløfjer et aktieobjekt til listen
        /// </summary>
        /// <param name="aktie"></param>
        public static void AddAktie(Aktie aktie)
        {
            Aktier.Add(aktie);
        }

        /// <summary>
        /// Udregner og returnerer det totale afkast af alle aktierne i Aktier
        /// </summary>
        /// <returns></returns>
        public static double TotalAfkast()
        {
            double total = 0;
            foreach (Aktie aktie in Aktier)
            {
                total += aktie.Afkast();
            }
            return total;
        }
        /// <summary>
        /// Fjerner alle aktier fra aktiemanageren
        /// </summary>
        public static void Clear()
        {
            Aktier.Clear();
        }
    }
}
