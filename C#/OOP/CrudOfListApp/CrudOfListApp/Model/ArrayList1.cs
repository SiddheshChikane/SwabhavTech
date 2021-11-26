using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CrudOfListApp.Model
{
    class ArrayList1
    {
        private List<int> l = new List<int>();

        public void AddToList(int add)
        {
            l.Add(add);
        }
        public void DisplayToList()
        {
            for (int i=0; i<l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }
        }
        public void UpdateToList(int position, int updatedValue)
        {
            for (int i = 0; i < l.Count; i++)
            {
                if(position == i)
                {
                    l[position - 1] = updatedValue;
                }
            }

        } 
        public void DeleteToList(int position)
        {
            for (int i=0; i<l.Count; i++)
            {
                if( position == i)
                {
                    l.Remove(l[position - 1]);
                }
            }
        }
    }
}
