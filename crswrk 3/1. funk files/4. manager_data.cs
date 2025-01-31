using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crswrk_3
{
    internal class manager_data
    {
    }

    public class manager : IManager
    {
        public string name { get; set; }
        public int password { get; set; }

        public manager() { }

        public manager(string na, int pass)
        {
            name = na;
            password = pass;
        }

        // Запись данных в JSON файл
        public void WriteManagerData(manager Manager, string filePath)
        {
            string updatedJson = JsonConvert.SerializeObject(Manager, Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);
        }

        // Чтение данных из json файла
        public manager ReadManagerData(string filePath)
        {
            manager Manager = new manager();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                Manager = JsonConvert.DeserializeObject<manager>(json) ?? new manager();
            }

            if (Manager == null)
            {
                Manager = new manager();
            }

            return Manager;
        }

    }

    public class manager_catalog : IManager
    {
        public string name { get; set; }
        public int password { get; set; }
        public List<manager> managers { get; set; }
        public manager_catalog()
        {
            managers = new List<manager>();
        }

        public bool FindManager(string name, int password, manager_catalog allManagers)
        {
            bool Flag = false;
            foreach (var manager in allManagers.managers)
            {
                if (manager.name == name && manager.password == password)
                {
                    Flag = true;
                    break;
                }
            }
            return Flag;
        }

        public int ManagerIndex(string name, int password, manager_catalog allManagers)
        {
            int index = 0;
            foreach (var manager in allManagers.managers)
            {
                if (manager.name == name && manager.password == password)
                {
                    break;
                }
                index++;
            }
            return index;
        }

        // Запись данных в JSON файл
        public void WriteManagerCatalogData(manager_catalog allManagers, string filePath)
        {
            string updatedJson = JsonConvert.SerializeObject(allManagers, Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);
        }

        // Чтение данных из json файла
        public manager_catalog ReadManagerCatalogData(string filePath)
        {
            manager_catalog managers = new manager_catalog();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                managers = JsonConvert.DeserializeObject<manager_catalog>(json) ?? new manager_catalog();
            }

            if (managers.managers == null)
            {
                managers.managers = new List<manager>();
            }

            return managers;
        }
    }
}
