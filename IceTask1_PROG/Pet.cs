using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask1_PROG
{
    public class Pet
    {

        
        private double Bill;
        private string ID, Type, Name, Breed;

        public Pet(double bill, string iD, string type, string name, string breed)
        {
            Bill = bill;
            ID = iD;
            Type = type;
            Name = name;
            Breed = breed;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)

                    return this.Bill;
                else if (index == 1)

                    return this.ID;
                else if (index == 2)

                    return this.Type;
                else if (index == 3)

                    return this.Name;
                else if (index == 4)

                    return this.Breed;

                return null;

            }
            set
            {
                if (index == 0)
                    this.Bill = (double)value;
                else if (index == 1)
                    this.ID = (string)value;
                else if (index == 2)
                    this.Type = (string)value;
                else if (index == 3)
                    this.Name = (string)value;
                else if (index == 4)
                    this.Breed = (string)value;
            }
        }

        public object this[string attrName]
        {
            get
            {

                if (attrName.ToLower().Equals("Bill"))
                    return this.Bill;
                else if (attrName.ToLower().Equals("id"))
                    return this.ID;
                else if (attrName.ToLower().Equals("type"))
                    return this.Type;
                else if (attrName.ToLower().Equals("name"))
                    return this.Name;
                else if (attrName.ToLower().Equals("breed"))
                    return this.Breed;
                return null;
            }

            set
            {
                if (attrName.ToLower().Equals("bill"))
                    this.Bill = (double)value;
                else if (attrName.ToLower().Equals("id"))
                    this.ID = (string)value;
                else if (attrName.ToLower().Equals("type"))
                    this.Type = (string)value;
                else if (attrName.ToLower().Equals("name"))
                    this.Name = (string)value;
                else if (attrName.ToLower().Equals("breed"))
                    this.Breed = (string)value;

            }
        }

        }


}
