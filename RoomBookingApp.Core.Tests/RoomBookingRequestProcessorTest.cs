using RoomBookingApp.Core.Models;
using RoomBookingApp.Core.Processors;
using Shouldly;
using System;
using Xunit;

namespace RoomBookingApp.Core.Tests
{
    public class RoomBookingRequestProcessorTest
    {
        [Fact]
        public void ShouldReturnRoomBookingRequest()
        {
            //Arrange
            var request = new RoomBookingRequest
            {
                FullName = "Clinton Test",
                Email = "clinton@kington.com",
                Date = new DateTime(2022, 07, 24)
            };
            var processor = new RoomBookingRequestProcessor();

            //Act
            RoomBookingResult result = processor.BookRoom(request);


            //Assert
            Assert.NotNull(result);
            Assert.Equal(request.FullName, result.FullName);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.Date, result.Date);

            //Assertion using 
            result.ShouldNotBeNull();
            result.FullName.ShouldBe(request.FullName);
            result.Email.ShouldBe(request.Email);
            result.Date.ShouldBe(request.Date);

        }
    }
}
