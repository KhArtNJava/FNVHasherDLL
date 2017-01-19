using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace FNVHasherDLL
{
    public class FnvHash
    {

        private const int OFFSET_BASIS_32 = -2128831035;
        private const int FNV_PRIME_32 = 16777619;

        private const long OFFSET_BASIS_64 = -3750763034362895579L;
        private const long FNV_PRIME_64 = 1099511628211L;

        public static uint fnv24(byte[] bytes)
        {
            return FnvHash.fnv24(bytes, OFFSET_BASIS_32);
        }

        public static uint fnv24(byte[] bytes, int offset_basis)
        {
            uint hash = (uint)FnvHash.fnv32(bytes, offset_basis);

            return hash >> 24 ^ hash & 0xFFFFFF;
            // first hash >>> 24
            //second is & 0xFFFFFF
            //third is ^ hash

            //    Console.WriteLine("hash 1 !!! = " + (hash >> 24));
            //hash = (hash >> 24);

            //Console.WriteLine("hash 2 !!! = " + hash);
            //hash = hash & 0xFFFFFF;

            //Console.WriteLine("hash 3 !!! = " + hash);
            //hash = hash ^ hash;

            //Console.WriteLine("hash 4 !!! = " + hash);
            //  return hash;
        }

        public static int fnv32(byte[] bytes)
        {
            return FnvHash.fnv32(bytes, OFFSET_BASIS_32);
        }

        public static int fnv32(byte[] bytes, int offset_basis)
        {
            int hash = offset_basis;
            foreach (byte b in bytes)
            {
                hash *= FNV_PRIME_32;
                hash ^= b;
            }
            return hash;
        }


        public static long fnv64(byte[] bytes)
        {
            return FnvHash.fnv64(bytes, OFFSET_BASIS_64);
        }

        public static long fnv64(byte[] bytes, long offset_basis)
        {
            long hash = offset_basis;
            foreach (byte b in bytes)
            {
                hash *= FNV_PRIME_64;
                hash ^= b;
            }
            return hash;
        }






        //public static long fnv64HighBit(String str)
        //{
        //    ulong highBitUL = 0x8000000000000000L;
        //    long highBit = (long)highBitUL;
        //    return fnv64(str) | highBit;
        //}


    }
}
