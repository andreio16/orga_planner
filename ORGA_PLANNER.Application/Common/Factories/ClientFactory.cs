using BusinessCore.Models;
using System.Collections.Generic;
using System.Windows.Documents;

namespace BusinessCore.Factories
{
    public static class ClientFactory
    {
        public static List<ClientDTO> GetClientList()
        {
            return new List<ClientDTO> {
                new ClientDTO {Id=0, FirstName="Danii", LastName="Balan", Email="danbalat@yahoo.com",  Note="", Phonenumber="0589693244" ,Title="Jr."},
                new ClientDTO {Id=1, FirstName="Maria", LastName="Anton", Email="mariaaa@gmail.com",   Note="", Phonenumber="0587563245", Title="Mrs.Doctor"},
                new ClientDTO {Id=2, FirstName="Alexa", LastName="Panta", Email="alexpanta@yahoo.com", Note="", Phonenumber="0589652366", Title="Mr.Engineer."},
            };
        }
    }
}
