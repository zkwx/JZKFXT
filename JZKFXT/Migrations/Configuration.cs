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
            //�û�
            var user = new User { UserName = "", Password = "", Role = "����Ա", CreateTime = DateTime.Today, LastLoginTime = DateTime.Today };
            db.Users.AddOrUpdate(user);
            db.SaveChanges();

            //��ϵ
            List<Relationship> Relationships = new List<Relationship>
            {
                new Relationship { ID=1,Name = "��ĸ" },
                new Relationship { ID=2,Name = "��ż" },
                new Relationship { ID=3,Name = "�ֵܽ���" },
                new Relationship { ID=4,Name = "�游ĸ" },
                new Relationship { ID=5,Name = "����" }
            };
            foreach (var r in Relationships)
            {
                db.Relationships.AddOrUpdate(r);
            }
            db.SaveChanges();

            //�м����
            List<Category> Categories = new List<Category>
            {
                new Category { ID=1,Name = "����" },
                new Category { ID=2,Name = "����" },
                new Category { ID=3,Name = "����" },
                new Category { ID=4,Name = "֫��" },
                new Category { ID=5,Name = "����" },
                new Category { ID=6,Name = "����" }
            };
            foreach (var r in Categories)
            {
                db.Categories.AddOrUpdate(r);
            }
            db.SaveChanges();

            //�м��ȼ�
            List<Degree> Degrees = new List<Degree>
            {
                new Degree { ID=1,Name = "һ��" },
                new Degree { ID=2,Name = "����" },
                new Degree { ID=3,Name = "����" },
                new Degree { ID=4,Name = "�ļ�" },
                new Degree { ID=5,Name = "δ����" }
            };
            foreach (var r in Degrees)
            {
                db.Degrees.AddOrUpdate(r);
            }
            db.SaveChanges();

            //�м��ȼ�
            List<Next> Nexts = new List<Next>
            {
                new Next { ID=1,Name = "ת����������" },
                new Next { ID=2,Name = "ת��������" },
                new Next { ID=3,Name = "��������" }
            };
            foreach (var r in Nexts)
            {
                db.Nexts.AddOrUpdate(r);
            }

            //�²�ԭ��
            List<DisabilityReason> DisabilityReasons = new List<DisabilityReason>
            {
                new DisabilityReason { ID=1,CategoryID=2,Name = "������" },
                new DisabilityReason { ID=2,CategoryID=2,Name = "ҩ����" },
                new DisabilityReason { ID=3,CategoryID=2,Name = "������" },
                new DisabilityReason { ID=3,CategoryID=2,Name = "����" },
            };
            foreach (var r in DisabilityReasons)
            {
                db.DisabilityReasons.AddOrUpdate(r);
            }
            db.SaveChanges();
            //��������
            List<Rehabilitation> RehabilitationList = new List<Rehabilitation>
            {
                //����
                new Rehabilitation { ID = 1010101, Category = "����", CategoryDetail = "ä��", RehabilitationName = "�����ϸ�������" },
                new Rehabilitation { ID = 1010102, Category = "����", CategoryDetail = "ä��", RehabilitationName = "�����������估����",FuJu=true },
                new Rehabilitation { ID = 1010103, Category = "����", CategoryDetail = "ä��", RehabilitationName = "�������߼���Ӧѵ��" },
                new Rehabilitation { ID = 1010104, Category = "����", CategoryDetail = "ä��", RehabilitationName = "֧���Է���" },
                new Rehabilitation { ID = 1010201, Category = "����", CategoryDetail = "������", RehabilitationName = "�����������估����",FuJu=true },
                new Rehabilitation { ID = 1010202, Category = "����", CategoryDetail = "������", RehabilitationName = "�ӹ���ѵ��" },
                //����
                new Rehabilitation { ID = 1020101, Category = "����", CategoryDetail = "0-6���ͯ", RehabilitationName = "�˹�����ֲ������" },
                new Rehabilitation { ID = 1020102, Category = "����", CategoryDetail = "0-6���ͯ", RehabilitationName = "�����������估����",FuJu=true },
                new Rehabilitation { ID = 1020103, Category = "����", CategoryDetail = "0-6���ͯ", RehabilitationName = "�������﹦��ѵ��" },
                new Rehabilitation { ID = 1020104, Category = "����", CategoryDetail = "0-6���ͯ", RehabilitationName = "֧���Է���" },
                new Rehabilitation { ID = 1020201, Category = "����", CategoryDetail = "7��17���ͯ", RehabilitationName = "�����������估��Ӧѵ��",FuJu=true },
                new Rehabilitation { ID = 1020202, Category = "����", CategoryDetail = "7��17���ͯ", RehabilitationName = "֧���Է���" },
                new Rehabilitation { ID = 1020301, Category = "����", CategoryDetail = "����", RehabilitationName = "�����������估��Ӧѵ��",FuJu=true },
                //����
                new Rehabilitation { ID = 1030101, Category = "����", CategoryDetail = "����", RehabilitationName = "" },
                //֫��
                new Rehabilitation { ID = 1040101, Category = "֫��", CategoryDetail = "0-6���ͯ", RehabilitationName = "��������" },
                new Rehabilitation { ID = 1040102, Category = "֫��", CategoryDetail = "0-6���ͯ", RehabilitationName = "�˶�����Ӧѵ��" },
                new Rehabilitation { ID = 1040103, Category = "֫��", CategoryDetail = "0-6���ͯ", RehabilitationName = "�����������估����",FuJu=true },
                new Rehabilitation { ID = 1040104, Category = "֫��", CategoryDetail = "0-6���ͯ", RehabilitationName = "֧���Է���" },
                new Rehabilitation { ID = 1040201, Category = "֫��", CategoryDetail = "7-17��ͯ������", RehabilitationName = "�������Ƽ�ѵ��" },
                new Rehabilitation { ID = 1040202, Category = "֫��", CategoryDetail = "7-17��ͯ������", RehabilitationName = "�����������估����",FuJu=true },
                new Rehabilitation { ID = 1040203, Category = "֫��", CategoryDetail = "7-17��ͯ������", RehabilitationName = "֧���Է���" },
                //����
                new Rehabilitation { ID = 1050101, Category = "����", CategoryDetail = "0-6���ͯ", RehabilitationName = "��֪����Ӧѵ��" },
                new Rehabilitation { ID = 1050102, Category = "����", CategoryDetail = "0-6���ͯ", RehabilitationName = "֧���Է���" },
                new Rehabilitation { ID = 1050201, Category = "����", CategoryDetail = "7-17��ͯ������", RehabilitationName = "��֪����Ӧѵ��" },
                new Rehabilitation { ID = 1050202, Category = "����", CategoryDetail = "7-17��ͯ������", RehabilitationName = "֧���Է���" },
                //����
                new Rehabilitation { ID = 1060101, Category = "����", CategoryDetail = "0-6��¶�֢��ͯ", RehabilitationName = "��ͨ����Ӧѵ��" },
                new Rehabilitation { ID = 1060102, Category = "����", CategoryDetail = "0-6��¶�֢��ͯ", RehabilitationName = "֧���Է���" },
                new Rehabilitation { ID = 1060201, Category = "����", CategoryDetail = "7-17�¶�֢", RehabilitationName = "��ͨ����Ӧѵ��" },
                new Rehabilitation { ID = 1060202, Category = "����", CategoryDetail = "7-17�¶�֢", RehabilitationName = "֧���Է���" },
                new Rehabilitation { ID = 1060301, Category = "����", CategoryDetail = "���꾫��м���", RehabilitationName = "���񼲲�ҩ������" },
                new Rehabilitation { ID = 1060302, Category = "����", CategoryDetail = "���꾫��м���", RehabilitationName = "�����ϰ���ҵ�Ʒ�ѵ��" },
                new Rehabilitation { ID = 1060303, Category = "����", CategoryDetail = "���꾫��м���", RehabilitationName = "֧���Է���" },

            };
            foreach (var r in RehabilitationList)
            {
                db.Rehabilitations.AddOrUpdate(r);
            }
            db.SaveChanges();


            //�����뻧��Ϣ
            DisabledInfo disabledInfo = new DisabledInfo
            {
                ID = 1,
                Name = "����",
                Sex = 1,
                Tel = "13800000000",
                Guardian = "������",
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
            //����
            List<Question> questions = new List<Question> {
                new Question {ID=1, QuestionNo="1", QuestionText = "�����м��ȼ�",IsFirst=true,
                    Options = new List<Option> {
                        new Option(){ OptionText ="A",ContentText="һ��",NextQuestionID=3,AssistiveDevices="05 06"},
                        new Option(){ OptionText ="B",ContentText="����",NextQuestionID=3,AssistiveDevices="05 06"},
                        new Option(){ OptionText ="C",ContentText="����",NextQuestionID=3,AssistiveDevices="05 06"},
                        new Option(){ OptionText ="D",ContentText="�ļ�",NextQuestionID=3,AssistiveDevices="05 06"},
                        new Option{ OptionText ="E",ContentText="δ������ȼ���׼",NextQuestionID=2,AssistiveDevices="05 06"},
                    }
                },
                new Question {ID=2, QuestionNo="1-1", QuestionText = "�ڰ��������£����������豸ʱ��������",
                    Options = new List<Option> {
                        //ѡAʱ��������䣬ϵͳ����
                        //6�����£�05 06 ������-�˹�����
                        //6��-60�꣺05 06 ������(����/����/����/�����ʽ������)
                        //60�����ϣ�05 06 06���ʽ����ʽ��������
                        new Option{ OptionText ="A",ContentText="�����������κ���������ͬ��һ����",NextQuestionID=3,AssistiveDevices="05 06"},
                        new Option{ OptionText ="B",ContentText="ֻ���������ڡ��ùġ���������������������ͬ�ڶ�����",NextQuestionID=3,AssistiveDevices="05 06"},
                        new Option{ OptionText ="C",ContentText="ֻ����������˵������ͬ��������",NextQuestionID=3,AssistiveDevices="05 06"},
                        new Option{ OptionText ="D",ContentText="��������̸ͨ��������ͬ���ļ���",NextQuestionID=3,AssistiveDevices="05 06"},
                        new Option{ OptionText ="E",ContentText="����һ������ֱܷ���������丨�����ߣ�",NextQuestionID=3,AssistiveDevices="05 06"},
                    }
                },
                new Question {ID=3, QuestionNo="2", QuestionText = "�������⣬ϣ��ʵ�ֺ��ֹ���",IsLast=true,Multiple=true,
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="���Խ������������ߣ�",AssistiveDevices="05 21 09"},
                        new Option{ OptionText ="B",ContentText="����Ӧ��",AssistiveDevices="05 27 03"},
                        new Option{ OptionText ="C",ContentText="������",AssistiveDevices="05 06"}
                    }
                }
            };
            Exam exam = new Exam { ID = 2, ExamName = "����" };
            exam.Questions = questions;
            db.Exams.AddOrUpdate(exam);
        }
    }
}
