using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAssignment
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(e1, e2)
        {
            if (e1.Id.Equals(e2.Id))
            {
                return true;
            }
            {
                return false;
            }
        }
        public static bool operator !=(e1, e2)
        {
            if (!e1.Id.Equals(e2.Id))
            {
                return true;
            }
            {
                return false;
            }

        }

    }
}
