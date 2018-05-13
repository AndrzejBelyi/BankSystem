﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T t);
        void Remove(T t);
        void Update(T t);
        IEnumerable<T> GetAll();
        T GetById(string id);
    }
}
