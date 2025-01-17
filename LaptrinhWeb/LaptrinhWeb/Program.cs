using System;
using System.Text.Json;

class Program
{
    // Hàm tính diện tích, chu vi và đường kính của hình tròn  
    static string CalculateCircleProperties(double r)
    {
        // Tính toán  
        double dienTich = Math.PI * r * r;
        double chuVi = 2 * Math.PI * r;
        double duongKinh = 2 * r;

        // Tạo đối tượng kết quả  
        var result = new
        {
            dien_tich = dienTich,
            chu_vi = chuVi,
            duong_kinh = duongKinh
        };

        // Chuyển đổi thành chuỗi JSON  
        return JsonSerializer.Serialize(result);
    }

    static void Main(string[] args)
    {
        double r;

        while (true)
        {
            Console.Write("Nhập bán kính r (phải lớn hơn 0): ");
            string input = Console.ReadLine();

            // Kiểm tra tính hợp lệ của đầu vào  
            if (double.TryParse(input, out r) && r > 0)
            {
                break; // Thoát vòng lặp khi nhập hợp lệ  
            }

            Console.WriteLine("Bán kính không hợp lệ, vui lòng nhập lại.");
        }

        // Gọi hàm để tính toán và hiển thị kết quả  
        string jsonResult = CalculateCircleProperties(r);
        Console.WriteLine("Kết quả:\n" + jsonResult);
    }
}