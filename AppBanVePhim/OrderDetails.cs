using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanVePhim
{
    class FoodItem
    {
        public string Name;
        public int Price;
        public int Quantity;
    }

    class OrderDetail
    {
        public string Ticket { get; set; }     // Tên (Vé hoặc Bỏng)
        public string MovieName { get; set; }   // Số lượng
        public string Theater { get; set; }  // Đơn giá
        public string Date { get; set; }
        public string TimeFrame { get; set; }
        public int Seats { get; set; }
        public int PopcornPrices { get; set; }
        public int SeatPrices { get; set; }
        public int TotalPrice => Seats * SeatPrices + PopcornPrices; // Tự tính tổng
    }
}
