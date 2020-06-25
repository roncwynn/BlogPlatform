using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public interface IRepository<T> where T : class
    {

        public IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T obj);
        void Delete(Content content);
        void Update(Content content);

    }
}
