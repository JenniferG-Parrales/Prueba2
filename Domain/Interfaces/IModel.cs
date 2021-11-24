using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IModel<T>
    {
        void Create(T t);
         T[] GetAll();
        void Update(int index, T t2);
        void Delete(T t);
        int GetLastIndex();
    }
}
