using System;
using System.Collections.Generic;
using AttendanceLog.Logic;

namespace AttendanceLog.Data
{
    public class DemoVisitRepository : IVisitRepository
    {
        public List<Visit> GetAll()
        {
            return new List<Visit>
            {
                // Используем Student вместо StudentName и WasPresent = false вместо Status
                new Visit { Id = 100, Student = "Тестовый Демо-Студент", WasPresent = false }
            };
        }
    }
}
