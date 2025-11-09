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
        public static readonly Card NoCard = new Card(-1, null, "No Card");
        public string Name { get; }

        public Card(int id, Image? image, string name)
        {
            Id = id;
            CardImage = image;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
