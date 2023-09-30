namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Compression;
    using System.Security.Cryptography;
    using System.Text;
    using System.Xml.Linq;

    public static class Cryptography
    {
        public const string PublicPayload = "w/bWa1zwkuls4o6OhmcrudVCYyPdWf4apSdvAU8Ve4kXxz+fRXMVVU2z6LZsmZFZupgIHtpCNvAdThev9K2xJM";
        public static int NumberOfPbkdfRounds = 0x11170;
        private static readonly byte[] NonSecretPayload = new byte[] { 
            0xfd, 0xff, 0xaf, 0xcb, 0xf2, 15, 0x56, 0xc6, 0x8b, 0x95, 0xcc, 0xfd, 0xff, 0xff, 0xe8, 0x19,
            2, 1, 2, 0x89, 0x5e, 0x8b, 0xec, 0x81, 0x9a, 0xb5, 250, 0xff, 0xca, 0x8a, 0x85, 0xec,
            0xd8, 0xab, 130, 0x23, 0x55, 0xc3, 0xb5, 0xcc, 0xf4, 0xbb, 0x85, 0x3b, 0xae, 0xdb, 0x8b, 0x95,
            0xcc, 0xfd, 0x4f, 0x3f, 0xe8, 0xf3, 3, 0xcb, 3, 1, 90, 240, 0x8d, 0xcb, 0xb6, 0x5d,
            0x8b, 0x95, 0xcc, 0xfd, 0xff, 0xff, 0xe8, 0xcd, 1, 0xc9, 0xc3, 0x89, 0x45, 0xe8, 0xbb, 0x53,
            0xbb, 0x93, 0x35, 0xdf, 0x85, 0x8b, 0x95, 0xcc, 0xfd, 0xff, 0xff, 0xe8, 0xe0, 1, 0, 0,
            0x89, 0x45, 0xec, 0xbb, 0x49, 0x1c, 3, 200, 0xc1, 0xe3, 2, 0x99
        };
        private const string Seed = "NRCan HouseFile Library \x00a92014";

        public static string BytesToString(byte[] Data) => 
            (Data != null) ? Encoding.UTF8.GetString(Data) : null;

        public static byte[] CreateHmac(byte[] Salt, AesCryptoServiceProvider Aes, byte[] EncryptedMessage)
        {
            byte[] dst = new byte[EncryptedMessage.Length + Salt.Length];
            Buffer.BlockCopy(EncryptedMessage, 0, dst, 0, EncryptedMessage.Length);
            Buffer.BlockCopy(Salt, 0, dst, EncryptedMessage.Length, Salt.Length);
            using (HMACSHA256 hmacsha = new HMACSHA256(Aes.Key))
            {
                return hmacsha.ComputeHash(dst);
            }
        }

        public static string Decrypt(string encryptedMessage) => 
            AESThenHMAC.SimpleDecryptWithPassword(encryptedMessage, "NRCan HouseFile Library \x00a92014", NonSecretPayload.Length);

        //public static byte[] Decrypt(byte[] EncryptedData, string PassPhrase)
        //{
        //    byte[] buffer3;
        //    if ((EncryptedData == null) || (PassPhrase == null))
        //    {
        //        return null;
        //    }
        //    byte[] dst = new byte[0x20];
        //    Buffer.BlockCopy(EncryptedData, 0, dst, 0, 0x20);
        //    byte[] buffer2 = new byte[EncryptedData.Length - 0x20];
        //    Buffer.BlockCopy(EncryptedData, 0x20, buffer2, 0, EncryptedData.Length - 0x20);
        //    try
        //    {
        //        using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(PassPhrase, dst, NumberOfPbkdfRounds))
        //        {
        //            using (AesCryptoServiceProvider provider = new AesCryptoServiceProvider())
        //            {
        //                provider.Mode = CipherMode.CBC;
        //                provider.Padding = PaddingMode.PKCS7;
        //                provider.Key = bytes.GetBytes(0x20);
        //                provider.IV = bytes.GetBytes(0x10);
        //                using (MemoryStream stream = new MemoryStream())
        //                {
        //                    byte[] buffer4 = new byte[buffer2.Length - 0x20];
        //                    Buffer.BlockCopy(buffer2, 0x20, buffer4, 0, buffer2.Length - 0x20);
        //                    byte[] buffer6 = new byte[0x20];
        //                    Buffer.BlockCopy(buffer2, 0, buffer6, 0, 0x20);
        //                    byte[] res = CreateHmac(dst, provider, buffer4);
        //                    if (  !buffer6.Equals(res, StructuralComparisons.StructuralEqualityComparer))
        //                    {
        //                        throw new CryptographicException("HMAC check failed. Data corrupted?");
        //                    }
        //                    CryptoStream stream1 = new CryptoStream(stream, provider.CreateDecryptor(), CryptoStreamMode.Write);
        //                    stream1.Write(buffer4, 0, buffer4.Length);
        //                    stream1.FlushFinalBlock();
        //                    buffer3 = stream.ToArray();
        //                }
        //            }
        //        }
        //    }
        //    catch (CryptographicException exception1)
        //    {
        //        throw new CryptographicException(exception1.Message);
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //    List<byte> list = new List<byte>();
        //    using (MemoryStream stream2 = new MemoryStream(buffer3))
        //    {
        //        GZipStream stream3 = new GZipStream(stream2, CompressionMode.Decompress);
        //        while (true)
        //        {
        //            int num = stream3.ReadByte();
        //            if (num == -1)
        //            {
        //                stream3.Close();
        //                stream2.Close();
        //                break;
        //            }
        //            list.Add((byte) num);
        //        }
        //    }
        //    return list.ToArray();
        //}
        public static byte[] Decrypt(byte[] EncryptedData, string PassPhrase)
        {
            byte[] buffer3;
            if ((EncryptedData == null) || (PassPhrase == null))
            {
                return null;
            }
            byte[] dst = new byte[0x20];
            Buffer.BlockCopy(EncryptedData, 0, dst, 0, 0x20);
            byte[] buffer2 = new byte[EncryptedData.Length - 0x20];
            Buffer.BlockCopy(EncryptedData, 0x20, buffer2, 0, EncryptedData.Length - 0x20);
            try
            {
                using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(PassPhrase, dst, NumberOfPbkdfRounds))
                {
                    using (AesCryptoServiceProvider provider = new AesCryptoServiceProvider())
                    {
                        provider.Mode = CipherMode.CBC;
                        provider.Padding = PaddingMode.PKCS7;
                        provider.Key = bytes.GetBytes(0x20);
                        provider.IV = bytes.GetBytes(0x10);
                        using (MemoryStream stream = new MemoryStream())
                        {
                            byte[] buffer4 = new byte[buffer2.Length - 0x20];
                            Buffer.BlockCopy(buffer2, 0x20, buffer4, 0, buffer2.Length - 0x20);
                            byte[] other = CreateHmac(dst, provider, buffer4);
                            byte[] buffer6 = new byte[0x20];
                            Buffer.BlockCopy(buffer2, 0, buffer6, 0, 0x20);
                            //if (!buffer6.Equals(other, StructuralComparisons.StructuralEqualityComparer))
                            //{
                            //    throw new CryptographicException("HMAC check failed. Data corrupted?");
                            //}
                            CryptoStream stream1 = new CryptoStream(stream, provider.CreateDecryptor(), CryptoStreamMode.Write);
                            stream1.Write(buffer4, 0, buffer4.Length);
                            stream1.FlushFinalBlock();
                            buffer3 = stream.ToArray();
                        }
                    }
                }
            }
            catch (CryptographicException exception1)
            {
                throw new CryptographicException(exception1.Message);
            }
            catch
            {
                return null;
            }
            List<byte> list = new List<byte>();
            using (MemoryStream stream2 = new MemoryStream(buffer3))
            {
                int num;
                GZipStream stream3 = new GZipStream(stream2, CompressionMode.Decompress);
                while ((num = stream3.ReadByte()) != -1)
                {
                    list.Add((byte)num);
                }
                stream3.Close();
                stream2.Close();
            }
            return list.ToArray();
        }

        public static byte[] DecryptFile(string FileName, string RsaPrivateKey)
        {
            byte[] src = File.ReadAllBytes(FileName);
            byte[] dst = new byte[0x80];
            byte[] buffer3 = new byte[src.Length - 0x80];
            Buffer.BlockCopy(src, 0, dst, 0, 0x80);
            Buffer.BlockCopy(src, 0x80, buffer3, 0, src.Length - 0x80);
            return Decrypt(buffer3, RsaDecryptString(dst, RsaPrivateKey));
        }

        public static string DecryptFileToString(string FileName, string RsaPrivateKey) => 
            BytesToString(DecryptFile(FileName, RsaPrivateKey));

        public static string DecryptFromFile(string filename) => 
            Decrypt(Convert.ToBase64String(File.ReadAllBytes(filename)));

        public static string DecryptString(byte[] EncryptedData, string PassPhrase) => 
            BytesToString(Decrypt(EncryptedData, PassPhrase));

        public static XElement DecryptXmlFromFile(string filename) => 
            XDocument.Parse(DecryptFromFile(filename)).Root;

        public static string Encrypt(string message) => 
            AESThenHMAC.SimpleEncryptWithPassword(message, "NRCan HouseFile Library \x00a92014", NonSecretPayload);

        public static void EncryptToFile(string message, string filename)
        {
            File.WriteAllBytes(filename, Convert.FromBase64String(Encrypt(message)));
        }

        public static void EncryptXmlToFile(XElement xml, string filename)
        {
            EncryptToFile(xml.ToString(), filename);
        }

        public static byte[] RsaDecrypt(byte[] EncryptedData, string PrivateKey)
        {
            using (RSACryptoServiceProvider provider = new RSACryptoServiceProvider())
            {
                provider.FromXmlString(PrivateKey);
                return provider.Decrypt(EncryptedData, true);
            }
        }

        public static string RsaDecryptString(byte[] EncryptedData, string PrivateKey) => 
            BytesToString(RsaDecrypt(EncryptedData, PrivateKey));

        public static byte[] StringToBytes(string Data) => 
            !string.IsNullOrEmpty(Data) ? Encoding.UTF8.GetBytes(Data) : null;
    }
}

