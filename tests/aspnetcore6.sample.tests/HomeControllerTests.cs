using aspnetcore6.sample.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSubstitute;
using Xunit;

namespace aspnetcore6.sample.tests;

public class HomeControllerTests
{
    private readonly HomeController controller;    
    private readonly ILogger<HomeController> mockLogger;

    public HomeControllerTests()
    {
        mockLogger = Substitute.For<ILogger<HomeController>>();
        controller = new HomeController(mockLogger);
    }

    [Fact]
    public void Index_NoParams_ReturnViewResult()
    {
        var view = controller.Index();

        Assert.IsType<ViewResult>(view);
    }
}