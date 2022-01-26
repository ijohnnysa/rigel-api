using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Rigel;
using Xunit;

namespace Tests;

public class UnitTest1 : IClassFixture<WebApplicationFactory<Startup>>
{
    private readonly HttpClient _httpClient;

    public UnitTest1(WebApplicationFactory<Startup> webApplicationFactory)
    {
        _httpClient = webApplicationFactory.CreateClient();
    }

    [Fact]
    public async void Test1()
    {
        HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync("/");
        httpResponseMessage.EnsureSuccessStatusCode();
        string responseContent = await httpResponseMessage.Content.ReadAsStringAsync();
        Assert.Equal("Olá, mundo!", responseContent);
    }
}
