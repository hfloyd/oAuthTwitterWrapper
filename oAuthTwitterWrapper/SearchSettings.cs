using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OAuthTwitterWrapper
{
	public class SearchSettings : ISearchSettings
	{
		public string SearchFormat { get; set; }
		public string SearchQuery { get; set; }
		public string SearchUrl {
			get { return string.Format(SearchFormat, SearchQuery); }  
		}
	}

    public class TwitterSearchSettingsMissingQueryException : Exception
    {
        private string _message;

        public override string Message
        {
            get
            {
                return _message != "" ? _message : base.Message;
            }
        }

        public TwitterSearchSettingsMissingQueryException()
        {
            _message = "SearchSettings.SearchQuery is missing. Add key='searchQuery' to your web.config, or set the 'SearchSettings.SearchQuery' explicitly in your code before using property 'SearchUrl'.";
        }
    }
}
