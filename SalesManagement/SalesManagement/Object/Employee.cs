using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Object
{
    class Employee
    {
        string EmployeeID;
        public string Employee_ID
        {
            get { return EmployeeID; }
            set { EmployeeID = value; }
        }
        string EmployeeName;
        public string Employee_Name
        {
            get { return EmployeeName; }
            set { EmployeeName = value; }
        }
        string Gender;
        public string EmployeeGender
        {
            get { return Gender; }
            set { Gender = value; }
        }
        string PhoneNumber;
        public string Phone_Number
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }

        DateTime BirthDate;
        public DateTime Birth_Date
        {
            get { return BirthDate; }
            set { BirthDate = value; }
        }

        string EmployeeAddress;
        public string Employee_Address
        {
            get { return EmployeeAddress; }
            set { EmployeeAddress = value; }
        }

        string EmployeeEmail;
        public string Employee_Email
        {
            get { return EmployeeEmail; }
            set { EmployeeEmail = value; }
        }

        string EmployeeCMNN;
        public string Employee_CMNN
        {
            get { return EmployeeCMNN; }
            set { EmployeeCMNN = value; }
        }

    }
}
