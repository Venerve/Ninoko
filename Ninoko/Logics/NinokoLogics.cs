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

        public NinokoLogics()
        { LoadData(); }

        public const string UsersFile = "data/users.json";

        public void Registration(string name, string password)
        {
            _idCounter++;
            users.Add(new Models.User
            {
                Id = _idCounter,
                Username = name,
                Password = password,
                CurrentLevel = 1
            }); 
            Serialize(UsersFile, users);
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
