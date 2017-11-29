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
                new Category { ID=6,Name = "精神" }
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
                new DisabilityReason { ID=1,CategoryID=2,Name = "先天性" },
                new DisabilityReason { ID=2,CategoryID=2,Name = "药物性" },
                new DisabilityReason { ID=3,CategoryID=2,Name = "老年性" },
                new DisabilityReason { ID=3,CategoryID=2,Name = "其他" },
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
                new Rehabilitation { ID = 1010101, Category = "视力", CategoryDetail = "盲人", RehabilitationName = "白内障复明手术" },
                new Rehabilitation { ID = 1010102, Category = "视力", CategoryDetail = "盲人", RehabilitationName = "辅助器具适配及服务",FuJu=true },
                new Rehabilitation { ID = 1010103, Category = "视力", CategoryDetail = "盲人", RehabilitationName = "定向行走及适应训练" },
                new Rehabilitation { ID = 1010104, Category = "视力", CategoryDetail = "盲人", RehabilitationName = "支持性服务" },
                new Rehabilitation { ID = 1010201, Category = "视力", CategoryDetail = "低视力", RehabilitationName = "辅助器具适配及服务",FuJu=true },
                new Rehabilitation { ID = 1010202, Category = "视力", CategoryDetail = "低视力", RehabilitationName = "视功能训练" },
                //听力
                new Rehabilitation { ID = 1020101, Category = "听力", CategoryDetail = "0-6岁儿童", RehabilitationName = "人工耳蜗植入手术" },
                new Rehabilitation { ID = 1020102, Category = "听力", CategoryDetail = "0-6岁儿童", RehabilitationName = "辅助器具适配及服务",FuJu=true },
                new Rehabilitation { ID = 1020103, Category = "听力", CategoryDetail = "0-6岁儿童", RehabilitationName = "听觉言语功能训练" },
                new Rehabilitation { ID = 1020104, Category = "听力", CategoryDetail = "0-6岁儿童", RehabilitationName = "支持性服务" },
                new Rehabilitation { ID = 1020201, Category = "听力", CategoryDetail = "7—17岁儿童", RehabilitationName = "辅助器具适配及适应训练",FuJu=true },
                new Rehabilitation { ID = 1020202, Category = "听力", CategoryDetail = "7—17岁儿童", RehabilitationName = "支持性服务" },
                new Rehabilitation { ID = 1020301, Category = "听力", CategoryDetail = "成人", RehabilitationName = "辅助器具适配及适应训练",FuJu=true },
                //言语
                new Rehabilitation { ID = 1030101, Category = "言语", CategoryDetail = "成人", RehabilitationName = "" },
                //肢体
                new Rehabilitation { ID = 1040101, Category = "肢体", CategoryDetail = "0-6岁儿童", RehabilitationName = "矫治手术" },
                new Rehabilitation { ID = 1040102, Category = "肢体", CategoryDetail = "0-6岁儿童", RehabilitationName = "运动及适应训练" },
                new Rehabilitation { ID = 1040103, Category = "肢体", CategoryDetail = "0-6岁儿童", RehabilitationName = "辅助器具适配及服务",FuJu=true },
                new Rehabilitation { ID = 1040104, Category = "肢体", CategoryDetail = "0-6岁儿童", RehabilitationName = "支持性服务" },
                new Rehabilitation { ID = 1040201, Category = "肢体", CategoryDetail = "7-17儿童及成人", RehabilitationName = "康复治疗及训练" },
                new Rehabilitation { ID = 1040202, Category = "肢体", CategoryDetail = "7-17儿童及成人", RehabilitationName = "辅助器具适配及服务",FuJu=true },
                new Rehabilitation { ID = 1040203, Category = "肢体", CategoryDetail = "7-17儿童及成人", RehabilitationName = "支持性服务" },
                //智力
                new Rehabilitation { ID = 1050101, Category = "智力", CategoryDetail = "0-6岁儿童", RehabilitationName = "认知及适应训练" },
                new Rehabilitation { ID = 1050102, Category = "智力", CategoryDetail = "0-6岁儿童", RehabilitationName = "支持性服务" },
                new Rehabilitation { ID = 1050201, Category = "智力", CategoryDetail = "7-17儿童及成人", RehabilitationName = "认知及适应训练" },
                new Rehabilitation { ID = 1050202, Category = "智力", CategoryDetail = "7-17儿童及成人", RehabilitationName = "支持性服务" },
                //精神
                new Rehabilitation { ID = 1060101, Category = "精神", CategoryDetail = "0-6岁孤独症儿童", RehabilitationName = "沟通及适应训练" },
                new Rehabilitation { ID = 1060102, Category = "精神", CategoryDetail = "0-6岁孤独症儿童", RehabilitationName = "支持性服务" },
                new Rehabilitation { ID = 1060201, Category = "精神", CategoryDetail = "7-17孤独症", RehabilitationName = "沟通及适应训练" },
                new Rehabilitation { ID = 1060202, Category = "精神", CategoryDetail = "7-17孤独症", RehabilitationName = "支持性服务" },
                new Rehabilitation { ID = 1060301, Category = "精神", CategoryDetail = "成年精神残疾人", RehabilitationName = "精神疾病药物治疗" },
                new Rehabilitation { ID = 1060302, Category = "精神", CategoryDetail = "成年精神残疾人", RehabilitationName = "精神障碍作业疗法训练" },
                new Rehabilitation { ID = 1060303, Category = "精神", CategoryDetail = "成年精神残疾人", RehabilitationName = "支持性服务" },

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
                Name = "张三",
                Sex = 1,
                Tel = "13800000000",
                Guardian = "张三妈",
                RelationshipID = 1,
                HasCertificate = true,
                Certificate = "32030219911010101023",
                Need = true,
                CategoryID=2,
                DegreeID=3
            };
            db.DisabledInfoes.AddOrUpdate(disabledInfo);
            db.SaveChanges();

            List<DisabledInfo_Detail> disabledInfo_Details = new List<DisabledInfo_Detail> {
                new DisabledInfo_Detail{ ID=1,DisabledInfoID=1,CategoryID=2,DegreeID=3,RehabilitationID=1020102,NextID=3 },
            };
            foreach (var r in disabledInfo_Details)
            {
                db.DisabledInfo_Details.AddOrUpdate(r);
            }
            db.SaveChanges();
            //评估
            List<Question> questions = new List<Question> {
                new Question {ID=1, QuestionNo="1", QuestionText = "听力残疾等级",IsFirst=true,
                    Options = new List<Option> {
                        new Option(){ OptionText ="A",ContentText="一级",NextQuestionID=3,AssistiveDevices="05 06"},
                        new Option(){ OptionText ="B",ContentText="二级",NextQuestionID=3,AssistiveDevices="05 06"},
                        new Option(){ OptionText ="C",ContentText="三级",NextQuestionID=3,AssistiveDevices="05 06"},
                        new Option(){ OptionText ="D",ContentText="四级",NextQuestionID=3,AssistiveDevices="05 06"},
                        new Option{ OptionText ="E",ContentText="未评定或等级不准",NextQuestionID=2,AssistiveDevices="05 06"},
                    }
                },
                new Question {ID=2, QuestionNo="1-1", QuestionText = "在安静环境下，不带助听设备时，能听到",
                    Options = new List<Option> {
                        //选A时，结合年龄，系统关联
                        //6岁以下：05 06 助听器-人工耳蜗
                        //6岁-60岁：05 06 助听器(耳背/耳内/耳道/深耳道式助听器)
                        //60岁以上：05 06 06佩戴式（盒式）助听器
                        new Option{ OptionText ="A",ContentText="几乎听不到任何声音（等同于一级）",NextQuestionID=3,AssistiveDevices="05 06"},
                        new Option{ OptionText ="B",ContentText="只能听到鞭炮、敲鼓、雷声或用力击掌声（等同于二级）",NextQuestionID=3,AssistiveDevices="05 06"},
                        new Option{ OptionText ="C",ContentText="只能听到大声说话（等同于三级）",NextQuestionID=3,AssistiveDevices="05 06"},
                        new Option{ OptionText ="D",ContentText="能听到普通谈话声（等同于四级）",NextQuestionID=3,AssistiveDevices="05 06"},
                        new Option{ OptionText ="E",ContentText="听清一般言语，能分辨清楚（不配辅助器具）",NextQuestionID=3,AssistiveDevices="05 06"},
                    }
                },
                new Question {ID=3, QuestionNo="2", QuestionText = "除听声外，希望实现何种功能",IsLast=true,Multiple=true,
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="语言交流（无语言者）",AssistiveDevices="05 21 09"},
                        new Option{ OptionText ="B",ContentText="门铃应答",AssistiveDevices="05 27 03"},
                        new Option{ OptionText ="C",ContentText="叫早起床",AssistiveDevices="05 06"}
                    }
                }
            };
            Exam exam = new Exam { ID = 2, ExamName = "听力" };
            exam.Questions = questions;
            db.Exams.AddOrUpdate(exam);
        }
    }
}
