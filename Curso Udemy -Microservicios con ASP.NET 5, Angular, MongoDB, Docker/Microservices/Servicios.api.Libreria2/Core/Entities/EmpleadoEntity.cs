using MongoDB.Bson.Serialization.Attributes;

namespace Servicios.api.Libreria2.Core.Entities
{
    [BsonCollection("Empleado")]
    public class EmpleadoEntity : Document
    {
        [BsonElement("nombre")]
        public string Nombre { get; set; }
    }
}
