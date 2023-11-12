using Microsoft.AspNetCore.Components;
using System;
namespace HilltopBlazorWASM.Models {
    public class AEvent{
        public Data data {  get; set; }
        public class Data {


            public string Name { get; set; }
            public string Description { get; set; }
            public string Location { get; set; }
            public string ContactName { get; set; }
            public int ContactNumber { get; set; }
            public string ContactEmail { get; set; }

            public DateTime Time { get; set; }
            public bool MoreDetails { get; set; }
        }
        
    
    }


}
