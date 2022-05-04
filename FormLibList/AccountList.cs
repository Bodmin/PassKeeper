using System;

namespace FormLibList
{
    public class AccountList
    {
        public int id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }

        public string fullName
        {
            get
            {
                return $"{fName} {lName}";
            }
        }
    }

    public class Account
    {
        public int id { get; set; }
        public string category { get; set; }
        public string site { get; set; }
        public string username { get; set; }
        public string pass { get; set; }
        public string notes { get; set; }
    }
}
