using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Generics
{
    interface IGeneric<T> where T: class
    {
        Task Add(T Objeto);
        Task Update(T Objeto);
        Task task(T Objeto);
        Task<T> GetEntityById(int id);
        Task<List<T>> List();
    }
}
