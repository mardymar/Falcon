using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Data
{
    public class GuardModel
    {
        public string Text;
        public string Link;
        

        public GuardModel()
        {
            SetText();
            SetLink();
        }

        string[] possibilities = new string[5]
        {
            "Marc Perry",
            "Mr. Furd",
            "Russian Jon",
            "Polish Jon",
            "Logan Rockefeller"
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
            Link = "/guard/" + rand.Next(2000);
        }
    }
}
