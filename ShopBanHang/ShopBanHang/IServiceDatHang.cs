using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopBanHang
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceDatHang" in both code and config file together.
    [ServiceContract]
    public interface IServiceDatHang
    {
        [OperationContract]
        bool insertHD(string IDUser, DateTime Ngay, decimal TriGiaDH, string matrangthai);

        [OperationContract]
        bool insertCTHD(int MaDonHang, int MaSP, int SoLuong, decimal Gia, decimal ThanhTien);

        [OperationContract]
        List<DonHang> All();

        [OperationContract]
        List<DonHang> DonHangTheoUser(string iduser);

        [OperationContract]
        List<DonHang> TimTheoNgay(DateTime ngay);

        [OperationContract]
        DonHang LayMaHD(string iduser);


        [OperationContract]
        bool LuuTrangThai(int MaDonHang, string matrangthai);

    }
}
