using System;
using System.Collections.Generic;
using System.Linq;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Data
{
    public static class UserStore
    {
        private static readonly List<User> _users = new List<User>();

        static UserStore()
        {
            // Seed initial illustrative system accounts
            _users.Add(new User("USR001", "Abebe Kebede", "admin", "abebe@busbook.et", "+251 911 234 567", "Bole, Addis Ababa", "Admin@123", "Administrator", "Active", DateTime.Now.AddMonths(-6)));
            _users.Add(new User("USR002", "Hana Tesfaye", "hana.t", "hana@gmail.com", "+251 912 345 678", "Mexico, Addis Ababa", "Pass@123", "Passenger", "Active", DateTime.Now.AddMonths(-4)));
            _users.Add(new User("USR003", "Dawit Bekele", "dawit.b", "dawit@busbook.et", "+251 913 456 789", "Autobus Tera, Addis Ababa", "Officer@123", "Ticket Officer", "Inactive", DateTime.Now.AddMonths(-3)));
            _users.Add(new User("USR004", "Bekele Tadesse", "bekele.driver", "bekele@busbook.et", "+251 914 567 890", "Akaki, Addis Ababa", "Driver@123", "Driver", "Active", DateTime.Now.AddMonths(-2)));
            _users.Add(new User("USR005", "Almaz Wolde", "almaz.manager", "almaz@busbook.et", "+251 915 678 901", "Piazza, Addis Ababa", "Manager@123", "Bus Manager", "Active", DateTime.Now.AddMonths(-1)));
            _users.Add(new User("USR006", "Henok Girma", "henok.driver", "henok@busbook.et", "+251 916 789 012", "Merkato, Addis Ababa", "Driver@123", "Driver", "Active", DateTime.Now.AddDays(-15)));
            _users.Add(new User("USR007", "Selamawit Hailu", "selam.p", "selam@yahoo.com", "+251 917 890 123", "CMC, Addis Ababa", "Pass@123", "Passenger", "Active", DateTime.Now.AddDays(-5)));
        }

        public static List<User> GetAll()
        {
            return _users.ToList();
        }

        public static User? GetById(string id)
        {
            return _users.FirstOrDefault(u => u.UserId.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        public static void Add(User user)
        {
            if (string.IsNullOrEmpty(user.UserId))
            {
                user.UserId = GenerateNextId();
            }
            user.CreatedDate = DateTime.Now;
            _users.Add(user);
        }

        public static bool Update(User updatedUser)
        {
            var existing = GetById(updatedUser.UserId);
            if (existing != null)
            {
                existing.FullName = updatedUser.FullName;
                existing.Username = updatedUser.Username;
                existing.Email = updatedUser.Email;
                existing.Phone = updatedUser.Phone;
                existing.Address = updatedUser.Address;
                existing.Role = updatedUser.Role;
                existing.Status = updatedUser.Status;
                if (!string.IsNullOrEmpty(updatedUser.Password))
                {
                    existing.Password = updatedUser.Password;
                }
                return true;
            }
            return false;
        }

        public static bool Delete(string id)
        {
            var user = GetById(id);
            if (user != null)
            {
                _users.Remove(user);
                return true;
            }
            return false;
        }

        public static bool ToggleStatus(string id)
        {
            var user = GetById(id);
            if (user != null)
            {
                user.Status = (user.Status == "Active") ? "Inactive" : "Active";
                return true;
            }
            return false;
        }

        public static bool ResetPassword(string id, string newPassword)
        {
            var user = GetById(id);
            if (user != null)
            {
                user.Password = newPassword;
                return true;
            }
            return false;
        }

        public static bool IsUsernameUnique(string username, string? excludeUserId = null)
        {
            return !_users.Any(u => u.Username.Equals(username.Trim(), StringComparison.OrdinalIgnoreCase) &&
                                    (string.IsNullOrEmpty(excludeUserId) || !u.UserId.Equals(excludeUserId, StringComparison.OrdinalIgnoreCase)));
        }

        public static bool IsEmailUnique(string email, string? excludeUserId = null)
        {
            return !_users.Any(u => u.Email.Equals(email.Trim(), StringComparison.OrdinalIgnoreCase) &&
                                    (string.IsNullOrEmpty(excludeUserId) || !u.UserId.Equals(excludeUserId, StringComparison.OrdinalIgnoreCase)));
        }

        public static string GenerateNextId()
        {
            int maxId = 0;
            foreach (var u in _users)
            {
                if (u.UserId.StartsWith("USR") && int.TryParse(u.UserId.Substring(3), out int num))
                {
                    if (num > maxId) maxId = num;
                }
            }
            return $"USR{(maxId + 1):D3}";
        }
    }
}
