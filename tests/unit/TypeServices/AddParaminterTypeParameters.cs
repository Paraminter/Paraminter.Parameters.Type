﻿namespace Paraminter.Parameters;

using Microsoft.Extensions.DependencyInjection;

using Moq;

using System;

using Xunit;

public sealed class AddParaminterTypeParameters
{
    [Fact]
    public void NullServiceCollection_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidServiceCollection_ReturnsSameServiceCollection()
    {
        var services = Mock.Of<IServiceCollection>();

        var result = Target(services);

        Assert.Same(services, result);
    }

    private static IServiceCollection Target(
        IServiceCollection services)
    {
        return TypeServices.AddParaminterTypeParameters(services);
    }
}