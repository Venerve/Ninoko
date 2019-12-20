using Ninoko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ninoko
{
    /// <summary>
    /// Логика взаимодействия для Level.xaml
    /// </summary>
    public partial class Level : Window
    {
        public readonly NinokoLogics _logics = new NinokoLogics();
        private readonly Repository _repository;
        private readonly int correctAnswer;
        private readonly string _username;
        private readonly int EnLev, JaLev, EsLev;
        private readonly string qname;
        public List<User> users;
        public Level(Repository repository, string name, string username)
        {
            InitializeComponent();
            _repository = repository;
            _username = username;
            EnLev = _logics.GetLevel(username).Item1;
            JaLev = _logics.GetLevel(username).Item2;
            EsLev = _logics.GetLevel(username).Item3;

            foreach (Question _question in _repository.Questions)
            {
                foreach (Answer _answers in _repository.Answers)
                {
                    if ((_question.Name.Equals(name)) &
                            (_answers.Name.Equals(name)))
                    {
                        questionBox.Text = _question.QuestionItself;
                        firstAnswerBox.Content = _answers.Answer1;
                        secondAnswerBox.Content = _answers.Answer2;
                        thirdAnswerBox.Content = _answers.Answer3;
                        fourthAnswerBox.Content = _answers.Answer4;
                        qname = _question.Name;
                    }
                    correctAnswer = FindAnswer(name);
                }
            }
        }

        private void FirstAnswer(object sender, RoutedEventArgs e)
        {
            if (correctAnswer == 1) 
            {
                MessageBox.Show("Correct!", "Answer", MessageBoxButton.OK, MessageBoxImage.Information);
                _logics.LevelUp(_username, qname);
                var window = new UsersPersonalWindow(_username, EnLev, JaLev, EsLev);
                window.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Uncorrect! Try again", "Answer", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void SecondAnswer(object sender, RoutedEventArgs e)
        {
            if (correctAnswer == 2)
            {
                MessageBox.Show("Correct!", "Answer", MessageBoxButton.OK, MessageBoxImage.Information);
                _logics.LevelUp(_username, qname);
                var window = new UsersPersonalWindow(_username, EnLev, JaLev, EsLev);
                window.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Uncorrect! Try again", "Answer", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ThirdAnswer(object sender, RoutedEventArgs e)
        {
            if (correctAnswer == 3)
            {
                MessageBox.Show("Correct!", "Answer", MessageBoxButton.OK, MessageBoxImage.Information);
                _logics.LevelUp(_username, qname);
                var window = new UsersPersonalWindow(_username, EnLev, JaLev, EsLev);
                window.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Uncorrect! Try again", "Answer", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void FourthAnswer(object sender, RoutedEventArgs e)
        {
            if (correctAnswer == 4)
            {
                MessageBox.Show("Correct!", "Answer", MessageBoxButton.OK, MessageBoxImage.Information);
                _logics.LevelUp(_username, qname);
                var window = new UsersPersonalWindow(_username, EnLev, JaLev, EsLev);
                window.ShowDialog();
                Close();
                
            }
            else
            {
                MessageBox.Show("Uncorrect! Try again", "Answer", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        public void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public int FindAnswer(string name)
        {
            int answer;
            foreach (var item in _repository.Questions)
            {
                foreach (var item2 in _repository.Answers)
                {
                    if ((item.Name == item2.Name) & (name == item.Name))
                    {
                        answer = item2.Correct;
                        return answer;
                    }
                }
            }
            return 0;
        }
        
    }
}
