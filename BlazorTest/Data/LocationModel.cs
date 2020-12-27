using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Data
{
    public class LocationModel
    {
        public string Text;
        public string Link;


        public LocationModel()
        {
            SetText();
            SetLink();
        }

        string[] possibilities = new string[5]
        {
            "Compton",
            "Bronx",
            "Stockton",
            "Watts",
            "San Luis Obispo"
        };

        private void SetText()
        {
            Random rand = new Random();

            rand.Next(5);

            Text = possibilities[rand.Next(5)];
        }

        public void SetLink()
        {
            var rand = new Random();
            Link = "/location/" + rand.Next(2000);
        }
    }
}
