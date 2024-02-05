using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using

namespace Pod_Booking.dbAccess
{
    internal class ClientDBAccess
    {

        private Pod_Booking.objects.Database db;

        public ClientDBAccess(Pod_Booking.objects.Database _db)
        {
            db = _db;
        }



        public void GetAllCustomers()
        {
            string sqlCmd = "SELECT * FROM Client order by Surname asc";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }
    }
    
}
