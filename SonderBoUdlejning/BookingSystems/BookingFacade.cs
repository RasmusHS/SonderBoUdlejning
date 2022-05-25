using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SonderBoUdlejning.BookingSystems
{
    public static class BookingFacade
    {
        public static int mellemDatoer;
        public static void checkMellemDatoer(string startDato, string slutDato, int rid)
        {
            //CheckMellemDatoer checkMellem = new CheckMellemDatoer();
            mellemDatoer = CheckMellemDatoer.CheckDatesForBookings(startDato, slutDato, rid);
        }

        public static int ressourceIdType;
        public static void checkRessourceIdType(string tbResourceID)
        {
            //CheckResourceIdType checkResourceId = new CheckResourceIdType();
            ressourceIdType = CheckResourceIdType.getResourceIdType(tbResourceID);
        }

        public static int slutDato;
        public static void checkSlutDato(string slutdato, string resourceID)
        {
            //CheckSlutDato checkSlut = new CheckSlutDato();
            slutDato = CheckSlutDato.CheckSlutDate(slutdato, resourceID);
        }

        public static void getPersonList(List<int> beboerID, List<string> beboer)
        {
            //OnLoadFunctions getPerson = new OnLoadFunctions();
            OnLoadFunctions.GetPersonList(beboerID, beboer);
        }

        public static void getRessourceList(List<int> listResourceID, List<string> listResource, string date)
        {
            //OnLoadFunctions getRessource = new OnLoadFunctions();
            OnLoadFunctions.GetResourceList(listResourceID, listResource, date);
        }
           
        public static void setArrayInfo(string[] rTypeNavnArray, string[] antalReservationerArray, SqlConnection conn)
        {
            //SetArrayInfo setArrayInfo = new SetArrayInfo();
            SetArrayInfo.FillArrays(rTypeNavnArray, antalReservationerArray, conn);
        }
    }
}
