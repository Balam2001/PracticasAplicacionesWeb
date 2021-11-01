using System;
using System.Collections.Generic;

#nullable disable

namespace QueryApi.Domain.Entities
{
    public partial class Person
    {
        public Person()
        {
            //Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }
        public string Job { get; set; }
        public int? Age { get; set; }
        public Address Address { get; internal set; }



        //public virtual ICollection<Address> Addresses { get; set; }
    }
}
