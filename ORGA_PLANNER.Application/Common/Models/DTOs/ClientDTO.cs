namespace BusinessCore.Models.DTOs
{
    public sealed class ClientDTO
    {
        public int Id { get; set; }
        public bool isActive { get; set; }

        public string Note { get; set; }

        public string Title { get; set; }

        public string Email { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Phonenumber { get; set; }
    }
}
