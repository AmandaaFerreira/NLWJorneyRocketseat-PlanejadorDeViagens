using Journey.Communication.Responses;
using Journey.Exception;
using Journey.Exception.ExceptionsBase;
using Journey.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Journey.Application.UseCases.Trips.GetById
{
    public class GetByIdUseCase
    {
        public ResponseTripJson Execute(Guid id)
        {
            var dbContext = new JourneyDbContext();

            var trip = dbContext
                .Trips
                .Include(trip => trip.Activities)
                .FirstOrDefault(trip => trip.Id == id);

            if (trip is null)
            {
                throw new NotFoundException(ResourceErrorMessage.TRIP_NOT_FOUND); 

            }
            return new ResponseTripJson
            {
                Id = trip.Id,
                Name = trip.Name,
                StartDate = trip.StartDate,
                EndDate = trip.EndDate,
                Activities = trip.Activities.Select(activy => new ResponseActivityJson
                {
                    Id = activy.Id,
                    Name = activy.Name,
                    Date = activy.Date,
                    Status = (Communication.Enums.ActivityStatus) activy.Status,
                }).ToList()

            };

        } 


    }
}
