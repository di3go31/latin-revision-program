using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class ConnectSQL : IDataConnection
    {
        public UserProfile CreateProfile(UserProfile model)
        {
            throw new NotImplementedException();
        }
        User IDataConnection.CreateProfile(UserProfile model)
        {
            throw new NotImplementedException();
        }
    }
}