using System.Collections.Generic;

namespace GetContactAPI
{
    public class MainProfile
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string TagCount { get; set; }
        public string[] DefaultSearchCount { get; set; }
        public string[] TagSearchCount { get; set; }
    }

    public class TagProfile
    {
        public List<string> Tags { get; set; }
        public string DeletedTags { get; set; }

    }
}
