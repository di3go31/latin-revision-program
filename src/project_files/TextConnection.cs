using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class TextConnection : IDataConnection
    {
        public User CreateProfile(UserProfile model)
        {
            model.profileID = 1;
            return model;
        }
    }
}