using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xsis.Model;
using Xsis.Repo;

namespace Xsis.Web.Controllers
{
    public class BiodataController : Controller
    {
        // GET: Biodata
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tampil()
        {
            return Json(BiodataRepo.GetAll(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Select()
        {
            return Json(BiodataRepo.GetSelect(), JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult Edit(int ID)
        {
            return PartialView("_Edit");
        }

        public ActionResult AmbilData(int ID)
        {
            return Json(BiodataRepo.GetByID(ID), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Delete(int ID, Biodata biodatamdl)
        {
            biodatamdl.deleted_by = Convert.ToInt64(Session["foo"]);
            if (BiodataRepo.Deletebiodata(ID, biodatamdl)) //non static if ( BiodataRepo.Deletebiodata(ID))
            {
                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult EditSimpan(Biodata biodata)
        {
            biodata.modified_by = Convert.ToInt64(Session["foo"]);
            if (BiodataRepo.Editbiodata(biodata))
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