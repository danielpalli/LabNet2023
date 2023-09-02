﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T element);
        void Delete(int id);
        void Update(T element);
    }
}
