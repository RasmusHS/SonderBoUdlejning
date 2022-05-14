using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonderBoUdlejning.BoligSystems
{
    internal class BoligFacade
    {
        public void cBolig(string adresse, string postNr, string bId)
        {
            CreateBolig createBolig = new CreateBolig();
            createBolig.opretBolig(adresse, postNr, bId);
        }

        //public string readBoligTemplate = $"SELECT * FROM Bolig WHERE 1=1"; 
        public string rBoligQuery;
        public void rBolig(string adresse, string postNr, string bId, string pId, string indDato, string udDato)
        {
            ReadBolig readBolig = new ReadBolig();
            rBoligQuery = readBolig.readBolig(adresse, postNr, bId, pId, indDato, udDato);
        }

        public void rBoligTilLeje(string adresse, string postNr, string bId, string pId, string indDato, string udDato, string bType, string minKvm, string maxKvm, string minLejePris, string maxLejePris, bool tildelBolig)
        {
            ReadBolig readBoligTilLeje = new ReadBolig();
            rBoligQuery = readBoligTilLeje.readBoligTilLeje(adresse, postNr, bId, pId, indDato, udDato, bType, minKvm, maxKvm, minLejePris, maxLejePris);
        }

        public void uBolig(string adresse, string postNr, string bId, string pId, string indDato, string udDato)
        {
            UpdateBolig updateBolig = new UpdateBolig();
            updateBolig.updateBolig(adresse, postNr, bId, pId, indDato, udDato);
        }

        public void dBolig(string adresse)
        {
            DeleteBolig deleteBolig = new DeleteBolig();
            deleteBolig.deleteBolig(adresse);
        }
    }
}
