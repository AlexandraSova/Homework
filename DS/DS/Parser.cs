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

      //  public static List<Model> ParsePage(string website)
       // {

       // }
    }
}
