using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;
namespace DS
{
    class Parser
    {

        public static List<HrefModel> ParseMainPage(string website)
        {
            WebClient webClient = new WebClient();
            string page = webClient.DownloadString(website);

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(page);

            List<List<string>> table = doc.DocumentNode.SelectSingleNode("//table[@width='100%']")
            .Descendants("tr")
            .Skip(1)
            .Where(tr => tr.Elements("td").Count() > 1)
            .Select
            (
                 tr => tr.Elements("td")
                .Select(td => td.InnerText.Trim())
                .ToList()
            )
            .ToList();
            List<string> hrefs = doc.DocumentNode.SelectNodes("//table[@width='100%']")
            .Descendants("a")
            .Where(a => a.OuterHtml.Contains("href"))
            .Select(a => a.OuterHtml)
            .ToList();
            for (int i = 0; i < hrefs.Count; i++)
            {
                int j = 0;
                string str = null;
                while (hrefs[i][j] != '"')
                    j++;
                j++;
                while (hrefs[i][j] != '"')
                {
                    str += hrefs[i][j];
                    j++;
                }
                hrefs[i] = website + str;
            }
            for (int i = 0; i < table.Count; i++)
            {
                for (int j = 0; j < table[i].Count; j++)
                {
                    if (table[i][j].Length < 10)
                    {
                        table[i].Remove(table[i][j]);
                        break;
                    }
                    var fromEncodind = Encoding.GetEncoding("windows-1251");//из какой кодировки
                    var bytes = fromEncodind.GetBytes(table[i][j]);
                    var toEncoding = Encoding.UTF8;//в какую кодировку
                    table[i][j] = toEncoding.GetString(bytes);
                    table[i][j] = table[i][j].Replace("&shy;", "");
                    table[i][j] = table[i][j].Replace("&nbsp;", " ");
                }
            }
            List<HrefModel> Questions = new List<HrefModel>();
            int z = 0, k = 0;
            for (int i = 0; i < table.Count; i++)
            {
                for (int j = 0; j < table[i].Count; j++)
                {
                    if (table[i][j][0] == 'З')
                    {
                        HrefModel q = new HrefModel();
                        q.Types = new List<HrefModel.type>();
                        q.Name = table[i][j];
                        Questions.Add(q);
                        z++;
                    }
                    else
                    {
                        HrefModel.type t = new HrefModel.type();
                        t.Name = table[i][j];
                        t.href = hrefs[k];
                        Questions[z - 1].Types.Add(t);
                        k++;
                    }

                }
            }
            return Questions;
        }

        private void ParsePage(int NumOf, string website, out  List<string> Question, out List<string> Explain, out List<string> Answers)
        {
            WebClient webClient = new WebClient();
            string page = webClient.DownloadString(website);

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(page);
            // HtmlAgilityPack.HtmlNode
            //string
            Question = doc.DocumentNode.SelectNodes("//div[@class='prob_maindiv nobreak']")
                .Select(t => t.InnerText)
                .ToList();

            Explain = doc.DocumentNode.SelectNodes("//div[@class='nobreak solution']")
                .Select(span => span.InnerText)
                .ToList();
            Answers = doc.DocumentNode.SelectNodes("//div[@class='answer']")
                .Select(span => span.InnerText)
                .ToList();


            for (int i = 0; i < Question.Count; i++)
            {
                int div = 0;

                var fromEncodind = Encoding.GetEncoding("windows-1251");//из какой кодировки
                var bytes = fromEncodind.GetBytes(Question[i]);
                var toEncoding = Encoding.UTF8;//в какую кодировку
                Question[i] = toEncoding.GetString(bytes);
                Question[i] = Question[i].Remove(Question[i].IndexOf("Ответ: "));
                Question[i] = Question[i].Replace("&shy;", "");
                Question[i] = Question[i].Replace("&nbsp;", " ");
                Question[i] = Question[i].Replace("(1)", '\n' + "(1)");

                //richTextBox1.Text += Question[i] + '\n' + '\n' + '\n';
            }


            for (int i = 0; i < Explain.Count; i++)
            {
                var fromEncodind = Encoding.GetEncoding("windows-1251");//из какой кодировки
                var bytes = fromEncodind.GetBytes(Explain[i]);
                var toEncoding = Encoding.UTF8;//в какую кодировку
                Explain[i] = toEncoding.GetString(bytes);
                Explain[i] = Explain[i].Replace("&shy;", "");
                Explain[i] = Explain[i].Replace("&nbsp;", " ");
               // richTextBox1.Text += Explain[i] + '\n' + '\n' + '\n';

            }
            for (int i = 0; i < Answers.Count; i++)
            {
                var fromEncodind = Encoding.GetEncoding("windows-1251");//из какой кодировки
                var bytes = fromEncodind.GetBytes(Answers[i]);
                var toEncoding = Encoding.UTF8;//в какую кодировку
                Answers[i] = toEncoding.GetString(bytes);
                Answers[i] = Answers[i].Replace("&shy;", "");
                Answers[i] = Answers[i].Replace("&nbsp;", " ");
                Answers[i] = Answers[i].Replace("Ответ: ", " ");
                try
                {
                    Answers[i] = Answers[i].Remove(Answers[i].IndexOf('|')).Trim();
                }
                catch { }
               // richTextBox1.Text += Answers[i] + '\n' + '\n' + '\n';

            }
            

        }
    }
}
