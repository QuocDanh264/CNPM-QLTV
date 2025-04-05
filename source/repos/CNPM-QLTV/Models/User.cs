using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_QLTV.Models
{
    internal class User
    {
        public int Id { get; set; }       // Id làm khóa chính
        public string Username { get; set; }  // Tên đăng nhập
        public string Password { get; set; }  // Mật khẩu (thường sẽ lưu dưới dạng hash)
        public string Email { get; set; }     // Địa chỉ email
    }
}
