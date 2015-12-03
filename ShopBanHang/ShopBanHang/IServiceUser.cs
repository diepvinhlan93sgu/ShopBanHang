using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopBanHang
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceUser" in both code and config file together.
    [ServiceContract]
    public interface IServiceUser
    {
        [OperationContract]
        bool Login(string username, string password);

        [OperationContract]
        List<User> All();

        [OperationContract]
        bool KTraUser(string IDUser);

        [OperationContract]
        bool AddUser(string IDUser, string PassUser, string HoTenUser, string Email, string DiaChi, string SoDienThoai, string NgaySinh, int quyen);

        [OperationContract]
        User TimEDitUser(string IDUser);

        [OperationContract]
        bool EditUser(string userht, string IDUser, string PassUser, string HoTenUser, string Email, string DiaChi, string SoDienThoai, string NgaySinh);

        [OperationContract]
        bool XoaUser(string IDUser);
    }
}
