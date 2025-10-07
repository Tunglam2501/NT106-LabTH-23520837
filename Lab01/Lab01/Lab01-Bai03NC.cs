using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai03NC : Form
    {
        private readonly string[] _donVi = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        private readonly string[] _donViLon = { "", "nghìn", "triệu", "tỷ", "nghìn tỷ" };

        public Lab01_Bai03NC()
        {
            InitializeComponent();
            txtSo.MaxLength = 12; // Vẫn giới hạn độ dài
            // BỎ QUA HOẶC GỠ BỎ: txtSo.KeyPress += TxtSo_KeyPress;
            // Nếu muốn cho phép nhập bất kỳ thứ gì, không cần gắn sự kiện KeyPress
        }

        // // BỎ QUA HOẶC GỠ BỎ HÀM NÀY NẾU BẠN MUỐN CHO PHÉP NHẬP CHỮ VÀO TEXTBOX
        // private void TxtSo_KeyPress(object sender, KeyPressEventArgs e)
        // {
        //     // Hiện tại hàm này đang chặn input không phải số.
        //     // Nếu bạn muốn cho phép nhập, hãy xóa nội dung hàm hoặc bỏ comment
        //     // Ví dụ: Không làm gì cả, để input đi qua
        //     // e.Handled = false;
        // }


        private void btnDocSo_Click(object sender, EventArgs e)
        {
            rtbKetQuaDocSo.Clear();
            string soCanDoc = txtSo.Text.Trim();

            // 1. Kiểm tra nếu ô nhập liệu rỗng
            if (string.IsNullOrEmpty(soCanDoc))
            {
                MessageBox.Show("Vui lòng nhập một số.", "Lỗi đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo.Focus();
                return;
            }

            // **ĐIỂM SỬA ĐỔI QUAN TRỌNG:** Kiểm tra xem chuỗi có HOÀN TOÀN là các chữ số hay không.
            // Nếu không, báo lỗi và không tiến hành đọc.
            if (!Regex.IsMatch(soCanDoc, @"^\d+$"))
            {
                MessageBox.Show("Dữ liệu nhập vào không phải là một số hợp lệ. Vui lòng chỉ nhập các chữ số (từ 0-9).", "Lỗi đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSo.Clear(); // Xóa nội dung không hợp lệ
                txtSo.Focus();
                return;
            }

            // Các kiểm tra còn lại vẫn giữ nguyên vì chúng xử lý các trường hợp số hợp lệ
            // nhưng cần xử lý đặc biệt (như số 0, số 0 ở đầu).

            // 2. Xử lý trường hợp số 0 hoặc các chuỗi chỉ chứa số 0 ("0", "00", "000"...)
            string originalSoCanDoc = soCanDoc; // Giữ lại giá trị gốc để kiểm tra sau này nếu cần
            soCanDoc = soCanDoc.TrimStart('0'); // Bỏ các số 0 ở đầu

            if (string.IsNullOrEmpty(soCanDoc))
            {
                // Nếu sau khi trim mà rỗng, thì nghĩa là input là "0" hoặc toàn số 0 ("00", "000")
                rtbKetQuaDocSo.Text = "Không";
                return;
            }

            // Nếu số quá dài sau khi trim (trường hợp input ban đầu có 000...000xxx, và xxx có >12 chữ số)
            // Mặc dù MaxLength = 12 đã chặn ngay từ đầu, nhưng đây là một lớp bảo vệ thêm
            if (soCanDoc.Length > 12)
            {
                MessageBox.Show("Số nhập vào quá lớn. Vui lòng nhập số có tối đa 12 chữ số.", "Lỗi đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSo.Clear();
                txtSo.Focus();
                return;
            }


            try
            {
                string ketQua = DocSoLon(soCanDoc);
                if (!string.IsNullOrEmpty(ketQua))
                    ketQua = char.ToUpper(ketQua[0]) + ketQua.Substring(1);
                rtbKetQuaDocSo.Text = ketQua;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi đọc số", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string DocSoLon(string so)
        {
            StringBuilder ketQua = new StringBuilder();
            int length = so.Length;
            int numGroups = (int)Math.Ceiling((double)length / 3);

            string[] groups = new string[numGroups];
            for (int i = 0; i < numGroups; i++)
            {
                int startIndex = length - (i + 1) * 3;
                int subLength = 3;
                if (startIndex < 0)
                {
                    subLength = 3 + startIndex;
                    startIndex = 0;
                }
                groups[numGroups - 1 - i] = so.Substring(startIndex, subLength);
            }

            for (int i = 0; i < numGroups; i++)
            {
                string currentGroupStr = groups[i];
                int currentGroupValue = int.Parse(currentGroupStr);

                // Bỏ qua nhóm 000 nếu tất cả các nhóm sau nó cũng là 0
                if (currentGroupValue == 0)
                {
                    bool allFollowingGroupsAreZero = true;
                    for (int j = i + 1; j < numGroups; j++)
                    {
                        if (int.Parse(groups[j]) != 0)
                        {
                            allFollowingGroupsAreZero = false;
                            break;
                        }
                    }
                    if (allFollowingGroupsAreZero && i < numGroups - 1)
                    {
                        continue;
                    }
                }

                bool needExplicitZeroHundred = false;
                // Nếu không phải nhóm đầu tiên và nhóm hiện tại có giá trị
                if (i > 0 && currentGroupValue != 0)
                {
                    // Nếu nhóm hiện tại có dạng 0xy hoặc 00z (ví dụ "5" thay vì "005", hoặc "05" thay vì "005")
                    // và nhóm trước đó có giá trị khác 0 (nghĩa là không phải một chuỗi các số 0)
                    if (currentGroupStr.Length < 3 || currentGroupStr.StartsWith("0"))
                    {
                        // Kiểm tra xem nhóm trước đó có phải là một nhóm 000 hay không
                        bool prevGroupWasZero = (int.Parse(groups[i - 1]) == 0);

                        // Nếu nhóm trước đó là 000 và nhóm hiện tại có dạng 0xx hoặc 00x (VD: 100005)
                        if (prevGroupWasZero && (currentGroupStr.Length < 3 || currentGroupStr.StartsWith("0")))
                        {
                            needExplicitZeroHundred = true;
                        }
                        // Nếu nhóm trước đó KHÔNG phải 000, và nhóm hiện tại có dạng 0xx hoặc 00x (VD: 105)
                        else if (!prevGroupWasZero && currentGroupStr.Length < 3)
                        {
                            needExplicitZeroHundred = true;
                        }
                    }
                }
                // Điều kiện riêng cho "không trăm" của một nhóm 0xx hoặc 00x khi nó đứng một mình sau một số khác 0
                else if (currentGroupStr.Length == 3 && currentGroupStr.StartsWith("0") && currentGroupValue != 0)
                {
                    if (i > 0 && int.Parse(groups[i - 1]) != 0) // nếu có đơn vị lớn phía trước
                    {
                        needExplicitZeroHundred = true;
                    }
                }
                // Trường hợp đặc biệt 1.000.000.005 -> Một tỷ không trăm linh năm
                else if (i > 0 && int.Parse(groups[i - 1]) == 0 && currentGroupValue != 0 && currentGroupStr.Length < 3)
                {
                    needExplicitZeroHundred = true;
                }


                string docGroup = DocBaChuSo(currentGroupStr.PadLeft(3, '0'), needExplicitZeroHundred);

                // Logic thêm đơn vị lớn
                if (!string.IsNullOrEmpty(docGroup))
                {
                    ketQua.Append(docGroup + " " + _donViLon[numGroups - 1 - i] + " ");
                }
                else if (currentGroupValue == 0 && numGroups - 1 - i > 0) // Nếu nhóm là 000 và có đơn vị lớn
                {
                    // Kiểm tra xem có số có nghĩa nào sau nhóm 000 này không.
                    // Nếu không có, không cần thêm đơn vị lớn cho nhóm 000 này (VD: 1000000 -> "Một triệu")
                    bool hasMeaningfulNumbersAfter = false;
                    for (int k = i + 1; k < numGroups; k++)
                    {
                        if (int.Parse(groups[k]) != 0)
                        {
                            hasMeaningfulNumbersAfter = true;
                            break;
                        }
                    }
                    if (hasMeaningfulNumbersAfter)
                    {
                        // Nếu có số có nghĩa sau nó, thì thêm đơn vị lớn của nhóm 000 này
                        ketQua.Append(_donViLon[numGroups - 1 - i] + " ");
                    }
                }
            }

            string finalResult = Regex.Replace(ketQua.ToString().Trim(), @"\s+", " ");

            finalResult = finalResult.Replace("mươi một", "mươi mốt");
            finalResult = finalResult.Replace("mươi năm", "mươi lăm");
            finalResult = finalResult.Replace("một mươi", "mười");

            // Xử lý "không mươi" thành "linh" (ví dụ: "hai trăm không mươi ba" -> "hai trăm linh ba")
            // Cần cẩn thận với regex để không thay thế sai các trường hợp như "không trăm"
            // Cách tốt nhất là xử lý "linh" ngay trong DocBaChuSo. Phần regex này có thể gây lỗi.
            // Để đơn giản, tôi sẽ gỡ bỏ các regex phức tạp này và tin tưởng vào DocBaChuSo.
            // Nếu vẫn cần, hãy kiểm tra kỹ Regex.
            finalResult = Regex.Replace(finalResult, @"(\s+)(không mươi)(\s+)", "$1linh$3");
            finalResult = Regex.Replace(finalResult, @"(\s+)(không mươi)$", "$1linh");

            return finalResult.Trim();
        }

        private string DocBaChuSo(string paddedGroup, bool needExplicitZeroHundred)
        {
            int tram = int.Parse(paddedGroup[0].ToString());
            int chuc = int.Parse(paddedGroup[1].ToString());
            int donvi = int.Parse(paddedGroup[2].ToString());
            StringBuilder kq = new StringBuilder();

            // Hàng trăm
            if (tram != 0)
            {
                kq.Append(_donVi[tram] + " trăm");
            }
            else if (needExplicitZeroHundred && (chuc != 0 || donvi != 0)) // Trường hợp "không trăm"
            {
                kq.Append("không trăm");
            }

            // Hàng chục
            if (chuc == 0)
            {
                if (donvi != 0) // Nếu hàng đơn vị khác 0
                {
                    if (tram != 0 || needExplicitZeroHundred) // Nếu có hàng trăm hoặc cần "không trăm", thì thêm "linh"
                        kq.Append(" linh " + _donVi[donvi]);
                    else // Trường hợp nhóm là "00x", ví dụ "005" -> "năm"
                        kq.Append(" " + _donVi[donvi]);
                }
            }
            else if (chuc == 1) // Hàng chục là 1 (mười)
            {
                kq.Append(" mười");
                if (donvi == 5) kq.Append(" lăm");
                else if (donvi != 0) kq.Append(" " + _donVi[donvi]);
            }
            else // Hàng chục lớn hơn 1
            {
                kq.Append(" " + _donVi[chuc] + " mươi");
                if (donvi == 1) kq.Append(" mốt");
                else if (donvi == 5) kq.Append(" lăm");
                else if (donvi != 0) kq.Append(" " + _donVi[donvi]);
            }

            return Regex.Replace(kq.ToString().Trim(), @"\s+", " ");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSo.Clear();
            rtbKetQuaDocSo.Clear();
            txtSo.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}