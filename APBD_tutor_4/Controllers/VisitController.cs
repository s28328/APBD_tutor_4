using APBD_tutor_4.Model;
using APBD_tutor_4.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace APBD_tutor_4.Controllers;


[Route("api/v1/[controller]")]
[ApiController]
public class VisitController:ControllerBase
{
    private readonly IVisitService _visitService;

    public VisitController(IVisitService visitService)
    {
        _visitService = visitService;
    }

    [HttpGet]
    public IActionResult GetVisits()
    {
        return Ok(_visitService.GetVisits());
    }

    [HttpPost]
    public IActionResult CreateVisit(Visit visit)
    {
        var affetctedCount = _visitService.CreateVisit(visit);
        return StatusCode(StatusCodes.Status201Created);
    }

}