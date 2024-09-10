using System.Text;

namespace lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789";

            byte[] bb = File.ReadAllBytes("CodeBreakers.txt");

            int[] stat = new int[256];

            for (int i = 0; i < bb.Length; i++)
            {
                stat[bb[i]]++;
            }

            File.WriteAllText("stat1.csv", string.Join("\n", stat));


            // Encrypt caesar

            int key = 9;
            string text = File.ReadAllText("CodeBreakers.txt", Encoding.GetEncoding(866));
            char[] e = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (alphabet.Contains(c))
                {
                    int idx = alphabet.IndexOf(c);
                    e[i] = alphabet[(idx + key) % alphabet.Length];
                }
                else 
                    e[i] = c;
            }

            File.WriteAllText("encrypted.txt", new string(e), Encoding.GetEncoding(866));


            File.WriteAllText("encrypted.txt", new string(e), Encoding.GetEncoding(866));

            bb = File.ReadAllBytes("encrypted.txt");
            int[] stat2 = new int[256];

            for (int i = 0; i < bb.Length; i++)
            {
                stat2[bb[i]]++;
            }
            File.WriteAllText("stat2.csv", string.Join("\n", stat2));



            int N = text.Length / 4;
            char[] e4 = new char[N];
            int delta = text.Length/3;
            for (int i = 0; i < N; i++)
            {
                char c = text[i+delta];
                if (alphabet.Contains(c))
                {
                    int idx = alphabet.IndexOf(c);
                    e4[i] = alphabet[(idx + key) % alphabet.Length];
                }
                else
                    e4[i] = c;
            }

            File.WriteAllText("encryptedFrag.txt", new string(e4), Encoding.GetEncoding(866));

            bb = File.ReadAllBytes("encryptedFrag.txt");
            int[] stat3 = new int[256];

            for (int i = 0; i < bb.Length; i++)
            {
                stat2[bb[i]]++;
            }
            File.WriteAllText("stat3.csv", string.Join("\n", stat2));




            bb = File.ReadAllBytes("amdm.txt");

            int[] stat4 = new int[256];

            for (int i = 0; i < bb.Length; i++)
            {
                stat[bb[i]]++;
            }

            File.WriteAllText("stat4.csv", string.Join("\n", stat));
        }
    }
}
