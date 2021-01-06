using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class SanPham
    {
        public int Id { get; set; }
        public string Tensp { get; set; }
        public string Hang { get; set; }
        public int Gia { get; set; }
    }
}
