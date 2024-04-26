using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSol.Classes
{
    internal class RisoluzioniClasse
    {
        //4320p(8K) : 7680 x 4320.
        //2160p(4K) : 3840 x 2160.
        //1440p(2K) : 2560 x 1440.
        //1080p(HD) : 1920 x 1080.
        //720p(HD) : 1280 x 720.
        //480p(SD) : 854 x 480.
        //360p(SD) : 640 x 360.
        //240p(SD) : 426 x 240.
        
        public string Pr1 { get; set; } = "426-240";
        public string Pr2 { get; set; } = "640-360";
        public string Pr3 { get; set; } = "854-480";
        public string Pr4 { get; set; } = "1280-720";
        public string Pr5 { get; set; }  = "1920-1080";
        public string Pr6 { get; set; } = "2560-1440";
        public string Pr7 { get; set; } = "3840-2160";
        public string Pr8 { get; set; } = "7680-4320";

       

        
    }
}
