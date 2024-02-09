using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    public class MainServer
    {
        private string _fail = "Music.json";
        public List<Music> Musics {  get; set; }
        public object JsonConvert { get; }

        public MainServer() 
        {
        if (File.Exists(_fail) == false)
                File.Create(_fail).Close();
            try
            {
                string jsonContent = File.ReadAllText(_fail);
                Musics = JsonConverter.Desia<List<Music>>(jsonContent);
            }
        
        }
    }



}
