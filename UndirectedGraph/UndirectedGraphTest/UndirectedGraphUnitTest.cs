using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UndirectedGraph;
using UndirectedGraph.Utility;
using Common.Utility;

namespace UndirectedGraph.Test.UnitTest
{
    [TestClass]
    public class UndirectedGraphUnitTest
    {
        // This example shows why we can't add an edge with the same node
        // Because when AddEdge, the dictionary will add the edge two times, then when we call ClearAdjacentEdges it will throw InvalidOperation Exception
        [TestMethod]
        public void TestClearAdjacentEdges()
        {
            var g = new UndirectedGraph<int, Edge<int>>();
            g.AddVertex(1);
            g.AddEdge(new Edge<int>(1, 1));
            g.ClearAdjacentEdges(1);
        }
    }
}
