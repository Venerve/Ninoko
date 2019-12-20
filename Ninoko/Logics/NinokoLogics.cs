using Newtonsoft.Json;
using Ninoko.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Controls;


namespace Ninoko
{
    public class NinokoLogics
    {
        public List<User> users;
        private static int _idCounter = 1;

        public NinokoLogics()
        { 
            LoadData();
        }

        public const string UsersFile = "../../../Data/Users.json";

        
        public void AvailableButtons(int level, Button button2, Button button3, Button button4, Button button5)
        {
            switch (level)
            {
                case 1:
                    button2.IsEnabled = false;
                    button3.IsEnabled = false;
                    button4.IsEnabled = false;
                    button5.IsEnabled = false;
                    break;
                case 2:
                    button3.IsEnabled = false;
                    button4.IsEnabled = false;
                    button5.IsEnabled = false;
                    break;
                case 3:
                    button4.IsEnabled = false;
                    button5.IsEnabled = false;
                    break;
                case 4:
                    button5.IsEnabled = false;
                    break;
                case 5:
                    break;
            }
            
           
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

        public void LevelUp(string username, string name)
        {
            if (name.StartsWith("En"))
            {
                var updated = users.FirstOrDefault(x => (x.Username == username));
                if (updated != null) updated.CurrentLevelEn += 1;
                Serialize(UsersFile, users);
            }
            else if (name.StartsWith("Ja"))
            {
                var updated = users.FirstOrDefault(x => (x.Username == username));
                if (updated != null) updated.CurrentLevelJa += 1;
                Serialize(UsersFile, users);
            }
            else if (name.StartsWith("Es"))
            {
                var updated = users.FirstOrDefault(x => (x.Username == username));
                if (updated != null) updated.CurrentLevelEs += 1;
                Serialize(UsersFile, users);
            }
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
            using var sr = new StreamReader(fileName);
            using var jsonReader = new JsonTextReader(sr);
            var serializer = new JsonSerializer();
            return serializer.Deserialize<T>(jsonReader);
        }

        public void Serialize<T>(string fileName, T data)
        {
            using var sw = new StreamWriter(fileName);
            using var jsonWriter = new JsonTextWriter(sw);
            var serializer = new JsonSerializer();
            serializer.Serialize(jsonWriter, data);
        }
    }
}
