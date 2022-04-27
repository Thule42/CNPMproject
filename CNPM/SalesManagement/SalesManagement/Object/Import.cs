using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Object
{
    class Import
    {
        string ImportID;
        DateTime ImportDate;
        string _ProductID;
        string _ProductName;
        int _Quantity;
        float _Price;

        public Import()
        {
        }

        public Import(string ProductID, string ProductName,int Quantity, float Price)
        {
            this._ProductID = ProductID;
            this._ProductName = ProductName;
            this._Quantity = Quantity;
            this._Price = Price;
        }

        public Import(string ImportID, string ProductID, string ProductName, DateTime ImportDate, int Quantity, float Price)
        {
            this.ImportID = ImportID;
            this.ImportDate = ImportDate;
            this._ProductID = ProductID;
            this._ProductName = ProductName;
            this._Quantity = Quantity;
            this._Price = Price;
        }

        public string ImportID1 { get => ImportID; set => ImportID = value; }
        public DateTime ImportDate1 { get => ImportDate; set => ImportDate = value; }
        public string ProductID { get => _ProductID; set => _ProductID = value; }
        public string ProductName { get => _ProductName; set => _ProductName = value; }
        public int Quantity { get => _Quantity; set => _Quantity = value; }
        public float Price { get => _Price; set => _Price = value; }

        


    }
}
        