using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.DataBase
{
    internal abstract class DAL<T> where T : class
    {
        private readonly ScreenSoundContext _context;

        public DAL(ScreenSoundContext context)
        {
            _context = context;
        }
        public IEnumerable<T> List() {
            return _context.Set<T>().ToList();
        }
        public void Add(T obj) {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
        }
        public void Delete(T obj) {
            _context.Set<T>().Remove(obj);
            _context.SaveChanges();
        }
        public void Update(T obj) {
            _context.Set<T>().Update(obj);
            _context.SaveChanges();
        }
        public T? ListByName(Func<T, bool> condicao)
        {
            return _context.Set<T>().FirstOrDefault(condicao);
        }
        public IEnumerable<T> ListarPor(Func<T, bool> condicao)
        {
            return _context.Set<T>().Where(condicao);
        }
    }
}
