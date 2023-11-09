using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HilltopBlazorWASM.DataAccess {
    public static class DynamoDBInitializer {
        private const string accessKey = "AKIAZJSTU5752NG5M2FU";
        private const string secretKey = "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";
        public static AmazonDynamoDBClient client;
        public static async Task InitializeDynamoDB(string tableName = "") {
            var credentials = new BasicAWSCredentials(accessKey, secretKey);
            client = new AmazonDynamoDBClient(credentials, RegionEndpoint.USEast1);
            DynamoDBContext context = new DynamoDBContext(client);
            Task<HilltopTest> testItem = context.LoadAsync<HilltopTest>("Brian");
            Console.WriteLine(testItem.Result);
            Console.WriteLine(testItem);
            Console.Write("Is This Thing On?");
        }
       
    }

    

    [DynamoDBTable("HilltopBlazorTest")]
    public class HilltopTest {
        [DynamoDBHashKey]
        public string Hilltop {  get; set; }
        [DynamoDBRangeKey] public string data { get; set; }
    }
}
