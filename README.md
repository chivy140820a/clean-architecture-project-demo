Các thành phần chính trong Clean Architecture
Clean Architecture thường được mô tả dưới dạng các vòng tròn đồng tâm, với mỗi vòng tròn đại diện cho một cấp độ của kiến trúc và có các nguyên tắc riêng biệt:

Entities (Thực thể):

Mô tả: Đại diện cho các đối tượng kinh doanh với các logic và quy tắc nghiệp vụ cốt lõi. Đây là các đối tượng nền tảng của ứng dụng.

Ví dụ: User, Order, Product.

Use Cases (Trường hợp sử dụng):

Mô tả: Chứa các logic cụ thể cho từng trường hợp sử dụng của ứng dụng. Đây là nơi xử lý các thao tác liên quan đến nghiệp vụ.

Ví dụ: RegisterUser, PlaceOrder.

Interface Adapters (Giao diện thích nghi):

Mô tả: Chịu trách nhiệm chuyển đổi dữ liệu giữa các mô hình nghiệp vụ và các mô hình dữ liệu bên ngoài (như database, API). Đây là lớp trung gian giúp giảm sự phụ thuộc giữa các lớp.

Ví dụ: Controller, Presenter, Gateway.

Frameworks and Drivers (Khung làm việc và trình điều khiển):

Mô tả: Là các công cụ và thư viện cụ thể của bên thứ ba, như cơ sở dữ liệu, giao diện người dùng, frameworks, hệ điều hành. Các thành phần này nằm ở vòng ngoài cùng và phụ thuộc vào các lớp bên trong.

Ví dụ: ASP.NET, Entity Framework, SQL Server.

Nguyên tắc quan trọng
Dependency Rule: Phụ thuộc phải luôn luôn hướng từ ngoài vào trong. Các lớp bên trong không bao giờ phụ thuộc vào các lớp bên ngoài. Thay vào đó, các lớp bên ngoài có thể phụ thuộc vào các lớp bên trong.

Separation of Concerns: Mỗi lớp chỉ nên có một lý do để thay đổi, giúp mã nguồn dễ bảo trì và mở rộng.

Testability: Việc tách biệt các lớp giúp việc kiểm thử trở nên dễ dàng hơn.
