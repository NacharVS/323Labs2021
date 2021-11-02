using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Group323TOP
{
    class Unit
    {
        [BsonId]
        ObjectId _id;
        public string name;
        public int age;
        public int Group;
        [BsonIgnoreIfNull]
        List<Item> items = new List<Item>();


        public Unit(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Unit(string name, int age, int group) : this(name, age)
        {
            Group = group;
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public static void AddToDb(Unit unit)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("323GroupOloloPiyPiy");
            var collection = database.GetCollection<Unit>("Student");
            collection.InsertOne(unit);
        }

        public static void FindFromDatabase()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("323GroupOloloPiyPiy");
            var collection = database.GetCollection<Unit>("Student");
            var list = collection.Find(x => x.name == "Vasyan").FirstOrDefault();
            foreach(var pushka in list.items)
            {
                System.Console.WriteLine($" {pushka.itemName} {pushka.damage}");
            }
        }
    }
}
