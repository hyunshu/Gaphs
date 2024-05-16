using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        DirectedGraph graph = new DirectedGraph();
        graph.PrintGraph();
    }
}


//UndirectedGraph
public class UndirectedGraph
{
    private Dictionary<string, Dictionary<string, int>> adjacencyList;

    public UndirectedGraph()
    {
        adjacencyList = new Dictionary<string, Dictionary<string, int>>();
    }

    public void AddVertex(string vertex)
    {
        if (!adjacencyList.ContainsKey(vertex))
        {
            adjacencyList[vertex] = new Dictionary<string, int>();
        } else {
            Console.WriteLine("Vertex already exists!");
        }
    }

    public void AddEdge(string vertex1, string vertex2, int weight)
    {
        AddVertex(vertex1);
        AddVertex(vertex2);
        adjacencyList[vertex1][vertex2] = weight;
        adjacencyList[vertex2][vertex1] = weight;
    }

    public void PrintGraph()
    {
        if (adjacencyList.Count == 0)
        {
            Console.WriteLine("Graph is EMPTY!");
            return;
        }
        foreach (var vertex in adjacencyList)
        {
            Console.Write(vertex.Key + " is connected to: ");
            foreach (var edge in vertex.Value)
            {
                Console.Write($"({edge.Key}, {edge.Value}), ");
            }
            Console.WriteLine();
        }
    }
}

//Directed Graph
public class DirectedGraph
{
    private Dictionary<string, Dictionary<string, int>> adjacencyList;

    public DirectedGraph()
    {
        adjacencyList = new Dictionary<string, Dictionary<string, int>>();
    }

    public void AddVertex(string vertex)
    {
        if (!adjacencyList.ContainsKey(vertex))
        {
            adjacencyList[vertex] = new Dictionary<string, int>();
        } else {
            Console.WriteLine("Vertex already exists!");
        }
    }

    public void AddEdge(string vertex1, string vertex2, int weight)
    {
        AddVertex(vertex1);
        AddVertex(vertex2);
        adjacencyList[vertex1][vertex2] = weight;
    }

    public void PrintGraph()
    {
        if (adjacencyList.Count == 0)
        {
            Console.WriteLine("Graph is EMTPY!");
            return;
        }
        foreach (var vertex in adjacencyList)
        {
            Console.Write(vertex.Key + " is connected to: ");
            foreach (var edge in vertex.Value)
            {
                Console.Write($"({edge.Key}, {edge.Value}), ");
            }
            Console.WriteLine();
        }
    }
}