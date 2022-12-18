using HayvonlarHaqida.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvonlarHaqida
{

    public class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Image Image1 { get; set; }
        public Image Image2 { get; set; }
    }

    public class Animals
    {
        List<Animal> animals;
        public Animals()
        {
            animals = new List<Animal>
            {
               new Animal
               {
                    Name = "Timsoh",
                    Description = "Timsohlar — suvda yashovchi sudralib yuruvchilar turkumi. Tanasi kaltakesakka oʻxshash, uzunligi 2–7 m, boshi yassilashgan, tumshugʻi uzun. Koʻzlari va burun teshiklari boshi ustidan boʻrtib chiqib turadi. Burun va quloq teshiklari suvda yopiladigan klapanlar bilan taʼminlangan. Ogʻiz boʻshligʻida ikkilamchi tanglay boʻladi. Tishlari yirik. Tili ogʻiz tubiga yopishgan. Dumi uzun va baland (ikki yondan yassilashgan). Orqa oyoqlari barmoqlari orasida suzgich pardalari bor. Terisi qattiq va qalin, muguzsimon yirik plastinkalar bilan qoplangan. Muguz plastinkalar ostida suyak plastinkalar joylashgʻan. Timsoh yuragi 4 kamerali boʻlishi bilan boshqa sudralib yuruvchilardan farq qiladi. Oʻpkasi yaxshi rivojlangan. Alligatorlar, gaviallar va haqiqiy timsoxlar oilalariga boʻlinadi."+
                        "\nTimsohlar oilasiga 3 urugʻ va 15 ga yaqin tur kiradi, jumladan, nil Timsohi (uzunligi 7 m gacha) tropik Afrika daryo, koʻl va botqokliklarida yashaydi.  Tarokli Timsoh (uzunligi 6 m gacha) Janubiy-Sharqiy Osiyo, Malayya arxipelagi orollari, Shimoliy Avstraliya va Yangi Gvineyadagi daryolarning quyilish joylari va dengiz sohillarida tarqalgan. Timsohlar  hayotining koʻp qismini suvda oʻtkazadi, asosan, tunda faol. Balikdar, sut emizuvchilar, qushlar va suv umurtqasizlari bilan oziklanadi. Nil Timsohi va tarokdi Timsohi odam uchun xavfli. Urgʻochi Timsoh qirgʻokdagi qum yoki chiriyotgan barglar orasiga 20—100 tuxum qoʻyadi. Nasli toʻgʻrisida gʻamxoʻrlik qiladi. Timsoh goʻshti yeyiladi, terisidan qimmatbaho terigalantereya buyumlari tayyorlanadi. Koʻplab ovlanishi tufayli soni kamayib ketgan. 26 turi va kenja turi  Xalqaro Qizil kitobga kiritilgan. Bir qancha mamlakatlar (AQSH, Kuba, Yaponiya, Keniya)da Timsohlarni koʻpaytiradigan pitomniklar mavjud.",
                    Image1 = Resources.timsoh,
                    Image2 = Resources.timsoh2,
               },

               new Animal
               {
                   Name = "Kobra iloni",
                   Description = "Kobra — O‘zbekistondagi yirik zaharli ilonlardan biridir Tanasining uzunligi 125 sm, dumi 45 sm gacha. Rangi tana rangidan to‘q sariq, qo‘ng‘ir yoki qoragacha kuchli darajada o‘zgarib turadi. Ostki tomoni oq va tanasining oldingi tomonida ikki-uchta qora ko‘ndalang yo‘llari bor. Yoshlarining orqasida uzunasiga qora rangli ko‘ndalang yo‘llari bor, ularning old tomonidagilari pastki yuzasiga o‘tib ketadi. Hindistonda yashaydigan kobralarning ensasida ko‘zoynakka o‘xshash naqshi bo‘lgani uchun ular ko‘zoynakli ilon deb ataladi. ",
                   Image1 = Resources.kobra,
                   Image2 = Resources.kobra2,
               },

               new Animal
               {
                   Name = "Sher",
                   Description = "Arslon yoki sher -mushuksimonlar oilasiga mansub turdir. Uzunligi 240 sm gacha (urgʻochisi kichikroq), ogʻirligi 280 kg gacha boʻladi. Yuz qismi choʻziq, dumining uchida uzun qora qildan iborat popugi bor. Tanasi kalta jun bilan qoplangan, erkaklari tanasining oldingi qismi (boʻyni, koʻkragi va yuzi)dagi uzun yunglari yolni hosil qiladi. Rangi sargʻish, yoli qoramtir tusda. Qadimgi areali Afrika (gʻarbidan tashqari), Yevropa (Bolqon yarim oroli, Zakavkaze – Armaniston) hamda Osiyoni (Arabiston yarim oroli, Kichik, Old va Janubiy Osiyo – Sharqda Hindistongacha) oʻz ichiga olgan. Individlar soni va areali keskin kamayib ketgan, hozirgi areali asosan Markaziy Afrikaning qoʻriqlanadigan hududlari va qisman Janubiy Osiyodan iborat." +
                        "\nArslon choʻl, savanna va daryo yaqinidagi oʻrmonlarda istiqomat qiladi. Poligam, oilaviy guruh hosil qiladi. Har 2 yilda bir marta 3–4 tadan bolalaydi. Homiladorlik davri 4–5 oy, 6–7 yoshida voyaga yetadi, erkagidan 3 yoshda yol chiqadi. Arslon kechasi guruh boʻlib ov qiladi, yirik tuyoqli hayvonlarni ovlaydi. Qari va yarador arslon odamga ham hujum qilishi mumkin. 70 yilgacha yashaydi. Arslon hamma joyda muhofaza qilinadi.",
                   Image1 = Resources.sher,
                   Image2 = Resources.sher2,
               },

               new Animal
               {
                   Name = "Akula",
                   Description = "Akulalar (Selachomorpha) – tog‘ayli baliqlar sinfi plastinka jabralilar kenja sinfining katta turkumi. Tanasi suyri shaklda, suv tubida yashovchi A. yassi, uz. 15–40 sm dan (tikanli qora Akula) 15–20 m gacha (gigant Akula), og‘irligi 14 t gacha (gigant va kit Akula). Tanasi plakoid tangachalar bilan krplangan. Jabra yoriqlari 5 (ba’zi turlarida 6–7) tadan bo‘lib, boshining ikki yonida, og‘zi boshining ostida tanasiga ko‘ndalang joylashgan. Dum suzgichi kuchli rivojlangan, har xil kattalikdagi (gsterotserkal) ikkita bo‘lakdan iborat. Tishlari ko‘p, uchi o‘tkir. Yirtqich Akulalarning tishlari juda yirik. Ko‘pchilik Akulalar yirtqich, baliqlar, mollyuskalar va boshqa hayvonlar bilan, kit va gigant Akulalar esa plankton bilan oziqlanadi. Akula tuxumdan tirik tug‘adi yoki tuxum qo‘yib ko‘payadi. Akula 6 turkumni (har xil tishlilar, ko‘p jabralilar, lamnosimonlar, katransimonlar, arraburunsimonlar, skvatinsimonlar), 20 oilani o‘z ichiga oladi. Akulalar Orol va Kaspiy dengizidan boshqa hamma dengiz va okeanlarda, ayrim turlari chuchuk suv havzalari (Gang va Amazonka daryolari, Nikaragua ko‘li)da yashaydi. Qora va Uzoq Sharq dengizlarida tikanli qora Akulalar, ya’ni katran, Shimoliy va Uzoq Sharq dengizlarida seld Akulalar, shimoliy dengizlarda qutb Akulalari tarkalgan. Akulalar ayniqsa tropik dengizlarda xilma-xil bo‘ladi. Ko‘pchilik Akulalar ovlanadi, jigaridan baliq yog‘i olinadi, go‘shti ovqat uchun ishlatiladi. Skeletidan baliq yelimi tayyorlanadi.",
                   Image1 = Resources.akula,
                   Image2 = Resources.akula2,
               },

               new Animal
               {
                   Name = "Bo'ri",
                   Description = "Boʻri, qashqir— itsimonlar oilasiga mansub yirtqich sut emizuvchi hayvon. Yevropa, Osiyo va Shimoliy Amerikada tarqalgan. Oʻzbekistonning choʻl, dashtlari, oʻrmon, toʻqay, togʻ va togʻ etaklarida tarqalgan; qor va muz bilan qoplangan baland togʻlar va tundrada ham yashaydi." +
                        "\nBoʻrilar qoyalar orasiga, toʻqaylik va jarliklarga, quruq qamishzorlarga in quradi. Tulki inlaridan ham foydalanadi. Boʻrilar inida bolalaydi va bolalarini parvarish qiladi. Chorvachilik r-nlarida podalardan uzoqqa ketmaydi. Boʻrilar yanvar oyidan boshlab urchiydi. Urchish vaqtida erkaklari urgʻochisini talashib qattiq urishadi. Boʻrilar monogam hayvon. Jufti uzoq muddat saqlanib qoladi. Homiladorlik davri 62— 65 kun. Yosh boʻri 3—5 ta, qarisi 6—8 ta, baʼzan 10—13 ta bola tugʻadi. Bolasini 5—6 hafta emizadi. Bolasi 3 haftaligida inidan chiqa boshlaydi. Urgʻochisi emizikli davrida erkagi ovqat olib kelib turadi. Bolalari goʻsht bilan oziqlanishga oʻtgandan soʻng ona boʻri ham oʻlja tutib kela boshlaydi. Avgust oxiridan boshlab yosh boʻrilar har xil mayda kemiruvchilarni tutib yeya boshlaydi. Sentabrda kattalari bilan birgalashib, uy hayvonlarini va yovvoyi hayvonlarni ov qilishga oʻrganadi. Noyab.ga qadar 10—15 ta buri gala boʻlib yuradi. Oʻlja topish qiyin boʻlib qolganda bitta yoki ikkitadan boʻlib, tarqalib ketadi. Erkagi 2 yoshida, urgʻochisi 2—3 yoshida voyaga yetadi. Bo’rilar 15—16 yil yashaydi. Yilda ikki marta — bahor va kuzda tullaydi. Boʻrilar kuchli, chidamli va chaqqon, hid bilish va eshitish organlari yaxshi rivojlangan hayvon. Goʻsht bilan oziqlanadi, baʼzan olma, qovun, tarvuz kabi mevalarni ham yeydi. Asosan, uy hayvonlari va yovvoyi hayvonlar, quyon, yumronqoziq kabi kemiruvchilar, qushlar, hatto oʻlimtiklar bilan oziqlanadi. Boʻrilar juda ochkoʻz va xoʻra, ikkitasi bitta qoʻyni yeb qoʻyishi mumkin. Podaga hujum qilganda koʻp qoʻyni nobud qiladi. Bir nechta Bo’rilar birgalikda yoki tuda boʻlib ov qiladi. Quturgan va ochiqqan boʻrilar odamga ham hujum qilishi mumkin. Bo`rilarning 12 ta kenja turi bor. Oʻrta Osiyoning choʻl, dasht va past togʻlarida choʻl boʻrisi, Pomir togʻlarida tibet boʻrisi kenja turlari yashaydi. Baʼzan qora boʻrilar ham uchraydi, uning terisi qimmatbaho hisoblanadi.",
                   Image1= Resources.bori,
                   Image2 = Resources.bori2,
               },

               new Animal
               {
                   Name = "Burgut",
                   Description = "Burgut — yirtqichlar turkumining qirgʻiylar oilasiga mansub qush. Burgut yirik, chaqqon va kuchli. Tanasining uz. 95 sm gacha. Qanoti 62—72 sm, yoyganda 2 m ga yetadi. Orqa oyogʻi barmogʻidagi tirnogʻining 4,2 sm dan uzunroq boʻlishi oʻziga xos belgilaridandir. Pat rangi toʻq qoʻngʻir, boshi malla. Burgut Yevropa, Osiyo va Shimoliy Amerikada keng tarqalgan. Oʻrta Osiyoda oʻtroq yashandi. Togʻ va choʻllarning odam yashamaydigan uzoq joylarida, qoyalar orasida, saksovulzorlarda uchraydi. Togʻ, choʻl va suv Burguti boʻladi. Burgut monogam qush. Nari bilan modasi doim birga boʻladi. Biri oʻlsagina ikkinchisi oʻziga boshqa sherik axtaradi. Uyasini odam chiqa olmaydigan yerlarga xaschoʻp va lattaputtalardan quradi. Odatda, bir-biriga yaqin 2—3 uyasi boʻlib, bittasidan foydalanadi. Xira oq va qoʻngʻir xollar bilan qoplangan 1—2 ta tuxum qoʻyadi. Joʻjasini boqishda nari ham ishtirok etadi. Burgut parrandalar (kaklik, dudoq), yumronqoziq, toshbaqa, quyon va boshqa hayvonlar bilan oziqlanadi. Burgut joʻjasini uyadayoq ovga oʻrgata boshlaydi. Oʻrta Osiyoda Burgutning yosh joʻjasini qoʻlga oʻrgatishadi. Voyaga yetganida uni quyon, tulki va hatto boʻri oviga olib chiqishadi. Burgut oʻljasini uzoqdan yaxshi koʻradi va tez uchib borib unga tashlanadi. Kemiruvchilarni qirib, qishloq xoʻjaligi ga foyda keltiradi. Burgut Oʻzbekiston va boshqa davlatlar Qizil kitobiga kiritilgan.",
                   Image1= Resources.burgut,
                   Image2 = Resources.burgut2,
               },

               new Animal
               {
                   Name = "Ayiq",
                   Description = "Ayiqlar  – yirtqichlar turkumiga mansub sut emizuvchilar oilasi. Eng yirik yirtqichlar, boshi katta, bo‘yni qisqa va yo‘g‘on. Panjalari kuchli rivojlangan, tovonida yuradi. Dumi kalta, kalin juni orasida deyarli sezilmaydi. Ko‘pchilik Ayiqlar o‘simlik xo‘r yoki aralash oziqlanadi. Ayiqlar odamga tegmaydi. Faqat oziq tanqis bo‘lganida, keksa va yarador ayiqlar odam uchun xavfli hisoblanadi. Oq ayiq esa haqiqiy yirtqich bo‘lib, odam uchun xavfli. Oq ayiq— ayiqsimonlar oilasiga mansub sut emizuvchi. Baʼzan alohida Thalarctos urugʻiga ajratiladi. Gavdasininguz. 2— 2,5 m, baʼzan 3 m gacha, balandligi (yagʻrinidan) 1,5 m gacha, vazni 800 kg gacha. Yungi oq, baʼzan limon yoki kulrang tusda. Tovoni va panjalarining osti yung bilan qoplangan. Arktika faunasining tipik vakili, suzuvchi muzliklar va Shim. Muz okeani sohalari yaqinida yashaydi. Yaxshi suzadi va shoʻngʻiydi. Asosiy ozigʻi — tyulenlar." + 
                        "\nPast haroratga yaxshi moslashgan, gavdasi massasining  40 % ini yogʻ tashkil etadi. Atrof muhit harorati —50° gacha pasayganida ham tanasidagi gaz almashinuvi kuchaymaydi, yaʼni termoregulyasiya uchun qoʻshimcha energiya sarflamaydi. Mart—aprel oylarida urchiydi. Urgʻochisi 2 yilda 1 marta, 1—3 ta koʻzi yumuq bola tugʻadi. Boʻgʻoz urgʻochisi qor ostidagi inida qishki uyquga ketadi va faqat mart—aprel oylarida bolalari bilan inidan chiqadi va kezib hayot kechiradi. Bolalari 1,5 yilgacha onasiga ergashib yuradi. Oq ayiqni terisi va goʻshti uchun koʻp ovlanadi. 1956-yildan ovlash man qilingan. 1976-yildan xalqaro muhofazaga olingan, Xalqaro va RF Qizil kitoblariga kiritilgan.",
                   Image1= Resources.ayiq,
                   Image2 = Resources.ayiq2,
               },

               new Animal
               {
                   Name = "Yo'lbars",
                   Description = "Yoʻlbars— mushuksimonlar oilasiga mansub sut emizuvchi hayvon. Shu oilaning eng yirik vakili. Tanasining uzunligi 160—290 sm (baʼzan 3 m dan ortiq), dumi 114 sm gacha, vazni 390 kg gacha. Boshi yumaloq, mallarang , tanasining orqa va yon tomonlarida koʻndalang qora yoʻllari boʻladi. 7 ta kenja turi maʼlum. Gʻarbiy va Janubi-Sharqiy Osiyo hamda Hindiston yarim orolida tarqalgan. Rossiyaning Primorye oʻlkasida uchraydi. XX-asrning 30-yilgacha Kavkaz ortida, 50-yil gacha Amudaryoning quyi oqimida uchragan. Yo`lbarslar -20 asr boshlarigacha Chirchiq havzasida ham yashagan. Yo`lbarslar, asosan, toʻqaylar, qalin qamishzor va togʻ oʻrmonlarida yashaydi. Ular yovvoyi tuyoqli hayvonlar, jumladan, toʻngʻizlarni ovlaydi, odamxoʻr Yo`lbarslar kamdan-kam uchraydi. 2—3 yilda bir marta bolalaydi, homiladorlik davri 98—112 kun, 2—6 ta bola tugʻadi, 5—6 oy emizadi. Bolalari 1—2 yoshida mustaqil yashay boshlaydi. Soni juda kamayib ketgan, barcha kenja turlari Xalqaro Qizil kitobga kiritilgan.",
                   Image1 = Resources.yolbars,
                   Image2 = Resources.yolbars2,
               },

               new Animal
               {
                   Name = "Tulki",
                   Description = "Tulkilar — boʻrisimonlar oilasiga mansub sut emizuvchilar urugʻi. Tanasining uzunligi  40—90 sm, dumi 60 sm. Tanasi choʻziq, oyoklari nisbatan kalta. Uzun dumidagi moʻynasi baroq. Juni sariqdan to kumushqizgʻish (deyarli qoramtir) tusgacha. Tulkilarda mavsumiy va geografik dimorfizm kuchli namoyon boʻladi. 6— 11 turi maʼlum. Yevrosiyo, Afrika, Shimoliy Amerikada tarqalgan. Avstraliyaga ham olib kelingan. Oʻzbekistonda 2 turi (oddiy tulki, korsak) uchraydi. Ularning oziqlanish va yashash joyi xilmaxil: oʻrmontundradan boshlab sahro mintaqasigacha. In quradi. Asosan, kemiruvchilar, sut emizuvchilar va qushlar bilan oziqlanadi. Odatda, 4—6 ta, baʼzan 17 tagacha bola tugʻadi. Eng yirik vakili oddiy tulki. Tanasining uzuzunligi 90 sm gacha, dumi 60 sm gacha. Kechqurun qorongʻi tushishdan oldin faol boʻladi. Moʻynasi moʻyna sanoatining asosiy xom ashyosi hisoblanadi. Tulkilarning qoramtir rangli moʻynasi ayniqsa yuqori baholanadi. Tulkilar ovchilik va parrandachilik xoʻjaliklariga birmuncha ziyon yetkazadi. Ular kemiruvchi zararkunandalar sonini kamaytirib, qishloq xoʻjaligi va tibbiyotga katta foyda keltiradi.",
                   Image1= Resources.tulki,
                   Image2 = Resources.tulki2,
               },

               new Animal
               {
                   Name = "Chayon",
                   Description = "Chayonlar — oʻrgimchaksimonlar turkumi, baʼzan mustaqil sinf sifatida qaraladi. Uzunligi 1—20 sm. Boshkoʻkragi yaxlit qalqon bilan qoplangan. Bu qalqon oʻrtasida 2 juft, uning 2 yonida bir necha juft koʻzlari bor. Kutikulasi mum qavati bilan qoplangan. Korin qismi kengaygan. Ingichka keyingi boʻlimi boshkoʻkrak tomoniga egiluvchan. Bir juft zahar bezi keyingi qorinning oxirgi boʻgʻimida joylashgan boʻlib, sanchuvchi nashtarga ochiladi. Xelitseralari mayda, qiskichsimon. Oyoq paypaslagichlari uchki kismi yirik qisqichga aylangan. Oʻpka orqali nafas oladi. Spermatoforlar yordamida urugʻlanadi. Chayonlar tirik tugʻadi. 750 ga yakin turi mavjud. Jumladan, Oʻzbekistonda bir necha turi bor. Chipor (sariq) Chayon koʻp uchraydi. Yirtkich, tunda ov qiladi. Chaqqanida qattiq ogʻriydi. Ammo chayon chaqishi o'limga olib kelmaydi.",
                   Image1 = Resources.chayon,
                   Image2 = Resources.chayon2,
               },

               new Animal
               {
                   Name = "Boyqush",
                   Description = "Boyoʻgʻlilar (boyqushlar)— yapaloqqushlar oilasiga mansub tungi yirtqich qushlar urugʻi. Yevropa, Osiyo, Amerika va Afrikada tarqalgan, 20 tacha turi bor. Oʻzbekistonda bir turi — uy boyoʻgʻlisi uchraydi. Oyoqlari kuchli va paxmoq, tumshugʻi qayrilgan, pati mayin, tovushsiz uchib kelib, oʻljasini tutib oladi. Koʻzlari oʻtkirligidan salgina yorugʻni ham sezadi. Xira kulrang pati qorongʻida koʻzga chalinmaydi. Boyoʻgʻlilarning bu turi Yevropa, Shimoliy Afrika, Osiyoda ham tarqalgan. Uni dasht va choʻllarda, haroba va qabristonlarda uchratish mumkin. Nari bilan modasi fakat urchish davrida birga yashaydi. Bahorda (urchiydigan vaqtda) kechalari, baʼzan kunduzi ham sayraydi. Ovozi yigʻlagan bolaning tovushini eslatadi. Uyasini turli kovaklarga quradi. 4—9 ta tuxum qoʻyadi. Tuxumdan bir oyda joʻja chiqadi. Boyoʻgʻlilar mayda kemiruvchilar, kaltakesaklar, hasharotlar va kichik qushlar bilan oziklanadi. Zararkunanda kemiruvchilarni qirib, xoʻjalikka foyda keltiradi.",
                   Image1 = Resources.boyqush,
                   Image2 = Resources.boyqush2,
               },

               new Animal
               {
                   Name = "Sirtlon",
                   Description = "Sirtlonlar— yirtqichlar turkumiga mansub sut emizuvchilar oilasi. Tashqi koʻrinishi buriga oʻxshaydi. Gavdasining uzunligi 55—165 sm. Oldingi oyoklari orqadagisiga nisbatan uzunroq. Oyoqlari 4 barmokli, boʻyni yoʻgʻon, boshi katta, tishlari yirik. Dumi pahmoq, kalta (uzunligi 20—22 sm). Koʻpchiligining boʻyni ustida va qisman yagʻrinida uzun yungi (yoli) boʻladi. Qoʻngʻir yoki kulrangtusli yungi yoʻl-yoʻl yoki xoldor. Afrika, Old va Oʻrta Osiyo, Janubi-Gʻarbiy Osiyoda tarkalgan. Oʻzbekiston janubida (Surxondaryo viloyati) yoʻl-yoʻl sirtlon 20-asr oʻrtalarigacha uchragan. Sirtloblar yarim choʻl va choʻlda yashaydi, kechasi ov qiladi. Yakka yoki juft-juft boʻlib yuradi. Yiliga 1 marta 2—4, baʼzan 6 tadan bolalaydi. Hayvonlar murdasi bilan oziqlanadi. Guruh boʻlib birmuncha yirik tuyoqli hayvonlar (antilopalar), baʼzan uy hayvonlariga ham hujum qiladi. 1 turi va 1 kenja turi Xalqaro Qizil kitobga kiritilgan.",
                   Image1 = Resources.sirtlon,
                   Image2 = Resources.sirtlon2,
               },

               new Animal
               {
                   Name = "Qoplon",
                   Description = "Qoplon, qor qoploni, irbis — mushuksimonlar oilasiga mansub sut emizuvchi; urugʻning yagona turi. Baʼzan yirik mushuksimonlar urugʻiga kiritiladi. Gavdasining uz. 103—130 sm, ogʻirligi 70 kg gacha. Tanasi choʻziq, oyoqlari qisqa. Moʻynasi qalin, sargʻish tusda, qora halqa dogʻlari bor. Asosan, Markaziy va Oʻrta Osiyodagi baland togʻlarda, odatda, 2000 m dan balandroqda doimiy qorli togʻ tizmalarida uchraydi. Qishda pastroqqa — ninabargli oʻrmonlar mintaqasigacha tushadi. Oʻrta Osiyoda jan.-gʻarbiy Turkiston va tojikistonning jan. dagi togʻlarda yashaydi. Aksariyat kechqurunlari ov qiladi. 4—5 ta, koʻpincha 2—3 ta bola tugʻadi. Asosan, tuyoqlilar, quyonlar, sugʻurlar va b. ni ovlaydi. Soni keskin kamayib ketgan. Xalqaro Qizil kitobga kiritilgan.",
                   Image1 = Resources.qoplon,
                   Image2 = Resources.qoplon2,
               },

               new Animal
               {
                   Name = "Anakonda iloni",
                   Description = "Anakondalar– boʻgʻma ilonlar urugʻi. Hozirgi ilonlarning eng yirigi – uzunligi 10 m gacha (qayd qilingan uzunligi 11,43 m). Sargʻish-kulrang tanasi orqa tomondan 2 qator yirik doira shakli-dagi qoʻngʻir, yon tomonlardan bir necha qator mayda oqish dogʻlar bilan qoplangan. 3 turi tropik. Janubiy Amerikaning daryo, koʻl va botqoqliklarida tarqalgan. Oddiy Anakondalar kuproq uchraydi. Anakondalar suvda yaxshi suzadi va shoʻngʻiydi, suv tubida uzoq tura oladi. Suv ostida burun teshiklari klapanlari bekiladi. Anakondalar har xil mayda umurtqalilar (kemiruvchilar, tuyoqlilar, toshbaqalar, qushlar, yosh timsohlar), ba’zan uy hayvonlari bilan oziqlanadi, kamdan-kam odamga hujum qiladi. Qurgʻoqchilik mavsumida balchiqqa koʻmilib karaxt boʻlib oladi. Tuxumdan tirik tugʻish (ba’zan tuxum qoʻyish) orqali koʻpayadi. 28dan 42 tagacha tuxum qoʻyadi. Tuxumlardan darhol yosh ilonlar chiqib, suvga tushib ketadi. Anakondalar tutqinlikda 28 yilgacha (oʻrta hisobda 5–6 yil) yashaydi. Terisi, goʻshti va yogʻi uchun ovlanadi.",
                   Image1 = Resources.anakonda,
                   Image2 = Resources.anakonda2,
               },

               new Animal
               {
                   Name = "Meduza",
                   Description = "Meduzalar — boʻshliqichlilarning , koʻpincha, erkin yashovchi jinsiy avlodi. Gavdasi xira shaffof (mezogliysi kuchli rivojlanganligi tufayli), soyabon yoki qoʻngʻiroq shaklda, diametri bir necha mm dan 2–3 m gacha. Soyaboni chetlarida paypaslagichlari (uzunligi 30 sm gacha) va sezgi organlari joylashgan. Ogʻzi soyabonining ostki botiq tomoni oʻrtasida boʻlib, odatda, ogʻiz parraklari bilan oʻralgan. Meduzalar  soyaboni ostida suvni siqib chiqarishi tufayli reaktiv usulda harakatlanadi. Ayrim ssifomeduzalar (stavromeduzalar) suv tubida biron substratga yopishib yashaydi. Meduzalar suv tubida yopishib yashaydigan gidroid poliplar (boʻshliqichlilarning jinssiz koʻpayadigan avlodi)dan kurtaklanish tufayli hosil boʻladi. Meduzalar ssifoidlar va koʻpchilik gidropoliplar uchun xos. Gidralar, ayrim dengiz gidropolishtari va korall poliplar Meduzalarni hosil qilmaydi. Traxilidlar va pelagiylarda nayel gallanishi boʻlmaydi. Meduzalar  tuxumdan hosil boʻladi. Meduzalarning jinsiy bezlari oshqozoni yaqinida yoki oshqozondan boshlanadigan gastrovaskulyar sistemaning radial naylarida joylashgan. Gidromeduzalarda jinsiy bezlar ektodermada, ssifomeduzalarda endodermada boʻladi. Meduzalar  jinsiy yoʻl bilan koʻpayadi, jinsiy hujayralar (tuxum va urugʻlar) suvga chiqariladi, suvda urugʻlanish roʻy beradi. Faqat ssi-fomeduzalar tuxum hujayralari ona organizmda urugʻlanib, ulardan planula lichinkasi chiqadi. Ayrim Meduzalarning otuvchi hujayralari kuydirish xususiyatiga ega boʻlgani uchun ular zaharli Meduzalarga kiritiladi.",
                   Image1 = Resources.meduza,
                   Image2 = Resources.meduza2,
               },

               new Animal
               {
                   Name = "Yaguar",
                   Description = "Yaguar — katta mushuklar urugʻiga mansub yirtqich sut emizuvchi. Gavdasining uz. 2 m gacha, dumi 75 sm gacha. Jussasining koʻrinishi yoʻlbarsga oʻxshash; qizgʻish yungida qora dogʻlari va halqalari boʻladi. Janubiy, Markaziy Amerika va Shim. Amerikaning janubida tarqalgan. Tropik va subtropik oʻrmonlarda, ahyonahyonda togʻlarda uchraydi. Daraxtlarga chiqa oladi. Tuyoqlilar, maymunlar va kemiruvchilar bilan oziklanadi. Soni kamayib ketgan. Tabiatni muhofaza qilish xalqaro ittifoqi Qizil kitobiga kiritilgan.",
                   Image1 = Resources.yaguar,
                   Image2 = Resources.yaguar2,
               },

               new Animal
               {
                   Name = "Begemot",
                   Description = "Begemotlar ,suv aygʻirlari— juft tuyoqlilar turkumiga mansub kavsh qaytarmaydigan sut emizuvchilar. Terisi qalin, siyrak yung bilan qoplangan, oyoqlari kalta, tushmugʻining uchki qismi kengaygan, oshqozoni 3 boʻlmali, pastki kurak va qoziq tishlari doim oʻsib turadi. Afrikaning tinch oqadigan va botqoklashgan suv havzalarida yashaydi. Bitta bola tugʻadi. 2 urugʻining bittadan turi bor. Odsiy suv aygʻiri, yaʼni gippopotam  gavdasining uzunligi 4,0—4,5 metr, dumi 35—50 sm. vazni 1,3—3,2 (baʼzan 4,5) tonna. Boshi katta, koʻzlari boʻrtib chiqib turadi. Tana tuzilishi va hayoti suvda yashashga moslashgan. Koʻzi, qulogʻi va burnini suvdan chiqarib, uzoq vaqt suvda turishi mumkin. Kechasi suvdan chiqib oziqlanadi. Poda boʻlib yuradi; 40— 50 yil yashaydi. Pakana Suv aygʻirlari uzunligi 170— 175 sm, dumi 15—17 sm, vazni 250– 275 kg. Tanasi bochkasimon, past boʻyli, boshi nisbatan kichik va kalta. Yakka yoki juft boʻlib yuradi. 35 yilga yaqin yashaydi, soni kamayib ketgan. Suv aygʻirlarini ov qilish man etilgan. Pakana Suv aygʻirlari Xalqaro Qizil kitobga kiritilgan.",
                   Image1 = Resources.begemot,
                   Image2 = Resources.begemot2,
               },

               new Animal
               {
                   Name = "Echkiemar",
                   Description = "Echkemarlar — kaltakesaklar kenja turkumiga mansub sudralib yuruvchilar oilasi. Hozir yashab turgan bir urugʻi (Varanus) mavjud. Tanasi choʻziq, oyoqlari yaxshi rivojlangan, dumi koʻpchilik turlarida yon tomondan siqilgan. Boshi mayda qalqonchalar bilan qoplangan. Tanasidagi tangachalar yumaloq, botiq. Tili uzun, uchi ikki ayrili. 24 turi bor. Sharqiy yarim shardagi tropik, subtropik va qisman moʻʼtadil mintaqalarda tarqalgan. Madagaskarda uchramaydi. Odatda, ochiq yerlarda, daryo va boshqalar chuchuk suv havzalari qirgʻogʻida yashaydi. Yaxshi suzadi va shoʻngʻiydi. Tez yuguradi. Echkiemarlar — eng yirik kaltakesaklardir. Pleyston davrida yashagan qazilma ajdodlarining uzunligi 10 metrgacha boʻlgan." + 
                        "Echkiemarlar — yirtqich. Kaltakesaklar, ilonlar, mayda sut emizuvchilar, suvda yashaydiganlari esa, asosan, baqalar, baliqlar, qisqichbaqalar, mollyuskalar va boshqalar hayvonlar bilan oziqlanadi. Kulrang Echkiemarlar choʻllarda yashaydi. Turkmaniston, Oʻzbekiston, Tojikiston va Qozogʻistonning janubiy qismida tarqalgan. Uzunligi 1,5 m gacha. Boshqa hayvonlarning inlarida yashaydi, kamdankam oʻzi in qaziydi. Uch yoshida jinsiy yetiladi. Urgʻochisi 10—23 ta tuxum qoʻyadi. Oʻzbekiston Respublikasi va Oʻrta Osiyo davlatlari Qizil kitobiga kiritilgan.",
                   Image1 = Resources.echkiemar,
                   Image2 = Resources.echkiemar2,
               },
            };
        }

        public Animal GetAnimal(string Name)
        {
            return animals.FirstOrDefault(a => a.Name == Name);
        }
    }
}
