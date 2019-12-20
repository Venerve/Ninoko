﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Ninoko.Models;


namespace Ninoko
{
    public class NinokoLogics
    {
        public List<User> users;
        private static int _idCounter = 1;
        private readonly Repository _repository;

        public NinokoLogics()
        { 
            LoadData(); 
        }

        public const string UsersFile = "Data/Users.json";

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

        public void Registration(string login,string password)
        {
            _idCounter++;
            users.Add(new Models.User
            {
                Id = _idCounter,
                Username = login,
                Password = password,
                CurrentLevelEn = 1,
                CurrentLevelJa = 1,
                CurrentLevelEs = 1
            }); 
            Serialize(UsersFile, users);
        }

        public (int, int, int) GetLevel(string name)
        {
            foreach (User item in users)
            {
                if (item.Username == name)
                {
                    return (item.CurrentLevelEn, item.CurrentLevelJa, item.CurrentLevelEs);
                }
            }
            return (0, 0, 0);
        }

              
        public void LoadData()
        {
            users = Deserialize<List<User>>(UsersFile);
        }

        public void AddUser(User newUser)
        {
            users.Add(newUser);
            Serialize(UsersFile, users);
        }

        public T Deserialize<T>(string fileName)
        {
            using (var sr = new StreamReader(fileName))
            {
                using (var jsonReader = new JsonTextReader(sr))
                {
                    var serializer = new JsonSerializer();
                    return serializer.Deserialize<T>(jsonReader);
                }
            }
        }

        public void Serialize<T>(string fileName, T data)
        {
            using (var sw = new StreamWriter(fileName))
            {
                using (var jsonWriter = new JsonTextWriter(sw))
                {
                    var serializer = new JsonSerializer();
                    serializer.Serialize(jsonWriter, data);
                }
            }
        }
    }
}
