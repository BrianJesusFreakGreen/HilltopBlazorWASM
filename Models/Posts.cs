using System;

namespace HilltopBlazorWASM.Models
{
    public class Posts
    {
        public Data[] data { get; set; }

        public class Data
        {
            public int id { get; set; }
            public Attributes? attributes { get; set; }

        }
        public class Attributes
        {
            public string? Title { get; set; }
            public string? Content { get; set; }
            public string? Author { get; set; }
            public string? Slug { get; set; }

        }

        public string TrimString(string input)
        {
            String output;
            output = input;
            return output;
        }
    }    
}
