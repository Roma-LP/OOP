using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace LP_LAB_12
{
    static class Reflector
    {
        public struct Information
        {
            public bool PublicConstrtExist;
            public string Name;
            public string AssemblyName;
            public IEnumerable<FieldInfo> namePublicFields;
            public IEnumerable<PropertyInfo> namePublicProperties;
            public IEnumerable<FieldInfo> namePrivateFields;
            public IEnumerable<PropertyInfo> namePrivateProperties;
            public IEnumerable<MethodInfo> namePublicFunc;
            public IEnumerable<MethodInfo> namePrivateFunc;
            public string NameSpace;
            public Type Parent;
        }
        public static void Analyse(object TakeInfo, string Way)
        {
            Information info = new Information();
            Type type = TakeInfo.GetType();

            info.PublicConstrtExist = type.GetConstructors().Any();
            info.Name = type.Name;
            info.AssemblyName = type.AssemblyQualifiedName;
            info.namePublicFields = type.GetFields().AsEnumerable();
            info.namePublicProperties = type.GetProperties().AsEnumerable();  // Instance: получает только методы экземпляра
            info.namePrivateFields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance).AsEnumerable();
            info.namePrivateProperties = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance).AsEnumerable();
            info.namePublicFunc = type.GetMethods().AsEnumerable();
            info.namePrivateFunc = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance).AsEnumerable();
            info.NameSpace = type.Namespace;
            info.Parent = type.BaseType;

            using (StreamWriter sw = File.CreateText(Way))
            {
                if (!File.Exists(Way))
                    throw new Exception("Нет файла "+Path.GetExtension(Way)+"\nПо пути "+Path.GetDirectoryName(Way));
                sw.Write(JsonConvert.SerializeObject(info, Formatting.Indented));
            }
        }

        public static object Create<T>(T cl, object[] param)
        {
            Type type = cl.GetType();
           // var cons = type.GetTypeInfo().GetConstructors().AsEnumerable();
            var cons = type.GetConstructors().AsEnumerable();
            foreach (ConstructorInfo ke in cons)
            {
    
                var ret = ke.Invoke(BindingFlags.CreateInstance, null, param, null);

                if (ret != null)
                    return ret;
            }
            return -1;
        }

        public static void Invoke<T>(T obj, string method, object[] param)
        {
            Type type = obj.GetType();
            var met = type.GetMethod(method);
            if (met == null)
                throw new Exception("Не найденн метод "+ method);
            type.InvokeMember(method, BindingFlags.InvokeMethod, Type.DefaultBinder, obj, param);

        }
        public static void Invoke<T>(T obj, string method, object[] param, BindingFlags flags) where T : class
        {
            Type type = obj.GetType();
            var met = type.GetMethod(method, flags);
            if (met == null)
                throw new Exception("Не найденн метод " + method);
            type.InvokeMember(method, BindingFlags.InvokeMethod, Type.DefaultBinder, obj, param);

        }
        public static void Invoke<T>(T obj, string method, object[] param, object[] paramConst) where T : class
        {
            T perem = (T)Create<T>(obj, paramConst);
            Reflector.Invoke(perem, method, param);
        }
        public static void Invoke<T>(T obj, string method, object[] param, object[] paramConst, BindingFlags flags) where T : class
        {
            T perem = (T)Create<T>(obj, paramConst);
            Reflector.Invoke(perem, method, param, flags);
        }
    }
}
