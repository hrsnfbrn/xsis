using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xsis.Model;

namespace Xsis.Repo
{
    public class BiodataRepo
    {
        public static List<Biodata> GetAll()
        {
            List<Biodata> result = new List<Biodata>();
            using (var db = new DataContext())
            {
                //result = db.Biodata.ToList();

                result = (from t in db.Biodata
                          where t.is_delete == false
                          select t).ToList();
                //select new Biodata {biodata_name = t.biodata_name, notes = t.notes, skill_level_id = t.skill_level_id }).ToList();


                //result = (from item in db.Biodata
                //          where item.is_delete == false
                //          select new Biodata { item.skill_name }).ToList();
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

        public static Biodata GetByID(int ID)
        {
            Biodata biodata = new Biodata();
            using (DataContext db = new DataContext())
            {
                biodata = db.Biodata.Where(d => d.id == ID).First();
                return biodata;
            }
        }


        public static Boolean Deletebiodata(int ID, Biodata biodatamdl)
        {
            try
            {

                Biodata dep;
                using (DataContext db = new DataContext())
                {
                    dep = db.Biodata.Where(d => d.id == ID).First();
                    dep.is_delete = true;
                    dep.deleted_by = biodatamdl.deleted_by;
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

        public static Boolean Editbiodata(Biodata biodata)
        {
            try
            {
                Biodata dep;
                using (DataContext db = new DataContext())
                {
                    dep = db.Biodata.Where(d => d.id == biodata.id).First();
                    dep.modified_by = biodata.modified_by;
                    dep.modified_on = DateTime.Now;
                    dep.fullname = biodata.fullname;
                    dep.nick_name = biodata.nick_name;
                    dep.pob = biodata.pob;
                    dep.dob = biodata.dob;
                    dep.gender = biodata.gender;
                    dep.religion_id = biodata.religion_id;
                    dep.high = biodata.high;
                    dep.weight = biodata.weight;
                    dep.nationality = biodata.nationality;
                    dep.ethnic = biodata.ethnic;
                    dep.hobby = biodata.hobby;
                    dep.identity_type_id = biodata.identity_type_id;
                    dep.identity_no = biodata.identity_no;
                    dep.email = biodata.email;
                    dep.phone_number1 = biodata.phone_number1;
                    dep.phone_number2 = biodata.phone_number2;
                    dep.parent_phone_number = biodata.parent_phone_number;
                    dep.child_sequence = biodata.child_sequence;
                    dep.how_many_brothers = biodata.how_many_brothers;
                    dep.marital_status_id = biodata.marital_status_id;
                    dep.mariage_year = biodata.mariage_year;
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
