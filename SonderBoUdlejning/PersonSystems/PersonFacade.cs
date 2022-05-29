using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SonderBoUdlejning.personCRUD
{
    public class PersonFacade
    {
        //Metode der kalder create-metoden, som opretter en ny person i databasen
        public void cPerson(string navn, string mail, string tlf)
        {
            CreatePerson pCreate = new CreatePerson();
            pCreate.createPerson(navn, mail, tlf);
        }

        //Metode der kalder read-metoden, som returnerer en liste af alle personer fra person tabellen ud fra de givne parametre
        public string readPQuery; //string der indeholder SQL-query
        public void rPerson(string columns, string pId, string navn, string mail, string tlf, bool medlem, bool erBeboer, bool alt)
        {
            ReadPerson pRead = new ReadPerson();
            readPQuery = pRead.readPerson(columns, pId, navn, mail, tlf, medlem, erBeboer, alt);
        }

        //Metode der kalder update-metoden, som opdaterer en person i databasen
        public void uPerson(string navn, string mail, string tlf, string pId, bool erBeboer)
        {
            UpdatePerson pUpdate = new UpdatePerson();
            pUpdate.uPerson(navn, mail, tlf, pId, erBeboer);
        }

        //Metode der kalder delete-metoden, som sletter en person fra databasen
        public void dPerson(string tlf)
        {
            DeletePerson pDelete = new DeletePerson();
            pDelete.dPerson(tlf);
        }
    }
}
