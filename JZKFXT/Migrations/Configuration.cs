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

            //��ɫ
            List<Role> Roles = new List<Role>
            {
                new Role( 1, "����������Ա","��������м��˹�������Ա���м���ר�ɡ��м��˿���Э��Ա��","ʹ���ƶ��˶�Ͻ��ָ����ȫ�������ϰ��ߵĻ�����Ϣ���м���Ϣ�������룻��Ͻ��ָ����ȫ�������ϰ��߽��С���׼�����뻧ģ�顱�͡�������������������ģ�顱���������ԡ��ۺϷ���طá�ģ����С���֫�������طá��������ϰ��طá��͡����߻طá����䡰�������񡱵ĸ��١�",""),
                new Role( 2, "����ǩԼҽ��","������չ�м���ҽ�Ʊ��Ϸ����ǩԼҽ����", "�ڡ���׼�����뻧��ģ��͡������������������䡱ģ�飬��Ͻ��ָ����ȫ�������ϰ��߽��о�׼�����뻧�͸����������������䣻�ڡ���������ģ�飬�Թ����ϰ����ṩ��֧���Է��񡱡��ԡ��ۺϷ���طá�ģ����С���֫�������طá��������ϰ��طá��͡����߻طá����䡰�������񡱵ĸ��١�",""),
                new Role( 3, "��������������ȫ��","��������չ���������Ȩ���������縨�����ģ���Ա���漰�����������з���","�ڡ�������������ˡ�ģ�飬�ԡ�����������ӡ�ģ�����ݽ�����������ˣ��ԡ����ϰ����족ģ�����ݽ�����������ˣ��ԡ������������������䡱ģ�������������������ˣ������δͨ��������������ϰ��߽��ж���������",""),
                new Role( 4, "���߼�����Ա��֫�巽��","��������չ���������Ȩ���������縨�����ģ���Ա���漰��������֫�巽��", "�ڡ�������������ˡ�ģ�飬�ԡ�����������ӡ�ģ�����ݽ�����������ˣ��ԡ����ϰ����족ģ�����ݽ�����������ˣ��ԡ������������������䡱ģ�������������������������ˣ������δͨ����֫�幦���ϰ��߽��ж���������",""),
                new Role( 5, "���߼�����Ա����������","��������չ���������Ȩ���������縨�����ģ���Ա���漰����������������", "�ڡ��������������ģ���飬��Ͻ��ָ����ȫ�������ϰ��ߵĸ�����������������ģ���漰������������������������ˡ������δͨ�������������ϰ��߽��ж���������",""),
                new Role( 6, "���߼�����Ա����������","��������չ���������Ȩ���������縨�����ģ���Ա���漰����������������", "�ڻ������������ģ�飬��Ͻ��ָ����ȫ�������ϰ��ߵĸ�����������������ģ���漰������������������������ˡ������δͨ�������������ϰ��߽��ж���������",""),
                new Role( 7, "���߼�����Ա����֫����������","��������չ���������Ȩ���������縨�����ģ���Ա���漰���������֫����������", "�ڡ�������������ˡ�ģ�飬�ԡ�����������ӡ�ģ�����ݽ����������ԡ����ϰ����족ģ�����ݽ����������ԡ������������������䡱ģ�������������������ˣ������δͨ����֫�幦���ϰ��߽��ж���������","")   ,
                new Role( 8, "���߼�����Ա�����ϰ�����","��������չ���������Ȩ���������縨�����ģ���Ա���漰���ϰ�������", "�ڡ�������������ˡ�ģ�飬�ԡ����ϰ����족ģ�����ݽ�����������ˡ�",""),
                new Role( 9, "�����������������⣩","��������չ��������������ҵ������������������漰����������ѵ����������֧���Է��񣬵ȵ�������", "�ڡ�������������ˡ�ģ�飬��Ͻ��ָ����ȫ�������ϰ����漰����������ѵ����������֧���Է�����������������","")   ,
                new Role( 10, "�����������","��������չ��������������ҵ������ķ���������漰����������ѵ����������֧���Է��񣬵ȵķ���", "�ڡ��ۺϿ�������ģ��ġ�����������ģ�飬�Թ����ϰ��߿�չ����������ѵ����������֧���Է��񣬵ȵķ���",""),
                new Role( 11, "���߷������","��������չ���߷���Ļ�����", "�ڡ��ۺϿ�������ģ��ġ����߷�����ģ�飬�Թ����ϰ��߿�չ�����䷢����֫�����������ϰ��ȵķ���","")
            };
            foreach (var r in Roles)
            {
                db.Roles.AddOrUpdate(r);
            }
            db.SaveChanges();

            //�û�
            var user = new User("", "", "����Ա", 1, DateTime.Today);
            db.Users.AddOrUpdate(user);
            db.SaveChanges();

            //��ϵ
            List<Relationship> Relationships = new List<Relationship>
        {
            new Relationship(1, "��ĸ"),
            new Relationship(2, "��ż"),
            new Relationship(3, "�ֵܽ���"),
            new Relationship(4, "�游ĸ"),
            new Relationship(5, "����")
        };
            foreach (var r in Relationships)
            {
                db.Relationships.AddOrUpdate(r);
            }
            db.SaveChanges();

            //�м����
            List<Category> Categories = new List<Category>
        {
            new Category(1, "����"),
            new Category(2, "����"),
            new Category(3, "����"),
            new Category(4, "֫��"),
            new Category(5, "����"),
            new Category(6, "����"),
            new Category(7, "����"),

        };
            foreach (var r in Categories)
            {
                db.Categories.AddOrUpdate(r);
            }
            db.SaveChanges();

            //�м��ȼ�
            List<Degree> Degrees = new List<Degree>
        {
            new Degree(1, "һ��"),
            new Degree(2, "����"),
            new Degree(3, "����"),
            new Degree(4, "�ļ�"),
            new Degree(5, "δ����")
        };
            foreach (var r in Degrees)
            {
                db.Degrees.AddOrUpdate(r);
            }
            db.SaveChanges();

            //�м��ȼ�
            List<Next> Nexts = new List<Next>
        {
            new Next(1, "ת����������"),
            new Next(2, "ת��������"),
            new Next(3, "��������")
        };
            foreach (var r in Nexts)
            {
                db.Nexts.AddOrUpdate(r);
            }

            //�²�ԭ��
            List<DisabilityReason> DisabilityReasons = new List<DisabilityReason>
        {
            new DisabilityReason(1, "����"),
            new DisabilityReason(1, "�����"),
            new DisabilityReason(1, "��Ĥ��"),
            new DisabilityReason(1, "����Ĥ"),
            new DisabilityReason(1, "ɫ��Ĥ����"),
            new DisabilityReason(1, "���ⲻ��/����"),
            new DisabilityReason(1, "������"),
            new DisabilityReason(1, "�ư߱���"),
            new DisabilityReason(1, "����ή��"),
            new DisabilityReason(1, "����"),
            new DisabilityReason(2, "������"),
            new DisabilityReason(2, "ҩ����"),
            new DisabilityReason(2, "������"),
            new DisabilityReason(2, "����"),
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
            new Rehabilitation(1010101, 1, "����", "ä��","�����ϸ�������",false),
            new Rehabilitation(1010102, 1, "����", "ä��","�����������估����", true),
            new Rehabilitation(1010103, 1, "����", "ä��","�������߼���Ӧѵ��",false),
            new Rehabilitation(1010104, 1, "����", "ä��","֧���Է���",false),
            new Rehabilitation(1010201, 1, "����", "������","�����������估����", true),
            new Rehabilitation(1010202, 1, "����", "������","�ӹ���ѵ��",false),
            //����
            new Rehabilitation(1020101, 2, "����", "0-6���ͯ","�˹�����ֲ������",false),
            new Rehabilitation(1020102, 2, "����", "0-6���ͯ","�����������估����", true),
            new Rehabilitation(1020103, 2, "����", "0-6���ͯ","�������﹦��ѵ��",false),
            new Rehabilitation(1020104, 2, "����", "0-6���ͯ","֧���Է���",false),
            new Rehabilitation(1020201, 2, "����", "7��17���ͯ","�����������估��Ӧѵ��", true),
            new Rehabilitation(1020202, 2, "����", "7��17���ͯ","֧���Է���",false),
            new Rehabilitation(1020301, 2, "����", "����","�����������估��Ӧѵ��", true),
            //����
            new Rehabilitation(1030101, 3, "����", "����","",false),
            //֫�� 
            new Rehabilitation(1040101, 4, "֫��", "0-6���ͯ","��������",false),
            new Rehabilitation(1040102, 4, "֫��", "0-6���ͯ","�˶�����Ӧѵ��",false),
            new Rehabilitation(1040103, 4, "֫��", "0-6���ͯ","�����������估����", true),
            new Rehabilitation(1040104, 4, "֫��", "0-6���ͯ","֧���Է���",false),
            new Rehabilitation(1040201, 4, "֫��", "7-17��ͯ������","�������Ƽ�ѵ��",false),
            new Rehabilitation(1040202, 4, "֫��", "7-17��ͯ������","�����������估����", true),
            new Rehabilitation(1040203, 4, "֫��", "7-17��ͯ������","֧���Է���",false),
            //����
            new Rehabilitation(1050101, 5, "����", "0-6���ͯ","��֪����Ӧѵ��",false),
            new Rehabilitation(1050102, 5, "����", "0-6���ͯ","֧���Է���",false),
            new Rehabilitation(1050201, 5, "����", "7-17��ͯ������","��֪����Ӧѵ��",false),
            new Rehabilitation(1050202, 5, "����", "7-17��ͯ������","֧���Է���",false),
            //����
            new Rehabilitation(1060101, 6, "����", "0-6��¶�֢��ͯ","��ͨ����Ӧѵ��",false),
            new Rehabilitation(1060102, 6, "����", "0-6��¶�֢��ͯ","֧���Է���",false),
            new Rehabilitation(1060201, 6, "����", "7-17�¶�֢","��ͨ����Ӧѵ��",false),
            new Rehabilitation(1060202, 6, "����", "7-17�¶�֢","֧���Է���",false),
            new Rehabilitation(1060301, 6, "����", "���꾫��м���","���񼲲�ҩ������",false),
            new Rehabilitation(1060302, 6, "����", "���꾫��м���","�����ϰ���ҵ�Ʒ�ѵ��",false),
            new Rehabilitation(1060303, 6, "����", "���꾫��м���","֧���Է���",false),
        };
            foreach (var r in RehabilitationList)
            {
                db.Rehabilitations.AddOrUpdate(r);
            }
            db.SaveChanges();


            //�����뻧��Ϣ
            DisabledInfo disabledInfo = new DisabledInfo
            (
                "Ȩ�Ӻ�",
                1,
                "13800000000",
               "Ȩ�Ӻ���",
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
                "��ɯɯ",
                2,
                "13800000000",
               "ɯɯ��",
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
                "����һ",
                1,
                "13800000000",
               "����һ��",
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
                "л��",
                1,
                "13800000000",
               "л����",
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
                "����",
                2,
                "13800000000",
               "������",
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
                "����",
                1,
                "13800000000",
               "������",
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
                "����",
                1,
                "13800000000",
               "������",
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
                new DisabledInfo_Detail(1, 1, 1, 1010102, 3, "����"),
                new DisabledInfo_Detail(2, 2, 2, 1020102, 3, "����"),
            };
            foreach (var r in disabledInfo_Details)
            {
                db.DisabledInfo_Details.AddOrUpdate(r);
            }
            db.SaveChanges();
            //����

            //����
            List<Question> questions1 = new List<Question> {
                new Question(1010000, "1", "�����м��ȼ�", true,false,
                    new List<Option>{
                        new Option("A","һ��", 1010100,null,null),
                        new Option("B","����", 1010100,null,null),
                        new Option("C","����", 1010200,null,null),
                        new Option("D","�ļ�", 1010200,null,null),
                        new Option("E","δ������ȼ���׼", 1090000,null,null),
                    }
                ),
                new Question(1090000, "������", "�ܷ񿴼�",false,false,
                    new List<Option>{
                        new Option("A", "���ܣ��൱��һ��������", 1010100,null,null),
                        new Option("B", "�ܣ��൱�������ļ���", 1010200,null,null),
                    }
                ),
                new Question(1010100, "1-1", "�ܷ�����",false,false,
                    new List<Option>{
                        new Option("A", "��", 1010101,null,null),
                        new Option("B", "����", 1010102,null,null),
                    }
                ),
                new Question(1010101, "1-1-1", "ϣ��ʵ�ֺ��ֹ��ܣ���ѡ��", false,true,
                    new List<Option>{
                        new Option("A", "��������", 1020000, "02 39 03", "ä��"),
                        new Option("B", "��������", 1020000, "05 18 03", "������¼�Ͳ����豸(�����)"),
                        new Option("C", "ʱ������", 1020000, "05 27 12", "ʱ�Ӻͼ�ʱ��(������/���ֱ�)"),
                        new Option("D", "ͨѶ����", 1020000, "05 24 06,05 33 15", "�ƶ�����绰(ä�����ֻ�),���������͹�ͨ���"),
                        new Option("E", "������", 1020000, "05 27 06", "���ź�ָʾ��"),
                        new Option("F", "ѧϰ��д", 1020000, "03,05 12 12,05 12 18", "�ֶ�ʽ�滭����д����,��дä����дװ��,������дֽ����Ĥ��"),
                    }
                ),
                new Question(1010102, "1-1-2", "ϣ��ʵ�ֺ��ֹ��ܣ���ѡ��", false,true,
                    new List<Option>{
                        new Option("A", "��������", 1020000, "02 39 03", "ä��"),
                        new Option("B", "ʱ������", 1020000, "05 27 12", "ʱ�Ӻͼ�ʱ��(������/���ֱ�)"),
                    }
                ),
                new Question(1010200, "1-2", "ϣ�������ﻹ�ǿ�Զ������ѡ��", false,true,
                    new List<Option>{
                        new Option("A", "����", 1010201,null,null),
                        new Option("B", "��Զ", 1010300, "05 03 12", "˫Ͳ��Զ���͵�Ͳ��Զ��"),
                    }
                ),
                new Question(1010201, "1-2-1", "��Ҫ��ѧ���������ǵ���������",false,false,
                    new List<Option>{
                        new Option("A", "��ѧ", 1010300, "05 03 09", "���зŴ��ܵ��۾�����Ƭ������ϵͳ��ֻѡ���й�ѧ�ࣩ"),
                        new Option("B", "����", 1010300, "05 03 09", "���зŴ��ܵ��۾�����Ƭ������ϵͳ��ֻѡ���е����ࣩ"),
                    }
                ),
                new Question(1010300, "1-3", "ϣ��ʵ�ֺ��ֹ��ܣ���ѡ��", false,true,
                    new List<Option>{
                        new Option("A", "�Ķ�ѧϰ", 1020000, "05 30 21,05 30 18,05 12 06,05 12 15", "�ַ��Ķ���,�Ķ���Ͱ����޶���,��д�塢��ͼ��ͻ滭��,���ֻ�"),
                        new Option("B", "����ͨѶ", 1020000, "05 24 03", "��ͨ����绰"),
                        new Option("C", "��ѧ����", 1020000, "05 15 03,05 15 06", "�ֶ�������,�����豸"),
                        new Option("D", "��������", 1020000, "05 21 03", "��ĸ�ͷ��ſ�����"),
                        new Option("E", "�����ʹ��", 1020000, "05 33 18", "���ڼ����������ĸ���"),
                    }
                ),
                new Question(1020000, "2", "�Ƿ����ѣ������",false,false,
                    new List<Option>{
                        new Option("A", "��", 1030000, "05 03 03", "�˹�����������ר���˹⾵"),
                        new Option("B", "��", 1030000,null,null),
                    }
                ),
                new Question(1030000, "3", "�Ƿ�������˵��", false,false,
                    new List<Option>{
                        new Option("A", "��",null,null,null),
                        new Option("B", "����", 1030100,null,null),
                    }
                ),
                new Question(1030100, "3-1", "�Ƿ��д��",false,false,
                    new List<Option>{
                        new Option("A", "��", null,"05 12 12,05 09 03", "��дä����дװ��,����������"),
                        new Option("B", "����",null,null,null),
                    }
                ),
            };
            Exam exam1 = new Exam(1, "����", questions1);
            db.Exams.AddOrUpdate(exam1);
            //����
            List<Question> questions2 = new List<Question> {
                new Question(2010000, "1", "�����м��ȼ�", true,false,
                    new List<Option>{
                        ////ѡAʱ��������䣬ϵͳ����
                        //6�����£�05 06 ������-�˹�����
                        //6��-60�꣺05 06 ������(����/����/����/�����ʽ������)
                        //60�����ϣ�05 06 06���ʽ����ʽ��������
                        new Option("A", "һ��", 2020000, "05 06", "������-�˹�����,������(����/����/����/�����ʽ������),���ʽ����ʽ��������"),
                        new Option("B", "����", 2020000, "05 06", "������(����/����/����/�����ʽ������)"),
                        new Option("C", "����", 2020000, "05 06", "������(����/����/����/�����ʽ������)"),
                        new Option("D", "�ļ�", 2020000, "05 06", "������(����/����/����/�����ʽ������)"),
                        new Option("E", "δ������ȼ���׼", 2010100,null,null),
                    }
                ),
                new Question(2010100, "1-1", "�ڰ��������£����������豸ʱ��������",false,false,
                    new List<Option>{
                        //ѡAʱ��������䣬ϵͳ����
                        new Option("A", "�����������κ���������ͬ��һ����", 2020000, "05 06", "������-�˹�����,������(����/����/����/�����ʽ������),���ʽ����ʽ��������"),
                        new Option("B", "ֻ���������ڡ��ùġ���������������������ͬ�ڶ�����", 2020000, "05 06", "������(����/����/����/�����ʽ������)"),
                        new Option("C", "ֻ����������˵������ͬ��������", 2020000, "05 06", "������(����/����/����/�����ʽ������)"),
                        new Option("D", "��������̸ͨ��������ͬ���ļ���", 2020000, "05 06", "������(����/����/����/�����ʽ������)"),
                        new Option("E", "����һ������ֱܷ���������丨�����ߣ�", 2020000,null,null),
                    }
                ),
                new Question(2020000, "2", "�������⣬ϣ��ʵ�ֺ��ֹ���", false,true,
                    new List<Option>{
                        new Option("A", "���Խ������������ߣ�",null, "05 21 09", "�Ի�װ��(������д������/��ͨ��)"),
                        new Option("B", "����Ӧ��", null,"05 27 03", "�Ӿ��ź�ָʾ��(��������)"),
                        new Option("C", "������", null,"05 27 12", "ʱ�Ӻͼ�ʱ��(������)")
                    }
                )
            };
            Exam exam2 = new Exam(2, "����", questions2);
            db.Exams.AddOrUpdate(exam2);



        }
    }
}
