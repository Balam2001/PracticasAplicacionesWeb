using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueryApi.Domain.Dtos
{
    public record PersonRequest(int Age, char? Gender, string City);
}