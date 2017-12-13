namespace JZKFXT.Migrations
{
    using JZKFXT.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JZKFXT.DAL.BaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
        protected override void Seed(JZKFXT.DAL.BaseContext db)
        {
            base.Seed(db);
            //用户
            var user = new User { UserName = "", Password = "", Role = "管理员", CreateTime = DateTime.Today, LastLoginTime = DateTime.Today };
            db.Users.AddOrUpdate(user);
            db.SaveChanges();
            //角色
            List<Role> Roles = new List<Role>
            {
                new Role { ID=1,RoleName = "社区工作人员"                  ,Description="社区负责残疾人工作的人员：残疾人专干、残疾人康复协调员。"                                     ,Duty ="使用移动端对辖区指定或全部功能障碍者的基本信息、残疾信息进行输入；对辖区指定或全部功能障碍者进行“精准康复入户模块”和“辅具上门评估与适配模块”的评估；对“综合服务回访”模块进行“假肢矫形器回访”、“无障碍回访”和“辅具回访”和其“康复服务”的跟踪。",MenuIDs=""                                             },
                new Role { ID=2,RoleName = "社区签约医生"                  ,Description="社区开展残疾人医疗保障服务的签约医生。"                                                     , Duty="在“精准康复入户”模块和“辅具上门评估与适配”模块，对辖区指定或全部功能障碍者进行精准康复入户和辅具上门评估与适配；在“康复服务”模块，对功能障碍者提供“支持性服务”。对“综合服务回访”模块进行“假肢矫形器回访”、“无障碍回访”和“辅具回访”和其“康复服务”的跟踪。",MenuIDs=""                             },
                new Role { ID=3,RoleName = "辅具评估机构（全）",Description="本地区开展辅具适配的权威机构（如辅具中心）人员，涉及辅具适配所有方向。"                        ,Duty ="在“机构评估与审核”模块，对“长江新里程子”模块数据进行评估和审核，对“无障碍改造”模块数据进行评估和审核，对“辅具上门评估与适配”模块的评估适配结果进行审核；对审核未通过的所有类别功能障碍者进行二次评估。",MenuIDs=""                          },
                new Role { ID=4,RoleName = "辅具技术人员（肢体方向）"       ,Description="本地区开展辅具适配的权威机构（如辅具中心）人员，涉及辅具适配肢体方向。"                        , Duty="在“机构评估与审核”模块，对“长江新里程子”模块数据进行评估和审核，对“无障碍改造”模块数据进行评估和审核，对“辅具上门评估与适配”模块的评估适配结果进行评估和审核；对审核未通过的肢体功能障碍者进行二次评估。",MenuIDs=""                                              },
                new Role { ID=5,RoleName = "辅具技术人员（听力方向）"       ,Description="本地区开展辅具适配的权威机构（如辅具中心）人员，涉及辅具适配听力方向。"                        , Duty="在“机构评估与审核模”块，对辖区指定或全部功能障碍者的辅具上门评估与适配模块涉及听力方向评估适配结果进行审核。对审核未通过的听力功能障碍者进行二次评估。",MenuIDs=""                                             },
                new Role { ID=6,RoleName = "辅具技术人员（视力方向）",Description="本地区开展辅具适配的权威机构（如辅具中心）人员，涉及辅具适配视力方向。"                        , Duty="在机构评估与审核模块，对辖区指定或全部功能障碍者的辅具上门评估与适配模块涉及视力方向评估适配结果进行审核。对审核未通过的视力功能障碍者进行二次评估。",MenuIDs=""                 },
                new Role { ID=7,RoleName = "辅具技术人员（假肢矫形器方向）",Description="本地区开展辅具适配的权威机构（如辅具中心）人员，涉及辅具适配假肢矫形器方向。"                  , Duty="在“机构评估与审核”模块，对“长江新里程子”模块数据进行评估，对“无障碍改造”模块数据进行评估，对“辅具上门评估与适配”模块的评估适配结果进行审核；对审核未通过的肢体功能障碍者进行二次评估。",MenuIDs=""            }   ,
                new Role { ID=8,RoleName = "辅具技术人员（无障碍方向）"     ,Description="本地区开展辅具适配的权威机构（如辅具中心）人员，涉及无障碍方向方向。"                          , Duty="在“机构评估与审核”模块，对“无障碍改造”模块数据进行评估和审核。",MenuIDs=""                 },
                new Role { ID=9,RoleName = "评估机构（除辅具外）"           ,Description="本地区开展除辅具评估适配业务以外的评估机构，涉及康复治疗与训练、手术、支持性服务，等的评估。"    , Duty="在“机构评估与审核”模块，对辖区指定或全部功能障碍者涉及康复治疗与训练、手术、支持性服务的需求进行评估。",MenuIDs=""                                                      }   ,
                new Role { ID=10,RoleName = "康复服务机构"                  ,Description="本地区开展除辅具评估适配业务以外的服务机构，涉及康复治疗与训练、手术、支持性服务，等的服务。"    , Duty="在“综合康复服务”模块的“康复服务”子模块，对功能障碍者开展康复治疗与训练、手术、支持性服务，等的服务。",MenuIDs=""                                                                                  },
                new Role { ID=11,RoleName = "辅具服务机构"                  ,Description="本地区开展辅具服务的机构。"                                                                , Duty="在“综合康复服务”模块的“辅具服务”子模块，对功能障碍者开展辅具配发、假肢矫形器和无障碍等的服务。",MenuIDs=""                      }
            };
            foreach (var r in Roles)
            {
                db.Roles.AddOrUpdate(r);
            }
            db.SaveChanges();
            //关系
            List<Relationship> Relationships = new List<Relationship>
            {
                new Relationship { ID=1,Name = "父母" },
                new Relationship { ID=2,Name = "配偶" },
                new Relationship { ID=3,Name = "兄弟姐妹" },
                new Relationship { ID=4,Name = "祖父母" },
                new Relationship { ID=5,Name = "其他" }
            };
            foreach (var r in Relationships)
            {
                db.Relationships.AddOrUpdate(r);
            }
            db.SaveChanges();

            //残疾类别
            List<Category> Categories = new List<Category>
            {
                new Category { ID=1,Name = "视力" },
                new Category { ID=2,Name = "听力" },
                new Category { ID=3,Name = "言语" },
                new Category { ID=4,Name = "肢体" },
                new Category { ID=5,Name = "智力" },
                new Category { ID=6,Name = "精神" },
                new Category { ID=7,Name = "多重" },
            };
            foreach (var r in Categories)
            {
                db.Categories.AddOrUpdate(r);
            }
            db.SaveChanges();

            //残疾等级
            List<Degree> Degrees = new List<Degree>
            {
                new Degree { ID=1,Name = "一级" },
                new Degree { ID=2,Name = "二级" },
                new Degree { ID=3,Name = "三级" },
                new Degree { ID=4,Name = "四级" },
                new Degree { ID=5,Name = "未定级" }
            };
            foreach (var r in Degrees)
            {
                db.Degrees.AddOrUpdate(r);
            }
            db.SaveChanges();

            //残疾等级
            List<Next> Nexts = new List<Next>
            {
                new Next { ID=1,Name = "转介评估机构" },
                new Next { ID=2,Name = "转介服务机构" },
                new Next { ID=3,Name = "上门评估" }
            };
            foreach (var r in Nexts)
            {
                db.Nexts.AddOrUpdate(r);
            }

            //致残原因
            List<DisabilityReason> DisabilityReasons = new List<DisabilityReason>
            {
                new DisabilityReason { CategoryID=1,Name = "外伤" },
                new DisabilityReason { CategoryID=1,Name = "青光眼" },
                new DisabilityReason { CategoryID=1,Name = "角膜病" },
                new DisabilityReason { CategoryID=1,Name = "视网膜" },
                new DisabilityReason { CategoryID=1,Name = "色素膜变性" },
                new DisabilityReason { CategoryID=1,Name = "屈光不正/弱视" },
                new DisabilityReason { CategoryID=1,Name = "白内障" },
                new DisabilityReason { CategoryID=1,Name = "黄斑变性" },
                new DisabilityReason { CategoryID=1,Name = "视神经萎缩" },
                new DisabilityReason { CategoryID=1,Name = "其他" },
                new DisabilityReason { CategoryID=2,Name = "先天性" },
                new DisabilityReason { CategoryID=2,Name = "药物性" },
                new DisabilityReason { CategoryID=2,Name = "老年性" },
                new DisabilityReason { CategoryID=2,Name = "其他" },
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
                new Rehabilitation { ID = 1010101, CategoryID = 1, Category = "视力", CategoryDetail = "盲人", RehabilitationName = "白内障复明手术" },
                new Rehabilitation { ID = 1010102, CategoryID = 1, Category = "视力", CategoryDetail = "盲人", RehabilitationName = "辅助器具适配及服务",FuJu=true },
                new Rehabilitation { ID = 1010103, CategoryID = 1, Category = "视力", CategoryDetail = "盲人", RehabilitationName = "定向行走及适应训练" },
                new Rehabilitation { ID = 1010104, CategoryID = 1, Category = "视力", CategoryDetail = "盲人", RehabilitationName = "支持性服务" },
                new Rehabilitation { ID = 1010201, CategoryID = 1, Category = "视力", CategoryDetail = "低视力", RehabilitationName = "辅助器具适配及服务",FuJu=true },
                new Rehabilitation { ID = 1010202, CategoryID = 1, Category = "视力", CategoryDetail = "低视力", RehabilitationName = "视功能训练" },
                //听力
                new Rehabilitation { ID = 1020101, CategoryID = 2, Category = "听力", CategoryDetail = "0-6岁儿童", RehabilitationName = "人工耳蜗植入手术" },
                new Rehabilitation { ID = 1020102, CategoryID = 2, Category = "听力", CategoryDetail = "0-6岁儿童", RehabilitationName = "辅助器具适配及服务",FuJu=true },
                new Rehabilitation { ID = 1020103, CategoryID = 2, Category = "听力", CategoryDetail = "0-6岁儿童", RehabilitationName = "听觉言语功能训练" },
                new Rehabilitation { ID = 1020104, CategoryID = 2, Category = "听力", CategoryDetail = "0-6岁儿童", RehabilitationName = "支持性服务" },
                new Rehabilitation { ID = 1020201, CategoryID = 2, Category = "听力", CategoryDetail = "7—17岁儿童", RehabilitationName = "辅助器具适配及适应训练",FuJu=true },
                new Rehabilitation { ID = 1020202, CategoryID = 2, Category = "听力", CategoryDetail = "7—17岁儿童", RehabilitationName = "支持性服务" },
                new Rehabilitation { ID = 1020301, CategoryID = 2, Category = "听力", CategoryDetail = "成人", RehabilitationName = "辅助器具适配及适应训练",FuJu=true },
                //言语
                new Rehabilitation { ID = 1030101, CategoryID = 3, Category = "言语", CategoryDetail = "成人", RehabilitationName = "" },
                //肢体 
                new Rehabilitation { ID = 1040101, CategoryID = 4, Category = "肢体", CategoryDetail = "0-6岁儿童", RehabilitationName = "矫治手术" },
                new Rehabilitation { ID = 1040102, CategoryID = 4, Category = "肢体", CategoryDetail = "0-6岁儿童", RehabilitationName = "运动及适应训练" },
                new Rehabilitation { ID = 1040103, CategoryID = 4, Category = "肢体", CategoryDetail = "0-6岁儿童", RehabilitationName = "辅助器具适配及服务",FuJu=true },
                new Rehabilitation { ID = 1040104, CategoryID = 4, Category = "肢体", CategoryDetail = "0-6岁儿童", RehabilitationName = "支持性服务" },
                new Rehabilitation { ID = 1040201, CategoryID = 4, Category = "肢体", CategoryDetail = "7-17儿童及成人", RehabilitationName = "康复治疗及训练" },
                new Rehabilitation { ID = 1040202, CategoryID = 4, Category = "肢体", CategoryDetail = "7-17儿童及成人", RehabilitationName = "辅助器具适配及服务",FuJu=true },
                new Rehabilitation { ID = 1040203, CategoryID = 4, Category = "肢体", CategoryDetail = "7-17儿童及成人", RehabilitationName = "支持性服务" },
                //智力
                new Rehabilitation { ID = 1050101, CategoryID = 5, Category = "智力", CategoryDetail = "0-6岁儿童", RehabilitationName = "认知及适应训练" },
                new Rehabilitation { ID = 1050102, CategoryID = 5, Category = "智力", CategoryDetail = "0-6岁儿童", RehabilitationName = "支持性服务" },
                new Rehabilitation { ID = 1050201, CategoryID = 5, Category = "智力", CategoryDetail = "7-17儿童及成人", RehabilitationName = "认知及适应训练" },
                new Rehabilitation { ID = 1050202, CategoryID = 5, Category = "智力", CategoryDetail = "7-17儿童及成人", RehabilitationName = "支持性服务" },
                //精神
                new Rehabilitation { ID = 1060101, CategoryID = 6, Category = "精神", CategoryDetail = "0-6岁孤独症儿童", RehabilitationName = "沟通及适应训练" },
                new Rehabilitation { ID = 1060102, CategoryID = 6, Category = "精神", CategoryDetail = "0-6岁孤独症儿童", RehabilitationName = "支持性服务" },
                new Rehabilitation { ID = 1060201, CategoryID = 6, Category = "精神", CategoryDetail = "7-17孤独症", RehabilitationName = "沟通及适应训练" },
                new Rehabilitation { ID = 1060202, CategoryID = 6, Category = "精神", CategoryDetail = "7-17孤独症", RehabilitationName = "支持性服务" },
                new Rehabilitation { ID = 1060301, CategoryID = 6, Category = "精神", CategoryDetail = "成年精神残疾人", RehabilitationName = "精神疾病药物治疗" },
                new Rehabilitation { ID = 1060302, CategoryID = 6, Category = "精神", CategoryDetail = "成年精神残疾人", RehabilitationName = "精神障碍作业疗法训练" },
                new Rehabilitation { ID = 1060303, CategoryID = 6, Category = "精神", CategoryDetail = "成年精神残疾人", RehabilitationName = "支持性服务" },

            };
            foreach (var r in RehabilitationList)
            {
                db.Rehabilitations.AddOrUpdate(r);
            }
            db.SaveChanges();


            //康复入户信息
            DisabledInfo disabledInfo = new DisabledInfo
            {
                ID = 1,
                Name = "权子豪",
                Sex = 1,
                Tel = "13800000000",
                Guardian = "权子豪爸",
                RelationshipID = 1,
                HasCertificate = true,
                Certificate = "32030219911010101011",
                Need = true,
                CategoryID = 1,
                DegreeID = 1
            };
            db.DisabledInfoes.AddOrUpdate(disabledInfo);
            disabledInfo = new DisabledInfo
            {
                ID = 2,
                Name = "唐莎莎",
                Sex = 2,
                Tel = "13800000000",
                Guardian = "莎莎妈",
                RelationshipID = 2,
                HasCertificate = true,
                Certificate = "32030219911010101022",
                Need = true,
                CategoryID = 2,
                DegreeID = 2
            };
            db.DisabledInfoes.AddOrUpdate(disabledInfo);
            disabledInfo = new DisabledInfo
            {
                ID = 3,
                Name = "周正一",
                Sex = 1,
                Tel = "13800000000",
                Guardian = "周正一妈",
                RelationshipID = 2,
                HasCertificate = true,
                Certificate = "32030219911010101033",
                Need = true,
                CategoryID = 3,
                DegreeID = 3
            };
            db.DisabledInfoes.AddOrUpdate(disabledInfo);
            disabledInfo = new DisabledInfo
            {
                ID = 4,
                Name = "谢琦",
                Sex = 1,
                Tel = "13800000000",
                Guardian = "谢琦妈",
                RelationshipID = 2,
                HasCertificate = true,
                Certificate = "32030219911010101044",
                Need = true,
                CategoryID = 4,
                DegreeID = 4
            };
            db.DisabledInfoes.AddOrUpdate(disabledInfo);
            disabledInfo = new DisabledInfo
            {
                ID = 5,
                Name = "韩冰",
                Sex = 2,
                Tel = "13800000000",
                Guardian = "韩冰妈",
                RelationshipID = 2,
                HasCertificate = true,
                Certificate = "32030219911010101054",
                Need = true,
                CategoryID = 5,
                DegreeID = 4
            };
            db.DisabledInfoes.AddOrUpdate(disabledInfo);
            disabledInfo = new DisabledInfo
            {
                ID = 6,
                Name = "韩儒",
                Sex = 1,
                Tel = "13800000000",
                Guardian = "韩儒妈",
                RelationshipID = 2,
                HasCertificate = true,
                Certificate = "32030219911010101064",
                Need = true,
                CategoryID = 6,
                DegreeID = 4
            };
            db.DisabledInfoes.AddOrUpdate(disabledInfo);
            disabledInfo = new DisabledInfo
            {
                ID = 7,
                Name = "孙永",
                Sex = 1,
                Tel = "13800000000",
                Guardian = "孙永妈",
                RelationshipID = 2,
                HasCertificate = true,
                Certificate = "32030219911010101074",
                Need = true,
                CategoryID = 7,
                DegreeID = 4
            };
            db.DisabledInfoes.AddOrUpdate(disabledInfo);
            db.SaveChanges();

            List<DisabledInfo_Detail> disabledInfo_Details = new List<DisabledInfo_Detail> {
                new DisabledInfo_Detail{ ID=1,DisabledInfoID=1,CategoryID=1,DegreeID=1,RehabilitationID=1010102,NextID=3,TargetExamName="视力" },
                new DisabledInfo_Detail{ ID=2,DisabledInfoID=2,CategoryID=2,DegreeID=2,RehabilitationID=1020102,NextID=3,TargetExamName="听力" },
            };
            foreach (var r in disabledInfo_Details)
            {
                db.DisabledInfo_Details.AddOrUpdate(r);
            }
            db.SaveChanges();
            //评估

            //视力
            List<Question> questions1 = new List<Question> {
                new Question {ID=1010000, QuestionNo="1", QuestionText = "视力残疾等级",IsFirst=true,
                    Options = new List<Option> {
                        new Option(){ OptionText ="A",ContentText="一级",NextQuestionID=1010100},
                        new Option(){ OptionText ="B",ContentText="二级",NextQuestionID=1010100},
                        new Option(){ OptionText ="C",ContentText="三级",NextQuestionID=1010200},
                        new Option(){ OptionText ="D",ContentText="四级",NextQuestionID=1010200},
                        new Option{ OptionText ="E",ContentText="未评定或等级不准",NextQuestionID=1090000},
                    }
                },
                new Question {ID=1090000, QuestionNo="附加题", QuestionText = "能否看见",
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="不能（相当于一、二级）",NextQuestionID=1010100},
                        new Option{ OptionText ="B",ContentText="能（相当于三、四级）",NextQuestionID=1010200},
                    }
                },
                new Question {ID=1010100, QuestionNo="1-1", QuestionText = "能否听见",
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="能",NextQuestionID=1010101},
                        new Option{ OptionText ="B",ContentText="不能",NextQuestionID=1010102},
                    }
                },
                new Question {ID=1010101, QuestionNo="1-1-1", QuestionText = "希望实现何种功能（多选）",Multiple=true,
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="引导出行",NextQuestionID=1020000,AssistiveDeviceID="02 39 03",AssistiveDeviceName="盲杖"},
                        new Option{ OptionText ="B",ContentText="听书娱乐",NextQuestionID=1020000,AssistiveDeviceID="05 18 03",AssistiveDeviceName="声音记录和播放设备(听书机)"},
                        new Option{ OptionText ="C",ContentText="时间提醒",NextQuestionID=1020000,AssistiveDeviceID="05 27 12",AssistiveDeviceName="时钟和计时器(震动闹钟/震动手表)"},
                        new Option{ OptionText ="D",ContentText="通讯交流",NextQuestionID=1020000,AssistiveDeviceID="05 24 06,05 33 15",AssistiveDeviceName="移动网络电话(盲人用手机),浏览器软件和沟通软件"},
                        new Option{ OptionText ="E",ContentText="生活便捷",NextQuestionID=1020000,AssistiveDeviceID="05 27 06",AssistiveDeviceName="声信号指示器"},
                        new Option{ OptionText ="F",ContentText="学习书写",NextQuestionID=1020000,AssistiveDeviceID="03,05 12 12,05 12 18",AssistiveDeviceName="手动式绘画和书写器具,手写盲文书写装置,特制书写纸（塑膜）"},
                    }
                },
                new Question {ID=1010102, QuestionNo="1-1-2", QuestionText = "希望实现何种功能（多选）",Multiple=true,
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="引导出行",NextQuestionID=1020000,AssistiveDeviceID="02 39 03",AssistiveDeviceName="盲杖"},
                        new Option{ OptionText ="B",ContentText="时间提醒",NextQuestionID=1020000,AssistiveDeviceID="05 27 12",AssistiveDeviceName="时钟和计时器(震动闹钟/震动手表)"},
                    }
                },
                new Question {ID=1010200, QuestionNo="1-2", QuestionText = "希望看近物还是看远处（多选）",Multiple=true,
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="看近",NextQuestionID=1010201},
                        new Option{ OptionText ="B",ContentText="看远",NextQuestionID=1010300,AssistiveDeviceID="05 03 12",AssistiveDeviceName="双筒望远镜和单筒望远镜"},
                    }
                },
                new Question {ID=1010201, QuestionNo="1-2-1", QuestionText = "需要光学助视器还是电子助视器",Multiple=true,
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="光学",NextQuestionID=1010300,AssistiveDeviceID="05 03 09",AssistiveDeviceName="具有放大功能的眼镜、镜片、助视系统（只选其中光学类）"},
                        new Option{ OptionText ="B",ContentText="电子",NextQuestionID=1010300,AssistiveDeviceID="05 03 09",AssistiveDeviceName="具有放大功能的眼镜、镜片、助视系统（只选其中电子类）"},
                    }
                },
                new Question {ID=1010300, QuestionNo="1-3", QuestionText = "希望实现何种功能（多选）",Multiple=true,
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="阅读学习",NextQuestionID=1020000,AssistiveDeviceID="05 30 21,05 30 18,05 12 06,05 12 15",AssistiveDeviceName="字符阅读器,阅读框和版面限定器,书写板、绘图板和绘画板,打字机"},
                        new Option{ OptionText ="B",ContentText="交流通讯",NextQuestionID=1020000,AssistiveDeviceID="05 24 03",AssistiveDeviceName="普通网络电话"},
                        new Option{ OptionText ="C",ContentText="数学计算",NextQuestionID=1020000,AssistiveDeviceID="05 15 03,05 15 06",AssistiveDeviceName="手动计算器,计算设备"},
                        new Option{ OptionText ="D",ContentText="休闲娱乐",NextQuestionID=1020000,AssistiveDeviceID="05 21 03",AssistiveDeviceName="字母和符号卡、板"},
                        new Option{ OptionText ="E",ContentText="计算机使用",NextQuestionID=1020000,AssistiveDeviceID="05 33 18",AssistiveDeviceName="用于计算机和网络的附件"},
                    }
                },
                new Question {ID=1020000, QuestionNo="2", QuestionText = "是否存在眩光现象",
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="是",NextQuestionID=1030000,AssistiveDeviceID="05 03 03",AssistiveDeviceName="滤光器：低视力专用滤光镜"},
                        new Option{ OptionText ="B",ContentText="否",NextQuestionID=1030000},
                    }
                },
                new Question {ID=1030000, QuestionNo="3", QuestionText = "是否能正常说话",IsLast=true,
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="能"},
                        new Option{ OptionText ="B",ContentText="不能",NextQuestionID=1030100},
                    }
                },
                new Question {ID=1030100, QuestionNo="3-1", QuestionText = "是否会写字",IsLast=true,
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="会",AssistiveDeviceID="05 12 12,05 09 03",AssistiveDeviceName="手写盲文书写装置,语音发生器"},
                        new Option{ OptionText ="B",ContentText="不会"},
                    }
                },
            };
            Exam exam1 = new Exam { ID = 1, Name = "视力" };
            exam1.Questions = questions1;
            db.Exams.AddOrUpdate(exam1);
            //听力
            List<Question> questions2 = new List<Question> {
                new Question {ID=2010000, QuestionNo="1", QuestionText = "听力残疾等级",IsFirst=true,
                    Options = new List<Option> {
                        ////选A时，结合年龄，系统关联
                        //6岁以下：05 06 助听器-人工耳蜗
                        //6岁-60岁：05 06 助听器(耳背/耳内/耳道/深耳道式助听器)
                        //60岁以上：05 06 06佩戴式（盒式）助听器
                        new Option(){ OptionText ="A",ContentText="一级",NextQuestionID=2020000,AssistiveDeviceID="05 06",AssistiveDeviceName="助听器-人工耳蜗,助听器(耳背/耳内/耳道/深耳道式助听器),佩戴式（盒式）助听器"},
                        new Option(){ OptionText ="B",ContentText="二级",NextQuestionID=2020000,AssistiveDeviceID="05 06",AssistiveDeviceName="助听器(耳背/耳内/耳道/深耳道式助听器)"},
                        new Option(){ OptionText ="C",ContentText="三级",NextQuestionID=2020000,AssistiveDeviceID="05 06",AssistiveDeviceName="助听器(耳背/耳内/耳道/深耳道式助听器)"},
                        new Option(){ OptionText ="D",ContentText="四级",NextQuestionID=2020000,AssistiveDeviceID="05 06",AssistiveDeviceName="助听器(耳背/耳内/耳道/深耳道式助听器)"},
                        new Option{ OptionText ="E",ContentText="未评定或等级不准",NextQuestionID=2010100},
                    }
                },
                new Question {ID=2010100, QuestionNo="1-1", QuestionText = "在安静环境下，不带助听设备时，能听到",
                    Options = new List<Option> {
                        //选A时，结合年龄，系统关联
                        new Option{ OptionText ="A",ContentText="几乎听不到任何声音（等同于一级）",NextQuestionID=2020000,AssistiveDeviceID="05 06",AssistiveDeviceName="助听器-人工耳蜗,助听器(耳背/耳内/耳道/深耳道式助听器),佩戴式（盒式）助听器"},
                        new Option{ OptionText ="B",ContentText="只能听到鞭炮、敲鼓、雷声或用力击掌声（等同于二级）",NextQuestionID=2020000,AssistiveDeviceID="05 06",AssistiveDeviceName="助听器(耳背/耳内/耳道/深耳道式助听器)"},
                        new Option{ OptionText ="C",ContentText="只能听到大声说话（等同于三级）",NextQuestionID=2020000,AssistiveDeviceID="05 06",AssistiveDeviceName="助听器(耳背/耳内/耳道/深耳道式助听器)"},
                        new Option{ OptionText ="D",ContentText="能听到普通谈话声（等同于四级）",NextQuestionID=2020000,AssistiveDeviceID="05 06",AssistiveDeviceName="助听器(耳背/耳内/耳道/深耳道式助听器)"},
                        new Option{ OptionText ="E",ContentText="听清一般言语，能分辨清楚（不配辅助器具）",NextQuestionID=2020000},
                    }
                },
                new Question {ID=2020000, QuestionNo="2", QuestionText = "除听声外，希望实现何种功能",IsLast=true,Multiple=true,
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="语言交流（无语言者）",AssistiveDeviceID="05 21 09",AssistiveDeviceName="对话装置(电子手写交流板/沟通板)"},
                        new Option{ OptionText ="B",ContentText="门铃应答",AssistiveDeviceID="05 27 03",AssistiveDeviceName="视觉信号指示器(闪光门铃)"},
                        new Option{ OptionText ="C",ContentText="叫早起床",AssistiveDeviceID="05 27 12",AssistiveDeviceName="时钟和计时器(震动闹钟)"}
                    }
                }
            };
            Exam exam2 = new Exam { ID = 2, Name = "听力" };
            exam2.Questions = questions2;
            db.Exams.AddOrUpdate(exam2);
        }
    }
}
