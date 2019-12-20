﻿using Ninoko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ninoko
{
    public class Repository
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
                },
                new Question()
                {
                    Name = "En3",
                    QuestionItself = " "
                },
                new Question()
                {
                    Name = "En4",
                    QuestionItself = " "
                },
                new Question()
                {
                    Name = "Ja1",
                    QuestionItself = "Write 'ri' in hiragana"
                },
                new Question()
                {
                    Name = "Ja2",
                    QuestionItself = "What is for I/me?"
                },
                new Question()
                {
                    Name = "Ja3",
                    QuestionItself = "Say hello!"
                },
                new Question()
                {
                    Name = "Ja4",
                    QuestionItself = "What means cat?"
                },
                new Question()
                {
                    Name = "Ja5",
                    QuestionItself = "あなたのお名前は____ですか。"
                },
                new Question()
                {
                    Name = "Es1",
                    QuestionItself = " "
                },
                new Question()
                {
                    Name = "Es2",
                    QuestionItself = " "
                },
                new Question()
                {
                    Name = "Es3",
                    QuestionItself = " "
                },
                new Question()
                {
                    Name = "Es4",
                    QuestionItself = " "
                },
                new Question()
                {
                    Name = "Es5",
                    QuestionItself = " "
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
                    Answer4 = "think about",
                    Correct = 3
                },
                new Answer()
                {
                    Name = "En2",
                    Answer1 = "tree",
                    Answer2 = "flower",
                    Answer3 = "grass",
                    Answer4 = "Groot",
                    Correct = 1
                },
                new Answer()
                {
                    Name = "En3",
                    Answer1 = " ",
                    Answer2 = " ",
                    Answer3 = " ",
                    Answer4 = " ",
                    Correct = 1
                },
                new Answer()
                {
                    Name = "En4",
                    Answer1 = " ",
                    Answer2 = " ",
                    Answer3 = " ",
                    Answer4 = " ",
                    Correct = 1
                },
                new Answer()
                {
                    Name = "Ja1",
                    Answer1 = "こ",
                    Answer2 = "り",
                    Answer3 = "み",
                    Answer4 = "ふ",
                    Correct = 2
                },
                new Answer()
                {
                    Name = "Ja2",
                    Answer1 = "人",
                    Answer2 = "本",
                    Answer3 = "水",
                    Answer4 = "私",
                    Correct = 4
                },
                new Answer()
                {
                    Name = "Ja3",
                    Answer1 = "ありがとう!",
                    Answer2 = "お早う!",
                    Answer3 = "さようなら!",
                    Answer4 = "こんにちは!",
                    Correct = 4
                },
                new Answer()
                {
                    Name = "Ja4",
                    Answer1 = "ねこ",
                    Answer2 = "いぬ",
                    Answer3 = "とり",
                    Answer4 = "まうす",
                    Correct = 1
                },
                new Answer()
                {
                    Name = "Ja5",
                    Answer1 = "で",
                    Answer2 = "何",
                    Answer3 = "人",
                    Answer4 = "私",
                    Correct = 2
                },
                new Answer()
                {
                    Name = "Es1",
                    Answer1 = " ",
                    Answer2 = " ",
                    Answer3 = " ",
                    Answer4 = " ",
                    Correct = 1
                },
                new Answer()
                {
                    Name = "Es2",
                    Answer1 = " ",
                    Answer2 = " ",
                    Answer3 = " ",
                    Answer4 = " ",
                    Correct = 1
                },
                new Answer()
                {
                    Name = "Es3",
                    Answer1 = " ",
                    Answer2 = " ",
                    Answer3 = " ",
                    Answer4 = " ",
                    Correct = 1
                },
                new Answer()
                {
                    Name = "Es4",
                    Answer1 = " ",
                    Answer2 = " ",
                    Answer3 = " ",
                    Answer4 = " ",
                    Correct = 1
                }
            };

        }
    }
}

