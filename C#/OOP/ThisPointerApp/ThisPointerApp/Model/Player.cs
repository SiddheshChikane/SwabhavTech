using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisPointerApp.Model
{
    class Player
    {
        private string _name;
        private int _age;
        private GenderType _gender;

        public Player(string _name):this(_name,18,GenderType.Male)
        {
            this._name = _name;
            this._age = 18;
            this._gender = GenderType.Male;
        }
        public Player(string _name, int _age, GenderType _gender)
        {

            this._name = _name;
            this._age = _age;
            this._gender = _gender;
            Console.WriteLine("Object has created");
        }
        public Player WhoIsElder(Player p)
        {
            if (this._age > p._age)
            {
                Console.WriteLine("The Elder player is :");
                return this;
            }
            else
            {

                return p;
            }

        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
        }
        public GenderType Gender
        {
            get
            {
                return _gender;
            }
        }
       
                
        
       

    }
}
