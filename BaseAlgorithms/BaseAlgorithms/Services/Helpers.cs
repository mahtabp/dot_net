﻿using System;
namespace BaseAlgorithms.Services
{
    public static class Helpers
    {
        public static bool IsWithinInputRange(long value)
        {
            return value >= -92 && value <= 92;
        }
    }
}
