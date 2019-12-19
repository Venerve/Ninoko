using Ninoko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ninoko
{
    class Repository
    {
        public IList<Answer> Answers { get; set; }
        public IList<Question> Questions { get; set; }
        public IReadOnlyCollection<int> Tasks { get; set; }

        public Repository()
        {
            Tasks = Enumerable.Range(1, 15)
                .ToList();

            Questions = new List<Question>()
            {
                new Question()
                {
                    Name = "En1",
                    QuestionItself = "How do you _____ your free time?"
                },
                new Question()
                {
                    Name = "En2",
                    QuestionItself = "What has braches, roots and leaves and doesn't move?"
                }

            };

            Answers = new List<Answer>()
            {
                new Answer()
                {
                    Name = "En1",
                    Answer1 = "do",
                    Answer2 = "like",
                    Answer3 = "spend",
                    Answer4 = "think about"
                },
                new Answer()
                {
                    Name = "En2",
                    Answer1 = "tree",
                    Answer2 = "flower",
                    Answer3 = "grass",
                    Answer4 = "Groot"
                }
            };
        }
    }
}

