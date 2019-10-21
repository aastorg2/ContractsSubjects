using System;
using Microsoft.Pex.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BinaryHeap;
using Common.Utility4QuickGraph3;

namespace BinaryHeap.Test.Factories
{
    public static partial class BinaryHeapFactory
    {
        [PexFactoryMethod(typeof(BinaryHeap.BinaryHeap<int, int>))]
        public static BinaryHeap<int, int> CreateBinaryHeapGeneral(int[] priorities, int[] values, int capacity)
        {
            PexAssume.IsTrue(capacity > 0);
            PexAssume.IsTrue(priorities.Length == values.Length);
            PexAssume.TrueForAll(priorities, e => e <= 12 || e >= 12);
            PexAssume.TrueForAll(values, e => e <= 12 || e >= 12);
            var bh = new BinaryHeap<int, int>(capacity, Comparer<int>.Default.Compare);

            for (int i = 0; i < priorities.Length; i++)
            {
                bh.Add(priorities[i], values[i]);
            }

            return bh;
        }

        [PexFactoryMethod(typeof(BinaryHeap.BinaryHeap<int, int>))]
        public static BinaryHeap<int, int> CreateBinaryHeapKeyValPair([PexAssumeNotNull]KeyValuePair<int, int>[] pairs, int capacity)
        {
            //PexAssume.TrueForAll(0, pairs.Length, _i => pairs[_i].Key > -11 && pairs[_i].Key < 11 && pairs[_i].Value > -11 && pairs[_i].Value < 11);
            //PexAssume.TrueForAll(0, pairs.Length, _i => pairs[_i].Key > -101 && pairs[_i].Key < 101);
            PexAssume.IsTrue(capacity > 0);
            PexAssume.IsTrue(pairs.Length <= 8 || pairs.Length >= 8);
            var bh = new BinaryHeap<int, int>(capacity, Comparer<int>.Default.Compare);
            foreach (var pair in pairs)
            {
                bh.Add(pair.Key, pair.Value);
            }

            return bh;
        }

        [PexFactoryMethod(typeof(BinaryHeap.BinaryHeap<int, int>))]
        public static BinaryHeap<int, int> CreateBinaryHeapConstants(int num, int capacity)
        {
            PexAssume.IsTrue(num > 0 && num < 20);
            PexAssume.IsTrue(capacity > 0);

            var bh = new BinaryHeap<int, int>(capacity, Comparer<int>.Default.Compare);
            for (int i = 0; i < num; i++)
            {
                bh.Add(num - i, num - i + 1);
            }
            return bh;
        }

        [PexFactoryMethod(typeof(BinaryHeap.BinaryHeap<int, int>))]
        public static BinaryHeap<int, int> CreateBinaryHeapPexChoose(int num, int capacity)
        {
            PexAssume.IsTrue(num > 0 && num < 20);
            PexAssume.IsTrue(capacity > 0);

            var bh = new BinaryHeap<int, int>(capacity, Comparer<int>.Default.Compare);
            for (int i = 0; i < num; i++)
            {
                int priority = PexChoose.Value<int>("priority");
                int value = PexChoose.Value<int>("value");
                bh.Add(priority, value);
            }
            return bh;
        }
    }
}
