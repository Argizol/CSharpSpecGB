using Newtonsoft.Json;
using Seminar7;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml.Linq;

class Program()
{
    [STAThread]
    static void Main(string[] args)
    {

        //ћожно через боль и JsonDocument, но зачем? Ѕерем нормальную бибилиотеку и делаем по человечески:

        string path = string.Empty;
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                path = Path.Combine(openFileDialog.FileName);
                using (StreamReader sr = new StreamReader(path))
                {
                    StringBuilder sb = new StringBuilder();
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        sb.Append(line);
                    }
                    XNode? node = JsonConvert.DeserializeXNode(sb.ToString(), "Root");
                    Console.WriteLine(node?.ToString());
                }
            }
        }
    }
}



