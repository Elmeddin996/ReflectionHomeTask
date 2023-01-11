using ReflectionHomeTask.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHomeTask.Models.Classes
{
    internal class Piano : Instrument
    {
        public override string Brand { get; set; } = "Yamaha";
        public override string Model { get; set; } = "P22D";
        public override string Price { get; set; } = "8800$";

        public override void Sound()
        {
          
        }
    }
}
