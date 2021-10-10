using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace BL.Controller
{
    public abstract class ControllerBase
    {
        protected void Save<T>(string fileName, T obj )
        {
            var formatter = new BinaryFormatter();

            using (var fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, obj );
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
