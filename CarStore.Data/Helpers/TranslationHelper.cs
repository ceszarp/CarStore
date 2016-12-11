using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;
using CarStore.Data.Settings;

namespace CarStore.Data.Helpers
{
    public static class TranslationHelper
    {
        private static Dictionary<string,Dictionary<string,string>> Translations =
            new Dictionary<string,Dictionary<string,string>>();

        static TranslationHelper()
        {
            Assembly assembly = typeof(TranslationHelper).Assembly;
            foreach (string language in Configuration.Laguages)
            {
                string path = $"CarStore.Data.Models.Translations.{language}.json";
                string translationText = null;
                try
                {
                    using (Stream stream = assembly.GetManifestResourceStream(path))
                    {
                        using (StreamReader st = new StreamReader(stream))
                        {
                            translationText = st.ReadToEnd();
                        }
                    }

                    Dictionary<string, string> translation = JsonConvert.DeserializeObject<Dictionary<string, string>>(translationText);
                    Translations.Add(language, translation);
                }
                catch (Exception)
                {
                }
            }             
        }

        public static string GetTranslation(string key, string language)
        {
            string word = null;
            try
            {
                word = Translations[language][key];
            }
            catch (Exception)
            {
            }
            return word;
        }

    }
}
