using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using static WebApp.Models.student_information;

namespace WebApp.Models
{
    public class StudentRepository
    {
        public readonly DapperContext _context;
        public readonly IConfiguration _myconfiguration;

        public StudentRepository(DapperContext context, IConfiguration myconfiguration)
        {
            _context = context;
            _myconfiguration = myconfiguration;
        }

        public student_information GetStudentDetails()
        {
            student_information obj = new student_information();
            try
            {
                string query = "select * from student";

                using(var connection = _context.CreateConnection()) 
                {

                    obj.ostudentRegister = connection.Query<studentRegister>(query, commandType: CommandType.Text).FirstOrDefault();
                
                }
                return obj;
            }
            catch (Exception ex) 
            {
                throw ex;
            
            }
        }
  
        public int SaveStudentDetails(studentRegister obj)
        {
            try 
            {
                obj.status = 1;
                string query = "insert into student values('" + obj.register_id + "','" + obj.register_date + "','" + obj.student_name + "','" + obj.gender + "','" + obj.dob + "','" + obj.age + "','" + obj.blood_groop + "','" + obj.mother_tongue + "','" + obj.student_contact + "','" + obj.aadhar_number + "','" + obj.student_mailid + "','" + obj.father_name + "','" + obj.guardian_name + "','" + obj.father_contact + "','" + obj.guardian_contact + "','" + obj.father_mailid + "','" + obj.guardian_mailid + "','" + obj.father_occupation + "','" + obj.mother_name + "','" + obj.mother_mailid + "','" + obj.mother_occupation + "','" + obj.mother_contact + "','" + obj.annual_income + "','" + obj.residential_address + "','" + obj.city + "','" + obj.state + "','" + obj.nationality + "','" + obj.religion + "','" + obj.caste + "','" + obj.board + "','" + obj.medium + "','" + obj.sslc_passout_year + "','" + obj.sslc_percent + "','" + obj.hsc_passout_year + "','" + obj.hsc_percent + "','" + obj.degree + "','" + obj.branch + "','" + obj.quota + "','" + obj.scholarship + "','" + obj.hosteller + "','" + obj.information_added_date + "','" + obj.information_updated_date + "','" + obj.user_name + "','" + obj.status + "')";
                using (var connection = _context.CreateConnection())
                {

                    connection.Query(query, commandType: CommandType.Text).FirstOrDefault();

                }

            }
            catch (Exception ex) { throw ex; }


            
            return 1;
        }

    }
}
