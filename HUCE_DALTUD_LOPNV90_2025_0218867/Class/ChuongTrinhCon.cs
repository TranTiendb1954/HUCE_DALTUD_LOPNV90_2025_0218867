using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUCE_DALTUD_LOPNV90_2025_0218867.Class
{
    public class KetQuaCucBo
    {
        public bool Ben { get; set; }
        public bool OnDinhTongThe { get; set; }
        public bool OnDinhCucBo { get; set; }
        public double KNLechTam { get; set; }
        public string GhiChu { get; set; }
    }

    public class ChuongTrinhCon
    {
        public bool TinhToanBen(double N, double An, double f, double gamaC)
        {
            return N / An <= f * gamaC;
        }

        public bool TinhToanOnDinhTongThe(double N, double A, double f, double gamaC, double Lamda, double E)
        {
            double hsUonDoc = TinhPhiMin(Lamda, f, E);
            return N / (hsUonDoc * A) <= f * gamaC;
        }

        public bool TinhToanOnDinhCucBo(double hw, double tw, double Lamda, double f, double E, double bo, double tf)
        {
            double domanhquyuoc = Lamda * Math.Sqrt(f / E);
            double domanhgioihanchophep = TTDoManhGioiHan(Lamda, f, E);
            double doManhGHBanNho = (0.36 + 0.1 * domanhquyuoc) * Math.Sqrt(E / f);
            return hw / tw <= domanhgioihanchophep && bo / tf <= doManhGHBanNho;
        }

        public double TTDoManhGioiHan(double Lamda, double f, double E)
        {
            double domanhquyuoc = Lamda * Math.Sqrt(f / E);
            if (domanhquyuoc >= 2)
                return (1.2 + 0.35 * domanhquyuoc) * Math.Sqrt(E / f);
            else
                return (1.3 + 0.15 * Math.Pow(domanhquyuoc, 2)) * Math.Sqrt(E / f);
        }

        public double TTKhaNangChiuNenLechtam(double N, double f, double gamaC, double A, double Lamda, double E)
        {
            double KNTheoDKBen = A * f * gamaC;
            double hsUonDoc = TinhPhiMin(Lamda, f, E);
            double KNTheoOnDinhTongThe = hsUonDoc * A * f * gamaC;
            return Math.Min(KNTheoDKBen, KNTheoOnDinhTongThe);
        }

        public double DoManh(double tBanCanh, double tBanBung, double hBanCanh, double hBanBung)
        {
            double Ix = (hBanCanh * Math.Pow((hBanBung + 2 * tBanCanh), 3) - (hBanCanh - hBanBung) * Math.Pow(hBanBung, 3)) / 12;
            double Iy = (2 * tBanCanh * Math.Pow(hBanCanh, 3) + hBanBung * Math.Pow(tBanBung, 3)) / 12;
            double A = 2 * (tBanCanh * hBanCanh) + (tBanBung * hBanBung);
            return Math.Max(Math.Sqrt(Ix / A), Math.Sqrt(Iy / A));
        }

        public double TinhPhiMin(double Lamda, double f, double E)
        {
            double domanhquyuoc = Lamda * Math.Sqrt(f / E);
            if (domanhquyuoc > 0 && domanhquyuoc <= 2.5)
                return 1 - (0.073 - 5.53 * f / E);
            else if (domanhquyuoc <= 4.5)
                return 1.47 - 13 * f / E - (0.371 - 27.3 * f / E) * domanhquyuoc + (0.0275 - 5.53 * f / E) * Math.Pow(domanhquyuoc, 2);
            else
                return 332 / Math.Pow(domanhquyuoc, 2) * (51 - domanhquyuoc);
        }
        #region tổ hợp
        ///// <summary>
        ///// Tính toán cho một cột tổ hợp, tính cả mặt cắt chân và đỉnh
        ///// </summary>
        //public KetQuaCucBo TinhToanCotToHop(
        //    double N_Chan, double N_Dinh,
        //    double An_Chan, double An_Dinh,
        //    double f, double gamaC,
        //    double Lamda_Chan, double Lamda_Dinh,
        //    double E,
        //    double hw, double tw, double bo, double tf)
        //{
        //    // Điều kiện bền
        //    bool Ben_Chan = TinhToanBen(N_Chan, An_Chan, f, gamaC);
        //    bool Ben_Dinh = TinhToanBen(N_Dinh, An_Dinh, f, gamaC);
        //    bool Ben_Cuoi = Ben_Chan && Ben_Dinh;

        //    // Ổn định tổng thể
        //    bool OnDinh_Chan = TinhToanOnDinhTongThe(N_Chan, An_Chan, f, gamaC, Lamda_Chan, E);
        //    bool OnDinh_Dinh = TinhToanOnDinhTongThe(N_Dinh, An_Dinh, f, gamaC, Lamda_Dinh, E);
        //    bool OnDinh_Cuoi = OnDinh_Chan && OnDinh_Dinh;

        //    // Ổn định cục bộ (giữ nguyên 1 lần, theo chân)
        //    bool OnDinhCucBo = TinhToanOnDinhCucBo(hw, tw, Lamda_Chan, f, E, bo, tf);

        //    // Khả năng chịu nén lệch tâm tối thiểu
        //    double KNLechTam_Min = Math.Min(
        //        TTKhaNangChiuNenLechtam(N_Chan, f, gamaC, An_Chan, Lamda_Chan, E),
        //        TTKhaNangChiuNenLechtam(N_Dinh, f, gamaC, An_Dinh, Lamda_Dinh, E)
        //    );

        //    // Tổng hợp kết quả
        //    return new KetQuaCucBo
        //    {
        //        Ben = Ben_Cuoi,
        //        OnDinhTongThe = OnDinh_Cuoi,
        //        OnDinhCucBo = OnDinhCucBo,
        //        KNLechTam = KNLechTam_Min,
        //        GhiChu = $"Chân: Ben={Ben_Chan}, OnDinh={OnDinh_Chan}; Đỉnh: Ben={Ben_Dinh}, OnDinh={OnDinh_Dinh}"
        //    };
        //}
        #endregion

        # region Tính toán cho một cột tổ hợp, tính cả mặt cắt chân và đỉnh        

        public KetQuaCucBo TinhToanCotToHop(
            double N_Chan, double N_Dinh,     // Lực nén tại chân và đỉnh
            double An_Chan, double An_Dinh,   // Diện tích tiết diện tại chân và đỉnh
            double f, double gamaC,
            double Lamda_Chan, double Lamda_Dinh, // Hệ số độ mảnh tại chân và đỉnh
            double E,
            double hw, double tw, double bo, double tf) // Kích thước mặt cắt
        {
            // Tính điều kiện bền
            bool Ben_Chan = TinhToanBen(N_Chan, An_Chan, f, gamaC);
            bool Ben_Dinh = TinhToanBen(N_Dinh, An_Dinh, f, gamaC);
            bool Ben_Cuoi = Ben_Chan && Ben_Dinh;

            // Tính ổn định tổng thể
            bool OnDinh_Chan = TinhToanOnDinhTongThe(N_Chan, An_Chan, f, gamaC, Lamda_Chan, E);
            bool OnDinh_Dinh = TinhToanOnDinhTongThe(N_Dinh, An_Dinh, f, gamaC, Lamda_Dinh, E);
            bool OnDinh_Cuoi = OnDinh_Chan && OnDinh_Dinh;

            // Tính ổn định cục bộ (theo tiết diện)
            bool OnDinhCucBo = TinhToanOnDinhCucBo(hw, tw, Lamda_Chan, f, E, bo, tf);

            // Tính khả năng chịu nén lệch tâm tối thiểu
            double KNLechTam_Chan = TTKhaNangChiuNenLechtam(N_Chan, f, gamaC, An_Chan, Lamda_Chan, E);
            double KNLechTam_Dinh = TTKhaNangChiuNenLechtam(N_Dinh, f, gamaC, An_Dinh, Lamda_Dinh, E);
            double KNLechTam_Min = Math.Min(KNLechTam_Chan, KNLechTam_Dinh);

            // Tổng hợp kết quả
            KetQuaCucBo ketQua = new KetQuaCucBo
            {
                Ben = Ben_Cuoi,
                OnDinhTongThe = OnDinh_Cuoi,
                OnDinhCucBo = OnDinhCucBo,
                KNLechTam = KNLechTam_Min,
                GhiChu = $"Chân: Ben={Ben_Chan}, OnDinh={OnDinh_Chan}; Đỉnh: Ben={Ben_Dinh}, OnDinh={OnDinh_Dinh}"
            };

            return ketQua;
            #endregion
        }
    }
}
