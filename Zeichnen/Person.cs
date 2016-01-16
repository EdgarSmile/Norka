using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Norka.Zeichnen
{
    public class Person : IPosition
    {
        private int _age;
        private string _hairColor;

        public Person(int alter, string haarfarbe)
        {
            _age = alter;
            _hairColor = haarfarbe;
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <= 65 && value >= 18)
                {
                    _age = value;
                }
                else
                    _age = 18;
            }
        }
        public string HairColor
        {
            get
            {
                return _hairColor;
            }
            set
            {
                _hairColor = value;
            }
        }

        public override string ToString()
        {
            return "Person - " + _age.ToString();
        }

        string IPosition.AsString()
        {
            return
                    "Alter: " + this.Age + "\r\n" +
                    "Haarfarbe: " + this.HairColor + "\r\n";
        }

        public void DrawOnPanel(Graphics graphics)
        {
            throw new NotImplementedException();
        }
    }
}
