using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Object
{
    class Export
    {
        string ExportID;
        public string Export_ID
        {
            get { return ExportID; }
            set { ExportID = value; }
        }
        string ProductID;
        public string Product_ID
        {
            get { return ProductID; }
            set { ProductID = value; }
        }
        string ProductName;
        public string Product_Name
        {
            get { return ProductName; }
            set { ProductName = value; }
        }
        string AgentID;
        public string Agent_ID
        {
            get { return AgentID; }
            set { AgentID = value; }
        }
        DateTime EmportDate;
        public DateTime Emport_Date
        {
            get { return EmportDate; }
            set { EmportDate = value; }
        }
        int Quantity;
        public int QuantityProduct
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        float Price;
        public float ProductPrice
        {
            get { return Price; }
            set { Price = value; }
        }

        public double Total
        {
            get { return Quantity * Price; }

        }
    }
}
