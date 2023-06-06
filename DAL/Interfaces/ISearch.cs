using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ISearch<T>
    {
        List<T> Search(Dictionary<string,dynamic> Search);
    }
}
