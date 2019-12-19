using System;
using System.Collections.Generic;
using System.Text;

namespace Ninoko.Logics
{
    public abstract class Levels
    {
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }


        public void Check(string answer)
        {

        }

    }

    public class Level1To4 : Levels
    {

    }
}
