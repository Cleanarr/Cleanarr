﻿using System.Collections.Generic;

namespace cleanerr.data.Models
{
    public class MediaProvider
    {
        public int    MediaProviderId { get; set; }
        public string Name            { get; set; }
        public string PluginFile      { get; set; }

        public ICollection<User>      Users      { get; set; }
        public ICollection<MediaItem> MediaItems { get; set; }
    }
}
