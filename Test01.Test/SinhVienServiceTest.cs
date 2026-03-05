namespace Test01.Test;

public class SinhVienServiceTest
{
    private SinhVienService _sinhVienService;
    [SetUp]
    public void Setup()
    {
        _sinhVienService = new SinhVienService();
    }

    [Test]
    public void KiemTraMaTonTai_False()
    {
        Assert.That(_sinhVienService.KiemTraSinhVienTonTai("SV003"), Is.False);
    }
    [Test]
    public void SuaSinhVien_ThanhCong()
    {
        var sinhVienMoi = new SinhVien() { maSV = "SV001", Ten = "Nguyen Van A", Tuoi = 20, diemTB = 7.5f, kyHoc = 4, chuyenNghanh = "CNTT" };
        var result = _sinhVienService.SuaSinhVien(sinhVienMoi);
        Assert.That(result, Is.True);
    }
        [Test]
        public void SuaSinhVien_KhongTonTai()
        {
            var sinhVienMoi = new SinhVien() { maSV = "SV003", Ten = "Nguyen Van C", Tuoi = 22, diemTB = 6.5f, kyHoc = 3, chuyenNghanh = "Dien Tu" };
            var result = _sinhVienService.SuaSinhVien(sinhVienMoi);
            Assert.That(result, Is.False);
    }
    [Test]
    public void SuaSinhVien_TenRong()
    {
        var sinhVienMoi = new SinhVien() { maSV = "SV001", Ten = "", Tuoi = 19, diemTB = 8.0f, kyHoc = 2, chuyenNghanh = "An Toan Thong Tin" };
        var result = _sinhVienService.SuaSinhVien(sinhVienMoi);
        Assert.That(result, Is.False);
    }
}
