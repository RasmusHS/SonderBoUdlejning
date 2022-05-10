using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SonderBoUdlejning.TildelBoligSystems
{
    internal class LejekontraktFacade
    {  
        public void PrintKontrakt(string lejerNavn, string lejePris, string adresse, string postNr, string by, string startDato)
        {
            //Tildeler computerens navn en variabel, så print funktionen kan virke på de fleste computere.
            string userName = Environment.UserName;
            //Definere stien som .txt filerne skal gemmes i.
            string path = $@"C:\Users\{userName}\Documents\SønderBoLejekontrakter";

            if (Directory.Exists(path))
            {
                CreatePdf(lejerNavn, lejePris, adresse, postNr, by, startDato);
            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
                CreatePdf(lejerNavn, lejePris, adresse, postNr, by, startDato);
            }
        }

        string kontraktParagraf = "Ved betaling af nedenstående depositum, samt leje for første måned, accepterer de tilbuddet om lejemålet og medfølgende vilkår.";
        
        private void CreatePdf(string lejerNavn, string lejePris, string adresse, string postNr, string by, string startDato)
        {
            //Tildeler computerens navn en variabel, så print funktionen kan virke på de fleste computere.
            string userName = Environment.UserName;
            //Definere stien som .txt filerne skal gemmes i.
            string path = $@"C:\Users\{userName}\Documents\SønderBoLejekontrakter";

            string depositum = Convert.ToString(Convert.ToInt32(lejePris) * 3);
            
            Document document = new Document(PageSize.A4, 20, 20, 30, 30);
            
            using (PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path + $"\\{lejerNavn}_Lejekontrakt.pdf", FileMode.Create)))
            {
                document.Open();

                //Titel
                Font titleFont = FontFactory.GetFont("Arial", 20, BaseColor.BLACK);
                Paragraph title = new Paragraph("Lejekontrakt", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                //grey rectangle
                Rectangle rectangle = new Rectangle(20, 805, document.PageSize.Width - 20, + 773);
                rectangle.Border = Rectangle.BOX;
                rectangle.BorderColor = BaseColor.BLACK;
                rectangle.BorderWidth = 1;
                rectangle.BackgroundColor = new BaseColor(170, 170, 170);
                document.Add(rectangle);

                Font modtagerFont = FontFactory.GetFont("Arial", 14, BaseColor.BLACK);
                Paragraph lejerInfo = new Paragraph();
                string lejerNavnLinje = $"\n\n     {lejerNavn}\n";
                string tidligereAdresseLinje = $"     Tidligerevej 1\n";
                string tidligerePostNummerLinje = $"     1234\n\n";
                lejerInfo.Font = modtagerFont;
                lejerInfo.SpacingBefore = 10;
                lejerInfo.SpacingAfter = 10;
                lejerInfo.Alignment = Element.ALIGN_LEFT;
                lejerInfo.Add(lejerNavnLinje);
                lejerInfo.Add(tidligereAdresseLinje);
                lejerInfo.Add(tidligerePostNummerLinje);
                document.Add(lejerInfo);

                //Blev tilføjet
                Font brødTekstFont = FontFactory.GetFont("Arial", 12, BaseColor.BLACK);
                Paragraph kontraktPara = new Paragraph(kontraktParagraf, brødTekstFont);
                document.Add(kontraktPara);

                //Blev ikke tilføjet
                Paragraph lejePrisPara = new Paragraph();
                string lejeMål = $"Lejemål: {adresse}, {postNr} {by}\n";
                string lejePrisLinje = $" > Lejepris: kr. {lejePris},-  pr. måned\n";
                string depositumLinje = $" > Depositum: kr. {depositum},- \n";
                string iAltLinje = $" > I alt: kr. {Convert.ToDouble(lejePris) + Convert.ToDouble(depositum)},- \n";
                string startDatoLinje = $"\nLejemålet begynder den: {startDato}\n";
                string betalingsDeadline = $"Betalingsfristen er: {startDato}\n";
                lejePrisPara.Font = brødTekstFont;
                lejePrisPara.SpacingBefore = 10;
                lejePrisPara.SpacingAfter = 10;
                lejePrisPara.Alignment = Element.ALIGN_LEFT;
                lejePrisPara.Add(lejeMål);
                lejePrisPara.Add(lejePrisLinje);
                lejePrisPara.Add(depositumLinje);
                lejePrisPara.Add(iAltLinje);
                lejePrisPara.Add(startDatoLinje);
                lejePrisPara.Add(betalingsDeadline);
                document.Add(lejePrisPara);

                //Blev tilføjet
                Paragraph venligHpara = new Paragraph();
                string venligHilsen = "\nVenlig hilsen\nSønderBo UdLejning";
                venligHpara.SpacingBefore = 10;
                venligHpara.SpacingAfter = 10;
                venligHpara.Alignment = Element.ALIGN_LEFT;
                venligHpara.Font = FontFactory.GetFont("Arial", 14, BaseColor.BLACK);
                venligHpara.Add(venligHilsen);
                document.Add(venligHpara);

                document.Close();
                writer.Close();
            }
        }
    }
}
