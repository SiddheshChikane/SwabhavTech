using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RicksGuitarApp.Model.Enums;
namespace RicksGuitarApp.Model
{
    class Inventory
    {
        List<Guitar> listGuitar;

        public Inventory()
        {
            listGuitar = new List<Guitar>();
        }
        public void AddGuitar(string serialNumber, double price, Builder builder, string model, GType type, Wood backWood, Wood topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
            listGuitar.Add(guitar);
        }
        public Guitar GetGuitar(string serialNumber)
        {
            foreach(Guitar guitar in listGuitar)
            {
                if (guitar.GetSerialNumber == serialNumber)
                {
                    return guitar;
                }
            }
            return null;
        }
        public List<Guitar> search(Guitar searchGuitar)
        {
            List<Guitar> mathGuitars = new List<Guitar>();
            foreach(Guitar items in listGuitar)
            {
                int flag = 0;
                Builder builder = searchGuitar.GetBuilder;
                string model = searchGuitar.GetModel;
                GType type = searchGuitar.Type;
                Wood topWood = searchGuitar.GetTopWood;
                Wood backWood = searchGuitar.GetBackWood;

                if ((builder.Equals(items.GetBuilder)))
                {
                    flag = 1;
                }
                else if ((model.Equals(items.GetModel)))
                {
                    flag = 1;
                }
                else if ((type.Equals(items.Type)))
                {
                    flag = 1;
                }
                else if ((topWood.Equals(items.GetTopWood)))
                {
                    flag = 1;
                }
                else if ((backWood.Equals(items.GetBackWood)))
                {
                    flag = 1;
                }
                else
                {
                    continue;
                }
                if (flag == 1)
                {
                    mathGuitars.Add(items);
                }
                else
                {
                    continue;
                }      
            }
            return mathGuitars;
        }
    }
}
