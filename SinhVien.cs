using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class SinhVien
    {
        private int masv;
        private string hoten;
        private double diemlt, diemth;

        public int MaSV
        {
            get { return masv; }
            set
            {
                if (value > 0)
                    masv = value;
                else
                    masv = 1;
            }

        }
        public string HoTen
        {
            get { return hoten; }
            set
            {
                if(!string.IsNullOrEmpty(value))
                    hoten = value;
                else
                    hoten = "Le Hoai Phong";
            }
        }
        public double DiemLT
        {
            get { return diemlt; }
            set
            {
                if (value >= 0.0 && value <= 10.0)
                    diemlt = value;
                else
                    diemlt = 0.0;
            }
        }
        public double DiemTH
        {
            get { return diemth; }
            set
            {
                if (value >= 0.0 && value <= 10.0)
                    diemth = value;
                else
                    diemth = 0.0;
            }
        }
        public SinhVien()
        {
            MaSV = 1;
            HoTen = "Le Hoai Phong";
            DiemLT = 0.0;
            DiemTH = 0.0;
        }
        public SinhVien(int msv,string ht,double dlt,double dth)
        {
            MaSV = msv;
            HoTen = ht;
            DiemLT = dlt;
            DiemTH = dth;
        }
        public double DiemTrungBinh()
        {
            return (diemlt + diemth) / 2;
        }
        public override string ToString()
        {
            return string.Format("{0,-10}{1,-20}{2,-10}{3,-10}",masv,"|"+hoten,"|"+diemlt,"|"+diemth);
        }
        public void Input()
        {
            Console.WriteLine("Nhap ma sinh vien: ");
            MaSV = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten sinh vien: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap diem ly thuyet: ");
            DiemLT = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem thuc hanh: ");
            DiemTH = double.Parse(Console.ReadLine());
        }
    }
}
