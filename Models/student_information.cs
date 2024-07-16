using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static WebApp.Models.student_information;
namespace WebApp.Models
{
    public class student_information
    {
        public studentRegister ostudentRegister { get; set; }
        public List<studentRegister> ostudentRegisterList { get; set; }
        public bloodRegister obloodRegister { get; set; }
        public List<bloodRegister> obloodRegisterList { get; set; }
        public boardRegister oboardRegister { get; set; }
        public List<boardRegister> oboardRegisterList { get; set; }
        public genderRegister ogenderRegister { get; set; }
        public List<genderRegister> ogenderRegisterList { get; set; }

        public casteRegister ocasteRegister { get; set; }
        public List<casteRegister> ocasteRegisterList { get; set; }


        public degreeRegister odegreeRegister { get; set; }
        public List<degreeRegister> odegreeRegisterList { get; set; }
        public branchRegister obranchRegister { get; set; }
        public List<branchRegister> obranchRegisterList { get; set; }

        public student_information()
        {

            ostudentRegister = new studentRegister();
            ostudentRegisterList = new List<studentRegister>();
            obloodRegister = new bloodRegister();
            obloodRegisterList = new List<bloodRegister>();
            oboardRegister = new boardRegister();
            oboardRegisterList = new List<boardRegister> ();
            ogenderRegister = new genderRegister();
            ogenderRegisterList = new List<genderRegister>();
            ocasteRegister = new casteRegister();
            ocasteRegisterList = new List<casteRegister>();
            odegreeRegister = new degreeRegister();
            odegreeRegisterList = new List<degreeRegister>();
            obranchRegister = new branchRegister();
            obranchRegisterList = new List<branchRegister>();

        }
        public class studentRegister
        {
            [Key]
            public int register_id { get; set; }
            public string register_date { get; set; }

            public string student_name { get; set; }
            public int gender { get; set; }
            public string dob { get; set; }

            public int age { get; set; }
            public int blood_groop { get; set; }
            public string mother_tongue { get; set; }

            public string student_contact { get; set; }

            public string aadhar_number { get; set; }
            public string student_mailid { get; set; }
            public string father_name { get; set; }
            public string guardian_name { get; set; }
            public string father_contact { get; set; }
            public string guardian_contact { get; set; }
            public string father_mailid { get; set; }
            public string guardian_mailid { get; set; }
            public string father_occupation { get; set; }
            public string mother_name { get; set; }
            public string mother_contact { get; private set; }
            public string mother_mailid { get; set; }
            public string mother_occupation { get; set; }
            public decimal annual_income { get; set; }
            public string residential_address { get; set; }

            public string city { get; set; }
            public string state { get; set; }
            public string nationality { get; set; }
            public string religion { get; set; }
            public int caste { get; set; }
            public int board { get; set; }
            public string medium { get; set; }
            public int sslc_passout_year { get; set; }
            public decimal sslc_percent { get; private set; }
            public int hsc_passout_year { get; set; }
            public decimal hsc_percent { get; private set; }
            public int degree { get; set; }
            public int branch { get; set; }
            public string quota { get; set; }

            public string scholarship { get; set; }
            public string hosteller { get; set; }
            public string information_added_date { get; set; }
            public string information_updated_date { get; set; }
            public string user_name { get; set; }
            public int status { get; set; }

        }
        public class bloodRegister
        {
            public string blood_group { get; set; }

            [Key]
            public int blood_group_id { get; set; }

        }
        public class boardRegister
        {
            public string board_name { get; set; }

            [Key]
            public int board_id { get; set; }
        }
        public class genderRegister
        {
            public string gender { get; set; }

            [Key]
            public int gender_id { get; set; }
        }
        public class casteRegister
        {
            public string caste_name { get; set; }

            [Key]
            public int caste_id { get; set; }
        }
        public class degreeRegister
        {
            public string degree_name { get; set; }
            [Key]
            public int degree_id { get; set; }
        }
        public class branchRegister
        {
            public string branch_name { get; set; }
            [Key]
            public int branch_id { get; set; } 
        }
    }  
}