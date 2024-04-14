using APBD_tutor_4.Model;

namespace APBD_tutor_4.Services;

public interface IVisitService
{
    IEnumerable<Visit> GetVisits();
    int CreateVisit(Visit visit);
}