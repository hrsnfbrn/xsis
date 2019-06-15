using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xsis.Model;

namespace Xsis.Repo
{
    public class KeluargaRepo
    {
        public static List<Keluarga> GetAll()
        {
            List<Keluarga> result = new List<Keluarga>();
            using (var db = new DataContext())
            {
                //result = db.Keluarga.ToList();

                result = (from t in db.Keluarga
                          where t.is_delete == false
                          select t).ToList();
                //select new Keluarga { keluarga_name = t.keluarga_name, notes = t.notes, skill_level_id = t.skill_level_id }).ToList();


                //result = (from item in db.Keluarga
                //          where item.is_delete == false
                //          select new Keluarga { item.skill_name }).ToList();
                return result;
            }
        }

        public static List<Family_Tree_Type> GetSelect()
        {
            List<Family_Tree_Type> result = new List<Family_Tree_Type>();
            using (var db = new DataContext())
            {
                result = db.Family_Tree_Type.ToList();
                return result;
            }
        }

        public static Boolean Createkeluarga(Keluarga keluargamdl)
        {
            try
            {
                Keluarga keluarga = new Keluarga();
                using (DataContext db = new DataContext())
                {
                    keluarga.biodata_id = 1;
                    keluarga.created_by = keluargamdl.created_by;
                    keluarga.created_on = DateTime.Now.Date;
                    keluarga.family_tree_type_id = keluargamdl.family_tree_type_id;
                    keluarga.family_relation_id = keluargamdl.family_relation_id;
                    keluarga.name = keluargamdl.name;
                    keluarga.gender = keluargamdl.gender;
                    keluarga.dob = keluargamdl.dob;
                    keluarga.education_level_id = keluargamdl.education_level_id;
                    keluarga.job = keluargamdl.job;
                    keluarga.notes = keluargamdl.notes;
                    db.Keluarga.Add(keluarga);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static Keluarga GetByID(int ID)
        {
            Keluarga keluarga = new Keluarga();
            using (DataContext db = new DataContext())
            {
                keluarga = db.Keluarga.Where(d => d.id == ID).First();
                return keluarga;
            }
        }


        public static Boolean Deletekeluarga(int ID, Keluarga keluargamdl)
        {
            try
            {

                Keluarga dep;
                using (DataContext db = new DataContext())
                {
                    dep = db.Keluarga.Where(d => d.id == ID).First();
                    dep.is_delete = true;
                    dep.deleted_by = keluargamdl.deleted_by;
                    dep.deleted_on = DateTime.Now.Date;
                    db.Entry(dep).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static Boolean Editkeluarga(Keluarga keluarga)
        {
            try
            {
                Keluarga dep;
                using (DataContext db = new DataContext())
                {
                    dep = db.Keluarga.Where(d => d.id == keluarga.id).First();
                    dep.modified_by = keluarga.modified_by;
                    dep.modified_on = DateTime.Now.Date;
                    dep.family_tree_type_id = keluarga.family_tree_type_id;
                    dep.family_relation_id = keluarga.family_relation_id;
                    dep.name = keluarga.name;
                    dep.gender = keluarga.gender;
                    dep.dob = keluarga.dob;
                    dep.education_level_id = keluarga.education_level_id;
                    dep.job = keluarga.job;
                    dep.notes = keluarga.notes;
                    db.Entry(dep).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
