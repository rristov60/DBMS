using System;
using System.Collections.Generic;
using System.Text;

namespace SQL
{
    public class Current_User
    {
        private static string username;
        private static string firstName;
        private static string lastName;
        private static string privileges;
        public static bool exception = false;

        public static void SetUser(string _username, string _firstName, string _lastName, string _privileges)
        {
            username = _username;
            firstName = _firstName;
            lastName = _lastName;
            privileges = _privileges;
        }

        public static string GetUserName()
        {
            return username;
        }

        public static string GetFirstName()
        {
            return firstName;
        }

        public static string GetLastName()
        {
            return lastName;
        }

        public static string GetPrivileges()
        {
            return privileges;
        }

    }
}
