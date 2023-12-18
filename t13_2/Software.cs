using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace t13_2
{
    class Software
    {
        /// <summary>
        /// Name
        /// </summary>
        string name;

        public string Name { get => (name != "") ? name : "Unknown" ; set => name = value; }
        /// <summary>
        /// Producer
        /// </summary>
        string producer;
        public string Producer { get => (producer != "") ?producer : "Unknown"; set => producer = value; }
        /// <summary>
        /// Usage (paid or free)
        /// </summary>
        string usage;
        public string Usage { get => (Convert.ToInt32(usage) != 0) ? "Paid" : "Free"; set => usage = value; }
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Software() { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="producer"></param>
        /// <param name="usage"></param>
        public Software(string name, string producer, string usage)
        {
            this.Name = name; this.Producer = producer; this.Usage = usage; 
        }
        /// <summary>
        /// Output
        /// </summary>
        public void Output()
        {
            WriteLine($"Name: {Name}\nProducer: {Producer}\nUsage: {Usage}\n");
        }
        /// <summary>
        /// Invers
        /// </summary>
        /// <returns></returns>
        public string Invers()
        {
            return (Convert.ToInt32(usage) != 0) ? "Free" : "Paid";
        }
       




        


        
    }
}
