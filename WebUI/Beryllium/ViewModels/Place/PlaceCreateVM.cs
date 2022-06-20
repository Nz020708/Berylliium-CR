using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.ViewModels.Place
{
    public class PlaceCreateVM
    {
        [Required]
        public string Name { get; set; }
    }
}
