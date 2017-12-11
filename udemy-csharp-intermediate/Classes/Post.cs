using System;

namespace udemy_csharp_intermediate.Classes
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Votes { get; private set; }
        public DateTime DateCreated = DateTime.Now;

        public Post(string title, string description)
        {
            if (String.IsNullOrWhiteSpace(title) || String.IsNullOrWhiteSpace(description))
                throw new ArgumentException("The title/description cannot be null, empty or whitespace.");

            Title = title.Trim();
            Description = description.Trim();
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