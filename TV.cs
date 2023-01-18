using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1_home_applicant_with_SQL_
{
    class TV: products
    {

        /// <summary>
        /// This class is a child of tv
        /// add constructor for connection from other class
        /// checking the values with Encapsulation
        /// </summary>

        string resolution;
        int inch;
        bool smart;

        public TV(string id, string model, string brand, float price,string resolution, int inch, bool smart) 
        {
            this.Id = id;
            this.Model = model;
            this.Brand = brand;
            this.Price = price;
            this.resolution = resolution;
            this.inch = inch;
            this.smart = smart;
        }

        public string Resolution 
        {
            get { return resolution; }

            set { resolution = value;}
        }

        public int Inch
        {
            get { return inch; }

            set {

                if (value < 0)
                {
                    inch = -value;
                }
                else
                {
                    inch = value;
                }
                 }
        }

        public bool Smart
        {
            get { return smart; }

            set { smart= value; }
        }


    }
}
