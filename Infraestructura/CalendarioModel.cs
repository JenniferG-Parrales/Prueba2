using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura
{
    public class CalendarioModel : ICalendarioRepos
    {
        protected List<CalendarioPrest> data;
        public CalendarioModel()
        {
            data = new List<CalendarioPrest>();
        }
        public void Create(CalendarioPrest e)
        {
            data.Add(e);
        }

        public void Delete(CalendarioPrest e)
        {
            data.Remove(e);
        }

        public List<CalendarioPrest> GetAll()
        {
            return data;
        }

        public int GetLastIndex()
        {
            throw new NotImplementedException();
        }

        public void Update(int index, CalendarioPrest e)
        {
            data.Insert(index, e);
        }
    }
}
