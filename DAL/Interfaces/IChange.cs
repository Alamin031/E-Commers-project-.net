using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IChange
    {
        bool ChangePassword(string Sname, string password);
    }
}
