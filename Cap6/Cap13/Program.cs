using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Channels;
using System.Globalization;
using Cap13.Entities;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region FILEINFO

            /*
            string sourcePath = @"C:\temp\file.txt";
            string targetPath = @"C:\temp\file1.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (IOException ex) 
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }
            */

            #endregion

            #region FILESTREAM STREAMREADER

            /*
            string path = @"C:\temp\file.txt";

            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream) 
                {   
                    string line = sr.ReadLine();                    
                    Console.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
            */

            #endregion

            #region USING BLOCK

            //string path = @"C:\temp\file1.txt";

            // FORMA EXTENDIDA

            /*
            try 
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }  
            */

            // FORMA RESUMIDA

            /*
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }
            */

            #endregion

            #region STREAMWRITER

            /*
            string sourcePath = @"C:\temp\file1.txt";
            string targetPath = @"C:\temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }
            catch (IOException ex) 
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }
            */

            #endregion

            #region DIRECTORY, DIRECTORYINFO

            /*
            string path = @"C:\temp\myfolder";

            try
            {

                // LISTANDO PASTAS

                var folders = Directory.EnumerateDirectories(path,"*.*", SearchOption.AllDirectories);
                
                Console.WriteLine("FOLDERS:");

                foreach (string item in folders)
                {
                    Console.WriteLine(item);
                }

                // LISTANDO ARQUIVOS

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FILES:");

                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                // CRIANDO PASTA

                Directory.CreateDirectory(path + "/newfolder");
            }
            catch (IOException ex) 
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }
            */

            #endregion

            #region PATH

            /*
            string path = @"C:\temp\myfolder\file1";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
            */

            #endregion

            #region EXERCÍCIO DE FIXAÇÃO

            /*
            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"/out";
                string targetFilePath = targetFolderPath + @"/summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Products prod = new Products(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException ex) 
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }
            */

            #endregion

        }
    }
}