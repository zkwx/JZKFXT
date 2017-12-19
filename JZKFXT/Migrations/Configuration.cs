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
            //评估

            //视力
            List<Question> questions1 = new List<Question> {
                new Question(1010000, "1", "视力残疾等级", true,false,
                    new List<Option>{
                        new Option("A","一级", 1010100,null,null),
                        new Option("B","二级", 1010100,null,null),
                        new Option("C","三级", 1010200,null,null),
                        new Option("D","四级", 1010200,null,null),
                        new Option("E","未评定或等级不准", 1090000,null,null),
                    }
                ),
                new Question(1090000, "附加题", "能否看见",false,false,
                    new List<Option>{
                        new Option("A", "不能（相当于一、二级）", 1010100,null,null),
                        new Option("B", "能（相当于三、四级）", 1010200,null,null),
                    }
                ),
                new Question(1010100, "1-1", "能否听见",false,false,
                    new List<Option>{
                        new Option("A", "能", 1010101,null,null),
                        new Option("B", "不能", 1010102,null,null),
                    }
                ),
                new Question(1010101, "1-1-1", "希望实现何种功能（多选）", false,true,
                    new List<Option>{
                        new Option("A", "引导出行", 1020000, "02 39 03", "盲杖"),
                        new Option("B", "听书娱乐", 1020000, "05 18 03", "声音记录和播放设备(听书机)"),
                        new Option("C", "时间提醒", 1020000, "05 27 12", "时钟和计时器(震动闹钟/震动手表)"),
                        new Option("D", "通讯交流", 1020000, "05 24 06,05 33 15", "移动网络电话(盲人用手机),浏览器软件和沟通软件"),
                        new Option("E", "生活便捷", 1020000, "05 27 06", "声信号指示器"),
                        new Option("F", "学习书写", 1020000, "03,05 12 12,05 12 18", "手动式绘画和书写器具,手写盲文书写装置,特制书写纸（塑膜）"),
                    }
                ),
                new Question(1010102, "1-1-2", "希望实现何种功能（多选）", false,true,
                    new List<Option>{
                        new Option("A", "引导出行", 1020000, "02 39 03", "盲杖"),
                        new Option("B", "时间提醒", 1020000, "05 27 12", "时钟和计时器(震动闹钟/震动手表)"),
                    }
                ),
                new Question(1010200, "1-2", "希望看近物还是看远处（多选）", false,true,
                    new List<Option>{
                        new Option("A", "看近", 1010201,null,null),
                        new Option("B", "看远", 1010300, "05 03 12", "双筒望远镜和单筒望远镜"),
                    }
                ),
                new Question(1010201, "1-2-1", "需要光学助视器还是电子助视器",false,false,
                    new List<Option>{
                        new Option("A", "光学", 1010300, "05 03 09", "具有放大功能的眼镜、镜片、助视系统（只选其中光学类）"),
                        new Option("B", "电子", 1010300, "05 03 09", "具有放大功能的眼镜、镜片、助视系统（只选其中电子类）"),
                    }
                ),
                new Question(1010300, "1-3", "希望实现何种功能（多选）", false,true,
                    new List<Option>{
                        new Option("A", "阅读学习", 1020000, "05 30 21,05 30 18,05 12 06,05 12 15", "字符阅读器,阅读框和版面限定器,书写板、绘图板和绘画板,打字机"),
                        new Option("B", "交流通讯", 1020000, "05 24 03", "普通网络电话"),
                        new Option("C", "数学计算", 1020000, "05 15 03,05 15 06", "手动计算器,计算设备"),
                        new Option("D", "休闲娱乐", 1020000, "05 21 03", "字母和符号卡、板"),
                        new Option("E", "计算机使用", 1020000, "05 33 18", "用于计算机和网络的附件"),
                    }
                ),
                new Question(1020000, "2", "是否存在眩光现象",false,false,
                    new List<Option>{
                        new Option("A", "是", 1030000, "05 03 03", "滤光器：低视力专用滤光镜"),
                        new Option("B", "否", 1030000,null,null),
                    }
                ),
                new Question(1030000, "3", "是否能正常说话", false,false,
                    new List<Option>{
                        new Option("A", "能",null,null,null),
                        new Option("B", "不能", 1030100,null,null),
                    }
                ),
                new Question(1030100, "3-1", "是否会写字",false,false,
                    new List<Option>{
                        new Option("A", "会", null,"05 12 12,05 09 03", "手写盲文书写装置,语音发生器"),
                        new Option("B", "不会",null,null,null),
                    }
                ),
            };
            Exam exam1 = new Exam(1, "视力", questions1);
            db.Exams.AddOrUpdate(exam1);
            //听力
            List<Question> questions2 = new List<Question> {
                new Question(2010000, "1", "听力残疾等级", true,false,
                    new List<Option>{
                        ////选A时，结合年龄，系统关联
                        //6岁以下：05 06 助听器-人工耳蜗
                        //6岁-60岁：05 06 助听器(耳背/耳内/耳道/深耳道式助听器)
                        //60岁以上：05 06 06佩戴式（盒式）助听器
                        new Option("A", "一级", 2020000, "05 06", "助听器-人工耳蜗,助听器(耳背/耳内/耳道/深耳道式助听器),佩戴式（盒式）助听器"),
                        new Option("B", "二级", 2020000, "05 06", "助听器(耳背/耳内/耳道/深耳道式助听器)"),
                        new Option("C", "三级", 2020000, "05 06", "助听器(耳背/耳内/耳道/深耳道式助听器)"),
                        new Option("D", "四级", 2020000, "05 06", "助听器(耳背/耳内/耳道/深耳道式助听器)"),
                        new Option("E", "未评定或等级不准", 2010100,null,null),
                    }
                ),
                new Question(2010100, "1-1", "在安静环境下，不带助听设备时，能听到",false,false,
                    new List<Option>{
                        //选A时，结合年龄，系统关联
                        new Option("A", "几乎听不到任何声音（等同于一级）", 2020000, "05 06", "助听器-人工耳蜗,助听器(耳背/耳内/耳道/深耳道式助听器),佩戴式（盒式）助听器"),
                        new Option("B", "只能听到鞭炮、敲鼓、雷声或用力击掌声（等同于二级）", 2020000, "05 06", "助听器(耳背/耳内/耳道/深耳道式助听器)"),
                        new Option("C", "只能听到大声说话（等同于三级）", 2020000, "05 06", "助听器(耳背/耳内/耳道/深耳道式助听器)"),
                        new Option("D", "能听到普通谈话声（等同于四级）", 2020000, "05 06", "助听器(耳背/耳内/耳道/深耳道式助听器)"),
                        new Option("E", "听清一般言语，能分辨清楚（不配辅助器具）", 2020000,null,null),
                    }
                ),
                new Question(2020000, "2", "除听声外，希望实现何种功能", false,true,
                    new List<Option>{
                        new Option("A", "语言交流（无语言者）",null, "05 21 09", "对话装置(电子手写交流板/沟通板)"),
                        new Option("B", "门铃应答", null,"05 27 03", "视觉信号指示器(闪光门铃)"),
                        new Option("C", "叫早起床", null,"05 27 12", "时钟和计时器(震动闹钟)")
                    }
                )
            };
            Exam exam2 = new Exam(2, "听力", questions2);
            db.Exams.AddOrUpdate(exam2);



        }
    }
}
