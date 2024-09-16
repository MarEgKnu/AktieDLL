namespace Aktie
{
    public class Aktie
    {
        /// <summary>
        /// Representerer en eller flere aktier fra det samme firma
        /// </summary>
        /// <param name="aktieNavn">Navnet på aktien</param>
        /// <param name="købsKurs">Kursen når den blev købt</param>
        /// <param name="salgsKurs">Kursen når den blev solgt</param>
        /// <param name="antalAktier">Antal aktier</param>
        public Aktie(string aktieNavn, double købsKurs, double salgsKurs, int antalAktier)
        {
            AktieNavn = aktieNavn;
            KøbsKurs = købsKurs;
            SalgsKurs = salgsKurs;
            AntalAktier = antalAktier;
        }
        /// <summary>
        /// Navnet på aktien (eg. Novo Nordisk)
        /// </summary>
        public string AktieNavn { get; set; }
        /// <summary>
        /// Aktiekurs når aktien var købt
        /// </summary>
        public double KøbsKurs { get; set; }
        /// <summary>
        /// Aktiekurs når aktien sælges
        /// </summary>
        public double SalgsKurs { get; set; }
        /// <summary>
        /// Antal aktier der er
        /// </summary>
        public int AntalAktier { get; set; }
        /// <summary>
        /// Returnerer afkast på alle aktierne, kan blive negative
        /// </summary>
        /// <returns></returns>
        public double Afkast()
        {
            return (SalgsKurs - KøbsKurs) * AntalAktier;    
        }

    }
}
