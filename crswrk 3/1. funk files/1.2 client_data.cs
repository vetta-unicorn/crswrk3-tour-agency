using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crswrk_3;
using Newtonsoft.Json;

namespace crswrk_3
{
    internal class crswrk_3
    {
    }

    [Serializable]
    public class ClientData : IClient
    {
        public string name { get; set; }
        public DateOnly birth_date { get; set; }
        public int pass_s { get; set; }
        public int pass_n { get; set; }
        public DateOnly pass_date { get; set; }
        public string pass_given { get; set; }
        public List<private_data> Clients { get; set; }

        public ClientData()
        {
            Clients = new List<private_data>();
        }


        // запись данных в json файл
        public void AddClientData(private_data newClient, string filePath)
        {
            // Чтение существующих данных из JSON файла
            ClientData allClients = ReadClientData(filePath);

            // Добавление нового клиента
            allClients.Clients.Add(newClient);

            WriteClientData(allClients, filePath);
        }

        // Запись данных в JSON файл
        public void WriteClientData(ClientData allClients, string filePath)
        {
            string updatedJson = JsonConvert.SerializeObject(allClients, Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);
        }

        // Чтение данных из json файла
        public ClientData ReadClientData(string filePath)
        {
            ClientData clientList = new ClientData();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                clientList = JsonConvert.DeserializeObject<ClientData>(json) ?? new ClientData();
            }

            if (clientList.Clients == null)
            {
                clientList.Clients = new List<private_data>();
            }


            return clientList;
        }

        // ищем нужного клиента, есть ли он в списке в принципе
        public bool FindClient(string name, int password, ClientData allClients)
        {
            bool Flag = false;
            foreach (var client in allClients.Clients)
            {
                if (client.name == name && client.pass_n == password)
                {
                    Flag = true;
                    break;
                }
            }
            return Flag;
        }

        // ищем индекс нужного клиента
        public int ClientIndex(string name, int password, ClientData allClients)
        {
            int index = 0;
            foreach (var client in allClients.Clients)
            {
                if (client.name == name && client.pass_n == password)
                {
                    break;
                }
                index++;
            }
            return index;
        }

        // выводим информацию о всех клиентах, выбравших определенный тур
        public string ShowClientTour(ClientData allClients, string t_name)
        {
            string st = "";
            // перебираем всех клиентов
            foreach(var client in allClients.Clients)
            {
                if(client.FindTourClient(client, t_name))
                {
                    st += client.CLientStringWithPayed(client, t_name);
                }
            }

            if (st == "")
            {
                st = "No client has chosen this tour";
            }

            return st;
        }

        public string ClientDataString(ClientData allClients)
        {
            string st = "";

            foreach (var client in allClients.Clients)
            {
                if (client != null)
                {
                    st += client.ShortClientString(client) + "\n";
                }
            }

            if (st == "")
            {
                st = "No client was found!\n";
            }

            return st;
        }
    }
}
