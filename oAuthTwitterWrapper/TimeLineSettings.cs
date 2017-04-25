using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OAuthTwitterWrapper
{
    public class TimeLineSettings : ITimeLineSettings
    {
        public string ScreenName { get; set; }
        public string IncludeRts { get; set; }
        public string ExcludeReplies { get; set; }
        public int Count { get; set; }
        public string TimelineFormat { get; set; }

        public string TimelineUrl
        {
            get
            {
                if (String.IsNullOrEmpty(ScreenName))
                {
                    throw new TwitterTimelineSettingsMissingScreenNameException();
                }

                return string.Format(TimelineFormat, ScreenName, IncludeRts, ExcludeReplies, Count);
            }
        }
    }

    public class TwitterTimelineSettingsMissingScreenNameException : Exception
    {
        private string _message;

        public override string Message
        {
            get
            {
                return _message != "" ? _message : base.Message;
            }
        }

        public TwitterTimelineSettingsMissingScreenNameException()
        {
            _message = "TimeLineSettings.ScreenName is missing. Add key='screenname' to your web.config, or set the 'TimeLineSettings.ScreenName' explicitly in your code before using property 'TimelineUrl'.";
        }
    }
}
