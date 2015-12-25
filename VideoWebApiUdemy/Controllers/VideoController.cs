using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VideoWebApiUdemy.Models;

namespace VideoWebApiUdemy.Controllers
{
    public class VideoController : ApiController
    {
        VideoDb _db = new VideoDb();
        // GET: api/Video
        public IEnumerable<Video> Get()
        {
            return _db.Videos;
        }

        // GET: api/Video/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Video
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Video/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Video/5
        public void Delete(int id)
        {
        }
    }
}
