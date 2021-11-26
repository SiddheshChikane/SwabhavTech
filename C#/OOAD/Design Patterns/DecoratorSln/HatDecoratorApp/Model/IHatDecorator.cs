using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorApp.Model
{
    interface IHatDecorator:IHat
    {
       string GetName();
    }
}
