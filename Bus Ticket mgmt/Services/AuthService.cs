using System;
using System.Collections.Generic;

namespace Bus_Ticket_mgmt.Services
{
    public enum UserRole
    {
        Unknown,
        Administrator,
        Passenger,
        TicketOfficer,
        Driver,
        BusManager
    }

    public class AuthResult
    {
        public bool IsSuccess { get; set; }
        public UserRole Role { get; set; } = UserRole.Unknown;
        public string Email { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public string ErrorMessage { get; set; } = string.Empty;

        public static AuthResult Success(UserRole role, string email, string displayName)
        {
            return new AuthResult
            {
                IsSuccess = true,
                Role = role,
                Email = email,
                DisplayName = displayName
            };
        }

        public static AuthResult Failure(string message)
        {
            return new AuthResult
            {
                IsSuccess = false,
                ErrorMessage = message
            };
        }
    }

    /// <summary>
    /// Service responsible for authenticating users and enforcing role-based access.
    /// Supports the 5 core system roles with unified password validation.
    /// </summary>
    public static class AuthService
    {
        public const string UniversalPassword = "pass1234";

        public static AuthResult Authenticate(string emailOrUsername, string password)
        {
            if (string.IsNullOrWhiteSpace(emailOrUsername))
            {
                return AuthResult.Failure("Please enter your email address or username.");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                return AuthResult.Failure("Please enter your password.");
            }

            // Verify password
            if (password != UniversalPassword)
            {
                return AuthResult.Failure($"Invalid password!\n\nPlease use the universal system password: {UniversalPassword}");
            }

            string cleanEmail = emailOrUsername.Trim().ToLowerInvariant();

            // Match Role
            if (cleanEmail == "admin@gmail.com" || cleanEmail == "admin")
            {
                return AuthResult.Success(UserRole.Administrator, "admin@gmail.com", "System Administrator");
            }
            if (cleanEmail == "officer@gmail.com" || cleanEmail == "officer" || cleanEmail == "ticket@gmail.com")
            {
                return AuthResult.Success(UserRole.TicketOfficer, "officer@gmail.com", "Marta Tadesse (Ticket Officer)");
            }
            if (cleanEmail == "manager@gmail.com" || cleanEmail == "manager")
            {
                return AuthResult.Success(UserRole.BusManager, "manager@gmail.com", "Almaz Wolde (Bus Manager)");
            }
            if (cleanEmail == "passenger@gmail.com" || cleanEmail == "passenger")
            {
                return AuthResult.Failure("The Passenger portal has been removed from this system deployment.\nPlease log in as Administrator or Ticket Officer.");
            }
            if (cleanEmail == "driver@gmail.com" || cleanEmail == "driver")
            {
                return AuthResult.Failure("The Driver portal has been removed from this system deployment.\nPlease log in as Administrator or Ticket Officer.");
            }

            return AuthResult.Failure(
                "User account not found!\n\n" +
                "Please use one of the registered system accounts (Password: pass1234):\n\n" +
                "• admin@gmail.com       (Administrator Portal)\n" +
                "• officer@gmail.com     (Ticket Officer Portal)\n" +
                "• manager@gmail.com     (Bus Manager Portal)"
            );
        }

        public static IReadOnlyList<(string Role, string Email, string Description)> GetRegisteredAccounts()
        {
            return new List<(string Role, string Email, string Description)>
            {
                ("Administrator", "admin@gmail.com", "Full administrative control of users, fleet, routes, schedules, and fares"),
                ("Ticket Officer", "officer@gmail.com", "Issue walk-in tickets, verify boarding passes, cashier and manifests"),
                ("Bus Manager", "manager@gmail.com", "Monitor fleet operations, assign buses, and track departures")
            };
        }
    }
}

