namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography;
    using System.Text;

    public static class AESThenHMAC
    {
        private static readonly RandomNumberGenerator Random = RandomNumberGenerator.Create();
        public static readonly int BlockBitSize = 0x80;
        public static readonly int KeyBitSize = 0x100;
        public static readonly int SaltBitSize = 0x40;
        public static readonly int Iterations = 0x2710;
        public static readonly int MinPasswordLength = 12;

        public static byte[] NewKey()
        {
            byte[] data = new byte[KeyBitSize / 8];
            Random.GetBytes(data);
            return data;
        }

        public static string SimpleDecrypt(string encryptedMessage, byte[] cryptKey, byte[] authKey, int nonSecretPayloadLength = 0)
        {
            if (string.IsNullOrWhiteSpace(encryptedMessage))
            {
                throw new ArgumentException("Encrypted Message Required!", "encryptedMessage");
            }
            byte[] bytes = SimpleDecrypt(Convert.FromBase64String(encryptedMessage), cryptKey, authKey, nonSecretPayloadLength);
            return Encoding.UTF8.GetString(bytes);
        }

        public static byte[] SimpleDecrypt(byte[] encryptedMessage, byte[] cryptKey, byte[] authKey, int nonSecretPayloadLength = 0)
        {
            byte[] buffer3;
            if ((cryptKey == null) || (cryptKey.Length != (KeyBitSize / 8)))
            {
                throw new ArgumentException($"CryptKey needs to be {KeyBitSize} bit!", "cryptKey");
            }
            if ((authKey == null) || (authKey.Length != (KeyBitSize / 8)))
            {
                throw new ArgumentException($"AuthKey needs to be {KeyBitSize} bit!", "authKey");
            }
            if ((encryptedMessage == null) || (encryptedMessage.Length == 0))
            {
                throw new ArgumentException("Encrypted Message Required!", "encryptedMessage");
            }
            using (HMACSHA256 hmacsha = new HMACSHA256(authKey))
            {
                byte[] destinationArray = new byte[hmacsha.HashSize / 8];
                byte[] buffer2 = hmacsha.ComputeHash(encryptedMessage, 0, encryptedMessage.Length - destinationArray.Length);
                int num = BlockBitSize / 8;
                if (encryptedMessage.Length < ((destinationArray.Length + nonSecretPayloadLength) + num))
                {
                    buffer3 = null;
                }
                else
                {
                    Array.Copy(encryptedMessage, encryptedMessage.Length - destinationArray.Length, destinationArray, 0, destinationArray.Length);
                    int num2 = 0;
                    int index = 0;
                    while (true)
                    {
                        if (index >= destinationArray.Length)
                        {
                            if (num2 != 0)
                            {
                                buffer3 = null;
                            }
                            else
                            {
                                AesManaged managed1 = new AesManaged();
                                managed1.KeySize = KeyBitSize;
                                managed1.BlockSize = BlockBitSize;
                                managed1.Mode = CipherMode.CBC;
                                managed1.Padding = PaddingMode.PKCS7;
                                using (AesManaged managed = managed1)
                                {
                                    byte[] buffer4 = new byte[num];
                                    Array.Copy(encryptedMessage, nonSecretPayloadLength, buffer4, 0, buffer4.Length);
                                    using (ICryptoTransform transform = managed.CreateDecryptor(cryptKey, buffer4))
                                    {
                                        using (MemoryStream stream = new MemoryStream())
                                        {
                                            using (CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write))
                                            {
                                                using (BinaryWriter writer = new BinaryWriter(stream2))
                                                {
                                                    writer.Write(encryptedMessage, nonSecretPayloadLength + buffer4.Length, ((encryptedMessage.Length - nonSecretPayloadLength) - buffer4.Length) - destinationArray.Length);
                                                }
                                            }
                                            buffer3 = stream.ToArray();
                                        }
                                    }
                                }
                            }
                            break;
                        }
                        num2 |= destinationArray[index] ^ buffer2[index];
                        index++;
                    }
                }
            }
            return buffer3;
        }

        public static string SimpleDecryptWithPassword(string encryptedMessage, string password, int nonSecretPayloadLength = 0)
        {
            if (string.IsNullOrWhiteSpace(encryptedMessage))
            {
                throw new ArgumentException("Encrypted Message Required!", "encryptedMessage");
            }
            byte[] bytes = SimpleDecryptWithPassword(Convert.FromBase64String(encryptedMessage), password, nonSecretPayloadLength);
            return Encoding.UTF8.GetString(bytes);
        }

        public static byte[] SimpleDecryptWithPassword(byte[] encryptedMessage, string password, int nonSecretPayloadLength = 0)
        {
            byte[] buffer3;
            byte[] buffer4;
            if (string.IsNullOrWhiteSpace(password) || (password.Length < MinPasswordLength))
            {
                throw new ArgumentException($"Must have a password of at least {MinPasswordLength} characters!", "password");
            }
            if ((encryptedMessage == null) || (encryptedMessage.Length == 0))
            {
                throw new ArgumentException("Encrypted Message Required!", "encryptedMessage");
            }
            byte[] destinationArray = new byte[SaltBitSize / 8];
            byte[] buffer2 = new byte[SaltBitSize / 8];
            Array.Copy(encryptedMessage, nonSecretPayloadLength, destinationArray, 0, destinationArray.Length);
            Array.Copy(encryptedMessage, nonSecretPayloadLength + destinationArray.Length, buffer2, 0, buffer2.Length);
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, destinationArray, Iterations))
            {
                buffer3 = bytes.GetBytes(KeyBitSize / 8);
            }
            using (Rfc2898DeriveBytes bytes2 = new Rfc2898DeriveBytes(password, buffer2, Iterations))
            {
                buffer4 = bytes2.GetBytes(KeyBitSize / 8);
            }
            return SimpleDecrypt(encryptedMessage, buffer3, buffer4, (destinationArray.Length + buffer2.Length) + nonSecretPayloadLength);
        }

        public static string SimpleEncrypt(string secretMessage, byte[] cryptKey, byte[] authKey, byte[] nonSecretPayload = null)
        {
            if (string.IsNullOrEmpty(secretMessage))
            {
                throw new ArgumentException("Secret Message Required!", "secretMessage");
            }
            return Convert.ToBase64String(SimpleEncrypt(Encoding.UTF8.GetBytes(secretMessage), cryptKey, authKey, nonSecretPayload));
        }

        public static byte[] SimpleEncrypt(byte[] secretMessage, byte[] cryptKey, byte[] authKey, byte[] nonSecretPayload = null)
        {
            byte[] buffer;
            byte[] iV;
            byte[] buffer4;
            if ((cryptKey == null) || (cryptKey.Length != (KeyBitSize / 8)))
            {
                throw new ArgumentException($"Key needs to be {KeyBitSize} bit!", "cryptKey");
            }
            if ((authKey == null) || (authKey.Length != (KeyBitSize / 8)))
            {
                throw new ArgumentException($"Key needs to be {KeyBitSize} bit!", "authKey");
            }
            if ((secretMessage == null) || (secretMessage.Length < 1))
            {
                throw new ArgumentException("Secret Message Required!", "secretMessage");
            }
            nonSecretPayload = new byte[0];
            AesManaged managed1 = new AesManaged();
            managed1.KeySize = KeyBitSize;
            managed1.BlockSize = BlockBitSize;
            managed1.Mode = CipherMode.CBC;
            managed1.Padding = PaddingMode.PKCS7;
            using (AesManaged managed = managed1)
            {
                managed.GenerateIV();
                iV = managed.IV;
                using (ICryptoTransform transform = managed.CreateEncryptor(cryptKey, iV))
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        using (CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write))
                        {
                            using (BinaryWriter writer = new BinaryWriter(stream2))
                            {
                                writer.Write(secretMessage);
                            }
                        }
                        buffer = stream.ToArray();
                    }
                }
            }
            using (HMACSHA256 hmacsha = new HMACSHA256(authKey))
            {
                using (MemoryStream stream3 = new MemoryStream())
                {
                    using (BinaryWriter writer2 = new BinaryWriter(stream3))
                    {
                        writer2.Write(nonSecretPayload);
                        writer2.Write(iV);
                        writer2.Write(buffer);
                        writer2.Flush();
                        writer2.Write(hmacsha.ComputeHash(stream3.ToArray()));
                    }
                    buffer4 = stream3.ToArray();
                }
            }
            return buffer4;
        }

        public static string SimpleEncryptWithPassword(string secretMessage, string password, byte[] nonSecretPayload = null)
        {
            if (string.IsNullOrEmpty(secretMessage))
            {
                throw new ArgumentException("Secret Message Required!", "secretMessage");
            }
            return Convert.ToBase64String(SimpleEncryptWithPassword(Encoding.UTF8.GetBytes(secretMessage), password, nonSecretPayload));
        }

        public static byte[] SimpleEncryptWithPassword(byte[] secretMessage, string password, byte[] nonSecretPayload = null)
        {
            byte[] buffer2;
            byte[] buffer3;
            nonSecretPayload = new byte[0];
            if (string.IsNullOrWhiteSpace(password) || (password.Length < MinPasswordLength))
            {
                throw new ArgumentException($"Must have a password of at least {MinPasswordLength} characters!", "password");
            }
            if ((secretMessage == null) || (secretMessage.Length == 0))
            {
                throw new ArgumentException("Secret Message Required!", "secretMessage");
            }
            byte[] destinationArray = new byte[((SaltBitSize / 8) * 2) + nonSecretPayload.Length];
            Array.Copy(nonSecretPayload, destinationArray, nonSecretPayload.Length);
            int length = nonSecretPayload.Length;
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, SaltBitSize / 8, Iterations))
            {
                byte[] salt = bytes.Salt;
                buffer2 = bytes.GetBytes(KeyBitSize / 8);
                Array.Copy(salt, 0, destinationArray, length, salt.Length);
                length += salt.Length;
            }
            using (Rfc2898DeriveBytes bytes2 = new Rfc2898DeriveBytes(password, SaltBitSize / 8, Iterations))
            {
                byte[] salt = bytes2.Salt;
                buffer3 = bytes2.GetBytes(KeyBitSize / 8);
                Array.Copy(salt, 0, destinationArray, length, salt.Length);
            }
            return SimpleEncrypt(secretMessage, buffer2, buffer3, destinationArray);
        }
    }
}

