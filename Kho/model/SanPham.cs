using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1.model
{
    internal class SanPham
    {
            [Key]
            public String maSanPham { get; set; }
            public String tenSanPham { get; set; }
            public decimal donGiaBan { get; set; }
            public String maNhaCC { get; set; }
            public int soLuongTon { get; set; }
            public decimal donGiaNhap { get; set; }

    }
}
