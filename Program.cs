using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExSubLab1();
            //ExSubLab3();
            //ExSubLab6();
            ExSubLab5();
            Console.ReadKey();
        }
        /*1. In ra bảng cửu chương dùng cả for, dowhile, whiledo*/
        static void ExSubLab1()
        {
            Console.Write("\n");
            Console.Write("In bang cuu chuong trong C#:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{j} x {i}= {j * i}\t");
                }
                Console.WriteLine();
            }
            Console.Write("\n");
            Console.Write("----------------------------\n");
            Console.Write("In bang cuu chuong trong C#:\n");
            Console.Write("------Using While - do -----\n");
            int a = 1;
            while (a <= 10)
            {
                int b = 1;
                while (b <= 10)
                {
                    Console.Write("{0} x {1} = {2}\t", b, a, b * a);
                    b++;
                }

                Console.WriteLine();
                a++;
            }
            Console.Write("\n");
            Console.Write("----------------------------\n");
            Console.Write("In bang cuu chuong trong C#:\n");
            Console.Write("------Using do - While -----\n");
            int num, so_nhan;

            num = 1;

            do
            {

                so_nhan = 1;
                do
                {
                    Console.Write("{0} x {1} = {2}\t",
                        so_nhan, num, num * so_nhan);
                    so_nhan++;
                }
                while (so_nhan <= 10);

                Console.WriteLine();
                num++;

            } while (num <= 10);
        }
        /*3. Đếm số lần xuất hiện ký tự chuỗi trong 1 chuỗi
        Ví dụ: abccccdeff --> a1b1c4d1e1f2 */
        static void ExSubLab3()
        {
        Console.Write("\n");
        Console.Write("----------Bai 3----------\n");
        Console.Write("In bang cuu chuong trong C#:\n");
        Console.Write("----3-Dem so lan xuat hien ki tu -----\n");
        Console.Write("Nhap vao chuoi: ");
        string message = Console.ReadLine();
        //Xóa khoảng trắng khỏi chuỗi
        // Hàm Replace xử lý thay thế chuỗi
        message = message.Replace(" ", string.Empty);
        //sử dụng vòng lặp while và for để lặp và đếm số lần xuất hiện của ký tự
        while (message.Length > 0)
        {
            Console.Write(message[0] + " : ");
            int count = 0;
            for (int j = 0; j < message.Length; j++)
            {
                if (message[0] == message[j])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            message = message.Replace(message[0].ToString(), string.Empty);
        }
        Console.WriteLine("\n ----Chuong trinh su dung vong lap---- \n");
        /*làm cách khác sử dụng từ điển*/
        /*Console.Write("Nhap vao chuoi: ");
        string message = Console.ReadLine();*/
        //khai báo và sử dụng class Dictionary lưu ký tự và số lượng
        Dictionary<char, int> dict = new Dictionary<char, int>();
        //sử dụng vòng lặp for để lặp từng ký tự
        //nếu chưa có trong Dic thì thêm vào và tăng ký tự đó lên 1
        //nếu tồn tại rồi thì tăng ký tự đó lên 1
        foreach (char ch in message.Replace(" ", string.Empty))
        {
            if (dict.ContainsKey(ch))// ContainsKey kiểm tra xem 1 khóa có tồn tại trong từ điển ko?
            {
                dict[ch] = dict[ch] + 1;
            }
            else
            {
                dict.Add(ch, 1);//Add là Thêm giá trị vào cuối danh sách
            }
        }
        //hiển thị ký tự và số lần xuất hiện ra màn hình
        foreach (var item in dict.Keys)
        {
            Console.WriteLine(item + " : " + dict[item]);
        }
        Console.WriteLine("\n ----Chuong trinh su dung tu dien---- \n");
    }
        /*5. Tìm tất cả các số có 6 chữ số trong chuỗi:
        Ví dụ: Mã xác thực t-123456 tồn tại 60s --> 123456*/
        static void ExSubLab5()
        {
        Console.OutputEncoding = Encoding.UTF8;// Hiển thị tiếng việt trong console
        Console.Write("\n");
        Console.Write("----------Bai 5----------\n");
        Console.Write("In bang cuu chuong trong C#:\n");
        Console.Write("----5-Tìm tất cả các số có 6 chữ số trong chuỗi -----\n");
            Console.Write("Nhap vao chuoi: ");
            string message = Console.ReadLine();
            string strNum = "";
            //int dem = 0;
        foreach(char x in message)
            {
               if (char.IsDigit(x))//kiểm tra có phải là kiểu số ko?
                {
                    strNum += x;
                    if (strNum.Length == 6)
                    {
                        break;
                    }
                }
            }
         Console.WriteLine(strNum);
        }
        /*6. Cho chuỗi bất kỳ, sắp xếp lại theo thứ tự trong bảng chữ cái abc
        Ví dụ: "kdj5ldl" --> "5ddjkll"*/
        static void ExSubLab6()
        {
            Console.Write("\n");
            Console.Write("----------Bai 6----------\n");
            Console.Write("In bang cuu chuong trong C#:\n");
            Console.Write("----6-Cho chuỗi bất kỳ, sắp xếp lại theo thứ tự trong bảng chữ cái abc -----\n");
            Console.Write("Nhap vao chuoi: ");
            string str; //khai bao mot chuoi
            char[] arr1;
            char ch;
            int i, j, l;
            str = Console.ReadLine();
            l = str.Length;
            arr1 = str.ToCharArray(0, l);

            for (i = 1; i < l; i++)
                for (j = 0; j < l - i; j++)

                    if (arr1[j] > arr1[j + 1])
                    {
                        ch = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = ch;
                    }
            Console.Write("Sau khi sap xep, chuoi co dang: \n");
            foreach (char c in arr1)
            {
                ch = c;
                Console.Write("{0}", ch);
            }
            Console.WriteLine("\n");
        }
    }
}
