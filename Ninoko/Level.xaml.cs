using Ninoko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public readonly NinokoLogics _logics;
        private readonly Repository _repository;
        private readonly Question _question;
        private readonly Answer _answers;
        private readonly int correctAnswer;
        public Level(string name)
        {
            if ((_repository.Questions.
                Any(value => value.Name.Contains(name))) &
               (_repository.Answers.
                Any(value => value.Name.Contains(name))))
            {
                question.Text = _question.QuestionItself;
                firstAnswer.Text = _answers.Answer1;
                secondAnswer.Text = _answers.Answer2;
                thirdAnswer.Text = _answers.Answer3;
                fourthAnswer.Text = _answers.Answer4;
            }
            correctAnswer =_logics.FindAnswer(name);

            
        }

        private void FirstAnswer(object sender, RoutedEventArgs e)
        {
            if (correctAnswer == 1) 
            {
                // Должно что-то что-то в окошке меняться, что-то появляться или цвет меняется НА ЗЕЛЕНЫЙ. Потом 3 секунды ожидание и должна быть следующая команда
                UsersPersonalWindow window = new UsersPersonalWindow();
                window.ShowDialog();
            }
            else
            {
                // Должно что-то что-то в окошке меняться, что-то появляться или цвет меняется НА КРАСНЫЙ. Потом 3 секунды ожидание и должна быть следующая команда
                UsersPersonalWindow window = new UsersPersonalWindow();
                window.ShowDialog();
            }
        }

        private void SecondAnswer(object sender, RoutedEventArgs e)
        {
            if (correctAnswer == 2)
            {
                
                UsersPersonalWindow window = new UsersPersonalWindow();
                window.ShowDialog();
            }
            else
            {
                
                UsersPersonalWindow window = new UsersPersonalWindow();
                window.ShowDialog();
            }
        }

        private void ThirdAnswer(object sender, RoutedEventArgs e)
        {
            if (correctAnswer == 3)
            {

                UsersPersonalWindow window = new UsersPersonalWindow();
                window.ShowDialog();
            }
            else
            {

                UsersPersonalWindow window = new UsersPersonalWindow();
                window.ShowDialog();
            }
        }

        private void FourthAnswer(object sender, RoutedEventArgs e)
        {
            if (correctAnswer == 4)
            {

                UsersPersonalWindow window = new UsersPersonalWindow();
                window.ShowDialog();
            }
            else
            {

                UsersPersonalWindow window = new UsersPersonalWindow();
                window.ShowDialog();
            }
        }
    }
}
