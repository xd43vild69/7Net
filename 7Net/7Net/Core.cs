using _7Net.Aggregate;
using _7Net.Enums;

namespace _7Net;

public class Core
{
    public void ConnectInput(Node node1, Node node2, PropertiesEnum property)
    {
        node1.ConnectInput(node2.NodeId, property);
    }

    public void DisconnectInput(Node node1, Node node2, PropertiesEnum property)
    {
        node1.DisconnectInput(node2.NodeId, property);
    }
}

