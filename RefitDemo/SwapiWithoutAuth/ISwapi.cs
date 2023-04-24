using Refit;
using RefitDemo.SwapiWithoutAuth.Dtos;

namespace RefitDemo.SwapiWithoutAuth;

public interface ISwapi
{
    [Get("/api/people/{id}")]
    public Task<IApiResponse<PersonResponse>> GetPerson([AliasAs("id")] string personId, CancellationToken cancellationToken);
}