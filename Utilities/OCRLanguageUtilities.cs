using System;
using System.Collections.Generic;

namespace pdfOCRCloud.Utilities
{
    internal static class OCRLanguageUtilities
    {
        private static readonly Dictionary<string, string> OCRLanguages = new Dictionary<string, string>()
        {
            {"afr", "Afrikaans"},
            {"sqi", "Albanian"},
            {"grc", "Ancient Greek"},
            {"ara", "Arabic"},
            {"aze", "Azerbaijani"},
            {"eus", "Basque"},
            {"bel", "Belarusian"},
            {"ben", "Bengali"},
            {"bul", "Bulgarian"},
            {"cat", "Catalan"},
            {"chr", "Cherokee"},
            {"chi_sim", "Chinese (Simplified)"},
            {"chi_tra", "Chinese (Traditional)"},
            {"hrv", "Croatian"},
            {"ces", "Czech"},
            {"dan", "Danish"},
            {"dan-frak", "Danish (Fraktur)"},
            {"nld", "Dutch"},
            {"eng", "English"},
            {"epo", "Esperanto"},
            {"est", "Estonian"},
            {"fin", "Finnish"},
            {"frk", "Frankish"},
            {"fra", "French"},
            {"glg", "Galician"},
            {"deu", "German"},
            {"deu-frak", "German (Fraktur)"},
            {"ell", "Greek"},
            {"heb", "Hebrew"},
            {"hin", "Hindi"},
            {"hun", "Hungarian"},
            {"isl", "Icelandic"},
            {"ind", "Indonesian"},
            {"ita", "Italian"},
            {"ita_old", "Italian (Old)"},
            {"jpn", "Japanese"},
            {"kan", "Kannada"},
            {"kor", "Korean"},
            {"lav", "Latvian"},
            {"lit", "Lithuanian"},
            {"mkd", "Macedonian"},
            {"msa", "Malay"},
            {"mal", "Malayalam"},
            {"mlt", "Maltese"},
            {"enm", "Middle English (1100-1500)"},
            {"frm", "Middle French (1400-1600)"},
            {"nor", "Norwegian"},
            {"pol", "Polish"},
            {"por", "Portuguese"},
            {"ron", "Romanian"},
            {"rus", "Russian"},
            {"srp", "Serbian (Latin)"},
            {"slk", "Slovakian"},
            {"slk-frak", "Slovakian (Fraktur)"},
            {"slv", "Slovenian"},
            {"spa", "Spanish"},
            {"spa_old", "Spanish (Old)"},
            {"swa", "Swahili"},
            {"swe", "Swedish"},
            {"tgl", "Tagalog"},
            {"tam", "Tamil"},
            {"tel", "Telugu"},
            {"tha", "Thai"},
            {"tur", "Turkish"},
            {"ukr", "Ukrainian"},
            {"vie", "Vietnamese"}
        };


        public static string GetFullLanguageNameFromAbreviation(string abreviation)
        {
            if (OCRLanguages.TryGetValue(abreviation, out string fullLanguageName))
            {
                return fullLanguageName;
            }

            return abreviation;
        }
    }
}
