using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SonderBoUdlejning.VentelisteSystems
{
    public class vFacade
    {
        //Facade til venteliste systemet

        //Opretter et medlem på en venteliste
        public void AddToList(string pId, string bId)
        {
            vAddToList addToList = new vAddToList();
            addToList.vAddTo(pId, bId);
        }

        //Fjerner et medlem fra en venteliste
        public void RemoveFromList(string pId, string bId)
        {
            vRemoveFromList vRemove = new vRemoveFromList();
            vRemove.vRemoveFrList(pId, bId);
        }

        //Finder et medlems position i en venteliste
        public string Position;
        public void GetListPosition(string pId, string bId)
        {
            vGetPos vGet = new vGetPos();
            Position = vGet.vGetPosition(pId, bId);
        }

        public string ReadVente;
        public void ReadVenteListe(string pId, string bId, string signUpDato)
        {
            ReadVenteliste readV = new ReadVenteliste();
            ReadVente = readV.rVente(pId, bId, signUpDato);
        }
    }
}
