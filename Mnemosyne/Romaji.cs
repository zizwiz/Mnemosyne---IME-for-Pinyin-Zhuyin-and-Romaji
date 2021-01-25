using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mnemosyne
{
    public partial class Form1
    {
        string[][] romaji = new string[967][];

        private void cmbobx_romaji_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            

            romaji[0] = new string[] { "-", "\u30fc" };
            romaji[1] = new string[] { "a", "\u3042", "\u3041", "\u30a2", "\u30a1", "\u963f", "\u5516", "\u4e9c", "\u5a03" };
            romaji[2] = new string[] { "abu", "\u867b" };
            romaji[3] = new string[] { "abura", "\u6cb9", "\u8102" };
            romaji[4] = new string[] { "ai", "\u611b", "\u54c0", "\u76f8", "\u6328" };
            romaji[5] = new string[] { "aida", "\u9593" };
            romaji[6] = new string[] { "aka", "\u8d64", "\u57a2" };
            romaji[7] = new string[] { "akane", "\u831c" };
            romaji[8] = new string[] { "akatuki", "\u6681" };
            romaji[9] = new string[] { "akebono", "\u66d9" };
            romaji[10] = new string[] { "aki", "\u79cb", "\u7a50" };
            romaji[11] = new string[] { "aku", "\u60aa", "\u63e1", "\u6e25" };
            romaji[12] = new string[] { "ama", "\u5929", "\u96e8", "\u7518", "\u5c3c" };
            romaji[13] = new string[] { "ame", "\u96e8", "\u98f4", "\u5929" };
            romaji[14] = new string[] { "ami", "\u7db2" };
            romaji[15] = new string[] { "an", "\u5b89", "\u6848", "\u6697", "\u884c", "\u674f", "\u978d", "\u5eb5", "\u95c7", "\u6309" };
            romaji[16] = new string[] { "ana", "\u7a74" };
            romaji[17] = new string[] { "ane", "\u59c9", "\u59d0" };
            romaji[18] = new string[] { "ani", "\u5144" };
            romaji[19] = new string[] { "ao", "\u9752" };
            romaji[20] = new string[] { "aoi", "\u8475" };
            romaji[21] = new string[] { "aragane", "\u9271" };
            romaji[22] = new string[] { "arasi", "\u5d50" };
            romaji[23] = new string[] { "aru", "\u6216" };
            romaji[24] = new string[] { "aruzi", "\u4e3b" };
            romaji[25] = new string[] { "asa", "\u671d", "\u9ebb" };
            romaji[26] = new string[] { "ase", "\u6c57" };
            romaji[27] = new string[] { "asi", "\u8db3", "\u82a6", "\u8466", "\u811a" };
            romaji[28] = new string[] { "atai", "\u5024", "\u4fa1" };
            romaji[29] = new string[] { "atakamo", "\u5b9b" };
            romaji[30] = new string[] { "atama", "\u982d" };
            romaji[31] = new string[] { "atari", "\u8fba" };
            romaji[32] = new string[] { "ate", "\u5b9b" };
            romaji[33] = new string[] { "ato", "\u5f8c", "\u8de1" };
            romaji[34] = new string[] { "atu", "\u7be4", "\u65a1", "\u5727" };
            romaji[35] = new string[] { "awa", "\u6ce1", "\u7c9f" };
            romaji[36] = new string[] { "awase", "\u88b7" };
            romaji[37] = new string[] { "aya", "\u6587", "\u7dbe", "\u7d62" };
            romaji[38] = new string[] { "ayu", "\u4e88" };
            romaji[39] = new string[] { "ayu", "\u9b8e" };
            romaji[40] = new string[] { "aza", "\u5b57" };
            romaji[41] = new string[] { "aze", "\u7566" };
            romaji[42] = new string[] { "azi", "\u5473", "\u9bf5" };
            romaji[43] = new string[] { "azuma", "\u6771" };
            romaji[44] = new string[] { "azusa", "\u6893" };
            romaji[45] = new string[] { "ba", "\u3070", "\u30d0", "\u5834", "\u99ac", "\u7f75", "\u5a46" };
            romaji[46] = new string[] { "bai", "\u500d", "\u966a", "\u8ce0", "\u58f2", "\u8cb7", "\u72fd", "\u7164", "\u6973", "\u6885", "\u5a92", "\u57f9" };
            romaji[47] = new string[] { "baku", "\u9ea6", "\u99c1", "\u83ab", "\u7e1b", "\u7206", "\u6f20", "\u66dd", "\u535a", "\u66b4", "\u5e55" };
            romaji[48] = new string[] { "ban", "\u756a", "\u5224", "\u677f", "\u4e07", "\u6669", "\u76e4", "\u78d0", "\u4f34", "\u86ee", "\u633d", "\u8543" };
            romaji[49] = new string[] { "bati", "\u7f70" };
            romaji[50] = new string[] { "batu", "\u7f70", "\u95a5", "\u629c", "\u4f10", "\u672b", "\u7b4f" };
            romaji[51] = new string[] { "be", "\u3079", "\u30d9", "\u8fba" };
            romaji[52] = new string[] { "bei", "\u7c73" };
            romaji[53] = new string[] { "ben", "\u52c9", "\u97ad", "\u5f01", "\u5a29", "\u4fbf" };
            romaji[54] = new string[] { "beni", "\u7d05" };
            romaji[55] = new string[] { "betu", "\u5225", "\u8511", "\u77a5" };
            romaji[56] = new string[] { "bi", "\u3073", "\u30d3", "\u9f3b", "\u7f8e", "\u7709", "\u6bd8", "\u5fae", "\u5c3e", "\u5099" };
            romaji[57] = new string[] { "bin", "\u74f6", "\u654f", "\u8ca7", "\u4fbf" };
            romaji[58] = new string[] { "bo", "\u307c", "\u30dc", "\u6bcd", "\u66ae", "\u7c3f", "\u620a", "\u6155", "\u5893", "\u52df", "\u6a21" };
            romaji[59] = new string[] { "boku", "\u50d5", "\u6728", "\u7a46", "\u7766", "\u7267", "\u6734", "\u64b2", "\u58a8", "\u535c", "\u76ee" };
            romaji[60] = new string[] { "bon", "\u76c6", "\u51e1" };
            romaji[61] = new string[] { "botan", "\u91e6" };
            romaji[62] = new string[] { "botu", "\u574a" };
            romaji[63] = new string[] { "botu", "\u6ca1", "\u52c3" };
            romaji[64] = new string[] { "bou", "\u67d0", "\u59a8", "\u9632", "\u8cbf", "\u8c8c", "\u8b00", "\u81a8", "\u7d21", "\u5192", "\u68d2", "\u671b", "\u66b4", "\u623f", "\u5fd9", "\u5fd8", "\u574a", "\u5256", "\u508d", "\u4ea1", "\u4e4f", "\u5984", "\u80aa", "\u5e3d" };
            romaji[65] = new string[] { "bu", "\u3076", "\u30d6", "\u5206", "\u90e8", "\u7121", "\u821e", "\u6b66", "\u64ab", "\u4fae", "\u4e0d", "\u6b69", "\u5949", "\u856a" };
            romaji[66] = new string[] { "bun", "\u5206", "\u6587", "\u805e" };
            romaji[67] = new string[] { "buta", "\u8c5a" };
            romaji[68] = new string[] { "butu", "\u7269", "\u4ecf" };
            romaji[69] = new string[] { "byaku", "\u767d" };
            romaji[70] = new string[] { "byou", "\u79d2", "\u5e73", "\u92f2", "\u82d7", "\u75c5", "\u63cf", "\u5edf", "\u732b", "\u9328" };
            romaji[71] = new string[] { "byuu", "\u8b2c" };
            romaji[72] = new string[] { "cha", "\u8336" };
            romaji[73] = new string[] { "chaku", "\u7740", "\u5ae1" };
            romaji[74] = new string[] { "cho", "\u8caf", "\u8457", "\u82e7", "\u7026", "\u6a17", "\u7dd2", "\u732a" };
            romaji[75] = new string[] { "choku", "\u76f4", "\u6357", "\u52c5" };
            romaji[76] = new string[] { "chou", "\u9577", "\u8d85", "\u8087", "\u5f14", "\u91cd", "\u5e33", "\u8abf", "\u5f35", "\u9ce5", "\u9802", "\u8df3", "\u8adc", "\u8776", "\u8178", "\u8139", "\u8074", "\u773a", "\u753a", "\u7252", "\u6f6e", "\u671d", "\u66a2", "\u6311", "\u61f2", "\u5fb4", "\u5f6b", "\u5e81", "\u5e16", "\u5bf5", "\u558b", "\u51cb", "\u5146", "\u4e01", "\u6f84" };
            romaji[77] = new string[] { "chuu", "\u4e2d", "\u6ce8", "\u663c", "\u866b", "\u5b99", "\u99d0", "\u92f3", "\u914e", "\u8a3b", "\u8877", "\u67f1", "\u62bd", "\u5fe0", "\u4ef2" };
            romaji[78] = new string[] { "da", "\u3060", "\u30c0", "\u99c4", "\u9640", "\u6955", "\u8235", "\u67c1", "\u6253", "\u60f0", "\u59a5", "\u5815", "\u553e", "\u86c7" };
            romaji[79] = new string[] { "dai", "\u5927", "\u7b2c", "\u5185", "\u4ee3", "\u53f0", "\u984c", "\u5f1f" };
            romaji[80] = new string[] { "daku", "\u8afe", "\u6fc1" };
            romaji[81] = new string[] { "dan", "\u7537", "\u6bb5", "\u65ad", "\u5f3e", "\u6696", "\u8ac7", "\u6a80", "\u58c7", "\u56e3" };
            romaji[82] = new string[] { "dare", "\u8ab0" };
            romaji[83] = new string[] { "datu", "\u596a", "\u8131" };
            romaji[84] = new string[] { "de", "\u3067", "\u30c7", "\u5f1f" };
            romaji[85] = new string[] { "dei", "\u6ce5" };
            romaji[86] = new string[] { "den", "\u96fb", "\u7530", "\u6fb1", "\u6bbf", "\u4f1d" };
            romaji[87] = new string[] { "di", "\u3062", "\u30c2" };
            romaji[88] = new string[] { "do", "\u3069", "\u30c9", "\u5ea6", "\u5974", "\u571f", "\u6012", "\u52aa" };
            romaji[89] = new string[] { "doku", "\u6bd2", "\u8aad", "\u72ec" };
            romaji[90] = new string[] { "don", "\u920d", "\u66c7", "\u5451" };
            romaji[91] = new string[] { "dono", "\u6bbf" };
            romaji[92] = new string[] { "doro", "\u6ce5" };
            romaji[93] = new string[] { "dou", "\u9053", "\u52d5", "\u77b3", "\u5c0e", "\u540c", "\u9285", "\u80f4", "\u7ae5", "\u6d1e", "\u649e", "\u61a7", "\u5802", "\u50cd" };
            romaji[94] = new string[] { "du", "\u3065", "\u30c5" };
            romaji[95] = new string[] { "e", "\u3048", "\u3047", "\u30a8", "\u30a7", "\u56de", "\u4f1a", "\u7d75", "\u91cd", "\u6075", "\u990c", "\u834f", "\u6c5f", "\u67c4" };
            romaji[96] = new string[] { "eda", "\u679d" };
            romaji[97] = new string[] { "ei", "\u82f1", "\u6620", "\u5f71", "\u92ed", "\u8a60", "\u885b", "\u9834", "\u7a4e", "\u76c8", "\u745b", "\u6d29", "\u6cf3", "\u6c38", "\u6804", "\u66f3", "\u5b30", "\u55b6", "\u53e1" };
            romaji[98] = new string[] { "eki", "\u99c5", "\u5f79", "\u76ca", "\u75ab", "\u6db2", "\u6613" };
            romaji[99] = new string[] { "en", "\u5186", "\u5ef6", "\u7159", "\u6df5", "\u6f14", "\u5869", "\u925b", "\u9060", "\u8597", "\u82d1", "\u8276", "\u7e01", "\u733f", "\u7114", "\u708e", "\u6cbf", "\u63f4", "\u63a9", "\u6028", "\u5bb4", "\u5712", "\u53ad", "\u71d5", "\u5944", "\u9d1b", "\u5830" };
            romaji[100] = new string[] { "enoki", "\u698e" };
            romaji[101] = new string[] { "eri", "\u895f" };
            romaji[102] = new string[] { "etu", "\u95b2", "\u8d8a", "\u8b01", "\u60a6" };
            romaji[103] = new string[] { "fu", "\u3075", "\u30d5", "\u7236", "\u8ca0", "\u9644", "\u8d74", "\u8ce6", "\u8b5c", "\u8150", "\u7b26", "\u6d6e", "\u666e", "\u6577", "\u6276", "\u6016", "\u5e9c", "\u5e03", "\u51a8", "\u5bcc", "\u5a66", "\u592b", "\u57e0", "\u4ed8", "\u4e0d", "\u98a8", "\u6b69", "\u819a", "\u65a7", "\u961c" };
            romaji[104] = new string[] { "fuda", "\u672d" };
            romaji[105] = new string[] { "fude", "\u7b46" };
            romaji[106] = new string[] { "fue", "\u7b1b" };
            romaji[107] = new string[] { "fuki", "\u8557", "\u847a" };
            romaji[108] = new string[] { "fuku", "\u8986", "\u5e45", "\u8179", "\u798f", "\u670d", "\u8907", "\u5fa9", "\u526f", "\u4f0f" };
            romaji[109] = new string[] { "fukuro", "\u888b" };
            romaji[110] = new string[] { "fumi", "\u6587" };
            romaji[111] = new string[] { "fun", "\u5206", "\u7cde", "\u96f0", "\u7d1b", "\u7c89", "\u596e", "\u711a", "\u626e", "\u61a4", "\u58b3", "\u5674", "\u543b" };
            romaji[112] = new string[] { "funa", "\u9b92", "\u8239", "\u821f" };
            romaji[113] = new string[] { "fune", "\u8239", "\u821f" };
            romaji[114] = new string[] { "fusa", "\u623f" };
            romaji[115] = new string[] { "fusi", "\u7bc0" };
            romaji[116] = new string[] { "fusuma", "\u8956" };
            romaji[117] = new string[] { "futa", "\u4e8c", "\u53cc" };
            romaji[118] = new string[] { "futi", "\u6df5", "\u7e01" };
            romaji[119] = new string[] { "futokoro", "\u61d0" };
            romaji[120] = new string[] { "futu", "\u6cb8", "\u6255", "\u5f17" };
            romaji[121] = new string[] { "fuu", "\u98a8", "\u5c01", "\u592b", "\u5bcc", "\u6953" };
            romaji[122] = new string[] { "fuyu", "\u51ac" };
            romaji[123] = new string[] { "ga", "\u304c", "\u30ac", "\u6211", "\u99d5", "\u9913", "\u96c5", "\u8cc0", "\u86fe", "\u82bd", "\u81e5", "\u753b", "\u7259", "\u4fc4", "\u5ce8" };
            romaji[124] = new string[] { "gai", "\u5916", "\u8857", "\u5bb3", "\u6982", "\u9ab8", "\u93a7", "\u8a72", "\u84cb", "\u788d", "\u6daf", "\u6168", "\u5d16", "\u52be", "\u51f1", "\u54b3" };
            romaji[125] = new string[] { "gaku", "\u697d", "\u984d", "\u5b66", "\u984e", "\u5cb3" };
            romaji[126] = new string[] { "gan", "\u5143", "\u9854", "\u4e38", "\u542b", "\u9858", "\u9811", "\u96c1", "\u8d0b", "\u7feb", "\u5ca9", "\u773c", "\u764c", "\u73a9", "\u5dcc", "\u5cb8" };
            romaji[127] = new string[] { "gara", "\u67c4" };
            romaji[128] = new string[] { "gatu", "\u5408" };
            romaji[129] = new string[] { "gatu", "\u6708" };
            romaji[130] = new string[] { "ge", "\u3052", "\u30b2", "\u4e0b", "\u5916", "\u89e3" };
            romaji[131] = new string[] { "gei", "\u9be8", "\u8fce", "\u82b8" };
            romaji[132] = new string[] { "geki", "\u6fc0", "\u6483", "\u621f", "\u5287", "\u9699" };
            romaji[133] = new string[] { "gen", "\u539f", "\u73fe", "\u8a00", "\u9650", "\u6e90", "\u5143", "\u6e1b", "\u53b3", "\u7384", "\u5f26", "\u5e7b", "\u8237", "\u9a13", "\u5acc", "\u7d43", "\u8afa", "\u773c" };
            romaji[134] = new string[] { "getu", "\u6708" };
            romaji[135] = new string[] { "gi", "\u304e", "\u30ae", "\u6280", "\u7591", "\u8b70", "\u8abc", "\u87fb", "\u7fa9", "\u7947", "\u6b3a", "\u64ec", "\u622f", "\u5b9c", "\u5993", "\u5100", "\u507d", "\u72a0" };
            romaji[136] = new string[] { "gin", "\u9280", "\u541f" };
            romaji[137] = new string[] { "go", "\u3054", "\u30b4", "\u5f8c", "\u8a9e", "\u5fa1", "\u8aa4", "\u8b77", "\u7881", "\u68a7", "\u609f", "\u543e", "\u5449", "\u5348", "\u4f0d", "\u4e92", "\u4e94", "\u671f", "\u5a2f" };
            romaji[138] = new string[] { "goku", "\u7344", "\u6975" };
            romaji[139] = new string[] { "gon", "\u8a00", "\u6a29" };
            romaji[140] = new string[] { "goro", "\u9803" };
            romaji[141] = new string[] { "gou", "\u5408", "\u53f7", "\u5f37", "\u8f5f", "\u8c6a", "\u6fe0", "\u62f7", "\u58d5", "\u52ab", "\u525b", "\u696d", "\u90f7" };
            romaji[142] = new string[] { "gu", "\u3050", "\u30b0", "\u865e", "\u611a", "\u5177" };
            romaji[143] = new string[] { "gun", "\u7fa4", "\u90e1", "\u8ecd" };
            romaji[144] = new string[] { "guu", "\u9685", "\u9047", "\u5bd3", "\u5076", "\u5bae" };
            romaji[145] = new string[] { "gyaku", "\u9006", "\u8650" };
            romaji[146] = new string[] { "gyo", "\u9b5a", "\u5fa1", "\u79a6", "\u6f01" };
            romaji[147] = new string[] { "gyoku", "\u7389" };
            romaji[148] = new string[] { "gyou", "\u884c", "\u4ef0", "\u696d", "\u6681", "\u5c2d", "\u51dd", "\u5f62" };
            romaji[149] = new string[] { "gyuu", "\u725b" };
            romaji[150] = new string[] { "ha", "\u306f", "\u30cf", "\u7834", "\u8449", "\u6b6f", "\u6ce2", "\u7aef", "\u6d3e", "\u8987", "\u64ad", "\u628a", "\u5df4", "\u7fbd", "\u5203" };
            romaji[151] = new string[] { "haba", "\u5e45" };
            romaji[152] = new string[] { "hada", "\u808c" };
            romaji[153] = new string[] { "hadaka", "\u88f8" };
            romaji[154] = new string[] { "hae", "\u877f" };
            romaji[155] = new string[] { "hagane", "\u92fc" };
            romaji[156] = new string[] { "hagi", "\u8429", "\u77e7" };
            romaji[157] = new string[] { "haha", "\u6bcd" };
            romaji[158] = new string[] { "hai", "\u80cc", "\u914d", "\u8f29", "\u80ba", "\u724c", "\u76c3", "\u676f", "\u6557", "\u6392", "\u62dd", "\u5ec3", "\u4ff3", "\u7070" };
            romaji[159] = new string[] { "haka", "\u5893" };
            romaji[160] = new string[] { "hakama", "\u88b4" };
            romaji[161] = new string[] { "hakari", "\u79e4" };
            romaji[162] = new string[] { "hako", "\u7bb1", "\u51fd" };
            romaji[163] = new string[] { "haku", "\u6cca", "\u767d", "\u8584", "\u8feb", "\u8236", "\u7c95", "\u7b94", "\u67cf", "\u62cd", "\u535a", "\u5265", "\u4f2f" };
            romaji[164] = new string[] { "hama", "\u6d5c" };
            romaji[165] = new string[] { "hamaguri", "\u86e4" };
            romaji[166] = new string[] { "han", "\u7248", "\u534a", "\u5742", "\u5224", "\u53cd", "\u98ef", "\u9812", "\u7169", "\u91c6", "\u7bc4", "\u8ca9", "\u85e9", "\u822c", "\u7e41", "\u7554", "\u73ed", "\u72af", "\u6c4e", "\u6c3e", "\u677f", "\u6591", "\u642c", "\u5e06", "\u53db", "\u4f34", "\u51e1" };
            romaji[167] = new string[] { "hana", "\u82b1", "\u9f3b", "\u83ef" };
            romaji[168] = new string[] { "hanasi", "\u8a71", "\u567a" };
            romaji[169] = new string[] { "hanawa", "\u5859" };
            romaji[170] = new string[] { "hane", "\u7fbd" };
            romaji[171] = new string[] { "hara", "\u8179", "\u539f" };
            romaji[172] = new string[] { "hari", "\u91dd" };
            romaji[173] = new string[] { "haru", "\u6625" };
            romaji[174] = new string[] { "haruka", "\u9065" };
            romaji[175] = new string[] { "hasi", "\u7bb8", "\u6a4b", "\u7aef" };
            romaji[176] = new string[] { "hasira", "\u67f1" };
            romaji[177] = new string[] { "hasu", "\u84ee" };
            romaji[178] = new string[] { "hata", "\u5e61", "\u65d7", "\u6a5f", "\u7aef", "\u7551" };
            romaji[179] = new string[] { "hatake", "\u7560", "\u7551" };
            romaji[180] = new string[] { "hati", "\u9262", "\u516b", "\u8702" };
            romaji[181] = new string[] { "hato", "\u9ce9" };
            romaji[182] = new string[] { "hatu", "\u6cd5" };
            romaji[183] = new string[] { "hatu", "\u9aea", "\u521d", "\u767a", "\u9197", "\u6e8c" };
            romaji[184] = new string[] { "hayabusa", "\u96bc" };
            romaji[185] = new string[] { "hayasi", "\u6797" };
            romaji[186] = new string[] { "hazama", "\u7872" };
            romaji[187] = new string[] { "haze", "\u6ae8" };
            romaji[188] = new string[] { "hazi", "\u6065" };
            romaji[189] = new string[] { "hazime", "\u8087" };
            romaji[190] = new string[] { "hazu", "\u7b48" };
            romaji[191] = new string[] { "hazure", "\u5916" };
            romaji[192] = new string[] { "he", "\u3078", "\u30d8" };
            romaji[193] = new string[] { "hebi", "\u86c7" };
            romaji[194] = new string[] { "hei", "\u9589", "\u5e73", "\u965b", "\u853d", "\u4e26", "\u67c4", "\u5f0a", "\u5e63", "\u5840", "\u5175", "\u4f75", "\u4e19", "\u75c5" };
            romaji[195] = new string[] { "heki", "\u58c1", "\u78a7", "\u7656", "\u50fb" };
            romaji[196] = new string[] { "hen", "\u5909", "\u8fba", "\u7de8", "\u8fd4", "\u904d", "\u7bc7", "\u7247", "\u504f" };
            romaji[197] = new string[] { "hera", "\u7b86" };
            romaji[198] = new string[] { "hi", "\u3072", "\u30d2", "\u65e5", "\u5f7c", "\u6bd4", "\u6249", "\u706b", "\u967d", "\u8cbb", "\u6a0b", "\u98db", "\u975e", "\u907f", "\u8ab9", "\u88ab", "\u80a5", "\u7f77", "\u7dcb", "\u79d8", "\u7891", "\u76ae", "\u75b2", "\u6ccc", "\u6590", "\u62ab", "\u6279", "\u60b2", "\u5e87", "\u5983", "\u5426", "\u5351", "\u532a", "\u706f", "\u6c37" };
            romaji[199] = new string[] { "hidari", "\u5de6" };
            romaji[200] = new string[] { "hide", "\u82f1" };
            romaji[201] = new string[] { "hie", "\u7a17" };
            romaji[202] = new string[] { "higasi", "\u6771" };
            romaji[203] = new string[] { "hige", "\u9aed" };
            romaji[204] = new string[] { "hiiragi", "\u67ca" };
            romaji[205] = new string[] { "hikari", "\u5149" };
            romaji[206] = new string[] { "hiki", "\u5339", "\u758b" };
            romaji[207] = new string[] { "hiko", "\u5f66" };
            romaji[208] = new string[] { "hima", "\u6687" };
            romaji[209] = new string[] { "hime", "\u5a9b", "\u59eb" };
            romaji[210] = new string[] { "himo", "\u7d10" };
            romaji[211] = new string[] { "hin", "\u983b", "\u8cd3", "\u8ca7", "\u7015", "\u6d5c", "\u658c", "\u5f6c", "\u54c1" };
            romaji[212] = new string[] { "hinoki", "\u6867" };
            romaji[213] = new string[] { "hira", "\u5e73" };
            romaji[214] = new string[] { "hire", "\u9c2d" };
            romaji[215] = new string[] { "hiro", "\u88d5" };
            romaji[216] = new string[] { "hiru", "\u663c", "\u86ed", "\u849c" };
            romaji[217] = new string[] { "hisi", "\u83f1" };
            romaji[218] = new string[] { "hitai", "\u984d" };
            romaji[219] = new string[] { "hito", "\u4e00", "\u4eba" };
            romaji[220] = new string[] { "hitomi", "\u77b3" };
            romaji[221] = new string[] { "hitu", "\u5fc5", "\u903c", "\u7b46", "\u7562", "\u5f3c", "\u6ccc" };
            romaji[222] = new string[] { "hitugi", "\u68fa" };
            romaji[223] = new string[] { "hituzi", "\u7f8a", "\u672a" };
            romaji[224] = new string[] { "hiza", "\u819d" };
            romaji[225] = new string[] { "hizi", "\u8098" };
            romaji[226] = new string[] { "ho", "\u307b", "\u30db", "\u4fdd", "\u7a42", "\u8f14", "\u88dc", "\u752b", "\u6b69", "\u6355", "\u5703", "\u92ea", "\u8217", "\u706b", "\u5e06" };
            romaji[227] = new string[] { "hodo", "\u7a0b" };
            romaji[228] = new string[] { "hoka", "\u4ed6", "\u5916" };
            romaji[229] = new string[] { "hoko", "\u77db", "\u927e" };
            romaji[230] = new string[] { "hoku", "\u5317" };
            romaji[231] = new string[] { "hon", "\u672c", "\u7ffb", "\u5954", "\u53cd" };
            romaji[232] = new string[] { "hone", "\u9aa8" };
            romaji[233] = new string[] { "honoo", "\u708e" };
            romaji[234] = new string[] { "hoo", "\u982c" };
            romaji[235] = new string[] { "hora", "\u6d1e" };
            romaji[236] = new string[] { "hori", "\u5800" };
            romaji[237] = new string[] { "horo", "\u5e4c" };
            romaji[238] = new string[] { "hosi", "\u661f" };
            romaji[239] = new string[] { "hotaru", "\u86cd" };
            romaji[240] = new string[] { "hotoke", "\u4ecf" };
            romaji[241] = new string[] { "hotu", "\u6cd5" };
            romaji[242] = new string[] { "hotu", "\u767a" };
            romaji[243] = new string[] { "hou", "\u65b9", "\u6cd5", "\u6ce1", "\u7832", "\u653e", "\u5831", "\u9d6c", "\u9cf3", "\u98fd", "\u92d2", "\u90a6", "\u8c4a", "\u8a2a", "\u84ec", "\u840c", "\u82b3", "\u80de", "\u70f9", "\u670b", "\u6367", "\u62b1", "\u5e96", "\u5d29", "\u5cef", "\u5cf0", "\u5b9d", "\u5949", "\u5446", "\u5305", "\u4ff8", "\u5023", "\u7e2b", "\u5c01", "\u8912", "\u8702" };
            romaji[244] = new string[] { "hyaku", "\u767e" };
            romaji[245] = new string[] { "hyou", "\u8868", "\u8c79", "\u8a55", "\u7968", "\u6f02", "\u6c37", "\u6a19", "\u5f6a", "\u4ff5", "\u62cd", "\u5175", "\u74e2" };
            romaji[246] = new string[] { "i", "\u3044", "\u3043", "\u30a4", "\u30a3", "\u4f4d", "\u70ba", "\u610f", "\u4e95", "\u552f", "\u5982", "\u5049", "\u7570", "\u4ea5", "\u533b", "\u907a", "\u9055", "\u8b02", "\u8863", "\u840e", "\u80c3", "\u7def", "\u7dad", "\u79fb", "\u754f", "\u6613", "\u6170", "\u60df", "\u5c09", "\u5a01", "\u59d4", "\u5937", "\u56f2", "\u4f9d", "\u4f0a", "\u4ee5", "\u6905" };
            romaji[247] = new string[] { "ibara", "\u8328" };
            romaji[248] = new string[] { "ie", "\u5bb6" };
            romaji[249] = new string[] { "ikada", "\u7b4f" };
            romaji[250] = new string[] { "ikari", "\u9328" };
            romaji[251] = new string[] { "ike", "\u6c60" };
            romaji[252] = new string[] { "iki", "\u606f", "\u57df" };
            romaji[253] = new string[] { "iku", "\u90c1", "\u80b2", "\u5e7e" };
            romaji[254] = new string[] { "ikusa", "\u6226" };
            romaji[255] = new string[] { "ima", "\u4eca" };
            romaji[256] = new string[] { "imo", "\u828b" };
            romaji[257] = new string[] { "imouto", "\u59b9" };
            romaji[258] = new string[] { "in", "\u97f3", "\u5f15", "\u5370", "\u96a0", "\u9670", "\u56e0", "\u97fb", "\u9662", "\u852d", "\u80e4", "\u6deb", "\u98f2", "\u59fb", "\u54e1", "\u54bd", "\u5141" };
            romaji[259] = new string[] { "ina", "\u5426" };
            romaji[260] = new string[] { "ine", "\u7a32" };
            romaji[261] = new string[] { "inosisi", "\u732a" };
            romaji[262] = new string[] { "inoti", "\u547d" };
            romaji[263] = new string[] { "inti", "\u540b" };
            romaji[264] = new string[] { "inu", "\u72ac" };
            romaji[265] = new string[] { "iro", "\u8272" };
            romaji[266] = new string[] { "isi", "\u77f3", "\u533b", "\u5e2b" };
            romaji[267] = new string[] { "isizue", "\u790e" };
            romaji[268] = new string[] { "iso", "\u78ef" };
            romaji[269] = new string[] { "ita", "\u677f" };
            romaji[270] = new string[] { "itadaki", "\u9802" };
            romaji[271] = new string[] { "iti", "\u4e00", "\u4f4d", "\u7f6e", "\u58f1", "\u5e02" };
            romaji[272] = new string[] { "ito", "\u7cf8", "\u610f", "\u56f3" };
            romaji[273] = new string[] { "itu", "\u4e00", "\u4e94", "\u9038", "\u6ea2" };
            romaji[274] = new string[] { "iwa", "\u5ca9" };
            romaji[275] = new string[] { "iwasi", "\u9c2f" };
            romaji[276] = new string[] { "iya", "\u5acc" };
            romaji[277] = new string[] { "izumi", "\u6cc9" };
            romaji[278] = new string[] { "ja", "\u90aa", "\u86c7" };
            romaji[279] = new string[] { "jaku", "\u5f31", "\u82e5", "\u5bc2", "\u7740", "\u60f9" };
            romaji[280] = new string[] { "jo", "\u5973", "\u5982", "\u9664", "\u6055", "\u5f90", "\u5e8f", "\u53d9", "\u52a9", "\u92e4" };
            romaji[281] = new string[] { "joku", "\u8fb1" };
            romaji[282] = new string[] { "jou", "\u4e0a", "\u60c5", "\u5e38", "\u5834", "\u72b6", "\u4e57", "\u6761", "\u57ce", "\u5b9a", "\u8b72", "\u4e08", "\u5270", "\u6d44", "\u84b8", "\u91b8", "\u5197", "\u9320", "\u7573", "\u6210", "\u58cc", "\u9759", "\u76db", "\u5b22", "\u6756", "\u4e1e", "\u7a63", "\u64fe" };
            romaji[283] = new string[] { "ju", "\u53d7", "\u9700", "\u7dac", "\u6a39", "\u6388", "\u5bff", "\u546a", "\u5112", "\u5c31" };
            romaji[284] = new string[] { "juku", "\u719f", "\u587e" };
            romaji[285] = new string[] { "jun", "\u9806", "\u9187", "\u9075", "\u5de1", "\u7d14", "\u76fe", "\u6f64", "\u6e96", "\u6df3", "\u6b89", "\u65ec", "\u5faa", "\u51c6", "\u696f" };
            romaji[286] = new string[] { "jutu", "\u8ff0", "\u8853" };
            romaji[287] = new string[] { "juu", "\u91cd", "\u5341", "\u4f4f", "\u5f93", "\u6e0b", "\u67d4", "\u5145", "\u7363", "\u9283", "\u7e26", "\u620e", "\u6c41", "\u4ec0", "\u62fe" };
            romaji[288] = new string[] { "ka", "\u304b", "\u30ab", "\u4e0b", "\u65e5", "\u6b4c", "\u5316", "\u5bb6", "\u4eee", "\u82b1", "\u590f", "\u706b", "\u6687", "\u9999", "\u9774", "\u679c", "\u868a", "\u971e", "\u904e", "\u8fe6", "\u8ca8", "\u8ab2", "\u8766", "\u83d3", "\u83ef", "\u8377", "\u8304", "\u82db", "\u7b87", "\u7a3c", "\u79be", "\u798d", "\u73c2", "\u6cb3", "\u67b6", "\u79d1", "\u5be1", "\u5ac1", "\u5609", "\u53ef", "\u52a0", "\u4f73", "\u4fa1", "\u4f3d", "\u4f55" };
            romaji[289] = new string[] { "kaba", "\u6a3a", "\u691b" };
            romaji[290] = new string[] { "kaban", "\u9784" };
            romaji[291] = new string[] { "kabe", "\u58c1" };
            romaji[292] = new string[] { "kabu", "\u682a", "\u856a" };
            romaji[293] = new string[] { "kabuto", "\u515c" };
            romaji[294] = new string[] { "kado", "\u89d2", "\u9580" };
            romaji[295] = new string[] { "kaede", "\u6953" };
            romaji[296] = new string[] { "kaeru", "\u86d9" };
            romaji[297] = new string[] { "kagami", "\u93e1" };
            romaji[298] = new string[] { "kage", "\u9670", "\u5f71" };
            romaji[299] = new string[] { "kagi", "\u9375", "\u920e" };
            romaji[300] = new string[] { "kagiri", "\u9650" };
            romaji[301] = new string[] { "kago", "\u7bed" };
            romaji[302] = new string[] { "kai", "\u4f1a", "\u56de", "\u89e3", "\u958b", "\u6539", "\u754c", "\u6d77", "\u968e", "\u5feb", "\u4ecb", "\u58ca", "\u68b0", "\u8c9d", "\u6212", "\u7686", "\u7d75", "\u6094", "\u602a", "\u61d0", "\u8857", "\u584a", "\u7070", "\u7532", "\u6590", "\u6062", "\u5efb", "\u9b41", "\u82a5", "\u87f9", "\u6666", "\u62d0" };
            romaji[303] = new string[] { "kaiko", "\u8695" };
            romaji[304] = new string[] { "kairi", "\u6d6c" };
            romaji[305] = new string[] { "kakari", "\u4fc2" };
            romaji[306] = new string[] { "kake", "\u639b" };
            romaji[307] = new string[] { "kaku", "\u78ba", "\u5404", "\u5ba2", "\u899a", "\u9769", "\u9694", "\u95a3", "\u90ed", "\u8f03", "\u8d6b", "\u89d2", "\u7a6b", "\u7372", "\u6bbb", "\u6838", "\u683c", "\u64b9", "\u62e1", "\u5ed3", "\u5687", "\u5283", "\u753b" };
            romaji[308] = new string[] { "kama", "\u938c", "\u91dc", "\u84b2", "\u7aaf", "\u7ac3" };
            romaji[309] = new string[] { "kamado", "\u7ac3" };
            romaji[310] = new string[] { "kami", "\u4e0a", "\u7d19", "\u9aea", "\u795e" };
            romaji[311] = new string[] { "kaminari", "\u96f7" };
            romaji[312] = new string[] { "kamo", "\u9d28" };
            romaji[313] = new string[] { "kan", "\u9593", "\u63db", "\u5dfb", "\u611f", "\u7518", "\u89b3", "\u5b8c", "\u51fd", "\u95a2", "\u8218", "\u9928", "\u97d3", "\u9665", "\u9591", "\u9451", "\u9084", "\u8cab", "\u8acc", "\u839e", "\u8266", "\u809d", "\u7ff0", "\u7f36", "\u7de9", "\u7c21", "\u7ba1", "\u770b", "\u76e3", "\u74b0", "\u6f45", "\u6f97", "\u6f22", "\u6c57", "\u6b53", "\u6b3e", "\u68fa", "\u6853", "\u67d1", "\u6562", "\u61be", "\u6163", "\u60a3", "\u5e79", "\u5e72", "\u5bdb", "\u5b98", "\u59e6", "\u582a", "\u559a", "\u52e7", "\u52d8", "\u520a", "\u5bd2", "\u51a0", "\u4f83", "\u4e7e", "\u795e", "\u7532", "\u7aff" };
            romaji[314] = new string[] { "kana", "\u91d1" };
            romaji[315] = new string[] { "kane", "\u91d1", "\u9418" };
            romaji[316] = new string[] { "kanmuri", "\u51a0" };
            romaji[317] = new string[] { "kano", "\u5f7c" };
            romaji[318] = new string[] { "kao", "\u9854" };
            romaji[319] = new string[] { "kaoru", "\u99a8" };
            romaji[320] = new string[] { "kara", "\u7a7a", "\u6bbb", "\u5510" };
            romaji[321] = new string[] { "karada", "\u4f53" };
            romaji[322] = new string[] { "karasu", "\u70cf" };
            romaji[323] = new string[] { "kare", "\u5f7c" };
            romaji[324] = new string[] { "kari", "\u4eee", "\u72e9" };
            romaji[325] = new string[] { "kasa", "\u7b20", "\u5098" };
            romaji[326] = new string[] { "kasiwa", "\u6822" };
            romaji[327] = new string[] { "kasumi", "\u971e" };
            romaji[328] = new string[] { "kata", "\u65b9", "\u5f62", "\u578b", "\u80a9", "\u6f5f", "\u7247" };
            romaji[329] = new string[] { "kataki", "\u6575" };
            romaji[330] = new string[] { "katamari", "\u584a" };
            romaji[331] = new string[] { "katana", "\u5200" };
            romaji[332] = new string[] { "katati", "\u5f62" };
            romaji[333] = new string[] { "kate", "\u7ce7" };
            romaji[334] = new string[] { "katu", "\u5272", "\u6ed1", "\u4e14", "\u8f44", "\u8910", "\u845b", "\u6e07", "\u6d3b", "\u62ec", "\u6070", "\u559d" };
            romaji[335] = new string[] { "katu", "\u5408" };
            romaji[336] = new string[] { "katuo", "\u9c39" };
            romaji[337] = new string[] { "kawa", "\u5074", "\u5ddd", "\u9769", "\u6cb3", "\u76ae" };
            romaji[338] = new string[] { "kawara", "\u74e6" };
            romaji[339] = new string[] { "kaya", "\u8431", "\u8305", "\u6822" };
            romaji[340] = new string[] { "kayu", "\u7ca5" };
            romaji[341] = new string[] { "kaza", "\u98a8" };
            romaji[342] = new string[] { "kaze", "\u98a8", "\u98a8", "\u90aa" };
            romaji[343] = new string[] { "kazi", "\u68b6" };
            romaji[344] = new string[] { "kazika", "\u9c0d" };
            romaji[345] = new string[] { "kazu", "\u6570" };
            romaji[346] = new string[] { "ke", "\u3051", "\u30b1", "\u6c17", "\u5316", "\u5bb6", "\u6bdb", "\u602a", "\u7941", "\u5366", "\u4eee" };
            romaji[347] = new string[] { "kei", "\u5f62", "\u578b", "\u7cfb", "\u5144", "\u8a08", "\u7d99", "\u6075", "\u8efd", "\u7d4c", "\u50be", "\u9d8f", "\u981a", "\u8b66", "\u8a63", "\u86cd", "\u834a", "\u830e", "\u7f6b", "\u7e4b", "\u6e13", "\u6842", "\u666f", "\u656c", "\u643a", "\u63b2", "\u61a9", "\u6167", "\u6176", "\u5f84", "\u5951", "\u73ea", "\u572d", "\u5553", "\u5211", "\u4fc2", "\u4eac", "\u7af6", "\u5883", "\u7a3d", "\u7566" };
            romaji[348] = new string[] { "kemono", "\u7363" };
            romaji[349] = new string[] { "kemuri", "\u7159" };
            romaji[350] = new string[] { "ken", "\u898b", "\u9593", "\u4ef6", "\u7814", "\u80a9", "\u72ac", "\u5acc", "\u6a29", "\u9a13", "\u9855", "\u967a", "\u9063", "\u8ed2", "\u8ce2", "\u8b19", "\u770c", "\u7d79", "\u786f", "\u732e", "\u727d", "\u691c", "\u6372", "\u62f3", "\u61f8", "\u61b2", "\u5efa", "\u5805", "\u570f", "\u5263", "\u5238", "\u517c", "\u5065", "\u5026", "\u5039", "\u7e6d", "\u9375", "\u55a7" };
            romaji[351] = new string[] { "keta", "\u6841" };
            romaji[352] = new string[] { "ketu", "\u7a74", "\u6c7a", "\u7d50", "\u8a23", "\u8840", "\u6f54", "\u6b20", "\u5091" };
            romaji[353] = new string[] { "ki", "\u304d", "\u30ad", "\u6c17", "\u8a18", "\u671f", "\u6a5f", "\u898f", "\u57fa", "\u6728", "\u8d77", "\u4f01", "\u5e30", "\u5947", "\u8cb4", "\u68c4", "\u5371", "\u5bc4", "\u7d00", "\u5e0c", "\u5b63", "\u9ec4", "\u5668", "\u8ecc", "\u65e2", "\u4e80", "\u63ee", "\u9b3c", "\u5c90", "\u98e2", "\u6c7d", "\u5fcc", "\u751f", "\u559c", "\u9a0e", "\u5e7e", "\u8f1d", "\u65d7", "\u68cb", "\u7a00", "\u7948", "\u6bc5", "\u4f0e", "\u673a", "\u5fbd", "\u5b09", "\u757f" };
            romaji[354] = new string[] { "kibi", "\u9ecd" };
            romaji[355] = new string[] { "kiku", "\u97a0", "\u83ca", "\u63ac" };
            romaji[356] = new string[] { "kimi", "\u541b" };
            romaji[357] = new string[] { "kimo", "\u809d" };
            romaji[358] = new string[] { "kin", "\u4eca", "\u8fd1", "\u91d1", "\u7b4b", "\u8b39", "\u895f", "\u887f", "\u83cc", "\u7dca", "\u79bd", "\u7981", "\u7434", "\u6b3d", "\u6b23", "\u65a4", "\u9326", "\u5dfe", "\u5747", "\u52e4", "\u50c5", "\u82b9" };
            romaji[359] = new string[] { "kine", "\u6775" };
            romaji[360] = new string[] { "kinu", "\u7d79" };
            romaji[361] = new string[] { "kinuta", "\u7827" };
            romaji[362] = new string[] { "kiri", "\u6850", "\u9727" };
            romaji[363] = new string[] { "kiri", "\u7c81" };
            romaji[364] = new string[] { "kisi", "\u5cb8" };
            romaji[365] = new string[] { "kita", "\u5317" };
            romaji[366] = new string[] { "kiti", "\u5409" };
            romaji[367] = new string[] { "kitu", "\u8a70", "\u6a58", "\u55ab", "\u5403", "\u5409", "\u6854" };
            romaji[368] = new string[] { "kiwa", "\u969b" };
            romaji[369] = new string[] { "kizu", "\u50b7" };
            romaji[370] = new string[] { "ko", "\u3053", "\u30b3", "\u5b50", "\u5c0f", "\u500b", "\u6545", "\u53e4", "\u5df1", "\u56fa", "\u5eab", "\u5f27", "\u53bb", "\u62e0", "\u6238", "\u547c", "\u6e56", "\u7c89", "\u8a87", "\u9867", "\u9ec4", "\u6728", "\u9f13", "\u5b64", "\u4e4e", "\u864e", "\u96c7", "\u80a1", "\u80e1", "\u67af", "\u72d0", "\u59d1", "\u865a", "\u8de8", "\u9237", "\u7cca", "\u83f0" };
            romaji[371] = new string[] { "koe", "\u58f0", "\u80a5" };
            romaji[372] = new string[] { "koi", "\u604b", "\u9bc9" };
            romaji[373] = new string[] { "kokono", "\u4e5d" };
            romaji[374] = new string[] { "kokoro", "\u5fc3" };
            romaji[375] = new string[] { "kokoro", "\u5fd7" };
            romaji[376] = new string[] { "koku", "\u56fd", "\u9ed2", "\u9d60", "\u9177", "\u7a40", "\u544a", "\u523b", "\u514b", "\u77f3", "\u8c37" };
            romaji[377] = new string[] { "koma", "\u72db", "\u99d2" };
            romaji[378] = new string[] { "komainu", "\u72db" };
            romaji[379] = new string[] { "kome", "\u7c73" };
            romaji[380] = new string[] { "komi", "\u8fbc" };
            romaji[381] = new string[] { "komo", "\u83f0" };
            romaji[382] = new string[] { "komu", "\u8fbc" };
            romaji[383] = new string[] { "kon", "\u4eca", "\u91d1", "\u6df7", "\u6839", "\u9b42", "\u826e", "\u7d3a", "\u75d5", "\u68b1", "\u6606", "\u660f", "\u61c7", "\u6068", "\u5a5a", "\u58be", "\u5764", "\u56f0", "\u732e", "\u5efa" };
            romaji[384] = new string[] { "kona", "\u7c89" };
            romaji[385] = new string[] { "koori", "\u6c37" };
            romaji[386] = new string[] { "kore", "\u6b64" };
            romaji[387] = new string[] { "koro", "\u9803" };
            romaji[388] = new string[] { "koromo", "\u8863" };
            romaji[389] = new string[] { "kosi", "\u8170" };
            romaji[390] = new string[] { "kosiki", "\u7511" };
            romaji[391] = new string[] { "kotae", "\u7b54" };
            romaji[392] = new string[] { "koto", "\u4e8b", "\u7570", "\u8a00", "\u6b8a", "\u7434" };
            romaji[393] = new string[] { "kotobuki", "\u5bff" };
            romaji[394] = new string[] { "kotu", "\u9aa8", "\u60da", "\u5ffd" };
            romaji[395] = new string[] { "kou", "\u884c", "\u9ad8", "\u69cb", "\u5de5", "\u516c", "\u5411", "\u52b9", "\u6821", "\u4ea4", "\u8003", "\u9805", "\u7a3f", "\u5f8c", "\u66f4", "\u8b1b", "\u597d", "\u5e83", "\u5019", "\u5e78", "\u5eb7", "\u6297", "\u7d05", "\u964d", "\u8cfc", "\u529f", "\u8ca2", "\u5149", "\u822a", "\u7532", "\u53e3", "\u683c", "\u8208", "\u8352", "\u6052", "\u6e2f", "\u795e", "\u5b5d", "\u7687", "\u653b", "\u539a", "\u8015", "\u9271", "\u614c", "\u9175", "\u80af", "\u786c", "\u6d69", "\u6c5f", "\u6897", "\u62d8", "\u5de7", "\u5b54", "\u4ef0", "\u9999", "\u92fc", "\u90ca", "\u8861", "\u7db1", "\u6d2a", "\u63a7", "\u6643", "\u9ec4", "\u52fe", "\u5f18", "\u4faf", "\u7d5e", "\u6e9d", "\u5751", "\u818f", "\u8154", "\u6602", "\u7d18", "\u5b8f", "\u9d3b", "\u5589", "\u4f7c", "\u57a2", "\u676d", "\u5016", "\u8017", "\u95a4", "\u783f", "\u80b1", "\u5e9a", "\u540e", "\u5df7", "\u7ce0" };
            romaji[396] = new string[] { "kouzi", "\u9eb9" };
            romaji[397] = new string[] { "kowa", "\u58f0" };
            romaji[398] = new string[] { "koyomi", "\u66a6" };
            romaji[399] = new string[] { "ku", "\u304f", "\u30af", "\u53e3", "\u82e6", "\u5de5", "\u99c8", "\u99c6", "\u8eaf", "\u77e9", "\u7396", "\u72d7", "\u533a", "\u53e5", "\u5036", "\u4e5d", "\u4f9b", "\u8ca2", "\u4e45", "\u5bae", "\u5eab", "\u529f", "\u7d05", "\u99d2" };
            romaji[400] = new string[] { "kubi", "\u9996" };
            romaji[401] = new string[] { "kubo", "\u7aaa" };
            romaji[402] = new string[] { "kuda", "\u7ba1" };
            romaji[403] = new string[] { "kui", "\u676d" };
            romaji[404] = new string[] { "kuki", "\u830e" };
            romaji[405] = new string[] { "kuma", "\u718a", "\u9688" };
            romaji[406] = new string[] { "kume", "\u7c82" };
            romaji[407] = new string[] { "kumi", "\u7d44" };
            romaji[408] = new string[] { "kumo", "\u96f2", "\u8718", "\u86db" };
            romaji[409] = new string[] { "kun", "\u541b", "\u8a13", "\u85ab", "\u52f2" };
            romaji[410] = new string[] { "kuni", "\u56fd" };
            romaji[411] = new string[] { "kura", "\u8535", "\u5009" };
            romaji[412] = new string[] { "kurai", "\u4f4d" };
            romaji[413] = new string[] { "kurenai", "\u7d05" };
            romaji[414] = new string[] { "kuri", "\u7e70", "\u6817" };
            romaji[415] = new string[] { "kuro", "\u9ed2" };
            romaji[416] = new string[] { "kuruma", "\u8eca" };
            romaji[417] = new string[] { "kusa", "\u8349" };
            romaji[418] = new string[] { "kusari", "\u9396" };
            romaji[419] = new string[] { "kusi", "\u6adb", "\u4e32" };
            romaji[420] = new string[] { "kuso", "\u7cde" };
            romaji[421] = new string[] { "kusuri", "\u85ac" };
            romaji[422] = new string[] { "kuti", "\u53e3" };
            romaji[423] = new string[] { "kutibiru", "\u5507" };
            romaji[424] = new string[] { "kutu", "\u9774", "\u6398", "\u6c93", "\u7a9f", "\u5c48" };
            romaji[425] = new string[] { "kutuwa", "\u8f61" };
            romaji[426] = new string[] { "kuu", "\u7a7a" };
            romaji[427] = new string[] { "kuwa", "\u936c", "\u6851" };
            romaji[428] = new string[] { "kuzira", "\u9be8" };
            romaji[429] = new string[] { "kuzu", "\u5c51" };
            romaji[430] = new string[] { "kyaku", "\u5ba2", "\u811a", "\u5374" };
            romaji[431] = new string[] { "kyo", "\u5c45", "\u53bb", "\u8ddd", "\u8a31", "\u865a", "\u6e20", "\u6319", "\u62e0", "\u62d2", "\u5de8", "\u92f8" };
            romaji[432] = new string[] { "kyoku", "\u66f2", "\u5c40", "\u6975" };
            romaji[433] = new string[] { "kyuu", "\u4e45", "\u5438", "\u6025", "\u6ce3", "\u6551", "\u4f11", "\u53ca", "\u6c42", "\u65e7", "\u7d66", "\u7cfe", "\u7d1a", "\u7aae", "\u7a76", "\u7403", "\u7078", "\u6c72", "\u673d", "\u5f13", "\u5bae", "\u4ec7", "\u4e18", "\u4e5d", "\u7b08" };
            romaji[434] = new string[] { "ma", "\u307e", "\u30de", "\u9593", "\u76ee", "\u771f", "\u9ebb", "\u9b54", "\u78e8", "\u6469", "\u99ac" };
            romaji[435] = new string[] { "maborosi", "\u5e7b" };
            romaji[436] = new string[] { "made", "\u8fc4" };
            romaji[437] = new string[] { "mado", "\u7a93" };
            romaji[438] = new string[] { "mae", "\u524d" };
            romaji[439] = new string[] { "mago", "\u5b6b" };
            romaji[440] = new string[] { "maguro", "\u9baa" };
            romaji[441] = new string[] { "mai", "\u679a", "\u6bce", "\u6627", "\u59b9", "\u57cb", "\u821e", "\u7c73" };
            romaji[442] = new string[] { "mairu", "\u54e9" };
            romaji[443] = new string[] { "maki", "\u5dfb", "\u69d9", "\u7267" };
            romaji[444] = new string[] { "makoto", "\u8aa0" };
            romaji[445] = new string[] { "maku", "\u819c", "\u5e55" };
            romaji[446] = new string[] { "makura", "\u6795" };
            romaji[447] = new string[] { "mama", "\u4fad" };
            romaji[448] = new string[] { "mame", "\u8c46" };
            romaji[449] = new string[] { "man", "\u4e07", "\u6e80", "\u6f2b", "\u6162", "\u8513" };
            romaji[450] = new string[] { "manako", "\u773c" };
            romaji[451] = new string[] { "maro", "\u9ebf" };
            romaji[452] = new string[] { "maru", "\u4e38" };
            romaji[453] = new string[] { "masa", "\u6b63", "\u67fe" };
            romaji[454] = new string[] { "masu", "\u685d", "\u9c52", "\u5347", "\u821b" };
            romaji[455] = new string[] { "mata", "\u53c8", "\u4fe3", "\u4ea6" };
            romaji[456] = new string[] { "mati", "\u8857", "\u753a" };
            romaji[457] = new string[] { "mato", "\u7684" };
            romaji[458] = new string[] { "matu", "\u653f" };
            romaji[459] = new string[] { "matu", "\u677e", "\u672b", "\u6cab", "\u62b9" };
            romaji[460] = new string[] { "mayu", "\u7e6d" };
            romaji[461] = new string[] { "mayuzumi", "\u9edb" };
            romaji[462] = new string[] { "me", "\u3081", "\u30e1", "\u76ee", "\u5973", "\u82bd", "\u96cc" };
            romaji[463] = new string[] { "mei", "\u540d", "\u660e", "\u547d", "\u8ff7", "\u59ea", "\u9cf4", "\u9298", "\u76df", "\u51a5" };
            romaji[464] = new string[] { "men", "\u9762", "\u9eba", "\u7dec", "\u7dbf", "\u68c9", "\u514d" };
            romaji[465] = new string[] { "mesi", "\u98ef" };
            romaji[466] = new string[] { "mesu", "\u725d", "\u96cc" };
            romaji[467] = new string[] { "metu", "\u6ec5" };
            romaji[468] = new string[] { "mi", "\u307f", "\u30df", "\u5b9f", "\u5473", "\u4e09", "\u8eab", "\u672a", "\u7b95", "\u5df3", "\u9b45" };
            romaji[469] = new string[] { "midori", "\u7dd1" };
            romaji[470] = new string[] { "migi", "\u53f3" };
            romaji[471] = new string[] { "migi", "\u8a54" };
            romaji[472] = new string[] { "miki", "\u5e79" };
            romaji[473] = new string[] { "mimi", "\u8033" };
            romaji[474] = new string[] { "min", "\u7720", "\u6c11" };
            romaji[475] = new string[] { "mina", "\u7686" };
            romaji[476] = new string[] { "minami", "\u5357" };
            romaji[477] = new string[] { "minamoto", "\u6e90" };
            romaji[478] = new string[] { "minato", "\u6e4a", "\u6e2f" };
            romaji[479] = new string[] { "mine", "\u5cf0" };
            romaji[480] = new string[] { "mino", "\u84d1" };
            romaji[481] = new string[] { "minoru", "\u7a14" };
            romaji[482] = new string[] { "miri", "\u7c8d" };
            romaji[483] = new string[] { "miri", "\u7c8d" };
            romaji[484] = new string[] { "misaki", "\u5cac" };
            romaji[485] = new string[] { "misao", "\u64cd" };
            romaji[486] = new string[] { "misasagi", "\u9675" };
            romaji[487] = new string[] { "mise", "\u5e97" };
            romaji[488] = new string[] { "misoka", "\u6666" };
            romaji[489] = new string[] { "miti", "\u9053" };
            romaji[490] = new string[] { "mitu", "\u871c", "\u5bc6" };
            romaji[491] = new string[] { "miya", "\u5bae" };
            romaji[492] = new string[] { "miyako", "\u90fd" };
            romaji[493] = new string[] { "mizo", "\u6e9d" };
            romaji[494] = new string[] { "mizu", "\u6c34" };
            romaji[495] = new string[] { "mizuumi", "\u6e56" };
            romaji[496] = new string[] { "mo", "\u3082", "\u30e2", "\u8302", "\u6a21", "\u6478", "\u55aa" };
            romaji[497] = new string[] { "moku", "\u76ee", "\u6728", "\u6762", "\u9ed9" };
            romaji[498] = new string[] { "momi", "\u7c7e" };
            romaji[499] = new string[] { "momo", "\u6843" };
            romaji[500] = new string[] { "mon", "\u554f", "\u6587", "\u9580", "\u7d0b", "\u60b6", "\u805e" };
            romaji[501] = new string[] { "monme", "\u5301" };
            romaji[502] = new string[] { "mono", "\u7269", "\u8005" };
            romaji[503] = new string[] { "mori", "\u68ee" };
            romaji[504] = new string[] { "moti", "\u9905", "\u52ff" };
            romaji[505] = new string[] { "moto", "\u4e0b", "\u672c", "\u5143", "\u57fa" };
            romaji[506] = new string[] { "motoi", "\u57fa" };
            romaji[507] = new string[] { "motu", "\u7269" };
            romaji[508] = new string[] { "mou", "\u8499", "\u8017", "\u7db2", "\u76f2", "\u731b", "\u6bdb", "\u5b5f", "\u5984", "\u4ea1", "\u671b" };
            romaji[509] = new string[] { "mu", "\u3080", "\u30e0", "\u5922", "\u7121", "\u9727", "\u77db", "\u725f", "\u52d9", "\u6b66", "\u516d", "\u8b00" };
            romaji[510] = new string[] { "mugi", "\u9ea6" };
            romaji[511] = new string[] { "mui", "\u516d" };
            romaji[512] = new string[] { "mukasi", "\u6614" };
            romaji[513] = new string[] { "muko", "\u5a7f" };
            romaji[514] = new string[] { "muku", "\u690b" };
            romaji[515] = new string[] { "muna", "\u80f8", "\u68df" };
            romaji[516] = new string[] { "mune", "\u65e8", "\u80f8", "\u68df" };
            romaji[517] = new string[] { "mura", "\u7fa4", "\u6751" };
            romaji[518] = new string[] { "murasaki", "\u7d2b" };
            romaji[519] = new string[] { "mure", "\u7fa4" };
            romaji[520] = new string[] { "muro", "\u5ba4" };
            romaji[521] = new string[] { "musume", "\u5a18" };
            romaji[522] = new string[] { "myaku", "\u8108" };
            romaji[523] = new string[] { "myou", "\u540d", "\u660e", "\u547d", "\u5999" };
            romaji[524] = new string[] { "na", "\u306a", "\u30ca", "\u540d", "\u90a3", "\u5948", "\u83dc", "\u7d0d", "\u5357" };
            romaji[525] = new string[] { "nabe", "\u934b" };
            romaji[526] = new string[] { "nada", "\u7058" };
            romaji[527] = new string[] { "nae", "\u82d7" };
            romaji[528] = new string[] { "nagara", "\u4e4d" };
            romaji[529] = new string[] { "nagi", "\u51ea", "\u8599" };
            romaji[530] = new string[] { "nagisa", "\u6e1a" };
            romaji[531] = new string[] { "nagu", "\u8599" };
            romaji[532] = new string[] { "nai", "\u5185" };
            romaji[533] = new string[] { "naka", "\u4e2d", "\u4ef2" };
            romaji[534] = new string[] { "nama", "\u751f" };
            romaji[535] = new string[] { "namari", "\u925b" };
            romaji[536] = new string[] { "nami", "\u6ce2", "\u4e26" };
            romaji[537] = new string[] { "namida", "\u6d99" };
            romaji[538] = new string[] { "nan", "\u4f55", "\u96e3", "\u5357", "\u8edf", "\u6960", "\u7537", "\u7d0d" };
            romaji[539] = new string[] { "nana", "\u4e03" };
            romaji[540] = new string[] { "nani", "\u4f55" };
            romaji[541] = new string[] { "nano", "\u4e03" };
            romaji[542] = new string[] { "nanzi", "\u6c5d" };
            romaji[543] = new string[] { "nasi", "\u68a8" };
            romaji[544] = new string[] { "natu", "\u590f", "\u637a" };
            romaji[545] = new string[] { "natu", "\u7d0d" };
            romaji[546] = new string[] { "nawa", "\u7e04", "\u82d7" };
            romaji[547] = new string[] { "nawate", "\u7577" };
            romaji[548] = new string[] { "nazo", "\u8b0e" };
            romaji[549] = new string[] { "ne", "\u306d", "\u30cd", "\u97f3", "\u5024", "\u5bdd", "\u6839", "\u7962", "\u79b0" };
            romaji[550] = new string[] { "negi", "\u8471" };
            romaji[551] = new string[] { "nei", "\u5be7", "\u7962", "\u79b0" };
            romaji[552] = new string[] { "neko", "\u732b" };
            romaji[553] = new string[] { "nen", "\u5e74", "\u5ff5", "\u7c98", "\u71c3", "\u649a", "\u637b", "\u7136" };
            romaji[554] = new string[] { "netu", "\u71b1" };
            romaji[555] = new string[] { "ni", "\u306b", "\u30cb", "\u4e8c", "\u8377", "\u4ec1", "\u5150", "\u5c3c", "\u8fe9", "\u5f10" };
            romaji[556] = new string[] { "nii", "\u65b0" };
            romaji[557] = new string[] { "nijuu", "\u5eff" };
            romaji[558] = new string[] { "niku", "\u8089" };
            romaji[559] = new string[] { "nin", "\u4eba", "\u4efb", "\u598a", "\u5fcd", "\u8a8d" };
            romaji[560] = new string[] { "nira", "\u97ee" };
            romaji[561] = new string[] { "nise", "\u507d" };
            romaji[562] = new string[] { "nisi", "\u897f" };
            romaji[563] = new string[] { "niti", "\u65e5" };
            romaji[564] = new string[] { "niwa", "\u5ead" };
            romaji[565] = new string[] { "niwatori", "\u9d8f" };
            romaji[566] = new string[] { "nizi", "\u8679" };
            romaji[567] = new string[] { "nn", "\u3093", "\u30f3" };
            romaji[568] = new string[] { "no", "\u306e", "\u30ce", "\u57dc", "\u4e4b", "\u5efc", "\u4e43", "\u91ce" };
            romaji[569] = new string[] { "nobu", "\u4fe1" };
            romaji[570] = new string[] { "noki", "\u8ed2" };
            romaji[571] = new string[] { "nomi", "\u86a4" };
            romaji[572] = new string[] { "nori", "\u6cd5", "\u7cca" };
            romaji[573] = new string[] { "noti", "\u5f8c" };
            romaji[574] = new string[] { "nou", "\u8fb2", "\u81bf", "\u8133", "\u80fd", "\u7d0d", "\u6fc3", "\u60a9", "\u56a2" };
            romaji[575] = new string[] { "nu", "\u306c", "\u30cc", "\u5974" };
            romaji[576] = new string[] { "nuka", "\u7ce0" };
            romaji[577] = new string[] { "numa", "\u6cbc" };
            romaji[578] = new string[] { "nuno", "\u5e03" };
            romaji[579] = new string[] { "nusi", "\u4e3b" };
            romaji[580] = new string[] { "nyaku", "\u82e5" };
            romaji[581] = new string[] { "nyo", "\u5973", "\u5982" };
            romaji[582] = new string[] { "nyou", "\u5c3f", "\u5973" };
            romaji[583] = new string[] { "nyuu", "\u5165", "\u4e73" };
            romaji[584] = new string[] { "o", "\u304a", "\u3049", "\u30aa", "\u30a9", "\u6c5a", "\u65bc", "\u7dd2", "\u5c0f", "\u5c3e", "\u96c4", "\u548c" };
            romaji[585] = new string[] { "obi", "\u5e2f" };
            romaji[586] = new string[] { "ogi", "\u837b" };
            romaji[587] = new string[] { "oi", "\u7525", "\u7b08" };
            romaji[588] = new string[] { "oka", "\u4e18", "\u5ca1" };
            romaji[589] = new string[] { "oke", "\u6876" };
            romaji[590] = new string[] { "oki", "\u6c96" };
            romaji[591] = new string[] { "oku", "\u5c4b", "\u5965", "\u81c6", "\u61b6", "\u5104" };
            romaji[592] = new string[] { "omo", "\u4e3b", "\u9762" };
            romaji[593] = new string[] { "omoi", "\u601d" };
            romaji[594] = new string[] { "omomuki", "\u8da3" };
            romaji[595] = new string[] { "omote", "\u8868", "\u9762" };
            romaji[596] = new string[] { "on", "\u97f3", "\u6e29", "\u5fa1", "\u6069", "\u7a4f", "\u9060" };
            romaji[597] = new string[] { "oni", "\u9b3c" };
            romaji[598] = new string[] { "onna", "\u5973" };
            romaji[599] = new string[] { "ono", "\u65a7" };
            romaji[600] = new string[] { "onoono", "\u5404" };
            romaji[601] = new string[] { "onore", "\u5df1" };
            romaji[602] = new string[] { "oo", "\u5927" };
            romaji[603] = new string[] { "ookami", "\u72fc" };
            romaji[604] = new string[] { "oomune", "\u6982" };
            romaji[605] = new string[] { "ooyake", "\u516c" };
            romaji[606] = new string[] { "ore", "\u4ffa" };
            romaji[607] = new string[] { "orosi", "\u5378" };
            romaji[608] = new string[] { "osore", "\u865e" };
            romaji[609] = new string[] { "osu", "\u7261", "\u96c4" };
            romaji[610] = new string[] { "oto", "\u97f3" };
            romaji[611] = new string[] { "otoko", "\u7537" };
            romaji[612] = new string[] { "otouto", "\u5f1f" };
            romaji[613] = new string[] { "otu", "\u4e59" };
            romaji[614] = new string[] { "otuto", "\u592b" };
            romaji[615] = new string[] { "ou", "\u6a2a", "\u685c", "\u5fdc", "\u9ec4", "\u9d0e", "\u7fc1", "\u738b", "\u6bb4", "\u6b27", "\u65fa", "\u62bc", "\u5f80", "\u5965", "\u592e", "\u51f9", "\u7687", "\u9d2c", "\u8956" };
            romaji[616] = new string[] { "ougi", "\u6247" };
            romaji[617] = new string[] { "oya", "\u89aa" };
            romaji[618] = new string[] { "pa", "\u3071", "\u30d1" };
            romaji[619] = new string[] { "pe", "\u307a", "\u30da" };
            romaji[620] = new string[] { "pi", "\u3074", "\u30d4" };
            romaji[621] = new string[] { "po", "\u307d", "\u30dd" };
            romaji[622] = new string[] { "pu", "\u3077", "\u30d7" };
            romaji[623] = new string[] { "ra", "\u3089", "\u30e9", "\u7b49", "\u88f8", "\u87ba", "\u7f85" };
            romaji[624] = new string[] { "rai", "\u6765", "\u96f7", "\u983c", "\u83b1", "\u793c" };
            romaji[625] = new string[] { "raku", "\u697d", "\u843d", "\u916a", "\u7d61", "\u6d1b" };
            romaji[626] = new string[] { "ran", "\u89a7", "\u6b04", "\u5d50", "\u4e71", "\u862d", "\u85cd", "\u6feb", "\u5375" };
            romaji[627] = new string[] { "re", "\u308c", "\u30ec" };
            romaji[628] = new string[] { "rei", "\u4f8b", "\u9f62", "\u9e97", "\u970a", "\u96f6", "\u96b7", "\u9234", "\u82d3", "\u793c", "\u73b2", "\u601c", "\u5dba", "\u52b1", "\u51b7", "\u4f36", "\u4ee4", "\u623b" };
            romaji[629] = new string[] { "reki", "\u6b74", "\u66a6" };
            romaji[630] = new string[] { "ren", "\u604b", "\u84ee", "\u9023", "\u806f", "\u7df4", "\u7c3e", "\u7149", "\u6f23", "\u6190", "\u5ec9", "\u932c" };
            romaji[631] = new string[] { "retu", "\u5217", "\u88c2", "\u70c8", "\u52a3" };
            romaji[632] = new string[] { "ri", "\u308a", "\u30ea", "\u88cf", "\u91cc", "\u96e2", "\u7406", "\u5229", "\u75e2", "\u88e1", "\u7483", "\u674e", "\u5c65", "\u540f", "\u68a8" };
            romaji[633] = new string[] { "riki", "\u529b" };
            romaji[634] = new string[] { "riku", "\u9678" };
            romaji[635] = new string[] { "rin", "\u96a3", "\u8f2a", "\u9e9f", "\u9c57", "\u81e8", "\u7433", "\u71d0", "\u6dcb", "\u6797", "\u5398", "\u502b", "\u9234" };
            romaji[636] = new string[] { "riti", "\u5f8b" };
            romaji[637] = new string[] { "ritu", "\u7387", "\u7acb", "\u844e", "\u5f8b" };
            romaji[638] = new string[] { "ro", "\u308d", "\u30ed", "\u9732", "\u8def", "\u7089", "\u6ad3", "\u9b6f", "\u5442" };
            romaji[639] = new string[] { "roku", "\u7dd1", "\u9332", "\u808b", "\u7984", "\u516d" };
            romaji[640] = new string[] { "ron", "\u8ad6" };
            romaji[641] = new string[] { "rou", "\u6717", "\u90ce", "\u874b", "\u807e", "\u8001", "\u7262", "\u6f0f", "\u6d6a", "\u6994", "\u697c", "\u5f04", "\u5a41", "\u52b4", "\u7ce7", "\u9732", "\u72fc", "\u5eca", "\u7bed" };
            romaji[642] = new string[] { "ru", "\u308b", "\u30eb", "\u6d41", "\u7460" };
            romaji[643] = new string[] { "rui", "\u6d99", "\u985e", "\u7d2f", "\u5841" };
            romaji[644] = new string[] { "ryaku", "\u7565", "\u63a0" };
            romaji[645] = new string[] { "ryo", "\u865c", "\u65c5", "\u616e", "\u4fb6" };
            romaji[646] = new string[] { "ryoku", "\u529b", "\u7dd1" };
            romaji[647] = new string[] { "ryou", "\u91cf", "\u5bee", "\u4e21", "\u9818", "\u9675", "\u907c", "\u8ad2", "\u826f", "\u7ce7", "\u7a1c", "\u77ad", "\u7642", "\u731f", "\u6dbc", "\u6881", "\u6599", "\u51cc", "\u50da", "\u4eae", "\u4e86", "\u6f01", "\u970a" };
            romaji[648] = new string[] { "ryuu", "\u6d41", "\u9686", "\u7acb", "\u9f8d", "\u7adc", "\u7c92", "\u786b", "\u7559", "\u6e9c", "\u5289", "\u67f3" };
            romaji[649] = new string[] { "sa", "\u3055", "\u30b5", "\u5dee", "\u5de6", "\u8336", "\u9396", "\u8a50", "\u7802", "\u7473", "\u6c99", "\u67fb", "\u5506", "\u53c9", "\u4f50", "\u4e9b", "\u518d", "\u4f5c" };
            romaji[650] = new string[] { "saba", "\u9bd6" };
            romaji[651] = new string[] { "sabi", "\u9306", "\u5bc2" };
            romaji[652] = new string[] { "saga", "\u6027", "\u5d6f", "\u5ce8" };
            romaji[653] = new string[] { "sagi", "\u9dfa" };
            romaji[654] = new string[] { "sai", "\u969b", "\u6700", "\u6b73", "\u624d", "\u897f", "\u518d", "\u59bb", "\u8f09", "\u88c1", "\u83dc", "\u7d30", "\u658e", "\u796d", "\u7826", "\u7815", "\u7280", "\u91c7", "\u707d", "\u6e08", "\u683d", "\u63a1", "\u5f69", "\u5bb0", "\u585e", "\u54c9", "\u50ac", "\u50b5", "\u8ca1", "\u6bba", "\u5207" };
            romaji[655] = new string[] { "saka", "\u9152", "\u5742", "\u962a", "\u9006" };
            romaji[656] = new string[] { "sakai", "\u583a", "\u5883" };
            romaji[657] = new string[] { "sakaki", "\u698a" };
            romaji[658] = new string[] { "sakana", "\u9b5a", "\u80b4" };
            romaji[659] = new string[] { "sakasa", "\u9006" };
            romaji[660] = new string[] { "sakazuki", "\u676f" };
            romaji[661] = new string[] { "sake", "\u9152", "\u9bad" };
            romaji[662] = new string[] { "saki", "\u5148", "\u7895", "\u57fc", "\u5d0e", "\u54b2" };
            romaji[663] = new string[] { "saku", "\u4f5c", "\u518a", "\u932f", "\u7d22", "\u7b56", "\u7a84", "\u67f5", "\u6714", "\u6628", "\u643e", "\u548b", "\u524a", "\u9162" };
            romaji[664] = new string[] { "sakura", "\u685c" };
            romaji[665] = new string[] { "sama", "\u69d8" };
            romaji[666] = new string[] { "same", "\u9bab" };
            romaji[667] = new string[] { "samurai", "\u4f8d" };
            romaji[668] = new string[] { "san", "\u5c71", "\u4e09", "\u6563", "\u9910", "\u9178", "\u8cdb", "\u8b83", "\u8695", "\u7e82", "\u7b97", "\u7523", "\u71e6", "\u685f", "\u6492", "\u60e8", "\u53c2", "\u5098" };
            romaji[669] = new string[] { "sao", "\u7aff" };
            romaji[670] = new string[] { "sara", "\u66f4", "\u76bf" };
            romaji[671] = new string[] { "sarasu", "\u6652" };
            romaji[672] = new string[] { "saru", "\u733f" };
            romaji[673] = new string[] { "sasa", "\u7b39" };
            romaji[674] = new string[] { "sati", "\u5e78" };
            romaji[675] = new string[] { "sato", "\u91cc" };
            romaji[676] = new string[] { "satu", "\u65e9" };
            romaji[677] = new string[] { "satu", "\u672d", "\u518a", "\u64e6", "\u85a9", "\u6bba", "\u64ae", "\u5bdf", "\u5237" };
            romaji[678] = new string[] { "satuki", "\u7690" };
            romaji[679] = new string[] { "sawa", "\u6ca2" };
            romaji[680] = new string[] { "sazi", "\u5319" };
            romaji[681] = new string[] { "se", "\u305b", "\u30bb", "\u4e16", "\u80cc", "\u702c", "\u755d", "\u65bd" };
            romaji[682] = new string[] { "sei", "\u751f", "\u58f0", "\u4e16", "\u661f", "\u6210", "\u6027", "\u897f", "\u88fd", "\u6b63", "\u59d3", "\u9752", "\u52e2", "\u6589", "\u9759", "\u9192", "\u901d", "\u8acb", "\u8a93", "\u8aa0", "\u8056", "\u7cbe", "\u76db", "\u6e05", "\u6816", "\u68f2", "\u6674", "\u6574", "\u653f", "\u5f81", "\u5236", "\u51c4", "\u7701", "\u6b73", "\u60c5", "\u5a7f", "\u80cc", "\u7272" };
            romaji[683] = new string[] { "seki", "\u6614", "\u7a4d", "\u5e2d", "\u5915", "\u95a2", "\u5bc2", "\u78a9", "\u8e5f", "\u8de1", "\u8d64", "\u8cac", "\u810a", "\u7e3e", "\u7c4d", "\u77f3", "\u6790", "\u65a5", "\u621a", "\u60dc", "\u96bb", "\u5830", "\u54b3" };
            romaji[684] = new string[] { "semi", "\u8749" };
            romaji[685] = new string[] { "sen", "\u5148", "\u7dda", "\u6226", "\u7e4a", "\u8239", "\u5ddd", "\u9078", "\u5360", "\u9bae", "\u9583", "\u9291", "\u92ad", "\u9077", "\u8df5", "\u8cce", "\u8a6e", "\u85a6", "\u817a", "\u7fa8", "\u7bad", "\u7a7f", "\u65cb", "\u717d", "\u714e", "\u6f5c", "\u67d3", "\u6d17", "\u6d45", "\u6cc9", "\u6813", "\u64b0", "\u6247", "\u5c16", "\u5c02", "\u5ba3", "\u5343", "\u4ed9", "\u821b" };
            romaji[686] = new string[] { "senti", "\u7cce" };
            romaji[687] = new string[] { "senti", "\u7cce" };
            romaji[688] = new string[] { "seri", "\u82b9" };
            romaji[689] = new string[] { "seti", "\u7bc0" };
            romaji[690] = new string[] { "setu", "\u96ea", "\u8aac", "\u7bc0", "\u5207", "\u8a2d", "\u6298", "\u7a83", "\u6442", "\u63a5", "\u62d9", "\u6bba" };
            romaji[691] = new string[] { "sha", "\u8eca", "\u8005", "\u793e", "\u716e", "\u5199", "\u659c", "\u906e", "\u8b1d", "\u7d17", "\u8d66", "\u6368", "\u5c04", "\u820e", "\u7802" };
            romaji[692] = new string[] { "shaku", "\u91c8", "\u501f", "\u5c3a", "\u77f3", "\u7235", "\u914c", "\u6753", "\u707c", "\u932b", "\u6614", "\u52fa" };
            romaji[693] = new string[] { "sho", "\u6240", "\u521d", "\u66f8", "\u6691", "\u8af8", "\u85f7", "\u85af", "\u7f72", "\u7dd2", "\u5eb6", "\u51e6", "\u6e1a", "\u66d9" };
            romaji[694] = new string[] { "shoku", "\u8272", "\u71ed", "\u62ed", "\u98df", "\u8755", "\u89e6", "\u8077", "\u7e54", "\u6b96", "\u690d", "\u98fe", "\u57f4", "\u5631" };
            romaji[695] = new string[] { "shou", "\u5c0f", "\u8a3c", "\u5546", "\u8c61", "\u5c11", "\u6d88", "\u52dd", "\u8cde", "\u5c06", "\u79f0", "\u969c", "\u7167", "\u75c7", "\u7ae0", "\u627f", "\u7701", "\u511f", "\u5531", "\u6b63", "\u7d39", "\u662d", "\u638c", "\u8a73", "\u50b7", "\u885d", "\u5968", "\u751f", "\u6e09", "\u7b11", "\u6027", "\u713c", "\u6676", "\u62db", "\u7126", "\u7965", "\u5f70", "\u53ec", "\u88c5", "\u88f3", "\u76f8", "\u6607", "\u5e8a", "\u677e", "\u5e84", "\u5c1a", "\u7cbe", "\u660c", "\u8a1f", "\u5320", "\u6377", "\u6284", "\u9418", "\u8096", "\u785d", "\u68a2", "\u54e8", "\u91a4", "\u7901", "\u5a3c", "\u4e0a", "\u9798", "\u8a54", "\u58f0", "\u59d3", "\u6a1f", "\u937e", "\u661f", "\u653f", "\u5bb5", "\u5347", "\u9752", "\u6cbc", "\u5ee0", "\u848b", "\u59be", "\u5617", "\u9266", "\u6a35", "\u7ca7", "\u6e58", "\u8549" };
            romaji[696] = new string[] { "shu", "\u624b", "\u4e3b", "\u7a2e", "\u4fee", "\u9996", "\u9152", "\u53d6", "\u8da3", "\u816b", "\u73e0", "\u72e9", "\u6b8a", "\u6731", "\u5b88", "\u8846" };
            romaji[697] = new string[] { "shuku", "\u5bbf", "\u795d", "\u7c9b", "\u7e2e", "\u6dd1", "\u5919", "\u53d4" };
            romaji[698] = new string[] { "shun", "\u6625", "\u77ac", "\u99ff", "\u821c", "\u5cfb", "\u4fca", "\u7ae3" };
            romaji[699] = new string[] { "shutu", "\u51fa" };
            romaji[700] = new string[] { "shuu", "\u96c6", "\u4fee", "\u9031", "\u79cb", "\u795d", "\u62fe", "\u7fd2", "\u919c", "\u916c", "\u8f2f", "\u8e74", "\u8972", "\u8846", "\u821f", "\u81ed", "\u7e4d", "\u7d42", "\u79c0", "\u6d32", "\u6101", "\u5dde", "\u5c31", "\u5b97", "\u5468", "\u53ce", "\u56da", "\u57f7", "\u8b90", "\u8490", "\u914b" };
            romaji[701] = new string[] { "si", "\u3057", "\u30b7", "\u79c1", "\u5b50", "\u6c0f", "\u6307", "\u7d19", "\u8997", "\u4f7f", "\u8a8c", "\u6b7b", "\u65e8", "\u59ff", "\u59c9", "\u4f3a", "\u81f3", "\u5e2b", "\u6b6f", "\u6b62", "\u8a66", "\u98fc", "\u96cc", "\u8cdc", "\u8cc7", "\u8aee", "\u8a69", "\u8a5e", "\u8996", "\u8102", "\u80a2", "\u7d2b", "\u7cf8", "\u7949", "\u7345", "\u679d", "\u65bd", "\u65af", "\u5b5c", "\u652f", "\u601d", "\u5fd7", "\u5e02", "\u5c4d", "\u59cb", "\u58eb", "\u56db", "\u55e3", "\u53f2", "\u53f8", "\u523a", "\u4ed4", "\u4ed5", "\u6b21", "\u793a", "\u81ea", "\u77e2" };
            romaji[702] = new string[] { "siba", "\u829d", "\u67f4" };
            romaji[703] = new string[] { "sibasiba", "\u5c61" };
            romaji[704] = new string[] { "sibe", "\u854a" };
            romaji[705] = new string[] { "sibu", "\u6e0b" };
            romaji[706] = new string[] { "sigi", "\u9d2b" };
            romaji[707] = new string[] { "sika", "\u9e7f" };
            romaji[708] = new string[] { "siki", "\u8272", "\u5f0f", "\u62ed", "\u8b58", "\u7e54" };
            romaji[709] = new string[] { "sima", "\u7e1e", "\u5cf6" };
            romaji[710] = new string[] { "simo", "\u4e0b" };
            romaji[711] = new string[] { "sin", "\u5fc3", "\u65b0", "\u771f", "\u89aa", "\u8eab", "\u795e", "\u4f38", "\u68ee", "\u5bdd", "\u8f9b", "\u8fb0", "\u9032", "\u4fe1", "\u9707", "\u91dd", "\u8a3a", "\u85aa", "\u82af", "\u81e3", "\u7d33", "\u79e6", "\u75b9", "\u7533", "\u6df1", "\u6d78", "\u699b", "\u664b", "\u632f", "\u614e", "\u5be9", "\u5a20", "\u5507", "\u4fb5", "\u8acb" };
            romaji[712] = new string[] { "sina", "\u54c1" };
            romaji[713] = new string[] { "sino", "\u7be0" };
            romaji[714] = new string[] { "sio", "\u6c50", "\u5869", "\u6f6e" };
            romaji[715] = new string[] { "sira", "\u767d" };
            romaji[716] = new string[] { "siri", "\u5c3b" };
            romaji[717] = new string[] { "siro", "\u57ce", "\u767d", "\u4ee3" };
            romaji[718] = new string[] { "siru", "\u6c41" };
            romaji[719] = new string[] { "sirusi", "\u5370" };
            romaji[720] = new string[] { "sisi", "\u5b8d" };
            romaji[721] = new string[] { "sita", "\u4e0b", "\u820c" };
            romaji[722] = new string[] { "siti", "\u8cea", "\u4e03" };
            romaji[723] = new string[] { "sitomi", "\u8500" };
            romaji[724] = new string[] { "situ", "\u5931", "\u8cea", "\u75be", "\u6f06", "\u6e7f", "\u6089", "\u5ba4", "\u5ac9", "\u57f7", "\u53f1" };
            romaji[725] = new string[] { "sizu", "\u9759" };
            romaji[726] = new string[] { "sizuku", "\u96eb", "\u6ef4" };
            romaji[727] = new string[] { "so", "\u305d", "\u30bd", "\u7d44", "\u9f20", "\u9061", "\u963b", "\u8a34", "\u8607", "\u7d20", "\u7c97", "\u79df", "\u7956", "\u790e", "\u758e", "\u758f", "\u72d9", "\u695a", "\u66fd", "\u66fe", "\u5ca8", "\u5851", "\u60f3", "\u63aa" };
            romaji[728] = new string[] { "sode", "\u8896" };
            romaji[729] = new string[] { "soko", "\u5e95" };
            romaji[730] = new string[] { "soku", "\u8db3", "\u5074", "\u901f", "\u606f", "\u5373", "\u6e2c", "\u675f", "\u6349", "\u5247", "\u4fc3" };
            romaji[731] = new string[] { "son", "\u640d", "\u5b58", "\u905c", "\u6751", "\u5c0a", "\u5b6b" };
            romaji[732] = new string[] { "sono", "\u5176", "\u5712" };
            romaji[733] = new string[] { "sora", "\u7a7a" };
            romaji[734] = new string[] { "soregasi", "\u67d0" };
            romaji[735] = new string[] { "soto", "\u5916" };
            romaji[736] = new string[] { "sotu", "\u7387", "\u5352" };
            romaji[737] = new string[] { "sou", "\u9a12", "\u7dcf", "\u5c64", "\u76f8", "\u60f3", "\u9001", "\u65e9", "\u971c", "\u9397", "\u906d", "\u8d70", "\u88c5", "\u85fb", "\u84bc", "\u846c", "\u8358", "\u8349", "\u8061", "\u7d9c", "\u7cdf", "\u7a93", "\u75e9", "\u4e89", "\u71e5", "\u6f15", "\u69fd", "\u69cd", "\u5de3", "\u66f9", "\u64cd", "\u63bb", "\u633f", "\u6383", "\u635c", "\u60e3", "\u5b8b", "\u723d", "\u594f", "\u58ee", "\u55aa", "\u5009", "\u53e2", "\u53cc", "\u5275", "\u50e7", "\u5b97", "\u8d08", "\u531d" };
            romaji[738] = new string[] { "sourou", "\u5019" };
            romaji[739] = new string[] { "su", "\u3059", "\u30b9", "\u7d20", "\u9808", "\u5b50", "\u5b88", "\u5de3", "\u9162", "\u5dde", "\u4e3b", "\u6570", "\u7b25", "\u8acf" };
            romaji[740] = new string[] { "subete", "\u7dcf" };
            romaji[741] = new string[] { "sude", "\u65e2" };
            romaji[742] = new string[] { "sue", "\u672b" };
            romaji[743] = new string[] { "sugata", "\u59ff" };
            romaji[744] = new string[] { "suge", "\u83c5" };
            romaji[745] = new string[] { "sugi", "\u6919", "\u6749" };
            romaji[746] = new string[] { "sui", "\u6c34", "\u5439", "\u9318", "\u9310", "\u9154", "\u9042", "\u8870", "\u7fe0", "\u7c8b", "\u7761", "\u708a", "\u63a8", "\u5e25", "\u5782", "\u51fa", "\u7a42" };
            romaji[747] = new string[] { "suke", "\u4ecb", "\u52a9" };
            romaji[748] = new string[] { "suki", "\u9699", "\u92e4" };
            romaji[749] = new string[] { "sukoburu", "\u9817" };
            romaji[750] = new string[] { "sumi", "\u9685", "\u70ad", "\u58a8" };
            romaji[751] = new string[] { "sun", "\u5bf8" };
            romaji[752] = new string[] { "suna", "\u7802" };
            romaji[753] = new string[] { "suri", "\u647a" };
            romaji[754] = new string[] { "suso", "\u88fe" };
            romaji[755] = new string[] { "suu", "\u6570", "\u96db", "\u8da8", "\u67a2", "\u5d69", "\u5d07" };
            romaji[756] = new string[] { "suzi", "\u7b4b" };
            romaji[757] = new string[] { "suzu", "\u9234" };
            romaji[758] = new string[] { "suzume", "\u96c0" };
            romaji[759] = new string[] { "ta", "\u305f", "\u30bf", "\u4ed6", "\u592a", "\u591a", "\u8a51", "\u6c70", "\u7530", "\u624b" };
            romaji[760] = new string[] { "taba", "\u675f" };
            romaji[761] = new string[] { "tabi", "\u5ea6", "\u65c5" };
            romaji[762] = new string[] { "tada", "\u552f", "\u53ea" };
            romaji[763] = new string[] { "tae", "\u5999" };
            romaji[764] = new string[] { "tai", "\u5927", "\u4ee3", "\u888b", "\u4f53", "\u968a", "\u5bfe", "\u614b", "\u9bdb", "\u902e", "\u9000", "\u8cb8", "\u82d4", "\u817f", "\u80ce", "\u6ede", "\u6cf0", "\u66ff", "\u6234", "\u6020", "\u5f85", "\u5e2f", "\u5cb1", "\u8010", "\u5806", "\u53f0", "\u592a", "\u9edb" };
            romaji[765] = new string[] { "taka", "\u9df9", "\u9ad8" };
            romaji[766] = new string[] { "takara", "\u5b9d" };
            romaji[767] = new string[] { "take", "\u8338", "\u5cb3", "\u4e08", "\u7af9" };
            romaji[768] = new string[] { "taki", "\u7027", "\u6edd" };
            romaji[769] = new string[] { "takigi", "\u85aa" };
            romaji[770] = new string[] { "tako", "\u86f8", "\u51e7" };
            romaji[771] = new string[] { "taku", "\u9438", "\u8a17", "\u7422", "\u6ca2", "\u62d3", "\u629e", "\u6258", "\u5b85", "\u5544", "\u5353", "\u5ea6", "\u6fef" };
            romaji[772] = new string[] { "tama", "\u970a", "\u7389", "\u7403", "\u5f3e" };
            romaji[773] = new string[] { "tamago", "\u5375" };
            romaji[774] = new string[] { "tamasii", "\u9b42" };
            romaji[775] = new string[] { "tame", "\u70ba" };
            romaji[776] = new string[] { "tami", "\u6c11" };
            romaji[777] = new string[] { "tan", "\u5358", "\u7aef", "\u53cd", "\u935b", "\u8a95", "\u80c6", "\u803d", "\u77ed", "\u70ad", "\u6e5b", "\u6de1", "\u6b4e", "\u65e6", "\u63a2", "\u62c5", "\u5766", "\u5606", "\u4e39", "\u7baa" };
            romaji[778] = new string[] { "tana", "\u68da" };
            romaji[779] = new string[] { "tane", "\u7a2e" };
            romaji[780] = new string[] { "tani", "\u8c37" };
            romaji[781] = new string[] { "tanuki", "\u72f8" };
            romaji[782] = new string[] { "tara", "\u9c48" };
            romaji[783] = new string[] { "taru", "\u6a3d" };
            romaji[784] = new string[] { "tatami", "\u7573" };
            romaji[785] = new string[] { "tate", "\u7aea", "\u7e26", "\u696f" };
            romaji[786] = new string[] { "tati", "\u9928" };
            romaji[787] = new string[] { "tatu", "\u8fb0", "\u7adc", "\u9054" };
            romaji[788] = new string[] { "tatumi", "\u5dfd" };
            romaji[789] = new string[] { "tawara", "\u4ff5" };
            romaji[790] = new string[] { "te", "\u3066", "\u30c7", "\u624b" };
            romaji[791] = new string[] { "tei", "\u5b9a", "\u7a0b", "\u9f0e", "\u91d8", "\u912d", "\u90b8", "\u9013", "\u8e44", "\u8ae6", "\u8a02", "\u8247", "\u7de0", "\u798e", "\u7887", "\u6c40", "\u68af", "\u63d0", "\u633a", "\u62b5", "\u608c", "\u5f1f", "\u5ef7", "\u5ead", "\u5e95", "\u5e1d", "\u5824", "\u5448", "\u8c9e", "\u5243", "\u5075", "\u505c", "\u4f4e", "\u4ead", "\u4f53", "\u4e01" };
            romaji[792] = new string[] { "teki", "\u7684", "\u6575", "\u93d1", "\u9069", "\u7b1b", "\u6ef4", "\u64e2", "\u6458" };
            romaji[793] = new string[] { "ten", "\u70b9", "\u5e97", "\u5929", "\u8ee2", "\u985b", "\u751c", "\u7e8f", "\u6dfb", "\u5c55", "\u586b", "\u5178", "\u8cbc", "\u6bbf" };
            romaji[794] = new string[] { "tera", "\u5bfa" };
            romaji[795] = new string[] { "tetu", "\u9244", "\u8fed", "\u8f4d", "\u64a4", "\u5fb9", "\u54f2" };
            romaji[796] = new string[] { "ti", "\u3061", "\u30c1", "\u5024", "\u6065", "\u5730", "\u77e5", "\u8305", "\u99b3", "\u9045", "\u81f4", "\u7f6e", "\u7a1a", "\u75f4", "\u6c60", "\u667a", "\u6cbb", "\u8840", "\u8cea", "\u5343", "\u4e73", "\u5f1b" };
            romaji[797] = new string[] { "tikara", "\u529b" };
            romaji[798] = new string[] { "timata", "\u5df7" };
            romaji[799] = new string[] { "tin", "\u693f", "\u9673", "\u93ae", "\u8cc3", "\u73cd", "\u6c88", "\u6715" };
            romaji[800] = new string[] { "titi", "\u7236", "\u4e73" };
            romaji[801] = new string[] { "titu", "\u7a92", "\u79e9" };
            romaji[802] = new string[] { "to", "\u3068", "\u30c8", "\u90fd", "\u767b", "\u9014", "\u56f3", "\u6238", "\u982d", "\u5341", "\u571f", "\u5f92", "\u6e21", "\u5857", "\u6597", "\u5410", "\u8ced", "\u5ea6", "\u675c", "\u7825", "\u5c60", "\u783a", "\u59ac", "\u5835", "\u934d", "\u514e", "\u83df" };
            romaji[803] = new string[] { "tobi", "\u9cf6" };
            romaji[804] = new string[] { "tobira", "\u6249" };
            romaji[805] = new string[] { "todo", "\u6934" };
            romaji[806] = new string[] { "toi", "\u554f" };
            romaji[807] = new string[] { "toki", "\u6642", "\u9d07" };
            romaji[808] = new string[] { "toko", "\u5e38", "\u5e8a" };
            romaji[809] = new string[] { "tokoro", "\u6240" };
            romaji[810] = new string[] { "toku", "\u7279", "\u5f97", "\u7be4", "\u79bf", "\u7763", "\u6d9c", "\u5fb3", "\u533f", "\u8aad" };
            romaji[811] = new string[] { "toma", "\u82eb" };
            romaji[812] = new string[] { "tomi", "\u5bcc" };
            romaji[813] = new string[] { "tomo", "\u5171", "\u4f9b", "\u53cb" };
            romaji[814] = new string[] { "ton", "\u8c5a", "\u9813", "\u9041", "\u6c8c", "\u6566", "\u60c7", "\u5c6f", "\u5678", "\u56e3", "\u554f" };
            romaji[815] = new string[] { "tonari", "\u96a3" };
            romaji[816] = new string[] { "tono", "\u6bbf" };
            romaji[817] = new string[] { "too", "\u5341" };
            romaji[818] = new string[] { "toori", "\u901a" };
            romaji[819] = new string[] { "tora", "\u5bc5" };
            romaji[820] = new string[] { "tori", "\u9149", "\u9ce5" };
            romaji[821] = new string[] { "toro", "\u701e" };
            romaji[822] = new string[] { "tosi", "\u5e74", "\u6b73" };
            romaji[823] = new string[] { "totu", "\u7a81", "\u51f8" };
            romaji[824] = new string[] { "tou", "\u7b49", "\u982d", "\u5f53", "\u8a0e", "\u8463", "\u6771", "\u6295", "\u51ac", "\u76d7", "\u95d8", "\u9a30", "\u9676", "\u9419", "\u900f", "\u9003", "\u8e0f", "\u8c46", "\u8b04", "\u85e4", "\u8569", "\u5230", "\u7d71", "\u7cd6", "\u7b52", "\u7b54", "\u7977", "\u75d8", "\u71c8", "\u706f", "\u6d9b", "\u6e6f", "\u6dd8", "\u68df", "\u68bc", "\u6843", "\u642d", "\u60bc", "\u5d8b", "\u5cf6", "\u5b95", "\u5957", "\u5858", "\u5854", "\u5510", "\u5200", "\u51cd", "\u515a", "\u5012", "\u767b", "\u8aad", "\u9053", "\u7d0d", "\u9017" };
            romaji[825] = new string[] { "touge", "\u5ce0" };
            romaji[826] = new string[] { "tu", "\u3064", "\u3063", "\u30c4", "\u30c3", "\u6d25", "\u90fd" };
            romaji[827] = new string[] { "tuba", "\u9354" };
            romaji[828] = new string[] { "tubaki", "\u693f" };
            romaji[829] = new string[] { "tubame", "\u71d5" };
            romaji[830] = new string[] { "tubasa", "\u7ffc" };
            romaji[831] = new string[] { "tubo", "\u58f7", "\u576a" };
            romaji[832] = new string[] { "tubu", "\u7c92" };
            romaji[833] = new string[] { "tudoi", "\u96c6" };
            romaji[834] = new string[] { "tudumi", "\u9f13" };
            romaji[835] = new string[] { "tuga", "\u6802" };
            romaji[836] = new string[] { "tuge", "\u67d8" };
            romaji[837] = new string[] { "tugi", "\u6b21" };
            romaji[838] = new string[] { "tui", "\u5bfe", "\u939a", "\u8ffd", "\u69cc", "\u690e", "\u589c" };
            romaji[839] = new string[] { "tuka", "\u585a" };
            romaji[840] = new string[] { "tuki", "\u6708", "\u4ed8", "\u69fb" };
            romaji[841] = new string[] { "tukuda", "\u4f43" };
            romaji[842] = new string[] { "tukue", "\u673a" };
            romaji[843] = new string[] { "tuma", "\u59bb", "\u5b2c" };
            romaji[844] = new string[] { "tume", "\u722a" };
            romaji[845] = new string[] { "tumi", "\u7f6a" };
            romaji[846] = new string[] { "tumu", "\u9318" };
            romaji[847] = new string[] { "tumugi", "\u7d2c" };
            romaji[848] = new string[] { "tuna", "\u7db1" };
            romaji[849] = new string[] { "tune", "\u5e38" };
            romaji[850] = new string[] { "tuno", "\u89d2" };
            romaji[851] = new string[] { "tura", "\u9762" };
            romaji[852] = new string[] { "turi", "\u91e3", "\u540a" };
            romaji[853] = new string[] { "turu", "\u9db4", "\u5f26", "\u8513" };
            romaji[854] = new string[] { "turugi", "\u5263" };
            romaji[855] = new string[] { "tuta", "\u8526" };
            romaji[856] = new string[] { "tuti", "\u571f" };
            romaji[857] = new string[] { "tutu", "\u7832", "\u7b52" };
            romaji[858] = new string[] { "tutumi", "\u5824" };
            romaji[859] = new string[] { "tuu", "\u901a", "\u75db" };
            romaji[860] = new string[] { "tuyu", "\u9732" };
            romaji[861] = new string[] { "tuzi", "\u8fbb" };
            romaji[862] = new string[] { "u", "\u3046", "\u3045", "\u30a6", "\u30a5", "\u96e8", "\u53f3", "\u6709", "\u9d5c", "\u536f", "\u8fc2", "\u7fbd", "\u5b87", "\u70cf" };
            romaji[863] = new string[] { "uba", "\u59e5" };
            romaji[864] = new string[] { "ubu", "\u7523" };
            romaji[865] = new string[] { "ude", "\u8155" };
            romaji[866] = new string[] { "ue", "\u4e0a" };
            romaji[867] = new string[] { "uguisu", "\u9d2c" };
            romaji[868] = new string[] { "ui", "\u521d" };
            romaji[869] = new string[] { "uma", "\u99ac" };
            romaji[870] = new string[] { "umaya", "\u53a9" };
            romaji[871] = new string[] { "ume", "\u6885" };
            romaji[872] = new string[] { "umi", "\u6d77" };
            romaji[873] = new string[] { "un", "\u4e91", "\u904b", "\u96f2" };
            romaji[874] = new string[] { "unagi", "\u9c3b" };
            romaji[875] = new string[] { "une", "\u755d" };
            romaji[876] = new string[] { "uo", "\u9b5a" };
            romaji[877] = new string[] { "ura", "\u88cf", "\u6d66" };
            romaji[878] = new string[] { "uri", "\u74dc" };
            romaji[879] = new string[] { "urusi", "\u6f06" };
            romaji[880] = new string[] { "uruu", "\u958f" };
            romaji[881] = new string[] { "usagi", "\u514e" };
            romaji[882] = new string[] { "usi", "\u725b", "\u4e11" };
            romaji[883] = new string[] { "usiro", "\u5f8c" };
            romaji[884] = new string[] { "uso", "\u5618" };
            romaji[885] = new string[] { "usu", "\u81fc", "\u7893" };
            romaji[886] = new string[] { "uta", "\u6b4c", "\u5504" };
            romaji[887] = new string[] { "utai", "\u8b21" };
            romaji[888] = new string[] { "uti", "\u5185" };
            romaji[889] = new string[] { "utu", "\u851a", "\u6b1d" };
            romaji[890] = new string[] { "utuwa", "\u5668" };
            romaji[891] = new string[] { "uwa", "\u4e0a" };
            romaji[892] = new string[] { "uwasa", "\u5642" };
            romaji[893] = new string[] { "uzi", "\u6c0f" };
            romaji[894] = new string[] { "uzu", "\u6e26" };
            romaji[895] = new string[] { "wa", "\u308f", "\u30ef", "\u8a71", "\u548c", "\u6211", "\u8f2a", "\u502d" };
            romaji[896] = new string[] { "wai", "\u6b6a" };
            romaji[897] = new string[] { "wake", "\u8a33" };
            romaji[898] = new string[] { "waki", "\u8107" };
            romaji[899] = new string[] { "waku", "\u67a0", "\u60d1" };
            romaji[900] = new string[] { "wan", "\u8155", "\u7897", "\u6e7e", "\u6900" };
            romaji[901] = new string[] { "wani", "\u9c10" };
            romaji[902] = new string[] { "wara", "\u85c1" };
            romaji[903] = new string[] { "warabe", "\u7ae5" };
            romaji[904] = new string[] { "warabi", "\u8568" };
            romaji[905] = new string[] { "ware", "\u6211" };
            romaji[906] = new string[] { "wari", "\u5272" };
            romaji[907] = new string[] { "wasi", "\u9df2" };
            romaji[908] = new string[] { "wata", "\u7dbf" };
            romaji[909] = new string[] { "watakusi", "\u79c1" };
            romaji[910] = new string[] { "watasi", "\u79c1" };
            romaji[911] = new string[] { "waza", "\u6280", "\u696d" };
            romaji[912] = new string[] { "ya", "\u3084", "\u3083", "\u30e4", "\u30e3", "\u5c4b", "\u5bb6", "\u591c", "\u77e2", "\u5f25", "\u91ce", "\u8036", "\u723a", "\u51b6", "\u4e5f", "\u516b" };
            romaji[913] = new string[] { "yabu", "\u85ae" };
            romaji[914] = new string[] { "yado", "\u5bbf" };
            romaji[915] = new string[] { "yaku", "\u7d04", "\u5f79", "\u8a33", "\u85ac", "\u8e8d", "\u5384", "\u76ca" };
            romaji[916] = new string[] { "yama", "\u5c71" };
            romaji[917] = new string[] { "yamai", "\u75c5" };
            romaji[918] = new string[] { "yanagi", "\u67f3" };
            romaji[919] = new string[] { "yari", "\u9453" };
            romaji[920] = new string[] { "yasiro", "\u793e" };
            romaji[921] = new string[] { "yasui", "\u9756" };
            romaji[922] = new string[] { "yatu", "\u5974" };
            romaji[923] = new string[] { "yatuko", "\u5974" };
            romaji[924] = new string[] { "yo", "\u3088", "\u3087", "\u30e8", "\u30e7", "\u4ee3", "\u4e16", "\u4f59", "\u591c", "\u4e88", "\u9810", "\u8f3f", "\u8a89", "\u4e0e", "\u56db" };
            romaji[925] = new string[] { "yodo", "\u6dc0" };
            romaji[926] = new string[] { "yoi", "\u5bb5" };
            romaji[927] = new string[] { "yoko", "\u6a2a" };
            romaji[928] = new string[] { "yoku", "\u7ffc", "\u7fcc", "\u6d74", "\u6c83", "\u6b32", "\u6291", "\u617e" };
            romaji[929] = new string[] { "yome", "\u5ac1" };
            romaji[930] = new string[] { "yon", "\u56db" };
            romaji[931] = new string[] { "yone", "\u7c73" };
            romaji[932] = new string[] { "yoroi", "\u93a7" };
            romaji[933] = new string[] { "yoru", "\u591c" };
            romaji[934] = new string[] { "yosi", "\u7531" };
            romaji[935] = new string[] { "you", "\u7528", "\u69d8", "\u8981", "\u967d", "\u9065", "\u8449", "\u990a", "\u8e0a", "\u8b21", "\u8000", "\u7f8a", "\u7aaf", "\u7194", "\u6eb6", "\u6d0b", "\u694a", "\u66dc", "\u64c1", "\u63fa", "\u63da", "\u5eb8", "\u5bb9", "\u5996", "\u5e7c", "\u50ad", "\u8170", "\u516b" };
            romaji[936] = new string[] { "yu", "\u3086", "\u3085", "\u30e6", "\u30e5", "\u8aed", "\u6cb9", "\u7531", "\u8f38", "\u7652", "\u6108", "\u6109", "\u6e6f", "\u904a" };
            romaji[937] = new string[] { "yubi", "\u6307" };
            romaji[938] = new string[] { "yue", "\u6545" };
            romaji[939] = new string[] { "yui", "\u7531", "\u552f" };
            romaji[940] = new string[] { "yuka", "\u5e8a" };
            romaji[941] = new string[] { "yuki", "\u96ea" };
            romaji[942] = new string[] { "yume", "\u5922" };
            romaji[943] = new string[] { "yumi", "\u5f13" };
            romaji[944] = new string[] { "yutaka", "\u88d5" };
            romaji[945] = new string[] { "yuu", "\u6709", "\u512a", "\u7531", "\u5915", "\u53cb", "\u90f5", "\u8a98", "\u88d5", "\u878d", "\u904a", "\u53f3", "\u52c7", "\u96c4", "\u7950", "\u6182", "\u5e7d", "\u60a0", "\u6e67", "\u7336", "\u5ba5", "\u4f51", "\u9091", "\u7337", "\u63d6", "\u6d8c", "\u67da" };
            romaji[946] = new string[] { "za", "\u3056", "\u30b6", "\u5ea7", "\u632b", "\u5750" };
            romaji[947] = new string[] { "zai", "\u8ca1", "\u5728", "\u7f6a", "\u6750", "\u5264" };
            romaji[948] = new string[] { "zan", "\u6b8b", "\u66ab", "\u65ac" };
            romaji[949] = new string[] { "zatu", "\u96d1" };
            romaji[950] = new string[] { "ze", "\u305c", "\u30bc", "\u662f" };
            romaji[951] = new string[] { "zei", "\u7a0e", "\u8106", "\u8aac" };
            romaji[952] = new string[] { "zen", "\u524d", "\u5168", "\u81b3", "\u7e55", "\u7985", "\u7136", "\u6f38", "\u5584" };
            romaji[953] = new string[] { "zeni", "\u92ad" };
            romaji[954] = new string[] { "zetu", "\u7d76", "\u820c" };
            romaji[955] = new string[] { "zi", "\u3058", "\u30b8", "\u6642", "\u4e8b", "\u81ea", "\u5b57", "\u6b21", "\u793a", "\u5730", "\u8f9e", "\u6cbb", "\u5bfa", "\u78c1", "\u6301", "\u4f3c", "\u8def", "\u5150", "\u8033", "\u6148", "\u6ecb", "\u75d4", "\u4f8d", "\u9664", "\u4ed5", "\u74bd", "\u723e", "\u800c", "\u8494" };
            romaji[956] = new string[] { "ziki", "\u76f4", "\u6642", "\u671f" };
            romaji[957] = new string[] { "ziku", "\u5b8d", "\u8ef8", "\u7afa" };
            romaji[958] = new string[] { "zin", "\u4eba", "\u5c3d", "\u976d", "\u9663", "\u8fc5", "\u8a0a", "\u814e", "\u751a", "\u5c0b", "\u58ec", "\u5875", "\u5203", "\u4ec1", "\u795e", "\u81e3" };
            romaji[959] = new string[] { "zitu", "\u5341" };
            romaji[960] = new string[] { "zitu", "\u65e5", "\u5b9f" };
            romaji[961] = new string[] { "zo", "\u305e", "\u30be" };
            romaji[962] = new string[] { "zoku", "\u7d9a", "\u65cf", "\u8cca", "\u5c5e", "\u4fd7" };
            romaji[963] = new string[] { "zon", "\u5b58" };
            romaji[964] = new string[] { "zou", "\u81d3", "\u8d08", "\u9020", "\u8535", "\u618e", "\u5897", "\u50cf", "\u96d1", "\u8c61" };
            romaji[965] = new string[] { "zu", "\u305a", "\u30ba", "\u56f3", "\u982d", "\u8c46", "\u4e8b", "\u53a8" };
            romaji[966] = new string[] { "zui", "\u9ac4", "\u745e", "\u968f" };


            //-------------------------------------------------------------------------------


            rchtxbx_rom_out.Clear();
            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();
            dataGridView3.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 25);
            dataGridView3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            string[] InnerCharArray = romaji[cmbobx_romaji.SelectedIndex];
            int num_col = 6, grid_y = 0, grid_x = 1, index = 0, num_rows = 1, char_num = 1;

            int array_length = InnerCharArray.Length;
            int remainder = (array_length % num_col);

            if ((remainder != 0) && (InnerCharArray.Length > num_col))
            {
                num_rows = (array_length / num_col) + 1; // add extra row as we have more bitmaps but not a full row.
            }
            else
            {
                num_rows = (array_length / num_col);
            }

            while (grid_x < num_rows)
            {

                grid_x = grid_x + 1;
                dataGridView3.Rows.Add();
            }

            grid_x = 0;

            while ((grid_y < num_col) & (char_num < array_length))
            {
                dataGridView3[grid_y, grid_x].Value = InnerCharArray[char_num];

                grid_y = grid_y + 1;
                index = index + 1;
                char_num = char_num + 1;

                if ((char_num <= array_length) & (grid_y >= num_col))
                {
                    grid_y = 0;
                    grid_x = grid_x + 1;
                }
            }

            for (int a = 0; a < InnerCharArray.Length; a++)
            {
                rchtxbx_rom_out.AppendText(InnerCharArray[a] + " ");
            }
            rchtxbx_rom_out.AppendText("\n");



        }

        private void dataGridView3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rchtxbx_rom_msg.AppendText(dataGridView3[e.ColumnIndex, e.RowIndex].Value.ToString());
        }


        private void btn_rom_exit_Click(object sender, System.EventArgs e)
        {
            close();
        }

        private void btn_r_exit_Click(object sender, System.EventArgs e)
        {
            close();
        }

        private void btn_r_reset_input_Click(object sender, System.EventArgs e)
        {
            rchtxbx_z_input.Clear();
        }

        private void btn_r_reset_output_Click(object sender, System.EventArgs e)
        {
            rchtxbx_z_output.Clear();
        }

        private void btn_r_copy_Click(object sender, System.EventArgs e)
        {
            // Select all text in the text box.

            rchtxbx_rom_msg.Focus();
            rchtxbx_rom_msg.Select(0, rchtxbx_rom_msg.Text.Length);

            // Determine if any text is selected in the TextBox control.
            if (rchtxbx_rom_msg.SelectionLength > 0)
            {
                // Copy the contents of the control to the Clipboard.
                rchtxbx_rom_msg.Copy();
            }
            else
            {
                MessageBox.Show("No text to copy");
            }
        }

        private void btn_r_convert_Click(object sender, System.EventArgs e)
        {
            

            for (int i = 0; i < rchtxbx_r_input.Text.Length; i++)
            {

                string answers = "";

                int InPutChar = Convert.ToInt32(rchtxbx_r_input.Text[i]);

                char c = '\u4e00';
                // Implicit conversion: char is basically a 16-bit unsigned integer
                int LowestRomajiChar = c;

                bool doCheck = true, multipleChar = false; //set true if statements will set false.

                if (InPutChar < LowestRomajiChar) //Not Zhuyin so just write out the char
                {
                    rchtxbx_r_output.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 14);
                    rchtxbx_r_output.AppendText(rchtxbx_r_input.Text[i].ToString());
                    doCheck = false;
                }

                if (doCheck == true) //Could be Zhuyin more checks inside
                {
                    for (int j = 0; j < romaji.Length; j++)
                    {

                        string[] InnerCharArray = romaji[j];

                        for (int k = 1; k < InnerCharArray.Length; k++)
                        {
                            string unichar = InnerCharArray[k]; //Get next char to check


                            if (rchtxbx_r_input.Text[i].ToString() == unichar) //&& (doCheck))
                                                                               //check with the char in textbox
                            {
                                if (doCheck == true)
                                {
                                    answers = InnerCharArray[0]; //first time in we have one char
                                }
                                else
                                {
                                    answers += ";" + InnerCharArray[0]; //comes in here if multiple chars for same sound
                                    multipleChar = true;
                                }
                                // rchtxbx_output.AppendText(InnerCharArray[0] + " ");
                                //If the char then put down the sound and space.
                                doCheck = false;

                            }
                        }

                    }


                    if (multipleChar == true)
                    {
                        rchtxbx_r_output.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 14);
                        rchtxbx_r_output.AppendText("(" + answers + ") "); //multiple char
                    }
                    else
                    {
                        rchtxbx_r_output.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 14);
                        rchtxbx_r_output.AppendText(answers + " "); //single char
                    }

                    answers = ""; //reset
                    multipleChar = false; //reset

                    if (doCheck == true)
                    //still true when we have not yet found the item so now we will just put down the item
                    {
                        rchtxbx_r_output.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 14);
                        rchtxbx_r_output.AppendText(rchtxbx_r_input.Text[i].ToString());
                        //not chinese so just put down the Char
                    }

                }
            }

            GC.Collect(); //I see it releases large bits of memory following the array stuff but only collects next time round forced to collect here as well.

        }


        private void rchtxbx_r_input_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
                MenuItem menuItem = new MenuItem("Paste");
                menuItem.Click += new EventHandler(PasteRAction);
                contextMenu.MenuItems.Add(menuItem);

                rchtxbx_r_input.ContextMenu = contextMenu;
            }
        }

        void PasteRAction(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                rchtxbx_r_input.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();
            }
        }
    }
}
