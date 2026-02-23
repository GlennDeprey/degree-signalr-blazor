using Pin.NewFeatures.Cons.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.NewFeatures.Cons.Models
{
    public class HowestPerson(string firstName, string lastName, HowestPersonType howestPersonType = HowestPersonType.Student)
    {
        public string Fullname => $"{firstName} {lastName}";
        
        public string Email => $"{firstName.ToLower()}.{lastName.ToLower()}@{GetEmailSuffix(howestPersonType)}";
        public string Status => howestPersonType.ToString();

        private string GetEmailSuffix(HowestPersonType type) => type switch
        {
            HowestPersonType.Student => "student.howest.be",
            HowestPersonType.Staff => "howest.be",
            HowestPersonType.Guest => "guest.howest.be",
            _ => "student.howest.be"
        };

        public void ChangeName(string newFirstName, string newLastName)
        {
            firstName = newFirstName;
            lastName = newLastName;
        }
        public void ChangeStatus(HowestPersonType newType)
        {
            howestPersonType = newType;
        }
    }
}
