namespace TheQuestionClass
{
    class Question
    {
        public string questionText;
        public string optionA;
        public string optionB;
        public string optionC;
        public string optionD;
        public char correctAnswerLetter;
        private static char defaultCorrectAnswerLetter = 'X';

        public Question()
        {
            //TO DO: Initialize questionText, optionA, optionB, optionC, optionD as null. Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.
            this.questionText = null;
            this.optionA = null;
            this.optionB = null;
            this.optionC = null;
            this.optionD = null;
            this.correctAnswerLetter = Question.defaultCorrectAnswerLetter;
        }

        public Question(string questionText)
        {
            //TO DO: Initialize questionText. Also, initialize optionA, optionB, optionC, optionD as null. Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.
            this.questionText = questionText;
            this.optionA = null;
            this.optionB = null;
            this.optionC = null;
            this.optionD = null;
            this.correctAnswerLetter = Question.defaultCorrectAnswerLetter;
        }

        public Question(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter = '\0')
        {
            //TO DO: Initialize questionText, optionA, optionB, optionC, optionD and correctAnswerText. Validate the value of correctAnswerLetter. It should either 'A', 'B', 'C' or 'D' only
            
            this.questionText = questionText;
            this.optionA = optionA;
            this.optionB = optionB;
            this.optionC = optionC;
            this.optionD = optionD;
            this.correctAnswerLetter = correctAnswerLetter == 'A' | correctAnswerLetter ==  'B' | correctAnswerLetter == 'C' | correctAnswerLetter == 'D' ? correctAnswerLetter : Question.defaultCorrectAnswerLetter;
        }

        public bool AreOptionsValid()
        {
            //TO DO: Return true, if at least two options are not null
            int validCount = 0;

            if (!(this.optionA is null))
                validCount++;
            if (!(this.optionB is null))
                validCount++;
            if (!(this.optionC is null))
                validCount++;
            if (!(this.optionD is null))
                validCount++;

            return validCount >= 2;
        }
    }

    class Program
    {
        static void Main()
        {
            //TO DO: Create an object of Question class and pass no arguments to the constructor
            Question question1 = new Question();

            //TO DO: Create an object of Question class and pass value for questionText only to the constructor.
            Question question2 = new Question("What is the capital of the USA ?");

            //TO DO: Create an object of Question class and pass values for questionText, optionA, optionB, optionC, optionD and correctAnswerLetter to the constructor.
            Question question3 = new Question("What is the capital of the USA ?", "London", "New York", "Washington, D.C.", "San Diego", 'C');

            //TO DO: Create an object of Question class and pass values for questionText, optionA, optionB, optionC, optionD only to the constructor.
            Question question4 = new Question("What is the capital of the USA ?", "London", "New York", "Washington, D.C.", "San Diego");
        }
    }
}
