using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restapi.DTO
{
    public class StudentDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Fees { get; set; }
    }

}