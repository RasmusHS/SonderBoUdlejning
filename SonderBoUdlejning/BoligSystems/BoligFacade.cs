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
        /*public void rBolig(string adresse, string postNr, string bId, string pId, string indDato, string udDato)
        {
            ReadBolig readBolig = new ReadBolig();
            rBoligQuery = readBolig.readBolig(adresse, postNr, bId, pId, indDato, udDato);
        }*/

        //Unik metode som kalder metoden, som indlæser boliger til leje ud fra givne parametre
        /*public void rBoligTilLeje(string adresse, string postNr, string bId, string bType, string minKvm, string maxKvm, string minLejePris, string maxLejePris)
        {
            ReadBolig readBoligTilLeje = new ReadBolig();
            rBoligQuery = readBoligTilLeje.readBoligTilLeje(adresse, postNr, bId, bType, minKvm, maxKvm, minLejePris, maxLejePris);
        }*/

        //Metode som kalder read-metoden, som indlæser boliger ud fra givne parametre
        public void tempRBolig(string sqlTemplate, string adresse, string postNr, string bId, string pId, string indDato, string udDato, string bType, string minKvm, string maxKvm, string minLejePris, string maxLejePris, bool tilLeje)
        {
            ReadBolig tempRBolig = new ReadBolig();
            rBoligQuery = tempRBolig.tempReadBolig(sqlTemplate, adresse, postNr, bId, pId, indDato, udDato, bType, minKvm, maxKvm, minLejePris, maxLejePris, tilLeje);
        }

        //Metode som kalder update-metoden, som opdaterer en bolig i databasen
        public void uBolig(string adresse, string postNr, string bId, string pId, string indDato, string udDato)
        {
            UpdateBolig updateBolig = new UpdateBolig();
            updateBolig.updateBolig(adresse, postNr, bId, pId, indDato, udDato);
        }

        //Metode som kalder delete-metoden, som sletter en bolig i databasen
        public void dBolig(string adresse)
        {
            DeleteBolig deleteBolig = new DeleteBolig();
            deleteBolig.deleteBolig(adresse);
        }
    }
}
