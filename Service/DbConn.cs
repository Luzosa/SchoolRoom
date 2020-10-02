using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Service
{
    public class DbConn
    {
        private System.Timers.Timer _timer;
        
        static DataAccess data = new DataAccess();
        public DbConn()
        {

            Initialize();
        }

        public void Initialize()
        {
            //log = new EventLog("DynaProLogs");
            _timer = new System.Timers.Timer(2000) { AutoReset = true };
            _timer.Elapsed += GetData;
        }


        public async void GetData(object sender, System.Timers.ElapsedEventArgs args)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-agent", "C# Console Application");
            try
            {
                string body = await client.GetStringAsync("http://192.168.1.177/");
                UpdateDB(body);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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
        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }
    }
}
