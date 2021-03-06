﻿using System.Collections.Generic;

namespace DynamicTranslator.LanguageManagement
{
    public static class LanguageMapping
    {
        #region All/Google

        public static IDictionary<string, string> All => new Dictionary<string, string>
        {
            {"Afrikaans", "af"},
            {"Albanian", "sq"},
            {"Arabic", "ar"},
            {"Armenian", "hy"},
            {"Azerbaijani", "az"},
            {"Basque", "eu"},
            {"Belarusian", "be"},
            {"Bengali", "bn"},
            {"Bulgarian", "bg"},
            {"Catalan", "ca"},
            {"Chinese", "zh-CN"},
            {"Croatian", "hr"},
            {"Czech", "cs"},
            {"Danish", "da"},
            {"Dutch", "nl"},
            {"English", "en"},
            {"Esperanto", "eo"},
            {"Estonian", "et"},
            {"Filipino", "tl"},
            {"Finnish", "fi"},
            {"French", "fr"},
            {"Galician", "gl"},
            {"German", "de"},
            {"Georgian", "ka"},
            {"Greek", "el"},
            {"Haitian Creole", "ht"},
            {"Hebrew", "iw"},
            {"Hindi", "hi"},
            {"Hungarian", "hu"},
            {"Icelandic", "is"},
            {"Indonesian", "id"},
            {"Irish", "ga"},
            {"Italian", "it"},
            {"Japanese", "ja"},
            {"Korean", "ko"},
            {"Lao", "lo"},
            {"Latin", "la"},
            {"Latvian", "lv"},
            {"Lithuanian", "lt"},
            {"Macedonian", "mk"},
            {"Malay", "ms"},
            {"Maltese", "mt"},
            {"Norwegian", "no"},
            {"Persian", "fa"},
            {"Polish", "pl"},
            {"Portuguese", "pt"},
            {"Romanian", "ro"},
            {"Russian", "ru"},
            {"Serbian", "sr"},
            {"Slovak", "sk"},
            {"Slovenian", "sl"},
            {"Spanish", "es"},
            {"Swahili", "sw"},
            {"Swedish", "sv"},
            {"Tamil", "ta"},
            {"Telugu", "te"},
            {"Thai", "th"},
            {"Turkish", "tr"},
            {"Ukrainian", "uk"},
            {"Urdu", "ur"},
            {"Vietnamese", "vi"},
            {"Welsh", "cy"},
            {"Yiddish", "yi"}
        };

        #endregion

        #region Bing

        public static IDictionary<string, string> Bing => new Dictionary<string, string>
        {
            {"Afrikaans", "af"},
            {"Arabic", "ar"},
            {"Bosnian(Latin)", "bs-Latn"},
            {"Bulgarian", "bg"},
            {"Catalan", "ca"},
            {"Chinese Simplified", "zh-CHS"},
            {"Chinese Traditional", "zh-CHT "},
            {"Croatian", "hr"},
            {"Czech", "cs"},
            {"Danish", "da"},
            {"Dutch", "nl"},
            {"English", "en"},
            {"Estonian", "et"},
            {"Finnish", "fi"},
            {"French", "fr"},
            {"German", "de"},
            {"Greek", "el"},
            {"Haitian Creole", "ht"},
            {"Hebrew", "he"},
            {"Hindi", "hi"},
            {"Hmong Daw", "mww "},
            {"Hungarian", "hu"},
            {"Indonesian", "id"},
            {"Italian", "it"},
            {"Japanese", "ja"},
            {"Kiswahili", "sw"},
            {"Klingon", "tlh "},
            {"Klingon (pIqaD)", "tlh-Qaak "},
            {"Korean", "ko"},
            {"Latvian", "lv"},
            {"Lithuanian", "lt"},
            {"Malay", "ms"},
            {"Maltese", "mt"},
            {"Norwegian", "no"},
            {"Persian", "fa"},
            {"Polish", "pl"},
            {"Portuguese", "pt"},
            {"Querétaro Otomi", "otq "},
            {"Romanian", "ro"},
            {"Russian", "ru"},
            {"Serbian (Cyrillic)", "sr-Cyrl "},
            {"Serbian (Latin)", "sr-Latn "},
            {"Slovak", "sk"},
            {"Slovenian", "sl"},
            {"Spanish", "es"},
            {"Swedish", "sv"},
            {"Thai", "th"},
            {"Turkish", "tr"},
            {"Ukrainian", "uk"},
            {"Urdu", "ur"},
            {"Vietnamese", "vi"},
            {"Welsh", "cy"},
            {"Yucatec Maya", "yua"}
        };

        #endregion

        #region SesliSozluk 

        public static IDictionary<string, string> SesliSozluk => new Dictionary<string, string>
        {
            {"English", "en"},
            {"Turkish", "tr"},
            {"German", "de"},
            {"Arabic", "ar"},
            {"Danish", "da"},
            {"Persian", "fa"},
            {"Finnish", "fi"},
            {"French", "fr"},
            {"Dutch", "nl"},
            {"Spanish", "es"},
            {"Swedish", "sv"},
            {"Italian", "it"},
            {"Greek", "el"},
            {"Polish", "pl"},
            {"Russian", "ru"},
            {"Portuguese", "pt"}
        };

        #endregion

        #region Tureng

        public static IDictionary<string, string> Tureng => new Dictionary<string, string>
        {
            {"English", "en"},
            {"Turkish", "tr"}
        };

        #endregion

        #region Yandex

        public static IDictionary<string, string> Yandex => new Dictionary<string, string>
        {
            {"Albanian", "sq"},
            {"English", "en"},
            {"Arabic", "ar"},
            {"Armenian", "hy"},
            {"Azerbaijan", "az"},
            {"Afrikaans", "af"},
            {"Basque", "eu"},
            {"Belarusian", "be"},
            {"Bulgarian", "bg"},
            {"Bosnian", "bs"},
            {"Welsh", "cy"},
            {"Vietnamese", "vi"},
            {"Hungarian", "hu"},
            {"Haitian (Creole)", "ht"},
            {"Galician", "gl"},
            {"Dutch", "nl"},
            {"Greek", "el"},
            {"Georgian", "ka"},
            {"Danish", "da"},
            {"Yiddish", "he"},
            {"Indonesian", "id"},
            {"Irish", "ga"},
            {"Italian", "it"},
            {"Icelandic", "is"},
            {"Spanish", "es"},
            {"Kazakh", "kk"},
            {"Catalan", "ca"},
            {"Kyrgyz", "ky"},
            {"Chinese", "zh"},
            {"Korean", "ko"},
            {"Latin", "la"},
            {"Latvian", "lv"},
            {"Lithuanian", "lt"},
            {"Malagasy", "mg"},
            {"Malay", "ms"},
            {"Maltese", "mt"},
            {"Macedonian", "mk"},
            {"Mongolian", "mn"},
            {"German", "de"},
            {"Norwegian", "no"},
            {"Persian", "fa"},
            {"Polish", "pl"},
            {"Portuguese", "pt"},
            {"Romanian", "ro"},
            {"Russian", "ru"},
            {"Serbian", "sr"},
            {"Slovakian", "sk"},
            {"Slovenian", "sl"},
            {"Swahili", "sw"},
            {"Tajik", "tg"},
            {"Thai", "th"},
            {"Tagalog", "tl"},
            {"Tatar", "tt"},
            {"Turkish", "tr"},
            {"Uzbek", "uz"},
            {"Ukrainian", "uk"},
            {"Finish", "fi"},
            {"French", "fr"},
            {"Croatian", "hr"},
            {"Czech", "cs"},
            {"Swedish", "sv"},
            {"Estonian", "et"},
            {"Japanese", "ja"}
        };

        #endregion
    }
}