using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    public class Music
    {
        public string MusicName {  get; set; }

        public int Id {  get; set; }

        public string Memory { get; private set; }

        public int  Date { get; private set; }

        List<Music> MusicList { get;set; }
        
            
    }



}
