using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Card
    {
        public int Id { get; }
        public Image? CardImage { get; }
        public static readonly Card NoCard = new Card(-1, null);

        public Card(int id, Image? image)
        {
            Id = id;
            CardImage = image;
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
