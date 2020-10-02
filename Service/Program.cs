using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var exitCode = HostFactory.Run(x =>
            {
                x.Service<DbConn>(s =>
                {
                    s.ConstructUsing(conn => new DbConn());
                    s.WhenStarted(conn => conn.Start());
                    s.WhenStopped(conn => conn.Stop());
                });

                x.RunAsLocalSystem();

                x.SetServiceName("ArduinoUpdate");
                x.SetDisplayName("Arduino Update");
                x.SetDescription("Update DB based on Arduino data");
            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetType());
            Environment.ExitCode = exitCodeValue;
        }
    }
}
