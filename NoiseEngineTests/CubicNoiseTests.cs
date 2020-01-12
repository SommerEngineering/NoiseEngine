﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using CubicNoise;
using CubicNoise.Contracts;
using CubicNoise.Noisers;
using NUnit.Framework;

namespace CubicNoiseTests
{
    public class CubicNoiseTests
    {
        [Test]
        public void TestValidity()
        {
            var engineO57PX12PY16 = NoiseEngine.Create(new EngineParameters
            {
                Seed = "test seed".GetDeterministicHashCode(),
                Type = NoiseTypes.CUBIC_NOISE,
                IntParameters = new Dictionary<IParameterName, int>
                {
                    { CubicNoiseIntParameters.OCTAVE, 57 },
                    { CubicNoiseIntParameters.PERIOD_X, 12 },
                    { CubicNoiseIntParameters.PERIOD_Y, 16 },
                },
            });

            var engineO45PX16PY99 = NoiseEngine.Create(new EngineParameters
            {
                Seed = "test seed".GetDeterministicHashCode(),
                Type = NoiseTypes.CUBIC_NOISE,
                IntParameters = new Dictionary<IParameterName, int>
                {
                    { CubicNoiseIntParameters.OCTAVE, 45 },
                    { CubicNoiseIntParameters.PERIOD_X, 16 },
                    { CubicNoiseIntParameters.PERIOD_Y, 99 },
                },
            });

            Assert.That(engineO57PX12PY16, Is.Not.Null);
            Assert.That(engineO45PX16PY99, Is.Not.Null);

            // Generated by means of https://github.com/jobtalle/CubicNoise/blob/master/c%23/CubicNoise.cs
            var expectedValuesO57 = new List<(int X, int Y, float Result)>
            {
                (X: 0, Y: 0, Result: 0.3416f), (X: 0, Y: 1, Result: 0.3346f), (X: 0, Y: 2, Result: 0.3272f), (X: 0, Y: 3, Result: 0.3196f), (X: 0, Y: 4, Result: 0.3117f), (X: 0, Y: 5, Result: 0.3035f), (X: 0, Y: 6, Result: 0.2951f), (X: 0, Y: 7, Result: 0.2864f), (X: 0, Y: 8, Result: 0.2775f), (X: 0, Y: 9, Result: 0.2684f),
                (X: 1, Y: 0, Result: 0.3292f), (X: 1, Y: 1, Result: 0.3222f), (X: 1, Y: 2, Result: 0.3149f), (X: 1, Y: 3, Result: 0.3073f), (X: 1, Y: 4, Result: 0.2995f), (X: 1, Y: 5, Result: 0.2913f), (X: 1, Y: 6, Result: 0.2830f), (X: 1, Y: 7, Result: 0.2744f), (X: 1, Y: 8, Result: 0.2655f), (X: 1, Y: 9, Result: 0.2564f),
                (X: 2, Y: 0, Result: 0.3172f), (X: 2, Y: 1, Result: 0.3103f), (X: 2, Y: 2, Result: 0.3030f), (X: 2, Y: 3, Result: 0.2955f), (X: 2, Y: 4, Result: 0.2877f), (X: 2, Y: 5, Result: 0.2796f), (X: 2, Y: 6, Result: 0.2713f), (X: 2, Y: 7, Result: 0.2627f), (X: 2, Y: 8, Result: 0.2539f), (X: 2, Y: 9, Result: 0.2449f),
                (X: 3, Y: 0, Result: 0.3057f), (X: 3, Y: 1, Result: 0.2988f), (X: 3, Y: 2, Result: 0.2916f), (X: 3, Y: 3, Result: 0.2841f), (X: 3, Y: 4, Result: 0.2764f), (X: 3, Y: 5, Result: 0.2683f), (X: 3, Y: 6, Result: 0.2601f), (X: 3, Y: 7, Result: 0.2515f), (X: 3, Y: 8, Result: 0.2428f), (X: 3, Y: 9, Result: 0.2338f),
                (X: 4, Y: 0, Result: 0.2947f), (X: 4, Y: 1, Result: 0.2878f), (X: 4, Y: 2, Result: 0.2807f), (X: 4, Y: 3, Result: 0.2732f), (X: 4, Y: 4, Result: 0.2655f), (X: 4, Y: 5, Result: 0.2575f), (X: 4, Y: 6, Result: 0.2492f), (X: 4, Y: 7, Result: 0.2408f), (X: 4, Y: 8, Result: 0.2321f), (X: 4, Y: 9, Result: 0.2232f),
                (X: 5, Y: 0, Result: 0.2841f), (X: 5, Y: 1, Result: 0.2772f), (X: 5, Y: 2, Result: 0.2701f), (X: 5, Y: 3, Result: 0.2627f), (X: 5, Y: 4, Result: 0.2550f), (X: 5, Y: 5, Result: 0.2470f), (X: 5, Y: 6, Result: 0.2388f), (X: 5, Y: 7, Result: 0.2304f), (X: 5, Y: 8, Result: 0.2217f), (X: 5, Y: 9, Result: 0.2129f),
                (X: 6, Y: 0, Result: 0.2738f), (X: 6, Y: 1, Result: 0.2670f), (X: 6, Y: 2, Result: 0.2599f), (X: 6, Y: 3, Result: 0.2525f), (X: 6, Y: 4, Result: 0.2449f), (X: 6, Y: 5, Result: 0.2370f), (X: 6, Y: 6, Result: 0.2288f), (X: 6, Y: 7, Result: 0.2204f), (X: 6, Y: 8, Result: 0.2118f), (X: 6, Y: 9, Result: 0.2030f),
                (X: 7, Y: 0, Result: 0.2640f), (X: 7, Y: 1, Result: 0.2572f), (X: 7, Y: 2, Result: 0.2502f), (X: 7, Y: 3, Result: 0.2428f), (X: 7, Y: 4, Result: 0.2352f), (X: 7, Y: 5, Result: 0.2273f), (X: 7, Y: 6, Result: 0.2192f), (X: 7, Y: 7, Result: 0.2108f), (X: 7, Y: 8, Result: 0.2022f), (X: 7, Y: 9, Result: 0.1934f),
                (X: 8, Y: 0, Result: 0.2546f), (X: 8, Y: 1, Result: 0.2478f), (X: 8, Y: 2, Result: 0.2408f), (X: 8, Y: 3, Result: 0.2334f), (X: 8, Y: 4, Result: 0.2258f), (X: 8, Y: 5, Result: 0.2180f), (X: 8, Y: 6, Result: 0.2099f), (X: 8, Y: 7, Result: 0.2015f), (X: 8, Y: 8, Result: 0.1930f), (X: 8, Y: 9, Result: 0.1843f),
                (X: 9, Y: 0, Result: 0.2455f), (X: 9, Y: 1, Result: 0.2388f), (X: 9, Y: 2, Result: 0.2317f), (X: 9, Y: 3, Result: 0.2244f), (X: 9, Y: 4, Result: 0.2168f), (X: 9, Y: 5, Result: 0.2090f), (X: 9, Y: 6, Result: 0.2009f), (X: 9, Y: 7, Result: 0.1926f), (X: 9, Y: 8, Result: 0.1841f), (X: 9, Y: 9, Result: 0.1754f),

                (X: 1123456, Y: -1123456, Result: 0.7784f), (X: 1123456, Y: -1123455, Result: 0.7834f), (X: 1123456, Y: -1123454, Result: 0.7880f), (X: 1123456, Y: -1123453, Result: 0.7921f), (X: 1123456, Y: -1123452, Result: 0.7958f), (X: 1123456, Y: -1123451, Result: 0.7991f), (X: 1123456, Y: -1123450, Result: 0.8019f), (X: 1123456, Y: -1123449, Result: 0.8043f), (X: 1123456, Y: -1123448, Result: 0.8062f), (X: 1123456, Y: -1123447, Result: 0.8077f),
                (X: 1123457, Y: -1123456, Result: 0.7796f), (X: 1123457, Y: -1123455, Result: 0.7848f), (X: 1123457, Y: -1123454, Result: 0.7897f), (X: 1123457, Y: -1123453, Result: 0.7941f), (X: 1123457, Y: -1123452, Result: 0.7980f), (X: 1123457, Y: -1123451, Result: 0.8016f), (X: 1123457, Y: -1123450, Result: 0.8047f), (X: 1123457, Y: -1123449, Result: 0.8073f), (X: 1123457, Y: -1123448, Result: 0.8095f), (X: 1123457, Y: -1123447, Result: 0.8112f),
                (X: 1123458, Y: -1123456, Result: 0.7806f), (X: 1123458, Y: -1123455, Result: 0.7861f), (X: 1123458, Y: -1123454, Result: 0.7911f), (X: 1123458, Y: -1123453, Result: 0.7958f), (X: 1123458, Y: -1123452, Result: 0.8000f), (X: 1123458, Y: -1123451, Result: 0.8038f), (X: 1123458, Y: -1123450, Result: 0.8071f), (X: 1123458, Y: -1123449, Result: 0.8100f), (X: 1123458, Y: -1123448, Result: 0.8125f), (X: 1123458, Y: -1123447, Result: 0.8145f),
                (X: 1123459, Y: -1123456, Result: 0.7814f), (X: 1123459, Y: -1123455, Result: 0.7871f), (X: 1123459, Y: -1123454, Result: 0.7924f), (X: 1123459, Y: -1123453, Result: 0.7973f), (X: 1123459, Y: -1123452, Result: 0.8017f), (X: 1123459, Y: -1123451, Result: 0.8057f), (X: 1123459, Y: -1123450, Result: 0.8093f), (X: 1123459, Y: -1123449, Result: 0.8124f), (X: 1123459, Y: -1123448, Result: 0.8151f), (X: 1123459, Y: -1123447, Result: 0.8173f),
                (X: 1123460, Y: -1123456, Result: 0.7821f), (X: 1123460, Y: -1123455, Result: 0.7880f), (X: 1123460, Y: -1123454, Result: 0.7935f), (X: 1123460, Y: -1123453, Result: 0.7986f), (X: 1123460, Y: -1123452, Result: 0.8032f), (X: 1123460, Y: -1123451, Result: 0.8074f), (X: 1123460, Y: -1123450, Result: 0.8111f), (X: 1123460, Y: -1123449, Result: 0.8145f), (X: 1123460, Y: -1123448, Result: 0.8173f), (X: 1123460, Y: -1123447, Result: 0.8198f),
                (X: 1123461, Y: -1123456, Result: 0.7826f), (X: 1123461, Y: -1123455, Result: 0.7887f), (X: 1123461, Y: -1123454, Result: 0.7943f), (X: 1123461, Y: -1123453, Result: 0.7996f), (X: 1123461, Y: -1123452, Result: 0.8044f), (X: 1123461, Y: -1123451, Result: 0.8088f), (X: 1123461, Y: -1123450, Result: 0.8127f), (X: 1123461, Y: -1123449, Result: 0.8162f), (X: 1123461, Y: -1123448, Result: 0.8192f), (X: 1123461, Y: -1123447, Result: 0.8218f),
                (X: 1123462, Y: -1123456, Result: 0.7829f), (X: 1123462, Y: -1123455, Result: 0.7891f), (X: 1123462, Y: -1123454, Result: 0.7949f), (X: 1123462, Y: -1123453, Result: 0.8003f), (X: 1123462, Y: -1123452, Result: 0.8053f), (X: 1123462, Y: -1123451, Result: 0.8098f), (X: 1123462, Y: -1123450, Result: 0.8139f), (X: 1123462, Y: -1123449, Result: 0.8176f), (X: 1123462, Y: -1123448, Result: 0.8208f), (X: 1123462, Y: -1123447, Result: 0.8235f),
                (X: 1123463, Y: -1123456, Result: 0.7830f), (X: 1123463, Y: -1123455, Result: 0.7894f), (X: 1123463, Y: -1123454, Result: 0.7953f), (X: 1123463, Y: -1123453, Result: 0.8009f), (X: 1123463, Y: -1123452, Result: 0.8059f), (X: 1123463, Y: -1123451, Result: 0.8106f), (X: 1123463, Y: -1123450, Result: 0.8148f), (X: 1123463, Y: -1123449, Result: 0.8186f), (X: 1123463, Y: -1123448, Result: 0.8219f), (X: 1123463, Y: -1123447, Result: 0.8248f),
                (X: 1123464, Y: -1123456, Result: 0.7830f), (X: 1123464, Y: -1123455, Result: 0.7895f), (X: 1123464, Y: -1123454, Result: 0.7955f), (X: 1123464, Y: -1123453, Result: 0.8011f), (X: 1123464, Y: -1123452, Result: 0.8063f), (X: 1123464, Y: -1123451, Result: 0.8110f), (X: 1123464, Y: -1123450, Result: 0.8153f), (X: 1123464, Y: -1123449, Result: 0.8192f), (X: 1123464, Y: -1123448, Result: 0.8226f), (X: 1123464, Y: -1123447, Result: 0.8256f),
                (X: 1123465, Y: -1123456, Result: 0.7828f), (X: 1123465, Y: -1123455, Result: 0.7893f), (X: 1123465, Y: -1123454, Result: 0.7954f), (X: 1123465, Y: -1123453, Result: 0.8011f), (X: 1123465, Y: -1123452, Result: 0.8064f), (X: 1123465, Y: -1123451, Result: 0.8112f), (X: 1123465, Y: -1123450, Result: 0.8155f), (X: 1123465, Y: -1123449, Result: 0.8195f), (X: 1123465, Y: -1123448, Result: 0.8230f), (X: 1123465, Y: -1123447, Result: 0.8260f),             };

            // Generated by means of https://github.com/jobtalle/CubicNoise/blob/master/c%23/CubicNoise.cs
            var expectedValuesO45 = new List<(int X, int Y, float Result)>
            {
                (X: 0, Y: 0, Result: 0.3416f), (X: 0, Y: 1, Result: 0.3326f), (X: 0, Y: 2, Result: 0.3232f), (X: 0, Y: 3, Result: 0.3133f), (X: 0, Y: 4, Result: 0.3030f), (X: 0, Y: 5, Result: 0.2922f), (X: 0, Y: 6, Result: 0.2811f), (X: 0, Y: 7, Result: 0.2696f), (X: 0, Y: 8, Result: 0.2578f), (X: 0, Y: 9, Result: 0.2457f),
                (X: 1, Y: 0, Result: 0.3259f), (X: 1, Y: 1, Result: 0.3171f), (X: 1, Y: 2, Result: 0.3077f), (X: 1, Y: 3, Result: 0.2979f), (X: 1, Y: 4, Result: 0.2876f), (X: 1, Y: 5, Result: 0.2770f), (X: 1, Y: 6, Result: 0.2659f), (X: 1, Y: 7, Result: 0.2546f), (X: 1, Y: 8, Result: 0.2428f), (X: 1, Y: 9, Result: 0.2309f),
                (X: 2, Y: 0, Result: 0.3110f), (X: 2, Y: 1, Result: 0.3022f), (X: 2, Y: 2, Result: 0.2929f), (X: 2, Y: 3, Result: 0.2832f), (X: 2, Y: 4, Result: 0.2730f), (X: 2, Y: 5, Result: 0.2624f), (X: 2, Y: 6, Result: 0.2515f), (X: 2, Y: 7, Result: 0.2402f), (X: 2, Y: 8, Result: 0.2286f), (X: 2, Y: 9, Result: 0.2167f),
                (X: 3, Y: 0, Result: 0.2969f), (X: 3, Y: 1, Result: 0.2881f), (X: 3, Y: 2, Result: 0.2789f), (X: 3, Y: 3, Result: 0.2692f), (X: 3, Y: 4, Result: 0.2591f), (X: 3, Y: 5, Result: 0.2486f), (X: 3, Y: 6, Result: 0.2377f), (X: 3, Y: 7, Result: 0.2265f), (X: 3, Y: 8, Result: 0.2149f), (X: 3, Y: 9, Result: 0.2031f),
                (X: 4, Y: 0, Result: 0.2834f), (X: 4, Y: 1, Result: 0.2747f), (X: 4, Y: 2, Result: 0.2655f), (X: 4, Y: 3, Result: 0.2558f), (X: 4, Y: 4, Result: 0.2458f), (X: 4, Y: 5, Result: 0.2354f), (X: 4, Y: 6, Result: 0.2245f), (X: 4, Y: 7, Result: 0.2134f), (X: 4, Y: 8, Result: 0.2019f), (X: 4, Y: 9, Result: 0.1902f),
                (X: 5, Y: 0, Result: 0.2705f), (X: 5, Y: 1, Result: 0.2619f), (X: 5, Y: 2, Result: 0.2527f), (X: 5, Y: 3, Result: 0.2432f), (X: 5, Y: 4, Result: 0.2332f), (X: 5, Y: 5, Result: 0.2228f), (X: 5, Y: 6, Result: 0.2120f), (X: 5, Y: 7, Result: 0.2009f), (X: 5, Y: 8, Result: 0.1896f), (X: 5, Y: 9, Result: 0.1779f),
                (X: 6, Y: 0, Result: 0.2583f), (X: 6, Y: 1, Result: 0.2497f), (X: 6, Y: 2, Result: 0.2406f), (X: 6, Y: 3, Result: 0.2311f), (X: 6, Y: 4, Result: 0.2211f), (X: 6, Y: 5, Result: 0.2108f), (X: 6, Y: 6, Result: 0.2001f), (X: 6, Y: 7, Result: 0.1891f), (X: 6, Y: 8, Result: 0.1778f), (X: 6, Y: 9, Result: 0.1662f),
                (X: 7, Y: 0, Result: 0.2467f), (X: 7, Y: 1, Result: 0.2381f), (X: 7, Y: 2, Result: 0.2291f), (X: 7, Y: 3, Result: 0.2196f), (X: 7, Y: 4, Result: 0.2097f), (X: 7, Y: 5, Result: 0.1994f), (X: 7, Y: 6, Result: 0.1887f), (X: 7, Y: 7, Result: 0.1778f), (X: 7, Y: 8, Result: 0.1665f), (X: 7, Y: 9, Result: 0.1550f),
                (X: 8, Y: 0, Result: 0.2357f), (X: 8, Y: 1, Result: 0.2271f), (X: 8, Y: 2, Result: 0.2181f), (X: 8, Y: 3, Result: 0.2086f), (X: 8, Y: 4, Result: 0.1987f), (X: 8, Y: 5, Result: 0.1885f), (X: 8, Y: 6, Result: 0.1779f), (X: 8, Y: 7, Result: 0.1670f), (X: 8, Y: 8, Result: 0.1558f), (X: 8, Y: 9, Result: 0.1444f),
                (X: 9, Y: 0, Result: 0.2251f), (X: 9, Y: 1, Result: 0.2166f), (X: 9, Y: 2, Result: 0.2076f), (X: 9, Y: 3, Result: 0.1982f), (X: 9, Y: 4, Result: 0.1883f), (X: 9, Y: 5, Result: 0.1781f), (X: 9, Y: 6, Result: 0.1676f), (X: 9, Y: 7, Result: 0.1567f), (X: 9, Y: 8, Result: 0.1456f), (X: 9, Y: 9, Result: 0.1342f),

                (X: 1123456, Y: -1123456, Result: 0.0018f), (X: 1123456, Y: -1123455, Result: 0.0195f), (X: 1123456, Y: -1123454, Result: 0.0359f), (X: 1123456, Y: -1123453, Result: 0.0525f), (X: 1123456, Y: -1123452, Result: 0.0707f), (X: 1123456, Y: -1123451, Result: 0.0875f), (X: 1123456, Y: -1123450, Result: 0.1058f), (X: 1123456, Y: -1123449, Result: 0.1226f), (X: 1123456, Y: -1123448, Result: 0.1392f), (X: 1123456, Y: -1123447, Result: 0.1573f),
                (X: 1123457, Y: -1123456, Result: 0.0069f), (X: 1123457, Y: -1123455, Result: 0.0252f), (X: 1123457, Y: -1123454, Result: 0.0422f), (X: 1123457, Y: -1123453, Result: 0.0593f), (X: 1123457, Y: -1123452, Result: 0.0781f), (X: 1123457, Y: -1123451, Result: 0.0953f), (X: 1123457, Y: -1123450, Result: 0.1142f), (X: 1123457, Y: -1123449, Result: 0.1314f), (X: 1123457, Y: -1123448, Result: 0.1486f), (X: 1123457, Y: -1123447, Result: 0.1671f),
                (X: 1123458, Y: -1123456, Result: 0.0120f), (X: 1123458, Y: -1123455, Result: 0.0309f), (X: 1123458, Y: -1123454, Result: 0.0484f), (X: 1123458, Y: -1123453, Result: 0.0661f), (X: 1123458, Y: -1123452, Result: 0.0854f), (X: 1123458, Y: -1123451, Result: 0.1032f), (X: 1123458, Y: -1123450, Result: 0.1225f), (X: 1123458, Y: -1123449, Result: 0.1402f), (X: 1123458, Y: -1123448, Result: 0.1578f), (X: 1123458, Y: -1123447, Result: 0.1769f),
                (X: 1123459, Y: -1123456, Result: 0.0178f), (X: 1123459, Y: -1123455, Result: 0.0373f), (X: 1123459, Y: -1123454, Result: 0.0554f), (X: 1123459, Y: -1123453, Result: 0.0735f), (X: 1123459, Y: -1123452, Result: 0.0935f), (X: 1123459, Y: -1123451, Result: 0.1117f), (X: 1123459, Y: -1123450, Result: 0.1317f), (X: 1123459, Y: -1123449, Result: 0.1498f), (X: 1123459, Y: -1123448, Result: 0.1679f), (X: 1123459, Y: -1123447, Result: 0.1875f),
                (X: 1123460, Y: -1123456, Result: 0.0232f), (X: 1123460, Y: -1123455, Result: 0.0432f), (X: 1123460, Y: -1123454, Result: 0.0618f), (X: 1123460, Y: -1123453, Result: 0.0804f), (X: 1123460, Y: -1123452, Result: 0.1009f), (X: 1123460, Y: -1123451, Result: 0.1196f), (X: 1123460, Y: -1123450, Result: 0.1400f), (X: 1123460, Y: -1123449, Result: 0.1586f), (X: 1123460, Y: -1123448, Result: 0.1771f), (X: 1123460, Y: -1123447, Result: 0.1971f),
                (X: 1123461, Y: -1123456, Result: 0.0292f), (X: 1123461, Y: -1123455, Result: 0.0498f), (X: 1123461, Y: -1123454, Result: 0.0689f), (X: 1123461, Y: -1123453, Result: 0.0880f), (X: 1123461, Y: -1123452, Result: 0.1090f), (X: 1123461, Y: -1123451, Result: 0.1282f), (X: 1123461, Y: -1123450, Result: 0.1491f), (X: 1123461, Y: -1123449, Result: 0.1682f), (X: 1123461, Y: -1123448, Result: 0.1871f), (X: 1123461, Y: -1123447, Result: 0.2076f),
                (X: 1123462, Y: -1123456, Result: 0.0348f), (X: 1123462, Y: -1123455, Result: 0.0560f), (X: 1123462, Y: -1123454, Result: 0.0755f), (X: 1123462, Y: -1123453, Result: 0.0951f), (X: 1123462, Y: -1123452, Result: 0.1165f), (X: 1123462, Y: -1123451, Result: 0.1361f), (X: 1123462, Y: -1123450, Result: 0.1575f), (X: 1123462, Y: -1123449, Result: 0.1770f), (X: 1123462, Y: -1123448, Result: 0.1963f), (X: 1123462, Y: -1123447, Result: 0.2172f),
                (X: 1123463, Y: -1123456, Result: 0.0406f), (X: 1123463, Y: -1123455, Result: 0.0622f), (X: 1123463, Y: -1123454, Result: 0.0822f), (X: 1123463, Y: -1123453, Result: 0.1022f), (X: 1123463, Y: -1123452, Result: 0.1241f), (X: 1123463, Y: -1123451, Result: 0.1441f), (X: 1123463, Y: -1123450, Result: 0.1659f), (X: 1123463, Y: -1123449, Result: 0.1857f), (X: 1123463, Y: -1123448, Result: 0.2055f), (X: 1123463, Y: -1123447, Result: 0.2267f),
                (X: 1123464, Y: -1123456, Result: 0.0472f), (X: 1123464, Y: -1123455, Result: 0.0693f), (X: 1123464, Y: -1123454, Result: 0.0896f), (X: 1123464, Y: -1123453, Result: 0.1101f), (X: 1123464, Y: -1123452, Result: 0.1324f), (X: 1123464, Y: -1123451, Result: 0.1529f), (X: 1123464, Y: -1123450, Result: 0.1751f), (X: 1123464, Y: -1123449, Result: 0.1953f), (X: 1123464, Y: -1123448, Result: 0.2154f), (X: 1123464, Y: -1123447, Result: 0.2371f),
                (X: 1123465, Y: -1123456, Result: 0.0533f), (X: 1123465, Y: -1123455, Result: 0.0759f), (X: 1123465, Y: -1123454, Result: 0.0966f), (X: 1123465, Y: -1123453, Result: 0.1174f), (X: 1123465, Y: -1123452, Result: 0.1401f), (X: 1123465, Y: -1123451, Result: 0.1609f), (X: 1123465, Y: -1123450, Result: 0.1835f), (X: 1123465, Y: -1123449, Result: 0.2041f), (X: 1123465, Y: -1123448, Result: 0.2246f), (X: 1123465, Y: -1123447, Result: 0.2466f),
            };

            foreach (var (x, y, result) in expectedValuesO45)
            {
                var output = engineO45PX16PY99.Get(x, y);
                Assert.That(output, Is.EqualTo(result).Within(0.00005f), $"The result {result} was expected (accepting a tolerance +/- 0.00001) for the input X={x}, Y={y}, but was {output}. Octave=45, px=16, py=99");
            }

            foreach (var (x, y, result) in expectedValuesO57)
            {
                var output = engineO57PX12PY16.Get(x, y);
                Assert.That(output, Is.EqualTo(result).Within(0.00005f), $"The result {result} was expected (accepting a tolerance +/- 0.00001) for the input X={x}, Y={y}, but was {output}. Octave=57, px=12, py=16");
            }
        }

        [Test]
        public void Performance1Second2D()
        {
            var stopwatch = new Stopwatch();
            var desiredRuntime = TimeSpan.FromSeconds(1);
            var counter = 0;
            var sum = 0L;

            var engine = NoiseEngine.Create(new EngineParameters
            {
                Seed = "test seed".GetHashCode(),
                Type = NoiseTypes.CUBIC_NOISE,
                IntParameters = new Dictionary<IParameterName, int>
                {
                    { CubicNoiseIntParameters.OCTAVE, 57 },
                    { CubicNoiseIntParameters.PERIOD_X, 12 },
                    { CubicNoiseIntParameters.PERIOD_Y, 16 },
                },
            });

            while (true)
            {
                counter++;

                var x = counter;
                var y = (int)Math.Pow(counter, 2);

                stopwatch.Start();
                var value = engine.Get(x, y);
                stopwatch.Stop();
                sum += (long) value;

                if (stopwatch.Elapsed >= desiredRuntime)
                    break;
            }

            var result = counter / stopwatch.Elapsed.TotalSeconds;
            TestContext.Write($"Benchmark for 1 second (2D): {result:###,###,##0.00} lookups/second");
            Assert.That(true);
        }

        [Test]
        public void Performance30Seconds2D()
        {
            var stopwatch = new Stopwatch();
            var desiredRuntime = TimeSpan.FromSeconds(30);
            var counter = 0;
            var sum = 0L;

            var engine = NoiseEngine.Create(new EngineParameters
            {
                Seed = "test seed".GetHashCode(),
                Type = NoiseTypes.CUBIC_NOISE,
                IntParameters = new Dictionary<IParameterName, int>
                {
                    { CubicNoiseIntParameters.OCTAVE, 57 },
                    { CubicNoiseIntParameters.PERIOD_X, 12 },
                    { CubicNoiseIntParameters.PERIOD_Y, 16 },
                },
            });

            while (true)
            {
                counter++;

                var x = counter;
                var y = (int)Math.Pow(counter, 2);

                stopwatch.Start();
                var value = engine.Get(x, y);
                stopwatch.Stop();
                sum += (long) value;

                if (stopwatch.Elapsed >= desiredRuntime)
                    break;
            }

            var result = counter / stopwatch.Elapsed.TotalSeconds;
            TestContext.Write($"Benchmark for 30 seconds (2D): {result:###,###,##0.00} lookups/second");
            Assert.That(true);
        }

        [Test]
        public void Performance1Second1D()
        {
            var stopwatch = new Stopwatch();
            var desiredRuntime = TimeSpan.FromSeconds(1);
            var counter = 0;
            var sum = 0L;

            var engine = NoiseEngine.Create(new EngineParameters
            {
                Seed = "test seed".GetHashCode(),
                Type = NoiseTypes.CUBIC_NOISE,
                IntParameters = new Dictionary<IParameterName, int>
                {
                    { CubicNoiseIntParameters.OCTAVE, 57 },
                    { CubicNoiseIntParameters.PERIOD_X, 12 },
                    { CubicNoiseIntParameters.PERIOD_Y, 16 },
                },
            });

            while (true)
            {
                counter++;

                var x = counter;

                stopwatch.Start();
                var value = engine.Get(x);
                stopwatch.Stop();
                sum += (long)value;

                if (stopwatch.Elapsed >= desiredRuntime)
                    break;
            }

            var result = counter / stopwatch.Elapsed.TotalSeconds;
            TestContext.Write($"Benchmark for 1 second (1D): {result:###,###,##0.00} lookups/second");
            Assert.That(true);
        }

        [Test]
        public void Performance30Seconds1D()
        {
            var stopwatch = new Stopwatch();
            var desiredRuntime = TimeSpan.FromSeconds(30);
            var counter = 0;
            var sum = 0L;

            var engine = NoiseEngine.Create(new EngineParameters
            {
                Seed = "test seed".GetHashCode(),
                Type = NoiseTypes.CUBIC_NOISE,
                IntParameters = new Dictionary<IParameterName, int>
                {
                    { CubicNoiseIntParameters.OCTAVE, 57 },
                    { CubicNoiseIntParameters.PERIOD_X, 12 },
                    { CubicNoiseIntParameters.PERIOD_Y, 16 },
                },
            });

            while (true)
            {
                counter++;

                var x = counter;

                stopwatch.Start();
                var value = engine.Get(x);
                stopwatch.Stop();
                sum += (long) value;

                if (stopwatch.Elapsed >= desiredRuntime)
                    break;
            }

            var result = counter / stopwatch.Elapsed.TotalSeconds;
            TestContext.Write($"Benchmark for 30 seconds (1D): {result:###,###,##0.00} lookups/second");
            Assert.That(true);
        }
    }
}