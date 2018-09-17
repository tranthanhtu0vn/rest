using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Web.Http;

namespace Rest.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController: ApiController
    {
        public IList<User> users;
        public UsersController()
        {
            this.users = new List<User>();
            this.users.Add(new User(1,"Tu", "Tran"));
            this.users.Add(new User(2, "Tu 2", "Tran"));
        }
        [Route("")]
        [HttpGet()]
        public IList<User> GetUsers() {
            return this.users;
        }
    }
    [DataContract(Name="User")]
    public class User {
        [DataMember(Name="Id")]
        public int Id { get; set; }
        [DataMember(Name = "LastName")]
        public string LastName { get; set; }
        [DataMember(Name = "FirstName")]
        public string FirstName { get; set; }
        public User(int id, string fName, string lName)
        {
            this.Id = id;
            this.FirstName = fName;
            this.LastName = lName;
        }

    }
}