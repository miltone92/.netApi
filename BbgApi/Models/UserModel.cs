using System;
using MongoDB.Bson.Serialization.Attributes;


namespace BbgApi.Models
{
    public class UserModel
    {

        //Attributess
        [BsonId]
        public Guid Id { get; set;}
        public string UserName { get; set; }
        public string Password { get; set; }

        //Constructor
        public UserModel()
        {
        }

        //Constructor
        public UserModel(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

    }
}


