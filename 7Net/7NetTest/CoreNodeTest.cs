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

        Assert.True(node1?.Inputs?.FirstOrDefault()?.Source == node2.NodeId);
    }

    [Fact]
    public void Should_Disconnect_Input_Node_Property()
    {
        var core = new Core();
        var node1 = new Node();
        var node2 = new Node();

        core.DisconnectInput(node1, node2, PropertiesEnum.Genre);

        Assert.True(!node1?.Inputs.Any(x => x.GenreEnum == PropertiesEnum.Genre &&
                                        x.Source == node2.NodeId));
    }

    [Fact]
    public void Should_Connect_Output_Node_Property()
    {
        var core = new Core();
        var node1 = new Node();
        var node2 = new Node();

        core.ConnectOutput(node1, node2, PropertiesEnum.Genre);

        Assert.True(node1?.Outputs?.FirstOrDefault()?.Destiny == node2.NodeId);
    }

    [Fact]
    public void Should_Disconnect_Output_Node_Property()
    {
        var core = new Core();
        var node1 = new Node();
        var node2 = new Node();

        core.DisconnectInput(node1, node2, PropertiesEnum.Genre);

        Assert.True(!node1?.Outputs.Any(x => x.GenreEnum == PropertiesEnum.Genre &&
                                        x.Destiny == node2.NodeId));
    }

    //TODO: test for multiple connections & multiple disconnections
}