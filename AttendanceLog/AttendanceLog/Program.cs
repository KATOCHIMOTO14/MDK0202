using System;
using AttendanceLog.Logic;

var service = new VisitService();

Console.WriteLine("Отобранные записи (Пропуски студентов):");
foreach (var item in service.GetAbsences())
{
    Console.WriteLine($"{item.Id}: {item.Student}");
}
