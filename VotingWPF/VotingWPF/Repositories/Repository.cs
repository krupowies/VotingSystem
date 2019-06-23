using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingWPF.Classes;

namespace ProjektPK.Repositories
{
    class Repository<T>
    {
        private Dictionary<int, T> repository;

        public Repository()
        {
            this.repository = new Dictionary<int, T>();
        }
        public void addElement(int id, T element)
        {
            repository.Add(id, element);
        }
        public void updateElement(int id, T element)
        {
            repository[id] = element;
        }
        public void deleteElement(int id)
        {
            if (repository.ContainsKey(id))
            {
                repository.Remove(id);
            }
            else
            {
                throw new Exception("There is no element with such id");
            }
        }
        public List<T> getAll()
        {
            return repository.Values.ToList();
        }

        public T findById(int id)
        {
            return repository[id];
        }


        public int getLastId()
        {
            if (repository.Count == 0)
            {
                return 0;
            }
            return repository.Keys.Last();

        }


    }
}