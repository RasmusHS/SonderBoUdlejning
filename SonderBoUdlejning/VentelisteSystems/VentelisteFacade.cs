using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SonderBoUdlejning.VentelisteSystems
{
    public class VentelisteFacade //Facade til venteliste systemet
    {
        //Opretter et medlem på en venteliste
        public void AddToList(string pId, string Lid)
        {
            vAddToList addToList = new vAddToList();
            addToList.vAddTo(pId, Lid);
        }

        //Fjerner et medlem fra en venteliste
        public void RemoveFromList(string pId, string Lid, bool prompt)
        {
            vRemoveFromList vRemove = new vRemoveFromList();
            vRemove.vRemoveFrList(pId, Lid, prompt);
        }

        //Finder et medlems position i en venteliste
        public string Position;
        public void GetListPosition(string pId, string Lid)
        {
            vGetPos vGet = new vGetPos();
            Position = vGet.vGetPosition(pId, Lid);
        }

        //Metode der kalder read-metoden, som returnerer en liste af medlemmer på en venteliste
        public string readVQuery;
        public void rVenteliste(string pId, string Lid, string signUpDato)
        {
            vRead vRead = new vRead();
            readVQuery = vRead.readVenteliste(pId, Lid, signUpDato);
        }
    }
}
