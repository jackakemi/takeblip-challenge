using ChallengeTakeBlip.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChallengeTakeBlip.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GitHubController : ControllerBase
    {
        public List<GitHubModel> gitHubData { get; set; } = new List<GitHubModel>();
        public List<BotData> botData { get; set; } = new List<BotData>();

        [HttpGet]
        public List<BotData> GetRepositoryGitHub()
        {
            string ApiBaseUrl = "https://api.github.com/orgs/takenet/repos";

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ApiBaseUrl);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";
                httpWebRequest.UserAgent = "request";

                var responseString = "";

                using (HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    responseString = reader.ReadToEnd();
                }

                var jsonConvert = JsonConvert.DeserializeObject<List<GitHubModel>>(responseString);
                var json = jsonConvert.Take(5).ToList();

                var list = new BotData();

                foreach (var item in json)
                {
                    string nameRepository = item.full_name;
                    string description = item.description;
                    string urlAvatar = item.owner.avatar_url;

                    botData.Add(new BotData{RepositoryName = nameRepository, RepositoryDescription = description, Avatar = urlAvatar});
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return botData;
        }
    }
}
