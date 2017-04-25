namespace oAuthTwitterWrapper.Models
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    using OAuthTwitterWrapper.JsonTypes;

    public class Tweet : TimeLine
    {
        private const string _TwitterDateFormat = "ddd MMM dd HH:mm:ss +ffff yyyy"; //ex: "Mon Apr 18 15:26:21 +0000 2016"

        //Customized Props
        public DateTime CreatedAtDate
        {
            get
            {
                var dateString = this.CreatedAt;
                var dateParsed = DateTime.ParseExact(this.CreatedAt, _TwitterDateFormat, new System.Globalization.CultureInfo("en-US"));
                return dateParsed;
            }
        }

        public string Url
        {
            get { return string.Format("https://twitter.com/{0}/status/{1}", this.User.ScreenName, this.Id); }
        }

        public string TextWithoutUrls
        {
            get
            {
                var text = this.Text;
                text = Regex.Replace(text, "(http(s)?://)?([\\w-]+\\.)+[\\w-]+(/\\S\\w[\\w- ;,./?%&=]\\S*)?", new MatchEvaluator(ReplaceUrl));
                return text;
            }
        }

        public bool HasMedia
        {
            get { return this.Entities.Media != null && this.Entities.Media.Any(); }
        }

        public bool IsOriginalPost
        {
            get
            {
                if (InReplyToStatusId == "" && InReplyToUserId == "" && InReplyToScreenName == "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //Standard JsonProps
        //public string CreatedAt { get; set; }

        //public string Id { get; set; }

        //public string IdStr { get; set; }

        //public string Text { get; set; }

        //public string Source { get; set; }

        //public bool Truncated { get; set; }

        //public string InReplyToStatusId { get; set; }

        //public string InReplyToStatusIdStr { get; set; }

        //public string InReplyToUserId { get; set; }

        //public string InReplyToUserIdStr { get; set; }

        //public string InReplyToScreenName { get; set; }

        //public User User { get; set; }

        //public string Geo { get; set; }

        //public string Coordinates { get; set; }

        //public Place Place { get; set; }

        //public string Contributors { get; set; }

        //public int RetweetCount { get; set; }

        //public int FavoriteCount { get; set; }

        //public Entities Entities { get; set; }

        //public bool Favorited { get; set; }

        //public bool Retweeted { get; set; }

        //public string Lang { get; set; }

        //Present only in 'Status' object from Search
        public Metadata StatusMetadata { get; set; }

        public Status StatusRetweetedStatus { get; set; }

        public bool? StatusPossiblySensitive { get; set; } 

        public Tweet(TimeLine TimelineObject)
        {
            //Fill Standard Json Props
            this.CreatedAt = TimelineObject.CreatedAt;
            this.Id = TimelineObject.Id;
            this.IdStr = TimelineObject.IdStr;
            this.Text = TimelineObject.Text;
            this.Source = TimelineObject.Source;
            this.Truncated = TimelineObject.Truncated;
            this.InReplyToStatusId = TimelineObject.InReplyToStatusId;
            this.InReplyToStatusIdStr = TimelineObject.InReplyToStatusIdStr;
            this.InReplyToUserId = TimelineObject.InReplyToUserId;
            this.InReplyToUserIdStr = TimelineObject.InReplyToUserIdStr;
            this.InReplyToScreenName = TimelineObject.InReplyToScreenName;
            this.User = TimelineObject.User;
            this.Geo = TimelineObject.Geo;
            this.Coordinates = TimelineObject.Coordinates;
            this.Place = TimelineObject.Place;
            this.Contributors = TimelineObject.Contributors;
            this.RetweetCount = TimelineObject.RetweetCount;
            this.FavoriteCount = TimelineObject.FavoriteCount;
            this.Entities = TimelineObject.Entities;
            this.Favorited = TimelineObject.Favorited;
            this.Retweeted = TimelineObject.Retweeted;
            this.Lang = TimelineObject.Lang;
        }

        public Tweet(Status StatusObject)
        {
            //Fill Standard Json Props
            this.CreatedAt = StatusObject.CreatedAt;
            this.Id = StatusObject.Id;
            this.IdStr = StatusObject.IdStr;
            this.Text = StatusObject.Text;
            this.Source = StatusObject.Source;
            this.Truncated = StatusObject.Truncated;
            this.InReplyToStatusId = StatusObject.InReplyToStatusId;
            this.InReplyToStatusIdStr = StatusObject.InReplyToStatusIdStr;
            this.InReplyToUserId = StatusObject.InReplyToUserId;
            this.InReplyToUserIdStr = StatusObject.InReplyToUserIdStr;
            this.InReplyToScreenName = StatusObject.InReplyToScreenName;
            this.User = StatusObject.User;
            this.Geo = StatusObject.Geo;
            this.Coordinates = StatusObject.Coordinates;
            this.Place = StatusObject.Place;
            this.Contributors = StatusObject.Contributors;
            this.RetweetCount = StatusObject.RetweetCount;
            this.FavoriteCount = StatusObject.FavoriteCount;
            this.Entities = StatusObject.Entities;
            this.Favorited = StatusObject.Favorited;
            this.Retweeted = StatusObject.Retweeted;
            this.Lang = StatusObject.Lang;

            this.StatusMetadata = StatusObject.Metadata;
            this.StatusRetweetedStatus = StatusObject.RetweetedStatus;
            this.StatusPossiblySensitive = StatusObject.PossiblySensitive;
        }


        private static string ReplaceUrl(Match m)
        {
            string str = m.ToString();
            return "[LINK]";
        }
    }
}
