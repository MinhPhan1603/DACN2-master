using DACN2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DACN2.Controllers
{
    public class NhanVienController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();
        // GET: NhanVien
        public ActionResult Index()
        {
            return View();
        }
       /* public ActionResult ListChang()
        {

            
            
            var sptl = from ss in data.Changs select ss;
            List<Chang> changs = data.Changs.Where(s => s.GiaChang != null ).ToList();
            

            if (changs.Count > 0)   
            {
                for (int i = 0; i < changs.Count; i++)
                {
                    Chang chang = data.Changs.FirstOrDefault(s => s.MaChang == changs[i].MaChang);
       

                    if (chang != null)
                    {
                        decimal tongTien = 0;
                        List<LichTrinh> lichTrinhs = data.LichTrinhs.Where(s => s.MaChang == chang.MaChang ).ToList();
                        if (lichTrinhs.Count > 0)
                        {

                            for (int j = 0; j < lichTrinhs.Count; j++)
                            {

                                LichTrinh lichTrinh = data.LichTrinhs.FirstOrDefault(s => s.MaLichTrinh == lichTrinhs[j].MaLichTrinh && s.GiaLichTrinh != null);
                                if (lichTrinh != null)
                                {
                                    tongTien += (decimal)lichTrinh.GiaLichTrinh;
                                }

                                if (tongTien > 0)
                                {
                                    chang.GiaChang = tongTien;
                                    UpdateModel(chang);
                                    data.SubmitChanges();
                                }
                            }
                            
                        }
                    }
                }
            }

            return PartialView(sptl);

        }*/
        
      /*  public ActionResult ListTour()
        {
            

            var sptl = from ss in data.Tours select ss;

            List<Tour> tours = data.Tours.Where(s => s.Gia != null ).ToList();
            if (tours.Count > 0)
            {
                for (int i = 0; i < tours.Count; i++)
                {

                    Tour Tour = data.Tours.FirstOrDefault(s => s.ID == tours[i].ID);
                    decimal tongTien = 0;
                    decimal TongTienLoi = 0;
                    if (Tour != null)
                    {

                      
                        List<Chang> Changs = data.Changs.Where(s => s.ID == Tour.ID).ToList();
                        if (Changs.Count > 0)
                        {

                            for (int j = 0; j < Changs.Count; j++)
                            {

                                Chang chang = data.Changs.FirstOrDefault(s => s.ID == Changs[j].ID && s.GiaChang != null);
                                if (chang != null)
                                {
                                    tongTien += (decimal)chang.GiaChang;
                                }
                                if (tongTien > 0)
                                {
                                    Tour.TongChang = tongTien;
                                    Tour.LoiNhuan = (decimal)(Tour.Gia - Tour.TongChang);
                                    TongTienLoi = tours.Sum(s => s.LoiNhuan);
                                    UpdateModel(Tour);
                                    data.SubmitChanges();
                                    ViewBag.tongtien = TongTienLoi;
                                }
                            }
                        }
                    }
                }
            }
            
            

            return PartialView(sptl);

        }
      */
        public ActionResult Edit(int id)
        {


            var D_tour = data.Tours.FirstOrDefault(m => m.MaTour == id);

            /*D_tour.LoaiTours = data.LoaiTours.ToList();
            D_tour.LoaiKsan = data.KSans.ToList();
            D_tour.HuongDanViens = data.NhanViens.ToList();
            D_tour.MayBays = data.PhuongTiens.ToList();
            D_tour.DiaDiems = data.DiaDiems.ToList();
            D_tour.LichTrinhs = data.LichTrinhs.ToList();*/
            return View(D_tour);
        }
        [HttpPost]
        public ActionResult Edit(FormCollection collection, int id)
        {

            /*s.LoaiTours = data.LoaiTours.ToList();*/
            var D_tour = data.Tours.First(m => m.MaTour == id);
            /*            D_tour.LoaiTours = data.LoaiTours.ToList();
                        D_tour.LoaiKsan = data.KSans.ToList();
                        D_tour.HuongDanViens = data.HuongDanViens.ToList();
                        D_tour.MayBays = data.MayBays.ToList();
                        D_tour.DiaDiems = data.DiaDiems.ToList();
                        D_tour.LichTrinhs = data.LichTrinhs.ToList();*/
            var E_TenTour = collection["TenTour"];
            var E_Gia = Convert.ToDecimal(collection["Gia"]);
            var E_NgayKhoiHanh = Convert.ToDateTime(collection["NgayKhoiHanh"]);
            var E_NgayKetThuc = Convert.ToDateTime(collection["NgayKetThuc"]);
            var E_SoCho = Convert.ToInt32(collection["SoCho"]);
            var E_NoiDung = collection["NoiDung"];
            var E_ChiTietTour = collection["ChiTietTour"];
            var E_MaLoaiTour = int.Parse(Request.Form["MaLoaiTour"]);
            var E_MaKS = int.Parse(collection["MaKS"]);
            var E_MaTour = collection["MaTour"];
            var E_Hinh = collection["Hinh"];
            var E_MaDiaDiem = Convert.ToInt32(collection["MaDiaDiem"]);
            var E_MaMayBay = Convert.ToInt32(collection["MaMayBay"]);
            var E_IDHDV = Convert.ToInt32(collection["MaNV"]);
            /*--------*/
            var E_NoiKhoiHanh = collection["NoiKhoiHanh"];
            var E_MaLichTrinh = int.Parse(Request.Form["MaLichTrinh"]);
            var E_GiaNguoiLon = Convert.ToDecimal(collection["GiaNguoiLon"]);
            var E_GiaTreEm = Convert.ToDecimal(collection["GiaTreEm"]);
            var E_ThoiGian = collection["ThoiGian"];
            var E_Hinh2 = collection["Hinh2"];
            var E_Hinh3 = collection["Hinh3"];
            /*            var E_Hinh4 = collection["Hinh4"];*/
            D_tour.MaTour = id;

            if (string.IsNullOrEmpty(E_TenTour))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                D_tour.TenTour = E_TenTour.ToString();
                D_tour.Gia = E_Gia;
               /* D_tour.NgayKhoiHanh = E_NgayKhoiHanh;
                D_tour.NgayKetThuc = E_NgayKetThuc;*/
                D_tour.SoCho = E_SoCho;
                D_tour.NoiDung = E_NoiDung.ToString();

                D_tour.MaLoaiTour = E_MaLoaiTour;

                D_tour.Hinh = E_Hinh.ToString();
                /*               D_tour.MaKS = E_MaKS;
                                D_tour.MaDiaDiem = E_MaDiaDiem;
                                D_tour.MaMayBay = E_MaMayBay;*/
                D_tour.MaNV = E_IDHDV;
                /*--------*/
                D_tour.NoiKhoiHanh = E_NoiKhoiHanh.ToString();
                /*D_tour.MaLichTrinh = E_MaLichTrinh;*/
                D_tour.GiaNguoiLon = E_GiaNguoiLon;
                D_tour.GiaTreEm = E_GiaTreEm;
                D_tour.ThoiGian = E_ThoiGian.ToString();
                D_tour.Hinh2 = E_Hinh2.ToString();
                D_tour.Hinh3 = E_Hinh3.ToString();
                /*D_tour.Hinh4 = E_Hinh4.ToString();*/

                UpdateModel(D_tour);


                data.SubmitChanges();
                return RedirectToAction("Index");
            }

            return this.Edit(id);
        }
        public ActionResult Delete(int id)
        {
            var D_tour = data.Tours.First(m => m.MaTour == id);
            return View(D_tour);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var D_giay = data.Tours.Where(m => m.MaTour == id).First();
            data.Tours.DeleteOnSubmit(D_giay);
            data.SubmitChanges();
            return RedirectToAction("Index");
        }




        /*------------------------------------------*/
        /* private decimal TongTien()
         {
             decimal tt = 0;
             List<LichTrinh> lst = new List<LichTrinh>();

             tt = (decimal)lst.Sum(n => n.PhuongTien.GiaPT);

             return tt;


         }*/
        /* public ActionResult ListLichTrinh()
         {
             ViewBag.Tongtien = TongTien();
             var sptl = from ss in data.LichTrinhs select ss;
             return PartialView(sptl);

         }*/
        /*-----------------------------*/

  /*      public ActionResult ListPhuongTien()
        {
            var sptl = from ss in data.PhuongTiens select ss;
            return PartialView(sptl);

        }
        *//*CREATE PHUONG TIEN *//*
        public ActionResult CreatePhuongTien()
        {

            return View();

        }
        [HttpPost]
        public ActionResult CreatePhuongTien(FormCollection collection, PhuongTien s)
        {


            var E_TenPhuongTien = collection["TenPhuognTien"];
            var E_GiaPT = Convert.ToDecimal(collection["GiaPT"]);
            var E_GioDi = Convert.ToDateTime(collection["GioDi"]);
            var E_GioDen = Convert.ToDateTime(collection["GioDen"]);


            if (string.IsNullOrEmpty(E_TenPhuongTien))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                s.TenPhuongTien = E_TenPhuongTien.ToString();
                s.GiaPT = E_GiaPT;
                s.GioDi = E_GioDi;
                s.GioDen = E_GioDen;

                data.PhuongTiens.InsertOnSubmit(s);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }

            return this.CreatePhuongTien();
        }


        *//*EDIT PHUONG TIEN*//*
        public ActionResult EditPhuongTien(int id)
        {


            var D_PT = data.PhuongTiens.FirstOrDefault(m => m.MaPhuongTien == id);
            return View(D_PT);
        }

        [HttpPost]
        public ActionResult EditPhuongTien(FormCollection collection, int id)
        {


            var D_PT = data.PhuongTiens.First(m => m.MaPhuongTien == id);

            var E_TenPhuongTien = collection["TenPhuongTien"];
            var E_GiaPT = Convert.ToDecimal(collection["GiaPT"]);
            var E_GioDi = Convert.ToDateTime(collection["GioDi"]);
            var E_GioDen = Convert.ToDateTime(collection["GioDen"]);

            D_PT.MaPhuongTien = id;

            if (string.IsNullOrEmpty(E_TenPhuongTien))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                D_PT.TenPhuongTien = E_TenPhuongTien.ToString();
                D_PT.GiaPT = E_GiaPT;
                D_PT.GioDi = E_GioDi;
                D_PT.GioDen = E_GioDen;


                UpdateModel(D_PT);


                data.SubmitChanges();
                return RedirectToAction("Index");
            }

            return this.EditPhuongTien(id);
        }

        *//*DELETE PHUONG TIEN*//*
        public ActionResult DeletePhuongTien(int id)
        {
            var D_tour = data.PhuongTiens.First(m => m.MaPhuongTien == id);
            return View(D_tour);
        }
        [HttpPost]
        public ActionResult DeletePhuongTien(int id, FormCollection collection)
        {
            var D_giay = data.PhuongTiens.Where(m => m.MaPhuongTien == id).First();
            data.PhuongTiens.DeleteOnSubmit(D_giay);
            data.SubmitChanges();
            return RedirectToAction("Index");
        }




        *//*-----------------------------*//*

        public ActionResult ListDiaDiem()
        {
            var sptl = from ss in data.DiaDiems select ss;
            return PartialView(sptl);

        }
        *//*CREATE ĐIA DIEM *//*
        public ActionResult CreateDiaDiem()
        {

            return View();

        }
        [HttpPost]
        public ActionResult CreateDiaDiem(FormCollection collection, DiaDiem s)
        {


            var E_TenDiaDiem = collection["TenDiaDiem"];
            var E_GiaDD = Convert.ToDecimal(collection["ChiPhiDD"]);



            if (string.IsNullOrEmpty(E_TenDiaDiem))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                s.TenDiaDiem = E_TenDiaDiem.ToString();
                s.ChiPhiDD = E_GiaDD;

                data.DiaDiems.InsertOnSubmit(s);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }

            return this.CreateDiaDiem();
        }

        *//*EDIT DIA DIEM*//*
        public ActionResult EditDiaDiem(int id)
        {


            var D_PT = data.DiaDiems.FirstOrDefault(m => m.MaDiaDiem == id);
            return View(D_PT);
        }

        [HttpPost]
        public ActionResult EditDiaDiem(FormCollection collection, int id)
        {


            var D_PT = data.DiaDiems.First(m => m.MaDiaDiem == id);

            var E_TenDiaDiem = collection["TenDiaDiem"];
            var E_GiaDD = Convert.ToDecimal(collection["ChiPhiDD"]);


            D_PT.MaDiaDiem = id;

            if (string.IsNullOrEmpty(E_TenDiaDiem))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                D_PT.TenDiaDiem = E_TenDiaDiem.ToString();
                D_PT.ChiPhiDD = E_GiaDD;



                UpdateModel(D_PT);


                data.SubmitChanges();
                return RedirectToAction("Index");
            }

            return this.EditDiaDiem(id);
        }

        *//*DELETE DIADIEM*//*
        public ActionResult DeleteDiaDiem(int id)
        {
            var D_tour = data.DiaDiems.First(m => m.MaDiaDiem == id);
            return View(D_tour);
        }
        [HttpPost]
        public ActionResult DeleteDiaDiem(int id, FormCollection collection)
        {
            var D_giay = data.DiaDiems.Where(m => m.MaDiaDiem == id).First();
            data.DiaDiems.DeleteOnSubmit(D_giay);
            data.SubmitChanges();
            return RedirectToAction("Index");
        }



        *//*-----------------------------*//*

        public ActionResult ListAnUong()
        {
            var sptl = from ss in data.AnUongs select ss;
            return PartialView(sptl);

        }


        *//*CREATE AnUong *//*
        public ActionResult CreateAnUong()
        {

            return View();

        }
        [HttpPost]
        public ActionResult CreateAnUong(FormCollection collection, AnUong s)
        {


            var E_TenBuaAn = collection["TenBuaAn"];
            var E_ChiPhi = Convert.ToDecimal(collection["ChiPhi"]);
            var E_DiaDiemAnUong = collection["DiaDiemAnUong"];


            if (string.IsNullOrEmpty(E_TenBuaAn))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                s.TenBuaAn = E_TenBuaAn.ToString();
                s.ChiPhi = E_ChiPhi;
                s.DiaDiemAnUong = E_DiaDiemAnUong.ToString();

                data.AnUongs.InsertOnSubmit(s);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }

            return this.CreateAnUong();
        }

        *//*EDIT An Uong*//*
        public ActionResult EditAnUong(int id)
        {


            var D_PT = data.AnUongs.FirstOrDefault(m => m.MaAnUong == id);
            return View(D_PT);
        }

        [HttpPost]
        public ActionResult EditAnUong(FormCollection collection, int id)
        {


            var D_PT = data.AnUongs.First(m => m.MaAnUong == id);

            var E_TenBuaAn = collection["TenBuaAn"];
            var E_ChiPhi = Convert.ToDecimal(collection["ChiPhi"]);
            var E_DiaDiemAnUong = collection["DiaDiemAnUong"];


            D_PT.MaAnUong = id;

            if (string.IsNullOrEmpty(E_TenBuaAn))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                D_PT.TenBuaAn = E_TenBuaAn.ToString();
                D_PT.ChiPhi = E_ChiPhi;
                D_PT.DiaDiemAnUong = E_DiaDiemAnUong.ToString();


                UpdateModel(D_PT);


                data.SubmitChanges();
                return RedirectToAction("Index");
            }

            return this.EditAnUong(id);
        }

        *//*DELETE An Uong*//*
        public ActionResult DeleteAnUong(int id)
        {
            var D_tour = data.AnUongs.First(m => m.MaAnUong == id);
            return View(D_tour);
        }
        [HttpPost]
        public ActionResult DeleteAnUong(int id, FormCollection collection)
        {
            var D_giay = data.AnUongs.Where(m => m.MaAnUong == id).First();
            data.AnUongs.DeleteOnSubmit(D_giay);
            data.SubmitChanges();
            return RedirectToAction("Index");
        }




        *//*-----------------------------*//*
        public ActionResult ListKhachSan()
        {
            var sptl = from ss in data.KSans select ss;
            return PartialView(sptl);

        }
        *//*CREATE KS *//*
        public ActionResult CreateKS()
        {

            return View();

        }
        [HttpPost]
        public ActionResult CreateKS(FormCollection collection, KSan s)
        {


            var E_TenKS = collection["TenKS"];
            var E_DiaChi = collection["Dia Chi"];
            var E_sao = collection["Sao"];
            var E_GiaKS = Convert.ToDecimal(collection["Gia KS"]);
            var E_PhuThuPD = Convert.ToDecimal(collection["Phu Thu PD"]);


            if (string.IsNullOrEmpty(E_TenKS))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                s.TenKhachSan = E_TenKS.ToString();
                s.Diachi = E_DiaChi.ToString();
                s.Sao = E_sao.ToString();
                s.GiaKS = E_GiaKS;


                data.KSans.InsertOnSubmit(s);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }

            return this.CreateKS();
        }

        *//*EDIT KS*//*
        public ActionResult EditKS(int id)
        {


            var D_PT = data.KSans.FirstOrDefault(m => m.MaKS == id);
            return View(D_PT);
        }

        [HttpPost]
        public ActionResult EditKS(FormCollection collection, int id)
        {


            var D_PT = data.KSans.First(m => m.MaKS == id);

            var E_TenKS = collection["TenKS"];
            var E_DiaChi = collection["Dia Chi"];
            var E_sao = collection["Sao"];
            var E_GiaKS = Convert.ToDecimal(collection["Gia KS"]);
            var E_PhuThuPD = Convert.ToDecimal(collection["Phu Thu PD"]);

            D_PT.MaKS = id;

            if (string.IsNullOrEmpty(E_TenKS))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                D_PT.TenKhachSan = E_TenKS.ToString();
                D_PT.Diachi = E_DiaChi.ToString();
                D_PT.Sao = E_sao.ToString();
                D_PT.GiaKS = E_GiaKS;
                D_PT.PhuThuPhongDon = E_PhuThuPD;


                UpdateModel(D_PT);


                data.SubmitChanges();
                return RedirectToAction("Index");
            }

            return this.EditKS(id);
        }

        *//*DELETE KS*//*
        public ActionResult DeleteKS(int id)
        {
            var D_tour = data.KSans.First(m => m.MaKS == id);
            return View(D_tour);
        }
        [HttpPost]
        public ActionResult DeleteKS(int id, FormCollection collection)
        {
            var D_giay = data.KSans.Where(m => m.MaKS == id).First();
            data.KSans.DeleteOnSubmit(D_giay);
            data.SubmitChanges();
            return RedirectToAction("Index");
        }


        *//*-----------------------------*//*
        public ActionResult ListNguoiDiTour(int id)
        {
            var sptl = from ss in data.NguoiDiTours where ss.ChiTietDatTour.ID == id select ss;
            return PartialView(sptl);

        }
        public ActionResult ListDatTour()
        {
            var sptl = from ss in data.DatTours select ss;
            return PartialView(sptl);

        }*/
        /*------------------------------------------------------------*/
        public ActionResult ListKhachHang()
        {
            var sptl = from ss in data.KhachHangs select ss;
            return PartialView(sptl);

        }
        public ActionResult CreateKhachHang()
        {
           KhachHang KhachHang = new KhachHang();
           
            return View(KhachHang);

        }

        [HttpPost]
        public ActionResult CreateKhachHang(FormCollection collection, KhachHang s)
        {

            
            var E_Ten = collection["Ten"];
            var E_SDT = Convert.ToInt32(collection["SDT"]);
            var E_TenDangNhap = collection["TenDangNhap"];
            var E_Email = collection["Email"];
            var E_DiaChi = collection["DiaChi"];
            var E_CMND = Convert.ToInt32(collection["CMND"]);
            var E_MatKhau = collection["MatKhau"];
            if (string.IsNullOrEmpty(E_Ten))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                s.Ten = E_Ten.ToString();
                s.SDT = E_SDT;
                s.Email = E_Email.ToString();
                s.MatKhau = E_MatKhau.ToString();
                s.TenDangNhap = E_TenDangNhap.ToString();
                s.CMND = E_CMND;
                s.DiaChi = E_DiaChi.ToString();
                data.KhachHangs.InsertOnSubmit(s);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }

            return this.CreateKhachHang();
        }

        public ActionResult EditKhachHang(int id)
        {


            var D_PT = data.KhachHangs.FirstOrDefault(m => m.MaKhachHang == id);
            return View(D_PT);
        }

        [HttpPost]
        public ActionResult EditKhachHang(FormCollection collection, int id, KhachHang s)
        {

            var D_PT = data.KhachHangs.First(m => m.MaKhachHang == id);
            var E_Ten = collection["Ten"];
            var E_SDT = Convert.ToInt32(collection["SDT"]);
            var E_TenDangNhap = collection["TenDangNhap"];
            var E_Email = collection["Email"];
            var E_DiaChi = collection["DiaChi"];
            var E_CMND = Convert.ToInt32(collection["CMND"]);
            var E_MatKhau = collection["MatKhau"];

            if (string.IsNullOrEmpty(E_Ten))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                D_PT.Ten = E_Ten.ToString();

                D_PT.SDT = E_SDT;
                D_PT.TenDangNhap = E_TenDangNhap.ToString();
                D_PT.Email = E_Email.ToString();
                D_PT.MatKhau = E_MatKhau.ToString();
                D_PT.DiaChi = E_DiaChi.ToString();
                D_PT.CMND = E_CMND;


                UpdateModel(D_PT);


                data.SubmitChanges();
                return RedirectToAction("Index");
            }

            return this.EditKhachHang(id);
        }

        public ActionResult DeleteKhachHang(int id)
        {
            var D_tour = data.KhachHangs.First(m => m.MaKhachHang == id);
            return View(D_tour);
        }
        [HttpPost]
        public ActionResult DeleteKhachHang(int id, FormCollection collection)
        {
            var D_giay = data.KhachHangs.Where(m => m.MaKhachHang == id).First();
            data.KhachHangs.DeleteOnSubmit(D_giay);
            data.SubmitChanges();
            return RedirectToAction("Index");
        }



        /*--------------------------------------------------------------------------*/
        /*public ActionResult Listchang(int id)
        {
            var sptl = from ss in data.Changs where ss.ID == id select ss;
            return PartialView(sptl);

        }*/
        /* private decimal TongTien()
         {
             decimal tt = 0;
             List<LichTrinh> lst = new List<LichTrinh>();

             tt = (decimal)lst.Sum(n => n.PhuongTien.GiaPT);

             return tt;


         }*/
  /*      public ActionResult ListLichTrinh()
        {
            *//*ViewBag.Tongtien = TongTien();*//*
            var sptl = from ss in data.LichTrinhs select ss;
            List<LichTrinh> lichTrinhs = data.LichTrinhs.Where(s =>  s.GiaLichTrinh != null).ToList();
            if (lichTrinhs.Count > 0)
            {
                for (int i = 0; i < lichTrinhs.Count; i++)
                {
                    LichTrinh lichTrinh = data.LichTrinhs.FirstOrDefault(s => s.MaLichTrinh == lichTrinhs[i].MaLichTrinh);
                    decimal tongTien = 0;
                    if (lichTrinh != null)
                    {
                        AnUong anUong = data.AnUongs.FirstOrDefault(s => s.MaAnUong == lichTrinh.MaAnUong && s.ChiPhi > 0);
                        if (anUong != null)
                        {
                            tongTien += (decimal)anUong.ChiPhi;
                        }
                        KSan kSan = data.KSans.FirstOrDefault(s => s.MaKS == lichTrinh.MaKS && s.GiaKS > 0);
                        if (kSan != null)
                        {
                            tongTien += (decimal)kSan.GiaKS;
                        }
                        DiaDiem diaDiem = data.DiaDiems.FirstOrDefault(s => s.MaDiaDiem == lichTrinh.MaDiaDiem
                        && s.ChiPhiDD > 0);
                        if (diaDiem != null)
                        {
                            tongTien += (decimal)diaDiem.ChiPhiDD;
                        }
                        PhuongTien phuongTien = data.PhuongTiens.FirstOrDefault(s => s.MaPhuongTien == lichTrinh.MaPhuongTien
                        && s.GiaPT > 0);
                        if (phuongTien != null)
                        {
                            tongTien += (decimal)phuongTien.GiaPT;
                        }
                        if (tongTien > 0)
                        {
                            lichTrinh.GiaLichTrinh = tongTien;
                            UpdateModel(lichTrinh);
                            data.SubmitChanges();
                        }
                    }
                }
            }
            return PartialView(sptl);
        }

        public ActionResult CreateLichTrinh()
        {
            LichTrinh lichTrinh = new LichTrinh();

            lichTrinh.Ksans = data.KSans.ToList();
            lichTrinh.Changs = data.Changs.ToList();
            lichTrinh.DiaDiems = data.DiaDiems.ToList();
            lichTrinh.PhuongTiens = data.PhuongTiens.ToList();
            lichTrinh.AnUongs = data.AnUongs.ToList();


            return View(lichTrinh);

        }
        [HttpPost]
        public ActionResult CreateLichTrinh(FormCollection collection, LichTrinh s)
        {

            s.Ksans = data.KSans.ToList();
            s.Changs = data.Changs.ToList();
            s.DiaDiems = data.DiaDiems.ToList();
            s.PhuongTiens = data.PhuongTiens.ToList();
            s.AnUongs = data.AnUongs.ToList();



            var E_Ten = collection["TenLichTrinh"];
            var E_Gia = Convert.ToInt32(collection["GiaLichTrinh"]);

            if (string.IsNullOrEmpty(E_Ten))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                s.TenLichTrinh = E_Ten.ToString();
                s.GiaLichTrinh = E_Gia;

                data.LichTrinhs.InsertOnSubmit(s);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }

            return this.CreateLichTrinh();
        }
        *//*EDIT lcihtrinh*//*
        public ActionResult EditLichTrinh(int id)
        {


            var D_PT = data.LichTrinhs.FirstOrDefault(m => m.MaLichTrinh == id);
            return View(D_PT);
        }

        [HttpPost]
        public ActionResult EditLichTrinh(FormCollection collection, int id)
        {


            var D_PT = data.LichTrinhs.First(m => m.MaLichTrinh == id);
            var E_Ten = collection["TenLichTrinh"];
            var E_Gia = Convert.ToInt32(collection["GiaLichTrinh"]);



            D_PT.MaLichTrinh = id;

            if (string.IsNullOrEmpty(E_Ten))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                D_PT.TenLichTrinh = E_Ten.ToString();

               
                D_PT.GiaLichTrinh = E_Gia;



                UpdateModel(D_PT);


                data.SubmitChanges();
                return RedirectToAction("Index");
            }

            return this.EditLichTrinh(id);
        }

        *//*DELETE Chang*//*
        public ActionResult DeleteLichTrinh(int id)
        {
            var D_tour = data.LichTrinhs.First(m => m.MaLichTrinh == id);
            return View(D_tour);
        }
        [HttpPost]
        public ActionResult DeleteLichTrinh(int id, FormCollection collection)
        {
            var D_giay = data.LichTrinhs.Where(m => m.MaLichTrinh == id).First();
            data.LichTrinhs.DeleteOnSubmit(D_giay);
            data.SubmitChanges();
            return RedirectToAction("Index");
        }



*/


        /*-------------------------------*/
        public ActionResult CreateChang()
        {
            Chang Chang = new Chang();          
            Chang.Tours = data.Tours.ToList();
            return View(Chang);

        }
        [HttpPost]
        public ActionResult CreateChang(FormCollection collection, Chang s)
        {
           
            s.Tours = data.Tours.ToList();
           
            s.MaTour = int.Parse(Request.Form["ID"]);

            var E_Ten = collection["TenChang"];
            var E_Gia = Convert.ToInt32(collection["Gia"]);
            var E_NoiDung = collection["NoiDungChang"];
            if (string.IsNullOrEmpty(E_Ten))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                s.TenChang = E_Ten.ToString();
              /*  s.GiaChang = E_Gia;*/                
                s.NoiDungChang = E_NoiDung.ToString();
                data.Changs.InsertOnSubmit(s);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }

            return this.CreateChang();
        }
        public ActionResult CreateNhanVien()
        {
            NhanVien NhanVien = new NhanVien();
            NhanVien.chucVus = data.ChucVus.ToList();
            return View(NhanVien);

        }

        /*EDIT chang*/
        public ActionResult EditChang(int id)
        {


            var D_PT = data.Changs.FirstOrDefault(m => m.MaChang == id);
            return View(D_PT);
        }

        [HttpPost]
        public ActionResult EditChang(FormCollection collection, int id)
        {


            var D_PT = data.Changs.First(m => m.MaChang == id);
            var E_Ten = collection["TenChang"];
            /*var E_Gia = Convert.ToInt32(collection["Gia"]);*/
            var E_NoiDung = collection["NoiDungChang"];

          

            D_PT.MaChang = id;

            if (string.IsNullOrEmpty(E_Ten))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                D_PT.TenChang = E_Ten.ToString();
          
                D_PT.NoiDungChang = E_NoiDung.ToString();
               /* D_PT.GiaChang = E_Gia;*/
            


                UpdateModel(D_PT);


                data.SubmitChanges();
                return RedirectToAction("Index");
            }

            return this.EditChang(id);
        }

        /*DELETE Chang*/
        public ActionResult DeleteChang(int id)
        {
            var D_tour = data.Changs.First(m => m.MaChang == id);
            return View(D_tour);
        }
        [HttpPost]
        public ActionResult DeleteChang(int id, FormCollection collection)
        {
            var D_giay = data.Changs.Where(m => m.MaChang== id).First();
            data.Changs.DeleteOnSubmit(D_giay);
            data.SubmitChanges();
            return RedirectToAction("Index");
        }

        /*------------------*/
        [HttpPost]
        public ActionResult CreateNhanVien(FormCollection collection, NhanVien s)
        {

            s.chucVus = data.ChucVus.ToList();

            s.MaCV = int.Parse(Request.Form["MaCV"]);

            var E_Ten = collection["TenNV"];
            var E_SDT = Convert.ToInt32(collection["SDT"]);
            var E_Email = collection["Email"];

            var E_MatKhau = collection["MatKhau"];
            if (string.IsNullOrEmpty(E_Ten))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                s.TenNV = E_Ten.ToString();
                s.SDT = E_SDT;
                s.Email = E_Email.ToString();
                s.MatKhau = E_MatKhau.ToString();

                data.NhanViens.InsertOnSubmit(s);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }

            return this.CreateNhanVien();
        }

        public ActionResult EditNhanVien(int id)
        {


            var D_PT = data.NhanViens.FirstOrDefault(m => m.MaNV == id);
            return View(D_PT);
        }

        [HttpPost]
        public ActionResult EditNhanVien(FormCollection collection, int id,NhanVien s)
        {


            s.chucVus = data.ChucVus.ToList();

            s.MaCV = int.Parse(Request.Form["MaCV"]);
            var D_PT = data.NhanViens.First(m => m.MaNV == id);
            var E_Ten = collection["TenNV"];
            var E_SDT = Convert.ToInt32(collection["SDT"]);
            var E_Email = collection["Email"];

            var E_MatKhau = collection["MatKhau"];

            if (string.IsNullOrEmpty(E_Ten))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                D_PT.TenNV = E_Ten.ToString();

                D_PT.SDT = E_SDT;

                D_PT.Email = E_Email.ToString();
                D_PT.MatKhau = E_MatKhau.ToString();



                UpdateModel(D_PT);


                data.SubmitChanges();
                return RedirectToAction("Index");
            }

            return this.EditNhanVien(id);
        }

        public ActionResult DeleteNhanVien(int id)
        {
            var D_tour = data.NhanViens.First(m => m.MaNV == id);
            return View(D_tour);
        }
        [HttpPost]
        public ActionResult DeleteNhanVien(int id, FormCollection collection)
        {
            var D_giay = data.NhanViens.Where(m => m.MaNV == id).First();
            data.NhanViens.DeleteOnSubmit(D_giay);
            data.SubmitChanges();
            return RedirectToAction("Index");
        }



        public ActionResult ListNhanVien()
        {
            var sptl = from ss in data.NhanViens select ss;
            return PartialView(sptl);

        }
        /*--------------------*/
       /* public ActionResult Chitietdonhang(int id)
        {
            var D_tour = data.DatTours.FirstOrDefault(m => m.MaDatTour == id);
            return View(D_tour);
        }*/
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection collection)
        {
            var TenDangNhap = collection["Email"];
            var MatKhau = collection["MatKhau"];
            NhanVien kh = data.NhanViens.SingleOrDefault(n => n.Email == TenDangNhap && n.MatKhau == MatKhau);
            if (kh != null)
            {
                ViewBag.ThongBao = "Chúc mừng đăng nhập thành công";
                Session["TaiKhoan"] = kh;

                return RedirectToAction("Index", "NhanVien");

            }
            else
            {
                ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không đúng";

            }
            return View();
        }


     




    }
}