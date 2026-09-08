using System.Collections.Generic;

namespace AttendanceLog.Data;

public class VisitRepository
{
    private readonly List<Visit> _items = new()
    {
        new Visit { Id = 1, Student = "Боев Антон", WasPresent = false },
        new Visit { Id = 2, Student = "Иванов Иван", WasPresent = true },
        new Visit { Id = 3, Student = "Петров Петр", WasPresent = false }
    };

    public List<Visit> GetAll()
    {
        return _items;
    }
}
