using System;
using System.Collections.Generic;
using System.Linq;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Data
{
    public static class RouteStore
    {
        private static readonly List<Route> _routes = new List<Route>();

        static RouteStore()
        {
            // Seed realistic Ethiopian transport routes
            _routes.Add(new Route("RT001", "Addis - Bahir Dar Express", "Addis Ababa", "Bahir Dar", 565, "8 hrs 30 mins", 1150.0m, "Dejen, Debre Markos", "Active", "Northern highway primary passenger corridor."));
            _routes.Add(new Route("RT002", "Addis - Hawassa Highway", "Addis Ababa", "Hawassa", 275, "4 hrs 00 mins", 650.0m, "Bishoftu, Mojo, Batu", "Active", "Expressway route through Rift Valley."));
            _routes.Add(new Route("RT003", "Addis - Gondar Historical", "Addis Ababa", "Gondar", 725, "11 hrs 00 mins", 1450.0m, "Bahir Dar, Debre Tabor", "Active", "Extended northern route serving historical sites."));
            _routes.Add(new Route("RT004", "Addis - Dire Dawa Highway", "Addis Ababa", "Dire Dawa", 450, "7 hrs 30 mins", 950.0m, "Adama, Awash", "Active", "Eastern industrial and trade corridor."));
            _routes.Add(new Route("RT005", "Addis - Mekelle Route", "Addis Ababa", "Mekelle", 780, "12 hrs 30 mins", 1600.0m, "Dessie, Woldiya, Alamata", "Active", "North-eastern artery route."));
            _routes.Add(new Route("RT006", "Addis - Jimma Coffee Trail", "Addis Ababa", "Jimma", 350, "5 hrs 30 mins", 750.0m, "Welkite, Woliso", "Active", "South-western commercial route."));
            _routes.Add(new Route("RT007", "Addis - Dessie Highlands", "Addis Ababa", "Dessie", 400, "6 hrs 30 mins", 850.0m, "Debre Berhan, Shewa Robit", "Active", "Mountain corridor route with scenic terrain."));
            _routes.Add(new Route("RT008", "Addis - Arba Minch Lakes", "Addis Ababa", "Arba Minch", 450, "7 hrs 30 mins", 900.0m, "Shashemene, Wolaita Sodo", "Inactive", "Temporarily suspended due to seasonal road upgrade."));
        }

        public static List<Route> GetAll()
        {
            return _routes.ToList();
        }

        public static Route? GetById(string id)
        {
            return _routes.FirstOrDefault(r => r.RouteId.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        public static void Add(Route route)
        {
            if (string.IsNullOrEmpty(route.RouteId))
            {
                route.RouteId = GenerateNextId();
            }
            _routes.Add(route);
        }

        public static bool Update(Route updatedRoute)
        {
            var existing = GetById(updatedRoute.RouteId);
            if (existing != null)
            {
                existing.RouteName = updatedRoute.RouteName;
                existing.Source = updatedRoute.Source;
                existing.Destination = updatedRoute.Destination;
                existing.DistanceKm = updatedRoute.DistanceKm;
                existing.EstimatedTime = updatedRoute.EstimatedTime;
                existing.BaseFare = updatedRoute.BaseFare;
                existing.IntermediateStops = updatedRoute.IntermediateStops;
                existing.Status = updatedRoute.Status;
                existing.Description = updatedRoute.Description;
                return true;
            }
            return false;
        }

        public static bool Delete(string id)
        {
            var route = GetById(id);
            if (route != null)
            {
                _routes.Remove(route);
                return true;
            }
            return false;
        }

        public static bool SetStatus(string id, string newStatus)
        {
            var route = GetById(id);
            if (route != null)
            {
                route.Status = newStatus;
                return true;
            }
            return false;
        }

        public static bool ToggleStatus(string id)
        {
            var route = GetById(id);
            if (route != null)
            {
                route.Status = (route.Status == "Active") ? "Inactive" : "Active";
                return true;
            }
            return false;
        }

        public static bool IsRouteIdUnique(string id, string? excludeId = null)
        {
            string cleanId = id.Trim().ToUpper();
            return !_routes.Any(r => r.RouteId.Trim().ToUpper() == cleanId &&
                                     (string.IsNullOrEmpty(excludeId) || !r.RouteId.Equals(excludeId, StringComparison.OrdinalIgnoreCase)));
        }

        public static string GenerateNextId()
        {
            int maxId = 0;
            foreach (var r in _routes)
            {
                if (r.RouteId.StartsWith("RT") && int.TryParse(r.RouteId.Substring(2), out int num))
                {
                    if (num > maxId) maxId = num;
                }
            }
            return $"RT{(maxId + 1):D3}";
        }

        public static int GetTotalCount() => _routes.Count;
        public static int GetActiveCount() => _routes.Count(r => r.Status == "Active");
        public static int GetInactiveCount() => _routes.Count(r => r.Status == "Inactive");
        public static int GetTotalDistanceKm() => _routes.Sum(r => r.DistanceKm);
    }
}
