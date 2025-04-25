using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Places.Application.Dtos.Reservation.Create;
using Places.Application.Dtos.Reservation.Created;

namespace Places.Application.Interfaces
{
    public interface IReservationService
    {
        public Task<CreatedReservationDto> CreateReservation(CreateReservationDTO reservationDTO);
        public Task<CreatedReservationDto> GetReservationById(int reservationId);
    }
}