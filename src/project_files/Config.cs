using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public static class Config
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                ConnectSQL sql = new ConnectSQL();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
