using System;
using System.Collections.Generic;

namespace EmployeeLibrary
{
    public interface IGraph<T> where T : IComparable<T>
    {
        
        bool IsDirected { get; }

        
        bool IsWeighted { get; }
        
        int VerticesCount { get; }
        
        int EdgesCount { get; }
        
        IEnumerable<T> Vertices { get; }
        
        IEnumerable<IEdge<T>> Edges { get; }
        
        IEnumerable<IEdge<T>> IncomingEdges(T vertex);

       
        IEnumerable<IEdge<T>> OutgoingEdges(T vertex);
        
        bool AddEdge(T firstVertex, T secondVertex);
        
        bool RemoveEdge(T firstVertex, T secondVertex);
        
        void AddVertices(IList<T> collection);
        
        bool AddVertex(T vertex);
        
        bool RemoveVertex(T vertex);
        
        bool HasEdge(T firstVertex, T secondVertex);
        
        bool HasVertex(T vertex);
        
        DLinkedList<T> Neighbours(T vertex);
        
        int Degree(T vertex);
        
        string ToReadable();
        
        IEnumerable<T> DepthFirstWalk();
        
        IEnumerable<T> DepthFirstWalk(T startingVertex);
        
        void Clear();
    }

}
