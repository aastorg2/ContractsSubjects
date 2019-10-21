using System;
using System.Text;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Exceptions;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using UndirectedGraph;
using Common.Utility4QuickGraph3;
using PexAPIWrapper;
using NUnit.Framework;

namespace UndirectedGraph.Test
{
    [TestFixture, PexClass]
    public partial class UndirectedGraphContractTest
    {
        [PexMethod]
        public void PUT_AddVertexContract([PexAssumeUnderTest]UndirectedGraph.UndirectedGraph<int, Edge<int>> ug, int x)
        {
            
            AssumePrecondition.IsTrue(true);

            int Old_ugVertexCount = ug.VertexCount;
            int Old_ugEdgeCount = ug.EdgeCount;
            //int Old_ugAdjacentDegree = -1;
            //int Old_ugAdjacentDegree = ug.ContainsVertex(x)? ug.AdjacentDegree(x) : PexChoose.Value<int>("old_ugAdjacentDegree");
            int Old_x = x;
            //bool Old_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool Old_ugContainsVertexX = ug.ContainsVertex(x);
            bool Old_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool Old_ugIsEdgesEmpty = ug.IsEdgesEmpty;
            //code
            bool New_Ret = ug.AddVertex(x);

            int New_ugVertexCount = ug.VertexCount;
            int New_ugEdgeCount = ug.EdgeCount;
            int New_ugAdjacentDegree = ug.AdjacentDegree(x);
            int New_x = x;
            //bool New_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool New_ugContainsVertexX = ug.ContainsVertex(x);
            bool New_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool New_ugIsEdgesEmpty = ug.IsEdgesEmpty;
            
            PexObserve.ValueForViewing("$old_ug_vertex_count", Old_ugVertexCount);
            PexObserve.ValueForViewing("$new_ug_vertex_count", New_ugVertexCount);
            PexObserve.ValueForViewing("$old_ug_edge_count", Old_ugEdgeCount);
            PexObserve.ValueForViewing("$new_ug_edge_count", New_ugEdgeCount);
            //PexObserve.ValueForViewing("$old_ug_adjacent_degree", Old_ugAdjacentDegree);
            PexObserve.ValueForViewing("$new_ug_adjacent_degree", New_ugAdjacentDegree);
            PexObserve.ValueForViewing("$old_ug_x", Old_x);
            PexObserve.ValueForViewing("$new_ug_x", New_x);
            PexObserve.ValueForViewing("$old_ug_contains_x", Old_ugContainsVertexX);
            PexObserve.ValueForViewing("$new_ug_contains_x", New_ugContainsVertexX);
            //PexObserve.ValueForViewing("$old_ug_allow_parallel_edges", Old_ugAllowParallelEdges);
            //PexObserve.ValueForViewing("$new_ug_allow_parallel_edges", New_ugAllowParallelEdges);
            PexObserve.ValueForViewing("$Old_ugIsVerticesEmpty", Old_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$New_ugIsVerticesEmpty", New_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$Olds_IsEdgesEmpty", Old_ugIsEdgesEmpty);
            PexObserve.ValueForViewing("$New_IsEdgesEmpty", New_ugIsEdgesEmpty);
            PexObserve.ValueForViewing("$New_Ret", New_Ret);

            Assert.True(((New_ugContainsVertexX && New_ugEdgeCount == Old_ugEdgeCount && New_x == Old_x && (!(New_ugIsVerticesEmpty)) && New_ugVertexCount == 1 + Old_ugVertexCount && New_ugAdjacentDegree == 0 && (!(Old_ugContainsVertexX)) && (!(New_ugEdgeCount == New_ugVertexCount)) && (!(New_ugAdjacentDegree == New_ugVertexCount)) && New_Ret)|| (!New_Ret)));
        }

        [PexMethod]
        public void PUT_RemoveVertexContract([PexAssumeUnderTest]UndirectedGraph.UndirectedGraph<int, Edge<int>> ug, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_ugVertexCount = ug.VertexCount;
            int Old_ugEdgeCount = ug.EdgeCount;
            //int Old_ugAdjacentDegree = ug.ContainsVertex(x) ? ug.AdjacentDegree(x) : PexChoose.Value<int>("old_ugAdjacentDegree");
            int Old_x = x;
            bool Old_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool Old_ugContainsVertexX = ug.ContainsVertex(x);
            bool Old_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool Old_ugIsEdgesEmpty = ug.IsEdgesEmpty;
            

            //code
            bool New_Ret = ug.RemoveVertex(x);

            int New_ugVertexCount = ug.VertexCount;
            int New_ugEdgeCount = ug.EdgeCount;
            //int New_ugAdjacentDegree = ug.ContainsVertex(x) ? ug.AdjacentDegree(x) : PexChoose.Value<int>("new_ugAdjacentDegree"); ;
            int New_x = x;
            bool New_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool New_ugContainsVertexX = ug.ContainsVertex(x);
            bool New_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool New_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            PexObserve.ValueForViewing("$old_ug_vertex_count", Old_ugVertexCount);
            PexObserve.ValueForViewing("$new_ug_vertex_count", New_ugVertexCount);
            PexObserve.ValueForViewing("$old_ug_edge_count", Old_ugEdgeCount);
            PexObserve.ValueForViewing("$new_ug_edge_count", New_ugEdgeCount);
            //PexObserve.ValueForViewing("$old_ug_adjacent_degree", Old_ugAdjacentDegree);
            //PexObserve.ValueForViewing("$new_ug_adjacent_degree", New_ugAdjacentDegree);
            PexObserve.ValueForViewing("$old_ug_x", Old_x);
            PexObserve.ValueForViewing("$new_ug_x", New_x);
            PexObserve.ValueForViewing("$new_ret", New_Ret);
            PexObserve.ValueForViewing("$old_ug_contains_x", Old_ugContainsVertexX);
            PexObserve.ValueForViewing("$new_ug_contains_x", New_ugContainsVertexX);
            PexObserve.ValueForViewing("$old_ug_allow_parallel_edges", Old_ugAllowParallelEdges);
            PexObserve.ValueForViewing("$new_ug_allow_parallel_edges", New_ugAllowParallelEdges);
            PexObserve.ValueForViewing("$Old_ugIsVerticesEmpty", Old_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$New_ugIsVerticesEmpty", New_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$Olds_IsEdgesEmpty", Old_ugIsEdgesEmpty);
            PexObserve.ValueForViewing("$New_IsEdgesEmpty", New_ugIsEdgesEmpty);

            Assert.True(false);
        }

        [PexMethod]
        public void PUT_ClearAdjacentEdgesContract([PexAssumeUnderTest]UndirectedGraph.UndirectedGraph<int, Edge<int>> ug, int x)
        {
            AssumePrecondition.IsTrue(ug.ContainsVertex(x));

            int Old_ugVertexCount = ug.VertexCount;
            int Old_ugEdgeCount = ug.EdgeCount;
            int Old_ugAdjacentDegree = ug.AdjacentDegree(x);
            int Old_x = x;
            //bool Old_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool Old_ugContainsVertexX = ug.ContainsVertex(x);
            bool Old_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool Old_ugIsEdgesEmpty = ug.IsEdgesEmpty;
            //code
            ug.ClearAdjacentEdges(x);

            int New_ugVertexCount = ug.VertexCount;
            int New_ugEdgeCount = ug.EdgeCount;
            int New_ugAdjacentDegree = ug.AdjacentDegree(x);
            int New_x = x;
            bool New_ugContainsVertexX = ug.ContainsVertex(x);
            bool New_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool New_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            PexObserve.ValueForViewing("$old_ug_vertex_count", Old_ugVertexCount);
            PexObserve.ValueForViewing("$new_ug_vertex_count", New_ugVertexCount);
            PexObserve.ValueForViewing("$old_ug_edge_count", Old_ugEdgeCount);
            PexObserve.ValueForViewing("$new_ug_edge_count", New_ugEdgeCount);
            PexObserve.ValueForViewing("$old_ug_adjacent_degree", Old_ugAdjacentDegree);
            PexObserve.ValueForViewing("$new_ug_adjacent_degree", New_ugAdjacentDegree);
            PexObserve.ValueForViewing("$old_ug_x", Old_x);
            PexObserve.ValueForViewing("$new_ug_x", New_x);
            PexObserve.ValueForViewing("$old_ug_contains_x", Old_ugContainsVertexX);
            PexObserve.ValueForViewing("$new_ug_contains_x", New_ugContainsVertexX);
            PexObserve.ValueForViewing("$Old_ugIsVerticesEmpty", Old_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$New_ugIsVerticesEmpty", New_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$Olds_IsEdgesEmpty", Old_ugIsEdgesEmpty);
            PexObserve.ValueForViewing("$New_IsEdgesEmpty", New_ugIsEdgesEmpty);
            //PexObserve.ValueForViewing("$old_ug_allow_parallel_edges", Old_ugAllowParallelEdges);
            //PexObserve.ValueForViewing("$new_ug_allow_parallel_edges", New_ugAllowParallelEdges);
            Assert.True(false);
        }

        [PexMethod]
        public void PUT_ContainsEdgeContract([PexAssumeUnderTest]UndirectedGraph.UndirectedGraph<int, Edge<int>> ug, int source, int target)
        {
            AssumePrecondition.IsTrue(ug.ContainsVertex(source));

            int Old_ugVertexCount = ug.VertexCount;
            int Old_ugEdgeCount = ug.EdgeCount;
            int Old_ugAdjacentDegreeSource = ug.AdjacentDegree(source);
            //int Old_ugAdjacentDegreeTarget = ug.ContainsVertex(target) ? ug.AdjacentDegree(target) : PexChoose.Value<int>("old_ugAdjacentDegree");
            int Old_source = source;
            int Old_target = target;
            //bool Old_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool Old_ugContainsVertexSource = ug.ContainsVertex(source);
            bool Old_ugContainsVertexTarget = ug.ContainsVertex(target);
            bool Old_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool Old_ugIsEdgesEmpty = ug.IsEdgesEmpty;
            bool Old_ContainsEdgeSrcTar = ug.ContainsEdge(source, target);

            //code
            bool New_Ret = ug.ContainsEdge(new Edge<int>(source, target));

            int New_ugVertexCount = ug.VertexCount;
            int New_ugEdgeCount = ug.EdgeCount;
            int New_ugAdjacentDegreeSource = ug.AdjacentDegree(source);
            //int New_ugAdjacentDegreeTarget = ug.ContainsVertex(target) ? ug.AdjacentDegree(target) : PexChoose.Value<int>("new_ugAdjacentDegree");
            int New_source = source;
            int New_target = target;
            //bool New_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool New_ugContainsVertexSource = ug.ContainsVertex(source);
            bool New_ugContainsVertexTarget = ug.ContainsVertex(target);
            bool New_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool New_ugIsEdgesEmpty = ug.IsEdgesEmpty;
            bool New_ContainsEdgeSrcTar = ug.ContainsEdge(source, target);

            PexObserve.ValueForViewing("$old_ug_vertex_count", Old_ugVertexCount);
            PexObserve.ValueForViewing("$new_ug_vertex_count", New_ugVertexCount);
            PexObserve.ValueForViewing("$old_ug_edge_count", Old_ugEdgeCount);
            PexObserve.ValueForViewing("$new_ug_edge_count", New_ugEdgeCount);
            PexObserve.ValueForViewing("$old_ug_adjacent_degree_source", Old_ugAdjacentDegreeSource);
            PexObserve.ValueForViewing("$new_ug_adjacent_degree_source", New_ugAdjacentDegreeSource);
            //PexObserve.ValueForViewing("$old_ug_adjacent_degree_target", Old_ugAdjacentDegreeTarget);
            //PexObserve.ValueForViewing("$new_ug_adjacent_degree_target", New_ugAdjacentDegreeTarget);
            PexObserve.ValueForViewing("$old_ug_source", Old_source);
            PexObserve.ValueForViewing("$new_ug_source", New_source);
            PexObserve.ValueForViewing("$old_ug_target", Old_target);
            PexObserve.ValueForViewing("$new_ug_target", New_target);
            PexObserve.ValueForViewing("$new_ret", New_Ret);
            PexObserve.ValueForViewing("$old_ug_contains_source", Old_ugContainsVertexSource);
            PexObserve.ValueForViewing("$new_ug_contains_source", New_ugContainsVertexSource);
            PexObserve.ValueForViewing("$old_ug_contains_target", Old_ugContainsVertexTarget);
            PexObserve.ValueForViewing("$new_ug_contains_target", New_ugContainsVertexTarget);

            PexObserve.ValueForViewing("$Old_ContainsEdge", Old_ContainsEdgeSrcTar);
            PexObserve.ValueForViewing("$New_ContainsEdge", New_ContainsEdgeSrcTar);

            PexObserve.ValueForViewing("$Old_ugIsVerticesEmpty", Old_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$New_ugIsVerticesEmpty", New_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$Olds_IsEdgesEmpty", Old_ugIsEdgesEmpty);
            PexObserve.ValueForViewing("$New_IsEdgesEmpty", New_ugIsEdgesEmpty);
            //PexObserve.ValueForViewing("$old_ug_allow_parallel_edges", Old_ugAllowParallelEdges);
            //PexObserve.ValueForViewing("$new_ug_allow_parallel_edges", New_ugAllowParallelEdges);

            Assert.True(false);
        }

        [PexMethod]
        public void PUT_ContainsEdgeIntContract([PexAssumeUnderTest]UndirectedGraph.UndirectedGraph<int, Edge<int>> ug, int source, int target)
        {
            AssumePrecondition.IsTrue(ug.ContainsVertex(source));

            int Old_ugVertexCount = ug.VertexCount;
            int Old_ugEdgeCount = ug.EdgeCount;
            int Old_ugAdjacentDegreeSource = ug.AdjacentDegree(source);
            //int Old_ugAdjacentDegreeTarget = ug.ContainsVertex(target) ? ug.AdjacentDegree(target) : PexChoose.Value<int>("old_ugAdjacentDegree") ;
            int Old_source = source;
            int Old_target = target;
            //bool Old_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool Old_ugContainsVertexSource = ug.ContainsVertex(source);
            bool Old_ugContainsVertexTarget = ug.ContainsVertex(target);
            bool Old_ContainsEdgeSrcTar = ug.ContainsEdge(source, target);
            bool Old_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool Old_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            //code
            bool New_Ret = ug.ContainsEdge(source, target);

            int New_ugVertexCount = ug.VertexCount;
            int New_ugEdgeCount = ug.EdgeCount;
            int New_ugAdjacentDegreeSource = ug.AdjacentDegree(source);
            //int New_ugAdjacentDegreeTarget = ug.ContainsVertex(target) ? ug.AdjacentDegree(target) : PexChoose.Value<int>("new_ugAdjacentDegree");
            int New_source = source;
            int New_target = target;
            //bool New_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool New_ugContainsVertexSource = ug.ContainsVertex(source);
            bool New_ugContainsVertexTarget = ug.ContainsVertex(target);
            bool New_ContainsEdgeSrcTar = ug.ContainsEdge(source, target);
            bool New_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool New_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            PexObserve.ValueForViewing("$old_ug_vertex_count", Old_ugVertexCount);
            PexObserve.ValueForViewing("$new_ug_vertex_count", New_ugVertexCount);
            PexObserve.ValueForViewing("$old_ug_edge_count", Old_ugEdgeCount);
            PexObserve.ValueForViewing("$new_ug_edge_count", New_ugEdgeCount);
            PexObserve.ValueForViewing("$old_ug_adjacent_degree_source", Old_ugAdjacentDegreeSource);
            PexObserve.ValueForViewing("$new_ug_adjacent_degree_source", New_ugAdjacentDegreeSource);
            //PexObserve.ValueForViewing("$old_ug_adjacent_degree_target", Old_ugAdjacentDegreeTarget);
            //PexObserve.ValueForViewing("$new_ug_adjacent_degree_target", New_ugAdjacentDegreeTarget);
            PexObserve.ValueForViewing("$old_ug_source", Old_source);
            PexObserve.ValueForViewing("$new_ug_source", New_source);
            PexObserve.ValueForViewing("$old_ug_target", Old_target);
            PexObserve.ValueForViewing("$new_ug_target", New_target);
            PexObserve.ValueForViewing("$new_ret", New_Ret);
            PexObserve.ValueForViewing("$old_ug_contains_source", Old_ugContainsVertexSource);
            PexObserve.ValueForViewing("$new_ug_contains_source", New_ugContainsVertexSource);
            PexObserve.ValueForViewing("$old_ug_contains_target", Old_ugContainsVertexTarget);
            PexObserve.ValueForViewing("$new_ug_contains_target", New_ugContainsVertexTarget);
            PexObserve.ValueForViewing("$Old_ContainsEdge", Old_ContainsEdgeSrcTar);
            PexObserve.ValueForViewing("$New_ContainsEdge", New_ContainsEdgeSrcTar);
            //PexObserve.ValueForViewing("$old_ug_allow_parallel_edges", Old_ugAllowParallelEdges);
            //PexObserve.ValueForViewing("$new_ug_allow_parallel_edges", New_ugAllowParallelEdges);
            PexObserve.ValueForViewing("$Old_ugIsVerticesEmpty", Old_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$New_ugIsVerticesEmpty", New_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$Olds_IsEdgesEmpty", Old_ugIsEdgesEmpty);
            PexObserve.ValueForViewing("$New_IsEdgesEmpty", New_ugIsEdgesEmpty);
            
            Assert.True(false);
        }

        [PexMethod]
        public void PUT_AdjacentEdgeContract([PexAssumeUnderTest]UndirectedGraph.UndirectedGraph<int, Edge<int>> ug, int x, int index)
        {
            AssumePrecondition.IsTrue(ug.ContainsVertex(x) && (index < ug.AdjacentDegree(x)) && (index >= 0));

            int Old_ugVertexCount = ug.VertexCount;
            int Old_ugEdgeCount = ug.EdgeCount;
            int Old_ugAdjacentDegree = ug.AdjacentDegree(x);
            int Old_x = x;
            int Old_index = index;
            //bool Old_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool Old_ugContainsVertexX = ug.ContainsVertex(x);
            bool Old_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool Old_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            //code
            Edge<int> e = ug.AdjacentEdge(x, index);
            
            int New_Ret_Source = e.Source;
            int New_Ret_Target = e.Target;

            int New_ugVertexCount = ug.VertexCount;
            int New_ugEdgeCount = ug.EdgeCount;
            int New_ugAdjacentDegree = ug.AdjacentDegree(x);
            int New_x = x;
            int New_index = index;
            //bool New_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool New_ugContainsVertexX = ug.ContainsVertex(x);
            bool New_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool New_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            PexObserve.ValueForViewing("$old_ug_vertex_count", Old_ugVertexCount);
            PexObserve.ValueForViewing("$new_ug_vertex_count", New_ugVertexCount);
            PexObserve.ValueForViewing("$old_ug_edge_count", Old_ugEdgeCount);
            PexObserve.ValueForViewing("$new_ug_edge_count", New_ugEdgeCount);
            PexObserve.ValueForViewing("$old_ug_adjacent_degree", Old_ugAdjacentDegree);
            PexObserve.ValueForViewing("$new_ug_adjacent_degree", New_ugAdjacentDegree);
            PexObserve.ValueForViewing("$old_ug_x", Old_x);
            PexObserve.ValueForViewing("$new_ug_x", New_x);
            PexObserve.ValueForViewing("$old_ug_index", Old_index);
            PexObserve.ValueForViewing("$new_ug_index", New_index);
            PexObserve.ValueForViewing("$new_ret_source", New_Ret_Source);
            PexObserve.ValueForViewing("$new_ret_target", New_Ret_Target);
            PexObserve.ValueForViewing("$old_ug_contains_x", Old_ugContainsVertexX);
            PexObserve.ValueForViewing("$new_ug_contains_x", New_ugContainsVertexX);
            
            PexObserve.ValueForViewing("$Old_ugIsVerticesEmpty", Old_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$New_ugIsVerticesEmpty", New_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$Olds_IsEdgesEmpty", Old_ugIsEdgesEmpty);
            PexObserve.ValueForViewing("$New_IsEdgesEmpty", New_ugIsEdgesEmpty);
            //PexObserve.ValueForViewing("$old_ug_allow_parallel_edges", Old_ugAllowParallelEdges);
            //PexObserve.ValueForViewing("$new_ug_allow_parallel_edges", New_ugAllowParallelEdges);

            Assert.True(false);
        }

        [PexMethod]
        public void PUT_IsVerticesEmptyContract([PexAssumeUnderTest]UndirectedGraph.UndirectedGraph<int, Edge<int>> ug)
        {
            AssumePrecondition.IsTrue(true);
            
            int Old_ugVertexCount = ug.VertexCount; // opportunity to synthesie ug.VertexCount > 0 -> !New_Ret
            int Old_ugEdgeCount = ug.EdgeCount;
            //bool Old_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool Old_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool Old_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            //code
            bool New_Ret = ug.IsVerticesEmpty;

            int New_ugVertexCount = ug.VertexCount;
            int New_ugEdgeCount = ug.EdgeCount;
            //bool New_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool New_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool New_ugIsEdgesEmpty = ug.IsEdgesEmpty;


            PexObserve.ValueForViewing("$old_ug_vertex_count", Old_ugVertexCount);
            PexObserve.ValueForViewing("$new_ug_vertex_count", New_ugVertexCount);
            PexObserve.ValueForViewing("$old_ug_edge_count", Old_ugEdgeCount);
            PexObserve.ValueForViewing("$new_ug_edge_count", New_ugEdgeCount);
            PexObserve.ValueForViewing("$new_ret", New_Ret);
            //PexObserve.ValueForViewing("$old_ug_allow_parallel_edges", Old_ugAllowParallelEdges);
            //PexObserve.ValueForViewing("$new_ug_allow_parallel_edges", New_ugAllowParallelEdges);
            PexObserve.ValueForViewing("$Old_ugIsVerticesEmpty", Old_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$New_ugIsVerticesEmpty", New_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$Olds_IsEdgesEmpty", Old_ugIsEdgesEmpty);
            PexObserve.ValueForViewing("$New_IsEdgesEmpty", New_ugIsEdgesEmpty);
            Assert.True(false);
        }

        [PexMethod]
        public void PUT_VertexCountContract([PexAssumeUnderTest]UndirectedGraph.UndirectedGraph<int, Edge<int>> ug)
        {
            AssumePrecondition.IsTrue(true);

            int Old_ugVertexCount = ug.VertexCount;
            int Old_ugEdgeCount = ug.EdgeCount;
            //bool Old_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool Old_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool Old_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            //code
            int New_Ret = ug.VertexCount;

            int New_ugVertexCount = ug.VertexCount;
            int New_ugEdgeCount = ug.EdgeCount;
            //bool New_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool New_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool New_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            PexObserve.ValueForViewing("$old_ug_vertex_count", Old_ugVertexCount);
            PexObserve.ValueForViewing("$new_ug_vertex_count", New_ugVertexCount);
            PexObserve.ValueForViewing("$old_ug_edge_count", Old_ugEdgeCount);
            PexObserve.ValueForViewing("$new_ug_edge_count", New_ugEdgeCount);
            PexObserve.ValueForViewing("$new_ret", New_Ret);
            
            //PexObserve.ValueForViewing("$old_ug_allow_parallel_edges", Old_ugAllowParallelEdges);
            //PexObserve.ValueForViewing("$new_ug_allow_parallel_edges", New_ugAllowParallelEdges);
            
            PexObserve.ValueForViewing("$Old_ugIsVerticesEmpty", Old_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$New_ugIsVerticesEmpty", New_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$Olds_IsEdgesEmpty", Old_ugIsEdgesEmpty);
            PexObserve.ValueForViewing("$New_IsEdgesEmpty", New_ugIsEdgesEmpty);
            Assert.True(false);
        }

        [PexMethod]
        public void PUT_ContainsVertexContract([PexAssumeUnderTest]UndirectedGraph.UndirectedGraph<int, Edge<int>> ug, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_ugVertexCount = ug.VertexCount;
            int Old_ugEdgeCount = ug.EdgeCount;
            int Old_ugAdjacentDegree = ug.ContainsVertex(x) ? ug.AdjacentDegree(x) : -1;
            int Old_x = x;
            //bool Old_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool Old_ugContainsVertexX = ug.ContainsVertex(x);
            bool Old_Ret = PexChoose.Value<bool>("default_Ret");
            bool Old_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool Old_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            //code
            bool New_Ret = ug.ContainsVertex(x);

            int New_ugVertexCount = ug.VertexCount;
            int New_ugEdgeCount = ug.EdgeCount;
            int New_ugAdjacentDegree = ug.ContainsVertex(x) ? ug.AdjacentDegree(x) : -1;
            int New_x = x;
            //bool New_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool New_ugContainsVertexX = ug.ContainsVertex(x);
            bool New_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool New_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            PexObserve.ValueForViewing("$old_ug_vertex_count", Old_ugVertexCount);
            PexObserve.ValueForViewing("$new_ug_vertex_count", New_ugVertexCount);
            PexObserve.ValueForViewing("$old_ug_edge_count", Old_ugEdgeCount);
            PexObserve.ValueForViewing("$new_ug_edge_count", New_ugEdgeCount);
            PexObserve.ValueForViewing("$old_ug_adjacent_degree", Old_ugAdjacentDegree);
            PexObserve.ValueForViewing("$new_ug_adjacent_degree", New_ugAdjacentDegree);
            PexObserve.ValueForViewing("$old_ug_x", Old_x);
            PexObserve.ValueForViewing("$new_ug_x", New_x);
            PexObserve.ValueForViewing("$old_ret", Old_Ret);
            PexObserve.ValueForViewing("$new_ret", New_Ret);
            PexObserve.ValueForViewing("$old_ug_contains_x", Old_ugContainsVertexX);
            PexObserve.ValueForViewing("$new_ug_contains_x", New_ugContainsVertexX);
            //PexObserve.ValueForViewing("$old_ug_allow_parallel_edges", Old_ugAllowParallelEdges);
            //PexObserve.ValueForViewing("$new_ug_allow_parallel_edges", New_ugAllowParallelEdges);
            PexObserve.ValueForViewing("$Old_ugIsVerticesEmpty", Old_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$New_ugIsVerticesEmpty", New_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$Olds_IsEdgesEmpty", Old_ugIsEdgesEmpty);
            PexObserve.ValueForViewing("$New_IsEdgesEmpty", New_ugIsEdgesEmpty);
            
            Assert.True(false);
        }

        [PexMethod]
        public void PUT_AddEdgeContract([PexAssumeUnderTest]UndirectedGraph.UndirectedGraph<int, Edge<int>> ug, int source, int target)
        {
            AssumePrecondition.IsTrue(ug.ContainsVertex(source) && ug.ContainsVertex(target));

            int Old_ugVertexCount = ug.VertexCount;
            int Old_ugEdgeCount = ug.EdgeCount;
            int Old_ugAdjacentDegreeSource = ug.AdjacentDegree(source);
            int Old_ugAdjacentDegreeTarget = ug.AdjacentDegree(target);
            int Old_source = source;
            int Old_target = target;
            //bool Old_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool Old_ugContainsVertexSource = ug.ContainsVertex(source);
            bool Old_ugContainsVertexTarget = ug.ContainsVertex(target);
            
            bool Old_ContainsEdgeSrcTar = ug.ContainsEdge(source, target);
            bool Old_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool Old_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            //code
            bool New_Ret = ug.AddEdge(new Edge<int>(source, target));

            int New_ugVertexCount = ug.VertexCount;
            int New_ugEdgeCount = ug.EdgeCount;
            int New_ugAdjacentDegreeSource = ug.AdjacentDegree(source);
            int New_ugAdjacentDegreeTarget = ug.AdjacentDegree(target);
            int New_source = source;
            int New_target = target;
            
            //bool New_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool New_ugContainsVertexSource = ug.ContainsVertex(source);
            bool New_ugContainsVertexTarget = ug.ContainsVertex(target);
            bool New_ContainsEdgeSrcTar = ug.ContainsEdge(source, target);
            bool New_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool New_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            PexObserve.ValueForViewing("$old_ug_vertex_count", Old_ugVertexCount);
            PexObserve.ValueForViewing("$new_ug_vertex_count", New_ugVertexCount);
            PexObserve.ValueForViewing("$old_ug_edge_count", Old_ugEdgeCount);
            PexObserve.ValueForViewing("$new_ug_edge_count", New_ugEdgeCount);
            PexObserve.ValueForViewing("$old_ug_adjacent_degree_source", Old_ugAdjacentDegreeSource);
            PexObserve.ValueForViewing("$new_ug_adjacent_degree_source", New_ugAdjacentDegreeSource);
            PexObserve.ValueForViewing("$old_ug_adjacent_degree_target", Old_ugAdjacentDegreeTarget);
            PexObserve.ValueForViewing("$new_ug_adjacent_degree_target", New_ugAdjacentDegreeTarget);
            PexObserve.ValueForViewing("$old_ug_source", Old_source);
            PexObserve.ValueForViewing("$new_ug_source", New_source);
            PexObserve.ValueForViewing("$old_ug_target", Old_target);
            PexObserve.ValueForViewing("$new_ug_target", New_target);
            PexObserve.ValueForViewing("$new_ret", New_Ret);
            PexObserve.ValueForViewing("$old_ug_contains_source", Old_ugContainsVertexSource);
            PexObserve.ValueForViewing("$new_ug_contains_source", New_ugContainsVertexSource);
            PexObserve.ValueForViewing("$old_ug_contains_target", Old_ugContainsVertexTarget);
            PexObserve.ValueForViewing("$new_ug_contains_target", New_ugContainsVertexTarget);
            //PexObserve.ValueForViewing("$old_ug_allow_parallel_edges", Old_ugAllowParallelEdges);
            //PexObserve.ValueForViewing("$new_ug_allow_parallel_edges", New_ugAllowParallelEdges);
            PexObserve.ValueForViewing("$Old_ContainsEdgeSrcTar", Old_ContainsEdgeSrcTar);
            PexObserve.ValueForViewing("$New_ContainsEdgeSrcTar", New_ContainsEdgeSrcTar);
            
            PexObserve.ValueForViewing("$Old_ugIsVerticesEmpty", Old_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$New_ugIsVerticesEmpty", New_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$Olds_IsEdgesEmpty", Old_ugIsEdgesEmpty);
            PexObserve.ValueForViewing("$New_IsEdgesEmpty", New_ugIsEdgesEmpty);

            Assert.True(false);
        }

        [PexMethod]
        public void PUT_RemoveEdgeContract([PexAssumeUnderTest]UndirectedGraph.UndirectedGraph<int, Edge<int>> ug, int source, int target)
        {
            AssumePrecondition.IsTrue(ug.ContainsVertex(source));

            int Old_ugVertexCount = ug.VertexCount;
            int Old_ugEdgeCount = ug.EdgeCount;
            int Old_ugAdjacentDegreeSource = ug.AdjacentDegree(source);
            int Old_ugAdjacentDegreeTarget = ug.AdjacentDegree(target);
            int Old_source = source;
            int Old_target = target;
            //bool Old_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool Old_ugContainsVertexSource = ug.ContainsVertex(source);
            bool Old_ugContainsVertexTarget = ug.ContainsVertex(target);
            
            //bool Old_ContainsEdgeSrcTar = ug.ContainsEdge(source, target);
            bool Old_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool Old_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            //code
            bool New_Ret = ug.RemoveEdge(new Edge<int>(source, target));

            int New_ugVertexCount = ug.VertexCount;
            int New_ugEdgeCount = ug.EdgeCount;
            int New_ugAdjacentDegreeSource = ug.AdjacentDegree(source);
            int New_ugAdjacentDegreeTarget = ug.AdjacentDegree(target);
            int New_source = source;
            int New_target = target;
            //bool New_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool New_ugContainsVertexSource = ug.ContainsVertex(source);
            bool New_ugContainsVertexTarget = ug.ContainsVertex(target);

            //bool New_ContainsEdgeSrcTar = New_ugContainsVertexSource? ug.ContainsEdge(source, target): PexChoose.Value<bool>("$New_containsEdgeSrcTar");
            bool New_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool New_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            PexObserve.ValueForViewing("$old_ug_vertex_count", Old_ugVertexCount);
            PexObserve.ValueForViewing("$new_ug_vertex_count", New_ugVertexCount);
            PexObserve.ValueForViewing("$old_ug_edge_count", Old_ugEdgeCount);
            PexObserve.ValueForViewing("$new_ug_edge_count", New_ugEdgeCount);
            PexObserve.ValueForViewing("$old_ug_adjacent_degree_source", Old_ugAdjacentDegreeSource);
            PexObserve.ValueForViewing("$new_ug_adjacent_degree_source", New_ugAdjacentDegreeSource);
            PexObserve.ValueForViewing("$old_ug_adjacent_degree_target", Old_ugAdjacentDegreeTarget);
            PexObserve.ValueForViewing("$new_ug_adjacent_degree_target", New_ugAdjacentDegreeTarget);
            PexObserve.ValueForViewing("$old_ug_source", Old_source);
            PexObserve.ValueForViewing("$new_ug_source", New_source);
            PexObserve.ValueForViewing("$old_ug_target", Old_target);
            PexObserve.ValueForViewing("$new_ug_target", New_target);
            PexObserve.ValueForViewing("$new_ret", New_Ret);
            PexObserve.ValueForViewing("$old_ug_contains_source", Old_ugContainsVertexSource);
            PexObserve.ValueForViewing("$new_ug_contains_source", New_ugContainsVertexSource);
            PexObserve.ValueForViewing("$old_ug_contains_target", Old_ugContainsVertexTarget);
            PexObserve.ValueForViewing("$new_ug_contains_target", New_ugContainsVertexTarget);
            //PexObserve.ValueForViewing("$old_ug_allow_parallel_edges", Old_ugAllowParallelEdges);
            //PexObserve.ValueForViewing("$new_ug_allow_parallel_edges", New_ugAllowParallelEdges);
            //PexObserve.ValueForViewing("$Old_ContainsEdgeSrcTar", Old_ContainsEdgeSrcTar);
            //PexObserve.ValueForViewing("$New_ContainsEdgeSrcTar", New_ContainsEdgeSrcTar);
            
            PexObserve.ValueForViewing("$Old_ugIsVerticesEmpty", Old_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$New_ugIsVerticesEmpty", New_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$Olds_IsEdgesEmpty", Old_ugIsEdgesEmpty);
            PexObserve.ValueForViewing("$New_IsEdgesEmpty", New_ugIsEdgesEmpty);

            Assert.True(false);
        }

        [PexMethod]
        public void PUT_IsEdgesEmptyContract([PexAssumeUnderTest]UndirectedGraph.UndirectedGraph<int, Edge<int>> ug)
        {
            AssumePrecondition.IsTrue(true);

            int Old_ugVertexCount = ug.VertexCount;
            int Old_ugEdgeCount = ug.EdgeCount;
            bool Old_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool Old_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool Old_ugIsEdgesEmpty = ug.IsEdgesEmpty;
            //code
            bool New_Ret = ug.IsEdgesEmpty;

            int New_ugVertexCount = ug.VertexCount;
            int New_ugEdgeCount = ug.EdgeCount;
            bool New_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool New_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool New_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            PexObserve.ValueForViewing("$old_ug_vertex_count", Old_ugVertexCount);
            PexObserve.ValueForViewing("$new_ug_vertex_count", New_ugVertexCount);
            PexObserve.ValueForViewing("$old_ug_edge_count", Old_ugEdgeCount);
            PexObserve.ValueForViewing("$new_ug_edge_count", New_ugEdgeCount);
            PexObserve.ValueForViewing("$new_ret", New_Ret);
            PexObserve.ValueForViewing("$old_ug_allow_parallel_edges", Old_ugAllowParallelEdges);
            PexObserve.ValueForViewing("$new_ug_allow_parallel_edges", New_ugAllowParallelEdges);

            PexObserve.ValueForViewing("$Old_ugIsVerticesEmpty", Old_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$New_ugIsVerticesEmpty", New_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$Olds_IsEdgesEmpty", Old_ugIsEdgesEmpty);
            PexObserve.ValueForViewing("$New_IsEdgesEmpty", New_ugIsEdgesEmpty);

            Assert.True(false);
        }

        [PexMethod]
        public void PUT_EdgeCountContract([PexAssumeUnderTest]UndirectedGraph.UndirectedGraph<int, Edge<int>> ug)
        {
            AssumePrecondition.IsTrue(true);

            int Old_ugVertexCount = ug.VertexCount;
            int Old_ugEdgeCount = ug.EdgeCount;
            //bool Old_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool Old_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool Old_ugIsEdgesEmpty = ug.IsEdgesEmpty;
            //code
            int New_Ret = ug.EdgeCount;

            int New_ugVertexCount = ug.VertexCount;
            int New_ugEdgeCount = ug.EdgeCount;
            //bool New_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool New_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool New_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            PexObserve.ValueForViewing("$old_ug_vertex_count", Old_ugVertexCount);
            PexObserve.ValueForViewing("$new_ug_vertex_count", New_ugVertexCount);
            PexObserve.ValueForViewing("$old_ug_edge_count", Old_ugEdgeCount);
            PexObserve.ValueForViewing("$new_ug_edge_count", New_ugEdgeCount);
            PexObserve.ValueForViewing("$new_ret", New_Ret);
            //PexObserve.ValueForViewing("$old_ug_allow_parallel_edges", Old_ugAllowParallelEdges);
            //PexObserve.ValueForViewing("$new_ug_allow_parallel_edges", New_ugAllowParallelEdges);
            PexObserve.ValueForViewing("$Old_ugIsVerticesEmpty", Old_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$New_ugIsVerticesEmpty", New_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$Olds_IsEdgesEmpty", Old_ugIsEdgesEmpty);
            PexObserve.ValueForViewing("$New_IsEdgesEmpty", New_ugIsEdgesEmpty);

            Assert.True(false);
        }

        [PexMethod]
        public void PUT_AdjacentDegreeContract([PexAssumeUnderTest]UndirectedGraph.UndirectedGraph<int, Edge<int>> ug, int x)
        {
            AssumePrecondition.IsTrue(ug.ContainsVertex(x));

            int Old_ugVertexCount = ug.VertexCount;
            int Old_ugEdgeCount = ug.EdgeCount;
            int Old_ugAdjacentDegree = ug.AdjacentDegree(x);
            int Old_x = x;
            bool Old_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool Old_ugContainsVertexX = ug.ContainsVertex(x);
            bool Old_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool Old_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            //code
            int New_Ret = ug.AdjacentDegree(x);

            int New_ugVertexCount = ug.VertexCount;
            int New_ugEdgeCount = ug.EdgeCount;
            int New_ugAdjacentDegree = ug.AdjacentDegree(x);
            int New_x = x;
            bool New_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool New_ugContainsVertexX = ug.ContainsVertex(x);
            bool New_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool New_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            PexObserve.ValueForViewing("$old_ug_vertex_count", Old_ugVertexCount);
            PexObserve.ValueForViewing("$new_ug_vertex_count", New_ugVertexCount);
            PexObserve.ValueForViewing("$old_ug_edge_count", Old_ugEdgeCount);
            PexObserve.ValueForViewing("$new_ug_edge_count", New_ugEdgeCount);
            PexObserve.ValueForViewing("$old_ug_adjacent_degree", Old_ugAdjacentDegree);
            PexObserve.ValueForViewing("$new_ug_adjacent_degree", New_ugAdjacentDegree);
            PexObserve.ValueForViewing("$old_ug_x", Old_x);
            PexObserve.ValueForViewing("$new_ug_x", New_x);
            PexObserve.ValueForViewing("$new_ret", New_Ret);
            PexObserve.ValueForViewing("$old_ug_contains_x", Old_ugContainsVertexX);
            PexObserve.ValueForViewing("$new_ug_contains_x", New_ugContainsVertexX);
            PexObserve.ValueForViewing("$old_ug_allow_parallel_edges", Old_ugAllowParallelEdges);
            PexObserve.ValueForViewing("$new_ug_allow_parallel_edges", New_ugAllowParallelEdges);
            
            PexObserve.ValueForViewing("$Old_ugIsVerticesEmpty", Old_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$New_ugIsVerticesEmpty", New_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$Olds_IsEdgesEmpty", Old_ugIsEdgesEmpty);
            PexObserve.ValueForViewing("$New_IsEdgesEmpty", New_ugIsEdgesEmpty);

            Assert.True(false);
        }

        [PexMethod]
        public void PUT_IsAdjacentEdgesEmptyContract([PexAssumeUnderTest]UndirectedGraph.UndirectedGraph<int, Edge<int>> ug, int x)
        {
            AssumePrecondition.IsTrue(ug.ContainsVertex(x));

            int Old_ugVertexCount = ug.VertexCount;
            int Old_ugEdgeCount = ug.EdgeCount;
            int Old_ugAdjacentDegree = ug.AdjacentDegree(x);
            int Old_x = x;
            //bool Old_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool Old_ugContainsVertexX = ug.ContainsVertex(x);
            bool Old_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool Old_ugIsEdgesEmpty = ug.IsEdgesEmpty;
            //code
            bool New_Ret = ug.IsAdjacentEdgesEmpty(x);

            int New_ugVertexCount = ug.VertexCount;
            int New_ugEdgeCount = ug.EdgeCount;
            int New_ugAdjacentDegree = ug.AdjacentDegree(x);
            int New_x = x;
            //bool New_ugAllowParallelEdges = ug.AllowParallelEdges;
            bool New_ugContainsVertexX = ug.ContainsVertex(x);
            bool New_ugIsVerticesEmpty = ug.IsVerticesEmpty;
            bool New_ugIsEdgesEmpty = ug.IsEdgesEmpty;

            PexObserve.ValueForViewing("$old_ug_vertex_count", Old_ugVertexCount);
            PexObserve.ValueForViewing("$new_ug_vertex_count", New_ugVertexCount);
            PexObserve.ValueForViewing("$old_ug_edge_count", Old_ugEdgeCount);
            PexObserve.ValueForViewing("$new_ug_edge_count", New_ugEdgeCount);
            PexObserve.ValueForViewing("$old_ug_adjacent_degree", Old_ugAdjacentDegree);
            PexObserve.ValueForViewing("$new_ug_adjacent_degree", New_ugAdjacentDegree);
            PexObserve.ValueForViewing("$old_ug_x", Old_x);
            PexObserve.ValueForViewing("$new_ug_x", New_x);
            PexObserve.ValueForViewing("$new_ret", New_Ret);
            PexObserve.ValueForViewing("$old_ug_contains_x", Old_ugContainsVertexX);
            PexObserve.ValueForViewing("$new_ug_contains_x", New_ugContainsVertexX);
            //PexObserve.ValueForViewing("$old_ug_allow_parallel_edges", Old_ugAllowParallelEdges);
            //PexObserve.ValueForViewing("$new_ug_allow_parallel_edges", New_ugAllowParallelEdges);
            PexObserve.ValueForViewing("$Old_ugIsVerticesEmpty", Old_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$New_ugIsVerticesEmpty", New_ugIsVerticesEmpty);
            PexObserve.ValueForViewing("$Olds_IsEdgesEmpty", Old_ugIsEdgesEmpty);
            PexObserve.ValueForViewing("$New_IsEdgesEmpty", New_ugIsEdgesEmpty);


            Assert.True(false);
        }

    }
}