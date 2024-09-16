﻿
namespace IntroToCSharp.GD3A.Utilities
{
    internal static class MathUtility
    {
        internal static readonly double FLOAT_TOLERANCE = 10E-6;

        /// <summary>
        /// Compares two doubles within a given epsilon 
        /// </summary>
        /// <param name="a">Double a</param>
        /// <param name="b">Double b</param>
        /// <param name="epsilon">Tolerance value</param>
        /// <returns>True if less than epsilon</returns>
        public static bool AreEqualWithin(double a, double b, double epsilon)
        {
            return Math.Abs(a - b) < epsilon;
        }

        public static bool AreEqualWithin(double a, double b)
        {
            return Math.Abs(a - b) < FLOAT_TOLERANCE;
        }

    }
}
