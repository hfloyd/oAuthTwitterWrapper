using System.Collections.Generic;
using Newtonsoft.Json;

namespace OAuthTwitterWrapper.JsonTypes
{
    using oAuthTwitterWrapper.JsonTypes;

    public class Metadata
    {
        [JsonProperty("result_type")]
        public string ResultType { get; set; }

        [JsonProperty("iso_language_code")]
        public string IsoLanguageCode { get; set; }
    }

    //public class RetweetedStatus
    //{
    //    [JsonProperty("metadata")]
    //    public Metadata Metadata { get; set; }

    //    [JsonProperty("created_at")]
    //    public string CreatedAt { get; set; }

    //    [JsonProperty("id")]
    //    public long Id { get; set; }

    //    [JsonProperty("id_str")]
    //    public string id_str { get; set; }

    //    [JsonProperty("text")]
    //    public string text { get; set; }

    //    [JsonProperty("source")]
    //    public string source { get; set; }

    //    [JsonProperty("truncated")]
    //    public bool truncated { get; set; }

    //    [JsonProperty("in_reply_to_status_id")]
    //    public object in_reply_to_status_id { get; set; }

    //    [JsonProperty("in_reply_to_status_id_str")]
    //    public object in_reply_to_status_id_str { get; set; }

    //    [JsonProperty("in_reply_to_user_id")]
    //    public object in_reply_to_user_id { get; set; }

    //    [JsonProperty("in_reply_to_user_id_str")]
    //    public object in_reply_to_user_id_str { get; set; }

    //    [JsonProperty("in_reply_to_screen_name")]
    //    public object in_reply_to_screen_name { get; set; }

    //    [JsonProperty("user")]
    //    public User user { get; set; }

    //    [JsonProperty("geo")]
    //    public object geo { get; set; }

    //    [JsonProperty("coordinates")]
    //    public object coordinates { get; set; }

    //    [JsonProperty("place")]
    //    public object place { get; set; }

    //    [JsonProperty("created_at")]
    //    public object contributors { get; set; }

    //    [JsonProperty("retweet_count")]
    //    public int retweet_count { get; set; }

    //    [JsonProperty("favorite_count")]
    //    public int favorite_count { get; set; }

    //    [JsonProperty("entities")]
    //    public Entities entities { get; set; }

    //    [JsonProperty("favorited")]
    //    public bool favorited { get; set; }

    //    [JsonProperty("retweeted")]
    //    public bool retweeted { get; set; }

    //    [JsonProperty("lang")]
    //    public string lang { get; set; }
    //}

    public class Status
    {
        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("id_str")]
        public string IdStr { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("truncated")]
        public bool Truncated { get; set; }

        [JsonProperty("in_reply_to_status_id")]
        public string InReplyToStatusId { get; set; }

        [JsonProperty("in_reply_to_status_id_str")]
        public string InReplyToStatusIdStr { get; set; }

        [JsonProperty("in_reply_to_user_id")]
        public string InReplyToUserId { get; set; }

        [JsonProperty("in_reply_to_user_id_str")]
        public string InReplyToUserIdStr { get; set; }

        [JsonProperty("in_reply_to_screen_name")]
        public string InReplyToScreenName { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("geo")]
        public string Geo { get; set; }

        [JsonProperty("coordinates")]
        public string Coordinates { get; set; }

        [JsonProperty("place")]
        public Place Place { get; set; }

        [JsonProperty("contributors")]
        public string Contributors { get; set; }

        [JsonProperty("retweet_count")]
        public int RetweetCount { get; set; }

        [JsonProperty("favorite_count")]
        public int FavoriteCount { get; set; }

        [JsonProperty("entities")]
        public Entities Entities { get; set; }

        [JsonProperty("favorited")]
        public bool Favorited { get; set; }

        [JsonProperty("retweeted")]
        public bool Retweeted { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("retweeted_status")]
        public Status RetweetedStatus { get; set; }
        //public RetweetedStatus RetweetedStatus { get; set; }

        [JsonProperty("possibly_sensitive")]
        public bool? PossiblySensitive { get; set; }
    }

    public class SearchMetadata
    {
        [JsonProperty("completed_in")]
        public double CompletedIn { get; set; }

        [JsonProperty("max_id")]
        public long MaxId { get; set; }

        [JsonProperty("max_id_str")]
        public string MaxIdStr { get; set; }

        [JsonProperty("next_results")]
        public string NextResults { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("refresh_url")]
        public string RefreshUrl { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("since_id")]
        public int SinceId { get; set; }

        [JsonProperty("since_id_str")]
        public string SinceIdStr { get; set; }
    }

    public class Search
    {
        [JsonProperty("statuses")]
        public List<Status> Results { get; set; }

        [JsonProperty("search_metadata")]
        public SearchMetadata SearchMetadata { get; set; }
    }

}


