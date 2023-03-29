using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_Polymorphism
{
    internal static class IdentityGenerator
    {
        static private string[] NameBegininings =
        {
            "B",
            "C",
            "D",
            "F",
            "G",
            "H",
            "Hj",
            "J",
            "K",
            "Kl",
            "L",
            "M",
            "N",
            "P",
            "Ph",
            "R",
            "Rh",
            "S",
            "St",
            "T",
            "V",
            "W",
            "Z"
        };

        static private string[] NameMiddles =
        {
            "a",
            "e",
            "o",
            "u",
            "i",
            "y",
            "el",
            "ev",
            "ou",
            "app",
            "efl",
            "est",
            "elle",
            "odho",
            "olph",
        };

        static private string[] NameSecondMiddles = 
        {
            "",
            "a",
            "c",
            "e",
            "l",
            "t",
        };

        static private string[] NameEndings =
        {
            "",
            "a",
            "n",
            "r",
            "t",
            "er",
            "or",
            "ur",
            "vi",
            "zor",
        };

        static private string[] SurNameEndings =
        {
            "",
            "son",
            "sen",
            "vic",
            "avik",
            "sson",
            "qwist",
            "dottir",
        };

        static private string[] NobleNameBeginnings =
        {
            "A",
            "Cz",
            "Tz",
            "Sch",
        };

        static private string[] NobleNameMiddles=
        {
            "a",
            "e",
            "an",
            "en",
            "avi",
            "ros",
            "sen",
        };

        static private string[] NobleNameEndings =
        {
            "",
            "s",
            "tz",
            "ef",
            "os",
            "zer",
        };

        public static string FirstName()
        {
            // This will maybe cause errors in about one and a half decade...
            // https://en.wikipedia.org/wiki/Year_2038_problem
            int uniqueSeed = (int)DateTime.Now.ToBinary();
            Random random = new Random(uniqueSeed);

            string nameBeginning = NameBegininings[random.Next(NameBegininings.Length)];
            string nameMiddle = NameMiddles[random.Next(NameMiddles.Length)];
            string nameSecondMiddle = NameSecondMiddles[random.Next(NameSecondMiddles.Length)];
            string nameEnding = NameEndings[random.Next(NameEndings.Length)];

            return nameBeginning + nameMiddle + nameSecondMiddle + nameEnding;
        }

        public static string SurName()
        {
            // This will maybe cause errors in about one and a half decade...
            // https://en.wikipedia.org/wiki/Year_2038_problem
            int uniqueSeed = (int)DateTime.Now.ToBinary();
            Random random = new Random(uniqueSeed);

            bool noble = random.Next(100) < 3;

            if (noble)
            {
                string nobleNameBeginning = NobleNameBeginnings[random.Next(NobleNameBeginnings.Length)];
                string nobleNameMiddle = NobleNameMiddles[random.Next(NobleNameMiddles.Length)];
                string nobleNameEnding = NobleNameEndings[random.Next(NobleNameEndings.Length)];
                return "von " + nobleNameBeginning + nobleNameMiddle + nobleNameEnding;
            }
            else
            {
                string surNameBeginning = NameBegininings[random.Next(NameBegininings.Length)];
                string surNameMiddle = NameMiddles[random.Next(NameMiddles.Length)];
                string surNameSecondMiddle = NameSecondMiddles[random.Next(NameSecondMiddles.Length)];
                string surNameEnding = SurNameEndings[random.Next(SurNameEndings.Length)];
                return surNameBeginning + surNameMiddle + surNameSecondMiddle + surNameEnding;
            }
        }

        public static string WholeName()
        {
            string firstName = FirstName();
            string surName = SurName();
            return firstName + " " + surName;
        }

        public static byte Age()
        {
            // This will maybe cause errors in about one and a half decade...
            // https://en.wikipedia.org/wiki/Year_2038_problem
            int uniqueSeed = (int)DateTime.Now.ToBinary();
            Random random = new Random(uniqueSeed);

            byte age = (byte) random.Next(0, 120);
            return age;
        }
    }
}
