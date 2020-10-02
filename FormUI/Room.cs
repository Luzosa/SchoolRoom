using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Room
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public string Temperature { get; set; }
        public string Humidity { get; set; }

        public string FullInfo 
        { 
            get
            {
                return $"Room Number: {Number}, Temperature: {Temperature}, Humidity: {Humidity}";
            } 
        }
    }
}
