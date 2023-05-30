using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    internal class ContactData
    {
        private string firstname;
        private string secondname;

        public ContactData(string firstname, string secondname)
        {
            this.firstname = firstname;
            this.secondname = secondname;
        }

        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        public string SecondName
        {
            get
            {
                return secondname;
            }
            set
            {
                secondname = value;
            }
        }


    }
}
