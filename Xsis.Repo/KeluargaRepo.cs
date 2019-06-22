using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xsis.Model;
using Xsis.ViewModel;

namespace Xsis.Repo
{
    public class KeluargaRepo
    {
        public static List<KeluargaViewModel> GetAll()
        {
            List<KeluargaViewModel> result = new List<KeluargaViewModel>();
            using (var db = new DataContext())
            {
                result = (from item in db.Keluarga
                          join Educational_Level in db.Educational_Level on item.educational_level_id equals Educational_Level.id
                          join Family_Tree_Type in db.Family_Tree_Type on item.family_tree_type_id equals Family_Tree_Type.id
                          join Family_Relation in db.Family_Relation on item.family_tree_type_id equals Family_Relation.family_tree_type_id
                          where item.is_delete == false
                          select new KeluargaViewModel
                          {
                              id = item.id,
                              family_relation_name = Family_Relation.name,
                              name = item.name,
                              gender = item.gender,
                              dob = item.dob,
                              educational_level_name=Educational_Level.name,
                              job=item.job
                          }
                          ).ToList();
            }
            return result;
        }

        public static List<Family_Tree_Type> GetSelectFamilyTreeType()
        {
            List<Family_Tree_Type> result = new List<Family_Tree_Type>();
            using (var db = new DataContext())
            {
                result = db.Family_Tree_Type.ToList();
                return result;
            }
        }

        public static List<Family_Relation> GetSelectFamilyRelation()
        {
            List<Family_Relation> result = new List<Family_Relation>();
            using (var db = new DataContext())
            {
                result = db.Family_Relation.ToList();
                return result;
            }
        }

        public static List<Educational_Level> GetSelectEducationalLevel()
        {
            List<Educational_Level> result = new List<Educational_Level>();
            using (var db = new DataContext())
            {
                result = db.Educational_Level.ToList();
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
                    keluarga.created_on = DateTime.Now;
                    keluarga.family_tree_type_id = keluargamdl.family_tree_type_id;
                    keluarga.family_relation_id = keluargamdl.family_relation_id;
                    keluarga.name = keluargamdl.name;
                    keluarga.gender = keluargamdl.gender;
                    keluarga.dob = keluargamdl.dob;
                    keluarga.educational_level_id = keluargamdl.educational_level_id;
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
                    dep.deleted_on = DateTime.Now;
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
                    dep.modified_on = DateTime.Now;
                    dep.family_tree_type_id = keluarga.family_tree_type_id;
                    dep.family_relation_id = keluarga.family_relation_id;
                    dep.name = keluarga.name;
                    dep.gender = keluarga.gender;
                    dep.dob = keluarga.dob;
                    dep.educational_level_id = keluarga.educational_level_id;
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
