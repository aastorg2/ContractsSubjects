using System;
using Microsoft.Pex.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BinaryHeap;
using Common.Utility;

namespace BinaryHeap.Test.Factories
{
    public static partial class BinaryHeapFactory
    {
        [PexFactoryMethod(typeof(BinaryHeap.BinaryHeap<int, int>))]
        public static BinaryHeap<int, int> CreateBinaryHeapGeneral(int capacity, int[] priorities, int[] values)
        {
            PexAssume.IsTrue( priorities.Length == values.Length);
            var bh = new BinaryHeap<int, int>(capacity, Comparer<int>.Default.Compare);

            for (int i = 0; i < priorities.Length; i++)
            {
                bh.Add(priorities[i], values[i]);
            }

            return bh;
        }

        [PexFactoryMethod(typeof(BinaryHeap.BinaryHeap<int, int>))]
        public static BinaryHeap<int, int> CreateBinaryHeapKeyValPair([PexAssumeNotNull]KeyValuePair<int,int>[] pairs, int capacity)
        {
            PexAssume.IsTrue(capacity < 11 && capacity > 0 && pairs.Length <= capacity);
            PexAssume.TrueForAll(0, pairs.Length, _i => pairs[_i].Key > -11 && pairs[_i].Key < 11 && pairs[_i].Value > -11 && pairs[_i].Value < 11);
            //PexAssume.TrueForAll(0, pairs.Length, _i => pairs[_i].Key > -101 && pairs[_i].Key < 101);
            
            var bh = new BinaryHeap<int, int>(capacity, Comparer<int>.Default.Compare);
            foreach (var pair in pairs)
            {
                bh.Add(pair.Key, pair.Value);
            }

            return bh;
        }

        [PexFactoryMethod(typeof(BinaryHeap.BinaryHeap<int, int>))]
        public static BinaryHeap<int, int> CreateBinaryHeapKConstants(int num, int capacity)
        {
            PexAssume.IsTrue(num < capacity && num > 0 && num < 11);
            
            var bh = new BinaryHeap<int, int>(capacity, Comparer<int>.Default.Compare);
            for (int i = 0; i < num; i++)
            {
                bh.Add(i, i + 1);
            }
            return bh;
        }

    }
}
