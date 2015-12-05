using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopBanHang
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceNhapHang" in both code and config file together.
    [ServiceContract]
    public interface IServiceNhapHang
    {
        [OperationContract]
        List<WFNhapHang> All();

        [OperationContract]
        List<WFCTPhieuNhap> CTPhieuNhap(int mapn);

        [OperationContract]
        bool XoaPN(int masp);

        [OperationContract]
        bool ThemPN(DateTime ngay);

        [OperationContract]
        bool ThemCTPN(int mapn, int masp, int soluong);

        [OperationContract]
        WFNhapHang LayMaPN();

    }
}
