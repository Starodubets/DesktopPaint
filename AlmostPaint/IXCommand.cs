using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmostPaint
{
     public interface IXCommand
    {

        void SetColor(Color col);
        void SetLineWidth(int lineWidth);
         void SetFigureType(int type);
         void SetText(string text);
         void SetTextFont(string font);
         void SetTextSize(int size);
         void SetTextColor(Color col);
         void SetTextAlign(string align);
         void ThemeChange();
         void LanguageChange();
         void SwitchTab();
         void AddNewTab();
         void CloseTab();
         void RenameTab();
         void PluginShow();
         void PluginClosed();
         string[] SetLang(string lang);
    }
}
