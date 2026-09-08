using System.Collections.Generic;
using System.Linq;
using AttendanceLog.Data;

namespace AttendanceLog.Logic;

public class VisitService
{
    private readonly VisitRepository _repository = new();

    public List<Visit> GetAbsences()
    {
        return _repository.GetAll()
            .Where(item => item.WasPresent == false)
            .ToList();
    }
}
