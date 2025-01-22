using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.DataBase
{
    internal class MusicaDAL : DAL<Musica>
    {
        private readonly ScreenSoundContext _context;
        public MusicaDAL(ScreenSoundContext context) : base(context){ }
        
    }
}
