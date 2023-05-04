using Apteka.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apteka
{
    internal class DbConnection
    {
        public static AptekaEntities db = new AptekaEntities();
    }
}
