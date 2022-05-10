using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonderBoUdlejning.BoligSystems
{
    internal class BoligFacade
    {
        public void cBolig(string adresse, string postNr, string bId, string indflytDato)
        {
            CreateBolig createBolig = new CreateBolig();
            createBolig.opretBolig(adresse, postNr, bId, indflytDato);
        }

        public string rBoligQuery;
        public void rBolig(string adresse, string postNr, string bId, string pId, string indDato, string udDato)
        {
            ReadBolig readBolig = new ReadBolig();
            rBoligQuery = readBolig.readBolig(adresse, postNr, bId, pId, indDato, udDato);
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
