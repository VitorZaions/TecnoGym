using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Tecno_Gym.Database
{
    class Database
    {        
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost; User Id=academy; Database=TECNO_GYM; Port=5432; Password=academia@1578;SSLMode=Prefer");
        }
    }
}
