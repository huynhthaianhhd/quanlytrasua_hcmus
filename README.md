# quanlytrasua_hcmus

### Trước khi sử dụng, hãy conenct Database và chạy SQL
- Bước 1. Vào Tools --> Connect to DataBase
- Bước 2. Điền các thông số:
```
Server Name: [ServerSQL máy bạn] (ví dụ: DESKTOP-NBS8IM4\SQLSERVER)
Select or enter database name: QUANLYTS
```
- Bước 3. Vào DataProvider.cs trong folder DAO, chỉnh sửa như sau:
```
Line 24. private string connectionSTR = [DataSource của ServerSQL máy bạn]; (ví dụ: private string connectionSTR = "Data Source=DESKTOP-NBS8IM4\\SQLSERVER;Initial Catalog=QUANLYTS;Integrated Security=True";)
```
