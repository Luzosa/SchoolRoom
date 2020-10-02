using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using RoomLibrary;



namespace DataAccessLibrary
{
    public class DataAccess
    {

        public List<Rooms> GetRooms(string number)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnVal("con")))
            {
                //var output = connection.Query<Room>($"Select * From Room where Number = '{ number }'").ToList();
                var output = connection.Query<Rooms>("dbo.spSchoolRooms_GetByRoom @Number", new { Number = number }).ToList();
                return output;
            }
        }

        public List<Rooms> GetAllRooms()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnVal("con")))
            {
                //var output = connection.Query<Room>($"Select * From Room where Number = '{ number }'").ToList();
                var output = connection.Query<Rooms>("dbo.GetAllRooms").ToList();
                return output;
            }
        }

        public List<Rooms> GetAllRooms(String ConnectionString)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                //var output = connection.Query<Room>($"Select * From Room where Number = '{ number }'").ToList();
                var output = connection.Query<Rooms>("dbo.GetAllRooms").ToList();
                return output;
            }
        }

        public void InsertRoom(string number, string temp, string humidity)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnVal("con")))
            {

                List<Rooms> room = new List<Rooms>();

                room.Add(new Rooms { Number = number, Temperature = temp, Humidity = humidity });

                var command = new SqlCommand("dbo.spSchoolRooms_GetByRoom @Number");
                command.Parameters.AddWithValue("@Number", number);

                int Exist = (int)command.ExecuteScalar();
                
                if( Exist > 0)
                {
                    UpdateRoom(temp, humidity);
                }
                else
                {
                    connection.Execute("dbo.RoomInsert @Number, @Temperature, @Humidity", room);
                }

                
            }
        }

        public void UpdateRoom(string temp, string humidity)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnVal("con")))
            {
                List<Rooms> room = new List<Rooms>();

                room.Add(new Rooms {Temperature = temp, Humidity = humidity });

                connection.Execute("dbo.RoomUpdate @Temperature, @Humidity", room);
            }
        }
    }
}
