using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Object
{
    class Agent
    {
        string AgentID;
        public string Agent_ID
        {
            get { return AgentID; }
            set { AgentID = value; }
        }
        string AgentName;
        public string Agent_Name
        {
            get { return AgentName; }
            set { AgentName = value; }
        }
        string AgentAdress;
        public string Agent_Address
        {
            get { return AgentAdress;}
            set { AgentAdress = value; }
        }
        string PhoneNumber;
        public string Phone_Number
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }
    }
}
