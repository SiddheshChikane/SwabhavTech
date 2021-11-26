using RicksGuitarApp.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksGuitarApp.Model
{
    class Guitar
    {
        private string _serialNumber; 
        private string _model;
        private Builder _builder;
        private GType _type; 
        private Wood _backWood;
        private Wood _topWood;
        private double _price;

        public Guitar(string serialNumber, double price, Builder builder,string model,GType type, Wood backWood, Wood topWood)
        {
            this._serialNumber = serialNumber;
            this._price = price;
            this._builder = builder;
            this._model = model;
            this._type = type;
            this._backWood = backWood;
            this._topWood = topWood;
            
        }
        public string GetSerialNumber
        {
            get
            {
                return _serialNumber;
            }
        } 
        public string GetModel
        {
            get
            {
                return _model; 
            }
        } 
        public Builder GetBuilder
        {
            get
            {
                return _builder; 
            }
        } 
        public GType Type
        {
            get
            {
                return _type; 
            }
        }
        public Wood GetBackWood
        {
            get
            {
                return _backWood; 
            }
        } 
        public Wood GetTopWood
        {
            get
            {
                return _topWood; 
            }
        } 
        public double GetPrice
        {
            get
            {
                return _price; 
            }
        } 
        
    }
   
}

