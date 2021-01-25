using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mnemosyne
{
    public partial class Form1
    {

        private void cmbobx_zhu_real_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            cmbobx_zhu.SelectedIndex = cmbobx_zhu_real.SelectedIndex; //line up both drop downs
            renderText();
        }

        private void cmbobx_zhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbobx_zhu_real.SelectedIndex = cmbobx_zhu.SelectedIndex; //line up both drop downs
            renderText();
        }

        string[][] zhuyin = new string[1096][];

        private void renderText()
        {
            


            zhuyin[0] = new string[] { ", = \u311d      ", "\u311D" };
            zhuyin[1] = new string[] { "- = \u3126       ", "\u3126", "\u5152" };
            zhuyin[2] = new string[] { "-3 = \u3126\u02c7       ", "\u8033", "\u990C" };
            zhuyin[3] = new string[] { "-4 = \u3126\u02cb       ", "\u4E8C", "\u8CB3" };
            zhuyin[4] = new string[] { "-6 = \u3126\u02ca       ", "\u800C" };
            zhuyin[5] = new string[] { ". = \u3121       ", "\u3121", "\u6B50", "\u750C", "\u9DD7" };
            zhuyin[6] = new string[] { ".3 = \u3121\u02c7       ", "\u5076", "\u5614", "\u85D5" };
            zhuyin[7] = new string[] { ".6 = \u3121\u02ca       ", "\u5662" };
            zhuyin[8] = new string[] { "/ = \u3125       ", "\u3125" };
            zhuyin[9] = new string[] { "0 = \u3122       ", "\u3122", "\u5B89", "\u92A8", "\u8AF3", "\u978D", "\u6C28", "\u4F92", "\u5EB5", "\u80FA" };
            zhuyin[10] = new string[] { "03 = \u3122\u02c7       ", "\u4FFA" };
            zhuyin[11] = new string[] { "04 = \u3122\u02cb       ", "\u6697", "\u6848", "\u6309", "\u5CB8", "\u95C7", "\u9EEF" };
            zhuyin[12] = new string[] { "1 = \u3105       ", "\u3105" };
            zhuyin[13] = new string[] { "1/ = \u3105\u3125       ", "\u5D29", "\u7E43" };
            zhuyin[14] = new string[] { "1/4 = \u3105\u3125\u02cb       ", "\u8E66", "\u6CF5" };
            zhuyin[15] = new string[] { "1/6 = \u3105\u3125\u02ca       ", "\u752D" };
            zhuyin[16] = new string[] { "10 = \u3105\u3122       ", "\u73ED", "\u642C", "\u822C", "\u6273", "\u9812", "\u6591" };
            zhuyin[17] = new string[] { "103 = \u3105\u3122\u02c7       ", "\u7248", "\u677F", "\u962A", "\u95C6" };
            zhuyin[18] = new string[] { "104 = \u3105\u3122\u02cb       ", "\u8FA6", "\u534A", "\u4F34", "\u62CC", "\u626E", "\u7D46" };
            zhuyin[19] = new string[] { "18 = \u3105\u311a       ", "\u516B", "\u5DF4", "\u82AD", "\u634C", "\u5427", "\u5CC7" };
            zhuyin[20] = new string[] { "183 = \u3105\u311a\u02c7       ", "\u628A", "\u9776" };
            zhuyin[21] = new string[] { "184 = \u3105\u311a\u02cb       ", "\u9738", "\u7238", "\u58E9", "\u7F77" };
            zhuyin[22] = new string[] { "186 = \u3105\u311a\u02ca       ", "\u62D4", "\u8DCB" };
            zhuyin[23] = new string[] { "19 = \u3105\u311e       ", "\u63B0" };
            zhuyin[24] = new string[] { "193 = \u3105\u311e\u02c7       ", "\u767E", "\u64FA", "\u4F70" };
            zhuyin[25] = new string[] { "194 = \u3105\u311e\u02cb       ", "\u6557", "\u62DC" };
            zhuyin[26] = new string[] { "196 = \u3105\u311e\u02ca       ", "\u767D" };
            zhuyin[27] = new string[] { "1; = \u3105\u3124  ", "\u90A6", "\u5E6B" };
            zhuyin[28] = new string[] { "1; 3 = \u3105\u3124\u02c7  ", "\u699C", "\u7D81" };
            zhuyin[29] = new string[] { "1; 4 = \u3105\u3124\u02cb  ", "\u68D2", "\u78C5", "\u8B17", "\u868C" };
            zhuyin[30] = new string[] { "1i = \u3105\u311b       ", "\u73BB", "\u64A5", "\u525D", "\u7F3D", "\u83E0", "\u64AD", "\u6CE2" };
            zhuyin[31] = new string[] { "1i3 = \u3105\u311b\u02c7       ", "\u8DDB", "\u7C38" };
            zhuyin[32] = new string[] { "1i4 = \u3105\u311b\u02cb       ", "\u64D8" };
            zhuyin[33] = new string[] { "1i6 = \u3105\u311b\u02ca       ", "\u4F2F", "\u67CF", "\u535A", "\u8236", "\u6CCA", "\u8116", "\u6A97" };
            zhuyin[34] = new string[] { "1j3 = \u3105\u3128\u02c7       ", "\u6355", "\u88DC", "\u57D4" };
            zhuyin[35] = new string[] { "1j4 = \u3105\u3128\u02cb       ", "\u6B65", "\u4E0D", "\u90E8", "\u5E03", "\u4F48", "\u57E0", "\u7C3F" };
            zhuyin[36] = new string[] { "1l = \u3105\u3120       ", "\u5305", "\u80DE", "\u8912" };
            zhuyin[37] = new string[] { "1l3 = \u3105\u3120\u02c7       ", "\u4FDD", "\u5BF6", "\u5821", "\u98FD" };
            zhuyin[38] = new string[] { "1l4 = \u3105\u3120\u02cb       ", "\u66B4", "\u5831", "\u7206", "\u62B1", "\u9B91", "\u8C79", "\u7011" };
            zhuyin[39] = new string[] { "1l6 = \u3105\u3120\u02ca       ", "\u96F9" };
            zhuyin[40] = new string[] { "1o = \u3105\u311f       ", "\u676F", "\u76C3", "\u80CC", "\u60B2", "\u5351", "\u7891" };
            zhuyin[41] = new string[] { "1o3 = \u3105\u311f\u02c7       ", "\u5317" };
            zhuyin[42] = new string[] { "1o4 = \u3105\u311f\u02cb       ", "\u84D3", "\u500D", "\u88AB", "\u5099", "\u8C9D", "\u8F29" };
            zhuyin[43] = new string[] { "1p = \u3105\u3123       ", "\u5954", "\u8CC1" };
            zhuyin[44] = new string[] { "1p3 = \u3105\u3123\u02c7       ", "\u672C", "\u755A" };
            zhuyin[45] = new string[] { "1p4 = \u3105\u3123\u02cb       ", "\u7B28" };
            zhuyin[46] = new string[] { "1u = \u3105\u3127       ", "\u903C" };
            zhuyin[47] = new string[] { "1u, = \u3105\u3127       ", "\u9C49", "\u618B" };
            zhuyin[48] = new string[] { "1u,3 = \u3105\u3127  ", "\u765F" };
            zhuyin[49] = new string[] { "1u,6 = \u3105\u3127  ", "\u5225" };
            zhuyin[50] = new string[] { "1u/ = \u3105\u3127\u3125       ", "\u51B0", "\u5175" };
            zhuyin[51] = new string[] { "1u/3 = \u3105\u3127\u3125\u02c7       ", "\u70B3", "\u4E19", "\u79C9", "\u67C4" };
            zhuyin[52] = new string[] { "1u/4 = \u3105\u3127\u3125\u02cb       ", "\u4E26", "\u75C5" };
            zhuyin[53] = new string[] { "1u0 = \u3105\u3127\u3122       ", "\u908A", "\u7DE8", "\u97AD", "\u782D", "\u8759" };
            zhuyin[54] = new string[] { "1u03 = \u3105\u3127\u3122\u02c7       ", "\u8CB6", "\u6241" };
            zhuyin[55] = new string[] { "1u04 = \u3105\u3127\u3122\u02cb       ", "\u8B8A", "\u4FBF", "\u904D", "\u8FA8" };
            zhuyin[56] = new string[] { "1u3 = \u3105\u3127\u02c7       ", "\u6BD4", "\u7B46", "\u5F7C" };
            zhuyin[57] = new string[] { "1u4 = \u3105\u3127\u02cb       ", "\u9589", "\u5FC5", "\u5E63", "\u78A7", "\u907F", "\u7562", "\u58C1", "\u81C2" };
            zhuyin[58] = new string[] { "1u6 = \u3105\u3127\u02ca       ", "\u9F3B" };
            zhuyin[59] = new string[] { "1ul = \u3105\u3127\u3120       ", "\u6A19", "\u93E2" };
            zhuyin[60] = new string[] { "1ul3 = \u3105\u3127\u3120\u02c7       ", "\u8868", "\u9336" };
            zhuyin[61] = new string[] { "1up = \u3105\u3127\u3123       ", "\u5F6C", "\u658C", "\u8CD3", "\u6FF1", "\u6AB3" };
            zhuyin[62] = new string[] { "1up4 = \u3105\u3127\u3123\u02cb       ", "\u9B22" };
            zhuyin[63] = new string[] { "2 = \u3109       ", "\u3109" };
            zhuyin[64] = new string[] { "2. = \u3109\u3121       ", "\u90FD", "\u515C" };
            zhuyin[65] = new string[] { "2.3 = \u3109\u3121\u02c7       ", "\u6296", "\u6597" };
            zhuyin[66] = new string[] { "2.4 = \u3109\u3121\u02cb       ", "\u9B25", "\u8C46", "\u9017", "\u7AC7" };
            zhuyin[67] = new string[] { "2/ = \u3109\u3125       ", "\u71C8", "\u767B" };
            zhuyin[68] = new string[] { "2/3 = \u3109\u3125\u02c7       ", "\u7B49" };
            zhuyin[69] = new string[] { "2/4 = \u3109\u3125\u02cb       ", "\u9127", "\u77AA" };
            zhuyin[70] = new string[] { "20 = \u3109\u3122       ", "\u55AE", "\u4E39", "\u64D4" };
            zhuyin[71] = new string[] { "203 = \u3109\u3122\u02c7       ", "\u81BD", "\u75B8" };
            zhuyin[72] = new string[] { "204 = \u3109\u3122\u02cb       ", "\u6DE1", "\u4F46", "\u86CB", "\u8A95", "\u6C2E", "\u5F48" };
            zhuyin[73] = new string[] { "28 = \u3109\u311a       ", "\u642D" };
            zhuyin[74] = new string[] { "283 = \u3109\u311a\u02c7       ", "\u6253" };
            zhuyin[75] = new string[] { "284 = \u3109\u311a\u02cb       ", "\u5927" };
            zhuyin[76] = new string[] { "286 = \u3109\u311a\u02ca       ", "\u7B54", "\u9054" };
            zhuyin[77] = new string[] { "29 = \u3109\u311e       ", "\u5446", "\u5F85" };
            zhuyin[78] = new string[] { "293 = \u3109\u311e\u02c7       ", "\u6B79", "\u902E" };
            zhuyin[79] = new string[] { "294 = \u3109\u311e\u02cb       ", "\u888B", "\u5E36", "\u4EE3", "\u6234", "\u5F85" };
            zhuyin[80] = new string[] { "2; = \u3109\u3124  ", "\u7576" };
            zhuyin[81] = new string[] { "2; 3 = \u3109\u3124\u02c7  ", "\u6A94", "\u9EE8" };
            zhuyin[82] = new string[] { "2; 4 = \u3109\u3124\u02cb  ", "\u8569", "\u76EA" };
            zhuyin[83] = new string[] { "2j = \u3109\u3128       ", "\u7763" };
            zhuyin[84] = new string[] { "2j/ = \u3109\u3128\u3125       ", "\u6771", "\u51AC" };
            zhuyin[85] = new string[] { "2j/3 = \u3109\u3128\u3125\u02c7       ", "\u61C2", "\u8463" };
            zhuyin[86] = new string[] { "2j/4 = \u3109\u3128\u3125\u02cb       ", "\u6D1E", "\u52D5", "\u68DF", "\u51CD", "\u606B" };
            zhuyin[87] = new string[] { "2j0 = \u3109\u3128\u3122       ", "\u7AEF" };
            zhuyin[88] = new string[] { "2j03 = \u3109\u3128\u3122\u02c7       ", "\u77ED" };
            zhuyin[89] = new string[] { "2j04 = \u3109\u3128\u3122\u02cb       ", "\u6BB5", "\u65B7" };
            zhuyin[90] = new string[] { "2j3 = \u3109\u3128\u02c7       ", "\u8CED" };
            zhuyin[91] = new string[] { "2j4 = \u3109\u3128\u02cb       ", "\u809A", "\u5EA6", "\u675C" };
            zhuyin[92] = new string[] { "2j6 = \u3109\u3128\u02ca       ", "\u7368", "\u8B80", "\u6BD2" };
            zhuyin[93] = new string[] { "2ji = \u3109\u3128\u311b       ", "\u591A" };
            zhuyin[94] = new string[] { "2ji3 = \u3109\u3128\u311b\u02c7       ", "\u6735", "\u8EB2" };
            zhuyin[95] = new string[] { "2ji4 = \u3109\u3128\u311b\u02cb       ", "\u58AE", "\u60F0" };
            zhuyin[96] = new string[] { "2ji6 = \u3109\u3128\u311b\u02ca       ", "\u596A", "\u9438" };
            zhuyin[97] = new string[] { "2jo = \u3109\u3128\u311f       ", "\u5806" };
            zhuyin[98] = new string[] { "2jo4 = \u3109\u3128\u311f\u02cb       ", "\u968A", "\u5C0D", "\u514C" };
            zhuyin[99] = new string[] { "2jp = \u3109\u3128\u3123       ", "\u6566", "\u8E72" };
            zhuyin[100] = new string[] { "2jp3 = \u3109\u3128\u3123\u02c7       ", "\u76F9" };
            zhuyin[101] = new string[] { "2jp4 = \u3109\u3128\u3123\u02cb       ", "\u9813", "\u5678", "\u76FE" };
            zhuyin[102] = new string[] { "2k6 = \u3109\u311c\u02ca       ", "\u5F97", "\u5FB7" };
            zhuyin[103] = new string[] { "2k7 = \u3109\u311c\u02d9       ", "\u7684" };
            zhuyin[104] = new string[] { "2l = \u3109\u3120       ", "\u5200" };
            zhuyin[105] = new string[] { "2l3 = \u3109\u3120\u02c7       ", "\u6417", "\u5C0E", "\u5CF6", "\u5012" };
            zhuyin[106] = new string[] { "2l4 = \u3109\u3120\u02cb       ", "\u9053", "\u5230", "\u7A3B" };
            zhuyin[107] = new string[] { "2u = \u3109\u3127       ", "\u6EF4", "\u4F4E" };
            zhuyin[108] = new string[] { "2u, = \u3109\u3127       ", "\u7239" };
            zhuyin[109] = new string[] { "2u,6 = \u3109\u3127  ", "\u758A", "\u8DCC", "\u789F", "\u8ADC" };
            zhuyin[110] = new string[] { "2u/ = \u3109\u3127\u3125       ", "\u4E01", "\u76EF" };
            zhuyin[111] = new string[] { "2u/3 = \u3109\u3127\u3125\u02c7       ", "\u9802", "\u9F0E" };
            zhuyin[112] = new string[] { "2u/4 = \u3109\u3127\u3125\u02cb       ", "\u8A02", "\u9320", "\u7887", "\u91D8" };
            zhuyin[113] = new string[] { "2u0 = \u3109\u3127\u3122       ", "\u985B" };
            zhuyin[114] = new string[] { "2u03 = \u3109\u3127\u3122\u02c7       ", "\u9EDE", "\u5178", "\u7898" };
            zhuyin[115] = new string[] { "2u04 = \u3109\u3127\u3122\u02cb       ", "\u96FB", "\u5E97", "\u588A", "\u6BBF" };
            zhuyin[116] = new string[] { "2u3 = \u3109\u3127\u02c7       ", "\u5E95" };
            zhuyin[117] = new string[] { "2u4 = \u3109\u3127\u02cb       ", "\u5730", "\u7B2C", "\u5E1D", "\u8482", "\u5F1F" };
            zhuyin[118] = new string[] { "2u6 = \u3109\u3127\u02ca       ", "\u8FEA", "\u6575", "\u72C4", "\u7B1B", "\u6ECC" };
            zhuyin[119] = new string[] { "2ul = \u3109\u3127\u3120       ", "\u96D5", "\u8C82", "\u51CB" };
            zhuyin[120] = new string[] { "2ul4 = \u3109\u3127\u3120\u02cb       ", "\u91E3", "\u6389", "\u540A" };
            zhuyin[121] = new string[] { "3 = \u02c7       ", "\u02C7" };
            zhuyin[122] = new string[] { "4 = \u02cb       ", "\u02CB" };
            zhuyin[123] = new string[] { "5 = \u3113       ", "\u3113", "\u96BB", "\u4E4B", "\u652F", "\u77E5", "\u829D", "\u679D", "\u6C41", "\u7E54", "\u8102", "\u80A2", "\u8718" };
            zhuyin[124] = new string[] { "5. = \u3113\u3121       ", "\u5DDE", "\u5468", "\u9031", "\u6D32", "\u821F", "\u7CA5" };
            zhuyin[125] = new string[] { "5.3 = \u3113\u3121\u02c7       ", "\u5E1A", "\u8098" };
            zhuyin[126] = new string[] { "5.4 = \u3113\u3121\u02cb       ", "\u76BA", "\u5492", "\u5B99", "\u5191", "\u665D", "\u7D02" };
            zhuyin[127] = new string[] { "5.6 = \u3113\u3121\u02ca       ", "\u8EF8", "\u59AF" };
            zhuyin[128] = new string[] { "5/ = \u3113\u3125       ", "\u6014", "\u5FB5", "\u722D", "\u84B8", "\u5F81", "\u775C", "\u7665", "\u7B8F" };
            zhuyin[129] = new string[] { "5/3 = \u3113\u3125\u02c7       ", "\u6574", "\u62EF" };
            zhuyin[130] = new string[] { "5/4 = \u3113\u3125\u02cb       ", "\u8A3C", "\u6B63", "\u653F", "\u912D", "\u8B49", "\u75C7", "\u5E40" };
            zhuyin[131] = new string[] { "50 = \u3113\u3122       ", "\u6CBE", "\u8A79", "\u77BB" };
            zhuyin[132] = new string[] { "503 = \u3113\u3122\u02c7       ", "\u76DE", "\u5C55", "\u65AC", "\u8F3E" };
            zhuyin[133] = new string[] { "504 = \u3113\u3122\u02cb       ", "\u7AD9", "\u6230", "\u4F54", "\u5360", "\u68E7", "\u66AB" };
            zhuyin[134] = new string[] { "53 = \u3113\u02c7       ", "\u6307", "\u53EA", "\u5740", "\u6B62", "\u7D19", "\u65E8" };
            zhuyin[135] = new string[] { "54 = \u3113\u02cb       ", "\u81F3", "\u5FD7", "\u5236", "\u667A", "\u81F4", "\u7F6E", "\u88FD", "\u6CBB", "\u79E9", "\u7A1A", "\u5CD9" };
            zhuyin[136] = new string[] { "56 = \u3113\u02ca       ", "\u76F4", "\u503C", "\u57F7", "\u8077", "\u8CEA" };
            zhuyin[137] = new string[] { "58 = \u3113\u311a       ", "\u6E23", "\u624E" };
            zhuyin[138] = new string[] { "583 = \u3113\u311a\u02c7       ", "\u7728" };
            zhuyin[139] = new string[] { "584 = \u3113\u311a\u02cb       ", "\u70B8", "\u8A50", "\u67F5" };
            zhuyin[140] = new string[] { "586 = \u3113\u311a\u02ca       ", "\u9598", "\u672D" };
            zhuyin[141] = new string[] { "593 = \u3113\u311e\u02c7       ", "\u7A84" };
            zhuyin[142] = new string[] { "594 = \u3113\u311e\u02cb       ", "\u50B5", "\u5BE8" };
            zhuyin[143] = new string[] { "596 = \u3113\u311e\u02ca       ", "\u7FDF", "\u5B85" };
            zhuyin[144] = new string[] { "5; = \u3113\u3124  ", "\u5F35", "\u7AE0", "\u5F70", "\u748B", "\u6A1F" };
            zhuyin[145] = new string[] { "5; 3 = \u3113\u3124\u02c7  ", "\u6F32", "\u638C" };
            zhuyin[146] = new string[] { "5; 4 = \u3113\u3124\u02cb  ", "\u5E33", "\u4ED7", "\u8139", "\u969C", "\u4E08", "\u6756" };
            zhuyin[147] = new string[] { "5j = \u3113\u3128       ", "\u73E0", "\u6731", "\u8C6C", "\u8AF8", "\u682A", "\u86DB" };
            zhuyin[148] = new string[] { "5j/ = \u3113\u3128\u3125       ", "\u4E2D", "\u937E", "\u5FE0", "\u9418", "\u7D42" };
            zhuyin[149] = new string[] { "5j/3 = \u3113\u3128\u3125\u02c7       ", "\u816B", "\u585A", "\u8E35" };
            zhuyin[150] = new string[] { "5j/4 = \u3113\u3128\u3125\u02cb       ", "\u773E", "\u7A2E", "\u4EF2" };
            zhuyin[151] = new string[] { "5j0 = \u3113\u3128\u3122       ", "\u5C08", "\u78DA" };
            zhuyin[152] = new string[] { "5j03 = \u3113\u3128\u3122\u02c7       ", "\u8F49" };
            zhuyin[153] = new string[] { "5j04 = \u3113\u3128\u3122\u02cb       ", "\u8CFA", "\u64B0", "\u7BC6", "\u994C" };
            zhuyin[154] = new string[] { "5j3 = \u3113\u3128\u02c7       ", "\u716E", "\u4E3B", "\u56D1", "\u8CAF", "\u782B" };
            zhuyin[155] = new string[] { "5j4 = \u3113\u3128\u02cb       ", "\u795D", "\u4F4F", "\u99D0", "\u52A9", "\u6CE8", "\u8457", "\u67F1", "\u8A3B", "\u9444", "\u86C0" };
            zhuyin[156] = new string[] { "5j6 = \u3113\u3128\u02ca       ", "\u7B51", "\u7AF9", "\u9010", "\u7BC9", "\u71ED", "\u7AFA" };
            zhuyin[157] = new string[] { "5j; = \u3113\u3128\u3124  ", "\u6A01", "\u88DD", "\u838A", "\u599D", "\u5E84", "\u7CA7" };
            zhuyin[158] = new string[] { "5j; 4 = \u3113\u3128\u3124\u02cb  ", "\u58EF", "\u72C0", "\u649E" };
            zhuyin[159] = new string[] { "5ji = \u3113\u3128\u311b       ", "\u684C", "\u6349" };
            zhuyin[160] = new string[] { "5ji6 = \u3113\u3128\u311b\u02ca       ", "\u62D9", "\u5353", "\u914C", "\u6FC1", "\u5544", "\u6FEF", "\u9432" };
            zhuyin[161] = new string[] { "5jo = \u3113\u3128\u311f       ", "\u8FFD", "\u690E", "\u9310" };
            zhuyin[162] = new string[] { "5jo4 = \u3113\u3128\u311f\u02cb       ", "\u589C", "\u7DB4", "\u8D05" };
            zhuyin[163] = new string[] { "5jp = \u3113\u3128\u3123       ", "\u8AC4" };
            zhuyin[164] = new string[] { "5jp3 = \u3113\u3128\u3123\u02c7       ", "\u6E96", "\u51C6" };
            zhuyin[165] = new string[] { "5k = \u3113\u311c       ", "\u906E", "\u87AB" };
            zhuyin[166] = new string[] { "5k3 = \u3113\u311c\u02c7       ", "\u8005", "\u8D6D", "\u937A" };
            zhuyin[167] = new string[] { "5k4 = \u3113\u311c\u02cb       ", "\u9019", "\u8517", "\u6D59" };
            zhuyin[168] = new string[] { "5k6 = \u3113\u311c\u02ca       ", "\u8936", "\u6298", "\u54F2", "\u8F12" };
            zhuyin[169] = new string[] { "5l = \u3113\u3120       ", "\u62DB", "\u662D", "\u53EC", "\u91D7", "\u6641", "\u671D" };
            zhuyin[170] = new string[] { "5l3 = \u3113\u3120\u02c7       ", "\u627E", "\u6CBC", "\u722A" };
            zhuyin[171] = new string[] { "5l4 = \u3113\u3120\u02cb       ", "\u7F69", "\u7167", "\u8D99", "\u5146", "\u8087", "\u8A54" };
            zhuyin[172] = new string[] { "5p = \u3113\u3123       ", "\u91DD", "\u771F", "\u73CD", "\u8C9E", "\u5075", "\u7504", "\u81FB", "\u659F", "\u7BB4" };
            zhuyin[173] = new string[] { "5p3 = \u3113\u3123\u02c7       ", "\u8A3A", "\u75B9", "\u6795" };
            zhuyin[174] = new string[] { "5p4 = \u3113\u3123\u02cb       ", "\u9663", "\u9707", "\u632F", "\u93AE", "\u6715", "\u8CD1" };
            zhuyin[175] = new string[] { "6 = \u02ca       ", "\u02CA" };
            zhuyin[176] = new string[] { "7 = \u02d9       ", "\u02D9" };
            zhuyin[177] = new string[] { "8 = \u311a       ", "\u311A", "\u554A", "\u963F" };
            zhuyin[178] = new string[] { "9 = \u311e       ", "\u311E", "\u57C3", "\u54C0", "\u54CE", "\u5509", "\u6328", "\u5540" };
            zhuyin[179] = new string[] { "93 = \u311e\u02c7       ", "\u6BD0", "\u77EE", "\u85F9" };
            zhuyin[180] = new string[] { "94 = \u311e\u02cb       ", "\u7919", "\u611B", "\u827E", "\u9698" };
            zhuyin[181] = new string[] { "96 = \u311e\u02ca       ", "\u6371", "\u764C", "\u769A" };
            zhuyin[182] = new string[] { "; = \u3124  ", "\u3124", "\u9AAF" };
            zhuyin[183] = new string[] { "; 3 = \u3124\u02c7  ", "\u8EEE" };
            zhuyin[184] = new string[] { "; 4 = \u3124\u02cb  ", "\u76CE" };
            zhuyin[185] = new string[] { "; 6 = \u3124\u02ca  ", "\u6602", "\u536C" };
            zhuyin[186] = new string[] { "a = \u3107       ", "\u3107" };
            zhuyin[187] = new string[] { "a.3 = \u3107\u3121\u02c7       ", "\u67D0" };
            zhuyin[188] = new string[] { "a.6 = \u3107\u3121\u02ca       ", "\u8B00", "\u725F" };
            zhuyin[189] = new string[] { "a/ = \u3107\u3125       ", "\u77C7" };
            zhuyin[190] = new string[] { "a/3 = \u3107\u3125\u02c7       ", "\u731B", "\u61DE", "\u824B", "\u61F5" };
            zhuyin[191] = new string[] { "a/4 = \u3107\u3125\u02cb       ", "\u5922", "\u5B5F" };
            zhuyin[192] = new string[] { "a/6 = \u3107\u3125\u02ca       ", "\u76DF", "\u8499", "\u840C", "\u6726", "\u6AAC" };
            zhuyin[193] = new string[] { "a03 = \u3107\u3122\u02c7       ", "\u6EFF" };
            zhuyin[194] = new string[] { "a04 = \u3107\u3122\u02cb       ", "\u6162", "\u66FC", "\u6F2B", "\u8513" };
            zhuyin[195] = new string[] { "a06 = \u3107\u3122\u02ca       ", "\u883B", "\u9C3B", "\u779E", "\u9945" };
            zhuyin[196] = new string[] { "a8 = \u3107\u311a       ", "\u5ABD", "\u5B24", "\u55CE", "\u561B" };
            zhuyin[197] = new string[] { "a83 = \u3107\u311a\u02c7       ", "\u99AC", "\u78BC", "\u879E" };
            zhuyin[198] = new string[] { "a84 = \u3107\u311a\u02cb       ", "\u7F75" };
            zhuyin[199] = new string[] { "a86 = \u3107\u311a\u02ca       ", "\u9EBB", "\u87C6" };
            zhuyin[200] = new string[] { "a93 = \u3107\u311e\u02c7       ", "\u8CB7" };
            zhuyin[201] = new string[] { "a94 = \u3107\u311e\u02cb       ", "\u8108", "\u8CE3", "\u9EA5", "\u9081", "\u52F1" };
            zhuyin[202] = new string[] { "a96 = \u3107\u311e\u02ca       ", "\u57CB", "\u973E" };
            zhuyin[203] = new string[] { "a;3 = \u3107\u3124\u02c7       ", "\u83BD", "\u87D2" };
            zhuyin[204] = new string[] { "a;6 = \u3107\u3124\u02ca       ", "\u5FD9", "\u8292", "\u76F2", "\u6C13", "\u832B" };
            zhuyin[205] = new string[] { "ai = \u3107\u311b       ", "\u6478" };
            zhuyin[206] = new string[] { "ai3 = \u3107\u311b\u02c7       ", "\u62B9" };
            zhuyin[207] = new string[] { "ai4 = \u3107\u311b\u02cb       ", "\u672B", "\u83AB", "\u58A8", "\u9ED8", "\u8C98", "\u8309", "\u6CAB", "\u5BDE", "\u6B7F", "\u964C" };
            zhuyin[208] = new string[] { "ai6 = \u3107\u311b\u02ca       ", "\u7CE2", "\u6469", "\u6A21", "\u9B54", "\u78E8", "\u819C" };
            zhuyin[209] = new string[] { "aj3 = \u3107\u3128\u02c7       ", "\u6BCD", "\u59C6", "\u755D", "\u7261" };
            zhuyin[210] = new string[] { "aj4 = \u3107\u3128\u02cb       ", "\u5E55", "\u6728", "\u76EE", "\u6155", "\u7A46", "\u5893", "\u7267", "\u7766", "\u6C90", "\u66AE" };
            zhuyin[211] = new string[] { "ak7 = \u3107\u311c\u02d9       ", "\u569C", "\u9EBC" };
            zhuyin[212] = new string[] { "al = \u3107\u3120       ", "\u8C93" };
            zhuyin[213] = new string[] { "al3 = \u3107\u3120\u02c7       ", "\u536F" };
            zhuyin[214] = new string[] { "al4 = \u3107\u3120\u02cb       ", "\u8302", "\u8CBF", "\u5192", "\u5E3D", "\u61CB", "\u8C8C", "\u7441" };
            zhuyin[215] = new string[] { "al6 = \u3107\u3120\u02ca       ", "\u6BDB", "\u8305", "\u9328" };
            zhuyin[216] = new string[] { "ao3 = \u3107\u311f\u02c7       ", "\u7F8E", "\u6BCF", "\u9382" };
            zhuyin[217] = new string[] { "ao4 = \u3107\u311f\u02cb       ", "\u59B9", "\u5A9A", "\u8882", "\u6627" };
            zhuyin[218] = new string[] { "ao6 = \u3107\u311f\u02ca       ", "\u6C92", "\u6885", "\u73AB", "\u7709", "\u5A92", "\u7164", "\u8393", "\u6963", "\u9709" };
            zhuyin[219] = new string[] { "ap = \u3107\u3123       ", "\u60B6" };
            zhuyin[220] = new string[] { "ap6 = \u3107\u3123\u02ca       ", "\u9580", "\u5011" };
            zhuyin[221] = new string[] { "au = \u3107\u3127       ", "\u54AA", "\u7787" };
            zhuyin[222] = new string[] { "au/3 = \u3107\u3127\u3125\u02c7       ", "\u8317", "\u9169" };
            zhuyin[223] = new string[] { "au/4 = \u3107\u3127\u3125\u02cb       ", "\u547D" };
            zhuyin[224] = new string[] { "au/6 = \u3107\u3127\u3125\u02ca       ", "\u9CF4", "\u660E", "\u540D", "\u9298", "\u51A5" };
            zhuyin[225] = new string[] { "au03 = \u3107\u3127\u3122\u02c7       ", "\u7DEC", "\u514D", "\u52C9", "\u5195" };
            zhuyin[226] = new string[] { "au04 = \u3107\u3127\u3122\u02cb       ", "\u9762", "\u9EB5" };
            zhuyin[227] = new string[] { "au06 = \u3107\u3127\u3122\u02ca       ", "\u7DBF", "\u68C9", "\u7720" };
            zhuyin[228] = new string[] { "au3 = \u3107\u3127\u02c7       ", "\u7C73", "\u5F2D", "\u9761" };
            zhuyin[229] = new string[] { "au4 = \u3107\u3127\u02cb       ", "\u79D8", "\u5BC6", "\u871C", "\u8993" };
            zhuyin[230] = new string[] { "au6 = \u3107\u3127\u02ca       ", "\u5F4C", "\u8FF7", "\u8B0E", "\u7CDC", "\u919A", "\u9E8B" };
            zhuyin[231] = new string[] { "aul = \u3107\u3127\u3120       ", "\u55B5" };
            zhuyin[232] = new string[] { "aul3 = \u3107\u3127\u3120\u02c7       ", "\u79D2", "\u6DFC", "\u6E3A", "\u85D0", "\u7DF2" };
            zhuyin[233] = new string[] { "aul4 = \u3107\u3127\u3120\u02cb       ", "\u5999", "\u5EDF", "\u7E46" };
            zhuyin[234] = new string[] { "aul6 = \u3107\u3127\u3120\u02ca       ", "\u82D7", "\u7784" };
            zhuyin[235] = new string[] { "aup3 = \u3107\u3127\u3123\u02c7       ", "\u95A9", "\u654F", "\u9594", "\u61AB", "\u6CEF", "\u76BF" };
            zhuyin[236] = new string[] { "aup6 = \u3107\u3127\u3123\u02ca       ", "\u65FB", "\u6C11", "\u739F" };
            zhuyin[237] = new string[] { "b = \u3116       ", "\u3116" };
            zhuyin[238] = new string[] { "b.4 = \u3116\u3121\u02cb       ", "\u8089" };
            zhuyin[239] = new string[] { "b.6 = \u3116\u3121\u02ca       ", "\u63C9", "\u67D4", "\u8E42" };
            zhuyin[240] = new string[] { "b/ = \u3116\u3125       ", "\u6254" };
            zhuyin[241] = new string[] { "b/6 = \u3116\u3125\u02ca       ", "\u4ECD" };
            zhuyin[242] = new string[] { "b4 = \u3116\u02cb       ", "\u65E5" };
            zhuyin[243] = new string[] { "bj/3 = \u3116\u3128\u3125\u02c7       ", "\u5197", "\u8338" };
            zhuyin[244] = new string[] { "bj/6 = \u3116\u3128\u3125\u02ca       ", "\u7D68", "\u69AE", "\u5BB9", "\u878D", "\u84C9", "\u620E", "\u6995", "\u6EB6" };
            zhuyin[245] = new string[] { "bj03 = \u3116\u3128\u3122\u02c7       ", "\u8EDF", "\u962E" };
            zhuyin[246] = new string[] { "bj3 = \u3116\u3128\u02c7       ", "\u4E73", "\u6C5D", "\u8FB1" };
            zhuyin[247] = new string[] { "bj4 = \u3116\u3128\u02cb       ", "\u5165", "\u8FB1" };
            zhuyin[248] = new string[] { "bj6 = \u3116\u3128\u02ca       ", "\u5982", "\u5112", "\u8339", "\u5B7A", "\u8815" };
            zhuyin[249] = new string[] { "bji4 = \u3116\u3128\u311b\u02cb       ", "\u82E5", "\u5F31", "\u84BB" };
            zhuyin[250] = new string[] { "bjo3 = \u3116\u3128\u311f\u02c7       ", "\u854A" };
            zhuyin[251] = new string[] { "bjo4 = \u3116\u3128\u311f\u02cb       ", "\u92B3", "\u745E", "\u53E1", "\u82AE" };
            zhuyin[252] = new string[] { "bk3 = \u3116\u311c\u02c7       ", "\u60F9" };
            zhuyin[253] = new string[] { "bk4 = \u3116\u311c\u02cb       ", "\u71B1" };
            zhuyin[254] = new string[] { "bp3 = \u3116\u3123\u02c7       ", "\u5FCD" };
            zhuyin[255] = new string[] { "bp4 = \u3116\u3123\u02cb       ", "\u8A8D", "\u4EFB", "\u5203", "\u97CC" };
            zhuyin[256] = new string[] { "bp6 = \u3116\u3123\u02ca       ", "\u4EBA", "\u4EC1" };
            zhuyin[257] = new string[] { "c = \u3104       ", "\u310F" };
            zhuyin[258] = new string[] { "c.4 = \u3104\u3121\u02cb       ", "\u5F8C", "\u539A", "\u5019", "\u540E" };
            zhuyin[259] = new string[] { "c.6 = \u3104\u3121\u02ca       ", "\u5589", "\u7334" };
            zhuyin[260] = new string[] { "c/ = \u3104\u3125       ", "\u54FC" };
            zhuyin[261] = new string[] { "c/6 = \u3104\u3125\u02ca       ", "\u6A6B", "\u6046", "\u8861", "\u6052", "\u73E9" };
            zhuyin[262] = new string[] { "c0 = \u3104\u3122       ", "\u61A8", "\u9163", "\u9F3E" };
            zhuyin[263] = new string[] { "c03 = \u3104\u3122\u02c7       ", "\u558A", "\u7F55" };
            zhuyin[264] = new string[] { "c04 = \u3104\u3122\u02cb       ", "\u7FF0", "\u548C", "\u6F22", "\u608D", "\u701A", "\u6C57", "\u61BE", "\u65F1", "\u710A", "\u92B2" };
            zhuyin[265] = new string[] { "c06 = \u3104\u3122\u02ca       ", "\u542B", "\u51FD", "\u97D3", "\u6DB5", "\u5BD2" };
            zhuyin[266] = new string[] { "c93 = \u3104\u311e\u02c7       ", "\u6D77" };
            zhuyin[267] = new string[] { "c94 = \u3104\u311e\u02cb       ", "\u55E8", "\u5BB3", "\u99ED", "\u4EA5", "\u6C26" };
            zhuyin[268] = new string[] { "c96 = \u3104\u311e\u02ca       ", "\u9084", "\u5B69", "\u9AB8" };
            zhuyin[269] = new string[] { "c; = \u3104\u3124       ", "\u592F" };
            zhuyin[270] = new string[] { "c;6 = \u3104\u3124\u02ca       ", "\u822A", "\u884C", "\u676D" };
            zhuyin[271] = new string[] { "cj = \u3104\u3128       ", "\u547C", "\u5FFD", "\u4E4E" };
            zhuyin[272] = new string[] { "cj/ = \u3104\u3128\u3125       ", "\u8F5F", "\u70D8", "\u54C4" };
            zhuyin[273] = new string[] { "cj/4 = \u3104\u3128\u3125\u02cb       ", "\u9B28" };
            zhuyin[274] = new string[] { "cj/6 = \u3104\u3128\u3125\u02ca       ", "\u5B8F", "\u7D05", "\u6D2A", "\u8679", "\u5F18", "\u6CD3", "\u958E", "\u9D3B", "\u7AD1", "\u6D64", "\u7D18" };
            zhuyin[275] = new string[] { "cj0 = \u3104\u3128\u3122       ", "\u6B61" };
            zhuyin[276] = new string[] { "cj03 = \u3104\u3128\u3122\u02c7       ", "\u7DE9" };
            zhuyin[277] = new string[] { "cj04 = \u3104\u3128\u3122\u02cb       ", "\u63DB", "\u559A", "\u60A3", "\u5E7B", "\u5BA6", "\u6E19" };
            zhuyin[278] = new string[] { "cj06 = \u3104\u3128\u3122\u02ca       ", "\u74B0", "\u6853" };
            zhuyin[279] = new string[] { "cj3 = \u3104\u3128\u02c7       ", "\u864E", "\u552C", "\u6EF8" };
            zhuyin[280] = new string[] { "cj4 = \u3104\u3128\u02cb       ", "\u6236", "\u6248", "\u8B77", "\u4E92", "\u623D" };
            zhuyin[281] = new string[] { "cj6 = \u3104\u3128\u02ca       ", "\u6E56", "\u58FA", "\u80E1", "\u7CCA", "\u5F27", "\u72D0", "\u9D60", "\u9B0D" };
            zhuyin[282] = new string[] { "cj8 = \u3104\u3128\u311a       ", "\u82B1" };
            zhuyin[283] = new string[] { "cj84 = \u3104\u3128\u311a\u02cb       ", "\u8A71", "\u5316", "\u756B", "\u5283", "\u6A3A" };
            zhuyin[284] = new string[] { "cj86 = \u3104\u3128\u311a\u02ca       ", "\u5212", "\u6ED1", "\u83EF", "\u733E" };
            zhuyin[285] = new string[] { "cj94 = \u3104\u3128\u311e\u02cb       ", "\u58DE" };
            zhuyin[286] = new string[] { "cj96 = \u3104\u3128\u311e\u02ca       ", "\u61F7" };
            zhuyin[287] = new string[] { "cj; = \u3104\u3128\u3124       ", "\u614C", "\u8352" };
            zhuyin[288] = new string[] { "cj;3 = \u3104\u3128\u3124\u02c7       ", "\u8B0A", "\u5E4C", "\u604D" };
            zhuyin[289] = new string[] { "cj;4 = \u3104\u3128\u3124\u02cb       ", "\u6643", "\u6130" };
            zhuyin[290] = new string[] { "cj;6 = \u3104\u3128\u3124\u02ca       ", "\u9EC3", "\u8757", "\u7687", "\u51F0", "\u5FA8", "\u60F6", "\u714C", "\u78FA", "\u7C27" };
            zhuyin[291] = new string[] { "cji3 = \u3104\u3128\u311b\u02c7       ", "\u706B", "\u4F19", "\u5925" };
            zhuyin[292] = new string[] { "cji4 = \u3104\u3128\u311b\u02cb       ", "\u6216", "\u8CA8", "\u798D", "\u7372", "\u60D1", "\u970D", "\u58D1", "\u8C41", "\u7A6B" };
            zhuyin[293] = new string[] { "cji6 = \u3104\u3128\u311b\u02ca       ", "\u6D3B" };
            zhuyin[294] = new string[] { "cjo = \u3104\u3128\u311f       ", "\u7070", "\u63EE", "\u6062", "\u6689", "\u8F1D" };
            zhuyin[295] = new string[] { "cjo3 = \u3104\u3128\u311f\u02c7       ", "\u6BC0", "\u6094", "\u8AA8" };
            zhuyin[296] = new string[] { "cjo4 = \u3104\u3128\u311f\u02cb       ", "\u6703", "\u532F", "\u7E6A", "\u5349", "\u60E0", "\u8CC4", "\u6167", "\u7A62" };
            zhuyin[297] = new string[] { "cjo6 = \u3104\u3128\u311f\u02ca       ", "\u56DE", "\u5F8A", "\u8FF4" };
            zhuyin[298] = new string[] { "cjp = \u3104\u3128\u3123       ", "\u8477", "\u660F", "\u5A5A" };
            zhuyin[299] = new string[] { "cjp4 = \u3104\u3128\u3123\u02cb       ", "\u6DF7" };
            zhuyin[300] = new string[] { "cjp6 = \u3104\u3128\u3123\u02ca       ", "\u9B42", "\u6E3E" };
            zhuyin[301] = new string[] { "ck = \u3104\u311c       ", "\u559D" };
            zhuyin[302] = new string[] { "ck4 = \u3104\u311c\u02cb       ", "\u8D6B", "\u8CC0", "\u9DB4" };
            zhuyin[303] = new string[] { "ck6 = \u3104\u311c\u02ca       ", "\u76D2", "\u4F55", "\u5408", "\u6838", "\u6CB3", "\u8377", "\u79BE", "\u52BE", "\u95D4" };
            zhuyin[304] = new string[] { "cl3 = \u3104\u3120\u02c7       ", "\u597D", "\u90DD" };
            zhuyin[305] = new string[] { "cl4 = \u3104\u3120\u02cb       ", "\u7693", "\u865F", "\u6D69", "\u8017" };
            zhuyin[306] = new string[] { "cl6 = \u3104\u3120\u02ca       ", "\u8C6A", "\u6BEB" };
            zhuyin[307] = new string[] { "co = \u3104\u311f       ", "\u9ED1" };
            zhuyin[308] = new string[] { "cp3 = \u3104\u3123\u02c7       ", "\u5F88", "\u72E0" };
            zhuyin[309] = new string[] { "cp4 = \u3104\u3123\u02cb       ", "\u6068" };
            zhuyin[310] = new string[] { "cp6 = \u3104\u3123\u02ca       ", "\u75D5", "\u978E" };
            zhuyin[311] = new string[] { "d = \u310e       ", "\u310E" };
            zhuyin[312] = new string[] { "d. = \u310e\u3121       ", "\u6473" };
            zhuyin[313] = new string[] { "d.3 = \u310e\u3121\u02c7       ", "\u53E3" };
            zhuyin[314] = new string[] { "d.4 = \u310e\u3121\u02cb       ", "\u6263", "\u5BC7", "\u53E9", "\u91E6" };
            zhuyin[315] = new string[] { "d/ = \u310e\u3125       ", "\u5751", "\u93D7" };
            zhuyin[316] = new string[] { "d0 = \u310e\u3122       ", "\u582A", "\u520A", "\u52D8" };
            zhuyin[317] = new string[] { "d03 = \u310e\u3122\u02c7       ", "\u780D", "\u574E", "\u4F83", "\u5D01", "\u6ABB" };
            zhuyin[318] = new string[] { "d04 = \u310e\u3122\u02cb       ", "\u770B" };
            zhuyin[319] = new string[] { "d8 = \u310e\u311a       ", "\u5496" };
            zhuyin[320] = new string[] { "d83 = \u310e\u311a\u02c7       ", "\u5361" };
            zhuyin[321] = new string[] { "d84 = \u310e\u311a\u02cb       ", "\u5580" };
            zhuyin[322] = new string[] { "d9 = \u310e\u311e       ", "\u958B" };
            zhuyin[323] = new string[] { "d93 = \u310e\u311e\u02c7       ", "\u51F1", "\u6977", "\u93A7" };
            zhuyin[324] = new string[] { "d94 = \u310e\u311e\u02cb       ", "\u6168", "\u613E" };
            zhuyin[325] = new string[] { "d; = \u310e\u3124       ", "\u7CE0", "\u5EB7", "\u6177" };
            zhuyin[326] = new string[] { "d;4 = \u310e\u3124\u02cb       ", "\u6297", "\u4EA2", "\u4F09" };
            zhuyin[327] = new string[] { "d;6 = \u310e\u3124\u02ca       ", "\u625B" };
            zhuyin[328] = new string[] { "dj = \u310e\u3128       ", "\u54ED", "\u67AF", "\u9AB7" };
            zhuyin[329] = new string[] { "dj/ = \u310e\u3128\u3125       ", "\u7A7A", "\u5025", "\u5D06" };
            zhuyin[330] = new string[] { "dj/3 = \u310e\u3128\u3125\u02c7       ", "\u5B54", "\u6050" };
            zhuyin[331] = new string[] { "dj/4 = \u310e\u3128\u3125\u02cb       ", "\u63A7" };
            zhuyin[332] = new string[] { "dj0 = \u310e\u3128\u3122       ", "\u5BEC" };
            zhuyin[333] = new string[] { "dj03 = \u310e\u3128\u3122\u02c7       ", "\u6B3E", "\u7ABE" };
            zhuyin[334] = new string[] { "dj3 = \u310e\u3128\u02c7       ", "\u82E6" };
            zhuyin[335] = new string[] { "dj4 = \u310e\u3128\u02cb       ", "\u8932", "\u5EAB", "\u9177" };
            zhuyin[336] = new string[] { "dj94 = \u310e\u3128\u311e\u02cb       ", "\u584A", "\u5FEB", "\u7B77", "\u528A", "\u6A9C" };
            zhuyin[337] = new string[] { "dj; = \u310e\u3128\u3124       ", "\u7B50", "\u6846", "\u5321", "\u8A86" };
            zhuyin[338] = new string[] { "dj;3 = \u310e\u3128\u3124\u02c7       ", "\u4FC7" };
            zhuyin[339] = new string[] { "dj;4 = \u310e\u3128\u3124\u02cb       ", "\u7926", "\u6CC1", "\u913A" };
            zhuyin[340] = new string[] { "dj;6 = \u310e\u3128\u3124\u02ca       ", "\u72C2", "\u8A91" };
            zhuyin[341] = new string[] { "dji4 = \u310e\u3128\u311b\u02cb       ", "\u95CA", "\u62EC", "\u5ED3", "\u64F4" };
            zhuyin[342] = new string[] { "djo = \u310e\u3128\u311f       ", "\u8667", "\u76D4", "\u7ABA" };
            zhuyin[343] = new string[] { "djo3 = \u310e\u3128\u311f\u02c7       ", "\u5080", "\u78C8" };
            zhuyin[344] = new string[] { "djo4 = \u310e\u3128\u311f\u02cb       ", "\u6127", "\u5331", "\u6F70", "\u994B" };
            zhuyin[345] = new string[] { "djo6 = \u310e\u3128\u311f\u02ca       ", "\u594E", "\u63C6", "\u8475", "\u777D", "\u9B41" };
            zhuyin[346] = new string[] { "djp = \u310e\u3128\u3123       ", "\u5764", "\u6606", "\u5D11" };
            zhuyin[347] = new string[] { "djp3 = \u310e\u3128\u3123\u02c7       ", "\u6346", "\u7D91" };
            zhuyin[348] = new string[] { "djp4 = \u310e\u3128\u3123\u02cb       ", "\u56F0", "\u774F" };
            zhuyin[349] = new string[] { "dk = \u310e\u311c       ", "\u9846", "\u68F5", "\u79D1", "\u78D5", "\u523B", "\u67EF", "\u82DB" };
            zhuyin[350] = new string[] { "dk3 = \u310e\u311c\u02c7       ", "\u53EF", "\u6E34" };
            zhuyin[351] = new string[] { "dk4 = \u310e\u311c\u02cb       ", "\u8AB2", "\u523B", "\u5BA2", "\u514B", "\u524B" };
            zhuyin[352] = new string[] { "dk6 = \u310e\u311c\u02ca       ", "\u6BBC", "\u54B3" };
            zhuyin[353] = new string[] { "dp3 = \u310e\u3123\u02c7       ", "\u80AF", "\u5543", "\u58BE", "\u61C7" };
            zhuyin[354] = new string[] { "e = \u310d       ", "\u310D" };
            zhuyin[355] = new string[] { "e. = \u310d\u3121       ", "\u52FE", "\u6E9D", "\u9264", "\u67B8" };
            zhuyin[356] = new string[] { "e.3 = \u310d\u3121\u02c7       ", "\u72D7", "\u67B8", "\u830D" };
            zhuyin[357] = new string[] { "e.4 = \u310d\u3121\u02cb       ", "\u8CFC", "\u69CB", "\u5920", "\u57A2", "\u8A6C", "\u9005" };
            zhuyin[358] = new string[] { "e/ = \u310d\u3125       ", "\u5E9A", "\u8015", "\u7FB9" };
            zhuyin[359] = new string[] { "e/3 = \u310d\u3125\u02c7       ", "\u803F", "\u6897", "\u54FD", "\u57C2" };
            zhuyin[360] = new string[] { "e/4 = \u310d\u3125\u02cb       ", "\u66F4", "\u4E99" };
            zhuyin[361] = new string[] { "e0 = \u310d\u3122       ", "\u4E7E", "\u7518", "\u809D", "\u5E72", "\u7AFF", "\u5C37" };
            zhuyin[362] = new string[] { "e03 = \u310d\u3122\u02c7       ", "\u687F", "\u611F", "\u6562", "\u8D95" };
            zhuyin[363] = new string[] { "e04 = \u310d\u3122\u02cb       ", "\u5E79", "\u8D1B" };
            zhuyin[364] = new string[] { "e8 = \u310d\u311a       ", "\u560E" };
            zhuyin[365] = new string[] { "e84 = \u310d\u311a\u02cb       ", "\u5C2C" };
            zhuyin[366] = new string[] { "e86 = \u310d\u311a\u02ca       ", "\u8ECB" };
            zhuyin[367] = new string[] { "e9 = \u310d\u311e       ", "\u8A72", "\u5793" };
            zhuyin[368] = new string[] { "e93 = \u310d\u311e\u02c7       ", "\u6539" };
            zhuyin[369] = new string[] { "e94 = \u310d\u311e\u02cb       ", "\u84CB", "\u6982", "\u9223", "\u4E10", "\u6E89" };
            zhuyin[370] = new string[] { "e; = \u310d\u3124       ", "\u525B", "\u92FC", "\u5CA1", "\u7DB1", "\u7F61", "\u7F38", "\u809B" };
            zhuyin[371] = new string[] { "e;3 = \u310d\u3124\u02c7       ", "\u6E2F", "\u5D17" };
            zhuyin[372] = new string[] { "e;4 = \u310d\u3124\u02cb       ", "\u69D3" };
            zhuyin[373] = new string[] { "ej = \u310d\u3128       ", "\u8F9C", "\u4F30", "\u59D1", "\u5B64", "\u5495", "\u83C7", "\u7B8D", "\u6CBD" };
            zhuyin[374] = new string[] { "ej/ = \u310d\u3128\u3125       ", "\u8EAC", "\u516C", "\u5DE5", "\u653B", "\u4F9B", "\u529F", "\u5BAE", "\u606D", "\u9F94", "\u5F13" };
            zhuyin[375] = new string[] { "ej/3 = \u310d\u3128\u3125\u02c7       ", "\u62F1", "\u978F", "\u6C5E" };
            zhuyin[376] = new string[] { "ej/4 = \u310d\u3128\u3125\u02cb       ", "\u5171", "\u8CA2", "\u4F9B" };
            zhuyin[377] = new string[] { "ej0 = \u310d\u3128\u3122       ", "\u95DC", "\u89C0", "\u5B98", "\u68FA" };
            zhuyin[378] = new string[] { "ej03 = \u310d\u3128\u3122\u02c7       ", "\u7BA1", "\u9928", "\u839E" };
            zhuyin[379] = new string[] { "ej04 = \u310d\u3128\u3122\u02cb       ", "\u7F50", "\u51A0", "\u8CAB", "\u704C", "\u6163", "\u76E5" };
            zhuyin[380] = new string[] { "ej3 = \u310d\u3128\u02c7       ", "\u9F13", "\u80A1", "\u53E4", "\u8C37", "\u9AA8", "\u7A40", "\u726F", "\u8831" };
            zhuyin[381] = new string[] { "ej4 = \u310d\u3128\u02cb       ", "\u56FA", "\u6545", "\u9867", "\u96C7", "\u50F1", "\u932E", "\u51C5" };
            zhuyin[382] = new string[] { "ej8 = \u310d\u3128\u311a       ", "\u74DC", "\u522E", "\u62EC", "\u98B3", "\u8778" };
            zhuyin[383] = new string[] { "ej83 = \u310d\u3128\u311a\u02c7       ", "\u5BE1", "\u526E" };
            zhuyin[384] = new string[] { "ej84 = \u310d\u3128\u311a\u02cb       ", "\u639B", "\u5366", "\u7F63", "\u8902" };
            zhuyin[385] = new string[] { "ej9 = \u310d\u3128\u311e       ", "\u4E56" };
            zhuyin[386] = new string[] { "ej93 = \u310d\u3128\u311e\u02c7       ", "\u62D0", "\u67FA" };
            zhuyin[387] = new string[] { "ej94 = \u310d\u3128\u311e\u02cb       ", "\u602A" };
            zhuyin[388] = new string[] { "ej; = \u310d\u3128\u3124       ", "\u5149", "\u80F1" };
            zhuyin[389] = new string[] { "ej;3 = \u310d\u3128\u3124\u02c7       ", "\u5EE3" };
            zhuyin[390] = new string[] { "ej;4 = \u310d\u3128\u3124\u02cb       ", "\u901B" };
            zhuyin[391] = new string[] { "eji = \u310d\u3128\u311b       ", "\u90ED", "\u934B", "\u588E" };
            zhuyin[392] = new string[] { "eji3 = \u310d\u3128\u311b\u02c7       ", "\u679C", "\u88F9", "\u7CBF" };
            zhuyin[393] = new string[] { "eji4 = \u310d\u3128\u311b\u02cb       ", "\u904E" };
            zhuyin[394] = new string[] { "eji6 = \u310d\u3128\u311b\u02ca       ", "\u570B", "\u6451", "\u5E57" };
            zhuyin[395] = new string[] { "ejo = \u310d\u3128\u311f       ", "\u9F9C", "\u898F", "\u6B78", "\u572D", "\u9BAD", "\u7470", "\u7688", "\u95A8" };
            zhuyin[396] = new string[] { "ejo3 = \u310d\u3128\u311f\u02c7       ", "\u9B3C", "\u8ECC", "\u8A6D", "\u7678" };
            zhuyin[397] = new string[] { "ejo4 = \u310d\u3128\u311f\u02cb       ", "\u8CB4", "\u6AC3", "\u6842", "\u8DEA" };
            zhuyin[398] = new string[] { "ek = \u310d\u311c       ", "\u6B4C", "\u54E5", "\u5272", "\u6208", "\u64F1", "\u9D3F", "\u7599", "\u80F3" };
            zhuyin[399] = new string[] { "ek3 = \u310d\u311c\u02c7       ", "\u845B", "\u500B" };
            zhuyin[400] = new string[] { "ek4 = \u310d\u311c\u02cb       ", "\u5404", "\u7B87" };
            zhuyin[401] = new string[] { "ek6 = \u310d\u311c\u02ca       ", "\u683C", "\u95A3", "\u9694", "\u9769", "\u86E4", "\u95A4", "\u55DD", "\u9398", "\u9ABC" };
            zhuyin[402] = new string[] { "ek7 = \u310d\u311c\u02d9       ", "\u500B" };
            zhuyin[403] = new string[] { "el = \u310d\u3120       ", "\u9AD8", "\u818F", "\u7CD5", "\u7F94" };
            zhuyin[404] = new string[] { "el3 = \u310d\u3120\u02c7       ", "\u641E", "\u7A3F", "\u776A", "\u93AC" };
            zhuyin[405] = new string[] { "el4 = \u310d\u3120\u02cb       ", "\u544A", "\u8AA5" };
            zhuyin[406] = new string[] { "eo3 = \u310d\u311f\u02c7       ", "\u7D66" };
            zhuyin[407] = new string[] { "ep = \u310d\u3123       ", "\u8DDF", "\u6839" };
            zhuyin[408] = new string[] { "ep3 = \u310d\u3123\u02c7       ", "\u826E" };
            zhuyin[409] = new string[] { "ep4 = \u310d\u3123\u02cb       ", "\u4E99" };
            zhuyin[410] = new string[] { "f = \u3111       ", "\u3111" };
            zhuyin[411] = new string[] { "fm = \u3111\u3129       ", "\u5340", "\u8DA8", "\u9A45", "\u5C48", "\u86C6", "\u8EC0" };
            zhuyin[412] = new string[] { "fm, = \u3111\u3129       ", "\u7F3A", "\u7094" };
            zhuyin[413] = new string[] { "fm,4 = \u3111\u3129       ", "\u602F", "\u537B", "\u78BA", "\u96C0", "\u95D5" };
            zhuyin[414] = new string[] { "fm,6 = \u3111\u3129       ", "\u7638" };
            zhuyin[415] = new string[] { "fm/ = \u3111\u3129\u3125       ", "\u828E" };
            zhuyin[416] = new string[] { "fm/6 = \u3111\u3129\u3125\u02ca       ", "\u74CA", "\u7AAE", "\u7A79" };
            zhuyin[417] = new string[] { "fm0 = \u3111\u3129\u3122       ", "\u5708" };
            zhuyin[418] = new string[] { "fm03 = \u3111\u3129\u3122\u02c7       ", "\u72AC", "\u7DA3" };
            zhuyin[419] = new string[] { "fm04 = \u3111\u3129\u3122\u02cb       ", "\u52F8", "\u5238" };
            zhuyin[420] = new string[] { "fm06 = \u3111\u3129\u3122\u02ca       ", "\u62F3", "\u5168", "\u6B0A", "\u6CC9", "\u8A6E", "\u9293", "\u8343", "\u75CA", "\u8737" };
            zhuyin[421] = new string[] { "fm3 = \u3111\u3129\u02c7       ", "\u66F2", "\u53D6", "\u5A36", "\u9F72" };
            zhuyin[422] = new string[] { "fm4 = \u3111\u3129\u02cb       ", "\u53BB", "\u8DA3" };
            zhuyin[423] = new string[] { "fm6 = \u3111\u3129\u02ca       ", "\u8C66", "\u6E20", "\u74A9", "\u9EB4", "\u4F62", "\u5337" };
            zhuyin[424] = new string[] { "fu = \u3111\u3127       ", "\u621A", "\u4E03", "\u59BB", "\u6F06", "\u6B3A", "\u6DD2", "\u60BD", "\u67D2", "\u68F2" };
            zhuyin[425] = new string[] { "fu, = \u3111\u3127       ", "\u5207" };
            zhuyin[426] = new string[] { "fu,3 = \u3111\u3127       ", "\u4E14" };
            zhuyin[427] = new string[] { "fu,4 = \u3111\u3127       ", "\u7ACA", "\u59BE", "\u611C", "\u9365" };
            zhuyin[428] = new string[] { "fu,6 = \u3111\u3127       ", "\u4F3D", "\u8304" };
            zhuyin[429] = new string[] { "fu. = \u3111\u3127\u3121       ", "\u4E18", "\u90B1", "\u79CB", "\u5775" };
            zhuyin[430] = new string[] { "fu.3 = \u3111\u3127\u3121\u02c7       ", "\u7CD7" };
            zhuyin[431] = new string[] { "fu.6 = \u3111\u3127\u3121\u02ca       ", "\u7403", "\u6C42", "\u88D8", "\u56DA", "\u914B" };
            zhuyin[432] = new string[] { "fu/ = \u3111\u3127\u3125       ", "\u8F15", "\u6E05", "\u9752", "\u537F", "\u50BE", "\u6C2B", "\u9803" };
            zhuyin[433] = new string[] { "fu/3 = \u3111\u3127\u3125\u02c7       ", "\u8ACB", "\u50BE" };
            zhuyin[434] = new string[] { "fu/4 = \u3111\u3127\u3125\u02cb       ", "\u6176", "\u7F44" };
            zhuyin[435] = new string[] { "fu/6 = \u3111\u3127\u3125\u02ca       ", "\u60C5", "\u64CE", "\u6674" };
            zhuyin[436] = new string[] { "fu0 = \u3111\u3127\u3122       ", "\u5343", "\u7C3D", "\u5D4C", "\u9077", "\u727D", "\u4EDF", "\u7C64", "\u925B", "\u8B19", "\u828A", "\u9A2B" };
            zhuyin[437] = new string[] { "fu03 = \u3111\u3127\u3122\u02c7       ", "\u6DFA", "\u9063", "\u8B74" };
            zhuyin[438] = new string[] { "fu04 = \u3111\u3127\u3122\u02cb       ", "\u6B20", "\u831C", "\u5029", "\u84A8", "\u5879", "\u6B49", "\u82A1" };
            zhuyin[439] = new string[] { "fu06 = \u3111\u3127\u3122\u02ca       ", "\u9322", "\u524D", "\u6F5B", "\u8654", "\u63AE", "\u7B9D", "\u9ED4", "\u5898" };
            zhuyin[440] = new string[] { "fu3 = \u3111\u3127\u02c7       ", "\u8D77", "\u555F", "\u7DBA", "\u8C48", "\u4E5E", "\u675E" };
            zhuyin[441] = new string[] { "fu4 = \u3111\u3127\u02cb       ", "\u6CE3", "\u6C23", "\u5668", "\u4F01", "\u8FC4", "\u68C4", "\u7DDD", "\u6C7D", "\u5951", "\u61A9", "\u780C", "\u8A16" };
            zhuyin[442] = new string[] { "fu6 = \u3111\u3127\u02ca       ", "\u7426", "\u5176", "\u671F", "\u5947", "\u65D7", "\u742A", "\u9F4A", "\u9A0E", "\u68CB", "\u5D0E", "\u9E92", "\u797A", "\u6B67", "\u7948", "\u9321", "\u9A0F", "\u8006", "\u9324" };
            zhuyin[443] = new string[] { "fu; = \u3111\u3127\u3124       ", "\u93D8", "\u69CD", "\u9397", "\u8154", "\u7F8C" };
            zhuyin[444] = new string[] { "fu;3 = \u3111\u3127\u3124\u02c7       ", "\u6436", "\u93F9", "\u7E48" };
            zhuyin[445] = new string[] { "fu;4 = \u3111\u3127\u3124\u02cb       ", "\u55C6" };
            zhuyin[446] = new string[] { "fu;6 = \u3111\u3127\u3124\u02ca       ", "\u5F37", "\u7246", "\u8594" };
            zhuyin[447] = new string[] { "ful = \u3111\u3127\u3120       ", "\u6084", "\u6572", "\u936C" };
            zhuyin[448] = new string[] { "ful3 = \u3111\u3127\u3120\u02c7       ", "\u5DE7" };
            zhuyin[449] = new string[] { "ful4 = \u3111\u3127\u3120\u02cb       ", "\u4FCF", "\u7FF9", "\u5CED", "\u7AC5", "\u9798", "\u64AC", "\u8E7A" };
            zhuyin[450] = new string[] { "ful6 = \u3111\u3127\u3120\u02ca       ", "\u77A7", "\u6A4B", "\u50D1", "\u55AC", "\u6A35", "\u854E" };
            zhuyin[451] = new string[] { "fup = \u3111\u3127\u3123       ", "\u99F8", "\u89AA", "\u6B3D", "\u4FB5" };
            zhuyin[452] = new string[] { "fup3 = \u3111\u3127\u3123\u02c7       ", "\u5BE2" };
            zhuyin[453] = new string[] { "fup4 = \u3111\u3127\u3123\u02cb       ", "\u6C81" };
            zhuyin[454] = new string[] { "fup6 = \u3111\u3127\u3123\u02ca       ", "\u52E4", "\u7434", "\u79E6", "\u64D2", "\u79BD", "\u82B9" };
            zhuyin[455] = new string[] { "g = \u3115       ", "\u3115", "\u6EBC", "\u5931", "\u65BD", "\u5E2B", "\u8A69", "\u7345", "\u5C4D", "\u6FD5", "\u8768" };
            zhuyin[456] = new string[] { "g. = \u3115\u3121       ", "\u6536" };
            zhuyin[457] = new string[] { "g.3 = \u3115\u3121\u02c7       ", "\u9996", "\u624B", "\u5B88" };
            zhuyin[458] = new string[] { "g.4 = \u3115\u3121\u02cb       ", "\u6388", "\u53D7", "\u7626", "\u552E", "\u58FD" };
            zhuyin[459] = new string[] { "g.6 = \u3115\u3121\u02ca       ", "\u719F" };
            zhuyin[460] = new string[] { "g/ = \u3115\u3125       ", "\u8072", "\u751F", "\u5347", "\u6607", "\u965E", "\u7B19", "\u7272", "\u7525", "\u80DC" };
            zhuyin[461] = new string[] { "g/3 = \u3115\u3125\u02c7       ", "\u7701" };
            zhuyin[462] = new string[] { "g/4 = \u3115\u3125\u02cb       ", "\u52DD", "\u76DB", "\u8056", "\u5269" };
            zhuyin[463] = new string[] { "g/6 = \u3115\u3125\u02ca       ", "\u7E69", "\u6FA0" };
            zhuyin[464] = new string[] { "g0 = \u3115\u3122       ", "\u5C71", "\u73CA", "\u6749", "\u522A", "\u886B", "\u6427", "\u8222", "\u6F78" };
            zhuyin[465] = new string[] { "g03 = \u3115\u3122\u02c7       ", "\u9583", "\u965C" };
            zhuyin[466] = new string[] { "g04 = \u3115\u3122\u02cb       ", "\u8A15", "\u5584", "\u64C5", "\u6247", "\u717D", "\u759D", "\u79AA" };
            zhuyin[467] = new string[] { "g3 = \u3115\u02c7       ", "\u4F7F", "\u53F2", "\u59CB", "\u99DB", "\u77E2", "\u5C4E" };
            zhuyin[468] = new string[] { "g4 = \u3115\u02cb       ", "\u4E8B", "\u662F", "\u5F0F", "\u5E02", "\u5BA4", "\u8996", "\u793A", "\u4E16", "\u58EB", "\u52E2", "\u8A66", "\u91CB", "\u8B58", "\u6C0F", "\u9069", "\u98FE", "\u4ED5", "\u901D", "\u8A93", "\u4F8D", "\u55DC", "\u5F12", "\u566C", "\u62ED", "\u67FF", "\u8EFE" };
            zhuyin[469] = new string[] { "g6 = \u3115\u02ca       ", "\u5341", "\u6642", "\u77F3", "\u5BE6", "\u98DF", "\u62FE", "\u8755" };
            zhuyin[470] = new string[] { "g7 = \u3115\u02d9       ", "\u5319" };
            zhuyin[471] = new string[] { "g8 = \u3115\u311a       ", "\u6BBA", "\u6C99", "\u838E", "\u7802", "\u9BCA", "\u7D17", "\u88DF" };
            zhuyin[472] = new string[] { "g83 = \u3115\u311a\u02c7       ", "\u50BB" };
            zhuyin[473] = new string[] { "g84 = \u3115\u311a\u02cb       ", "\u715E", "\u970E", "\u524E", "\u5EC8" };
            zhuyin[474] = new string[] { "g86 = \u3115\u311a\u02ca       ", "\u5565" };
            zhuyin[475] = new string[] { "g; = \u3115\u3124       ", "\u5546", "\u50B7", "\u6BA4" };
            zhuyin[476] = new string[] { "g;3 = \u3115\u3124\u02c7       ", "\u8CDE" };
            zhuyin[477] = new string[] { "g;4 = \u3115\u3124\u02cb       ", "\u4E0A", "\u5C1A" };
            zhuyin[478] = new string[] { "g;7 = \u3115\u3124\u02d9       ", "\u88F3" };
            zhuyin[479] = new string[] { "gj = \u3115\u3128       ", "\u8F38", "\u66F8", "\u8212", "\u758F", "\u6B8A", "\u852C", "\u68B3" };
            zhuyin[480] = new string[] { "gj3 = \u3115\u3128\u02c7       ", "\u7F72", "\u5C6C", "\u9F20", "\u6691" };
            zhuyin[481] = new string[] { "gj4 = \u3115\u3128\u02cb       ", "\u6578", "\u8853", "\u6055", "\u6A39", "\u8C4E" };
            zhuyin[482] = new string[] { "gj6 = \u3115\u3128\u02ca       ", "\u6DD1", "\u53D4", "\u8D16" };
            zhuyin[483] = new string[] { "gj8 = \u3115\u3128\u311a       ", "\u5237" };
            zhuyin[484] = new string[] { "gj83 = \u3115\u3128\u311a\u02c7       ", "\u800D" };
            zhuyin[485] = new string[] { "gj9 = \u3115\u3128\u311e       ", "\u8870", "\u6454" };
            zhuyin[486] = new string[] { "gj93 = \u3115\u3128\u311e\u02c7       ", "\u7529" };
            zhuyin[487] = new string[] { "gj94 = \u3115\u3128\u311e\u02cb       ", "\u5E25", "\u87C0" };
            zhuyin[488] = new string[] { "gj; = \u3115\u3128\u3124       ", "\u96D9", "\u971C" };
            zhuyin[489] = new string[] { "gj;3 = \u3115\u3128\u3124\u02c7       ", "\u723D" };
            zhuyin[490] = new string[] { "gji = \u3115\u3128\u311b       ", "\u8AAA" };
            zhuyin[491] = new string[] { "gji4 = \u3115\u3128\u311b\u02cb       ", "\u78A9", "\u6714", "\u720D" };
            zhuyin[492] = new string[] { "gjo3 = \u3115\u3128\u311f\u02c7       ", "\u6C34" };
            zhuyin[493] = new string[] { "gjo4 = \u3115\u3128\u311f\u02cb       ", "\u7761", "\u7A05" };
            zhuyin[494] = new string[] { "gjo6 = \u3115\u3128\u311f\u02ca       ", "\u8AB0" };
            zhuyin[495] = new string[] { "gk = \u3115\u311c       ", "\u5953", "\u5962", "\u8CD2" };
            zhuyin[496] = new string[] { "gk3 = \u3115\u311c\u02c7       ", "\u6368" };
            zhuyin[497] = new string[] { "gk4 = \u3115\u311c\u02cb       ", "\u820D", "\u8A2D", "\u793E", "\u6D89", "\u651D", "\u5C04", "\u8D66", "\u9E9D" };
            zhuyin[498] = new string[] { "gk6 = \u3115\u311c\u02ca       ", "\u4F58", "\u86C7", "\u4EC0", "\u820C" };
            zhuyin[499] = new string[] { "gl = \u3115\u3120       ", "\u7A0D", "\u71D2", "\u634E" };
            zhuyin[500] = new string[] { "gl4 = \u3115\u3120\u02cb       ", "\u7D39", "\u90B5", "\u54E8", "\u5C11" };
            zhuyin[501] = new string[] { "gl6 = \u3115\u3120\u02ca       ", "\u52FA", "\u97F6", "\u6753" };
            zhuyin[502] = new string[] { "gp = \u3115\u3123       ", "\u6DF1", "\u8EAB", "\u7533", "\u4F38", "\u7D33", "\u7521" };
            zhuyin[503] = new string[] { "gp3 = \u3115\u3123\u02c7       ", "\u5B38", "\u6C88", "\u5BE9", "\u700B", "\u8B85" };
            zhuyin[504] = new string[] { "gp4 = \u3115\u3123\u02cb       ", "\u614E", "\u751A", "\u814E", "\u6939", "\u6EF2" };
            zhuyin[505] = new string[] { "gp6 = \u3115\u3123\u02ca       ", "\u795E" };
            zhuyin[506] = new string[] { "h = \u3118       ", "\u3118", "\u96CC", "\u75B5" };
            zhuyin[507] = new string[] { "h/4 = \u3118\u3125\u02cb       ", "\u8E6D" };
            zhuyin[508] = new string[] { "h/6 = \u3118\u3125\u02ca       ", "\u5C64" };
            zhuyin[509] = new string[] { "h0 = \u3118\u3122       ", "\u9910", "\u53C3" };
            zhuyin[510] = new string[] { "h03 = \u3118\u3122\u02c7       ", "\u6158" };
            zhuyin[511] = new string[] { "h04 = \u3118\u3122\u02cb       ", "\u71E6", "\u74A8" };
            zhuyin[512] = new string[] { "h06 = \u3118\u3122\u02ca       ", "\u6B98", "\u8836", "\u615A" };
            zhuyin[513] = new string[] { "h3 = \u3118\u02c7       ", "\u6B64" };
            zhuyin[514] = new string[] { "h4 = \u3118\u02cb       ", "\u523A", "\u6B21" };
            zhuyin[515] = new string[] { "h6 = \u3118\u02ca       ", "\u6148", "\u8FAD", "\u8A5E", "\u78C1", "\u74F7", "\u7960" };
            zhuyin[516] = new string[] { "h9 = \u3118\u311e       ", "\u731C" };
            zhuyin[517] = new string[] { "h93 = \u3118\u311e\u02c7       ", "\u5F69", "\u63A1", "\u91C7" };
            zhuyin[518] = new string[] { "h94 = \u3118\u311e\u02cb       ", "\u83DC", "\u8521" };
            zhuyin[519] = new string[] { "h96 = \u3118\u311e\u02ca       ", "\u6750", "\u624D", "\u8CA1", "\u88C1" };
            zhuyin[520] = new string[] { "h; = \u3118\u3124       ", "\u84BC", "\u5009", "\u8259", "\u6EC4" };
            zhuyin[521] = new string[] { "h;6 = \u3118\u3124\u02ca       ", "\u85CF" };
            zhuyin[522] = new string[] { "hj/ = \u3118\u3128\u3125       ", "\u5306", "\u8070" };
            zhuyin[523] = new string[] { "hj/6 = \u3118\u3128\u3125\u02ca       ", "\u6DD9", "\u5F9E", "\u53E2", "\u742E", "\u6B09" };
            zhuyin[524] = new string[] { "hji = \u3118\u3128\u311b       ", "\u6413", "\u64AE" };
            zhuyin[525] = new string[] { "hji4 = \u3118\u3128\u311b\u02cb       ", "\u92BC", "\u932F", "\u632B", "\u63AA", "\u539D", "\u5249" };
            zhuyin[526] = new string[] { "hjo = \u3118\u3128\u311f       ", "\u5D14", "\u50AC", "\u6467" };
            zhuyin[527] = new string[] { "hjo4 = \u3118\u3128\u311f\u02cb       ", "\u8106", "\u7FE0", "\u7CB9" };
            zhuyin[528] = new string[] { "hjp = \u3118\u3128\u3123       ", "\u6751" };
            zhuyin[529] = new string[] { "hjp4 = \u3118\u3128\u3123\u02cb       ", "\u540B", "\u5BF8" };
            zhuyin[530] = new string[] { "hjp6 = \u3118\u3128\u3123\u02ca       ", "\u5B58" };
            zhuyin[531] = new string[] { "hk4 = \u3118\u311c\u02cb       ", "\u6E2C", "\u5074", "\u7B56", "\u5EC1" };
            zhuyin[532] = new string[] { "hl = \u3118\u3120       ", "\u64CD", "\u7CD9" };
            zhuyin[533] = new string[] { "hl3 = \u3118\u3120\u02c7       ", "\u8349" };
            zhuyin[534] = new string[] { "hl4 = \u3118\u3120\u02cb       ", "\u64CD", "\u7CD9" };
            zhuyin[535] = new string[] { "hl6 = \u3118\u3120\u02ca       ", "\u66F9", "\u69FD" };
            zhuyin[536] = new string[] { "hp6 = \u3118\u3123\u02ca       ", "\u5C91" };
            zhuyin[537] = new string[] { "i = \u311b       ", "\u311B" };
            zhuyin[538] = new string[] { "j = \u3128       ", "\u3128", "\u55DA", "\u5C4B", "\u70CF", "\u5DEB", "\u6C61" };
            zhuyin[539] = new string[] { "j0 = \u3128\u3122       ", "\u5F4E", "\u7063" };
            zhuyin[540] = new string[] { "j03 = \u3128\u3122\u02c7       ", "\u7897", "\u665A", "\u5B9B", "\u6D63" };
            zhuyin[541] = new string[] { "j04 = \u3128\u3122\u02cb       ", "\u842C", "\u8155" };
            zhuyin[542] = new string[] { "j06 = \u3128\u3122\u02ca       ", "\u73A9", "\u5B8C", "\u4E38", "\u9811" };
            zhuyin[543] = new string[] { "j3 = \u3128\u02c7       ", "\u4E94", "\u6B66", "\u5348", "\u821E", "\u4F0D" };
            zhuyin[544] = new string[] { "j4 = \u3128\u02cb       ", "\u7269", "\u52D9", "\u52FF", "\u8AA4", "\u9727", "\u609F", "\u620A" };
            zhuyin[545] = new string[] { "j6 = \u3128\u02ca       ", "\u7121", "\u5433", "\u543E", "\u8AA3", "\u68A7" };
            zhuyin[546] = new string[] { "j8 = \u3128\u311a       ", "\u54C7", "\u6316", "\u86D9", "\u7AAA" };
            zhuyin[547] = new string[] { "j83 = \u3128\u311a\u02c7       ", "\u74E6" };
            zhuyin[548] = new string[] { "j84 = \u3128\u311a\u02cb       ", "\u896A" };
            zhuyin[549] = new string[] { "j9 = \u3128\u311e       ", "\u6B6A" };
            zhuyin[550] = new string[] { "j94 = \u3128\u311e\u02cb       ", "\u5916" };
            zhuyin[551] = new string[] { "j; = \u3128\u3124       ", "\u6C6A" };
            zhuyin[552] = new string[] { "j;3 = \u3128\u3124\u02c7       ", "\u7DB2", "\u5F80", "\u7F54" };
            zhuyin[553] = new string[] { "j;4 = \u3128\u3124\u02cb       ", "\u65FA", "\u671B", "\u5FD8", "\u5984" };
            zhuyin[554] = new string[] { "j;6 = \u3128\u3124\u02ca       ", "\u738B", "\u4EA1" };
            zhuyin[555] = new string[] { "ji = \u3128\u311b       ", "\u7AA9", "\u502D", "\u6E26" };
            zhuyin[556] = new string[] { "ji3 = \u3128\u311b\u02c7       ", "\u6211" };
            zhuyin[557] = new string[] { "ji4 = \u3128\u311b\u02cb       ", "\u63E1", "\u81E5", "\u9F77", "\u6FE3" };
            zhuyin[558] = new string[] { "jo = \u3128\u311f       ", "\u5A01", "\u5D34" };
            zhuyin[559] = new string[] { "jo3 = \u3128\u311f\u02c7       ", "\u59D4", "\u5049", "\u5C3E", "\u744B", "\u7DEF", "\u9BAA" };
            zhuyin[560] = new string[] { "jo4 = \u3128\u311f\u02cb       ", "\u9935", "\u4F4D", "\u672A", "\u5473", "\u885B", "\u9B4F", "\u8B02", "\u80C3", "\u754F" };
            zhuyin[561] = new string[] { "jo6 = \u3128\u311f\u02ca       ", "\u8587", "\u70BA", "\u7DAD", "\u5371", "\u5FAE", "\u570D", "\u97CB", "\u6845" };
            zhuyin[562] = new string[] { "jp = \u3128\u3123       ", "\u6EAB", "\u586D", "\u761F" };
            zhuyin[563] = new string[] { "jp3 = \u3128\u3123\u02c7       ", "\u7A69" };
            zhuyin[564] = new string[] { "jp4 = \u3128\u3123\u02cb       ", "\u554F", "\u6C76", "\u7D0A" };
            zhuyin[565] = new string[] { "jp6 = \u3128\u3123\u02ca       ", "\u96EF", "\u6587", "\u805E", "\u7D0B", "\u868A", "\u82A0", "\u741D", "\u95BA" };
            zhuyin[566] = new string[] { "k = \u311c       ", "\u311C" };
            zhuyin[567] = new string[] { "l = \u3120       ", "\u3120", "\u51F9" };
            zhuyin[568] = new string[] { "l3 = \u3120\u02c7       ", "\u8956", "\u62D7" };
            zhuyin[569] = new string[] { "l4 = \u3120\u02cb       ", "\u6FB3", "\u5967", "\u50B2" };
            zhuyin[570] = new string[] { "l6 = \u3120\u02ca       ", "\u6556", "\u71AC", "\u7FF1" };
            zhuyin[571] = new string[] { "m = \u3129       ", "\u3129", "\u6DE4", "\u8FC2" };
            zhuyin[572] = new string[] { "m, = \u3129       ", "\u7D04", "\u66F0" };
            zhuyin[573] = new string[] { "m,4 = \u3129       ", "\u6708", "\u8D8A", "\u95B1", "\u7CB5", "\u6085", "\u5CB3" };
            zhuyin[574] = new string[] { "m/ = \u3129\u3125       ", "\u5EB8", "\u96CD", "\u50AD", "\u93DE", "\u5889", "\u58C5", "\u64C1" };
            zhuyin[575] = new string[] { "m/3 = \u3129\u3125\u02c7       ", "\u8A60", "\u6C38", "\u52C7", "\u6CF3", "\u6E67", "\u4FD1", "\u752C", "\u86F9", "\u8E34" };
            zhuyin[576] = new string[] { "m/4 = \u3129\u3125\u02cb       ", "\u7528", "\u4F63" };
            zhuyin[577] = new string[] { "m0 = \u3129\u3122       ", "\u51A4", "\u6DF5", "\u9CF6", "\u9D1B", "\u5B9B", "\u68E9", "\u7722", "\u847E" };
            zhuyin[578] = new string[] { "m03 = \u3129\u3122\u02c7       ", "\u9060" };
            zhuyin[579] = new string[] { "m04 = \u3129\u3122\u02cb       ", "\u6028", "\u9662", "\u9858", "\u82D1", "\u613F" };
            zhuyin[580] = new string[] { "m06 = \u3129\u3122\u02ca       ", "\u6E90", "\u5143", "\u5713", "\u539F", "\u54E1", "\u5712", "\u63F4", "\u7DE3", "\u8881", "\u5A9B", "\u57A3", "\u7230", "\u733F" };
            zhuyin[581] = new string[] { "m3 = \u3129\u02c7       ", "\u79B9", "\u8207", "\u5B87", "\u4E88", "\u96E8", "\u8A9E", "\u5DBC", "\u7FBD", "\u7440", "\u5EBE" };
            zhuyin[582] = new string[] { "m4 = \u3129\u02cb       ", "\u80B2", "\u6108", "\u7389", "\u9810", "\u6B32", "\u88D5", "\u9047", "\u57DF", "\u6631", "\u90C1", "\u6BD3", "\u7344", "\u6D74", "\u8B7D", "\u715C", "\u5FA1", "\u5BD3", "\u828B", "\u8C6B" };
            zhuyin[583] = new string[] { "m6 = \u3129\u02ca       ", "\u5A1B", "\u65BC", "\u9918", "\u745C", "\u903E", "\u9B5A", "\u4F59", "\u4E8E", "\u865E", "\u6F01", "\u4FDE", "\u611A", "\u59A4", "\u6986", "\u9685", "\u8F3F", "\u7AFD", "\u81FE", "\u8753", "\u8E30", "\u4E88" };
            zhuyin[584] = new string[] { "mp = \u3129\u3123       ", "\u6688" };
            zhuyin[585] = new string[] { "mp3 = \u3129\u3123\u02c7       ", "\u5141", "\u6B9E", "\u9695" };
            zhuyin[586] = new string[] { "mp4 = \u3129\u3123\u02cb       ", "\u904B", "\u5B55", "\u97FB", "\u860A", "\u919E", "\u71A8" };
            zhuyin[587] = new string[] { "mp6 = \u3129\u3123\u02ca       ", "\u4E91", "\u96F2", "\u82B8", "\u7B60", "\u52FB", "\u8018" };
            zhuyin[588] = new string[] { "n = \u3119       ", "\u3119", "\u6495", "\u65AF", "\u601D", "\u7D72", "\u53F8", "\u79C1", "\u5636", "\u5EDD" };
            zhuyin[589] = new string[] { "n. = \u3119\u3121       ", "\u641C", "\u98BC", "\u8490", "\u993F" };
            zhuyin[590] = new string[] { "n.3 = \u3119\u3121\u02c7       ", "\u53DF", "\u85EA", "\u8B0F" };
            zhuyin[591] = new string[] { "n.4 = \u3119\u3121\u02cb       ", "\u55FD" };
            zhuyin[592] = new string[] { "n/ = \u3119\u3125       ", "\u50E7" };
            zhuyin[593] = new string[] { "n0 = \u3119\u3122       ", "\u4E09", "\u53C1" };
            zhuyin[594] = new string[] { "n03 = \u3119\u3122\u02c7       ", "\u5098", "\u7E56" };
            zhuyin[595] = new string[] { "n04 = \u3119\u3122\u02cb       ", "\u6563" };
            zhuyin[596] = new string[] { "n3 = \u3119\u02c7       ", "\u6B7B" };
            zhuyin[597] = new string[] { "n4 = \u3119\u02cb       ", "\u56DB", "\u4F3C", "\u5BFA", "\u8086", "\u98FC", "\u55E3", "\u6CD7", "\u7940", "\u5DF3", "\u99DF", "\u4F3A", "\u8CDC" };
            zhuyin[598] = new string[] { "n8 = \u3119\u311a       ", "\u6492" };
            zhuyin[599] = new string[] { "n83 = \u3119\u311a\u02c7       ", "\u7051" };
            zhuyin[600] = new string[] { "n84 = \u3119\u311a\u02cb       ", "\u85A9" };
            zhuyin[601] = new string[] { "n9 = \u3119\u311e       ", "\u585E", "\u816E" };
            zhuyin[602] = new string[] { "n94 = \u3119\u311e\u02cb       ", "\u8CFD" };
            zhuyin[603] = new string[] { "nj = \u3119\u3128       ", "\u7A4C", "\u8607", "\u9165", "\u7526" };
            zhuyin[604] = new string[] { "nj/ = \u3119\u3128\u3125       ", "\u9B06", "\u677E", "\u5FEA", "\u5D27", "\u5D69", "\u6DDE" };
            zhuyin[605] = new string[] { "nj/3 = \u3119\u3128\u3125\u02c7       ", "\u8073", "\u609A" };
            zhuyin[606] = new string[] { "nj/4 = \u3119\u3128\u3125\u02cb       ", "\u5B8B", "\u9001", "\u980C", "\u8A1F", "\u8AA6" };
            zhuyin[607] = new string[] { "nj0 = \u3119\u3128\u3122       ", "\u9178", "\u75E0" };
            zhuyin[608] = new string[] { "nj04 = \u3119\u3128\u3122\u02cb       ", "\u7B97", "\u849C" };
            zhuyin[609] = new string[] { "nj4 = \u3119\u3128\u02cb       ", "\u7C0C", "\u901F", "\u8A34", "\u7D20", "\u5851", "\u8085", "\u5BBF", "\u6EAF", "\u5919", "\u612B", "\u6CDD", "\u6D91", "\u7C9F", "\u8B16" };
            zhuyin[610] = new string[] { "nj6 = \u3119\u3128\u02ca       ", "\u4FD7" };
            zhuyin[611] = new string[] { "nji = \u3119\u3128\u311b       ", "\u7E2E", "\u68AD", "\u5506", "\u7C11" };
            zhuyin[612] = new string[] { "nji3 = \u3119\u3128\u311b\u02c7       ", "\u7D22", "\u6240", "\u9396", "\u55E9", "\u7463" };
            zhuyin[613] = new string[] { "nji4 = \u3119\u3128\u311b\u02cb       ", "\u9024" };
            zhuyin[614] = new string[] { "njo = \u3119\u3128\u311f       ", "\u96D6", "\u7D8F" };
            zhuyin[615] = new string[] { "njo3 = \u3119\u3128\u311f\u02c7       ", "\u9AD3" };
            zhuyin[616] = new string[] { "njo4 = \u3119\u3128\u311f\u02cb       ", "\u788E", "\u6B72", "\u9042", "\u7A57", "\u96A7" };
            zhuyin[617] = new string[] { "njo6 = \u3119\u3128\u311f\u02ca       ", "\u96A8", "\u968B" };
            zhuyin[618] = new string[] { "njp = \u3119\u3128\u3123       ", "\u5B6B", "\u84C0" };
            zhuyin[619] = new string[] { "njp3 = \u3119\u3128\u3123\u02c7       ", "\u7B4D", "\u640D" };
            zhuyin[620] = new string[] { "nk4 = \u3119\u311c\u02cb       ", "\u573E", "\u8272", "\u745F", "\u6F80", "\u92AB" };
            zhuyin[621] = new string[] { "nl = \u3119\u3120       ", "\u6414", "\u8258", "\u9A37" };
            zhuyin[622] = new string[] { "nl3 = \u3119\u3120\u02c7       ", "\u6383", "\u5AC2", "\u57FD" };
            zhuyin[623] = new string[] { "nl4 = \u3119\u3120\u02cb       ", "\u81CA" };
            zhuyin[624] = new string[] { "o = \u311f       ", "\u311F" };
            zhuyin[625] = new string[] { "p = \u3123       ", "\u3123", "\u55EF", "\u6069" };
            zhuyin[626] = new string[] { "q = \u3106       ", "\u3106" };
            zhuyin[627] = new string[] { "q/ = \u3106\u3125       ", "\u7830", "\u70F9", "\u6F8E" };
            zhuyin[628] = new string[] { "q/3 = \u3106\u3125\u02c7       ", "\u6367" };
            zhuyin[629] = new string[] { "q/4 = \u3106\u3125\u02cb       ", "\u78B0", "\u692A" };
            zhuyin[630] = new string[] { "q/6 = \u3106\u3125\u02ca       ", "\u84EC", "\u5F6D", "\u9D6C", "\u6F8E", "\u81A8", "\u670B" };
            zhuyin[631] = new string[] { "q0 = \u3106\u3122       ", "\u6F58", "\u6500", "\u756A" };
            zhuyin[632] = new string[] { "q04 = \u3106\u3122\u02cb       ", "\u76FC", "\u5224", "\u7554", "\u53DB" };
            zhuyin[633] = new string[] { "q06 = \u3106\u3122\u02ca       ", "\u76E4", "\u78D0", "\u69C3" };
            zhuyin[634] = new string[] { "q8 = \u3106\u311a       ", "\u556A", "\u8DB4" };
            zhuyin[635] = new string[] { "q84 = \u3106\u311a\u02cb       ", "\u6015", "\u5E15" };
            zhuyin[636] = new string[] { "q86 = \u3106\u311a\u02ca       ", "\u722C", "\u6252", "\u6777", "\u7436", "\u8019" };
            zhuyin[637] = new string[] { "q9 = \u3106\u311e       ", "\u62CD", "\u556A" };
            zhuyin[638] = new string[] { "q94 = \u3106\u311e\u02cb       ", "\u6D3E", "\u6E43" };
            zhuyin[639] = new string[] { "q96 = \u3106\u311e\u02ca       ", "\u6392", "\u724C", "\u5F98" };
            zhuyin[640] = new string[] { "q; = \u3106\u3124       ", "\u4E53", "\u6EC2" };
            zhuyin[641] = new string[] { "q;4 = \u3106\u3124\u02cb       ", "\u80D6" };
            zhuyin[642] = new string[] { "q;6 = \u3106\u3124\u02ca       ", "\u65C1", "\u9F90", "\u5FAC", "\u8180" };
            zhuyin[643] = new string[] { "qi = \u3106\u311b       ", "\u6CE2", "\u6F51", "\u5761" };
            zhuyin[644] = new string[] { "qi3 = \u3106\u311b\u02c7       ", "\u9817", "\u5256" };
            zhuyin[645] = new string[] { "qi4 = \u3106\u311b\u02cb       ", "\u7834", "\u8FEB", "\u9B44", "\u6CCA" };
            zhuyin[646] = new string[] { "qi6 = \u3106\u311b\u02ca       ", "\u76A4", "\u5A46", "\u9131" };
            zhuyin[647] = new string[] { "qj = \u3106\u3128       ", "\u5657", "\u92EA", "\u64B2", "\u4EC6" };
            zhuyin[648] = new string[] { "qj3 = \u3106\u3128\u02c7       ", "\u6D66", "\u666E", "\u8B5C", "\u6EA5", "\u5703", "\u57D4" };
            zhuyin[649] = new string[] { "qj4 = \u3106\u3128\u02cb       ", "\u8216", "\u66DD", "\u7011", "\u66B4" };
            zhuyin[650] = new string[] { "qj6 = \u3106\u3128\u02ca       ", "\u50D5", "\u6734", "\u58A3", "\u6A38", "\u84B2", "\u8461", "\u749E", "\u8386", "\u530D", "\u83E9", "\u8E7C" };
            zhuyin[651] = new string[] { "ql = \u3106\u3120       ", "\u62CB" };
            zhuyin[652] = new string[] { "ql3 = \u3106\u3120\u02c7       ", "\u8DD1" };
            zhuyin[653] = new string[] { "ql4 = \u3106\u3120\u02cb       ", "\u6CE1", "\u7832", "\u70AE" };
            zhuyin[654] = new string[] { "ql6 = \u3106\u3120\u02ca       ", "\u888D", "\u5228" };
            zhuyin[655] = new string[] { "qo = \u3106\u311f       ", "\u5478", "\u80DA" };
            zhuyin[656] = new string[] { "qo4 = \u3106\u311f\u02cb       ", "\u4F69", "\u914D", "\u73EE", "\u6C9B", "\u59F5", "\u9708" };
            zhuyin[657] = new string[] { "qo6 = \u3106\u311f\u02ca       ", "\u966A", "\u57F9", "\u8CE0", "\u88F4" };
            zhuyin[658] = new string[] { "qp = \u3106\u3123       ", "\u5674", "\u6B55", "\u6FC6" };
            zhuyin[659] = new string[] { "qp6 = \u3106\u3123\u02ca       ", "\u76C6" };
            zhuyin[660] = new string[] { "qu = \u3106\u3127       ", "\u6279", "\u62AB", "\u5339", "\u5288", "\u7812", "\u9739" };
            zhuyin[661] = new string[] { "qu/ = \u3106\u3127\u3125       ", "\u4E52" };
            zhuyin[662] = new string[] { "qu/6 = \u3106\u3127\u3125\u02ca       ", "\u5E73", "\u8A55", "\u576A", "\u5C4F", "\u840D", "\u6191", "\u74F6", "\u860B" };
            zhuyin[663] = new string[] { "qu0 = \u3106\u3127\u3122       ", "\u7BC7", "\u504F", "\u7FE9" };
            zhuyin[664] = new string[] { "qu3 = \u3106\u3127\u02c7       ", "\u75DE" };
            zhuyin[665] = new string[] { "qu4 = \u3106\u3127\u02cb       ", "\u5C41", "\u95E2", "\u8B6C", "\u7247", "\u9A19", "\u904D" };
            zhuyin[666] = new string[] { "qu6 = \u3106\u3127\u02ca       ", "\u76AE", "\u75B2", "\u57E4", "\u5564", "\u813E", "\u7435", "\u6787", "\u80FC", "\u99E2" };
            zhuyin[667] = new string[] { "qul = \u3106\u3127\u3120       ", "\u6F02", "\u98C4" };
            zhuyin[668] = new string[] { "qul3 = \u3106\u3127\u3120\u02c7       ", "\u647D", "\u7E39" };
            zhuyin[669] = new string[] { "qul4 = \u3106\u3127\u3120\u02cb       ", "\u7968", "\u527D", "\u9A43" };
            zhuyin[670] = new string[] { "qul6 = \u3106\u3127\u3120\u02ca       ", "\u5AD6", "\u74E2" };
            zhuyin[671] = new string[] { "qup = \u3106\u3127\u3123       ", "\u59D8", "\u62DA" };
            zhuyin[672] = new string[] { "qup3 = \u3106\u3127\u3123\u02c7       ", "\u54C1" };
            zhuyin[673] = new string[] { "qup4 = \u3106\u3127\u3123\u02cb       ", "\u8058" };
            zhuyin[674] = new string[] { "qup6 = \u3106\u3127\u3123\u02ca       ", "\u983B", "\u8CA7", "\u5B2A", "\u7015" };
            zhuyin[675] = new string[] { "r = \u3110       ", "\u3110" };
            zhuyin[676] = new string[] { "rm = \u3110\u3129       ", "\u5C45", "\u99D2", "\u62D8", "\u72D9" };
            zhuyin[677] = new string[] { "rm, = \u3110\u3129       ", "\u5658" };
            zhuyin[678] = new string[] { "rm,3 = \u3110\u3129       ", "\u8E76" };
            zhuyin[679] = new string[] { "rm,4 = \u3110\u3129       ", "\u5014" };
            zhuyin[680] = new string[] { "rm,6 = \u3110\u3129       ", "\u6C7A", "\u7D55", "\u89BA", "\u6398", "\u8A23", "\u53A5", "\u5671", "\u7235", "\u56BC" };
            zhuyin[681] = new string[] { "rm/ = \u3110\u3129\u3125       ", "\u518F", "\u5770" };
            zhuyin[682] = new string[] { "rm/3 = \u3110\u3129\u3125\u02c7       ", "\u7A98", "\u70AF", "\u8FE5", "\u518F" };
            zhuyin[683] = new string[] { "rm0 = \u3110\u3129\u3122       ", "\u6350", "\u5A1F", "\u6D93", "\u9D51", "\u6081" };
            zhuyin[684] = new string[] { "rm03 = \u3110\u3129\u3122\u02c7       ", "\u5377", "\u6372" };
            zhuyin[685] = new string[] { "rm04 = \u3110\u3129\u3122\u02cb       ", "\u7737", "\u5026", "\u5377" };
            zhuyin[686] = new string[] { "rm3 = \u3110\u3129\u02c7       ", "\u8209", "\u6CAE", "\u77E9", "\u8392", "\u9F5F", "\u849F" };
            zhuyin[687] = new string[] { "rm4 = \u3110\u3129\u02cb       ", "\u53E5", "\u64DA", "\u5DE8", "\u8DDD", "\u805A", "\u5287", "\u5177", "\u92F8", "\u62D2", "\u61FC", "\u70AC", "\u4FF1", "\u9245", "\u8E1E", "\u907D", "\u98B6", "\u77BF" };
            zhuyin[688] = new string[] { "rm6 = \u3110\u3129\u02ca       ", "\u5C40", "\u6A58", "\u83CA", "\u6854", "\u63AC", "\u8DFC", "\u97A0" };
            zhuyin[689] = new string[] { "rmp = \u3110\u3129\u3123       ", "\u8ECD", "\u5747", "\u541B", "\u921E" };
            zhuyin[690] = new string[] { "rmp4 = \u3110\u3129\u3123\u02cb       ", "\u4FCA", "\u5733", "\u5CFB", "\u6D5A", "\u90E1", "\u7AE3", "\u83CC", "\u96CB", "\u6FEC", "\u99FF" };
            zhuyin[691] = new string[] { "ru = \u3110\u3127       ", "\u6A5F", "\u96DE", "\u7A4D", "\u6FC0", "\u8DE1", "\u98E2", "\u808C", "\u59EC", "\u5C50", "\u57FA", "\u7284", "\u7578", "\u7B95", "\u757F", "\u7A3D", "\u78EF", "\u7E3E", "\u8E5F", "\u8B4F", "\u9951", "\u7F88" };
            zhuyin[692] = new string[] { "ru, = \u3110\u3127       ", "\u63A5", "\u8857", "\u968E", "\u63ED", "\u7686" };
            zhuyin[693] = new string[] { "ru,3 = \u3110\u3127       ", "\u89E3", "\u59D0", "\u59CA" };
            zhuyin[694] = new string[] { "ru,4 = \u3110\u3127       ", "\u754C", "\u501F", "\u5C46", "\u4ECB", "\u6212", "\u82A5", "\u8AA1", "\u85C9" };
            zhuyin[695] = new string[] { "ru,6 = \u3110\u3127       ", "\u7BC0", "\u7D50", "\u622A", "\u52AB", "\u6770", "\u6840", "\u6377", "\u5091", "\u7AED", "\u6F54", "\u9821" };
            zhuyin[696] = new string[] { "ru. = \u3110\u3127\u3121       ", "\u63EA", "\u7CFE", "\u8D73", "\u557E", "\u9CE9" };
            zhuyin[697] = new string[] { "ru.3 = \u3110\u3127\u3121\u02c7       ", "\u4E5D", "\u9152", "\u4E45", "\u7078", "\u7396", "\u97ED" };
            zhuyin[698] = new string[] { "ru.4 = \u3110\u3127\u3121\u02cb       ", "\u820A", "\u5C31", "\u6551", "\u81FC", "\u7A76", "\u759A", "\u67E9", "\u5EC4", "\u8205" };
            zhuyin[699] = new string[] { "ru/ = \u3110\u3127\u3125       ", "\u7D93", "\u9A5A", "\u9BE8", "\u7CBE", "\u8396", "\u6676", "\u4EAC", "\u834A", "\u775B", "\u5162" };
            zhuyin[700] = new string[] { "ru/3 = \u3110\u3127\u3125\u02c7       ", "\u4E95", "\u666F", "\u9838", "\u8B66" };
            zhuyin[701] = new string[] { "ru/4 = \u3110\u3127\u3125\u02cb       ", "\u7ADF", "\u975C", "\u6DE8", "\u93E1", "\u5883", "\u656C", "\u5F91", "\u52C1", "\u9756", "\u7AF6" };
            zhuyin[702] = new string[] { "ru0 = \u3110\u3127\u3122       ", "\u9593", "\u5C16", "\u80A9", "\u517C", "\u714E", "\u6BB2", "\u5805", "\u5978", "\u59E6", "\u83C5", "\u76E3", "\u8271" };
            zhuyin[703] = new string[] { "ru03 = \u3110\u3127\u3122\u02c7       ", "\u9E7C", "\u64BF", "\u6AA2", "\u7C21", "\u7B67", "\u5109", "\u7FE6", "\u6E1B", "\u63C0", "\u526A" };
            zhuyin[704] = new string[] { "ru04 = \u3110\u3127\u3122\u02cb       ", "\u4EF6", "\u898B", "\u5EFA", "\u7BAD", "\u8CE4", "\u6F38", "\u528D", "\u6FFA", "\u5065", "\u8266", "\u9375", "\u8E10", "\u8AEB", "\u991E", "\u85A6", "\u9451" };
            zhuyin[705] = new string[] { "ru3 = \u3110\u3127\u02c7       ", "\u5E7E", "\u5DF1", "\u64E0", "\u810A" };
            zhuyin[706] = new string[] { "ru4 = \u3110\u3127\u02cb       ", "\u8A08", "\u8A18", "\u65E2", "\u7D00", "\u969B", "\u7E7C", "\u5B63", "\u5BC4", "\u6280", "\u5993", "\u6FDF", "\u5291", "\u60B8", "\u796D", "\u5FCC", "\u66A8", "\u5180", "\u9A65", "\u89AC" };
            zhuyin[707] = new string[] { "ru6 = \u3110\u3127\u02ca       ", "\u6025", "\u6975", "\u53CA", "\u7D1A", "\u5373", "\u96C6", "\u7C4D", "\u75BE", "\u4E9F", "\u5409", "\u5BC2", "\u68D8", "\u5AC9", "\u696B", "\u8F2F", "\u64CA" };
            zhuyin[708] = new string[] { "ru8 = \u3110\u3127\u311a       ", "\u5BB6", "\u52A0", "\u5609", "\u4F73", "\u50A2", "\u8FE6", "\u67B7", "\u8888" };
            zhuyin[709] = new string[] { "ru83 = \u3110\u3127\u311a\u02c7       ", "\u5047", "\u7532", "\u8CC8" };
            zhuyin[710] = new string[] { "ru84 = \u3110\u3127\u311a\u02cb       ", "\u50F9", "\u5047", "\u67B6", "\u99D5", "\u5AC1", "\u8CC8", "\u7A3C" };
            zhuyin[711] = new string[] { "ru86 = \u3110\u3127\u311a\u02ca       ", "\u593E", "\u633E", "\u9830", "\u83A2", "\u823A" };
            zhuyin[712] = new string[] { "ru; = \u3110\u3127\u3124       ", "\u5C07", "\u6C5F", "\u6F3F", "\u59DC", "\u7586", "\u8591", "\u50F5", "\u6BAD" };
            zhuyin[713] = new string[] { "ru;3 = \u3110\u3127\u3124\u02c7       ", "\u8B1B", "\u734E", "\u8523", "\u69F3" };
            zhuyin[714] = new string[] { "ru;4 = \u3110\u3127\u3124\u02cb       ", "\u964D", "\u91AC", "\u5320", "\u7D73" };
            zhuyin[715] = new string[] { "rul = \u3110\u3127\u3120       ", "\u4EA4", "\u6559", "\u6F86", "\u7126", "\u5B0C", "\u81A0", "\u7901", "\u90CA", "\u8DE4", "\u9A55" };
            zhuyin[716] = new string[] { "rul3 = \u3110\u3127\u3120\u02c7       ", "\u89D2", "\u8173", "\u652A", "\u7E73", "\u7D5E", "\u72E1", "\u527F", "\u50E5", "\u9903", "\u77EF", "\u4F7C", "\u7B4A", "\u87DC" };
            zhuyin[717] = new string[] { "rul4 = \u3110\u3127\u3120\u02cb       ", "\u53EB", "\u8F03", "\u6559", "\u89BA", "\u8F4E", "\u7A96", "\u91AE" };
            zhuyin[718] = new string[] { "rul6 = \u3110\u3127\u3120\u02ca       ", "\u56BC" };
            zhuyin[719] = new string[] { "rup = \u3110\u3127\u3123       ", "\u65A4", "\u91D1", "\u4ECA", "\u7B4B", "\u895F", "\u5DFE", "\u6D25", "\u77DC" };
            zhuyin[720] = new string[] { "rup3 = \u3110\u3127\u3123\u02c7       ", "\u7DCA", "\u50C5", "\u9326", "\u8B39", "\u747E", "\u5118" };
            zhuyin[721] = new string[] { "rup4 = \u3110\u3127\u3123\u02cb       ", "\u9032", "\u8FD1", "\u52C1", "\u76E1", "\u6D78", "\u7981", "\u6649", "\u5664", "\u89B2", "\u9773" };
            zhuyin[722] = new string[] { "s = \u310b       ", "\u310B" };
            zhuyin[723] = new string[] { "s/6 = \u310b\u3125\u02ca       ", "\u80FD" };
            zhuyin[724] = new string[] { "s03 = \u310b\u3122\u02c7       ", "\u6E73", "\u8169", "\u8D67" };
            zhuyin[725] = new string[] { "s06 = \u310b\u3122\u02ca       ", "\u5583", "\u5357", "\u96E3", "\u7537" };
            zhuyin[726] = new string[] { "s84 = \u310b\u311a\u02cb       ", "\u7D0D", "\u90A3", "\u9209", "\u637A", "\u54EA", "\u5A1C" };
            zhuyin[727] = new string[] { "s86 = \u310b\u311a\u02ca       ", "\u62FF" };
            zhuyin[728] = new string[] { "s93 = \u310b\u311e\u02c7       ", "\u4E43", "\u5976", "\u8FFA", "\u6C16" };
            zhuyin[729] = new string[] { "s94 = \u310b\u311e\u02cb       ", "\u5948", "\u8010" };
            zhuyin[730] = new string[] { "sj/4 = \u310b\u3128\u3125\u02cb       ", "\u5F04" };
            zhuyin[731] = new string[] { "sj/6 = \u310b\u3128\u3125\u02ca       ", "\u6FC3", "\u8FB2", "\u5102", "\u81BF" };
            zhuyin[732] = new string[] { "sj03 = \u310b\u3128\u3122\u02c7       ", "\u6696" };
            zhuyin[733] = new string[] { "sj3 = \u310b\u3128\u02c7       ", "\u52AA", "\u5F29" };
            zhuyin[734] = new string[] { "sj4 = \u310b\u3128\u02cb       ", "\u6012" };
            zhuyin[735] = new string[] { "sj6 = \u310b\u3128\u02ca       ", "\u5974", "\u99D1" };
            zhuyin[736] = new string[] { "sji4 = \u310b\u3128\u311b\u02cb       ", "\u8AFE", "\u61E6", "\u7CEF" };
            zhuyin[737] = new string[] { "sji6 = \u310b\u3128\u311b\u02ca       ", "\u632A" };
            zhuyin[738] = new string[] { "sl = \u310b\u3120       ", "\u5B6C" };
            zhuyin[739] = new string[] { "sl3 = \u310b\u3120\u02c7       ", "\u8166", "\u60F1", "\u7459" };
            zhuyin[740] = new string[] { "sl4 = \u310b\u3120\u02cb       ", "\u9B27" };
            zhuyin[741] = new string[] { "sl6 = \u310b\u3120\u02ca       ", "\u6493" };
            zhuyin[742] = new string[] { "sm3 = \u310b\u3129\u02c7       ", "\u5973" };
            zhuyin[743] = new string[] { "so3 = \u310b\u311f\u02c7       ", "\u9912" };
            zhuyin[744] = new string[] { "so4 = \u310b\u311f\u02cb       ", "\u5167" };
            zhuyin[745] = new string[] { "su, = \u310b\u3127       ", "\u634F" };
            zhuyin[746] = new string[] { "su,4 = \u310b\u3127       ", "\u8076", "\u93B3", "\u6D85" };
            zhuyin[747] = new string[] { "su. = \u310b\u3127\u3121       ", "\u599E" };
            zhuyin[748] = new string[] { "su.3 = \u310b\u3127\u3121\u02c7       ", "\u626D", "\u7D10", "\u9215" };
            zhuyin[749] = new string[] { "su/3 = \u310b\u3127\u3125\u02c7       ", "\u64F0" };
            zhuyin[750] = new string[] { "su/4 = \u310b\u3127\u3125\u02cb       ", "\u4F5E", "\u6FD8", "\u64F0", "\u752F" };
            zhuyin[751] = new string[] { "su/6 = \u310b\u3127\u3125\u02ca       ", "\u5BE7", "\u51DD", "\u64F0", "\u7370", "\u725B" };
            zhuyin[752] = new string[] { "su03 = \u310b\u3127\u3122\u02c7       ", "\u8F3E", "\u649A", "\u637B", "\u62C8" };
            zhuyin[753] = new string[] { "su04 = \u310b\u3127\u3122\u02cb       ", "\u5538", "\u5FF5" };
            zhuyin[754] = new string[] { "su06 = \u310b\u3127\u3122\u02ca       ", "\u5E74", "\u7C98", "\u9ECF" };
            zhuyin[755] = new string[] { "su3 = \u310b\u3127\u02c7       ", "\u4F60", "\u59B3", "\u64EC" };
            zhuyin[756] = new string[] { "su4 = \u310b\u3127\u02cb       ", "\u81A9", "\u9006", "\u6EBA", "\u533F", "\u66B1" };
            zhuyin[757] = new string[] { "su6 = \u310b\u3127\u02ca       ", "\u59AE", "\u5C3C", "\u6CE5", "\u502A", "\u9713" };
            zhuyin[758] = new string[] { "sul3 = \u310b\u3127\u3120\u02c7       ", "\u9CE5" };
            zhuyin[759] = new string[] { "sul4 = \u310b\u3127\u3120\u02cb       ", "\u5C3F" };
            zhuyin[760] = new string[] { "sup6 = \u310b\u3127\u3123\u02ca       ", "\u60A8" };
            zhuyin[761] = new string[] { "t = \u3114       ", "\u3114", "\u75F4", "\u5403", "\u7661" };
            zhuyin[762] = new string[] { "t. = \u3114\u3121       ", "\u62BD" };
            zhuyin[763] = new string[] { "t.3 = \u3114\u3121\u02c7       ", "\u919C", "\u4E11" };
            zhuyin[764] = new string[] { "t.4 = \u3114\u3121\u02cb       ", "\u81ED" };
            zhuyin[765] = new string[] { "t.6 = \u3114\u3121\u02ca       ", "\u7A20", "\u7C4C", "\u916C", "\u6101", "\u4EC7", "\u7DA2", "\u8E8A" };
            zhuyin[766] = new string[] { "t/ = \u3114\u3125       ", "\u7A31", "\u6490", "\u77A0", "\u6A55", "\u725A" };
            zhuyin[767] = new string[] { "t/3 = \u3114\u3125\u02c7       ", "\u901E", "\u9A01" };
            zhuyin[768] = new string[] { "t/4 = \u3114\u3125\u02cb       ", "\u79E4" };
            zhuyin[769] = new string[] { "t/6 = \u3114\u3125\u02ca       ", "\u57CE", "\u6210", "\u7A0B", "\u8AA0", "\u627F", "\u5448", "\u4E58", "\u6F84", "\u665F", "\u4E1E", "\u61F2", "\u57D5", "\u6A59", "\u9A2C" };
            zhuyin[770] = new string[] { "t3 = \u3114\u02c7       ", "\u544E", "\u5C3A", "\u9F52", "\u6065", "\u892B" };
            zhuyin[771] = new string[] { "t4 = \u3114\u02cb       ", "\u8D64", "\u7FC5", "\u65A5", "\u98ED", "\u71BE", "\u6470", "\u6555" };
            zhuyin[772] = new string[] { "t6 = \u3114\u02ca       ", "\u9072", "\u6301", "\u6C60", "\u99B3", "\u5319", "\u5F1B" };
            zhuyin[773] = new string[] { "t8 = \u3114\u311a       ", "\u53C9", "\u5DEE", "\u63D2" };
            zhuyin[774] = new string[] { "t84 = \u3114\u311a\u02cb       ", "\u524E", "\u5C94", "\u8A6B" };
            zhuyin[775] = new string[] { "t86 = \u3114\u311a\u02ca       ", "\u67E5", "\u5BDF", "\u8336", "\u78B4" };
            zhuyin[776] = new string[] { "t; = \u3114\u3124       ", "\u660C", "\u9329", "\u83D6", "\u88EE", "\u95B6" };
            zhuyin[777] = new string[] { "t;3 = \u3114\u3124\u02c7       ", "\u5834", "\u5EE0", "\u6636", "\u655E" };
            zhuyin[778] = new string[] { "t;4 = \u3114\u3124\u02cb       ", "\u5021", "\u5531", "\u66A2", "\u60B5" };
            zhuyin[779] = new string[] { "t;6 = \u3114\u3124\u02ca       ", "\u5E38", "\u9577", "\u5690", "\u511F", "\u5617", "\u8178", "\u5AE6", "\u5F9C" };
            zhuyin[780] = new string[] { "tj = \u3114\u3128       ", "\u9F63", "\u51FA", "\u521D" };
            zhuyin[781] = new string[] { "tj/ = \u3114\u3128\u3125       ", "\u6C96", "\u885D", "\u5145", "\u5FE1", "\u61A7" };
            zhuyin[782] = new string[] { "tj/3 = \u3114\u3128\u3125\u02c7       ", "\u5BF5" };
            zhuyin[783] = new string[] { "tj/6 = \u3114\u3128\u3125\u02ca       ", "\u87F2", "\u5D07" };
            zhuyin[784] = new string[] { "tj0 = \u3114\u3128\u3122       ", "\u7A7F", "\u5DDD" };
            zhuyin[785] = new string[] { "tj03 = \u3114\u3128\u3122\u02c7       ", "\u5598" };
            zhuyin[786] = new string[] { "tj04 = \u3114\u3128\u3122\u02cb       ", "\u4E32" };
            zhuyin[787] = new string[] { "tj06 = \u3114\u3128\u3122\u02ca       ", "\u8239", "\u50B3" };
            zhuyin[788] = new string[] { "tj3 = \u3114\u3128\u02c7       ", "\u695A", "\u891A", "\u790E", "\u5132" };
            zhuyin[789] = new string[] { "tj4 = \u3114\u3128\u02cb       ", "\u8655", "\u89F8", "\u755C", "\u7D40", "\u9EDC" };
            zhuyin[790] = new string[] { "tj6 = \u3114\u3128\u02ca       ", "\u5EDA", "\u9664", "\u5132", "\u92E4", "\u96DB", "\u6AE5", "\u82BB", "\u870D", "\u8E87" };
            zhuyin[791] = new string[] { "tj93 = \u3114\u3128\u311e\u02c7       ", "\u63E3" };
            zhuyin[792] = new string[] { "tj94 = \u3114\u3128\u311e\u02cb       ", "\u8E39" };
            zhuyin[793] = new string[] { "tj; = \u3114\u3128\u3124       ", "\u7A97", "\u7621", "\u5275" };
            zhuyin[794] = new string[] { "tj;3 = \u3114\u3128\u3124\u02c7       ", "\u95D6" };
            zhuyin[795] = new string[] { "tj;4 = \u3114\u3128\u3124\u02cb       ", "\u5275" };
            zhuyin[796] = new string[] { "tj;6 = \u3114\u3128\u3124\u02ca       ", "\u5E62", "\u5E8A" };
            zhuyin[797] = new string[] { "tji = \u3114\u3128\u311b       ", "\u6233" };
            zhuyin[798] = new string[] { "tji4 = \u3114\u3128\u311b\u02cb       ", "\u7DBD", "\u555C", "\u8F1F", "\u9F6A" };
            zhuyin[799] = new string[] { "tjo = \u3114\u3128\u311f       ", "\u5439", "\u708A" };
            zhuyin[800] = new string[] { "tjo6 = \u3114\u3128\u311f\u02ca       ", "\u9318", "\u5782", "\u69CC", "\u939A", "\u9672", "\u6376", "\u6425" };
            zhuyin[801] = new string[] { "tjp = \u3114\u3128\u3123       ", "\u693F", "\u6625" };
            zhuyin[802] = new string[] { "tjp3 = \u3114\u3128\u3123\u02c7       ", "\u8822" };
            zhuyin[803] = new string[] { "tjp6 = \u3114\u3128\u3123\u02ca       ", "\u6DF3", "\u7D14", "\u5507", "\u9187", "\u8123" };
            zhuyin[804] = new string[] { "tk = \u3114\u311c       ", "\u8ECA" };
            zhuyin[805] = new string[] { "tk3 = \u3114\u311c\u02c7       ", "\u626F" };
            zhuyin[806] = new string[] { "tk4 = \u3114\u311c\u02cb       ", "\u64A4", "\u5FB9", "\u8F4D", "\u63A3" };
            zhuyin[807] = new string[] { "tl = \u3114\u3120       ", "\u6284", "\u8D85", "\u9214" };
            zhuyin[808] = new string[] { "tl3 = \u3114\u3120\u02c7       ", "\u5435", "\u7092" };
            zhuyin[809] = new string[] { "tl6 = \u3114\u3120\u02ca       ", "\u6F6E", "\u5DE2", "\u5632" };
            zhuyin[810] = new string[] { "tp = \u3114\u3123       ", "\u741B" };
            zhuyin[811] = new string[] { "tp4 = \u3114\u3123\u02cb       ", "\u8D81", "\u896F", "\u6AEC" };
            zhuyin[812] = new string[] { "tp6 = \u3114\u3123\u02ca       ", "\u9673", "\u5875", "\u6668", "\u8FB0", "\u81E3", "\u5A20" };
            zhuyin[813] = new string[] { "u = \u3127       ", "\u3127", "\u4E00", "\u4F9D", "\u91AB", "\u4F0A", "\u8863", "\u58F9", "\u92A5", "\u63D6" };
            zhuyin[814] = new string[] { "u, = \u3127       ", "\u564E", "\u8036" };
            zhuyin[815] = new string[] { "u,3 = \u3127       ", "\u91CE", "\u4E5F", "\u51B6" };
            zhuyin[816] = new string[] { "u,4 = \u3127       ", "\u591C", "\u696D", "\u9801", "\u8449", "\u71C1", "\u8B01", "\u814B", "\u54BD" };
            zhuyin[817] = new string[] { "u,6 = \u3127       ", "\u723A", "\u6930", "\u63F6", "\u8036" };
            zhuyin[818] = new string[] { "u. = \u3127\u3121       ", "\u5E7D", "\u512A", "\u6538", "\u6182", "\u60A0", "\u55B2" };
            zhuyin[819] = new string[] { "u.3 = \u3127\u3121\u02c7       ", "\u53CB", "\u6709", "\u9149", "\u9EDD" };
            zhuyin[820] = new string[] { "u.4 = \u3127\u3121\u02cb       ", "\u5E7C", "\u53C8", "\u53F3", "\u4F51", "\u7950", "\u8A98", "\u91C9", "\u5BA5", "\u67DA", "\u923E" };
            zhuyin[821] = new string[] { "u.6 = \u3127\u3121\u02ca       ", "\u6CB9", "\u7531", "\u904A", "\u6E38", "\u90F5", "\u5C24", "\u7336", "\u7337" };
            zhuyin[822] = new string[] { "u/ = \u3127\u3125       ", "\u6AFB", "\u61C9", "\u82F1", "\u9DF9", "\u5B30", "\u745B", "\u9DAF", "\u7F4C", "\u9E1A", "\u78A4", "\u7E93" };
            zhuyin[823] = new string[] { "u/3 = \u3127\u3125\u02c7       ", "\u5F71", "\u7A4E" };
            zhuyin[824] = new string[] { "u/4 = \u3127\u3125\u02cb       ", "\u786C", "\u6620", "\u61C9", "\u7005" };
            zhuyin[825] = new string[] { "u/6 = \u3127\u3125\u02ca       ", "\u76C8", "\u71DF", "\u8D0F", "\u8FCE", "\u7469", "\u87A2", "\u701B", "\u5B34" };
            zhuyin[826] = new string[] { "u0 = \u3127\u3122       ", "\u5944", "\u7159", "\u83F8", "\u7109", "\u9183", "\u6DF9", "\u54BD", "\u5AE3", "\u6E6E", "\u80ED", "\u5819" };
            zhuyin[827] = new string[] { "u03 = \u3127\u3122\u02c7       ", "\u6F14", "\u773C", "\u884D", "\u63A9" };
            zhuyin[828] = new string[] { "u04 = \u3127\u3122\u02cb       ", "\u61E8", "\u9A57", "\u5F65", "\u5BB4", "\u71D5", "\u8277", "\u7130", "\u5830", "\u8AFA", "\u53AD", "\u5B3F", "\u71C4", "\u786F" };
            zhuyin[829] = new string[] { "u06 = \u3127\u3122\u02ca       ", "\u708E", "\u8A00", "\u5EF6", "\u7814", "\u984F", "\u56B4", "\u764C", "\u9E7D", "\u6CBF", "\u5CA9", "\u95BB", "\u5DD6", "\u598D", "\u6A90", "\u7B75", "\u7C37" };
            zhuyin[830] = new string[] { "u3 = \u3127\u02c7       ", "\u5DF2", "\u4EE5", "\u501A", "\u4E59", "\u77E3", "\u87FB", "\u4F41" };
            zhuyin[831] = new string[] { "u4 = \u3127\u02cb       ", "\u610F", "\u7FA9", "\u7570", "\u8B70", "\u5104", "\u6613", "\u4EA6", "\u85DD", "\u76CA", "\u5F79", "\u61B6", "\u6BC5", "\u8B6F", "\u6EA2", "\u9038", "\u75AB", "\u6291", "\u5955", "\u7FFC", "\u6DB2", "\u5C79", "\u61FF", "\u5F0B", "\u93B0", "\u7FCA", "\u9A5B", "\u7E79", "\u8084" };
            zhuyin[832] = new string[] { "u6 = \u3127\u02ca       ", "\u5B9C", "\u6021", "\u79FB", "\u7591", "\u5100", "\u59E8", "\u907A", "\u8ABC", "\u8CBD", "\u5937", "\u8A52" };
            zhuyin[833] = new string[] { "u8 = \u3127\u311a       ", "\u58D3", "\u62BC", "\u5440", "\u9D28", "\u9D09" };
            zhuyin[834] = new string[] { "u83 = \u3127\u311a\u02c7       ", "\u555E", "\u4E9E", "\u96C5", "\u6C2C" };
            zhuyin[835] = new string[] { "u84 = \u3127\u311a\u02cb       ", "\u8A1D" };
            zhuyin[836] = new string[] { "u86 = \u3127\u311a\u02ca       ", "\u7259", "\u82BD", "\u6DAF", "\u8859" };
            zhuyin[837] = new string[] { "u; = \u3127\u3124       ", "\u6CF1", "\u592E", "\u6B83", "\u79E7", "\u9D26", "\u9785" };
            zhuyin[838] = new string[] { "u;3 = \u3127\u3124\u02c7       ", "\u7662", "\u990A", "\u4EF0", "\u6C27" };
            zhuyin[839] = new string[] { "u;4 = \u3127\u3124\u02cb       ", "\u600F", "\u6A23", "\u6F3E" };
            zhuyin[840] = new string[] { "u;6 = \u3127\u3124\u02ca       ", "\u967D", "\u694A", "\u63DA", "\u6D0B", "\u7F8A", "\u4F6F" };
            zhuyin[841] = new string[] { "ul = \u3127\u3120       ", "\u592D", "\u9080", "\u8170", "\u55B2", "\u5996", "\u4E48" };
            zhuyin[842] = new string[] { "ul3 = \u3127\u3120\u02c7       ", "\u54AC", "\u7A88", "\u8200" };
            zhuyin[843] = new string[] { "ul4 = \u3127\u3120\u02cb       ", "\u8981", "\u8000", "\u85E5", "\u9470", "\u846F", "\u8E8D" };
            zhuyin[844] = new string[] { "ul6 = \u3127\u3120\u02ca       ", "\u6416", "\u7E47", "\u59DA", "\u9059", "\u582F", "\u6DC6", "\u7464", "\u7AAF", "\u8B20", "\u991A" };
            zhuyin[845] = new string[] { "up = \u3127\u3123       ", "\u8335", "\u56E0", "\u97F3", "\u6BB7", "\u9670", "\u59FB" };
            zhuyin[846] = new string[] { "up3 = \u3127\u3123\u02c7       ", "\u96B1", "\u5F15", "\u5C39", "\u98F2", "\u766E", "\u6BB7", "\u8693" };
            zhuyin[847] = new string[] { "up4 = \u3127\u3123\u02cb       ", "\u5370", "\u852D", "\u80E4", "\u7AA8" };
            zhuyin[848] = new string[] { "up6 = \u3127\u3123\u02ca       ", "\u9280", "\u541F", "\u6DEB", "\u5BC5" };
            zhuyin[849] = new string[] { "v = \u3112       ", "\u3112" };
            zhuyin[850] = new string[] { "vm = \u3112\u3129       ", "\u9700", "\u9808", "\u865B", "\u5653" };
            zhuyin[851] = new string[] { "vm, = \u3112\u3129       ", "\u859B", "\u5671", "\u9774" };
            zhuyin[852] = new string[] { "vm,3 = \u3112\u3129       ", "\u96EA", "\u9C48" };
            zhuyin[853] = new string[] { "vm,4 = \u3112\u3129       ", "\u524A", "\u7A74", "\u8840" };
            zhuyin[854] = new string[] { "vm,6 = \u3112\u3129       ", "\u5B78" };
            zhuyin[855] = new string[] { "vm/ = \u3112\u3129\u3125       ", "\u51F6", "\u5147", "\u80F8", "\u5144", "\u6D36", "\u5308" };
            zhuyin[856] = new string[] { "vm/6 = \u3112\u3129\u3125\u02ca       ", "\u718A", "\u96C4" };
            zhuyin[857] = new string[] { "vm0 = \u3112\u3129\u3122       ", "\u8AE0", "\u5BA3", "\u8ED2", "\u8431", "\u7444", "\u8AFC" };
            zhuyin[858] = new string[] { "vm03 = \u3112\u3129\u3122\u02c7       ", "\u9078", "\u70DC" };
            zhuyin[859] = new string[] { "vm04 = \u3112\u3129\u3122\u02cb       ", "\u70AB", "\u7729", "\u6E32", "\u7D62", "\u65CB", "\u6F29" };
            zhuyin[860] = new string[] { "vm06 = \u3112\u3129\u3122\u02ca       ", "\u65CB", "\u7384", "\u61F8", "\u7487" };
            zhuyin[861] = new string[] { "vm3 = \u3112\u3129\u02c7       ", "\u8A31", "\u8A61", "\u6829", "\u7166" };
            zhuyin[862] = new string[] { "vm4 = \u3112\u3129\u02cb       ", "\u7D6E", "\u7E8C", "\u65ED", "\u5E8F", "\u6558", "\u7DD2", "\u6064", "\u84C4", "\u5A7F", "\u9157", "\u755C" };
            zhuyin[863] = new string[] { "vm6 = \u3112\u3129\u02ca       ", "\u5F90", "\u4F59" };
            zhuyin[864] = new string[] { "vmp = \u3112\u3129\u3123       ", "\u85B0", "\u52F3", "\u52DB", "\u718F" };
            zhuyin[865] = new string[] { "vmp4 = \u3112\u3129\u3123\u02cb       ", "\u8A13", "\u905C", "\u8FC5", "\u5DFD", "\u6C5B", "\u6B89", "\u8A0A" };
            zhuyin[866] = new string[] { "vmp6 = \u3112\u3129\u3123\u02ca       ", "\u5C0B", "\u8A62", "\u5FAA", "\u65EC", "\u5DE1", "\u99B4" };
            zhuyin[867] = new string[] { "vu = \u3112\u3127       ", "\u516E", "\u897F", "\u6790", "\u5E0C", "\u6EAA", "\u6089", "\u5438", "\u79A7", "\u651C", "\u7199", "\u819D", "\u7A00", "\u66E6", "\u595A", "\u5B09", "\u6670", "\u8725" };
            zhuyin[868] = new string[] { "vu, = \u3112\u3127       ", "\u6B47", "\u4E9B", "\u874E" };
            zhuyin[869] = new string[] { "vu,3 = \u3112\u3127       ", "\u5BEB", "\u8840" };
            zhuyin[870] = new string[] { "vu,4 = \u3112\u3127       ", "\u5378", "\u8B1D", "\u6D29", "\u7009", "\u68B0", "\u5C51", "\u61C8" };
            zhuyin[871] = new string[] { "vu,6 = \u3112\u3127       ", "\u659C", "\u5354", "\u978B", "\u8AE7", "\u90AA", "\u8105" };
            zhuyin[872] = new string[] { "vu. = \u3112\u3127\u3121       ", "\u4FEE", "\u7F9E" };
            zhuyin[873] = new string[] { "vu.3 = \u3112\u3127\u3121\u02c7       ", "\u5BBF", "\u673D" };
            zhuyin[874] = new string[] { "vu.4 = \u3112\u3127\u3121\u02cb       ", "\u7407", "\u79C0", "\u7E61", "\u8896", "\u55C5", "\u92B9" };
            zhuyin[875] = new string[] { "vu/ = \u3112\u3127\u3125       ", "\u661F", "\u8208", "\u7329", "\u99A8" };
            zhuyin[876] = new string[] { "vu/3 = \u3112\u3127\u3125\u02c7       ", "\u9192" };
            zhuyin[877] = new string[] { "vu/4 = \u3112\u3127\u3125\u02cb       ", "\u6027", "\u59D3", "\u5E78", "\u674F", "\u5016" };
            zhuyin[878] = new string[] { "vu/6 = \u3112\u3127\u3125\u02ca       ", "\u884C", "\u578B", "\u5F62", "\u5211" };
            zhuyin[879] = new string[] { "vu0 = \u3112\u3127\u3122       ", "\u7E96", "\u5148", "\u9BAE", "\u4ED9", "\u6380", "\u66B9" };
            zhuyin[880] = new string[] { "vu03 = \u3112\u3127\u3122\u02c7       ", "\u96AA", "\u986F", "\u766C", "\u9291" };
            zhuyin[881] = new string[] { "vu04 = \u3112\u3127\u3122\u02cb       ", "\u61B2", "\u7DDA", "\u73FE", "\u7E23", "\u9650", "\u737B", "\u9677", "\u7FA8", "\u817A", "\u9921" };
            zhuyin[882] = new string[] { "vu06 = \u3112\u3127\u3122\u02ca       ", "\u6D8E", "\u5ACC", "\u8CE2", "\u54B8", "\u9E79", "\u5F26", "\u929C", "\u5AFB", "\u9591" };
            zhuyin[883] = new string[] { "vu3 = \u3112\u3127\u02c7       ", "\u6D17", "\u559C", "\u74BD", "\u56CD", "\u5C63", "\u5F99" };
            zhuyin[884] = new string[] { "vu4 = \u3112\u3127\u02cb       ", "\u7D30", "\u7CFB", "\u77FD", "\u4FC2", "\u6232", "\u7E6B", "\u5915", "\u6C50", "\u9699" };
            zhuyin[885] = new string[] { "vu6 = \u3112\u3127\u02ca       ", "\u7FD2", "\u8936", "\u606F", "\u5E2D", "\u932B", "\u8972", "\u60DC", "\u7184", "\u6614", "\u5AB3", "\u84C6", "\u8785" };
            zhuyin[886] = new string[] { "vu8 = \u3112\u3127\u311a       ", "\u8766", "\u778E" };
            zhuyin[887] = new string[] { "vu84 = \u3112\u3127\u311a\u02cb       ", "\u590F", "\u4E0B", "\u5687", "\u5EC8" };
            zhuyin[888] = new string[] { "vu86 = \u3112\u3127\u311a\u02ca       ", "\u633E", "\u4FE0", "\u971E", "\u8F44", "\u5323", "\u72F9", "\u7455", "\u5477", "\u5CFD", "\u9050" };
            zhuyin[889] = new string[] { "vu; = \u3112\u3127\u3124       ", "\u7BB1", "\u9109", "\u76F8", "\u9999", "\u6E58", "\u5EC2", "\u8944", "\u9472", "\u858C" };
            zhuyin[890] = new string[] { "vu;3 = \u3112\u3127\u3124\u02c7       ", "\u60F3", "\u97FF", "\u4EAB", "\u9957", "\u9909" };
            zhuyin[891] = new string[] { "vu;4 = \u3112\u3127\u3124\u02cb       ", "\u5DF7", "\u5411", "\u9805", "\u50CF", "\u8C61", "\u6A61", "\u56AE" };
            zhuyin[892] = new string[] { "vu;6 = \u3112\u3127\u3124\u02ca       ", "\u7FD4", "\u7965", "\u8A73", "\u964D" };
            zhuyin[893] = new string[] { "vul = \u3112\u3127\u3120       ", "\u856D", "\u92B7", "\u6D88", "\u785D", "\u900D", "\u9704", "\u689F", "\u54EE", "\u56C2", "\u5BB5", "\u524A" };
            zhuyin[894] = new string[] { "vul3 = \u3112\u3127\u3120\u02c7       ", "\u5C0F", "\u66C9", "\u7B71" };
            zhuyin[895] = new string[] { "vul4 = \u3112\u3127\u3120\u02cb       ", "\u7B11", "\u6821", "\u6548", "\u5B5D", "\u9175", "\u8096", "\u562F" };
            zhuyin[896] = new string[] { "vup = \u3112\u3127\u3123       ", "\u6B23", "\u65B0", "\u5FC3", "\u946B", "\u8F9B", "\u85AA" };
            zhuyin[897] = new string[] { "vup4 = \u3112\u3127\u3123\u02cb       ", "\u4FE1", "\u91C1" };
            zhuyin[898] = new string[] { "w = \u310a       ", "\u310A" };
            zhuyin[899] = new string[] { "w. = \u310a\u3121       ", "\u5077" };
            zhuyin[900] = new string[] { "w.4 = \u310a\u3121\u02cb       ", "\u900F" };
            zhuyin[901] = new string[] { "w.6 = \u310a\u3121\u02ca       ", "\u982D", "\u6295" };
            zhuyin[902] = new string[] { "w0 = \u310a\u3122       ", "\u6524", "\u8CAA", "\u7058", "\u574D", "\u7671" };
            zhuyin[903] = new string[] { "w03 = \u310a\u3122\u02c7       ", "\u8962", "\u6BEF", "\u5FD0", "\u81BB", "\u8892" };
            zhuyin[904] = new string[] { "w04 = \u310a\u3122\u02cb       ", "\u63A2", "\u78B3", "\u5606", "\u70AD", "\u6B4E" };
            zhuyin[905] = new string[] { "w06 = \u310a\u3122\u02ca       ", "\u8AC7", "\u5F48", "\u6F6D", "\u8B5A", "\u7F48", "\u91B0" };
            zhuyin[906] = new string[] { "w8 = \u310a\u311a       ", "\u4ED6", "\u5979", "\u7260", "\u584C" };
            zhuyin[907] = new string[] { "w83 = \u310a\u311a\u02c7       ", "\u5854", "\u6999" };
            zhuyin[908] = new string[] { "w84 = \u310a\u311a\u02cb       ", "\u8E0F", "\u69BB" };
            zhuyin[909] = new string[] { "w9 = \u310a\u311e       ", "\u80CE", "\u82D4" };
            zhuyin[910] = new string[] { "w94 = \u310a\u311e\u02cb       ", "\u6CF0", "\u592A", "\u614B", "\u6C70", "\u50A3", "\u9226" };
            zhuyin[911] = new string[] { "w96 = \u310a\u311e\u02ca       ", "\u62AC", "\u53F0", "\u81FA", "\u6AAF", "\u8DC6", "\u98B1" };
            zhuyin[912] = new string[] { "w; = \u310a\u3124       ", "\u6E6F", "\u8E5A", "\u93DC" };
            zhuyin[913] = new string[] { "w;3 = \u310a\u3124\u02c7       ", "\u8EBA", "\u5E11", "\u5018", "\u6DCC" };
            zhuyin[914] = new string[] { "w;4 = \u310a\u3124\u02cb       ", "\u71D9", "\u8D9F" };
            zhuyin[915] = new string[] { "w;6 = \u310a\u3124\u02ca       ", "\u5802", "\u5510", "\u7CD6", "\u68E0", "\u5858", "\u91A3", "\u819B", "\u87B3" };
            zhuyin[916] = new string[] { "wj = \u310a\u3128       ", "\u79BF", "\u51F8" };
            zhuyin[917] = new string[] { "wj/ = \u310a\u3128\u3125       ", "\u901A" };
            zhuyin[918] = new string[] { "wj/3 = \u310a\u3128\u3125\u02c7       ", "\u7D71", "\u6876", "\u7B52", "\u6345" };
            zhuyin[919] = new string[] { "wj/4 = \u310a\u3128\u3125\u02cb       ", "\u75DB", "\u615F" };
            zhuyin[920] = new string[] { "wj/6 = \u310a\u3128\u3125\u02ca       ", "\u77B3", "\u540C", "\u50EE", "\u7AE5", "\u9285", "\u6850", "\u6F7C", "\u916E", "\u7B52" };
            zhuyin[921] = new string[] { "wj0 = \u310a\u3128\u3122       ", "\u6E4D" };
            zhuyin[922] = new string[] { "wj06 = \u310a\u3128\u3122\u02ca       ", "\u5718", "\u7CF0" };
            zhuyin[923] = new string[] { "wj3 = \u310a\u3128\u02c7       ", "\u5410", "\u571F" };
            zhuyin[924] = new string[] { "wj4 = \u310a\u3128\u02cb       ", "\u5154", "\u5410" };
            zhuyin[925] = new string[] { "wj6 = \u310a\u3128\u02ca       ", "\u5857", "\u5716", "\u7A81", "\u5F92", "\u9014", "\u6D82", "\u5C60" };
            zhuyin[926] = new string[] { "wji = \u310a\u3128\u311b       ", "\u62D6", "\u812B", "\u6258", "\u8A17" };
            zhuyin[927] = new string[] { "wji3 = \u310a\u3128\u311b\u02c7       ", "\u59A5", "\u5EB9" };
            zhuyin[928] = new string[] { "wji4 = \u310a\u3128\u311b\u02cb       ", "\u62D3", "\u553E" };
            zhuyin[929] = new string[] { "wji6 = \u310a\u3128\u311b\u02ca       ", "\u9640", "\u99DD", "\u4F57", "\u7823", "\u6CB1" };
            zhuyin[930] = new string[] { "wjo = \u310a\u3128\u311f       ", "\u63A8" };
            zhuyin[931] = new string[] { "wjo3 = \u310a\u3128\u311f\u02c7       ", "\u817F" };
            zhuyin[932] = new string[] { "wjo4 = \u310a\u3128\u311f\u02cb       ", "\u9000", "\u86FB", "\u8781" };
            zhuyin[933] = new string[] { "wjo6 = \u310a\u3128\u311f\u02ca       ", "\u9839" };
            zhuyin[934] = new string[] { "wjp = \u310a\u3128\u3123       ", "\u541E", "\u65FD" };
            zhuyin[935] = new string[] { "wjp3 = \u310a\u3128\u3123\u02c7       ", "\u5428" };
            zhuyin[936] = new string[] { "wjp4 = \u310a\u3128\u3123\u02cb       ", "\u892A" };
            zhuyin[937] = new string[] { "wjp6 = \u310a\u3128\u3123\u02ca       ", "\u8C5A", "\u5C6F", "\u81C0", "\u98E9" };
            zhuyin[938] = new string[] { "wk4 = \u310a\u311c\u02cb       ", "\u7279", "\u5FD1" };
            zhuyin[939] = new string[] { "wl = \u310a\u3120       ", "\u6ED4", "\u6FE4", "\u638F", "\u97DC" };
            zhuyin[940] = new string[] { "wl3 = \u310a\u3120\u02c7       ", "\u8A0E" };
            zhuyin[941] = new string[] { "wl4 = \u310a\u3120\u02cb       ", "\u5957" };
            zhuyin[942] = new string[] { "wl6 = \u310a\u3120\u02ca       ", "\u6DD8", "\u9676", "\u9003", "\u6843", "\u8404" };
            zhuyin[943] = new string[] { "wu = \u310a\u3127       ", "\u8E22", "\u68AF" };
            zhuyin[944] = new string[] { "wu, = \u310a\u3127       ", "\u6017", "\u8DD5" };
            zhuyin[945] = new string[] { "wu,3 = \u310a\u3127       ", "\u5E16", "\u9435" };
            zhuyin[946] = new string[] { "wu/ = \u310a\u3127\u3125       ", "\u807D", "\u5EF3" };
            zhuyin[947] = new string[] { "wu/3 = \u310a\u3127\u3125\u02c7       ", "\u633A", "\u8247", "\u753A" };
            zhuyin[948] = new string[] { "wu/6 = \u310a\u3127\u3125\u02ca       ", "\u5A77", "\u505C", "\u5EAD", "\u5EF7", "\u4EAD", "\u9706" };
            zhuyin[949] = new string[] { "wu0 = \u310a\u3127\u3122       ", "\u5929", "\u6DFB" };
            zhuyin[950] = new string[] { "wu03 = \u310a\u3127\u3122\u02c7       ", "\u5FDD", "\u8214", "\u8146", "\u6B84" };
            zhuyin[951] = new string[] { "wu06 = \u310a\u3127\u3122\u02ca       ", "\u751C", "\u7530", "\u586B", "\u606C" };
            zhuyin[952] = new string[] { "wu3 = \u310a\u3127\u02c7       ", "\u9AD4" };
            zhuyin[953] = new string[] { "wu4 = \u310a\u3127\u02cb       ", "\u608C", "\u60D5", "\u5243", "\u501C", "\u568F", "\u6D95", "\u5254", "\u5C5C" };
            zhuyin[954] = new string[] { "wu6 = \u310a\u3127\u02ca       ", "\u5824", "\u63D0", "\u984C", "\u8E44", "\u7DF9", "\u557C" };
            zhuyin[955] = new string[] { "wul = \u310a\u3127\u3120       ", "\u6311" };
            zhuyin[956] = new string[] { "wul3 = \u310a\u3127\u3120\u02c7       ", "\u7A95", "\u8A82" };
            zhuyin[957] = new string[] { "wul4 = \u310a\u3127\u3120\u02cb       ", "\u8DF3" };
            zhuyin[958] = new string[] { "wul6 = \u310a\u3127\u3120\u02ca       ", "\u689D", "\u8ABF" };
            zhuyin[959] = new string[] { "x = \u310c       ", "\u310C" };
            zhuyin[960] = new string[] { "x. = \u310c\u3121       ", "\u645F" };
            zhuyin[961] = new string[] { "x.4 = \u310c\u3121\u02cb       ", "\u9732", "\u6F0F", "\u964B" };
            zhuyin[962] = new string[] { "x.6 = \u310c\u3121\u02ca       ", "\u6A13" };
            zhuyin[963] = new string[] { "x/3 = \u310c\u3125\u02c7       ", "\u51B7" };
            zhuyin[964] = new string[] { "x/4 = \u310c\u3125\u02cb       ", "\u6123" };
            zhuyin[965] = new string[] { "x/6 = \u310c\u3125\u02ca       ", "\u7A1C", "\u8506", "\u5D1A", "\u68F1" };
            zhuyin[966] = new string[] { "x03 = \u310c\u3122\u02c7       ", "\u61F6", "\u652C", "\u7E9C", "\u89BD" };
            zhuyin[967] = new string[] { "x04 = \u310c\u3122\u02cb       ", "\u6FEB", "\u4E82", "\u703E", "\u7E9C" };
            zhuyin[968] = new string[] { "x06 = \u310c\u3122\u02ca       ", "\u85CD", "\u6514", "\u7C43", "\u6B04", "\u703E" };
            zhuyin[969] = new string[] { "x8 = \u310c\u311a       ", "\u62C9", "\u524C" };
            zhuyin[970] = new string[] { "x83 = \u310c\u311a\u02c7       ", "\u5587" };
            zhuyin[971] = new string[] { "x84 = \u310c\u311a\u02cb       ", "\u8FA3", "\u881F", "\u524C", "\u81D8", "\u760C" };
            zhuyin[972] = new string[] { "x86 = \u310c\u311a\u02ca       ", "\u908B" };
            zhuyin[973] = new string[] { "x94 = \u310c\u311e\u02cb       ", "\u8CF4", "\u7669" };
            zhuyin[974] = new string[] { "x96 = \u310c\u311e\u02ca       ", "\u4F86", "\u840A", "\u9338" };
            zhuyin[975] = new string[] { "x;3 = \u310c\u3124\u02c7       ", "\u6717" };
            zhuyin[976] = new string[] { "x;4 = \u310c\u3124\u02cb       ", "\u6D6A" };
            zhuyin[977] = new string[] { "x;6 = \u310c\u3124\u02ca       ", "\u72FC", "\u5ECA", "\u90CE", "\u7405", "\u6994" };
            zhuyin[978] = new string[] { "xj = \u310c\u3128       ", "\u5695" };
            zhuyin[979] = new string[] { "xj/6 = \u310c\u3128\u3125\u02ca       ", "\u9F8D", "\u9686", "\u807E" };
            zhuyin[980] = new string[] { "xj03 = \u310c\u3128\u3122\u02c7       ", "\u5375" };
            zhuyin[981] = new string[] { "xj04 = \u310c\u3128\u3122\u02cb       ", "\u4E82" };
            zhuyin[982] = new string[] { "xj06 = \u310c\u3128\u3122\u02ca       ", "\u947E", "\u5DD2", "\u6B12" };
            zhuyin[983] = new string[] { "xj3 = \u310c\u3128\u02c7       ", "\u9B6F", "\u64C4", "\u6EF7", "\u865C", "\u9E75" };
            zhuyin[984] = new string[] { "xj4 = \u310c\u3128\u02cb       ", "\u8DEF", "\u9304", "\u9678", "\u9E7F", "\u797F", "\u9DFA", "\u622E", "\u8F46", "\u8CC2" };
            zhuyin[985] = new string[] { "xj6 = \u310c\u3128\u02ca       ", "\u7210", "\u76E7", "\u5EEC" };
            zhuyin[986] = new string[] { "xji = \u310c\u3128\u311b       ", "\u56C9" };
            zhuyin[987] = new string[] { "xji3 = \u310c\u3128\u311b\u02c7       ", "\u88F8" };
            zhuyin[988] = new string[] { "xji4 = \u310c\u3128\u311b\u02cb       ", "\u843D", "\u7D61", "\u99F1", "\u916A" };
            zhuyin[989] = new string[] { "xji6 = \u310c\u3128\u311b\u02ca       ", "\u87BA" };
            zhuyin[990] = new string[] { "xjp4 = \u310c\u3128\u3123\u02cb       ", "\u8AD6" };
            zhuyin[991] = new string[] { "xjp6 = \u310c\u3128\u3123\u02ca       ", "\u502B", "\u8F2A", "\u7DB8", "\u5D19", "\u4F96", "\u9300" };
            zhuyin[992] = new string[] { "xk4 = \u310c\u311c\u02cb       ", "\u6A02", "\u808B", "\u5783" };
            zhuyin[993] = new string[] { "xk7 = \u310c\u311c\u02d9       ", "\u4E86" };
            zhuyin[994] = new string[] { "xl = \u310c\u3120       ", "\u6488" };
            zhuyin[995] = new string[] { "xl3 = \u310c\u3120\u02c7       ", "\u8001", "\u59E5", "\u8356" };
            zhuyin[996] = new string[] { "xl4 = \u310c\u3120\u02cb       ", "\u70D9" };
            zhuyin[997] = new string[] { "xl6 = \u310c\u3120\u02ca       ", "\u7262", "\u52DE" };
            zhuyin[998] = new string[] { "xm,4 = \u310c\u3129       ", "\u7565", "\u63A0" };
            zhuyin[999] = new string[] { "xm3 = \u310c\u3129\u02c7       ", "\u5C62", "\u65C5", "\u5442", "\u92C1", "\u5C65", "\u7E37" };
            zhuyin[1000] = new string[] { "xm4 = \u310c\u3129\u02cb       ", "\u7DA0", "\u7387", "\u5F8B", "\u6FFE", "\u616E" };
            zhuyin[1001] = new string[] { "xm6 = \u310c\u3129\u02ca       ", "\u9A62" };
            zhuyin[1002] = new string[] { "xo = \u310c\u311f       ", "\u52D2" };
            zhuyin[1003] = new string[] { "xo3 = \u310c\u311f\u02c7       ", "\u58D8", "\u857E", "\u78CA" };
            zhuyin[1004] = new string[] { "xo4 = \u310c\u311f\u02cb       ", "\u6DDA", "\u985E", "\u7D2F" };
            zhuyin[1005] = new string[] { "xo6 = \u310c\u311f\u02ca       ", "\u96F7" };
            zhuyin[1006] = new string[] { "xu,4 = \u310c\u3127       ", "\u5217", "\u88C2", "\u52A3", "\u70C8", "\u7375" };
            zhuyin[1007] = new string[] { "xu.3 = \u310c\u3127\u3121\u02c7       ", "\u67F3" };
            zhuyin[1008] = new string[] { "xu.4 = \u310c\u3127\u3121\u02cb       ", "\u516D", "\u905B", "\u6E9C" };
            zhuyin[1009] = new string[] { "xu.6 = \u310c\u3127\u3121\u02ca       ", "\u5289", "\u7559", "\u6D41", "\u7409", "\u786B" };
            zhuyin[1010] = new string[] { "xu/ = \u310c\u3127\u3125       ", "\u62CE" };
            zhuyin[1011] = new string[] { "xu/3 = \u310c\u3127\u3125\u02c7       ", "\u9818", "\u5DBA" };
            zhuyin[1012] = new string[] { "xu/4 = \u310c\u3127\u3125\u02cb       ", "\u4EE4", "\u53E6" };
            zhuyin[1013] = new string[] { "xu/6 = \u310c\u3127\u3125\u02ca       ", "\u73B2", "\u96F6", "\u51CC", "\u9748", "\u9F61", "\u83F1", "\u9234", "\u9675", "\u82D3", "\u8046", "\u7FCE", "\u7F9A" };
            zhuyin[1014] = new string[] { "xu03 = \u310c\u3127\u3122\u02c7       ", "\u81C9" };
            zhuyin[1015] = new string[] { "xu04 = \u310c\u3127\u3122\u02cb       ", "\u7149", "\u7DF4", "\u93C8", "\u6200", "\u6582", "\u934A" };
            zhuyin[1016] = new string[] { "xu06 = \u310c\u3127\u3122\u02ca       ", "\u9023", "\u806F", "\u84EE", "\u5EC9", "\u6190" };
            zhuyin[1017] = new string[] { "xu3 = \u310c\u3127\u02c7       ", "\u674E", "\u91CC", "\u7406", "\u79AE", "\u88E1" };
            zhuyin[1018] = new string[] { "xu4 = \u310c\u3127\u02cb       ", "\u529B", "\u7ACB", "\u7C92", "\u5229", "\u4F8B", "\u6B77", "\u540F", "\u623E", "\u7B20", "\u8389", "\u849E", "\u66C6", "\u52F5", "\u96B8", "\u58E2", "\u701D", "\u9E97", "\u792A" };
            zhuyin[1019] = new string[] { "xu6 = \u310c\u3127\u02ca       ", "\u96E2", "\u68A8", "\u7483", "\u9ECE", "\u91D0", "\u9E97", "\u7C6C", "\u5398" };
            zhuyin[1020] = new string[] { "xu;3 = \u310c\u3127\u3124\u02c7       ", "\u5169", "\u5006" };
            zhuyin[1021] = new string[] { "xu;4 = \u310c\u3127\u3124\u02cb       ", "\u4EAE", "\u91CF", "\u8F1B", "\u8AD2" };
            zhuyin[1022] = new string[] { "xu;6 = \u310c\u3127\u3124\u02ca       ", "\u6DBC", "\u7CE7", "\u91CF", "\u6881", "\u826F", "\u7CB1" };
            zhuyin[1023] = new string[] { "xul = \u310c\u3127\u3120       ", "\u64A9" };
            zhuyin[1024] = new string[] { "xul3 = \u310c\u3127\u3120\u02c7       ", "\u4E86", "\u71CE", "\u77AD" };
            zhuyin[1025] = new string[] { "xul4 = \u310c\u3127\u3120\u02cb       ", "\u6599", "\u5ED6" };
            zhuyin[1026] = new string[] { "xul6 = \u310c\u3127\u3120\u02ca       ", "\u804A", "\u5BE5", "\u5BEE", "\u64A9", "\u907C", "\u7642" };
            zhuyin[1027] = new string[] { "xup3 = \u310c\u3127\u3123\u02c7       ", "\u51DC" };
            zhuyin[1028] = new string[] { "xup4 = \u310c\u3127\u3123\u02cb       ", "\u85FA", "\u81E8", "\u541D", "\u6DCB", "\u8CC3", "\u8EAA" };
            zhuyin[1029] = new string[] { "xup6 = \u310c\u3127\u3123\u02ca       ", "\u6797", "\u81E8", "\u6DCB", "\u9130", "\u7433", "\u9716", "\u9E9F" };
            zhuyin[1030] = new string[] { "y = \u3117       ", "\u3117", "\u5B5C", "\u8CC7", "\u6ECB", "\u59FF", "\u7386", "\u5B73", "\u4ED4" };
            zhuyin[1031] = new string[] { "y. = \u3117\u3121       ", "\u9112" };
            zhuyin[1032] = new string[] { "y.3 = \u3117\u3121\u02c7       ", "\u8D70" };
            zhuyin[1033] = new string[] { "y.4 = \u3117\u3121\u02cb       ", "\u594F", "\u9A5F" };
            zhuyin[1034] = new string[] { "y/ = \u3117\u3125       ", "\u589E", "\u66FE" };
            zhuyin[1035] = new string[] { "y/4 = \u3117\u3125\u02cb       ", "\u8D08" };
            zhuyin[1036] = new string[] { "y04 = \u3117\u3122\u02cb       ", "\u8D0A", "\u66AB" };
            zhuyin[1037] = new string[] { "y06 = \u3117\u3122\u02ca       ", "\u54B1" };
            zhuyin[1038] = new string[] { "y3 = \u3117\u02c7       ", "\u6893", "\u5B50", "\u4ED4", "\u7D2B", "\u7C7D" };
            zhuyin[1039] = new string[] { "y4 = \u3117\u02cb       ", "\u5B57", "\u81EA", "\u6F2C", "\u6063", "\u5B73" };
            zhuyin[1040] = new string[] { "y8 = \u3117\u311a       ", "\u531D", "\u7D2E" };
            zhuyin[1041] = new string[] { "y86 = \u3117\u311a\u02ca       ", "\u96DC", "\u7838" };
            zhuyin[1042] = new string[] { "y9 = \u3117\u311e       ", "\u707D", "\u683D" };
            zhuyin[1043] = new string[] { "y93 = \u3117\u311e\u02c7       ", "\u5BB0", "\u4ED4", "\u8F09" };
            zhuyin[1044] = new string[] { "y94 = \u3117\u311e\u02cb       ", "\u5728", "\u518D", "\u8F09" };
            zhuyin[1045] = new string[] { "y; = \u3117\u3124       ", "\u9AD2", "\u8D13", "\u81E7" };
            zhuyin[1046] = new string[] { "y;4 = \u3117\u3124\u02cb       ", "\u846C", "\u5958" };
            zhuyin[1047] = new string[] { "yj = \u3117\u3128       ", "\u79DF" };
            zhuyin[1048] = new string[] { "yj/ = \u3117\u3128\u3125       ", "\u5B97", "\u7D9C", "\u8E64", "\u68D5", "\u9B03" };
            zhuyin[1049] = new string[] { "yj/3 = \u3117\u3128\u3125\u02c7       ", "\u7E3D" };
            zhuyin[1050] = new string[] { "yj/4 = \u3117\u3128\u3125\u02cb       ", "\u7E31" };
            zhuyin[1051] = new string[] { "yj0 = \u3117\u3128\u3122       ", "\u947D" };
            zhuyin[1052] = new string[] { "yj04 = \u3117\u3128\u3122\u02cb       ", "\u8CFA" };
            zhuyin[1053] = new string[] { "yj3 = \u3117\u3128\u02c7       ", "\u7956", "\u7D44", "\u963B", "\u8A5B" };
            zhuyin[1054] = new string[] { "yj6 = \u3117\u3128\u02ca       ", "\u65CF", "\u5352", "\u8DB3" };
            zhuyin[1055] = new string[] { "yji3 = \u3117\u3128\u311b\u02c7       ", "\u4F50", "\u5DE6" };
            zhuyin[1056] = new string[] { "yji4 = \u3117\u3128\u311b\u02cb       ", "\u4F5C", "\u505A", "\u5750", "\u5EA7" };
            zhuyin[1057] = new string[] { "yjo3 = \u3117\u3128\u311f\u02c7       ", "\u5634" };
            zhuyin[1058] = new string[] { "yjo4 = \u3117\u3128\u311f\u02cb       ", "\u6700", "\u7F6A", "\u9189", "\u58AC" };
            zhuyin[1059] = new string[] { "yjp = \u3117\u3128\u3123       ", "\u5C0A", "\u9075" };
            zhuyin[1060] = new string[] { "yjp4 = \u3117\u3128\u3123\u02cb       ", "\u5733", "\u4FCA" };
            zhuyin[1061] = new string[] { "yk3 = \u3117\u311c\u02c7       ", "\u600E" };
            zhuyin[1062] = new string[] { "yk6 = \u3117\u311c\u02ca       ", "\u5247", "\u6FA4", "\u8CAC", "\u64C7" };
            zhuyin[1063] = new string[] { "yl = \u3117\u3120       ", "\u7CDF", "\u906D" };
            zhuyin[1064] = new string[] { "yl3 = \u3117\u3120\u02c7       ", "\u86A4", "\u6FA1", "\u68D7" };
            zhuyin[1065] = new string[] { "yl4 = \u3117\u3120\u02cb       ", "\u71E5", "\u9020", "\u8E81", "\u566A", "\u7682", "\u8B5F" };
            zhuyin[1066] = new string[] { "yl6 = \u3117\u3120\u02ca       ", "\u947F" };
            zhuyin[1067] = new string[] { "z = \u3108       ", "\u3108" };
            zhuyin[1068] = new string[] { "z.3 = \u3108\u3121\u02c7       ", "\u5426" };
            zhuyin[1069] = new string[] { "z/ = \u3108\u3125       ", "\u760B", "\u8C50", "\u98A8", "\u5CF0", "\u5C01", "\u92D2", "\u6953", "\u8702", "\u4E30", "\u70FD", "\u8451", "\u9146" };
            zhuyin[1070] = new string[] { "z/3 = \u3108\u3125\u02c7       ", "\u8AF7" };
            zhuyin[1071] = new string[] { "z/4 = \u3108\u3125\u02cb       ", "\u7E2B" };
            zhuyin[1072] = new string[] { "z/6 = \u3108\u3125\u02ca       ", "\u99AE", "\u5906", "\u7E2B" };
            zhuyin[1073] = new string[] { "z0 = \u3108\u3122       ", "\u7FFB", "\u756A", "\u8543", "\u7C53", "\u5E06" };
            zhuyin[1074] = new string[] { "z03 = \u3108\u3122\u02c7       ", "\u53CD", "\u8FD4" };
            zhuyin[1075] = new string[] { "z04 = \u3108\u3122\u02cb       ", "\u8303", "\u72AF", "\u8CA9", "\u98EF", "\u6CDB", "\u6C4E", "\u7BC4" };
            zhuyin[1076] = new string[] { "z06 = \u3108\u3122\u02ca       ", "\u7169", "\u51E1", "\u7E41", "\u85E9", "\u6A0A", "\u5E06", "\u74A0" };
            zhuyin[1077] = new string[] { "z8 = \u3108\u311a       ", "\u767C", "\u4F10" };
            zhuyin[1078] = new string[] { "z83 = \u3108\u311a\u02c7       ", "\u9AEE" };
            zhuyin[1079] = new string[] { "z84 = \u3108\u311a\u02cb       ", "\u6CD5" };
            zhuyin[1080] = new string[] { "z86 = \u3108\u311a\u02ca       ", "\u7F70", "\u95A5", "\u7B4F", "\u4F10" };
            zhuyin[1081] = new string[] { "z; = \u3108\u3124       ", "\u65B9", "\u678B", "\u574A" };
            zhuyin[1082] = new string[] { "z;3 = \u3108\u3124\u02c7       ", "\u8A2A", "\u7D21", "\u5F77", "\u4EFF", "\u5023", "\u822B" };
            zhuyin[1083] = new string[] { "z;4 = \u3108\u3124\u02cb       ", "\u653E" };
            zhuyin[1084] = new string[] { "z;6 = \u3108\u3124\u02ca       ", "\u623F", "\u9632", "\u574A", "\u59A8", "\u80AA" };
            zhuyin[1085] = new string[] { "zj = \u3108\u3128       ", "\u592B", "\u6577", "\u819A", "\u5B75", "\u5C03" };
            zhuyin[1086] = new string[] { "zj3 = \u3108\u3128\u02c7       ", "\u64AB", "\u5E9C", "\u752B", "\u8F14", "\u8150", "\u91DC", "\u65A7", "\u4FEF" };
            zhuyin[1087] = new string[] { "zj4 = \u3108\u3128\u02cb       ", "\u8CA0", "\u526F", "\u5FA9", "\u5BCC", "\u8D74", "\u4ED8", "\u9644", "\u5A66", "\u7236", "\u5085", "\u8986", "\u8907", "\u8CE6", "\u961C", "\u99A5", "\u5490" };
            zhuyin[1088] = new string[] { "zj6 = \u3108\u3128\u02ca       ", "\u5E45", "\u798F", "\u670D", "\u6D6E", "\u4F0F", "\u8299", "\u6276", "\u5F17", "\u7B26", "\u5B5A", "\u62C2", "\u6C1F", "\u4FD8", "\u7E1B", "\u8F3B" };
            zhuyin[1089] = new string[] { "zo = \u3108\u311f       ", "\u83F2", "\u98DB", "\u975E", "\u5983", "\u6249", "\u7DCB", "\u970F" };
            zhuyin[1090] = new string[] { "zo3 = \u3108\u311f\u02c7       ", "\u6590", "\u532A", "\u8AB9" };
            zhuyin[1091] = new string[] { "zo4 = \u3108\u311f\u02cb       ", "\u8CBB", "\u5EE2", "\u80BA", "\u5420" };
            zhuyin[1092] = new string[] { "zp = \u3108\u3123       ", "\u7D1B", "\u5206", "\u82AC", "\u6C1B" };
            zhuyin[1093] = new string[] { "zp3 = \u3108\u3123\u02c7       ", "\u7C89" };
            zhuyin[1094] = new string[] { "zp4 = \u3108\u3123\u02cb       ", "\u5FFF", "\u4EFD", "\u596E", "\u61A4", "\u7CDE" };
            zhuyin[1095] = new string[] { "zp6 = \u3108\u3123\u02ca       ", "\u58B3" };


            rchtxbx_zhu_out.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            dataGridView2.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 25);
            dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            string[] InnerCharArray = zhuyin[cmbobx_zhu.SelectedIndex];
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
                dataGridView2.Rows.Add();
            }

            grid_x = 0;

            while ((grid_y < num_col) & (char_num < array_length))
            {
                dataGridView2[grid_y, grid_x].Value = InnerCharArray[char_num];

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
                rchtxbx_zhu_out.AppendText(InnerCharArray[a] + " ");
            }
            rchtxbx_zhu_out.AppendText("\n");

        }


        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            rchtxbx_zhu_msg.AppendText(dataGridView2[e.ColumnIndex, e.RowIndex].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            close();
        }

        private void btn_z_exit_Click(object sender, System.EventArgs e)
        {
            close();
        }

        private void btn_z_reset_output_Click(object sender, System.EventArgs e)
        {
            rchtxbx_z_output.Clear();
        }

        private void btn_z_reset_input_Click(object sender, System.EventArgs e)
        {
            rchtxbx_z_input.Clear();
        }

        private void btn_z_copy_Click(object sender, System.EventArgs e)
        {

            // Select all text in the text box.

            rchtxbx_zhu_msg.Focus();
            rchtxbx_zhu_msg.Select(0, rchtxbx_zhu_msg.Text.Length);

            // Determine if any text is selected in the TextBox control.
            if (rchtxbx_zhu_msg.SelectionLength > 0)
            {
                // Copy the contents of the control to the Clipboard.
                rchtxbx_zhu_msg.Copy();
            }
            else
            {
                MessageBox.Show("No text to copy");
            }
        }

        private void btn_z_convert_Click(object sender, System.EventArgs e)
        {
            

            for (int i = 0; i < rchtxbx_z_input.Text.Length; i++)
            {

                string answers = "";

                int InPutChar = Convert.ToInt32(rchtxbx_z_input.Text[i]);

                char c = '\u4e00';
                // Implicit conversion: char is basically a 16-bit unsigned integer
                int LowestZhuyinChar = c;

                bool doCheck = true, multipleChar = false; //set true if statements will set false.

                if (InPutChar < LowestZhuyinChar) //Not Zhuyin so just write out the char
                {
                    rchtxbx_z_output.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 14);
                    rchtxbx_z_output.AppendText(rchtxbx_z_input.Text[i].ToString());
                    doCheck = false;
                }

                if (doCheck == true) //Could be Zhuyin more checks inside
                {
                    for (int j = 0; j < zhuyin.Length; j++)
                    {

                        string[] InnerCharArray = zhuyin[j];

                        for (int k = 1; k < InnerCharArray.Length; k++)
                        {
                            string unichar = InnerCharArray[k]; //Get next char to check


                            if (rchtxbx_z_input.Text[i].ToString() == unichar) //&& (doCheck))
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
                        rchtxbx_z_output.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 14);
                        rchtxbx_z_output.AppendText("(" + answers + ") "); //multiple char
                    }
                    else
                    {
                        rchtxbx_z_output.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 14);
                        rchtxbx_z_output.AppendText(answers + " "); //single char
                    }

                    answers = ""; //reset
                    multipleChar = false; //reset

                    if (doCheck == true)
                    //still true when we have not yet found the item so now we will just put down the item
                    {
                        rchtxbx_z_output.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 14);
                        rchtxbx_z_output.AppendText(rchtxbx_z_input.Text[i].ToString());
                        //not chinese so just put down the Char
                    }

                }
            }

            GC.Collect(); //I see it releases large bits of memory following the array stuff but only collects next time round forced to collect here as well.

        }

        private void rchtxbx_z_input_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
                MenuItem menuItem = new MenuItem("Paste");
                menuItem.Click += new EventHandler(PasteZAction);
                contextMenu.MenuItems.Add(menuItem);

                rchtxbx_z_input.ContextMenu = contextMenu;
            }
        }

        void PasteZAction(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                rchtxbx_z_input.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();
            }
        }
    }
}
