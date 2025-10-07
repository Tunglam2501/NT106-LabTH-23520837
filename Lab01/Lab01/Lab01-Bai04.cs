using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab01 // Đã thay đổi namespace thành Lab01
{
    // Đổi tên class Form thành Lab01_Bai04
    public partial class Lab01_Bai04 : Form
    {
        // Định nghĩa các loại vé và hệ số giá
        public enum TicketType
        {
            VeVot,    // 1/4 giá chuẩn
            VeThuong, // 1 giá chuẩn
            VeVIP     // 2 giá chuẩn
        }

        // Thông tin chi tiết về một chỗ ngồi
        public class Seat
        {
            public string SeatNumber { get; set; }
            public TicketType Type { get; set; }
            public bool IsSold { get; set; }
            public string RoomNumber { get; set; } // Phòng chiếu mà chỗ ngồi thuộc về

            public override string ToString()
            {
                // Hiển thị thông tin ghế và loại vé, ví dụ: "A1 (Vé Vớt)"
                return $"{SeatNumber} ({Type})";
            }
        }

        // Thông tin về phim
        public class Movie
        {
            public string Name { get; set; }
            public decimal StandardPrice { get; set; }
            public List<string> AvailableRooms { get; set; } // Danh sách các phòng chiếu có phim này

            public override string ToString()
            {
                return Name;
            }
        }

        // Dữ liệu rạp phim
        private Dictionary<string, Movie> movies; // Key: Tên phim, Value: Đối tượng Movie
        private Dictionary<string, Dictionary<string, Seat>> cinemaRooms; // Key: Số phòng chiếu, Value: Dictionary<Số ghế, Đối tượng Seat>

        // Constructor của Form - Đã đổi tên
        public Lab01_Bai04()
        {
            InitializeComponent();
            InitializeCinemaData();
            LoadMovieDataToUI();
        }

        private void InitializeCinemaData()
        {
            movies = new Dictionary<string, Movie>();
            cinemaRooms = new Dictionary<string, Dictionary<string, Seat>>();

            // 1. Khởi tạo dữ liệu phim
            movies.Add("Đào, phở và piano", new Movie { Name = "Đào, phở và piano", StandardPrice = 45000m, AvailableRooms = new List<string> { "1", "2", "3" } });
            movies.Add("Mai", new Movie { Name = "Mai", StandardPrice = 100000m, AvailableRooms = new List<string> { "2", "3" } });
            movies.Add("Gặp lại chị bầu", new Movie { Name = "Gặp lại chị bầu", StandardPrice = 70000m, AvailableRooms = new List<string> { "1" } });
            movies.Add("Tarot", new Movie { Name = "Tarot", StandardPrice = 90000m, AvailableRooms = new List<string> { "3" } });

            // 2. Khởi tạo dữ liệu phòng chiếu và ghế ngồi
            string[] seatRows = { "A", "B", "C" };
            string[] seatNumbers = { "1", "2", "3", "4", "5" };

            // Khởi tạo 3 phòng chiếu
            for (int i = 1; i <= 3; i++)
            {
                string roomNumber = i.ToString();
                cinemaRooms.Add(roomNumber, new Dictionary<string, Seat>());

                foreach (string row in seatRows)
                {
                    foreach (string num in seatNumbers)
                    {
                        string seatId = row + num;
                        TicketType type;

                        // Xác định loại vé cho từng ghế
                        if (new[] { "A1", "A5", "C1", "C5" }.Contains(seatId))
                        {
                            type = TicketType.VeVot;
                        }
                        else if (new[] { "A2", "A3", "A4", "C2", "C3", "C4" }.Contains(seatId))
                        {
                            type = TicketType.VeThuong;
                        }
                        else if (new[] { "B2", "B3", "B4" }.Contains(seatId))
                        {
                            type = TicketType.VeVIP;
                        }
                        else // B1, B5 không được nhắc đến trong yêu cầu, coi là không bán hoặc loại khác
                        {
                            continue; // Bỏ qua các ghế không được định nghĩa loại vé
                        }

                        cinemaRooms[roomNumber].Add(seatId, new Seat
                        {
                            SeatNumber = seatId,
                            Type = type,
                            IsSold = false,
                            RoomNumber = roomNumber
                        });
                    }
                }
            }
        }

        private void LoadMovieDataToUI()
        {
            // Thêm các phim vào ComboBox
            // Đảm bảo ComboBox của bạn có tên là cmbMovies trong Designer
            cmbMovies.DataSource = new BindingSource(movies.Values, null);
            cmbMovies.DisplayMember = "Name"; // Hiển thị tên phim
            cmbMovies.ValueMember = "Name";   // Lấy tên phim làm giá trị
        }

        // Sự kiện khi chọn phim thay đổi
        private void cmbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMovies.SelectedItem is Movie selectedMovie)
            {
                // Cập nhật ComboBox phòng chiếu dựa trên phim đã chọn
                // Đảm bảo ComboBox của bạn có tên là cmbRooms trong Designer
                cmbRooms.DataSource = selectedMovie.AvailableRooms;
                cmbRooms.SelectedIndex = -1; // Đặt lại để không có phòng nào được chọn mặc định
                // Đảm bảo CheckedListBox của bạn có tên là checkedListBoxSeats trong Designer
                checkedListBoxSeats.Items.Clear(); // Xóa danh sách ghế cũ
            }
        }

        // Sự kiện khi chọn phòng chiếu thay đổi
        private void cmbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRooms.SelectedItem is string selectedRoom)
            {
                checkedListBoxSeats.Items.Clear();
                if (cinemaRooms.ContainsKey(selectedRoom))
                {
                    // Sắp xếp ghế theo số ghế để hiển thị đẹp hơn
                    foreach (var seat in cinemaRooms[selectedRoom].Values.OrderBy(s => s.SeatNumber))
                    {
                        // Chỉ hiển thị ghế chưa bán
                        if (!seat.IsSold)
                        {
                            checkedListBoxSeats.Items.Add(seat);
                        }
                    }
                }
            }
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            // Đảm bảo TextBox nhập tên có tên là txtCustomerName trong Designer
            string customerName = txtCustomerName.Text.Trim();
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbMovies.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbRooms.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkedListBoxSeats.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkedListBoxSeats.CheckedItems.Count > 2)
            {
                MessageBox.Show("Bạn không thể chọn nhiều hơn 2 vé.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Movie selectedMovie = (Movie)cmbMovies.SelectedItem;
            string selectedRoom = cmbRooms.SelectedItem.ToString();
            List<Seat> selectedSeats = new List<Seat>();

            // Lấy các ghế đã chọn
            foreach (var item in checkedListBoxSeats.CheckedItems)
            {
                if (item is Seat seat)
                {
                    selectedSeats.Add(seat);
                }
            }

            // Kiểm tra xem có chọn ghế ở 2 phòng chiếu khác nhau không (yêu cầu không cho phép)
            // Logic này đã được đảm bảo một phần vì CheckedListBox chỉ hiển thị ghế của 1 phòng.
            // Nhưng nếu có một cách nào đó để chọn ghế từ nhiều phòng (ví dụ: giao diện phức tạp hơn),
            // thì kiểm tra này sẽ cần thiết. Với yêu cầu hiện tại, nó không thực sự cần.
            /*
            if (selectedSeats.Any(s => s.RoomNumber != selectedRoom))
            {
                MessageBox.Show("Không thể chọn vé ở 2 phòng chiếu khác nhau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            */

            decimal totalAmount = 0;
            string ticketInfo = "";

            foreach (var seat in selectedSeats)
            {
                if (seat.IsSold) // Kiểm tra lại lần nữa phòng trường hợp có lỗi đồng bộ (không nên xảy ra với CheckedListBox)
                {
                    MessageBox.Show($"Ghế {seat.SeatNumber} đã được bán. Vui lòng chọn ghế khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal ticketPrice = selectedMovie.StandardPrice;

                // Tính giá vé dựa trên loại vé
                switch (seat.Type)
                {
                    case TicketType.VeVot:
                        ticketPrice *= 0.25m; // 1/4
                        break;
                    case TicketType.VeThuong:
                        // Giữ nguyên giá chuẩn
                        break;
                    case TicketType.VeVIP:
                        ticketPrice *= 2m;
                        break;
                }
                totalAmount += ticketPrice;
                ticketInfo += $" - Ghế: {seat.SeatNumber} ({seat.Type}), Giá: {ticketPrice:N0}đ\n";
            }

            // Xác nhận mua vé
            DialogResult result = MessageBox.Show($"Xác nhận mua {selectedSeats.Count} vé cho phim '{selectedMovie.Name}' tại phòng '{selectedRoom}' với tổng số tiền {totalAmount:N0}đ?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Cập nhật trạng thái ghế đã bán
                foreach (var seat in selectedSeats)
                {
                    cinemaRooms[selectedRoom][seat.SeatNumber].IsSold = true;
                }

                // Cập nhật lại danh sách ghế trên CheckedListBox
                // Kích hoạt lại sự kiện để refresh ghế đã bán không còn hiển thị
                cmbRooms_SelectedIndexChanged(this, EventArgs.Empty);

                // Hiển thị thông tin khách hàng và vé đã mua
                // Đảm bảo RichTextBox của bạn có tên là rtbReceipt trong Designer
                string receipt = $"--- Hóa đơn mua vé ---\n";
                receipt += $"Họ và tên khách hàng: {customerName}\n";
                receipt += $"Phim: {selectedMovie.Name}\n";
                receipt += $"Phòng chiếu: {selectedRoom}\n";
                receipt += $"Vé đã chọn:\n{ticketInfo}";
                receipt += $"Tổng số tiền thanh toán: {totalAmount:N0}đ\n";
                receipt += $"------------------------\n";

                rtbReceipt.AppendText(receipt);
                rtbReceipt.ScrollToCaret(); // Cuộn xuống cuối để hiển thị hóa đơn mới nhất

                MessageBox.Show("Mua vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}