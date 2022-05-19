using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SonderBoUdlejning.VentelisteSystems
{
    public class vFacade //Facade til venteliste systemet
    {
        //Opretter et medlem på en venteliste
        public void AddToList(string pId, string Lid)
        {
            vAddToList addToList = new vAddToList();
            addToList.vAddTo(pId, Lid);
        }

        //Fjerner et medlem fra en venteliste
        public void RemoveFromList(string pId, string Lid)
        {
            vRemoveFromList vRemove = new vRemoveFromList();
            vRemove.vRemoveFrList(pId, Lid);
        }

        //Finder et medlems position i en venteliste
        public string Position;
        public void GetListPosition(string pId, string Lid)
        {
            vGetPos vGet = new vGetPos();
            Position = vGet.vGetPosition(pId, Lid);
        }

        //Metode der kalder read-metoden, som returnerer en liste af medlemmer på en venteliste
        public string ReadVente;
        public void ReadVenteListe(string pId, string Lid, string signUpDato)
        {
            ReadVenteliste readV = new ReadVenteliste();
            ReadVente = readV.rVente(pId, Lid, signUpDato);
        }
    }
}
