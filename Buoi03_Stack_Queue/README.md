# Buổi 03 – Stack và Queue

Họ tên: [Điền Họ tên của bạn] · MSV: [Điền MSV của bạn]

## Bài đã làm

Bài 1, 2, 3, 4, 5 (Theo file code hiện tại trong thư mục dự án).

## Cách chạy

```
dotnet run --project Buoi03_Stack_Queue
```

## Kết quả chạy

```
================ MENU BÀI TẬP CTDL & GT ================
1. Bài tập 1: Mảng 1 chiều số nguyên dương
2. Bài tập 2: Danh sách Nhân viên (Struct)
3. Bài tập 3: Ma trận vuông cấp n
4. Bài tập 4: Danh sách liên kết đơn (số nguyên dương)
5. Bài tập 5: Danh sách liên kết đơn (số nguyên)
0. Thoát chương trình
=> Chọn bài tập muốn chạy (0-5): 1

Nhập số phần tử n: 4
Nhập a[0]: 10
Nhập a[1]: 20
Nhập a[2]: 30
Nhập a[3]: 40
Danh sách vừa nhập: 10 20 30 40 
Nhập giá trị x cần chèn: 99
Nhập vị trí k cần chèn (0 -> 4): 2
Danh sách sau khi chèn: 10 20 99 30 40 

================ MENU BÀI TẬP CTDL & GT ================
1. Bài tập 1: Mảng 1 chiều số nguyên dương
2. Bài tập 2: Danh sách Nhân viên (Struct)
3. Bài tập 3: Ma trận vuông cấp n
4. Bài tập 4: Danh sách liên kết đơn (số nguyên dương)
5. Bài tập 5: Danh sách liên kết đơn (số nguyên)
0. Thoát chương trình
=> Chọn bài tập muốn chạy (0-5): 2

Nhập số lượng nhân viên: 2
--- Nhập thông tin nhân viên thứ 1 ---
Mã nhân viên: NV01
Họ và tên: Nguyen Van A
Năm sinh: 2000
Phòng ban: IT
Lương cơ bản: 10000000
Thưởng: 1500000
--- Nhập thông tin nhân viên thứ 2 ---
Mã nhân viên: NV02
Họ và tên: Tran Thi B
Năm sinh: 2001
Phòng ban: HR
Lương cơ bản: 8000000
Thưởng: 1000000

a) Tổng thực lĩnh của toàn công ty: 20500000

b) Nhân viên có lương cơ bản thấp nhất (8000000):
   Mã: NV02 | Tên: Tran Thi B | NS: 2001 | PB: HR | Lương CB: 8000000 | Thưởng: 1000000 | Thực lĩnh: 9000000

c) Số nhân viên có mức thưởng >= 1.200.000: 1

d) Danh sách nhân viên sau khi sắp xếp:
   Mã: NV02 | Tên: Tran Thi B | NS: 2001 | PB: HR | Lương CB: 8000000 | Thưởng: 1000000 | Thực lĩnh: 9000000
   Mã: NV01 | Tên: Nguyen Van A | NS: 2000 | PB: IT | Lương CB: 10000000 | Thưởng: 1500000 | Thực lĩnh: 11500000

e) Danh sách nhân viên sau khi tăng lương cơ bản thêm 5%:
   Mã: NV02 | Tên: Tran Thi B | NS: 2001 | PB: HR | Lương CB: 8400000 | Thưởng: 1000000 | Thực lĩnh: 9400000
   Mã: NV01 | Tên: Nguyen Van A | NS: 2000 | PB: IT | Lương CB: 10500000 | Thưởng: 1500000 | Thực lĩnh: 12000000

================ MENU BÀI TẬP CTDL & GT ================
1. Bài tập 1: Mảng 1 chiều số nguyên dương
2. Bài tập 2: Danh sách Nhân viên (Struct)
3. Bài tập 3: Ma trận vuông cấp n
4. Bài tập 4: Danh sách liên kết đơn (số nguyên dương)
5. Bài tập 5: Danh sách liên kết đơn (số nguyên)
0. Thoát chương trình
=> Chọn bài tập muốn chạy (0-5): 3

Nhập cấp n của ma trận vuông (0 < n < 100): 3
Nhập a[0,0]: 1
Nhập a[0,1]: 2
Nhập a[0,2]: 3
Nhập a[1,0]: 4
Nhập a[1,1]: 5
Nhập a[1,2]: 6
Nhập a[2,0]: 7
Nhập a[2,1]: 8
Nhập a[2,2]: 9
a) Tổng tất cả phần tử của ma trận: 45
b) Giá trị dương nhỏ nhất của ma trận: 1
c) Tổng các phần tử trên đường chéo phụ: 15
d) Các phần tử trên đường chéo chính TĂNG DẦN.

================ MENU BÀI TẬP CTDL & GT ================
1. Bài tập 1: Mảng 1 chiều số nguyên dương
2. Bài tập 2: Danh sách Nhân viên (Struct)
3. Bài tập 3: Ma trận vuông cấp n
4. Bài tập 4: Danh sách liên kết đơn (số nguyên dương)
5. Bài tập 5: Danh sách liên kết đơn (số nguyên)
0. Thoát chương trình
=> Chọn bài tập muốn chạy (0-5): 4

Nhập số lượng nút muốn tạo: 4
Nhập giá trị dương nút 1: 5
Nhập giá trị dương nút 2: 2
Nhập giá trị dương nút 3: 8
Nhập giá trị dương nút 4: 2
Danh sách hiện tại: 5 -> 2 -> 8 -> 2 -> null

Nhập giá trị x cần đếm: 2
a) Số lượng phần tử bằng 2 là: 2
b) Phần tử dương nhỏ nhất là: 2

Nhập giá trị x cần xóa (xuất hiện đầu tiên): 2
c) Danh sách sau khi xóa 2 đầu tiên: 5 -> 8 -> 2 -> null

================ MENU BÀI TẬP CTDL & GT ================
1. Bài tập 1: Mảng 1 chiều số nguyên dương
2. Bài tập 2: Danh sách Nhân viên (Struct)
3. Bài tập 3: Ma trận vuông cấp n
4. Bài tập 4: Danh sách liên kết đơn (số nguyên dương)
5. Bài tập 5: Danh sách liên kết đơn (số nguyên)
0. Thoát chương trình
=> Chọn bài tập muốn chạy (0-5): 5

Nhập số lượng nút cho danh sách l: 5
Nhập số nguyên nút 1: -3
Nhập số nguyên nút 2: 0
Nhập số nguyên nút 3: 2
Nhập số nguyên nút 4: 5
Nhập số nguyên nút 5: 4
Danh sách l: -3 -> 0 -> 2 -> 5 -> 4 -> null

a) Phần tử lớn nhất: 5
b) Tổng các phần tử: 8
c) Số lượng số nguyên tố: 2
d) Số âm: 1 | Số không: 1 | Số dương: 3

Nhập x cần đếm cho câu e: 5
e) Số phần tử bằng 5: 1
f) Phần tử dương nhỏ nhất: 2

================ MENU BÀI TẬP CTDL & GT ================
1. Bài tập 1: Mảng 1 chiều số nguyên dương
2. Bài tập 2: Danh sách Nhân viên (Struct)
3. Bài tập 3: Ma trận vuông cấp n
4. Bài tập 4: Danh sách liên kết đơn (số nguyên dương)
5. Bài tập 5: Danh sách liên kết đơn (số nguyên)
0. Thoát chương trình
=> Chọn bài tập muốn chạy (0-5): 0
```