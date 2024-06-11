/*
Define an abstract base class for common graph functionalities.
*/

public abstract class GraphBase
{
    public abstract void AddVertex(string vertex);
    public abstract void AddEdge(string startVertex, string endVertex, int weight);
    public abstract void PrintGraph();
}