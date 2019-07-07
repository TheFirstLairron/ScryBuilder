using System;
using System.Collections.Generic;
using System.Text;

namespace ScryBuilder.Shared.Models
{
    public class Card
    {

        public Guid ID { get; set; }

        public string Name { get; set; }

        public Uri Image { get; set; }

        public Card(Guid id, string name, Uri image)
        {
            ID = id;
            Name = name;
            Image = image;
        }
    }
}
