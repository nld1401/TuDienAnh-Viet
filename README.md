# TuDienAnh-Viet
Xây dựng chương trình từ điển Anh – Việt có hình ảnh, âm thanh

### Tên sv1: Nguyễn Mạnh Tùng 
mssv: 17521236

### Tên sv2: Nguyễn Lương Duy
mssv: 17520004
## 1.PHÂN TÍCH VÀ THIẾT KẾ CHƯƠNG TRÌNH
### 1.	Thiết kế cơ sở dữ liệu 
•	Mô tả cấu trúc XML database:
Cú pháp XML cơ bản cho một phần tử là: 
         <tên thuộc_tính="giá trị">nội dung</tên>

•	Cấu trúc file data.xml: 
><DictItem>
       <Items>
            <DictData>
                  <Key>key</Key> 
                  <Mean>mean</Mean>
            </DictData>
       </Items>
</DictItem>

Key: từ khóa

Mean: nghĩa

- Lý do lựa chọn xml database:
Nếu sử dụng sql database người dung sẽ cần cài đặt sql sever gây khó khăn trong việc sử dụng phần mềm. 



### 2.	Các chức năng chính :
- Tra cứu cơ bản: 
  
      - Mục đích: Dùng 1 combobox để tìm kiếm key, sau đó so sánh với csdl và hiện nghĩa của từ lên textbox bên phải
      - Cách thực hiện: sử dụng even SelectedIndexChanged và so sánh với database sau đó hiện nghĩa tương ứng vào textbox 


- Phát âm từ được chọn:
 
       - Mục đích: Phát âm được từ khóa người dùng đã nhập 
       - Cách thực hiện: sử dụng class SpeechSynthesizer được cung cấp trong c#
       - Thư viện sử dụng: 
      using System.Speech;
      using System.Speech.Synthesis;


-	Tìm kiếm hình ảnh với google: 

         - Mục đích: Hiện kết quả tìm kiếm hình ảnh từ google cho key
         - Cách thực hiện: sử dụng class WebBrowser có sẵn của c# winform
         - Thư viện sử dụng: 
           using Google;
           using Google.API;
           using Google.API.Search;

- Tham khảo Cambridge Dictionary:
 
      - Mục đích: Hiện kết quả tra cứu key với nghĩa đầy đủ hơn tại Cambridge Dictionary
      - Cách thực hiện: sử dụng class WebBrowser có sẵn của c# winform
      - Thư viện sử dụng: 
      using Google;
      using Google.API;
      using Google.API.Search;

## 2.KẾT LUẬN VÀ HƯỚNG PHÁT TRIỂN

### 1.KẾT LUẬN:
	1.1 Thuận lợi và khó khăn trong lúc thực hiện đồ án:
		1.1.1 Thuận lợi: 
			- Bản thân đã được trang bị các kiến thức liên quan về thiết kế phần mềm. Đã có kinh nghiệm trong việc tìm hiểu, phân tích thiết kế hệ thống thông tin.
			- Từ điển là một ứng dụng khá quen thuộc và dễ dàng trong cách tiếp cận các chức năng bởi vì khá phổ biến.
			- Được sự giúp đỡ của tận tình của GVHD và sự trợ giúp kiến thức từ Internet.
		1.1.2 Khó khăn:
			- Số lượng người trong nhóm ít 2 dẫn đến khối lượng công việc nhiều.
			- Với Cơ sở dữ liệu là XML database kiến thức vẫn nắm chưa thật kỹ về hệ quản trị này, áp dụng chỉ dẫn thiết kế và kết nối trên Internet.
    - Tìm kiếm database dạng XML trên Internet không có dẫn đến việc phải tự tìm hiểu việc chuyển đổi csdl từ SQL sang XML
			- Do chưa có kinh nghiệm về thiết kế một phần mềm nên còn rất khó khăn khi triển khai công việc.
	
    1.2 Kết quả đạt được:
	Qua thời gian nghiên cứu và học tập, nhìn chung đồ án  đã hoàn thành các mục tiêu, nhiệm vụ đề ra của một chương trình từ điển anh-việt với các chức năng như hệ thống phân tích thiết kế đã mô tả như ở trên.
	Xây dựng được một chương trình hoàn chỉnh có khả năng áp dụng vào thực tế.

### 2.ƯU VÀ NHƯỢC ĐIỂM CỦA HỆ THỐNG
		2.1 Ưu điểm:
			- Hệ thống được xây dựng gọn nhẹ, dễ sử dụng.
			- Giao diện thân thiện với người sử dụng.
		2.2 Nhược điểm:
			- Kỹ thuật lập trình chưa tốt.
			- Bắt lỗi hạn chế, chưa hoàn thiện.
			- Các chức năng của chương trình chưa linh động, có thể gây khó khăn khi sử dụng.

	3. HƯỚNG PHÁT TRIỂN:
		- Khả năng xử lý được tất cả các sự kiện, các lỗi ngoài ý muốn tốt hơn của chương trình và dùng thao tác lên chương trình.
		- Nâng cao tính linh động của chương trình.
		- Thêm các chức năng mới để đáp ứng điều kiện của người dùng.
		- Nâng cao kỷ thuật lập trình và hoàn chỉnh các thành phần còn thiếu theo hướng chuyên nghiệp, chạy thử, khả năng đưa vào áp dụng thức tế khả quan.

			

		


	

## TÀI LIỆU THAM KHẢO

1.	https://www.howkteam.vn
2.	https://www.Caulacbovb.com
3.	https://www.Dictionary.cambridge.org
4.	https://www.O7planning.org
		
