using _7Net.Aggregate;
using _7Net.Enums;

namespace _7Net;

public class Core
{
    private Node Node1 { get; }
    private Node Node2 { get; }
    private PropertiesEnum Property {get;}

    public Core(Node node1, Node node2, PropertiesEnum property)
    {
        Node1 = node1;
        Node2 = node2;
        Property = property;
    }

    public void ConnectNodes()
    {
        Node2.ConnectInput(Node1.NodeId, Property);
    }

    public void DisconnectInput()
    {
        Node2.DisconnectInput(Node1.NodeId, Property);
    }
}

