using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    public class SinhVienService
    {
        private List<SinhVien> _sinhViens = new List<SinhVien>()
        {
        new SinhVien() { maSV = "SV001", Ten = "Nguyen Van A", Tuoi = 20, diemTB = 7.5f, kyHoc = 4, chuyenNghanh = "CNTT" },
        new SinhVien() { maSV = "SV002", Ten = "Le Thi B", Tuoi = 21, diemTB = 8.0f, kyHoc = 5, chuyenNghanh = "Kinh Te" },
        };
        public bool KiemTraSinhVienTonTai(string maSV)
        {
            return _sinhViens.Any(sv => sv.maSV == maSV);
        }
        public bool SuaSinhVien(SinhVien sinhVienMoi)
        {
            if (sinhVienMoi == null)
            {
                return false;
            }
            //validate ko để trống:
            if (string.IsNullOrEmpty(sinhVienMoi.maSV) || string.IsNullOrEmpty(sinhVienMoi.Ten) || string.IsNullOrEmpty(sinhVienMoi.chuyenNghanh))
            {
                return false;
            }
            var sv = _sinhViens.FirstOrDefault(s => s.maSV == sinhVienMoi.maSV);
            if (sv == null)
            {
                return false;
            }
            sv.Ten = sinhVienMoi.Ten;
            sv.Tuoi = sinhVienMoi.Tuoi;
            sv.diemTB = sinhVienMoi.diemTB;
            sv.kyHoc = sinhVienMoi.kyHoc;
            sv.chuyenNghanh = sinhVienMoi.chuyenNghanh;
            return true;

        }
        public SinhVien GetByMaSV(string ma)
        {
            return _sinhViens.FirstOrDefault(sv => sv.maSV == ma);
        }
    }
}
