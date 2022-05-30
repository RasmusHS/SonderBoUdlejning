using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text; //Der gøres brug af iTextSharp NuGet pakken
using iTextSharp.text.pdf;
using System.Windows.Forms;

namespace SonderBoUdlejning.TildelLejemaalSystems
{
    internal class LejekontraktFacade //Facade til kreation og udprintning af lejekontrakt
    {  
        public void PrintKontrakt(string lejerNavn, string lejePris, string adresse, string postNr, string by, string startDato, string Lid)
        {
            //Tildeler computerens navn en variabel, så print funktionen kan virke på de fleste computere.
            string userName = Environment.UserName;
            //Definere stien som .txt filerne skal gemmes i.
            string path = $@"C:\Users\{userName}\Documents\SønderBoUdlejning\Kontrakter\Aktive_Lejekontrakter";

            if (Directory.Exists(path))
            {
                CreatePdf(lejerNavn, lejePris, adresse, postNr, by, startDato, Lid);
            }
            else
            {
                Directory.CreateDirectory(path);
                CreatePdf(lejerNavn, lejePris, adresse, postNr, by, startDato, Lid);
            }
        }

        //Definerer brødtekst indhold
        string kontraktParagraf = "Ved betaling af nedenstående depositum, samt leje for første måned, accepterer de tilbuddet om lejemålet og medfølgende vilkår.";
        
        private void CreatePdf(string lejerNavn, string lejePris, string adresse, string postNr, string by, string startDato, string Lid)
        {
            //Tildeler computerens navn en variabel, så print funktionen kan virke på de fleste computere.
            string userName = Environment.UserName;
            
            //Definere stien som .txt filerne skal gemmes i.
            string path = $@"C:\Users\{userName}\Documents\SønderBoUdlejning\Kontrakter\Aktive_Lejekontrakter";

            //Definere størrelsen på depositummet
            string depositum = Convert.ToString(Convert.ToInt32(lejePris) * 3);
            
            //Definere pdf filens størrelsesformat og margins
            Document document = new Document(PageSize.A4, 20, 20, 30, 30);

            //Definere pdf filens navn, placering og indhold
            using (PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path + $"\\{lejerNavn}_{Lid}_Lejekontrakt.pdf", FileMode.Create)))
            {
                document.Open(); //Åbner pdf filen

                //Tilføjer titel
                Font titleFont = FontFactory.GetFont("Arial", 20, BaseColor.BLACK); //Definerer titel font
                Paragraph title = new Paragraph("Lejekontrakt", titleFont); //Definerer titel
                title.Alignment = Element.ALIGN_CENTER; //Definerer titel placering
                document.Add(title); //Tilføjer titel til pdf dokumentet

                //grå rektangel, som er titlens baggrund
                Rectangle rectangle = new Rectangle(20, 805, document.PageSize.Width - 20, +773); //Definere rektanglets placering og størrelse
                rectangle.Border = Rectangle.BOX; //Definerer rektanglets kant
                rectangle.BorderColor = BaseColor.BLACK; //Definerer rektanglets kant-farve
                rectangle.BorderWidth = 1; //Definerer rektanglets kant-bredde
                rectangle.BackgroundColor = new BaseColor(170, 170, 170); //Definerer rektanglets baggrundsfarve (grå)
                document.Add(rectangle); //Tilføjer rektangel til pdf dokumentet

                //Definerer modtager felt og placering
                Font modtagerFont = FontFactory.GetFont("Arial", 14, BaseColor.BLACK); //Definerer modtager font
                Paragraph lejerInfo = new Paragraph(); //Definerer modtagerfelt som en paragraf
                string lejerNavnLinje = $"\n\n     {lejerNavn}\n"; //Definerer modtager navn
                string tidligereAdresseLinje = $"     Tidligerevej 1\n"; //Definerer modtagerens tidligere adresse
                string tidligerePostNummerLinje = $"     1234\n\n"; //Definerer modtagerens tidligere postnummer
                lejerInfo.Font = modtagerFont; //Definerer modtager font
                lejerInfo.SpacingBefore = 10; //Definerer hvor meget plads der skal være mellem modtager info og andre elementer
                lejerInfo.SpacingAfter = 10;
                lejerInfo.Alignment = Element.ALIGN_LEFT; //Definerer modtager placering
                lejerInfo.Add(lejerNavnLinje); //Tilføjer modtager navn til paragraf
                lejerInfo.Add(tidligereAdresseLinje); //Tilføjer modtagerens tidligere adresse til paragraf
                lejerInfo.Add(tidligerePostNummerLinje); //Tilføjer modtagerens tidligere postnummer til paragraf
                document.Add(lejerInfo); //Tilføjer modtager info til pdf dokumentet

                //Definerer brødtekst paragraf
                Font brødTekstFont = FontFactory.GetFont("Arial", 12, BaseColor.BLACK); //Definerer brødtekst font
                Paragraph kontraktPara = new Paragraph(kontraktParagraf, brødTekstFont);
                document.Add(kontraktPara); //Tilføjer brødtekst paragraf til pdf dokumentet

                //Definerer lejesum felt og placering
                Paragraph lejePrisPara = new Paragraph(); //Definerer lejesum felt som en paragraf
                string lejeMål = $"Lejemål: {adresse}, {postNr} {by}\n"; //Definerer lejemål
                string lejePrisLinje = $" > Lejepris: kr. {lejePris},-  pr. måned\n"; //Definerer lejepris
                string depositumLinje = $" > Depositum: kr. {depositum},- \n"; //Definerer depositum
                string iAltLinje = $" > I alt: kr. {Convert.ToDouble(lejePris) + Convert.ToDouble(depositum)},- \n"; //Definerer i alt
                string startDatoLinje = $"\nLejemålet begynder den: {startDato}\n"; //Definerer lejemålets startdato
                string betalingsDeadline = $"Betalingsfristen er: {startDato}\n"; //Definerer betalingsfristen
                lejePrisPara.Font = brødTekstFont; //Definerer lejesum font
                lejePrisPara.SpacingBefore = 10; //Definerer hvor meget plads der skal være mellem lejesum og andre elementer
                lejePrisPara.SpacingAfter = 10;
                lejePrisPara.Alignment = Element.ALIGN_LEFT; //Definerer lejesum placering
                lejePrisPara.Add(lejeMål); //Tilføjer lejemål til paragraf
                lejePrisPara.Add(lejePrisLinje); //Tilføjer lejepris til paragraf
                lejePrisPara.Add(depositumLinje); //Tilføjer depositum til paragraf
                lejePrisPara.Add(iAltLinje); //Tilføjer i alt til paragraf
                lejePrisPara.Add(startDatoLinje); //Tilføjer lejemålets startdato til paragraf
                lejePrisPara.Add(betalingsDeadline); //Tilføjer betalingsfristen til paragraf
                document.Add(lejePrisPara); //Tilføjer lejesum paragrafen til pdf dokumentet

                //Definerer venlig hilsen felt og placering
                Paragraph venligHpara = new Paragraph(); //Definerer venlig hilsen felt som en paragraf
                string venligHilsen = "\nVenlig hilsen\nSønderBo UdLejning"; //Definerer venlig hilsen
                venligHpara.SpacingBefore = 10; //Definerer hvor meget plads der skal være mellem venlig hilsen og andre elementer
                venligHpara.SpacingAfter = 10;
                venligHpara.Alignment = Element.ALIGN_LEFT; //Definerer venlig hilsen placering
                venligHpara.Font = FontFactory.GetFont("Arial", 14, BaseColor.BLACK); //Definerer venlig hilsen font
                venligHpara.Add(venligHilsen); //Tilføjer venlig hilsen til paragraf
                document.Add(venligHpara); //Tilføjer venlig hilsen paragraf til pdf dokumentet

                document.Close(); //Lukker pdf dokumentet
                writer.Close(); //Lukker pdf dokumentets writer
            }
            ErrorMessage.ErrorList.Add($@"Lejekontrakt blev genereret og ligger i C:\Brugere\{userName}\Dokumenter\SønderBoUdlejning\Kontrakter\Aktive_Lejekontrakter");
        }
    }
}
