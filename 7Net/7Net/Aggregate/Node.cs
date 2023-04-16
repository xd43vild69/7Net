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
            NodeId = Guid.NewGuid();
            Inputs = new List<Connection>();
            Outputs = new List<Connection>();
        }

        public void ConnectInput(Guid inputId, PropertiesEnum property)
        {
            //TODO: a property could be only assign by 1 connection in time, else override.
            Inputs.Add(new Connection(inputId, NodeId, property));
        }

        public void DisconnectInput(Guid inputId, PropertiesEnum property)
        {
            Inputs.Remove(new Connection(inputId, NodeId, property));
        }

        public void ConnectOutput(Guid outputId, PropertiesEnum property)
        {
            Outputs.Add(new Connection(NodeId, outputId, property));
        }

        public void DisconnectOutput(Guid outputId, PropertiesEnum property)
        {
            Outputs.Remove(new Connection(NodeId, outputId, property));
        }
    }
}

