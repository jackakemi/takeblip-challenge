using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


namespace ChallengeTakeBlip.Model
{
    public class GitHubModel
    {
        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }


        [JsonPropertyName("name")]
        public string Name { get; set; }


        [JsonPropertyName("full_name")]
        public string FullName { get; set; }


        [JsonPropertyName("owner")]
        public string Owner { get; set; }


        [JsonPropertyName("description")]
        public string Description { get; set; }


        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }


        [JsonPropertyName("updated_at")]
        public string UpdateAt { get; set; }


        [JsonPropertyName("language")]
        public string Language { get; set; }


        [JsonPropertyName("languages_url")]
        public string LanguagesUrl { get; set; }

        [JsonPropertyName("html_url")]
        public string LinkRepo { get; set; }
    }
}
