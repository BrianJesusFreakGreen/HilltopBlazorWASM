using System;
using Amazon.DynamoDBv2.DataModel;

namespace HilltopBlazorWASM.Models
{
    [DynamoDBTable("PrayerRequest")]
    public class PrayerRequest{
        [DynamoDBHashKey]
        public string PrayerID { get; set; }
        public string PrayerOwner { get; set; }
        public string PrayerContent { get; set; }
    }    
}
