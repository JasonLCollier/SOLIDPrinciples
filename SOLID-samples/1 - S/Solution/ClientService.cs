using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.samples.SRP.Solution
{
    public class ClientService
    {
        public (bool, string) AddClient(Client client)
        {
            if (!client.IsValid()) return (false, "Client data is not valid");

            var repo = new ClientRepository();
            repo.Add(client);

            EmailHelper.Send(client.Email, "Welcome", "Congrats!");

            return (true, string.Empty);
        }
    }
}
