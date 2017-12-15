﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OIS.Common.Utils
{
    /// <summary>
    /// Sysmmetric Encrypt and Decrypt the string.
    /// Contain two method.
    /// </summary>
    public class Encryption
    {
        /// <summary>
        /// One-way encryption.
        /// </summary>
        /// <param name="strKey">Key</param>
        /// <param name="strPass">Password</param>
        /// <returns></returns>
        public static string MD5EncryptString(string strKey, string strPass)
        {
            /*กระบวนการเข้ารหัส
             *  จะนำรหัสของ Key และ Pass มา Hash เป็น ByteArray
             *  แล้วนำ ByteArray ที่ได้มาทำการ XOR กัน
             *  เสร็จแล้วจะทำการ Reverse byte array เพื่อสร้างเป็นข้อความรหัสผ่าน
             */
            byte[] byteHashKey = MD5EncryptString(strKey);
            byte[] byteHashPass = MD5EncryptString(strPass);

            string strHash = "";
            for (int i = byteHashKey.Length - 1; i >= 0; i--)
            {
                strHash += String.Format("{0:X2}", byteHashKey[i] ^ byteHashPass[i]);
            }
            return strHash;
        }

        public static byte[] MD5EncryptString(string plainText)
        {
            MD5 md5 = MD5.Create();
            byte[] byteText = Encoding.ASCII.GetBytes(plainText);

            byte[] byteHashText = md5.ComputeHash(byteText);
            return byteHashText;
        }

        public static string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        /// <summary>
        /// Encrypt the string input with password key. Return string encrypted.
        /// </summary>
        /// <param name="InputPlainTxt"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public static string TwoWayEncryptString(string InputPlainTxt, string Key)
        {
            RijndaelManaged RijndaelCipher = new RijndaelManaged();
            byte[] PlainText = System.Text.Encoding.Unicode.GetBytes(InputPlainTxt);
            byte[] Salt = Encoding.ASCII.GetBytes(Key.Length.ToString());
            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Key, Salt);
            ICryptoTransform Encryptor = RijndaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(PlainText, 0, PlainText.Length);
            cryptoStream.FlushFinalBlock();
            byte[] CipherBytes = memoryStream.ToArray();
            memoryStream.Close();
            string EncryptedData = Convert.ToBase64String(CipherBytes);
            return EncryptedData;
        }

        /// <summary>
        /// Decrypt the string encrypted with the match password key. Return string original.
        /// </summary>
        /// <param name="InputEncTxt"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        /// <exception cref="DBEncryptionException"><c>DBEncryptionException</c>.</exception>
        public static string TwoWayDecryptString(string InputEncTxt, string Key)
        {
            try
            {
                RijndaelManaged RijndaelCipher = new RijndaelManaged();
                byte[] EncryptedData = Convert.FromBase64String(InputEncTxt);
                byte[] Salt = Encoding.ASCII.GetBytes(Key.Length.ToString());
                PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Key, Salt);
                ICryptoTransform Decryptor = RijndaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));

                MemoryStream memoryStream = new MemoryStream(EncryptedData);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read);
                byte[] PlainText = new byte[EncryptedData.Length];
                int DecryptedCount = cryptoStream.Read(PlainText, 0, PlainText.Length);
                memoryStream.Close();
                cryptoStream.Close();
                string DecryptedData = Encoding.Unicode.GetString(PlainText, 0, DecryptedCount);
                return DecryptedData;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

    }
}
