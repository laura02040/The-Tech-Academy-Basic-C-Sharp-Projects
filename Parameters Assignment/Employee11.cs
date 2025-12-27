using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignement
{
    //Make the Employee class take a generic type parameter <T>
    public class Employee<T>
    {
        //Add a property called "Things" with a generic list matching the class type
        public List<T> Things { get; set; }
        public string Name { get; set; }
        public Employee(string name)
        {
            Name = name;
            Things = new List<T>();
        }
        public void AddThing(T item)
        {
            Things.Add(item);
        }
    }
}
