using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1_home_applicant_with_SQL_
{
    class products
    {
         /// <summary>
         /// father classs
         /// add one empty constructor for ınherıtence
         /// check the values with encapsulatıon
         /// </summary>

        string id;
        string model;
        string brand;
        float price;

        public products() { }

        public products(string id , string model , string brand, float price) 
        {
            this.id = id;
            this.model = model;
            this.brand = brand;
            this.price = price;
        }

        public string Id
        {
            get { return id; }
            
            set
            {
                id = value;
            }
        }

        public string Model
        {
            get { return model; }

            set
            {
                model = value;
            }
        }


        public string Brand
        {
            get { return brand; }

            set
            {
                brand = value;
            }
        }

        public float Price
        {
            get { return price; }

            set {

                if (value >= 0 )
                {
                    price = value;
                }

                else if (value < 0 )
                {
                    price = -value;
                }
                 
            }
        }




    }
}
