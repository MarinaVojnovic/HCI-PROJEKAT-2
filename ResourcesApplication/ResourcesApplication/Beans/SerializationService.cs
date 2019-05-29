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
    class SerializationService
    {
        public static readonly string RESOURCES_DATA = "resources.txt";
        public static readonly string TYPES_DATA = "types.txt";
        public static readonly string TAGS_DATA = "tags.txt";

        public static void serializeResource(ObservableCollection<Resource> resource)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            try
            {
                stream = File.Open(RESOURCES_DATA, FileMode.OpenOrCreate);
                formatter.Serialize(stream, resource);
            }
            catch
            {
                throw new DirectoryNotFoundException();
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
        }

        public static void serializeTypes(ObservableCollection<ResourceType> types)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            try
            {
                stream = File.Open(TYPES_DATA, FileMode.OpenOrCreate);
                formatter.Serialize(stream, types);
            }
            catch
            {
                throw new DirectoryNotFoundException();
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
        }

        public static void serializeTags(ObservableCollection<ResourceTag> tag)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            try
            {
                stream = File.Open(TAGS_DATA, FileMode.OpenOrCreate);
                formatter.Serialize(stream, tag);
            }
            catch
            {
                throw new DirectoryNotFoundException();
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
        }
    }
}
