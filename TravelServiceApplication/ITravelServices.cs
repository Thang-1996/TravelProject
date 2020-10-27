using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TravelServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITravelServices" in both code and config file together.
    [ServiceContract]
    public interface ITravelServices
    {
        //Location Services
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
           UriTemplate = "api/v1/GetLocationList"
         )] // định nghĩa đường link trả về
        List<Location> GetLocations();
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
           UriTemplate = "api/v1/CreateLocation"
         )] // định nghĩa đường link trả về
        bool AddLocation(Location location);
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "PUT",
          ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
          UriTemplate = "api/v1/EditLocation/{id}"
        )] // định nghĩa đường link trả về
        bool EditLocation(string id,Location location);
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
          UriTemplate = "api/v1/DeleteLocation/{id}"
        )] // định nghĩa đường link trả về
        bool DeleteLocation(string id);

        // POST Services
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
           UriTemplate = "api/v1/GetPostList"
         )] // định nghĩa đường link trả về
        List<Post> GetPosts();
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
           UriTemplate = "api/v1/CreatePost"
         )] // định nghĩa đường link trả về
        bool AddPost(Post post);
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "PUT",
          ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
          UriTemplate = "api/v1/EditPost/{id}"
        )] // định nghĩa đường link trả về
        bool EditPost(string id, Post post);
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
          UriTemplate = "api/v1/DeletePost/{id}"
        )] // định nghĩa đường link trả về
        bool DeletePost(string id);

        // Comment Services

        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "GET",
          ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
          UriTemplate = "api/v1/GetCommentList"
        )] // định nghĩa đường link trả về
        List<Comment> GetComments();
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
           UriTemplate = "api/v1/CreateComment"
         )] // định nghĩa đường link trả về
        bool AddComment(Comment comment);
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "PUT",
          ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
          UriTemplate = "api/v1/EditComment/{id}"
        )] // định nghĩa đường link trả về
        bool EditComment(string id, Comment comment);
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
          UriTemplate = "api/v1/DeleteComment/{id}"
        )] // định nghĩa đường link trả về
        bool DeleteComment(string id);


        // Images Services
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "GET",
          ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
          UriTemplate = "api/v1/GetImageList"
        )] // định nghĩa đường link trả về
        List<Image> GetImages();
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
           UriTemplate = "api/v1/CreateImage"
         )] // định nghĩa đường link trả về
        bool AddImage(Image image);
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "PUT",
          ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
          UriTemplate = "api/v1/EditImage/{id}"
        )] // định nghĩa đường link trả về
        bool EditImage(string id, Image image);
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
          UriTemplate = "api/v1/DeleteImage/{id}"
        )] // định nghĩa đường link trả về
        bool DeleteImage(string id);
    }
}
