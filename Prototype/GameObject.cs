using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    [Serializable]
    class GameObject
    {
        List<Component> components = new List<Component>();

        static GameObject DeepClone(GameObject obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (GameObject)formatter.Deserialize(ms);
            }
        }

        public static GameObject Instantiate(GameObject original)
        {
            return DeepClone(original);
        }

        public T GetComponent<T>()
            where T : Component
        {
            foreach (var component in components)
            {
                if (component.GetType() == typeof(T))
                {
                    return component as T;
                }
            }
            return null;
        }

        public T AddComponent<T>()
            where T : Component, new()
        {
            T component = new T();
            components.Add(component);
            return component;
        }

    }
}
