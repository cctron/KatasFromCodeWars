using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Katas.Business;

namespace Katas.Tests
{
    public class KataSimpleEncryptionAlternatingSplitTests
    {
        [Fact]
        public void EncryptExampleTests()
        {
            Assert.Equal("This is a test!", KataSimpleEncryptionAlternatingSplit.Encrypt("This is a test!", 0));
            Assert.Equal("hsi  etTi sats!", KataSimpleEncryptionAlternatingSplit.Encrypt("This is a test!", 1));
            Assert.Equal("s eT ashi tist!", KataSimpleEncryptionAlternatingSplit.Encrypt("This is a test!", 2));
            Assert.Equal(" Tah itse sits!", KataSimpleEncryptionAlternatingSplit.Encrypt("This is a test!", 3));
            Assert.Equal("This is a test!", KataSimpleEncryptionAlternatingSplit.Encrypt("This is a test!", 4));
            Assert.Equal("This is a test!", KataSimpleEncryptionAlternatingSplit.Encrypt("This is a test!", -1));
            Assert.Equal("hskt svr neetn!Ti aai eyitrsig", KataSimpleEncryptionAlternatingSplit.Encrypt("This kata is very interesting!", 1));
        }

        [Fact]
        public void DecryptExampleTests()
        {
            Assert.Equal("This is a test!", KataSimpleEncryptionAlternatingSplit.Decrypt("This is a test!", 0));
            Assert.Equal("This is a test!", KataSimpleEncryptionAlternatingSplit.Decrypt("hsi  etTi sats!", 1));
            Assert.Equal("This is a test!", KataSimpleEncryptionAlternatingSplit.Decrypt("s eT ashi tist!", 2));
            Assert.Equal("This is a test!", KataSimpleEncryptionAlternatingSplit.Decrypt(" Tah itse sits!", 3));
            Assert.Equal("This is a test!", KataSimpleEncryptionAlternatingSplit.Decrypt("This is a test!", 4));
            Assert.Equal("This is a test!", KataSimpleEncryptionAlternatingSplit.Decrypt("This is a test!", -1));
            Assert.Equal("This kata is very interesting!", KataSimpleEncryptionAlternatingSplit.Decrypt("hskt svr neetn!Ti aai eyitrsig", 1));
        }

        [Fact]
        public void EmptyTests()
        {
            Assert.Equal("", KataSimpleEncryptionAlternatingSplit.Encrypt("", 0));
            Assert.Equal("", KataSimpleEncryptionAlternatingSplit.Decrypt("", 0));
        }

        [Fact]
        public void NullTests()
        {
            Assert.Null(KataSimpleEncryptionAlternatingSplit.Encrypt(null, 0));
            Assert.Null(KataSimpleEncryptionAlternatingSplit.Decrypt(null, 0));
        }
    }
}
