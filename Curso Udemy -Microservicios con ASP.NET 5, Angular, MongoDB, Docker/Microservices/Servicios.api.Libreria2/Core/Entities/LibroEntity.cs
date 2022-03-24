using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Servicios.api.Libreria2.Core.Entities
{
    [BsonCollection("Libro")]
    public class LibroEntity :Document
    {
        [BsonElement("titulo")]
        public string Titulo { get; set; }

        [BsonElement("descripcion")]
        public string Descripcion { get; set; }

        [BsonElement("precion")]
        public int Precio { get; set; }

        [BsonElement("fechaPublicacion")]
        public DateTime? FechaPublicacion { get; set; }

        [BsonElement("autor")]
        public AutorEntity Autor { get; set; }
    }
}
