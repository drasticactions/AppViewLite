using FishyFlip.Lexicon.App.Bsky.Feed;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable CS1998

namespace AppViewLite.Web.ApiCompat
{
    [Route("/xrpc")]
    [ApiController]
    [EnableCors("BskyClient")]
    public class AppBskyLabeler : ControllerBase
    {
        private readonly BlueskyEnrichedApis apis;
        public AppBskyLabeler(BlueskyEnrichedApis apis)
        {
            this.apis = apis;
        }

        [HttpGet("app.bsky.labeler.getServices")]
        public async Task<IResult> GetServices()
        {
            return new FishyFlip.Lexicon.App.Bsky.Labeler.GetServicesOutput
            {
                Views = []
            }.ToJsonResponse();
        }
    }
}

