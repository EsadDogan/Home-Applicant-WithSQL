using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1_home_applicant_with_SQL_
{
    class smartphone:products
    {

        /// <summary>
        /// This class is a child of tv
        /// add constructor for connection from other class
        /// checking the values with Encapsulation
        /// </summary>

        int rom;
        string os;
        bool fiveG;

        public smartphone(string id, string model, string brand, float price,int rom, string os, bool fiveG) 
        {

            this.Id = id;
            this.Model = model;
            this.Brand = brand;
            this.Price = price;
            this.rom = rom;
            this.os = os;
            this.fiveG = fiveG;
        

        }

        public int Rom 
        {
            get { return rom; }
            set
            {
                if (value < 0)
                {
                    rom = -value;
                }

                else
                {
                    rom = value;

                }

            }
        }


        public string Os 
        {
            get { return os; }

            set { os = value; }


        }

        public bool FiveG
        {
            get { return fiveG; }

            set { fiveG = value; }


        }


    }
}
