using System;
using System.Collections.Generic;
using System.Linq;
using Bus_Ticket_mgmt.Data;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Services
{
    /// <summary>
    /// Service responsible for managing fleet assets (buses), travel routes, and operational schedules.
    /// </summary>
    public static class FleetService
    {
        // ------------------ BUS OPERATIONS ------------------

        public static List<Bus> GetAllBuses() => BusStore.GetAll();

        public static Bus? GetBusById(string id) => BusStore.GetById(id);

        public static bool RegisterBus(Bus bus, out string error)
        {
            if (bus == null)
            {
                error = "Bus object cannot be null.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(bus.PlateNumber))
            {
                error = "Plate number is required.";
                return false;
            }

            if (!BusStore.IsPlateUnique(bus.PlateNumber, bus.BusId))
            {
                error = $"Plate number '{bus.PlateNumber}' is already registered in the system.";
                return false;
            }

            BusStore.Add(bus);
            error = string.Empty;
            return true;
        }

        public static bool UpdateBus(Bus bus, out string error)
        {
            if (bus == null)
            {
                error = "Bus object cannot be null.";
                return false;
            }

            if (!BusStore.IsPlateUnique(bus.PlateNumber, bus.BusId))
            {
                error = $"Plate number '{bus.PlateNumber}' conflicts with another registered bus.";
                return false;
            }

            bool updated = BusStore.Update(bus);
            if (!updated)
            {
                error = "Bus record not found.";
                return false;
            }

            error = string.Empty;
            return true;
        }

        public static bool RemoveBus(string id) => BusStore.Delete(id);

        public static bool SetBusStatus(string id, string status) => BusStore.SetStatus(id, status);

        public static (int Total, int Active, int Maintenance, int Inactive) GetFleetMetrics()
        {
            var buses = BusStore.GetAll();
            return (
                buses.Count,
                buses.Count(b => b.Status.Equals("Active", StringComparison.OrdinalIgnoreCase)),
                buses.Count(b => b.Status.Equals("Maintenance", StringComparison.OrdinalIgnoreCase)),
                buses.Count(b => b.Status.Equals("Inactive", StringComparison.OrdinalIgnoreCase))
            );
        }

        // ------------------ ROUTE OPERATIONS ------------------

        public static List<Route> GetAllRoutes() => RouteStore.GetAll();

        public static Route? GetRouteById(string id) => RouteStore.GetById(id);

        public static bool AddRoute(Route route, out string error)
        {
            if (route == null)
            {
                error = "Route object cannot be null.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(route.RouteName))
            {
                error = "Route name is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(route.Source) || string.IsNullOrWhiteSpace(route.Destination))
            {
                error = "Both source and destination locations are required.";
                return false;
            }

            RouteStore.Add(route);
            error = string.Empty;
            return true;
        }

        public static bool UpdateRoute(Route route, out string error)
        {
            if (route == null)
            {
                error = "Route object cannot be null.";
                return false;
            }

            bool updated = RouteStore.Update(route);
            if (!updated)
            {
                error = "Route not found.";
                return false;
            }

            error = string.Empty;
            return true;
        }

        public static bool RemoveRoute(string id) => RouteStore.Delete(id);

        public static List<Route> SearchRoutes(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return RouteStore.GetAll();

            string q = query.Trim().ToLowerInvariant();
            return RouteStore.GetAll()
                .Where(r => r.RouteName.ToLowerInvariant().Contains(q) ||
                            r.Source.ToLowerInvariant().Contains(q) ||
                            r.Destination.ToLowerInvariant().Contains(q) ||
                            r.IntermediateStops.ToLowerInvariant().Contains(q))
                .ToList();
        }

        public static (int Total, int Active, int Inactive) GetRouteMetrics()
        {
            var routes = RouteStore.GetAll();
            return (
                routes.Count,
                routes.Count(r => r.Status.Equals("Active", StringComparison.OrdinalIgnoreCase)),
                routes.Count(r => !r.Status.Equals("Active", StringComparison.OrdinalIgnoreCase))
            );
        }
    }
}

