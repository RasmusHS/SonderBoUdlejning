using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonderBoUdlejning.BoligSystems
{
    public class BoligFacade //Facade til metoder der interagere med bolig tabellen
    {
        //Metode som kalder create-metoden, som opretter en ny bolig i databasen
        public void cBolig(string adresse, string postNr, string bId)
        {
            CreateBolig createBolig = new CreateBolig();
            createBolig.opretBolig(adresse, postNr, bId);
        }

        //Metode som kalder metoden, som indlæser boliger ud fra givne parametre
        public string rBoligQuery; //String field til at holde på SELECT Querien, så formen der kaldte facaden kan sende Querien videre til SQLExecutionHandler klassen
        //Metode som kalder read-metoden, som indlæser boliger ud fra givne parametre
        public void rBolig(string sqlTemplate, string adresse, string postNr, string bId, string pId, string indDato, string udDato, string bType, string minKvm, string maxKvm, string minLejePris, string maxLejePris, bool tilLeje)
        {
            ReadBolig rBolig = new ReadBolig();
            rBoligQuery = rBolig.readBolig(sqlTemplate, adresse, postNr, bId, pId, indDato, udDato, bType, minKvm, maxKvm, minLejePris, maxLejePris, tilLeje);
        }

        //Metode som kalder update-metoden, som opdaterer en bolig i databasen
        public void uBolig(string lejemaal, string adresse, string postNr, string bId, string pId, string indDato, string udDato)
        {
            UpdateBolig updateBolig = new UpdateBolig();
            updateBolig.updateBolig(lejemaal, adresse, postNr, bId, pId, indDato, udDato);
        }

        //Metode som kalder delete-metoden, som sletter en bolig i databasen
        public void dBolig(string lejemaal)
        {
            DeleteBolig deleteBolig = new DeleteBolig();
            deleteBolig.deleteBolig(lejemaal);
        }
    }
}
