﻿using System.ComponentModel.DataAnnotations;

namespace AIMSService.Model
{
    public class ClientDto
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public DateTime? Dob { get; set; }
        public string? Status { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
