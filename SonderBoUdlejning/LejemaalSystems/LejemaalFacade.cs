using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonderBoUdlejning.LejemaalSystems
{
    public class LejemaalFacade //Facade til metoder der interagere med lejemål tabellen
    {
        //Metode som kalder create-metoden, som opretter en ny lejemål i databasen
        public void cLejemaal(string adresse, string postNr, string Lid)
        {
            CreateLejemaal createLejemaal = new CreateLejemaal();
            createLejemaal.opretLejemaal(adresse, postNr, Lid);
        }

        //Metode som kalder metoden, som indlæser boliger ud fra givne parametre
        public string rLejemaalQuery; //String field til at holde på SELECT Querien, så formen der kaldte facaden kan sende Querien videre til SQLExecutionHandler klassen
        //Metode som kalder read-metoden, som indlæser boliger ud fra givne parametre
        public void rLejemaal(string sqlTemplate, string adresse, string postNr, string Lid, string pId, string indDato, string udDato, string lType, string minKvm, string maxKvm, string minLejePris, string maxLejePris, bool tilLeje)
        {
            ReadLejemaal rLejemaal = new ReadLejemaal();
            rLejemaalQuery = rLejemaal.readLejemaal(sqlTemplate, adresse, postNr, Lid, pId, indDato, udDato, lType, minKvm, maxKvm, minLejePris, maxLejePris, tilLeje);
        }

        //Metode som kalder update-metoden, som opdaterer en lejemål i databasen
        public void uLejemaal(string lejemaalNr, string adresse, string postNr, string Lid, string pId, string indDato, string udDato)
        {
            UpdateLejemaal updateLejemaal = new UpdateLejemaal();
            updateLejemaal.updateLejemaal(lejemaalNr, adresse, postNr, Lid, pId, indDato, udDato);
        }

        //Metode som kalder delete-metoden, som sletter en lejemål i databasen
        public void dLejemaal(string lejemaalNr)
        {
            DeleteLejemaal deleteLejemaal = new DeleteLejemaal();
            deleteLejemaal.deleteLejemaal(lejemaalNr);
        }
    }
}
