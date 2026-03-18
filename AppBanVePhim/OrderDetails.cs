using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanVePhim
{
        public class FoodItem
        {
            public string Name;
            public int Price;
            public int Quantity;
        }

        public class OrderDetail
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
            public int StarRating { get; set; } = 0;
            public string Review { get; set; } = "";
            public string Username { get; set; } = "";
        }
        public class UserAccount
        {
            public string FullName { get; set; }
            public string BirthDate { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string Gender { get; set; }
        }
        public class SeatRecord
        {
            public string MovieName { get; set; }
            public string Theater { get; set; }
            public string Date { get; set; }
            public string TimeFrame { get; set; }
            public List<string> BookedSeats { get; set; } = new List<string>();
        }
}
