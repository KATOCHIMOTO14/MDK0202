using System.Collections.Generic;
using System.Linq;

namespace AttendanceLog.Logic;

public class VisitService
{
    private readonly IVisitRepository _repository;
    public VisitService(IVisitRepository repository)
    {
        _repository = repository;
    }
    public List<Visit> GetImportant()
    {
        return _repository.GetAll()
            .Where(item => item.WasPresent == false)
            .ToList();
    }
}
