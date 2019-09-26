using Microsoft.Extensions.DependencyInjection;
using OFour.Bll.Operations;
using OFour.Core.Infrastructure.BLLInterfaces;
using OFour.Core.Infrastructure.RepositoryAbstraction;
using OFour.Core.Infrastructure.RepositoryInterfaces;
using OFour.Dal;
using OFour.Dal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OFour.Configurations
{
    public static class DependancyConfiguration
    {
        private static readonly Dictionary<Type, Type> Operations = new Dictionary<Type, Type>
        {

            {typeof(IStudentOperation),typeof(StudentOperation) },
            {typeof(ITeacherOperation),typeof(TeacherOperation) },
            {typeof(ISubjectOperation),typeof(SubjectOperation) },
            {typeof(ICourseOperation),typeof(CourseOperation) },
            {typeof(IStudentCourseOperation),typeof(StudentCourseOperation) },

        };

        private static readonly Dictionary<Type, Type> Repositories = new Dictionary<Type, Type>
        {
            {typeof(IRepositoryManager),typeof(RepositoryManager) },
            {typeof(IStudentRepository),typeof(StudentRepository) },
            {typeof(ITeacherRepository),typeof(TeacherRepository) },
            {typeof(ISubjectRepository),typeof(SubjectRepository) },
            {typeof(ICourseRepository),typeof(CourseRepository) },
            {typeof(IStudentCourseRepository),typeof(StudentCourseRepository) },


        };

        public static void AddDALServices(this IServiceCollection services)
        {
            foreach (var entry in Repositories)
            {
                services.Add(new ServiceDescriptor(entry.Key, entry.Value, ServiceLifetime.Transient));
            }

        }
        public static void AddBLLServices(this IServiceCollection services)
        {
            foreach (var entry in Operations)
            {
                services.Add(new ServiceDescriptor(entry.Key, entry.Value, ServiceLifetime.Transient));
            }
        }



    }
}
