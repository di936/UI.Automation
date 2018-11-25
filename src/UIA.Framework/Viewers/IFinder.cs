using System.Collections.Generic;

namespace UIA.Framework.Viewers
{
    public interface IFinder
    {
        T Find<T>();
        T FindById<T>(string id);
        T FindByName<T>(string name);
        T FindByWindowHandle<T>(int handle);
        List<T> FindAll<T>();
    }
}
