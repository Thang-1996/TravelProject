using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TravelServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TravelServices" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TravelServices.svc or TravelServices.svc.cs at the Solution Explorer and start debugging.
    public class TravelServices : ITravelServices
    {
        TravelDataContext data = new TravelDataContext();

        public bool AddComment(Comment comment)
        {
            try
            {
                data.Comments.InsertOnSubmit(comment);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool AddImage(Image image)
        {
            try
            {
                data.Images.InsertOnSubmit(image);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool AddLocation(Location location)
        {
            try
            {
                data.Locations.InsertOnSubmit(location);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool AddPost(Post post)
        {
            try
            {
                data.Posts.InsertOnSubmit(post);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool DeleteComment(string id)
        {
            try
            {
                var comment = data.Comments.Where(b => b.id == int.Parse(id)).FirstOrDefault();
                data.Comments.DeleteOnSubmit(comment);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool DeleteImage(string id)
        {
            try
            {
                var image = data.Images.Where(b => b.id == int.Parse(id)).FirstOrDefault();
                data.Images.DeleteOnSubmit(image);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool DeleteLocation(string id)
        {
            try
            {
                var location = data.Locations.Where(b => b.id == int.Parse(id)).FirstOrDefault();
                data.Locations.DeleteOnSubmit(location);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool DeletePost(string id)
        {
            try
            {
                var post = data.Posts.Where(b => b.id == int.Parse(id)).FirstOrDefault();
                data.Posts.DeleteOnSubmit(post);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool EditComment(string id, Comment newComment)
        {
            try
            {
                var comment = data.Comments.Where(b => b.id == int.Parse(id)).FirstOrDefault();
                data.Comments.DeleteOnSubmit(comment);
                data.Comments.InsertOnSubmit(newComment);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool EditImage(string id, Image newImage)
        {
            try
            {
                var image = data.Images.Where(b => b.id == int.Parse(id)).FirstOrDefault();
                data.Images.DeleteOnSubmit(image);
                data.Images.InsertOnSubmit(newImage);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool EditLocation(string id, Location newlocation)
        {
            try
            {
                var location = data.Locations.Where(b => b.id == int.Parse(id)).FirstOrDefault();
                data.Locations.DeleteOnSubmit(location);
                data.Locations.InsertOnSubmit(newlocation);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
           
        }

        public bool EditPost(string id, Post newPost)
        {
            try
            {
                var post = data.Posts.Where(b => b.id == int.Parse(id)).FirstOrDefault();
                data.Posts.DeleteOnSubmit(post);
                data.Posts.InsertOnSubmit(newPost);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public List<Comment> GetComments()
        {
            try
            {
                var comments = (from comment in data.Comments select comment).ToList();
                return comments;
            }
            catch { return null; }
        }

        public List<Image> GetImages()
        {
            try
            {
                var images = (from image in data.Images select image).ToList();
                return images;
            }
            catch { return null; }
        }

        public List<Location> GetLocations()
        {
            try
            {
                var locations = (from location in data.Locations select location).ToList();
                return locations;
            }
            catch { return null; }
        }

        public List<Post> GetPosts()
        {
            try
            {
                var posts = (from post in data.Posts select post).ToList();
                return posts;
            }
            catch { return null; }
        }
    }
}
