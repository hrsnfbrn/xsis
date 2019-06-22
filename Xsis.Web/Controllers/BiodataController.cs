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

        public ActionResult SelectReligion()
        {
            return Json(BiodataRepo.GetSelectReligion(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult SelectIdentityType()
        {
            return Json(BiodataRepo.GetSelectIdentityType(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult SelectMaritalStatus()
        {
            return Json(BiodataRepo.GetSelectMaritalStatus(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(int ID)
        {
            return PartialView("_Edit");
        }

        public ActionResult AmbilData(int ID)
        {
            return Json(BiodataRepo.GetByID(ID), JsonRequestBehavior.AllowGet);
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