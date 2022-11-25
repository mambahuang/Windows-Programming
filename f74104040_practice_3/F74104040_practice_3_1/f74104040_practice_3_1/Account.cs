using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_manager
{
    class Account : IEquatable<Account>
    {
        public string link { get; set; }
        public string user { get; set; }
        public string pass { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Account objAsAccount = obj as Account;
            if (objAsAccount == null) return false;
            else return Equals(objAsAccount);
        }
        public override int GetHashCode()
        {
            return link.GetHashCode();
        }
        public bool Equals(Account other)
        {
            if (other == null) return false;
            return link.Equals(other.link) && user.Equals(other.user) && pass.Equals(other.pass);
        }
        public Account(string _link, string _user, string _pass)
        {
            link = _link;
            user = _user;
            pass = _pass;
        }

        //public Account()
        //{
            
        //}
    }
}
