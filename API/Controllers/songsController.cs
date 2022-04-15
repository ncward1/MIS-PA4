using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Models;
using API.Models.Interfaces;
using Microsoft.AspNetCore.Cors;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class songsController : ControllerBase
    {

        
        // GET: api/songs
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<Song> Get()
        {
            IGetAllSongs readObject = new ReadSongData();
            return readObject.GetAll();
        }

        // GET: api/songs/5
        [EnableCors("AnotherPolicy")]
        [HttpGet("{id}", Name = "Get")]
        public Song Get(int id)
        {
            IGetOneSongs readObject = new ReadSongData();
            return readObject.GetOne(id);
        }

        // POST: api/songs
        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post([FromBody] Song value)
        {
            ICreateSongs insertObject = new ReadSongData();
            insertObject.Create(value.SongTitle);
        }

        // PUT: api/songs/5
        [EnableCors("AnotherPolicy")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            IUpdateSongs updateObject = new ReadSongData();
            updateObject.Update(id);
        }

        // DELETE: api/songs/5
        [EnableCors("AnotherPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            IDeleteSongs deleteObject = new ReadSongData();
            deleteObject.Delete(id);
        }
    }
}
