using NUnit.Framework;

namespace Test01.Test;

public class TinhTongTest
{
    private TinhTong _tinhTong;
    [SetUp]
    public void Setup()
    {
        _tinhTong = new TinhTong();
    }

    [Test]
    public void TinhTong_MangDuong()
    {
        int[] n = { 1, 2, 3};
        int result = _tinhTong.TinhTongCacSo(n);
        Assert.That(result, Is.EqualTo(6));
    }
    [Test]
    public void TinhTong_MangAm()
    {
        int[] n = { -1, -2, -3 };
        int result = _tinhTong.TinhTongCacSo(n);
        Assert.That(result, Is.EqualTo(-6));

    }
    [Test]
    public void TinhTong_MangRong()
    {
        int[] n = { };
        int result = _tinhTong.TinhTongCacSo(n);
        Assert.That(result, Is.EqualTo(0));
    }
    [Test]
    public void TinhTong_MangMotPhanTu()
    {
        int[] n = { 10 };
        int result = _tinhTong.TinhTongCacSo(n);
        Assert.That(result, Is.EqualTo(10));
    }
}
