﻿using CoolapkUWP.Core.Models;
using CoolapkUWP.Helpers;
using Newtonsoft.Json.Linq;

namespace CoolapkUWP.Models
{
    internal class DyhModel : Entity
    {
        public string Url { get; private set; }
        public string Title { get; private set; }
        public string Follownum { get; private set; }
        public ImageModel Logo { get; private set; }

        public DyhModel(JObject o) : base(o)
        {
            Url = o.Value<string>("url");
            Title = o.Value<string>("title");
            Follownum = o["follownum"].ToString().Replace("\"", string.Empty, System.StringComparison.Ordinal);
            Logo = new ImageModel(o.Value<string>("logo"), ImageType.Icon);
        }
    }
}