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
        private string make_id;
        private string item_name;
        private string contents;
        private int quanlity_available;
        private int quantity_order;
        private string ingredient;
        private string packaging;
        private float price;
        private float cost;
        private float tax;
        private string note;

        public string Id { get => id; set => id = value; }
        public string Make_id { get => make_id; set => make_id = value; }
        public string Item_name { get => item_name; set => item_name = value; }
        public string Contents { get => contents; set => contents = value; }
        public int Quanlity_available { get => quanlity_available; set => quanlity_available = value; }
        public int Quantity_order { get => quantity_order; set => quantity_order = value; }
        public string Ingredient { get => ingredient; set => ingredient = value; }
        public string Packaging { get => packaging; set => packaging = value; }
        public float Price { get => price; set => price = value; }
        public float Cost { get => cost; set => cost = value; }
        public float Tax { get => tax; set => tax = value; }
        public string Note { get => note; set => note = value; }

        public Item(string id, string make_id, string item_name, string contents, int quanlity_available, int quantity_order, string ingredient, string packaging, float price, float cost, float tax, string note)
        {
            this.id = id;
            this.make_id = make_id;
            this.item_name = item_name;
            this.contents = contents;
            this.quanlity_available = quanlity_available;
            this.quantity_order = quantity_order;
            this.ingredient = ingredient;
            this.packaging = packaging;
            this.price = price;
            this.cost = cost;
            this.tax = tax;
            this.note = note;
        }
        public object Clone()
        {
            return new Item(id, make_id, item_name, contents, quanlity_available, quantity_order, ingredient, packaging, price, cost, tax, note);
        }
    }
}
