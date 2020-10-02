using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace FormUI
{
    public class DataAccess
    {
        public List<Room> GetRooms(string number)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnVal("con")))
            {
                //var output = connection.Query<Room>($"Select * From Room where Number = '{ number }'").ToList();
                var output = connection.Query<Room>("dbo.spSchoolRooms_GetByRoom @Number", new { Number = number }).ToList();
                return output;
            }
        }

        public void InsertRoom(string number, string temp, string humidity)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnVal("con")))
            {

                List<Room> room = new List<Room>();

                room.Add(new Room { Number = number, Temperature = temp, Humidity = humidity });

                connection.Execute("dbo.RoomInsert @Number, @Temperature, @Humidity", room);
            }
        }
    }
}
