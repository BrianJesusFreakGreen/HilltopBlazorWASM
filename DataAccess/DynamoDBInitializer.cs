using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using Amazon.Util;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HilltopBlazorWASM.DataAccess {
    public static class DynamoDBInitializer {
        
        public static AmazonDynamoDBClient client;
        public static async Task InitializeDynamoDB(string tableName = "") {
            Console.WriteLine("Trying to do crap");
            client = new AmazonDynamoDBClient(RegionEndpoint.USEast1);
            var response = client.ListTablesAsync();
            Console.WriteLine("Testing");
            Console.WriteLine(response);
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
         public string Data { get; set; }
    }
}
