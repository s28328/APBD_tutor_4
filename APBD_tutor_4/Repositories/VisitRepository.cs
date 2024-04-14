using APBD_tutor_4.Model;

namespace APBD_tutor_4.Repositories;

public class VisitRepository:IVisitRepository
{
    private static List<Visit> _visits = new List<Visit>()
    {
        new Visit()
        {
            Animal = AnimalRepository.Animals[0],
            DateTime = new DateTime(2024,03,24),
            Description = "Description",
            Price = 200
        }
    };
    public IEnumerable<Visit> GetVisits()
    {
        return _visits;
    }

    public int CreateVisit(Visit visit)
    {
        _visits.Add(visit);
        return 1;
    }
}