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
            List<AssistiveDevice> AssistiveDevices = new List<AssistiveDevice>
            {
                new AssistiveDevice(10217,"���������","���δ���"),
                new AssistiveDevice(10218,"���г�","���δ���"),
                new AssistiveDevice(10222,"�ֶ����γ�","���δ���"),
                new AssistiveDevice(10223,"�������γ�","���δ���"),

                new AssistiveDevice(1021703,"��¥��װ��","���δ���"),
                new AssistiveDevice(1021706,"վ��ʽ������","���δ���"),
                new AssistiveDevice(1021806,"���˽�̤���ֳ������ֳ�","���δ���"),
                new AssistiveDevice(1021809,"��ҡ���ֳ�","���δ���"),
                new AssistiveDevice(1022203,"˫���������γ�","���δ���"),
                new AssistiveDevice(1022206,"�ڸ���������","���δ���"),
                new AssistiveDevice(1022209,"�����������γ�","���δ���"),
                new AssistiveDevice(1022212,"���������ֶ����γ�","���δ���"),
                new AssistiveDevice(1022215,"����������","���δ���"),
                new AssistiveDevice(1022218,"�����߲��ݵ����γ�","���δ���"),
                new AssistiveDevice(1022303,"�綯���γ�","���δ���"),
                new AssistiveDevice(1022315,"��¥�����γ�","���δ���"),
                new AssistiveDevice(1022309,"�������γ�","���δ���"),
                new AssistiveDevice(102170301,"��¥������","���δ���"),

                new AssistiveDevice(102170302,"��¥���������ع���","���δ���"),
                new AssistiveDevice(102170601,"վ��ʽ������","���δ���"),
                new AssistiveDevice(102180601,"��ҡ��̤����ʽ���ֳ�","���δ���"),
                new AssistiveDevice(102180602,"��ҡ��̤����ʽ���ֳ�","���δ���"),
                new AssistiveDevice(102180901,"��ҡ��������ʽ���ֳ�","���δ���"),
                new AssistiveDevice(102180902,"��ҡ����ǰ��ʽ���ֳ�","���δ���"),
                new AssistiveDevice(102180903,"ƽҡʽ��ҡ���ֳ�","���δ���"),
                new AssistiveDevice(102180904,"����ʽ��ҡ���ֳ�","���δ���"),
                new AssistiveDevice(102220301,"��ͨ���Σ������������Σ�","���δ���"),
                new AssistiveDevice(102220302,"��������","���δ���"),
                new AssistiveDevice(102220303,"ϴԡ����","���δ���"),
                new AssistiveDevice(102220304,"ǰ����������","���δ���"),
                new AssistiveDevice(102220305,"վ��ʽ�ֶ�����","���δ���"),
                new AssistiveDevice(102220306,"б��ʽ�ֶ�����","���δ���"),
                new AssistiveDevice(102220307,"��бʽ�ֶ�����","���δ���"),
                new AssistiveDevice(102220308,"��������","���δ���"),
                new AssistiveDevice(102220309,"�˶�����","���δ���"),
                new AssistiveDevice(102220310,"��������","���δ���"),
                new AssistiveDevice(102220311,"ƹ��������","���δ���"),
                new AssistiveDevice(102220312,"���������","���δ���"),
                new AssistiveDevice(102220313,"��������","���δ���"),
                new AssistiveDevice(102220314,"�赸����","���δ���"),
                new AssistiveDevice(102220315,"��������","���δ���"),
                new AssistiveDevice(102220316,"ɳ̲����","���δ���"),
                new AssistiveDevice(102220317,"Ӿ������","���δ���"),
                new AssistiveDevice(102220318,"ѩ������","���δ���"),
                new AssistiveDevice(102220319,"��������","���δ���"),
                new AssistiveDevice(102220601,"˫�ְڸ���������","���δ���"),
                new AssistiveDevice(102220602,"�ܸ���������","���δ���"),
                new AssistiveDevice(102220901,"��������������","���δ���"),
                new AssistiveDevice(102220902,"���ְڸ���������","���δ���"),
                new AssistiveDevice(102221201,"���������ֶ����γ�","���δ���"),
                new AssistiveDevice(102221501,"����������","���δ���"),
                new AssistiveDevice(102221801,"�߿������Σ������㣩","���δ���"),
                new AssistiveDevice(102221802,"��������","���δ���"),
                new AssistiveDevice(102221803,"����ʽ����","���δ���"),
                new AssistiveDevice(102221804,"����ʽ����","���δ���"),
                new AssistiveDevice(102221805,"��������","���δ���"),
                new AssistiveDevice(102221806,"վ��ʽ����","���δ���"),
                new AssistiveDevice(102221807,"��������̱��ͯ����","���δ���"),
                new AssistiveDevice(102221808,"ƽ������̱��ͯ����","���δ���"),
                new AssistiveDevice(102221809,"��ͨ��ͯ����","���δ���"),
                new AssistiveDevice(102230301,"�����͵綯����","���δ���"),
                new AssistiveDevice(102230302,"�����͵綯����","���δ���"),
                new AssistiveDevice(102230303,"��·�͵綯����","���δ���"),
                new AssistiveDevice(102230304,"��ͨ�綯����","���δ���"),
                new AssistiveDevice(102230305,"վ���綯����","���δ���"),
                new AssistiveDevice(102230306,"б��ʽ�綯����","���δ���"),
                new AssistiveDevice(102230307,"��бʽ�綯����","���δ���"),
                new AssistiveDevice(102230308,"�綯��������","���δ���"),
                new AssistiveDevice(102230309,"�綯��������","���δ���"),
                new AssistiveDevice(102230310,"�綯���ֳ�","���δ���"),
                new AssistiveDevice(102230311,"��ͯ�綯����","���δ���"),
                new AssistiveDevice(102231501,"������ϵ��¥����","���δ���"),
                new AssistiveDevice(102231502,"�Ĵ�ʽ��¥����","���δ���"),
                new AssistiveDevice(102230901,"���ֻ������γ�","���δ���"),
                new AssistiveDevice(102230902,"���ֻ������γ�","���δ���"),


            };
            foreach (var r in AssistiveDevices)
            {
                db.AssistiveDevices.AddOrUpdate(r);
            }
            db.SaveChanges();
            //����
            //����
            List<Question> questions1 = new List<Question> {
                new Question("1", "�����м��ȼ�", true,false,
                    new List<Option>{
                        new Option("A","һ��", "1-1-1",new List<AssistiveDevice>{
                            new AssistiveDevice(1001010),
                        }),
                        new Option("B","����", "1-1-1",null,null),
                        new Option("C","����", "1-2",null,null),
                        new Option("D","�ļ�", "1-2",null,null),
                        new Option("E","δ������ȼ���׼", "������",null,null),
                    }
                ),
                new Question("������", "�ܷ񿴼�",false,false,
                    new List<Option>{
                        new Option("A", "���ܣ��൱��һ��������", "1-1",null,null),
                        new Option("B", "�ܣ��൱�������ļ���", "1-2",null,null),
                    }
                ),
                new Question("1-1", "�ܷ�����",false,false,
                    new List<Option>{
                        new Option("A", "��", "1-1-1",null,null),
                        new Option("B", "����", "1-1-2",null,null),
                    }
                ),
                new Question("1-1-1", "ϣ��ʵ�ֺ��ֹ��ܣ���ѡ��", false,true,
                    new List<Option>{
                        new Option("A", "��������", "2", "02 39 03", "ä��"),
                        new Option("B", "��������", "2", "05 18 03", "������¼�Ͳ����豸(�����)"),
                        new Option("C", "ʱ������", "2", "05 27 12", "ʱ�Ӻͼ�ʱ��(������/���ֱ�)"),
                        new Option("D", "ͨѶ����", "2", "05 24 06,05 33 15", "�ƶ�����绰(ä�����ֻ�),���������͹�ͨ���"),
                        new Option("E", "������", "2", "05 27 06", "���ź�ָʾ��"),
                        new Option("F", "ѧϰ��д", "2", "03,05 12 12,05 12 18", "�ֶ�ʽ�滭����д����,��дä����дװ��,������дֽ����Ĥ��"),
                    }
                ),
                new Question("1-1-2", "ϣ��ʵ�ֺ��ֹ��ܣ���ѡ��", false,true,
                    new List<Option>{
                        new Option("A", "��������", "2", "02 39 03", "ä��"),
                        new Option("B", "ʱ������", "2", "05 27 12", "ʱ�Ӻͼ�ʱ��(������/���ֱ�)"),
                    }
                ),
                new Question("1-2", "ϣ�������ﻹ�ǿ�Զ������ѡ��", false,true,
                    new List<Option>{
                        new Option("A", "����", "1-2-1",null,null),
                        new Option("B", "��Զ", "1-3", "05 03 12", "˫Ͳ��Զ���͵�Ͳ��Զ��"),
                    }
                ),
                new Question("1-2-1", "��Ҫ��ѧ���������ǵ���������",false,false,
                    new List<Option>{
                        new Option("A", "��ѧ", "1-3", "05 03 09", "���зŴ��ܵ��۾�����Ƭ������ϵͳ��ֻѡ���й�ѧ�ࣩ"),
                        new Option("B", "����", "1-3", "05 03 09", "���зŴ��ܵ��۾�����Ƭ������ϵͳ��ֻѡ���е����ࣩ"),
                    }
                ),
                new Question("1-3", "ϣ��ʵ�ֺ��ֹ��ܣ���ѡ��", false,true,
                    new List<Option>{
                        new Option("A", "�Ķ�ѧϰ", "2", "05 30 21,05 30 18,05 12 06,05 12 15", "�ַ��Ķ���,�Ķ���Ͱ����޶���,��д�塢��ͼ��ͻ滭��,���ֻ�"),
                        new Option("B", "����ͨѶ", "2", "05 24 03", "��ͨ����绰"),
                        new Option("C", "��ѧ����", "2", "05 15 03,05 15 06", "�ֶ�������,�����豸"),
                        new Option("D", "��������", "2", "05 21 03", "��ĸ�ͷ��ſ�����"),
                        new Option("E", "�����ʹ��", "2", "05 33 18", "���ڼ����������ĸ���"),
                    }
                ),
                new Question("2", "�Ƿ����ѣ������",false,false,
                    new List<Option>{
                        new Option("A", "��", "3", "05 03 03", "�˹�����������ר���˹⾵"),
                        new Option("B", "��", "3",null,null),
                    }
                ),
                new Question("3", "�Ƿ�������˵��", false,false,
                    new List<Option>{
                        new Option("A", "��",null,null,null),
                        new Option("B", "����", "3-1",null,null),
                    }
                ),
                new Question("3-1", "�Ƿ��д��",false,false,
                    new List<Option>{
                        new Option("A", "��", null,"05 12 12,05 09 03", "��дä����дװ��,����������"),
                        new Option("B", "����",null,null,null),
                    }
                ),
            };
            Exam exam1 = new Exam(1, "������������", "����", questions1);
            db.Exams.AddOrUpdate(exam1);
            //����
            List<Question> questions2 = new List<Question> {
                new Question("1", "�����м��ȼ�", true,false,
                    new List<Option>{
                        ////ѡAʱ��������䣬ϵͳ����
                        //6�����£�05 06 ������-�˹�����
                        //6��-60�꣺05 06 ������(����/����/����/�����ʽ������)
                        //60�����ϣ�05 06 06���ʽ����ʽ��������
                        new Option("A", "һ��","2", "05 06", "������-�˹�����,������(����/����/����/�����ʽ������),���ʽ����ʽ��������"),
                        new Option("B", "����","2", "05 06", "������(����/����/����/�����ʽ������)"),
                        new Option("C", "����","2", "05 06", "������(����/����/����/�����ʽ������)"),
                        new Option("D", "�ļ�","2", "05 06", "������(����/����/����/�����ʽ������)"),
                        new Option("E", "δ������ȼ���׼","1-1",null,null),
                    }
                ),
                new Question("1-1", "�ڰ��������£����������豸ʱ��������",false,false,
                    new List<Option>{
                        //ѡAʱ��������䣬ϵͳ����
                        new Option("A", "�����������κ���������ͬ��һ����","2", "05 06", "������-�˹�����,������(����/����/����/�����ʽ������),���ʽ����ʽ��������"),
                        new Option("B", "ֻ���������ڡ��ùġ���������������������ͬ�ڶ�����","2", "05 06", "������(����/����/����/�����ʽ������)"),
                        new Option("C", "ֻ����������˵������ͬ��������","2", "05 06", "������(����/����/����/�����ʽ������)"),
                        new Option("D", "��������̸ͨ��������ͬ���ļ���","2", "05 06", "������(����/����/����/�����ʽ������)"),
                        new Option("E", "����һ������ֱܷ���������丨�����ߣ�","2",null,null),
                    }
                ),
                new Question("2", "�������⣬ϣ��ʵ�ֺ��ֹ���", false,true,
                    new List<Option>{
                        new Option("A", "���Խ������������ߣ�",null, "05 21 09", "�Ի�װ��(������д������/��ͨ��)"),
                        new Option("B", "����Ӧ��", null,"05 27 03", "�Ӿ��ź�ָʾ��(��������)"),
                        new Option("C", "������", null,"05 27 12", "ʱ�Ӻͼ�ʱ��(������)")
                    }
                )
            };
            Exam exam2 = new Exam(2, "������������", "����", questions2);
            db.Exams.AddOrUpdate(exam2);
            //ƫ̱
            List<Question> questions3 = new List<Question>
            {
                new Question("1", "�Ƿ��Դ�", true,false,
                    new List<Option>{
                         new Option("A", "��","1-1-1", "05 27 18", "���˽�������ϵͳ����������"),
                         new Option("B", "��","1-2-1", null, null),
                    }
                ),
                new Question("1-1-1", "�ܷ���", false,false,
                    new List<Option>{
                        new Option("A", "����","1-1-2", "04,06 33 06,07 33 09,06 33 04", "��ͥ�ͼҾ�-��ʽ�Ҿߣ�������,������֯�����Ե����Ը������ߣ���ѹ�����棩,�����ƶ�ѵ���������ߣ���������,������֯�����ԵĿ������С�����棨��λ�棩"),
                        new Option("B", "��","1-1-2", "04,06 33 06,06 33 04,04 10 09", "��ͥ�ͼҾ�-��ʽ�Ҿߣ�������,������֯�����Ե����Ը������ߣ���ѹ�����棩,������֯�����ԵĿ������С�����棨��λ�棩,���֣����Ի�����"),
                    }
                ),
                new Question("1-1-2", "�ܷ�����", false,false,
                    new List<Option>{
                         new Option("A", "����","1-1-3", null, null),
                         new Option("B", "��","1-1-3", "04 10 03,02 22 18", "����,�����߲��ݵ����Σ��߿������Σ�"),
                    }
                ),
                new Question("1-1-3", "�ܷ���ƴ�С��", false,false,
                    new List<Option>{
                         new Option("A", "����","2", "07 09 03,03 30 21,03 30 18,03 27 18,03 31 06", "ʧ��������,����һ������,����һ���Գĵ�,���ռ�ϵͳ,����������Ų�����"),
                         new Option("B", "��","2", "03 24 15,03 24 21,03 12 33", "Ů�ô���ʽ�����,���ô���ʽ�����,���裨��Яʽ��������/���ϴ���裩"),
                    }
                ),
                new Question("1-2-1", "�ܷ�����", false,false,
                    new List<Option>{
                        new Option("A", "����","1-2-1-1", null, null),
                        new Option("B", "��","1-2-2", null, null),
                    }
                ),
                new Question("1-2-1-1", "�ܷ������ƶ����", false,false,
                    new List<Option>{
                        new Option("A", "����","1-2-1-2", "02 22 18", "�����߲��ݵ����Σ��������Σ�"),
                        new Option("B", "��","1-2-1-2", "02 22 03,02 22 09,02 23 03", "˫���������γ����������Σ�,�����������γ�(��������������/ƫ̱����),�綯���γ��������͵綯���Σ�"),
                    }
                ),
                new Question("1-2-1-2", "�Ƿ���ѹ��", false,false,
                    new List<Option>{
                         new Option("A", "��","1-2-1-3", null, null),
                         new Option("B", "�����У�������","1-2-1-3", "06 33 03", "������֯�����Ե�����ͳĵ棨��ѹ�����棩"),
                         new Option("C", "��","1-2-1-3", "06 33 03", "������֯�����Ե�����ͳĵ棨��ѹ�����棩"),
                    }
                ),
                new Question("1-2-1-3", "�ܷ�վ�����д�-��ת��", false,false,
                    new List<Option>{
                         new Option("A", "����","2", "07 33 09", "�����ƶ�ѵ���������ߣ��Ƴ˴����Ƴ˰壩"),
                         new Option("B", "��Ҫ����","2", "04 10 09,02 03 03", "����,���ȣ�ֱ���Ľ����ȣ��̶�/�ɵ�����"),
                         new Option("C", "����վ��ת��","2", null, null),
                    }
                ),
                new Question("1-2-2", "����ʱ�Ƿ���Ҫ���", false,false,
                    new List<Option>{
                         new Option("A", "ȫ�̲��","1-2-2-1", null, null),
                         new Option("B", "���ֲ��","2", "02 03 03", "���ȣ��������ȣ�"),
                         new Option("C", "������","2", null, null),
                    }
                ),
                new Question("1-2-2-1", "����ʱ�Ƿ���Ҫ���", false,false,
                    new List<Option>{
                         new Option("A", "��Ҫ","2", "02 03 03,0", "���ȣ�S���Ľ����ȣ��̶�/�ɵ�����,����������м�"),
                         new Option("B", "����Ҫ","2", "02 03 03", "���ȣ�ֱ���Ľ����ȣ��̶�/�ɵ�����"),
                    }
                ),
                new Question("2", "����֫�����״��", false,true,
                    new List<Option>{
                         new Option("A", "����³�","3", "01 06 21", "�������-�粿����"),
                         new Option("B", "��ָ������չ","3", "01 06,01 06 07", "��֫������,��-ָ������-��ָ��"),
                         new Option("C", "����ʱ���ϵ�","3", "01 12", "��֫������"),
                    }
                ),
                new Question("3", "�ܷ����н�ʳ", false,false,
                    new List<Option>{
                         new Option("A", "����","4", "04 30", "��ֱ���͸�������-���ࣨ���ò�������������"),
                         new Option("B", "��Ҫ����","4", "08 18 03,10 09 18,10 09 21,10 09", "ץ��װ�ã����������,���Ӻ��루��ͨ������/�ײ������̲;ߣ�,ʳ�ﵲ��(���Ϸ�����),ʳ����������"),
                         new Option("C", "������ʳ","4",null, null),
                    }
                ),
                new Question("4", "�ܷ�����ϴԡ", false,false,
                    new List<Option>{
                         new Option("A", "����","5", "03 33 12,03 33,03 33 15,1", "ϴԡ������ԡ���͸���������ϴԡ����,��ϴ����ԡ����ԡ�������ߣ�ϴԡ������,ϴ�裨����ʽϴͷ�أ�,ϴԡ����"),
                         new Option("B", "��","4-1", null,null),
                    }
                ),
                new Question("4-1", "�Ƿ�վ��ϴԡ", false,false,
                    new List<Option>{
                         new Option("A", "��","4-2", "03 33 06", "������ԡ��桢��ԡ��ʹ��ӣ���������棩"),
                         new Option("B", "��","4-2", "03 33 03", "��ԡ����ԡ�Ρ�ԡ�����塢���ӡ���������"),
                    }
                ),
                new Question("4-2", "�Ƿ���Ҫϴԡ��������", false,false,
                    new List<Option>{
                         new Option("A", "��Ҫ","5", "03 33 30,03 36 06,03 36 09", "���а��֡��ֱ����հѵ�ϴ�貼�������ˢ��,ָ��ﱺ�ɰֽ��,ָ�׼���ָ�׵�"),
                         new Option("B", "����Ҫ","5", null, null),
                    }
                ),
                new Question("5", "�������ʱ���Ƿ��¶�", false,false,
                    new List<Option>{
                         new Option("A", "��","6", null, null),
                         new Option("B", "����","5-1", null, null),
                    }
                ),
                new Question("5-1", "�����Ƿ���������", false,false,
                    new List<Option>{
                         new Option("A", "�У��Ҹ߶Ⱥ���","6", null, null),
                         new Option("B", "�У��߶Ƚϵ�","6", "03 12 18,03 12 21,04 10 09,03 12 12", "��װ���������ϼӸߵ���������,���ð����������µ�������������������,����,����ͼӸߵ���������"),
                         new Option("C", "��","6", "03 12 03", "������"),
                    }
                ),
                new Question("6", "�ܷ����д�������", false,false,
                    new List<Option>{
                         new Option("A", "���ܣ��Ҹ߶Ⱥ���","7", "03 03 18,03 03 42", "�п����ͳ���,Ь��ѥ�����㴩��Ь��"),
                         new Option("B", "���������","7", "03 09 12,03 09 03,03 09 06", "�����¹������¹�,������ʹ�������ĸ�������,Ь�κ���ѥ��������Ь�Σ�"),
                         new Option("C", "�������","7", null, null),
                    }
                ),
                new Question("7", "�Ƿ񾭳���Ҫ��ʰԶ����Ʒ", false,false,
                    new List<Option>{
                         new Option("A", "��","8", null, null),
                         new Option("B", "��","8", "08 21 03", "�ֶ�ץȡǯ���۵�ʽ����ȡ����/���۵�ʽ����ȡ������"),
                    }
                ),
                new Question("8", "�Ƿ������������м�", false,false,
                    new List<Option>{
                         new Option("A", "��","9", null, null),
                         new Option("B", "����",1,"9", null, null),
                         new Option("C", "����",2,"9", null, null),
                         new Option("D", "����","9", null, null),
                    }
                ),
                new Question("9", "��ϣ�����ʲô���⣨���ѡ��������", false,true,
                    new List<Option>{
                         new Option("A", "���δ���",null, null, null),
                         new Option("B", "��������",null, null, null),
                         new Option("C", "��ʳ",null, null, null),
                         new Option("D", "���˻���",null, null, null),
                         new Option("E", "���",null, null, null),
                         new Option("F", "��Ϣ����",null, null, null),
                         new Option("G", "����ѵ��",null, null, null),
                         new Option("H", "��������",null, null, null),
                         new Option("I", "���ϰ�����",8,null, null, null),
                         new Option("J", "������ʹ��",null, null, null),
                         new Option("K", "λ��ת��",null, null, null),
                         new Option("L", "��������",null, null, null),
                         new Option("M", "��֫",7,null, null, null),
                         new Option("N", "������",null, null, null),
                         new Option("O", "������",null, null, null),
                         new Option("P", "������",null, null, null),
                         new Option("Q", "ϴ����",null, null, null),
                         new Option("R", "������",null, null, null),
                    }
                ),
            };
            Exam exam3 = new Exam(3, "������������", "ƫ̱", questions3);
            db.Exams.AddOrUpdate(exam3);
            //��̱
            List<Question> questions4 = new List<Question>
            {
                new Question("1", "����", true,false,
                    new List<Option>{
                         new Option("A", "��7��","2-1", null, null),
                         new Option("B", ">7��","3-1", null, null),
                    }
                ),
                new Question("2-1", "�ܷ���ɡ����𡱶���", false,false,
                    new List<Option>{
                         new Option("A", "��ȫ����","2-1-1", null, null),
                         new Option("B", "��Ҫ�������","2-1-2", null, null),
                         new Option("C", "���踨���ܶ������","2-1-2", null, null),
                    }
                ),
                new Question("2-1-1", "�ܷ���", false,false,
                    new List<Option>{
                         new Option("A", "��ȫ����","2-1-1-1", null, null),
                         new Option("B", "��Ҫ����","2-2", "06 33 04,02 22 18", "������֯�����ԵĿ������С������(Ш�ε�),�����߲��ݵ����γ�(0-3��Ϊ��ͯ���Σ�4-7��Ϊ��ͯ��̱����)"),
                         new Option("C", "���踨���������","2-2", "04 09 21,02 22 18", "�������ߣ�0-3��Ϊ��ͯ�����Σ�4-7��Ϊ��ͯ�����Σ�,�����߲��ݵ����γ�(0-3��Ϊ��ͯ���Σ�4-7��Ϊ��ͯ��̱����)"),
                    }
                ),
                new Question("2-1-1-1", "�ܷ�̧ͷ", false,false,
                    new List<Option>{
                         new Option("A", "��ȫ����","2-2", "06 33 04", "������֯�����ԵĿ������С�����棨��λ�任��ϵ棩"),
                         new Option("B", "����̧ͷ������ά��","2-2", "06 33 04", "������֯�����ԵĿ������С������(Ш�ε�)��02 22 18�����߲��ݵ����γ�(0-3��Ϊ��ͯ���Σ�4-7��Ϊ��ͯ��̱����)"),
                         new Option("C", "��̧ͷ����ά��","2-2", "06 33 04", "������֯�����ԵĿ������С������(Ш�ε�)��02 22 18�����߲��ݵ����γ�(0-3��Ϊ��ͯ���Σ�4-7��Ϊ��ͯ��̱����)"),
                    }
                ),

            };
            Exam exam4 = new Exam(4, "������������", "��̱", questions4);
            db.Exams.AddOrUpdate(exam4);
        }
    }
}
