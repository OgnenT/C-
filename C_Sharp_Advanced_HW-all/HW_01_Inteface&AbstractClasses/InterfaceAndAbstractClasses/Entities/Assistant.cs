using InterfaceAndAbstractClasses.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractClasses.Entities
{
    public class Assistant : User, IAssistant
    {
        public Dictionary<int, string> Homeworks { get; set; } = new Dictionary<int, string>();
        public void ShowHomeworksResult()
        {
            foreach (var key in Homeworks)
            {
                Console.WriteLine(key);
            };
        }
    }
}
