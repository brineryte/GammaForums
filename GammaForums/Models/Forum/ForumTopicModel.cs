using GammaForums.Models.Post;
using System.Collections;
using System.Collections.Generic;

namespace GammaForums.Models.Forum
{
    public class ForumTopicModel
    {
        public ForumListingModel Forum { get; set; }
        public IEnumerable<PostListingModel> Posts { get; set; } 
        public string SearchQuery { get; set; }
    }
}
