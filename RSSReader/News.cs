using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace RSSReader
{
    public class News
    {
        public string Link { get; set; } 
        public string Description { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
    

}
