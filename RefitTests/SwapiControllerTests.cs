using System.Net;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Refit;
using RefitDemo.SwapiWithoutAuth;
using RefitDemo.SwapiWithoutAuth.Dtos;

namespace RefitTests;

public class SwapiControllerTests : TestBase<SwapiController>
{
    [Test]
    public async Task Should_Hanlde_Api_Request_With_Success()
    {
        AutoMocker.GetMock<ISwapi>()
            .Setup(p => p.GetPerson(It.IsAny<string>(), CancellationToken.None))
            .ReturnsAsync(() => new ApiResponse<PersonResponse>(
                new HttpResponseMessage(HttpStatusCode.OK), 
                new PersonResponse()
                {
                    Films = new List<string>() { "Saga 1"},
                    Gender = "male",
                    Name = "Obi Wan",
                    BirthYear = "1970",
                    EyeColor = "blue",
                },
                new RefitSettings()));
        
      
        var result = await ServiceMock.Get("1", CancellationToken.None);
        
        ((ObjectResult) result).StatusCode.Should().Be(StatusCodes.Status200OK);
        ((ObjectResult) result).Value.Should().BeOfType<PersonResponse>();
        
        var personResult = (PersonResponse) ((ObjectResult) result).Value;
        personResult.BirthYear.Should().Be("1970");
        
    }
    
    [Test]
    public async Task Should_Hanlde_Api_Request_With_Forbidden()
    {
        AutoMocker.GetMock<ISwapi>()
            .Setup(p => p.GetPerson(It.IsAny<string>(), CancellationToken.None))
            .ReturnsAsync(() => new ApiResponse<PersonResponse>(
                new HttpResponseMessage(HttpStatusCode.Forbidden), 
                null,
                new RefitSettings()));
        
      
        var result = await ServiceMock.Get("1", CancellationToken.None);
        
        result.Should().BeOfType<StatusCodeResult>();
        ((StatusCodeResult) result).StatusCode.Should().Be(StatusCodes.Status403Forbidden);
        
    }
}