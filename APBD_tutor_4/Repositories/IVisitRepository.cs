using APBD_tutor_4.Model;

namespace APBD_tutor_4.Repositories;

public interface IVisitRepository
{
    IEnumerable<Visit> GetVisits();
    int CreateVisit(Visit visit);
}