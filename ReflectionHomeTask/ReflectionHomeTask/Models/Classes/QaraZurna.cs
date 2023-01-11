using ReflectionHomeTask.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHomeTask.Models.Classes
{
    internal class QaraZurna : Instrument
    {
        public override string Model { get ; set ; }="National";
        public override string Price { get; set; } = "500Azn";
        public override string Brand { get; set; } = "It is Old Azerbaijan Traditional Instrument";
        public override bool IsWindInstrument { get ; set ; }=true;
        public override void Sound()
        {
           
        }
    }
}
