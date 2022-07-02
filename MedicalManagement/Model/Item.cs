using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagement.Model
{
    class Item : ICloneable
    {
        private string id;
        private string makeId;
        private string makeName;
        private string itemName;
        private string contents;
        private int quantityAvailable;
        private int quantity0rder;
        private string ingredient;
        private string packaging;
        private float price;
        private float cost;
        private float tax;
        private string note;

        public string Id { get => id; set => id=value; }
        public string MakeId { get => makeId; set => makeId=value; }
        public string MakeName { get => makeName; set => makeName=value; }
        public string ItemName { get => itemName; set => itemName=value; }
        public string Contents { get => contents; set => contents=value; }
        public int QuantityAvailable { get => quantityAvailable; set => quantityAvailable=value; }
        public int Quantity0rder { get => quantity0rder; set => quantity0rder=value; }
        public string Ingredient { get => ingredient; set => ingredient=value; }
        public string Packaging { get => packaging; set => packaging=value; }
        public float Price { get => price; set => price=value; }
        public float Cost { get => cost; set => cost=value; }
        public float Tax { get => tax; set => tax=value; }
        public string Note { get => note; set => note=value; }



        public Item(string id, string makeId, string makeName, string itemName, string contents, int quantityAvailable, int quantity0rder, string ingredient, string packaging, float price, float cost, float tax, string note)
        {
            Id=id;
            MakeId=makeId;
            MakeName=makeName;
            ItemName=itemName;
            Contents=contents;
            QuantityAvailable=quantityAvailable;
            Quantity0rder=quantity0rder;
            Ingredient=ingredient;
            Packaging=packaging;
            Price=price;
            Cost=cost;
            Tax=tax;
            Note=note;
        }

        public Item()
        {
        }

        public object Clone()
        {
            return new Item(id, makeId, makeName, itemName, contents, quantityAvailable, quantity0rder, ingredient, packaging, price, cost, tax, note);
        }
    }
}
