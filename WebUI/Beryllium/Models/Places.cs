using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Models
{
    public class Places
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public bool isDeleted { get; set; }
    }
}
