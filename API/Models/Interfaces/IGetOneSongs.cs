using System.Collections.Generic;
using API.Models;

namespace API.Models.Interfaces
{
    public interface IGetOneSongs
    {
         public Song GetOne(int id);
    }
}