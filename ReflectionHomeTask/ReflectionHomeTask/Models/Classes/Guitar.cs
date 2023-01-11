using ReflectionHomeTask.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHomeTask.Models.Classes
{
    internal class Guitar : Instrument
    {
        public override string Model { get; set; } =  "PAC012";
        public override string Price { get; set; } = "250$";
        public override string Brand { get; set; } ="Yamaha";
        public override bool IsStringedInstrument { get ; set; }=true;

        public override void Sound()
        {
           
        }
    }
}
