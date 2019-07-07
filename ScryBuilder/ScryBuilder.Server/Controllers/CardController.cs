using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScryBuilder.Shared.Models;
using Ignitus.Option;

namespace ScryBuilder.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        [HttpGet("{name}")]
        public Option<Card> GetCardByName(string name)
        {
            return new None<Card>();
        }

        [HttpGet("list")]
        public List<Option<Card>> GetCardsByName([FromBody]List<string> names)
        {
            return new List<Option<Card>>();
        }
    }
}