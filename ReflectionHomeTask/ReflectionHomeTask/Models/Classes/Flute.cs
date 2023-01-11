using ReflectionHomeTask.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHomeTask.Models.Classes
{
    internal class Flute : Instrument
    {
        public override string Model { get; set; } = "797H Series";
        public override string Price { get; set; } = "7345$";
        public override string Brand { get; set; } = "Yamaha";
        public override bool IsWindInstrument { get; set; }=true;

        public override void Sound()
        {
          
        }
    }
}
