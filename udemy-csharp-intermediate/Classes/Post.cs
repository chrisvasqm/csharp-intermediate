using System;

namespace udemy_csharp_intermediate.Classes
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Votes { get; private set; }
        public DateTime DateCreated { get; }

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            DateCreated = DateTime.Now;
        }

        public void UpVote()
        {
            Votes++;
        }

        public void DownVote()
        {
            Votes--;
        }
    }
}