/*
This file will inherit from GraphBase and implement specific behaviors for 
undirected graphs.
*/

public class UndirectedGraph : GraphBase
{
    // Implementation specific to undirected graphs
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