using RoomBookingApp.Core.Models;
using System;

namespace RoomBookingApp.Core.Processors
{
    public class RoomBookingRequestProcessor
    {
        public RoomBookingRequestProcessor()
        {
        }

        public RoomBookingResult BookRoom(RoomBookingRequest request)
        {
            return new RoomBookingResult
            {
                Date = request.Date,
                FullName = request.FullName,
                Email = request.Email,
            };
        }
    }
}