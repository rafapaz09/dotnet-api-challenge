using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_api_challenge.Core.Domain
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int OrderNumber { get; set; }
        public int OrderDow { get; set; }
        public int OrderHourOfDay { get; set; }
        public double DaysSincePriorOrder { get; set; }
        public string OrderDetail { get; set; }
    }
}
