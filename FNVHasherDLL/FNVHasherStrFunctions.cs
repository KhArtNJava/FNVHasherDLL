using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FNVHasherDLL
{
    public class FNVHasherStrFunctions
    {
        private static int HIGH_BIT_32 = int.MinValue;
        private static long HIGH_BIT_64 = long.MinValue;


        private static byte[] toBytes(String str)
        {
            return System.Text.Encoding.GetEncoding("US-ASCII").GetBytes(
                str.ToLower(System.Globalization.CultureInfo.InvariantCulture));
        }


        public static uint fnv24(String str)
        {
            return FnvHash.fnv24(toBytes(str));
        }
        public static String fnv24HexString(String str)
        {
            String s = FNVHasherStrFunctions.fnv24(str).ToString("X");

            int l = 8 - s.Length;

            for (int x = 0; x < l; x++)
            {
                s = "0" + s;
            }
            s = "0x" + s;
            return s;
        }
        public static BigInteger fnv24Decimal(String str)
        {
            BigInteger r = 0;

            long t = FNVHasherStrFunctions.fnv24(str);

            if (t < 0)
            {
                r = BigInteger.Parse(
                    "0" +
                    FNVHasherStrFunctions.fnv24HexString(str).Replace("0x", "")
                    , NumberStyles.HexNumber);

            }
            else
            {
                r = t;
            }

            return r;
        }

        public static int fnv32(String str)
        {
            return FnvHash.fnv32(toBytes(str));
        }
        public static String fnv32HexString(String str)
        {
            String s = FNVHasherStrFunctions.fnv32(str).ToString("X");

            int l = 8 - s.Length;

            for (int x = 0; x < l; x++)
            {
                s = "0" + s;
            }
            s = "0x" + s;
            return s;
        }
        public static BigInteger fnv32Decimal(String str)
        {
            BigInteger r = 0;

            long t = FNVHasherStrFunctions.fnv32(str);

            if (t < 0)
            {
                r = BigInteger.Parse(
                    "0" +
                    FNVHasherStrFunctions.fnv32HexString(str).Replace("0x", "")
                    , NumberStyles.HexNumber);

            }
            else
            {
                r = t;
            }

            return r;
        }

        public static int fnv32HighBit(String str)
        {
            ulong highBitUL = 0x80000000;
            int highBit = (int)highBitUL;
            return FNVHasherStrFunctions.fnv32(str) | highBit;

        }
        public static String fnv32HighBitHexString(String str)
        {
            String s = FNVHasherStrFunctions.fnv32HighBit(str).ToString("X");

            int l = 8 - s.Length;

            for (int x = 0; x < l; x++)
            {
                s = "0" + s;
            }
            s = "0x" + s;
            return s;
        }
        public static BigInteger fnv32HighBitDecimal(String str)
        {
            BigInteger r = 0;

            long t = FNVHasherStrFunctions.fnv32HighBit(str);

            if (t < 0)
            {
                r = BigInteger.Parse(
                    "0" +
                    FNVHasherStrFunctions.fnv32HighBitHexString(str).Replace("0x", "")
                    , NumberStyles.HexNumber);

            }
            else
            {
                r = t;
            }

            return r;
        }

        public static long fnv64(String str)
        {
            return FnvHash.fnv64(toBytes(str));
        }
        public static String fnv64HexString(String str)
        {
            String s = FNVHasherStrFunctions.fnv64(str).ToString("X");

            int l = 16 - s.Length;

            for (int x = 0; x < l; x++)
            {
                s = "0" + s;
            }
            s = "0x" + s;
            return s;
        }
        public static BigInteger fnv64Decimal(String str)
        {
            BigInteger r = 0;

            long t = FNVHasherStrFunctions.fnv64(str);

            if (t < 0)
            {
                r = BigInteger.Parse(
                    "0" +
                    FNVHasherStrFunctions.fnv64HexString(str).Replace("0x", "")
                    , NumberStyles.HexNumber);

            }
            else
            {
                r = t;
            }

            return r;
        }

        public static long fnv64HighBit(String str)
        {
            ulong highBitUL = 0x8000000000000000;
            long highBit = (long)highBitUL;
            return FNVHasherStrFunctions.fnv64(str) | highBit;
        }
        public static String fnv64HighBitHexString(String str)
        {
            String s = FNVHasherStrFunctions.fnv64HighBit(str).ToString("X");

            int l = 16 - s.Length;

            for (int x = 0; x < l; x++)
            {
                s = "0" + s;
            }
            s = "0x" + s;
            return s;
        }
        public static BigInteger fnv64HighBitDecimal(String str)
        {
            BigInteger r = 0;

            long t = FNVHasherStrFunctions.fnv64HighBit(str);

            if (t < 0)
            {
                r = BigInteger.Parse(
                    "0" +
                    FNVHasherStrFunctions.fnv64HighBitHexString(str).Replace("0x", "")
                    , NumberStyles.HexNumber);

            }
            else
            {
                r = t;
            }

            return r;
        }

        public static BigInteger hexToDecimal(String hexStr)
        {
            BigInteger r = BigInteger.Parse(
                   "0" +
                  hexStr.Replace("0x", "").Replace("0X", "")
                   , NumberStyles.HexNumber);

            return r;
        }

        public static String decimalToHex(String decimalStr)
        {
            String s = Convert.ToInt64(decimalStr).ToString("X");
            s = "0x" + s;
            return s;
        }
    }
}
