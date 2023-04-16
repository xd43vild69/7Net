using _7Net;
using _7Net.Aggregate;
using _7Net.Enums;

namespace _7NetTest;

public class CoreNodeTest
{
    [Fact]
    public void Should_Connect_Input_Node_Property()
    {
        var core = new Core();
        var node1 = new Node();
        var node2 = new Node();

        core.ConnectInput(node1, node2, PropertiesEnum.Genre);

        var x = string.Empty;
        Assert.True(node1?.Inputs?.FirstOrDefault()?.Source == node2.NodeId);
    }
}