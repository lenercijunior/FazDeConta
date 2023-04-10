using System.ComponentModel;

namespace FazDeConta.Infra.Repositories
{
    public abstract class BaseRepository<T> where T : class
    {
        public void Add(T objeto)
        {
        }
    }
}
