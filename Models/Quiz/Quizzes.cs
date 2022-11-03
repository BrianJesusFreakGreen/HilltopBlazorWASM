using System;

namespace HilltopBlazorWASM.Models.Quiz {
    public class Quizzes {

        public Data[] data { get; set; }

        public class Data {
            public int id { get; set; }
            public Attributes? Attributes { get; set; }

        }
        public class Attributes {
            public string? Title { get; set; }
            public Question[] Question { get; set; }
        }
        public class Question {
            public int id { get; set; }
            public string? QuestionText { get; set; }
            public PossibleAnswer[] PossibleAnswer { get; set; }

        }
        public class PossibleAnswer {
            public int Id { get; set; }
            public string? AnswerText { get; set; }
            public bool Correct { get; set; }
        }
    }
    

   
}
