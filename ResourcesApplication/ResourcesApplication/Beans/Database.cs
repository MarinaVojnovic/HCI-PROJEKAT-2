using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ResourcesApplication.Beans
{
    [Serializable]
    class Database : INotifyPropertyChanged
    {

        private static Database instance = null;

        private ObservableCollection<Resource> resources;
        public ObservableCollection<Resource> Resources
        {
            get { return Resources; }
            set
            {
                if (value != resources)
                {
                    resources = value;
                    OnPropertyChanged("Resources");
                }
            }
        }

        private ObservableCollection<ResourceType> types;
        public ObservableCollection<ResourceType> Types
        {
            get { return types; }
            set
            {
                if (value != types)
                {
                    types = value;
                    OnPropertyChanged("Types");
                }
            }
        }

        private ObservableCollection<ResourceTag> tags;
        public static DeserializationService DeserialiationService { get; set; }

        public ObservableCollection<ResourceTag> Tags
        {
            get { return tags; }
            set
            {
                if (value != tags)
                {
                    tags = value;
                    OnPropertyChanged("Tags");
                }
            }
        }

        public static SerializationService SerializationService{ get; set; }

        private Database()
        {
            resources = new ObservableCollection<Resource>();
            types = new ObservableCollection<ResourceType>();
            tags = new ObservableCollection<ResourceTag>();
        }

        public static Database getInstance()
        {
            if (instance == null)
            {
                instance = new Database();
            }
            return instance;
        }

        public static void SaveResources()
        {
            SerializationService.serializeResource(getInstance().resources);
        }

        public static void SaveTypes()
        {
            SerializationService.serializeTypes(getInstance().types);
        }

        public static void SaveTags()
        {
            SerializationService.serializeTags(getInstance().tags);
        }

        public static void AddResource(Resource resource)
        {
            getInstance().resources.Add(resource);
            SaveResources();
        }

        public static void AddType(ResourceType type)
        {
            getInstance().types.Add(type);
            SaveTypes();
        }

        public static void AddTag(ResourceTag tag)
        {
            getInstance().tags.Add(tag);
            SaveTags();
        }

        public static Resource GetResource(string id)
        {
            for (int i = 0; i < getInstance().Resources.Count; i++)
            {
                if (getInstance().Resources[i].Id.Equals(id))
                {
                    return getInstance().Resources[i];
                }
            }
            return null;
        }

        public static ResourceType GetType(string id)
        {
            for (int i = 0; i < getInstance().Types.Count; i++)
            {
                if (getInstance().Types[i].Id.Equals(id))
                {
                    return getInstance().Types[i];
                }
            }
            return null;
        }

        public static ResourceTag GetTag(string id)
        {
            for (int i = 0; i < getInstance().Tags.Count; i++)
            {
                if (getInstance().Tags[i].Id.Equals(id))
                {
                    return getInstance().Tags[i];
                }
            }
            return null;
        }

        public static void UpdateResource(string oldId, Resource resource)
        {
            for (int i = 0; i < getInstance().Resources.Count; i++)
            {
                if (oldId.Equals(getInstance().Resources[i].Id))
                {
                    getInstance().Resources[i] = resource;
                    SaveResources();
                    break;
                }
            }
        }

        public static void UpdateType(string oldId, ResourceType type)
        {
            for (int i = 0; i < getInstance().Types.Count; i++)
            {
                if (oldId.Equals(getInstance().Types[i].Id))
                {
                    getInstance().Types[i] = type;
                    SaveTypes();
                    break;
                }
            }
        }

        public static void UpdateTag(string oldId, ResourceTag tag)
        {
            for (int i = 0; i < getInstance().Tags.Count; i++)
            {
                if (oldId.Equals(getInstance().Tags[i].Id))
                {
                    Console.WriteLine("Uslo u updatee");
                    getInstance().Tags[i] = tag;
                    SaveTags();
                    break;
                }
            }
        }

        public static void DeleteResource(Resource resource)
        {
            for (int i = 0; i < getInstance().Resources.Count; i++)
            {
                if (resource.Id.Equals(getInstance().Resources[i].Id))
                {
                    getInstance().Resources.RemoveAt(i);
                    SaveResources();
                    break;
                }
            }
        }

        public static void DeleteType(ResourceType type)
        {
            for (int i = 0; i < getInstance().Types.Count; i++)
            {
                if (type.Id.Equals(getInstance().Types[i].Id))
                {
                    getInstance().Types.RemoveAt(i);
                    SaveTypes();
                    break;
                }
            }
        }

        public static void DeleteTag(ResourceTag tag)
        {
            for (int i = 0; i < getInstance().Tags.Count; i++)
            {
                if (tag.Id.Equals(getInstance().Tags[i].Id))
                {
                    getInstance().Tags.RemoveAt(i);
                    SaveTags();
                    break;
                }
            }
        }


        
        public static void loadData()
        {
            DeserializationService.deserializeTags();
            DeserializationService.deserializeTypes();
            DeserializationService.deserializeResources();
        }
        

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
