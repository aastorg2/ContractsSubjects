using System;

namespace Common.Utility4QuickGraph3
{
    /// <summary>
    /// Colors used in vertex coloring algorithms
    /// </summary>
#if !SILVERLIGHT
    [Serializable]
#endif
    public enum GraphColor : byte
    {
        /// <summary>
        /// Usually initial color,
        /// </summary>
        White = 0,
        /// <summary>
        /// Usually intermidiate color,
        /// </summary>
        Gray,
        /// <summary>
        /// Usually finished color
        /// </summary>
        Black
    }
}
