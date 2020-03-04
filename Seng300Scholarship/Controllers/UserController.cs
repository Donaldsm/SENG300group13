using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using dto = Seng300Scholarship.Models;

namespace Seng300Scholarship.Controllers
{
    public class UserController
    {
        private MySQLDatabase MySqlDatabase { get; set; }
        public UserController(MySQLDatabase mySqlDatabase)
        {
            this.MySqlDatabase = mySqlDatabase;
        }
        //private async User<List<dto.User>> GetTasks()
        //{
        //    var ret = new List<dto.User>();

        //    var cmd = this.MySqlDatabase.Connection.CreateCommand() as MySqlCommand;
        //    cmd.CommandText = @"SELECT TaskId, Text, Completed FROM Tasks WHERE Archived IS NULL";

        //    using (var reader = await cmd.ExecuteReaderAsync())
        //        while (await reader.ReadAsync())
        //        {
        //            var t = new dto.User()
        //            {
        //                TaskId = reader.GetFieldValue<int>(0),
        //                Text = reader.GetFieldValue<string>(1)
        //            };
        //            if (!reader.IsDBNull(2))
        //                t.Completed = reader.GetFieldValue<DateTime>(2);

        //            ret.Add(t);
        //        }
        //    return ret;
        //}
    }
}
