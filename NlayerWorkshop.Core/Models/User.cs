using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayerWorkshop.Core.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }

        //foreign key
        public int TeamId { get; set; }

        public Team Team { get; set; } //bire-çok ilişki
    }
}
