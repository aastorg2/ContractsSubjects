using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UndirectedGraph;
using UndirectedGraph.Utility;
using Common.Utility4QuickGraph3;

namespace UndirectedGraph.Test.UnitTest
{
    [TestClass]
    public class UndirectedGraphUnitTest
    {
        [TestMethod]
        public void TestEdgeCountAndVerticeCountAfterAdd()
        {
            var g = new UndirectedGraph<int, Edge<int>>(false);
            g.AddVertex(1);
            g.AddVertex(2);
            g.AddEdge(new Edge<int>(1, 1));
            g.AddEdge(new Edge<int>(2, 2));
            g.AddEdge(new Edge<int>(1, 2));
            bool ret = g.AddVertex(3);
            Assert.IsTrue(g.EdgeCount == 3 && g.VertexCount == 3);
        }

        [TestMethod]
        public void TestClearAdjacentEdgesNoExistingNode()
        {
            var g = new UndirectedGraph<int, Edge<int>>(false);
            //g.AddVertex(1);
            g.ClearAdjacentEdges(1);

        }
        // This example shows why we can't add an edge with the same node
        // Because when AddEdge, the dictionary will add the edge two times, then when we call ClearAdjacentEdges it will throw InvalidOperation Exception -> this bug has been fixed in quickgraph 3.0
        [TestMethod]
        public void TestClearAdjacentEdges()
        {
            var g = new UndirectedGraph<int, Edge<int>>(true);
            g.AddVertex(1);
            g.AddEdge(new Edge<int>(1, 1));
            //g.ClearAdjacentEdges(1);
            Assert.IsTrue(g.EdgeCount == 1);
        }

        [TestMethod]
        public void TestContainsEdgeWithEdgeTypeSelfEdge()
        {
            var g = new UndirectedGraph<int, Edge<int>>(true);
            g.AddVertex(1);
            g.AddEdge(new Edge<int>(1, 1));
            Assert.IsTrue(g.ContainsEdge(1, 1));
        }

        [TestMethod]
        public void TestContainsEdgeWithWithOutSourceNode()
        {
            var g = new UndirectedGraph<int, Edge<int>>(true);
            g.AddVertex(1);
            //g.AddEdge(new Edge<int>(1, 1));
            Assert.IsTrue(g.ContainsEdge(2, 1));
        }
        [TestMethod]
        public void TestContainsEdgeWithEdgeType()
        {
            var g = new UndirectedGraph<int, Edge<int>>(true);
            g.AddVertex(1);
            g.AddVertex(2);
            g.AddEdge(new Edge<int>(1, 2));
            Assert.IsTrue(g.ContainsEdge(1, 2));
        }

        [TestMethod]
        public void TestContainsEdgeWithEdgeTypeReverseEdge()
        {
            var g = new UndirectedGraph<int, Edge<int>>(true);
            g.AddVertex(1);
            g.AddVertex(2);
            g.AddEdge(new Edge<int>(1, 2));
            Assert.IsTrue(g.ContainsEdge(2, 1));
        }
        [TestMethod]
        public void TestContainsEdgeWithEdgeTypeReverseEdgeTypeEdge()
        {
            var g = new UndirectedGraph<int, Edge<int>>(true);
            g.AddVertex(1);
            g.AddVertex(2);
            g.AddEdge(new Edge<int>(1, 2));
            Assert.IsTrue(g.ContainsEdge(new Edge<int>(1,2)));
        }

        [TestMethod]
        public void TestContainsEdgeWithEdgeWithNoTargetNode()
        {
            var g = new UndirectedGraph<int, Edge<int>>(true);
            g.AddVertex(1);
            g.AddVertex(2);
            g.AddEdge(new Edge<int>(1, 2));
            Assert.IsFalse(g.ContainsEdge(new Edge<int>(1, 3)));
        }
        [TestMethod]
        [ExpectedException(typeof(System.Collections.Generic.KeyNotFoundException))]
        public void TestContainsEdgeWithEdgeWithNoSourceNode()
        {
            var g = new UndirectedGraph<int, Edge<int>>(true);
            g.AddVertex(1);
            g.AddVertex(2);
            g.AddEdge(new Edge<int>(1, 2));
            Assert.IsFalse(g.ContainsEdge(new Edge<int>(3, 1)));
        }

        [TestMethod]
        public void TestContainsEdgeCountTrueParallelEdges()
        {
            var g = new UndirectedGraph<int, Edge<int>>(true);
            g.AddVertex(1);
            g.AddVertex(2);
            g.AddEdge(new Edge<int>(1, 2));
            g.AddEdge(new Edge<int>(2,1));
            Assert.IsTrue(g.EdgeCount == 2);
        }
        [TestMethod]
        public void TestContainsEdgeCountFalseParallelEdges()
        {
            var g = new UndirectedGraph<int, Edge<int>>(false);
            g.AddVertex(1);
            g.AddVertex(2);
            g.AddEdge(new Edge<int>(1, 2));
            g.AddEdge(new Edge<int>(2, 1));
            Assert.IsTrue(g.EdgeCount == 1);
        }
    }
}
