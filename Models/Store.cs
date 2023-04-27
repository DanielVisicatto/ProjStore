namespace Models
{
    public class Store
    {
        public readonly static string INSERT = "INSERT INTO [Store]" +
                                                "   (Description, Address)" +
                                                "   VALUES" +
                                                "   (@Description, @Address)";

        public readonly static string GETALL = "SELECT " +
                                                "Id" +
            "                                   ,Description" +
            "                                   ,Address" +
            "                                    FROM [Store]";

        public int Id { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this); // instalado a partir de Nuget para montar formato json;
        }
    }
}