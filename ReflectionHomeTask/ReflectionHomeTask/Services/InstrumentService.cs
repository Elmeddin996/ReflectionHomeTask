using ReflectionHomeTask.Models.Abstracts;
using ReflectionHomeTask.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHomeTask.Services
{
    internal class InstrumentService
    {

        public List<Instrument> instruments=new List<Instrument>();
       
        internal InstrumentService()
        {
            instruments.Add(new Guitar());
            instruments.Add(new QaraZurna());
            instruments.Add(new Flute());
            instruments.Add(new Piano());
        }
         
        public void PrintAllInstruments()
        {

            Assembly assembly = Assembly.GetExecutingAssembly();

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {

                Console.WriteLine(type.Name);

            }
          
            foreach (Instrument item in instruments.ToList())
            {
                string type=item.GetType().ToString();
                Console.WriteLine($"{type}  {item.Brand}  {item.Model}  {item.Price}");
            }
        }


    }
}
