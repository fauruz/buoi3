using bai2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien ts = new SinhVien();
            ts.Input();
            Console.WriteLine(string.Format("{0,-10}{1,-20}{2,-10}{3,-10}", "Ma sv", "|Ho va ten", "|Diem lt", "|Diem th"));
            SinhVien td = new SinhVien(1,"Le Hoai Phong",7.9,8.7);
            SinhVien tv = new SinhVien(3, "Ho Nguyen Gia Huy", 9.3, 6.7);
            Console.WriteLine("{0}", td);
            Console.WriteLine("{0}", tv);
            Console.WriteLine("{0}", ts);
            Console.ReadLine();
        }

    }
}