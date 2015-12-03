using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopBanHang
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceUser" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceUser.svc or ServiceUser.svc.cs at the Solution Explorer and start debugging.
    public class ServiceUser : IServiceUser
    {
        private ShopEntities db = new ShopEntities();

        public bool Login(string username, string password)
        {
            try
            {
                bool abc = db.Users.Any(user => user.IDUser == username && user.PassUser == password);
                return abc;
            }
            catch
            {
                return false;
            }
        }

        public User TimEDitUser(string IDUser)
        {
            return this.db.Users.Single(sp => sp.IDUser == IDUser);
        }

        public bool KTraUser(string IDUser)
        {
            try
            {
                bool userValid = db.Users.Any(user => user.IDUser == IDUser);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<User> All()
        {
            return this.db.Users.ToList();
        }

        public bool AddUser(string IDUser, string PassUser, string HoTenUser, string Email, string DiaChi, string SoDienThoai, string NgaySinh, int quyen)
        {
            try
            {
                User usr = new User();
                usr.IDUser = IDUser;
                usr.PassUser = PassUser;
                usr.HoTenUser = HoTenUser;
                usr.Email = Email;
                usr.DiaChi = DiaChi;
                usr.SoDienThoai = SoDienThoai;
                usr.Ngaysinh = NgaySinh;
                usr.Quyen = quyen;
                db.Users.Add(usr);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditUser(string userht, string IDUser, string PassUser, string HoTenUser, string Email, string DiaChi, string SoDienThoai, string NgaySinh)
        {
            try
            {
                User usr = db.Users.First(p => p.IDUser.Trim() == userht);
                usr.PassUser = PassUser;
                usr.HoTenUser = HoTenUser;
                usr.Email = Email;
                usr.DiaChi = DiaChi;
                usr.SoDienThoai = SoDienThoai;
                usr.Ngaysinh = NgaySinh;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaUser(string IDUser)
        {
            try
            {
                User tv = db.Users.SingleOrDefault(p => p.IDUser.Contains(IDUser));
                db.Users.Remove(tv);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
