using System;
using System.IO;

namespace ExamSystem
{
    class IPAdress
    {
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ExamApp", "IpAddress.txt");
        string newpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ExamApp");
        public void CreateFile()
        {

            if (!Directory.Exists(newpath))
            {
                

                Directory.CreateDirectory(newpath);
                StreamWriter file = new StreamWriter(path);
                file.Write("127.0.0.1");
                file.Close();
            }
            else if(!File.Exists(path))
            {
                StreamWriter file = new StreamWriter(path);
                file.Write("127.0.0.1");
                file.Close();
            }
        }

        public string ReadFile()
        {
            string address = null;
            if (Directory.Exists(newpath))
            {
                StreamReader fileReader = new StreamReader(path);
                while (!fileReader.EndOfStream)
                {
                    address = fileReader.ReadLine();
                }
            }

            return address;
        }
    }
}
