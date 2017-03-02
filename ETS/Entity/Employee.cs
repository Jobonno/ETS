using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.Entity
{
    public class Employee
    {
        //fields
        private int empId;
        private string firstName;
        private string lastName;
        private string email;
        private DateTime dob;
        private string phone;
        
       
        #region Properties
        public int EmpId
        {
            get
            {
                return empId;
            }
            set
            {
                empId = value;
            }
                        
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public DateTime Dob
        {
            get
            {
                return dob;
            }

            set
            {
                dob = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }


        #endregion

        //constructors
        public Employee(string firstName, string lastName, string email, DateTime dob, string phone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.dob = dob;
            this.phone = phone;
        }
        public Employee()
        {

        }

        //methods
        public override string ToString()
        {
            return "ID : " + empId + ") " + firstName + ", " + lastName;
        }
    }

}
