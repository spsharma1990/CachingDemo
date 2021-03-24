using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedisCache.Service;

namespace RedisCache.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CacheController : ControllerBase
    {
        public readonly ICacheService _cacheService;
        public CacheController(ICacheService cacheService)
        {
            _cacheService = cacheService;
        }
        [HttpGet("cache/{key}")]
        public async Task<IActionResult> GetCacheValue(string key)
        {
            var value = await _cacheService.GetCacheValueAsync(key);
            return string.IsNullOrEmpty(value) ? (IActionResult)NotFound() : Ok(value);
        }

        [HttpPost("cache")]
        public async Task<IActionResult> SetCacheValue([FromBody]NewCacheEntryPoint request)
        {
            await _cacheService.SetCacheValueAsync(request.key, request.value);
            return Ok();
        }
    }

}
