using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Data
{
    public class IncidentModel
    {

        public IncidentModel()
        {
            GetSeverity();
            GetText();
            GetLink();
        }

        public string severity;

        public string theText;

        public string link;

        string[] possibilities = new string[5]
        {
        "Micha got drunk",
        "Martha is a dancer",
        "Francis likes to pee",
        "Something something",
        "All's good here"
        };

        public void GetText()
        {
            Random rand = new Random();

            rand.Next(5);

            theText = possibilities[rand.Next(5)];
        }

        public void GetSeverity()
        {
            Random rand = new Random();
            var color = rand.Next(3);

            severity = color.ToString();

            //return color == 2 ? "btn-danger" : color == 1 ? "btn-warning" : "btn-info";
        }

        public void GetLink()
        {
            var rand = new Random();
            link = "/incident/" + rand.Next(2000);
        }
    }
}
