using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xsis.Model;
using Xsis.Repo;

namespace Xsis.Web.Controllers
{
    public class KeluargaController : Controller
    {
        // GET: Keluarga
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tampil()
        {
            return Json(KeluargaRepo.GetAll(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult SelectFamilyTreeType()
        {
            return Json(KeluargaRepo.GetSelectFamilyTreeType(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult SelectFamilyRelation()
        {
            return Json(KeluargaRepo.GetSelectFamilyRelation(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult SelectEducationalLevel()
        {
            return Json(KeluargaRepo.GetSelectEducationalLevel(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        public ActionResult Save(Keluarga keluarga)
        {
            keluarga.created_by = Convert.ToInt64(Session["foo"]);
            if (KeluargaRepo.Createkeluarga(keluarga))
            {
                return Json(new { Simpan = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Simpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Edit(int ID)
        {
            return PartialView("_Edit");
        }

        public ActionResult AmbilData(int ID)
        {
            return Json(KeluargaRepo.GetByID(ID), JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteCfr(int ID)
        {
            return PartialView("_Delete");
        }

        public ActionResult Delete(int ID, Keluarga keluargamdl)
        {
            keluargamdl.deleted_by = Convert.ToInt64(Session["foo"]);
            if (KeluargaRepo.Deletekeluarga(ID, keluargamdl)) //non static if ( KeluargaRepo.Deletekeluarga(ID))
            {
                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult EditSimpan(Keluarga keluarga)
        {
            keluarga.modified_by = Convert.ToInt64(Session["foo"]);
            if (KeluargaRepo.Editkeluarga(keluarga))
            {
                return Json(new { EditSimpan = "Berhasil" }, JsonRequestBehavior.AllowGet); //return json digunakan untuk memunculkan alert
            }
            else
            {
                return Json(new { EditSimpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}