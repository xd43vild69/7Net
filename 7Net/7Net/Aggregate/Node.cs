using System;
using _7Net.Enums;

namespace _7Net.Aggregate
{
    public partial class Node : Band
    {
        public List<Connection> Inputs { get; set; }
        public List<Connection> Outputs { get; set; }
        public Guid NodeId { get; }

        public Node()
        {
            NodeId = new Guid();
            Inputs = new List<Connection>();
            Outputs = new List<Connection>();
        }

        public void ConnectInput(Guid sourceId, PropertiesEnum property)
        {
			//TODO: a property could be only assign by 1 connection in time, else override.
            Inputs.Add(new Connection(sourceId, NodeId, property));
        }

        public void DisconnectInput(Guid source, PropertiesEnum property)
        {
            Inputs.Remove(new Connection(source, NodeId, property));
        }

        public void ConnectOutput(Guid destination, PropertiesEnum property)
        {
            Outputs.Add(new Connection(NodeId, destination, property));
        }

        public void DisconnectOutput(Guid destination, PropertiesEnum property)
        {
            Outputs.Remove(new Connection(NodeId, destination, property));
        }
    }
}

