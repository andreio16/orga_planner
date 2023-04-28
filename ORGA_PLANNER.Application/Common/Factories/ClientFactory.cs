using BusinessCore.Models.DTOs;
using System.Collections.Generic;

namespace BusinessCore.Factories
{
    public static class ClientFactory
    {
        public static List<ClientDTO> GetClientList()
        {
            return new List<ClientDTO> {
                new ClientDTO {Id=0, FirstName="Danii", LastName="Balan", Note="", Phonenumber="0589693244", Email="danbalat@yahoo.com",  isActive=false, Title="Jr."},
                new ClientDTO {Id=1, FirstName="Maria", LastName="Anton", Note="", Phonenumber="0587563245", Email="mariaaa@gmail.com",   isActive=true,  Title="Mrs.Doc."},
                new ClientDTO {Id=2, FirstName="Alexa", LastName="Panta", Note="", Phonenumber="0589652366", Email="alexpanta@yahoo.com", isActive=true,  Title="Mr.Eng."},
            };                                                             
        }
    }
}
