using Refit;

namespace RefitDemo.KeycloakApiClient;

public interface IContentApi
{
    [Post("/v1/video-upload")]
    public Task<IApiResponse> StartVideoUploadWithResponse(CancellationToken cancellationToken = default);
    
    [Post("/v1/video-upload")]
    public Task StartVideoUploadWithoutResponse(CancellationToken cancellationToken = default);
}