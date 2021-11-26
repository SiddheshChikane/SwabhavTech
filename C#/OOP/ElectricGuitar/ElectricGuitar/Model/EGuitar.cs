using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricGuitar.Model
{
    class EGuitar
    {
       public string brand;
       public int NumOfPickups;
       public bool IsPopstarUsesIt;
 
       public void SetBrand(string Pbrand)
        {
        brand = Pbrand;
        }
       public string GetBrand()
        {
        return brand;
        }
       public void SetNumOfPickups(int num)
        {
        NumOfPickups = num;
        }
        public int GetNumOfPickups()
        {
        return NumOfPickups;
        }
        public void SetIsPopstarUsesIt(bool YesOrNo)
        {
        IsPopstarUsesIt = YesOrNo;
        }
        public bool GetIsPopstarUsesIt()
        {
        return IsPopstarUsesIt;
        }
    }
}
