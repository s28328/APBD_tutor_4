using APBD_tutor_4.Model;
using APBD_tutor_4.Repositories;

namespace APBD_tutor_4.Services;

public class VisitService:IVisitService
{
    private readonly IVisitRepository _visitRepository;

    public VisitService(IVisitRepository visitRepository)
    {
        _visitRepository = visitRepository;
    }
    public IEnumerable<Visit> GetVisits()
    {
        return _visitRepository.GetVisits();
    }

    public int CreateVisit(Visit visit)
    {
        return _visitRepository.CreateVisit(visit);
    }
}