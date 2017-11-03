using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems;
using System.Threading;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.Factory;
using TestStack.White.UIItems.WindowStripControls;
using TestStack.White.UIItems.MenuItems;

namespace WhiteTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string path = @"C:\Users\Ren\Documents\Visual Studio 2017\Projects\AlmostPaint\AlmostPaint\bin\Debug\AlmostPaint.exe";

        [DataTestMethod]
        [DataRow("File")]
        [DataRow("Edit figure")]
        [DataRow("Edit text")]
        [DataRow("Edit tab")]
        [DataRow("Switch tab")]
        [DataRow("Plugins")]
        [DataRow("Cloud")]
        [DataRow("Network")]
        [DataRow("Settings")]
        [DataRow("Help")]
        public void IsElementExists1(string id)
        {
            Application application = Application.Launch(path);
            Window window = application.GetWindow("Form1", InitializeOption.NoCache);
            MenuBar menuBar = window.MenuBar;
            Menu level2Menu = menuBar.MenuItem(id);
            level2Menu = menuBar.MenuItemBy(SearchCriteria.ByText(id)); //can use any other search criteria as well.
            level2Menu.Click();
            application.Kill();
        }

        //[DataTestMethod]
        //[DataRow("button1", "1")]
        //[DataRow("button2", "2")]
        //[DataRow("button3", "3")]
        //[DataRow("button4", "4")]
        //[DataRow("button5", "5")]
        //[DataRow("button6", "6")]
        //[DataRow("button7", "7")]
        //[DataRow("button8", "8")]
        //[DataRow("button9", "9")]
        //[DataRow("button10", "0")]
        //public void SimpleCheck(string a, string exp)
        //{

        //    Application application = Application.Launch(path);
        //    Window window = application.GetWindow("Form1", InitializeOption.NoCache);
        //    Button button1 = window.Get<Button>(a);
        //    button1.Click();
        //    SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("result");
        //    TextBox textBox = (TextBox)window.Get(searchCriteria);
        //    string res = textBox.Text;
        //    Assert.AreEqual(exp, res);
        //    application.Kill();
        //}


        //[DataTestMethod]
        //[DataRow("button1", "button2", "button2", "122")]
        //[DataRow("button9", "button2", "button2", "922")]
        //[DataRow("button5", "button9", "button2", "592")]
        //[DataRow("button9", "button5", "button3", "953")]
        //[DataRow("button5", "button5", "button2", "552")]
        //public void ComplexCheck(string a, string b, string c, string exp)
        //{
        //    Application application = Application.Launch(path);
        //    Window window = application.GetWindow("Form1", InitializeOption.NoCache);
        //    Button button4 = window.Get<Button>(a);
        //    button4.Click();
        //    Button button5 = window.Get<Button>(b);
        //    button5.Click();
        //    Button button6 = window.Get<Button>(c);
        //    button6.Click();
        //    SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("result");
        //    TextBox textBox = (TextBox)window.Get(searchCriteria);
        //    string res = textBox.Text;
        //    Assert.AreEqual(exp, res);
        //    application.Kill();

        //}
        ////RealJob
        //[DataTestMethod]
        //[DataRow("button1", "buttonplus", "button2", "3")]
        //[DataRow("button9", "buttonminus", "button2", "7")]
        //[DataRow("button5", "buttonmult", "button2", "10")]
        //[DataRow("button9", "buttondel", "button3", "3")]
        //[DataRow("button5", "buttonplus", "button2", "7")]
        //public void RealJob(string a, string b, string c, string exp)
        //{
        //    Application application = Application.Launch(path);
        //    Window window = application.GetWindow("Form1", InitializeOption.NoCache);
        //    //Assert.IsNotNull(window);
        //    // Assert.IsTrue(window.DisplayState == DisplayState.Restored);
        //    Button button1 = window.Get<Button>(a);
        //    button1.Click();
        //    Button button2 = window.Get<Button>(b);
        //    button2.Click();
        //    Button button3 = window.Get<Button>(c);
        //    button3.Click();
        //    Button button4 = window.Get<Button>("buttoncalc");
        //    button4.Click();
        //    SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("result");
        //    TextBox textBox = (TextBox)window.Get(searchCriteria);
        //    string res = textBox.Text;
        //    Assert.AreEqual(exp, res);
        //    application.Kill();




        /*var calc = Application.Launch("D:/Laba/Calc/Calc/bin/Debug/Calc.exe");
        var winMain = calc.GetWindow("Calc15");
        var textArea = winMain.Get<TextBox>(SearchCriteria.ByAutomationId("firstnumb"));
        textArea.Text = "Hello, world!";


        /*var applicationDirectory = TestContext.TestDeploymentDir;
        using (var application = Application.Launch("D:/Laba/Calc/Calc15/bin/Debug/Calc15.exe"))
        {
            var calculator = application.GetWindow("Calculator", InitializeOption.NoCache);
            var b7 = calculator.Get<Button>(SearchCriteria.ByText("7"));
            b7.Click();
            // do something with the application

            application.Close();
        }
        /* Application application = Application.Launch("D:/Laba/Calc/Calc/bin/Debug/Calc.exe");
         window = (Core.UIItems.WindowItems.WPFWindow)application.GetWindow("Window1", Core.Factory.InitializeOption.NoCache);

         Assert.IsNotNull(window);
         /*Assert.IsNotNull(application);
         var applicationDirectory = TestContext.TestDeploymentDir;
         var applicationPath = Path.Combine(applicationPath, "D:\Laba\Calc\Calc\bin\Debugfoo.exe");
         Application application = Application.Launch(applicationPath);
         Window window = application.GetWindow("bar", InitializeOption.NoCache);
         D:\Laba\Calc\Calc\bin\Debug
    }*/
    }
}
