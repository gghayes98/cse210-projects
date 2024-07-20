using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Foundation1
{
    internal class Tracker
    {
        private List<Video> _videos;

        public Tracker() { _videos = new List<Video>(); }

        public void Run()
        {
            Video vid1 = new Video("Easy Homemade Pizza Recipe", "CookingWithEmma", 694);
            vid1.AddComment(new Comment("PizzaLover123", "Tried this recipe last night, and it was delicious! Thanks Emma!"));
            vid1.AddComment(new Comment("ChefMike", "Great tips for making the dough. I added some garlic powder for extra flavor."));
            vid1.AddComment(new Comment("BusyMom", "So simple and quick! My kids loved helping out with this recipe."));
            _videos.Add(vid1);

            Video vid2 = new Video("Top 5 Tips for Beginner Programmers", "CodeMaster101", 300);
            vid2.AddComment(new Comment("GeekGirl42", "These tips were super helpful! Thanks for sharing!"));
            vid2.AddComment(new Comment("DevDude", "Great video fro newbies. Learned a lot!"));
            vid2.AddComment(new Comment("CodeQueen", "I wish I had this guide when I started coding. Awesome Job!"));
            _videos.Add(vid2);

            Video vid3 = new Video("Beginner's Guide to Yoga", "ZenMaster", 450);
            vid3.AddComment(new Comment("NamasteNancy", "Great introduction to yoga. Feeling more relaxed already."));
            vid3.AddComment(new Comment("FlexiLexi", "I’ve been wanting to start yoga, and this is perfect. Thanks!"));
            vid3.AddComment(new Comment("CalmCarl", "Easy to follow and very informative. Great job!"));
            _videos.Add(vid3);

            Video vid4 = new Video("10 Easy Recipes for College Students", "QuickBites", 600);
            vid4.AddComment(new Comment("HungryStudent", "Finally, recipes I can actually make! Thanks!"));
            vid4.AddComment(new Comment("FoodieFrenzy", "These look delicious and simple. Will definitely try them out."));
            vid4.AddComment(new Comment("MealPrepQueen", "Perfect for busy weeks. Thanks for the ideas!"));
            _videos.Add(vid4);

            DisplayVideoInfo();
        }

        public void DisplayVideoInfo()
        { 
            foreach (Video video in _videos) 
            {
                Console.WriteLine(video.GetDisplayInfo());
                video.PrintComments();
            } 
        }
    }
}
