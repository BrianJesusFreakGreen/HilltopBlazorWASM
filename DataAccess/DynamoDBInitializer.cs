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
        
        public static AmazonDynamoDBClient client;
        public static async Task InitializeDynamoDB(string tableName = "") {
            client = new AmazonDynamoDBClient( );
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
