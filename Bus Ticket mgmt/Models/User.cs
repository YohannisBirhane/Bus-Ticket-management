using System;

namespace Bus_Ticket_mgmt.Models
{
    public class User
    {
        public string UserId { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = "Passenger";
        public string Status { get; set; } = "Active";
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public User() { }

        public User(string id, string name, string username, string email, string phone, string address, string password, string role, string status, DateTime createdDate)
        {
            UserId = id;
            FullName = name;
            Username = username;
            Email = email;
            Phone = phone;
            Address = address;
            Password = password;
            Role = role;
            Status = status;
            CreatedDate = createdDate;
        }
    }
}
