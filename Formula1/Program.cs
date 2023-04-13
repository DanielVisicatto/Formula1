using Formula1.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

internal class Program
{
    private static void Main(string[] args)
    {
       
        //Connection Stringo com o nosso banco de dados MongoDB
        MongoClient mongo = new("mongodb://localhost:27017");

        #region[Testada a conexão]
        //trazendo a lista de bancos para verificar conexão OK.
        //var listabancos = mongo.ListDatabaseNames().ToList();

        //foreach (var database in listabancos)
        //{
        //    Console.WriteLine(database);
        //}
        #endregion


        var dataBases = mongo.GetDatabase("Formula1"); // vai guardar minha base de dados
        var collection = dataBases.GetCollection<BsonDocument>("Pilotos"); // vai buscar nossa coleção de pilotos.
        var document = collection.Find(new BsonDocument()).ToList(); // gera um obj e recebe o primeiro registro da collection e trazer para ele


        #region[CREATE]
        //Console.WriteLine("Nome:");
        //string n = Console.ReadLine();

        //Console.WriteLine("Abreviacao:");
        //string a = Console.ReadLine();

        //Console.WriteLine("Numero:");
        //int num = int.Parse(Console.ReadLine());

        //Console.WriteLine("Equipe:");
        //string eq = Console.ReadLine();

        //Console.WriteLine("Pais:");
        //string p = Console.ReadLine();

        //Console.WriteLine("Data de Nascimento:");
        //string bd = Console.ReadLine();


        //Driver driver = new(n, a, num, eq, p, bd);
        //Console.WriteLine(driver.ToString());

        ////gerando um novo documento usando os campos do objeto que existia
        //var dr = new BsonDocument
        //{
        //    {"Driver", driver.DriverName},
        //    {"Abbreviation", driver.Abbreviation},
        //    {"No", driver.Number},
        //    {"Team", driver.Team},
        //    {"Coutry", driver.Country},
        //    {"Date od Birth", driver.BirthDate},
        //};
        //Console.WriteLine(dr);
        //collection.InsertOne(dr);
        #endregion

        #region[UPDATE]
        //Console.WriteLine("Informe o nome do piloto:");
        //string pilotName = Console.ReadLine();

        //Console.WriteLine("Informe o novo número:");
        //int numb = int.Parse(Console.ReadLine());

        //var filter = Builders<BsonDocument>.Filter.Regex("Driver", pilotName);
        //var update = Builders<BsonDocument>.Update.Set("No", numb);        

        //collection.UpdateOne(filter,update);
        #endregion

        #region[DELETE]
        //Console.WriteLine("Informe o nome do piloto:");
        //string pilotName = Console.ReadLine();

        //var filter = Builders<BsonDocument>.Filter.Eq("Driver", pilotName); // Equals porque senão pode apagar um outro

        //collection.FindOneAndDelete(filter);
        #endregion


        #region[COMMENTED]
        //Console.WriteLine("Informe o nome do piloto: ");
        //var v = Console.ReadLine();

        //var filter = Builders<BsonDocument>.Filter.Regex("Driver", v); // a classe Builder cria a consulta no Mongo para nós {"Driver": "Sergio Perez"}

        //var pilot = collection.Find(filter).FirstOrDefault();
        // var driver = BsonSerializer.Deserialize<Driver>(collection.Find(filter).FirstOrDefault());

        //Console.WriteLine(driver.ToString());

        //Console.WriteLine(pilot.ToString());

        //Console.WriteLine("INforme o nome da equipe:");
        //var e = Console.ReadLine();

        //filter = Builders<BsonDocument>.Filter.Regex("Team", e);
        //var pilots = collection.Find(filter).ToList();

        //foreach (var driver in pilots)
        //{
        //    Console.WriteLine(driver);
        //}
        #endregion
    }

}