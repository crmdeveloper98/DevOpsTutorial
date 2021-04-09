using System.ComponentModel.DataAnnotations;

namespace DevOpsDemo.Models
{
    public class PostViewModel
    {
        public int PostId { get; set; }
        public string Title { get; set; }

        [StringLength(5000)]
        public string Description {get; set;}
        public string Author {get; set;}
    }
}
