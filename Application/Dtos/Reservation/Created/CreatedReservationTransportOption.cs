using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Places.Application.Dtos.Reservation.Create;

namespace Places.Application.Dtos.Reservation.Created
{
    public class CreatedReservationTransportOption : ReservationSelectedTransportOptionDto
    {
        public SelectedTransportOptionDto SelectedTransportOption { get; set; } = null!;
    }
}
