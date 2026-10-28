using System;

namespace Bus_Ticket_mgmt.Models
{
    public class Route
    {
        public string RouteId { get; set; } = string.Empty;
        public string RouteName { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public int DistanceKm { get; set; } = 0;
        public string EstimatedTime { get; set; } = string.Empty;
        public decimal BaseFare { get; set; } = 0.0m;
        public string IntermediateStops { get; set; } = string.Empty;
        public string Status { get; set; } = "Active";
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string FullRouteDisplay => $"{Source} ➔ {Destination}";

        public Route() { }

        public Route(string routeId, string routeName, string source, string destination, int distanceKm, string estimatedTime, decimal baseFare, string intermediateStops, string status = "Active", string description = "")
        {
            RouteId = routeId;
            RouteName = routeName;
            Source = source;
            Destination = destination;
            DistanceKm = distanceKm;
            EstimatedTime = estimatedTime;
            BaseFare = baseFare;
            IntermediateStops = intermediateStops;
            Status = status;
            Description = description;
            CreatedDate = DateTime.Now;
        }
    }
}
