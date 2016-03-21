using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Security.Cryptography
{
    public abstract class HashAlgorithm : IDisposable
    {
        public void Dispose() { }

        public abstract byte[] ComputeHash(byte[] bytes);
    }

    public class HMACSHA1 : HashAlgorithm, IDisposable
    {
        private byte[] key;

        public HMACSHA1(byte[] key)
        {
            this.key = key;
        }

        public override byte[] ComputeHash(byte[] bytes)
        {
            throw new NotImplementedException();
        }
    }

    public class Rfc2898DeriveBytes : IDisposable
    {
        private int count;
        private string password;
        private byte[] saltBytes;

        public Rfc2898DeriveBytes(string password, byte[] saltBytes, int count)
        {
            this.password = password;
            this.saltBytes = saltBytes;
            this.count = count;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        internal byte[] GetBytes(int v)
        {
            throw new NotImplementedException();
        }
    }

    public class MD5CryptoServiceProvider : HashAlgorithm, IDisposable
    {
        public override byte[] ComputeHash(byte[] bytes)
        {
            throw new NotImplementedException();
        }
    }

    public class RNGCryptoServiceProvider : HashAlgorithm
    {
        public override byte[] ComputeHash(byte[] bytes)
        {
            throw new NotImplementedException();
        }
    }

    public class SHA1Managed : HashAlgorithm
    {
        public override byte[] ComputeHash(byte[] bytes)
        {
            throw new NotImplementedException();
        }
    }

    public class SHA256Managed : HashAlgorithm
    {
        public override byte[] ComputeHash(byte[] bytes)
        {
            throw new NotImplementedException();
        }
    }

    public class SHA384Managed : HashAlgorithm
    {
        public override byte[] ComputeHash(byte[] bytes)
        {
            throw new NotImplementedException();
        }
    }

    public class SHA512Managed : HashAlgorithm
    {
        public override byte[] ComputeHash(byte[] bytes)
        {
            throw new NotImplementedException();
        }
    }
}
