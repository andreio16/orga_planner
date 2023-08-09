using BusinessCore.Models.DTOs;

using OrgaPlanner.Database.Storage.Models;
using OrgaPlanner.Storage.Database;

using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessCore.Factories
{
    public class CoreFactory
    {
        public OrgaPlannerDbContext dbContext { get; set; }

        public CoreFactory()
        {
            dbContext = new OrgaPlannerDbContext();
        }

        public IEnumerable<ClientDTO> GetClients() 
        {
            var dbClients = dbContext.Clients.ToList();

            foreach (var client in dbClients)
                yield return new ClientDTO(client);
        }

        public void InsertDummyClients()
        {
            List<Client> clientList = new List<Client> {
                new Client {Id=0, FirstName="Danii", LastName="Balan", Note="", Phonenumber="0589693244", Email="danbalan@yahoo.com",  isActive=false, Title="Jr.", DateCreated=DateTime.Now},
                new Client {Id=1, FirstName="Maria", LastName="Anton", Note="", Phonenumber="0587563245", Email="mariaaa@gmail.com",   isActive=true,  Title="Mrs.Doc.", DateCreated=DateTime.Now},
                new Client {Id=2, FirstName="Alexa", LastName="Panta", Note="", Phonenumber="0589652366", Email="alexpanta@yahoo.com", isActive=true,  Title="Mr.Eng.", DateCreated=DateTime.Now},
                new Client {Id=3, FirstName="Cosmo", LastName="Zalan", Note="", Phonenumber="0589883244", Email="cosmoZala@yahoo.com",  isActive=false, Title="Jr.", DateCreated=DateTime.Now},
            };

            foreach (var client in clientList)
            {
                dbContext.Clients.Add(client);
                dbContext.SaveChanges();
            }
        }
    }
}
