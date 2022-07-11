namespace RijndaelAlgorithmTest
{
    public static class Encryption
    {
        static string passPhrase = "P@ssPhr@se";        // can be any string
        static string saltValue = "S@1tV@lue";          // can be any string
        static string hashAlgorithm = "SHA1";           // can be "MD5"
        static int passwordIterations = 2;              // can be any number
        static string initVector = "@1B2c3D4e5F6g7H8";  // must be 16 bytes
        static int keySize = 256;                       // can be 192 or 128

        /// <summary>
        /// Decrypts the data.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        public static string DecryptData(
            string message)
        {

            return RijndaelAlgorithm.Decrypt(message,
                                                 passPhrase,
                                                 saltValue,
                                                 hashAlgorithm,
                                                 passwordIterations,
                                                 initVector,
                                                 keySize);
        }

        /// <summary>
        /// Encyrpts the data.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        public static string EncyrptData(
            string message)
        {

            return RijndaelAlgorithm.Encrypt(message,
                                                        passPhrase,
                                                        saltValue,
                                                        hashAlgorithm,
                                                        passwordIterations,
                                                        initVector,
                                                        keySize);

        }
    }
}
