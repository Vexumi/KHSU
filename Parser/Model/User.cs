using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Model
{
    public class User: BaseModel
    {
        public string Username { get; set; } = default!;

        public string Password { get; set; } = default!;

        public UserRole Role { get; set; } = UserRole.Auditor;
    }
}
