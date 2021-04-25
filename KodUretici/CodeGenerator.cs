using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodUretici
{
    public class CodeGenerator
    {
        

        internal string  GenerateFromToThemplate(string sablonTextAreaText, ListView tekrarListView, ListView degiskenListView)
        {
            int id;
            string[] ciktiListe = sablonTextAreaText.Split(new string[] { "@tr", "@etr" }, StringSplitOptions.None);
            List<string> list = new List<string>();
            string[] kopyala = list.ToArray();
            int y = 0;
            for (int i = 1; i < ciktiListe.Length - 1; i = i + 2)
            {
                list.Add(ciktiListe[i]);
                kopyala = list.ToArray();
                ciktiListe[i] = ciktiListe[i].Replace("@ktvar", tekrarListView.Items[0].Text.ToLower());
                ciktiListe[i] = ciktiListe[i].Replace("@kttip", tekrarListView.Items[0].SubItems[1].Text.ToLower());
                ciktiListe[i] = ciktiListe[i].Replace("@tvar", tekrarListView.Items[0].Text);
                ciktiListe[i] = ciktiListe[i].Replace("@ttip", tekrarListView.Items[0].SubItems[1].Text);
                for (int x = 1; x < tekrarListView.Items.Count; x++)
                {
                    if (x == tekrarListView.Items.Count - 1 && kopyala[y].Substring(kopyala[y].Length - 1) == ",")
                        kopyala[y] = kopyala[y].Substring(0, kopyala[y].Length - 1);
                    ciktiListe[i] = ciktiListe[i] + kopyala[y];
                    ciktiListe[i] = ciktiListe[i].Replace("@tvar", tekrarListView.Items[x].Text);
                    ciktiListe[i] = ciktiListe[i].Replace("@ttip", tekrarListView.Items[x].SubItems[1].Text);
                    ciktiListe[i] = ciktiListe[i].Replace("@ktvar", tekrarListView.Items[x].Text.ToLower());
                    ciktiListe[i] = ciktiListe[i].Replace("@kttip", tekrarListView.Items[x].SubItems[1].Text.ToLower());
                }
                y++;
            }

            string cikti = "";
            for (int i = 0; i < ciktiListe.Length; i++)
                cikti += ciktiListe[i];

            foreach (ListViewItem item in degiskenListView.Items)
            {
                id = item.Index + 1;
                cikti = cikti.Replace("@var" + id.ToString(), item.SubItems[1].Text);
                cikti = cikti.Replace("@tip" + id.ToString(), item.SubItems[2].Text);
                cikti = cikti.Replace("@kvar" + id.ToString(), item.SubItems[1].Text.ToLower());
                cikti = cikti.Replace("@ktip" + id.ToString(), item.SubItems[2].Text.ToLower());
            }

            return cikti;
        }
    }
}
