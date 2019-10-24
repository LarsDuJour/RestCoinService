using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestCoinService.Model;

namespace RestCoinService.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowAnyOrigin")]
    [ApiController]
    public class CoinController : ControllerBase
    {
        private static List<Coin> CoinList = new List<Coin>()
        {
            new Coin(1, "Gold DK 1640", 0, "ingen"),
            new Coin(2, "Gold NL 1764", 0, "ingen"),
            new Coin(3, "Gold FR 1644", 0, "ingen"),
            new Coin(4, "Gold FR 1644", 0, "ingen"),
            new Coin(5, "Silver GR 333", 0, "ingen")
        };

        // OPTIONS: api/Coin
        [HttpOptions]
        public string Options()
        {
            return "help me";
        }

        // GET: api/Coin
        [HttpGet]
        public IEnumerable<Coin> Get()
        {
            return CoinList;
        }

        // GET: api/Coin/5
        [HttpGet("{id}", Name = "Get")]
        public Coin Get(int id)
        {
            return CoinList.Find(b => b.Id == id);
        }

        // POST: api/Coin
        [HttpPost]
        public void Post([FromBody] Coin value)
        {
            CoinList.Add(value);
        }

        // PUT: api/Coin/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Coin value)
        {
            Coin b = CoinList.Find(c => c.Id == id);
            b.Id = value.Id;
            b.Genstand = value.Genstand;
            b.Bud = value.Bud;
            b.Navn = value.Navn;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            CoinList.Remove(CoinList.Find(b => b.Id == id));
        }


        //kunde relateret søgninger

        [HttpGet("{navn}")]
        public void GetNavn(string navn)
        {
            //CoinList.Find(CoinList.Find(b => b.Navn == navn));
        }
    }
}