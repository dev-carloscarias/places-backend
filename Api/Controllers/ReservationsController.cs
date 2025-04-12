using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Places.Application.Dtos.Reservation.Create;

namespace Places.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
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
    }
}