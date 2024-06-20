using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoDevMaui.Models
{
    public class Order
    {
        public int Id { get; set; }
        public IEnumerable<CartItem> Items { get; set; } = Enumerable.Empty<CartItem>();
        public DateTime Date { get; set; } = DateTime.Now;
        public decimal TotalAmount => Items.Sum(i => i.Amount);

        public OrderStatus Status { get; set; }

        public Color Color => _orderStatusColorsMap[Status];

        private static readonly IReadOnlyDictionary<OrderStatus, Color> _orderStatusColorsMap =
            new Dictionary<OrderStatus, Color>
            {
                [OrderStatus.Placed] = Colors.Yellow,
                [OrderStatus.Confirmed] = Colors.Blue,
                [OrderStatus.Delivered] = Colors.Green,
                [OrderStatus.Cancelled] = Colors.Red,
            };

        public enum OrderStatus
        {
            Placed = 0,
            Confirmed = 1,
            Delivered = 2,
            Cancelled = 3,
        }

    }
}
