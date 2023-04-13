using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Formula1.Entities
{
    [BsonIgnoreExtraElements]
    internal class Driver
    {
        // O processo abaixo denomina-se serialização. Cada elemento recebido como string do nosso documento será atribuido nestas propriedades

        [BsonId]// Data notation, refere-se a um objeto unico da nossa base de dados dizendo dentro da nossa aplicação, que vai trabalhar com aquele tipo de dados
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Driver")]
        public string? DriverName { get; set; }

        [BsonElement("Abbreviation")]
        public string? Abbreviation { get; set; }

        [BsonElement("No")]
        [BsonRepresentation(BsonType.Int32)]
        public int Number { get; set; }

        [BsonElement("Team")]
        public string? Team { get; set; }

        [BsonElement("Coutry")]
        public string? Country { get; set; }

        [BsonElement("Date of Birth")]
        public string? BirthDate { get; set; }

        public Driver(string? driverName, string? abbreviation, int number,
            string? team, string? country, string? birthDate)
        {
            DriverName = driverName;
            Abbreviation = abbreviation;
            Number = number;
            Team = team;
            Country = country;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"Nome: {DriverName}\n" +
                   $"Abreviação: {Abbreviation}\n" +
                   $"Numero do carro: {Number}\n" +
                   $"Equipe: {Team}\n" +
                   $"País de Origem: {Country}\n" +
                   $"Data de Nascimento: {BirthDate}\n\n"; 
        }
    }
}
