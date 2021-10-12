using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BL.Controller
{
    /// <summary>
    /// Abstruct class. created to minimize code duplication 
    /// </summary>
    public abstract class ControllerBase
    {
        protected void Save<T>(string fileName, T obj)
        {
            var formatter = new BinaryFormatter();

            using (var fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, obj);
            }
        }
   
        protected T Load<T>(string fileName)
        {
            var formatter = new BinaryFormatter();
            using (var fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                fileStream.Position = 0;
                if (fileStream.Length > 0 && formatter.Deserialize(fileStream) is T obj)
                {
                    return obj;
                }
                return default(T);
            }
        }
    }
}
