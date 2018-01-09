namespace JZKFXT.Migrations
{
    using JZKFXT.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<JZKFXT.DAL.BaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }
        protected override void Seed(JZKFXT.DAL.BaseContext db)
        {
            base.Seed(db);

            #region 角色
            List<Role> Roles = new List<Role>
            {
                new Role( 1, "社区工作人员","社区负责残疾人工作的人员：残疾人专干、残疾人康复协调员。","使用移动端对辖区指定或全部功能障碍者的基本信息、残疾信息进行输入；对辖区指定或全部功能障碍者进行“精准康复入户模块”和“辅具上门评估与适配模块”的评估；对“综合服务回访”模块进行“假肢矫形器回访”、“无障碍回访”和“辅具回访”和其“康复服务”的跟踪。",""),
                new Role( 2, "社区签约医生","社区开展残疾人医疗保障服务的签约医生。", "在“精准康复入户”模块和“辅具上门评估与适配”模块，对辖区指定或全部功能障碍者进行精准康复入户和辅具上门评估与适配；在“康复服务”模块，对功能障碍者提供“支持性服务”。对“综合服务回访”模块进行“假肢矫形器回访”、“无障碍回访”和“辅具回访”和其“康复服务”的跟踪。",""),
                new Role( 3, "辅具评估机构（全）","本地区开展辅具适配的权威机构（如辅具中心）人员，涉及辅具适配所有方向。","在“机构评估与审核”模块，对“长江新里程子”模块数据进行评估和审核，对“无障碍改造”模块数据进行评估和审核，对“辅具上门评估与适配”模块的评估适配结果进行审核；对审核未通过的所有类别功能障碍者进行二次评估。",""),
                new Role( 4, "辅具技术人员（肢体方向）","本地区开展辅具适配的权威机构（如辅具中心）人员，涉及辅具适配肢体方向。", "在“机构评估与审核”模块，对“长江新里程子”模块数据进行评估和审核，对“无障碍改造”模块数据进行评估和审核，对“辅具上门评估与适配”模块的评估适配结果进行评估和审核；对审核未通过的肢体功能障碍者进行二次评估。",""),
                new Role( 5, "辅具技术人员（听力方向）","本地区开展辅具适配的权威机构（如辅具中心）人员，涉及辅具适配听力方向。", "在“机构评估与审核模”块，对辖区指定或全部功能障碍者的辅具上门评估与适配模块涉及听力方向评估适配结果进行审核。对审核未通过的听力功能障碍者进行二次评估。",""),
                new Role( 6, "辅具技术人员（视力方向）","本地区开展辅具适配的权威机构（如辅具中心）人员，涉及辅具适配视力方向。", "在机构评估与审核模块，对辖区指定或全部功能障碍者的辅具上门评估与适配模块涉及视力方向评估适配结果进行审核。对审核未通过的视力功能障碍者进行二次评估。",""),
                new Role( 7, "辅具技术人员（假肢矫形器方向）","本地区开展辅具适配的权威机构（如辅具中心）人员，涉及辅具适配假肢矫形器方向。", "在“机构评估与审核”模块，对“长江新里程子”模块数据进行评估，对“无障碍改造”模块数据进行评估，对“辅具上门评估与适配”模块的评估适配结果进行审核；对审核未通过的肢体功能障碍者进行二次评估。","")   ,
                new Role( 8, "辅具技术人员（无障碍方向）","本地区开展辅具适配的权威机构（如辅具中心）人员，涉及无障碍方向方向。", "在“机构评估与审核”模块，对“无障碍改造”模块数据进行评估和审核。",""),
                new Role( 9, "评估机构（除辅具外）","本地区开展除辅具评估适配业务以外的评估机构，涉及康复治疗与训练、手术、支持性服务，等的评估。", "在“机构评估与审核”模块，对辖区指定或全部功能障碍者涉及康复治疗与训练、手术、支持性服务的需求进行评估。","")   ,
                new Role( 10, "康复服务机构","本地区开展除辅具评估适配业务以外的服务机构，涉及康复治疗与训练、手术、支持性服务，等的服务。", "在“综合康复服务”模块的“康复服务”子模块，对功能障碍者开展康复治疗与训练、手术、支持性服务，等的服务。",""),
                new Role( 11, "辅具服务机构","本地区开展辅具服务的机构。", "在“综合康复服务”模块的“辅具服务”子模块，对功能障碍者开展辅具配发、假肢矫形器和无障碍等的服务。","")
            };
            db.Roles.AddRange(Roles);
            #endregion

            #region 关系
            List<Relationship> Relationships = new List<Relationship>
            {
                new Relationship(1, "父母"),
                new Relationship(2, "配偶"),
                new Relationship(3, "兄弟姐妹"),
                new Relationship(4, "祖父母"),
                new Relationship(5, "其他")
            };
            db.Relationships.AddRange(Relationships);
            #endregion

            #region 残疾类别
            List<Category> Categories = new List<Category>
            {
                new Category(1, "视力"),
                new Category(2, "听力"),
                new Category(3, "言语"),
                new Category(4, "肢体"),
                new Category(5, "智力"),
                new Category(6, "精神"),
                new Category(7, "多重"),
            };
            db.Categories.AddRange(Categories);
            #endregion

            #region 残疾等级
            List<Degree> Degrees = new List<Degree>
            {
                new Degree(1, "一级"),
                new Degree(2, "二级"),
                new Degree(3, "三级"),
                new Degree(4, "四级"),
                new Degree(5, "未定级")
            };
            db.Degrees.AddRange(Degrees);
            #endregion

            #region 服务走向
            List<Next> Nexts = new List<Next>
            {
                new Next(1, "转介评估机构"),
                new Next(2, "转介服务机构"),
                new Next(3, "上门评估")
            };
            db.Nexts.AddRange(Nexts);
            #endregion

            #region 致残原因
            List<DisabilityReason> DisabilityReasons = new List<DisabilityReason>
            {
                new DisabilityReason(1, "外伤"),
                new DisabilityReason(1, "青光眼"),
                new DisabilityReason(1, "角膜病"),
                new DisabilityReason(1, "视网膜"),
                new DisabilityReason(1, "色素膜变性"),
                new DisabilityReason(1, "屈光不正/弱视"),
                new DisabilityReason(1, "白内障"),
                new DisabilityReason(1, "黄斑变性"),
                new DisabilityReason(1, "视神经萎缩"),
                new DisabilityReason(1, "其他"),
                new DisabilityReason(2, "先天性"),
                new DisabilityReason(2, "药物性"),
                new DisabilityReason(2, "老年性"),
                new DisabilityReason(2, "其他"),
            };
            db.DisabilityReasons.AddRange(DisabilityReasons);
            #endregion

            #region 康复需求
            List<Rehabilitation> Rehabilitations = new List<Rehabilitation>
            {
                //视力
                new Rehabilitation(1010101, 1, "视力", "盲人","白内障复明手术",false),
                new Rehabilitation(1010102, 1, "视力", "盲人","辅助器具适配及服务", true),
                new Rehabilitation(1010103, 1, "视力", "盲人","定向行走及适应训练",false),
                new Rehabilitation(1010104, 1, "视力", "盲人","支持性服务",false),
                new Rehabilitation(1010201, 1, "视力", "低视力","辅助器具适配及服务", true),
                new Rehabilitation(1010202, 1, "视力", "低视力","视功能训练",false),
                //听力
                new Rehabilitation(1020101, 2, "听力", "0-6岁儿童","人工耳蜗植入手术",false),
                new Rehabilitation(1020102, 2, "听力", "0-6岁儿童","辅助器具适配及服务", true),
                new Rehabilitation(1020103, 2, "听力", "0-6岁儿童","听觉言语功能训练",false),
                new Rehabilitation(1020104, 2, "听力", "0-6岁儿童","支持性服务",false),
                new Rehabilitation(1020201, 2, "听力", "7—17岁儿童","辅助器具适配及适应训练", true),
                new Rehabilitation(1020202, 2, "听力", "7—17岁儿童","支持性服务",false),
                new Rehabilitation(1020301, 2, "听力", "成人","辅助器具适配及适应训练", true),
                //言语
                new Rehabilitation(1030101, 3, "言语", "成人","",false),
                //肢体 
                new Rehabilitation(1040101, 4, "肢体", "0-6岁儿童","矫治手术",false),
                new Rehabilitation(1040102, 4, "肢体", "0-6岁儿童","运动及适应训练",false),
                new Rehabilitation(1040103, 4, "肢体", "0-6岁儿童","辅助器具适配及服务", true),
                new Rehabilitation(1040104, 4, "肢体", "0-6岁儿童","支持性服务",false),
                new Rehabilitation(1040201, 4, "肢体", "7-17儿童及成人","康复治疗及训练",false),
                new Rehabilitation(1040202, 4, "肢体", "7-17儿童及成人","辅助器具适配及服务", true),
                new Rehabilitation(1040203, 4, "肢体", "7-17儿童及成人","支持性服务",false),
                //智力
                new Rehabilitation(1050101, 5, "智力", "0-6岁儿童","认知及适应训练",false),
                new Rehabilitation(1050102, 5, "智力", "0-6岁儿童","支持性服务",false),
                new Rehabilitation(1050201, 5, "智力", "7-17儿童及成人","认知及适应训练",false),
                new Rehabilitation(1050202, 5, "智力", "7-17儿童及成人","支持性服务",false),
                //精神
                new Rehabilitation(1060101, 6, "精神", "0-6岁孤独症儿童","沟通及适应训练",false),
                new Rehabilitation(1060102, 6, "精神", "0-6岁孤独症儿童","支持性服务",false),
                new Rehabilitation(1060201, 6, "精神", "7-17孤独症","沟通及适应训练",false),
                new Rehabilitation(1060202, 6, "精神", "7-17孤独症","支持性服务",false),
                new Rehabilitation(1060301, 6, "精神", "成年精神残疾人","精神疾病药物治疗",false),
                new Rehabilitation(1060302, 6, "精神", "成年精神残疾人","精神障碍作业疗法训练",false),
                new Rehabilitation(1060303, 6, "精神", "成年精神残疾人","支持性服务",false),
            };
            db.Rehabilitations.AddRange(Rehabilitations);
            #endregion
            db.SaveChanges();

            #region 用户
            var user = new User("", "", "管理员", 1, DateTime.Today);
            db.Users.AddOrUpdate(user);
            #endregion

            #region 残疾人信息
            List<Disabled> Disableds = new List<Disabled> {
                new Disabled
                (
                    "权子豪",
                    1,
                    "13800000000",
                   "权子豪爸",
                    1,
                    true,
                    "32030219911010101011",
                    true,
                    1,
                    1,
                    DateTime.Today
                ),
                new Disabled
                (
                    "唐莎莎",
                    2,
                    "13800000000",
                   "莎莎妈",
                    2,
                    true,
                    "32030219911010101022",
                    true,
                    2,
                    2,
                    DateTime.Today
                ),
                new Disabled
                (
                    "周正一",
                    1,
                    "13800000000",
                   "周正一妈",
                    2,
                    true,
                    "32030219911010101033",
                    true,
                    3,
                    3,
                    DateTime.Today
                ),
                new Disabled
                (
                    "谢琦",
                    1,
                    "13800000000",
                   "谢琦妈",
                    2,
                    true,
                    "32030219911010101044",
                    true,
                    4,
                    4,
                    DateTime.Today
                ),
                new Disabled
                (
                    "韩冰",
                    2,
                    "13800000000",
                   "韩冰妈",
                    2,
                    true,
                    "32030219911010101054",
                    true,
                    5,
                    4,
                    DateTime.Today
                ),
                new Disabled
                (
                    "韩儒",
                    1,
                    "13800000000",
                   "韩儒妈",
                    2,
                    true,
                    "32030219911010101064",
                    true,
                    6,
                    4,
                    DateTime.Today
                ),
                new Disabled
                (
                    "孙永",
                    1,
                    "13800000000",
                   "孙永妈",
                    2,
                    true,
                    "32030219911010101074",
                    true,
                    7,
                    4,
                    DateTime.Today
                )
            };
            db.Disableds.AddRange(Disableds);
            #endregion
            db.SaveChanges();

            //康复需求
            List<Disabled_Detail> Disabled_Details = new List<Disabled_Detail> {
                new Disabled_Detail(1, 1, 1, 1010102, 3),
                new Disabled_Detail(2, 2, 2, 1020102, 3),
            };
            db.Disabled_Details.AddRange(Disabled_Details);
            db.SaveChanges();


            #region 辅具列表
            List<AssistiveDevice> AssistiveDevices = new List<AssistiveDevice>
            {
                #region 轮椅代步
                new AssistiveDevice(10217,"替代机动车","轮椅代步"),
                new AssistiveDevice(10218,"自行车","轮椅代步"),
                new AssistiveDevice(10222,"手动轮椅车","轮椅代步"),
                new AssistiveDevice(10223,"动力轮椅车","轮椅代步"),

                new AssistiveDevice(1021703,"爬楼梯装置","轮椅代步"),
                new AssistiveDevice(1021706,"站驾式机动车","轮椅代步"),
                new AssistiveDevice(1021806,"单人脚踏三轮车或四轮车","轮椅代步"),
                new AssistiveDevice(1021809,"手摇三轮车","轮椅代步"),
                new AssistiveDevice(1022203,"双手驱动轮椅车","轮椅代步"),
                new AssistiveDevice(1022206,"摆杆驱动轮椅","轮椅代步"),
                new AssistiveDevice(1022209,"单手驱动轮椅车","轮椅代步"),
                new AssistiveDevice(1022212,"电力辅助手动轮椅车","轮椅代步"),
                new AssistiveDevice(1022215,"脚驱动轮椅","轮椅代步"),
                new AssistiveDevice(1022218,"护理者操纵的轮椅车","轮椅代步"),
                new AssistiveDevice(1022303,"电动轮椅车","轮椅代步"),
                new AssistiveDevice(1022315,"爬楼梯轮椅车","轮椅代步"),
                new AssistiveDevice(1022309,"机动轮椅车","轮椅代步"),
                new AssistiveDevice(102170301,"爬楼梯座椅","轮椅代步"),

                new AssistiveDevice(102170302,"爬楼梯轮椅运载工具","轮椅代步"),
                new AssistiveDevice(102170601,"站驾式机动车","轮椅代步"),
                new AssistiveDevice(102180601,"手摇脚踏驱动式三轮车","轮椅代步"),
                new AssistiveDevice(102180602,"手摇脚踏驱动式四轮车","轮椅代步"),
                new AssistiveDevice(102180901,"手摇驱动后轮式三轮车","轮椅代步"),
                new AssistiveDevice(102180902,"手摇驱动前轮式三轮车","轮椅代步"),
                new AssistiveDevice(102180903,"平摇式手摇三轮车","轮椅代步"),
                new AssistiveDevice(102180904,"推拉式手摇三轮车","轮椅代步"),
                new AssistiveDevice(102220301,"普通轮椅（后轮驱动轮椅）","轮椅代步"),
                new AssistiveDevice(102220302,"功能轮椅","轮椅代步"),
                new AssistiveDevice(102220303,"洗浴轮椅","轮椅代步"),
                new AssistiveDevice(102220304,"前轮驱动轮椅","轮椅代步"),
                new AssistiveDevice(102220305,"站立式手动轮椅","轮椅代步"),
                new AssistiveDevice(102220306,"斜躺式手动轮椅","轮椅代步"),
                new AssistiveDevice(102220307,"倾斜式手动轮椅","轮椅代步"),
                new AssistiveDevice(102220308,"休闲轮椅","轮椅代步"),
                new AssistiveDevice(102220309,"运动轮椅","轮椅代步"),
                new AssistiveDevice(102220310,"篮球轮椅","轮椅代步"),
                new AssistiveDevice(102220311,"乒乓球轮椅","轮椅代步"),
                new AssistiveDevice(102220312,"橄榄球轮椅","轮椅代步"),
                new AssistiveDevice(102220313,"网球轮椅","轮椅代步"),
                new AssistiveDevice(102220314,"舞蹈轮椅","轮椅代步"),
                new AssistiveDevice(102220315,"竞速轮椅","轮椅代步"),
                new AssistiveDevice(102220316,"沙滩轮椅","轮椅代步"),
                new AssistiveDevice(102220317,"泳池轮椅","轮椅代步"),
                new AssistiveDevice(102220318,"雪地轮椅","轮椅代步"),
                new AssistiveDevice(102220319,"定制轮椅","轮椅代步"),
                new AssistiveDevice(102220601,"双手摆杆驱动轮椅","轮椅代步"),
                new AssistiveDevice(102220602,"杠杆驱动轮椅","轮椅代步"),
                new AssistiveDevice(102220901,"单手轮驱动轮椅","轮椅代步"),
                new AssistiveDevice(102220902,"单手摆杆驱动轮椅","轮椅代步"),
                new AssistiveDevice(102221201,"电力辅助手动轮椅车","轮椅代步"),
                new AssistiveDevice(102221501,"脚驱动轮椅","轮椅代步"),
                new AssistiveDevice(102221801,"高靠背轮椅（带坐便）","轮椅代步"),
                new AssistiveDevice(102221802,"护理轮椅","轮椅代步"),
                new AssistiveDevice(102221803,"可趟式轮椅","轮椅代步"),
                new AssistiveDevice(102221804,"助推式轮椅","轮椅代步"),
                new AssistiveDevice(102221805,"座便轮椅","轮椅代步"),
                new AssistiveDevice(102221806,"站立式轮椅","轮椅代步"),
                new AssistiveDevice(102221807,"体廓形脑瘫儿童轮椅","轮椅代步"),
                new AssistiveDevice(102221808,"平面型脑瘫儿童轮椅","轮椅代步"),
                new AssistiveDevice(102221809,"普通儿童轮椅","轮椅代步"),
                new AssistiveDevice(102230301,"室内型电动轮椅","轮椅代步"),
                new AssistiveDevice(102230302,"室外型电动轮椅","轮椅代步"),
                new AssistiveDevice(102230303,"道路型电动轮椅","轮椅代步"),
                new AssistiveDevice(102230304,"普通电动轮椅","轮椅代步"),
                new AssistiveDevice(102230305,"站立电动轮椅","轮椅代步"),
                new AssistiveDevice(102230306,"斜躺式电动轮椅","轮椅代步"),
                new AssistiveDevice(102230307,"倾斜式电动轮椅","轮椅代步"),
                new AssistiveDevice(102230308,"电动升降轮椅","轮椅代步"),
                new AssistiveDevice(102230309,"电动六轮轮椅","轮椅代步"),
                new AssistiveDevice(102230310,"电动三轮车","轮椅代步"),
                new AssistiveDevice(102230311,"儿童电动轮椅","轮椅代步"),
                new AssistiveDevice(102231501,"行星轮系爬楼轮椅","轮椅代步"),
                new AssistiveDevice(102231502,"履带式爬楼轮椅","轮椅代步"),
                new AssistiveDevice(102230901,"三轮机动轮椅车","轮椅代步"),
                new AssistiveDevice(102230902,"四轮机动轮椅车","轮椅代步"),
                #endregion
                
                #region 辅助行走
                new AssistiveDevice(10203,"单臂操作助行器","辅助行走"),
                new AssistiveDevice(10206,"双臂操作助行器","辅助行走"),
                new AssistiveDevice(10207,"助行器附件","辅助行走"),
                new AssistiveDevice(10239,"定位辅助器具","辅助行走"),

                new AssistiveDevice(1020303,"手杖","辅助行走"),
                new AssistiveDevice(1020306,"肘拐","辅助行走"),
                new AssistiveDevice(1020309,"前臂支撑拐","辅助行走"),
                new AssistiveDevice(1020312,"腋拐","辅助行走"),
                new AssistiveDevice(1020318,"带座手杖","辅助行走"),
                new AssistiveDevice(1023819,"单侧操作助行架","辅助行走"),
                new AssistiveDevice(1020603,"框式助行架","辅助行走"),
                new AssistiveDevice(1020606,"轮式助行器","辅助行走"),
                new AssistiveDevice(1020609,"座式助行器","辅助行走"),
                new AssistiveDevice(1020612,"台式助行器","辅助行走"),
                new AssistiveDevice(1020705,"助行器支脚","辅助行走"),
                new AssistiveDevice(1020712,"握持助行器的器具","辅助行走"),
                new AssistiveDevice(1020715,"支撑身体特定部位的助行器配件","辅助行走"),
                new AssistiveDevice(1020718,"防止擦伤或皮肤损伤的垫子、衬垫和其他助行器配件","辅助行走"),
                new AssistiveDevice(1020721,"助行器座椅","辅助行走"),
                new AssistiveDevice(1020724,"固定或携带物品的助行器配件","辅助行走"),
                new AssistiveDevice(1020727,"助行器不使用时的固定器具","辅助行走"),
                new AssistiveDevice(1020730,"帮助操纵助行器的配件","辅助行走"),
                new AssistiveDevice(1020733,"轮式助行器和框式助行器调节高度的配件","辅助行走"),
                new AssistiveDevice(1020736,"助行器的灯和安全信号装置","辅助行走"),
                new AssistiveDevice(1020739,"助行器的轮胎和轮子","辅助行走"),
                new AssistiveDevice(1023903,"盲杖","辅助行走"),
                new AssistiveDevice(1023906,"电子定位辅助器具","辅助行走"),

                new AssistiveDevice(102030301,"单脚直形手杖（固定/可调）","辅助行走"),
                new AssistiveDevice(102030302,"单脚弯形手杖（固定/可调）","辅助行走"),
                new AssistiveDevice(102030303,"单脚S形手杖（固定/可调）","辅助行走"),
                new AssistiveDevice(102030304,"直形三脚手杖（固定/可调）","辅助行走"),
                new AssistiveDevice(102030305,"弯形三脚手杖（固定/可调）","辅助行走"),
                new AssistiveDevice(102030306,"S形三脚手杖（固定/可调）","辅助行走"),
                new AssistiveDevice(102030307,"直形四脚手杖（固定/可调）","辅助行走"),
                new AssistiveDevice(102030308,"弯形四脚手杖（固定/可调）","辅助行走"),
                new AssistiveDevice(102030309,"S形四脚手杖（固定/可调）","辅助行走"),
                new AssistiveDevice(102030310,"折叠手杖","辅助行走"),
                new AssistiveDevice(102030311,"带灯手杖","辅助行走"),
                new AssistiveDevice(102030312,"登山杖","辅助行走"),
                new AssistiveDevice(102030601,"固定式肘拐","辅助行走"),
                new AssistiveDevice(102030602,"臂套式肘拐","辅助行走"),
                new AssistiveDevice(102030603,"多脚肘拐","辅助行走"),
                new AssistiveDevice(102030901,"单脚前臂支撑拐","辅助行走"),
                new AssistiveDevice(102030902,"三脚前臂支撑拐","辅助行走"),
                new AssistiveDevice(102030903,"四脚前臂支撑拐","辅助行走"),
                new AssistiveDevice(102030904,"单脚前臂托板拐","辅助行走"),
                new AssistiveDevice(102030905,"前臂托多脚板拐","辅助行走"),
                new AssistiveDevice(102031201,"普通腋拐（单脚）","辅助行走"),
                new AssistiveDevice(102031202,"弧形腋拐","辅助行走"),
                new AssistiveDevice(102031203,"单杆腋拐","辅助行走"),
                new AssistiveDevice(102031204,"多脚腋拐","辅助行走"),
                new AssistiveDevice(102031205,"肘支撑腋拐","辅助行走"),
                new AssistiveDevice(102031206,"前臂托板腋拐","辅助行走"),
                new AssistiveDevice(102031207,"儿童腋拐","辅助行走"),
                new AssistiveDevice(102031801,"带座三脚手杖","辅助行走"),
                new AssistiveDevice(102381901,"单侧操作助行架","辅助行走"),
                new AssistiveDevice(102060301,"三脚框式助行器","辅助行走"),
                new AssistiveDevice(102060302,"四脚框式助行器","辅助行走"),
                new AssistiveDevice(102060303,"阶梯框式助行器","辅助行走"),
                new AssistiveDevice(102060304,"交替框式助行器（交互式/差动式）","辅助行走"),
                new AssistiveDevice(102060305,"可调式助行器","辅助行走"),
                new AssistiveDevice(102060306,"平台式助行器","辅助行走"),
                new AssistiveDevice(102060307,"手撑座椅式助行器","辅助行走"),
                new AssistiveDevice(102060601,"手扶两轮助行器","辅助行走"),
                new AssistiveDevice(102060602,"手扶三轮助行器","辅助行走"),
                new AssistiveDevice(102060603,"手扶四轮助行器","辅助行走"),
                new AssistiveDevice(102060604,"手扶多功能助行器","辅助行走"),
                new AssistiveDevice(102060605,"框式两轮助行器","辅助行走"),
                new AssistiveDevice(102060606,"框式四轮助行器","辅助行走"),
                new AssistiveDevice(102060607,"后置四轮助行器","辅助行走"),
                new AssistiveDevice(102060608,"腋托四轮助行器","辅助行走"),
                new AssistiveDevice(102060609,"下压制动两轮助行器","辅助行走"),
                new AssistiveDevice(102060610,"吊带坐式四轮助行器","辅助行走"),
                new AssistiveDevice(102060901,"固定支撑座式助行器","辅助行走"),
                new AssistiveDevice(102060902,"吊带支撑座式助行器","辅助行走"),
                new AssistiveDevice(102061201,"平台支撑台式助行器","辅助行走"),
                new AssistiveDevice(102061202,"前臂支撑台式助行器","辅助行走"),
                new AssistiveDevice(102061203,"固定式助行器","辅助行走"),
                new AssistiveDevice(102061204,"可调式助行器","辅助行走"),
                new AssistiveDevice(102061205,"两轮带座助行器","辅助行走"),
                new AssistiveDevice(102061206,"两轮带座折叠助行器","辅助行走"),
                new AssistiveDevice(102061207,"四轮带刹带筐购物助行器","辅助行走"),
                new AssistiveDevice(102070501,"加防滑材料的支脚","辅助行走"),
                new AssistiveDevice(102070502,"软性支脚","辅助行走"),
                new AssistiveDevice(102070503,"支脚垫","辅助行走"),
                new AssistiveDevice(102071201,"可调把手","辅助行走"),
                new AssistiveDevice(102071202,"防滑把手","辅助行走"),
                new AssistiveDevice(102071203,"手柄杆","辅助行走"),
                new AssistiveDevice(102071204,"调节装置","辅助行走"),
                new AssistiveDevice(102071501,"腋托","辅助行走"),
                new AssistiveDevice(102071502,"背托","辅助行走"),
                new AssistiveDevice(102071503,"头托","辅助行走"),
                new AssistiveDevice(102071504,"安全带","辅助行走"),
                new AssistiveDevice(102071801,"拐杖垫","辅助行走"),
                new AssistiveDevice(102071802,"助行架垫","辅助行走"),
                new AssistiveDevice(102072101,"硬质座椅","辅助行走"),
                new AssistiveDevice(102072102,"吊兜类座椅","辅助行走"),
                new AssistiveDevice(102072103,"可折叠座椅","辅助行走"),
                new AssistiveDevice(102072401,"储物筐","辅助行走"),
                new AssistiveDevice(102072402,"挂钩","辅助行走"),
                new AssistiveDevice(102072403,"搁板","辅助行走"),
                new AssistiveDevice(102072404,"伞固定架","辅助行走"),
                new AssistiveDevice(102072405,"拐杖固定架","辅助行走"),
                new AssistiveDevice(102072406,"前臂托板","辅助行走"),
                new AssistiveDevice(102072407,"支撑吊带","辅助行走"),
                new AssistiveDevice(102072701,"助行器停放制动装置","辅助行走"),
                new AssistiveDevice(102073001,"助推杆","辅助行走"),
                new AssistiveDevice(102073002,"防翻转轮","辅助行走"),
                new AssistiveDevice(102073003,"过门槛和路沿的装置","辅助行走"),
                new AssistiveDevice(102073004,"连续制动器","辅助行走"),
                new AssistiveDevice(102073301,"高度伸缩杆","辅助行走"),
                new AssistiveDevice(102073601,"照明灯","辅助行走"),
                new AssistiveDevice(102073602,"安全信号装置","辅助行走"),
                new AssistiveDevice(102073603,"反光镜","辅助行走"),
                new AssistiveDevice(102073901,"小脚轮","辅助行走"),
                new AssistiveDevice(102390301,"铝合金普通盲杖（直杆）","辅助行走"),
                new AssistiveDevice(102390302,"声光盲人手杖","辅助行走"),
                new AssistiveDevice(102390303,"声光折叠电子盲杖","辅助行走"),
                new AssistiveDevice(102390304,"铝合金四折盲杖","辅助行走"),
                new AssistiveDevice(102390305,"铝合金七折盲杖","辅助行走"),
                new AssistiveDevice(102390306,"超声波电子盲杖","辅助行走"),
                new AssistiveDevice(102390307,"语音导盲盲杖","辅助行走"),
                new AssistiveDevice(102390308,"收缩式盲杖","辅助行走"),
                new AssistiveDevice(102390309,"盲聋杖","辅助行走"),
                new AssistiveDevice(102390601,"电子导盲器","辅助行走"),
                #endregion
                
                #region 饮食
                new AssistiveDevice(11003,"准备食物和饮料的辅助器具","饮食"),
                new AssistiveDevice(11006,"清洗餐具辅助器具","饮食"),
                new AssistiveDevice(11009,"食饮辅助器具","饮食"),

                new AssistiveDevice(1100306,"准备食物和饮料用的切、砍和分割辅助器具","饮食"),
                new AssistiveDevice(1100307,"烹饪食物用炉灶、锅具等辅具","饮食"),
                new AssistiveDevice(1100309,"清洗和削皮的辅助器具","饮食"),
                new AssistiveDevice(1100312,"烘烤辅助器具","饮食"),
                new AssistiveDevice(1100315,"用于准备食物的机器","饮食"),
                new AssistiveDevice(1100318,"烹调和油煎辅助器具","饮食"),
                new AssistiveDevice(1100319,"称量用辅具","饮食"),
                new AssistiveDevice(1100320,"准备药品用辅具","饮食"),
                new AssistiveDevice(1100606,"洗盘用刷和瓶刷","饮食"),
                new AssistiveDevice(1100609,"盘子滤干器","饮食"),
                new AssistiveDevice(1100615,"抹布绞干机","饮食"),
                new AssistiveDevice(1100903,"供应食物和饮料的辅助器具","饮食"),
                new AssistiveDevice(1100918,"盘子和碗","饮食"),
                new AssistiveDevice(1100921,"食物挡边","饮食"),
                new AssistiveDevice(1100922,"叉","饮食"),
                new AssistiveDevice(1100923,"勺","饮食"),
                new AssistiveDevice(1100924,"筷子","饮食"),
                new AssistiveDevice(1100925,"杯子","饮食"),
                new AssistiveDevice(1100927,"喂食器械","饮食"),
                new AssistiveDevice(1100930,"喂管","饮食"),
                new AssistiveDevice(1100931,"生活自助具套装","饮食"),

                new AssistiveDevice(110030601,"单手切菜器","饮食"),
                new AssistiveDevice(110030602,"带刻度切菜板","饮食"),
                new AssistiveDevice(110030603,"多功能单手切菜器","饮食"),
                new AssistiveDevice(110030701,"语音带盲文电磁炉","饮食"),
                new AssistiveDevice(110030702,"微电脑盲文语音电压力锅","饮食"),
                new AssistiveDevice(110030703,"盲文语言微波炉","饮食"),
                new AssistiveDevice(110030704,"微电脑盲文语音西施煲","饮食"),
                new AssistiveDevice(110030705,"语音带盲文电饭煲","饮食"),
                new AssistiveDevice(110030706,"语音带盲文电压力锅","饮食"),
                new AssistiveDevice(110030707,"微电脑盲文语音电磁炉","饮食"),
                new AssistiveDevice(110030901,"带吸盘削皮器","饮食"),
                new AssistiveDevice(110030902,"固定夹式削皮器","饮食"),
                new AssistiveDevice(110030903,"带吸盘菜刷","饮食"),
                new AssistiveDevice(110030904,"挖核的刀子","饮食"),
                new AssistiveDevice(110031201, "烘烤罐", "饮食"),
                new AssistiveDevice(110031202, "烘烤皿", "饮食"),
                new AssistiveDevice(110031203, "烘烤盘", "饮食"),
                new AssistiveDevice(110031501, "打蛋器", "饮食"),
                new AssistiveDevice(110031801, "烹调和油煎辅助器具", "饮食"),
                new AssistiveDevice(110031901, "计量油壶", "饮食"),
                new AssistiveDevice(110032001, "自动分药盒", "饮食"),
                new AssistiveDevice(110060601, "带吸盘盘刷", "饮食"),
                new AssistiveDevice(110060602, "带吸盘瓶刷", "饮食"),
                new AssistiveDevice(110060901, "盘子滤干器", "饮食"),
                new AssistiveDevice(110061501, "抹布绞干机", "饮食"),
                new AssistiveDevice(110090301,"供应食物和饮料的辅助器具","饮食"),
                new AssistiveDevice(110091801, "普通防洒碗", "饮食"),
                new AssistiveDevice(110091802, "保温防洒碗", "饮食"),
                new AssistiveDevice(110091803, "底部带吸盘餐具", "饮食"),
                new AssistiveDevice(110091804, "盘子", "饮食"),
                new AssistiveDevice(110092101, "盘挡", "饮食"),
                new AssistiveDevice(110092102, "桌上防滑垫", "饮食"),
                new AssistiveDevice(110092201, "粗柄叉", "饮食"),
                new AssistiveDevice(110092202, "弯柄叉", "饮食"),
                new AssistiveDevice(110092203, "记忆叉", "饮食"),
                new AssistiveDevice(110092204, "掌套式叉", "饮食"),
                new AssistiveDevice(110092301, "感温汤匙（2支装）", "饮食"),
                new AssistiveDevice(110092302, "辅助弯柄弯头勺", "饮食"),
                new AssistiveDevice(110092303, "粗柄勺", "饮食"),
                new AssistiveDevice(110092304, "掌套式勺", "饮食"),
                new AssistiveDevice(110092305, "热塑记忆勺", "饮食"),
                new AssistiveDevice(110092401, "辅助训练防滑筷", "饮食"),
                new AssistiveDevice(110092402, "弹簧助开筷子", "饮食"),
                new AssistiveDevice(110092403, "弹簧助合筷子", "饮食"),
                new AssistiveDevice(110092404, "防滑餐筷", "饮食"),
                new AssistiveDevice(110092501, "防漏水壶（小号）", "饮食"),
                new AssistiveDevice(110092502, "斜口杯", "饮食"),
                new AssistiveDevice(110092503, "大耳杯", "饮食"),
                new AssistiveDevice(110092504, "吸管杯", "饮食"),
                new AssistiveDevice(110092701, "电动喂食机", "饮食"),
                new AssistiveDevice(110093001, "喂食泵", "饮食"),
                new AssistiveDevice(110093101, "生活自助具", "饮食"),
                #endregion
                
                #region 个人护理
                new AssistiveDevice(10315,"气管造口护理辅助器具","个人护理"),
                new AssistiveDevice(10318,"肠造口护理辅助器具","个人护理"),
                new AssistiveDevice(10321,"护肤和洁肤产品","个人护理"),
                new AssistiveDevice(10336,"修剪手指甲和脚趾甲的辅助器具","个人护理"),
                new AssistiveDevice(10339,"护发辅助器具","个人护理"),
                new AssistiveDevice(10342,"牙科护理辅助器具","个人护理"),
                new AssistiveDevice(10345,"面部护理和皮肤护理辅助器具","个人护理"),
                new AssistiveDevice(10408,"卧式家具","个人护理"),
                new AssistiveDevice(10410,"坐具配件","个人护理"),

                new AssistiveDevice(1031503,"气管造口套管","个人护理"),
                new AssistiveDevice(1031506,"气管造口保护器","个人护理"),
                new AssistiveDevice(1031804,"一件式封口造口袋","个人护理"),
                new AssistiveDevice(1031805,"两件式封口造口袋","个人护理"),
                new AssistiveDevice(1031807,"带防回流阀的一件式开口造口袋","个人护理"),
                new AssistiveDevice(1031808,"带防回流阀的两件式开口造口袋","个人护理"),
                new AssistiveDevice(1031809,"造口袋支撑和压固辅助器具","个人护理"),
                new AssistiveDevice(1031813,"造口护理压板和带子","个人护理"),
                new AssistiveDevice(1031814,"造口护理胶粘器具","个人护理"),
                new AssistiveDevice(1031815,"造口袋密封件","个人护理"),
                new AssistiveDevice(1031818,"造口护理气味吸收器和除臭器","个人护理"),
                new AssistiveDevice(1031821,"造口袋的护套","个人护理"),
                new AssistiveDevice(1031824,"灌肠辅助器具","个人护理"),
                new AssistiveDevice(1031830,"造口防护罩","个人护理"),
                new AssistiveDevice(1031833,"瘘口导液管","个人护理"),
                new AssistiveDevice(1031836,"造口护理用冲洗注射器","个人护理"),
                new AssistiveDevice(1031839,"一件式开口的造口袋","个人护理"),
                new AssistiveDevice(1031842,"两件式开口的造口袋","个人护理"),
                new AssistiveDevice(1031845,"造口护理皮肤遮盖层","个人护理"),
                new AssistiveDevice(1031848,"术后造口袋及配件","个人护理"),
                new AssistiveDevice(1032103,"褪胶剂","个人护理"),
                new AssistiveDevice(1032106,"洁肤剂","个人护理"),
                new AssistiveDevice(1032109,"消毒剂","个人护理"),
                new AssistiveDevice(1032112,"覆盖材料","个人护理"),
                new AssistiveDevice(1032115,"密封材料","个人护理"),
                new AssistiveDevice(1032118,"护肤剂","个人护理"),
                new AssistiveDevice(1033603,"指甲刷","个人护理"),
                new AssistiveDevice(1033606,"指甲锉和砂纸板","个人护理"),
                new AssistiveDevice(1033609,"指甲剪和指甲刀","个人护理"),
                new AssistiveDevice(1033612,"磨茧锉","个人护理"),
                new AssistiveDevice(1033903,"用洗发剂洗头发的辅助器具","个人护理"),
                new AssistiveDevice(1033907,"梳子","个人护理"),
                new AssistiveDevice(1033906,"头发刷","个人护理"),
                new AssistiveDevice(1033909,"吹风机","个人护理"),
                new AssistiveDevice(1034203,"无动力（手动）牙刷","个人护理"),
                new AssistiveDevice(1034206,"动力（电动）牙刷","个人护理"),
                new AssistiveDevice(1034503,"修胡刷、剃刀和（电动）剃须刀","个人护理"),
                new AssistiveDevice(1034506,"化妆品使用辅助器具","个人护理"),
                new AssistiveDevice(1034509,"脸部保养用的镜子","个人护理"),
                new AssistiveDevice(1040801,"护理床","个人护理"),
                new AssistiveDevice(1041003,"靠背","个人护理"),
                new AssistiveDevice(1041006,"座垫和衬垫","个人护理"),
                new AssistiveDevice(1041009,"扶手","个人护理"),
                new AssistiveDevice(1041012,"头托和颈托","个人护理"),
                new AssistiveDevice(1041015,"腿托和足托","个人护理"),
                new AssistiveDevice(1041018,"躯干托和骨盆托","个人护理"),

                new AssistiveDevice(103150301,"普通型气管插管","个人护理"),
                new AssistiveDevice(103150302,"加强型气管插管","个人护理"),
                new AssistiveDevice(103150601,"气管切开护理保护器","个人护理"),
                new AssistiveDevice(103150602,"气管插管加湿保护器","个人护理"),
                new AssistiveDevice(103150603, "气管插管防喷保护器", "个人护理"),
                new AssistiveDevice(103180401, "一件式封口造口袋", "个人护理"),
                new AssistiveDevice(103180501, "两件式封口造口袋", "个人护理"),
                new AssistiveDevice(103180701,"带防回流阀的一件式开口造口袋","个人护理"),
                new AssistiveDevice(103180801,"带防回流阀的两件式开口造口袋","个人护理"),
                new AssistiveDevice(103180901, "造口袋支撑和压固辅助器具", "个人护理"),
                new AssistiveDevice(103181301, "造口护理压板和带子", "个人护理"),
                new AssistiveDevice(103181401, "造口护理胶粘器具", "个人护理"),
                new AssistiveDevice(103181501, "造口袋密封件", "个人护理"),
                new AssistiveDevice(103181801,"造口护理气味吸收器和除臭器","个人护理"),
                new AssistiveDevice(103182101, "条形封口夹", "个人护理"),
                new AssistiveDevice(103182102, "圆形封口夹", "个人护理"),
                new AssistiveDevice(103182401, "筒式灌肠器", "个人护理"),
                new AssistiveDevice(103182402, "球式灌肠器", "个人护理"),
                new AssistiveDevice(103182403,"手摇灌肠器","个人护理"),
                new AssistiveDevice(103182404, "全自动灌肠器", "个人护理"),
                new AssistiveDevice(103182405,"一次性灌肠器","个人护理"),
                new AssistiveDevice(103183001, "通用型防护罩", "个人护理"),
                new AssistiveDevice(103183002, "铠甲型防护罩", "个人护理"),
                new AssistiveDevice(103183003,"卷帘型防护罩","个人护理"),
                new AssistiveDevice(103183301, "瘘口导液管", "个人护理"),
                new AssistiveDevice(103183601, "造口护理用冲洗注射器", "个人护理"),
                new AssistiveDevice(103183901, "成人一件式造口袋", "个人护理"),
                new AssistiveDevice(103183902,"儿童一件式造口袋","个人护理"),
                new AssistiveDevice(103183903, "带防回流阀的一件式造口袋", "个人护理"),
                new AssistiveDevice(103184201, "嵌入式两件式造口袋", "个人护理"),
                new AssistiveDevice(103184202,"粘贴式两件式造口袋","个人护理"),
                new AssistiveDevice(103184203,"带防回流阀的两件式造口袋","个人护理"),
                new AssistiveDevice(103184501, "造口护理皮肤遮盖层", "个人护理"),
                new AssistiveDevice(103184801, "术后造口袋及配件", "个人护理"),
                new AssistiveDevice(103210301, "褪胶剂", "个人护理"),
                new AssistiveDevice(103210601, "洁肤剂", "个人护理"),
                new AssistiveDevice(103210901, "消毒剂", "个人护理"),
                new AssistiveDevice(103211201, "纱布敷料", "个人护理"),
                new AssistiveDevice(103211202, "薄膜敷料", "个人护理"),
                new AssistiveDevice(103211203, "水胶体敷料", "个人护理"),
                new AssistiveDevice(103211204, "胶布", "个人护理"),
                new AssistiveDevice(103211501, "密封材料", "个人护理"),
                new AssistiveDevice(103211801, "护肤剂", "个人护理"),
                new AssistiveDevice(103360301, "指甲刷", "个人护理"),
                new AssistiveDevice(103360601, "带吸盘指甲锉", "个人护理"),
                new AssistiveDevice(103360602, "带吸盘砂纸板", "个人护理"),
                new AssistiveDevice(103360901, "带放大镜指甲剪", "个人护理"),
                new AssistiveDevice(103360902, "带吸盘指甲剪", "个人护理"),
                new AssistiveDevice(103360903, "放大镜指甲刀", "个人护理"),
                new AssistiveDevice(103361201, "手动茧皮修剪器", "个人护理"),
                new AssistiveDevice(103390301,"用洗发剂洗头发的辅助器具","个人护理"),
                new AssistiveDevice(103390701, "长柄头梳", "个人护理"),
                new AssistiveDevice(103390601, "长柄发刷", "个人护理"),
                new AssistiveDevice(103390602, "粗柄发刷", "个人护理"),
                new AssistiveDevice(103390603, "弯柄发刷", "个人护理"),
                new AssistiveDevice(103390604, "掌套式发刷", "个人护理"),
                new AssistiveDevice(103390901, "吹风机", "个人护理"),
                new AssistiveDevice(103420301, "弯柄牙刷", "个人护理"),
                new AssistiveDevice(103420302, "粗柄牙刷", "个人护理"),
                new AssistiveDevice(103420303, "掌套式牙刷", "个人护理"),
                new AssistiveDevice(103420304, "记忆牙刷", "个人护理"),
                new AssistiveDevice(103420601, "普通电动牙刷", "个人护理"),
                new AssistiveDevice(103420602, "掌套式电动牙刷", "个人护理"),
                new AssistiveDevice(103420603, "粗柄电动牙刷", "个人护理"),
                new AssistiveDevice(103450301, "修面刷", "个人护理"),
                new AssistiveDevice(103450302, "剃刀", "个人护理"),
                new AssistiveDevice(103450303, "手动剃须刀", "个人护理"),
                new AssistiveDevice(103450304, "电动剃须刀", "个人护理"),
                new AssistiveDevice(103450601, "化妆品使用辅助器具", "个人护理"),
                new AssistiveDevice(103450901, "脸部保养用的镜子", "个人护理"),
                new AssistiveDevice(104080101, "普通直板护理床", "个人护理"),
                new AssistiveDevice(104080102, "普通护理（折叠）床", "个人护理"),
                new AssistiveDevice(104080103, "手动单摇护理床", "个人护理"),
                new AssistiveDevice(104080104, "手动双摇护理床", "个人护理"),
                new AssistiveDevice(104080105, "手动三摇护理床（可翻身）", "个人护理"),
                new AssistiveDevice(104080106, "普通电动护理床", "个人护理"),
                new AssistiveDevice(104080107, "升降电动护理床", "个人护理"),
                new AssistiveDevice(104080108, "翻身电动护理床", "个人护理"),
                new AssistiveDevice(104100301, "可调靠背（架）", "个人护理"),
                new AssistiveDevice(104100302, "普通靠背", "个人护理"),
                new AssistiveDevice(104100303, "定制型靠背", "个人护理"),
                new AssistiveDevice(104100601, "蛋篓型泡沫坐垫", "个人护理"),
                new AssistiveDevice(104100602,"蜂巢型聚酯化物坐垫","个人护理"),
                new AssistiveDevice(104100603, "液态型凝胶坐垫", "个人护理"),
                new AssistiveDevice(104100604,"复合式坐垫","个人护理"),
                new AssistiveDevice(104100605, "气囊式坐垫", "个人护理"),
                new AssistiveDevice(104100606, "靠背垫", "个人护理"),
                new AssistiveDevice(104100607, "腰椎垫", "个人护理"),
                new AssistiveDevice(104100901, "床护栏杆（床旁护栏）", "个人护理"),
                new AssistiveDevice(104100902, "上翻式前臂扶手", "个人护理"),
                new AssistiveDevice(104100903, "固定式前臂扶手", "个人护理"),
                new AssistiveDevice(104100904, "床旁扶手", "个人护理"),
                new AssistiveDevice(104100905, "浴缸扶手", "个人护理"),
                new AssistiveDevice(104101201, "椅座上头托", "个人护理"),
                new AssistiveDevice(104101202, "椅座上颈托", "个人护理"),
                new AssistiveDevice(104101203, "椅座", "个人护理"),
                new AssistiveDevice(104101204,"上颈枕","个人护理"),
                new AssistiveDevice(104101501, "椅座上腿托", "个人护理"),
                new AssistiveDevice(104101502, "椅座上足托", "个人护理"),
                new AssistiveDevice(104101503, "椅座上限位搁脚板", "个人护理"),
                new AssistiveDevice(104101801, "椅座上骨盆托", "个人护理"),
                new AssistiveDevice(104101802, "椅座上躯干托", "个人护理"),
                #endregion
                
                #region 如厕
                new AssistiveDevice(10312,"如厕辅助器具","如厕"),
                new AssistiveDevice(10324,"排尿装置","如厕"),
                new AssistiveDevice(10327,"尿便收集器","如厕"),
                new AssistiveDevice(10330,"二便吸收辅助器具","如厕"),
                new AssistiveDevice(10331,"防止大小便不自主流出的辅助器具","如厕"),

                new AssistiveDevice(1031203,"坐便椅","如厕"),
                new AssistiveDevice(1031206,"坐便器","如厕"),
                new AssistiveDevice(1031209,"坐便器座","如厕"),
                new AssistiveDevice(1031212,"框架型加高的坐便器座","如厕"),
                new AssistiveDevice(1031215,"嵌入型加高的坐便器座","如厕"),
                new AssistiveDevice(1031218,"安装在坐便器上加高的坐便器座","如厕"),
                new AssistiveDevice(1031221,"内置帮助起身、坐下的升降机构的坐便器座","如厕"),
                new AssistiveDevice(1031224,"装配在坐便器上的扶手和靠背","如厕"),
                new AssistiveDevice(1031225,"落地式座便器的扶手靠背","如厕"),
                new AssistiveDevice(1031227,"手纸夹","如厕"),
                new AssistiveDevice(1031233,"便盆","如厕"),
                new AssistiveDevice(1031236,"作为坐便器附件的冲洗器和风干燥器","如厕"),
                new AssistiveDevice(1032403,"长期留置导尿管","如厕"),
                new AssistiveDevice(1032406,"间歇性导尿管","如厕"),
                new AssistiveDevice(1032409,"阴茎尿套","如厕"),
                new AssistiveDevice(1032415,"女用穿戴式软尿壶","如厕"),
                new AssistiveDevice(1032421,"男用穿戴式软尿壶","如厕"),
                new AssistiveDevice(1032704,"封口储尿袋","如厕"),
                new AssistiveDevice(1032705,"开口储尿袋","如厕"),
                new AssistiveDevice(1032709,"非穿戴式尿壶和贮尿瓶","如厕"),
                new AssistiveDevice(1032713,"集尿器悬吊架和固定装置","如厕"),
                new AssistiveDevice(1032718,"尿收集系统","如厕"),
                new AssistiveDevice(1032721,"粪便收集袋","如厕"),
                new AssistiveDevice(1033012,"儿童用一次性失禁用品","如厕"),
                new AssistiveDevice(1033015,"儿童可洗失禁用品","如厕"),
                new AssistiveDevice(1033018,"成人一次性衬垫","如厕"),
                new AssistiveDevice(1033021,"成人一次性尿布","如厕"),
                new AssistiveDevice(1033042,"非贴身一次性尿便吸收用品","如厕"),
                new AssistiveDevice(1033045,"非贴身可洗尿便吸收用品","如厕"),
                new AssistiveDevice(1033103,"阻尿器","如厕"),
                new AssistiveDevice(1033106,"阻便器","如厕"),

                new AssistiveDevice(103120301,"折叠座便椅","如厕"),
                new AssistiveDevice(103120302,"固定座便椅","如厕"),
                new AssistiveDevice(103120303,"带轮座便椅","如厕"),
                new AssistiveDevice(103120304,"简易座便椅","如厕"),
                new AssistiveDevice(103120305,"带扶手座便椅","如厕"),
                new AssistiveDevice(103120306,"不带扶手座便椅","如厕"),
                new AssistiveDevice(103120307,"儿童坐便椅","如厕"),
                new AssistiveDevice(103120601,"底座坐便器","如厕"),
                new AssistiveDevice(103120602,"高座坐便器","如厕"),
                new AssistiveDevice(103120603,"内置冲洗器的坐便器","如厕"),
                new AssistiveDevice(103120901,"坐便器座","如厕"),
                new AssistiveDevice(103121201,"带扶手加高型坐便器座","如厕"),
                new AssistiveDevice(103121501,"嵌入型加高的坐便器座","如厕"),
                new AssistiveDevice(103121801,"安装在坐便器上加高的坐便器座","如厕"),
                new AssistiveDevice(103122101,"带助起功能坐便器座","如厕"),
                new AssistiveDevice(103122401,"固定在坐便器上的身体支撑架","如厕"),
                new AssistiveDevice(103122501,"落地式座便器的扶手靠背","如厕"),
                new AssistiveDevice(103122701,"短柄手纸夹","如厕"),
                new AssistiveDevice(103122702,"长柄手纸夹","如厕"),
                new AssistiveDevice(103123301,"便携式充气便盆","如厕"),
                new AssistiveDevice(103123302,"塑料大便盆","如厕"),
                new AssistiveDevice(103123601,"坐便器冲洗器","如厕"),
                new AssistiveDevice(103123602,"坐便器热风干燥器","如厕"),
                new AssistiveDevice(103240301,"男用留置导尿管","如厕"),
                new AssistiveDevice(103240302,"女用留置导尿管","如厕"),
                new AssistiveDevice(103240303,"小儿留置导尿管","如厕"),
                new AssistiveDevice(103240601,"男用间歇性导尿管","如厕"),
                new AssistiveDevice(103240602,"女用间歇性导尿管","如厕"),
                new AssistiveDevice(103240603,"小儿间歇性导尿管","如厕"),
                new AssistiveDevice(103240901,"成人用阴茎尿套","如厕"),
                new AssistiveDevice(103240902,"小儿用阴茎尿套","如厕"),
                new AssistiveDevice(103241501,"普通女用尿壶","如厕"),
                new AssistiveDevice(103241502,"带盖女用尿壶","如厕"),
                new AssistiveDevice(103241503,"带刻度女用尿壶","如厕"),
                new AssistiveDevice(103242101, "普通男用尿壶", "如厕"),
                new AssistiveDevice(103242102, "带盖男用尿壶", "如厕"),
                new AssistiveDevice(103242103,"带刻度男用尿壶","如厕"),
                new AssistiveDevice(103270401, "穿着式柔性封口集尿器", "如厕"),
                new AssistiveDevice(103270402, "与导尿管一同使用的袋子", "如厕"),
                new AssistiveDevice(103270501, "穿着式柔性开口集尿器", "如厕"),
                new AssistiveDevice(103270502, "与导尿管一同使用的袋子", "如厕"),
                new AssistiveDevice(103270901, "非穿戴式尿壶和贮尿瓶", "如厕"),
                new AssistiveDevice(103271301, "集尿器吊带", "如厕"),
                new AssistiveDevice(103271302, "集尿器紧固带", "如厕"),
                new AssistiveDevice(103271801, "乳胶接尿器", "如厕"),
                new AssistiveDevice(103271802, "普通接尿器", "如厕"),
                new AssistiveDevice(103271803, "封闭式接尿器", "如厕"),
                new AssistiveDevice(103271804, "引流袋", "如厕"),
                new AssistiveDevice(103272101, "一次性粪便收集袋", "如厕"),
                new AssistiveDevice(103272102, "可冲洗粪便收集袋", "如厕"),
                new AssistiveDevice(103301201, "儿童尿不湿", "如厕"),
                new AssistiveDevice(103301202, "儿童尿衬垫", "如厕"),
                new AssistiveDevice(103301501, "儿童隔尿毯", "如厕"),
                new AssistiveDevice(103301801, "纸质尿衬垫", "如厕"),
                new AssistiveDevice(103302101, "成人纸尿裤", "如厕"),
                new AssistiveDevice(103304201, "一次性布尿布", "如厕"),
                new AssistiveDevice(103304202, "一次性卫生垫", "如厕"),
                new AssistiveDevice(103304203,"一次性床单","如厕"),
                new AssistiveDevice(103304204, "一次性床罩", "如厕"),
                new AssistiveDevice(103304501, "卫生垫", "如厕"),
                new AssistiveDevice(103304502, "床单", "如厕"),
                new AssistiveDevice(103304503, "床罩", "如厕"),
                new AssistiveDevice(103310301, "尿壶控制插闩", "如厕"),
                new AssistiveDevice(103310302, "尿道插塞", "如厕"),
                new AssistiveDevice(103310303, "阴道阀", "如厕"),
                new AssistiveDevice(103310304, "阴茎夹", "如厕"),
                new AssistiveDevice(103310305, "可膨胀的夹紧导尿管的气球", "如厕"),
                new AssistiveDevice(103310601, "肛门插闩", "如厕"),
                new AssistiveDevice(103310602, "肛门插塞", "如厕"),
                #endregion
                
                #region 信息交流
                new AssistiveDevice(10527,"报警、指示、提醒和讯号辅助器具","信息交流"),
                new AssistiveDevice(10509,"发声辅助器具","信息交流"),
                new AssistiveDevice(10515,"计算辅助器具","信息交流"),
                new AssistiveDevice(10518,"记录、播放和显示视听信息的辅助器具","信息交流"),
                new AssistiveDevice(10521,"面对面沟通辅助器具","信息交流"),
                new AssistiveDevice(10524,"电话传送（信息）和远程信息处理辅助器具","信息交流"),
                new AssistiveDevice(10530,"阅读辅助器具","信息交流"),
                new AssistiveDevice(10533,"计算机和终端设备","信息交流"),
                new AssistiveDevice(10536,"计算机输入设备","信息交流"),
                new AssistiveDevice(10539,"计算机输出设备","信息交流"),

                new AssistiveDevice(1052721,"环境紧急报警系统","信息交流"),
                new AssistiveDevice(1050903,"语音发生器","信息交流"),
                new AssistiveDevice(1050906,"个人用语音放大器","信息交流"),
                new AssistiveDevice(1051503,"手动计算器","信息交流"),
                new AssistiveDevice(1051506,"计算设备","信息交流"),
                new AssistiveDevice(1051509,"计算软件","信息交流"),
                new AssistiveDevice(1051803,"声音记录和播放设备","信息交流"),
                new AssistiveDevice(1051806,"视频记录和播放设备","信息交流"),
                new AssistiveDevice(1051809,"无线电接收机","信息交流"),
                new AssistiveDevice(1051812,"双向无线对讲机","信息交流"),
                new AssistiveDevice(1051815,"电视机","信息交流"),
                new AssistiveDevice(1051818,"闭路电视系统","信息交流"),
                new AssistiveDevice(1051821,"图文和文本电视解码器","信息交流"),
                new AssistiveDevice(1051824,"无线电频率传输系统","信息交流"),
                new AssistiveDevice(1051827,"声音信息红外分析系统","信息交流"),
                new AssistiveDevice(1052103,"字母和符号卡、板","信息交流"),
                new AssistiveDevice(1052109,"对话装置","信息交流"),
                new AssistiveDevice(1052112,"面对面沟通用软件","信息交流"),
                new AssistiveDevice(1052403,"普通网络电话","信息交流"),
                new AssistiveDevice(1052406,"移动网络电话","信息交流"),
                new AssistiveDevice(1052409,"文本电话机","信息交流"),
                new AssistiveDevice(1052415,"电话应答机","信息交流"),
                new AssistiveDevice(1052418,"电话交换机","信息交流"),
                new AssistiveDevice(1052424,"远程交流和远程信息处理软件","信息交流"),
                new AssistiveDevice(1052427,"内部通话装置","信息交流"),
                new AssistiveDevice(1052430,"应门对讲电话","信息交流"),
                new AssistiveDevice(1052703,"视觉信号指示器","信息交流"),
                new AssistiveDevice(1052706,"声信号指示器","信息交流"),
                new AssistiveDevice(1052709,"机械信号指示器","信息交流"),
                new AssistiveDevice(1052712,"时钟和计时器","信息交流"),
                new AssistiveDevice(1052715,"日历和时间表","信息交流"),
                new AssistiveDevice(1052716,"帮助记忆的产品","信息交流"),
                new AssistiveDevice(1052718,"个人紧急报警系统","信息交流"),
                new AssistiveDevice(1052724,"监测和定位系统","信息交流"),
                new AssistiveDevice(1052727,"标识材料和标记工具","信息交流"),
                new AssistiveDevice(1053003,"带语音输出的阅读材料","信息交流"),
                new AssistiveDevice(1053006,"大号字体印刷的阅读材料","信息交流"),
                new AssistiveDevice(1053009,"多媒体阅读材料","信息交流"),
                new AssistiveDevice(1053012,"翻书器","信息交流"),
                new AssistiveDevice(1053015,"书支撑架和书固定架","信息交流"),
                new AssistiveDevice(1053021,"字符阅读器","信息交流"),
                new AssistiveDevice(1053018,"阅读框和版面限定器","信息交流"),
                new AssistiveDevice(1053024,"触摸阅读材料","信息交流"),
                new AssistiveDevice(1053027,"特殊多媒体演示软件","信息交流"),
                new AssistiveDevice(1053303,"台式计算机","信息交流"),
                new AssistiveDevice(1053306,"便携式计算机和个人数字助理（PDA）","信息交流"),
                new AssistiveDevice(1053309,"公共信息、交易终端","信息交流"),
                new AssistiveDevice(1053312,"操作软件","信息交流"),
                new AssistiveDevice(1053315,"浏览器软件和沟通软件","信息交流"),
                new AssistiveDevice(1053318,"用于计算机和网络的附件","信息交流"),
                new AssistiveDevice(1053603,"键盘","信息交流"),
                new AssistiveDevice(1053612,"替代输入设备","信息交流"),
                new AssistiveDevice(1053615,"输入配件","信息交流"),
                new AssistiveDevice(1053618,"输入软件","信息交流"),
                new AssistiveDevice(1053621,"定位屏幕指针和选择计算机显示器显示内容的辅助器具","信息交流"),
                new AssistiveDevice(1053904,"可视计算机显示器和配件","信息交流"),
                new AssistiveDevice(1053905,"盲文计算机显示器","信息交流"),
                new AssistiveDevice(1053906,"打印机","信息交流"),
                new AssistiveDevice(1053907,"可听计算机显示器","信息交流"),
                new AssistiveDevice(1053912,"特殊输出软件","信息交流"),

                new AssistiveDevice(105272101,"床旁呼叫器","信息交流"),
                new AssistiveDevice(105272102,"防溢报警器","信息交流"),
                new AssistiveDevice(105090301,"语言交流板","信息交流"),
                new AssistiveDevice(105090601,"个人用语音放大器","信息交流"),
                new AssistiveDevice(105150301,"易适盲人学习用算盘","信息交流"),
                new AssistiveDevice(105150601,"语音电子计算器","信息交流"),
                new AssistiveDevice(105150901,"语音计算软件","信息交流"),
                new AssistiveDevice(105180301,"听书机","信息交流"),
                new AssistiveDevice(105180601,"脑瘫儿童学习机","信息交流"),
                new AssistiveDevice(105180901,"智能收音机","信息交流"),
                new AssistiveDevice(105181201,"双向无线对讲机","信息交流"),
                new AssistiveDevice(105181501,"电视机","信息交流"),
                new AssistiveDevice(105181801,"闭路电视系统","信息交流"),
                new AssistiveDevice(105182101,"图文和文本电视解码器","信息交流"),
                new AssistiveDevice(105182401,"无线电频率传输系统","信息交流"),
                new AssistiveDevice(105182701,"声音信息红外分析系统","信息交流"),
                new AssistiveDevice(105210301,"盲人专用象棋","信息交流"),
                new AssistiveDevice(105210302,"盲人扑克","信息交流"),
                new AssistiveDevice(105210303,"低视力大字扑克","信息交流"),
                new AssistiveDevice(105210901,"双机有线对讲门铃","信息交流"),
                new AssistiveDevice(105210902,"单机有线对讲门铃","信息交流"),
                new AssistiveDevice(105210903,"无线对讲门铃","信息交流"),
                new AssistiveDevice(105210904,"USB 电脑手写交流板","信息交流"),
                new AssistiveDevice(105210905,"彩色手写交流板","信息交流"),
                new AssistiveDevice(105210906,"电子手写交流板","信息交流"),
                new AssistiveDevice(105210907,"E本通","信息交流"),
                new AssistiveDevice(105210908,"微电脑启智沟通仪（7寸）","信息交流"),
                new AssistiveDevice(105211201,"认知沟通程序","信息交流"),
                new AssistiveDevice(105211202,"言语沟通程序","信息交流"),
                new AssistiveDevice(105211203,"手语沟通程序","信息交流"),
                new AssistiveDevice(105240301, "盲人语音电话机", "信息交流"),
                new AssistiveDevice(105240302, "带盲文电话机", "信息交流"),
                new AssistiveDevice(105240303, "低视力大键盘电话", "信息交流"),
                new AssistiveDevice(105240304, "可视电话机", "信息交流"),
                new AssistiveDevice(105240601, "盲人用手机", "信息交流"),
                new AssistiveDevice(105240901, "普通图文电话机", "信息交流"),
                new AssistiveDevice(105240902, "盲文符号电话机", "信息交流"),
                new AssistiveDevice(105241501, "电话应答机", "信息交流"),
                new AssistiveDevice(105241801, "电话交换机", "信息交流"),
                new AssistiveDevice(105242401,"远程交流和远程信息处理软件","信息交流"),
                new AssistiveDevice(105242701, "内部通话装置", "信息交流"),
                new AssistiveDevice(105243001, "应门对讲电话", "信息交流"),
                new AssistiveDevice(105270301, "音乐闪光门铃", "信息交流"),
                new AssistiveDevice(105270302, "语音闪光门铃", "信息交流"),
                new AssistiveDevice(105270303, "普通闪光门铃", "信息交流"),
                new AssistiveDevice(105270304, "遥控闪光门铃", "信息交流"),
                new AssistiveDevice(105270601, "盲人点钞机", "信息交流"),
                new AssistiveDevice(105270602, "腕式全自动血压计", "信息交流"),
                new AssistiveDevice(105270603, "人体电子秤（语音）", "信息交流"),
                new AssistiveDevice(105270604, "手提电子秤（语音）", "信息交流"),
                new AssistiveDevice(105270605, "防溢报警器", "信息交流"),
                new AssistiveDevice(105270606, "语音提示器", "信息交流"),
                new AssistiveDevice(105270607, "语音数显体温计", "信息交流"),
                new AssistiveDevice(105270608, "臂式全自动血压计（语音）", "信息交流"),
                new AssistiveDevice(105270609, "智能家居安全预警套", "信息交流"),
                new AssistiveDevice(105270610, "音乐闪光燃气式报警壶", "信息交流"),
                new AssistiveDevice(105270611, "语音闪光电水壶", "信息交流"),
                new AssistiveDevice(105270612, "语音寻物器", "信息交流"),
                new AssistiveDevice(105270613, "微电脑语音养生机", "信息交流"),
                new AssistiveDevice(105270614, "音乐闪光电热式报警壶", "信息交流"),
                new AssistiveDevice(105270615, "语音指南针", "信息交流"),
                new AssistiveDevice(105270901, "盲人纸币识别器", "信息交流"),
                new AssistiveDevice(105270902, "多功能聋人手表", "信息交流"),
                new AssistiveDevice(105271201, "语音电子盲表", "信息交流"),
                new AssistiveDevice(105271202, "实用触摸盲表", "信息交流"),
                new AssistiveDevice(105271203, "计时器", "信息交流"),
                new AssistiveDevice(105271204, "震动闹钟", "信息交流"),
                new AssistiveDevice(105271205, "震动手表", "信息交流"),
                new AssistiveDevice(105271206, "智能定位手表", "信息交流"),
                new AssistiveDevice(105271501, "盲文日历板", "信息交流"),
                new AssistiveDevice(105271601, "帮助记忆的产品", "信息交流"),
                new AssistiveDevice(105271801, "呼叫器", "信息交流"),
                new AssistiveDevice(105272103, "水报警器", "信息交流"),
                new AssistiveDevice(105272401, "监测和定位系统", "信息交流"),
                new AssistiveDevice(105272701, "标识材料和标记工具", "信息交流"),
                new AssistiveDevice(105300301, "带语音输出的阅读材料", "信息交流"),
                new AssistiveDevice(105300601, "大号字体印刷的阅读材料", "信息交流"),
                new AssistiveDevice(105300901, "聋人计算机手语教材", "信息交流"),
                new AssistiveDevice(105300902, "聋人日常会话教材", "信息交流"),
                new AssistiveDevice(105300903, "聋人手语词汇教材", "信息交流"),
                new AssistiveDevice(105300904, "聋人手语视频培训教材", "信息交流"),
                new AssistiveDevice(105301201, "翻书器", "信息交流"),
                new AssistiveDevice(105301501, "便捷式书支撑架", "信息交流"),
                new AssistiveDevice(105301502, "便捷式书固定架", "信息交流"),
                new AssistiveDevice(105302101, "便携式多功能阅读器", "信息交流"),
                new AssistiveDevice(105302102, "智能语音认知地球仪（32cm)", "信息交流"),
                new AssistiveDevice(105302103, "语音点读认知地图套装（含点读笔）", "信息交流"),
                new AssistiveDevice(105302104, "智能中国电子语音地图", "信息交流"),
                new AssistiveDevice(105302105, "盲文显形器", "信息交流"),
                new AssistiveDevice(105302106, "一键式智能阅读器", "信息交流"),
                new AssistiveDevice(105302107, "点读机", "信息交流"),
                new AssistiveDevice(105301801, "阅读标尺", "信息交流"),
                new AssistiveDevice(105301802, "便捷式版面限定器", "信息交流"),
                new AssistiveDevice(105302401, "盲文教材", "信息交流"),
                new AssistiveDevice(105302701, "智力障碍者用多媒体输出软件", "信息交流"),
                new AssistiveDevice(105302702,"视觉障碍者用多媒体输出软件","信息交流"),
                new AssistiveDevice(105330301, "触摸式计算机", "信息交流"),
                new AssistiveDevice(105330302, "盲人用语音计算机", "信息交流"),
                new AssistiveDevice(105330601, "便携式计算机和个人数字助理（PDA）", "信息交流"),
                new AssistiveDevice(105330901, "公共信息、交易终端", "信息交流"),
                new AssistiveDevice(105331201, "操作软件", "信息交流"),
                new AssistiveDevice(105331501, "布莱叶读屏软件", "信息交流"),
                new AssistiveDevice(105331502, "阳光标准单机版软件", "信息交流"),
                new AssistiveDevice(105331801, "低视力用大字体键盘", "信息交流"),
                new AssistiveDevice(105331802, "特殊鼠标", "信息交流"),
                new AssistiveDevice(105331803, "手部辅助支架", "信息交流"),
                new AssistiveDevice(105360301, "盲人用键盘", "信息交流"),
                new AssistiveDevice(105360302, "大字键盘", "信息交流"),
                new AssistiveDevice(105361201, "手握式键盘敲击器", "信息交流"),
                new AssistiveDevice(105361202,"掌套式键盘敲击器","信息交流"),
                new AssistiveDevice(105361203, "腕套式键盘敲击器", "信息交流"),
                new AssistiveDevice(105361501, "输入配件", "信息交流"),
                new AssistiveDevice(105361801, "输入软件", "信息交流"),
                new AssistiveDevice(105362101, "大轨迹球鼠标", "信息交流"),
                new AssistiveDevice(105362102, "脚控鼠标", "信息交流"),
                new AssistiveDevice(105390401, "屏幕放大器", "信息交流"),
                new AssistiveDevice(105390501, "40 方点显器", "信息交流"),
                new AssistiveDevice(105390502, "80 方点显器", "信息交流"),
                new AssistiveDevice(105390601, "盲文打印机", "信息交流"),
                new AssistiveDevice(105390701, "可听计算机显示器", "信息交流"),
                new AssistiveDevice(105391201, "光标定位的屏幕放大程序", "信息交流"),
                #endregion
                
                #region 康复训练
                new AssistiveDevice(10636,"知觉训练辅助器具","康复训练"),
                new AssistiveDevice(10645,"脊柱牵引辅助器具","康复训练"),
                new AssistiveDevice(10648,"运动、肌力和平衡训练的设备","康复训练"),
                new AssistiveDevice(10703,"沟通治疗和沟通训练辅助器具","康复训练"),
                new AssistiveDevice(10706,"替代增强沟通训练辅助器具","康复训练"),
                new AssistiveDevice(10709,"失禁训练辅助器具","康复训练"),
                new AssistiveDevice(10712,"认知技能训练辅助器具","康复训练"),
                new AssistiveDevice(10715,"基本技能训练辅助器具","康复训练"),
                new AssistiveDevice(10718,"教育课程训练辅助器具","康复训练"),
                new AssistiveDevice(10724,"艺术训练辅助器具","康复训练"),
                new AssistiveDevice(10727,"社交技能训练辅助器具","康复训练"),
                new AssistiveDevice(10730,"输入器件及操作产品和货物的训练控制辅助器具","康复训练"),
                new AssistiveDevice(10733,"日常生活活动训练的辅助器具","康复训练"),

                new AssistiveDevice(1063603,"知觉辨别和知觉匹配训练辅助器具","康复训练"),
                new AssistiveDevice(1063606,"知觉协调训练辅助器具","康复训练"),
                new AssistiveDevice(1063609,"感觉统合训练辅助器具","康复训练"),
                new AssistiveDevice(1064503,"颈椎牵引器","康复训练"),
                new AssistiveDevice(1064506,"腰椎牵引器","康复训练"),
                new AssistiveDevice(1064803,"训练和功率自行车","康复训练"),
                new AssistiveDevice(1064807,"行走训练辅助器具","康复训练"),
                new AssistiveDevice(1064808,"站立架和站立支撑台","康复训练"),
                new AssistiveDevice(1064812,"手指和手训练器械","康复训练"),
                new AssistiveDevice(1064815,"上肢训练器械、躯干训练器械和下肢训练器械","康复训练"),
                new AssistiveDevice(1064818,"负荷环带","康复训练"),
                new AssistiveDevice(1064821,"斜面台","康复训练"),
                new AssistiveDevice(1064824,"运动、肌力和平衡训练的生物反馈仪器","康复训练"),
                new AssistiveDevice(1064827,"治疗期间身体定位辅助器具","康复训练"),
                new AssistiveDevice(1064830,"颚训练器具","康复训练"),
                new AssistiveDevice(1064831,"爬行训练辅助器具","康复训练"),
                new AssistiveDevice(1070303,"语言和言语训练辅助器具","康复训练"),
                new AssistiveDevice(1070306,"阅读技能开发训练材料","康复训练"),
                new AssistiveDevice(1070309,"书写技能开发训练材料","康复训练"),
                new AssistiveDevice(1070603,"手指拼读训练辅助器具","康复训练"),
                new AssistiveDevice(1070606,"手势语训练辅助器具","康复训练"),
                new AssistiveDevice(1070609,"唇读训练辅助器具","康复训练"),
                new AssistiveDevice(1070612,"提示语言训练辅助器具","康复训练"),
                new AssistiveDevice(1070615,"盲文训练辅助器具","康复训练"),
                new AssistiveDevice(1070618,"除盲文外其他可触摸符号训练辅助器具","康复训练"),
                new AssistiveDevice(1070621,"图标和符号训练辅助器具","康复训练"),
                new AssistiveDevice(1070624,"布里斯语言沟通训练辅助器具","康复训练"),
                new AssistiveDevice(1070627,"图片和绘画沟通训练辅助器具","康复训练"),
                new AssistiveDevice(1070630,"莫尔斯电码沟通训练辅助器具","康复训练"),
                new AssistiveDevice(1070903,"失禁报警器","康复训练"),
                new AssistiveDevice(1071203,"记忆训练辅助器具","康复训练"),
                new AssistiveDevice(1071206,"排序训练辅助器具","康复训练"),
                new AssistiveDevice(1071209,"注意力训练辅助器具","康复训练"),
                new AssistiveDevice(1071212,"概念启发训练辅助器具","康复训练"),
                new AssistiveDevice(1071215,"分类训练辅助器具","康复训练"),
                new AssistiveDevice(1071218,"训练解决问题的辅助器具","康复训练"),
                new AssistiveDevice(1071221,"归纳（演绎）推理训练辅助器具","康复训练"),
                new AssistiveDevice(1071224,"因果关系启发理解辅助器具","康复训练"),
                new AssistiveDevice(1071503,"早期计算训练辅助器具","康复训练"),
                new AssistiveDevice(1071506,"编码和解码书写语言辅助器具","康复训练"),
                new AssistiveDevice(1071509,"时间理解训练辅助器具","康复训练"),
                new AssistiveDevice(1071512,"货币理解训练辅助器具","康复训练"),
                new AssistiveDevice(1071515,"度量衡理解训练辅助器具","康复训练"),
                new AssistiveDevice(1071518,"基本几何技巧训练辅助器具","康复训练"),
                new AssistiveDevice(1071803,"母语训练辅助器具","康复训练"),
                new AssistiveDevice(1071806,"外语训练辅助器具","康复训练"),
                new AssistiveDevice(1071809,"人文科学课程训练辅助器具","康复训练"),
                new AssistiveDevice(1071812,"社会科学课程训练辅助器具","康复训练"),
                new AssistiveDevice(1071815,"数学和物理课程训练辅助器具","康复训练"),
                new AssistiveDevice(1072403,"音乐技能训练辅助器具","康复训练"),
                new AssistiveDevice(1072406,"绘图和绘画技能训练辅助器具","康复训练"),
                new AssistiveDevice(1072409,"戏剧和舞蹈训练辅助器具","康复训练"),
                new AssistiveDevice(1072703,"休闲娱乐活动训练辅助器具","康复训练"),
                new AssistiveDevice(1072706,"社会行为训练辅助器具","康复训练"),
                new AssistiveDevice(1072709,"个人安全训练辅助器具","康复训练"),
                new AssistiveDevice(1072712,"旅行训练辅助器具","康复训练"),
                new AssistiveDevice(1073003,"鼠标控制训练辅助器具","康复训练"),
                new AssistiveDevice(1073006,"操纵杆操纵训练辅助器具","康复训练"),
                new AssistiveDevice(1073009,"开关控制训练辅助器具","康复训练"),
                new AssistiveDevice(1073012,"打字训练辅助器具","康复训练"),
                new AssistiveDevice(1073015,"选择技能训练辅助器具","康复训练"),
                new AssistiveDevice(1073303,"矫形器和假肢使用训练辅助器具","康复训练"),
                new AssistiveDevice(1073306,"个人日常活动训练辅助器具","康复训练"),
                new AssistiveDevice(1073312,"家务训练辅助器具","康复训练"),

                new AssistiveDevice(106360301,"语言训练仪","康复训练"),
                new AssistiveDevice(106360302,"宣泄情绪、协调身体机能训练仪","康复训练"),
                new AssistiveDevice(106360303, "音乐振动椅", "康复训练"),
                new AssistiveDevice(106360304,"足底触觉训练垫","康复训练"),
                new AssistiveDevice(106360305, "嗅觉训练盒", "康复训练"),
                new AssistiveDevice(106360601, "眼手协调穿线游戏软件", "康复训练"),
                new AssistiveDevice(106360901, "插棍", "康复训练"),
                new AssistiveDevice(106360902, "独脚椅", "康复训练"),
                new AssistiveDevice(106360903, "跳跳床", "康复训练"),
                new AssistiveDevice(106360904,"S 形平衡木","康复训练"),
                new AssistiveDevice(106360905, "羊角球", "康复训练"),
                new AssistiveDevice(106360906, "平衡台", "康复训练"),
                new AssistiveDevice(106360907, "圆筒吊缆", "康复训练"),
                new AssistiveDevice(106360908, "圆木马吊缆", "康复训练"),
                new AssistiveDevice(106360909, "四角晃动平衡板", "康复训练"),
                new AssistiveDevice(106360910,"晃动平衡木","康复训练"),
                new AssistiveDevice(106360911, "趴地推球", "康复训练"),
                new AssistiveDevice(106360912,"滑板爬","康复训练"),
                new AssistiveDevice(106360913, "滑梯", "康复训练"),
                new AssistiveDevice(106450301, "颈椎牵引器", "康复训练"),
                new AssistiveDevice(106450601, "腰椎牵引器", "康复训练"),
                new AssistiveDevice(106480301, "坐式功率自行车", "康复训练"),
                new AssistiveDevice(106480302, "立式功率自行车", "康复训练"),
                new AssistiveDevice(106480701, "减重步行训练器", "康复训练"),
                new AssistiveDevice(106480702, "步行训练用平行杠和行走支撑台", "康复训练"),
                new AssistiveDevice(106480703, "步行阶梯", "康复训练"),
                new AssistiveDevice(106480801, "儿童用直立式站立架", "康复训练"),
                new AssistiveDevice(106480802, "儿童用仰卧式站立架", "康复训练"),
                new AssistiveDevice(106480803, "儿童用俯卧式站立架", "康复训练"),
                new AssistiveDevice(106480804, "成人用直立型站立架", "康复训练"),
                new AssistiveDevice(106480805, "成人用仰卧式站立架", "康复训练"),
                new AssistiveDevice(106480806, "成人用俯卧式站立架", "康复训练"),
                new AssistiveDevice(106481201, "重锤式手指肌力训练桌", "康复训练"),
                new AssistiveDevice(106481202, "分指器", "康复训练"),
                new AssistiveDevice(106481501, "上肢综合训练器", "康复训练"),
                new AssistiveDevice(106481502, "上肢拉力器", "康复训练"),
                new AssistiveDevice(106481503,"训练球","康复训练"),
                new AssistiveDevice(106481504, "上肢诱导运动训练器", "康复训练"),
                new AssistiveDevice(106481505,"腕关节旋转训练器","康复训练"),
                new AssistiveDevice(106481506,"前臂内外旋运动器","康复训练"),
                new AssistiveDevice(106481507, "肘关节运动器", "康复训练"),
                new AssistiveDevice(106481508, "肩关节运动器", "康复训练"),
                new AssistiveDevice(106481509, "下肢综合训练器", "康复训练"),
                new AssistiveDevice(106481510, "踝关节训练器", "康复训练"),
                new AssistiveDevice(106481511, "膝关节运动器", "康复训练"),
                new AssistiveDevice(106481512, "髋关节运动器", "康复训练"),
                new AssistiveDevice(106481513,"综合步态训练器","康复训练"),
                new AssistiveDevice(106481514, "起立训练器", "康复训练"),
                new AssistiveDevice(106481515,"复合全身运动装置","康复训练"),
                new AssistiveDevice(106481516, "滑车重锤运动器", "康复训练"),
                new AssistiveDevice(106481517, "躯干运动器", "康复训练"),
                new AssistiveDevice(106481518, "肋木", "康复训练"),
                new AssistiveDevice(106481519, "梯背椅", "康复训练"),
                new AssistiveDevice(106481520, "训练床", "康复训练"),
                new AssistiveDevice(106481801, "绑式系列沙袋", "康复训练"),
                new AssistiveDevice(106482101, "手摇站立床", "康复训练"),
                new AssistiveDevice(106482102, "电动站立床", "康复训练"),
                new AssistiveDevice(106482401, "平衡功能检测训练系统", "康复训练"),
                new AssistiveDevice(106482402, "划船器", "康复训练"),
                new AssistiveDevice(106482701, "手动治疗台", "康复训练"),
                new AssistiveDevice(106483001, "颚训练器具", "康复训练"),
                new AssistiveDevice(106483101, "儿童爬行架", "康复训练"),
                new AssistiveDevice(107030301, "发音训练卡片", "康复训练"),
                new AssistiveDevice(107030302, "语言障碍治疗仪", "康复训练"),
                new AssistiveDevice(107030303, "发声呼气训练仪", "康复训练"),
                new AssistiveDevice(107030304,"发声吸气训练仪","康复训练"),
                new AssistiveDevice(107030601, "阅读技能开发训练材料", "康复训练"),
                new AssistiveDevice(107030901, "学前运笔练习", "康复训练"),
                new AssistiveDevice(107030902,"手功能障碍者握笔器 * ","康复训练"),
                new AssistiveDevice(107060301, "手指字母表", "康复训练"),
                new AssistiveDevice(107060302, "《中国手语》", "康复训练"),
                new AssistiveDevice(107060601, "手势语训练辅助器具", "康复训练"),
                new AssistiveDevice(107060901, "唇语图片", "康复训练"),
                new AssistiveDevice(107061201, "提示语言训练辅助器具", "康复训练"),
                new AssistiveDevice(107061501, "点字学习板", "康复训练"),
                new AssistiveDevice(107061801, "触摸训练用符号和图形", "康复训练"),
                new AssistiveDevice(107062101, "图标和符号训练辅助器具", "康复训练"),
                new AssistiveDevice(107062401,"布里斯语言沟通训练辅助器具","康复训练"),
                new AssistiveDevice(107062701,"图片和绘画沟通训练辅助器具","康复训练"),
                new AssistiveDevice(107063001, "莫尔斯码输入软件", "康复训练"),
                new AssistiveDevice(107063002,"六键式莫尔斯码输入键盘","康复训练"),
                new AssistiveDevice(107090301, "尿失禁报警器", "康复训练"),
                new AssistiveDevice(107090302, "排便失禁报警器", "康复训练"),
                new AssistiveDevice(107090303, "大小便失禁报警器", "康复训练"),
                new AssistiveDevice(107120301, "认知技能训练程序", "康复训练"),
                new AssistiveDevice(107120302, "记忆游戏组", "康复训练"),
                new AssistiveDevice(107120601, "顺序图片", "康复训练"),
                new AssistiveDevice(107120901, "火车积木", "康复训练"),
                new AssistiveDevice(107120902, "儿童图形认知组件", "康复训练"),
                new AssistiveDevice(107120903, "数字套塔", "康复训练"),
                new AssistiveDevice(107120904, "阶梯对比积木", "康复训练"),
                new AssistiveDevice(107120905, "台式智力拨钟", "康复训练"),
                new AssistiveDevice(107120906, "几何套圈", "康复训练"),
                new AssistiveDevice(107120907, "认知拼装图片", "康复训练"),
                new AssistiveDevice(107120908, "日本切切看", "康复训练"),
                new AssistiveDevice(107120909, "形状盒", "康复训练"),
                new AssistiveDevice(107120910, "积木车", "康复训练"),
                new AssistiveDevice(107120911, "多变型装拆组合", "康复训练"),
                new AssistiveDevice(107120912, "几何插板", "康复训练"),
                new AssistiveDevice(107120913, "彩虹套塔", "康复训练"),
                new AssistiveDevice(107120914, "双面智力计算架", "康复训练"),
                new AssistiveDevice(107120915, "1+1计算架", "康复训练"),
                new AssistiveDevice(107120916, "智力串珠盒", "康复训练"),
                new AssistiveDevice(107120917, "《找找看哪里不一样彩色卡片》", "康复训练"),
                new AssistiveDevice(107121201, "组合形状板", "康复训练"),
                new AssistiveDevice(107121501, "形状与颜色分类卡片", "康复训练"),
                new AssistiveDevice(107121801, "问题解决积木", "康复训练"),
                new AssistiveDevice(107121802, "问题解决连续图片", "康复训练"),
                new AssistiveDevice(107122101, "归纳", "康复训练"),
                new AssistiveDevice(107122102, "演绎图片卡", "康复训练"),
                new AssistiveDevice(107122401, "因果关系图卡", "康复训练"),
                new AssistiveDevice(107150301,"学习数学拼图版、《数学超级市场游戏》软件","康复训练"),
                new AssistiveDevice(107150601, "木制带磁条字母板", "康复训练"),
                new AssistiveDevice(107150901, "积木时钟拼图版", "康复训练"),
                new AssistiveDevice(107150902,"时间技能训练程序","康复训练"),
                new AssistiveDevice(107151201, "钱币纸钞组合", "康复训练"),
                new AssistiveDevice(107151501, "盲用点字尺及量角器组合", "康复训练"),
                new AssistiveDevice(107151801, "几何图形配对卡片", "康复训练"),
                new AssistiveDevice(107180301,"带有汉语拼音和汉字的生活小图卡","康复训练"),
                new AssistiveDevice(107180601, "字母树图卡", "康复训练"),
                new AssistiveDevice(107180901, "《人文教育丛书》", "康复训练"),
                new AssistiveDevice(107181201,"社会科学课程训练辅助器具","康复训练"),
                new AssistiveDevice(107181501, "《科学启蒙》（小学二年级）", "康复训练"),
                new AssistiveDevice(107240301, "感觉治疗乐器组合", "康复训练"),
                new AssistiveDevice(107240601, "《儿童学画大全》", "康复训练"),
                new AssistiveDevice(107240901, "戏剧和舞蹈训练辅助器具", "康复训练"),
                new AssistiveDevice(107270301, "坐式排球训练教具", "康复训练"),
                new AssistiveDevice(107270601, "社会行为训练辅助器具", "康复训练"),
                new AssistiveDevice(107270901, "个人安全训练辅助器具", "康复训练"),
                new AssistiveDevice(107271201, "中华人民共和国语音地图", "康复训练"),
                new AssistiveDevice(107300301, "智力障碍者鼠标训练程", "康复训练"),
                new AssistiveDevice(107300601, "操纵杆游戏软件", "康复训练"),
                new AssistiveDevice(107300901, "训练控制开关的软件", "康复训练"),
                new AssistiveDevice(107301201,"视觉障碍者和智力障碍者打字训练程序","康复训练"),
                new AssistiveDevice(107301202,"肢体障碍者五指打字指导程序","康复训练"),
                new AssistiveDevice(107301501, "看图选择训练软件", "康复训练"),
                new AssistiveDevice(107330301,"矫形器和假肢使用训练辅助器具","康复训练"),
                new AssistiveDevice(107330601, "穿袜子架", "康复训练"),
                new AssistiveDevice(107330602, "长把鞋拔子", "康复训练"),
                new AssistiveDevice(107330603,"拿牙刷辅具","康复训练"),
                new AssistiveDevice(107330604, "训练拧湿毛巾辅具", "康复训练"),
                new AssistiveDevice(107331201, "炊事用具使用训练器具", "康复训练"),
                new AssistiveDevice(107331202,"饮食用具使用训练器具","康复训练"),
                new AssistiveDevice(107331203,"清扫用具使用训练器具","康复训练"),
                new AssistiveDevice(107331204, "家庭缝纫使用训练器具", "康复训练"),
                #endregion
                
                #region 防护功能
                new AssistiveDevice(10603,"呼吸辅助器具","防护功能"),
                new AssistiveDevice(10606,"循环治疗辅助器具","防护功能"),
                new AssistiveDevice(10607,"预防瘢痕形成的辅助器具","防护功能"),
                new AssistiveDevice(10608,"身体控制和促进血液循环的压力衣","防护功能"),
                new AssistiveDevice(10609,"光疗辅助器具","防护功能"),
                new AssistiveDevice(10624,"身体、生理和生化检测设备及材料","防护功能"),
                new AssistiveDevice(10625,"认知测试和评估材料","防护功能"),
                new AssistiveDevice(10627,"刺激器","防护功能"),
                new AssistiveDevice(10630,"热疗或冷疗辅助器具","防护功能"),
                new AssistiveDevice(10633,"保护组织完整性的辅助器具","防护功能"),

                new AssistiveDevice(1060303,"吸入气体的预处理器","防护功能"),
                new AssistiveDevice(1060306,"吸入器","防护功能"),
                new AssistiveDevice(1060312,"呼吸罩","防护功能"),
                new AssistiveDevice(1060318,"供氧器","防护功能"),
                new AssistiveDevice(1060321,"吸引器","防护功能"),
                new AssistiveDevice(1060327,"呼吸肌训练器","防护功能"),
                new AssistiveDevice(1060330,"呼吸计量器","防护功能"),
                new AssistiveDevice(1060606,"用于上肢、下肢和身体其他部位的抗水肿袜套","防护功能"),
                new AssistiveDevice(1060609,"治疗血液循环障碍的充气服和加压装置","防护功能"),
                new AssistiveDevice(1060703,"自粘性硅胶片","防护功能"),
                new AssistiveDevice(1060706,"弹力衣","防护功能"),
                new AssistiveDevice(1060803,"静脉曲张袜","防护功能"),
                new AssistiveDevice(1060903,"紫外线A 段（UVA）灯","防护功能"),
                new AssistiveDevice(1060906,"可选的紫外线光疗法（SUP）和紫外线B 段（UVB）灯","防护功能"),
                new AssistiveDevice(1060909,"光疗护目镜","防护功能"),
                new AssistiveDevice(1062409,"血压计","防护功能"),
                new AssistiveDevice(1062412,"血液分析器械、设备和材料","防护功能"),
                new AssistiveDevice(1062418,"身体检查和评价材料","防护功能"),
                new AssistiveDevice(1062421,"人体物理和生理特性的测量辅助器具","防护功能"),
                new AssistiveDevice(1062424,"体温计","防护功能"),
                new AssistiveDevice(1062427,"体重秤","防护功能"),
                new AssistiveDevice(1062430,"测量皮肤状况的辅助器具","防护功能"),
                new AssistiveDevice(1062503,"语言测试和评估材料","防护功能"),
                new AssistiveDevice(1062506,"心理测试和评估材料","防护功能"),
                new AssistiveDevice(1062509,"教育能力测试和评估材料","防护功能"),
                new AssistiveDevice(1062706,"减痛刺激器","防护功能"),
                new AssistiveDevice(1062709,"肌肉刺激器( 不作矫形器用)","防护功能"),
                new AssistiveDevice(1062712,"振动器","防护功能"),
                new AssistiveDevice(1062715,"声音刺激器","防护功能"),
                new AssistiveDevice(1062718,"刺激感觉和灵敏度的辅助器具","防护功能"),
                new AssistiveDevice(1062721,"刺激细胞生长的辅助器具","防护功能"),
                new AssistiveDevice(1063003,"热疗辅助器具","防护功能"),
                new AssistiveDevice(1063006,"冷疗辅助器具","防护功能"),
                new AssistiveDevice(1063303,"保护组织完整性的座垫和衬垫","防护功能"),
                new AssistiveDevice(1063304,"保护组织完整性的靠背垫和小靠背垫","防护功能"),
                new AssistiveDevice(1063306,"保护组织完整性的躺卧辅助器具","防护功能"),
                new AssistiveDevice(1063309,"保护组织完整性的特殊设备","防护功能"),

                new AssistiveDevice(106030301,"预热吸入气体装置","防护功能"),
                new AssistiveDevice(106030601,"雾化吸入器","防护功能"),
                new AssistiveDevice(106030602,"中药雾化吸入器","防护功能"),
                new AssistiveDevice(106030603,"一次性雾化吸入器","防护功能"),
                new AssistiveDevice(106031201,"防烟呼吸罩","防护功能"),
                new AssistiveDevice(106031801,"家用氧气瓶","防护功能"),
                new AssistiveDevice(106031802,"便携式供氧器","防护功能"),
                new AssistiveDevice(106031803,"供氧器箱","防护功能"),
                new AssistiveDevice(106032101,"电动吸痰器","防护功能"),
                new AssistiveDevice(106032102,"手动吸痰器","防护功能"),
                new AssistiveDevice(106032103,"脚踏吸痰器","防护功能"),
                new AssistiveDevice(106032701,"手持式呼吸肌训练器","防护功能"),
                new AssistiveDevice(106032702,"膈肌阻力训练器","防护功能"),
                new AssistiveDevice(106032703,"吸气阻力训练器","防护功能"),
                new AssistiveDevice(106032704,"诱发呼吸训练器","防护功能"),
                new AssistiveDevice(106033001,"肺活量电子测量仪","防护功能"),
                new AssistiveDevice(106060601,"抗水肿袜套","防护功能"),
                new AssistiveDevice(106060901,"充气压力服","防护功能"),
                new AssistiveDevice(106070301,"自粘性硅胶片","防护功能"),
                new AssistiveDevice(106070601,"烧伤衣","防护功能"),
                new AssistiveDevice(106080301,"小腿静脉曲张袜","防护功能"),
                new AssistiveDevice(106080302,"大腿静脉曲张袜","防护功能"),
                new AssistiveDevice(106090301,"紫外线A 段灯315nm、","防护功能"),
                new AssistiveDevice(106090302,"紫外线A 段灯340nm","防护功能"),
                new AssistiveDevice(106090303, "紫外线A 段灯365nm", "防护功能"),
                new AssistiveDevice(106090304,"紫外线A 段灯385nm","防护功能"),
                new AssistiveDevice(106090305,"紫外线A 段灯400nm","防护功能"),
                new AssistiveDevice(106090601, "紫外线B 段灯280nm", "防护功能"),
                new AssistiveDevice(106090901, "UV 护目镜", "防护功能"),
                new AssistiveDevice(106240901, "语音电子血压计", "防护功能"),
                new AssistiveDevice(106241201, "血糖仪", "防护功能"),
                new AssistiveDevice(106241801, "手肌力测量仪", "防护功能"),
                new AssistiveDevice(106242101,"人体物理和生理特性的测量辅助器具","防护功能"),
                new AssistiveDevice(106242401, "语音体温计", "防护功能"),
                new AssistiveDevice(106242701, "语音体重秤", "防护功能"),
                new AssistiveDevice(106243001, "测量皮肤状况的辅助器具", "防护功能"),
                new AssistiveDevice(106250301,"失语症计算机评测与治疗系统软件 * ","防护功能"),
                new AssistiveDevice(106250601, "康复医学心理测验系统软件", "防护功能"),
                new AssistiveDevice(106250901, "韦氏智力量表", "防护功能"),
                new AssistiveDevice(106270601, "吸力型低频刺激仪（减痛仪", "防护功能"),
                new AssistiveDevice(106270901, "肌肉刺激仪", "防护功能"),
                new AssistiveDevice(106271201, "振动排痰机", "防护功能"),
                new AssistiveDevice(106271501, "声音刺激器", "防护功能"),
                new AssistiveDevice(106271801,"刺激感觉和灵敏度的辅助器具","防护功能"),
                new AssistiveDevice(106272101, "刺激细胞生长的辅助器具", "防护功能"),
                new AssistiveDevice(106300301, "红外线灯", "防护功能"),
                new AssistiveDevice(106300601, "二氧化碳激光治疗仪", "防护功能"),
                new AssistiveDevice(106300602, "冷敷袋", "防护功能"),
                new AssistiveDevice(106330301, "普通海绵防压疮坐垫", "防护功能"),
                new AssistiveDevice(106330302, "慢回弹海绵防压疮坐垫", "防护功能"),
                new AssistiveDevice(106330303, "液体凝胶防压疮坐垫", "防护功能"),
                new AssistiveDevice(106330304, "固体凝胶防压疮坐垫", "防护功能"),
                new AssistiveDevice(106330305, "塑料充气防压疮坐垫", "防护功能"),
                new AssistiveDevice(106330306, "橡胶充气防压疮坐垫", "防护功能"),
                new AssistiveDevice(106330307, "凝胶海绵复合防压疮坐垫", "防护功能"),
                new AssistiveDevice(106330308, "四气室防压疮坐垫", "防护功能"),
                new AssistiveDevice(106330401, "体位变换组合垫", "防护功能"),
                new AssistiveDevice(106330402, "楔形垫", "防护功能"),
                new AssistiveDevice(106330601, "手动PVC充气防压疮床垫", "防护功能"),
                new AssistiveDevice(106330602, "电动PVC充气防压疮床垫", "防护功能"),
                new AssistiveDevice(106330603, "记忆海绵防压疮床垫", "防护功能"),
                new AssistiveDevice(106330604, "手动橡胶充气防压疮床垫", "防护功能"),
                new AssistiveDevice(106330605, "电动橡胶充气防压疮床垫", "防护功能"),
                new AssistiveDevice(106330606, "凝胶海绵复合防压疮床垫", "防护功能"),
                new AssistiveDevice(106330901, "压力测量床垫", "防护功能"),
                new AssistiveDevice(106330902, "防褥疮喷气床垫", "防护功能"),
                #endregion
                
                #region 无障碍环境
                new AssistiveDevice(10420,"无障碍改造","无障碍环境"),
                new AssistiveDevice(10433,"家庭和其他场所的安全设施","无障碍环境"),
                new AssistiveDevice(10903,"改善环境辅助器具","无障碍环境"),

                new AssistiveDevice(1042001,"无障碍改造","无障碍环境"),
                new AssistiveDevice(1043315,"地面用触感材料","无障碍环境"),
                new AssistiveDevice(1090309,"降低噪音的辅助器具","无障碍环境"),
                new AssistiveDevice(1090312,"减小振动的辅助器具","无障碍环境"),
                new AssistiveDevice(1090315,"照明控制辅助器具","无障碍环境"),
                new AssistiveDevice(1090318,"水净化器和软化器","无障碍环境"),

                new AssistiveDevice(104200101,"门的改造","无障碍环境"),
                new AssistiveDevice(104200102,"卫生间改造","无障碍环境"),
                new AssistiveDevice(104331501,"地面盲道砖","无障碍环境"),
                new AssistiveDevice(104331502,"转角防护垫","无障碍环境"),
                new AssistiveDevice(104331503,"墙壁防护板","无障碍环境"),
                new AssistiveDevice(109030901, "噪音吸收器", "无障碍环境"),
                new AssistiveDevice(109030902, "噪音吸收板", "无障碍环境"),
                new AssistiveDevice(109030903, "隔音板", "无障碍环境"),
                new AssistiveDevice(109031201, "减震器", "无障碍环境"),
                new AssistiveDevice(109031202, "减震垫", "无障碍环境"),
                new AssistiveDevice(109031501, "照明控制辅助器具", "无障碍环境"),
                new AssistiveDevice(109031801, "水净化器", "无障碍环境"),
                new AssistiveDevice(109031802, "水软化器", "无障碍环境"),
                #endregion

                #region 操作和使用
                new AssistiveDevice(10806,"操作容器的辅助器具","操作和使用"),
                new AssistiveDevice(10809,"操控设备的辅助器具","操作和使用"),
                new AssistiveDevice(10813,"远程控制辅助器具","操作和使用"),
                new AssistiveDevice(10818,"协助或代替臂、手或手指功能或他们组合功能的辅助器具","操作和使用"),
                new AssistiveDevice(10821,"延伸取物辅助器具","操作和使用"),
                new AssistiveDevice(10824,"定位辅助器具","操作和使用"),
                new AssistiveDevice(10827,"固定用辅助器具","操作和使用"),
                new AssistiveDevice(10836,"搬运和运输辅助器具","操作和使用"),
                new AssistiveDevice(11103,"工作场所的家具和装饰元素","操作和使用"),
                new AssistiveDevice(11112,"工作场所固定、探取、抓握物品的辅助器具","操作和使用"),
                new AssistiveDevice(11124,"工作场所健康保护和安全的辅助器具","操作和使用"),
                new AssistiveDevice(11203,"玩耍辅助器具","操作和使用"),
                new AssistiveDevice(11209,"运动辅助器具","操作和使用"),
                new AssistiveDevice(11218,"手工工艺工具、材料和设备","操作和使用"),

                new AssistiveDevice(1080603,"开启器","操作和使用"),
                new AssistiveDevice(1080606,"挤管器","操作和使用"),
                new AssistiveDevice(1080903,"按钮","操作和使用"),
                new AssistiveDevice(1080906,"固定把手和固定球形手柄","操作和使用"),
                new AssistiveDevice(1080909,"旋转把手和旋转球形手柄","操作和使用"),
                new AssistiveDevice(1080912,"脚踏板（机械）","操作和使用"),
                new AssistiveDevice(1080915,"手轮和曲柄把手","操作和使用"),
                new AssistiveDevice(1080918,"电器开关","操作和使用"),
                new AssistiveDevice(1080924,"配电盘","操作和使用"),
                new AssistiveDevice(1080928,"可调电源","操作和使用"),
                new AssistiveDevice(1080930,"定时开关","操作和使用"),
                new AssistiveDevice(1081303,"环境控制系统","操作和使用"),
                new AssistiveDevice(1081306,"个人环境控制软件","操作和使用"),
                new AssistiveDevice(1081803,"抓握装置","操作和使用"),
                new AssistiveDevice(1081806,"握持适配件和附件","操作和使用"),
                new AssistiveDevice(1081809,"穿戴式抓握器","操作和使用"),
                new AssistiveDevice(1081812,"物品稳定器","操作和使用"),
                new AssistiveDevice(1081815,"操纵杆","操作和使用"),
                new AssistiveDevice(1081818,"指向灯","操作和使用"),
                new AssistiveDevice(1081821,"送纸夹","操作和使用"),
                new AssistiveDevice(1081824,"手稿夹持架","操作和使用"),
                new AssistiveDevice(1081827,"手工活动用的前臂支撑托","操作和使用"),
                new AssistiveDevice(1081828,"剪刀类","操作和使用"),
                new AssistiveDevice(1082103,"手动抓取钳","操作和使用"),
                new AssistiveDevice(1082109,"无抓握功能的延伸器","操作和使用"),
                new AssistiveDevice(1082403,"固定位置系统","操作和使用"),
                new AssistiveDevice(1082406,"转动和滑动系统","操作和使用"),
                new AssistiveDevice(1082409,"升降和倾斜系统","操作和使用"),
                new AssistiveDevice(1082703,"吸盘","操作和使用"),
                new AssistiveDevice(1082706,"防滑垫","操作和使用"),
                new AssistiveDevice(1082712,"夹子和弹簧夹","操作和使用"),
                new AssistiveDevice(1082718,"磁铁、磁条和磁夹","操作和使用"),
                new AssistiveDevice(1083603,"搬运辅助器具","操作和使用"),
                new AssistiveDevice(1083606,"脚轮装置","操作和使用"),
                new AssistiveDevice(1083609,"行李车和购物推车","操作和使用"),
                new AssistiveDevice(1083615,"与自行车或轮椅一起使用的运输辅助器具","操作和使用"),
                new AssistiveDevice(1110303,"工作桌","操作和使用"),
                new AssistiveDevice(1110306,"作业台","操作和使用"),
                new AssistiveDevice(1110312,"工作场所用高脚凳和站立辅助器具","操作和使用"),
                new AssistiveDevice(1110318,"工作场所用垫子","操作和使用"),
                new AssistiveDevice(1111203,"运送和夹持工件和工具的辅助器具","操作和使用"),
                new AssistiveDevice(1111206,"固定和定位工件和工具的辅助器具","操作和使用"),
                new AssistiveDevice(1112403,"工作场所个人防护设备","操作和使用"),
                new AssistiveDevice(1112418,"工作场所及工作周围区域的安全设备","操作和使用"),
                new AssistiveDevice(1120303,"玩具","操作和使用"),
                new AssistiveDevice(1120309,"游戏用具","操作和使用"),
                new AssistiveDevice(1120903,"团队球类运动辅助器具","操作和使用"),
                new AssistiveDevice(1120906,"箭术辅助器具","操作和使用"),
                new AssistiveDevice(1120909,"划船辅助器具","操作和使用"),
                new AssistiveDevice(1120912,"保龄球辅助器具","操作和使用"),
                new AssistiveDevice(1120918,"击剑辅助器具","操作和使用"),
                new AssistiveDevice(1120927,"球拍和球板类运动辅助器具","操作和使用"),
                new AssistiveDevice(1120930,"射击辅助器具","操作和使用"),
                new AssistiveDevice(1120933,"游泳和水上运动辅助器具","操作和使用"),
                new AssistiveDevice(1120936,"冬季运动辅助器具","操作和使用"),
                new AssistiveDevice(1120939,"其它运动辅助器具","操作和使用"),
                new AssistiveDevice(1121803,"纺织手工艺工具、材料和设备","操作和使用"),
                new AssistiveDevice(1121806,"制陶工艺工具、材料和设备","操作和使用"),
                new AssistiveDevice(1121809,"木工工艺工具、材料和设备","操作和使用"),
                new AssistiveDevice(1121812,"金属加工工具、材料和设备","操作和使用"),
                new AssistiveDevice(1121815,"图案设计工具、材料和设备","操作和使用"),
                new AssistiveDevice(1121818,"其它材料的手工工艺的工具、材料和设备","操作和使用"),

                new AssistiveDevice(108060301,"开瓶器","操作和使用"),
                new AssistiveDevice(108060601,"自动牙膏挤压器","操作和使用"),
                new AssistiveDevice(108090301,"按钮式水龙头","操作和使用"),
                new AssistiveDevice(108090601,"塑料固定把手","操作和使用"),
                new AssistiveDevice(108090602,"塑料球形手柄","操作和使用"),
                new AssistiveDevice(108090901,"L型门把手","操作和使用"),
                new AssistiveDevice(108090902,"万能把手","操作和使用"),
                new AssistiveDevice(108091201,"单足自行车脚踏板","操作和使用"),
                new AssistiveDevice(108091202,"脚踏气泵","操作和使用"),
                new AssistiveDevice(108091501,"手轮和曲柄把手","操作和使用"),
                new AssistiveDevice(108091801,"声光延时开关","操作和使用"),
                new AssistiveDevice(108091802,"眼控开关","操作和使用"),
                new AssistiveDevice(108092401,"配电盘","操作和使用"),
                new AssistiveDevice(108092801,"可调电源","操作和使用"),
                new AssistiveDevice(108093001,"震动提醒定时器","操作和使用"),
                new AssistiveDevice(108130301,"信号警示系统","操作和使用"),
                new AssistiveDevice(108130302,"环境控制装置","操作和使用"),
                new AssistiveDevice(108130601,"环境控制装置程序","操作和使用"),
                new AssistiveDevice(108180301,"万能袖带","操作和使用"),
                new AssistiveDevice(108180601,"执笔辅助器","操作和使用"),
                new AssistiveDevice(108180602,"笔握持器","操作和使用"),
                new AssistiveDevice(108180901,"电话听筒抓握器","操作和使用"),
                new AssistiveDevice(108181201,"杯子稳定器","操作和使用"),
                new AssistiveDevice(108181202,"盲人用盒装大头针","操作和使用"),
                new AssistiveDevice(108181203,"大耳杯架","操作和使用"),
                new AssistiveDevice(108181204,"掌套式杯架","操作和使用"),
                new AssistiveDevice(108181501,"头部控制杆","操作和使用"),
                new AssistiveDevice(108181502,"口含器","操作和使用"),
                new AssistiveDevice(108181801,"头部指向灯","操作和使用"),
                new AssistiveDevice(108182101,"送纸夹","操作和使用"),
                new AssistiveDevice(108182401,"文稿固定架","操作和使用"),
                new AssistiveDevice(108182701,"前臂支撑架","操作和使用"),
                new AssistiveDevice(108182801,"带弹簧剪刀","操作和使用"),
                new AssistiveDevice(108210301,"折叠式长柄取物器","操作和使用"),
                new AssistiveDevice(108210302,"非折叠式长柄取物器","操作和使用"),
                new AssistiveDevice(108210901,"无抓握功能的延伸器","操作和使用"),
                new AssistiveDevice(108240301,"固定位置系统","操作和使用"),
                new AssistiveDevice(108240601,"转动和滑动系统","操作和使用"),
                new AssistiveDevice(108240901,"升降和倾斜系统","操作和使用"),
                new AssistiveDevice(108270301,"吸盘","操作和使用"),
                new AssistiveDevice(108270601,"防滑垫","操作和使用"),
                new AssistiveDevice(108271201,"夹子和弹簧夹","操作和使用"),
                new AssistiveDevice(108271801,"磁性贴","操作和使用"),
                new AssistiveDevice(108360301,"搬运辅助器具","操作和使用"),
                new AssistiveDevice(108360601,"脚轮装置","操作和使用"),
                new AssistiveDevice(108360901,"行李车和购物推车","操作和使用"),
                new AssistiveDevice(108361501,"轮椅车背包","操作和使用"),
                new AssistiveDevice(111030301,"工作桌","操作和使用"),
                new AssistiveDevice(111030601,"作业台","操作和使用"),
                new AssistiveDevice(111031201,"凳子","操作和使用"),
                new AssistiveDevice(111031202,"站立椅","操作和使用"),
                new AssistiveDevice(111031801,"工作场所用垫子","操作和使用"),
                new AssistiveDevice(111120301,"手持式磁铁","操作和使用"),
                new AssistiveDevice(111120302,"抓持式磁铁","操作和使用"),
                new AssistiveDevice(111120601,"弹簧夹","操作和使用"),
                new AssistiveDevice(111120602,"工作台用防滑垫","操作和使用"),
                new AssistiveDevice(111120603,"带格子的旋转桌","操作和使用"),
                new AssistiveDevice(111240301, "安全靴", "操作和使用"),
                new AssistiveDevice(111240302, "防护工作服", "操作和使用"),
                new AssistiveDevice(111241801, "防滑地板", "操作和使用"),
                new AssistiveDevice(111241802, "道路标识", "操作和使用"),
                new AssistiveDevice(112030301, "数学算盘文字类玩具", "操作和使用"),
                new AssistiveDevice(112030302, "工具类玩具", "操作和使用"),
                new AssistiveDevice(112030303, "益智组合类玩具", "操作和使用"),
                new AssistiveDevice(112030304, "交通类玩具", "操作和使用"),
                new AssistiveDevice(112030901, "棋盘", "操作和使用"),
                new AssistiveDevice(112090301, "轮椅篮球", "操作和使用"),
                new AssistiveDevice(112090302, "盲人足球", "操作和使用"),
                new AssistiveDevice(112090303, "坐式排球", "操作和使用"),
                new AssistiveDevice(112090304, "轮椅乒乓球", "操作和使用"),
                new AssistiveDevice(112090601, "箭术辅助器具", "操作和使用"),
                new AssistiveDevice(112090901, "划船辅助器具", "操作和使用"),
                new AssistiveDevice(112091201, "保龄球辅助器具", "操作和使用"),
                new AssistiveDevice(112091801, "击剑辅助器具", "操作和使用"),
                new AssistiveDevice(112092701, "网球拍", "操作和使用"),
                new AssistiveDevice(112092702, "乒乓球拍", "操作和使用"),
                new AssistiveDevice(112092703, "羽毛球拍", "操作和使用"),
                new AssistiveDevice(112093001, "射击辅助器具", "操作和使用"),
                new AssistiveDevice(112093301, "游泳和水上运动辅助器具", "操作和使用"),
                new AssistiveDevice(112093601, "冬季运动辅助器具", "操作和使用"),
                new AssistiveDevice(112093901, "其它运动辅助器具", "操作和使用"),
                new AssistiveDevice(112180301, "刺绣针", "操作和使用"),
                new AssistiveDevice(112180302, "花绷子", "操作和使用"),
                new AssistiveDevice(112180303, "绣架", "操作和使用"),
                new AssistiveDevice(112180304,"钩针编织模具","操作和使用"),
                new AssistiveDevice(112180601,"制陶工艺工具、材料和设备","操作和使用"),
                new AssistiveDevice(112180901,"木工工艺工具、材料和设备","操作和使用"),
                new AssistiveDevice(112181201,"金属加工工具、材料和设备","操作和使用"),
                new AssistiveDevice(112181501, "画板", "操作和使用"),
                new AssistiveDevice(112181502, "画架", "操作和使用"),
                new AssistiveDevice(112181503, "画夹", "操作和使用"),
                new AssistiveDevice(112181504, "调色盘", "操作和使用"),
                new AssistiveDevice(112181505,"调色板","操作和使用"),
                new AssistiveDevice(112181506, "笔洗", "操作和使用"),
                new AssistiveDevice(112181507, "镇纸", "操作和使用"),
                new AssistiveDevice(112181801,"其它材料的手工工艺的工具、材料和设备","操作和使用"),
                #endregion
                
                #region 位置转移
                new AssistiveDevice(10236,"升降人的辅助器具","位置转移"),
                new AssistiveDevice(10430,"垂直运送辅助器具","位置转移"),

                new AssistiveDevice(1023603,"带吊兜的移位机","位置转移"),
                new AssistiveDevice(1023606,"带硬座的移位机","位置转移"),
                new AssistiveDevice(1023612,"安装在墙上、地板或天花板上的固定移位机","位置转移"),
                new AssistiveDevice(1023615,"固定、安置在另一个产品上的固定移位机","位置转移"),
                new AssistiveDevice(1023618,"固定自立式移位机","位置转移"),
                new AssistiveDevice(1023621,"移位机的身体支撑部分","位置转移"),
                new AssistiveDevice(1043005,"固定式升降台","位置转移"),
                new AssistiveDevice(1043008,"便携式升降台","位置转移"),
                new AssistiveDevice(1043010,"楼梯升降椅","位置转移"),
                new AssistiveDevice(1043011,"平台楼梯升降机","位置转移"),
                new AssistiveDevice(1043015,"可移动坡道","位置转移"),
                new AssistiveDevice(1043018,"固定坡道","位置转移"),
                new AssistiveDevice(1043019,"桌类","位置转移"),
                new AssistiveDevice(1073309,"个人移动训练辅助器具","位置转移"),

                new AssistiveDevice(102360301,"地面吊兜式移位机","位置转移"),
                new AssistiveDevice(102360302,"带导轨装置的吊兜式移位机","位置转移"),
                new AssistiveDevice(102360303, "站立式移位机", "位置转移"),
                new AssistiveDevice(102360601, "带硬座的移位机", "位置转移"),
                new AssistiveDevice(102361201, "顶置式移位机", "位置转移"),
                new AssistiveDevice(102361501, "浴缸移位机", "位置转移"),
                new AssistiveDevice(102361502, "水疗提升装置", "位置转移"),
                new AssistiveDevice(102361801, "垂直平台", "位置转移"),
                new AssistiveDevice(102362101, "吊索", "位置转移"),
                new AssistiveDevice(102362102, "吊兜", "位置转移"),
                new AssistiveDevice(104300501, "轮椅升降台", "位置转移"),
                new AssistiveDevice(104300502, "固定式升降台", "位置转移"),
                new AssistiveDevice(104300503,"平台升降机","位置转移"),
                new AssistiveDevice(104300504, "斜挂式轮椅升降平台", "位置转移"),
                new AssistiveDevice(104300505,"垂直式轮椅升降平台","位置转移"),
                new AssistiveDevice(104300801, "便携式轮椅升降机", "位置转移"),
                new AssistiveDevice(104301001, "座椅式楼梯机", "位置转移"),
                new AssistiveDevice(104301101, "轮椅用楼梯升降机", "位置转移"),
                new AssistiveDevice(104301102, "轮椅用滚梯", "位置转移"),
                new AssistiveDevice(104301501, "可拆装的简易坡道", "位置转移"),
                new AssistiveDevice(104301502, "便携式斜坡板", "位置转移"),
                new AssistiveDevice(104301503, "模块式组合坡道", "位置转移"),
                new AssistiveDevice(104301801, "普通固定坡道、", "位置转移"),
                new AssistiveDevice(104301802,"安全挡台","位置转移"),
                new AssistiveDevice(104301803, "轮椅缓冲地带", "位置转移"),
                new AssistiveDevice(104301901, "床用餐桌", "位置转移"),
                new AssistiveDevice(107330901, "辅助起身带", "位置转移"),
                new AssistiveDevice(107330902, "简易移乘带", "位置转移"),
                new AssistiveDevice(107330903, "双人移乘带", "位置转移"),
                new AssistiveDevice(107330904, "保护腰带", "位置转移"),
                new AssistiveDevice(107330905, "翻身床单", "位置转移"),
                new AssistiveDevice(107330906, "移乘板", "位置转移"),
                new AssistiveDevice(107330907, "起身绳梯", "位置转移"),
                #endregion
                
                #region 纠正姿势
                new AssistiveDevice(10409,"坐式家具","纠正姿势"),

                new AssistiveDevice(1040921,"特殊坐具","纠正姿势"),

                new AssistiveDevice(104092101,"儿童三角椅","纠正姿势"),
                new AssistiveDevice(104092102,"儿童姿势矫正椅","纠正姿势"),
                new AssistiveDevice(104092103,"儿童梯背训练椅","纠正姿势"),
                new AssistiveDevice(104092104,"儿童安全椅","纠正姿势"),
                new AssistiveDevice(104092105,"儿童船形摇椅","纠正姿势"),
                new AssistiveDevice(104092106,"儿童鞍型可调座椅","纠正姿势"),
                #endregion

                #region 假肢
                new AssistiveDevice(10118,"上肢假肢","假肢"),
                new AssistiveDevice(10124,"下肢假肢","假肢"),
                new AssistiveDevice(10130,"不同于假肢的假体","假肢"),

                new AssistiveDevice(1011803,"部分手假肢","假肢"),
                new AssistiveDevice(1011806,"腕离断假肢","假肢"),
                new AssistiveDevice(1011809,"前臂假肢","假肢"),
                new AssistiveDevice(1011812,"肘离断假肢","假肢"),
                new AssistiveDevice(1011815,"上臂假肢","假肢"),
                new AssistiveDevice(1011818,"肩离断假肢","假肢"),
                new AssistiveDevice(1011821,"肩胛胸廓假肢","假肢"),
                new AssistiveDevice(1011824,"假手","假肢"),
                new AssistiveDevice(1011825,"钩状手","假肢"),
                new AssistiveDevice(1011826,"工具手及工具","假肢"),
                new AssistiveDevice(1011830,"腕关节","假肢"),
                new AssistiveDevice(1011833,"肘关节","假肢"),
                new AssistiveDevice(1011836,"肩关节","假肢"),
                new AssistiveDevice(1011840,"肱骨旋转装置","假肢"),
                new AssistiveDevice(1011841,"屈肘倍增器","假肢"),
                new AssistiveDevice(1012403,"部分足假肢","假肢"),
                new AssistiveDevice(1012406,"踝部假肢","假肢"),
                new AssistiveDevice(1012409,"小腿假肢","假肢"),
                new AssistiveDevice(1012412,"膝离断假肢","假肢"),
                new AssistiveDevice(1012415,"大腿假肢","假肢"),
                new AssistiveDevice(1012418,"髋离断假肢","假肢"),
                new AssistiveDevice(1012421,"半骨盆切除假肢","假肢"),
                new AssistiveDevice(1012424,"半体假肢","假肢"),
                new AssistiveDevice(1012427,"踝足装置","假肢"),
                new AssistiveDevice(1012430,"扭矩缓冲器","假肢"),
                new AssistiveDevice(1012431,"缓冲器","假肢"),
                new AssistiveDevice(1012433,"膝关节","假肢"),
                new AssistiveDevice(1012436,"髋关节","假肢"),
                new AssistiveDevice(1012440,"内衬套","假肢"),
                new AssistiveDevice(1012441,"预制接受腔","假肢"),
                new AssistiveDevice(1012445,"下肢假肢的对线装置","假肢"),
                new AssistiveDevice(1012448,"下肢临时假肢","假肢"),
                new AssistiveDevice(1013003,"假发","假肢"),
                new AssistiveDevice(1013018,"假乳房","假肢"),
                new AssistiveDevice(1013021,"假眼","假肢"),
                new AssistiveDevice(1013024,"假耳","假肢"),
                new AssistiveDevice(1013027,"假鼻","假肢"),
                new AssistiveDevice(1013030,"面部合成假体","假肢"),
                new AssistiveDevice(1013033,"假腭","假肢"),
                new AssistiveDevice(1013036,"假牙","假肢"),

                new AssistiveDevice(101180301,"掌骨截肢假肢","假肢"),
                new AssistiveDevice(101180302,"掌骨截肢肌电手","假肢"),
                new AssistiveDevice(101180303,"装饰性部分手假肢","假肢"),
                new AssistiveDevice(101180304,"装饰性假手指","假肢"),
                new AssistiveDevice(101180601,"索控手腕离断假肢","假肢"),
                new AssistiveDevice(101180602,"单自由度肌电手腕离断假肢","假肢"),
                new AssistiveDevice(101180603, "工具手腕离断假肢", "假肢"),
                new AssistiveDevice(101180604, "装饰性腕离断假肢", "假肢"),
                new AssistiveDevice(101180901, "索控手前臂假肢", "假肢"),
                new AssistiveDevice(101180902, "单自由度肌电手前臂假肢", "假肢"),
                new AssistiveDevice(101180903, "双自由度肌电手前臂假肢", "假肢"),
                new AssistiveDevice(101180904, "工具手前臂假肢", "假肢"),
                new AssistiveDevice(101180905, "装饰性前臂假肢", "假肢"),
                new AssistiveDevice(101181201, "索控手肘离断假肢", "假肢"),
                new AssistiveDevice(101181202,"单自由度肌电手肘离断假肢","假肢"),
                new AssistiveDevice(101181203, "双自由度肌电手肘离断假肢", "假肢"),
                new AssistiveDevice(101181204,"工具手肘离断假肢","假肢"),
                new AssistiveDevice(101181205, "装饰性肘离断假肢", "假肢"),
                new AssistiveDevice(101181501, "索控手上臂假肢", "假肢"),
                new AssistiveDevice(101181502, "单自由度肌电手上臂假肢", "假肢"),
                new AssistiveDevice(101181503, "双自由度肌电手上臂假肢", "假肢"),
                new AssistiveDevice(101181504,"双自由度混合式电动手上臂假肢","假肢"),
                new AssistiveDevice(101181505, "三自由度肌电手上臂假肢", "假肢"),
                new AssistiveDevice(101181506,"工具手上臂假肢","假肢"),
                new AssistiveDevice(101181507, "装饰性上臂假肢", "假肢"),
                new AssistiveDevice(101181801, "索控手肩离断假肢", "假肢"),
                new AssistiveDevice(101181802,"双自由度肌电手肩离断假肢","假肢"),
                new AssistiveDevice(101181803, "装饰性肩离断假肢", "假肢"),
                new AssistiveDevice(101182101, "装饰性肩胛胸廓假肢", "假肢"),
                new AssistiveDevice(101182401, "壳式索控手", "假肢"),
                new AssistiveDevice(101182402, "骨架式索控手", "假肢"),
                new AssistiveDevice(101182403, "单自由度肌电手", "假肢"),
                new AssistiveDevice(101182404, "双自由度肌电手", "假肢"),
                new AssistiveDevice(101182405, "装饰手", "假肢"),
                new AssistiveDevice(101182406, "掌骨截肢肌电手", "假肢"),
                new AssistiveDevice(101182501, "万能型钩状手", "假肢"),
                new AssistiveDevice(101182502, "侧钩型钩状手", "假肢"),
                new AssistiveDevice(101182601, "劳动用钩状工具手", "假肢"),
                new AssistiveDevice(101182602, "劳动用夹持工具手", "假肢"),
                new AssistiveDevice(101182603,"专用工具","假肢"),
                new AssistiveDevice(101183001, "摩擦式可旋腕关节", "假肢"),
                new AssistiveDevice(101183002, "被动式腕关节", "假肢"),
                new AssistiveDevice(101183003,"换装手头式腕关节","假肢"),
                new AssistiveDevice(101183004, "工具手连接器", "假肢"),
                new AssistiveDevice(101183301, "单轴自由肘关节铰链", "假肢"),
                new AssistiveDevice(101183302, "双轴自由肘关节铰链", "假肢"),
                new AssistiveDevice(101183303, "锁定式肘关节铰链", "假肢"),
                new AssistiveDevice(101183304, "挠性肘关节铰链", "假肢"),
                new AssistiveDevice(101183305,"电动肘关节","假肢"),
                new AssistiveDevice(101183601, "隔板式肩关节", "假肢"),
                new AssistiveDevice(101183602, "外展式肩关节", "假肢"),
                new AssistiveDevice(101183603, "万向肩关节", "假肢"),
                new AssistiveDevice(101184001, "肱骨旋转装置", "假肢"),
                new AssistiveDevice(101184101, "三杆结构倍增式肘铰链", "假肢"),
                new AssistiveDevice(101184102,"四杆结构倍增式肘铰链","假肢"),
                new AssistiveDevice(101240301, "皮套式假足趾", "假肢"),
                new AssistiveDevice(101240302, "硅胶套式假足趾", "假肢"),
                new AssistiveDevice(101240303,"硅胶足套式假半足","假肢"),
                new AssistiveDevice(101240304, "树脂成型小腿式假半足", "假肢"),
                new AssistiveDevice(101240601, "皮制赛姆假肢", "假肢"),
                new AssistiveDevice(101240602, "树脂成型赛姆假肢", "假肢"),
                new AssistiveDevice(101240901, "壳式小腿假肢", "假肢"),
                new AssistiveDevice(101240902, "组件式单轴脚小腿假肢", "假肢"),
                new AssistiveDevice(101240903,"组件式SACH 脚小腿假肢","假肢"),
                new AssistiveDevice(101240904,"组件式万向踝单轴脚小腿假肢","假肢"),
                new AssistiveDevice(101240905, "组件式储能脚小腿假肢", "假肢"),
                new AssistiveDevice(101241201, "不锈钢组件膝离断假肢", "假肢"),
                new AssistiveDevice(101241202,"铝合金组件膝离断假肢","假肢"),
                new AssistiveDevice(101241203, "钛合金组件膝离断假肢", "假肢"),
                new AssistiveDevice(101241204,"气压控制膝离断假肢","假肢"),
                new AssistiveDevice(101241205, "液压控制膝离断假肢", "假肢"),
                new AssistiveDevice(101241206,"智能控制膝离断假肢","假肢"),
                new AssistiveDevice(101241501, "不锈钢组件大腿假肢", "假肢"),
                new AssistiveDevice(101241502, "铝合金组件大腿假肢", "假肢"),
                new AssistiveDevice(101241503, "钛合金组件大腿假肢", "假肢"),
                new AssistiveDevice(101241504, "气压控制大腿假肢", "假肢"),
                new AssistiveDevice(101241505,"液压控制大腿假肢","假肢"),
                new AssistiveDevice(101241506, "智能控制大腿假肢", "假肢"),
                new AssistiveDevice(101241801, "不锈钢组件髋离断假肢", "假肢"),
                new AssistiveDevice(101241802,"铝合金组件髋离断假肢","假肢"),
                new AssistiveDevice(101241803, "钛合金组件髋离断假肢", "假肢"),
                new AssistiveDevice(101241804,"气压控制髋离断假肢","假肢"),
                new AssistiveDevice(101241805, "液压控制髋离断假肢", "假肢"),
                new AssistiveDevice(101242101, "半骨盆切除假肢", "假肢"),
                new AssistiveDevice(101242102, "特制半骨盆切除假肢", "假肢"),
                new AssistiveDevice(101242401, "短桩半体假肢", "假肢"),
                new AssistiveDevice(101242402, "特制半体假肢", "假肢"),
                new AssistiveDevice(101242701, "单轴脚", "假肢"),
                new AssistiveDevice(101242702, "单轴低踝脚", "假肢"),
                new AssistiveDevice(101242703, "静踝脚", "假肢"),
                new AssistiveDevice(101242704, "多轴脚", "假肢"),
                new AssistiveDevice(101242705,"储能脚","假肢"),
                new AssistiveDevice(101242706, "方锥静踝", "假肢"),
                new AssistiveDevice(101242707, "单轴动踝", "假肢"),
                new AssistiveDevice(101242708, "万向踝", "假肢"),
                new AssistiveDevice(101243001, "弹簧扭矩缓冲器", "假肢"),
                new AssistiveDevice(101243002, "橡胶扭矩缓冲器", "假肢"),
                new AssistiveDevice(101243101, "膝伸展缓冲器", "假肢"),
                new AssistiveDevice(101243102, "足前缓冲器", "假肢"),
                new AssistiveDevice(101243103, "足后缓冲器", "假肢"),
                new AssistiveDevice(101243301, "单轴膝关节", "假肢"),
                new AssistiveDevice(101243302, "承重自锁膝关节", "假肢"),
                new AssistiveDevice(101243303,"手动锁单轴膝关节","假肢"),
                new AssistiveDevice(101243304, "四连杆膝关节", "假肢"),
                new AssistiveDevice(101243305, "气压膝关节", "假肢"),
                new AssistiveDevice(101243306,"液压膝关节","假肢"),
                new AssistiveDevice(101243307, "智能膝关节", "假肢"),
                new AssistiveDevice(101243308, "四连杆膝离断膝关节", "假肢"),
                new AssistiveDevice(101243309,"气压膝离断膝关节","假肢"),
                new AssistiveDevice(101243310, "液压膝离断膝关节", "假肢"),
                new AssistiveDevice(101243601, "前置式单轴髋关节", "假肢"),
                new AssistiveDevice(101243602, "下置式单轴髋关节", "假肢"),
                new AssistiveDevice(101243603,"四连杆髋关节","假肢"),
                new AssistiveDevice(101244001, "接受腔内衬套", "假肢"),
                new AssistiveDevice(101244002, "无锁凝胶残肢套", "假肢"),
                new AssistiveDevice(101244003,"有锁凝胶残肢套","假肢"),
                new AssistiveDevice(101244004, "无锁硅胶残肢套", "假肢"),
                new AssistiveDevice(101244005, "有锁硅胶残肢套", "假肢"),
                new AssistiveDevice(101244101, "预制接受腔", "假肢"),
                new AssistiveDevice(101244501, "小腿假肢装配对线连接盘", "假肢"),
                new AssistiveDevice(101244502,"临时接受腔可调连接架","假肢"),
                new AssistiveDevice(101244503, "可调连接盘", "假肢"),
                new AssistiveDevice(101244504, "三爪连接盘", "假肢"),
                new AssistiveDevice(101244505, "四爪连接盘", "假肢"),
                new AssistiveDevice(101244506, "锁紧管接头", "假肢"),
                new AssistiveDevice(101244507, "双向接头", "假肢"),
                new AssistiveDevice(101244801, "石膏接受腔临时假肢", "假肢"),
                new AssistiveDevice(101244802,"采用接受腔调节架的临时假肢","假肢"),
                new AssistiveDevice(101244803, "树脂接受腔临时假肢", "假肢"),
                new AssistiveDevice(101244804, "短桩临时假肢", "假肢"),
                new AssistiveDevice(101300301, "假发", "假肢"),
                new AssistiveDevice(101301801, "胸罩式假乳房", "假肢"),
                new AssistiveDevice(101301802, "仿真假乳房", "假肢"),
                new AssistiveDevice(101302101, "配制硬性假眼", "假肢"),
                new AssistiveDevice(101302102, "定制硬性假眼", "假肢"),
                new AssistiveDevice(101302103, "软性假眼", "假肢"),
                new AssistiveDevice(101302104,"薄体假眼","假肢"),
                new AssistiveDevice(101302105, "特制活动假眼", "假肢"),
                new AssistiveDevice(101302401, "硅胶假耳", "假肢"),
                new AssistiveDevice(101302701, "硅胶假鼻", "假肢"),
                new AssistiveDevice(101303001, "面部合成假体", "假肢"),
                new AssistiveDevice(101303301, "假腭", "假肢"),
                new AssistiveDevice(101303601, "单颗牙", "假肢"),
                new AssistiveDevice(101303602, "全口牙", "假肢"),
                #endregion

                #region 矫形器
                new AssistiveDevice(10103,"脊柱和颅部矫形器","矫形器"),
                new AssistiveDevice(10104,"腹部矫形器","矫形器"),
                new AssistiveDevice(10106,"上肢矫形器系统","矫形器"),
                new AssistiveDevice(10112,"下肢矫形器","矫形器"),
                new AssistiveDevice(10133,"矫形鞋","矫形器"),

                new AssistiveDevice(1010303,"骶髂矫形器","矫形器"),
                new AssistiveDevice(1010304,"腰部矫形器","矫形器"),
                new AssistiveDevice(1010306,"腰骶矫形器","矫形器"),
                new AssistiveDevice(1010307,"胸部矫形器","矫形器"),
                new AssistiveDevice(1010308,"胸腰矫形器","矫形器"),
                new AssistiveDevice(1010309,"胸腰骶矫形器","矫形器"),
                new AssistiveDevice(1010312,"颈部矫形器","矫形器"),
                new AssistiveDevice(1010315,"颈胸矫形器","矫形器"),
                new AssistiveDevice(1010318,"颈胸腰骶矫形器","矫形器"),
                new AssistiveDevice(1010321,"颅部矫形器","矫形器"),
                new AssistiveDevice(1010326,"脊柱侧弯矫形器","矫形器"),
                new AssistiveDevice(1010327,"脊柱矫形器铰链","矫形器"),
                new AssistiveDevice(1010403,"腹肌托","矫形器"),
                new AssistiveDevice(1010404,"胃（下垂）托","矫形器"),
                new AssistiveDevice(1010405,"肾（下垂）托","矫形器"),
                new AssistiveDevice(1010603,"指矫形器","矫形器"),
                new AssistiveDevice(1010606,"手矫形器","矫形器"),
                new AssistiveDevice(1010607,"手-指矫形器","矫形器"),
                new AssistiveDevice(1010612,"腕手矫形器","矫形器"),
                new AssistiveDevice(1010613,"腕手-手指矫形器","矫形器"),
                new AssistiveDevice(1010614,"夹持矫形器","矫形器"),
                new AssistiveDevice(1010615,"肘矫形器","矫形器"),
                new AssistiveDevice(1010619,"肘腕手矫形器","矫形器"),
                new AssistiveDevice(1010620,"前臂矫形器","矫形器"),
                new AssistiveDevice(1010621,"肩矫形器","矫形器"),
                new AssistiveDevice(1010624,"肩肘矫形器","矫形器"),
                new AssistiveDevice(1010625,"上臂矫形器","矫形器"),
                new AssistiveDevice(1010630,"肩肘腕手矫形器","矫形器"),
                new AssistiveDevice(1010631,"手-指关节铰链","矫形器"),
                new AssistiveDevice(1010633,"腕铰链","矫形器"),
                new AssistiveDevice(1010636,"肘铰链","矫形器"),
                new AssistiveDevice(1010639,"肩铰链","矫形器"),
                new AssistiveDevice(1011203,"足矫形器","矫形器"),
                new AssistiveDevice(1011206,"踝足矫形器","矫形器"),
                new AssistiveDevice(1011209,"膝矫形器","矫形器"),
                new AssistiveDevice(1011212,"膝踝足矫形器","矫形器"),
                new AssistiveDevice(1011213,"小腿矫形器","矫形器"),
                new AssistiveDevice(1011215,"髋矫形器","矫形器"),
                new AssistiveDevice(1011216,"髋膝矫形器","矫形器"),
                new AssistiveDevice(1011217,"大腿矫形器","矫形器"),
                new AssistiveDevice(1011218,"髋膝踝足矫形器","矫形器"),
                new AssistiveDevice(1011219,"胸腰(腰)骶髋膝踝足矫形器","矫形器"),
                new AssistiveDevice(1011220,"足-趾铰链","矫形器"),
                new AssistiveDevice(1011221,"踝关节铰链","矫形器"),
                new AssistiveDevice(1011224,"膝关节铰链","矫形器"),
                new AssistiveDevice(1011227,"髋关节铰链","矫形器"),
                new AssistiveDevice(1013307,"控制畸形的矫形鞋","矫形器"),
                new AssistiveDevice(1013318,"补高鞋","矫形器"),
                new AssistiveDevice(1013321,"补缺鞋","矫形器"),
                new AssistiveDevice(1013330,"免荷鞋","矫形器"),
                new AssistiveDevice(1013333,"保护用矫形鞋","矫形器"),

                new AssistiveDevice(101030301,"塑模成型骶髂矫形器","矫形器"),
                new AssistiveDevice(101030302,"骶髂带","矫形器"),
                new AssistiveDevice(101030303,"大转子带","矫形器"),
                new AssistiveDevice(101030401,"弹力腰围","矫形器"),
                new AssistiveDevice(101030402,"加强型弹力腰围","矫形器"),
                new AssistiveDevice(101030403,"内置支条式弹力腰围","矫形器"),
                new AssistiveDevice(101030404,"硬托式腰围","矫形器"),
                new AssistiveDevice(101030405,"皮腰围","矫形器"),
                new AssistiveDevice(101030406,"帆布腰围","矫形器"),
                new AssistiveDevice(101030407,"保温型腰围","矫形器"),
                new AssistiveDevice(101030408,"硬性腰围","矫形器"),
                new AssistiveDevice(101030601,"塑模成型腰骶矫形器","矫形器"),
                new AssistiveDevice(101030602,"腰骶屈曲（伸展限制矫形器）","矫形器"),
                new AssistiveDevice(101030603,"腰椎牵引带","矫形器"),
                new AssistiveDevice(101030604,"家用腰椎牵引器","矫形器"),
                new AssistiveDevice(101030701,"胸部矫形器","矫形器"),
                new AssistiveDevice(101030801,"内置支条弹力高腰围腰","矫形器"),
                new AssistiveDevice(101030802,"内置帆布弹力高腰围腰","矫形器"),
                new AssistiveDevice(101030803,"内置支条皮革高腰围腰","矫形器"),
                new AssistiveDevice(101030804,"腹背托式高腰围腰","矫形器"),
                new AssistiveDevice(101030805,"背姿矫形带","矫形器"),
                new AssistiveDevice(101030901,"泰勒型胸腰骶矫形器","矫形器"),
                new AssistiveDevice(101030902,"奈特-泰勒型胸腰骶矫形器","矫形器"),
                new AssistiveDevice(101030903,"脊柱过伸矫形器","矫形器"),
                new AssistiveDevice(101030904,"支条固定式胸腰骶矫形器","矫形器"),
                new AssistiveDevice(101030905,"模塑夹克式胸腰骶矫形器","矫形器"),
                new AssistiveDevice(101030906,"可调夹克式胸腰骶矫形器","矫形器"),
                new AssistiveDevice(101030907,"带胸背托可调夹克式胸腰骶矫形器","矫形器"),
                new AssistiveDevice(101030908,"带胸托围腰式胸腰骶矫形器","矫形器"),
                new AssistiveDevice(101031201,"围领式颈托","矫形器"),
                new AssistiveDevice(101031202,"费城颈托","矫形器"),
                new AssistiveDevice(101031203,"模塑成型固定式颈托","矫形器"),
                new AssistiveDevice(101031204,"高度可调式颈托","矫形器"),
                new AssistiveDevice(101031205,"充气式颈托","矫形器"),
                new AssistiveDevice(101031206,"三片组合式颈托","矫形器"),
                new AssistiveDevice(101031207,"颈椎牵引器","矫形器"),
                new AssistiveDevice(101031501,"索米型颈胸矫形器","矫形器"),
                new AssistiveDevice(101031502,"支杆加强型颈胸矫形器","矫形器"),
                new AssistiveDevice(101031503,"头匝式颈胸矫形器","矫形器"),
                new AssistiveDevice(101031504,"头环式颈胸矫形器","矫形器"),
                new AssistiveDevice(101031505,"模塑成型颈胸矫形器","矫形器"),
                new AssistiveDevice(101031506,"框架式颈胸矫形器","矫形器"),
                new AssistiveDevice(101031801,"模塑成型胸腰骶矫形器","矫形器"),
                new AssistiveDevice(101031802,"框架式胸腰骶矫形器","矫形器"),
                new AssistiveDevice(101031803,"颈腰椎牵引器","矫形器"),
                new AssistiveDevice(101032101,"保护性头盔","矫形器"),
                new AssistiveDevice(101032102,"颅骨护罩","矫形器"),
                new AssistiveDevice(101032601,"密尔沃基型侧凸矫形器","矫形器"),
                new AssistiveDevice(101032602,"波士顿型侧凸矫形器","矫形器"),
                new AssistiveDevice(101032603,"里昂型侧凸矫形器","矫形器"),
                new AssistiveDevice(101032604,"色努型侧凸矫形器","矫形器"),
                new AssistiveDevice(101032605,"CBW 型侧凸矫形器","矫形器"),
                new AssistiveDevice(101032606,"OMC（大阪医大）型侧凸矫形器","矫形器"),
                new AssistiveDevice(101032701,"脊柱矫形器铰链","矫形器"),
                new AssistiveDevice(101040301,"束腹带","矫形器"),
                new AssistiveDevice(101040401,"普通胃托","矫形器"),
                new AssistiveDevice(101040402,"可调式胃托","矫形器"),
                new AssistiveDevice(101040501,"单侧肾托","矫形器"),
                new AssistiveDevice(101040502,"双侧肾托","矫形器"),
                new AssistiveDevice(101060301,"指间关节固定托","矫形器"),
                new AssistiveDevice(101060302,"槌状指矫正托","矫形器"),
                new AssistiveDevice(101060303,"鹅颈变形指矫正托","矫形器"),
                new AssistiveDevice(101060304,"扣眼变形指矫形托","矫形器"),
                new AssistiveDevice(101060305,"硬胶指套","矫形器"),
                new AssistiveDevice(101060306,"指护托","矫形器"),
                new AssistiveDevice(101060307,"弹力屈指器","矫形器"),
                new AssistiveDevice(101060308,"弹力伸指器","矫形器"),
                new AssistiveDevice(101060601,"掌指关节固定矫形器","矫形器"),
                new AssistiveDevice(101060602,"掌指关节伸展辅助矫形器","矫形器"),
                new AssistiveDevice(101060603,"尺神经麻痹矫形器","矫形器"),
                new AssistiveDevice(101060604,"短对掌矫形器","矫形器"),
                new AssistiveDevice(101060701,"可调分指板","矫形器"),
                new AssistiveDevice(101060702,"手掌肌膜挛缩矫形器","矫形器"),
                new AssistiveDevice(101060703,"正中神经麻痹用矫形器","矫形器"),
                new AssistiveDevice(101061201,"弹力护腕","矫形器"),
                new AssistiveDevice(101061202,"加固型护腕","矫形器"),
                new AssistiveDevice(101061203,"腕关节定位托板","矫形器"),
                new AssistiveDevice(101061204,"模塑成型腕手固定矫形器","矫形器"),
                new AssistiveDevice(101061205,"抗痉挛腕手矫形器","矫形器"),
                new AssistiveDevice(101061206,"动态腕手矫形器","矫形器"),
                new AssistiveDevice(101061207,"长对掌矫形器","矫形器"),
                new AssistiveDevice(101061301,"带MP伸展限位的长对掌矫形器","矫形器"),
                new AssistiveDevice(101061302,"带IP伸展辅助和MP伸展限位的长对掌矫形器","矫形器"),
                new AssistiveDevice(101061303,"带MP屈曲辅助的长对掌矫形器","矫形器"),
                new AssistiveDevice(101061304,"带MP伸展辅助的长对掌矫形器","矫形器"),
                new AssistiveDevice(101061305,"带IP伸展辅助的长对掌矫形器","矫形器"),
                new AssistiveDevice(101061401,"恩根型夹持矫形器","矫形器"),
                new AssistiveDevice(101061402,"兰乔型夹持矫形器","矫形器"),
                new AssistiveDevice(101061501,"弹力护肘","矫形器"),
                new AssistiveDevice(101061502,"网球肘护肘","矫形器"),
                new AssistiveDevice(101061503,"肘过伸限制矫形器","矫形器"),
                new AssistiveDevice(101061504,"肘固定矫形器","矫形器"),
                new AssistiveDevice(101061505,"可调肘矫形器","矫形器"),
                new AssistiveDevice(101061901,"前臂（肘腕手）矫形器","矫形器"),
                new AssistiveDevice(101062001,"前臂固定护托","矫形器"),
                new AssistiveDevice(101062002,"模塑成型前臂固定托","矫形器"),
                new AssistiveDevice(101062101,"弹力护肩","矫形器"),
                new AssistiveDevice(101062102,"锁骨带","矫形器"),
                new AssistiveDevice(101062103,"肩关节固定矫形器","矫形器"),
                new AssistiveDevice(101062104,"肩外展矫形器","矫形器"),
                new AssistiveDevice(101062105,"肩关节脱位矫形器","矫形器"),
                new AssistiveDevice(101062106,"肩锁关节脱位矫形器","矫形器"),
                new AssistiveDevice(101062107,"臂吊带","矫形器"),
                new AssistiveDevice(101062401,"肩肘固定垫","矫形器"),
                new AssistiveDevice(101062402,"屈肘辅助铰链式动态肩肘矫形器","矫形器"),
                new AssistiveDevice(101062501,"上臂固定护托","矫形器"),
                new AssistiveDevice(101062502,"模塑成型上臂固定托","矫形器"),
                new AssistiveDevice(101063001,"功能性上肢矫形器","矫形器"),
                new AssistiveDevice(101063002,"平衡式前臂矫形器(BFO)","矫形器"),
                new AssistiveDevice(101063101,"手-指关节铰链","矫形器"),
                new AssistiveDevice(101063301,"腕铰链","矫形器"),
                new AssistiveDevice(101063601,"单轴肘关节铰链","矫形器"),
                new AssistiveDevice(101063602,"定位盘锁定式肘关节铰链","矫形器"),
                new AssistiveDevice(101063603,"克伦扎克式肘关节铰链","矫形器"),
                new AssistiveDevice(101063604,"挠性肘关节铰链","矫形器"),
                new AssistiveDevice(101063901,"挠性肩关节铰链","矫形器"),
                new AssistiveDevice(101120301,"拇指外翻矫形器（垫）","矫形器"),
                new AssistiveDevice(101120302,"硅胶分趾垫","矫形器"),
                new AssistiveDevice(101120303,"槌状趾垫","矫形器"),
                new AssistiveDevice(101120304,"鸡眼垫","矫形器"),
                new AssistiveDevice(101120305,"跖骨垫","矫形器"),
                new AssistiveDevice(101120306,"足掌垫","矫形器"),
                new AssistiveDevice(101120307,"跟骨垫","矫形器"),
                new AssistiveDevice(101120308,"跟骨骨刺垫","矫形器"),
                new AssistiveDevice(101120309,"横弓垫","矫形器"),
                new AssistiveDevice(101120310,"平足垫","矫形器"),
                new AssistiveDevice(101120311,"弓形足垫","矫形器"),
                new AssistiveDevice(101120312,"足内/外翻矫正垫","矫形器"),
                new AssistiveDevice(101120313,"足弓托","矫形器"),
                new AssistiveDevice(101120314,"补高垫","矫形器"),
                new AssistiveDevice(101120315,"足外侧楔形垫","矫形器"),
                new AssistiveDevice(101120316,"缓冲性鞋垫","矫形器"),
                new AssistiveDevice(101120601,"弹力护踝","矫形器"),
                new AssistiveDevice(101120602,"韧带型护踝","矫形器"),
                new AssistiveDevice(101120603,"踝足固定矫形器","矫形器"),
                new AssistiveDevice(101120604,"靴型踝足矫形器","矫形器"),
                new AssistiveDevice(101120605,"动态踝足矫形器","矫形器"),
                new AssistiveDevice(101120606,"塑料踝足矫形器","矫形器"),
                new AssistiveDevice(101120607,"螺旋式踝足矫形器","矫形器"),
                new AssistiveDevice(101120608,"半螺旋式踝足矫形器","矫形器"),
                new AssistiveDevice(101120609,"全免荷PTB踝足矫形器","矫形器"),
                new AssistiveDevice(101120610,"部分免荷PTB踝足矫形器","矫形器"),
                new AssistiveDevice(101120611,"丹尼斯·布朗支架","矫形器"),
                new AssistiveDevice(101120901,"弹性护膝","矫形器"),
                new AssistiveDevice(101120902,"带膝铰链护膝","矫形器"),
                new AssistiveDevice(101120903,"髌骨护托","矫形器"),
                new AssistiveDevice(101120904,"髌骨脱臼矫形器","矫形器"),
                new AssistiveDevice(101120905,"瑞典式膝反屈矫形器","矫形器"),
                new AssistiveDevice(101120906,"前（后）十字韧带损伤用矫形器","矫形器"),
                new AssistiveDevice(101120907,"内外侧副韧带损伤用护膝","矫形器"),
                new AssistiveDevice(101120908,"膝关节固定矫形器","矫形器"),
                new AssistiveDevice(101120909,"可调膝矫形器","矫形器"),
                new AssistiveDevice(101120910,"带膝压垫金属支条型膝矫形器","矫形器"),
                new AssistiveDevice(101120911,"模塑膝矫形器","矫形器"),
                new AssistiveDevice(101121201,"膝踝足固定矫形器","矫形器"),
                new AssistiveDevice(101121202,"金属支条式膝踝足矫形器","矫形器"),
                new AssistiveDevice(101121203,"X型腿矫形器","矫形器"),
                new AssistiveDevice(101121204,"O型腿矫形器","矫形器"),
                new AssistiveDevice(101121205,"全免荷坐骨承重大腿矫形器","矫形器"),
                new AssistiveDevice(101121206,"部分免荷坐骨承重大腿矫形器","矫形器"),
                new AssistiveDevice(101121207,"佩特兹病用矫形器","矫形器"),
                new AssistiveDevice(101121301,"弹力小腿护腿","矫形器"),
                new AssistiveDevice(101121302,"小腿固定护套","矫形器"),
                new AssistiveDevice(101121303,"模塑成型小腿固定托","矫形器"),
                new AssistiveDevice(101121501,"髋固定矫形器","矫形器"),
                new AssistiveDevice(101121502,"锁定式髋外展矫形器","矫形器"),
                new AssistiveDevice(101121503,"可调内收外展的髋固定矫形器","矫形器"),
                new AssistiveDevice(101121504,"蛙式支架","矫形器"),
                new AssistiveDevice(101121505,"儿童先天性髋脱位矫形器","矫形器"),
                new AssistiveDevice(101121601,"髋膝矫形器","矫形器"),
                new AssistiveDevice(101121701,"弹力大腿护腿","矫形器"),
                new AssistiveDevice(101121702,"大腿固定护套","矫形器"),
                new AssistiveDevice(101121703,"模塑成型大腿固定托","矫形器"),
                new AssistiveDevice(101121801,"金属支条式髋大腿矫形器","矫形器"),
                new AssistiveDevice(101121802,"模塑成型髋大腿矫形器","矫形器"),
                new AssistiveDevice(101121803,"坐骨承重髋大腿矫形器","矫形器"),
                new AssistiveDevice(101121901,"带腰骶矫形器的髋大腿矫形器","矫形器"),
                new AssistiveDevice(101121902,"带胸腰骶矫形器的髋大腿矫形器","矫形器"),
                new AssistiveDevice(101121903,"下肢扭转矫形器","矫形器"),
                new AssistiveDevice(101121904,"交替摆动式截瘫行走矫形器（RGO）","矫形器"),
                new AssistiveDevice(101121905,"高位截瘫行走矫形器（ARGO）","矫形器"),
                new AssistiveDevice(101122001,"足-趾铰链","矫形器"),
                new AssistiveDevice(101122101,"带足蹬自由式踝铰链","矫形器"),
                new AssistiveDevice(101122102,"带足蹬单向可调踝铰链","矫形器"),
                new AssistiveDevice(101122103,"带足蹬单向助动式踝铰链","矫形器"),
                new AssistiveDevice(101122104,"带足蹬双向可调外（内）侧支条式踝铰链","矫形器"),
                new AssistiveDevice(101122401,"自由式单轴膝铰链","矫形器"),
                new AssistiveDevice(101122402,"落环锁膝铰链","矫形器"),
                new AssistiveDevice(101122403,"棘爪锁膝铰链","矫形器"),
                new AssistiveDevice(101122404,"限位盘式锁膝铰链","矫形器"),
                new AssistiveDevice(101122701,"自由式单轴髋铰链","矫形器"),
                new AssistiveDevice(101122702,"落环锁髋铰链","矫形器"),
                new AssistiveDevice(101122703,"棘爪锁髋铰链","矫形器"),
                new AssistiveDevice(101330701,"带有各种矫形跟的矫正鞋","矫形器"),
                new AssistiveDevice(101330702,"带有各种矫形掌的矫正鞋","矫形器"),
                new AssistiveDevice(101330703,"扁平足矫正鞋","矫形器"),
                new AssistiveDevice(101330704,"弓形足矫正鞋","矫形器"),
                new AssistiveDevice(101330705,"内（外）翻足矫正鞋","矫形器"),
                new AssistiveDevice(101330706,"马蹄足矫正鞋","矫形器"),
                new AssistiveDevice(101331801,"矫形鞋（单鞋）","矫形器"),
                new AssistiveDevice(101331802,"矫形鞋（棉鞋）","矫形器"),
                new AssistiveDevice(101332101,"低腰补缺鞋","矫形器"),
                new AssistiveDevice(101332102,"中腰不缺鞋","矫形器"),
                new AssistiveDevice(101333001,"跖骨小头免荷鞋","矫形器"),
                new AssistiveDevice(101333002,"跟骨刺免荷鞋","矫形器"),
                new AssistiveDevice(101333301,"外科鞋","矫形器"),
                new AssistiveDevice(101333302,"糖尿病鞋","矫形器"),
                #endregion

                #region 助听类
                new AssistiveDevice(10506,"助听器","助听类"),

                new AssistiveDevice(1050606,"佩戴式（盒式）助听器","助听类"),
                new AssistiveDevice(1050609,"眼镜式助听器","助听类"),
                new AssistiveDevice(1050615,"耳背式助听器","助听类"),
                new AssistiveDevice(1050612,"耳内式助听器","助听类"),
                new AssistiveDevice(1050613,"耳道式助听器","助听类"),
                new AssistiveDevice(1050614,"深耳道式助听器","助听类"),
                new AssistiveDevice(1050617,"人工耳蜗","助听类"),
                new AssistiveDevice(1050618,"骨导式助听器","助听类"),
                new AssistiveDevice(1050627,"助听器配件","助听类"),

                new AssistiveDevice(105060601,"盒式助听器","助听类"),
                new AssistiveDevice(105060901,"眼镜式助听器","助听类"),
                new AssistiveDevice(105061501,"耳背式助听器","助听类"),
                new AssistiveDevice(105061201,"耳内式助听器","助听类"),
                new AssistiveDevice(105061301,"耳道式助听器","助听类"),
                new AssistiveDevice(105061401,"深耳道式助听器","助听类"),
                new AssistiveDevice(105061701,"人工耳蜗","助听类"),
                new AssistiveDevice(105061801,"骨导式助听器","助听类"),
                new AssistiveDevice(105062701,"助听器配件","助听类"),
                #endregion

                #region 助视类
                new AssistiveDevice(10503,"视力辅助器具","助视类"),
                new AssistiveDevice(10512,"绘画和书写辅助器具","助视类"),

                new AssistiveDevice(1050303,"滤光器","助视类"),
                new AssistiveDevice(1050306,"眼镜和隐形眼镜","助视类"),
                new AssistiveDevice(1050309,"具有放大功能的眼镜、镜片、助视系统","助视类"),
                new AssistiveDevice(1050312,"双筒望远镜和单筒望远镜","助视类"),
                new AssistiveDevice(1051203,"手动式绘画和书写器具","助视类"),
                new AssistiveDevice(1051206,"书写板、绘图板和绘画板","助视类"),
                new AssistiveDevice(1051209,"签字导向槽、印章和书写框","助视类"),
                new AssistiveDevice(1051212,"手写盲文书写装置","助视类"),
                new AssistiveDevice(1051215,"打字机","助视类"),
                new AssistiveDevice(1051218,"特制书写纸（塑膜）","助视类"),
                new AssistiveDevice(1051221,"便携式盲文记录装置","助视类"),
                new AssistiveDevice(1051224,"文字处理软件","助视类"),
                new AssistiveDevice(1051227,"绘图和绘画软件","助视类"),

                new AssistiveDevice(105030301,"低视力专用滤光镜","助视类"),
                new AssistiveDevice(105030302,"滤光器","助视类"),
                new AssistiveDevice(105030601,"眼镜和隐形眼镜","助视类"),
                new AssistiveDevice(105030901,"手持式放大镜","助视类"),
                new AssistiveDevice(105030902,"台灯式放大镜","助视类"),
                new AssistiveDevice(105030903,"折叠式放大镜","助视类"),
                new AssistiveDevice(105030904,"便携式放大镜","助视类"),
                new AssistiveDevice(105030905,"镇纸式助视器","助视类"),
                new AssistiveDevice(105030906,"可调座式放大镜","助视类"),
                new AssistiveDevice(105030907,"怀表式放大镜","助视类"),
                new AssistiveDevice(105030908,"柱面放大镜","助视类"),
                new AssistiveDevice(105030909,"照明放大镜","助视类"),
                new AssistiveDevice(105030910,"非球面镜片立式放大镜","助视类"),
                new AssistiveDevice(105030911,"立式放大镜","助视类"),
                new AssistiveDevice(105030912,"单筒放大镜","助视类"),
                new AssistiveDevice(105030913,"双目眼镜","助视类"),
                new AssistiveDevice(105030914,"单镜片夹式放大镜 ","助视类"),
                new AssistiveDevice(105030915,"球形便携式视觉读写放大镜","助视类"),
                new AssistiveDevice(105030916,"立式读写可旋式放大镜","助视类"),
                new AssistiveDevice(105030917,"滑动袖珍放大镜","助视类"),
                new AssistiveDevice(105030918,"胸挂式带灯放大镜","助视类"),
                new AssistiveDevice(105030919,"便携式电子助视器","助视类"),
                new AssistiveDevice(105030920,"手持式电子助视器","助视类"),
                new AssistiveDevice(105030921,"手持式远近两用电子助视器","助视类"),
                new AssistiveDevice(105030922,"随身看","助视类"),
                new AssistiveDevice(105030923,"便携式远近两用电子助视器","助视类"),
                new AssistiveDevice(105030924,"台式便携远近两用电子助视器","助视类"),
                new AssistiveDevice(105030925,"台式电子助视器","助视类"),
                new AssistiveDevice(105030926,"一键式智能阅读器","助视类"),
                new AssistiveDevice(105030927,"夹持三片眼镜式放大镜","助视类"),
                new AssistiveDevice(105030928,"眼镜式助视器","助视类"),
                new AssistiveDevice(105030929,"便携式眼镜电视放大镜","助视类"),
                new AssistiveDevice(105031201,"眼镜式望远镜","助视类"),
                new AssistiveDevice(105031202,"指环望远镜","助视类"),
                new AssistiveDevice(105031203,"单筒望远镜","助视类"),
                new AssistiveDevice(105031204,"双筒望远镜","助视类"),
                new AssistiveDevice(105120301,"盲人专用文具","助视类"),
                new AssistiveDevice(105120302,"盲人学习用直尺","助视类"),
                new AssistiveDevice(105120303,"盲人学习用三角尺","助视类"),
                new AssistiveDevice(105120304,"盲人学习用量角器(组合式)","助视类"),
                new AssistiveDevice(105120305,"盲人学习用圆规","助视类"),
                new AssistiveDevice(105120306,"小写字笔","助视类"),
                new AssistiveDevice(105120307,"盲文记事本","助视类"),
                new AssistiveDevice(105120601,"低视力助写板","助视类"),
                new AssistiveDevice(105120602,"盲人用绘图板","助视类"),
                new AssistiveDevice(105120603,"盲人用绘画板","助视类"),
                new AssistiveDevice(105120901,"盲人用书写框","助视类"),
                new AssistiveDevice(105120902, "盲人用印章", "助视类"),
                new AssistiveDevice(105120903, "盲人用签字导向槽", "助视类"),
                new AssistiveDevice(105121201, "易适塑料写字板4行", "助视类"),
                new AssistiveDevice(105121202, "铝合金写字板6行", "助视类"),
                new AssistiveDevice(105121203, "塑料写字板27行", "助视类"),
                new AssistiveDevice(105121204, "盲人刻字垫板", "助视类"),
                new AssistiveDevice(105121501, "盲文手动打字机", "助视类"),
                new AssistiveDevice(105121801, "特制书写纸（塑膜）", "助视类"),
                new AssistiveDevice(105122101, "便携式盲文记录装置", "助视类"),
                new AssistiveDevice(105122401, "盲文计算机编辑排版软件", "助视类"),
                new AssistiveDevice(105122402,"视觉控制计算机软件","助视类"),
                new AssistiveDevice(105122701, "盲文绘图程序", "助视类"),
                #endregion

                #region 洗漱类
                new AssistiveDevice(10333,"清洗、盆浴和淋浴辅助器具","洗漱类"),

                new AssistiveDevice(1033303,"盆浴或淋浴椅、浴室坐板、凳子、靠背和座","洗漱类"),
                new AssistiveDevice(1033306,"防滑的浴盆垫、淋浴垫和带子","洗漱类"),
                new AssistiveDevice(1033309,"淋浴器及其元件","洗漱类"),
                new AssistiveDevice(1033312,"洗浴床、淋浴桌和更换尿布桌","洗漱类"),
                new AssistiveDevice(1033315,"洗盆","洗漱类"),
                new AssistiveDevice(1033318,"坐浴盆","洗漱类"),
                new AssistiveDevice(1033321,"浴缸","洗漱类"),
                new AssistiveDevice(1033322,"洗浴床单","洗漱类"),
                new AssistiveDevice(1033327,"用于减少浴缸的长度或深度的辅助器具","洗漱类"),
                new AssistiveDevice(1033330,"带有把手、手柄和握把的洗澡布、海绵和刷子","洗漱类"),
                new AssistiveDevice(1033345,"浴缸温度计","洗漱类"),

                new AssistiveDevice(103330301,"洗浴躺椅","洗漱类"),
                new AssistiveDevice(103330302,"无扶手洗浴椅","洗漱类"),
                new AssistiveDevice(103330303,"带扶手洗浴椅","洗漱类"),
                new AssistiveDevice(103330304,"无轮洗浴椅","洗漱类"),
                new AssistiveDevice(103330305,"带轮洗浴椅","洗漱类"),
                new AssistiveDevice(103330401,"无扶手洗浴板","洗漱类"),
                new AssistiveDevice(103330402,"带扶手洗浴板","洗漱类"),
                new AssistiveDevice(103330501,"洗浴凳","洗漱类"),
                new AssistiveDevice(103330601,"地面防滑垫","洗漱类"),
                new AssistiveDevice(103330701,"浴缸防滑垫","洗漱类"),
                new AssistiveDevice(103330901,"调节淋浴头位置的固定元件","洗漱类"),
                new AssistiveDevice(103331201,"洗浴床","洗漱类"),
                new AssistiveDevice(103331202,"洗浴台","洗漱类"),
                new AssistiveDevice(103331501,"充气式洗头池","洗漱类"),
                new AssistiveDevice(103331502,"固定式洗盆","洗漱类"),
                new AssistiveDevice(103331503,"便携式洗盆","洗漱类"),
                new AssistiveDevice(103331504,"高度可调节的洗盆支架","洗漱类"),
                new AssistiveDevice(103331505,"高度可调节的洗盆底座和支架","洗漱类"),
                new AssistiveDevice(103331801, "固定坐浴盆", "洗漱类"),
                new AssistiveDevice(103331802, "便携式坐浴盆", "洗漱类"),
                new AssistiveDevice(103332101, "开门浴缸", "洗漱类"),
                new AssistiveDevice(103332201, "洗浴床单", "洗漱类"),
                new AssistiveDevice(103332701, "浴缸用一级踏板", "洗漱类"),
                new AssistiveDevice(103332702, "浴缸用二级踏板", "洗漱类"),
                new AssistiveDevice(103333001, "带有把手的海绵", "洗漱类"),
                new AssistiveDevice(103333002, "掌套式洗浴海绵", "洗漱类"),
                new AssistiveDevice(103333003, "长柄洗澡刷", "洗漱类"),
                new AssistiveDevice(103333004, "弯柄擦背刷", "洗漱类"),
                new AssistiveDevice(103333005, "带吸盘浴刷", "洗漱类"),
                new AssistiveDevice(103333006, "带有把手的洗澡布", "洗漱类"),
                new AssistiveDevice(103334501, "浴缸温度计", "洗漱类"),
                #endregion

                #region 穿衣类
                new AssistiveDevice(10303,"衣服和鞋","穿衣类"),
                new AssistiveDevice(10306,"穿着式身体防护辅助器具","穿衣类"),
                new AssistiveDevice(10307,"稳定身体的辅助器具","穿衣类"),
                new AssistiveDevice(10309,"穿脱衣服的辅助器具","穿衣类"),

                new AssistiveDevice(1030305,"外衣","穿衣类"),
                new AssistiveDevice(1030309,"帽子","穿衣类"),
                new AssistiveDevice(1030312,"分指手套和不分指手套","穿衣类"),
                new AssistiveDevice(1030315,"短外套和衬衫","穿衣类"),
                new AssistiveDevice(1030318,"夹克衫和长裤","穿衣类"),
                new AssistiveDevice(1030321,"半身裙和连衣裙","穿衣类"),
                new AssistiveDevice(1030324,"内衣","穿衣类"),
                new AssistiveDevice(1030327,"长筒袜和短袜","穿衣类"),
                new AssistiveDevice(1030330,"睡衣","穿衣类"),
                new AssistiveDevice(1030333,"浴衣","穿衣类"),
                new AssistiveDevice(1030339,"围嘴和围裙","穿衣类"),
                new AssistiveDevice(1030342,"鞋和靴","穿衣类"),
                new AssistiveDevice(1030345,"鞋和靴的防滑辅助器具","穿衣类"),
                new AssistiveDevice(1030348,"钉扣装置和纽扣","穿衣类"),
                new AssistiveDevice(1030351,"特殊系戴方式的领带","穿衣类"),
                new AssistiveDevice(1030603,"头部防护辅助器具","穿衣类"),
                new AssistiveDevice(1030606,"眼睛防护和面部防护辅助器具","穿衣类"),
                new AssistiveDevice(1030609,"耳防护和听觉防护辅助器具","穿衣类"),
                new AssistiveDevice(1030612,"肘防护或臂防护辅助器具","穿衣类"),
                new AssistiveDevice(1030615,"手部防护辅助器具","穿衣类"),
                new AssistiveDevice(1030618,"膝防护或腿防护辅助器具","穿衣类"),
                new AssistiveDevice(1030621,"足跟防护或足趾防护或足部防护辅助器具","穿衣类"),
                new AssistiveDevice(1030624,"躯干防护或全身防护辅助器具","穿衣类"),
                new AssistiveDevice(1030627,"气道防护辅助器具","穿衣类"),
                new AssistiveDevice(1030701,"稳定身体的辅助器具","穿衣类"),
                new AssistiveDevice(1030903,"穿短袜和穿连裤袜的辅助器具","穿衣类"),
                new AssistiveDevice(1030906,"鞋拔和脱靴器","穿衣类"),
                new AssistiveDevice(1030909,"穿衣架","穿衣类"),
                new AssistiveDevice(1030912,"穿脱衣钩或穿脱衣棍","穿衣类"),
                new AssistiveDevice(1030915,"拉动拉链的装置","穿衣类"),
                new AssistiveDevice(1030918,"系扣钩","穿衣类"),

                new AssistiveDevice(103030501,"乘坐轮椅的雨衣","穿衣类"),
                new AssistiveDevice(103030502,"裹身式雨衣","穿衣类"),
                new AssistiveDevice(103030901,"帽子","穿衣类"),
                new AssistiveDevice(103031201,"分指手套","穿衣类"),
                new AssistiveDevice(103031202,"不分指手套","穿衣类"),
                new AssistiveDevice(103031501, "侧开拉链式或侧开搭扣式衬衫", "穿衣类"),
                new AssistiveDevice(103031502,"侧开拉链式或侧开搭扣式外套","穿衣类"),
                new AssistiveDevice(103031801, "侧开拉链式夹克衫", "穿衣类"),
                new AssistiveDevice(103031802, "侧开拉链式长裤", "穿衣类"),
                new AssistiveDevice(103031803,"侧开搭扣式夹克衫","穿衣类"),
                new AssistiveDevice(103031804, "侧开搭扣式长裤", "穿衣类"),
                new AssistiveDevice(103031805, "侧开拉链式长裤", "穿衣类"),
                new AssistiveDevice(103032101, "半身裙", "穿衣类"),
                new AssistiveDevice(103032102, "连衣裙", "穿衣类"),
                new AssistiveDevice(103032401, "一次性内裤", "穿衣类"),
                new AssistiveDevice(103032402, "带假乳的文胸", "穿衣类"),
                new AssistiveDevice(103032701, "长筒袜", "穿衣类"),
                new AssistiveDevice(103032702, "短袜", "穿衣类"),
                new AssistiveDevice(103033001, "睡衣", "穿衣类"),
                new AssistiveDevice(103033301, "浴衣", "穿衣类"),
                new AssistiveDevice(103033901, "围嘴", "穿衣类"),
                new AssistiveDevice(103033902, "围裙", "穿衣类"),
                new AssistiveDevice(103034201, "防护鞋", "穿衣类"),
                new AssistiveDevice(103034202, "方便穿脱鞋", "穿衣类"),
                new AssistiveDevice(103034501,"鞋和靴的防滑辅助器具","穿衣类"),
                new AssistiveDevice(103034801, "钉扣装置和纽扣", "穿衣类"),
                new AssistiveDevice(103035101,"特殊系戴方式的领带","穿衣类"),
                new AssistiveDevice(103060301, "保护头盔", "穿衣类"),
                new AssistiveDevice(103060601, "防护面罩", "穿衣类"),
                new AssistiveDevice(103060602, "护目镜", "穿衣类"),
                new AssistiveDevice(103060901, "耳套", "穿衣类"),
                new AssistiveDevice(103060902, "耳塞", "穿衣类"),
                new AssistiveDevice(103060903, "降噪耳机", "穿衣类"),
                new AssistiveDevice(103061201,"肘防护或臂防护辅助器具","穿衣类"),
                new AssistiveDevice(103061501, "操纵轮椅的手套", "穿衣类"),
                new AssistiveDevice(103061801, "加厚长筒袜", "穿衣类"),
                new AssistiveDevice(103062101, "硬帮鞋", "穿衣类"),
                new AssistiveDevice(103062102, "加厚袜", "穿衣类"),
                new AssistiveDevice(103062401,"躯干防护或全身防护辅助器具","穿衣类"),
                new AssistiveDevice(103062701, "导气管", "穿衣类"),
                new AssistiveDevice(103070101, "稳定身体的辅助器具", "穿衣类"),
                new AssistiveDevice(103090301, "穿袜器", "穿衣类"),
                new AssistiveDevice(103090302, "多功能穿衣、穿鞋辅助器", "穿衣类"),
                new AssistiveDevice(103090601, "脱靴器", "穿衣类"),
                new AssistiveDevice(103090602, "长柄鞋拔", "穿衣类"),
                new AssistiveDevice(103090901, "穿衣架", "穿衣类"),
                new AssistiveDevice(103091201, "穿衣杆", "穿衣类"),
                new AssistiveDevice(103091202, "带鞋拔穿衣杆", "穿衣类"),
                new AssistiveDevice(103091203, "穿脱衣钩", "穿衣类"),
                new AssistiveDevice(103091501, "拉链器", "穿衣类"),
                new AssistiveDevice(103091801, "系扣器", "穿衣类"),
                #endregion
                
            };
            #endregion
            db.AssistiveDevices.AddRange(AssistiveDevices);
            db.SaveChanges();
            //评估
           
            #region 视力试题
            List<Question> questions1 = new List<Question> {
                new Question("1", "视力残疾等级", 1,
                    new List<Option>{
                        new Option("A","一级", "1-1-1"),
                        new Option("B","二级", "1-1-1"),
                        new Option("C","三级", "1-2"),
                        new Option("D","四级", "1-2"),
                        new Option("E","未评定或等级不准", "附加题"),
                    }
                ),
                new Question("附加题", "能否看见",1,
                    new List<Option>{
                        new Option("A", "不能（相当于一、二级）", "1-1"),
                        new Option("B", "能（相当于三、四级）", "1-2"),
                    }
                ),
                new Question("1-1", "能否听见",1,
                    new List<Option>{
                        new Option("A", "能", "1-1-1"),
                        new Option("B", "不能", "1-1-2"),
                    }
                ),
                new Question("1-1-1", "希望实现何种功能（多选）", 2,
                    new List<Option>{
                        //02 39 03盲杖
                        new Option("A", "引导出行", "2",1023903),
                        //05 18 03声音记录和播放设备(听书机)
                        new Option("B", "听书娱乐", "2",105180301),
                        //05 27 12时钟和计时器(震动闹钟/震动手表)
                        new Option("C", "时间提醒", "2", 105271204,105271205),
                        //05 24 06移动网络电话(盲人用手机) 05 33 15浏览器软件和沟通软件
                        new Option("D", "通讯交流", "2", 105240601,1053315),
                        //05 27 06声信号指示器
                        new Option("E", "生活便捷", "2", 1052706),
                        //03手动式绘画和书写器具；05 12 12手写盲文书写装置；05 12 18特制书写纸（塑膜）
                        new Option("F", "学习书写", "2", 1051203, 1051212,105121801),
                    }
                ),
                new Question("1-1-2", "希望实现何种功能（多选）", 2,
                    new List<Option>{
                        //02 39 03盲杖
                        new Option("A", "引导出行", "2", 1023903),
                        //05 27 12时钟和计时器(震动闹钟/震动手表)
                        new Option("B", "时间提醒", "2", 105271204,105271205),
                    }
                ),
                new Question("1-2", "希望看近物还是看远处（多选）", 2,
                    new List<Option>{
                        //05 03 12双筒望远镜和单筒望远镜
                        new Option("A", "看远", "1-3",1050312),
                        new Option("B", "看近", "1-2-1"),
                    }
                ),
                new Question("1-2-1", "需要光学助视器还是电子助视器",1,
                    new List<Option>{
                        //05 03 09具有放大功能的眼镜、镜片、助视系统（只选其中光学类）
                        new Option("A", "光学", "1-3", 105030901,105030903,105030904,105030905,105030906,105030907,105030908,105030909,105030910,105030911,105030912,105030913,105030914,105030915,105030916,105030917,105030927,105030928,105030929),
                        //05 03 09具有放大功能的眼镜、镜片、助视系统（只选其中电子类）
                        new Option("B", "电子", "1-3", 105030902,105030918,105030919,105030920,105030921,105030922,105030923,105030924,105030925,105030926),
                    }
                ),
                new Question("1-3", "希望实现何种功能（多选）", 2,
                    new List<Option>{
                        //05 30 21 字符阅读器；05 30 18阅读框和版面限定器；05 12 06书写板、绘图板和绘画板；05 12 15打字机
                        new Option("A", "阅读学习", "2", 1053021,1053018,1051206,1051215),
                        //05 24 03普通网络电话
                        new Option("B", "交流通讯", "2", 1052403),
                        //05 15 03手动计算器；05 15 06计算设备
                        new Option("C", "数学计算", "2", 1051503,1051506),
                        //05 21 03字母和符号卡、板
                        new Option("D", "休闲娱乐", "2", 1052103),
                        //05 33 18 用于计算机和网络的附件
                        new Option("E", "计算机使用", "2", 1053318),
                    }
                ),
                new Question("2", "是否存在眩光现象",1,
                    new List<Option>{
                        //05 03 03滤光器：低视力专用滤光镜
                        new Option("A", "是", "3", 105030301),
                        new Option("B", "否", "3"),
                    }
                ),
                new Question("3", "是否能正常说话", 1,
                    new List<Option>{
                        new Option("A", "能",null),
                        new Option("B", "不能", "3-1"),
                    }
                ),
                new Question("3-1", "是否会写字",1,
                    new List<Option>{
                        //05 12 12手写盲文书写装置；05 09 03语音发生器
                        new Option("A", "会", null,1051212,1050903),
                        new Option("B", "不会",null),
                    }
                ),
            };
            Exam exam1 = new Exam(1, "FuJuPingGu", "视力", questions1);
            db.Exams.AddOrUpdate(exam1);
            #endregion
            
            #region 听力试题
            List<Question> questions2 = new List<Question> {
                new Question("1", "听力残疾等级", 1,
                    new List<Option>{
                        ////选A时，结合年龄，系统关联
                        //6岁以下：05 06 助听器-人工耳蜗
                        //6岁-60岁：05 06 助听器(耳背/耳内/耳道/深耳道式助听器)
                        //60岁以上：05 06 06佩戴式（盒式）助听器
                        new Option("A", "一级","2", 105061501,105061201,105061301,105061401,105061701,105060601),
                        new Option("B", "二级","2", 105061501,105061201,105061301,105061401),
                        new Option("C", "三级","2", 105061501,105061201,105061301,105061401),
                        new Option("D", "四级","2", 105061501,105061201,105061301,105061401),
                        new Option("E", "未评定或等级不准","1-1"),
                    }
                ),
                new Question("1-1", "在安静环境下，不带助听设备时，能听到",1,
                    new List<Option>{
                        //选A时，结合年龄，系统关联
                        new Option("A", "几乎听不到任何声音（等同于一级）","2", 105061701,105061501,105061201,105061301,105061401,105060601),
                        new Option("B", "只能听到鞭炮、敲鼓、雷声或用力击掌声（等同于二级）","2", 105061501,105061201,105061301,105061401),
                        new Option("C", "只能听到大声说话（等同于三级）","2", 105061501,105061201,105061301,105061401),
                        new Option("D", "能听到普通谈话声（等同于四级）","2", 105061501,105061201,105061301,105061401),
                        new Option("E", "听清一般言语，能分辨清楚（不配辅助器具）","2"),
                    }
                ),
                new Question("2", "除听声外，希望实现何种功能", 1,
                    new List<Option>{
                        //05 21 09对话装置(电子手写交流板/沟通板)
                        new Option("A", "语言交流（无语言者）",null, 105210906),
                        //05 27 03视觉信号指示器(闪光门铃)
                        new Option("B", "门铃应答", null,1052703),
                        //05 27 12时钟和计时器(震动闹钟)
                        new Option("C", "叫早起床", null,105271204)
                    }
                )
            };
            Exam exam2 = new Exam(2, "FuJuPingGu", "听力", questions2);
            db.Exams.AddOrUpdate(exam2);
            #endregion

            #region 偏瘫试题
            List<Question> questions3 = new List<Question>
            {
                new Question("1", "是否卧床", 1,
                    new List<Option>{
                         new Option("A", "是","1-1-1", 105271801),
                         new Option("B", "否","1-2-1"),
                    }
                ),
                new Question("1-1-1", "能否翻身", 1,
                    new List<Option>{
                        //04家庭和家具-卧式家具（护理床）、06 33 06保护组织完整性的躺卧辅助器具（防压疮床垫）；07 33 09个人移动训练辅助器具（翻身床单）；06 33 04保护组织完整性的靠背垫和小靠背垫（体位垫）
                        new Option("A", "不能","1-1-2", 1040801,1063306,107330905,106330401),
                        //04家庭和家具-卧式家具（护理床）、06 33 06保护组织完整性的躺卧辅助器具（防压疮床垫）；06 33 04保护组织完整性的靠背垫和小靠背垫（体位垫）；04 10 09扶手（床旁护栏）
                        new Option("B", "能","1-1-2", 1040801,1063306,106330401,104100901),
                    }
                ),
                new Question("1-1-2", "能否坐起", 1,
                    new List<Option>{
                         new Option("A", "不能","1-1-3"),
                         //04 10 03靠背；02 22 18护理者操纵的轮椅（高靠背轮椅）
                         new Option("B", "能","1-1-3",1041003,102221801),
                    }
                ),
                new Question("1-1-3", "能否控制大小便", 1,
                    new List<Option>{
                         //07 09 03失禁报警器；03 30 21成人一次性尿布；03 30 18成人一次性衬垫；03 27 18尿收集系统；03 31 06阻便器（肛门插塞）
                         new Option("A", "不能","2", 1070903,1033021,1033018,1032718,103310602),
                         //03 24排尿装置(03 24 15女用穿戴式软尿壶/03 24 21男用穿戴式软尿壶)；03 12 33便盆（便携式充气便盆/塑料大便盆）
                         new Option("B", "能","2",1032415,1032421,103123301,103123302),
                    }
                ),
                new Question("1-2-1", "能否行走", 1,
                    new List<Option>{
                        new Option("A", "不能","1-2-1-1"),
                        new Option("B", "能","1-2-2"),
                    }
                ),
                new Question("1-2-1-1", "能否辅助下移动入厕", 1,
                    new List<Option>{
                        //02 22 18护理者操纵的轮椅（座便轮椅）
                        new Option("A", "不能","1-2-1-2", 102221805),
                        //02 22 03双手驱动轮椅车（功能轮椅）；或02 22 09单手驱动轮椅车(单手轮驱动轮椅/偏瘫轮椅)；或02 23 03电动轮椅车（室内型电动轮椅）
                        new Option("B", "能","1-2-1-2", 102220302,102220901,102230301),
                    }
                ),
                new Question("1-2-1-2", "是否有压疮", 1,
                    new List<Option>{
                         new Option("A", "无","1-2-1-3"),
                         //06 33 03保护组织完整性的坐垫和衬垫（防压疮坐垫）
                         new Option("B", "曾经有，已愈合","1-2-1-3", 1063303),
                         new Option("C", "有","1-2-1-3", 1063303),
                    }
                ),
                new Question("1-2-1-3", "能否站立进行床-椅转移", 1,
                    new List<Option>{
                        //07 33 09个人移动训练辅助器具（移乘带或移乘板）
                         new Option("A", "不能","2", 1073309),
                         //04 10 09扶手；或02 03 03手杖（直形四脚手杖（固定/可调））
                         new Option("B", "需要辅助","2",1041009,102030307),
                         new Option("C", "独立站立转移","2"),
                    }
                ),
                new Question("1-2-2", "行走时是否需要搀扶", 1,
                    new List<Option>{
                         new Option("A", "全程搀扶","1-2-2-1"),
                         //02 03 03手杖（单脚手杖）
                         new Option("B", "部分搀扶","2", 102030301,102030302,102030303),
                         new Option("C", "无需搀扶","2"),
                    }
                ),
                new Question("1-2-2-1", "行走时是否需要搀扶", 1,
                    new List<Option>{
                        //02 03 03手杖（S形四脚手杖（固定/可调））；或 02 38 19单侧操作助行架
                         new Option("A", "需要","2",102030309,102381901),
                         //02 03 03手杖（直形四脚手杖（固定/可调））
                         new Option("B", "不需要","2",102030307),
                    }
                ),
                new Question("2", "患侧肢体畸形状况（多选）", 2,
                    new List<Option>{
                         //01 06 21肩矫形器-肩部吊带
                         new Option("A", "肩膀下沉","3", 101062107),
                         //01 06上肢矫形器；或01 06 07手-指矫形器-分指板
                         new Option("B", "手指被动伸展","3", 10106,101060701),
                         //01 12下肢矫形器
                         new Option("C", "行走时足拖地","3", 10112),
                    }
                ),
                new Question("3", "能否自行进食", 1,
                    new List<Option>{
                        //04 30 垂直运送辅助器具-桌类（床用餐桌或轮椅桌）
                         new Option("A", "不能","4",104301901),
                         //08 18 03抓握装置（万能袖带）；10 09 18盘子和碗（普通防洒碗/底部带吸盘餐具）；10 09 21食物挡边(桌上防滑垫)；10 09食饮辅助器具-杯子（斜口杯）；10 09食饮辅助器具(叉、勺、筷子)
                         new Option("B", "需要辅助","4", 108180301,110091801,110091803,110092102,110092502,1100922,1100923,1100924),
                         new Option("C", "独立进食","4"),
                    }
                ),
                new Question("4", "能否自行洗浴", 1,
                    new List<Option>{
                        //03 33 12洗浴床、淋浴桌和更换尿布桌（洗浴床）；03 33 22清洗、盆浴和淋浴辅助器具（洗浴床单）；洗浴躺椅；03 33 15洗盆（充气式洗头池）
                         new Option("A", "不能","5", 103331201,103332201,103330301,103331501),
                         new Option("B", "能","4-1"),
                    }
                ),
                new Question("4-1", "是否站立洗浴", 1,
                    new List<Option>{
                         //03 33 06防滑的浴盆垫、淋浴垫和带子（地面防滑垫）
                         new Option("A", "是","4-2",103330601),
                         //03 33 03盆浴或淋浴椅、浴室坐板、凳子、靠背和座
                         new Option("B", "否","4-2", 1033303),
                    }
                ),
                new Question("4-2", "是否需要洗浴类自助具", 1,
                    new List<Option>{
                        //03 33 30带有把手、手柄和握把的洗澡布、海绵和刷子；03 36 06指甲锉和砂纸板；03 36 09指甲剪和指甲刀
                         new Option("A", "需要","5",1033330,1033606,1033609),
                         new Option("B", "不需要","5"),
                    }
                ),
                new Question("5", "自行如厕时，是否下蹲", 1,
                    new List<Option>{
                         new Option("A", "能","6"),
                         new Option("B", "不能","5-1"),
                    }
                ),
                new Question("5-1", "家中是否有坐便器", 1,
                    new List<Option>{
                         new Option("A", "有，且高度合适","6"),
                         //03 12 18安装在坐便器上加高的坐便器座；或03 12 21内置帮助起身、坐下的升降机构的坐便器座；或04 10 09扶手；03 12 12框架型加高的坐便器座
                         new Option("B", "有，高度较低","6", 1031218,1031221,1041009,1031212),
                         //03 12 03坐便椅
                         new Option("C", "无","6", 1031203),
                    }
                ),
                new Question("6", "能否自行穿脱衣物", 1,
                    new List<Option>{
                        //03 03 18夹克衫和长裤；03 03 42鞋和靴（方便穿脱鞋）
                         new Option("A", "不能，且高度合适","7", 1030318,1030342),
                        //03 09 12穿脱衣钩或穿脱衣棍；03 09 03穿短袜和穿连裤袜的辅助器具；03 09 06鞋拔和脱靴器（长柄鞋拔）
                         new Option("B", "辅助下完成","7", 1030912,1030903,103090602),
                         new Option("C", "独立完成","7"),
                    }
                ),
                new Question("7", "是否经常需要够拾远处物品", 1,
                    new List<Option>{
                         new Option("A", "否","8"),
                         //08 21 03手动抓取钳（折叠式长柄取物器/非折叠式长柄取物器）
                         new Option("B", "是","8",108210301,108210302),
                    }
                ),
                new Question("8", "是否存在其他方面残疾", 1,
                    new List<Option>{
                         new Option("A", "无","9"),
                         new Option("B", "视力",1,"9"),
                         new Option("C", "听力",2,"9"),
                         new Option("D", "其它","9"),
                    }
                ),
                new Question("9", "最希望解决什么问题（最多选择三个）", 2,
                    new List<Option>{
                         new Option("A", "轮椅代步",null),
                         new Option("B", "辅助行走",null),
                         new Option("C", "饮食",null),
                         new Option("D", "个人护理",null),
                         new Option("E", "如厕",null),
                         new Option("F", "信息交流",null),
                         new Option("G", "康复训练",null),
                         new Option("H", "防护功能",null),
                         new Option("I", "无障碍环境",8,null),
                         new Option("J", "操作和使用",null),
                         new Option("K", "位置转移",null),
                         new Option("L", "纠正姿势",null),
                         new Option("M", "假肢",7,null),
                         new Option("N", "矫形器",null),
                         new Option("O", "助听类",null),
                         new Option("P", "助视类",null),
                         new Option("Q", "洗漱类",null),
                         new Option("R", "穿衣类",null),
                    }
                ),
            };
            Exam exam3 = new Exam(3, "FuJuPingGu", "偏瘫", questions3);
            db.Exams.AddOrUpdate(exam3);
            #endregion

            #region 脑瘫试题
            List<Question> questions4 = new List<Question>
            {
                new Question("1", "年龄", 1,
                    new List<Option>{
                         new Option("A", "≤7岁","2-1"),
                         new Option("B", ">7岁","3-1"),
                    }
                ),
                #region 年龄（<= 7）岁
                new Question("2-1", "能否完成“坐起”动作", 1,
                    new List<Option>{
                         new Option("A", "完全不能","2-1-1"),
                         new Option("B", "需要辅助完成","2-1-2"),
                         new Option("C", "无需辅助能独立完成","2-1-2"),
                    }
                ),
                new Question("2-1-1", "能否翻身", 1,
                    new List<Option>{
                         new Option("A", "完全不能","2-1-1-1"),
                         //06 33 04保护组织完整性的靠背垫和小靠背垫(楔形垫)；02 22 18护理者操纵的轮椅车(0-3岁为儿童轮椅；4-7岁为儿童脑瘫轮椅)
                         new Option("B", "需要辅助","2-2",106330402,1022218),
                         //04 09 21特殊坐具（0-3岁为儿童三角椅，4-7岁为儿童坐姿椅）或02 22 18护理者操纵的轮椅车(0-3岁为儿童轮椅；4-7岁为儿童脑瘫轮椅)
                         new Option("C", "无需辅助独立完成","2-2",1040921,102218),
                    }
                ),
                new Question("2-1-1-1", "能否抬头", 1,
                    new List<Option>{
                         //06 33 04保护组织完整性的靠背垫和小靠背垫（体位变换组合垫）
                         new Option("A", "完全不能","2-2",106330401),
                         //06 33 04保护组织完整性的靠背垫和小靠背垫(楔形垫)；02 22 18护理者操纵的轮椅车(0-3岁为儿童轮椅；4-7岁为儿童脑瘫轮椅)
                         new Option("B", "短暂抬头，不能维持","2-2",106330402,1022218),
                         //06 33 04保护组织完整性的靠背垫和小靠背垫(楔形垫)；02 22 18护理者操纵的轮椅车(0-3岁为儿童轮椅；4-7岁为儿童脑瘫轮椅)
                         new Option("C", "能抬头且能维持","2-2",106330402,1022218),
                    }
                ),
                new Question("2-1-2", "能否维持坐位", 1,
                    new List<Option>{
                        //04 09 21特殊坐具(0-3岁为三角椅，4-7岁为儿童坐姿椅)；02 22 18护理者操纵的轮椅车(0-3岁为儿童轮椅；4-7岁为儿童脑瘫轮椅)
                         new Option("A", "完全不能","2-2",1040921,1022218),
                         //04 09 21特殊坐具(0-3岁为三角椅，4-7岁为儿童坐姿椅)；02 22 18护理者操纵的轮椅车(0-3岁为儿童轮椅；4-7岁为儿童脑瘫轮椅)
                         new Option("B", "辅助下可维持","2-2",1040921,1022218),
                         new Option("C", "无需辅助可独坐","2-1-2-1"),
                    }
                ),
                new Question("2-1-2-1", "能否爬行", 1,
                    new List<Option>{
                         new Option("A", "完全不能","2-1-2-1-1"),
                         new Option("B", "辅助下爬行 ","2-1-2-1-1"),
                         new Option("C", "独立爬行 ","2-2"),
                    }
                ),
                new Question("2-1-2-1-1", "能否进行手、肘支撑", 1,
                    new List<Option>{
                         //01 06 19肘腕手矫形器；06 48爬行训练辅助器具(儿童爬行架)
                         new Option("A", "完全不能","2-2",1010619,106483101),
                         //01 06 19肘腕手矫形器；06 48爬行训练辅助器具(儿童爬行架)
                         new Option("B", "短暂支撑，不能维持","2-2",1010619,106483101),
                         new Option("C", "能支撑且能维持","2-1-2-1-1-1"),
                    }
                ),
                new Question("2-1-2-1-1-1", "能否完成“站起”动作", 1,
                    new List<Option>{
                         //06 48 15上肢训练器械、躯干训练器械和下肢训练器械(肋木)
                         new Option("A", "完全不能","2-2",1064815),
                         //02 06 03框式助行架(阶梯框式助行器)
                         new Option("B", "需要辅助","2-2",102060303),
                         new Option("C", "无需辅助独立完成","2-1-2-1-1-1-1"),
                    }
                ),
                new Question("2-1-2-1-1-1-1", "能否维持站立", 1,
                    new List<Option>{
                         //06 48 08站立架和站立支撑台(儿童用仰卧式站立架)
                         new Option("A", "完全不能","2-2",106480802),
                         //06 48 08站立架和站立支撑台(儿童用直立式站立架)、儿童助行架
                         new Option("B", "需要辅助","2-2",106480801),
                         //02 06 06轮式助行器(后置四轮助行器)
                         new Option("C", "无需辅助可独站","2-2",102060607),
                    }
                ),
                new Question("2-2", "是否存在畸形", 1,
                    new List<Option>{
                         new Option("A", "不存在畸形","2-3"),
                         new Option("B", "存在畸形","2-2-1"),
                    }
                ),
                new Question("2-2-1", "存在畸形部位（多选）", 2,
                    new List<Option>{
                         //上肢矫形器
                         new Option("A", "上肢畸形","2-3",10106),
                         //躯干矫形器
                         new Option("B", "躯干畸形","2-3",10103,10104),
                         //下肢矫形器
                         new Option("C", "下肢畸形","2-3",10112,10133),
                    }
                ),
                new Question("2-3", "能否够独立进食、饮水", 1,
                    new List<Option>{
                         new Option("A", "不能","2-3-1"),
                         new Option("B", "能","2-4"),
                    }
                ),
                new Question("2-3-1", "双手是否能够抓握", 1,
                    new List<Option>{
                         //08 18 03抓握装置(万能袖带)；10 09杯子(大耳杯，改为大耳杯架)；10 09 18碗(防洒碗)；10 09 21食物挡边(桌上防滑垫)；10 09叉（粗柄叉）、勺(粗柄勺)
                         new Option("A", "完全不能","2-4",108180301,110092503,1100918,110092102,110092201,110092303),
                         //08 18 03抓握装置(万能袖带)；10 09杯子(大耳杯，改为大耳杯架)；10 09 18碗(防洒碗)；10 09 21食物挡边(桌上防滑垫)；10 09叉（粗柄叉）、勺(粗柄勺)
                         new Option("B", "短暂抓握，不能维持","2-4",108180301,110092503,1100918,110092102,110092201,110092303),
                         new Option("C", "能抓握且维持","2-4"),
                    }
                ),
                new Question("2-4", "能否独立上厕所", 1,
                    new List<Option>{
                         //03 30 12儿童用一次性失禁用品(儿童尿不湿)；03 12 33便盆
                         new Option("A", "不能","6",103301201,1031233),
                         new Option("B", "能","6"),
                    }
                ),
                #endregion
                #region 年龄（>7）岁
                new Question("3-1", "能否完成“坐起”动作", 1,
                    new List<Option>{
                         new Option("A", "完全不能","3-1-1"),
                         new Option("B", "需要辅助完成","3-1-2"),
                         new Option("C", "无需辅助能独立完成","3-1-2"),
                    }
                ),
                new Question("3-1-1", "能否翻身", 1,
                    new List<Option>{
                         new Option("A", "完全不能","3-1-1-1"),
                         //06 33 04保护组织完整性的靠背垫和小靠背垫(楔形垫)；02 22 18护理者操纵的轮椅车(脑瘫轮椅)；04家庭和家具-卧式家具（护理床）；06 33 06保护组织完整性的躺卧辅助器具（防压疮床垫）
                         new Option("B", "需要辅助","3-2",106330402,1022218,1040801,1063306),
                         //02 22 18护理者操纵的轮椅车-高靠背轮椅（带坐便/带轮椅桌）
                         new Option("C", "无需辅助独立完成","3-2",102221801),
                    }
                ),
                new Question("3-1-1-1", "是否能抬头", 1,
                    new List<Option>{
                         //06 33 04保护组织完整性的靠背垫和小靠背垫（体位变换组合垫）；04家庭和家具-卧式家具（护理床）；06 33 06保护组织完整性的躺卧辅助器具（防压疮床垫）
                         new Option("A", "完全不能","3-2",106330401,1040801,1063306),
                         //06 33 04保护组织完整性的靠背垫和小靠背垫(楔形垫)；02 22 18护理者操纵的轮椅车(脑瘫轮椅)；04家庭和家具-卧式家具（护理床）；06 33 06保护组织完整性的躺卧辅助器具（防压疮床垫）；04 10 09扶手(床旁护栏)
                         new Option("B", "短暂抬头，不能维持","3-2",106330402,1022218,1040801,1063306,104100901),
                         //06 33 04保护组织完整性的靠背垫和小靠背垫(楔形垫)；02 22 18护理者操纵的轮椅车(脑瘫轮椅)；04家庭和家具-卧式家具（护理床）；06 33 06保护组织完整性的躺卧辅助器具（防压疮床垫）；04 10 09扶手(床旁护栏)
                         new Option("C", "能抬头且能维持","3-2",106330402,1022218,1040801,1063306,104100901),
                    }
                ),
                new Question("3-1-2", "能否维持坐位", 1,
                    new List<Option>{
                         //02 22 18护理者操纵的轮椅车(脑瘫轮椅)；04 10 03靠背（可调靠背）
                         new Option("A", "完全不能","3-2",1022218,104100301),
                         //02 22 18护理者操纵的轮椅车(脑瘫轮椅)；04 10 03靠背（可调靠背）
                         new Option("B", "辅助下可维持","3-2",1022218,104100301),
                         new Option("C", "无需辅助可独坐","3-1-2-1"),
                    }
                ),
                new Question("3-1-2-1", "能否完成“站起”动作", 1,
                    new List<Option>{
                        //02 22 03双手驱动轮椅车(普通轮椅)；07 33 09个人移动训练辅助器具（转移腰带、移乘带，改为移乘带）
                         new Option("A", "完全不能","3-2",102220301,1073309),
                         //06 48 08站立架和站立支撑台(站立架)、02 06 03框式助行架(阶梯框式助行器)；07 33 09个人移动训练辅助器具（转移腰带、移乘带，改为移乘带）
                         new Option("B", "需要辅助","3-2",1064808,102060303,1073309),
                         new Option("C", "无需辅助独立完成","3-1-2-1-1"),
                    }
                ),
                new Question("3-1-2-1-1", "能否维持站立", 1,
                    new List<Option>{
                        //06 48 08站立架和站立支撑台(站立架)
                         new Option("A", "完全不能","3-2",1064808),
                         //06 48 08站立架和站立支撑台(站立架)、02 06 06轮式助行器(后置四轮助行器)
                         new Option("B", "需要辅助","3-2",1064808,102060607),
                         new Option("C", "无需辅助可独站","3-1-2-1-1-1"),
                    }
                ),
                new Question("3-1-2-1-1-1", "能否行走", 1,
                    new List<Option>{
                         new Option("A", "完全不能","3-2"),
                         //02 06 06轮式助行器(后置四轮助行器)
                         new Option("B", "需要较多辅助","3-2",102060607),
                         //02 03 12腋拐(儿童腋拐)
                         new Option("C", "需要较少辅助","3-2",102031207),
                         new Option("D", "无需辅助独立行走","3-2"),
                    }
                ),
                new Question("3-2", "是否存在畸形", 1,
                    new List<Option>{
                         new Option("A", "不存在畸形","3-3"),
                         new Option("B", "存在畸形","3-2-1"),
                    }
                ),
                new Question("3-2-1", "存在畸形部位（多选）", 2,
                    new List<Option>{
                         //上肢矫形器
                         new Option("A", "上肢畸形","3-3",10106),
                         //躯干矫形器
                         new Option("B", "躯干畸形","3-3",10103,10104),
                         //下肢矫形器
                         new Option("B", "下肢畸形","3-3",10112,10133),
                    }
                ),
                new Question("3-3", "能否够独立进食、饮水", 1,
                    new List<Option>{
                         new Option("A", "不能","3-3-1"),
                         new Option("B", "能","3-4"),
                    }
                ),
                new Question("3-3-1", "双手是否能够抓握（单选）", 1,
                    new List<Option>{
                        //08 18 03抓握装置(万能袖带)；10 09杯子(大耳杯，改为大耳杯架)；10 09 18碗(防洒碗)；10 09 21食物挡边(桌上防滑垫)；10 09叉（粗柄叉）、勺(粗柄勺)
                         new Option("A", "完全不能","3-4",108180301,110092503,1100918,110092102,110092201,110092303),
                         //08 18 03抓握装置(万能袖带)；10 09杯子(大耳杯，改为大耳杯架)；10 09 18碗(防洒碗)；10 09 21食物挡边(桌上防滑垫)；10 09叉（粗柄叉）、勺(粗柄勺)
                         new Option("B", "短暂抓握，不能维持","3-4",108180301,110092503,1100918,110092102,110092201,110092303),
                         new Option("C", "能抓握且维持","3-4"),
                    }
                ),
                new Question("3-4", "能否独立上厕所", 1,
                    new List<Option>{
                        //03 30 21成人一次性尿布(成人纸尿裤)；03 30 18成人一次性衬垫(纸质尿衬垫)；03 12 33便盆；
                         new Option("A", "不能","3-5",103302101,103301801,1031233),
                         new Option("B", "能","3-5"),
                    }
                ),
                new Question("3-5", "洗浴时是否能站立", 1,
                    new List<Option>{
                        //03 33 03盆浴或淋浴椅（有轮和无轮)-洗浴椅
                         new Option("A", "不能","6",103330302,103330303,103330304,103330305),
                         new Option("B", "能","6"),
                    }
                ),
                #endregion
                new Question("6", "是否存在其他方面残疾", 1,
                    new List<Option>{
                         new Option("A", "无","7"),
                         new Option("B", "视力",1,"7"),
                         new Option("C", "听力",2,"7"),
                         new Option("D", "其它","7"),
                    }
                ),
                 new Question("7", "最希望解决什么问题（最多选择三个）",2,
                    new List<Option>{
                         new Option("A", "轮椅代步",null),
                         new Option("B", "辅助行走",null),
                         new Option("C", "饮食",null),
                         new Option("D", "个人护理",null),
                         new Option("E", "如厕",null),
                         new Option("F", "信息交流",null),
                         new Option("G", "康复训练",null),
                         new Option("H", "防护功能",null),
                         new Option("I", "无障碍环境",8,null),
                         new Option("J", "操作和使用",null),
                         new Option("K", "位置转移",null),
                         new Option("L", "纠正姿势",null),
                         new Option("M", "假肢",7,null),
                         new Option("N", "矫形器",null),
                         new Option("O", "助听类",null),
                         new Option("P", "助视类",null),
                         new Option("Q", "洗漱类",null),
                         new Option("R", "穿衣类",null),
                    }
                ),
            };
            Exam exam4 = new Exam(4, "FuJuPingGu", "脑瘫", questions4);
            db.Exams.AddOrUpdate(exam4);
            #endregion

            #region 脊髓试题
            List<Question> questions5 = new List<Question>
            {
                new Question("1", "是否卧床", 1,
                    new List<Option>{
                        //04家庭和家具-卧式家具（护理床）、06 33 06保护组织完整性的躺卧辅助器具（防压疮床垫）；06 33 04保护组织完整性的靠背垫和小靠背垫（体位垫）；07 33 09个人移动训练辅助器具（翻身床单）；05 27 18 个人紧急报警系统（呼叫器）；03 03 18夹克衫和长裤
                         new Option("A", "是","1-1",1040801,1063306,106330401,107330905,105271801,1030318),
                         //02 22 03双手驱动轮椅车（功能轮椅），选配02 23 03电动轮椅车（普通电动轮椅）；06 33 03保护组织完整性的座垫和衬垫（防压疮坐垫）08 21 03手动抓取钳（折叠式长柄取物器/非折叠式长柄取物器）
                         new Option("B", "否","1-4",102220302,102230304,1063303,108210301,108210302),
                    }
                ),
                new Question("1-1", "双手是否具有抓握能力", 1,
                    new List<Option>{
                        //04 10 09扶手（床护栏杆/床旁护栏）；07 33 09个人移动训练辅助器具（起身绳梯）；08 21 03手动抓取钳（折叠式长柄取物器/非折叠式长柄取物器）
                         new Option("A", "是","1-2",104100901,107330907,108210301,108210302),
                         new Option("B", "否","1-2"),
                    }
                ),
                new Question("1-2", "能否保持坐位", 1,
                    new List<Option>{
                        //02 22 18护理者操纵的轮椅车-高靠背轮椅（带坐便/带轮椅桌）；选配（不选床的情况下）：04 10 03靠背（可调靠背/架）；04 30 垂直运送辅助器具-桌类（床用餐桌）
                         new Option("A", "能","1-3",102221801,104100301,104301901),
                         new Option("B", "不能","1-3"),
                    }
                ),
                new Question("1-3", "能否控制大小便", 1,
                    new List<Option>{
                        //03 24排尿装置(03 24 15女用穿戴式软尿壶/03 24 21男用穿戴式软尿壶)；03 12 33便盆
                         new Option("A", "能","2",1032415,1032421,1031233),
                         //07 09 03失禁报警器；03 30 21成人一次性尿布或03 30 18成人一次性衬垫；03 27 18尿收集系统；03 31 06阻便器（肛门插塞）
                         new Option("B", "不能","2",1070903,1033021,1033018,1032718,103310602),
                    }
                ),
                new Question("1-4", "双手支撑能否使臀部离开椅面", 1,
                    new List<Option>{
                         new Option("A", "能","1-5"),
                         //07 33 09个人移动训练辅助器具（移乘板或移乘带）
                         new Option("B", "不能","1-5",1073309),
                    }
                ),
               new Question("1-5", "能否经常自行远距离出行", 1,
                    new List<Option>{
                         //02 18 09手摇三轮车，选配02 23 09机动轮椅车
                         new Option("A", "能","1-6",1021809,1022309),
                         new Option("B", "不能","1-6"),
                    }
                ),
               new Question("1-6", "是否有站立需求", 1,
                    new List<Option>{
                        //脊柱矫形器
                         new Option("A", "有","1-6-1",1010327),
                         new Option("B", "无","1-7"),
                    }
                ),
               new Question("1-6-1", "能否自行站立", 1,
                    new List<Option>{
                        //下肢矫形器
                         new Option("A", "是","1-6-1-1",10112),
                         //选配02 23 03电动轮椅车（站立电动轮椅）
                         new Option("B", "否","1-7",102230305),
                    }
                ),
               new Question("1-6-1-1", "是否能行走", 1,
                    new List<Option>{
                        //02 06 03框式助行架；或02 03 12腋拐，选配02 03 06肘拐
                         new Option("A", "能","1-7",1020603,1020312,1020306),
                         //02 06 03框式助行架
                         new Option("B", "不能","1-7",1020603),
                    }
                ),
               new Question("1-7", "能否控制大小便", 1,
                    new List<Option>{
                         new Option("A", "能","1-7-1"),
                         //03 30 21成人一次性尿布(成人纸尿裤)；03 27 18尿收集系统
                         new Option("B", "不能","2",103302101,1032718),
                    }
                ),
               new Question("1-7-1", "能否自行如厕", 1,
                    new List<Option>{
                         new Option("A", "能","1-7-1-1"),
                         //03 12 03坐便椅
                         new Option("B", "不能","2",1031203),
                    }
                ),
               new Question("1-7-1-1", "家中是否有坐便器（单选）", 1,
                    new List<Option>{
                         new Option("A", "有","2"),
                         //03 12 03坐便椅
                         new Option("B", "无","2",1031203),
                    }
                ),
               new Question("2", "能否自主进食", 1,
                    new List<Option>{
                        //选配10 09 27喂食器械（电动喂食机）
                         new Option("A", "不能","3",110092701),
                         //08 18 03抓握装置（万能袖带），选配10 09食饮辅助器具(叉、勺、筷子)；10 09 18盘子和碗；10 09食饮辅助器具-杯子(斜口杯/吸管杯/大耳杯)；10 09 21食物挡边(桌上防滑垫)
                         new Option("B", "辅助下完成","2-1",108180301,1100922,1100923,1100924,1100918,110092502,110092503,110092504,110092102),
                         new Option("C", "独立完成","3"),
                    }
                ),
               new Question("2-1", "手部是否有畸形", 1,
                    new List<Option>{
                        //上肢矫形器
                         new Option("A", "有","3",10106),
                         new Option("B", "无","3"),
                    }
                ),
               new Question("3", "能否自主洗浴", 1,
                    new List<Option>{
                        //03 33 03盆浴或淋浴椅（有轮和无轮）-洗浴躺椅，选配03 33 12洗浴床（洗浴床）或03 33清洗、盆浴和淋浴辅助器具-洗浴床单（洗浴床单）；03 33 15洗盆（充气式洗头池）
                         new Option("A", "不能","4",103330301,103331201,103332201,103331501),
                         //03 33 03盆浴或淋浴椅（有轮和无轮)-洗浴椅；选配03 33 06防滑的淋浴垫和带子（地面防滑垫）；03 33 30带有把手、手柄和握把的洗澡布、海绵和刷子
                         new Option("B", "辅助下完成","4",103330302,103330303,103330304,103330305,103330601,1033330),
                         //03 33 03盆浴或淋浴椅（有轮和无轮)-洗浴椅；选配03 33 06防滑的淋浴垫和带子（地面防滑垫）
                         new Option("C", "独立完成","4",103330302,103330303,103330304,103330305,103330601),
                    }
                ),
               new Question("4", "能否自行穿脱衣物", 1,
                    new List<Option>{
                        //选配03 03 18夹克衫和长裤
                         new Option("A", "不能","5",1030318),
                         //选配03 09 18系扣钩（系扣器），03 09 03穿短袜和穿连裤袜的辅助器具（穿袜器），03 09 15拉动拉链的装置（拉链器）
                         new Option("B", "辅助下完成","5",103091801,103090301,103091501),
                         new Option("C", "独立完成","5"),
                    }
                ),
                new Question("5", "是否存在其他方面残疾", 1,
                    new List<Option>{
                         new Option("A", "无","6"),
                         new Option("B", "视力",1,"6"),
                         new Option("C", "听力",2,"6"),
                         new Option("D", "其它","6"),
                    }
                ),
                 new Question("6", "最希望解决什么问题（最多选择三个）", 2,
                    new List<Option>{
                         new Option("A", "轮椅代步",null),
                         new Option("B", "辅助行走",null),
                         new Option("C", "饮食",null),
                         new Option("D", "个人护理",null),
                         new Option("E", "如厕",null),
                         new Option("F", "信息交流",null),
                         new Option("G", "康复训练",null),
                         new Option("H", "防护功能",null),
                         new Option("I", "无障碍环境",8,null),
                         new Option("J", "操作和使用",null),
                         new Option("K", "位置转移",null),
                         new Option("L", "纠正姿势",null),
                         new Option("M", "假肢",7,null),
                         new Option("N", "矫形器",null),
                         new Option("O", "助听类",null),
                         new Option("P", "助视类",null),
                         new Option("Q", "洗漱类",null),
                         new Option("R", "穿衣类",null),
                    }
                ),
            };
            Exam exam5 = new Exam(5, "FuJuPingGu", "脊髓", questions5);
            db.Exams.AddOrUpdate(exam5);
            #endregion

            #region 肢体试题
            List<Question> questions6 = new List<Question>
            {
                new Question("1", "肢体是否有残缺", 1,
                    new List<Option>{
                         new Option("A", "有","2"),
                         new Option("B", "无","2"),
                    }
                ),
                new Question("2", "是否存在畸形", 1,
                    new List<Option>{
                         new Option("A", "有","2-1"),
                         new Option("B", "无","3"),
                    }
                ),
               new Question("2-1", "畸形能否用手矫正", 1,
                    new List<Option>{
                         new Option("A", "能","3"),
                         new Option("B", "不能","3"),
                    }
                ),
               new Question("3", "是否卧床", 1,
                    new List<Option>{
                        //04家庭和家具-卧式家具（护理床）、06 33 06保护组织完整性的躺卧辅助器具（防压疮床垫）；06 33 04保护组织完整性的靠背垫和小靠背垫（体位垫）；07 33 09个人移动训练辅助器具（翻身床单）；05 27 18 个人紧急报警系统（呼叫器）；03 03 18夹克衫和长裤
                         new Option("A", "是","3-1"),
                         new Option("B", "否","3-4"),
                    }
                ),
               new Question("3-1", "手能否抓握", 1,
                    new List<Option>{
                         new Option("A", "双手均无","3-2"),
                         //04 10 09扶手（床旁护栏）；08 21 03手动抓取钳（长柄取物器）
                         new Option("B", "单手有","3-2",104100901,108210301),
                         //04 10 09扶手（床旁护栏）；07 33 09个人移动训练辅助器具（起身绳梯）；08 21 03手动抓取钳（折叠式长柄取物器/非折叠式长柄取物器）
                         new Option("C", "双手均有","3-2",104100901,107330907,108210301,108210302),
                    }
                ),
               new Question("3-2", "能否保持坐位", 1,
                    new List<Option>{
                        //02 22 18护理者操纵的轮椅车-高靠背轮椅（带坐便/带轮椅桌）；选配（不选床的情况下）：04 10 03靠背（可调靠架）；04 30 垂直运送辅助器具-桌类（床用餐桌）；03 33 03洗浴躺椅
                         new Option("A", "能","3-3",102221801,104100301,104301901,1033303),
                         //03 33 12洗浴床、淋浴桌和更换尿布桌（洗浴床）或03 33清洗、盆浴和淋浴辅助器具（洗浴床单）；03 33 15洗盆（充气式洗头池）
                         new Option("B", "不能","3-3",103331201,103332201,103331501),
                    }
                ),

               //3-1选A并3-2选A，问3-2-1
               //3-1选B并3-2选A：10 09 18盘子和碗（1100918）；10 09 21食物挡边(桌上防滑垫)（110092102）
                new Question("3-2-1", "能否完成手到嘴的动作", 1,
                    new List<Option>{
                        //08 18 03抓握装置（万能袖带），选配10 09食饮辅助器具(叉、勺、筷子)；10 09 18盘子和碗；10 09食饮辅助器具-杯子(斜口杯/吸管杯/大耳杯)；10 09 21食物挡边(桌上防滑垫)
                         new Option("A", "能","3-3",108180301,1100922,1100923,1100924,1100918,110092502,110092503,110092504,110092102),
                         new Option("B", "不能","3-3"),
                    }
                ),

                new Question("3-3", "能否控制大小便", 1,
                    new List<Option>{
                        //03 24排尿装置(03 24 15女用穿戴式软尿壶/03 24 21男用穿戴式软尿壶)；03 12 33便盆
                         new Option("A", "能","4",1032415,1032421,1031233),
                         //07 09 03失禁报警器；03 30 21成人一次性尿布或03 30 18成人一次性衬垫；03 27储尿袋及尿收集系统；03 31 06阻便器（肛门插塞）
                         new Option("B", "不能","4",1070903,1033021,1033018,10327,103310602),
                    }
                ),
                new Question("3-4", "能否行走", 1,
                    new List<Option>{
                        //02 22 03双手驱动轮椅车（功能轮椅），选配02 23 03电动轮椅车（普通电动轮椅）；06 33 03保护组织完整性的座垫和衬垫（防压疮坐垫）；03 33 03盆浴或淋浴椅（有轮和无轮)-洗浴椅
                         new Option("A", "不能","3-4-1",102220302,102230304,1063303,103330302,103330303,103330304,103330305),
                         new Option("B", "能","3-4-7"),
                    }
                ),
                new Question("3-4-1", "双手能否将臀部支撑离开椅面", 1,
                    new List<Option>{
                         new Option("A", "能","3-4-2"),
                         //07 33 09个人移动训练辅助器具（移乘板或移乘带）
                         new Option("B", "不能","3-4-2",107330902,107330903),
                    }
                ),
                new Question("3-4-2", "是否经常自行远距离出行", 1,
                    new List<Option>{
                        //02 18 09手摇三轮车，选配02 23 09机动轮椅车
                         new Option("A", "是","3-4-3",1021809,1022309),
                         new Option("B", "否","3-4-3"),
                    }
                ),
                new Question("3-4-3", "是否有站立需求", 1,
                    new List<Option>{
                         new Option("A", "有","3-4-3-1"),
                         new Option("B", "无","3-4-4"),
                    }
                ),
                new Question("3-4-3-1", "能否自行站立", 1,
                    new List<Option>{
                        //并3-4-1选A：02 06 03框式助行架（阶梯框式助行架）
                        //并3-4-1选B：选配02 23 03电动轮椅车（站立电动轮椅）
                         new Option("A", "否","3-4-4"),
                         new Option("B", "是","3-4-4"),
                    }
                ),
                new Question("3-4-4", "能否控制大小便", 1,
                    new List<Option>{
                        //03 30 21成人一次性尿布(成人纸尿裤)；03 27 18尿收集系统
                         new Option("A", "不能","3-4-5",103302101,1032718),
                         new Option("B", "能","3-4-4-1"),
                    }
                ),
                new Question("3-4-4-1", "能否自行如厕", 1,
                    new List<Option>{
                         new Option("A", "能","3-4-4-1-1"),
                         //03 12 03坐便椅
                         new Option("B", "不能","3-4-5",1031203),
                    }
                ),
                new Question("3-4-4-1-1", "家中是否有坐便器", 1,
                    new List<Option>{
                         new Option("A", "有","3-4-5"),
                         //03 12 03坐便椅
                         new Option("B", "无","3-4-5",1031203),
                    }
                ),
                new Question("3-4-5", "手能否抓握", 1,
                    new List<Option>{
                         new Option("A", "双手均无","3-4-5-1"),
                         //10 09 18盘子和碗；10 09 21食物挡边(桌上防滑垫)；08 21 03手动抓取钳（长柄取物器）；03 33 30带有把手、手柄和握把的洗澡布、海绵和刷子
                         new Option("B", "单手有","3-4-6",1100918,110092102,108210301,1033330),
                         //08 21 03手动抓取钳（长柄取物器）
                         new Option("C", "双手均有","3-4-6",108210301),
                    }
                ),
                new Question("3-4-5-1", "能否完成手到嘴的动作", 1,
                    new List<Option>{
                        //08 18 03抓握装置（万能袖带），选配10 09食饮辅助器具(叉、勺、筷子)；10 09 18盘子和碗；10 09食饮辅助器具-杯子(斜口杯/吸管杯/大耳杯)；10 09 21食物挡边(桌上防滑垫)；03 33 30带有把手、手柄和握把的洗澡布、海绵和刷子
                         new Option("A", "能","3-4-6",108180301,1100922,1100923,1100924,1100918,110092502,110092503,110092504,110092102,1033330),
                         new Option("B", "不能","3-4-6"),
                    }
                ),
                new Question("3-4-6", "能否自行穿脱衣物", 1,
                    new List<Option>{
                        //选配03 03 18夹克衫和长裤
                         new Option("A", "不能","4",1030318),
                         //选配03 09 18系扣钩（系扣器），03 09 03穿短袜和穿连裤袜的辅助器具（穿袜器），03 09 15拉动拉链的装置（拉链器）
                         new Option("B", "辅助下完成","4",103091801,103090301,103091501),
                         new Option("C", "独立完成","4"),
                    }
                ),
                new Question("3-4-7", "能否长时间行走", 1,
                    new List<Option>{
                         new Option("A", "否","3-4-7-1"),
                         new Option("B", "是","3-4-7-3"),
                    }
                ),
                new Question("3-4-7-1", "手能否抓握", 1,
                    new List<Option>{
                        //07 33 09个人移动训练辅助器具（移乘带）
                         new Option("A", "双手均无","3-4-7-2",1073309),
                         //02 03 03手杖（四脚手杖或单侧操作助行架）
                         new Option("B", "单手有","3-4-7-2",102030307,102030308,102030309,1023819),
                         //02 06 03框式助行架（阶梯框式助行架）
                         new Option("C", "双手均有","3-4-7-2",1020603),
                    }
                ),
                new Question("3-4-7-2", "是否需要经常出门", 1,
                    new List<Option>{
                        //02 22 18护理者操纵的轮椅车（护理轮椅）
                         new Option("A", "否","3-4-8",102221802),
                         //02 22 03双手驱动轮椅车（普通轮椅），选配02 23 03电动轮椅车（普通电动轮椅）
                         new Option("B", "是","3-4-8",102220301,102230304),
                    }
                ),
                new Question("3-4-7-3", "行走时是否需要人搀扶", 1,
                    new List<Option>{
                         new Option("A", "全程搀扶","3-4-7-3-1"),
                         //02 03单臂操作助行器（单脚手杖，选配肘拐，国内少用）
                         new Option("B", "部分搀扶","3-4-8",10203),
                         new Option("C", "无需搀扶","3-4-7-3-2"),
                    }
                ),
                new Question("3-4-7-3-1", "手的抓握能力", 1,
                    new List<Option>{
                        //02 06 12台式助行器
                         new Option("A", "双手均无","3-4-8",1020612),
                         //02 03 03手杖（四脚手杖或单侧操作助行架）
                         new Option("B", "单手有","3-4-8",102030307,102030308,102030309,1023819),
                         //02 06 03框式助行架；02 03 12腋拐
                         new Option("C", "双手均有","3-4-8",1020603,1020312),
                    }
                ),
                new Question("3-4-7-3-2", "户外行走是否需要支撑", 1,
                    new List<Option>{
                        //02 06 06轮式助行器
                         new Option("A", "较多支撑","3-4-8",1020606),
                         //02 03 18带座手杖
                         new Option("B", "较少支撑","3-4-8",1020318),
                         new Option("C", "无需支撑","3-4-8"),
                    }
                ),
                new Question("3-4-8", "家中是否有坐便器", 1,
                    new List<Option>{
                         new Option("A", "无","3-4-8-1"),
                         new Option("B", "有","3-4-8-2"),
                    }
                ),
                new Question("3-4-8-1", "如厕时能否蹲下", 1,
                    new List<Option>{
                        //03 12 03坐便椅
                         new Option("A", "不能","3-4-9",1031203),
                         new Option("B", "能","3-4-9"),
                    }
                ),
                new Question("3-4-8-2", "如厕时起坐是否困难", 1,
                    new List<Option>{
                        //04 10 09扶手（上翻式前臂扶手、固定式前臂扶手）；选配03 12 12框架型加高的坐便器座，或03 12 18安装在坐便器上加高的坐便器座
                         new Option("A", "困难","3-4-9",104100902,104100903,1031212,1031218),
                         new Option("B", "不困难","3-4-9"),
                    }
                ),
                new Question("3-4-9", "洗浴时，能否长时间站立", 1,
                    new List<Option>{
                        //03 33 06防滑的浴盆垫、淋浴垫和带子（地面防滑垫）；04 10 09扶手（上翻式前臂扶手、固定式前臂扶手）
                         new Option("A", "能","3-4-10",103330601,104100902,104100903),
                         //03 33 03盆浴或淋浴椅；03 33 06防滑的浴盆垫、淋浴垫和带子（地面防滑垫）
                         new Option("B", "不能","3-4-10",1033303,103330601),
                    }
                ),
                new Question("3-4-10", "进食时，能否双手协调共同进食", 1,
                    new List<Option>{
                         new Option("A", "能","3-4-10-1"),
                         //10 09 18盘子和碗；10 09 21食物挡边(桌上防滑垫)
                         new Option("B", "不能","3-4-11",1100918,110092102),
                    }
                ),
                new Question("3-4-10-1", "双手能否握紧勺子", 1,
                    new List<Option>{
                         new Option("A", "能","3-4-11"),
                         //08 18 03抓握装置（万能袖带），选配10 09食饮辅助器具(叉、勺、筷子)；10 09 18盘子和碗；10 09食饮辅助器具-杯子(斜口杯/吸管杯/大耳杯)；10 09 21食物挡边(桌上防滑垫)
                         new Option("B", "不能","3-4-11",108180301,1100922,1100923,1100924,1100918,110092502,110092503,110092504,110092102),
                    }
                ),
                new Question("3-4-11", "能否自行穿脱衣物", 1,
                    new List<Option>{
                        //选配03 03 18夹克衫和长裤
                         new Option("A", "不能","4",1030318),
                         //选配03 09 18系扣钩（系扣器），03 09 03穿短袜和穿连裤袜的辅助器具（穿袜器），03 09 15拉动拉链的装置（拉链器），03 03 42鞋和靴（方便穿脱鞋），03 09 06鞋拔和脱靴器（长柄鞋拔）
                         new Option("B", "辅助下完成","4",103091801,103090301,103091501,103034202,103090602),
                         new Option("C", "独立完成","4"),
                    }
                ),
                new Question("4", "是否存在其他方面残疾", 1,
                    new List<Option>{
                         new Option("A", "无","5"),
                         new Option("B", "视力",1,"5"),
                         new Option("C", "听力",2,"5"),
                         new Option("D", "其它","5"),
                    }
                ),
                 new Question("5", "最希望解决什么问题（最多选择三个）", 2,
                    new List<Option>{
                         new Option("A", "轮椅代步",null),
                         new Option("B", "辅助行走",null),
                         new Option("C", "饮食",null),
                         new Option("D", "个人护理",null),
                         new Option("E", "如厕",null),
                         new Option("F", "信息交流",null),
                         new Option("G", "康复训练",null),
                         new Option("H", "防护功能",null),
                         new Option("I", "无障碍环境",8,null),
                         new Option("J", "操作和使用",null),
                         new Option("K", "位置转移",null),
                         new Option("L", "纠正姿势",null),
                         new Option("M", "假肢",7,null),
                         new Option("N", "矫形器",null),
                         new Option("O", "助听类",null),
                         new Option("P", "助视类",null),
                         new Option("Q", "洗漱类",null),
                         new Option("R", "穿衣类",null),
                    }
                ),

            };
            Exam exam6 = new Exam(6, "FuJuPingGu", "肢体", questions6);
            db.Exams.AddOrUpdate(exam6);
            #endregion

            #region 假肢试题
            List<Question> questions7 = new List<Question>
            {
                new Question("1", "患者有装配无假肢需求？", 1,
                    new List<Option>{
                         new Option("A", "无装配需求",null),
                         new Option("B", "有装配需求","2"),
                    }
                ),
                //身体部位图片选择
                new Question("2", "在图中标出残肢部位（可多选）", 6),
                new Question("3", "身体状况？", 1,
                    new List<Option>{
                         new Option("A", "正常","4"),
                         new Option("B", "体质极度衰弱","4"),
                         new Option("C", "平衡和协调功能严重障碍","4"),
                         new Option("D", "血液病或出血性疾病","4"),
                         new Option("E", "严重心脏病","4"),
                         new Option("F", "严重高血压、低血压","4"),
                         new Option("G", "意识障碍","4"),
                         new Option("H", "视力严重障碍","4"),
                         new Option("I", "严重的精神神经性疾病","4"),
                         new Option("J", "无法确定","4"),
                    }
                ),
                new Question("4", "残肢端状况？", 1,
                    new List<Option>{
                         new Option("A", "正常","5"),
                         new Option("B", "末梢血管循环不良","5"),
                         new Option("C", "炎症","5"),
                         new Option("D", "溃烂","5"),
                         new Option("E", "疼痛","5"),
                         new Option("F", "肿胀","5"),
                         new Option("G", "神经瘤","5"),
                         new Option("H", "皮肤过紧","5"),
                         new Option("I", "关节挛缩","5"),
                         new Option("J", "无法确定","5"),
                    }
                ),
                //图片上传
                new Question("5", "直接拍照或上传残肢部位的照片至少一张：为残缺一侧肢体的特写照片（残缺部位裸露）", 7),

            };
            Exam exam7 = new Exam(7, "FuJuPingGu", "假肢", questions7);
            db.Exams.AddOrUpdate(exam7);
            #endregion

            #region 无障碍试题
            List<Question> questions8 = new List<Question>
            {
                 new Question("1", "现在居住类型?", 1,
                    new List<Option>{
                         new Option("A", "城镇","2"),
                         new Option("B", "乡村","2"),
                         new Option("C", "其他","2"),
                    }
                ),
                 new Question("2", "现居住房屋所有情况?", 1,
                    new List<Option>{
                         new Option("A", "自有","3"),
                         new Option("B", "租借","3"),
                         new Option("C", "其他","3"),
                    }
                ),
                 new Question("3", "现居住楼层?", 1,
                    new List<Option>{
                         new Option("A", "地下室","4"),
                         new Option("B", "一层","4"),
                         new Option("C", "二层及以上","4"),
                    }
                ),
                 new Question("4", "现居住情况?", 1,
                    new List<Option>{
                         new Option("A", "独居","5"),
                         new Option("B", "与家人同住","5"),
                         new Option("C", "与朋友同住","5"),
                         new Option("D", "其他","5"),
                    }
                ),
                 new Question("5", "家庭中主要活动场所？(多选)", 2,
                    new List<Option>{
                         new Option("A", "客厅","6"),
                         new Option("B", "卫生间","6"),
                         new Option("C", "厨房","6"),
                         new Option("D", "卧室","6"),
                         new Option("E", "其他","6"),
                    }
                ),
                new Question("6", "您认为在家庭生活中存在困难较多的区域（多选）", 2,
                    new List<Option>{
                         new Option("A", "入户通道","7"),
                         new Option("B", "客厅","8"),
                         new Option("C", "卫生间","9"),
                         new Option("D", "厨房","10"),
                         new Option("E", "卧室","11"),
                         new Option("F", "上下楼梯","12"),
                         new Option("G", "其他","13"),
                         new Option("H", "无",null),
                    }
                ),
                new Question("7", "您认为入户通道存在的问题（多选）", 4,
                    new List<Option>{
                         new Option("A", "杂物堆放或空间不足","7-A"),
                         new Option("B", "门宽不足，或有门槛或高低落差","7-B"),
                         new Option("C", "门开启困难","7-C"),
                         new Option("D", "光线不足","7-D"),
                         new Option("E", "无扶手或扶手不合适","7-E"),
                         new Option("F", "无门把手、门铃、门锁等或使用困难","7-F"),
                         new Option("G", "其他","7-G"),
                    }
                ),
                new Question("7-A", null, 2,
                    new List<Option>{
                         new Option("A", "清理杂物",null),
                         new Option("B", "更换入门方式（如人车（轮椅）分离等）",null),
                         new Option("C", "门口增设平台",null),
                    }
                ),
                new Question("7-B", null, 2,
                    new List<Option>{
                         new Option("A", "改变进门方式（如更换为快拆轴轮椅（带后小轮）、教进门技巧、下轮椅进门、教过门槛技巧等）",null),
                         new Option("B", "增加门宽",null),
                         new Option("C", "通过固定坡道或简易坡道消除高低差",null),
                         new Option("D", "去除门槛",null),
                    }
                ),
                new Question("7-C", null, 2,
                    new List<Option>{
                         new Option("A", "更换开门方式（如请人协助等）",null),
                         new Option("B", "更换易开关门",null),
                    }
                ),
                new Question("7-D", null, 2,
                    new List<Option>{
                         new Option("A", "增加光线",null),
                         new Option("B", "改声光控灯",null),
                    }
                ),
                new Question("7-E", null, 2,
                    new List<Option>{
                         new Option("A", "增加扶手",null),
                         new Option("B", "更换扶手",null),
                    }
                ),
                new Question("7-F", null, 2,
                    new List<Option>{
                         new Option("A", "增加把手",null),
                         new Option("B", "更换把手",null),
                         new Option("C", "增加门铃",null),
                         new Option("D", "更换门铃（可改声光门铃（听力障碍））",null),
                         new Option("E", "更换门锁",null),
                         new Option("F", "增加醒目标志（视力障碍）",null),
                    }
                ),
                new Question("7-G", "自填",5),

                new Question("8", "您认为客厅存在的问题（多选）", 4,
                    new List<Option>{
                         new Option("A", "地面杂乱、家具摆放不当或空间不足","8-A"),
                         new Option("B", "地面不平整或不防滑","8-B"),
                         new Option("C", "光线不足","8-C"),
                         new Option("D", "使用开关/插座困难","8-D"),
                         new Option("E", "无扶手或扶手不合适","8-E"),
                         new Option("F", "其他","8-F"),
                    }
                ),

                 new Question("8-A", null, 2,
                    new List<Option>{
                         new Option("A", "清理地面物品",null),
                         new Option("B", "家具和物品重新摆放",null),
                    }
                ),
                 new Question("8-B", null, 2,
                    new List<Option>{
                         new Option("A", "平整地面（如有地毯去除地毯）",null),
                         new Option("B", "使用防滑垫",null),
                         new Option("C", "地面防滑处理",null),
                    }
                ),
                 new Question("8-C", null, 2,
                    new List<Option>{
                         new Option("A", "加灯光",null),
                         new Option("B", "对重要物品加醒目标志",null),
                    }
                ),
                 new Question("8-D", null, 2,
                    new List<Option>{
                         new Option("A", "更改开关/插座位置",null),
                         new Option("B", "改变使用开关/插座方式（如用长柄取物器开关等）",null),
                         new Option("C", "增加醒目标志",null),
                    }
                ),
                 new Question("8-E", null, 2,
                    new List<Option>{
                         new Option("A", "增加扶手",null),
                         new Option("B", "更换扶手",null),
                         new Option("C", "配助行架或拐杖类辅具",null),
                    }
                ),
                new Question("8-F", "自填",5),

                new Question("9", "您认为卫生间存在的问题（多选）", 4,
                    new List<Option>{
                         new Option("A", "地面杂乱，或空间不足","9-A"),
                         new Option("B", "门宽不足，或有门槛或高低落差","9-B"),
                         new Option("C", "门开启困难","9-C"),
                         new Option("D", "地面或浴缸不防滑","9-D"),
                         new Option("E", "使用开关/插座困难","9-E"),
                         new Option("F", "行走、站立、或使用便器困难","9-F"),
                         new Option("G", "洗浴不便","9-G"),
                         new Option("H", "其他","9-H"),
                    }
                ),
                new Question("9-A", null, 2,
                    new List<Option>{
                         new Option("A", "清理地面物品",null),
                         new Option("B", "调整物品摆放空间和位置",null),
                         new Option("C", "轮椅无法出入时，可掌握人车（轮椅）分离出入，或使用座厕椅",null),
                    }
                ),
                 new Question("9-B", null, 2,
                    new List<Option>{
                         new Option("A", "改变进门方式（如更换为快拆轴轮椅（带后小轮）、教进门技巧、下轮椅进门、教过门槛技巧等）",null),
                         new Option("B", "增加门宽",null),
                         new Option("C", "通过固定坡道或简易坡道消除高低差",null),
                         new Option("D", "去除门槛",null),
                    }
                ),
                new Question("9-C", null, 2,
                    new List<Option>{
                         new Option("A", "更换开门方式，如请人协助",null),
                         new Option("B", "去除门，改为门帘等遮蔽",null),
                         new Option("C", "更换易开关门",null),
                    }
                ),
                new Question("9-D", null, 2,
                    new List<Option>{
                         new Option("A", "防滑垫",null),
                         new Option("B", "地面防滑处理",null),
                    }
                ),
                new Question("9-E", null, 2,
                    new List<Option>{
                         new Option("A", "改变使用开关/插座方式（如用长柄取物器开关等）",null),
                         new Option("B", "增加醒目标志",null),
                         new Option("C", "更改开关/插座位置",null),
                    }
                ),
                new Question("9-F", null, 2,
                    new List<Option>{
                         new Option("A", "增加扶手",null),
                         new Option("B", "用阶梯助行架或拐杖类辅具",null),
                         new Option("C", "增加座厕椅或洗浴椅",null),
                    }
                ),
                new Question("9-G", null, 2,
                    new List<Option>{
                         new Option("A", "洗浴类自助具",null),
                    }
                ),
                new Question("9-H", "自填",5),

                new Question("10", "您认为厨房存在的问题（多选）", 4,
                    new List<Option>{
                         new Option("A", "地面杂乱或家具摆放不当","10-A"),
                         new Option("B", "门宽不足，或有门槛或高低落差","10-B"),
                         new Option("C", "门开启困难","10-C"),
                         new Option("D", "地面不平整或不防滑","10-D"),
                         new Option("E", "光线不足","10-E"),
                         new Option("F", "使用开关/插座困难","10-F"),
                         new Option("G", "操作台（包括储物柜、炉台、水池）使用困难","10-G"),
                         new Option("H", "其他","10-H"),
                    }
                ),
                new Question("10-A", null, 2,
                    new List<Option>{
                         new Option("A", "清理地面物品",null),
                         new Option("B", "整理家庭物品摆放空间和位置",null),
                    }
                ),
                new Question("10-B", null, 2,
                    new List<Option>{
                         new Option("A", "改变进门方式（如更换为快拆轴轮椅（带后小轮）、教进门技巧、下轮椅进门、教过门槛技巧等）",null),
                         new Option("B", "增加门宽",null),
                         new Option("C", "通过固定坡道或简易坡道消除高低差",null),
                         new Option("D", "去除门槛",null),
                    }
                ),
                new Question("10-C", null, 2,
                    new List<Option>{
                         new Option("A", "更换开门方式，如请人协助",null),
                         new Option("B", "去除门，改为门帘等遮蔽",null),
                         new Option("C", "更换易开关门",null),
                    }
                ),
                new Question("10-D", null, 2,
                    new List<Option>{
                         new Option("A", "平整地面（如有地毯去除地毯）",null),
                         new Option("B", "使用防滑垫",null),
                         new Option("C", "地面防滑",null),
                    }
                ),
                new Question("10-E", null, 2,
                    new List<Option>{
                         new Option("A", "加灯光",null),
                         new Option("B", "对重要物品加醒目标志",null),
                    }
                ),
                new Question("10-F", null, 2,
                    new List<Option>{
                         new Option("A", "改变使用开关/插座方式（如用长柄取物器开关等）",null),
                         new Option("B", "增加醒目标志",null),
                         new Option("C", "更改开关/插座位置",null),
                    }
                ),
                new Question("10-G", null, 2,
                    new List<Option>{
                         new Option("A", "整理操作台杂物或重新摆放",null),
                         new Option("B", "配备生活自助具",null),
                         new Option("C", "增加醒目标志",null),
                         new Option("D", "更换操作台（包括储物柜、炉台、水池）",null),
                    }
                ),
                new Question("10-H", "自填",5),

                new Question("11", "您认为卧室存在的问题（多选）", 4,
                    new List<Option>{
                         new Option("A", "地面杂乱或家具摆放不当","11-A"),
                         new Option("B", "门宽不足，或有门槛或有高低落差","11-B"),
                         new Option("C", "门开启困难","11-C"),
                         new Option("D", "地面不平整或不防滑","11-D"),
                         new Option("E", "光线不足","11-E"),
                         new Option("F", "使用开关/插座困难","11-F"),
                         new Option("G", "行走、起卧困难","11-G"),
                         new Option("H", "其他","11-H"),
                    }
                ),
                new Question("11-A", null, 2,
                    new List<Option>{
                         new Option("A", "清理地面物品",null),
                         new Option("B", "调整家庭物品摆放空间和位置",null),
                    }
                ),
                new Question("11-B", null, 2,
                    new List<Option>{
                         new Option("A", "改变进门方式（如更换为快拆轴轮椅（带后小轮）、教进门技巧、下轮椅进门、教过门槛技巧等）",null),
                         new Option("B", "增加门宽",null),
                         new Option("C", "通过固定坡道或简易坡道消除高低差",null),
                         new Option("D", "去除门槛",null),
                    }
                ),
                new Question("11-C", null, 2,
                    new List<Option>{
                         new Option("A", "更换开门方式，如请人协助",null),
                         new Option("B", "去除门，改为门帘等遮蔽",null),
                         new Option("C", "更换易开关门",null),
                    }
                ),
                new Question("11-D", null, 2,
                    new List<Option>{
                         new Option("A", "平整地面（如有地毯去除地毯）",null),
                         new Option("B", "使用防滑垫",null),
                         new Option("C", "地面防滑",null),
                    }
                ),
                new Question("11-E", null, 2,
                    new List<Option>{
                         new Option("A", "加灯光",null),
                         new Option("B", "重要物品加醒目标志",null),
                    }
                ),
                new Question("11-F", null, 2,
                    new List<Option>{
                         new Option("A", "更改开关/插座位置",null),
                         new Option("B", "改变使用开关/插座方式（如用长柄取物器开关等）",null),
                         new Option("C", "增加醒目标志",null),
                    }
                ),
                new Question("11-G", null, 2,
                    new List<Option>{
                         new Option("A", "增加扶手",null),
                         new Option("B", "可配助行架或拐杖类辅具，或其他卧室类自助具",null),
                    }
                ),
                new Question("11-H", "自填",5),

                new Question("12", "您认为上下楼梯存在的问题（多选）", 4,
                    new List<Option>{
                         new Option("A", "无扶手或扶手不合适","12-A"),
                         new Option("B", "无法通过扶手上下楼梯","12-B"),
                         new Option("C", "轮椅无法上下","12-C"),
                         new Option("D", "其他","12-D"),
                    }
                ),
                new Question("12-A", null, 2,
                    new List<Option>{
                         new Option("A", "增加扶手",null),
                         new Option("B", "更换扶手",null),
                    }
                ),
                new Question("12-B", null, 2,
                    new List<Option>{
                         new Option("A", "使用座椅式爬楼机",null),
                    }
                ),
                new Question("12-C", null, 2,
                    new List<Option>{
                         new Option("A", "使用轮椅用爬楼机",null),
                         new Option("B", "学习轮椅上下楼技巧",null),
                    }
                ),
                new Question("12-D", "自填",5),

               new Question("13", "您认为其他区域存在的问题", 4,
                    new List<Option>{
                         new Option("A", "其他","13-A"),
                    }
                ),
               new Question("13-A", "自填",5),
            };
            Exam exam8 = new Exam(8, "FuJuPingGu", "无障碍", questions8);
            db.Exams.AddOrUpdate(exam8);
            #endregion
    

            List<ExamRecord> examRecords = new List<ExamRecord>
            {
                new ExamRecord(1, 1,ExamState.待评估),
                new ExamRecord(2, 2,ExamState.待评估),
                new ExamRecord(3, 3,ExamState.待评估),
                new ExamRecord(4, 4,ExamState.待评估),
                new ExamRecord(7, 1,ExamState.待评估),
                new ExamRecord(8, 1,ExamState.待评估),
            };
            db.ExamRecords.AddRange(examRecords);
            db.SaveChanges();
        }
    }
}
