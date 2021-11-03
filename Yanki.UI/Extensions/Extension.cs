using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yanki.UI.Extensions
{
    public static class Extension
    {
        public static void SetObject(this ISession session,string key,object value)
        {
            string jsonObject = JsonConvert.SerializeObject(value);
            session.SetString(key, jsonObject);
        }
        public static T GetObject<T>(this ISession session,string key)
            where T : class
        {
            string jsonObejct = session.GetString(key);
            if (!string.IsNullOrEmpty(jsonObejct))
                return JsonConvert.DeserializeObject<T>(jsonObejct);

            return null;
            
        }
    }
}
