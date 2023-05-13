using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cachorro
{
    public class Dog
    {
        Random rand = new Random();
        public  System.Drawing.Point speed { get; set; }
  
        public int acel { get; set; }

        public  System.Drawing.Point max { get; set; }
      

        
        public int startX { get; set; }
        public int startY { get; set; }
 
    }
}
