using Places.Application.Dtos.Reservation.Availability;
using Places.Application.Dtos.Reservation.Create;

namespace Places.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        public ReservationsController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateReservationDTO createReservationDTO)
        {
            return Ok(await _reservationService.CreateReservation(createReservationDTO));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _reservationService.GetReservationById(id));
        }

        [HttpPost]
        [Route("verifyAvailability")]
        public async Task<IActionResult> VerifyAvailability([FromBody] VerifySiteAvailabilityDto request)
        {
            return Ok(await _reservationService.VerifyAvailability(request));

        }

        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> GetAllReservations()
        {
            return Ok(await _reservationService.GetAllReservations());
        }

    }
}