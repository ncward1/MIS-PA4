using System.Collections.Generic;
using API.Models;

namespace API.Models.Interfaces
{
    public interface IGetAllSongs
    {
        public List<Song> GetAll();
         
    }
}