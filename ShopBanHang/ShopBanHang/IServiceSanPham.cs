using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopBanHang
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceSanPham" in both code and config file together.
    [ServiceContract]
    public interface IServiceSanPham
    {
        [OperationContract]
        List<SanPham> All();

        [OperationContract]
        SanPham ChiTietSP(int masp);

        [OperationContract]
        List<SanPham> SanPhamTheoLoai(string loai);


        [OperationContract]
        List<SanPham> TimKiem(string loai);

        [OperationContract]
        bool XoaSanPham(int masp);


        [OperationContract]
        bool SuaSanPham(int maspht, int masp, string tensp, string madm, decimal gia, string mota, string kichthuoc, string mausac, string hinhanh, string soluong, int trangthai);

        [OperationContract]
        bool ThemSanPham(int masp, string tensp, string madm, decimal gia, string mota, string kichthuoc, string mausac, string hinhanh, string soluong);
    }
}
