using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmostPaint
{
    public class Utilites
    {
        public static Color GetColor()
        {
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                return dlgColor.Color;
            }
            return Color.Black;
        }


        //public static void SaveAction(/*string str*/)
        //{
        //    SaveFileDialog dlgSave = new SaveFileDialog();
        //    string[] ext = { "JSON (*.json)|*.json", "XML (*.xml) | *.xml", "YAML (*.yaml)|*.yaml" };
        //    dlgSave.Filter = String.Join("|", ext);
        //    if (dlgSave.ShowDialog() == DialogResult.OK)
        //    {

        //    }
        //    MessageBox.Show("File saved");
        //}
        //public static string LoadAction()
        //{
        //    OpenFileDialog dlgOpen = new OpenFileDialog();
        //    string ext = "SO (*.json; *.xml; *.yaml;)| *.json; *.xml; *.yaml;";
        //    dlgOpen.Filter = ext;
        //    string res = "";
        //    if (dlgOpen.ShowDialog() == DialogResult.OK)
        //    {

        //    }
        //    MessageBox.Show("File load");
        //    return res;
        //}

        public static void SaveAction(string str)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            string[] ext = { "JSON (*.json)|*.json", "XML (*.xml) | *.xml", "YAML (*.yaml)|*.yaml", "BIN (*.bin)|*.bin", "CSV (*.csv)|*.csv" };
            dlgSave.Filter = String.Join("|", ext);
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                //SOFactory.GetInstance(dlgSave.FileName).Save(cmd.df.GetListOfFigures());
                using (StreamWriter sw = new StreamWriter(dlgSave.FileName))
                {
                    sw.Write(str);
                }
            }
        }
        public static string LoadAction()
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            string ext = "SO (*.json; *.xml; *.yaml; *.bin; *.csv)| *.json; *.xml; *.yaml; *.bin; *.csv";
            dlgOpen.Filter = ext;
            string res = "";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                //cmd.df.SetListOfFigures(SOFactory.GetInstance(dlgOpen.FileName).Open());
                using (StreamReader sr = new StreamReader(dlgOpen.FileName))
                {
                    res = sr.ReadToEnd();
                }
            }
            return res;
        }
    }
}
