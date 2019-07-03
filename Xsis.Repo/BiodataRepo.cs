using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xsis.Model;
using Xsis.ViewModel;

namespace Xsis.Repo
{
    public class BiodataRepo
    {
        public static Biodata GetByID(int ID)
        {
            Biodata biodata = new Biodata();
            using (DataContext db = new DataContext())
            {
                biodata = db.Biodata.Where(d => d.id == ID).First();
                return biodata;
            }
        }

        public static List<BiodataViewModel> GetAll()
        {
            List<BiodataViewModel> biodataviewmodel = new List<BiodataViewModel>();
            using (var db = new DataContext())
            {
                biodataviewmodel = (from 
                          biodata in db.Biodata
                          //join Religion in db.Religion on item.religion_id equals Religion.id
                          //join Identity_Type in db.Identity_Type on item.identity_type_id equals Identity_Type.id
                          //join Marital_Status in db.Marital_Status on item.marital_status_id equals Marital_Status.id
                          //join AddrBook in db.AddrBook on item.addrbook_id equals AddrBook.id
                          //join Address in db.Address on item.id equals Address.biodata_id
                          where biodata.is_delete == false
                          select new BiodataViewModel
                          {
                              id = biodata.id,
                              fullname = biodata.fullname,
                              nick_name = biodata.nick_name,
                              pob = biodata.pob,
                              dob = biodata.dob,
                              gender = biodata.gender,
                              //religion_id=item.religion_id,
                              //religion_name = Religion.name,
                              //high = item.high,
                              //weight = item.weight,
                              //nationality = item.nationality,
                              //ethnic = item.ethnic,
                              //hobby = item.hobby,
                              //identity_type_id=item.identity_type_id,
                              //identity_type_name = Identity_Type.name,
                              //identity_no=item.identity_no,
                              //email=item.email,
                              //phone_number1=item.phone_number1,
                              //phone_number2=item.phone_number2,
                              //parent_phone_number=item.parent_phone_number,
                              //child_sequence=item.child_sequence,
                              //how_many_brothers=item.how_many_brothers,
                              //marital_status_id=item.marital_status_id,
                              //marital_status_name=Marital_Status.name,
                              //mariage_year=item.mariage_year,
                              //address1 = Address.address1,
                              //postalcode1=Address.postalcode1,
                              //rt1=Address.rt1,
                              //rw1=Address.rw1,
                              //kelurahan1=Address.kelurahan1,
                              //kecamatan1=Address.kecamatan1,
                              //region1=Address.region1,
                              //address2 = Address.address2,
                              //postalcode2 = Address.postalcode2,
                              //rt2 = Address.rt2,
                              //rw2 = Address.rw2,
                              //kelurahan2 = Address.kelurahan2,
                              //kecamatan2 = Address.kecamatan2,
                              //region2 = Address.region2
                          }
                          ).ToList();
            }
            return biodataviewmodel;
        }

        public static List<Religion> GetSelectReligion()
        {
            List<Religion> result = new List<Religion>();
            using (var db = new DataContext())
            {
                result = db.Religion.ToList();
                return result;
            }
        }

        public static List<Identity_Type> GetSelectIdentityType()
        {
            List<Identity_Type> result = new List<Identity_Type>();
            using (var db = new DataContext())
            {
                result = db.Identity_Type.ToList();
                return result;
            }
        }

        public static List<Marital_Status> GetSelectMaritalStatus()
        {
            List<Marital_Status> result = new List<Marital_Status>();
            using (var db = new DataContext())
            {
                result = db.Marital_Status.ToList();
                return result;
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
