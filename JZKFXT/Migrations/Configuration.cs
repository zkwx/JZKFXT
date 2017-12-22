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

            //角色
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
            foreach (var r in Roles)
            {
                db.Roles.AddOrUpdate(r);
            }
            db.SaveChanges();

            //用户
            var user = new User("", "", "管理员", 1, DateTime.Today);
            db.Users.AddOrUpdate(user);
            db.SaveChanges();

            //关系
            List<Relationship> Relationships = new List<Relationship>
        {
            new Relationship(1, "父母"),
            new Relationship(2, "配偶"),
            new Relationship(3, "兄弟姐妹"),
            new Relationship(4, "祖父母"),
            new Relationship(5, "其他")
        };
            foreach (var r in Relationships)
            {
                db.Relationships.AddOrUpdate(r);
            }
            db.SaveChanges();

            //残疾类别
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
            foreach (var r in Categories)
            {
                db.Categories.AddOrUpdate(r);
            }
            db.SaveChanges();

            //残疾等级
            List<Degree> Degrees = new List<Degree>
        {
            new Degree(1, "一级"),
            new Degree(2, "二级"),
            new Degree(3, "三级"),
            new Degree(4, "四级"),
            new Degree(5, "未定级")
        };
            foreach (var r in Degrees)
            {
                db.Degrees.AddOrUpdate(r);
            }
            db.SaveChanges();

            //残疾等级
            List<Next> Nexts = new List<Next>
        {
            new Next(1, "转介评估机构"),
            new Next(2, "转介服务机构"),
            new Next(3, "上门评估")
        };
            foreach (var r in Nexts)
            {
                db.Nexts.AddOrUpdate(r);
            }

            //致残原因
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
            foreach (var r in DisabilityReasons)
            {
                db.DisabilityReasons.AddOrUpdate(r);
            }
            db.SaveChanges();
            //康复需求
            List<Rehabilitation> RehabilitationList = new List<Rehabilitation>
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
            foreach (var r in RehabilitationList)
            {
                db.Rehabilitations.AddOrUpdate(r);
            }
            db.SaveChanges();


            //康复入户信息
            DisabledInfo disabledInfo = new DisabledInfo
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
            );
            db.DisabledInfoes.AddOrUpdate(disabledInfo);
            disabledInfo = new DisabledInfo
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
            );
            db.DisabledInfoes.AddOrUpdate(disabledInfo);
            disabledInfo = new DisabledInfo
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
            );
            db.DisabledInfoes.AddOrUpdate(disabledInfo);
            disabledInfo = new DisabledInfo
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
            );
            db.DisabledInfoes.AddOrUpdate(disabledInfo);
            disabledInfo = new DisabledInfo
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
            );
            db.DisabledInfoes.AddOrUpdate(disabledInfo);
            disabledInfo = new DisabledInfo
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
            );
            db.DisabledInfoes.AddOrUpdate(disabledInfo);
            disabledInfo = new DisabledInfo
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
            );
            db.DisabledInfoes.AddOrUpdate(disabledInfo);
            db.SaveChanges();

            List<DisabledInfo_Detail> disabledInfo_Details = new List<DisabledInfo_Detail> {
                new DisabledInfo_Detail(1, 1, 1, 1010102, 3, "视力"),
                new DisabledInfo_Detail(2, 2, 2, 1020102, 3, "听力"),
            };
            foreach (var r in disabledInfo_Details)
            {
                db.DisabledInfo_Details.AddOrUpdate(r);
            }
            db.SaveChanges();





            //辅具
            List<AssistiveDevice> AssistiveDevices = new List<AssistiveDevice>
            {
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


            };
            foreach (var r in AssistiveDevices)
            {
                db.AssistiveDevices.AddOrUpdate(r);
            }
            db.SaveChanges();
            //评估
            //视力
            List<Question> questions1 = new List<Question> {
                new Question("1", "视力残疾等级", true,false,
                    new List<Option>{
                        new Option("A","一级", "1-1-1",new List<AssistiveDevice>{
                            new AssistiveDevice(1001010),
                        }),
                        new Option("B","二级", "1-1-1",null,null),
                        new Option("C","三级", "1-2",null,null),
                        new Option("D","四级", "1-2",null,null),
                        new Option("E","未评定或等级不准", "附加题",null,null),
                    }
                ),
                new Question("附加题", "能否看见",false,false,
                    new List<Option>{
                        new Option("A", "不能（相当于一、二级）", "1-1",null,null),
                        new Option("B", "能（相当于三、四级）", "1-2",null,null),
                    }
                ),
                new Question("1-1", "能否听见",false,false,
                    new List<Option>{
                        new Option("A", "能", "1-1-1",null,null),
                        new Option("B", "不能", "1-1-2",null,null),
                    }
                ),
                new Question("1-1-1", "希望实现何种功能（多选）", false,true,
                    new List<Option>{
                        new Option("A", "引导出行", "2", "02 39 03", "盲杖"),
                        new Option("B", "听书娱乐", "2", "05 18 03", "声音记录和播放设备(听书机)"),
                        new Option("C", "时间提醒", "2", "05 27 12", "时钟和计时器(震动闹钟/震动手表)"),
                        new Option("D", "通讯交流", "2", "05 24 06,05 33 15", "移动网络电话(盲人用手机),浏览器软件和沟通软件"),
                        new Option("E", "生活便捷", "2", "05 27 06", "声信号指示器"),
                        new Option("F", "学习书写", "2", "03,05 12 12,05 12 18", "手动式绘画和书写器具,手写盲文书写装置,特制书写纸（塑膜）"),
                    }
                ),
                new Question("1-1-2", "希望实现何种功能（多选）", false,true,
                    new List<Option>{
                        new Option("A", "引导出行", "2", "02 39 03", "盲杖"),
                        new Option("B", "时间提醒", "2", "05 27 12", "时钟和计时器(震动闹钟/震动手表)"),
                    }
                ),
                new Question("1-2", "希望看近物还是看远处（多选）", false,true,
                    new List<Option>{
                        new Option("A", "看近", "1-2-1",null,null),
                        new Option("B", "看远", "1-3", "05 03 12", "双筒望远镜和单筒望远镜"),
                    }
                ),
                new Question("1-2-1", "需要光学助视器还是电子助视器",false,false,
                    new List<Option>{
                        new Option("A", "光学", "1-3", "05 03 09", "具有放大功能的眼镜、镜片、助视系统（只选其中光学类）"),
                        new Option("B", "电子", "1-3", "05 03 09", "具有放大功能的眼镜、镜片、助视系统（只选其中电子类）"),
                    }
                ),
                new Question("1-3", "希望实现何种功能（多选）", false,true,
                    new List<Option>{
                        new Option("A", "阅读学习", "2", "05 30 21,05 30 18,05 12 06,05 12 15", "字符阅读器,阅读框和版面限定器,书写板、绘图板和绘画板,打字机"),
                        new Option("B", "交流通讯", "2", "05 24 03", "普通网络电话"),
                        new Option("C", "数学计算", "2", "05 15 03,05 15 06", "手动计算器,计算设备"),
                        new Option("D", "休闲娱乐", "2", "05 21 03", "字母和符号卡、板"),
                        new Option("E", "计算机使用", "2", "05 33 18", "用于计算机和网络的附件"),
                    }
                ),
                new Question("2", "是否存在眩光现象",false,false,
                    new List<Option>{
                        new Option("A", "是", "3", "05 03 03", "滤光器：低视力专用滤光镜"),
                        new Option("B", "否", "3",null,null),
                    }
                ),
                new Question("3", "是否能正常说话", false,false,
                    new List<Option>{
                        new Option("A", "能",null,null,null),
                        new Option("B", "不能", "3-1",null,null),
                    }
                ),
                new Question("3-1", "是否会写字",false,false,
                    new List<Option>{
                        new Option("A", "会", null,"05 12 12,05 09 03", "手写盲文书写装置,语音发生器"),
                        new Option("B", "不会",null,null,null),
                    }
                ),
            };
            Exam exam1 = new Exam(1, "辅具上门评估", "视力", questions1);
            db.Exams.AddOrUpdate(exam1);
            //听力
            List<Question> questions2 = new List<Question> {
                new Question("1", "听力残疾等级", true,false,
                    new List<Option>{
                        ////选A时，结合年龄，系统关联
                        //6岁以下：05 06 助听器-人工耳蜗
                        //6岁-60岁：05 06 助听器(耳背/耳内/耳道/深耳道式助听器)
                        //60岁以上：05 06 06佩戴式（盒式）助听器
                        new Option("A", "一级","2", "05 06", "助听器-人工耳蜗,助听器(耳背/耳内/耳道/深耳道式助听器),佩戴式（盒式）助听器"),
                        new Option("B", "二级","2", "05 06", "助听器(耳背/耳内/耳道/深耳道式助听器)"),
                        new Option("C", "三级","2", "05 06", "助听器(耳背/耳内/耳道/深耳道式助听器)"),
                        new Option("D", "四级","2", "05 06", "助听器(耳背/耳内/耳道/深耳道式助听器)"),
                        new Option("E", "未评定或等级不准","1-1",null,null),
                    }
                ),
                new Question("1-1", "在安静环境下，不带助听设备时，能听到",false,false,
                    new List<Option>{
                        //选A时，结合年龄，系统关联
                        new Option("A", "几乎听不到任何声音（等同于一级）","2", "05 06", "助听器-人工耳蜗,助听器(耳背/耳内/耳道/深耳道式助听器),佩戴式（盒式）助听器"),
                        new Option("B", "只能听到鞭炮、敲鼓、雷声或用力击掌声（等同于二级）","2", "05 06", "助听器(耳背/耳内/耳道/深耳道式助听器)"),
                        new Option("C", "只能听到大声说话（等同于三级）","2", "05 06", "助听器(耳背/耳内/耳道/深耳道式助听器)"),
                        new Option("D", "能听到普通谈话声（等同于四级）","2", "05 06", "助听器(耳背/耳内/耳道/深耳道式助听器)"),
                        new Option("E", "听清一般言语，能分辨清楚（不配辅助器具）","2",null,null),
                    }
                ),
                new Question("2", "除听声外，希望实现何种功能", false,true,
                    new List<Option>{
                        new Option("A", "语言交流（无语言者）",null, "05 21 09", "对话装置(电子手写交流板/沟通板)"),
                        new Option("B", "门铃应答", null,"05 27 03", "视觉信号指示器(闪光门铃)"),
                        new Option("C", "叫早起床", null,"05 27 12", "时钟和计时器(震动闹钟)")
                    }
                )
            };
            Exam exam2 = new Exam(2, "辅具上门评估", "听力", questions2);
            db.Exams.AddOrUpdate(exam2);
            //偏瘫
            List<Question> questions3 = new List<Question>
            {
                new Question("1", "是否卧床", true,false,
                    new List<Option>{
                         new Option("A", "是","1-1-1", "05 27 18", "个人紧急报警系统（呼叫器）"),
                         new Option("B", "否","1-2-1", null, null),
                    }
                ),
                new Question("1-1-1", "能否翻身", false,false,
                    new List<Option>{
                        new Option("A", "不能","1-1-2", "04,06 33 06,07 33 09,06 33 04", "家庭和家具-卧式家具（护理床）,保护组织完整性的躺卧辅助器具（防压疮床垫）,个人移动训练辅助器具（翻身床单）,保护组织完整性的靠背垫和小靠背垫（体位垫）"),
                        new Option("B", "能","1-1-2", "04,06 33 06,06 33 04,04 10 09", "家庭和家具-卧式家具（护理床）,保护组织完整性的躺卧辅助器具（防压疮床垫）,保护组织完整性的靠背垫和小靠背垫（体位垫）,扶手（床旁护栏）"),
                    }
                ),
                new Question("1-1-2", "能否坐起", false,false,
                    new List<Option>{
                         new Option("A", "不能","1-1-3", null, null),
                         new Option("B", "能","1-1-3", "04 10 03,02 22 18", "靠背,护理者操纵的轮椅（高靠背轮椅）"),
                    }
                ),
                new Question("1-1-3", "能否控制大小便", false,false,
                    new List<Option>{
                         new Option("A", "不能","2", "07 09 03,03 30 21,03 30 18,03 27 18,03 31 06", "失禁报警器,成人一次性尿布,成人一次性衬垫,尿收集系统,阻便器（肛门插塞）"),
                         new Option("B", "能","2", "03 24 15,03 24 21,03 12 33", "女用穿戴式软尿壶,男用穿戴式软尿壶,便盆（便携式充气便盆/塑料大便盆）"),
                    }
                ),
                new Question("1-2-1", "能否行走", false,false,
                    new List<Option>{
                        new Option("A", "不能","1-2-1-1", null, null),
                        new Option("B", "能","1-2-2", null, null),
                    }
                ),
                new Question("1-2-1-1", "能否辅助下移动入厕", false,false,
                    new List<Option>{
                        new Option("A", "不能","1-2-1-2", "02 22 18", "护理者操纵的轮椅（座便轮椅）"),
                        new Option("B", "能","1-2-1-2", "02 22 03,02 22 09,02 23 03", "双手驱动轮椅车（功能轮椅）,单手驱动轮椅车(单手轮驱动轮椅/偏瘫轮椅),电动轮椅车（室内型电动轮椅）"),
                    }
                ),
                new Question("1-2-1-2", "是否有压疮", false,false,
                    new List<Option>{
                         new Option("A", "无","1-2-1-3", null, null),
                         new Option("B", "曾经有，已愈合","1-2-1-3", "06 33 03", "保护组织完整性的坐垫和衬垫（防压疮坐垫）"),
                         new Option("C", "有","1-2-1-3", "06 33 03", "保护组织完整性的坐垫和衬垫（防压疮坐垫）"),
                    }
                ),
                new Question("1-2-1-3", "能否站立进行床-椅转移", false,false,
                    new List<Option>{
                         new Option("A", "不能","2", "07 33 09", "个人移动训练辅助器具（移乘带或移乘板）"),
                         new Option("B", "需要辅助","2", "04 10 09,02 03 03", "扶手,手杖（直形四脚手杖（固定/可调））"),
                         new Option("C", "独立站立转移","2", null, null),
                    }
                ),
                new Question("1-2-2", "行走时是否需要搀扶", false,false,
                    new List<Option>{
                         new Option("A", "全程搀扶","1-2-2-1", null, null),
                         new Option("B", "部分搀扶","2", "02 03 03", "手杖（单脚手杖）"),
                         new Option("C", "无需搀扶","2", null, null),
                    }
                ),
                new Question("1-2-2-1", "行走时是否需要搀扶", false,false,
                    new List<Option>{
                         new Option("A", "需要","2", "02 03 03,0", "手杖（S形四脚手杖（固定/可调））,单侧操作助行架"),
                         new Option("B", "不需要","2", "02 03 03", "手杖（直形四脚手杖（固定/可调））"),
                    }
                ),
                new Question("2", "患侧肢体畸形状况", false,true,
                    new List<Option>{
                         new Option("A", "肩膀下沉","3", "01 06 21", "肩矫形器-肩部吊带"),
                         new Option("B", "手指被动伸展","3", "01 06,01 06 07", "上肢矫形器,手-指矫形器-分指板"),
                         new Option("C", "行走时足拖地","3", "01 12", "下肢矫形器"),
                    }
                ),
                new Question("3", "能否自行进食", false,false,
                    new List<Option>{
                         new Option("A", "不能","4", "04 30", "垂直运送辅助器具-桌类（床用餐桌或轮椅桌）"),
                         new Option("B", "需要辅助","4", "08 18 03,10 09 18,10 09 21,10 09", "抓握装置（万能袖带）,盘子和碗（普通防洒碗/底部带吸盘餐具）,食物挡边(桌上防滑垫),食饮辅助器具"),
                         new Option("C", "独立进食","4",null, null),
                    }
                ),
                new Question("4", "能否自行洗浴", false,false,
                    new List<Option>{
                         new Option("A", "不能","5", "03 33 12,03 33,03 33 15,1", "洗浴床、淋浴桌和更换尿布桌（洗浴床）,清洗、盆浴和淋浴辅助器具（洗浴床单）,洗盆（充气式洗头池）,洗浴躺椅"),
                         new Option("B", "能","4-1", null,null),
                    }
                ),
                new Question("4-1", "是否站立洗浴", false,false,
                    new List<Option>{
                         new Option("A", "是","4-2", "03 33 06", "防滑的浴盆垫、淋浴垫和带子（地面防滑垫）"),
                         new Option("B", "否","4-2", "03 33 03", "盆浴或淋浴椅、浴室坐板、凳子、靠背和座"),
                    }
                ),
                new Question("4-2", "是否需要洗浴类自助具", false,false,
                    new List<Option>{
                         new Option("A", "需要","5", "03 33 30,03 36 06,03 36 09", "带有把手、手柄和握把的洗澡布、海绵和刷子,指甲锉和砂纸板,指甲剪和指甲刀"),
                         new Option("B", "不需要","5", null, null),
                    }
                ),
                new Question("5", "自行如厕时，是否下蹲", false,false,
                    new List<Option>{
                         new Option("A", "能","6", null, null),
                         new Option("B", "不能","5-1", null, null),
                    }
                ),
                new Question("5-1", "家中是否有坐便器", false,false,
                    new List<Option>{
                         new Option("A", "有，且高度合适","6", null, null),
                         new Option("B", "有，高度较低","6", "03 12 18,03 12 21,04 10 09,03 12 12", "安装在坐便器上加高的坐便器座,内置帮助起身、坐下的升降机构的坐便器座,扶手,框架型加高的坐便器座"),
                         new Option("C", "无","6", "03 12 03", "坐便椅"),
                    }
                ),
                new Question("6", "能否自行穿脱衣物", false,false,
                    new List<Option>{
                         new Option("A", "不能，且高度合适","7", "03 03 18,03 03 42", "夹克衫和长裤,鞋和靴（方便穿脱鞋）"),
                         new Option("B", "辅助下完成","7", "03 09 12,03 09 03,03 09 06", "穿脱衣钩或穿脱衣棍,穿短袜和穿连裤袜的辅助器具,鞋拔和脱靴器（长柄鞋拔）"),
                         new Option("C", "独立完成","7", null, null),
                    }
                ),
                new Question("7", "是否经常需要够拾远处物品", false,false,
                    new List<Option>{
                         new Option("A", "否","8", null, null),
                         new Option("B", "是","8", "08 21 03", "手动抓取钳（折叠式长柄取物器/非折叠式长柄取物器）"),
                    }
                ),
                new Question("8", "是否存在其他方面残疾", false,false,
                    new List<Option>{
                         new Option("A", "无","9", null, null),
                         new Option("B", "视力",1,"9", null, null),
                         new Option("C", "听力",2,"9", null, null),
                         new Option("D", "其它","9", null, null),
                    }
                ),
                new Question("9", "最希望解决什么问题（最多选择三个）", false,true,
                    new List<Option>{
                         new Option("A", "轮椅代步",null, null, null),
                         new Option("B", "辅助行走",null, null, null),
                         new Option("C", "饮食",null, null, null),
                         new Option("D", "个人护理",null, null, null),
                         new Option("E", "如厕",null, null, null),
                         new Option("F", "信息交流",null, null, null),
                         new Option("G", "康复训练",null, null, null),
                         new Option("H", "防护功能",null, null, null),
                         new Option("I", "无障碍环境",8,null, null, null),
                         new Option("J", "操作和使用",null, null, null),
                         new Option("K", "位置转移",null, null, null),
                         new Option("L", "纠正姿势",null, null, null),
                         new Option("M", "假肢",7,null, null, null),
                         new Option("N", "矫形器",null, null, null),
                         new Option("O", "助听类",null, null, null),
                         new Option("P", "助视类",null, null, null),
                         new Option("Q", "洗漱类",null, null, null),
                         new Option("R", "穿衣类",null, null, null),
                    }
                ),
            };
            Exam exam3 = new Exam(3, "辅具上门评估", "偏瘫", questions3);
            db.Exams.AddOrUpdate(exam3);
            //脑瘫
            List<Question> questions4 = new List<Question>
            {
                new Question("1", "年龄", true,false,
                    new List<Option>{
                         new Option("A", "≤7岁","2-1", null, null),
                         new Option("B", ">7岁","3-1", null, null),
                    }
                ),
                new Question("2-1", "能否完成“坐起”动作", false,false,
                    new List<Option>{
                         new Option("A", "完全不能","2-1-1", null, null),
                         new Option("B", "需要辅助完成","2-1-2", null, null),
                         new Option("C", "无需辅助能独立完成","2-1-2", null, null),
                    }
                ),
                new Question("2-1-1", "能否翻身", false,false,
                    new List<Option>{
                         new Option("A", "完全不能","2-1-1-1", null, null),
                         new Option("B", "需要辅助","2-2", "06 33 04,02 22 18", "保护组织完整性的靠背垫和小靠背垫(楔形垫),护理者操纵的轮椅车(0-3岁为儿童轮椅；4-7岁为儿童脑瘫轮椅)"),
                         new Option("C", "无需辅助独立完成","2-2", "04 09 21,02 22 18", "特殊坐具（0-3岁为儿童三角椅，4-7岁为儿童坐姿椅）,护理者操纵的轮椅车(0-3岁为儿童轮椅；4-7岁为儿童脑瘫轮椅)"),
                    }
                ),
                new Question("2-1-1-1", "能否抬头", false,false,
                    new List<Option>{
                         new Option("A", "完全不能","2-2", "06 33 04", "保护组织完整性的靠背垫和小靠背垫（体位变换组合垫）"),
                         new Option("B", "短暂抬头，不能维持","2-2", "06 33 04", "保护组织完整性的靠背垫和小靠背垫(楔形垫)；02 22 18护理者操纵的轮椅车(0-3岁为儿童轮椅；4-7岁为儿童脑瘫轮椅)"),
                         new Option("C", "能抬头且能维持","2-2", "06 33 04", "保护组织完整性的靠背垫和小靠背垫(楔形垫)；02 22 18护理者操纵的轮椅车(0-3岁为儿童轮椅；4-7岁为儿童脑瘫轮椅)"),
                    }
                ),

            };
            Exam exam4 = new Exam(4, "辅具上门评估", "脑瘫", questions4);
            db.Exams.AddOrUpdate(exam4);
        }
    }
}
