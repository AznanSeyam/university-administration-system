using System.Collections.Generic;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Services
{
    public interface IEnrollmentService
    {
        IEnumerable<Enrollment> GetAllEnrollments();
        void RemoveEnrollment(int id);
    }
}
