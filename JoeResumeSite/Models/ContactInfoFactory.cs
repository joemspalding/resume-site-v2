using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JoeResumeSite.Models
{
    public static class ContactInfoFactory
    {
        public static ContactInfoViewModel LinkedIn
        {
            get
            {
                return new ContactInfoViewModel
                {
                    Name = "linkedin",
                    Blurb = @"My LinkedIn account is where you can connect with me and discuss employment opportunites. I'm currently at Waystar, but I am always open to opportunities!",
                    Url = @"https://www.linkedin.com/in/joseph-miles-spalding"
                };
            }
        }
        public static ContactInfoViewModel GitHub
        {
            get
            {
                return new ContactInfoViewModel
                {
                    Name = "github",
                    Blurb = @"I run a modest shop over at github, though a useful tool for groups of developers to contribute to amazing and passionate projects, I mostly use it for $&#!-posting dumb ideas! Go ahead and follow me if you're into that!",
                    Url = @"https://github.com/joemspalding"
                };
            }
        }
        public static ContactInfoViewModel SoundCloud
        {
            get
            {
                return new ContactInfoViewModel
                {
                    Name = "soundcloud",
                    Blurb = @"I mostly post crappy electronic music here, but you know what, it's MY crappy electronic music that I made! Go check it out.",
                    Url = @"https://soundcloud.com/joe-spalding-949266409"
                };
            }
        }

    }
}