using ReflectionHomeTask.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHomeTask.Models.Abstracts
{
    abstract class Instrument
    {
        public abstract string Model { get; set; }
        public abstract string Price { get; set; }
        public abstract string Brand { get; set; }
        public virtual bool IsWindInstrument { get; set; }
        public virtual bool IsStringedInstrument { get; set; }

       
    
        public abstract void Sound();
        

    }
}
