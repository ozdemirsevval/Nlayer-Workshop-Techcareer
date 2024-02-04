using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayerWorkshop.Core.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //foreign key
        public int UserId { get; set; }
        //1-1 ilişki
        public User User { get; set; }
    }
}
