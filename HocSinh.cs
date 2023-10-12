using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test008
{
    public class HocSinh
    {
        //Khai bao thuoc tinh
        private int maHS;
        string tenHS; 
        int ns;
        string diaChi;
        double diemT, diemV, diemA, DTB;
        // Xay dung ham khoi tao doi tuong Constructor 1
        public HocSinh()
        {
        }
        //Xay dung ham Constructor 2
        public HocSinh(int ma, string ten, int ns, string diaChi)
        {
            this.maHS = maHS;
            this.tenHS = tenHS;
            this.ns = ns;
            this.diaChi = diaChi;
        }

        public int MaHS
        {
            get { return maHS; }
            set { maHS = value; }
        }

        public string TenHS
        {
            get { return tenHS; }
            set { tenHS = value; }
        }

        public int Ns
        {
            get { return ns; }
            set { ns = value; }
        }

        public String DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public double DiemT
        {
            get { return diemT; }
            set { diemT = value; }
        }

        public double DiemV
        {
            get { return diemV; }
            set { diemV = value; }
        }
        public double DiemA
        {
            get { return diemA; }
            set { diemA = value; }
        }


        public virtual void NhapHS()
        {
            Console.Write("Nhap ma HS: ");
            MaHS = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap ten hoc sinh: ");
            TenHS = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            ns = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            diemT = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem van: ");
            diemV = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem anh: ");
            diemA = Convert.ToDouble(Console.ReadLine());
        }
        // Viet ham tinh diem trung binh
        //NEu viet ham ghi de thi can them tu khoa virtual public virtual sniDouble
 
        public virtual Double TinhDTB()
        {
            DTB = Math.Round((diemA + diemT + diemV) / 3, 1);
            return DTB;
        }
        public virtual void XuatHS()
        {

           // Console.WriteLine("Thong tin sinh vien la: ");
           // Console.WriteLine("Ma HS | Ten HS | Nam Sinh | Dia Chi | DTB");
            Console.WriteLine( "      "+MaHS + "      " + TenHS + "      " + ns + "       "+ DiaChi + "        "+TinhDTB());
        }
    }
}
