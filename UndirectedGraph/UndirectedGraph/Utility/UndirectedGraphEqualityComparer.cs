using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Common.Utility;

namespace UndirectedGraph.Utility
{
    public class UndirectedGraphEqualityComparer : EqualityComparer<UndirectedGraph<int, Edge<int>>>
    {
        public override bool Equals(UndirectedGraph.UndirectedGraph<int, Edge<int>> g1, UndirectedGraph.UndirectedGraph<int, Edge<int>> g2)
        {
            if (g1 == null )
            {
                return g2 == null;
            }
            else if (g2 == null)
            {
                return false;
            }
            else
            {
                
                if (g1.AllowParallelEdges != g2.AllowParallelEdges)
                {
                    return false;
                }

                if (g1.VertexCount != g2.VertexCount)
                {
                    return false;
                }

                if (g1.EdgeCount != g2.EdgeCount)
                {
                    return false;
                }
                
                int[] vertices1 = g1.Vertices.ToArray();
                for (int i = 0; i < vertices1.Length; i++)
                {
                    if (!g2.ContainsVertex(vertices1[i]))
                    {
                        return false;
                    }
                    else
                    {
                        
                        foreach (Edge<int> ve in g1.AdjacentEdges(vertices1[i]))
                        {
                            if (!g2.ContainsEdge(ve.Source, ve.Target))
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;   
            }
        }

        public override int GetHashCode(UndirectedGraph.UndirectedGraph<int, Edge<int>> g)
        {
            int hash = 0;

            if (g != null)
            {
                var edges = g.Edges;
                
                foreach (var e in edges)
                {
                    if (e != null)
                    {
                        hash += e.Source * e.Target;
                        
                    }
                }
            }

            return hash;
        }
    }
}
