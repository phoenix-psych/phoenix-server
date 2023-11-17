using System.ComponentModel.DataAnnotations;

namespace AIMSService.Model
{
    public class ClientDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime Dob { get; set; }
        public string Status { get; set; }

    }
}
