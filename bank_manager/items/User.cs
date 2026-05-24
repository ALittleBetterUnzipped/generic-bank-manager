using System;
using System.Collections.Generic;
using System.Text;

namespace bank_manager.items
{
    internal class User
    {

        private string _userID;
        private string _firstName;
        private string _lastName;
        private string _userEmail;

        public User(string userID, string firstName, string lastName, string email)
        {
            _userID = userID;
            _firstName = firstName;
            _lastName = lastName;
            _userEmail = email;
        }

    }


}
