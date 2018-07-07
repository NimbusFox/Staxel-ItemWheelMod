using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassicItemWheelMod {
    public static class Extensions {
        internal static T GetPrivatePropertyValue<T>(this object parentObject, string field) {
            return (T)parentObject.GetType().GetProperty(field, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?
                .GetValue(parentObject);
        }

        internal static void SetPrivatePropertyValue(this object parentObject, string field, object value) {
            parentObject.GetType().GetProperty(field, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?.SetValue(parentObject, value);
        }

        internal static T GetPrivateFieldValue<T>(this object parentObject, string field) {
            return (T)parentObject.GetType().GetField(field, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?
                .GetValue(parentObject);
        }

        internal static void SetPrivateFieldValue(this object parentObject, string field, object value) {
            parentObject.GetType().GetField(field, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?.SetValue(parentObject, value);
        }

        internal static T GetPrivatePropertyValue<T>(this object parentObject, string field, Type type) {
            return (T)type.GetProperty(field, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?
                .GetValue(parentObject);
        }

        internal static void SetPrivatePropertyValue(this object parentObject, string field, object value, Type type) {
            type.GetProperty(field, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?.SetValue(parentObject, value);
        }

        internal static T GetPrivateFieldValue<T>(this object parentObject, string field, Type type) {
            return (T)type.GetField(field, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?
                .GetValue(parentObject);
        }

        internal static void SetPrivateFieldValue(this object parentObject, string field, object value, Type type) {
            type.GetField(field, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?.SetValue(parentObject, value);
        }
    }
}
