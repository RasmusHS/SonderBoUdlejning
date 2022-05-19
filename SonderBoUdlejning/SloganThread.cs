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

        string[] slogans = {"Slogan 1", "Slogan 2", "Slogan 3", "Slogan 4", "Slogan 5", "Slogan 6", "Slogan 7" };
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
                    Thread.Sleep(300); //Skifter slogan hver 3 min
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
