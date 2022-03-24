using System;

namespace Servicios.api.Libreria2.Core.Entities
{
    [AttributeUsage(AttributeTargets.Class,Inherited =false)]
    public class BsonCollectionAttribute:Attribute
    {
        public string CollectionName { get; }

        public BsonCollectionAttribute(string collectionName)
        {
            CollectionName = collectionName;
        }
    }
}
