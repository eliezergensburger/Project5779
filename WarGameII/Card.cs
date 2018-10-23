using System;

namespace WarGameII
{
    public class Card
    {
        private int mispar;
        private E_Color color;
        public Card(int number, string colorName)
        {
            try
            {
                Number = number;
                bool success = Enum.TryParse<E_Color>(colorName,out color);
                if(!success)
                {
                    throw new Exception("not valid colour");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public E_Color Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Number
        {
            get { return mispar; }
            set
            {
                if (value < 2 || value > 14)
                {
                    throw new Exception("inavlid range");
                }
                mispar = value;
            }
        }

        public String CardName
        {
            get
            {
                switch (mispar)
                {
                    case 14:
                        return "Ace";
                    case 13:
                        return "King";
                    case 12:
                        return "Queen";
                    case 11:
                        return "Jack";
                    default:
                        return mispar.ToString();
                }
            }
        }


    }
}