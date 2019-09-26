using AutoMapper;
using OFour.Core.Entities;
using OFour.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OFour.Core.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentModel>();
            CreateMap<StudentModel, Student>()
                .ForMember(x => x.StudentCourses, y => y.Ignore());
            CreateMap<Teacher, TeacherModel>();
            CreateMap<TeacherModel, Teacher>()
                .ForMember(x => x.Cources, y => y.Ignore());
            CreateMap<Course, CourseModel>();
            CreateMap<CourseModel, Course>()
                .ForMember(x => x.Subject, y => y.Ignore())
                .ForMember(x => x.Teacher, y => y.Ignore());
            CreateMap<Subject, SubjectModel>();
            CreateMap<SubjectModel, Subject>()
                .ForMember(x => x.Cources, y => y.Ignore());
            CreateMap<StudentCourse, StudentCourseModel>();
            CreateMap<StudentCourseModel, StudentCourse>()
                .ForMember(x => x.Student, y => y.Ignore())
                .ForMember(x => x.Cource, y => y.Ignore());
            

        }
    }
}
