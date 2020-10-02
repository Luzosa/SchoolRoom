using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoomLibrary;
using DataAccessLibrary;
using System.Net.Http;
using System.Threading;
using Topshelf;

namespace RoomConsole
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();
        static DataAccess data = new DataAccess();
        
        static async Task Main()
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.

           
            while (true)
            {
                try { 
                    string body = await client.GetStringAsync("http://192.168.1.177/");
                    UpdateDB(body);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
                
                Thread.Sleep(2000);
            }
        }

        public static void UpdateDB(string body)
        {
            string print = "";


            for (int i = 0; i < body.Length; i++)
            {
                if (char.IsDigit(Convert.ToChar(body[i])))
                {
                    print += body[i];
                }
            }

            string temp = print.Substring(0, 2);
            string humi = print.Substring(2);

            data.UpdateRoom(temp, humi);
        }
    }
}
