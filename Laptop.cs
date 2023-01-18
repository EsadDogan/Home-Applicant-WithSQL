using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1_home_applicant_with_SQL_
{
    class Laptop: products
    {

        /// <summary>
        /// This class is a child of tv
        /// add constructor for connection from other class
        /// checking the values with Encapsulation
        /// </summary>


        string ram;
        string displayCard;
        bool gaming;

        public Laptop(string id, string model, string brand, float price,string ram, string displayCard, bool gaming)
        {
            this.Id = id;
            this.Model = model;
            this.Brand = brand;
            this.Price = price;
            this.ram = ram;
            this.displayCard = displayCard;
            this.gaming = gaming;

        }

        public string Ram
        {
            get { return ram; }
            set { ram = value; }
        }

        public string DisplayCard
        {
            get { return displayCard; }
            set { displayCard = value; }
        }

        public bool Gaming
        {
            get { return gaming; }
            set { gaming = value; }
        }

    }
}
