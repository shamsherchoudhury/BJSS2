using System.IO;
using Microsoft.Azure.Cosmos.Table;
using System.Collections.Generic;
using bjss_option1.Models;
using bjss_option1.Entities;
using System.Linq;
using AutoMapper

namespace bjss_option1.Services
{
    public class StorageManager
    {
        private CloudTableClient _cloudTableClient;

        public StorageManager()
        {
            using (StreamReader reader = File.OpenText(@$"./{Constants.ConfigurationFileName}"))
            {
                var content = reader.ReadToEnd();

                dynamic appsettings = Newtonsoft.Json.JsonConvert.DeserializeObject(content);

                var _connectionString = appsettings[Constants.ConfigurationStorageAccountEntry];

                _cloudTableClient = CloudStorageAccount.Parse(_connectionString).CreateCloudTableClient();
            }
        }

        public (bool, IEnumerable<Candidate>) GetCandidates()
        {
            var table = _cloudTableClient.GetTableReference("personal");
            var personal = table.CreateQuery<PersonalEntity>().Select(x => )


        }
    }
}
