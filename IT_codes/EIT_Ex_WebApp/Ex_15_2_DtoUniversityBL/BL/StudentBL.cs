using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Ex_15_2_DtoUniversityCMN;


namespace Ex_15_2_DtoUniversityBL
{
    public class StudentBL : BaseBL<IStudentDA, StudentDto>, IStudentBL
    {
        //map
        public Student MapDto(StudentDto studentDto)
        {
            if (studentDto != null)
            {
                return new Student
                {
                   FirstName = studentDto.FirstName,
                   LastName = studentDto.LastName,
                   MobileNumber = studentDto.MobileNumber,
                   StudentCode = studentDto.StudentCode,
                };
            }

            return null;
        }

        public override void Insert(StudentDto Dto)
        {
            Student student = MapDto(Dto);
            UnityManager.Container.Resolve<IBaseDA>().Insert(student);

        }

    }
}
