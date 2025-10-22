using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_Bai05 : Form
    {
        string inputFilePath = @"..\..\..\I_O_File\input5.txt";
        string outputFilePath = @"..\..\..\I_O_File\output5.txt";

        // Định nghĩa các loại vé
        public enum TicketType
        {
            VeVot,    // 1/4 giá chuẩn
            VeThuong, // 1 giá chuẩn
            VeVIP     // 2 giá chuẩn
        }

        // Thông tin ghế
        public class Seat
        {
            public string SeatNumber { get; set; }
            public TicketType Type { get; set; }
            public bool IsSold { get; set; }
            public string RoomNumber { get; set; }

            public override string ToString()
            {
                return $"{SeatNumber} ({Type})";
            }
        }

        // Thông tin phim
        public class Movie
        {
            public string Name { get; set; }
            public decimal StandardPrice { get; set; }
            public List<string> AvailableRooms { get; set; }

            // Thống kê
            public int TicketsSold { get; set; }
            public int TicketsRemaining { get; set; }
            public decimal Revenue { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        // Dữ liệu
        private Dictionary<string, Movie> movies;
        private Dictionary<string, Dictionary<string, Seat>> cinemaRooms;
        private List<string> transactionHistory; // Lưu lịch sử giao dịch

        public Lab02_Bai05()
        {
            InitializeComponent();
            transactionHistory = new List<string>();
            InitializeCinemaData();
            LoadMovieDataToUI();
            LoadSoldSeatsFromFileSilently();
        }

        private void InitializeCinemaData()
        {
            movies = new Dictionary<string, Movie>();
            cinemaRooms = new Dictionary<string, Dictionary<string, Seat>>();

            // Khởi tạo dữ liệu phim
            movies.Add("Đào, phở và piano", new Movie
            {
                Name = "Đào, phở và piano",
                StandardPrice = 45000m,
                AvailableRooms = new List<string> { "1", "2", "3" },
                TicketsSold = 0,
                Revenue = 0
            });
            movies.Add("Mai", new Movie
            {
                Name = "Mai",
                StandardPrice = 100000m,
                AvailableRooms = new List<string> { "2", "3" },
                TicketsSold = 0,
                Revenue = 0
            });
            movies.Add("Gặp lại chị bầu", new Movie
            {
                Name = "Gặp lại chị bầu",
                StandardPrice = 70000m,
                AvailableRooms = new List<string> { "1" },
                TicketsSold = 0,
                Revenue = 0
            });
            movies.Add("Tarot", new Movie
            {
                Name = "Tarot",
                StandardPrice = 90000m,
                AvailableRooms = new List<string> { "3" },
                TicketsSold = 0,
                Revenue = 0
            });

            // Khởi tạo phòng chiếu và ghế
            string[] seatRows = { "A", "B", "C" };
            string[] seatNumbers = { "1", "2", "3", "4", "5" };

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
                        else
                        {
                            continue;
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

            // Tính tổng số vé còn lại cho mỗi phim
            CalculateRemainingTickets();
        }

        private void CalculateRemainingTickets()
        {
            foreach (var movie in movies.Values)
            {
                int totalSeats = 0;
                int soldSeats = 0;

                foreach (string room in movie.AvailableRooms)
                {
                    if (cinemaRooms.ContainsKey(room))
                    {
                        totalSeats += cinemaRooms[room].Count;
                        soldSeats += cinemaRooms[room].Values.Count(s => s.IsSold);
                    }
                }

                movie.TicketsRemaining = totalSeats - soldSeats;
            }
        }

        private void LoadMovieDataToUI()
        {
            cmbMovies.DataSource = new BindingSource(movies.Values, null);
            cmbMovies.DisplayMember = "Name";
            cmbMovies.ValueMember = "Name";
        }

        private void cmbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMovies.SelectedItem is Movie selectedMovie)
            {
                cmbRooms.DataSource = selectedMovie.AvailableRooms;
                cmbRooms.SelectedIndex = -1;
                checkedListBoxSeats.Items.Clear();
            }
        }

        private void cmbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRooms.SelectedItem is string selectedRoom)
            {
                checkedListBoxSeats.Items.Clear();
                if (cinemaRooms.ContainsKey(selectedRoom))
                {
                    foreach (var seat in cinemaRooms[selectedRoom].Values.OrderBy(s => s.SeatNumber))
                    {
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

            foreach (var item in checkedListBoxSeats.CheckedItems)
            {
                if (item is Seat seat)
                {
                    selectedSeats.Add(seat);
                }
            }

            decimal totalAmount = 0;
            string ticketInfo = "";

            foreach (var seat in selectedSeats)
            {
                if (seat.IsSold)
                {
                    MessageBox.Show($"Ghế {seat.SeatNumber} đã được bán. Vui lòng chọn ghế khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal ticketPrice = selectedMovie.StandardPrice;

                switch (seat.Type)
                {
                    case TicketType.VeVot:
                        ticketPrice *= 0.25m;
                        break;
                    case TicketType.VeThuong:
                        break;
                    case TicketType.VeVIP:
                        ticketPrice *= 2m;
                        break;
                }
                totalAmount += ticketPrice;
                ticketInfo += $" - Ghế: {seat.SeatNumber} ({seat.Type}), Giá: {ticketPrice:N0}đ\n";
            }

            DialogResult result = MessageBox.Show($"Xác nhận mua {selectedSeats.Count} vé cho phim '{selectedMovie.Name}' tại phòng '{selectedRoom}' với tổng số tiền {totalAmount:N0}đ?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Cập nhật trạng thái ghế
                foreach (var seat in selectedSeats)
                {
                    cinemaRooms[selectedRoom][seat.SeatNumber].IsSold = true;
                }

                // Cập nhật thống kê phim
                selectedMovie.TicketsSold += selectedSeats.Count;
                selectedMovie.Revenue += totalAmount;
                CalculateRemainingTickets();

                // Lưu giao dịch
                string transaction = $"{customerName}|{string.Join(",", selectedSeats.Select(s => s.SeatNumber))}|{selectedMovie.Name}|{selectedRoom}|{(int)totalAmount}";
                transactionHistory.Add(transaction);
                try
                {
                    // Nếu file chưa tồn tại thì tạo mới
                    if (!File.Exists(inputFilePath))
                    {
                        File.WriteAllText(inputFilePath, transaction + Environment.NewLine, Encoding.UTF8);
                    }
                    else
                    {
                        // Ghi thêm giao dịch vào cuối file
                        File.AppendAllText(inputFilePath, transaction + Environment.NewLine, Encoding.UTF8);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể ghi giao dịch vào file: {ex.Message}",
                        "Lỗi ghi file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Refresh UI
                cmbRooms_SelectedIndexChanged(this, EventArgs.Empty);

                // Hiển thị hóa đơn
                string receipt = $"--- Hóa đơn mua vé ---\n";
                receipt += $"Thời gian: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\n";
                receipt += $"Họ và tên khách hàng: {customerName}\n";
                receipt += $"Phim: {selectedMovie.Name}\n";
                receipt += $"Phòng chiếu: {selectedRoom}\n";
                receipt += $"Vé đã chọn:\n{ticketInfo}";
                receipt += $"Tổng số tiền thanh toán: {totalAmount:N0}đ\n";
                receipt += $"------------------------\n\n";

                rtbReceipt.AppendText(receipt);
                rtbReceipt.ScrollToCaret();

                MessageBox.Show("Mua vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // === CHỨC NĂNG ĐỌC/GHI FILE ===

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Debug: Hiển thị đường dẫn đầy đủ
                string fullPath = Path.GetFullPath(inputFilePath);


                string[] lines = File.ReadAllLines(inputFilePath, Encoding.UTF8);
                StringBuilder content = new StringBuilder();
                content.AppendLine("=== NỘI DUNG FILE INPUT5.TXT ===\n");
                content.AppendLine($"Đường dẫn: {Path.GetFullPath(inputFilePath)}\n");
                content.AppendLine($"Số dòng: {lines.Length}\n");
                content.AppendLine(new string('=', 60));
                content.AppendLine();

                int count = 0;
                int errorCount = 0;

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split('|');
                    // Định dạng: Họ tên|Vé đã chọn|Tên phim|Phòng chiếu|Số tiền
                    if (parts.Length >= 5)
                    {
                        count++;
                        string customerName = parts[0].Trim();
                        string seatsStr = parts[1].Trim();
                        string movieName = parts[2].Trim();
                        string room = parts[3].Trim();
                        string amount = parts[4].Trim();

                        string[] seats = seatsStr.Split(',');

                        content.AppendLine($"[{count}] Khách hàng: {customerName}");
                        content.AppendLine($"    Phim: {movieName}");
                        content.AppendLine($"    Phòng: {room}");
                        content.AppendLine($"    Ghế: {seatsStr}");

                        try
                        {
                            content.AppendLine($"    Số tiền: {decimal.Parse(amount):N0}đ");
                        }
                        catch
                        {
                            content.AppendLine($"    Số tiền: {amount} (Lỗi format)");
                            errorCount++;
                        }
                        content.AppendLine();

                        // Xử lý dữ liệu
                        if (movies.ContainsKey(movieName) && cinemaRooms.ContainsKey(room))
                        {
                            Movie movie = movies[movieName];
                            decimal calculatedAmount = 0;
                            int validSeats = 0;

                            foreach (string seatNum in seats)
                            {
                                string seatId = seatNum.Trim();
                                if (cinemaRooms[room].ContainsKey(seatId))
                                {
                                    Seat seat = cinemaRooms[room][seatId];
                                    if (!seat.IsSold)
                                    {
                                        seat.IsSold = true;
                                        validSeats++;

                                        decimal price = movie.StandardPrice;
                                        switch (seat.Type)
                                        {
                                            case TicketType.VeVot:
                                                price *= 0.25m;
                                                break;
                                            case TicketType.VeVIP:
                                                price *= 2m;
                                                break;
                                        }
                                        calculatedAmount += price;
                                    }
                                }
                            }

                            movie.TicketsSold += validSeats;
                            movie.Revenue += calculatedAmount;
                        }
                        else
                        {
                            content.AppendLine($"    ⚠️ Cảnh báo: Phim '{movieName}' hoặc phòng '{room}' không tồn tại!");
                            content.AppendLine();
                            errorCount++;
                        }
                    }
                    else
                    {
                        errorCount++;
                        content.AppendLine($"❌ Dòng lỗi (thiếu dữ liệu): {line}");
                        content.AppendLine();
                    }
                }

                content.AppendLine(new string('=', 60));
                content.AppendLine($"\n✅ Tổng số giao dịch hợp lệ: {count}");
                if (errorCount > 0)
                {
                    content.AppendLine($"⚠️ Số dòng lỗi: {errorCount}");
                }

                CalculateRemainingTickets();
                txtFileContent.Text = content.ToString();

                if (count > 0)
                {
                    MessageBox.Show($"Đọc file thành công!\n\nĐã xử lý: {count} giao dịch\nLỗi: {errorCount} dòng",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("File không có dữ liệu hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc file:\n\n{ex.Message}\n\nStackTrace:\n{ex.StackTrace}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Hiển thị ProgressBar
                progressBar.Visible = true;
                progressBar.Value = 0;
                progressBar.Maximum = 100;

                // Tạo nội dung file output
                StringBuilder output = new StringBuilder();
                output.AppendLine("=== THỐNG KÊ DOANH THU RẠP PHIM ===");
                output.AppendLine($"Thời gian xuất: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                output.AppendLine("=" + new string('=', 60));
                output.AppendLine();

                // Sắp xếp phim theo doanh thu giảm dần
                var sortedMovies = movies.Values.OrderByDescending(m => m.Revenue).ToList();

                progressBar.Value = 20;
                Application.DoEvents();

                output.AppendLine(string.Format("{0,-25} {1,-12} {2,-12} {3,-15} {4,-20} {5,-10}",
                    "TÊN PHIM", "VÉ BÁN", "VÉ TỒN", "TỶ LỆ BÁN (%)", "DOANH THU (VNĐ)", "XẾP HẠNG"));
                output.AppendLine(new string('-', 110));

                int rank = 1;
                int step = 60 / sortedMovies.Count;

                foreach (var movie in sortedMovies)
                {
                    int totalTickets = movie.TicketsSold + movie.TicketsRemaining;
                    double salesRate = totalTickets > 0 ? (double)movie.TicketsSold / totalTickets * 100 : 0;

                    output.AppendLine(string.Format("{0,-25} {1,-12} {2,-12} {3,-15:F2} {4,-20:N0} {5,-10}",
                        movie.Name,
                        movie.TicketsSold,
                        movie.TicketsRemaining,
                        salesRate,
                        movie.Revenue,
                        rank));

                    rank++;
                    progressBar.Value = Math.Min(20 + (rank * step), 80);
                    Application.DoEvents();
                    Thread.Sleep(200); // Giả lập xử lý
                }

                output.AppendLine(new string('-', 110));
                output.AppendLine();

                // Tổng kết
                int totalSold = movies.Values.Sum(m => m.TicketsSold);
                int totalRemaining = movies.Values.Sum(m => m.TicketsRemaining);
                decimal totalRevenue = movies.Values.Sum(m => m.Revenue);

                output.AppendLine("=== TỔNG KẾT ===");
                output.AppendLine($"Tổng số vé đã bán: {totalSold}");
                output.AppendLine($"Tổng số vé còn lại: {totalRemaining}");
                output.AppendLine($"Tổng doanh thu: {totalRevenue:N0} VNĐ");

                progressBar.Value = 90;
                Application.DoEvents();

                // Ghi file
                File.WriteAllText(outputFilePath, output.ToString(), Encoding.UTF8);

                progressBar.Value = 100;
                Thread.Sleep(300);

                // Hiển thị nội dung
                txtStatistics.Text = output.ToString();

                MessageBox.Show("Xuất file thống kê thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                progressBar.Visible = false;
            }
            catch (Exception ex)
            {
                progressBar.Visible = false;
                MessageBox.Show($"Lỗi khi ghi file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveTransactions_Click(object sender, EventArgs e)
        {
            try
            {
                if (transactionHistory.Count == 0)
                {
                    MessageBox.Show("Chưa có giao dịch nào để lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                File.WriteAllLines(inputFilePath, transactionHistory, Encoding.UTF8);
                MessageBox.Show($"Đã lưu {transactionHistory.Count} giao dịch vào file input5.txt", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadSoldSeatsFromFileSilently()
        {
            try
            {
                if (!File.Exists(inputFilePath))
                    return;

                string[] lines = File.ReadAllLines(inputFilePath, Encoding.UTF8);

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split('|');
                    if (parts.Length < 5) continue;

                    string customerName = parts[0].Trim();
                    string seatsStr = parts[1].Trim();
                    string movieName = parts[2].Trim();
                    string room = parts[3].Trim();

                    if (!movies.ContainsKey(movieName) || !cinemaRooms.ContainsKey(room))
                        continue;

                    Movie movie = movies[movieName];
                    string[] seats = seatsStr.Split(',');

                    foreach (string seatNum in seats)
                    {
                        string seatId = seatNum.Trim();
                        if (cinemaRooms[room].ContainsKey(seatId))
                        {
                            Seat seat = cinemaRooms[room][seatId];
                            if (!seat.IsSold)
                            {
                                seat.IsSold = true;
                                decimal price = movie.StandardPrice;
                                switch (seat.Type)
                                {
                                    case TicketType.VeVot:
                                        price *= 0.25m;
                                        break;
                                    case TicketType.VeVIP:
                                        price *= 2m;
                                        break;
                                }
                                movie.TicketsSold++;
                                movie.Revenue += price;
                            }
                        }
                    }
                }

                CalculateRemainingTickets();
            }
            catch
            {
                // Không hiện thông báo gì
            }
        }
    }
}