using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.NewFeatures.Cons.Models
{
    public class Student(string firstName, string lastName)
    {
        public string Fullname => $"{firstName} {lastName}";

        public void ChangeName(string newFirstName, string newLastName)
        {
            firstName = newFirstName;
            lastName = newLastName;
        }
    }
}
