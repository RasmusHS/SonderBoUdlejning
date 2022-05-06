using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SonderBoUdlejning.SQLBuilders;

namespace SonderBoUdlejning.personCRUD
{
    public class pFacade
    {
        
        public void CreatePerson(string navn, string mail, string tlf)
        {
            pCreate Pcreate = new pCreate();
            Pcreate.pSQLC(navn, mail, tlf);
        }

        public string ReadQuery;
        public void ReadPerson(string navn, string mail, string tlf, bool medlem, bool erBeboer, bool alt)
        {
            pRead pRead = new pRead();
            ReadQuery = pRead.pSQLR(navn, mail, tlf, medlem, erBeboer, alt);
        }

        public void UpdatePerson(string navn, string mail, string tlf, string pId)
        {
            pUpdate pUpdate = new pUpdate();
            pUpdate.pSQLU(navn, mail, tlf, pId);
        }

        public void DeletePerson(string tlf)
        {
            pDelete pDelete = new pDelete();
            pDelete.pSQLD(tlf);
        }
    }
}
