using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4Linq.Logic
{
    public interface IABMLogic<T>
    {
        List<T> GetAll();
        T GetElementById(string id);
    }
}
