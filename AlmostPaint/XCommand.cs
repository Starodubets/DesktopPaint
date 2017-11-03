using AlmostPaint.Controls;
using AlmostPaint.Windows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AlmostPaint.Figure;

namespace AlmostPaint
{
    public class XCommand : IXCommand
    {
        public XData xData = new XData();
        public XText xText = new XText();
        public PDraw pDraw = null;

        public void SetColor(Color color)
        {
            if (pDraw.currentFigure == null)
                xData.color = color;
            else
                pDraw.currentFigure.Color = color;
            //MessageBox.Show("Color Change");
        }

        public void SetLineWidth(int lineWidth)
        {
            if (pDraw.currentFigure == null)
                xData.lineWidth = lineWidth;
            else
                pDraw.currentFigure.LineWidth = lineWidth;
            //MessageBox.Show("Width Change");
        }

        public void SetFigureType(int type)
        {
            switch (type)
            {
                case 1:
                    xData.type = 1;
                    break;
                case 2:
                    xData.type = 2;
                    break;
                case 3:
                    xData.type = 3;
                    break;
                case 4:
                    xData.type = 4;
                    break;
            }
            //MessageBox.Show("Type Change");
        }

        public void SetText(string text)
        {
            xText.text = text;
        }
        public void SetTextFont(string font)
        {
            xText.font = font;
        }
        public void SetTextSize(int size)
        {
            xText.sizetext = size;
        }
        public void SetTextColor(Color col)
        {
            xText.textcolor = col;
        }
        public void SetTextAlign(string align)
        {
            switch (align)
            {
                case "Left":
                    xText.textpos = "left";
                    break;
                case "Right":
                    xText.textpos = "right";
                    break;
                case "Up":
                    xText.textpos = "up";
                    break;
                case "Down":
                    xText.textpos = "down";
                    break;
                case "Center":
                    xText.textpos = "center";
                    break;
            }
        }
        public void ThemeChange()
        {
            MessageBox.Show("Theme changed");
        }
        public void LanguageChange()
        {
            MessageBox.Show("Language changed");
        }
        public void SwitchTab()
        {
            MessageBox.Show("Tab switched");
        }
        public void AddNewTab()
        {
            MessageBox.Show("Tab added");
        }
        public void CloseTab()
        {
            MessageBox.Show("Tab closed");
        }
        public void RenameTab()
        {

            RenameForm renameform = new RenameForm();
            renameform.Show();
            MessageBox.Show("Window renamed");
        }
        public void PluginShow()
        {
            MessageBox.Show("Plugin showed");
        }
        public void PluginClosed()
        {
            MessageBox.Show("Plugin closed");
        }

        public void SetMemento(List<MFigure> list)
        {
            pDraw.SetMemento(list);
            pDraw.Invalidate();
        }

        public List<MFigure> GetMemento()
        {
            return pDraw.GetMemento();
        }

        /// <summary>
        /// Функция возвращает массив строк, которые нужно задать кнопкам в элементе, при вызове передаётся название элемента
        /// Структура документа, Element -- text -- EndElement
        /// </summary>
        /// <param name="Element"></param>
        /// <returns></returns>
        public string[] SetLang(string Element)
        {
            string defaulLang;
            if (File.Exists("defaultLang.txt"))
            {
                defaulLang = File.ReadAllText("defaultLang.txt");
            }
            else
            {
                defaulLang = "English";
            }
            string[] btnTexts = new string[50];  // файлы одинаковые, так что вот тут нужно пересчитать сколько нужно элементов
            switch (defaulLang)  // проверки на отсутвие файлов по идее нужны бы
            {
                case "English":
                    string[] someText = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\Lang\Eng.txt");
                    btnTexts = someText;
                    break;
                case "Russian":
                    btnTexts = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\Lang\Rus.txt");
                    break;
                case "Spanish":
                    btnTexts = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\Lang\Sp.txt");
                    break;
                case "French":
                    btnTexts = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\Lang\Fr.txt");
                    break;
            }

            //я вот прям хз почему, но файндиндекс не работает, так что написал вот так
            int startElement = 0;
            for (int i = 0; i < btnTexts.Length; i++)
            {
                if (Element == btnTexts[i])
                {
                    startElement = i;
                    break;
                }
            }
            int endElement = 0;
            for (int i = 0; i < btnTexts.Length; i++)
            {
                if ("End" + Element == btnTexts[i])
                {
                    endElement = i;
                    break;
                }
            }
            string[] text = new string[endElement - startElement];
            for (int i = startElement , k = 0; i < endElement; i++ , k++)
            {
                text[k] = btnTexts[i];
            }
            return text;
        }
        
    }
}
