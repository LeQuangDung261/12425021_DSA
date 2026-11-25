using System;
using System.Text;

namespace BaiTapCTDL
{
    // Cấu trúc Nhân Viên dùng cho Bài tập 2 (theo gợi ý trang 160-161)
    struct NhanVien
    {
        public string MaNV;
        public string Hoten;
        public int Namsinh;
        public string Phongban;
        public int LuongCB;
        public int Thuong;

        public int ThucLinh()
        {
            return LuongCB + Thuong;
        }
    }

    // Cấu trúc Nút (Node) cho Danh sách liên kết đơn dùng cho Bài 4 và Bài 5
    class Node
    {
        public int info;
        public Node link;

        public Node(int x)
        {
            info = x;
            link = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n================ MENU BÀI TẬP CTDL & GT ================");
                Console.WriteLine("1. Bài tập 1: Mảng 1 chiều số nguyên dương");
                Console.WriteLine("2. Bài tập 2: Danh sách Nhân viên (Struct)");
                Console.WriteLine("3. Bài tập 3: Ma trận vuông cấp n");
                Console.WriteLine("4. Bài tập 4: Danh sách liên kết đơn (số nguyên dương)");
                Console.WriteLine("5. Bài tập 5: Danh sách liên kết đơn (số nguyên)");
                Console.WriteLine("0. Thoát chương trình");
                Console.Write("=> Chọn bài tập muốn chạy (0-5): ");

                int chon = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (chon)
                {
                    case 1: BaiTap1(); break;
                    case 2: BaiTap2(); break;
                    case 3: BaiTap3(); break;
                    case 4: BaiTap4(); break;
                    case 5: BaiTap5(); break;
                    case 0: return;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }
            }
        }

        // =====================================================================
        // BÀI TẬP 1: Mảng 1 chiều (Trang 159 - 160)
        // =====================================================================
        static void BaiTap1()
        {
            Console.Write("Nhập số phần tử n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            // a. Nhập từ bàn phím
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            // b. Hiển thị danh sách ra màn hình, cách nhau 1 khoảng trống
            Console.Write("Danh sách vừa nhập: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            // c. Chèn phần tử x vào vị trí k của dãy (theo gợi ý dùng mảng trung gian tmp)
            Console.Write("Nhập giá trị x cần chèn: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write($"Nhập vị trí k cần chèn (0 -> {a.Length}): ");
            int k = int.Parse(Console.ReadLine());

            if (k < 0 || k > a.Length)
            {
                Console.WriteLine("Vị trí k không hợp lệ!");
                return;
            }

            int[] tmp = new int[a.Length + 1];
            for (int i = 0; i < k; i++)
            {
                tmp[i] = a[i];
            }
            tmp[k] = x;
            for (int i = k; i < a.Length; i++)
            {
                tmp[i + 1] = a[i];
            }
            a = tmp;

            Console.Write("Danh sách sau khi chèn: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        // =====================================================================
        // BÀI TẬP 2: Danh sách Nhân viên (Trang 160 - 161)
        // =====================================================================
        static void BaiTap2()
        {
            Console.Write("Nhập số lượng nhân viên: ");
            int n = int.Parse(Console.ReadLine());
            NhanVien[] DS = new NhanVien[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"--- Nhập thông tin nhân viên thứ {i + 1} ---");
                Console.Write("Mã nhân viên: "); DS[i].MaNV = Console.ReadLine();
                Console.Write("Họ và tên: "); DS[i].Hoten = Console.ReadLine();
                Console.Write("Năm sinh: "); DS[i].Namsinh = int.Parse(Console.ReadLine());
                Console.Write("Phòng ban: "); DS[i].Phongban = Console.ReadLine();
                Console.Write("Lương cơ bản: "); DS[i].LuongCB = int.Parse(Console.ReadLine());
                Console.Write("Thưởng: "); DS[i].Thuong = int.Parse(Console.ReadLine());
            }

            // a. Tính tổng thực lĩnh tháng của tất cả nhân viên
            long tongThucLinh = 0;
            for (int i = 0; i < DS.Length; i++)
            {
                tongThucLinh += DS[i].ThucLinh();
            }
            Console.WriteLine($"\na) Tổng thực lĩnh của toàn công ty: {tongThucLinh}");

            // b. In danh sách những nhân viên có mức lương cơ bản thấp nhất
            int minLuong = int.MaxValue;
            for (int i = 0; i < DS.Length; i++)
            {
                if (DS[i].LuongCB < minLuong)
                    minLuong = DS[i].LuongCB;
            }
            Console.WriteLine($"\nb) Nhân viên có lương cơ bản thấp nhất ({minLuong}):");
            for (int i = 0; i < DS.Length; i++)
            {
                if (DS[i].LuongCB == minLuong)
                    In1NhanVien(DS[i]);
            }

            // c. Đếm số lượng nhân viên có mức thưởng >= 1200000
            int dem = 0;
            for (int i = 0; i < DS.Length; i++)
            {
                if (DS[i].Thuong >= 1200000)
                    dem++;
            }
            Console.WriteLine($"\nc) Số nhân viên có mức thưởng >= 1.200.000: {dem}");

            // d. In danh sách tăng dần theo phòng ban, trùng thì giảm dần theo mã NV
            for (int i = 0; i < DS.Length - 1; i++)
            {
                for (int j = i + 1; j < DS.Length; j++)
                {
                    int soSanhPB = string.Compare(DS[i].Phongban, DS[j].Phongban, StringComparison.OrdinalIgnoreCase);
                    bool canDoiCho = false;

                    if (soSanhPB > 0) // Phòng ban i > j -> đổi để tăng dần
                        canDoiCho = true;
                    else if (soSanhPB == 0 && string.Compare(DS[i].MaNV, DS[j].MaNV, StringComparison.OrdinalIgnoreCase) < 0) // Trùng phòng ban, Mã NV i < j -> đổi để giảm dần
                        canDoiCho = true;

                    if (canDoiCho)
                    {
                        NhanVien tam = DS[i];
                        DS[i] = DS[j];
                        DS[j] = tam;
                    }
                }
            }
            Console.WriteLine("\nd) Danh sách nhân viên sau khi sắp xếp:");
            for (int i = 0; i < DS.Length; i++)
            {
                In1NhanVien(DS[i]);
            }

            // e. Cập nhật tăng lương cơ bản của tất cả nhân viên lên 5%
            Console.WriteLine("\ne) Danh sách nhân viên sau khi tăng lương cơ bản thêm 5%:");
            for (int i = 0; i < DS.Length; i++)
            {
                DS[i].LuongCB = (int)(DS[i].LuongCB * 1.05);
                In1NhanVien(DS[i]);
            }
        }

        static void In1NhanVien(NhanVien nv)
        {
            Console.WriteLine($"   Mã: {nv.MaNV} | Tên: {nv.Hoten} | NS: {nv.Namsinh} | PB: {nv.Phongban} | Lương CB: {nv.LuongCB} | Thưởng: {nv.Thuong} | Thực lĩnh: {nv.ThucLinh()}");
        }

        // =====================================================================
        // BÀI TẬP 3: Ma trận vuông cấp n (Trang 162)
        // =====================================================================
        static void BaiTap3()
        {
            Console.Write("Nhập cấp n của ma trận vuông (0 < n < 100): ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Nhập a[{i},{j}]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"a) Tổng tất cả phần tử của ma trận: {TongMaTran(a, n)}");

            int minDuong = DuongNhoNhatMaTran(a, n);
            if (minDuong == int.MaxValue)
                Console.WriteLine("b) Ma trận không có phần tử dương.");
            else
                Console.WriteLine($"b) Giá trị dương nhỏ nhất của ma trận: {minDuong}");

            Console.WriteLine($"c) Tổng các phần tử trên đường chéo phụ: {TongCheoPhu(a, n)}");

            if (KiemTraCheoChinhTangDan(a, n))
                Console.WriteLine("d) Các phần tử trên đường chéo chính TĂNG DẦN.");
            else
                Console.WriteLine("d) Các phần tử trên đường chéo chính KHÔNG tăng dần.");
        }

        static int TongMaTran(int[,] a, int n)
        {
            int t = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    t += a[i, j];
            return t;
        }

        static int DuongNhoNhatMaTran(int[,] a, int n)
        {
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (a[i, j] > 0 && a[i, j] < min)
                        min = a[i, j];
            return min;
        }

        static int TongCheoPhu(int[,] a, int n)
        {
            int t = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (j == (n - 1) - i) // Điều kiện đường chéo phụ theo gợi ý
                        t += a[i, j];
            return t;
        }

        static bool KiemTraCheoChinhTangDan(int[,] a, int n)
        {
            int[] tg = new int[n];
            for (int i = 0; i < n; i++)
            {
                tg[i] = a[i, i]; // Đường chéo chính: i == j
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (tg[i] >= tg[j])
                        return false;
                }
            }
            return true;
        }

        // =====================================================================
        // CÁC HÀM HỖ TRỢ CHO DANH SÁCH LIÊN KẾT ĐƠN (BÀI 4 & BÀI 5)
        // =====================================================================
        static Node ChenCuoiDSLK(Node pHead, int x)
        {
            Node p = new Node(x);
            if (pHead == null) return p;

            Node q = pHead;
            while (q.link != null)
            {
                q = q.link;
            }
            q.link = p;
            return pHead;
        }

        static void InDSLK(Node pHead)
        {
            if (pHead == null)
            {
                Console.WriteLine("Danh sách rỗng.");
                return;
            }
            Node p = pHead;
            while (p != null)
            {
                Console.Write(p.info + " -> ");
                p = p.link;
            }
            Console.WriteLine("null");
        }

        // =====================================================================
        // BÀI TẬP 4: DSLK đơn số nguyên dương (Trang 163)
        // =====================================================================
        static void BaiTap4()
        {
            Node pHead = null;
            Console.Write("Nhập số lượng nút muốn tạo: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập giá trị dương nút {i + 1}: ");
                int val = int.Parse(Console.ReadLine());
                pHead = ChenCuoiDSLK(pHead, val);
            }

            Console.Write("Danh sách hiện tại: ");
            InDSLK(pHead);

            // a. Đếm xem trong danh sách có bao nhiêu số bằng x
            Console.Write("\nNhập giá trị x cần đếm: ");
            int xDem = int.Parse(Console.ReadLine());
            int d = 0;
            for (Node p = pHead; p != null; p = p.link)
            {
                if (p.info == xDem) d++;
            }
            Console.WriteLine($"a) Số lượng phần tử bằng {xDem} là: {d}");

            // b. Tìm phần tử dương nhỏ nhất trong danh sách
            int minduong = int.MaxValue;
            for (Node p = pHead; p != null; p = p.link)
            {
                if (p.info > 0 && p.info < minduong)
                    minduong = p.info;
            }
            if (minduong == int.MaxValue)
                Console.WriteLine("b) Không có phần tử dương trong danh sách.");
            else
                Console.WriteLine($"b) Phần tử dương nhỏ nhất là: {minduong}");

            // c. Xóa phần tử x xuất hiện đầu tiên trong danh sách
            Console.Write("\nNhập giá trị x cần xóa (xuất hiện đầu tiên): ");
            int xXoa = int.Parse(Console.ReadLine());

            Node cur = pHead;
            Node t = null; // Nút t đứng trước nút cur (theo gợi ý trong sách)
            while (cur != null && cur.info != xXoa)
            {
                t = cur;
                cur = cur.link;
            }

            if (cur == null)
            {
                Console.WriteLine($"c) Không tìm thấy {xXoa} trong danh sách.");
            }
            else
            {
                if (cur == pHead) // Trường hợp xóa nút đầu
                    pHead = pHead.link;
                else // Trường hợp xóa nút giữa hoặc cuối
                    t.link = cur.link;

                Console.Write($"c) Danh sách sau khi xóa {xXoa} đầu tiên: ");
                InDSLK(pHead);
            }
        }

        // =====================================================================
        // BÀI TẬP 5: DSLK đơn số nguyên (Trang 163 - 164)
        // =====================================================================
        static bool KTNT(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

        static void BaiTap5()
        {
            Node l = null;
            Console.Write("Nhập số lượng nút cho danh sách l: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập số nguyên nút {i + 1}: ");
                int val = int.Parse(Console.ReadLine());
                l = ChenCuoiDSLK(l, val);
            }

            Console.Write("Danh sách l: ");
            InDSLK(l);

            if (l == null) return;

            // a. Tìm phần tử lớn nhất danh sách l
            int max = int.MinValue;
            // b. Tính tổng các phần tử của danh sách l
            int tong = 0;
            // c. Đếm số nguyên tố
            int demNT = 0;
            // d. Đếm số âm, số 0, số dương
            int demAm = 0, demKhong = 0, demDuong = 0;
            // f. Tìm phần tử dương nhỏ nhất
            int minduong = int.MaxValue;

            for (Node p = l; p != null; p = p.link)
            {
                if (p.info > max) max = p.info;
                tong += p.info;
                if (KTNT(p.info)) demNT++;

                if (p.info < 0) demAm++;
                else if (p.info == 0) demKhong++;
                else
                {
                    demDuong++;
                    if (p.info < minduong) minduong = p.info;
                }
            }

            Console.WriteLine($"\na) Phần tử lớn nhất: {max}");
            Console.WriteLine($"b) Tổng các phần tử: {tong}");
            Console.WriteLine($"c) Số lượng số nguyên tố: {demNT}");
            Console.WriteLine($"d) Số âm: {demAm} | Số không: {demKhong} | Số dương: {demDuong}");

            // e. Đếm xem có bao nhiêu số bằng x
            Console.Write("\nNhập x cần đếm cho câu e: ");
            int x = int.Parse(Console.ReadLine());
            int demX = 0;
            for (Node p = l; p != null; p = p.link)
            {
                if (p.info == x) demX++;
            }
            Console.WriteLine($"e) Số phần tử bằng {x}: {demX}");

            if (minduong == int.MaxValue)
                Console.WriteLine("f) Danh sách không có số dương.");
            else
                Console.WriteLine($"f) Phần tử dương nhỏ nhất: {minduong}");
        }
    }
}