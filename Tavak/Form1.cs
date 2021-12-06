using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tavak
{
  public partial class Form1 : Form
  {
    List<To> tavak = new List<To>();
    public Form1()
    {
      InitializeComponent();
    }
    private void Form1_Shown(object sender, EventArgs e)
    {
      Beolvasas();
      ListBoxbaKiiratas();
      TanarUrFeladatai();
    }

    private void TanarUrFeladatai()
    {

    }

    private void ListBoxbaKiiratas()
    {
      foreach (var t in tavak)
      {
        string atmeneti = t.Terulet == 0 ? $"{t.Min} - {t.Max}" : t.Terulet.ToString();
        listBoxOsszes.Items.Add($"{t.Nev}\t{atmeneti}\t{t.Orszag}");
      }
    }
    private void Beolvasas()
    {
      StreamReader be = new StreamReader("tavak.csv");
      be.ReadLine();
      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split(';') ;
        tavak.Add(new To(a[0],a[1],a[2]));
      }
      be.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (EllenorzesSzoveg(txtBoxTóNév.Text) && EllenorzesSzoveg(txtBoxOrszágai.Text) && EllenorzesSzam(txtBoxTerületEgy.Text))
      {
        StreamWriter ki = File.AppendText("varosok.csv");
        if (txtBoxTerület2.Text.Length==0)
        {
          ki.WriteLine($"{txtBoxTóNév.Text}\t{txtBoxTerületEgy.Text}\t{txtBoxOrszágai.Text}");
        }
        else
        {
          ki.WriteLine($"{txtBoxTóNév.Text}\t{txtBoxTerületEgy.Text} - {txtBoxTerület2.Text}\t{txtBoxOrszágai.Text}");
        }
        ki.Close();
      }
    }

    private bool EllenorzesSzam(string text)
    {
      int valami;
      if (text.Length == 0)
      {
        MessageBox.Show("Nem adtál meg adatot!");
        return false;
      }
      
      else if (!int.TryParse(text, out valami))
      {
        MessageBox.Show("A számhoz szöveget adtál meg!");
        return false;
      }
      return true;
    }

    private bool EllenorzesSzoveg(string text)
    {
      int valami;
      if (text.Length==0)
      {
        MessageBox.Show("Nem adtál meg adatot!");
        return false;
      }
      else if (int.TryParse(text,out valami))
      {
        MessageBox.Show("Számot adtál meg!");
        return false;
      }
      return true;
    }
  }
}
