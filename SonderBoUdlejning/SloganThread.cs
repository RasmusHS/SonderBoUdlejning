using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SonderBoUdlejning
{
    public class SloganThread
    {
        Label lblSlogan;

        string[] slogans = { "Bo godt – bo hos SønderBo (1)", "Bo bedre blodigt (2)", "SønderBo - Aldrig hjemve (3)", "Ude godt, SønderBo bedst (4)", "StudieBo = SønderBo (5)", "Lev livet hos SønderBo (6)", "Sønderbo – Herfra din verden går (7)" };
        Random rnd  = new Random();

        public SloganThread (Label lblSlogan)
        {
            this.lblSlogan = lblSlogan;
        }

        private delegate void Workdelegate(string showText);

        private void DisplayWorkDelegate (string showText)
        {
            lblSlogan.Text = showText;
        }

        public void ShowSlogan()
        {
            bool isTrue = true;

            do
            {
                try
                {

                    int i = rnd.Next(slogans.Length);
                    Thread.Sleep(180000); //Skifter slogan hver 3 min
                    lblSlogan.Invoke(new Workdelegate(DisplayWorkDelegate), new object[] { slogans[i]});
                    
                }
                catch
                {
                    isTrue = false;
                }
            }
            while (isTrue);
        }

    }
}
