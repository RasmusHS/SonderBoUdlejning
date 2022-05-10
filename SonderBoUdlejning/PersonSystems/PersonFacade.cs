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
        
        public void CreatePerson(string navn, string mail, string tlf)
        {
            CreatePerson Pcreate = new CreatePerson();
            Pcreate.pSQLC(navn, mail, tlf);
        }

        public string ReadQuery;
        public void ReadPerson(string columns, string pId, string navn, string mail, string tlf, bool medlem, bool erBeboer, bool alt)
        {
            ReadPerson pRead = new ReadPerson();
            ReadQuery = pRead.pSQLR(columns, pId, navn, mail, tlf, medlem, erBeboer, alt);
        }

        public void UpdatePerson(string navn, string mail, string tlf, string pId, bool erBeboer)
        {
            UpdatePerson pUpdate = new UpdatePerson();
            pUpdate.pSQLU(navn, mail, tlf, pId, erBeboer);
        }

        public void DeletePerson(string tlf)
        {
            DeletePerson pDelete = new DeletePerson();
            pDelete.pSQLD(tlf);
        }
    }
}
