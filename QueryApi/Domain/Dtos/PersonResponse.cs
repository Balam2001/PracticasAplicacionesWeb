using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueryApi.Domain.Dtos
{
    public record PersonResponse(string Name, string Email, string ZipCode);
}