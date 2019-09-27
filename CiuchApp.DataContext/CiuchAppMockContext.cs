using System;
using System.Collections.Generic;
using System.Linq;

using CiuchApp.Domain;

namespace CiuchApp.DataContext
{
    public static class CiuchAppMockContext
    {

        public static IEnumerable<Color> Colors = new List<Color>{
                    new Color { Id = 1, Name = "KLAM212" },
                    new Color { Id = 2, Name = "OWTR20" },
                    new Color { Id = 3, Name = "BLEW32" },
                    new Color { Id = 4, Name = "KKE2111" }
            };

        public static IEnumerable<TopCategory> TopCategories = new List<TopCategory>{
                new TopCategory { Id = 1, Name = "Odzież" },
                new TopCategory { Id = 2, Name = "Obuwie" },
                new TopCategory { Id = 3, Name = "Akcesoria"}
        };

        public static IEnumerable<MainCategory> MainCategories = new List<MainCategory>{
                new MainCategory { Id = 1, TopCategoryId = 1, Name = "Bielizna" },
                new MainCategory { Id = 2, TopCategoryId = 1, Name = "Bluzki" },
                new MainCategory { Id = 3, TopCategoryId = 1, Name = "Bluzy" },
                new MainCategory { Id = 4, TopCategoryId = 1, Name = "Jeansy" },
                new MainCategory { Id = 5, TopCategoryId = 1, Name = "Kombinezony" },
                new MainCategory { Id = 6, TopCategoryId = 1, Name = "Komplety i dresy" },
                new MainCategory { Id = 7, TopCategoryId = 1, Name = "Koszule" },
                new MainCategory { Id = 8, TopCategoryId = 1, Name = "Kurtki i płaszcze" },
                new MainCategory { Id = 9, TopCategoryId = 1, Name = "Marynarki i garnitury" },
                new MainCategory { Id = 10, TopCategoryId = 1, Name = "Materiały" },
                new MainCategory { Id = 11, TopCategoryId = 1, Name = "Odzież niemowlęca" },
                new MainCategory { Id = 12, TopCategoryId = 1, Name = "Snowboard" },
                new MainCategory { Id = 13, TopCategoryId = 1, Name = "Spódnice" },
                new MainCategory { Id = 14, TopCategoryId = 1, Name = "Spodnie" },
                new MainCategory { Id = 15, TopCategoryId = 1, Name = "Spodnie i legginsy" },
                new MainCategory { Id = 16, TopCategoryId = 1, Name = "Stroje kąpielowe" },
                new MainCategory { Id = 17, TopCategoryId = 1, Name = "Sukienki i tuniki" },
                new MainCategory { Id = 18, TopCategoryId = 1, Name = "Swetry" },
                new MainCategory { Id = 19, TopCategoryId = 1, Name = "Szorty" },
                new MainCategory { Id = 20, TopCategoryId = 1, Name = "T-shirty i polo" },
                new MainCategory { Id = 21, TopCategoryId = 1, Name = "Topy" },
                new MainCategory { Id = 22, TopCategoryId = 1, Name = "Żakiety" },
                new MainCategory { Id = 23, TopCategoryId = 2, Name = "Baleriny" },
                new MainCategory { Id = 24, TopCategoryId = 2, Name = "Buty wysokie" },
                new MainCategory { Id = 25, TopCategoryId = 2, Name = "Dziecko" },
                new MainCategory { Id = 26, TopCategoryId = 2, Name = "Kalosze" },
                new MainCategory { Id = 27, TopCategoryId = 2, Name = "Klapki i sandały" },
                new MainCategory { Id = 28, TopCategoryId = 2, Name = "Kozaki i botki" },
                new MainCategory { Id = 29, TopCategoryId = 2, Name = "Mokasyny i półbuty" },
                new MainCategory { Id = 30, TopCategoryId = 2, Name = "Outdoor" },
                new MainCategory { Id = 31, TopCategoryId = 2, Name = "Sportowe i lifestyle" },
                new MainCategory { Id = 32, TopCategoryId = 2, Name = "Szpilki" },
                new MainCategory { Id = 33, TopCategoryId = 2, Name = "Trampki i tenisówki" },
                new MainCategory { Id = 34, TopCategoryId = 2, Name = "Zimowe" },
                new MainCategory { Id = 35, TopCategoryId = 3, Name = "Bielizna" },
                new MainCategory { Id = 36, TopCategoryId = 3, Name = "Biżuteria" },
                new MainCategory { Id = 37, TopCategoryId = 3, Name = "Czapki i kapelusze" },
                new MainCategory { Id = 38, TopCategoryId = 3, Name = "Gadżety i akcesoria" },
                new MainCategory { Id = 39, TopCategoryId = 3, Name = "Kosmetyki" },
                new MainCategory { Id = 40, TopCategoryId = 3, Name = "Krawaty i muchy" },
                new MainCategory { Id = 41, TopCategoryId = 3, Name = "Książki i albumy" },
                new MainCategory { Id = 42, TopCategoryId = 3, Name = "Okulary" },
                new MainCategory { Id = 43, TopCategoryId = 3, Name = "Parasole" },
                new MainCategory { Id = 44, TopCategoryId = 3, Name = "Paski" },
                new MainCategory { Id = 45, TopCategoryId = 3, Name = "Pielęgnacja obuwia" },
                new MainCategory { Id = 46, TopCategoryId = 3, Name = "Plecaki" },
                new MainCategory { Id = 47, TopCategoryId = 3, Name = "Portfele" },
                new MainCategory { Id = 48, TopCategoryId = 3, Name = "Rajstopy i skarpetki" },
                new MainCategory { Id = 49, TopCategoryId = 3, Name = "Rękawiczki" },
                new MainCategory { Id = 50, TopCategoryId = 3, Name = "Rowery" },
                new MainCategory { Id = 51, TopCategoryId = 3, Name = "Skarpety" },
                new MainCategory { Id = 52, TopCategoryId = 3, Name = "Słuchawki" },
                new MainCategory { Id = 53, TopCategoryId = 3, Name = "Snowboard" },
                new MainCategory { Id = 54, TopCategoryId = 3, Name = "Szaliki i chusty" },
                new MainCategory { Id = 55, TopCategoryId = 3, Name = "Torby i walizki" },
                new MainCategory { Id = 56, TopCategoryId = 3, Name = "Torebki" },
                new MainCategory { Id = 57, TopCategoryId = 3, Name = "Zegarki" }
        };

        public static IEnumerable<Group> Groups = new List<Group>{
                new Group { Id = 1, MainCategoryId = 1, Name = "Body", GroupCode = "BI", CnCode = "6212900000" },
                new Group { Id = 2, MainCategoryId = 1, Name = "Inne", GroupCode = "BI", CnCode = "6208920000" },
                new Group { Id = 3, MainCategoryId = 1, Name = "Kąpielówki", GroupCode = "BI", CnCode = "6112319000" },
                new Group { Id = 4, MainCategoryId = 1, Name = "Szlafroki", GroupCode = "BI", CnCode = "6208920000" },
                new Group { Id = 5, MainCategoryId = 1, Name = "Wyszczuplająca", GroupCode = "BI", CnCode = "6212900000" },
                new Group { Id = 6, MainCategoryId = 2, Name = "Z długim rękawem", GroupCode = "BU", CnCode = "" },
                new Group { Id = 7, MainCategoryId = 3, Name = "Przez głowę", GroupCode = "BL", CnCode = "6110309900" },
                new Group { Id = 8, MainCategoryId = 3, Name = "Rozpinane", GroupCode = "BL", CnCode = "6110309900" },
                new Group { Id = 9, MainCategoryId = 4, Name = "Jeansy", GroupCode = "SJ", CnCode = "6204623990" },
                new Group { Id = 10, MainCategoryId = 5, Name = "Kombinezony", GroupCode = "SK", CnCode = "6211439000" },
                new Group { Id = 11, MainCategoryId = 6, Name = "Dresy", GroupCode = "DK", CnCode = "6112110000" },
                new Group { Id = 12, MainCategoryId = 6, Name = "Komplety", GroupCode = "DK", CnCode = "6104230000" },
                new Group { Id = 13, MainCategoryId = 7, Name = "Z długim rękawem", GroupCode = "KD", CnCode = "" },
                new Group { Id = 14, MainCategoryId = 7, Name = "Z krótkim rękawem", GroupCode = "KK", CnCode = "6206300090" },
                new Group { Id = 15, MainCategoryId = 8, Name = "Bezrękawniki", GroupCode = "KU", CnCode = "6202930000" },
                new Group { Id = 16, MainCategoryId = 8, Name = "Kurtki długie", GroupCode = "KU", CnCode = "6202930000" },
                new Group { Id = 17, MainCategoryId = 8, Name = "Kurtki krótkie", GroupCode = "KU", CnCode = "6202930000" },
                new Group { Id = 18, MainCategoryId = 8, Name = "Płaszcze", GroupCode = "KP", CnCode = "" },
                new Group { Id = 19, MainCategoryId = 8, Name = "Poncha", GroupCode = "KU", CnCode = "6202930000" },
                new Group { Id = 20, MainCategoryId = 9, Name = "Garnitury", GroupCode = "KZ", CnCode = "6203120000" },
                new Group { Id = 21, MainCategoryId = 9, Name = "Kamizelki", GroupCode = "KZ", CnCode = "6211324100" },
                new Group { Id = 22, MainCategoryId = 9, Name = "Marynarki", GroupCode = "KZ", CnCode = "6203339000" },
                new Group { Id = 23, MainCategoryId = 10, Name = "Materiały", GroupCode = "MT", CnCode = "" },
                new Group { Id = 24, MainCategoryId = 10, Name = "Metki", GroupCode = "ML", CnCode = "" },
                new Group { Id = 25, MainCategoryId = 11, Name = "Odzież niemowlęca", GroupCode = "ON", CnCode = "" },
                new Group { Id = 26, MainCategoryId = 12, Name = "Kombinezony", GroupCode = "KU", CnCode = "6211200090" },
                new Group { Id = 27, MainCategoryId = 12, Name = "Kurtki", GroupCode = "KU", CnCode = "6210500000" },
                new Group { Id = 28, MainCategoryId = 12, Name = "Spodnie", GroupCode = "SP", CnCode = "6210500000" },
                new Group { Id = 29, MainCategoryId = 13, Name = "Maxi", GroupCode = "SD", CnCode = "6104530000" },
                new Group { Id = 30, MainCategoryId = 13, Name = "Midi", GroupCode = "SD", CnCode = "6104530000" },
                new Group { Id = 31, MainCategoryId = 13, Name = "Mini", GroupCode = "SD", CnCode = "6104530000" },
                new Group { Id = 32, MainCategoryId = 14, Name = "Casual (na co dzień)", GroupCode = "SP", CnCode = "6204623990" },
                new Group { Id = 33, MainCategoryId = 14, Name = "Eleganckie", GroupCode = "SP", CnCode = "6203423500" },
                new Group { Id = 34, MainCategoryId = 14, Name = "Sportowe", GroupCode = "SP", CnCode = "6204623990" },
                new Group { Id = 35, MainCategoryId = 15, Name = "Casual (na co dzień)", GroupCode = "SP", CnCode = "" },
                new Group { Id = 36, MainCategoryId = 15, Name = "Eleganckie", GroupCode = "SP", CnCode = "" },
                new Group { Id = 37, MainCategoryId = 15, Name = "Legginsy", GroupCode = "LG", CnCode = "" },
                new Group { Id = 38, MainCategoryId = 15, Name = "Sportowe", GroupCode = "SP", CnCode = "" },
                new Group { Id = 39, MainCategoryId = 16, Name = "Stroje kąpielowe", GroupCode = "BI", CnCode = "6112419000" },
                new Group { Id = 40, MainCategoryId = 17, Name = "Casual (na co dzień)", GroupCode = "SU", CnCode = "6204430000" },
                new Group { Id = 41, MainCategoryId = 17, Name = "Eleganckie", GroupCode = "SU", CnCode = "6204430000" },
                new Group { Id = 42, MainCategoryId = 18, Name = "Przez głowę", GroupCode = "SW", CnCode = "6110309900" },
                new Group { Id = 43, MainCategoryId = 18, Name = "Rozpinane", GroupCode = "SW", CnCode = "6110309900" },
                new Group { Id = 44, MainCategoryId = 19, Name = "Casual (na co dzień)", GroupCode = "SZ", CnCode = "6204639090" },
                new Group { Id = 45, MainCategoryId = 19, Name = "Eleganckie", GroupCode = "SZ", CnCode = "6204639090" },
                new Group { Id = 46, MainCategoryId = 19, Name = "Sportowe", GroupCode = "SZ", CnCode = "6204639090" },
                new Group { Id = 47, MainCategoryId = 20, Name = "Bez rękawów", GroupCode = "TS", CnCode = "6109100090" },
                new Group { Id = 48, MainCategoryId = 20, Name = "Polo", GroupCode = "PO", CnCode = "6105100000" },
                new Group { Id = 49, MainCategoryId = 20, Name = "T-shirty", GroupCode = "TS", CnCode = "6109100010" },
                new Group { Id = 50, MainCategoryId = 20, Name = "Z długim rękawem", GroupCode = "BU", CnCode = "6109100090" },
                new Group { Id = 51, MainCategoryId = 21, Name = "Bez rękawów", GroupCode = "TS", CnCode = "6109902000" },
                new Group { Id = 52, MainCategoryId = 21, Name = "Z krótkim rękawem", GroupCode = "TS", CnCode = "6109902000" },
                new Group { Id = 53, MainCategoryId = 22, Name = "Casual (na co dzień)", GroupCode = "KZ", CnCode = "6204339000" },
                new Group { Id = 54, MainCategoryId = 22, Name = "Eleganckie", GroupCode = "KZ", CnCode = "6204339000" },
                new Group { Id = 55, MainCategoryId = 22, Name = "Kamizelki", GroupCode = "KZ", CnCode = "6211324100" },
                new Group { Id = 56, MainCategoryId = 23, Name = "Baleriny", GroupCode = "OB", CnCode = "" },
                new Group { Id = 57, MainCategoryId = 24, Name = "Casual (na co dzień)", GroupCode = "OB", CnCode = "" },
                new Group { Id = 58, MainCategoryId = 24, Name = "Eleganckie", GroupCode = "OB", CnCode = "" },
                new Group { Id = 59, MainCategoryId = 25, Name = "Kozaki", GroupCode = "OD", CnCode = "" },
                new Group { Id = 60, MainCategoryId = 26, Name = "Kalosze", GroupCode = "OB", CnCode = "" },
                new Group { Id = 61, MainCategoryId = 27, Name = "Japonki", GroupCode = "KL", CnCode = "" },
                new Group { Id = 62, MainCategoryId = 27, Name = "Klapki", GroupCode = "KL", CnCode = "" },
                new Group { Id = 63, MainCategoryId = 27, Name = "Koturny i espadryle", GroupCode = "OB", CnCode = "" },
                new Group { Id = 64, MainCategoryId = 27, Name = "Sandały", GroupCode = "OB", CnCode = "" },
                new Group { Id = 65, MainCategoryId = 28, Name = "Botki", GroupCode = "OB", CnCode = "" },
                new Group { Id = 66, MainCategoryId = 28, Name = "Kozaki", GroupCode = "OB", CnCode = "" },
                new Group { Id = 67, MainCategoryId = 28, Name = "Oficerki", GroupCode = "OB", CnCode = "" },
                new Group { Id = 68, MainCategoryId = 28, Name = "Śniegowce", GroupCode = "OB", CnCode = "" },
                new Group { Id = 69, MainCategoryId = 29, Name = "Casual (na co dzień)", GroupCode = "OB", CnCode = "" },
                new Group { Id = 70, MainCategoryId = 29, Name = "Mokasyny", GroupCode = "OB", CnCode = "" },
                new Group { Id = 71, MainCategoryId = 29, Name = "Półbuty", GroupCode = "OB", CnCode = "" },
                new Group { Id = 72, MainCategoryId = 29, Name = "Wizytowe", GroupCode = "OB", CnCode = "" },
                new Group { Id = 73, MainCategoryId = 30, Name = "Outdoor", GroupCode = "OB", CnCode = "" },
                new Group { Id = 74, MainCategoryId = 30, Name = "Sandały", GroupCode = "OB", CnCode = "" },
                new Group { Id = 75, MainCategoryId = 31, Name = "Lifestyle", GroupCode = "OB", CnCode = "" },
                new Group { Id = 76, MainCategoryId = 31, Name = "Sportowe", GroupCode = "OB", CnCode = "" },
                new Group { Id = 77, MainCategoryId = 32, Name = "Czółenka", GroupCode = "OB", CnCode = "" },
                new Group { Id = 78, MainCategoryId = 32, Name = "Peep toe", GroupCode = "OB", CnCode = "" },
                new Group { Id = 79, MainCategoryId = 32, Name = "Sandały na obcasie", GroupCode = "OB", CnCode = "" },
                new Group { Id = 80, MainCategoryId = 32, Name = "Szpilki", GroupCode = "OB", CnCode = "" },
                new Group { Id = 81, MainCategoryId = 33, Name = "Niskie", GroupCode = "OB", CnCode = "" },
                new Group { Id = 82, MainCategoryId = 33, Name = "Wysokie", GroupCode = "OB", CnCode = "" },
                new Group { Id = 83, MainCategoryId = 34, Name = "Zimowe", GroupCode = "OB", CnCode = "" },
                new Group { Id = 84, MainCategoryId = 35, Name = "Biustonosze", GroupCode = "BI", CnCode = "6212109000" },
                new Group { Id = 85, MainCategoryId = 35, Name = "Bokserki", GroupCode = "BI", CnCode = "6107110000" },
                new Group { Id = 86, MainCategoryId = 35, Name = "Kalesony", GroupCode = "BI", CnCode = "6107110000" },
                new Group { Id = 87, MainCategoryId = 35, Name = "Komplety", GroupCode = "BI", CnCode = "6212101000" },
                new Group { Id = 88, MainCategoryId = 35, Name = "Koszulki", GroupCode = "BI", CnCode = "6109100000" },
                new Group { Id = 89, MainCategoryId = 35, Name = "Majtki", GroupCode = "BI", CnCode = "6108210000" },
                new Group { Id = 90, MainCategoryId = 35, Name = "Pasy do pończoch", GroupCode = "AK", CnCode = "6212200000" },
                new Group { Id = 91, MainCategoryId = 35, Name = "Piżamy", GroupCode = "BI", CnCode = "6108310000" },
                new Group { Id = 92, MainCategoryId = 35, Name = "Slipy", GroupCode = "BI", CnCode = "6107110000" },
                new Group { Id = 93, MainCategoryId = 36, Name = "Biżuteria", GroupCode = "AK", CnCode = "7117900000" },
                new Group { Id = 94, MainCategoryId = 36, Name = "Bransoletki", GroupCode = "AK", CnCode = "7117900000" },
                new Group { Id = 95, MainCategoryId = 36, Name = "Breloki", GroupCode = "AK", CnCode = "7326909890" },
                new Group { Id = 96, MainCategoryId = 36, Name = "Broszki", GroupCode = "AK", CnCode = "" },
                new Group { Id = 97, MainCategoryId = 36, Name = "Inne", GroupCode = "AK", CnCode = "7117900000" },
                new Group { Id = 98, MainCategoryId = 36, Name = "Kolczyki", GroupCode = "AK", CnCode = "7117900000" },
                new Group { Id = 99, MainCategoryId = 36, Name = "Naszyjniki", GroupCode = "AK", CnCode = "7117900000" },
                new Group { Id = 100, MainCategoryId = 36, Name = "Ozdoby do włosów", GroupCode = "AK", CnCode = "9615190000" },
                new Group { Id = 101, MainCategoryId = 36, Name = "Pierścionki", GroupCode = "AK", CnCode = "7117900000" },
                new Group { Id = 102, MainCategoryId = 37, Name = "Czapki z daszkiem", GroupCode = "CA", CnCode = "6505003000" },
                new Group { Id = 103, MainCategoryId = 37, Name = "Czapki zimowe", GroupCode = "CA", CnCode = "6505009090" },
                new Group { Id = 104, MainCategoryId = 37, Name = "Kapelusze", GroupCode = "CA", CnCode = "6505009090" },
                new Group { Id = 105, MainCategoryId = 37, Name = "Kaszkiety i berety", GroupCode = "CA", CnCode = "6505009090" },
                new Group { Id = 106, MainCategoryId = 38, Name = "Autorskie grafiki", GroupCode = "AK", CnCode = "" },
                new Group { Id = 107, MainCategoryId = 38, Name = "Elektronika", GroupCode = "AK", CnCode = "" },
                new Group { Id = 108, MainCategoryId = 38, Name = "Inne", GroupCode = "RO", CnCode = "4202990090" },
                new Group { Id = 109, MainCategoryId = 38, Name = "Kosmetyczki", GroupCode = "AK", CnCode = "4202921100" },
                new Group { Id = 110, MainCategoryId = 38, Name = "Pokrowce", GroupCode = "AK", CnCode = "4202990090" },
                new Group { Id = 111, MainCategoryId = 38, Name = "Ręczniki", GroupCode = "AK", CnCode = "6302600000" },
                new Group { Id = 112, MainCategoryId = 39, Name = "Do ciała", GroupCode = "AK", CnCode = "3304990000" },
                new Group { Id = 113, MainCategoryId = 39, Name = "Do makijażu", GroupCode = "AK", CnCode = "3304990000" },
                new Group { Id = 114, MainCategoryId = 39, Name = "Do paznokci", GroupCode = "AK", CnCode = "3304300000" },
                new Group { Id = 115, MainCategoryId = 39, Name = "Do twarzy", GroupCode = "AK", CnCode = "3304990000" },
                new Group { Id = 116, MainCategoryId = 39, Name = "Do włosów", GroupCode = "AK", CnCode = "3305900000" },
                new Group { Id = 117, MainCategoryId = 40, Name = "Krawaty", GroupCode = "AK", CnCode = "6215200000" },
                new Group { Id = 118, MainCategoryId = 40, Name = "Muchy", GroupCode = "AK", CnCode = "6215200000" },
                new Group { Id = 119, MainCategoryId = 40, Name = "Poszetki", GroupCode = "AK", CnCode = "6217100090" },
                new Group { Id = 120, MainCategoryId = 41, Name = "Książki i albumy", GroupCode = "AK", CnCode = "4901990000" },
                new Group { Id = 121, MainCategoryId = 42, Name = "Okulary", GroupCode = "OK", CnCode = "9004109100" },
                new Group { Id = 122, MainCategoryId = 43, Name = "Parasole", GroupCode = "AK", CnCode = "6601999000" },
                new Group { Id = 123, MainCategoryId = 44, Name = "Paski", GroupCode = "PA", CnCode = "3926200000" },
                new Group { Id = 124, MainCategoryId = 45, Name = "Inne", GroupCode = "AK", CnCode = "6307909899" },
                new Group { Id = 125, MainCategoryId = 45, Name = "Pasty i impregnaty", GroupCode = "AK", CnCode = "3405100000" },
                new Group { Id = 126, MainCategoryId = 45, Name = "Szczotki i czyściki", GroupCode = "AK", CnCode = "9603909100" },
                new Group { Id = 127, MainCategoryId = 45, Name = "Wkładki", GroupCode = "AK", CnCode = "6406909090" },
                new Group { Id = 128, MainCategoryId = 46, Name = "Plecaki", GroupCode = "PK", CnCode = "4202929190" },
                new Group { Id = 129, MainCategoryId = 47, Name = "Portfele", GroupCode = "PF", CnCode = "4202321000" },
                new Group { Id = 130, MainCategoryId = 48, Name = "Pończochy", GroupCode = "LG", CnCode = "6115301900" },
                new Group { Id = 131, MainCategoryId = 48, Name = "Rajstopy", GroupCode = "LG", CnCode = "6115220000" },
                new Group { Id = 132, MainCategoryId = 48, Name = "Skarpetki", GroupCode = "LG", CnCode = "6115969900" },
                new Group { Id = 133, MainCategoryId = 49, Name = "Rękawiczki", GroupCode = "RE", CnCode = "6116930000" },
                new Group { Id = 134, MainCategoryId = 50, Name = "Rowery", GroupCode = "AK", CnCode = "" },
                new Group { Id = 135, MainCategoryId = 51, Name = "Skarpety", GroupCode = "LG", CnCode = "6115969900" },
                new Group { Id = 136, MainCategoryId = 52, Name = "Słuchawki", GroupCode = "AK", CnCode = "8518309590" },
                new Group { Id = 137, MainCategoryId = 53, Name = "Rękawiczki", GroupCode = "AK", CnCode = "" },
                new Group { Id = 138, MainCategoryId = 54, Name = "Chusty", GroupCode = "SA", CnCode = "6117100000" },
                new Group { Id = 139, MainCategoryId = 54, Name = "Kominy", GroupCode = "SA", CnCode = "6117100000" },
                new Group { Id = 140, MainCategoryId = 54, Name = "Szale", GroupCode = "SA", CnCode = "6117100000" },
                new Group { Id = 141, MainCategoryId = 54, Name = "Szaliki", GroupCode = "SA", CnCode = "6117100000" },
                new Group { Id = 142, MainCategoryId = 55, Name = "Na laptopa", GroupCode = "TO", CnCode = "4202121100" },
                new Group { Id = 143, MainCategoryId = 55, Name = "Torby", GroupCode = "TO", CnCode = "4202121900" },
                new Group { Id = 144, MainCategoryId = 55, Name = "Walizki", GroupCode = "TO", CnCode = "4202121900" },
                new Group { Id = 145, MainCategoryId = 56, Name = "Casual (na co dzień)", GroupCode = "TO", CnCode = "4202221000" },
                new Group { Id = 146, MainCategoryId = 56, Name = "Eleganckie", GroupCode = "TO", CnCode = "4202221000" },
                new Group { Id = 147, MainCategoryId = 57, Name = "Zegarki", GroupCode = "AK", CnCode = "9102110000" }
        };

        public static IEnumerable<Component> Components = new List<Component>{
                new Component { Id = 1, Name = "100% Bawełna" },
                new Component { Id = 2, Name = "98% Bawełna, 2 Poliester" },
                new Component { Id = 3, Name = "100% Poliester" },
                new Component { Id = 4, Name = "90% Poliester, 10% Elastan" }
        };

        public static IEnumerable<CountryOfOrigin> CountryOfOrigins = new List<CountryOfOrigin>{
                new CountryOfOrigin { Id = 1, Name = "Chiny" },
                new CountryOfOrigin { Id = 2, Name = "Włochy" },
                new CountryOfOrigin { Id = 3, Name = "Bangladesz" },
                new CountryOfOrigin { Id = 4, Name = "Turcja" },
                new CountryOfOrigin { Id = 5, Name = "Polska" }
        };

        public static IEnumerable<Supplier> Suppliers = new List<Supplier>{
                new Supplier{ Id = 1, Name = "Alvaro" },
                new Supplier{ Id = 2, Name = "La Casa del Papel" },
                new Supplier{ Id = 3, Name = "Ing Ung Wang" },
                new Supplier{ Id = 4, Name = "Neapolitana" } };

        public static IEnumerable<Size> Sizes = new List<Size>{
                new Size { Id = 1, Name = "XS" },
                new Size { Id = 2, Name = "S" },
                new Size { Id = 3, Name = "M" },
                new Size { Id = 4, Name = "L" },
                new Size { Id = 5, Name = "XL" },
                new Size { Id = 6, Name = "S/M" },
                new Size { Id = 7, Name = "M/L" },
                new Size { Id = 8, Name = "36" },
                new Size { Id = 9, Name = "37" },
                new Size { Id = 10, Name = "37" },
                new Size { Id = 11, Name = "39" },
                new Size { Id = 12, Name = "40" },
                new Size { Id = 13, Name = "41" }
        };

        public static IEnumerable<CodeCn> CodeCns = new List<CodeCn>{
                new CodeCn{ Id = 1, Name = "QWERT" },
                new CodeCn{ Id = 2, Name = "ASDFG" },
                new CodeCn{ Id = 3, Name = "YUIO" },
                new CodeCn{ Id = 4, Name = "VBNM" },
                new CodeCn{ Id = 5, Name = "LKJHGF" }
        };

        public static IEnumerable<Set> Sets = new List<Set>{
                new Set{ Id = 1, Name = "Adventure Explorer" },
                new Set{ Id = 2, Name = "Animal Instinct" },
                new Set{ Id = 3, Name = "Advanced Retailer" },
                new Set{ Id = 4, Name = "Braveheart Warior" },
                new Set{ Id = 5, Name = "Elegant Summer" }
        };

        public static IEnumerable<ColorName> ColorNames = new List<ColorName>{
                new ColorName { Id = 1, Name = "Zielony" },
                new ColorName { Id = 2, Name = "Biały" },
                new ColorName { Id = 3, Name = "Czarny" },
                new ColorName { Id = 4, Name = "Niebieski" },
                new ColorName { Id = 5, Name = "Żółty" }
        };

        public static IEnumerable<Country> Countries = new List<Country>{
                   new Country { Id = 1, Name = "Polska" },
                   new Country { Id = 2, Name = "Hiszpania" },
                   new Country { Id = 3, Name = "Włochy" },
                   new Country { Id = 4, Name = "Wielka Brytania" },
                   new Country { Id = 5, Name = "Francja" },
                   new Country { Id = 6, Name = "Chiny" },
                   new Country { Id = 7, Name = "Turcja" }
        };

        public static IEnumerable<City> Cities = new List<City> {
               new City { Id = 1, CountryId = 1, Name = "Wólka Kosowska" },
               new City { Id = 2, CountryId = 2, Name = "Paryż" },
               new City { Id = 3, CountryId = 4, Name = "Londyn" },
               new City { Id = 4, CountryId = 4, Name = "Manchester" },
               new City { Id = 5, CountryId = 2, Name = "Madryt" },
               new City { Id = 6, CountryId = 3, Name = "Prato" },
               new City { Id = 7, CountryId = 7, Name = "Istambuł" },
               new City { Id = 8, CountryId = 6, Name = "Guangzhou" }
        };

        public static IEnumerable<Season> Seasons = new List<Season> {
               new Season { Id = 1, Name = "WW19" },
               new Season { Id = 2, Name = "WZ19" },
               new Season { Id = 3, Name = "WS19" },
               new Season { Id = 4, Name = "WA19" },
               new Season { Id = 5, Name = "WW20" },
               new Season { Id = 6, Name = "WZ20" },
               new Season { Id = 7, Name = "WS20" },
               new Season { Id = 8, Name = "WA20" },
               new Season { Id = 9, Name = "WW21" },
               new Season { Id = 10, Name = "WZ21" },
               new Season { Id = 11, Name = "WS21" },
               new Season { Id = 12, Name = "WA21" }
        };

        public static IEnumerable<Currency> Currencies = new List<Currency> {
               new Currency { Id = 1, Name = "PLN" },
               new Currency { Id = 2, Name = "EURO" },
               new Currency { Id = 3, Name = "FUNT" },
               new Currency { Id = 4, Name = "DOLAR" }
               };

        public static IEnumerable<BusinessTrip> BusinessTrips = new List<BusinessTrip> {
                new BusinessTrip { Id = 1, DateFrom = new DateTime(2018, 05, 06), DateTo = new DateTime(2018, 05, 09), CountryId = 1, CityId = 1, SeasonId = 3, CurrencyId = 1 },
                new BusinessTrip { Id = 2, DateFrom = new DateTime(2018, 06, 20), DateTo = new DateTime(2018, 06, 22), CountryId = 3, CityId = 5, SeasonId = 4, CurrencyId = 2 },
                new BusinessTrip { Id = 3, DateFrom = new DateTime(2018, 07, 03), DateTo = new DateTime(2018, 07, 09), CountryId = 4, CityId = 3, SeasonId = 4, CurrencyId = 3 }
        };

        public static IEnumerable<SizeAmountPair> SizeAmountPairs = new List<SizeAmountPair>
        {
            new SizeAmountPair { Id = 1, SizeId=1, Amount=20},
            new SizeAmountPair { Id = 2, SizeId=1, Amount=30},
            new SizeAmountPair { Id = 3, SizeId=2, Amount=40},
            new SizeAmountPair { Id = 3, SizeId=2, Amount=50},
            new SizeAmountPair { Id = 4, SizeId=3, Amount=60}
        };

        public static IEnumerable<Piece> Pieces = new List<Piece>
        {
             new Piece
             {
                 Id = 1,
                 Name = "SHIRT1122",
                 BusinessTripId = 1,
                 ColorId = 1,
                 TopCategoryId = 1,
                 MainCategoryId = 1,
                 GroupId = 1,
                 ComponentId = 1,
                 CountryOfOriginId = 1,
                 BuyPrice = 10.36,
                 SellPrice = 32.32,
                 SupplierId = 1,
                 OrderDate = new DateTime(2018, 09, 05),
                 EstimatedDateOfShipment = new DateTime(2018, 09, 15),
                 EstimatedTimeOfDelivery = new DateTime(2018, 09, 22),
                 CodeCnId = 1,
                 SetId = 1,
                 ColorNameId = 1,
                 ImageName = "SHIRT1122.jpg"
             },
             new Piece
             {
                 Id = 2,
                 Name = "SHIRT1122",
                 BusinessTripId = 1,
                 ColorId = 1,
                 TopCategoryId = 1,
                 MainCategoryId = 1,
                 GroupId = 1,
                 ComponentId = 1,
                 CountryOfOriginId = 1,
                 BuyPrice = 10.36,
                 SellPrice = 32.32,
                 SupplierId = 1,
                 OrderDate = new DateTime(2018, 09, 05),
                 EstimatedDateOfShipment = new DateTime(2018, 09, 15),
                 EstimatedTimeOfDelivery = new DateTime(2018, 09, 22),
                 CodeCnId = 1,
                 SetId = 1,
                 ColorNameId = 1,
                 ImageName = "SHIRT1OWA122.jpg"
             },
             new Piece
             {
                 Id = 3,
                 Name = "SHIRT1122",
                 BusinessTripId = 1,
                 ColorId = 1,
                 TopCategoryId = 1,
                 MainCategoryId = 1,
                 GroupId = 1,
                 ComponentId = 1,
                 CountryOfOriginId = 1,
                 BuyPrice = 10.36,
                 SellPrice = 32.32,
                 SupplierId = 1,
                 OrderDate = new DateTime(2018, 09, 05),
                 EstimatedDateOfShipment = new DateTime(2018, 09, 15),
                 EstimatedTimeOfDelivery = new DateTime(2018, 09, 22),
                 CodeCnId = 1,
                 SetId = 1,
                 ColorNameId = 1,
                 ImageName = "DOWAASHIRT1122.jpg"
             }
        };

        public static object Set<T>()
        {
            if (typeof(T) == typeof(Color           )) return Colors;
            if (typeof(T) == typeof(TopCategory     )) return TopCategories;
            if (typeof(T) == typeof(MainCategory    )) return MainCategories;
            if (typeof(T) == typeof(Group           )) return Groups;
            if (typeof(T) == typeof(Component       )) return Components;
            if (typeof(T) == typeof(CountryOfOrigin )) return CountryOfOrigins;
            if (typeof(T) == typeof(Supplier        )) return Suppliers;
            if (typeof(T) == typeof(Size            )) return Sizes;
            if (typeof(T) == typeof(CodeCn          )) return CodeCns;
            if (typeof(T) == typeof(Set             )) return Sets;
            if (typeof(T) == typeof(ColorName       )) return ColorNames;
            if (typeof(T) == typeof(Country         )) return Countries;
            if (typeof(T) == typeof(City            )) return  Cities;
            if (typeof(T) == typeof(Season          )) return Seasons;
            if (typeof(T) == typeof(Currency        )) return Currencies;
            if (typeof(T) == typeof(BusinessTrip    )) return BusinessTrips;
            if (typeof(T) == typeof(SizeAmountPair  )) return SizeAmountPairs;
            if (typeof(T) == typeof(Piece           )) return Pieces;


            return null;
        }
    }
}