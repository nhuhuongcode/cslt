using System;
class HelloWorld
{
    static void Main()
    {
        string[] Vi = {"May tinh", "Giao vien", "but chi", "sach", "con chuot", "mon toan",
                    "ban be", "mai toc", "trai chanh", "truong hoc", "tinh nguyen vien",
                    "dien thoai thong minh", "lop hoc", "he thong", "xe may", "con song",
                    "truc tuyen", "khach hang", "ngoi sao", "bau troi"};
        string[] En = {"computer", "teacher", "pencil", "book", "mouse", "math",
                    "friend", "hair", "lemon", "school", "volunteer",
                    "smarth phone", "class", "system", "motorbike", "river",
                    "online", "customer", "star", "sky"};
        String Yn = "Y";
        int c = 0; int d = 0;
        do
        {
            Random random = new Random();
            int i = random.Next(Vi.Length);
            Console.Write("Ban hay dich tu ");
            Console.ForegroundColor = ConsoleColor.Red;// doi mau chu
            Console.Write(Vi[i]);
            Console.ResetColor();//xoa doi mau chu
            Console.WriteLine(" sang tieng Anh nhe");
            //Console.WriteLine(Vi[i]);
            Console.WriteLine("Nhap dan an cua ban : ");
            string Da = Console.ReadLine();
            Da = Da.ToLower();
            if (Da != En[i])
            {
                Console.WriteLine("Dap an cua ban khong chinh xac!");
                Console.Write("Dap an chinh xac la: ");
                Console.ForegroundColor = ConsoleColor.Blue;// doi mau chu
                Console.WriteLine(En[i]);
                Console.ResetColor();//xoa doi mau chu
            }
            else
            {
                Console.WriteLine("\aDap an cua ban hoan toan chinh xac!");// \a: ting ting
                d++;
            }
            c++;
            Console.WriteLine("Ban co muon tiep tuc khong ?");
            Console.WriteLine("Y or N?");
            Yn = Console.ReadLine();
            Yn= Yn.ToUpper();
        } while (Yn == "Y");
        Console.WriteLine("Ban da tra loi dung {0}/{1} cau hoi",d,c);
    }
}