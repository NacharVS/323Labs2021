using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Group323TOP
{
    class MongoExamples
    {
        public class Person 
        { 

            public Person(string name, int age, int group)
            {
                this.name = name;
                this.age = age;
                this.Group = group;
            }

            [BsonId]
            [BsonIgnoreIfDefault]
            ObjectId _id;
            [BsonElement("Имя")]
            public string name { get; set; }
            public int age { get; set; }
            [BsonIgnoreIfDefault]
            public int Group { get; set; }
            //public List<string> items = new List<string>();

            public static void AddToDataBase(Person person)
            {
                var client = new MongoClient("mongodb://localhost");
                var database = client.GetDatabase("321gr2021brr");
                var collection = database.GetCollection<Person>("qqPerson");
                collection.InsertOne(person);
            }

            public static void UpdateFirst(Person person)
            {
                var client = new MongoClient("mongodb://localhost");
                var database = client.GetDatabase("321gr2021brr");
                var collection = database.GetCollection<Person>("qqPerson");
                collection.ReplaceOne(x => x.name == "Olegek", person);
            }
        }
    }
}
