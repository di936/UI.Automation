namespace UIA.Tests.MediaPlayerClassic
{
    using System.Diagnostics;
    using System.Linq;
    using NUnit.Framework;
    using UIA.Framework.Application;
    using UIA.Framework.Elements;
    using UIA.Framework.Helpers;

    [TestFixture]
    public class BaseUi
    {
        private string _path = @"C:\Program Files\MPC-BE x64\mpc-be64.exe";
        private Process _process;
        private Application _app;

        [OneTimeSetUp]
        public void SetUp()
        {
            _process = new Process()
            {
                StartInfo = new ProcessStartInfo(_path)
            };

            _process.Start();
            Wait.Milliseconds(500);
            _app = new Application(_process);
        }

        [Test]
        public void _01_Title()
        {
            var expected = @"MPC-BE x64";
            var title = _app.Find<TitleBar>().Name;
            Assert.That(title.Contains(expected));
        }

        [Test]
        public void _02_MenuBarItems()
        {
            var expected = new string[] { "Файл", "Вид", "Воспроизведение", "Навигация", "Закладки", "Помощь" };
            var items = _app.FindAll<MenuItem>().Select(item => item.Name).ToArray();
            foreach(var item in expected)
            {
                Assert.Contains(item, items);
            }
        }

        [Test]
        public void _03_СurrentWindow()
        {
            _app.FindByName<MenuItem>("Вид").Expand();
            _app.FindByName<MenuItem>("Настройки...").Invoke();
            _app.SetCurrentWindow("Настройки");
            Assert.That(_app.CurrentWindow.Name, Is.EqualTo("Настройки"));
            _app.CurrentWindow.Close();
            _app.SetDefaultWindow();
        }

        [Test]
        public void _04_Windows()
        {
            _app.FindByName<MenuItem>("Вид").Expand();
            _app.FindByName<MenuItem>("Настройки...").Invoke();
            var opened = _app.FindAll<Window>();
            _app.SetCurrentWindow("Настройки");
        }

        [Test]
        public void _05_SecondInstanceAndFirstFocus()
        {
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo(_path)
            };

            process.Start();
            Wait.Milliseconds(100);
            var app = new Application(_process);
            _app.CurrentWindow.SetFocus();
            Wait.Seconds(1);
            process.Kill();
        }

        //[Test]
        //public void _06_StringPath()
        //{
        //    _app.CurrentWindow.Close();
        //    _app.SetDefaultWindow();
        //    //var x = _app.FindById<MenuBar>("MenuBar");
        //    //x.InvokeByPath(new string[] { "Вид", "Настройки..."});
        //    _app.FindByName<MenuItem>("Файл").InvokeByPath(new string[] { "Последние файлы", "Очистить список" });

        //    Wait.Milliseconds(5000);
        //}

        [OneTimeTearDown]
        public void TearDown()
        {
            _process.Kill();
        }
    }
}
