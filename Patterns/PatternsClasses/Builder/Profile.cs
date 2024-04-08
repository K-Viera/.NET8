using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsClasses.Builder
{

    public class SocialMediaProfile
    {
        public string Name { get; set; }

        public SocialMediaType SocialMediaType { get; set;} 
        private List<SocialMediaProfile> Friends { get; }

        public SocialMediaProfile(string name)
        {
            Friends = new List<SocialMediaProfile>();
            Name = name;
        }
        public void AddFriend(SocialMediaProfile friend)
        {
            Friends.Add(friend);
        }
        public void AddNewFriend(SocialMediaProfile friend)
        {
            this.AddFriend(friend);
            friend.AddFriend(this);
        }
    }
    public enum SocialMediaType
    {
        Individual,
        Company
    }
}
