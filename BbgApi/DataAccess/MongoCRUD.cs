using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;


namespace BbgApi.DataAccess
{
    public class MongoCRUD
    {

        private IMongoDatabase db;

        //constructor
        public MongoCRUD(string database)
        {
            var client = new MongoClient("mongodb+srv://milton:milton@bbgcluster-m9enp.mongodb.net/test?retryWrites=true&w=majority");
            db = client.GetDatabase(database);
        }

        //post
        public void Post<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);

        }

        //get
        public List<T> Get<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();


        }
    }
}

