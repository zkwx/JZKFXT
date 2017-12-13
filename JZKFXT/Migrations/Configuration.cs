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
            //��ɫ
            List<Role> Roles = new List<Role>
            {
                new Role { ID=1,RoleName = "����������Ա"                  ,Description="��������м��˹�������Ա���м���ר�ɡ��м��˿���Э��Ա��"                                     ,Duty ="ʹ���ƶ��˶�Ͻ��ָ����ȫ�������ϰ��ߵĻ�����Ϣ���м���Ϣ�������룻��Ͻ��ָ����ȫ�������ϰ��߽��С���׼�����뻧ģ�顱�͡�������������������ģ�顱���������ԡ��ۺϷ���طá�ģ����С���֫�������طá��������ϰ��طá��͡����߻طá����䡰�������񡱵ĸ��١�",MenuIDs=""                                             },
                new Role { ID=2,RoleName = "����ǩԼҽ��"                  ,Description="������չ�м���ҽ�Ʊ��Ϸ����ǩԼҽ����"                                                     , Duty="�ڡ���׼�����뻧��ģ��͡������������������䡱ģ�飬��Ͻ��ָ����ȫ�������ϰ��߽��о�׼�����뻧�͸����������������䣻�ڡ���������ģ�飬�Թ����ϰ����ṩ��֧���Է��񡱡��ԡ��ۺϷ���طá�ģ����С���֫�������طá��������ϰ��طá��͡����߻طá����䡰�������񡱵ĸ��١�",MenuIDs=""                             },
                new Role { ID=3,RoleName = "��������������ȫ��",Description="��������չ���������Ȩ���������縨�����ģ���Ա���漰�����������з���"                        ,Duty ="�ڡ�������������ˡ�ģ�飬�ԡ�����������ӡ�ģ�����ݽ�����������ˣ��ԡ����ϰ����족ģ�����ݽ�����������ˣ��ԡ������������������䡱ģ�������������������ˣ������δͨ��������������ϰ��߽��ж���������",MenuIDs=""                          },
                new Role { ID=4,RoleName = "���߼�����Ա��֫�巽��"       ,Description="��������չ���������Ȩ���������縨�����ģ���Ա���漰��������֫�巽��"                        , Duty="�ڡ�������������ˡ�ģ�飬�ԡ�����������ӡ�ģ�����ݽ�����������ˣ��ԡ����ϰ����족ģ�����ݽ�����������ˣ��ԡ������������������䡱ģ�������������������������ˣ������δͨ����֫�幦���ϰ��߽��ж���������",MenuIDs=""                                              },
                new Role { ID=5,RoleName = "���߼�����Ա����������"       ,Description="��������չ���������Ȩ���������縨�����ģ���Ա���漰����������������"                        , Duty="�ڡ��������������ģ���飬��Ͻ��ָ����ȫ�������ϰ��ߵĸ�����������������ģ���漰������������������������ˡ������δͨ�������������ϰ��߽��ж���������",MenuIDs=""                                             },
                new Role { ID=6,RoleName = "���߼�����Ա����������",Description="��������չ���������Ȩ���������縨�����ģ���Ա���漰����������������"                        , Duty="�ڻ������������ģ�飬��Ͻ��ָ����ȫ�������ϰ��ߵĸ�����������������ģ���漰������������������������ˡ������δͨ�������������ϰ��߽��ж���������",MenuIDs=""                 },
                new Role { ID=7,RoleName = "���߼�����Ա����֫����������",Description="��������չ���������Ȩ���������縨�����ģ���Ա���漰���������֫����������"                  , Duty="�ڡ�������������ˡ�ģ�飬�ԡ�����������ӡ�ģ�����ݽ����������ԡ����ϰ����족ģ�����ݽ����������ԡ������������������䡱ģ�������������������ˣ������δͨ����֫�幦���ϰ��߽��ж���������",MenuIDs=""            }   ,
                new Role { ID=8,RoleName = "���߼�����Ա�����ϰ�����"     ,Description="��������չ���������Ȩ���������縨�����ģ���Ա���漰���ϰ�������"                          , Duty="�ڡ�������������ˡ�ģ�飬�ԡ����ϰ����족ģ�����ݽ�����������ˡ�",MenuIDs=""                 },
                new Role { ID=9,RoleName = "�����������������⣩"           ,Description="��������չ��������������ҵ������������������漰����������ѵ����������֧���Է��񣬵ȵ�������"    , Duty="�ڡ�������������ˡ�ģ�飬��Ͻ��ָ����ȫ�������ϰ����漰����������ѵ����������֧���Է�����������������",MenuIDs=""                                                      }   ,
                new Role { ID=10,RoleName = "�����������"                  ,Description="��������չ��������������ҵ������ķ���������漰����������ѵ����������֧���Է��񣬵ȵķ���"    , Duty="�ڡ��ۺϿ�������ģ��ġ�����������ģ�飬�Թ����ϰ��߿�չ����������ѵ����������֧���Է��񣬵ȵķ���",MenuIDs=""                                                                                  },
                new Role { ID=11,RoleName = "���߷������"                  ,Description="��������չ���߷���Ļ�����"                                                                , Duty="�ڡ��ۺϿ�������ģ��ġ����߷�����ģ�飬�Թ����ϰ��߿�չ�����䷢����֫�����������ϰ��ȵķ���",MenuIDs=""                      }
            };
            foreach (var r in Roles)
            {
                db.Roles.AddOrUpdate(r);
            }
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
                new Category { ID=6,Name = "����" },
                new Category { ID=7,Name = "����" },
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
                new DisabilityReason { CategoryID=1,Name = "����" },
                new DisabilityReason { CategoryID=1,Name = "�����" },
                new DisabilityReason { CategoryID=1,Name = "��Ĥ��" },
                new DisabilityReason { CategoryID=1,Name = "����Ĥ" },
                new DisabilityReason { CategoryID=1,Name = "ɫ��Ĥ����" },
                new DisabilityReason { CategoryID=1,Name = "���ⲻ��/����" },
                new DisabilityReason { CategoryID=1,Name = "������" },
                new DisabilityReason { CategoryID=1,Name = "�ư߱���" },
                new DisabilityReason { CategoryID=1,Name = "����ή��" },
                new DisabilityReason { CategoryID=1,Name = "����" },
                new DisabilityReason { CategoryID=2,Name = "������" },
                new DisabilityReason { CategoryID=2,Name = "ҩ����" },
                new DisabilityReason { CategoryID=2,Name = "������" },
                new DisabilityReason { CategoryID=2,Name = "����" },
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
                new Rehabilitation { ID = 1010101, CategoryID = 1, Category = "����", CategoryDetail = "ä��", RehabilitationName = "�����ϸ�������" },
                new Rehabilitation { ID = 1010102, CategoryID = 1, Category = "����", CategoryDetail = "ä��", RehabilitationName = "�����������估����",FuJu=true },
                new Rehabilitation { ID = 1010103, CategoryID = 1, Category = "����", CategoryDetail = "ä��", RehabilitationName = "�������߼���Ӧѵ��" },
                new Rehabilitation { ID = 1010104, CategoryID = 1, Category = "����", CategoryDetail = "ä��", RehabilitationName = "֧���Է���" },
                new Rehabilitation { ID = 1010201, CategoryID = 1, Category = "����", CategoryDetail = "������", RehabilitationName = "�����������估����",FuJu=true },
                new Rehabilitation { ID = 1010202, CategoryID = 1, Category = "����", CategoryDetail = "������", RehabilitationName = "�ӹ���ѵ��" },
                //����
                new Rehabilitation { ID = 1020101, CategoryID = 2, Category = "����", CategoryDetail = "0-6���ͯ", RehabilitationName = "�˹�����ֲ������" },
                new Rehabilitation { ID = 1020102, CategoryID = 2, Category = "����", CategoryDetail = "0-6���ͯ", RehabilitationName = "�����������估����",FuJu=true },
                new Rehabilitation { ID = 1020103, CategoryID = 2, Category = "����", CategoryDetail = "0-6���ͯ", RehabilitationName = "�������﹦��ѵ��" },
                new Rehabilitation { ID = 1020104, CategoryID = 2, Category = "����", CategoryDetail = "0-6���ͯ", RehabilitationName = "֧���Է���" },
                new Rehabilitation { ID = 1020201, CategoryID = 2, Category = "����", CategoryDetail = "7��17���ͯ", RehabilitationName = "�����������估��Ӧѵ��",FuJu=true },
                new Rehabilitation { ID = 1020202, CategoryID = 2, Category = "����", CategoryDetail = "7��17���ͯ", RehabilitationName = "֧���Է���" },
                new Rehabilitation { ID = 1020301, CategoryID = 2, Category = "����", CategoryDetail = "����", RehabilitationName = "�����������估��Ӧѵ��",FuJu=true },
                //����
                new Rehabilitation { ID = 1030101, CategoryID = 3, Category = "����", CategoryDetail = "����", RehabilitationName = "" },
                //֫�� 
                new Rehabilitation { ID = 1040101, CategoryID = 4, Category = "֫��", CategoryDetail = "0-6���ͯ", RehabilitationName = "��������" },
                new Rehabilitation { ID = 1040102, CategoryID = 4, Category = "֫��", CategoryDetail = "0-6���ͯ", RehabilitationName = "�˶�����Ӧѵ��" },
                new Rehabilitation { ID = 1040103, CategoryID = 4, Category = "֫��", CategoryDetail = "0-6���ͯ", RehabilitationName = "�����������估����",FuJu=true },
                new Rehabilitation { ID = 1040104, CategoryID = 4, Category = "֫��", CategoryDetail = "0-6���ͯ", RehabilitationName = "֧���Է���" },
                new Rehabilitation { ID = 1040201, CategoryID = 4, Category = "֫��", CategoryDetail = "7-17��ͯ������", RehabilitationName = "�������Ƽ�ѵ��" },
                new Rehabilitation { ID = 1040202, CategoryID = 4, Category = "֫��", CategoryDetail = "7-17��ͯ������", RehabilitationName = "�����������估����",FuJu=true },
                new Rehabilitation { ID = 1040203, CategoryID = 4, Category = "֫��", CategoryDetail = "7-17��ͯ������", RehabilitationName = "֧���Է���" },
                //����
                new Rehabilitation { ID = 1050101, CategoryID = 5, Category = "����", CategoryDetail = "0-6���ͯ", RehabilitationName = "��֪����Ӧѵ��" },
                new Rehabilitation { ID = 1050102, CategoryID = 5, Category = "����", CategoryDetail = "0-6���ͯ", RehabilitationName = "֧���Է���" },
                new Rehabilitation { ID = 1050201, CategoryID = 5, Category = "����", CategoryDetail = "7-17��ͯ������", RehabilitationName = "��֪����Ӧѵ��" },
                new Rehabilitation { ID = 1050202, CategoryID = 5, Category = "����", CategoryDetail = "7-17��ͯ������", RehabilitationName = "֧���Է���" },
                //����
                new Rehabilitation { ID = 1060101, CategoryID = 6, Category = "����", CategoryDetail = "0-6��¶�֢��ͯ", RehabilitationName = "��ͨ����Ӧѵ��" },
                new Rehabilitation { ID = 1060102, CategoryID = 6, Category = "����", CategoryDetail = "0-6��¶�֢��ͯ", RehabilitationName = "֧���Է���" },
                new Rehabilitation { ID = 1060201, CategoryID = 6, Category = "����", CategoryDetail = "7-17�¶�֢", RehabilitationName = "��ͨ����Ӧѵ��" },
                new Rehabilitation { ID = 1060202, CategoryID = 6, Category = "����", CategoryDetail = "7-17�¶�֢", RehabilitationName = "֧���Է���" },
                new Rehabilitation { ID = 1060301, CategoryID = 6, Category = "����", CategoryDetail = "���꾫��м���", RehabilitationName = "���񼲲�ҩ������" },
                new Rehabilitation { ID = 1060302, CategoryID = 6, Category = "����", CategoryDetail = "���꾫��м���", RehabilitationName = "�����ϰ���ҵ�Ʒ�ѵ��" },
                new Rehabilitation { ID = 1060303, CategoryID = 6, Category = "����", CategoryDetail = "���꾫��м���", RehabilitationName = "֧���Է���" },

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
                Name = "Ȩ�Ӻ�",
                Sex = 1,
                Tel = "13800000000",
                Guardian = "Ȩ�Ӻ���",
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
                Name = "��ɯɯ",
                Sex = 2,
                Tel = "13800000000",
                Guardian = "ɯɯ��",
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
                Name = "����һ",
                Sex = 1,
                Tel = "13800000000",
                Guardian = "����һ��",
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
                Name = "л��",
                Sex = 1,
                Tel = "13800000000",
                Guardian = "л����",
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
                Name = "����",
                Sex = 2,
                Tel = "13800000000",
                Guardian = "������",
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
                Name = "����",
                Sex = 1,
                Tel = "13800000000",
                Guardian = "������",
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
                Name = "����",
                Sex = 1,
                Tel = "13800000000",
                Guardian = "������",
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
                new DisabledInfo_Detail{ ID=1,DisabledInfoID=1,CategoryID=1,DegreeID=1,RehabilitationID=1010102,NextID=3,TargetExamName="����" },
                new DisabledInfo_Detail{ ID=2,DisabledInfoID=2,CategoryID=2,DegreeID=2,RehabilitationID=1020102,NextID=3,TargetExamName="����" },
            };
            foreach (var r in disabledInfo_Details)
            {
                db.DisabledInfo_Details.AddOrUpdate(r);
            }
            db.SaveChanges();
            //����

            //����
            List<Question> questions1 = new List<Question> {
                new Question {ID=1010000, QuestionNo="1", QuestionText = "�����м��ȼ�",IsFirst=true,
                    Options = new List<Option> {
                        new Option(){ OptionText ="A",ContentText="һ��",NextQuestionID=1010100},
                        new Option(){ OptionText ="B",ContentText="����",NextQuestionID=1010100},
                        new Option(){ OptionText ="C",ContentText="����",NextQuestionID=1010200},
                        new Option(){ OptionText ="D",ContentText="�ļ�",NextQuestionID=1010200},
                        new Option{ OptionText ="E",ContentText="δ������ȼ���׼",NextQuestionID=1090000},
                    }
                },
                new Question {ID=1090000, QuestionNo="������", QuestionText = "�ܷ񿴼�",
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="���ܣ��൱��һ��������",NextQuestionID=1010100},
                        new Option{ OptionText ="B",ContentText="�ܣ��൱�������ļ���",NextQuestionID=1010200},
                    }
                },
                new Question {ID=1010100, QuestionNo="1-1", QuestionText = "�ܷ�����",
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="��",NextQuestionID=1010101},
                        new Option{ OptionText ="B",ContentText="����",NextQuestionID=1010102},
                    }
                },
                new Question {ID=1010101, QuestionNo="1-1-1", QuestionText = "ϣ��ʵ�ֺ��ֹ��ܣ���ѡ��",Multiple=true,
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="��������",NextQuestionID=1020000,AssistiveDeviceID="02 39 03",AssistiveDeviceName="ä��"},
                        new Option{ OptionText ="B",ContentText="��������",NextQuestionID=1020000,AssistiveDeviceID="05 18 03",AssistiveDeviceName="������¼�Ͳ����豸(�����)"},
                        new Option{ OptionText ="C",ContentText="ʱ������",NextQuestionID=1020000,AssistiveDeviceID="05 27 12",AssistiveDeviceName="ʱ�Ӻͼ�ʱ��(������/���ֱ�)"},
                        new Option{ OptionText ="D",ContentText="ͨѶ����",NextQuestionID=1020000,AssistiveDeviceID="05 24 06,05 33 15",AssistiveDeviceName="�ƶ�����绰(ä�����ֻ�),���������͹�ͨ���"},
                        new Option{ OptionText ="E",ContentText="������",NextQuestionID=1020000,AssistiveDeviceID="05 27 06",AssistiveDeviceName="���ź�ָʾ��"},
                        new Option{ OptionText ="F",ContentText="ѧϰ��д",NextQuestionID=1020000,AssistiveDeviceID="03,05 12 12,05 12 18",AssistiveDeviceName="�ֶ�ʽ�滭����д����,��дä����дװ��,������дֽ����Ĥ��"},
                    }
                },
                new Question {ID=1010102, QuestionNo="1-1-2", QuestionText = "ϣ��ʵ�ֺ��ֹ��ܣ���ѡ��",Multiple=true,
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="��������",NextQuestionID=1020000,AssistiveDeviceID="02 39 03",AssistiveDeviceName="ä��"},
                        new Option{ OptionText ="B",ContentText="ʱ������",NextQuestionID=1020000,AssistiveDeviceID="05 27 12",AssistiveDeviceName="ʱ�Ӻͼ�ʱ��(������/���ֱ�)"},
                    }
                },
                new Question {ID=1010200, QuestionNo="1-2", QuestionText = "ϣ�������ﻹ�ǿ�Զ������ѡ��",Multiple=true,
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="����",NextQuestionID=1010201},
                        new Option{ OptionText ="B",ContentText="��Զ",NextQuestionID=1010300,AssistiveDeviceID="05 03 12",AssistiveDeviceName="˫Ͳ��Զ���͵�Ͳ��Զ��"},
                    }
                },
                new Question {ID=1010201, QuestionNo="1-2-1", QuestionText = "��Ҫ��ѧ���������ǵ���������",Multiple=true,
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="��ѧ",NextQuestionID=1010300,AssistiveDeviceID="05 03 09",AssistiveDeviceName="���зŴ��ܵ��۾�����Ƭ������ϵͳ��ֻѡ���й�ѧ�ࣩ"},
                        new Option{ OptionText ="B",ContentText="����",NextQuestionID=1010300,AssistiveDeviceID="05 03 09",AssistiveDeviceName="���зŴ��ܵ��۾�����Ƭ������ϵͳ��ֻѡ���е����ࣩ"},
                    }
                },
                new Question {ID=1010300, QuestionNo="1-3", QuestionText = "ϣ��ʵ�ֺ��ֹ��ܣ���ѡ��",Multiple=true,
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="�Ķ�ѧϰ",NextQuestionID=1020000,AssistiveDeviceID="05 30 21,05 30 18,05 12 06,05 12 15",AssistiveDeviceName="�ַ��Ķ���,�Ķ���Ͱ����޶���,��д�塢��ͼ��ͻ滭��,���ֻ�"},
                        new Option{ OptionText ="B",ContentText="����ͨѶ",NextQuestionID=1020000,AssistiveDeviceID="05 24 03",AssistiveDeviceName="��ͨ����绰"},
                        new Option{ OptionText ="C",ContentText="��ѧ����",NextQuestionID=1020000,AssistiveDeviceID="05 15 03,05 15 06",AssistiveDeviceName="�ֶ�������,�����豸"},
                        new Option{ OptionText ="D",ContentText="��������",NextQuestionID=1020000,AssistiveDeviceID="05 21 03",AssistiveDeviceName="��ĸ�ͷ��ſ�����"},
                        new Option{ OptionText ="E",ContentText="�����ʹ��",NextQuestionID=1020000,AssistiveDeviceID="05 33 18",AssistiveDeviceName="���ڼ����������ĸ���"},
                    }
                },
                new Question {ID=1020000, QuestionNo="2", QuestionText = "�Ƿ����ѣ������",
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="��",NextQuestionID=1030000,AssistiveDeviceID="05 03 03",AssistiveDeviceName="�˹�����������ר���˹⾵"},
                        new Option{ OptionText ="B",ContentText="��",NextQuestionID=1030000},
                    }
                },
                new Question {ID=1030000, QuestionNo="3", QuestionText = "�Ƿ�������˵��",IsLast=true,
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="��"},
                        new Option{ OptionText ="B",ContentText="����",NextQuestionID=1030100},
                    }
                },
                new Question {ID=1030100, QuestionNo="3-1", QuestionText = "�Ƿ��д��",IsLast=true,
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="��",AssistiveDeviceID="05 12 12,05 09 03",AssistiveDeviceName="��дä����дװ��,����������"},
                        new Option{ OptionText ="B",ContentText="����"},
                    }
                },
            };
            Exam exam1 = new Exam { ID = 1, Name = "����" };
            exam1.Questions = questions1;
            db.Exams.AddOrUpdate(exam1);
            //����
            List<Question> questions2 = new List<Question> {
                new Question {ID=2010000, QuestionNo="1", QuestionText = "�����м��ȼ�",IsFirst=true,
                    Options = new List<Option> {
                        ////ѡAʱ��������䣬ϵͳ����
                        //6�����£�05 06 ������-�˹�����
                        //6��-60�꣺05 06 ������(����/����/����/�����ʽ������)
                        //60�����ϣ�05 06 06���ʽ����ʽ��������
                        new Option(){ OptionText ="A",ContentText="һ��",NextQuestionID=2020000,AssistiveDeviceID="05 06",AssistiveDeviceName="������-�˹�����,������(����/����/����/�����ʽ������),���ʽ����ʽ��������"},
                        new Option(){ OptionText ="B",ContentText="����",NextQuestionID=2020000,AssistiveDeviceID="05 06",AssistiveDeviceName="������(����/����/����/�����ʽ������)"},
                        new Option(){ OptionText ="C",ContentText="����",NextQuestionID=2020000,AssistiveDeviceID="05 06",AssistiveDeviceName="������(����/����/����/�����ʽ������)"},
                        new Option(){ OptionText ="D",ContentText="�ļ�",NextQuestionID=2020000,AssistiveDeviceID="05 06",AssistiveDeviceName="������(����/����/����/�����ʽ������)"},
                        new Option{ OptionText ="E",ContentText="δ������ȼ���׼",NextQuestionID=2010100},
                    }
                },
                new Question {ID=2010100, QuestionNo="1-1", QuestionText = "�ڰ��������£����������豸ʱ��������",
                    Options = new List<Option> {
                        //ѡAʱ��������䣬ϵͳ����
                        new Option{ OptionText ="A",ContentText="�����������κ���������ͬ��һ����",NextQuestionID=2020000,AssistiveDeviceID="05 06",AssistiveDeviceName="������-�˹�����,������(����/����/����/�����ʽ������),���ʽ����ʽ��������"},
                        new Option{ OptionText ="B",ContentText="ֻ���������ڡ��ùġ���������������������ͬ�ڶ�����",NextQuestionID=2020000,AssistiveDeviceID="05 06",AssistiveDeviceName="������(����/����/����/�����ʽ������)"},
                        new Option{ OptionText ="C",ContentText="ֻ����������˵������ͬ��������",NextQuestionID=2020000,AssistiveDeviceID="05 06",AssistiveDeviceName="������(����/����/����/�����ʽ������)"},
                        new Option{ OptionText ="D",ContentText="��������̸ͨ��������ͬ���ļ���",NextQuestionID=2020000,AssistiveDeviceID="05 06",AssistiveDeviceName="������(����/����/����/�����ʽ������)"},
                        new Option{ OptionText ="E",ContentText="����һ������ֱܷ���������丨�����ߣ�",NextQuestionID=2020000},
                    }
                },
                new Question {ID=2020000, QuestionNo="2", QuestionText = "�������⣬ϣ��ʵ�ֺ��ֹ���",IsLast=true,Multiple=true,
                    Options = new List<Option> {
                        new Option{ OptionText ="A",ContentText="���Խ������������ߣ�",AssistiveDeviceID="05 21 09",AssistiveDeviceName="�Ի�װ��(������д������/��ͨ��)"},
                        new Option{ OptionText ="B",ContentText="����Ӧ��",AssistiveDeviceID="05 27 03",AssistiveDeviceName="�Ӿ��ź�ָʾ��(��������)"},
                        new Option{ OptionText ="C",ContentText="������",AssistiveDeviceID="05 27 12",AssistiveDeviceName="ʱ�Ӻͼ�ʱ��(������)"}
                    }
                }
            };
            Exam exam2 = new Exam { ID = 2, Name = "����" };
            exam2.Questions = questions2;
            db.Exams.AddOrUpdate(exam2);
        }
    }
}
