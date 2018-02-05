using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pic.Plugin;
using System.IO;


namespace Interface_Nicolas
{
    class ComponentSearchXMLFile : IComponentSearchMethod
    {
        #region Constructor
        private ComponentSearchXMLFile(string filePath)
        {
            // load from xml file
            componentList lComponents = componentList.LoadFromFile(filePath);
            _listComponent = lComponents.components.OrderBy(o => o.name).ToList();
        }
        #endregion

        #region IComponentSearchMethod
        public List<component> ComponentList => _listComponent;

        public byte[] GetAssemblyBytesFromGuid(Guid guid)
        {
            component cp = _listComponent.Find(c => Guid.Parse(c.guid) == guid);
            if (null == cp)
                throw new Exception($"Failed to retrieve component with guid = {guid}");

            string filePath = Path.Combine(LibraryPath, cp.fileName.Replace('-', '_'));
            FileInfo file = new FileInfo(filePath);
            // Preliminary check
            // must exist
            if (!file.Exists)
                throw new PluginException(string.Format("File {0} does not exist. Cannot load Component.", filePath));
            // must be a dll file
            if (!file.Extension.Equals(".dll"))
                throw new PluginException(string.Format("File {0} is not a dll file. Cannot load Component.", filePath));

            return File.ReadAllBytes(filePath);
        }

        public bool GetBoolParameterDefaultValue(Guid guid, string name)
        {
            component cp = _listComponent.Find(c => Guid.Parse(c.guid) == guid);
            parameter param = cp.paramDefaults.Find(p => p.name == name);
            if (param is parameterBool paramBool)
                return paramBool.value;
            else
                return false;
        }

        public double GetDoubleParameterDefaultValue(Guid guid, string name)
        {
            component cp = _listComponent.Find(c => Guid.Parse(c.guid) == guid);
            parameter param = cp.paramDefaults.Find(p => p.name == name);
            if (param is parameterDouble paramDouble)
                return paramDouble.value;
            else
                return 0.0;
        }

        public int GetIntParameterDefaultValue(Guid guid, string name)
        {
            component cp = _listComponent.Find(c => Guid.Parse(c.guid) == guid);
            parameter param = cp.paramDefaults.Find(p => p.name == name);
            if (param is parameterInt paramInt)
                return paramInt.value;
            else
                return 0;
        }

        public int GetMultiParameterDefaultValue(Guid guid, string name)
        {
            component cp = _listComponent.Find(c => Guid.Parse(c.guid) == guid);
            parameter param = cp.paramDefaults.Find(p => p.name == name);
            if (param is parameterInt paramInt)
                return paramInt.value;
            else
                return 0;
        }
        #endregion

        #region Specific methods
        public Guid GetGuidFromName(string name)
        {
            try
            {
                component cp = _listComponent.Find(c => c.name == name);
                return Guid.Parse(cp.guid);
            }
            catch (Exception /*ex*/)
            {
                return Guid.Empty;
            }
        }
        public string GetComponentPathFromName(string name)
        {
            component cp = _listComponent.Find(c => c.name == name);
            return Path.Combine(LibraryPath, cp.fileName.Replace('-', '_'));
        }

        public static ComponentSearchXMLFile Instance
        {
            get
            {
                if (null == _instance)
                    _instance = new ComponentSearchXMLFile(_xmlFilePath);
                return _instance;
            }
        }
        public static string XmlFilePath
        {
            set
            {
                _xmlFilePath = value;
                if (!File.Exists(_xmlFilePath))
                    throw new FileNotFoundException(_xmlFilePath);
            }
        }
        public static string LibraryPath
        {
            get { return Path.GetDirectoryName(_xmlFilePath); }
        }
        #endregion

        #region Static data members
        private static ComponentSearchXMLFile _instance;
        private static string _xmlFilePath;
        #endregion

        #region Data members
        private List<component> _listComponent;
        #endregion
    }
}
