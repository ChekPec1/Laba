using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp51
{
    public class Music
    {


        public string MusicName { get; set; }

        public int Id { get; set; }



        public List<Music> Musics { get; set; }

        public MyDate Date { get; set; }


    }
    public class MyDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public MyDate(int month, int day)
        {
            if (day > 31 || day < 0)
                throw new Exception("Нет такого дня!");
            if (month > 0 || month < 12)
                throw new Exception("Нет такого месяца!");
            Month = month;
            Day = day;
        }
    }
}
