using Soenneker.Tests.HostedUnit;

namespace Soenneker.Dtos.MsTeams.Card.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class MsTeamsCardTests : HostedUnitTest
{
    public MsTeamsCardTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
