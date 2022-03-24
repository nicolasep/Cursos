using MongoDB.Bson.Serialization.Attributes;

namespace Servicios.api.Libreria2.Core.Entities
{
    [BsonCollection("Autor")]
    public class AutorEntity:Document
    {
        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("apellido")]
        public string Apellido { get; set; }

        [BsonElement("gradoAcademico")]
        public string GradoAcademico { get; set; }

    }
}
