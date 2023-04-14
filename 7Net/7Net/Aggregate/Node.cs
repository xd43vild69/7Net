using System;
namespace _7Net.Aggregate
{
    //It could be infer from UI
    public class Node : Band
    {
        public List<Connection> Inputs { get; set; }
        public List<Connection> Outputs { get; set; }
        public Guid NodeId { get; set; }

        public Node()
        {
            NodeId = new Guid();
            Inputs = new List<Connection>();
            Outputs = new List<Connection>();
        }

        public void ConnectInput(Guid source)
        {
            Inputs.Add(new Connection(source, NodeId));
        }

        public void DisconnectInput(Guid source)
        {
            Inputs.Remove(new Connection(source, NodeId));
        }

        public void ConnectOutput(Guid destination)
        {
            Outputs.Add(new Connection(NodeId, destination));
        }

        public void DisconnectOutput(Guid destination)
        {
            Outputs.Remove(new Connection(NodeId, destination));
        }
    }
}

