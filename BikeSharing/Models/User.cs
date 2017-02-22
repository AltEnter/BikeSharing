using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace BikeSharing.Models
{
    public class User:ValidateableModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
