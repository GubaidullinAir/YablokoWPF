using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infoSysBackOffice
{
    class session
    {
        public int sessionId;
        public int userId
        {
            get { return sessionId; }
            set { sessionId = value; }
        }
    }
}
