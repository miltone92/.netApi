using System;
using MongoDB.Driver;

/*
 * Purpose: Allows data base connectivity
 * DB URL: "mongodb+srv://milton:milton@authordb-m9enp.mongodb.net/test?retryWrites=true&w=majority"
 * mongodb+srv://milton:<password>@bbgcluster-m9enp.mongodb.net/test?retryWrites=true&w=majority
 */

namespace BbgApi.Models
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
    }
}

