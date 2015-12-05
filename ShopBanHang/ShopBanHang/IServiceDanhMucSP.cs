using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopBanHang
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceDanhMucSP" in both code and config file together.
    [ServiceContract]
    public interface IServiceDanhMucSP
    {
        [OperationContract]
        List<DanhMucSP> All();

        [OperationContract]
        bool ThemDanhmuc(string madm, string tendm);

        [OperationContract]
        bool SuaDanhmuc(string dmht, string madm, string tendm);

        [OperationContract]
        bool XoaDanhmuc(string IDUser);
    }
}
