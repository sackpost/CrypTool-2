﻿namespace IDPAnalyser
{
    class Bigrams
    {
        //public static int getScore(byte b0, byte b1)
        //{
        //    if (b0 < 'A' || b0 > 'Z') return 0;
        //    if (b1 < 'A' || b1 > 'Z') return 0;
        //    return FlatList[b0 - 'A', b1 - 'A'];
        //}

        public static void InitLanguage(int lang)
        {
            int[,] FlatList;

            switch(lang) {
                case 1: FlatList = FlatList_DE; break;
                case 2: FlatList = FlatList_FR; break;
                case 3: FlatList = FlatList_IT; break;
                default: FlatList = FlatList_EN; break;
            }

            for (int i = 0; i < 26; i++)
                for (int j = 0; j < 26; j++)
                {
                    FlatList2[(i + 'A') * 256 + (j + 'A')] = FlatList[i, j];
                    FlatList2[(i + 'a') * 256 + (j + 'a')] = FlatList[i, j];
                }
        }

        public static int[] FlatList2 = new int[256*256];

        public static int[,] FlatList_EN = new int[26, 26] {
            {1721143,8775582,17904683,14877234,815963,5702567,8809266,2225270,13974919,870262,5137311,38211584,15975981,69775179,749566,8553911,315068,42353262,37773878,48274564,4884168,8288885,3918960,660826,11523416,768359},
            {8867461,689158,320380,141752,19468489,75352,40516,154489,4356462,282608,26993,6941044,191807,106125,8172395,115161,5513,4621080,1409672,428276,8113271,120081,140189,3021,5232074,8132},
            {19930754,298053,3026492,358435,19803619,267630,181590,20132750,8446084,41526,7205091,5683204,285942,188046,26737101,382923,157546,5514347,1381608,11888752,4604045,94224,257253,5300,1145316,57914},
            {17584055,6106719,3782481,4001275,27029835,4033878,2442139,4585765,21673998,799366,525744,3050945,3544905,2840522,13120322,3145043,283314,5701879,10429887,15759673,5861311,1238565,4906814,27413,2218040,98038},
            {43329810,9738798,25775798,46647960,18497942,13252227,8286463,7559141,16026915,1256993,2411639,23092248,18145294,48991276,13524186,14024377,1461436,77134382,57070453,32872552,3674130,10574011,14776406,5649363,7528342,465466},
            {8357929,888155,1570791,748027,8529289,6085519,637758,1507604,11993833,269865,228905,2890839,1251312,534362,18923772,1199845,47504,8339376,2047416,13696078,3138900,244685,1005903,19313,789961,31186},
            {11239788,1184377,1299541,879792,14425023,1465290,1468286,9880399,7103140,176947,163830,2576787,1178511,2426429,8188708,1215204,59750,6989963,3920675,7347990,3768430,186777,1567991,14778,979804,28514},
            {35971841,1014004,1441057,828755,100689263,834284,429607,1329998,27495342,189906,210385,1169468,1353001,1383958,19729026,978649,101241,3843001,2462026,8351551,2771830,197539,1403223,7526,1446451,37066},
            {10002012,2598444,21468412,12896787,12505546,5740414,9530574,610683,607124,219128,2585124,17877600,10544422,87674002,21210160,3348621,291635,11681353,37349981,37938534,576683,9129232,922059,879360,98361,1865802},
            {1712763,19380,24770,21903,1487348,12640,12023,20960,357577,16085,13967,12149,22338,14452,2721345,34520,722,80471,39326,20408,2924815,8925,16083,747,5723,2859},
            {2833038,457860,420017,277982,10650670,537342,209266,650095,5814357,76816,118811,846309,485617,1903836,1758001,375653,13905,507020,3227333,1443985,506618,73184,719633,5083,553296,11192},
            {23178317,2463693,2328063,10245579,30383262,2702522,926472,1274048,23291169,218362,1164186,24636875,2216514,752316,15596310,2543957,77148,1505092,8675452,6817273,4402940,1238287,1836811,15467,13742031,57314},
            {21828378,4121764,1101727,481126,27237733,715087,285133,710864,12168944,134263,111041,478528,3730508,558397,12950768,7835172,21358,660619,3922855,3055946,3755834,136314,937621,14250,1949129,18271},
            {23547524,3602692,15214623,46194306,27331675,4950333,38567365,3915410,17452104,1342735,3043200,3692985,3796928,5180899,18894111,2968126,217422,2393580,21306421,50701084,3732602,2194534,4215967,74844,4343290,266461},
            {6554221,6212512,7646952,7610214,2616308,30540904,4163126,3254659,5336616,661082,3397570,13726491,21066156,56915252,10168856,10459455,122677,45725191,13596265,20088048,31112284,7350014,14610429,650078,1932892,228556},
            {12068709,369336,400308,273162,15573318,418168,211133,2825344,5559210,47043,83017,9812226,931225,131645,11917535,4873393,18607,13191182,2377036,3812475,3858148,48105,530411,6814,396147,9697},
            {73527,27307,10667,8678,6020,8778,2567,12273,73387,1342,2023,9603,12315,3808,9394,6062,2499,5975,20847,16914,4169424,4212,34669,765,4557,280},
            {28645577,3346212,6974063,9025637,60923600,3436232,4645938,2968706,27634643,518157,4491400,4803246,7377989,7064635,29230770,3588188,156933,5896212,21237259,21456059,5330557,2692445,3348005,38654,8788539,113432},
            {30080131,5553684,10800636,3842250,31532272,6073995,2043770,16773127,25758841,704442,2321888,4965012,5580755,4157990,23903631,10570626,800346,3513808,18915696,54018399,10031005,882083,8673234,50975,2214270,79840},
            {26147593,3815459,5196817,2346516,42295813,3368452,1530045,116997844,42888666,559473,610333,5403137,3759861,1782119,46115188,3070427,159111,15821226,18922522,19367472,8477495,698150,8910254,28156,8008918,280007},
            {4589997,2990868,5742385,3499535,4927837,701892,4832325,339341,3481482,88168,514873,10173468,4389720,15237699,649906,5306948,23386,17341717,15699353,15137169,63043,212051,352732,144814,531960,153736},
            {4111375,29192,59024,85611,29320973,28090,25585,30203,9380037,11432,11469,49032,35024,33082,2253292,62577,1488,96416,204093,62912,82830,22329,45608,3192,233082,2633},
            {16838794,394820,448394,432646,13185116,336213,139890,11852909,15213018,99435,148964,657782,505687,3649615,9106647,321746,16245,1226755,1988727,1301293,180884,63930,674610,4678,553647,52836},
            {904148,94041,697995,60101,653947,113031,39289,166599,1024736,10629,13651,59585,127492,34734,211173,1840696,5416,90046,154347,1509969,147533,31117,119322,35052,94329,2082},
            {7239548,2696786,3128053,2122337,6499305,2305244,1049082,2291273,4461214,378679,391953,2013939,2516273,1485655,9088497,2581863,87953,2021939,7539621,6714151,695512,411487,3379064,16945,332973,78281},
            {929119,50652,41037,32906,1709871,28658,26369,107639,644035,7167,24262,80039,46034,24241,424016,30389,5773,32685,94993,56955,113538,14339,68865,2463,105871,221275}
        };

        public static int[,] FlatList_DE = new int[26, 26] {
        	{10,33,38,17,3,14,42,23,3,0,8,95,53,170,1,9,0,97,99,105,126,1,1,0,1,4},
	        {35,2,0,0,144,1,2,0,19,0,0,11,0,2,3,2,0,17,14,9,8,0,0,0,0,4},
	        {3,0,0,0,1,1,1,382,10,0,20,5,0,0,12,0,0,0,1,6,0,1,0,0,0,0},
	        {107,2,0,2,354,7,3,0,152,0,0,1,1,0,16,0,0,18,9,6,24,0,3,0,10,0},
	        {29,39,35,26,3,43,44,47,289,0,10,154,60,656,4,6,0,606,156,50,58,2,11,10,1,9},
	        {27,5,0,1,41,7,3,13,25,0,0,14,0,5,22,0,0,43,14,35,8,0,1,0,0,2},
	        {27,0,0,0,222,0,0,0,15,0,1,14,0,9,5,0,0,33,22,30,25,0,1,0,0,1},
	        {63,0,1,0,155,5,0,5,21,0,6,31,16,24,19,0,0,46,10,92,20,0,11,0,0,1},
	        {12,10,142,8,302,8,69,21,0,0,9,45,35,284,44,3,0,25,100,127,0,6,1,0,0,10},
	        {11,0,0,0,11,0,1,2,0,0,0,0,0,0,2,0,0,0,0,0,4,0,0,0,0,0},
	        {28,1,0,0,36,0,0,11,0,0,0,19,5,10,34,0,0,19,9,28,19,0,0,0,0,1},
	        {48,9,7,26,127,6,8,0,93,0,8,84,3,12,5,1,0,4,35,45,21,3,0,0,1,4},
	        {72,3,1,0,67,5,4,1,59,0,0,0,38,2,12,17,0,2,11,13,17,0,1,0,0,0},
	        {49,8,6,191,151,21,119,8,70,1,29,17,1,50,19,1,0,3,70,71,42,4,10,0,0,37},
	        {3,8,35,13,6,12,14,13,2,0,8,28,38,107,2,12,0,70,18,12,0,3,3,0,0,7},
	        {21,0,3,0,38,7,0,3,54,0,0,4,0,0,14,7,0,36,1,7,9,0,0,0,2,0},
	        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
	        {71,15,17,56,161,21,25,16,60,0,42,20,16,35,72,5,0,8,46,86,29,3,12,0,1,9},
	        {31,11,106,5,140,17,10,2,87,0,4,4,2,2,61,81,0,1,118,198,13,2,5,0,6,1},
	        {64,5,0,5,261,4,8,7,78,1,0,20,21,7,13,1,0,49,49,43,18,0,16,0,10,54},
	        {2,8,26,6,30,39,10,3,1,0,3,14,47,192,0,13,0,78,77,64,0,0,2,0,0,2},
	        {2,0,0,0,67,0,0,0,17,0,0,1,0,0,48,0,0,0,1,0,0,0,0,0,1,0},
	        {47,0,2,0,89,0,0,2,52,0,0,0,0,0,17,0,0,7,0,0,3,0,0,0,0,0},
	        {0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,5,0,0,0,3,0,0,0,0,0,0},
	        {0,0,0,0,1,1,0,0,0,0,1,2,1,5,0,0,0,0,4,0,0,0,3,0,0,0},
	        {10,0,0,1,73,0,1,1,17,0,0,0,2,0,4,2,0,5,0,11,111,5,10,0,0,0}
        };
    
        public static int[,] FlatList_FR = new int[26, 26] {
	        {0,14,30,30,0,7,22,1,95,5,1,47,21,146,1,25,0,90,25,67,54,27,0,1,0,3},
	        {23,0,0,0,6,0,0,0,13,1,0,29,0,0,4,0,0,7,7,2,5,0,0,0,0,0},
	        {38,1,2,3,92,0,0,38,33,0,1,10,0,0,81,0,1,10,7,40,15,0,0,0,0,0},
	        {58,3,14,1,258,3,0,5,73,1,0,2,8,2,17,8,0,13,3,2,43,5,0,0,2,0},
	        {9,2,37,9,1,7,1,0,7,1,0,55,38,174,0,11,2,106,234,69,52,8,1,12,2,0},
	        {11,1,0,2,19,19,0,0,16,0,0,5,0,2,15,2,0,13,2,0,10,0,0,0,0,0},
	        {9,0,0,0,30,3,0,1,8,0,0,1,0,11,1,0,0,10,0,0,3,0,0,0,0,0},
	        {13,0,0,0,27,0,0,0,7,0,0,1,0,0,25,2,0,6,0,1,6,0,0,0,8,0},
	        {12,11,49,31,62,13,13,0,0,1,0,38,18,104,63,8,21,39,72,84,2,26,0,6,0,2},
	        {5,0,0,0,10,0,0,0,0,0,0,0,0,0,7,0,0,0,0,0,9,0,0,0,0,0},
	        {0,0,0,0,0,0,0,0,0,0,0,0,1,1,6,0,0,0,0,0,0,0,0,0,0,0},
	        {136,0,3,1,153,2,1,4,53,0,0,52,6,1,45,1,2,0,2,9,42,0,0,0,4,0},
	        {52,11,0,4,89,0,0,0,34,0,0,1,20,4,23,15,0,3,3,1,5,0,0,0,0,0},
	        {45,0,66,43,90,10,3,0,39,1,1,1,0,20,30,0,5,2,75,174,8,4,0,0,2,0},
	        {2,10,14,1,2,1,6,1,28,0,0,31,34,174,2,10,4,60,32,15,78,12,0,1,0,1},
	        {64,0,0,0,34,0,0,26,11,0,0,23,0,0,54,20,0,59,1,2,19,0,0,0,0,0},
	        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,91,0,0,0,0,0},
	        {79,3,22,20,163,3,4,0,52,0,2,5,19,13,42,3,0,10,81,31,8,12,0,0,1,0},
	        {48,0,15,5,75,2,1,2,50,0,2,4,6,1,45,15,6,0,36,52,49,1,0,0,2,1},
	        {51,0,0,3,110,0,0,9,97,0,0,4,1,0,16,0,0,73,30,17,20,0,0,0,3,0},
	        {15,11,3,10,68,3,2,0,47,4,0,18,10,73,0,5,0,109,40,43,1,17,0,28,0,1},
	        {25,0,0,0,44,0,0,0,33,0,0,2,0,0,19,0,0,6,0,0,4,0,0,0,0,0},
	        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
	        {2,0,0,1,3,0,0,1,1,0,0,0,3,0,0,3,0,0,0,1,0,1,0,0,1,0},
	        {0,0,0,1,0,0,1,0,0,0,0,0,3,1,0,3,0,0,12,0,0,0,0,0,0,0},
	        {0,0,0,0,3,0,0,0,0,0,0,0,0,0,1,0,0,0,0,1,2,0,0,0,1,0}
        };

        public static int[,] FlatList_IT = new int[26, 26] {
	        {0,13,27,14,2,11,37,3,23,0,0,153,58,194,2,28,1,136,48,162,10,26,0,0,0,43},
	        {28,17,1,0,17,0,0,0,28,0,0,3,0,0,10,0,0,22,0,0,2,0,0,0,0,0},
	        {78,0,49,0,53,0,0,99,86,0,1,5,0,1,175,0,2,17,0,0,23,0,0,0,0,0},
	        {71,0,0,3,149,0,1,0,165,0,0,0,0,0,48,0,0,7,0,0,17,0,0,0,0,0},
	        {18,9,29,38,3,3,41,0,20,0,0,120,26,128,7,9,3,189,104,62,3,20,1,1,0,6},
	        {29,0,0,0,20,18,1,0,21,0,0,4,0,0,17,0,0,17,0,0,12,0,0,0,0,0},
	        {21,0,0,0,21,0,18,4,69,0,0,37,0,12,18,0,0,24,0,0,12,0,0,0,0,0},
	        {18,0,0,0,72,0,0,0,30,0,0,0,0,4,4,0,0,0,0,0,0,0,0,0,0,0},
	        {113,5,100,23,55,10,13,0,10,0,0,83,56,174,95,11,1,46,40,69,5,34,0,0,0,14},
	        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
	        {0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
	        {140,2,5,6,98,1,2,0,113,0,0,114,5,0,69,3,0,0,0,39,28,0,0,0,0,0},
	        {76,15,0,0,84,0,0,0,51,0,0,0,12,0,41,28,0,0,0,0,12,0,0,0,0,0},
	        {93,0,47,57,111,17,13,0,81,0,0,0,0,33,140,0,4,2,20,123,9,3,0,0,0,24},
	        {0,3,30,7,0,1,23,1,16,0,1,78,45,180,1,34,0,121,35,26,4,19,1,0,0,0},
	        {78,0,0,0,90,0,0,3,66,0,1,9,0,0,68,17,0,70,0,0,5,0,0,0,0,0},
	        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,56,0,0,0,0,0},
	        {145,6,17,19,200,3,10,0,146,0,1,8,11,10,79,6,0,16,44,41,19,14,0,0,0,4},
	        {45,1,55,0,74,3,1,1,97,0,0,0,1,0,83,32,1,0,46,100,31,3,0,0,0,0},
	        {148,1,0,0,117,0,0,1,128,0,0,0,0,0,175,1,0,79,0,94,33,0,1,0,4,0},
	        {28,5,4,7,42,3,4,0,35,0,0,19,4,97,21,8,0,34,23,31,0,1,0,0,0,3},
	        {53,0,0,0,57,0,0,0,50,0,0,0,0,0,28,0,0,2,0,0,2,1,0,0,0,0},
	        {0,0,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
	        {0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,0,1,0,1,0,0},
	        {0,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
	        {26,0,0,0,7,0,0,0,51,0,0,0,0,0,9,0,0,0,0,0,1,0,0,0,0,27},
        };
    }
}