using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueryApi.Domain.Entities
{
    public record Address(string Street, string Number, string ZipCode, string City);
    
}