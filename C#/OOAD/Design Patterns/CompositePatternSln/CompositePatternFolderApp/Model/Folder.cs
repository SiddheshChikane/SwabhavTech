using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFolderApp.Model
{
    class Folder : IStorageItem
    {
        private string _name;
        private List<IStorageItem> storageItems = new List<IStorageItem>();
        public Folder(string name)
        {
            this._name = name;
        }
        public void AddChild(IStorageItem storage)
        {
            storageItems.Add(storage);
        }
        public void Display()
        {
            Console.WriteLine(_name);
            foreach (IStorageItem item in storageItems)
            {
                item.Display();
            }
        }
    }
}
