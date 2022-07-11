using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraficRules.Properties;

namespace TraficRules
{
    public class Rule
    {
        public string Type { get; set; }
        public Image ImgFile { get; set; }
        public string ImgAlt { get; set; }
    }

    public static class Rules
    {
        private static List<Rule> rulesList = new List<Rule>()
        {
            new Rule()
            {
                Type = "Warning",
                ImgFile = Resources.img1_1,
                ImgAlt = "1.1 Shlagbaumli temir yo'l kesishmasi",
            },
            new Rule()
            {
                Type = "Warning",
                ImgFile = Resources.img1_2,
                ImgAlt = "1.2 Shlagbaumsiz temir yo’l kesishmasi",
            },
            new Rule()
            {
                Type = "Warning",
                ImgFile = Resources.img1_3,
                ImgAlt = "1.3 Diqqat \"UZP\"",
            },
            new Rule()
            {
                Type = "Warning",
                ImgFile = Resources.img1_4,
                ImgAlt = "1.4 Temir yo’l kesishmasining yaqinligi haqida ogohlantirish",
            },
            new Rule()
            {
                Type = "Warning",
                ImgFile = Resources.img1_5,
                ImgAlt = "1.5 Tramvay yo’li bilan kesishuv",
            },
            new Rule()
            {
                Type = "Warning",
                ImgFile = Resources.img1_6,
                ImgAlt = "1.6 Teng ahamiyatli yo’llar kesishuvi",
            },
            new Rule()
            {
                Type = "Warning",
                ImgFile = Resources.img1_7,
                ImgAlt = "1.7 Aylanma harakatlanish bilan kesishuv",
            },
            new Rule()
            {
                Type = "Warning",
                ImgFile = Resources.img1_8,
                ImgAlt = "1.8 Svetofor tartibga soladi",
            },
            new Rule()
            {
                Type = "Warning",
                ImgFile = Resources.img1_9,
                ImgAlt = "1.9 Ko’tarma ko’prik",
            },
            new Rule()
            {
                Type = "Warning",
                ImgFile = Resources.img1_10,
                ImgAlt = "1.10 Sohilga chiqish",
            },
            new Rule()
            {
                Type = "Privileged",
                ImgFile = Resources.imt2_1,
                ImgAlt = "2.1 Asosiy yo’l",
            },
            new Rule()
            {
                Type = "Privileged",
                ImgFile = Resources.imt2_2,
                ImgAlt = "2.2 Asosiy yo’lning oxiri",
            },
            new Rule()
            {
                Type = "Privileged",
                ImgFile = Resources.imt2_3_1,
                ImgAlt = "2.3.1 Ikkinchi darajali yo’l bilan kesishuv",
            },
            new Rule()
            {
                Type = "Privileged",
                ImgFile = Resources.imt2_3_2,
                ImgAlt = "2.3.2 tutashuv o’ngdan",
            },
            new Rule()
            {
                Type = "Privileged",
                ImgFile = Resources.imt2_3_3,
                ImgAlt = "2.3.3 tutashuv chapdan ",
            },
            new Rule()
            {
                Type = "Privileged",
                ImgFile = Resources.imt2_4,
                ImgAlt = "2.4 Yo’l bering",
            },
            new Rule()
            {
                Type = "Privileged",
                ImgFile = Resources.imt2_5,
                ImgAlt = "2.5 To’xtamasdan harakatlanish taqiqlangan",
            },
            new Rule()
            {
                Type = "Privileged",
                ImgFile = Resources.imt2_6,
                ImgAlt = "2.6 Ro’para harakatlanishning ustunligi",
            },
            new Rule()
            {
                Type = "Privileged",
                ImgFile = Resources.imt2_7,
                ImgAlt = "2.7 Ro’paradagi harakatlanishga nisbatan imtiyoz",
            },
            new Rule()
            {
                Type = "Prohibition",
                ImgFile = Resources.img3_1,
                ImgAlt = "3.1 Kirish ta'qiqlangan",
            },
            new Rule()
            {
                Type = "Prohibition",
                ImgFile = Resources.img3_2,
                ImgAlt = "3.2 Harakatlanish ta'qiqlangan",
            },
            new Rule()
            {
                Type = "Prohibition",
                ImgFile = Resources.img3_3,
                ImgAlt = "3.3 Mexanik transport vositalarining harakatlanishi taqiqlangan",
            },
            new Rule()
            {
                Type = "Prohibition",
                ImgFile = Resources.img3_4,
                ImgAlt = "3.4 Yuk avtomobillarining harakatlanishi taqiqlangan",
            },
            new Rule()
            {
                Type = "Prohibition",
                ImgFile = Resources.img3_5,
                ImgAlt = "3.5 Mototsikllar harakatlanishi taqiqlangan",
            },
            new Rule()
            {
                Type = "Prohibition",
                ImgFile = Resources.img3_6,
                ImgAlt = "3.6 Traktorlar harakatlanishi taqiqlangan",
            },
            new Rule()
            {
                Type = "Prohibition",
                ImgFile = Resources.img3_7,
                ImgAlt = "3.7 Tirkama bilan harakatlanish taqiqlangan",
            },
            new Rule()
            {
                Type = "Prohibition",
                ImgFile = Resources.img3_8,
                ImgAlt = "3.8 Ot-arava harakatlanishi taqiqlangan",
            },
            new Rule()
            {
                Type = "Prohibition",
                ImgFile = Resources.img3_9,
                ImgAlt = "3.9 Velosipedda harakatlanish ta'qiqlangan",
            },
            new Rule()
            {
                Type = "Prohibition",
                ImgFile = Resources.img3_10,
                ImgAlt = "3.10 Piyodalarning harakatlanishi ta'qiqlangan",
            },
            new Rule()
            {
                Type = "Commander",
                ImgFile = Resources.img4_1_1,
                ImgAlt = "4.1.1 Harakatlanish to’g’riga",
            },
            new Rule()
            {
                Type = "Commander",
                ImgFile = Resources.img4_1_2,
                ImgAlt = "4.1.2 Harakatlanish o’ngga",
            },
            new Rule()
            {
                Type = "Commander",
                ImgFile = Resources.img4_1_3,
                ImgAlt = "4.1.3 Harakatlanish chapga",
            },
            new Rule()
            {
                Type = "Commander",
                ImgFile = Resources.img4_1_4,
                ImgAlt = "4.1.4 Harakatlanish to’g’riga yoki o’ngga",
            },
            new Rule()
            {
                Type = "Commander",
                ImgFile = Resources.img4_1_5,
                ImgAlt = "4.1.5 Harakatlanish to’g’riga yoki chapga",
            },
            new Rule()
            {
                Type = "Commander",
                ImgFile = Resources.img4_1_6,
                ImgAlt = "4.1.6 Harakatlanish o’ngga yoki chapga",
            },
            new Rule()
            {
                Type = "Commander",
                ImgFile = Resources.img4_2_1,
                ImgAlt = "4.2.1 To’siqni o’ngdan chetlab o’tish",
            },
            new Rule()
            {
                Type = "Commander",
                ImgFile = Resources.img4_2_2,
                ImgAlt = "4.2.2 To’siqni chapdan chetlab o’tish",
            },
            new Rule()
            {
                Type = "Commander",
                ImgFile = Resources.img4_2_3,
                ImgAlt = "4.2.3 To’siqni o’ngdan yoki chapdan chetlab o’tish",
            },
            new Rule()
            {
                Type = "Commander",
                ImgFile = Resources.img4_3,
                ImgAlt = "4.3 Aylanma harakatlanish",
            },
        };

        public static List<Rule> GetRuleByType(string Type)
        {
            return rulesList.FindAll(rule => rule.Type == Type);
        }
    }
}
