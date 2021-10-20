using System;

namespace LogicAndLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Các toán tử so sánh
            
            //      == : So sánh bằng vd: bool c = (a==b)  c = true / false
            //      > : So sánh lớn hơn vd: bool c = (a>b)  c = true / false
            //      >= : So sánh lớn hơn bằng vd: bool c = (a>=b)  c = true / false
            //      < : So sánh nhỏ hơn vd: bool c = (a<b)  c = true / false
            //      <= : So sánh lớn hơn bằng vd: bool c = (a<=b)  c = true / false
            //      != : So sánh khác vd: bool c = (a != b)  c = true / false
            
            // 2. Các toán tử logic
            
            //      && (và) : phép toán và - trả về true nếu cả hai số hạng true, còn lại là false
                    // int a = 1;
                    // int b = 2;
                    // if (a == 1 && b == 3)
                    // {
                    //     
                    // }
                    // else
                    // {
                    //     
                    // }
            //      || (hoặc) : phép hoặc - trả về true nếu 1 trong hai số hạng là true, còn lại là false
                    // int a = 1;
                    // int b = 2;
                    // if (a == 1 || b == 3)
                    // {
                    //     
                    // }
                    // else
                    // {
                    //     
                    // }
            //      ! (đối) : phép đối - !true = false; !false = true
            
            // 3. Câu lệch if
            
                // if(điều kiện)
                //      câu_lênh; 
                // int a = 1;
                // int b = 1;
                // if (true)
                //     Console.WriteLine("fdasfdsafdasf");
                
                // if(điều kiện)
                //{
                        // Câu-Lênh;
                //}

                // if (true)
                // {
                //     Console.WriteLine("");
                //     Console.WriteLine("");
                //     Console.WriteLine("");
                //     Console.WriteLine("");
                // }
                
                // if(điều kiện)
                // {
                //     // Câu-Lênh;
                // }
                // else
                // {
                //     // Câu-Lênh;
                // }


                // int number = 1990;
                //
                // if ((number%2)==0)
                // {
                //     Console.WriteLine($"{number} là số chẵn");
                // }
                // else
                // {
                //     Console.WriteLine($"{number} là số lẻ");
                // }

                // int a = 10;
                // int b = 10;

                // cách 1
                // if (a>b)
                // {
                //     Console.WriteLine("Số a lớn hơn b");
                // }
                // else
                // {
                //     if (a==b)
                //     {
                //         Console.WriteLine("Số a Bằng b");
                //     }
                //     else
                //     {
                //         Console.WriteLine("Số a nhỏ hơn b");
                //     }
                // }
                
                //cách 2

                // if (a>b)
                // {
                //     Console.WriteLine("Số a lớn hơn b");
                // }
                // else if (a == b)
                // {
                //     Console.WriteLine("Số a Bằng b");
                // }
                // else if (a == b)
                // {
                //     Console.WriteLine("Số a Bằng b");
                // }
                // else if (a == b)
                // {
                //     Console.WriteLine("Số a Bằng b");
                // }
                // else
                // {
                //     Console.WriteLine("Số a nhỏ hơn b");
                // }

                // if (a > b && a > 30)
                // {
                //     
                // }


                // 4. Câu lệch ba thành phần
                
                    //string value = Diều kiện ? (Value for true) : (value for false)

                    // string value = false ? "Giá trị khi đúng" : "Giá trị khi sai";
                    // Console.WriteLine(value);

                    // var a = 2;
                    // var b = 3.5;
                    // var c = 2;
                    //
                    // var max = a >= b ? (a >= c ? a : c) : (b >= c ? b : c);
                    //
                    // Console.WriteLine(max);

            // 5. Câu lênh switch

                    // switch (value)
                    // {
                    //    case value1:
                    //        câu - lệnh;
                    //        break;
                    //    case value2:
                    //        câu - lệnh;
                    //        break;
                    //    case value3:
                    //        câu - lệnh;
                    //        break;
                    //    case value4:
                    //        câu - lệnh;
                    //        break;
                    //    default:
                    //        câu - lệnh;
                    //        break;
                    // }

                    // int number = 2;
                    // switch (number)
                    // {
                    //     case 1:
                    //         Console.WriteLine("Number bằng 1");
                    //         break;
                    //     case 2:
                    //         Console.WriteLine("Number bằng 2");
                    //         break;
                    //     case 3:
                    //         Console.WriteLine("Number bằng 3");
                    //         break;
                    //     case 4:
                    //         Console.WriteLine("Number bằng 4");
                    //         break;
                    //     default:
                    //         Console.WriteLine("Number ");
                    //         break;
                    // }

                // 6. For loop
                    // for(khởi_tạo; điều kiên; cập nhật){
                    //      câu lệnh
                    // }
                    
                    // Khởi_tạo: là giá trị ban đầu: int i = 1; 
                    // Điều kiện: điều kiện dừng lại (nếu điều kiện trả về true thì tiếp tục còn lại thì dừng lại)
                    // Câp_nhật: Chập nhật nhật lại giá trị ban đầu sau mỗi lần chạy;

                    // for (int i = 0; i < 10; i++)
                    // {
                    //     Console.WriteLine("số I =" + i);
                    // }

                    // int j = 10;
                    // for (; j < 20;)
                    // {
                    //     Console.WriteLine("số j = " + j);
                    //     j += 2;
                    // }
                    
                    // Lặp vô hạn
                    // int i = 0;
                    // for (;;)
                    // {
                    //     Console.WriteLine("Số i =" + i);
                    //     i++;
                    // }
                    
                // 7. While loop
                    // While(Điều kiện)
                    // {
                    //      câu lệnh
                    // }

                    // int i = 0;
                    // while (i <= 10)
                    // {
                    //     Console.WriteLine("Số i là"+ i);
                    //     //i++;
                    // }
                    
                // 8. do...while
                
                    // do
                    // {
                    //      câu lệnh
                    // }
                    // while (điều kiện)

                    // int i = 11;
                    // do
                    // {
                    //     Console.WriteLine("Số I là " + i);
                    // } while (i < 10);

                // 9. break, continue

                    // for (int j = 10; j < 20; j++)
                    // {
                    //     if (j % 3 != 0) 
                    //         continue;
                    //     Console.WriteLine("Số chia hết cho 3 là " + j);
                    // }

                    // int i = 0;
                    //
                    // while (true)
                    // {
                    //     Console.Write(" " + ++i);
                    //     if (i == 10)
                    //         break;
                    // }

        }
    }
}