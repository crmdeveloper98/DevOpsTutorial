using DevOpsDemo.Models;
using System.Collections.Generic;

namespace DevOpsDemo.Contracts
{
    public interface IPostRepository
    {
        List<PostViewModel> GetPosts();
    }
}
