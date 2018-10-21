using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    public class Card : IComparable<Card>
    {
        //private E_Color color;

        //public E_Color Color
        //{
        //    get { return color; }
        //    set { color = value; }
        //}
        private int number;

        public E_Color Color { get; set; }
        public int Number
        {
            get { return number; }
            set
            {
                if (value < 2 || value > 14)
                {
                    throw new Exception("range should be between <2-14> !!");
                }
                number = value;
            }
        }
        public String CardName
        {
            get
            {
                switch (number)
                {
                    case 14:
                        //result = "Ace";
                        //break;
                        return "Ace";
                    case 13:
                        return "King";
                    case 12:
                        return "Queen";
                    case 11:
                        return "Jack";
                    default:
                        return number.ToString();
                }
            }
        }

        public override string ToString()
        {
            return String.Format("card color: {0} , value: {1}", Color.ToString(), CardName);
        }
        public int CompareTo(Card other)
        {
            return number.CompareTo(other.number);
        }
    }
}
