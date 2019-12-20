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
    /// 
    public partial class Level : Window
    {
        public readonly NinokoLogics _logics = new NinokoLogics();
        private readonly Repository _repository;
        private readonly int correctAnswer;
        private readonly string _username;
        private readonly string qname;
        public List<User> users;
        private readonly int _levelEn, _levelJa, _levelEs;
        public Level(Repository repository, string name, string username, int levelEn, int levelJa, int levelEs)
        {
            InitializeComponent();
            _levelEn = levelEn;
            _levelJa = levelJa;
            _levelEs = levelEs;
            _repository = repository;
            _username = username;

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
                var window = new UsersPersonalWindow(_username, _levelEn, _levelJa, _levelEs);
                window.ShowDialog();
                this.Close();
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
                var window = new UsersPersonalWindow(_username, _levelEn, _levelJa, _levelEs);
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
                var window = new UsersPersonalWindow(_username, _levelEn, _levelJa, _levelEs);
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
                var window = new UsersPersonalWindow(_username, _levelEn, _levelJa, _levelEs);
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
