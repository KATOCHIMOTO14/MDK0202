using System;
using AttendanceLog.Data;
using AttendanceLog.Logic;

IVisitRepository repository = new DemoVisitRepository();

var service = new VisitService(repository);

Console.WriteLine("=== Проверка работы: Основное хранилище ===");

foreach (var item in service.GetImportant())
{
    string presence = item.WasPresent ? "Присутствовал" : "Отсутствовал";
    Console.WriteLine($"[ID {item.Id}] Студент: {item.Student} | Статус: {presence}");
}
