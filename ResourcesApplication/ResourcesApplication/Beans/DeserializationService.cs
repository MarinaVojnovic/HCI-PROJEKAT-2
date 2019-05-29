using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ResourcesApplication.Beans
{
    class DeserializationService
    {
        public static readonly string RESOURCES_DATA = "resources.txt";
        public static readonly string TYPES_DATA = "types.txt";
        public static readonly string TAGS_DATA = "tags.txt";
        public static void deserializeResources()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            if (File.Exists(RESOURCES_DATA))
            {
                try
                {
                    stream = File.Open(RESOURCES_DATA, FileMode.Open);
                    var data = (ObservableCollection<Resource>)formatter.Deserialize(stream);
                    Database.getInstance().Resources = data;

                }
                catch
                {
                    throw new FileNotFoundException();
                }
                finally
                {
                    if (stream != null)
                        stream.Dispose();
                }

            }
        }

        public static void deserializeTypes()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            if (File.Exists(TYPES_DATA))
            {
                try
                {
                    stream = File.Open(TYPES_DATA, FileMode.Open);
                    Database.getInstance().Types = (ObservableCollection<ResourceType>)formatter.Deserialize(stream);
                }
                catch
                {
                    throw new FileNotFoundException();
                }
                finally
                {
                    if (stream != null)
                        stream.Dispose();
                }

            }
        }

        public static void deserializeTags()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            if (File.Exists(TAGS_DATA))
            {
                try
                {
                    stream = File.Open(TAGS_DATA, FileMode.Open);
                    Database.getInstance().Tags = (ObservableCollection<ResourceTag>)formatter.Deserialize(stream);
                }
                catch
                {
                    throw new FileNotFoundException();
                }
                finally
                {
                    if (stream != null)
                        stream.Dispose();
                }

            }
        }
    }
}
