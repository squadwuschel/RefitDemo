using Moq.AutoMock;

namespace RefitTests;

public abstract class TestBase<T> where T : class
{
    protected AutoMocker AutoMocker { get; set; } = null!;
    protected T ServiceMock { get; set; } = null!;

    protected virtual Action<AutoMocker>? AutoMockerInit { get; } = null;

    [SetUp]
    public virtual void Setup()
    {
        AutoMocker = new AutoMocker();

        AutoMockerInit?.Invoke(AutoMocker);

        ServiceMock = AutoMocker.CreateInstance<T>();
    }
}