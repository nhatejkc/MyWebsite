using MyWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MyWebsite.Core
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<MyWebsiteDbContext>
    {
        protected override void Seed(MyWebsiteDbContext context)
        {
            SeedData(context);
            base.Seed(context);
        }

        private static void SeedData(MyWebsiteDbContext context)
        {
            #region Add Actor
            var actors = new List<Actor>()
            {
                new Actor()
                {
                    ENName = "Anna",
                    JPName = "アンナ",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
               new Actor()
                {
                    ENName = "Sakura",
                    JPName = "さくら",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Actor()
                {
                    ENName = "Dormitory manager",
                    JPName = "寮母",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Actor()
                {
                    ENName = "Salesman",
                    JPName = "店員",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Actor()
                {
                    ENName = "Teacher",
                    JPName = "先生",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Actor()
                {
                    ENName = "Student",
                    JPName = "学生",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Actor()
                {
                    ENName = "Rodrigo",
                    JPName = "ロドリゴ",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Actor()
                {
                    ENName = "Kenta",
                    JPName = "健太",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Actor()
                {
                    ENName = "Grandmother",
                    JPName = "おばあさん",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Actor()
                {
                    ENName = "Driver",
                    JPName = "運転手",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Actor()
                {
                    ENName = "Doctor",
                    JPName = "医者",
                    PostOn=DateTime.Now,
                    Modifie=null
                }
            };
            actors.ForEach(s => context.Actors.Add(s));
            context.SaveChanges();
            #endregion

            #region Add Lession
            var lessions = new List<Lession>()
            {
                new Lession()
                {

                    LessionShortDescription="Chị Anna là một du học sinh người Thái Lan. Hôm nay, chị Anna lần đầu tiên gặp chị Sakura, sinh viên hướng dẫn chị tại trường.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/01-vi-le_03.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le1_v_scall.mp3",
                    MainConent="わしわアンナデス(WATASHI WA ANNA DESU)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna, một du học sinh người Thái Lan, đã gặp chị Sakura, người hướng dẫn và cũng là sinh viên học cùng trường. Hai chị tự giới thiệu bản thân với nhau. Chị Anna đưa một vật cho chị Sakura",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/02-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le2_v_scall.mp3",
                    MainConent="これは何ですか(KORE WA NAN DESU KA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Hôm nay, chị Sakura dẫn chị Anna đi quanh trường đại học.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/03-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le3_v_scall.mp3",
                    MainConent="トイレはどこですか(TOIRE WA DOKO DESU KA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Hôm nay chị Anna dẫn chị Sakura về kí túc xá nơi chị ở. Người quản lý kí túc xá ra chào họ. Bà là người chăm nom các sinh viên ở kí túc xá, và gần như là một người mẹ của họ",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/04-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le4_v_scall.mp3",
                    MainConent="ただいま(TADAIMA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna mời chị Sakura, người hướng dẫn của mình, tới thăm phòng kí túc xá. Chị Sakura phát hiện thấy một cái gì đó",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/05-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le5_v_scall.mp3",
                    MainConent="それは私の宝物です。私は毎日マンガを読みます(SORE WA WATASHI NO TAKARAMONO DESU)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna va chị Sakura tiếp tục trò chuyện trong phòng chị Anna. Chị Sakura muốn hỏi chị Anna số điện thoại của chị Anna",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/06-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le6_v_scall.mp3",
                    MainConent="電話番号は何番ですか(DENWABANGÔ WA NANBAN DESU KA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna đến hiệu bánh cùng với chị Sakura",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/07-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le7_v_scall.mp3",
                    MainConent="シュークリームを２つください(SHÛKURÎMU O FUTATSU KUDASAI)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna đang ở trong lớp tiếng Nhật của Giáo sư Suzuki ở trường",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/08-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le8_v_scall.mp3",
                    MainConent="もう一度お願いします(MÔICHIDO ONEGAI SHIMASU)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Hôm nay, Giáo sư Suzuki sẽ có một thông báo trước cả lớp.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/09-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le9_v_scall.mp3",
                    MainConent="何時からですか(NANJI KARA DESU KA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Hôm nay, chị Anna có buổi khám sức khỏe tại trường đại học. Các sinh viên đã tập trung tại nơi khám sức khỏe",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/10-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le10_v_scall.mp3",
                    MainConent="全員いますか(ZEN-IN IMASU KA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Kí túc xá dành cho du học sinh nơi chị Anna sống sẽ có một bữa tiệc. Chị Anna mời chị Sakura tham dự",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/11-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le11_v_scall.mp3",
                    MainConent="ぜひ来てください(ZEHI KITE KUDASAI)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Hôm nay tại kí túc xá dành cho du học sinh mà chị Anna sống có một bữa tiệc dành cho các sinh viên người nước ngoài. Chị Anna giới thiệu anh Rodrigo, bạn cùng lớp người Mexico với chị Sakura",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/12-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le12_v_scall.mp3",
                    MainConent="いつ日本に来ましたか(ITSU NIHON NI KIMASHITA KA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Sakura và anh Rodrigo tiếp tục trò chuyện tại bữa tiệc tổ chức ở kí túc xá của sinh viên nước ngoài",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/13-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le13_v_scall.mp3",
                    MainConent="小説が好きです(SHÔSETSU GA SUKI DESU)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Anna dọn dẹp mọi thứ sau bữa tiệc tại kí túc xá.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/14-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le14_v_scall.mp3",
                    MainConent="ここにゴミを捨ててもいいですか(KOKO NI GOMI O SUTETE MO IIDESU KA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna cùng chị Sakura và anh Rodrigo đi đến hiệu sách ở Shinjuku. Tàu chở họ đang chuẩn bị tới ga Shinjuku",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/15-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le15_v_scall.mp3",
                    MainConent="寝ています(NETE IMASU)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna đến một hiệu sách ở Shinjuku với những người bạn. Chị hỏi người bán hàng xem quầy bán truyện tranh ở đâu",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/16-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le16_v_scall.mp3",
                    MainConent="階段を上がって、右に行ってください(KAIDAN O AGATTE, MIGI NI ITTE KUDASAI)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Tại hiệu sách, chị Anna tìm thấy rất nhiều cuốn truyện tranh trông có vẻ hay. Chị không quyết định được là nên mua cuốn nào.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/17-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le17_v_scall.mp3",
                    MainConent="おすすめは何ですか(OSUSUME WA NAN DESU KA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna đến hiệu sách với chị Sakura và anh Rodrigo. Sau khi cả 3 rời hiệu sách, chị Anna lạc mất 2 người bạn của mình.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/18-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le18_v_scall.mp3",
                    MainConent="道に迷ってしまいました(MICHI NI MAYOTTE SHIMAIMASHITA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna lạc mất những người bạn của mình và gọi điện nhờ chị Sakura giúp đỡ. Liệu chị Anna có gặp được chị Sakura và anh Rodrigo không?",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/19-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le19_v_scall.mp3",
                    MainConent="よかった(YOKATTA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna và bạn bè đến hát tại quán karaoke.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/20-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le20_v_scall.mp3",
                    MainConent="日本の歌を歌ったことがありますか(NIHON NO UTA O UTATTA KOTO GA ARIMASU KA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Khi ở quán Karaoke, chị Anna hát một bài hát của Nhật Bản. Chị Sakura khen chị Anna hát hay.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/21-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le21_v_scall.mp3",
                    MainConent="いいえ、それほどでも(IIE, SOREHODODEMO)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna và bạn bè đi hát Karaoke rất vui vẻ nên đã về muộn hơn giờ đóng cửa kí túc xá.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/22-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le22_v_scall.mp3",
                    MainConent="遅くなりました(OSOKU NARIMASHITA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna và chị Sakura đang nói chuyện với nhau ở trường. Chị Sakura hỏi thăm chị Anna về tình hình hôm đi về muộn",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/23-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le23_v_scall.mp3",
                    MainConent="お母さんに叱られました(OKÂSAN NI SHIKARAREMASHITA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna đang trong lớp học tiếng Nhật của Giáo sư Suzuki. Giáo sư giải thích về bài kiểm tra vào tuần tới.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/24-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le24_v_scall.mp3",
                    MainConent="使わないでください(TSUKAWANAIDE KUDASAI)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Khi chị Anna đang trong lớp tiếng Nhật của Giáo sư Suzuki thì tòa nhà bắt đầu rung lắc",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/25-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le25_v_scall.mp3",
                    MainConent="机の下に入れ(TSUKUE NO SHITA NI HAIRE)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Hôm nay, chị Anna nhận được kết quả bài kiểm tra tiếng Nhật. Sau giờ học, chị thấy bạn cùng lớp của mình là anh Rodrigo đứng ủ rũ ở một chỗ.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/26-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le26_v_scall.mp3",
                    MainConent="次はがんばろう(TSUGI WA GANBARÔ)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna đến thăm nhà chị Sakura. Chị Sakura đưa cho chị xem một thiệp mời đám cưới.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/27-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le27_v_scall.mp3",
                    MainConent="誰が結婚するんですか(DARE GA KEKKON SURU N DESU KA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna đến thành phố Shizuoka với chị Sakura. Anh Kenta, em họ chị Sakura, ra ga đón họ.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/28-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le28_v_scall.mp3",
                    MainConent="静岡へようこそ(SHIZUOKA E YÔKOSO)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna đến thăm thành phố Shizuoka, quê hương chị Sakura. Hôm nay, chị được anh Kenta, em họ chị Sakura, đưa đến điểm có thể ngắm nhìn cảnh quan hùng vĩ của núi Phú Sĩ",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/29-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le29_v_scall.mp3",
                    MainConent="近くで見ると、大きいですね(CHIKAKU DE MIRU TO, ÔKII DESU NE)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna đang chụp ảnh núi Phú Sĩ với chị Sakura và anh Kenta thì trời đổ mưa.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/30-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le30_v_scall.mp3",
                    MainConent="もう少し写真を撮りたいです(MÔ SUKOSHI SHASHIN O TORITAI DESU)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna đến thăm nhà bà của chị Sakura ở thành phố Shizuoka. Bà còn rất khỏe mạnh. Bà sống một mình và ngày ngày chăm sóc vườn rau.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/31-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le31_v_scall.mp3",
                    MainConent="もう８２歳ですよ(MÔ HACHIJÛNI SAI DESU YO)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna sẽ ngủ lại nhà bà của chị Sakura. Đây là lần đầu tiên chị Anna nằm ngủ trên đệm futon, một loại đệm của Nhật Bản.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/32-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le32_v_scall.mp3",
                    MainConent="布団のほうが好きです(FUTON NO HÔ GA SUKI DESU)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna đến lễ hội ở trường đại học cùng với em họ của chị Sakura là anh Kenta. Họ đang đi xem triển lãm của Câu lạc bộ Nhiếp ảnh.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/33-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le33_v_scall.mp3",
                    MainConent="アンナさんにあげます(ANNA-SAN NI AGEMASU)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Sau khi chị Anna đến lễ hội ở trường đại học với anh Kenta, cả 2 cùng đến hiệu sushi băng chuyền",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/34-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le34_v_scall.mp3",
                    MainConent="やわらかくておいしいです(YAWARAKAKUTE OISHII DESU)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna cùng với anh Kenta thưởng thức sushi tươi ngon tại quán sushi băng chuyền",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/35-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le35_v_scall.mp3",
                    MainConent="クレジットカードは使えますか(KUREJITTO KÂDO WA TSUKAEMASU KA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Sau những ngày đi chơi vui vẻ ở Shizuoka, chị Anna và chị Sakura chuẩn bị trở về Tokyo. Anh Kenta ra ga tiễn họ.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/36-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le36_v_scall.mp3",
                    MainConent="勉強しなければなりません(BENKYÔ SHINAKEREBA NARIMASEN)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Sau chuyến đi chơi, chị Anna từ Shizuoka về kí túc xá ở Tokyo. Chị nói chuyện với người quản lí kí túc xá về chuyến đi.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/37-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le37_v_scall.mp3",
                    MainConent="富士山を見たり、おすしを食べたりしました(FUJISAN O MITARI, OSUSHI O TABETARI SHIMASHITA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Sáng nay khi thức dậy, chị Anna thấy mệt lử và bị sốt. Người quản lí kí túc xá đưa chị đến bệnh viện bằng taxi.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/38-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le38_v_scall.mp3",
                    MainConent="かしこまりました(KASHIKOMARIMASHITA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna không được khỏe và đã được người quản lí kí túc xá đưa đến bệnh viện để bác sĩ khám.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/39-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le39_v_scall.mp3",
                    MainConent="かぜだと思います(KAZE DA TO OMOIMASU)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna bị cảm lạnh và đang nằm trong phòng. Người quản lí kí túc xá lo lắng vào hỏi thăm sức khỏe của chị.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/40-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le40_v_scall.mp3",
                    MainConent="頭がずきずきします(ATAMA GA ZUKIZUKI SHIMASU)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna đã hết cảm lạnh và khỏe lại. Hôm nay, chị viết email để cảm ơn anh Kenta, người đã đưa chị đi chơi quanh Shizuoka.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/41-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le41_v_scall.mp3",
                    MainConent="学園祭に行くことができて、楽しかったです(KGAKUEN-SAI NI IKU KOTO GA DEKITE, TANOSHIKATTA DESU)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Hôm nay, chị Anna tham gia chuyến tham quan học tập của trường. Chị chuẩn bị mua cơm hộp từ dịch vụ ăn uống trên tàu cao tốc Shinkansen.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/42-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le42_v_scall.mp3",
                    MainConent="どれがいちばんおいしいかな(DORE GA ICHIBAN OISHII KANA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Chị Anna đang trong chuyến tham quan học tập của trường đại học. Hôm nay, chị đến thăm Thành Himeji ở tỉnh Hyogo",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/43-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le43_v_scall.mp3",
                    MainConent="どうしてでしょうか(DÔSHITE DESHÔ KA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Sau khi đến thăm thành Himeji, chị Anna tham dự một buổi lễ trà đạo tại một trà thất ở gần đó",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/44-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le44_v_scall.mp3",
                    MainConent="和菓子を食べてから、抹茶を飲みます(WAGASHI O TABETE KARA, MACCHA O NOMIMASU.)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="CHôm nay là sinh nhật chị Anna. Bạn bè tổ chức mừng sinh nhật chị tại một nhà hàng.",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/45-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le45_v_scall.mp3",
                    MainConent="お誕生日おめでとう(OTANJÔBI OMEDETÔ)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Sau bữa tiệc sinh nhật của chị Anna, anh Kenta đề nghị được đưa chị về kí túc xá. Khi họ bắt đầu đi thì tuyết rơi",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/46-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le46_v_scall.mp3",
                    MainConent="帰国する前に、雪を見ることができて幸せです(KIKOKU SURU MAE NI, YUKI O MIRU KOTO GA DEKITE SHIAWASE DESU)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Một năm du học của chị Anna chuẩn bị kết thúc. Hôm nay, chị tham dự tiết học cuối cùng tại trường đại học",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/47-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le47_v_scall.mp3",
                    MainConent="日本語教師になるのが夢です(NIHONGO-KYÔSHI NI NARU NO GA YUME DESU)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new Lession()
                {

                    LessionShortDescription="Hôm nay, chị Anna chuẩn bị trở về Thái Lan. Chị Sakura và anh Kenta ra sân bay tiễn chị",
                    SoundLession="https://www.nhk.or.jp/lesson/vietnamese/learn/mp3/48-vi-le_01.mp3",
                    Sound="https://www.nhk.or.jp/lesson/update/mp3/le48_v_scall.mp3",
                    MainConent="いろいろお世話になりました(IROIRO OSEWA NI NARIMASHITA)",
                    PostOn=DateTime.Now,
                    Modifie=null
                }
            };
            lessions.ForEach(x => context.Lessions.Add(x));
            context.SaveChanges();
            #endregion

            #region Add Grammar
            var grammars = new List<Grammar>()
            {
                // lession  1
                new Grammar()
                {
                    GrammarShortDescription="A は B　です (A là B)",
                    GrammarDescription="は là trợ từ để biểu thị rằng danh từ đúng trước nó là chủ đề của câu。です đứng sau danh từ B. B thêm です thành vị ngữ.Ví dụ : 私はアンナです (Tôi là Anna)",
                    LessionId=1,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  2
                new Grammar()
                {
                    GrammarShortDescription="A の B (B của A)",
                    GrammarDescription="の là trợ từ nối hai danh từ. Trong tiếng Nhật, từ bổ nghĩa cho danh từ được đặt trước danh từ.Ví dụ : 東京のおみやげ (Món quà từ Tokyo)",
                    LessionId=2,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  3
                new Grammar()
                {
                    GrammarShortDescription="__はどこですか (_Ở đâu ạ?)",
                    GrammarDescription=" はどこですか là mẫu câu dùng để hỏi địa điểm . Ví dụ : トイレはどこですか。 (Nhà vệ sinh ở đâu ?)",
                    LessionId=3,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  4
                new Grammar()
                {
                    GrammarShortDescription="__ではありません",
                    GrammarDescription=" Để biến 1 câu kết thúc bằng です(câu khẳng định) thành câu phủ định, thì đổi です thành ではありません. Ví dụ : 日本人ではありません。 (Tôi không phải người Nhật Bản.)",
                    LessionId=4,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  5
                new Grammar()
                {
                    GrammarShortDescription="Chủ ngữ + は+ Bổ ngữ + Động từ ",
                    GrammarDescription="Thông thường, trật tự một câu tiếng Nhật là chủ ngữ, bổ ngữ, động từ. を　là trợ từ đứng sau từ chỉ đối tượng của hành động, tức là bổ ngữ.Ví dụ : 私はマンガを読みます (Tôi đọc truyện tranh)",
                    LessionId=5,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  6
                new Grammar()
                {
                    GrammarShortDescription="＿＿をします ",
                    GrammarDescription="します là động từ, có nghĩa là 'làm cái gì đó'. Khi kết hợp nó với các danh từ, có thể diễn tả nhiều hành động khác nhau .Ví dụ : 電話をします (Gọi điện thoại)",
                    LessionId=6,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  7
                new Grammar()
                {
                    GrammarShortDescription="A の B (B của A)",
                    GrammarDescription="の là trợ từ nối hai danh từ. Trong tiếng Nhật, từ bổ nghĩa cho danh từ được đặt trước danh từ.Ví dụ : 東京のおみやげ (Món quà từ Tokyo)",
                    LessionId=7,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  8
                new Grammar()
                {
                    GrammarShortDescription="Động từ thể て",
                    GrammarDescription="Khi động từ ở giữa câu, nghĩa là sau nó còn có các từ khác, thì phải chia động từ. Động từ khi chia kết thúc bằng て　được gọi là động từ thể て.Ví dụ : 覚えます->覚えて (Nhớ)",
                    LessionId=8,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  9
                new Grammar()
                {
                    GrammarShortDescription="何時 (Mấy giờ)",
                    GrammarDescription="何(nan) là mấy,時 (ji) là giờ để hỏi về giờ cụ thể.Ví dụ : 何時ですか。 (Bây giờ là mấy giờ)",
                    LessionId=9,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  10
                new Grammar()
                {
                    GrammarShortDescription="ます->ました。",
                    GrammarDescription="Để đổi các động từ thể ます sang quá khứ, đổi ます->ました.Ví dụ :食べます ->　食べました (Ăn->đã ăn)",
                    LessionId=10,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  11
                new Grammar()
                {
                    GrammarShortDescription="いきます　きます",
                    GrammarDescription="Trong tiếng Nhật, chúng ta dùng động từ khác nhau tùy thuộc vào vị trí của người nói.",
                    LessionId=11,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  12
                new Grammar()
                {
                    GrammarShortDescription="Các tháng trong năm (＿月)",
                    GrammarDescription="ichigatsu (1月), nigatsu(2月),sangatsu(3月),shigatsu(4月),gogatsu(5月),rokugatsu(6月),shichigatsu(7月),hachigatsu(8月),kugatsu(9月),jiugatsu(10月),jiuichigatsu(11月),jiunigatsu(12月) ",
                    LessionId=12,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  13
                new Grammar()
                {
                    GrammarShortDescription="A は　Ｂ　が好きです。(A thích B)",
                    GrammarDescription="好(suki) là tính từ, có nghĩa là 'thích'. が là trợ từ đứng sau từ chỉ đối tượng của một tính từ. ",
                    LessionId=13,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  13
                new Grammar()
                {
                    GrammarShortDescription="＿＿ませんか。",
                    GrammarDescription="Nếu đổi động từ thể ます　thành ませんか tức là bạn đang rủ hoặc mời ai đó làm 1 việc gì đó.Ví dụ : 皆で　ほんやに　行きませんか。（Mọi người cùng đi đến hiệu sách không?）",
                    LessionId=13,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  14
                new Grammar()
                {
                    GrammarShortDescription="＿＿から、＿＿",
                    GrammarDescription="Mệnh đề đằng trước から để chỉ nguyên nhân diễn ra mệnh đề đằng sau. Ví dụ : 缶は別の袋に入れてください。資源ですから (Hãy bỏ vỏ hộp kim loại vào một túi khác. Vì chúng là nguyên liệu có thể tái chế)",
                    LessionId=14,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  15
                new Grammar()
                {
                    GrammarShortDescription="＿＿ましょう。",
                    GrammarDescription="Nếu đổi ます thành ましょう sẽ được câu đề nghị. Chỉ có thể nói như vậy trong tình huống biết chắc người khác sẽ không từ chối lời đề nghị của mình",
                    LessionId=15,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  16
                new Grammar()
                {
                    GrammarShortDescription="Động từ thể て có thể nối các câu .",
                    GrammarDescription="Có thể dùng thể て của động từ để diễn đạt một chuỗi các hành động xảy ra nối tiếp nhau.Ví dụ : 階段を上がって、右に行ってください (Hãy đi lên cầu thang, rồi rẽ phải)",
                    LessionId=16,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  17
                new Grammar()
                {
                    GrammarShortDescription="＿＿は　ちょっと。。",
                    GrammarDescription="Đây là cách nói để từ chối một lời đề nghị một cách nhẹ nhàng, gián tiếp.Ví dụ : ホラーはちょっと… (Chuyện kinh dị thì hơi ...)",
                    LessionId=17,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  18
                new Grammar()
                {
                    GrammarShortDescription="V_て＋しまいました。",
                    GrammarDescription="しまいました- được dùng sau các động từ thể て để thể hiện đã làm việc gì đó một cách đãng trí bất cẩn.Ví dụ: 道に迷ってしまいました(Tôi bị lạc đường)",
                    LessionId=18,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  19
                new Grammar()
                {
                    GrammarShortDescription="Thể quá khứ của tính từ.",
                    GrammarDescription="Trong tiếng Nhật, tính từ có thể quá khứ. Đối với tính từ đuôi い, đổi い　ở cuối thành かった。Đối với tính từ đuôi な thêm　だった。Ví dụ : 安かった。　すきなだった。",
                    LessionId=19,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  20
                new Grammar()
                {
                    GrammarShortDescription="あります : Động từ chỉ sự sở hữu.",
                    GrammarDescription="Trong bài 7, あります nghĩa là 'có thứ gì đó', chỉ sự tồn tại. Trong bài 9, từ này nghĩa là 'có một sự kiện gì đó'. Còn ở đây thì あります có nghĩa là “có cái gì đó” như là “kinh nghiệm”.",
                    LessionId=20,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  21
                new Grammar()
                {
                    GrammarShortDescription="いいえ、それほどでも。(Không hay đến mức đó đâu ạ)",
                    GrammarDescription="いいえ nghĩa là “không”, là câu trả lời phủ định. それほどでも nghĩa là 'không được đến mức đấy'. いいえ,  それほどでも, “Không, không hay đến mức đấy đâu ạ”, là câu nói để tỏ ý khiêm tốn.",
                    LessionId=21,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  22
                new Grammar()
                {
                    GrammarShortDescription="Ｖ＿て＋はいけません",
                    GrammarDescription="Động từ thể て +　はいけません có nghĩa là 'không được làm việc gì.'",
                    LessionId=22,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  23
                new Grammar()
                {
                    GrammarShortDescription="＿＿ませんでした。",
                    GrammarDescription="Để đổi động từ ở thể ます sang thể phủ định ở quá khứ thì thay ます bằng ませんでした",
                    LessionId=23,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  24
                new Grammar()
                {
                    GrammarShortDescription="Các từ chỉ thời điểm",
                    GrammarDescription="きのう: hôm qua;　きょう: hôm nay;　あした: ngày mai;　せんしゅう: tuần trước;　こんしゅう: tuần này;　らいしゅう:tuần sau;　せんげつ:tháng trước;　こんげつ: tháng này;　らいげつ: tháng sau",
                    LessionId=24,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  25
                new Grammar()
                {
                    GrammarShortDescription="ようだ／ようです。",
                    GrammarDescription="ようだ là cách nói thân mật của　ようです, để chỉ là người nói đã đánh giá tình hình và đưa ra nhận xét về sự vật, sự việc. Trước ようだ　dùng động từ thể た",
                    LessionId=25,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  26
                new Grammar()
                {
                    GrammarShortDescription="ん　です。",
                    GrammarDescription="ん　です được dùng để giải thích một tình huống hoặc lý do. Trước ん　です phải dùng động từ ở dạng thông thường, như thể từ điển và thể た",
                    LessionId=26,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  27
                new Grammar()
                {
                    GrammarShortDescription="Ｖ＿ない＋？",
                    GrammarDescription="Khi dùng thể ない của động từ và lên giọng khi nói nghĩa là bạn đang rủ ai đó làm việc gì một cách thân mật",
                    LessionId=27,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  28
                new Grammar()
                {
                    GrammarShortDescription="＿＿へようこそ。",
                    GrammarDescription="へ là trợ từ chỉ điểm kết thúc của sự di chuyển. ようこそ là “chào mừng”.Ví dụ: 日本へようこそ. (Chào mừng anh / chị đến Nhật Bản.)",
                    LessionId=28,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  29
                new Grammar()
                {
                    GrammarShortDescription="＿＿と、＿＿",
                    GrammarDescription="Trợ từ と khi đứng sau động từ để chỉ điều kiện. Động từ đứng trước と ở thể từ điển hoặc thể ない.",
                    LessionId=29,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  30
                new Grammar()
                {
                    GrammarShortDescription="＿＿たいです",
                    GrammarDescription="Thay ます trong động từ thể ます bằng たい để thể hiện là muốn làm cái gì. Nếu thêm です sau たい, câu nói sẽ lịch sự",
                    LessionId=30,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  31
                new Grammar()
                {
                    GrammarShortDescription="A の B (B của A)",
                    GrammarDescription="の là trợ từ nối hai danh từ. Trong tiếng Nhật, từ bổ nghĩa cho danh từ được đặt trước danh từ.Ví dụ : 東京のおみやげ (Món quà từ Tokyo)",
                    LessionId=31,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  32
                new Grammar()
                {
                    GrammarShortDescription="A と B と　どちらが＋ tính từ　+ですか",
                    GrammarDescription="Khi muốn hỏi để so sánh đặc tính của A và B, dùng A と B と　どちらが, sau đó đến một tính từ, rồi cuối cùng là ですか",
                    LessionId=32,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  33
                new Grammar()
                {
                    GrammarShortDescription="あげます　＆　くれます",
                    GrammarDescription="Khi người nói cho người nghe một vật gì đó, thì người nói sẽ dùng あげます. Nếu ai đó đưa cho bạn cái gì thì bạn dùng くれます",
                    LessionId=33,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  34
                new Grammar()
                {
                    GrammarShortDescription="ってなんですか。",
                    GrammarDescription="Khi nghe được từ nào mà bạn không biết, bạn có thể hỏi ý nghĩa của từ đó bằng cách nói từ đó và thêm って なんですか.Ví dụ: トロって何ですか. (Toro là cái gì thế ạ ?)",
                    LessionId=34,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  35
                new Grammar()
                {
                    GrammarShortDescription="A の B (B của A)",
                    GrammarDescription="の là trợ từ nối hai danh từ. Trong tiếng Nhật, từ bổ nghĩa cho danh từ được đặt trước danh từ.Ví dụ : 東京のおみやげ (Món quà từ Tokyo)",
                    LessionId=35,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  36
                new Grammar()
                {
                    GrammarShortDescription="Các mùa trong năm",
                    GrammarDescription="はる:mùa xuân;　なつ:mùa hạ;　あき:mùa thu;　ふゆ:mùa đông;",
                    LessionId=36,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  37
                new Grammar()
                {
                    GrammarShortDescription="＿＿はどうだった。",
                    GrammarDescription="どう là “thế nào”. だった là cách nói thân mật của でした, dùng để kết thúc câu ở thể quá khứ.",
                    LessionId=37,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  38
                new Grammar()
                {
                    GrammarShortDescription="Kính ngữ (わかりました→かしこまりました。)",
                    GrammarDescription="Kính ngữ được dùng khi bạn đang nói chuyện với, hoặc nói về những người lớn tuổi hơn, có thâm niên/cấp bậc cao hơn, thày cô giáo, khách hàng. Ngoài ra, bạn cũng dùng kính ngữ với những người mà bạn không biết hoặc không biết rõ.",
                    LessionId=38,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  39
                new Grammar()
                {
                    GrammarShortDescription="Một số bệnh thường gặp",
                    GrammarDescription="Cách nói các triệu chứng bệnh khác nhau: あたまがいたいです. (Tôi bị đau đầu.)　はなみずがいたいです. (Tôi bị sổ mũi.)おなかがいたいです. (Tôi bị đau bụng.)",
                    LessionId=39,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  40
                new Grammar()
                {
                    GrammarShortDescription="Từ tượng thanh, tượng hình + します",
                    GrammarDescription="Ví dụ: ずきずき　します (đau nhức)。ずきずき là từ tượng hình, có thể dùng để diễn tả khi bạn bị đau đầu và cảm giác như có cái gì đập trong đầu. Nếu kết hợp với します, nghĩa là “làm”, từ này sẽ trở thành động từ.",
                    LessionId=40,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  41
                new Grammar()
                {
                    GrammarShortDescription="Động từ thể từ điển + ことができます",
                    GrammarDescription="Dùng động từ thể từ điển thêm ことができます để diễn đạt năng lực hay khả năng làm việc gì.",
                    LessionId=41,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  42
                new Grammar()
                {
                    GrammarShortDescription="どれがいちばん＿＿ですか。",
                    GrammarDescription="Để đặt câu hỏi với từ いちばん, “nhất, số một”, bạn dùng các đại từ nghi vấn khác nhau trước いちばん, tùy vào việc muốn so sánh cái gì.",
                    LessionId=42,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  43
                new Grammar()
                {
                    GrammarShortDescription="どうしてでしょうか。（Tại sao lại như vậy）",
                    GrammarDescription="どうして là “tại sao”. Khi hỏi một cách trang trọng thì dùng なぜ. Ví dụ: なぜ でしょうか.",
                    LessionId=43,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  44
                new Grammar()
                {
                    GrammarShortDescription="__かもしれません。",
                    GrammarDescription="かもしれません nghĩa là “có thể”.Ví dụ:  にがいかもしれません. (Nó có thể đắng.)",
                    LessionId =44,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  45
                new Grammar()
                {
                    GrammarShortDescription="もらいます",
                    GrammarDescription="Khi người nhận là chủ ngữ, dùng もらいます, “được cho/được tặng”. Dùng trợ từ に để chỉ người cho/tặng.Ví dụ: かのじょにふうせんをもらいます.",
                    LessionId=45,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  46
                new Grammar()
                {
                    GrammarShortDescription="＿＿のように。",
                    GrammarDescription="のように　có nghĩa là ’giống như’.Ví dụ: こなのように(giống như bột)",
                    LessionId=46,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  47
                new Grammar()
                {
                    GrammarShortDescription="＿＿になります(trở thành)",
                    GrammarDescription="に là trợ từ chỉ kết quả của sự thay đổi.Ví dụ: にほんごきょうしになります (Tôi sẽ trở thành giáo viên tiếng Nhật).",
                    LessionId=47,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                // lession  48
                new Grammar()
                {
                    GrammarShortDescription="気をつけて",
                    GrammarDescription="気をつけて là thể て của động từ 気をつけます, nghĩa là “chú ý” hoặc “cẩn thận”. Trợ từ に được dùng để chỉ đối tượng của động từ này, có nghĩa là đối tượng cần phải cẩn thận hoặc chú ý",
                    LessionId=48,
                    PostOn=DateTime.Now,
                    Modifie=null
                },
            };
            grammars.ForEach(x => context.Grammars.Add(x));
            context.SaveChanges();
            #endregion

            #region Add SoundConservation
            var soundConservations = new List<SoundConservation>()
            {
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=1,
                    Japanese="はじめまして。私はアンナです.",
                    VietNamese="Xin chào. Tôi là Anna.",
                    Romaji="HAJIMEMASHITE.WATASHI WA ANNA DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                     ActorId=2,
                    LessionId=1,
                    Japanese="はじめまして。さくらです.",
                    VietNamese="Xin chào. Tôi là Sakura.",
                    Romaji="HAJIMEMASHITE.WATASHI WA SAKURA DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                     ActorId=1,
                    LessionId=1,
                    Japanese="よろしくお願いします.",
                    VietNamese="Rất vui hân hạnh được làm quen.",
                    Romaji="YOROSHIKU ONEGAI SHIMASU",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=1,
                    Japanese="こちらこそ.",
                    VietNamese="Tôi cũng rất hân hạnh được gặp chị.",
                    Romaji="KOCHIRAKOSO.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //lession 2
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=2,
                    Japanese="さくらさん。はい、どうぞ。",
                    VietNamese="Chị Sakura này, xin tặng chị.",
                    Romaji="SAKURA-SAN. HAI, DOUZO.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                     ActorId=2,
                    LessionId=2,
                    Japanese="これは何ですか",
                    VietNamese="Đây là cái gì thế?",
                    Romaji="KORE WA NAN DESU KA",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                     ActorId=1,
                    LessionId=2,
                    Japanese="よそれはタイのお土産です。",
                    VietNamese="Đấy là món quà lưu niệm của Thái Lan.",
                    Romaji="SORE WA TAI NO OMIYAGE DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=2,
                    Japanese="ありがとうございます",
                    VietNamese="Xin cảm ơn chị.",
                    Romaji="ARIGATOU GOZAIMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=2,
                    Japanese="どういたしまして。",
                    VietNamese="Không có gì ạ.",
                    Romaji="DOUITASHIMASHITE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 3
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=3,
                    Japanese="ここは教室です。",
                    VietNamese="Chỗ này là lớp học.",
                    Romaji="KOKO WA KYOUSHITSU DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                     ActorId=2,
                    LessionId=3,
                    Japanese="わあ、広い。",
                    VietNamese="Ồ, rộng quá!",
                    Romaji="WAA, HIROI.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                     ActorId=1,
                    LessionId=3,
                    Japanese="あそこは図書館。",
                    VietNamese="Chỗ kia là thư viện.",
                    Romaji="ASOKO WA TOSHOKAN.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=3,
                    Japanese="トイレはどこですか。",
                    VietNamese="Nhà vệ sinh ở đâu ạ?",
                    Romaji="TOIRE WA DOKO DESU KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=3,
                    Japanese="すぐそこです。",
                    VietNamese="Ngay chỗ đó thôi.",
                    Romaji="SUGU SOKO DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 4
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=4,
                    Japanese="ただいま。",
                    VietNamese="Con đã về.",
                    Romaji="TADAIMA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                     ActorId=3,
                    LessionId=4,
                    Japanese="お帰りなさい。",
                    VietNamese="Con đã về đấy à.",
                    Romaji="OKAERINASAI.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                     ActorId=2,
                    LessionId=4,
                    Japanese="こんにちは。",
                    VietNamese="Cháu chào bác.",
                    Romaji="KONNICHIWA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=3,
                    LessionId=4,
                    Japanese="あなたも留学生ですか。",
                    VietNamese="Cháu cũng là du học sinh à?",
                    Romaji="ANATA MO RYÛGAKUSEI DESU KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=4,
                    Japanese="いいえ、私は留学生ではありません。日本人の学生です。",
                    VietNamese="Không, cháu không phải là du học sinh. Cháu là sinh viên người Nhật.",
                    Romaji="IIE, WATASHI WA RYÛGAKUSEI DEWA ARIMASEN.NIHON-JIN NO GAKUSEI DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 5
                new SoundConservation()
                {
                     ActorId=1,
                    LessionId=5,
                    Japanese="私の部屋はこちらです。どうぞ。",
                    VietNamese="Phòng tôi ở hướng này. Xin mời chị vào.",
                    Romaji="WATASHI NO HEYA WA KOCHIRA DESU. DÔZO.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=5,
                    Japanese="すごい！これは全部マンガ？",
                    VietNamese="Tuyệt quá! Những cái này tất cả là truyện tranh à?",
                    Romaji="SUGOI! KORE WA ZENBU MANGA?",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=5,
                    Japanese="それは私の宝物です。私は毎日マンガを読みます。",
                    VietNamese="Những cái đó là báu vật của tôi.Tôi đọc truyện tranh hàng ngày.",
                    Romaji="SORE WA WATASHI NO TAKARAMONO DESU.WATASHI WA MAINICHI MANGA O YOMIMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 6
                new SoundConservation()
                {
                     ActorId=2,
                    LessionId=6,
                    Japanese="ところでアンナさん。電話番号は何番ですか。",
                    VietNamese="Mà chị Anna này. Số điện thoại của chị là bao nhiêu?",
                    Romaji="TOKORODE ANNA-SAN. DENWABANGÔ WA NANBAN DESU KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=6,
                    Japanese="ええと。０８０－１２３４－・・・。",
                    VietNamese="Xem nào. 080 – 1234 – ...",
                    Romaji="ÊTO. REI HACHI REI - ICHI NI SAN YON - ...",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=6,
                    Japanese="ありがとう。じゃ、今度、電話をしますね。",
                    VietNamese="Cảm ơn chị. Thế thì, lần sau tôi sẽ điện thoại cho chị nhé.",
                    Romaji="ARIGATÔ. JA, KONDO, DENWA O SHIMASU NE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 7
                new SoundConservation()
                {
                     ActorId=1,
                    LessionId=7,
                    Japanese="ケーキがいっぱいありますね。",
                    VietNamese="Có nhiều bánh nhỉ!",
                    Romaji="KÊKI GA IPPAI ARIMASU NE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=7,
                    Japanese="すみません、シュークリームはありますか。",
                    VietNamese="Xin lỗi cho tôi hỏi, có bánh su kem không ạ?",
                    Romaji="SUMIMASEN, SHÛKURÎMU WA ARIMASU KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=4,
                    LessionId=7,
                    Japanese="はい、こちらです。",
                    VietNamese="Có, ở đằng này ạ.",
                    Romaji="HAI, KOCHIRA DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=7,
                    Japanese="シュークリームを２つください。",
                    VietNamese="Xin cho tôi 2 chiếc bánh su kem.",
                    Romaji="SHÛKURÎMU O FUTATSU KUDASAI.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSSION 8
                new SoundConservation()
                {
                    ActorId=5,
                    LessionId=8,
                    Japanese="みなさん、これを覚えてください。試験によく出ます。",
                    VietNamese="Các em, hãy ghi nhớ cái này! Cái này thường có trong bài thi.",
                    Romaji="MINASAN, KORE O OBOETE KUDASAI. SHIKEN NI YOKU DEMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=6,
                    LessionId=8,
                    Japanese="えっ。",
                    VietNamese="Ối!",
                    Romaji="E'.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=8,
                    Japanese="先生、もう一度お願いします。",
                    VietNamese="Thưa thày, xin thày nói lại một lần nữa ạ!",
                    Romaji="SENSEI, MÔICHIDO ONEGAI SHIMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 9
                new SoundConservation()
                {
                    ActorId=5,
                    LessionId=9,
                    Japanese="明日、健康診断があります。",
                    VietNamese="Ngày mai sẽ có khám sức khỏe.",
                    Romaji="ASHITA, KENKÔSHINDAN GA ARIMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=9,
                    Japanese="何時からですか。",
                    VietNamese="Từ mấy giờ ạ?",
                    Romaji="NANJI KARA DESU KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=5,
                    LessionId=9,
                    Japanese="午前９時から１１時までです。ここに８時半に集まって下さい。",
                    VietNamese="Từ 9 giờ đến 11 giờ sáng.Các em hãy tập trung ở đây lúc 8 rưỡi!",
                    Romaji="GOZEN KUJI KARA JÛICHIJI MADE DESU. KOKO NI HACHIJI HAN NI ATSUMATTE KUDASAI.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 10
                new SoundConservation()
                {
                    ActorId=5,
                    LessionId=10,
                    Japanese="はじめに身長と体重をはかります。全員いますか。",
                    VietNamese="Đầu tiên sẽ đo chiều cao và cân nặng. Tất cả mọi người có mặt chưa?",
                    Romaji="HAJIMENI SHINCHÔ TO TAIJÛ O HAKARIMASU. ZEN-IN IMASU KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=7,
                    LessionId=10,
                    Japanese="アンナさんがいません。",
                    VietNamese="Bạn Anna không có ở đây ạ.",
                    Romaji="ANNA-SAN GA IMASEN.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=10,
                    Japanese="すみません。遅れました。",
                    VietNamese="Xin lỗi, em đến muộn.",
                    Romaji="SUMIMASEN. OKUREMASHITA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 11
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=11,
                    Japanese="今週の土曜日に寮でパーティーを開きます。さくらさん、ぜひ来てください。",
                    VietNamese="Vào thứ Bảy tuần này, chúng tôi sẽ mở tiệc tại kí túc xá.Chị Sakura ơi, chị nhất định đến nhé!",
                    Romaji="KONSHÛ NO DOYÔBI NI RYÔ DE PÂTÎ O HIRAKIMASU.SAKURA-SAN, ZEHI KITE KUDASAI.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=11,
                    Japanese="わあ、行く行く。今度の土曜日ね。",
                    VietNamese="Ồ, đi chứ, đi chứ! Thứ Bảy này có phải không?",
                    Romaji="WÂ, IKU IKU.KONDO NO DOYÔBI NE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 12
                 new SoundConservation()
                {
                    ActorId=2,
                    LessionId=12,
                    Japanese="ロドリゴさんはいつ日本に来ましたか。	",
                    VietNamese="Anh Rodrigo này, anh đến Nhật Bản khi nào?",
                    Romaji="RODORIGO-SAN WA ITSU NIHON NI KIMASHITA KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=7,
                    LessionId=12,
                    Japanese="３月に来ました。",
                    VietNamese="Tôi đến hồi tháng 3.",
                    Romaji="SANGATSU NI KIMASHITA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                }, new SoundConservation()
                {
                    ActorId=2,
                    LessionId=12,
                    Japanese="もう日本の生活に慣れた？",
                    VietNamese="Anh đã quen với cuộc sống ở Nhật Bản chưa?",
                    Romaji="MÔ NIHON NO SEIKATSU NI NARETA?",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=7,
                    LessionId=12,
                    Japanese="ええ、まあ。",
                    VietNamese="Vâng, tôi cũng hơi quen rồi.",
                    Romaji="Ê, MÂ",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 13
                 new SoundConservation()
                {
                    ActorId=2,
                    LessionId=13,
                    Japanese="ロドリゴさんの趣味は何ですか。",
                    VietNamese="Sở thích của anh Rodrigo là gì?",
                    Romaji="RODORIGO-SAN NO SHUMI WA NAN DESU KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=7,
                    LessionId=13,
                    Japanese="読書です。特に歴史小説が好きです。",
                    VietNamese="Sở thích của tôi là đọc sách. Đặc biệt là tôi thích tiểu thuyết lịch sử.",
                    Romaji="DOKUSHO DESU. TOKUNI REKISHI SHÔSETSU GA SUKI DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=13,
                    Japanese="へえ。新宿に新しい本屋が出来ましたよ。みんなで行きませんか。",
                    VietNamese="Thế à? Ở Shinjuku có một hiệu sách mới mở đấy. Tất cả mọi người cùng đi không?",
                    Romaji="HÊ. SHINJUKU NI ATARASHII HON-YA GA DEKIMASHITA YO.MINNA DE IKIMASEN KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSSION 14
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=14,
                    Japanese="お母さん、ここにゴミを捨ててもいいですか。",
                    VietNamese="Mẹ ơi, con vứt rác ở đây có được không ạ?",
                    Romaji="OKÂSAN, KOKO NI GOMI O SUTETE MO II DESU KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=3,
                    LessionId=14,
                    Japanese="そうねえ。缶は別の袋に入れてください。資源ですから。",
                    VietNamese="Để xem nào. Hãy bỏ vỏ hộp kim loại vào một túi khác. Vì chúng là nguyên liệu có thể tái chế.",
                    Romaji="SÔNÊ. KAN WA BETSU NO FUKURO NI IRETE KUDASAI. SHIGEN DESU KARA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=14,
                    Japanese="はい、分かりました。",
                    VietNamese="Vâng, con hiểu rồi.",
                    Romaji="HAI, WAKARIMASHITA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 15
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=15,
                    Japanese="次は新宿駅です。さあ、降りましょう。",
                    VietNamese="Ga tới là ga Shinjuku. Nào, xuống tàu thôi!",
                    Romaji="TSUGI WA SHINJUKU EKI DESU. SÂ, ORIMASHÔ.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=7,
                    LessionId=15,
                    Japanese="あれ。あの人たち、寝ています。",
                    VietNamese="Ôi! Những người đó đang ngủ.",
                    Romaji="ARE. ANO HITO TACHI, NETE IMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=15,
                    Japanese="大丈夫かな。",
                    VietNamese="Có sao không nhỉ?",
                    Romaji="DAIJÔBU KANA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=15,
                    Japanese="丈夫、大丈夫。ほら、起きた。",
                    VietNamese="Không sao, không sao. Nhìn kìa! Họ dậy rồi.",
                    Romaji="DAIJÔBU, DAIJÔBU. HORA, OKITA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 16
                new SoundConservation()
                {
                    ActorId=4,
                    LessionId=16,
                    Japanese="いらっしゃいませ。",
                    VietNamese="Xin kính chào quý khách.",
                    Romaji="IRASSHAIMASE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=16,
                    Japanese="あのう、マンガ売り場はどこですか。",
                    VietNamese="Anh ơi, khu bán truyện tranh ở đâu ạ?",
                    Romaji="ANÔ, MANGA URIBA WA DOKO DESU KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=4,
                    LessionId=16,
                    Japanese="２階です。階段を上がって、右に行ってください。",
                    VietNamese="Trên tầng 2 ạ. Chị hãy đi lên cầu thang, rồi rẽ phải.",
                    Romaji="NIKAI DESU. KAIDAN O AGATTE, MIGI NI ITTE KUDASAI.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 17
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=17,
                    Japanese="あ、この本いいなあ。あれも面白そう。",
                    VietNamese="Ồ, cuốn truyện này trông hay quá! Cuốn kia cũng có vẻ thú vị.",
                    Romaji="A, KONO HON II NÂ. ARE MO OMOSHIROSÔ.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=17,
                    Japanese="さくらさんのおすすめは何ですか。",
                    VietNamese="Chị Sakura khuyên tôi nên mua cuốn nào?",
                    Romaji="SAKURA-SAN NO OSUSUME WA NAN DESU KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=17,
                    Japanese="これはどう？",
                    VietNamese="Cuốn này thì sao?",
                    Romaji="KORE WA DÔ?",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=17,
                    Japanese="ホラーはちょっと…。",
                    VietNamese="Truyện kinh dị thì hơi…",
                    Romaji="HORÂ WA CHOTTO....",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 18
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=18,
                    Japanese="もしもし、さくらさん。助けてください。道に迷ってしまいました。",
                    VietNamese="Alô, chị Sakura à? Xin hãy giúp tôi! Tôi bị lạc đường mất rồi.",
                    Romaji="MOSHIMOSHI, SAKURA-SAN. TASUKETE KUDASAI. MICHI NI MAYOTTE SHIMAIMASHITA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=18,
                    Japanese="今、どこ？",
                    VietNamese="Bây giờ, chị đang ở đâu?",
                    Romaji="IMA, DOKO?",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=18,
                    Japanese="目の前に郵便局があります。",
                    VietNamese="Ngay trước mắt tôi là bưu điện.",
                    Romaji="ME NO MAE NI YÛBINKYOKU GA ARIMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=18,
                    Japanese="分かった。そこにいて。",
                    VietNamese="Tôi hiểu rồi. Chị cứ ở chỗ đó nhé!",
                    Romaji="WAKATTA. SOKO NI ITE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 19
                new SoundConservation()
                {
                    ActorId=7,
                    LessionId=19,
                    Japanese="おーい、アンナさん。",
                    VietNamese="Chị Anna ơi.",
                    Romaji="ÔI, ANNA-SAN.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=19,
                    Japanese="みんな。",
                    VietNamese="Mọi người.",
                    Romaji="MINNA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=7,
                    LessionId=19,
                    Japanese="よかった。心配したよ。",
                    VietNamese="Tốt rồi. Chúng tôi đã lo lắng cho chị đấy.",
                    Romaji="YOKATTA. SHINPAI SHITA YO.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=19,
                    Japanese="ごめんなさい。カメラが安かったので、つい見てしまいました。",
                    VietNamese="Tôi xin lỗi. Vì máy ảnh rẻ, nên tôi cứ mải xem.",
                    Romaji="GOMENNASAI. KAMERA GA YASUKATTA NODE, TSUI MITE SHIMAIMASHITA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 20
                new SoundConservation()
                {
                    ActorId=7,
                    LessionId=20,
                    Japanese="アンナさんは日本の歌を歌ったことがありますか。",
                    VietNamese="Chị Anna này, chị đã bao giờ hát bài hát Nhật Bản chưa?",
                    Romaji="ANNA-SAN WA NIHON NO UTA O UTATTA KOTO GA ARIMASU KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=20,
                    Japanese="はい、あります。",
                    VietNamese="Có, rồi ạ.",
                    Romaji="HAI, ARIMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=20,
                    Japanese="どんな曲が得意？",
                    VietNamese="Chị hát được những bài như thế nào?",
                    Romaji="DONNA KYOKU GA TOKUI?",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=20,
                    Japanese="アニメの曲です。",
                    VietNamese="Bài hát của phim hoạt hình ạ.",
                    Romaji="ANIME NO KYOKU DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 21
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=21,
                    Japanese="アンナ、上手だね。",
                    VietNamese="Anna ơi, hát hay thế!",
                    Romaji="ANNA, JÔZU DA NE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=21,
                    Japanese="いいえ、それほどでも。",
                    VietNamese="Không, không hay đến mức đấy đâu ạ.",
                    Romaji="IIE, SOREHODODEMO.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=7,
                    LessionId=21,
                    Japanese="あっ、もうこんな時間です。",
                    VietNamese="Ôi, đã muộn như thế này rồi!",
                    Romaji="A', MÔ KONNA JIKAN DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=21,
                    Japanese="大変。門限に間に合わない。",
                    VietNamese="Gay go rồi! Tôi không về kịp giờ đóng cửa kí túc xá mất.",
                    Romaji="TAIHEN. MONGEN NI MANIAWANAI.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 22
                 new SoundConservation()
                {
                    ActorId=1,
                    LessionId=22,
                    Japanese="お母さん、ごめんなさい。遅くなりました。",
                    VietNamese="Mẹ ơi, con xin lỗi. Con đã về muộn.",
                    Romaji="OKÂSAN, GOMENNASAI. OSOKU NARIMASHITA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=3,
                    LessionId=22,
                    Japanese="アンナさん、１０分も遅刻です。約束を破ってはいけません。",
                    VietNamese="Anna này, con về muộn những 10 phút.Thất hứa là không được!",
                    Romaji="ANNA-SAN, JIPPUN MO CHIKOKU DESU. YAKUSOKU O YABUTTE WA IKEMASEN.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=22,
                    Japanese="すみません。気をつけます。",
                    VietNamese="Con xin lỗi. Con sẽ chú ý hơn.",
                    Romaji="SUMIMASEN. KI O TSUKEMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 23
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=23,
                    Japanese="この間は門限に間に合った？",
                    VietNamese="Hôm trước có kịp giờ đóng cửa kí túc xá không?",
                    Romaji="KONOAIDA WA MONGEN NI MANIATTA?",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=23,
                    Japanese="いいえ。間に合いませんでした。それで、お母さんに叱られました。",
                    VietNamese="Không ạ. Em đã không về kịp.Vì thế, em đã bị Mẹ mắng.",
                    Romaji="IIE. MANIAIMASEN DESHITA. SOREDE, OKÂSAN NI SHIKARAREMASHITA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=23,
                    Japanese="掃除当番が３回増えました。",
                    VietNamese="Em phải làm nhiệm vụ dọn dẹp thêm 3 lần.",
                    Romaji="SÔJI TÔBAN GA SANKAI FUEMASHITA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=23,
                    Japanese="それは大変だったね。",
                    VietNamese="Thế thì khổ thân nhỉ!",
                    Romaji="SORE WA TAIHEN DATTA NE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 24
                 new SoundConservation()
                {
                    ActorId=5,
                    LessionId=24,
                    Japanese="はい、今日はここまでです。来週の月曜日に試験をします。",
                    VietNamese="Được rồi, hôm nay đến chỗ này thôi.Vào thứ Hai tuần sau, tôi sẽ cho bài kiểm tra",
                    Romaji="HAI, KYÔ WA KOKO MADE DESU. RAISHÛ NO GETSUYÔBI NI SHIKEN O SHIMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=24,
                    Japanese="先生、辞書を使ってもいいですか。",
                    VietNamese="Thưa thầy, chúng em sử dụng từ điển có được không ạ?",
                    Romaji="SENSEI, JISHO O TSUKATTE MO II DESU KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=5,
                    LessionId=24,
                    Japanese="いいえ、だめです。使わないでください。",
                    VietNamese="Không, không được! Các em đừng sử dụng từ điển.",
                    Romaji="IIE, DAME DESU. TSUKAWANAIDE KUDASAI.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 25
                 new SoundConservation()
                {
                    ActorId=5,
                    LessionId=25,
                    Japanese="地震だ。みんな、落ち着いて。机の下に入れ。",
                    VietNamese="Có động đất! Tất cả mọi người, hãy bình tĩnh! Chui xuống gầm bàn!",
                    Romaji="JISHIN DA. MINNA, OCHITSUITE. TSUKUE NO SHITA NI HAIRE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=5,
                    LessionId=25,
                    Japanese="揺れは収まったようだ。",
                    VietNamese="Có vẻ như đã bớt rung lắc rồi.",
                    Romaji="YURE WA OSAMATTA YÔ DA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=25,
                    Japanese="びっくりした。日本は本当に地震が多いですね。",
                    VietNamese="Giật cả mình! Nhật Bản đúng là hay có động đất nhỉ.",
                    Romaji="BIKKURI SHITA. NIHON WA HONTÔ NI JISHIN GA ÔI DESU NE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 26
                 new SoundConservation()
                {
                    ActorId=1,
                    LessionId=26,
                    Japanese="ロドリゴ、元気がないね。",
                    VietNamese="Rodrigo ơi, bạn không khỏe à?",
                    Romaji="RODORIGO, GENKI GA NAI NE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=7,
                    LessionId=26,
                    Japanese="試験ができなかったんです",
                    VietNamese="Mình đã không làm tốt bài kiểm tra.",
                    Romaji="SHIKEN GA DEKINAKATTA N DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=26,
                    Japanese="私も…。６０点でした。次はがんばろう。",
                    VietNamese="Mình cũng vậy... Mình được 60 điểm.Lần sau bọn mình cùng cố gắng nhé.",
                    Romaji="WATASHI MO.... ROKUJITTEN DESHITA. TSUGI WA GANBARÔ.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 27
                 new SoundConservation()
                {
                    ActorId=1,
                    LessionId=27,
                    Japanese="誰が結婚するんですか。",
                    VietNamese="Ai kết hôn đấy ạ?",
                    Romaji="DARE GA KEKKON SURU N DESU KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=27,
                    Japanese="静岡の友だち。",
                    VietNamese="Một người bạn ở Shizuoka.",
                    Romaji="SHIZUOKA NO TOMODACHI.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=27,
                    Japanese="へえ。いつですか。",
                    VietNamese="Ôi, thế à! Bao giờ thế ạ?",
                    Romaji="HÊ. ITSU DESU KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=27,
                    Japanese="来月２０日よ。アンナも一緒に静岡に行かない？",
                    VietNamese="Ngày 20 tháng sau đấy. Anna có đi cùng chị đến Shizuoka không?",
                    Romaji="RAIGETSU HATSUKA YO. ANNA MO ISSHO NI SHIZUOKA NI IKANAI?",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 28
                 new SoundConservation()
                {
                    ActorId=2,
                    LessionId=28,
                    Japanese="こちらは、いとこの健太くん。",
                    VietNamese="Đây là em họ chị, Kenta.",
                    Romaji="KOCHIRA WA, ITOKO NO KENTA-KUN.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=8,
                    LessionId=28,
                    Japanese="静岡へようこそ。",
                    VietNamese="Chào mừng em đến Shizuoka.",
                    Romaji="SHIZUOKA E YÔKOSO.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=28,
                    Japanese="彼はカメラに詳しいから、いろいろきいてね。",
                    VietNamese="Cậu ấy biết nhiều về máy ảnh, nên có gì cứ hỏi cậu ấy nhé.",
                    Romaji="KARE WA KAMERA NI KUWASHII KARA, IROIRO KIITE NE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=28,
                    Japanese="どうぞよろしくお願いします。",
                    VietNamese="Mong được anh giúp đỡ.",
                    Romaji="DÔZO YOROSHIKU ONEGAI SHIMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=8,
                    LessionId=28,
                    Japanese="（アンナちゃん、かわいいなあ）",
                    VietNamese="(Anna dễ thương quá!)",
                    Romaji="(ANNA-CHAN, KAWAII NÂ.)",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 29
                 new SoundConservation()
                {
                    ActorId=1,
                    LessionId=29,
                    Japanese="富士山だ。近くで見ると、大きいですね。",
                    VietNamese="Núi Phú Sĩ đây rồi. Khi nhìn gần, trông lớn nhỉ!",
                    Romaji="FUJISAN DA. CHIKAKU DE MIRU TO, ÔKII DESU NE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=29,
                    Japanese="あれ。雲の形が帽子みたいです。",
                    VietNamese="Ôi! Hình dáng của đám mây trông giống chiếc mũ.",
                    Romaji="ARE. KUMO NO KATACHI GA BÔSHI MITAI DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=8,
                    LessionId=29,
                    Japanese="（あの雲が見えると、雨が降るんだよ。",
                    VietNamese="Nếu nhìn thấy đám mây kia, thì trời sẽ mưa đấy.",
                    Romaji="ANO KUMO GA MIERU TO, AME GA FURU N DA YO.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 30
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=30,
                    Japanese="あ、雨だ。急いで帰りましょう。",
                    VietNamese="Ối, trời mưa rồi! Mau về thôi!",
                    Romaji="A, AME DA. ISOIDE KAERIMASHÔ.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=30,
                    Japanese="ちょっと待ってください。もう少し写真を撮りたいです。",
                    VietNamese="Xin hãy đợi một chút! Em muốn chụp ảnh thêm một lúc nữa.",
                    Romaji="CHOTTO MATTE KUDASAI. MÔ SUKOSHI SHASHIN O TORITAI DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=8,
                    LessionId=30,
                    Japanese="雨にぬれたら、風邪をひくよ。",
                    VietNamese="Nếu bị mưa ướt, sẽ bị cảm lạnh đấy.",
                    Romaji="AME NI NURETARA, KAZE O HIKU YO.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 31
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=31,
                    Japanese="おばあさん、お元気ですね。",
                    VietNamese="Bà ơi, trông bà còn khỏe quá ạ!",
                    Romaji="OBÂSAN, OGENKI DESU NE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=9,
                    LessionId=31,
                    Japanese="もう８２歳ですよ。さあ、お茶をどうぞ。",
                    VietNamese="Bà đã 82 tuổi rồi đấy. Nào, cháu uống trà đi.",
                    Romaji="MÔ HACHIJÛNI SAI DESU YO.SÂ, OCHA O DÔZO.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=31,
                    Japanese="わあ、きれいな緑色。香りもいいです。",
                    VietNamese="Ồ, màu xanh lục đẹp quá! Hương cũng thơm.",
                    Romaji="WÂ, KIREINA MIDORI IRO. KAORI MO II DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 32
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=32,
                    Japanese="布団とベッドとどちらが好き？",
                    VietNamese="Giữa đệm futon và giường, em thích cái nào hơn?",
                    Romaji="FUTON TO BEDDO TO DOCHIRA GA SUKI?",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=32,
                    Japanese="布団のほうが好きです。この布団はベッドよりやわらかいです。",
                    VietNamese="Em thích đệm futon hơn. Đệm futon này mềm hơn giường.",
                    Romaji="FUTON NO HÔ GA SUKI DESU.KONO FUTON WA BEDDO YORI YAWARAKAI DESU",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=32,
                    Japanese="それじゃ、おやすみなさい",
                    VietNamese="Thế chị nhé! Chúc chị ngủ ngon.",
                    Romaji="SOREJA, OYASUMINASAI.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=32,
                    Japanese="おやすみ。",
                    VietNamese="Chúc ngủ ngon.",
                    Romaji="OYASUMI.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 33
                new SoundConservation()
                {
                    ActorId=8,
                    LessionId=33,
                    Japanese="これは、僕が富士山で撮った写真です",
                    VietNamese="Đây là bức ảnh anh chụp ở núi Phú Sĩ",
                    Romaji="KORE WA, BOKU GA FUJISAN DE TOTTA SHASHIN DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=33,
                    Japanese="あっ、私だ。",
                    VietNamese="Ơ, đó là em!",
                    Romaji="A', WATASHI DA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=8,
                    LessionId=33,
                    Japanese="驚いた？あとで、アンナさんにあげます。",
                    VietNamese="Em ngạc nhiên không?Sau này, anh sẽ tặng cho Anna.",
                    Romaji="ODOROITA?ATODE, ANNA-SAN NI AGEMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=33,
                    Japanese="写真をくれるんですか。うれしいです。",
                    VietNamese="Anh sẽ tặng bức ảnh cho em à? Vui quá ạ!",
                    Romaji="SHASHIN O KURERU N DESU KA? URESHII DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 34
                 new SoundConservation()
                {
                    ActorId=8,
                    LessionId=34,
                    Japanese="あっ、トロが来た。",
                    VietNamese="A, toro đến rồi!",
                    Romaji="A', TORO GA KITA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=34,
                    Japanese="トロって何ですか。",
                    VietNamese="Toro là cái gì thế ạ?",
                    Romaji="TORO TTE NAN DESU KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=8,
                    LessionId=34,
                    Japanese="マグロのおなかの部分です。どうぞ。",
                    VietNamese="Nó là phần bụng của cá ngừ đại dương. Mời em!",
                    Romaji="MAGURO NO ONAKA NO BUBUN DESU. DÔZO.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=34,
                    Japanese="いただきます。やわらかくておいしいです。",
                    VietNamese="Em xin phép. Mềm và ngon quá ạ!",
                    Romaji="ITADAKIMASU.YAWARAKAKUTE OISHII DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 35
                new SoundConservation()
                {
                    ActorId=8,
                    LessionId=35,
                    Japanese="お勘定をお願いします。",
                    VietNamese="Làm ơn cho tôi thanh toán.",
                    Romaji="OKANJÔ O ONEGAI SHIMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=4,
                    LessionId=35,
                    Japanese="全部で５２００円です。",
                    VietNamese="Tất cả là 5.200 yen ạ.",
                    Romaji="ZENBU DE GOSEN NIHYAKU EN DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=8,
                    LessionId=35,
                    Japanese="クレジットカードは使えますか。",
                    VietNamese="Tôi có thể trả bằng thẻ tín dụng được không?",
                    Romaji="KUREJITTO KÂDO WA TSUKAEMASU KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=4,
                    LessionId=35,
                    Japanese="はい、使えます。",
                    VietNamese="Vâng, được ạ.",
                    Romaji="HAI, TSUKAEMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 36
                new SoundConservation()
                {
                    ActorId=8,
                    LessionId=36,
                    Japanese="寂しくなります。",
                    VietNamese="Anh sẽ buồn lắm.",
                    Romaji="SABISHIKU NARIMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=36,
                    Japanese="私もです。でも、大学で勉強しなければなりません。",
                    VietNamese="Em cũng thế.Nhưng em còn phải học ở trường.",
                    Romaji="WATASHI MO DESU.DEMO, DAIGAKU DE BENKYÔ SHINAKEREBA NARIMASEN.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=8,
                    LessionId=36,
                    Japanese="じゃ、僕が春休みに東京に行きます。",
                    VietNamese="Thế thì, anh sẽ lên Tokyo trong kì nghỉ Xuân.",
                    Romaji="JA, BOKU GA HARUYASUMI NI TÔKYÔ NI IKIMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 37
                 new SoundConservation()
                {
                    ActorId=3,
                    LessionId=37,
                    Japanese="旅行はどうだった？",
                    VietNamese="Chuyến đi thế nào?",
                    Romaji="RYOKÔ WA DÔ DATTA?",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=37,
                    Japanese="富士山を見たり、おすしを食べたりしました。楽しかったです。",
                    VietNamese="Con đã ngắm núi Phú Sĩ, ăn sushi, và tham gia những hoạt động khác nữa. Vui lắm ạ!",
                    Romaji="FUJISAN O MITARI, OSUSHI O TABETARI SHIMASHITA. TANOSHIKATTA DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=3,
                    LessionId=37,
                    Japanese="それはよかったわね。",
                    VietNamese="Thế thì tốt rồi.",
                    Romaji="SORE WA YOKATTA WA NE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 38
                 new SoundConservation()
                {
                    ActorId=3,
                    LessionId=38,
                    Japanese="市民病院までお願いします。",
                    VietNamese="Xin hãy chở chúng tôi tới Bệnh viện Thành phố.",
                    Romaji="SHIMIN BYÔIN MADE ONEGAI SHIMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=10,
                    LessionId=38,
                    Japanese="かしこまりました。",
                    VietNamese="Vâng, tôi hiểu rồi ạ.",
                    Romaji="KASHIKOMARIMASHITA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=3,
                    LessionId=38,
                    Japanese="まっすぐ行って、３つ目の信号を左に曲がってください。",
                    VietNamese="Anh hãy đi thẳng, rồi rẽ trái ở chỗ đèn xanh đèn đỏ thứ 3.",
                    Romaji="MASSUGU ITTE, MITTSU ME NO SHINGÔ O HIDARI NI MAGATTE KUDASAI.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 39
                 new SoundConservation()
                {
                    ActorId=11,
                    LessionId=39,
                    Japanese="どうしましたか。",
                    VietNamese="Chị bị làm sao vậy?",
                    Romaji="DÔ SHIMASHITA KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=39,
                    Japanese="せきが出ます。",
                    VietNamese="Tôi bị ho.",
                    Romaji="SEKI GA DEMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=3,
                    LessionId=39,
                    Japanese="熱も３７．８度あります。",
                    VietNamese="Cô ấy cũng bị sốt 37,8 độ.",
                    Romaji="NETSU MO SANJÛNANA TEN HACHI DO ARIMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=11,
                    LessionId=39,
                    Japanese="喉を見せてください。かぜだと思います。",
                    VietNamese="Để tôi khám họng. Tôi nghĩ là chị bị cảm lạnh.",
                    Romaji="NODO O MISETE KUDASAI.KAZE DA TO OMOIMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 40
                new SoundConservation()
                {
                    ActorId=3,
                    LessionId=40,
                    Japanese="おかゆですよ。体調は、どう？",
                    VietNamese="Cháo này con. Con thấy trong người thế nào?",
                    Romaji="OKAYU DESU YO.TAICHÔ WA, DÔ?",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=40,
                    Japanese="	頭がずきずきします。",
                    VietNamese="Đầu con đau như búa bổ.",
                    Romaji="ATAMA GA ZUKIZUKI SHIMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=3,
                    LessionId=40,
                    Japanese="そう。欲しいものがあったら、言ってね。",
                    VietNamese="Thế à? Nếu muốn gì thì nói nhé!.",
                    Romaji="SÔ. HOSHII MONO GA ATTARA, ITTE NE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 41
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=41,
                    Japanese="健太様お元気ですか。",
                    VietNamese="Anh Kenta thân mến!Anh có khỏe không ạ?",
                    Romaji="KENTA SAMA OGENKI DESU KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=41,
                    Japanese="	この間はありがとうございました。",
                    VietNamese="Hôm trước, xin cảm ơn anh.",
                    Romaji="KONOAIDA WA ARIGATÔ GOZAIMASHITA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=41,
                    Japanese="学園祭に行くことができて、楽しかったです。",
                    VietNamese="Em rất vui vì đã được đến lễ hội ở trường.",
                    Romaji="GAKUEN-SAI NI IKU KOTO GA DEKITE, TANOSHIKATTA DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=41,
                    Japanese="次は東京で会いましょう。",
                    VietNamese="Lần tới, hẹn gặp anh ở Tokyo.",
                    Romaji="TSUGI WA TÔKYÔ DE AIMASHÔ.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 42
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=42,
                    Japanese="どれがいちばんおいしいかな。",
                    VietNamese="Cái nào thì ngon nhất nhỉ?",
                    Romaji="DORE GA ICHIBAN OISHII KANA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=4,
                    LessionId=42,
                    Japanese="幕の内弁当は人気がありますよ。",
                    VietNamese="Cơm hộp Makunouchi rất được ưa chuộng đấy ạ.",
                    Romaji="MAKUNOUCHI-BENTÔ WA NINKI GA ARIMASU YO.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=42,
                    Japanese="じゃ、私は幕の内。",
                    VietNamese="Thế thì tôi lấy Makunouchi.",
                    Romaji="JA, WATASHI WA MAKUNOUCHI.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=7,
                    LessionId=42,
                    Japanese="僕も。支払いは別々にお願いします。",
                    VietNamese="Tôi cũng vậy. Cho chúng tôi trả tiền riêng.",
                    Romaji="BOKU MO. SHIHARAI WA BETSUBETSUNI ONEGAI SHIMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 43
                 new SoundConservation()
                {
                    ActorId=5,
                    LessionId=43,
                    Japanese="姫路城は奇跡の城と言われています。どうしてでしょうか。",
                    VietNamese="Thành Himeji được gọi là một ngôi thành kì diệu. Theo các em, tại sao lại như vậy?",
                    Romaji="HIMEJI-JÔ WA KISEKI NO SHIRO TO IWARETE IMASU.DÔSHITE DESHÔ KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=7,
                    LessionId=43,
                    Japanese="戦争でも焼けなかったからです。",
                    VietNamese="Bởi vì ngay cả trong chiến tranh, nó chưa bao giờ bị cháy ạ.",
                    Romaji="SENSÔ DEMO YAKENAKATTA KARA DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=43,
                    Japanese="さすが、ロドリゴ！",
                    VietNamese="Rodrigo giỏi quá!",
                    Romaji="SASUGA, RODORIGO!",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 44
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=44,
                    Japanese="和菓子はとても甘いですね。",
                    VietNamese="Bánh Nhật Bản rất ngọt, thày nhỉ?",
                    Romaji="WAGASHI WA TOTEMO AMAI DESU NE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=5,
                    LessionId=44,
                    Japanese="和菓子を食べてから、抹茶を飲みます。抹茶は苦いかもしれません。",
                    VietNamese="Sau khi ăn bánh Nhật Bản, thì uống trà pha từ bột trà xanh.Trà này có thể đắng.",
                    Romaji="WAGASHI O TABETE KARA, MACCHA O NOMIMASU.MACCHA WA NIGAI KAMOSHIREMASEN.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=44,
                    Japanese="先生、足がしびれました。いたたたた。",
                    VietNamese="Thày ơi, chân em bị tê. Ôi, đau quá!",
                    Romaji="SENSEI, ASHI GA SHIBIREMASHITA. ITATATATA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 45
                new SoundConservation()
                {
                    ActorId=6,
                    LessionId=45,
                    Japanese="アンナ、お誕生日おめでとう。",
                    VietNamese="Chúc mừng sinh nhật Anna!",
                    Romaji="ANNA, OTANJÔBI OMEDETÔ.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=8,
                    LessionId=45,
                    Japanese="これ、ほんの気持ちです。",
                    VietNamese="Đây là món quà nhỏ tặng em.",
                    Romaji="KORE, HONNO KIMOCHI DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=45,
                    Japanese="どうもありがとうございます。",
                    VietNamese="Em cảm ơn anh ạ.",
                    Romaji="DÔMO ARIGATÔ GOZAIMASU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=45,
                    Japanese="何をもらったの？",
                    VietNamese="Em nhận được quà gì thế?",
                    Romaji="NANI O MORATTA NO?",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=45,
                    Japanese="開けてもいいですか。",
                    VietNamese="Em mở ra có được không ạ?",
                    Romaji="AKETE MO II DESU KA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 46
                 new SoundConservation()
                {
                    ActorId=1,
                    LessionId=46,
                    Japanese="もしかして、雪？",
                    VietNamese="Liệu có thể là tuyết không nhỉ?",
                    Romaji="MOSHIKASHITE, YUKI?",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=8,
                    LessionId=46,
                    Japanese="これは、粉雪。粉のようにさらさらしているでしょ。",
                    VietNamese="Đây là bụi tuyết. Khô và mịn giống như bột, đúng không?",
                    Romaji="KORE WA, KONAYUKI. KONA NO YÔ NI SARASARA SHITEIRU DESHO.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=46,
                    Japanese="帰国する前に、雪を見ることができて幸せです。",
                    VietNamese="Trước khi về nước được nhìn thấy tuyết, em thấy vui quá ạ!",
                    Romaji="KIKOKU SURU MAE NI, YUKI O MIRU KOTO GA DEKITE SHIAWASE DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 47
                new SoundConservation()
                {
                    ActorId=5,
                    LessionId=47,
                    Japanese="最後に、みなさんの夢を教えてください。",
                    VietNamese="Cuối cùng, hãy cho tôi biết ước mơ của các em!",
                    Romaji="SAIGO NI, MINASAN NO YUME O OSHIETE KUDASAI.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=7,
                    LessionId=47,
                    Japanese="僕は日本を１周したいです。",
                    VietNamese="Em muốn đi du lịch vòng quanh Nhật Bản.",
                    Romaji="BOKU WA NIHON O ISSHÛ SHITAI DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=47,
                    Japanese="私は…日本語教師になるのが夢です。",
                    VietNamese="Còn em thì…trở thành giáo viên tiếng Nhật là mơ ước của em.",
                    Romaji="WATASHI WA... NIHONGO-KYÔSHI NI NARU NO GA YUME DESU.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                //LESSION 48
                new SoundConservation()
                {
                    ActorId=8,
                    LessionId=48,
                    Japanese="体に気をつけて。",
                    VietNamese="Em hãy chú ý giữ gìn sức khỏe nhé!",
                    Romaji="KARADA NI KIOTSUKETE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=2,
                    LessionId=48,
                    Japanese="タイに着いたら連絡してね。",
                    VietNamese="Khi nào đến Thái Lan, thì báo cho bọn chị biết nhé!",
                    Romaji="TAI NI TSUITARA, RENRAKU SHITE NE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=48,
                    Japanese="はい。いろいろお世話になりました。",
                    VietNamese="Vâng. Cảm ơn mọi người vì mọi việc.",
                    Romaji="HAI. IROIRO OSEWA NI NARIMASHITA.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
                new SoundConservation()
                {
                    ActorId=1,
                    LessionId=48,
                    Japanese="健太さんとさくらさんもお元気で。",
                    VietNamese="Anh Kenta và chị Sakura cũng ở lại mạnh khỏe nhé!",
                    Romaji="KENTA-SAN TO SAKURA-SAN MO OGENKIDE.",
                    PostOn=DateTime.Now,
                    Modifie=null
                },
            };
            soundConservations.ForEach(x => context.SoundConservations.Add(x));
            context.SaveChanges();
            #endregion

            #region Add Topic
            var topics = new List<Topic>()
            {
                new Topic()
                {
                    TopicTitle="Đề số 1",
                },
                new Topic()
                {
                    TopicTitle="Đề số 2",
                },
                new Topic()
                {
                    TopicTitle="Đề số 3",
                },
                new Topic()
                {
                    TopicTitle="Đề số 4",
                },
                new Topic()
                {
                    TopicTitle="Đề số 5",
                },
                new Topic()
                {
                    TopicTitle="Đề số 6",
                },
                new Topic()
                {
                    TopicTitle="Đề số 7",
                },
                new Topic()
                {
                    TopicTitle="Đề số 8",
                },
                new Topic()
                {
                    TopicTitle="Đề số 9",
                },
                new Topic()
                {
                    TopicTitle="Đề số 10",
                }
            };

            topics.ForEach(x => context.Topics.Add(x));
            context.SaveChanges();
            #endregion

            #region Add Question
            var questions = new List<Question>()
            {
                //QUESSION 1 TOPIC 1
                new Question()
                {
                    QuestionTitle="先週の金曜日（学校）のしょかんでレポートを書きました.",
                    Answer="がっこう",
                    TopicId=1,
                },
                //QUESSION 2 TOPIC 1
                new Question()
                {
                    QuestionTitle="（今晩）いっしょにビールを飲みませんか。",
                    Answer="こんばん",
                   TopicId=1
                },
                //QUESSION 3 TOPIC 1
                new Question()
                {
                    QuestionTitle="(新聞) を読みます。それから、ＣＤを聞きます。",
                    Answer="しんぶん",
                   TopicId=1
                },
                //QUESSION 4 TOPIC 1
                new Question() 
                {
                    QuestionTitle="学校は (午後) 一時五十分からです。",
                    Answer="ごご",
                   TopicId=1
                },
                //QUESSION 5 TOPIC 1
                new Question()
                {
                    QuestionTitle="あの (店) で辞書を買いました。",
                    Answer="みせ",
                   TopicId=1
                },
                //QUESSION 6 TOPIC 1
                new Question()
                {
                    QuestionTitle="来月 (一人) で京都へ行きますか。",
                    Answer="ひとりで",
                   TopicId=1
                },
                //QUESSION 7 TOPIC 1
                new Question()
                {
                    QuestionTitle="よる時々ビデオを（見ます）。",
                    Answer="みます",
                   TopicId=1
                },
                //QUESSION 8 TOPIC 1
                new Question()
                {
                    QuestionTitle="ちょっと休みませんか。（水）を飲みましょう。",
                    Answer="みず",
                   TopicId=1
                },
                //QUESSION 9 TOPIC 1
                new Question()
                {
                    QuestionTitle="（誕生日）は何月何日ですか。",
                    Answer="たんじょうび",
                   TopicId=1
                },
                //QUESSION 10 TOPIC 1
                new Question()
                {
                    QuestionTitle="ロサンゼルスは今（午前）十一時です。",
                    Answer="ごぜん",
                   TopicId=1
                },
                ///QUESTION OF TOPIC 2/////////////////////////////////////////////////////
                new Question()
                {
                    QuestionTitle="いつ（お母さん）に電話をかけますか。",
                    Answer="おかあさん",
                    TopicId=2,
                },
                //QUESSION 2 TOPIC ２
                new Question()
                {
                    QuestionTitle="（（お父さん）の誕生日になんをあげましたか。",
                    Answer="おかあさん",
                   TopicId=2
                },
                //QUESSION 3 TOPIC ２
                new Question()
                {
                    QuestionTitle="もう（昼ご飯）を食べましたか。",
                    Answer="ひるごはん",
                   TopicId=2
                },
                //QUESSION 4 TOPIC ２
                new Question()
                {
                    QuestionTitle="ホセさんの（傘）はどれですか。",
                    Answer="かさ",
                   TopicId=2
                },
                //QUESSION 5 TOPIC 2
                new Question()
                {
                    QuestionTitle="富士山は高い山です。そしてきれいな山です。",
                    Answer="たかい",
                   TopicId=2
                },
                //QUESSION 6 TOPIC 2
                new Question()
                {
                    QuestionTitle="あの（赤い）かばんはだれのですか。",
                    Answer="あかい",
                    TopicId=2
                },
                //QUESSION 7 TOPIC 2
                new Question()
                {
                    QuestionTitle="この町まちは (夜) とてもにぎやかですか。",
                    Answer="よる",
                   TopicId=2
                },
                //QUESSION 8 TOPIC 2
                new Question()
                {
                    QuestionTitle="あのレストランは (安い) ですが、おいしくないです。",
                    Answer="やすい",
                   TopicId=2
                },
                //QUESSION 9 TOPIC 2
                new Question()
                {
                    QuestionTitle="毎朝まいあさ冷つめたいジュースを (飲みます) 。",
                    Answer="のみます",
                   TopicId=2
                },
                //QUESSION 10 TOPIC 2
                new Question()
                {
                    QuestionTitle="デパートでワインを買かいます。それからレストランで (晩ご飯) を食たべます。",
                    Answer="ばんごはん",
                   TopicId=2
                },
                //////QUESTION OF TOPIC 3/////////////////////////////////////////////////////
                new Question()
                {
                    QuestionTitle="あなたのカメラは (大きい) ですか。",
                    Answer="おおきい",
                    TopicId=3,
                },
                //QUESSION 2 TOPIC 3
                new Question()
                {
                    QuestionTitle="（白い) 花はなを買かいました。",
                    Answer="しろい",
                   TopicId=3
                },
                //QUESSION 3 TOPIC 3
                new Question()
                {
                    QuestionTitle=" (荷物) を送おくります。",
                    Answer="にもつ",
                   TopicId=3
                },
                //QUESSION 4 TOPIC 3
                new Question()
                {
                    QuestionTitle="日本にほんの (食べ物) はおいしいです。",
                    Answer="たべもの",
                   TopicId=3
                },
                //QUESSION 5 TOPIC 3
                new Question()
                {
                    QuestionTitle="銀行ぎんこうの (右) に学校がっこうがあります。",
                    Answer="みぎ",
                   TopicId=3
                },
                //QUESSION 6 TOPIC 3
                new Question()
                {
                    QuestionTitle="郵便局ゆうびんきょくはスーパーの (近く) です。",
                    Answer="ちかく",
                    TopicId=3
                },
                //QUESSION 7 TOPIC 3
                new Question()
                {
                    QuestionTitle="駅えきの前まえに白しろいビルがあります。そして駅えきの (後ろ )に大おおきいデパートがあります。",
                    Answer="うしろ",
                   TopicId=3
                },
                //QUESSION 8 TOPIC 3
                new Question()
                {
                    QuestionTitle="テーブルの上うえに (手紙) があります。",
                    Answer="てがみ",
                   TopicId=3
                },
                //QUESSION 9 TOPIC 3
                new Question()
                {
                    QuestionTitle="男おとこの子こと女おんなの子この間あいだに (犬) がいます。",
                    Answer="いぬ",
                   TopicId=3
                },
                //QUESSION 10 TOPIC 3
                new Question()
                {
                    QuestionTitle="スーパーの (中) に花屋はなやがあります。",
                    Answer="なか",
                   TopicId=3
                },
            };
            questions.ForEach(x => context.Questions.Add(x));
            context.SaveChanges();
            #endregion

            #region Add QuestionItem
            var questionItems = new List<QuestionItem>()
            {
                //QUESION 1 TOPIC 1
                new QuestionItem()
                {
                    Title="がっこう",
                    QuestionId=1,
                },
                new QuestionItem()
                {
                    Title="がくこう",
                    QuestionId=1,
                },
                new QuestionItem()
                {
                    Title="かっこう",
                    QuestionId=1,
                },
                new QuestionItem()
                {
                    Title="かくこう",
                    QuestionId=1,
                },
                //QUESION 2 TOPIC 1
                new QuestionItem()
                {
                    Title="けさ",
                    QuestionId=2,
                },
                new QuestionItem()
                {
                    Title="いまばん",
                    QuestionId=2,
                },
                new QuestionItem()
                {
                    Title="ゆうべ",
                    QuestionId=2,
                },
                new QuestionItem()
                {
                    Title="こんばん",
                    QuestionId=2,
                },
                //QUESION 3 TOPIC 1
                new QuestionItem()
                {
                    Title="しんぶん",
                    QuestionId=3,
                },
                new QuestionItem()
                {
                    Title="じんぶん",
                    QuestionId=3,
                },
                new QuestionItem()
                {
                    Title="しんふん",
                    QuestionId=3,
                },
                new QuestionItem()
                {
                    Title="じんふん",
                    QuestionId=3,
                },
                //QUESION 4 TOPIC 1
                new QuestionItem()
                {
                    Title="ごぜん",
                    QuestionId=4,
                },
                new QuestionItem()
                {
                    Title="ごご",
                    QuestionId=4,
                },
                new QuestionItem()
                {
                    Title="こあと",
                    QuestionId=4,
                },
                new QuestionItem()
                {
                    Title="こご",
                    QuestionId=4,
                },
                //QUESION ５ TOPIC 1
                new QuestionItem()
                {
                    Title="こえ",
                    QuestionId=5,
                },
                new QuestionItem()
                {
                    Title="はな",
                    QuestionId=5,
                },
                new QuestionItem()
                {
                    Title="かみ",
                    QuestionId=5,
                },
                new QuestionItem()
                {
                    Title="みせ",
                    QuestionId=5,
                },
                //QUESION 6 TOPIC 1
                new QuestionItem()
                {
                    Title="ひとりで",
                    QuestionId=6,
                },
                new QuestionItem()
                {
                    Title="いちひとで",
                    QuestionId=6,
                },
                new QuestionItem()
                {
                    Title="いちにんで",
                    QuestionId=6,
                },
                new QuestionItem()
                {
                    Title="いちじんで",
                    QuestionId=6,
                },
                //QUESION 7 TOPIC 1
                new QuestionItem()
                {
                    Title="のみます",
                    QuestionId=7,
                },
                new QuestionItem()
                {
                    Title="たべます",
                    QuestionId=7,
                },
                new QuestionItem()
                {
                    Title="すいます",
                    QuestionId=7,
                },
                new QuestionItem()
                {
                    Title="みます",
                    QuestionId=7,
                },
                //QUESION 8 TOPIC 1
                new QuestionItem()
                {
                    Title="か",
                    QuestionId=8,
                },
                new QuestionItem()
                {
                    Title="みず",
                    QuestionId=8,
                },
                new QuestionItem()
                {
                    Title="こおり",
                    QuestionId=8,
                },
                new QuestionItem()
                {
                    Title="うみ",
                    QuestionId=8,
                },
                //QUESION 9 TOPIC 1
                new QuestionItem()
                {
                    Title="たんじょうび",
                    QuestionId=9,
                },
                new QuestionItem()
                {
                    Title="たんしょうにち",
                    QuestionId=9,
                },
                new QuestionItem()
                {
                    Title="たんじょうひ",
                    QuestionId=9,
                },
                new QuestionItem()
                {
                    Title="たんじょうにち",
                    QuestionId=9,
                },
                //QUESION 10 TOPIC 1
                new QuestionItem()
                {
                    Title="ごご",
                    QuestionId=10,
                },
                new QuestionItem()
                {
                    Title="ごまえ",
                    QuestionId=10,
                },
                new QuestionItem()
                {
                    Title="ごぜん",
                    QuestionId=10,
                },
                new QuestionItem()
                {
                    Title="しょうまえ",
                    QuestionId=10,
                },
                //QUESION 1 TOPIC 2
                new QuestionItem()
                {
                    Title="おかさん",
                    QuestionId=11,
                },
                new QuestionItem()
                {
                    Title="おばさん",
                    QuestionId=11,
                },
                new QuestionItem()
                {
                    Title="おかあさん",
                    QuestionId=11,
                },
                new QuestionItem()
                {
                    Title="おばあさん",
                    QuestionId=11,
                },
                //QUESION 2 TOPIC 2
                new QuestionItem()
                {
                    Title="おちちさん",
                    QuestionId=12,
                },
                new QuestionItem()
                {
                    Title="おとうさん",
                    QuestionId=12,
                },
                new QuestionItem()
                {
                    Title="おじいさん",
                    QuestionId=12,
                },
                new QuestionItem()
                {
                    Title="おとさん",
                    QuestionId=12,
                },
                //QUESION 3 TOPIC 2
                new QuestionItem()
                {
                    Title="ひまごはん",
                    QuestionId=13,
                },
                new QuestionItem()
                {
                    Title="ひろごはん",
                    QuestionId=13,
                },
                new QuestionItem()
                {
                    Title="ひくごはん",
                    QuestionId=13,
                },
                new QuestionItem()
                {
                    Title="ひくごはん",
                    QuestionId=13,
                },
                //QUESION 4 TOPIC 2
                new QuestionItem()
                {
                    Title="かさ",
                    QuestionId=14,
                },
                new QuestionItem()
                {
                    Title="かみ",
                    QuestionId=14,
                },
                new QuestionItem()
                {
                    Title="くつ",
                    QuestionId=14,
                },
                new QuestionItem()
                {
                    Title="ふくろ",
                    QuestionId=14,
                },
                //QUESION ５ TOPIC 2
                new QuestionItem()
                {
                    Title="ふるい",
                    QuestionId=15,
                },
                new QuestionItem()
                {
                    Title="ちいさい",
                    QuestionId=15,
                },
                new QuestionItem()
                {
                    Title="たかい",
                    QuestionId=15,
                },
                new QuestionItem()
                {
                    Title="ちかい",
                    QuestionId=15,
                },
                //QUESION 6 TOPIC 2
                new QuestionItem()
                {
                    Title="しろい",
                    QuestionId=16,
                },
                new QuestionItem()
                {
                    Title="あかい",
                    QuestionId=16,
                },
                new QuestionItem()
                {
                    Title="あおい",
                    QuestionId=16,
                },
                new QuestionItem()
                {
                    Title="くろい",
                    QuestionId=16,
                },
                //QUESION 7 TOPIC 2
                new QuestionItem()
                {
                    Title="や",
                    QuestionId=17,
                },
                new QuestionItem()
                {
                    Title="よる",
                    QuestionId=17,
                },
                new QuestionItem()
                {
                    Title="なか",
                    QuestionId=17,
                },
                new QuestionItem()
                {
                    Title="ふゆ",
                    QuestionId=17,
                },
                //QUESION 8 TOPIC 2
                new QuestionItem()
                {
                    Title="ちかい",
                    QuestionId=18,
                },
                new QuestionItem()
                {
                    Title="たかい",
                    QuestionId=18,
                },
                new QuestionItem()
                {
                    Title="あんい",
                    QuestionId=18,
                },
                new QuestionItem()
                {
                    Title="やすい",
                    QuestionId=18,
                },
                //QUESION 9 TOPIC 2
                new QuestionItem()
                {
                    Title="のみます",
                    QuestionId=19,
                },
                new QuestionItem()
                {
                    Title="いたみます",
                    QuestionId=19,
                },
                new QuestionItem()
                {
                    Title="たのしみます",
                    QuestionId=19,
                },
                new QuestionItem()
                {
                    Title="すみます",
                    QuestionId=19,
                },
                //QUESION 10 TOPIC 2
                new QuestionItem()
                {
                    Title="あさごはん",
                    QuestionId=20,
                },
                new QuestionItem()
                {
                    Title="ひるごはん",
                    QuestionId=20,
                },
                new QuestionItem()
                {
                    Title="ばんごはん",
                    QuestionId=20,
                },
                new QuestionItem()
                {
                    Title="こんごはん",
                    QuestionId=20,
                },
                //QUESION 1 TOPIC 3
                new QuestionItem()
                {
                    Title="ちいさい",
                    QuestionId=21,
                },
                new QuestionItem()
                {
                    Title="ちかい",
                    QuestionId=21,
                },
                new QuestionItem()
                {
                    Title="おおきい",
                    QuestionId=21,
                },
                new QuestionItem()
                {
                    Title="おおい",
                    QuestionId=21,
                },
                //QUESION 2 TOPIC 3
                new QuestionItem()
                {
                    Title="しろい",
                    QuestionId=22,
                },
                new QuestionItem()
                {
                    Title="くろい",
                    QuestionId=22,
                },
                new QuestionItem()
                {
                    Title="あかい",
                    QuestionId=22,
                },
                new QuestionItem()
                {
                    Title="あおい",
                    QuestionId=22,
                },
                //QUESION 3 TOPIC 3
                new QuestionItem()
                {
                    Title="にもの",
                    QuestionId=23,
                },
                new QuestionItem()
                {
                    Title="にぶつ",
                    QuestionId=23,
                },
                new QuestionItem()
                {
                    Title="につか",
                    QuestionId=23,
                },
                new QuestionItem()
                {
                    Title="にもつ",
                    QuestionId=23,
                },
                //QUESION 4 TOPIC 3
                new QuestionItem()
                {
                    Title="たべもつ",
                    QuestionId=24,
                },
                new QuestionItem()
                {
                    Title="たべもの",
                    QuestionId=24,
                },
                new QuestionItem()
                {
                    Title="たべぶつ",
                    QuestionId=24,
                },
                new QuestionItem()
                {
                    Title="たへもの",
                    QuestionId=24,
                },
                //QUESION ５ TOPIC 3
                new QuestionItem()
                {
                    Title="いし",
                    QuestionId=25,
                },
                new QuestionItem()
                {
                    Title="みぎ",
                    QuestionId=25,
                },
                new QuestionItem()
                {
                    Title="ひだり",
                    QuestionId=25,
                },
                new QuestionItem()
                {
                    Title="となり",
                    QuestionId=25,
                },
                //QUESION 6 TOPIC 3
                new QuestionItem()
                {
                    Title="おおく",
                    QuestionId=26,
                },
                new QuestionItem()
                {
                    Title="ちいさく",
                    QuestionId=26,
                },
                new QuestionItem()
                {
                    Title="おおきく",
                    QuestionId=26,
                },
                new QuestionItem()
                {
                    Title="ちかい",
                    QuestionId=26,
                },
                //QUESION 7 TOPIC 3
                new QuestionItem()
                {
                    Title="うしろ",
                    QuestionId=27,
                },
                new QuestionItem()
                {
                    Title="あしろ",
                    QuestionId=27,
                },
                new QuestionItem()
                {
                    Title="ごろ",
                    QuestionId=27,
                },
                new QuestionItem()
                {
                    Title="まえろ",
                    QuestionId=27,
                },
                //QUESION 8 TOPIC 3
                new QuestionItem()
                {
                    Title="しゅかみ",
                    QuestionId=28,
                },
                new QuestionItem()
                {
                    Title="でがみ",
                    QuestionId=28,
                },
                new QuestionItem()
                {
                    Title="てがみ",
                    QuestionId=28,
                },
                new QuestionItem()
                {
                    Title="しゅがみ",
                    QuestionId=28,
                },
                //QUESION 9 TOPIC 3
                new QuestionItem()
                {
                    Title="いぬ",
                    QuestionId=29,
                },
                new QuestionItem()
                {
                    Title="ねこ",
                    QuestionId=29,
                },
                new QuestionItem()
                {
                    Title="ねずみ",
                    QuestionId=29,
                },
                new QuestionItem()
                {
                    Title="か",
                    QuestionId=29,
                },
                //QUESION 10 TOPIC 3
                new QuestionItem()
                {
                    Title="ちゅう",
                    QuestionId=30,
                },
                new QuestionItem()
                {
                    Title="なか",
                    QuestionId=30,
                },
                new QuestionItem()
                {
                    Title="よる",
                    QuestionId=30,
                },
                new QuestionItem()
                {
                    Title="なま",
                    QuestionId=30,
                },
            };
            questionItems.ForEach(x => context.QuestionItems.Add(x));
            context.SaveChanges();
            #endregion
        }
    }
}
