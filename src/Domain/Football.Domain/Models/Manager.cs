using System;
using System.Collections.Generic;
using System.Text;

namespace Football.Domain.Models
{
    public class Manager
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int YellowCard { get; set; }

        public int RedCard { get; set; }
    }
}
