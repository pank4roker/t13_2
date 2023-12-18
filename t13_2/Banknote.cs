using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace t13_2
{
    class Banknote
    {
        /// <summary>
        /// Name
        /// </summary>
        string name;

        public string Name { get => (name != "") ? name : "Unknown"; set => name = value; }
        /// <summary>
        /// denomination
        /// </summary>
        int denomination;
        public int Denomination { get => (denomination != 0) ? denomination : 0; set => denomination = value; }
        /// <summary>
        /// quantity
        /// </summary>
        int quantity;
        public int Quantity { get => (quantity > 0) ? quantity : 0; set => quantity = value; }
        /// <summary>
        /// Constr without param
        /// </summary>
        public Banknote() { }
        /// <summary>
        /// Constract with param
        /// </summary>
        /// <param name="name"></param>
        /// <param name="denomination"></param>
        /// <param name="quantity"></param>
        public Banknote(string name,  int denomination, int quantity)
        {
            this.Name = name;
            this.Denomination = denomination;
            this.Quantity = quantity;
        }
        /// <summary>
        /// Output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Name: {Name}\nDenomination: {Denomination}\nQuantity: {Quantity}\n";
        }
        public int Change(int n)
        {
            return Quantity +=n;
        }
        public int Compare()
        {

        }
    }
}
