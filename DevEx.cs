using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.U2D;

namespace Harumaro.DevEx {
    public static bool InRange(this float t, float start, float end) => start <= t && t <= end;
    
    public static T[] OrderByName<T>(this T[] array) where T : UnityEngine.Object {
        return array.OrderBy(sprite => sprite.name).ToArray();
    }

#if UNITY_EDITOR
    public static void ClearLog()
    {
        Assembly assembly = Assembly.GetAssembly(typeof(UnityEditor.Editor));
        Type type = assembly.GetType("UnityEditor.LogEntries");
        MethodInfo method = type.GetMethod("Clear");
        method.Invoke(new object(), null);
    }
#endif
}