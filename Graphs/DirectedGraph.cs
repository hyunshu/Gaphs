/*
This file will inherit from GraphBase and implement specific behaviors for 
directed graphs.
*/

public class DirectedGraph : GraphBase
{
    // Implementation specific to directed graphs
    public override void AddVertex(string vertex)
    {
        throw new System.NotImplementedException();
    }

    public override void AddEdge(string startVertex, string endVertex, int weight)
    {
        throw new System.NotImplementedException();
    }

    public override void PrintGraph()
    {
        throw new System.NotImplementedException();
    }
}