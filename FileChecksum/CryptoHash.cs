using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileChecksum
{
    internal class CryptoHash
    {
        public enum Hashs
        { MD5, SHA1, SAH256, SHA384, SHA512, BASE64 };

      //  http://stackoverflow.com/questions/2898609/system-threading-tasks-limit-the-number-of-concurrent-tasks

        public async Task<string> ComputeHash(string filename, Hashs Hashenum)
        {
            byte[] hashValue = null;
           
                try
                {
                    using (FileStream fs = File.OpenRead(filename))
                    {
                        fs.Position = 0;
                   



                        switch (Hashenum)
                        {
                            case Hashs.MD5:

                            // hashValue = MD5.Create().ComputeHash(fs);
                            //  return GetHashString(hashValue);

                            hashValue = CaculateHash(fs, MD5.Create());
                            return GetHashString(hashValue);

                            case Hashs.SHA1:
                            //  hashValue = SHA1.Create().ComputeHash(fs);
                            //  return GetHashString(hashValue);

                            hashValue = CaculateHash(fs,SHA1.Create());
                            return GetHashString(hashValue);

                        case Hashs.SAH256:
                            // hashValue = SHA256.Create().ComputeHash(fs);
                            //  return GetHashString(hashValue);

                            hashValue = CaculateHash(fs, SHA256.Create());
                            return GetHashString(hashValue);

                        case Hashs.SHA384:
                            //  hashValue = SHA384.Create().ComputeHash(fs);
                            //  return GetHashString(hashValue);

                            hashValue = CaculateHash(fs, SHA384.Create());
                            return GetHashString(hashValue);

                        case Hashs.SHA512:
                            //  hashValue = SHA512.Create().ComputeHash(fs);
                            //  return GetHashString(hashValue);

                            hashValue = CaculateHash(fs, SHA512.Create());
                            return GetHashString(hashValue);

                        case Hashs.BASE64:
                                // Compute the BASE64 hash of the fileStream.
                                byte[] binaryData = new byte[fs.Length];
                                long bytesRead = fs.Read(binaryData, 0, (int)fs.Length);
                                if (bytesRead != fs.Length)
                                {
                                    throw new Exception(String.Format("Number of bytes read ({0}) does not match file size ({1}).", bytesRead, fs.Length));
                                }
                                return System.Convert.ToBase64String(binaryData, 0, binaryData.Length);
                            //   Console.WriteLine("File: {0}\r\nBASE64 Hash: {1}", fs.Name, base64String);

                            default:
                                hashValue = null;

                                break;
                        }

                        fs.Close();
                    }
                }
                catch (System.Exception)
                {
                    hashValue = null;

                    return string.Empty;
                }

                return string.Empty;
          

           
        }


        const int chunkSize = 1042;
        static byte[] CaculateHash(Stream input, HashAlgorithm algo)
        {
            int bytesRead;
            byte[] buffer = new byte[chunkSize];
            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                algo.TransformBlock(buffer, 0, bytesRead, buffer, 0);
                
            } algo.TransformFinalBlock(buffer, 0, bytesRead);
            return algo.Hash;
        }

       


        private string GetHashString(byte[] array)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(string.Format("{0:x2}", array[i]));
            }
            string hash = sb.ToString();

            return hash.Count() > 1 ? hash : string.Empty;
        }
    }
}