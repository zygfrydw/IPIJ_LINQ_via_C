﻿using System;

namespace ITSILESIA.IPIJ_LINQ.Model
{
    public class User : IEquatable<User>
    {
        public string Name { get; set; }
        public UserType UserType { get; set; }

        public User (string name, UserType userType)
        {
            Name = name;
            UserType = userType;
        }



        public override string ToString()
        {
            return string.Format("User: {0} ({1})", Name, UserType);
        }

        public bool Equals(User other)
        {
            return Name == other.Name && UserType == other.UserType;
        }
    }
}
