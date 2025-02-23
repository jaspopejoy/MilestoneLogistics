﻿using MilestoneLogistics.web.Models.Domain;

namespace MilestoneLogistics.web.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<BlogPost> BlogPosts { get; set; }

        public IEnumerable<Tag> Tags { get; set; }
    }
}
