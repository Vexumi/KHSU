using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Model
{
    public enum UserRole
    {
        Administrator = 0, // read/edit/delete/addUsers
        Employee = 1, // read/edit/delete
        Auditor = 2 // read
    }
}
