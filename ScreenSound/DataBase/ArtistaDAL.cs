using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;

namespace ScreenSound.DataBase
{
    internal class ArtistaDAL : DAL<Artista>
    {
        private readonly ScreenSoundContext _context;

        public ArtistaDAL(ScreenSoundContext context): base(context) { }
    }
}
