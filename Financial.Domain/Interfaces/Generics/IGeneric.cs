﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Financial.Domain.Interfaces.Generics
{
    public interface IGeneric<T> where T : class
    {
        Task Add(T Objeto);
        Task Update(T Objeto);
        Task Delete(T Objeto);
        Task<T> GetEntityById(int id);
        Task<List<T>> List();
    }
}
