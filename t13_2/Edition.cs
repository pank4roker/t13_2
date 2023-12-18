using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace t13_2
{
    /// <summary>
    /// Class
    /// </summary>
    class Edition
    {
        /// <summary>
        /// Title
        /// </summary>
        string title;

        public string Title
        {
            get
            {
                return (title != "") ? title : "Unknown";
            }
            set
            {
                title = value;
            }
        }
        /// <summary>
        /// Author's name
        /// </summary>
        string authname;
        public string Authname { get => (authname != "") ? authname : "Unknown"; set => authname = value; }
        /// <summary>
        /// Yearof publication
        /// </summary>
        int year;
        public int Year { get => (year>1457) ? year : 0; set => year = value; }
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Edition() { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="title"></param>
        /// <param name="authname"></param>
        /// <param name="year"></param>
        public Edition (string title, string authname, int year)
        {
            this.Title = title; 
            this.Authname = authname;
            this.Year = year;
        }
        /// <summary>
        /// Output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Title: {Title}\nAuthname: {Authname}\nYear: {Year}\n";
        }
        /// <summary>
        /// Change the year
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public int Change(int date)
        {
            return Year+=date;
        }
        /// <summary>
        /// Compare
        /// </summary>
        /// <returns></returns>
        public string Compare()
        {
            return (Year > 1400) & (Year < 2020) ? "\nYear is in range" : "\nYear is not in range";
        }








    }
}
