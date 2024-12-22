using Microsoft.Extensions.Configuration;

namespace Framework.Helpers
{
    public class TestDataManager
    {
        private readonly string _BasePath = Directory.GetParent(@"../../../").FullName + Path.DirectorySeparatorChar + "TestData";

        public IConfigurationRoot GetTestData(string jsonFileName)
        {
            var fileName = jsonFileName + ".json";
            var filePath = Path.Combine(_BasePath, fileName);
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(filePath, false, true);
            return builder.Build();

        }
    }
}
