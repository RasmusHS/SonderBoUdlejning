using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonderBoUdlejning.BoligSystems
{
    public class LejemaalFacade //Facade til metoder der interagere med lejemål tabellen
    {
        //Metode som kalder create-metoden, som opretter en ny lejemål i databasen
        public void cBolig(string adresse, string postNr, string Lid)
        {
            CreateLejemaal createBolig = new CreateLejemaal();
            createBolig.opretBolig(adresse, postNr, Lid);
        }

        //Metode som kalder metoden, som indlæser boliger ud fra givne parametre
        public string rBoligQuery; //String field til at holde på SELECT Querien, så formen der kaldte facaden kan sende Querien videre til SQLExecutionHandler klassen
        //Metode som kalder read-metoden, som indlæser boliger ud fra givne parametre
        public void rBolig(string sqlTemplate, string adresse, string postNr, string Lid, string pId, string indDato, string udDato, string lType, string minKvm, string maxKvm, string minLejePris, string maxLejePris, bool tilLeje)
        {
            ReadLejemaal rBolig = new ReadLejemaal();
            rBoligQuery = rBolig.readBolig(sqlTemplate, adresse, postNr, Lid, pId, indDato, udDato, lType, minKvm, maxKvm, minLejePris, maxLejePris, tilLeje);
        }

        //Metode som kalder update-metoden, som opdaterer en lejemål i databasen
        public void uBolig(string lejemaalNr, string adresse, string postNr, string Lid, string pId, string indDato, string udDato)
        {
            UpdateLejemaal updateBolig = new UpdateLejemaal();
            updateBolig.updateBolig(lejemaalNr, adresse, postNr, Lid, pId, indDato, udDato);
        }

        //Metode som kalder delete-metoden, som sletter en lejemål i databasen
        public void dBolig(string lejemaalNr)
        {
            DeleteLejemaal deleteBolig = new DeleteLejemaal();
            deleteBolig.deleteBolig(lejemaalNr);
        }
    }
}
