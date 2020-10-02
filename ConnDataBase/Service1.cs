using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConnDataBase
{
    
    public partial class Service1 : ServiceBase
    {
        static readonly HttpClient client = new HttpClient();
        static DataAccess data = new DataAccess();
        public Service1()
        {
            InitializeComponent();
        }

        protected override async void OnStart(string[] args)
        {
            await DataConn();
        }

        protected override void OnStop()
        {
        }

        public async Task DataConn()
        {
            while (true)
            {
                try
                {
                    string body = await client.GetStringAsync("http://192.168.1.177/");
                    UpdateDB(body);
                }
                catch (Exception e)
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
