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

            #region ��ɫ
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
                new Role( 11, "���߷������","��������չ���߷���Ļ�����", "�ڡ��ۺϿ�������ģ��ġ����߷�����ģ�飬�Թ����ϰ��߿�չ�����䷢����֫�����������ϰ��ȵķ���",""),
                new Role( 12, "����Ա","����Ա","����Ȩ��","")
            };
            db.Roles.AddRange(Roles);
            #endregion

            #region ��ϵ
            List<Relationship> Relationships = new List<Relationship>
            {
                new Relationship(1, "��ĸ"),
                new Relationship(2, "��ż"),
                new Relationship(3, "�ֵܽ���"),
                new Relationship(4, "�游ĸ"),
                new Relationship(5, "����")
            };
            db.Relationships.AddRange(Relationships);
            #endregion

            #region �м����
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
            db.Categories.AddRange(Categories);
            #endregion

            #region �м��ȼ�
            List<Degree> Degrees = new List<Degree>
            {
                new Degree(1, "һ��"),
                new Degree(2, "����"),
                new Degree(3, "����"),
                new Degree(4, "�ļ�"),
                new Degree(5, "δ����")
            };
            db.Degrees.AddRange(Degrees);
            #endregion

            #region ��������
            List<Next> Nexts = new List<Next>
            {
                new Next(1, "ת����������"),
                new Next(2, "ת��������"),
                new Next(3, "��������")
            };
            db.Nexts.AddRange(Nexts);
            #endregion

            #region �²�ԭ��
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
            db.DisabilityReasons.AddRange(DisabilityReasons);
            #endregion

            #region ��������
            List<Rehabilitation> Rehabilitations = new List<Rehabilitation>
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
            db.Rehabilitations.AddRange(Rehabilitations);
            #endregion
            db.SaveChanges();

            #region �û�
            List<User> users = new List<User>{
                new User("admin","ZFh9qABh8","����",1,"13200000000","","", 12, DateTime.Now,""),
            };
            db.Users.AddRange(users);
            #endregion

            #region �м�����Ϣ
            List<Disabled> Disableds = new List<Disabled>
            {

            };
            db.Disableds.AddRange(Disableds);
            #endregion
            db.SaveChanges();

            #region ��������
            List<Disabled_Detail> Disabled_Details = new List<Disabled_Detail>
            {

            };
            db.Disabled_Details.AddRange(Disabled_Details);
            #endregion
            db.SaveChanges();

            #region �����б�
            List<AssistiveDevice> AssistiveDevices = new List<AssistiveDevice>
            {
                #region ���δ���
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

                new AssistiveDevice(102170301,"��¥������","���δ���","440��¥����������ͼƬ.jpg",0,""),
                new AssistiveDevice(102170302,"��¥���������ع���","���δ���","441��¥���������ع�������ͼƬ.jpg",0,""),
                new AssistiveDevice(102170601,"վ��ʽ������","���δ���","442վ��ʽ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(102180601,"��ҡ��̤����ʽ���ֳ�","���δ���","443��ҡ��̤����ʽ���ֳ�.jpg",0,""),
                new AssistiveDevice(102180602,"��ҡ��̤����ʽ���ֳ�","���δ���","444��ҡ��̤����ʽ���ֳ�.jpeg",0,""),
                new AssistiveDevice(102180901,"��ҡ��������ʽ���ֳ�","���δ���","445��ҡ��������ʽ���ֳ�.jpg",0,""),
                new AssistiveDevice(102180902,"��ҡ����ǰ��ʽ���ֳ�","���δ���","446��ҡ����ǰ��ʽ���ֳ�.jpg",0,""),
                new AssistiveDevice(102180903,"ƽҡʽ��ҡ���ֳ�","���δ���","447ƽҡʽ��ҡ���ֳ�.jpg",0,""),
                new AssistiveDevice(102180904,"����ʽ��ҡ���ֳ�","���δ���","448����ʽ��ҡ���ֳ�.jpg",0,""),
                new AssistiveDevice(102220301,"��ͨ���Σ������������Σ�","���δ���","449��ͨ���Σ������������Σ�.jpg",0,""),
                new AssistiveDevice(102220302,"��������","���δ���","450��������.png",0,""),
                new AssistiveDevice(102220303,"ϴԡ����","���δ���","451ϴԡ����.jpg",0,""),
                new AssistiveDevice(102220304,"ǰ����������","���δ���","452�ֶ�ǰ����������.jpg",0,""),
                new AssistiveDevice(102220305,"վ��ʽ�ֶ�����","���δ���","453վ��ʽ�ֶ�����.jpg",0,""),
                new AssistiveDevice(102220306,"б��ʽ�ֶ�����","���δ���","454б��ʽ�ֶ�����.jpg",0,""),
                new AssistiveDevice(102220307,"��бʽ�ֶ�����","���δ���","455��бʽ�ֶ����γ�.jpg",0,""),
                new AssistiveDevice(102220308,"��������","���δ���","456��������.jpg",0,""),
                new AssistiveDevice(102220309,"�˶�����","���δ���","457�˶�����.jpg",0,""),
                new AssistiveDevice(102220310,"��������","���δ���","458��������.jpg",0,""),
                new AssistiveDevice(102220311,"ƹ��������","���δ���","459ƹ��������.jpg",0,""),
                new AssistiveDevice(102220312,"���������","���δ���","460���������.jpg",0,""),
                new AssistiveDevice(102220313,"��������","���δ���","461��������.jpg",0,""),
                new AssistiveDevice(102220314,"�赸����","���δ���","462�赸����.jpg",0,""),
                new AssistiveDevice(102220315,"��������","���δ���","463��������.jpg",0,""),
                new AssistiveDevice(102220316,"ɳ̲����","���δ���","464ɳ̲����.jpg",0,""),
                new AssistiveDevice(102220317,"Ӿ������","���δ���","465Ӿ������.jpg",0,""),
                new AssistiveDevice(102220318,"ѩ������","���δ���","466ѩ������.jpg",0,""),
                new AssistiveDevice(102220319,"��������","���δ���","467��������.jpg",0,""),
                new AssistiveDevice(102220601,"˫�ְڸ���������","���δ���","468˫�ְڸ���������.jpg",0,""),
                new AssistiveDevice(102220602,"�ܸ���������","���δ���","469�ܸ���������.jpg",0,""),
                new AssistiveDevice(102220901,"��������������","���δ���","470�������������γ�.jpg",0,""),
                new AssistiveDevice(102220902,"���ְڸ���������","���δ���","471���ְڸ��������γ�.jpg",0,""),
                new AssistiveDevice(102221201,"���������ֶ����γ�","���δ���","472���������ֶ����γ�.jpg",0,""),
                new AssistiveDevice(102221501,"����������","���δ���","473����������.jpg",0,""),
                new AssistiveDevice(102221801,"�߿������Σ������㣩","���δ���","474�߿�������.jpg",0,""),
                new AssistiveDevice(102221802,"��������","���δ���","475��������.jpg",0,""),
                new AssistiveDevice(102221803,"����ʽ����","���δ���","476����ʽ����.jpg",0,""),
                new AssistiveDevice(102221804,"����ʽ����","���δ���","477����ʽ����.jpg",0,""),
                new AssistiveDevice(102221805,"��������","���δ���","478��������.jpg",0,""),
                new AssistiveDevice(102221806,"վ��ʽ����","���δ���","479վ��ʽ����.jpg",0,""),
                new AssistiveDevice(102221807,"��������̱��ͯ����","���δ���","480��������̱��ͯ����.jpg",0,""),
                new AssistiveDevice(102221808,"ƽ������̱��ͯ����","���δ���","481ƽ������̱��ͯ����.jpg",0,""),
                new AssistiveDevice(102221809,"��ͨ��ͯ����","���δ���","482��ͨ��ͯ����.jpg",0,""),
                new AssistiveDevice(102230301,"�����͵綯����","���δ���","483�����͵綯����.jpg",0,""),
                new AssistiveDevice(102230302,"�����͵綯����","���δ���","484�����͵綯����.jpg",0,""),
                new AssistiveDevice(102230303,"��·�͵綯����","���δ���","485��·�͵綯����.jpg",0,""),
                new AssistiveDevice(102230304,"��ͨ�綯����","���δ���","486��ͨ�綯���γ�.jpg",0,""),
                new AssistiveDevice(102230305,"վ���綯����","���δ���","487վ��ʽ�綯���γ�.png",0,""),
                new AssistiveDevice(102230306,"б��ʽ�綯����","���δ���","488б��ʽ�綯���γ�.jpg",0,""),
                new AssistiveDevice(102230307,"��бʽ�綯����","���δ���","489��бʽ�綯���γ�.png",0,""),
                new AssistiveDevice(102230308,"�綯��������","���δ���","490�綯��������.jpg",0,""),
                new AssistiveDevice(102230309,"�綯��������","���δ���","491�綯��������.JPG",0,""),
                new AssistiveDevice(102230310,"�綯���ֳ�","���δ���","492�綯���ֳ�.jpg",0,""),
                new AssistiveDevice(102230311,"��ͯ�綯����","���δ���","493��ͯ�綯����.jpg",0,""),
                new AssistiveDevice(102230901,"���ֻ������γ�","���δ���","496���ֻ������γ�.jpg",0,""),
                new AssistiveDevice(102230902,"���ֻ������γ�","���δ���","497���ֻ������γ�.jpg",0,""),
                new AssistiveDevice(102231501,"������ϵ��¥����","���δ���","494������ϵ��¥����.jpg",0,""),
                new AssistiveDevice(102231502,"�Ĵ�ʽ��¥����","���δ���","495�Ĵ�ʽ��¥����.jpg",0,""),
                #endregion
                
                #region ��������
                new AssistiveDevice(10203,"���۲���������","��������"),
                new AssistiveDevice(10206,"˫�۲���������","��������"),
                new AssistiveDevice(10207,"����������","��������"),
                new AssistiveDevice(10239,"��λ��������","��������"),

                new AssistiveDevice(1020303,"����","��������"),
                new AssistiveDevice(1020306,"���","��������"),
                new AssistiveDevice(1020309,"ǰ��֧�Ź�","��������"),
                new AssistiveDevice(1020312,"Ҹ��","��������"),
                new AssistiveDevice(1020318,"��������","��������"),
                new AssistiveDevice(1023819,"����������м�","��������"),
                new AssistiveDevice(1020603,"��ʽ���м�","��������"),
                new AssistiveDevice(1020606,"��ʽ������","��������"),
                new AssistiveDevice(1020609,"��ʽ������","��������"),
                new AssistiveDevice(1020612,"̨ʽ������","��������"),
                new AssistiveDevice(1020705,"������֧��","��������"),
                new AssistiveDevice(1020712,"�ճ�������������","��������"),
                new AssistiveDevice(1020715,"֧�������ض���λ�����������","��������"),
                new AssistiveDevice(1020718,"��ֹ���˻�Ƥ�����˵ĵ��ӡ��ĵ���������������","��������"),
                new AssistiveDevice(1020721,"����������","��������"),
                new AssistiveDevice(1020724,"�̶���Я����Ʒ�����������","��������"),
                new AssistiveDevice(1020727,"��������ʹ��ʱ�Ĺ̶�����","��������"),
                new AssistiveDevice(1020730,"�������������������","��������"),
                new AssistiveDevice(1020733,"��ʽ�������Ϳ�ʽ���������ڸ߶ȵ����","��������"),
                new AssistiveDevice(1020736,"�������ĵƺͰ�ȫ�ź�װ��","��������"),
                new AssistiveDevice(1020739,"����������̥������","��������"),
                new AssistiveDevice(1023903,"ä��","��������"),
                new AssistiveDevice(1023906,"���Ӷ�λ��������","��������"),

                new AssistiveDevice(102030301,"����ֱ�����ȣ��̶�/�ɵ���","��������","352����ֱ�����ȣ��̶��ɵ���.jpg",0,""),
                new AssistiveDevice(102030302,"�����������ȣ��̶�/�ɵ���","��������","353�����������ȣ��̶��ɵ���.jpg",0,""),
                new AssistiveDevice(102030303,"����S�����ȣ��̶�/�ɵ���","��������","354����S�����ȣ��̶��ɵ���.jpg",0,""),
                new AssistiveDevice(102030304,"ֱ���������ȣ��̶�/�ɵ���","��������","355ֱ���������ȣ��̶��ɵ���.jpg",0,""),
                new AssistiveDevice(102030305,"�����������ȣ��̶�/�ɵ���","��������","356�����������ȣ��̶��ɵ���.jpg",0,""),
                new AssistiveDevice(102030306,"S���������ȣ��̶�/�ɵ���","��������","357S���������ȣ��̶��ɵ���.jpg",0,""),
                new AssistiveDevice(102030307,"ֱ���Ľ����ȣ��̶�/�ɵ���","��������","358ֱ���Ľ����ȣ��̶��ɵ���.jpg",0,""),
                new AssistiveDevice(102030308,"�����Ľ����ȣ��̶�/�ɵ���","��������","359�����Ľ����ȣ��̶��ɵ���.jpg",0,""),
                new AssistiveDevice(102030309,"S���Ľ����ȣ��̶�/�ɵ���","��������","360S���Ľ����ȣ��̶��ɵ���.jpg",0,""),
                new AssistiveDevice(102030310,"�۵�����","��������","361�۵�ʽ����.jpg",0,""),
                new AssistiveDevice(102030311,"��������","��������","362��������.jpg",0,""),
                new AssistiveDevice(102030312,"��ɽ��","��������","363��ɽ��.jpg",0,""),
                new AssistiveDevice(102030601,"�̶�ʽ���","��������","364�̶�ʽ��� .jpg",0,""),
                new AssistiveDevice(102030602,"����ʽ���","��������","365����ʽ���.jpg",0,""),
                new AssistiveDevice(102030603,"������","��������","366������ .jpg",0,""),
                new AssistiveDevice(102030901,"����ǰ��֧�Ź�","��������","367����ǰ��֧�Ź�.jpg",0,""),
                new AssistiveDevice(102030902,"����ǰ��֧�Ź�","��������","368����ǰ��֧�Ź�.jpg",0,""),
                new AssistiveDevice(102030903,"�Ľ�ǰ��֧�Ź�","��������","369�Ľ�ǰ��֧�Ź�.jpg",0,""),
                new AssistiveDevice(102030904,"����ǰ���а��","��������","370����ǰ���а��.jpg",0,""),
                new AssistiveDevice(102030905,"ǰ���ж�Ű��","��������","371ǰ���ж�Ű��.jpg",0,""),
                new AssistiveDevice(102031201,"��ͨҸ�գ����ţ�","��������","372��ͨҸ�գ����ţ�.jpg",0,""),
                new AssistiveDevice(102031202,"����Ҹ��","��������","373����Ҹ��.jpg",0,""),
                new AssistiveDevice(102031203,"����Ҹ��","��������","374����Ҹ��.jpg",0,""),
                new AssistiveDevice(102031204,"���Ҹ��","��������","375���Ҹ��.jpg",0,""),
                new AssistiveDevice(102031205,"��֧��Ҹ��","��������","376��֧��Ҹ��.jpg",0,""),
                new AssistiveDevice(102031206,"ǰ���а�Ҹ��","��������","377ǰ���а�Ҹ��.jpg",0,""),
                new AssistiveDevice(102031207,"��ͯҸ��","��������","378��ͯҸ��.jpg",0,""),
                new AssistiveDevice(102031801,"������������","��������","379���Ŵ�������.jpg",0,""),
                new AssistiveDevice(102060301,"���ſ�ʽ������","��������","381���ſ�ʽ������.jpg",0,""),
                new AssistiveDevice(102060302,"�Ľſ�ʽ������","��������","382�Ľſ�ʽ������.jpg",0,""),
                new AssistiveDevice(102060303,"���ݿ�ʽ������","��������","383����ʽ������.jpg",0,""),
                new AssistiveDevice(102060304,"�����ʽ������������ʽ/�ʽ��","��������","384�����ʽ������������ʽ�ʽ��.jpg",0,""),
                new AssistiveDevice(102060305,"�ɵ�ʽ������","��������","385�ɵ�ʽ������.jpg",0,""),
                new AssistiveDevice(102060306,"ƽ̨ʽ������","��������","386ƽ̨ʽ������.jpg",0,""),
                new AssistiveDevice(102060307,"�ֳ�����ʽ������","��������","387�ֳ�����ʽ������.jpg",0,""),
                new AssistiveDevice(102060601,"�ַ�����������","��������","388�ַ�����������.jpg",0,""),
                new AssistiveDevice(102060602,"�ַ�����������","��������","389�ַ�����������.jpg",0,""),
                new AssistiveDevice(102060603,"�ַ�����������","��������","390�ַ�����������.jpg",0,""),
                new AssistiveDevice(102060604,"�ַ��๦��������","��������","391�ַ��๦��������.jpg",0,""),
                new AssistiveDevice(102060605,"��ʽ����������","��������","392��ʽ����������.jpg",0,""),
                new AssistiveDevice(102060606,"��ʽ����������","��������","393��ʽ����������.png",0,""),
                new AssistiveDevice(102060607,"��������������","��������","394��������������.jpg",0,""),
                new AssistiveDevice(102060608,"Ҹ������������","��������","395Ҹ������������.jpg",0,""),
                new AssistiveDevice(102060609,"��ѹ�ƶ�����������","��������","396��ѹ�ƶ�����������.jpg",0,""),
                new AssistiveDevice(102060610,"������ʽ����������","��������","397������ʽ����������.png",0,""),
                new AssistiveDevice(102060901,"�̶�֧����ʽ������","��������","398�̶�֧����ʽ������.jpg",0,""),
                new AssistiveDevice(102060902,"����֧����ʽ������","��������","399����֧����ʽ������.jpg",0,""),
                new AssistiveDevice(102061201,"ƽ̨֧��̨ʽ������","��������","400ƽ̨֧��̨ʽ������.jpg",0,""),
                new AssistiveDevice(102061202,"ǰ��֧��̨ʽ������","��������","401ǰ��֧��̨ʽ������.jpg",0,""),
                new AssistiveDevice(102061203,"�̶�ʽ������","��������","402�̶�ʽ������.jpg",0,""),
                new AssistiveDevice(102061204,"�ɵ�ʽ������","��������","403�ɵ�ʽ������.jpg",0,""),
                new AssistiveDevice(102061205,"���ִ���������","��������","404���ִ���������.jpg",0,""),
                new AssistiveDevice(102061206,"���ִ����۵�������","��������","405���ִ����۵�������.jpg",0,""),
                new AssistiveDevice(102061207,"���ִ�ɲ������������","��������","406���ִ�ɲ������������.jpg",0,""),
                new AssistiveDevice(102070501,"�ӷ������ϵ�֧��","��������","407�ӷ������ϵ�֧��.jpg",0,""),
                new AssistiveDevice(102070502,"����֧��","��������","408����֧��.jpg",0,""),
                new AssistiveDevice(102070503,"֧�ŵ�","��������","409֧�ŵ�.jpg",0,""),
                new AssistiveDevice(102071201,"�ɵ�����","��������","410�ɵ���������ͼƬ.jpg",0,""),
                new AssistiveDevice(102071202,"��������","��������","411������������ͼƬ.jpg",0,""),
                new AssistiveDevice(102071203,"�ֱ���","��������","412�ֱ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(102071204,"����װ��","��������","413����װ������ͼƬ.jpg",0,""),
                new AssistiveDevice(102071501,"Ҹ��","��������","414Ҹ������ͼƬ.jpg",0,""),
                new AssistiveDevice(102071502,"����","��������","415��������ͼƬ.jpg",0,""),
                new AssistiveDevice(102071503,"ͷ��","��������","416ͷ������ͼƬ.jpg",0,""),
                new AssistiveDevice(102071504,"��ȫ��","��������","417��ȫ������ͼƬ.jpg",0,""),
                new AssistiveDevice(102071801,"���ȵ�","��������","418���ȵ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(102071802,"���мܵ�","��������","419���мܵ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(102072101,"Ӳ������","��������","420Ӳ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(102072102,"����������","��������","421��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(102072103,"���۵�����","��������","422���۵���������ͼƬ.jpg",0,""),
                new AssistiveDevice(102072401,"�����","��������","423���������ͼƬ.jpg",0,""),
                new AssistiveDevice(102072402,"�ҹ�","��������","424�ҹ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(102072403,"���","��������","425�������ͼƬ.jpg",0,""),
                new AssistiveDevice(102072404,"ɡ�̶���","��������","426ɡ�̶�������ͼƬ.jpg",0,""),
                new AssistiveDevice(102072405,"���ȹ̶���","��������","427���ȹ̶�������ͼƬ.jpg",0,""),
                new AssistiveDevice(102072406,"ǰ���а�","��������","428ǰ���а�����ͼƬ.jpg",0,""),
                new AssistiveDevice(102072407,"֧�ŵ���","��������","429֧�ŵ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(102072701,"������ͣ���ƶ�װ��","��������","430������ͣ���ƶ�װ������ͼƬ.jpg",0,""),
                new AssistiveDevice(102073001,"���Ƹ�","��������","431���Ƹ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(102073002,"����ת��","��������","432����ת������ͼƬ.jpg",0,""),
                new AssistiveDevice(102073003,"���ż���·�ص�װ��","��������","433���ż���·�ص�װ������ͼƬ.jpg",0,""),
                new AssistiveDevice(102073004,"�����ƶ���","��������","434�����ƶ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(102073301,"�߶�������","��������","435�߶�����������ͼƬ.jpg",0,""),
                new AssistiveDevice(102073601,"������","��������","436����������ͼƬ.jpg",0,""),
                new AssistiveDevice(102073602,"��ȫ�ź�װ��","��������","437��ȫ�ź�װ������ͼƬ.jpg",0,""),
                new AssistiveDevice(102073603,"���⾵","��������","438���⾵����ͼƬ.jpg",0,""),
                new AssistiveDevice(102073901,"С����","��������","439С��������ͼƬ.jpg",0,""),
                new AssistiveDevice(102381901,"����������м�","��������","380����������м�.jpg",0,""),
                new AssistiveDevice(102390301,"���Ͻ���ͨä�ȣ�ֱ�ˣ�","��������","508���Ͻ���ͨä�ȣ�ֱ�ˣ�.jpg",0,""),
                new AssistiveDevice(102390302,"����ä������","��������","509����ä������.jpg",0,""),
                new AssistiveDevice(102390303,"�����۵�����ä��","��������","510�����۵�����ä��.jpg",0,""),
                new AssistiveDevice(102390304,"���Ͻ�����ä��","��������","511���Ͻ�����ä��.jpg",0,""),
                new AssistiveDevice(102390305,"���Ͻ�����ä��","��������","512���Ͻ�����ä��.jpg",0,""),
                new AssistiveDevice(102390306,"����������ä��","��������","513����������ä��.jpg",0,""),
                new AssistiveDevice(102390307,"������ää��","��������","514������ää��.jpg",0,""),
                new AssistiveDevice(102390308,"����ʽä��","��������","515����ʽä��.jpg",0,""),
                new AssistiveDevice(102390309,"ä����","��������","516ä����.jpg",0,""),
                new AssistiveDevice(102390601,"���ӵ�ä��","��������","517���ӵ�ä��.jpg",0,""),
                #endregion
                
                #region ��ʳ
                new AssistiveDevice(11003,"׼��ʳ������ϵĸ�������","��ʳ"),
                new AssistiveDevice(11006,"��ϴ�;߸�������","��ʳ"),
                new AssistiveDevice(11009,"ʳ����������","��ʳ"),

                new AssistiveDevice(1100306,"׼��ʳ��������õ��С����ͷָ������","��ʳ"),
                new AssistiveDevice(1100307,"���ʳ����¯����ߵȸ���","��ʳ"),
                new AssistiveDevice(1100309,"��ϴ����Ƥ�ĸ�������","��ʳ"),
                new AssistiveDevice(1100312,"�濾��������","��ʳ"),
                new AssistiveDevice(1100315,"����׼��ʳ��Ļ���","��ʳ"),
                new AssistiveDevice(1100318,"������ͼ帨������","��ʳ"),
                new AssistiveDevice(1100319,"�����ø���","��ʳ"),
                new AssistiveDevice(1100320,"׼��ҩƷ�ø���","��ʳ"),
                new AssistiveDevice(1100606,"ϴ����ˢ��ƿˢ","��ʳ"),
                new AssistiveDevice(1100609,"�����˸���","��ʳ"),
                new AssistiveDevice(1100615,"Ĩ���ʸɻ�","��ʳ"),
                new AssistiveDevice(1100903,"��Ӧʳ������ϵĸ�������","��ʳ"),
                new AssistiveDevice(1100918,"���Ӻ���","��ʳ"),
                new AssistiveDevice(1100921,"ʳ�ﵲ��","��ʳ"),
                new AssistiveDevice(1100922,"��","��ʳ"),
                new AssistiveDevice(1100923,"��","��ʳ"),
                new AssistiveDevice(1100924,"����","��ʳ"),
                new AssistiveDevice(1100925,"����","��ʳ"),
                new AssistiveDevice(1100927,"ιʳ��е","��ʳ"),
                new AssistiveDevice(1100930,"ι��","��ʳ"),
                new AssistiveDevice(1100931,"������������װ","��ʳ"),

                new AssistiveDevice(110030601,"�����в���","��ʳ","1260�����в���.png",0,""),
                new AssistiveDevice(110030602,"���̶��в˰�","��ʳ","1261���̶��в˰�.jpeg",0,""),
                new AssistiveDevice(110030603,"�๦�ܵ����в���","��ʳ","1262�๦�ܵ����в���.jpg",0,""),
                new AssistiveDevice(110030701,"������ä�ĵ��¯","��ʳ","1263������ä�ĵ��¯.jpg",0,""),
                new AssistiveDevice(110030702,"΢����ä��������ѹ����","��ʳ","1264΢����ä��������ѹ����.jpg",0,""),
                new AssistiveDevice(110030703,"ä������΢��¯","��ʳ","1265ä������΢��¯.jpg",0,""),
                new AssistiveDevice(110030704,"΢����ä��������ʩ��","��ʳ","1266΢����ä��������ʩ��.jpg",0,""),
                new AssistiveDevice(110030705,"������ä�ĵ緹��","��ʳ","1267������ä�ĵ緹��.jpg",0,""),
                new AssistiveDevice(110030706,"������ä�ĵ�ѹ����","��ʳ","1268������ä�ĵ�ѹ����.jpg",0,""),
                new AssistiveDevice(110030707,"΢����ä���������¯","��ʳ","1269΢����ä���������¯.jpg",0,""),
                new AssistiveDevice(110030901,"��������Ƥ��","��ʳ","1270��������Ƥ��.jpg",0,""),
                new AssistiveDevice(110030902,"�̶���ʽ��Ƥ��","��ʳ","1271�̶���ʽ��Ƥ��.png",0,""),
                new AssistiveDevice(110030903,"�����̲�ˢ","��ʳ","1272�����̲�ˢ.jpg",0,""),
                new AssistiveDevice(110030904,"�ں˵ĵ���","��ʳ","1273�ں˵ĵ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(110031201,"�濾��","��ʳ","1274�濾������ͼƬ.jpg",0,""),
                new AssistiveDevice(110031202,"�濾��","��ʳ","1275�濾������ͼƬ.jpg",0,""),
                new AssistiveDevice(110031203,"�濾��","��ʳ","1276�濾������ͼƬ.jpg",0,""),
                new AssistiveDevice(110031501,"����","��ʳ","1277��������ͼƬ.jpg",0,""),
                new AssistiveDevice(110031801,"������ͼ帨������","��ʳ","1278������ͼ帨����������ͼƬ.jpg",0,""),
                new AssistiveDevice(110031901,"�����ͺ�","��ʳ","1279�����ͺ�.jpg",0,""),
                new AssistiveDevice(110032001,"�Զ���ҩ��","��ʳ","1280�Զ���ҩ��.jpg",0,""),
                new AssistiveDevice(110060601,"��������ˢ","��ʳ","1281��������ˢ.jpg",0,""),
                new AssistiveDevice(110060602,"������ƿˢ","��ʳ","1282������ƿˢ.jpg",0,""),
                new AssistiveDevice(110060901,"�����˸���","��ʳ","1283�����˸�������ͼƬ.jpg",0,""),
                new AssistiveDevice(110061501,"Ĩ���ʸɻ�","��ʳ","1284Ĩ���ʸɻ�.jpg",0,""),
                new AssistiveDevice(110090301,"��Ӧʳ������ϵĸ�������","��ʳ","1285��Ӧʳ������ϵĸ�����������ͼƬ.jpg",0,""),
                new AssistiveDevice(110091801,"��ͨ������","��ʳ","1286��ͨ������.png",0,""),
                new AssistiveDevice(110091802,"���·�����","��ʳ","1287���·�����.jpg",0,""),
                new AssistiveDevice(110091803,"�ײ������̲;�","��ʳ","1288�ײ������̲;�.jpg",0,""),
                new AssistiveDevice(110091804,"����","��ʳ","1289����.jpg",0,""),
                new AssistiveDevice(110092101,"�̵�","��ʳ","1290�̵�.png",0,""),
                new AssistiveDevice(110092102,"���Ϸ�����","��ʳ","1291���Ϸ�����.jpg",0,""),
                new AssistiveDevice(110092201,"�ֱ���","��ʳ","1292�ֱ���.jpg",0,""),
                new AssistiveDevice(110092202,"�����","��ʳ","1293�����.jpg",0,""),
                new AssistiveDevice(110092203,"�����","��ʳ","1294�����.jpg",0,""),
                new AssistiveDevice(110092204,"����ʽ��","��ʳ","1295����ʽ��.jpg",0,""),
                new AssistiveDevice(110092301,"�������ף�2֧װ��","��ʳ","1296�������ף�2֧װ��.jpg",0,""),
                new AssistiveDevice(110092302,"���������ͷ��","��ʳ","1297���������ͷ��.png",0,""),
                new AssistiveDevice(110092303,"�ֱ���","��ʳ","1298�ֱ��桢��.png",0,""),
                new AssistiveDevice(110092304,"����ʽ��","��ʳ","1299����ʽ��.png",0,""),
                new AssistiveDevice(110092305,"���ܼ�����","��ʳ","1300������.jpg",0,""),
                new AssistiveDevice(110092401,"����ѵ��������","��ʳ","1301����ѵ��������.jpg",0,""),
                new AssistiveDevice(110092402,"������������","��ʳ","1302����ʽ����.jpg",0,""),
                new AssistiveDevice(110092403,"�������Ͽ���","��ʳ","1303����ʽ����.jpg",0,""),
                new AssistiveDevice(110092404,"�����Ϳ�","��ʳ","1304�����Ϳ�.jpg",0,""),
                new AssistiveDevice(110092501,"��©ˮ����С�ţ�","��ʳ","1305��©ˮ����С�ţ�.jpg",0,""),
                new AssistiveDevice(110092502,"б�ڱ�","��ʳ","1306б�ڱ�.jpg",0,""),
                new AssistiveDevice(110092503,"�����","��ʳ","1307�����.png",0,""),
                new AssistiveDevice(110092504,"���ܱ�","��ʳ","1308���ܱ�.jpg",0,""),
                new AssistiveDevice(110092701,"�綯ιʳ��","��ʳ","1309�Զ�ιʳ��2.png",0,""),
                new AssistiveDevice(110093001,"ιʳ��","��ʳ","1310�綯ιʳ��.jpg",0,""),
                new AssistiveDevice(110093101,"����������","��ʳ","1311������������װ.jpg",0,""),
                #endregion
                
                #region ���˻���
                new AssistiveDevice(10315,"������ڻ���������","���˻���"),
                new AssistiveDevice(10318,"����ڻ���������","���˻���"),
                new AssistiveDevice(10321,"�����ͽ����Ʒ","���˻���"),
                new AssistiveDevice(10336,"�޼���ָ�׺ͽ�ֺ�׵ĸ�������","���˻���"),
                new AssistiveDevice(10339,"������������","���˻���"),
                new AssistiveDevice(10342,"���ƻ���������","���˻���"),
                new AssistiveDevice(10345,"�沿�����Ƥ������������","���˻���"),
                new AssistiveDevice(10408,"��ʽ�Ҿ�","���˻���"),
                new AssistiveDevice(10410,"�������","���˻���"),

                new AssistiveDevice(1031503,"��������׹�","���˻���"),
                new AssistiveDevice(1031506,"������ڱ�����","���˻���"),
                new AssistiveDevice(1031804,"һ��ʽ�����ڴ�","���˻���"),
                new AssistiveDevice(1031805,"����ʽ�����ڴ�","���˻���"),
                new AssistiveDevice(1031807,"������������һ��ʽ������ڴ�","���˻���"),
                new AssistiveDevice(1031808,"����������������ʽ������ڴ�","���˻���"),
                new AssistiveDevice(1031809,"��ڴ�֧�ź�ѹ�̸�������","���˻���"),
                new AssistiveDevice(1031813,"��ڻ���ѹ��ʹ���","���˻���"),
                new AssistiveDevice(1031814,"��ڻ���ճ����","���˻���"),
                new AssistiveDevice(1031815,"��ڴ��ܷ��","���˻���"),
                new AssistiveDevice(1031818,"��ڻ�����ζ�������ͳ�����","���˻���"),
                new AssistiveDevice(1031821,"��ڴ��Ļ���","���˻���"),
                new AssistiveDevice(1031824,"�೦��������","���˻���"),
                new AssistiveDevice(1031830,"��ڷ�����","���˻���"),
                new AssistiveDevice(1031833,"���ڵ�Һ��","���˻���"),
                new AssistiveDevice(1031836,"��ڻ����ó�ϴע����","���˻���"),
                new AssistiveDevice(1031839,"һ��ʽ���ڵ���ڴ�","���˻���"),
                new AssistiveDevice(1031842,"����ʽ���ڵ���ڴ�","���˻���"),
                new AssistiveDevice(1031845,"��ڻ���Ƥ���ڸǲ�","���˻���"),
                new AssistiveDevice(1031848,"������ڴ������","���˻���"),
                new AssistiveDevice(1032103,"�ʽ���","���˻���"),
                new AssistiveDevice(1032106,"�����","���˻���"),
                new AssistiveDevice(1032109,"������","���˻���"),
                new AssistiveDevice(1032112,"���ǲ���","���˻���"),
                new AssistiveDevice(1032115,"�ܷ����","���˻���"),
                new AssistiveDevice(1032118,"������","���˻���"),
                new AssistiveDevice(1033603,"ָ��ˢ","���˻���"),
                new AssistiveDevice(1033606,"ָ��ﱺ�ɰֽ��","���˻���"),
                new AssistiveDevice(1033609,"ָ�׼���ָ�׵�","���˻���"),
                new AssistiveDevice(1033612,"ĥ���","���˻���"),
                new AssistiveDevice(1033903,"��ϴ����ϴͷ���ĸ�������","���˻���"),
                new AssistiveDevice(1033907,"����","���˻���"),
                new AssistiveDevice(1033906,"ͷ��ˢ","���˻���"),
                new AssistiveDevice(1033909,"�����","���˻���"),
                new AssistiveDevice(1034203,"�޶������ֶ�����ˢ","���˻���"),
                new AssistiveDevice(1034206,"�������綯����ˢ","���˻���"),
                new AssistiveDevice(1034503,"�޺�ˢ���굶�ͣ��綯�����뵶","���˻���"),
                new AssistiveDevice(1034506,"��ױƷʹ�ø�������","���˻���"),
                new AssistiveDevice(1034509,"���������õľ���","���˻���"),
                new AssistiveDevice(1040801,"����","���˻���"),
                new AssistiveDevice(1041003,"����","���˻���"),
                new AssistiveDevice(1041006,"����ͳĵ�","���˻���"),
                new AssistiveDevice(1041009,"����","���˻���"),
                new AssistiveDevice(1041012,"ͷ�к;���","���˻���"),
                new AssistiveDevice(1041015,"���к�����","���˻���"),
                new AssistiveDevice(1041018,"�����к͹�����","���˻���"),

                new AssistiveDevice(103150301,"��ͨ�����ܲ��","���˻���","592��ͨ�����ܲ������ͼƬ.jpg",0,""),
                new AssistiveDevice(103150302,"��ǿ�����ܲ��","���˻���","593��ǿ�����ܲ������ͼƬ.jpg",0,""),
                new AssistiveDevice(103150601,"�����п���������","���˻���","594�����п�������������ͼƬ.jpg",0,""),
                new AssistiveDevice(103150602,"���ܲ�ܼ�ʪ������","���˻���","595���ܲ�ܼ�ʪ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(103150603,"���ܲ�ܷ��籣����","���˻���","596���ܲ�ܷ��籣��������ͼƬ.jpg",0,""),
                new AssistiveDevice(103180401,"һ��ʽ�����ڴ�","���˻���","597һ��ʽ�����ڴ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(103180501,"����ʽ�����ڴ�","���˻���","598����ʽ�����ڴ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(103180701,"������������һ��ʽ������ڴ�","���˻���","599������������һ��ʽ������ڴ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(103180801,"����������������ʽ������ڴ�","���˻���","600����������������ʽ������ڴ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(103180901,"��ڴ�֧�ź�ѹ�̸�������","���˻���","601��ڴ�֧�ź�ѹ�̸�����������ͼƬ.jpg",0,""),
                new AssistiveDevice(103181301,"��ڻ���ѹ��ʹ���","���˻���","602��ڻ���ѹ��ʹ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(103181401,"��ڻ���ճ����","���˻���","603��ڻ���ճ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(103181501,"��ڴ��ܷ��","���˻���","604��ڴ��ܷ������ͼƬ.jpg",0,""),
                new AssistiveDevice(103181801,"��ڻ�����ζ�������ͳ�����","���˻���","605��ڻ�����ζ�������ͳ���������ͼƬ.jpg",0,""),
                new AssistiveDevice(103182101,"���η�ڼ�","���˻���","606���η�ڼ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(103182102,"Բ�η�ڼ�","���˻���","607Բ�η�ڼ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(103182401,"Ͳʽ�೦��","���˻���","608Ͳʽ�೦������ͼƬ.jpg",0,""),
                new AssistiveDevice(103182402,"��ʽ�೦��","���˻���","609��ʽ�೦������ͼƬ.jpg",0,""),
                new AssistiveDevice(103182403,"��ҡ�೦��","���˻���","610��ҡ�೦������ͼƬ.jpg",0,""),
                new AssistiveDevice(103182404,"ȫ�Զ��೦��","���˻���","611ȫ�Զ��೦������ͼƬ.jpg",0,""),
                new AssistiveDevice(103182405,"һ���Թ೦��","���˻���","612һ���Թ೦����ͼƬ.jpg",0,""),
                new AssistiveDevice(103183001,"ͨ���ͷ�����","���˻���","613ͨ���ͷ���������ͼƬ.jpg",0,""),
                new AssistiveDevice(103183002,"�����ͷ�����","���˻���","614�����ͷ���������ͼƬ.jpg",0,""),
                new AssistiveDevice(103183003,"�����ͷ�����","���˻���","615�����ͷ���������ͼƬ.jpg",0,""),
                new AssistiveDevice(103183301,"���ڵ�Һ��","���˻���","616���ڵ�Һ������ͼƬ.jpg",0,""),
                new AssistiveDevice(103183601,"��ڻ����ó�ϴע����","���˻���","617��ڻ����ó�ϴע��������ͼƬ.jpg",0,""),
                new AssistiveDevice(103183901,"����һ��ʽ��ڴ�","���˻���","618����һ��ʽ��ڴ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(103183902,"��ͯһ��ʽ��ڴ�","���˻���","619��ͯһ��ʽ��ڴ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(103183903,"������������һ��ʽ��ڴ�","���˻���","620������������һ��ʽ��ڴ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(103184201,"Ƕ��ʽ����ʽ��ڴ�","���˻���","621Ƕ��ʽ����ʽ��ڴ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(103184202,"ճ��ʽ����ʽ��ڴ�","���˻���","622ճ��ʽ����ʽ��ڴ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(103184203,"����������������ʽ��ڴ�","���˻���","623����������������ʽ��ڴ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(103184501,"��ڻ���Ƥ���ڸǲ�","���˻���","624��ڻ���Ƥ���ڸǲ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(103184801,"������ڴ������","���˻���","625������ڴ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(103210301,"�ʽ���","���˻���","626�ʽ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(103210601,"�����","���˻���","627���������ͼƬ.jpg",0,""),
                new AssistiveDevice(103210901,"������","���˻���","628����������ͼƬ.jpg",0,""),
                new AssistiveDevice(103211201,"ɴ������","���˻���","629ɴ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(103211202,"��Ĥ����","���˻���","630��Ĥ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(103211203,"ˮ�������","���˻���","631ˮ�����������ͼƬ.jpg",0,""),
                new AssistiveDevice(103211204,"����","���˻���","632��������ͼƬ.jpg",0,""),
                new AssistiveDevice(103211501,"�ܷ����","���˻���","633�ܷ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(103211801,"������","���˻���","634����������ͼƬ.jpg",0,""),
                new AssistiveDevice(103360301,"ָ��ˢ","���˻���","712ָ��ˢ����ͼƬ.jpg",0,""),
                new AssistiveDevice(103360601,"������ָ���","���˻���","713������ָ���.jpg",0,""),
                new AssistiveDevice(103360602,"������ɰֽ��","���˻���","714������ɰֽ��.jpg",0,""),
                new AssistiveDevice(103360901,"���Ŵ�ָ�׼�","���˻���","715���Ŵ�ָ�׼�.jpg",0,""),
                new AssistiveDevice(103360902,"������ָ�׼�","���˻���","716������ָ�׼�.jpg",0,""),
                new AssistiveDevice(103360903,"�Ŵ�ָ�׵�","���˻���","717�Ŵ�ָ�׵�.jpg",0,""),
                new AssistiveDevice(103361201,"�ֶ���Ƥ�޼���","���˻���","718�ֶ���Ƥ�޼�������ͼƬ.jpg",0,""),
                new AssistiveDevice(103390301,"��ϴ����ϴͷ���ĸ�������","���˻���","719��ϴ����ϴͷ���ĸ���������ͼƬ.jpg",0,""),
                new AssistiveDevice(103390601,"������ˢ","���˻���","721������ˢ.jpg",0,""),
                new AssistiveDevice(103390602,"�ֱ���ˢ","���˻���","722�ֱ���ˢ.jpg",0,""),
                new AssistiveDevice(103390603,"�����ˢ","���˻���","723�����ˢ.jpg",0,""),
                new AssistiveDevice(103390604,"����ʽ��ˢ","���˻���","724����ʽ��ˢ.jpg",0,""),
                new AssistiveDevice(103390701,"����ͷ��","���˻���","720����ͷ��.jpg",0,""),
                new AssistiveDevice(103390901,"�����","���˻���","725���������ͼƬ.jpg",0,""),
                new AssistiveDevice(103420301,"�����ˢ","���˻���","726�����ˢ.jpg",0,""),
                new AssistiveDevice(103420302,"�ֱ���ˢ","���˻���","727�ֱ���ˢ.jpg",0,""),
                new AssistiveDevice(103420303,"����ʽ��ˢ","���˻���","728����ʽ��ˢ.jpg",0,""),
                new AssistiveDevice(103420304,"������ˢ","���˻���","729������ˢ.jpg",0,""),
                new AssistiveDevice(103420601,"��ͨ�綯��ˢ","���˻���","730��ͨ�綯��ˢ.jpg",0,""),
                new AssistiveDevice(103420602,"����ʽ�綯��ˢ","���˻���","731����ʽ�綯��ˢ.jpg",0,""),
                new AssistiveDevice(103420603,"�ֱ��綯��ˢ","���˻���","732�ֱ��綯��ˢ.jpg",0,""),
                new AssistiveDevice(103450301,"����ˢ","���˻���","733����ˢ����ͼƬ.jpg",0,""),
                new AssistiveDevice(103450302,"�굶","���˻���","734�굶����ͼƬ.jpg",0,""),
                new AssistiveDevice(103450303,"�ֶ����뵶","���˻���","735�ֶ����뵶����ͼƬ.jpg",0,""),
                new AssistiveDevice(103450304,"�綯���뵶","���˻���","736�綯���뵶����ͼƬ.jpg",0,""),
                new AssistiveDevice(103450601,"��ױƷʹ�ø�������","���˻���","737��ױƷʹ�ø�����������ͼƬ.jpg",0,""),
                new AssistiveDevice(103450901,"���������õľ���","���˻���","738���������õľ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(104080101,"��ֱͨ�廤��","���˻���","739��ֱͨ�廤������ͼƬ.jpg",0,""),
                new AssistiveDevice(104080102,"��ͨ�����۵�����","���˻���","740��ͨ�����۵�����.jpg",0,""),
                new AssistiveDevice(104080103,"�ֶ���ҡ����","���˻���","741�ֶ���ҡ����.jpg",0,""),
                new AssistiveDevice(104080104,"�ֶ�˫ҡ����","���˻���","742�ֶ�˫ҡ����.jpg",0,""),
                new AssistiveDevice(104080105,"�ֶ���ҡ�������ɷ���","���˻���","743�ֶ���ҡ�������ɷ���.jpg",0,""),
                new AssistiveDevice(104080106,"��ͨ�綯����","���˻���","744��ͨ�綯����.jpg",0,""),
                new AssistiveDevice(104080107,"�����綯����","���˻���","745�����綯����.jpg",0,""),
                new AssistiveDevice(104080108,"����綯����","���˻���","746����綯����.png",0,""),
                new AssistiveDevice(104100301,"�ɵ��������ܣ�","���˻���","753�ɵ��������ܣ�.jpg",0,""),
                new AssistiveDevice(104100302,"��ͨ����","���˻���","754��ͨ����.jpg",0,""),
                new AssistiveDevice(104100303,"�����Ϳ���","���˻���","755�����Ϳ���.png",0,""),
                new AssistiveDevice(104100601,"��¨����ĭ����","���˻���","756��¨����ĭ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(104100602,"�䳲�;�����������","���˻���","757�䳲�;���������������ͼƬ.jpg",0,""),
                new AssistiveDevice(104100603,"Һ̬����������","���˻���","758Һ̬��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(104100604,"����ʽ����","���˻���","759����ʽ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(104100605,"����ʽ����","���˻���","760����ʽ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(104100606,"������","���˻���","761����������ͼƬ.jpg",0,""),
                new AssistiveDevice(104100607,"��׵��","���˻���","762��׵������ͼƬ.jpg",0,""),
                new AssistiveDevice(104100901,"�������ˣ����Ի�����","���˻���","763�������ˣ����Ի�����.png",0,""),
                new AssistiveDevice(104100902,"�Ϸ�ʽǰ�۷���","���˻���","764�Ϸ�ʽǰ�۷���.jpg",0,""),
                new AssistiveDevice(104100903,"�̶�ʽǰ�۷���","���˻���","765�̶�ʽǰ�۷���.jpg",0,""),
                new AssistiveDevice(104100904,"���Է���","���˻���","766���Է���.jpg",0,""),
                new AssistiveDevice(104100905,"ԡ�׷���","���˻���","767ԡ�׷���1.jpg",0,""),
                new AssistiveDevice(104101201,"������ͷ��","���˻���","768������ͷ������ͼƬ.jpg",0,""),
                new AssistiveDevice(104101202,"�����Ͼ���","���˻���","769�����Ͼ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(104101203,"����","���˻���","770��������ͼƬ.jpg",0,""),
                new AssistiveDevice(104101204,"�Ͼ���","���˻���","771�Ͼ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(104101501,"����������","���˻���","772��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(104101502,"����������","���˻���","773��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(104101503,"��������λ��Ű�","���˻���","774��������λ��Ű�����ͼƬ.jpg",0,""),
                new AssistiveDevice(104101801,"�����Ϲ�����","���˻���","775�����Ϲ���������ͼƬ.jpg",0,""),
                new AssistiveDevice(104101802,"������������","���˻���","776����������������ͼƬ.jpg",0,""),
                #endregion
                
                #region ���
                new AssistiveDevice(10312,"��޸�������","���"),
                new AssistiveDevice(10324,"����װ��","���"),
                new AssistiveDevice(10327,"����ռ���","���"),
                new AssistiveDevice(10330,"�������ո�������","���"),
                new AssistiveDevice(10331,"��ֹ��С�㲻���������ĸ�������","���"),

                new AssistiveDevice(1031203,"������","���"),
                new AssistiveDevice(1031206,"������","���"),
                new AssistiveDevice(1031209,"��������","���"),
                new AssistiveDevice(1031212,"����ͼӸߵ���������","���"),
                new AssistiveDevice(1031215,"Ƕ���ͼӸߵ���������","���"),
                new AssistiveDevice(1031218,"��װ���������ϼӸߵ���������","���"),
                new AssistiveDevice(1031221,"���ð����������µ�������������������","���"),
                new AssistiveDevice(1031224,"װ�����������ϵķ��ֺͿ���","���"),
                new AssistiveDevice(1031225,"���ʽ�������ķ��ֿ���","���"),
                new AssistiveDevice(1031227,"��ֽ��","���"),
                new AssistiveDevice(1031233,"����","���"),
                new AssistiveDevice(1031236,"��Ϊ�����������ĳ�ϴ���ͷ������","���"),
                new AssistiveDevice(1032403,"�������õ����","���"),
                new AssistiveDevice(1032406,"��Ъ�Ե����","���"),
                new AssistiveDevice(1032409,"��������","���"),
                new AssistiveDevice(1032415,"Ů�ô���ʽ�����","���"),
                new AssistiveDevice(1032421,"���ô���ʽ�����","���"),
                new AssistiveDevice(1032704,"��ڴ����","���"),
                new AssistiveDevice(1032705,"���ڴ����","���"),
                new AssistiveDevice(1032709,"�Ǵ���ʽ���������ƿ","���"),
                new AssistiveDevice(1032713,"�����������ܺ͹̶�װ��","���"),
                new AssistiveDevice(1032718,"���ռ�ϵͳ","���"),
                new AssistiveDevice(1032721,"����ռ���","���"),
                new AssistiveDevice(1033012,"��ͯ��һ����ʧ����Ʒ","���"),
                new AssistiveDevice(1033015,"��ͯ��ϴʧ����Ʒ","���"),
                new AssistiveDevice(1033018,"����һ���Գĵ�","���"),
                new AssistiveDevice(1033021,"����һ������","���"),
                new AssistiveDevice(1033042,"������һ�������������Ʒ","���"),
                new AssistiveDevice(1033045,"�������ϴ���������Ʒ","���"),
                new AssistiveDevice(1033103,"������","���"),
                new AssistiveDevice(1033106,"�����","���"),

                new AssistiveDevice(103120301,"�۵�������","���","569�۵�������.jpg",0,""),
                new AssistiveDevice(103120302,"�̶�������","���","570�̶�������.jpg",0,""),
                new AssistiveDevice(103120303,"����������","���","571����������.jpg",0,""),
                new AssistiveDevice(103120304,"����������","���","572����������.jpg",0,""),
                new AssistiveDevice(103120305,"������������","���","573������������.jpg",0,""),
                new AssistiveDevice(103120306,"��������������","���","574��������������.jpg",0,""),
                new AssistiveDevice(103120307,"��ͯ������","���","575��ͯ������.jpg",0,""),
                new AssistiveDevice(103120601,"����������","���","576����������.jpg",0,""),
                new AssistiveDevice(103120602,"����������","���","577����������.jpg",0,""),
                new AssistiveDevice(103120603,"���ó�ϴ����������","���","578���ó�ϴ����������.jpg",0,""),
                new AssistiveDevice(103120901,"��������","���","579������������ͼƬ.jpg",0,""),
                new AssistiveDevice(103121201,"�����ּӸ�����������","���","580�����ּӸ�����������.jpg",0,""),
                new AssistiveDevice(103121501,"Ƕ���ͼӸߵ���������","���","581Ƕ���ͼӸߵ���������.jpg",0,""),
                new AssistiveDevice(103121801,"��װ���������ϼӸߵ���������","���","582��װ���������ϼӸߵ���������.jpg",0,""),
                new AssistiveDevice(103122101,"����������������","���","583����������������.png",0,""),
                new AssistiveDevice(103122401,"�̶����������ϵ�����֧�ż�","���","584�̶����������ϵ�����֧�ż�.jpg",0,""),
                new AssistiveDevice(103122501,"���ʽ�������ķ��ֿ���","���","585���ʽ�������ķ��ֿ���.jpg",0,""),
                new AssistiveDevice(103122701,"�̱���ֽ��","���","586�̱���ֽ��.jpg",0,""),
                new AssistiveDevice(103122702,"������ֽ��","���","587������ֽ��.jpg",0,""),
                new AssistiveDevice(103123301,"��Яʽ��������","���","588��Яʽ��������.jpg",0,""),
                new AssistiveDevice(103123302,"���ϴ����","���","589���ϴ����.jpg",0,""),
                new AssistiveDevice(103123601,"��������ϴ��","���","590��������ϴ��.jpg",0,""),
                new AssistiveDevice(103123602,"�������ȷ������","���","591�������ȷ������.jpg",0,""),
                new AssistiveDevice(103240301,"�������õ����","���","635�������õ����.jpg",0,""),
                new AssistiveDevice(103240302,"Ů�����õ����","���","636Ů�����õ����.jpg",0,""),
                new AssistiveDevice(103240303,"С�����õ����","���","637С�����õ����.jpg",0,""),
                new AssistiveDevice(103240601,"���ü�Ъ�Ե����","���","638���ü�Ъ�Ե����.png",0,""),
                new AssistiveDevice(103240602,"Ů�ü�Ъ�Ե����","���","639Ů�ü�Ъ�Ե����.jpg",0,""),
                new AssistiveDevice(103240603,"С����Ъ�Ե����","���","640С����Ъ�Ե����.jpg",0,""),
                new AssistiveDevice(103240901,"��������������","���","641��������������.jpg",0,""),
                new AssistiveDevice(103240902,"С������������","���","642С����������������ͼƬ.jpg",0,""),
                new AssistiveDevice(103241501,"��ͨŮ�����","���","643��ͨŮ�����.jpg",0,""),
                new AssistiveDevice(103241502,"����Ů�����","���","644����Ů�����.jpg",0,""),
                new AssistiveDevice(103241503,"���̶�Ů�����","���","645���̶�Ů���������ͼƬ.jpg",0,""),
                new AssistiveDevice(103242101,"��ͨ�������","���","646��ͨ�������.jpg",0,""),
                new AssistiveDevice(103242102,"�����������","���","647�����������.jpg",0,""),
                new AssistiveDevice(103242103,"���̶��������","���","648���̶������������ͼƬ.jpg",0,""),
                new AssistiveDevice(103270401,"����ʽ���Է�ڼ�����","���","649����ʽ���Է�ڼ�����.jpg",0,""),
                new AssistiveDevice(103270402,"�뵼���һͬʹ�õĴ���","���","650�뵼���һͬʹ�õĴ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(103270501,"����ʽ���Կ��ڼ�����","���","651����ʽ���Կ��ڼ�����.jpg",0,""),
                new AssistiveDevice(103270502,"�뵼���һͬʹ�õĴ���","���","652�뵼���һͬʹ�õĴ���.jpg",0,""),
                new AssistiveDevice(103270901,"�Ǵ���ʽ���������ƿ","���","653�Ǵ���ʽ���������ƿ����ͼƬ.jpg",0,""),
                new AssistiveDevice(103271301,"����������","���","654��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(103271302,"���������̴�","���","655���������̴�����ͼƬ.jpg",0,""),
                new AssistiveDevice(103271801,"�齺������","���","656�齺������.jpg",0,""),
                new AssistiveDevice(103271802,"��ͨ������","���","657��ͨ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(103271803,"���ʽ������","���","658���ʽ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(103271804,"������","���","659������.jpg",0,""),
                new AssistiveDevice(103272101,"һ���Է���ռ���","���","660һ���Է���ռ���.jpg",0,""),
                new AssistiveDevice(103272102,"�ɳ�ϴ����ռ���","���","661�ɳ�ϴ����ռ���.jpg",0,""),
                new AssistiveDevice(103301201,"��ͯ��ʪ","���","662��ͯ��ʪ.jpg",0,""),
                new AssistiveDevice(103301202,"��ͯ��ĵ�","���","663��ͯ��ĵ�.png",0,""),
                new AssistiveDevice(103301501,"��ͯ����̺","���","664��ͯ����̺.png",0,""),
                new AssistiveDevice(103301801,"ֽ����ĵ�","���","665ֽ����ĵ�.png",0,""),
                new AssistiveDevice(103302101,"����ֽ���","���","666����ֽ���.jpg",0,""),
                new AssistiveDevice(103304201,"һ���Բ���","���","667һ���Բ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(103304202,"һ����������","���","668һ��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(103304203,"һ���Դ���","���","669һ���Դ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(103304204,"һ���Դ���","���","670һ���Դ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(103304501,"������","���","671����������ͼƬ.jpg",0,""),
                new AssistiveDevice(103304502,"����","���","672��������ͼƬ.jpg",0,""),
                new AssistiveDevice(103304503,"����","���","673��������ͼƬ.jpg",0,""),
                new AssistiveDevice(103310301,"������Ʋ���","���","674������Ʋ���.jpg",0,""),
                new AssistiveDevice(103310302,"�������","���","675�������.jpg",0,""),
                new AssistiveDevice(103310303,"������","���","676������.jpg",0,""),
                new AssistiveDevice(103310304,"������","���","677������.jpg",0,""),
                new AssistiveDevice(103310305,"�����͵ļн�����ܵ�����","���","678�����͵ļн�����ܵ�����.jpg",0,""),
                new AssistiveDevice(103310601,"���Ų���","���","679���Ų�������ͼƬ.jpg",0,""),
                new AssistiveDevice(103310602,"���Ų���","���","680���Ų���.jpg",0,""),
                #endregion
                
                #region ��Ϣ����
                new AssistiveDevice(10527,"������ָʾ�����Ѻ�Ѷ�Ÿ�������","��Ϣ����"),
                new AssistiveDevice(10509,"������������","��Ϣ����"),
                new AssistiveDevice(10515,"���㸨������","��Ϣ����"),
                new AssistiveDevice(10518,"��¼�����ź���ʾ������Ϣ�ĸ�������","��Ϣ����"),
                new AssistiveDevice(10521,"����湵ͨ��������","��Ϣ����"),
                new AssistiveDevice(10524,"�绰���ͣ���Ϣ����Զ����Ϣ����������","��Ϣ����"),
                new AssistiveDevice(10530,"�Ķ���������","��Ϣ����"),
                new AssistiveDevice(10533,"��������ն��豸","��Ϣ����"),
                new AssistiveDevice(10536,"����������豸","��Ϣ����"),
                new AssistiveDevice(10539,"���������豸","��Ϣ����"),

                new AssistiveDevice(1052721,"������������ϵͳ","��Ϣ����"),
                new AssistiveDevice(1050903,"����������","��Ϣ����"),
                new AssistiveDevice(1050906,"�����������Ŵ���","��Ϣ����"),
                new AssistiveDevice(1051503,"�ֶ�������","��Ϣ����"),
                new AssistiveDevice(1051506,"�����豸","��Ϣ����"),
                new AssistiveDevice(1051509,"�������","��Ϣ����"),
                new AssistiveDevice(1051803,"������¼�Ͳ����豸","��Ϣ����"),
                new AssistiveDevice(1051806,"��Ƶ��¼�Ͳ����豸","��Ϣ����"),
                new AssistiveDevice(1051809,"���ߵ���ջ�","��Ϣ����"),
                new AssistiveDevice(1051812,"˫�����߶Խ���","��Ϣ����"),
                new AssistiveDevice(1051815,"���ӻ�","��Ϣ����"),
                new AssistiveDevice(1051818,"��·����ϵͳ","��Ϣ����"),
                new AssistiveDevice(1051821,"ͼ�ĺ��ı����ӽ�����","��Ϣ����"),
                new AssistiveDevice(1051824,"���ߵ�Ƶ�ʴ���ϵͳ","��Ϣ����"),
                new AssistiveDevice(1051827,"������Ϣ�������ϵͳ","��Ϣ����"),
                new AssistiveDevice(1052103,"��ĸ�ͷ��ſ�����","��Ϣ����"),
                new AssistiveDevice(1052109,"�Ի�װ��","��Ϣ����"),
                new AssistiveDevice(1052112,"����湵ͨ�����","��Ϣ����"),
                new AssistiveDevice(1052403,"��ͨ����绰","��Ϣ����"),
                new AssistiveDevice(1052406,"�ƶ�����绰","��Ϣ����"),
                new AssistiveDevice(1052409,"�ı��绰��","��Ϣ����"),
                new AssistiveDevice(1052415,"�绰Ӧ���","��Ϣ����"),
                new AssistiveDevice(1052418,"�绰������","��Ϣ����"),
                new AssistiveDevice(1052424,"Զ�̽�����Զ����Ϣ�������","��Ϣ����"),
                new AssistiveDevice(1052427,"�ڲ�ͨ��װ��","��Ϣ����"),
                new AssistiveDevice(1052430,"Ӧ�ŶԽ��绰","��Ϣ����"),
                new AssistiveDevice(1052703,"�Ӿ��ź�ָʾ��","��Ϣ����"),
                new AssistiveDevice(1052706,"���ź�ָʾ��","��Ϣ����"),
                new AssistiveDevice(1052709,"��е�ź�ָʾ��","��Ϣ����"),
                new AssistiveDevice(1052712,"ʱ�Ӻͼ�ʱ��","��Ϣ����"),
                new AssistiveDevice(1052715,"������ʱ���","��Ϣ����"),
                new AssistiveDevice(1052716,"��������Ĳ�Ʒ","��Ϣ����"),
                new AssistiveDevice(1052718,"���˽�������ϵͳ","��Ϣ����"),
                new AssistiveDevice(1052724,"���Ͷ�λϵͳ","��Ϣ����"),
                new AssistiveDevice(1052727,"��ʶ���Ϻͱ�ǹ���","��Ϣ����"),
                new AssistiveDevice(1053003,"������������Ķ�����","��Ϣ����"),
                new AssistiveDevice(1053006,"�������ӡˢ���Ķ�����","��Ϣ����"),
                new AssistiveDevice(1053009,"��ý���Ķ�����","��Ϣ����"),
                new AssistiveDevice(1053012,"������","��Ϣ����"),
                new AssistiveDevice(1053015,"��֧�żܺ���̶���","��Ϣ����"),
                new AssistiveDevice(1053021,"�ַ��Ķ���","��Ϣ����"),
                new AssistiveDevice(1053018,"�Ķ���Ͱ����޶���","��Ϣ����"),
                new AssistiveDevice(1053024,"�����Ķ�����","��Ϣ����"),
                new AssistiveDevice(1053027,"�����ý����ʾ���","��Ϣ����"),
                new AssistiveDevice(1053303,"̨ʽ�����","��Ϣ����"),
                new AssistiveDevice(1053306,"��Яʽ������͸�����������PDA��","��Ϣ����"),
                new AssistiveDevice(1053309,"������Ϣ�������ն�","��Ϣ����"),
                new AssistiveDevice(1053312,"�������","��Ϣ����"),
                new AssistiveDevice(1053315,"���������͹�ͨ���","��Ϣ����"),
                new AssistiveDevice(1053318,"���ڼ����������ĸ���","��Ϣ����"),
                new AssistiveDevice(1053603,"����","��Ϣ����"),
                new AssistiveDevice(1053612,"��������豸","��Ϣ����"),
                new AssistiveDevice(1053615,"�������","��Ϣ����"),
                new AssistiveDevice(1053618,"�������","��Ϣ����"),
                new AssistiveDevice(1053621,"��λ��Ļָ���ѡ��������ʾ����ʾ���ݵĸ�������","��Ϣ����"),
                new AssistiveDevice(1053904,"���Ӽ������ʾ�������","��Ϣ����"),
                new AssistiveDevice(1053905,"ä�ļ������ʾ��","��Ϣ����"),
                new AssistiveDevice(1053906,"��ӡ��","��Ϣ����"),
                new AssistiveDevice(1053907,"�����������ʾ��","��Ϣ����"),
                new AssistiveDevice(1053912,"����������","��Ϣ����"),

                new AssistiveDevice(105090301,"���Խ�����","��Ϣ����","845���Խ�����.jpg",0,""),
                new AssistiveDevice(105090601,"�����������Ŵ���","��Ϣ����","846�����������Ŵ���.jpg",0,""),
                new AssistiveDevice(105150301,"����ä��ѧϰ������","��Ϣ����","870����ä��ѧϰ������.jpg",0,""),
                new AssistiveDevice(105150601,"�������Ӽ�����","��Ϣ����","871�������Ӽ�����.jpg",0,""),
                new AssistiveDevice(105150901,"�����������","��Ϣ����","872�������.jpg",0,""),
                new AssistiveDevice(105180301,"�����","��Ϣ����","873�����.jpg",0,""),
                new AssistiveDevice(105180601,"��̱��ͯѧϰ��","��Ϣ����","874��̱��ͯѧϰ��.jpg",0,""),
                new AssistiveDevice(105180901,"����������","��Ϣ����","875����������.jpg",0,""),
                new AssistiveDevice(105181201,"˫�����߶Խ���","��Ϣ����","876˫�����߶Խ���.jpg",0,""),
                new AssistiveDevice(105181501,"���ӻ�","��Ϣ����","877���ӻ�.jpg",0,""),
                new AssistiveDevice(105181801,"��·����ϵͳ","��Ϣ����","878��·����ϵͳ.jpg",0,""),
                new AssistiveDevice(105182101,"ͼ�ĺ��ı����ӽ�����","��Ϣ����","879ͼ�ĺ��ı����ӽ�����.jpg",0,""),
                new AssistiveDevice(105182401,"���ߵ�Ƶ�ʴ���ϵͳ","��Ϣ����","880���ߵ�Ƶ�ʴ���ϵͳ.JPG",0,""),
                new AssistiveDevice(105182701,"������Ϣ�������ϵͳ","��Ϣ����","881������Ϣ�������ϵͳ.jpg",0,""),
                new AssistiveDevice(105210301,"ä��ר������","��Ϣ����","882ä��ר������.jpg",0,""),
                new AssistiveDevice(105210302,"ä���˿�","��Ϣ����","883ä���˿�.jpg",0,""),
                new AssistiveDevice(105210303,"�����������˿�","��Ϣ����","884�����������˿�.jpg",0,""),
                new AssistiveDevice(105210901,"˫�����߶Խ�����","��Ϣ����","885˫�����߶Խ�����.jpg",0,""),
                new AssistiveDevice(105210902,"�������߶Խ�����","��Ϣ����","886�������߶Խ�����.jpg",0,""),
                new AssistiveDevice(105210903,"���߶Խ�����","��Ϣ����","887���߶Խ�����.jpg",0,""),
                new AssistiveDevice(105210904,"USB ������д������","��Ϣ����","888USB ������д������.jpg",0,""),
                new AssistiveDevice(105210905,"��ɫ��д������","��Ϣ����","889��ɫ��д������.jpg",0,""),
                new AssistiveDevice(105210906,"������д������","��Ϣ����","890������д������.jpg",0,""),
                new AssistiveDevice(105210907,"E��ͨ","��Ϣ����","891E��ͨ.jpg",0,""),
                new AssistiveDevice(105210908,"΢�������ǹ�ͨ�ǣ�7�磩","��Ϣ����","892΢�������ǹ�ͨ�ǣ�7�磩.jpg",0,""),
                new AssistiveDevice(105211201,"��֪��ͨ����","��Ϣ����","893��֪��ͨ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(105211202,"���﹵ͨ����","��Ϣ����","894���﹵ͨ����.jpg",0,""),
                new AssistiveDevice(105211203,"���﹵ͨ����","��Ϣ����","895���﹵ͨ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(105240301,"ä�������绰��","��Ϣ����","896ä�������绰��.jpg",0,""),
                new AssistiveDevice(105240302,"��ä�ĵ绰��","��Ϣ����","897����������̵绰.jpg",0,""),
                new AssistiveDevice(105240303,"����������̵绰","��Ϣ����","898����������̵绰����ͼƬ.jpg",0,""),
                new AssistiveDevice(105240304,"���ӵ绰��","��Ϣ����","899���ӵ绰������ͼƬ.jpg",0,""),
                new AssistiveDevice(105240601,"ä�����ֻ�","��Ϣ����","900ä�����ֻ�.jpg",0,""),
                new AssistiveDevice(105240901,"��ͨͼ�ĵ绰��","��Ϣ����","901��ͨͼ�ĵ绰������ͼƬ.jpg",0,""),
                new AssistiveDevice(105240902,"ä�ķ��ŵ绰��","��Ϣ����","902�ı��绰��.jpg",0,""),
                new AssistiveDevice(105241501,"�绰Ӧ���","��Ϣ����","903�绰Ӧ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(105241801,"�绰������","��Ϣ����","904�绰����������ͼƬ.jpg",0,""),
                new AssistiveDevice(105242401,"Զ�̽�����Զ����Ϣ�������","��Ϣ����","905Զ�̽�����Զ����Ϣ�����������ͼƬ.jpg",0,""),
                new AssistiveDevice(105242701,"�ڲ�ͨ��װ��","��Ϣ����","906�ڲ�ͨ��װ������ͼƬ.jpg",0,""),
                new AssistiveDevice(105243001,"Ӧ�ŶԽ��绰","��Ϣ����","907Ӧ�ŶԽ��绰����ͼƬ.jpg",0,""),
                new AssistiveDevice(105270301,"������������","��Ϣ����","908������������.jpeg",0,""),
                new AssistiveDevice(105270302,"������������","��Ϣ����","909������������.jpg",0,""),
                new AssistiveDevice(105270303,"��ͨ��������","��Ϣ����","910��ͨ��������.jpg",0,""),
                new AssistiveDevice(105270304,"ң����������","��Ϣ����","911ң��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(105270601,"ä�˵㳮��","��Ϣ����","912ä�˵㳮��.jpg",0,""),
                new AssistiveDevice(105270602,"��ʽȫ�Զ�Ѫѹ��","��Ϣ����","913��ʽȫ�Զ�Ѫѹ��.jpg",0,""),
                new AssistiveDevice(105270603,"������ӳӣ�������","��Ϣ����","914������ӳӣ�������.jpg",0,""),
                new AssistiveDevice(105270604,"������ӳӣ�������","��Ϣ����","915������ӳӣ�������.jpg",0,""),
                new AssistiveDevice(105270605,"���籨����","��Ϣ����","916���籨����.png",0,""),
                new AssistiveDevice(105270606,"������ʾ��","��Ϣ����","917������ʾ��.jpg",0,""),
                new AssistiveDevice(105270607,"�����������¼�","��Ϣ����","918�����������¼�.jpg",0,""),
                new AssistiveDevice(105270608,"��ʽȫ�Զ�Ѫѹ�ƣ�������","��Ϣ����","919��ʽȫ�Զ�Ѫѹ�ƣ�������.jpg",0,""),
                new AssistiveDevice(105270609,"���ܼҾӰ�ȫԤ����","��Ϣ����","920���ܼҾӰ�ȫԤ����.jpg",0,""),
                new AssistiveDevice(105270610,"��������ȼ��ʽ������","��Ϣ����","921��������ȼ��ʽ������.jpg",0,""),
                new AssistiveDevice(105270611,"���������ˮ��","��Ϣ����","922���������ˮ��.jpg",0,""),
                new AssistiveDevice(105270612,"����Ѱ����","��Ϣ����","923����Ѱ����.jpg",0,""),
                new AssistiveDevice(105270613,"΢��������������","��Ϣ����","924΢��������������.png",0,""),
                new AssistiveDevice(105270614,"�����������ʽ������","��Ϣ����","925�����������ʽ������.jpg",0,""),
                new AssistiveDevice(105270615,"����ָ����","��Ϣ����","926����ָ����.jpg",0,""),
                new AssistiveDevice(105270901,"ä��ֽ��ʶ����","��Ϣ����","927ä��ֽ��ʶ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(105270902,"�๦�������ֱ�","��Ϣ����","928�๦�������ֱ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(105271201,"��������ä��","��Ϣ����","929��������ä��.jpg",0,""),
                new AssistiveDevice(105271202,"ʵ�ô���ä��","��Ϣ����","930ʵ�ô���ä��.jpg",0,""),
                new AssistiveDevice(105271203,"��ʱ��","��Ϣ����","931��ʱ��.jpg",0,""),
                new AssistiveDevice(105271204,"������","��Ϣ����","932������.jpg",0,""),
                new AssistiveDevice(105271205,"���ֱ�","��Ϣ����","933���ֱ�.jpg",0,""),
                new AssistiveDevice(105271206,"���ܶ�λ�ֱ�","��Ϣ����","934���ܶ�λ�ֱ�.jpg",0,""),
                new AssistiveDevice(105271501,"ä��������","��Ϣ����","935������ʱ���.jpg",0,""),
                new AssistiveDevice(105271601,"��������Ĳ�Ʒ","��Ϣ����","936��������Ĳ�Ʒ.png",0,""),
                new AssistiveDevice(105271801,"������","��Ϣ����","937������.jpg",0,""),
                new AssistiveDevice(105272101,"���Ժ�����","��Ϣ����","798���Ժ�����.jpg",0,""),
                new AssistiveDevice(105272102,"���籨����","��Ϣ����","799���籨����.png",0,""),
                new AssistiveDevice(105272103,"ˮ������","��Ϣ����","938ˮ������.jpg",0,""),
                new AssistiveDevice(105272401,"���Ͷ�λϵͳ","��Ϣ����","939���Ͷ�λϵͳ.jpg",0,""),
                new AssistiveDevice(105272701,"��ʶ���Ϻͱ�ǹ���","��Ϣ����","940��ʶ���Ϻͱ�ǹ���.jpg",0,""),
                new AssistiveDevice(105300301,"������������Ķ�����","��Ϣ����","941������������Ķ���������ͼƬ.jpg",0,""),
                new AssistiveDevice(105300601,"�������ӡˢ���Ķ�����","��Ϣ����","942�������ӡˢ���Ķ���������ͼƬ.jpg",0,""),
                new AssistiveDevice(105300901,"���˼��������̲�","��Ϣ����","943���˼��������̲�.jpg",0,""),
                new AssistiveDevice(105300902,"�����ճ��Ự�̲�","��Ϣ����","944�����ճ�����̲�.jpg",0,""),
                new AssistiveDevice(105300903,"��������ʻ�̲�","��Ϣ����","945��������ʻ�̲�.jpg",0,""),
                new AssistiveDevice(105300904,"����������Ƶ��ѵ�̲�","��Ϣ����","946����������Ƶ��ѵ�̲�.jpg",0,""),
                new AssistiveDevice(105301201,"������","��Ϣ����","947������.jpg",0,""),
                new AssistiveDevice(105301501,"���ʽ��֧�ż�","��Ϣ����","948���ʽ��֧�ż�����ͼƬ.jpg",0,""),
                new AssistiveDevice(105301502,"���ʽ��̶���","��Ϣ����","949���ʽ��̶�������ͼƬ.jpg",0,""),
                new AssistiveDevice(105301801,"�Ķ����","��Ϣ����","956�Ķ����.jpg",0,""),
                new AssistiveDevice(105301802,"���ʽ�����޶���","��Ϣ����","957���ʽ�����޶���.png",0,""),
                new AssistiveDevice(105302101,"��Яʽ�๦���Ķ���","��Ϣ����","950��Яʽ�๦���Ķ���.jpg",0,""),
                new AssistiveDevice(105302102,"����������֪�����ǣ�32cm)","��Ϣ����","951����������֪�����ǣ�32cm).jpg",0,""),
                new AssistiveDevice(105302103,"���������֪��ͼ��װ��������ʣ�","��Ϣ����","952���������֪��ͼ��װ��������ʣ�.jpg",0,""),
                new AssistiveDevice(105302104,"�����й�����������ͼ","��Ϣ����","953�����й�����������ͼ.jpg",0,""),
                new AssistiveDevice(105302105,"ä��������","��Ϣ����","954ä��������.jpg",0,""),
                new AssistiveDevice(105302106,"һ��ʽ�����Ķ���","��Ϣ����","955һ��ʽ�����Ķ���.jpg",0,""),
                new AssistiveDevice(105302107,"�����","��Ϣ����","958���������ͼƬ.jpg",0,""),
                new AssistiveDevice(105302401,"ä�Ľ̲�","��Ϣ����","959ä�Ľ̲�����ͼƬ.jpg",0,""),
                new AssistiveDevice(105302701,"�����ϰ����ö�ý��������","��Ϣ����","960�����ϰ����ö�ý������������ͼƬ.jpg",0,""),
                new AssistiveDevice(105302702,"�Ӿ��ϰ����ö�ý��������","��Ϣ����","961�Ӿ��ϰ����ö�ý������������ͼƬ.jpg",0,""),
                new AssistiveDevice(105330301,"����ʽ�����","��Ϣ����","962����ʽ���������ͼƬ.jpg",0,""),
                new AssistiveDevice(105330302,"ä�������������","��Ϣ����","963̨ʽ�����.jpg",0,""),
                new AssistiveDevice(105330601,"��Яʽ������͸�����������PDA��","��Ϣ����","964��Яʽ������͸�����������PDA��.jpg",0,""),
                new AssistiveDevice(105330901,"������Ϣ�������ն�","��Ϣ����","965������Ϣ�������ն�����ͼƬ.jpg",0,""),
                new AssistiveDevice(105331201,"�������","��Ϣ����","966�������.jpg",0,""),
                new AssistiveDevice(105331501,"����Ҷ�������","��Ϣ����","967����Ҷ�������.jpg",0,""),
                new AssistiveDevice(105331502,"�����׼���������","��Ϣ����","968�����׼���������.jpg",0,""),
                new AssistiveDevice(105331801,"�������ô��������","��Ϣ����","969�������ô�������̣���������.jpg",0,""),
                new AssistiveDevice(105331802,"�������","��Ϣ����","970�������.jpg",0,""),
                new AssistiveDevice(105331803,"�ֲ�����֧��","��Ϣ����","971�ֲ�����֧��.jpg",0,""),
                new AssistiveDevice(105360301,"ä���ü���","��Ϣ����","972ä���ü�������ͼƬ.jpg",0,""),
                new AssistiveDevice(105360302,"���ּ���","��Ϣ����","973���ּ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(105361201,"����ʽ�����û���","��Ϣ����","974����ʽ�����û�������ͼƬ.jpg",0,""),
                new AssistiveDevice(105361202,"����ʽ�����û���","��Ϣ����","975����ʽ�����û�������ͼƬ.jpg",0,""),
                new AssistiveDevice(105361203,"����ʽ�����û���","��Ϣ����","976����ʽ�����û�������ͼƬ.jpg",0,""),
                new AssistiveDevice(105361501,"�������","��Ϣ����","977�����������ͼƬ.jpg",0,""),
                new AssistiveDevice(105361801,"�������","��Ϣ����","978����������ͼƬ.jpg",0,""),
                new AssistiveDevice(105362101,"��켣�����","��Ϣ����","979��켣���������ͼƬ.jpg",0,""),
                new AssistiveDevice(105362102,"�ſ����","��Ϣ����","980�ſ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(105390401,"��Ļ�Ŵ���","��Ϣ����","981��Ļ�Ŵ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(105390501,"40 ��������","��Ϣ����","982 40������������ͼƬ.jpg",0,""),
                new AssistiveDevice(105390502,"80 ��������","��Ϣ����","983 80 ������������ͼƬ.jpg",0,""),
                new AssistiveDevice(105390601,"ä�Ĵ�ӡ��","��Ϣ����","984ä�Ĵ�ӡ������ͼƬ.jpg",0,""),
                new AssistiveDevice(105390701,"�����������ʾ��","��Ϣ����","985�����������ʾ������ͼƬ.jpg",0,""),
                new AssistiveDevice(105391201,"��궨λ����Ļ�Ŵ����","��Ϣ����","986��궨λ����Ļ�Ŵ��������ͼƬ.jpg",0,""),
                #endregion
                
                #region ����ѵ��
                new AssistiveDevice(10636,"֪��ѵ����������","����ѵ��"),
                new AssistiveDevice(10645,"����ǣ����������","����ѵ��"),
                new AssistiveDevice(10648,"�˶���������ƽ��ѵ�����豸","����ѵ��"),
                new AssistiveDevice(10703,"��ͨ���ƺ͹�ͨѵ����������","����ѵ��"),
                new AssistiveDevice(10706,"�����ǿ��ͨѵ����������","����ѵ��"),
                new AssistiveDevice(10709,"ʧ��ѵ����������","����ѵ��"),
                new AssistiveDevice(10712,"��֪����ѵ����������","����ѵ��"),
                new AssistiveDevice(10715,"��������ѵ����������","����ѵ��"),
                new AssistiveDevice(10718,"�����γ�ѵ����������","����ѵ��"),
                new AssistiveDevice(10724,"����ѵ����������","����ѵ��"),
                new AssistiveDevice(10727,"�罻����ѵ����������","����ѵ��"),
                new AssistiveDevice(10730,"����������������Ʒ�ͻ����ѵ�����Ƹ�������","����ѵ��"),
                new AssistiveDevice(10733,"�ճ�����ѵ���ĸ�������","����ѵ��"),

                new AssistiveDevice(1063603,"֪������֪��ƥ��ѵ����������","����ѵ��"),
                new AssistiveDevice(1063606,"֪��Э��ѵ����������","����ѵ��"),
                new AssistiveDevice(1063609,"�о�ͳ��ѵ����������","����ѵ��"),
                new AssistiveDevice(1064503,"��׵ǣ����","����ѵ��"),
                new AssistiveDevice(1064506,"��׵ǣ����","����ѵ��"),
                new AssistiveDevice(1064803,"ѵ���͹������г�","����ѵ��"),
                new AssistiveDevice(1064807,"����ѵ����������","����ѵ��"),
                new AssistiveDevice(1064808,"վ���ܺ�վ��֧��̨","����ѵ��"),
                new AssistiveDevice(1064812,"��ָ����ѵ����е","����ѵ��"),
                new AssistiveDevice(1064815,"��֫ѵ����е������ѵ����е����֫ѵ����е","����ѵ��"),
                new AssistiveDevice(1064818,"���ɻ���","����ѵ��"),
                new AssistiveDevice(1064821,"б��̨","����ѵ��"),
                new AssistiveDevice(1064824,"�˶���������ƽ��ѵ�������ﷴ������","����ѵ��"),
                new AssistiveDevice(1064827,"�����ڼ����嶨λ��������","����ѵ��"),
                new AssistiveDevice(1064830,"�ѵ������","����ѵ��"),
                new AssistiveDevice(1064831,"����ѵ����������","����ѵ��"),
                new AssistiveDevice(1070303,"���Ժ�����ѵ����������","����ѵ��"),
                new AssistiveDevice(1070306,"�Ķ����ܿ���ѵ������","����ѵ��"),
                new AssistiveDevice(1070309,"��д���ܿ���ѵ������","����ѵ��"),
                new AssistiveDevice(1070603,"��ָƴ��ѵ����������","����ѵ��"),
                new AssistiveDevice(1070606,"������ѵ����������","����ѵ��"),
                new AssistiveDevice(1070609,"����ѵ����������","����ѵ��"),
                new AssistiveDevice(1070612,"��ʾ����ѵ����������","����ѵ��"),
                new AssistiveDevice(1070615,"ä��ѵ����������","����ѵ��"),
                new AssistiveDevice(1070618,"��ä���������ɴ�������ѵ����������","����ѵ��"),
                new AssistiveDevice(1070621,"ͼ��ͷ���ѵ����������","����ѵ��"),
                new AssistiveDevice(1070624,"����˹���Թ�ͨѵ����������","����ѵ��"),
                new AssistiveDevice(1070627,"ͼƬ�ͻ滭��ͨѵ����������","����ѵ��"),
                new AssistiveDevice(1070630,"Ī��˹���빵ͨѵ����������","����ѵ��"),
                new AssistiveDevice(1070903,"ʧ��������","����ѵ��"),
                new AssistiveDevice(1071203,"����ѵ����������","����ѵ��"),
                new AssistiveDevice(1071206,"����ѵ����������","����ѵ��"),
                new AssistiveDevice(1071209,"ע����ѵ����������","����ѵ��"),
                new AssistiveDevice(1071212,"��������ѵ����������","����ѵ��"),
                new AssistiveDevice(1071215,"����ѵ����������","����ѵ��"),
                new AssistiveDevice(1071218,"ѵ���������ĸ�������","����ѵ��"),
                new AssistiveDevice(1071221,"���ɣ��������ѵ����������","����ѵ��"),
                new AssistiveDevice(1071224,"�����ϵ������⸨������","����ѵ��"),
                new AssistiveDevice(1071503,"���ڼ���ѵ����������","����ѵ��"),
                new AssistiveDevice(1071506,"����ͽ�����д���Ը�������","����ѵ��"),
                new AssistiveDevice(1071509,"ʱ�����ѵ����������","����ѵ��"),
                new AssistiveDevice(1071512,"�������ѵ����������","����ѵ��"),
                new AssistiveDevice(1071515,"���������ѵ����������","����ѵ��"),
                new AssistiveDevice(1071518,"�������μ���ѵ����������","����ѵ��"),
                new AssistiveDevice(1071803,"ĸ��ѵ����������","����ѵ��"),
                new AssistiveDevice(1071806,"����ѵ����������","����ѵ��"),
                new AssistiveDevice(1071809,"���Ŀ�ѧ�γ�ѵ����������","����ѵ��"),
                new AssistiveDevice(1071812,"����ѧ�γ�ѵ����������","����ѵ��"),
                new AssistiveDevice(1071815,"��ѧ������γ�ѵ����������","����ѵ��"),
                new AssistiveDevice(1072403,"���ּ���ѵ����������","����ѵ��"),
                new AssistiveDevice(1072406,"��ͼ�ͻ滭����ѵ����������","����ѵ��"),
                new AssistiveDevice(1072409,"Ϸ����赸ѵ����������","����ѵ��"),
                new AssistiveDevice(1072703,"�������ֻѵ����������","����ѵ��"),
                new AssistiveDevice(1072706,"�����Ϊѵ����������","����ѵ��"),
                new AssistiveDevice(1072709,"���˰�ȫѵ����������","����ѵ��"),
                new AssistiveDevice(1072712,"����ѵ����������","����ѵ��"),
                new AssistiveDevice(1073003,"������ѵ����������","����ѵ��"),
                new AssistiveDevice(1073006,"���ݸ˲���ѵ����������","����ѵ��"),
                new AssistiveDevice(1073009,"���ؿ���ѵ����������","����ѵ��"),
                new AssistiveDevice(1073012,"����ѵ����������","����ѵ��"),
                new AssistiveDevice(1073015,"ѡ����ѵ����������","����ѵ��"),
                new AssistiveDevice(1073303,"�������ͼ�֫ʹ��ѵ����������","����ѵ��"),
                new AssistiveDevice(1073306,"�����ճ��ѵ����������","����ѵ��"),
                new AssistiveDevice(1073312,"����ѵ����������","����ѵ��"),

                new AssistiveDevice(106360301,"����ѵ����","����ѵ��","1053����ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106360302,"��й������Э���������ѵ����","����ѵ��","1054��й������Э���������ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106360303,"��������","����ѵ��","1055������������ͼƬ.jpg",0,""),
                new AssistiveDevice(106360304,"��״���ѵ����","����ѵ��","1056��״���ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106360305,"���ѵ����","����ѵ��","1057���ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106360601,"����Э��������Ϸ���","����ѵ��","1058����Э��������Ϸ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(106360901,"���","����ѵ��","1059�������ͼƬ.jpg",0,""),
                new AssistiveDevice(106360902,"������","����ѵ��","1060����������ͼƬ.jpg",0,""),
                new AssistiveDevice(106360903,"������","����ѵ��","1061����������ͼƬ.jpg",0,""),
                new AssistiveDevice(106360904,"S ��ƽ��ľ","����ѵ��","1062S ��ƽ��ľ����ͼƬ.jpg",0,""),
                new AssistiveDevice(106360905,"�����","����ѵ��","1063���������ͼƬ.jpg",0,""),
                new AssistiveDevice(106360906,"ƽ��̨","����ѵ��","1064ƽ��̨����ͼƬ.jpg",0,""),
                new AssistiveDevice(106360907,"ԲͲ����","����ѵ��","1065ԲͲ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106360908,"Բľ�����","����ѵ��","1066Բľ���������ͼƬ.jpg",0,""),
                new AssistiveDevice(106360909,"�Ľǻζ�ƽ���","����ѵ��","1067�Ľǻζ�ƽ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(106360910,"�ζ�ƽ��ľ","����ѵ��","1068�ζ�ƽ��ľ����ͼƬ.jpg",0,""),
                new AssistiveDevice(106360911,"ſ������","����ѵ��","1069ſ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(106360912,"������","����ѵ��","1070����������ͼƬ.jpg",0,""),
                new AssistiveDevice(106360913,"����","����ѵ��","1071��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106450301,"��׵ǣ����","����ѵ��","1072��׵ǣ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106450601,"��׵ǣ����","����ѵ��","1073��׵ǣ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106480301,"��ʽ�������г�","����ѵ��","1074��ʽ�������г�����ͼƬ.jpg",0,""),
                new AssistiveDevice(106480302,"��ʽ�������г�","����ѵ��","1075��ʽ�������г�����ͼƬ.jpg",0,""),
                new AssistiveDevice(106480701,"���ز���ѵ����","����ѵ��","1076���ز���ѵ����.jpg",0,""),
                new AssistiveDevice(106480702,"����ѵ����ƽ�иܺ�����֧��̨","����ѵ��","1077����ѵ����ƽ�иܺ�����֧��̨����ͼƬ.jpg",0,""),
                new AssistiveDevice(106480703,"���н���","����ѵ��","1078���н�������ͼƬ.jpg",0,""),
                new AssistiveDevice(106480801,"��ͯ��ֱ��ʽվ����","����ѵ��","1079��ͯ��ֱ��ʽվ����.jpg",0,""),
                new AssistiveDevice(106480802,"��ͯ������ʽվ����","����ѵ��","1080��ͯ������ʽվ����.jpg",0,""),
                new AssistiveDevice(106480803,"��ͯ�ø���ʽվ����","����ѵ��","1081��ͯ�ø���ʽվ����.jpg",0,""),
                new AssistiveDevice(106480804,"������ֱ����վ����","����ѵ��","1082������ֱ��ʽվ����.jpg",0,""),
                new AssistiveDevice(106480805,"����������ʽվ����","����ѵ��","1083����������ʽվ����.jpg",0,""),
                new AssistiveDevice(106480806,"�����ø���ʽվ����","����ѵ��","1084�����ø���ʽվ����.jpg",0,""),
                new AssistiveDevice(106481201,"�ش�ʽ��ָ����ѵ����","����ѵ��","1085�ش�ʽ��ָ����ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481202,"��ָ��","����ѵ��","1086��ָ������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481501,"��֫�ۺ�ѵ����","����ѵ��","1087��֫�ۺ�ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481502,"��֫������","����ѵ��","1088��֫����������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481503,"ѵ����","����ѵ��","1089ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481504,"��֫�յ��˶�ѵ����","����ѵ��","1090��֫�յ��˶�ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481505,"��ؽ���תѵ����","����ѵ��","1091��ؽ���תѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481506,"ǰ���������˶���","����ѵ��","1092ǰ���������˶�������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481507,"��ؽ��˶���","����ѵ��","1093��ؽ��˶�������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481508,"��ؽ��˶���","����ѵ��","1094��ؽ��˶�������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481509,"��֫�ۺ�ѵ����","����ѵ��","1095��֫�ۺ�ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481510,"�׹ؽ�ѵ����","����ѵ��","1096�׹ؽ�ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481511,"ϥ�ؽ��˶���","����ѵ��","1097ϥ�ؽ��˶�������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481512,"�Źؽ��˶���","����ѵ��","1098�Źؽ��˶�������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481513,"�ۺϲ�̬ѵ����","����ѵ��","1099�ۺϲ�̬ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481514,"����ѵ����","����ѵ��","1100����ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481515,"����ȫ���˶�װ��","����ѵ��","1101����ȫ���˶�װ������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481516,"�����ش��˶���","����ѵ��","1102�����ش��˶�������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481517,"�����˶���","����ѵ��","1103�����˶�������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481518,"��ľ","����ѵ��","1104��ľ.jpg",0,""),
                new AssistiveDevice(106481519,"�ݱ���","����ѵ��","1105�ݱ���.jpg",0,""),
                new AssistiveDevice(106481520,"ѵ����","����ѵ��","1106ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106481801,"��ʽϵ��ɳ��","����ѵ��","1107��ʽϵ��ɳ������ͼƬ.jpg",0,""),
                new AssistiveDevice(106482101,"��ҡվ����","����ѵ��","1108��ҡվ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106482102,"�綯վ����","����ѵ��","1109�綯վ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106482401,"ƽ�⹦�ܼ��ѵ��ϵͳ","����ѵ��","1110ƽ�⹦�ܼ��ѵ��ϵͳ����ͼƬ.jpg",0,""),
                new AssistiveDevice(106482402,"������","����ѵ��","1111����������ͼƬ.jpg",0,""),
                new AssistiveDevice(106482701,"�ֶ�����̨","����ѵ��","1112�ֶ�����̨����ͼƬ.jpg",0,""),
                new AssistiveDevice(106483001,"�ѵ������","����ѵ��","1113�ѵ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(106483101,"��ͯ���м�","����ѵ��","1114��ͯ���м�.jpeg",0,""),
                new AssistiveDevice(107030301,"����ѵ����Ƭ","����ѵ��","1115����ѵ����Ƭ����ͼƬ.jpg",0,""),
                new AssistiveDevice(107030302,"�����ϰ�������","����ѵ��","1116�����ϰ�����������ͼƬ.jpg",0,""),
                new AssistiveDevice(107030303,"��������ѵ����","����ѵ��","1117��������ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(107030304,"��������ѵ����","����ѵ��","1118��������ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(107030601,"�Ķ����ܿ���ѵ������","����ѵ��","1119�Ķ����ܿ���ѵ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(107030901,"ѧǰ�˱���ϰ","����ѵ��","1120ѧǰ�˱���ϰ����ͼƬ.jpg",0,""),
                new AssistiveDevice(107030902,"�ֹ����ϰ����ձ��� * ","����ѵ��","1121�ֹ����ϰ����ձ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(107060301,"��ָ��ĸ��","����ѵ��","1122��ָ��ĸ������ͼƬ.jpg",0,""),
                new AssistiveDevice(107060302,"���й����","����ѵ��","1123���й��������ͼƬ.jpg",0,""),
                new AssistiveDevice(107060601,"������ѵ����������","����ѵ��","1124������ѵ��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(107060901,"����ͼƬ","����ѵ��","1125����ͼƬ����ͼƬ.jpg",0,""),
                new AssistiveDevice(107061201,"��ʾ����ѵ����������","����ѵ��","1126��ʾ����ѵ��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(107061501,"����ѧϰ��","����ѵ��","1127����ѧϰ������ͼƬ.jpg",0,""),
                new AssistiveDevice(107061801,"����ѵ���÷��ź�ͼ��","����ѵ��","1128����ѵ���÷��ź�ͼ������ͼƬ.jpg",0,""),
                new AssistiveDevice(107062101,"ͼ��ͷ���ѵ����������","����ѵ��","1129ͼ��ͷ���ѵ��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(107062401,"����˹���Թ�ͨѵ����������","����ѵ��","1130����˹���Թ�ͨѵ��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(107062701,"ͼƬ�ͻ滭��ͨѵ����������","����ѵ��","1131ͼƬ�ͻ滭��ͨѵ��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(107063001,"Ī��˹���������","����ѵ��","1132Ī��˹�������������ͼƬ.jpg",0,""),
                new AssistiveDevice(107063002,"����ʽĪ��˹���������","����ѵ��","1133����ʽĪ��˹�������������ͼƬ.jpg",0,""),
                new AssistiveDevice(107090301,"��ʧ��������","����ѵ��","1134��ʧ��������.jpg",0,""),
                new AssistiveDevice(107090302,"�ű�ʧ��������","����ѵ��","1135�ű�ʧ��������.png",0,""),
                new AssistiveDevice(107090303,"��С��ʧ��������","����ѵ��","1136��С��ʧ��������.jpg",0,""),
                new AssistiveDevice(107120301,"��֪����ѵ������","����ѵ��","1137��֪����ѵ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(107120302,"������Ϸ��","����ѵ��","1138������Ϸ������ͼƬ.jpg",0,""),
                new AssistiveDevice(107120601,"˳��ͼƬ","����ѵ��","1139˳��ͼƬ����ͼƬ.jpg",0,""),
                new AssistiveDevice(107120901,"�𳵻�ľ","����ѵ��","1140�𳵻�ľ.jpg",0,""),
                new AssistiveDevice(107120902,"��ͯͼ����֪���","����ѵ��","1141��ͯͼ����֪���.jpg",0,""),
                new AssistiveDevice(107120903,"��������","����ѵ��","1142��������.jpg",0,""),
                new AssistiveDevice(107120904,"���ݶԱȻ�ľ","����ѵ��","1143���ݶԱȻ�ľ.jpg",0,""),
                new AssistiveDevice(107120905,"̨ʽ��������","����ѵ��","1144̨ʽ��������.jpg",0,""),
                new AssistiveDevice(107120906,"������Ȧ","����ѵ��","1145������Ȧ.jpg",0,""),
                new AssistiveDevice(107120907,"��֪ƴװͼƬ","����ѵ��","1146��֪ƴװͼƬ.jpg",0,""),
                new AssistiveDevice(107120908,"�ձ����п�","����ѵ��","1147�ձ����п�.jpg",0,""),
                new AssistiveDevice(107120909,"��״��","����ѵ��","1148��״��.jpg",0,""),
                new AssistiveDevice(107120910,"��ľ��","����ѵ��","1149��ľ��.jpg",0,""),
                new AssistiveDevice(107120911,"�����װ�����","����ѵ��","1150�����װ�����.jpg",0,""),
                new AssistiveDevice(107120912,"���β��","����ѵ��","1151���β��.jpg",0,""),
                new AssistiveDevice(107120913,"�ʺ�����","����ѵ��","1152�ʺ�����.jpg",0,""),
                new AssistiveDevice(107120914,"˫�����������","����ѵ��","1153˫�����������.jpg",0,""),
                new AssistiveDevice(107120915,"1+1�����","����ѵ��","1154 1+1�����.jpg",0,""),
                new AssistiveDevice(107120916,"���������","����ѵ��","1155���������.jpg",0,""),
                new AssistiveDevice(107120917,"�����ҿ����ﲻһ����ɫ��Ƭ��","����ѵ��","1156�����ҿ����ﲻһ����ɫ��Ƭ������ͼƬ.jpg",0,""),
                new AssistiveDevice(107121201,"�����״��","����ѵ��","1157�����״������ͼƬ.jpg",0,""),
                new AssistiveDevice(107121501,"��״����ɫ���࿨Ƭ","����ѵ��","1158��״����ɫ���࿨Ƭ����ͼƬ.jpg",0,""),
                new AssistiveDevice(107121801,"��������ľ","����ѵ��","1159��������ľ����ͼƬ.jpg",0,""),
                new AssistiveDevice(107121802,"����������ͼƬ","����ѵ��","1160����������ͼƬ����ͼƬ.jpg",0,""),
                new AssistiveDevice(107122101,"����","����ѵ��","1161��������ͼƬ.jpg",0,""),
                new AssistiveDevice(107122102,"����ͼƬ��","����ѵ��","1162����ͼƬ������ͼƬ.jpg",0,""),
                new AssistiveDevice(107122401,"�����ϵͼ��","����ѵ��","1163�����ϵͼ������ͼƬ.jpg",0,""),
                new AssistiveDevice(107150301,"ѧϰ��ѧƴͼ�桢����ѧ�����г���Ϸ�����","����ѵ��","1164ѧϰ��ѧƴͼ�桶��ѧ�����г���Ϸ���������ͼƬ.jpg",0,""),
                new AssistiveDevice(107150601,"ľ�ƴ�������ĸ��","����ѵ��","1165ľ�ƴ�������ĸ������ͼƬ.jpg",0,""),
                new AssistiveDevice(107150901,"��ľʱ��ƴͼ��","����ѵ��","1166��ľʱ��ƴͼ������ͼƬ.jpg",0,""),
                new AssistiveDevice(107150902,"ʱ�似��ѵ������","����ѵ��","1167ʱ�似��ѵ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(107151201,"Ǯ��ֽ�����","����ѵ��","1168Ǯ��ֽ���������ͼƬ.jpg",0,""),
                new AssistiveDevice(107151501,"ä�õ��ֳ߼����������","����ѵ��","1169ä�õ��ֳ߼��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(107151801,"����ͼ����Կ�Ƭ","����ѵ��","1170����ͼ����Կ�Ƭ����ͼƬ.jpg",0,""),
                new AssistiveDevice(107180301,"���к���ƴ���ͺ��ֵ�����Сͼ��","����ѵ��","1171���к���ƴ���ͺ��ֵ�����Сͼ������ͼƬ.jpg",0,""),
                new AssistiveDevice(107180601,"��ĸ��ͼ��","����ѵ��","1172��ĸ��ͼ������ͼƬ.jpg",0,""),
                new AssistiveDevice(107180901,"�����Ľ������顷","����ѵ��","1173�����Ľ������顷����ͼƬ.jpg",0,""),
                new AssistiveDevice(107181201,"����ѧ�γ�ѵ����������","����ѵ��","1174����ѧ�γ�ѵ��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(107181501,"����ѧ���ɡ���Сѧ���꼶��","����ѵ��","1175����ѧ���ɡ���Сѧ���꼶������ͼƬ.jpg",0,""),
                new AssistiveDevice(107240301,"�о������������","����ѵ��","1176�о����������������ͼƬ.jpg",0,""),
                new AssistiveDevice(107240601,"����ͯѧ����ȫ��","����ѵ��","1177����ͯѧ����ȫ������ͼƬ.jpg",0,""),
                new AssistiveDevice(107240901,"Ϸ����赸ѵ����������","����ѵ��","1178Ϸ����赸ѵ��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(107270301,"��ʽ����ѵ���̾�","����ѵ��","1179��ʽ����ѵ���̾�����ͼƬ.jpg",0,""),
                new AssistiveDevice(107270601,"�����Ϊѵ����������","����ѵ��","1180�����Ϊѵ��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(107270901,"���˰�ȫѵ����������","����ѵ��","1181���˰�ȫѵ��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(107271201,"�л����񹲺͹�������ͼ","����ѵ��","1182�л����񹲺͹�������ͼ����ͼƬ.jpg",0,""),
                new AssistiveDevice(107300301,"�����ϰ������ѵ����","����ѵ��","1183�����ϰ������ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(107300601,"���ݸ���Ϸ���","����ѵ��","1184���ݸ���Ϸ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(107300901,"ѵ�����ƿ��ص����","����ѵ��","1185ѵ�����ƿ��ص��������ͼƬ.jpg",0,""),
                new AssistiveDevice(107301201,"�Ӿ��ϰ��ߺ������ϰ��ߴ���ѵ������","����ѵ��","1186�Ӿ��ϰ��ߺ������ϰ��ߴ���ѵ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(107301202,"֫���ϰ�����ָ����ָ������","����ѵ��","1187֫���ϰ�����ָ����ָ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(107301501,"��ͼѡ��ѵ�����","����ѵ��","1188��ͼѡ��ѵ���������ͼƬ.jpg",0,""),
                new AssistiveDevice(107330301,"�������ͼ�֫ʹ��ѵ����������","����ѵ��","1189�������ͼ�֫ʹ��ѵ��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(107330601,"�����Ӽ�","����ѵ��","1190�����Ӽ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(107330602,"����Ь����","����ѵ��","1191����Ь��������ͼƬ.jpg",0,""),
                new AssistiveDevice(107330603,"����ˢ����","����ѵ��","1192����ˢ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(107330604,"ѵ��šʪë����","����ѵ��","1193ѵ��šʪë��������ͼƬ.jpg",0,""),
                new AssistiveDevice(107331201,"�����þ�ʹ��ѵ������","����ѵ��","1201�����þ�ʹ��ѵ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(107331202,"��ʳ�þ�ʹ��ѵ������","����ѵ��","1202��ʳ�þ�ʹ��ѵ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(107331203,"��ɨ�þ�ʹ��ѵ������","����ѵ��","1203��ɨ�þ�ʹ��ѵ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(107331204,"��ͥ����ʹ��ѵ������","����ѵ��","1204��ͥ����ʹ��ѵ����������ͼƬ.jpg",0,""),
                #endregion
                
                #region ��������
                new AssistiveDevice(10603,"������������","��������"),
                new AssistiveDevice(10606,"ѭ�����Ƹ�������","��������"),
                new AssistiveDevice(10607,"Ԥ�����γɵĸ�������","��������"),
                new AssistiveDevice(10608,"������ƺʹٽ�ѪҺѭ����ѹ����","��������"),
                new AssistiveDevice(10609,"���Ƹ�������","��������"),
                new AssistiveDevice(10624,"���塢�������������豸������","��������"),
                new AssistiveDevice(10625,"��֪���Ժ���������","��������"),
                new AssistiveDevice(10627,"�̼���","��������"),
                new AssistiveDevice(10630,"���ƻ����Ƹ�������","��������"),
                new AssistiveDevice(10633,"������֯�����Եĸ�������","��������"),

                new AssistiveDevice(1060303,"���������Ԥ������","��������"),
                new AssistiveDevice(1060306,"������","��������"),
                new AssistiveDevice(1060312,"������","��������"),
                new AssistiveDevice(1060318,"������","��������"),
                new AssistiveDevice(1060321,"������","��������"),
                new AssistiveDevice(1060327,"������ѵ����","��������"),
                new AssistiveDevice(1060330,"����������","��������"),
                new AssistiveDevice(1060606,"������֫����֫������������λ�Ŀ�ˮ������","��������"),
                new AssistiveDevice(1060609,"����ѪҺѭ���ϰ��ĳ������ͼ�ѹװ��","��������"),
                new AssistiveDevice(1060703,"��ճ�Թ轺Ƭ","��������"),
                new AssistiveDevice(1060706,"������","��������"),
                new AssistiveDevice(1060803,"����������","��������"),
                new AssistiveDevice(1060903,"������A �Σ�UVA����","��������"),
                new AssistiveDevice(1060906,"��ѡ�������߹��Ʒ���SUP����������B �Σ�UVB����","��������"),
                new AssistiveDevice(1060909,"���ƻ�Ŀ��","��������"),
                new AssistiveDevice(1062409,"Ѫѹ��","��������"),
                new AssistiveDevice(1062412,"ѪҺ������е���豸�Ͳ���","��������"),
                new AssistiveDevice(1062418,"����������۲���","��������"),
                new AssistiveDevice(1062421,"����������������ԵĲ�����������","��������"),
                new AssistiveDevice(1062424,"���¼�","��������"),
                new AssistiveDevice(1062427,"���س�","��������"),
                new AssistiveDevice(1062430,"����Ƥ��״���ĸ�������","��������"),
                new AssistiveDevice(1062503,"���Բ��Ժ���������","��������"),
                new AssistiveDevice(1062506,"������Ժ���������","��������"),
                new AssistiveDevice(1062509,"�����������Ժ���������","��������"),
                new AssistiveDevice(1062706,"��ʹ�̼���","��������"),
                new AssistiveDevice(1062709,"����̼���( ������������)","��������"),
                new AssistiveDevice(1062712,"����","��������"),
                new AssistiveDevice(1062715,"�����̼���","��������"),
                new AssistiveDevice(1062718,"�̼��о��������ȵĸ�������","��������"),
                new AssistiveDevice(1062721,"�̼�ϸ�������ĸ�������","��������"),
                new AssistiveDevice(1063003,"���Ƹ�������","��������"),
                new AssistiveDevice(1063006,"���Ƹ�������","��������"),
                new AssistiveDevice(1063303,"������֯�����Ե�����ͳĵ�","��������"),
                new AssistiveDevice(1063304,"������֯�����ԵĿ������С������","��������"),
                new AssistiveDevice(1063306,"������֯�����Ե����Ը�������","��������"),
                new AssistiveDevice(1063309,"������֯�����Ե������豸","��������"),

                new AssistiveDevice(106030301,"Ԥ����������װ��","��������","987Ԥ����������װ������ͼƬ.jpg",0,""),
                new AssistiveDevice(106030601,"��������","��������","988������������ͼƬ.jpg",0,""),
                new AssistiveDevice(106030602,"��ҩ��������","��������","989��ҩ������������ͼƬ.jpg",0,""),
                new AssistiveDevice(106030603,"һ������������","��������","990һ����������������ͼƬ.jpg",0,""),
                new AssistiveDevice(106031201,"���̺�����","��������","991���̺���������ͼƬ.jpg",0,""),
                new AssistiveDevice(106031801,"��������ƿ","��������","992��������ƿ����ͼƬ.jpg",0,""),
                new AssistiveDevice(106031802,"��Яʽ������","��������","993��Яʽ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(106031803,"��������","��������","994������������ͼƬ.jpg",0,""),
                new AssistiveDevice(106032101,"�綯��̵��","��������","995�綯��̵������ͼƬ.jpg",0,""),
                new AssistiveDevice(106032102,"�ֶ���̵��","��������","996�ֶ���̵������ͼƬ.jpg",0,""),
                new AssistiveDevice(106032103,"��̤��̵��","��������","997��̤��̵������ͼƬ.jpg",0,""),
                new AssistiveDevice(106032701,"�ֳ�ʽ������ѵ����","��������","998�ֳ�ʽ������ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106032702,"��������ѵ����","��������","999��������ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106032703,"��������ѵ����","��������","1000��������ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106032704,"�շ�����ѵ����","��������","1001�շ�����ѵ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106033001,"�λ������Ӳ�����","��������","1002�λ������Ӳ���������ͼƬ.jpg",0,""),
                new AssistiveDevice(106060601,"��ˮ������","��������","1003��ˮ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(106060901,"����ѹ����","��������","1004����ѹ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106070301,"��ճ�Թ轺Ƭ","��������","1005��ճ�Թ轺Ƭ����ͼƬ.jpg",0,""),
                new AssistiveDevice(106070601,"������","��������","1006����������ͼƬ.jpg",0,""),
                new AssistiveDevice(106080301,"С�Ⱦ���������","��������","1007С�Ⱦ�������������ͼƬ.jpg",0,""),
                new AssistiveDevice(106080302,"���Ⱦ���������","��������","1008���Ⱦ�������������ͼƬ.jpg",0,""),
                new AssistiveDevice(106090301,"������A �ε�315nm��","��������","1009������A �ε�315nm����ͼƬ.jpg",0,""),
                new AssistiveDevice(106090302,"������A �ε�340nm","��������","1010������A �ε�340nm����ͼƬ.jpg",0,""),
                new AssistiveDevice(106090303,"������A �ε�365nm","��������","1011������A �ε�365nm����ͼƬ.jpg",0,""),
                new AssistiveDevice(106090304,"������A �ε�385nm","��������","1012������A �ε�385nm����ͼƬ.jpg",0,""),
                new AssistiveDevice(106090305,"������A �ε�400nm","��������","1013������A �ε�400nm����ͼƬ.jpg",0,""),
                new AssistiveDevice(106090601,"������B �ε�280nm","��������","1014������B �ε�280nm����ͼƬ.jpg",0,""),
                new AssistiveDevice(106090901,"UV ��Ŀ��","��������","1015UV ��Ŀ������ͼƬ.jpg",0,""),
                new AssistiveDevice(106240901,"��������Ѫѹ��","��������","1016��������Ѫѹ������ͼƬ.jpg",0,""),
                new AssistiveDevice(106241201,"Ѫ����","��������","1017Ѫ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106241801,"�ּ���������","��������","1018�ּ�������������ͼƬ.jpg",0,""),
                new AssistiveDevice(106242101,"����������������ԵĲ�����������","��������","1019����������������ԵĲ���������������ͼƬ.jpg",0,""),
                new AssistiveDevice(106242401,"�������¼�","��������","1020�������¼�����ͼƬ.jpg",0,""),
                new AssistiveDevice(106242701,"�������س�","��������","1021�������س�����ͼƬ.jpg",0,""),
                new AssistiveDevice(106243001,"����Ƥ��״���ĸ�������","��������","1022����Ƥ��״���ĸ�����������ͼƬ.jpg",0,""),
                new AssistiveDevice(106250301,"ʧ��֢���������������ϵͳ��� * ","��������","1023ʧ��֢���������������ϵͳ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(106250601,"����ҽѧ�������ϵͳ���","��������","1024����ҽѧ�������ϵͳ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(106250901,"Τ����������","��������","1025Τ��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(106270601,"�����͵�Ƶ�̼��ǣ���ʹ��","��������","1026�����͵�Ƶ�̼��ǣ���ʹ������ͼƬ.jpg",0,""),
                new AssistiveDevice(106270901,"����̼���","��������","1027����̼�������ͼƬ.jpg",0,""),
                new AssistiveDevice(106271201,"����̵��","��������","1028����̵������ͼƬ.jpg",0,""),
                new AssistiveDevice(106271501,"�����̼���","��������","1029�����̼�������ͼƬ.jpg",0,""),
                new AssistiveDevice(106271801,"�̼��о��������ȵĸ�������","��������","1030�̼��о��������ȵĸ�����������ͼƬ.jpg",0,""),
                new AssistiveDevice(106272101,"�̼�ϸ�������ĸ�������","��������","1031�̼�ϸ�������ĸ�����������ͼƬ.jpg",0,""),
                new AssistiveDevice(106300301,"�����ߵ�","��������","1032�����ߵ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(106300601,"������̼����������","��������","1033������̼��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(106300602,"����","��������","1034��������ͼƬ.jpg",0,""),
                new AssistiveDevice(106330301,"��ͨ�����ѹ������","��������","1035��ͨ�����ѹ������.png",0,""),
                new AssistiveDevice(106330302,"���ص������ѹ������","��������","1036���ص������ѹ������.png",0,""),
                new AssistiveDevice(106330303,"Һ��������ѹ������","��������","1037Һ��������ѹ������.jpg",0,""),
                new AssistiveDevice(106330304,"����������ѹ������","��������","1038����������ѹ������.png",0,""),
                new AssistiveDevice(106330305,"���ϳ�����ѹ������","��������","1039���Ϸ�ѹ������.jpg",0,""),
                new AssistiveDevice(106330306,"�𽺳�����ѹ������","��������","1040�𽺳�����ѹ������.jpg",0,""),
                new AssistiveDevice(106330307,"�������ิ�Ϸ�ѹ������","��������","1041�������ิ�Ϸ�ѹ������.jpg",0,""),
                new AssistiveDevice(106330308,"�����ҷ�ѹ������","��������","1042�����ҷ�ѹ������.jpg",0,""),
                new AssistiveDevice(106330401,"��λ�任��ϵ�","��������","1043��λʽ��ϵ�.jpg",0,""),
                new AssistiveDevice(106330402,"Ш�ε�","��������","1044Ш�ε�.jpg",0,""),
                new AssistiveDevice(106330601,"�ֶ�PVC������ѹ������","��������","1045�ֶ�PVC������ѹ������.jpg",0,""),
                new AssistiveDevice(106330602,"�綯PVC������ѹ������","��������","1046�綯PVC������ѹ������.jpg",0,""),
                new AssistiveDevice(106330603,"���亣���ѹ������","��������","1047���亣���ѹ������.jpg",0,""),
                new AssistiveDevice(106330604,"�ֶ��𽺳�����ѹ������","��������","1048�ֶ��𽺳�����ѹ������.jpg",0,""),
                new AssistiveDevice(106330605,"�綯�𽺳�����ѹ������","��������","1049�綯�𽺳�����ѹ������.jpg",0,""),
                new AssistiveDevice(106330606,"�������ิ�Ϸ�ѹ������","��������","1050������ѹ������.jpg",0,""),
                new AssistiveDevice(106330901,"ѹ����������","��������","1051ѹ��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(106330902,"���촯��������","��������","1052���촯������������ͼƬ.jpg",0,""),
                #endregion
                
                #region ���ϰ�����
                new AssistiveDevice(10420,"���ϰ�����","���ϰ�����"),
                new AssistiveDevice(10433,"��ͥ�����������İ�ȫ��ʩ","���ϰ�����"),
                new AssistiveDevice(10903,"���ƻ�����������","���ϰ�����"),

                new AssistiveDevice(1042001,"���ϰ�����","���ϰ�����"),
                new AssistiveDevice(1043315,"�����ô��в���","���ϰ�����"),
                new AssistiveDevice(1090309,"���������ĸ�������","���ϰ�����"),
                new AssistiveDevice(1090312,"��С�񶯵ĸ�������","���ϰ�����"),
                new AssistiveDevice(1090315,"�������Ƹ�������","���ϰ�����"),
                new AssistiveDevice(1090318,"ˮ������������","���ϰ�����"),

                new AssistiveDevice(104200101,"�ŵĸ���","���ϰ�����","777�ŵĸ���.jpg",0,""),
                new AssistiveDevice(104200102,"���������","���ϰ�����","778���������.jpg",0,""),
                new AssistiveDevice(104331501,"����ä��ש","���ϰ�����","795����ä��ש����ͼƬ.jpg",0,""),
                new AssistiveDevice(104331502,"ת�Ƿ�����","���ϰ�����","796ת�Ƿ���������ͼƬ.jpg",0,""),
                new AssistiveDevice(104331503,"ǽ�ڷ�����","���ϰ�����","797ǽ�ڷ���������ͼƬ.jpg",0,""),
                new AssistiveDevice(109030901,"����������","���ϰ�����","1252��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(109030902,"�������հ�","���ϰ�����","1253�������հ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(109030903,"������","���ϰ�����","1254����������ͼƬ.jpg",0,""),
                new AssistiveDevice(109031201,"������","���ϰ�����","1255����������ͼƬ.jpg",0,""),
                new AssistiveDevice(109031202,"�����","���ϰ�����","1256���������ͼƬ.jpg",0,""),
                new AssistiveDevice(109031501,"�������Ƹ�������","���ϰ�����","1257�������Ƹ�����������ͼƬ.jpg",0,""),
                new AssistiveDevice(109031801,"ˮ������","���ϰ�����","1258ˮ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(109031802,"ˮ����","���ϰ�����","1259ˮ��������ͼƬ.jpg",0,""),
                #endregion

                #region ������ʹ��
                new AssistiveDevice(10806,"���������ĸ�������","������ʹ��"),
                new AssistiveDevice(10809,"�ٿ��豸�ĸ�������","������ʹ��"),
                new AssistiveDevice(10813,"Զ�̿��Ƹ�������","������ʹ��"),
                new AssistiveDevice(10818,"Э�������ۡ��ֻ���ָ���ܻ�������Ϲ��ܵĸ�������","������ʹ��"),
                new AssistiveDevice(10821,"����ȡ�︨������","������ʹ��"),
                new AssistiveDevice(10824,"��λ��������","������ʹ��"),
                new AssistiveDevice(10827,"�̶��ø�������","������ʹ��"),
                new AssistiveDevice(10836,"���˺����丨������","������ʹ��"),
                new AssistiveDevice(11103,"���������ļҾߺ�װ��Ԫ��","������ʹ��"),
                new AssistiveDevice(11112,"���������̶���̽ȡ��ץ����Ʒ�ĸ�������","������ʹ��"),
                new AssistiveDevice(11124,"�����������������Ͱ�ȫ�ĸ�������","������ʹ��"),
                new AssistiveDevice(11203,"��ˣ��������","������ʹ��"),
                new AssistiveDevice(11209,"�˶���������","������ʹ��"),
                new AssistiveDevice(11218,"�ֹ����չ��ߡ����Ϻ��豸","������ʹ��"),

                new AssistiveDevice(1080603,"������","������ʹ��"),
                new AssistiveDevice(1080606,"������","������ʹ��"),
                new AssistiveDevice(1080903,"��ť","������ʹ��"),
                new AssistiveDevice(1080906,"�̶����ֺ͹̶������ֱ�","������ʹ��"),
                new AssistiveDevice(1080909,"��ת���ֺ���ת�����ֱ�","������ʹ��"),
                new AssistiveDevice(1080912,"��̤�壨��е��","������ʹ��"),
                new AssistiveDevice(1080915,"���ֺ���������","������ʹ��"),
                new AssistiveDevice(1080918,"��������","������ʹ��"),
                new AssistiveDevice(1080924,"�����","������ʹ��"),
                new AssistiveDevice(1080928,"�ɵ���Դ","������ʹ��"),
                new AssistiveDevice(1080930,"��ʱ����","������ʹ��"),
                new AssistiveDevice(1081303,"��������ϵͳ","������ʹ��"),
                new AssistiveDevice(1081306,"���˻����������","������ʹ��"),
                new AssistiveDevice(1081803,"ץ��װ��","������ʹ��"),
                new AssistiveDevice(1081806,"�ճ�������͸���","������ʹ��"),
                new AssistiveDevice(1081809,"����ʽץ����","������ʹ��"),
                new AssistiveDevice(1081812,"��Ʒ�ȶ���","������ʹ��"),
                new AssistiveDevice(1081815,"���ݸ�","������ʹ��"),
                new AssistiveDevice(1081818,"ָ���","������ʹ��"),
                new AssistiveDevice(1081821,"��ֽ��","������ʹ��"),
                new AssistiveDevice(1081824,"�ָ�гּ�","������ʹ��"),
                new AssistiveDevice(1081827,"�ֹ���õ�ǰ��֧����","������ʹ��"),
                new AssistiveDevice(1081828,"������","������ʹ��"),
                new AssistiveDevice(1082103,"�ֶ�ץȡǯ","������ʹ��"),
                new AssistiveDevice(1082109,"��ץ�չ��ܵ�������","������ʹ��"),
                new AssistiveDevice(1082403,"�̶�λ��ϵͳ","������ʹ��"),
                new AssistiveDevice(1082406,"ת���ͻ���ϵͳ","������ʹ��"),
                new AssistiveDevice(1082409,"��������бϵͳ","������ʹ��"),
                new AssistiveDevice(1082703,"����","������ʹ��"),
                new AssistiveDevice(1082706,"������","������ʹ��"),
                new AssistiveDevice(1082712,"���Ӻ͵��ɼ�","������ʹ��"),
                new AssistiveDevice(1082718,"�����������ʹż�","������ʹ��"),
                new AssistiveDevice(1083603,"���˸�������","������ʹ��"),
                new AssistiveDevice(1083606,"����װ��","������ʹ��"),
                new AssistiveDevice(1083609,"����͹����Ƴ�","������ʹ��"),
                new AssistiveDevice(1083615,"�����г�������һ��ʹ�õ����丨������","������ʹ��"),
                new AssistiveDevice(1110303,"������","������ʹ��"),
                new AssistiveDevice(1110306,"��ҵ̨","������ʹ��"),
                new AssistiveDevice(1110312,"���������ø߽ŵʺ�վ����������","������ʹ��"),
                new AssistiveDevice(1110318,"���������õ���","������ʹ��"),
                new AssistiveDevice(1111203,"���ͺͼгֹ����͹��ߵĸ�������","������ʹ��"),
                new AssistiveDevice(1111206,"�̶��Ͷ�λ�����͹��ߵĸ�������","������ʹ��"),
                new AssistiveDevice(1112403,"�����������˷����豸","������ʹ��"),
                new AssistiveDevice(1112418,"����������������Χ����İ�ȫ�豸","������ʹ��"),
                new AssistiveDevice(1120303,"���","������ʹ��"),
                new AssistiveDevice(1120309,"��Ϸ�þ�","������ʹ��"),
                new AssistiveDevice(1120903,"�Ŷ������˶���������","������ʹ��"),
                new AssistiveDevice(1120906,"������������","������ʹ��"),
                new AssistiveDevice(1120909,"������������","������ʹ��"),
                new AssistiveDevice(1120912,"������������","������ʹ��"),
                new AssistiveDevice(1120918,"������������","������ʹ��"),
                new AssistiveDevice(1120927,"���ĺ�������˶���������","������ʹ��"),
                new AssistiveDevice(1120930,"�����������","������ʹ��"),
                new AssistiveDevice(1120933,"��Ӿ��ˮ���˶���������","������ʹ��"),
                new AssistiveDevice(1120936,"�����˶���������","������ʹ��"),
                new AssistiveDevice(1120939,"�����˶���������","������ʹ��"),
                new AssistiveDevice(1121803,"��֯�ֹ��չ��ߡ����Ϻ��豸","������ʹ��"),
                new AssistiveDevice(1121806,"���չ��չ��ߡ����Ϻ��豸","������ʹ��"),
                new AssistiveDevice(1121809,"ľ�����չ��ߡ����Ϻ��豸","������ʹ��"),
                new AssistiveDevice(1121812,"�����ӹ����ߡ����Ϻ��豸","������ʹ��"),
                new AssistiveDevice(1121815,"ͼ����ƹ��ߡ����Ϻ��豸","������ʹ��"),
                new AssistiveDevice(1121818,"�������ϵ��ֹ����յĹ��ߡ����Ϻ��豸","������ʹ��"),

                new AssistiveDevice(108060301,"��ƿ��","������ʹ��","1205��ƿ��.png",0,""),
                new AssistiveDevice(108060601,"�Զ����༷ѹ��","������ʹ��","1206�Զ����༷ѹ��.jpg",0,""),
                new AssistiveDevice(108090301,"��ťʽˮ��ͷ","������ʹ��","1207��ťʽˮ��ͷ����ͼƬ.jpg",0,""),
                new AssistiveDevice(108090601,"���Ϲ̶�����","������ʹ��","1208���Ϲ̶���������ͼƬ.jpg",0,""),
                new AssistiveDevice(108090602,"���������ֱ�","������ʹ��","1209���������ֱ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(108090901,"L���Ű���","������ʹ��","1210L���Ű���.jpg",0,""),
                new AssistiveDevice(108090902,"���ܰ���","������ʹ��","1211���ܰ���.jpg",0,""),
                new AssistiveDevice(108091201,"�������г���̤��","������ʹ��","1212�������г���̤������ͼƬ.jpg",0,""),
                new AssistiveDevice(108091202,"��̤����","������ʹ��","1213��̤��������ͼƬ.jpg",0,""),
                new AssistiveDevice(108091501,"���ֺ���������","������ʹ��","1214���ֺ�������������ͼƬ.jpg",0,""),
                new AssistiveDevice(108091801,"������ʱ����","������ʹ��","1215������ʱ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(108091802,"�ۿؿ���","������ʹ��","1216�ۿؿ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(108092401,"�����","������ʹ��","1217���������ͼƬ.jpg",0,""),
                new AssistiveDevice(108092801,"�ɵ���Դ","������ʹ��","1218�ɵ���Դ����ͼƬ.jpg",0,""),
                new AssistiveDevice(108093001,"�����Ѷ�ʱ��","������ʹ��","1219�����Ѷ�ʱ������ͼƬ.jpg",0,""),
                new AssistiveDevice(108130301,"�źž�ʾϵͳ","������ʹ��","1220�źž�ʾϵͳ����ͼƬ.jpg",0,""),
                new AssistiveDevice(108130302,"��������װ��","������ʹ��","1221��������װ������ͼƬ.jpg",0,""),
                new AssistiveDevice(108130601,"��������װ�ó���","������ʹ��","1222��������װ�ó�������ͼƬ.jpg",0,""),
                new AssistiveDevice(108180301,"�������","������ʹ��","1223�������.png",0,""),
                new AssistiveDevice(108180601,"ִ�ʸ�����","������ʹ��","1224ִ�ʸ�����.jpg",0,""),
                new AssistiveDevice(108180602,"���ճ���","������ʹ��","1225���ճ���.jpg",0,""),
                new AssistiveDevice(108180901,"�绰��Ͳץ����","������ʹ��","1226�绰��Ͳץ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(108181201,"�����ȶ���","������ʹ��","1227�����ȶ���.png",0,""),
                new AssistiveDevice(108181202,"ä���ú�װ��ͷ��","������ʹ��","1228ä���ú�װ��ͷ��.jpg",0,""),
                new AssistiveDevice(108181203,"�������","������ʹ��","1229�������.jpg",0,""),
                new AssistiveDevice(108181204,"����ʽ����","������ʹ��","1230����.JPG",0,""),
                new AssistiveDevice(108181501,"ͷ�����Ƹ�","������ʹ��","1231ͷ�����Ƹ�.png",0,""),
                new AssistiveDevice(108181502,"�ں���","������ʹ��","1232�ں���.jpg",0,""),
                new AssistiveDevice(108181801,"ͷ��ָ���","������ʹ��","1233ͷ��ָ���.jpg",0,""),
                new AssistiveDevice(108182101,"��ֽ��","������ʹ��","1234��ֽ������ͼƬ.jpg",0,""),
                new AssistiveDevice(108182401,"�ĸ�̶���","������ʹ��","1235�ĸ�̶�������ͼƬ.jpg",0,""),
                new AssistiveDevice(108182701,"ǰ��֧�ż�","������ʹ��","1236ǰ��֧�ż�.jpg",0,""),
                new AssistiveDevice(108182801,"�����ɼ���","������ʹ��","1237�����ɼ���.jpg",0,""),
                new AssistiveDevice(108210301,"�۵�ʽ����ȡ����","������ʹ��","1238�۵�ʽ����ȡ����.jpg",0,""),
                new AssistiveDevice(108210302,"���۵�ʽ����ȡ����","������ʹ��","1239���۵�ʽ����ȡ����.png",0,""),
                new AssistiveDevice(108210901,"��ץ�չ��ܵ�������","������ʹ��","1240��ץ�չ��ܵ�����������ͼƬ.jpg",0,""),
                new AssistiveDevice(108240301,"�̶�λ��ϵͳ","������ʹ��","1241�̶�λ��ϵͳ����ͼƬ.jpg",0,""),
                new AssistiveDevice(108240601,"ת���ͻ���ϵͳ","������ʹ��","1242ת���ͻ���ϵͳ����ͼƬ.jpg",0,""),
                new AssistiveDevice(108240901,"��������бϵͳ","������ʹ��","1243��������бϵͳ����ͼƬ.jpg",0,""),
                new AssistiveDevice(108270301,"����","������ʹ��","1244��������ͼƬ.jpg",0,""),
                new AssistiveDevice(108270601,"������","������ʹ��","1245����������ͼƬ.jpg",0,""),
                new AssistiveDevice(108271201,"���Ӻ͵��ɼ�","������ʹ��","1246���Ӻ͵��ɼ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(108271801,"������","������ʹ��","1247����������ͼƬ.jpg",0,""),
                new AssistiveDevice(108360301,"���˸�������","������ʹ��","1248���˸�����������ͼƬ.jpg",0,""),
                new AssistiveDevice(108360601,"����װ��","������ʹ��","1249����װ������ͼƬ.jpg",0,""),
                new AssistiveDevice(108360901,"����͹����Ƴ�","������ʹ��","1250����͹����Ƴ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(108361501,"���γ�����","������ʹ��","1251���γ���������ͼƬ.jpg",0,""),
                new AssistiveDevice(111030301,"������","������ʹ��","1312����������ͼƬ.jpg",0,""),
                new AssistiveDevice(111030601,"��ҵ̨","������ʹ��","1313��ҵ̨����ͼƬ.jpg",0,""),
                new AssistiveDevice(111031201,"����","������ʹ��","1314��������ͼƬ.jpg",0,""),
                new AssistiveDevice(111031202,"վ����","������ʹ��","1315վ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(111031801,"���������õ���","������ʹ��","1316���������õ�������ͼƬ.jpg",0,""),
                new AssistiveDevice(111120301,"�ֳ�ʽ����","������ʹ��","1317�ֳ�ʽ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(111120302,"ץ��ʽ����","������ʹ��","1318ץ��ʽ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(111120601,"���ɼ�","������ʹ��","1319���ɼ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(111120602,"����̨�÷�����","������ʹ��","1320����̨�÷���������ͼƬ.jpg",0,""),
                new AssistiveDevice(111120603,"�����ӵ���ת��","������ʹ��","1321�����ӵ���ת������ͼƬ.jpg",0,""),
                new AssistiveDevice(111240301,"��ȫѥ","������ʹ��","1322��ȫѥ����ͼƬ.jpg",0,""),
                new AssistiveDevice(111240302,"����������","������ʹ��","1323��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(111241801,"�����ذ�","������ʹ��","1324�����ذ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(111241802,"��·��ʶ","������ʹ��","1325��·��ʶ����ͼƬ.jpg",0,""),
                new AssistiveDevice(112030301,"��ѧ�������������","������ʹ��","1326��ѧ�����������������ͼƬ.jpg",0,""),
                new AssistiveDevice(112030302,"���������","������ʹ��","1327�������������ͼƬ.jpg",0,""),
                new AssistiveDevice(112030303,"������������","������ʹ��","1328����������������ͼƬ.jpg",0,""),
                new AssistiveDevice(112030304,"��ͨ�����","������ʹ��","1329��ͨ���������ͼƬ.jpg",0,""),
                new AssistiveDevice(112030901,"����","������ʹ��","1330��������ͼƬ.jpg",0,""),
                new AssistiveDevice(112090301,"��������","������ʹ��","1331������������ͼƬ.jpg",0,""),
                new AssistiveDevice(112090302,"ä������","������ʹ��","1332ä����������ͼƬ.jpg",0,""),
                new AssistiveDevice(112090303,"��ʽ����","������ʹ��","1333��ʽ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(112090304,"����ƹ����","������ʹ��","1334����ƹ��������ͼƬ.jpg",0,""),
                new AssistiveDevice(112090601,"������������","������ʹ��","1335����������������ͼƬ.jpg",0,""),
                new AssistiveDevice(112090901,"������������","������ʹ��","1336����������������ͼƬ.jpg",0,""),
                new AssistiveDevice(112091201,"������������","������ʹ��","1337����������������ͼƬ.jpg",0,""),
                new AssistiveDevice(112091801,"������������","������ʹ��","1338����������������ͼƬ.jpg",0,""),
                new AssistiveDevice(112092701,"������","������ʹ��","1339����������ͼƬ.jpg",0,""),
                new AssistiveDevice(112092702,"ƹ������","������ʹ��","1340ƹ����������ͼƬ.jpg",0,""),
                new AssistiveDevice(112092703,"��ë����","������ʹ��","1341��ë��������ͼƬ.jpg",0,""),
                new AssistiveDevice(112093001,"�����������","������ʹ��","1342���������������ͼƬ.jpg",0,""),
                new AssistiveDevice(112093301,"��Ӿ��ˮ���˶���������","������ʹ��","1343��Ӿ��ˮ���˶�������������ͼƬ.jpg",0,""),
                new AssistiveDevice(112093601,"�����˶���������","������ʹ��","1344�����˶�������������ͼƬ.jpg",0,""),
                new AssistiveDevice(112093901,"�����˶���������","������ʹ��","1345�����˶�������������ͼƬ.jpg",0,""),
                new AssistiveDevice(112180301,"������","������ʹ��","1346����������ͼƬ.jpg",0,""),
                new AssistiveDevice(112180302,"������","������ʹ��","1347����������ͼƬ.jpg",0,""),
                new AssistiveDevice(112180303,"���","������ʹ��","1348�������ͼƬ.jpg",0,""),
                new AssistiveDevice(112180304,"�����֯ģ��","������ʹ��","1349�����֯ģ������ͼƬ.jpg",0,""),
                new AssistiveDevice(112180601,"���չ��չ��ߡ����Ϻ��豸","������ʹ��","1350���չ��չ��ߡ����Ϻ��豸����ͼƬ.jpg",0,""),
                new AssistiveDevice(112180901,"ľ�����չ��ߡ����Ϻ��豸","������ʹ��","1351ľ�����չ��ߡ����Ϻ��豸����ͼƬ.jpg",0,""),
                new AssistiveDevice(112181201,"�����ӹ����ߡ����Ϻ��豸","������ʹ��","1352�����ӹ����ߡ����Ϻ��豸����ͼƬ.jpg",0,""),
                new AssistiveDevice(112181501,"����","������ʹ��","1353��������ͼƬ.jpg",0,""),
                new AssistiveDevice(112181502,"����","������ʹ��","1354��������ͼƬ.jpg",0,""),
                new AssistiveDevice(112181503,"����","������ʹ��","1355��������ͼƬ.jpg",0,""),
                new AssistiveDevice(112181504,"��ɫ��","������ʹ��","1356��ɫ������ͼƬ.jpg",0,""),
                new AssistiveDevice(112181505,"��ɫ��","������ʹ��","1357��ɫ������ͼƬ.jpg",0,""),
                new AssistiveDevice(112181506,"��ϴ","������ʹ��","1358��ϴ����ͼƬ.jpg",0,""),
                new AssistiveDevice(112181507,"��ֽ","������ʹ��","1359��ֽ����ͼƬ.jpg",0,""),
                new AssistiveDevice(112181801,"�������ϵ��ֹ����յĹ��ߡ����Ϻ��豸","������ʹ��","1360�������ϵ��ֹ����յĹ��߲��Ϻ��豸����ͼƬ.jpg",0,""),
                #endregion
                
                #region λ��ת��
                new AssistiveDevice(10236,"�����˵ĸ�������","λ��ת��"),
                new AssistiveDevice(10430,"��ֱ���͸�������","λ��ת��"),

                new AssistiveDevice(1023603,"����������λ��","λ��ת��"),
                new AssistiveDevice(1023606,"��Ӳ������λ��","λ��ת��"),
                new AssistiveDevice(1023612,"��װ��ǽ�ϡ��ذ���컨���ϵĹ̶���λ��","λ��ת��"),
                new AssistiveDevice(1023615,"�̶�����������һ����Ʒ�ϵĹ̶���λ��","λ��ת��"),
                new AssistiveDevice(1023618,"�̶�����ʽ��λ��","λ��ת��"),
                new AssistiveDevice(1023621,"��λ��������֧�Ų���","λ��ת��"),
                new AssistiveDevice(1043005,"�̶�ʽ����̨","λ��ת��"),
                new AssistiveDevice(1043008,"��Яʽ����̨","λ��ת��"),
                new AssistiveDevice(1043010,"¥��������","λ��ת��"),
                new AssistiveDevice(1043011,"ƽ̨¥��������","λ��ת��"),
                new AssistiveDevice(1043015,"���ƶ��µ�","λ��ת��"),
                new AssistiveDevice(1043018,"�̶��µ�","λ��ת��"),
                new AssistiveDevice(1043019,"����","λ��ת��"),
                new AssistiveDevice(1073309,"�����ƶ�ѵ����������","λ��ת��"),

                new AssistiveDevice(102360301,"�������ʽ��λ��","λ��ת��","498�������ʽ��λ��.jpg",0,""),
                new AssistiveDevice(102360302,"������װ�õĵ���ʽ��λ��","λ��ת��","499������װ�õĵ���ʽ��λ��.jpg",0,""),
                new AssistiveDevice(102360303,"վ��ʽ��λ��","λ��ת��","500վ��ʽ��λ��.jpg",0,""),
                new AssistiveDevice(102360601,"��Ӳ������λ��","λ��ת��","501��Ӳ������λ��.jpg",0,""),
                new AssistiveDevice(102361201,"����ʽ��λ��","λ��ת��","502����ʽ��λ��.jpg",0,""),
                new AssistiveDevice(102361501,"ԡ����λ��","λ��ת��","503ԡ����λ��.jpg",0,""),
                new AssistiveDevice(102361502,"ˮ������װ��","λ��ת��","504ˮ������װ��.jpg",0,""),
                new AssistiveDevice(102361801,"��ֱƽ̨","λ��ת��","505��ֱƽ̨.jpg",0,""),
                new AssistiveDevice(102362101,"����","λ��ת��","506����.jpg",0,""),
                new AssistiveDevice(102362102,"����","λ��ת��","507����.jpg",0,""),
                new AssistiveDevice(104300501,"��������̨","λ��ת��","779��������̨����ͼƬ.jpg",0,""),
                new AssistiveDevice(104300502,"�̶�ʽ����̨","λ��ת��","780�̶�ʽ����̨����ͼƬ.jpg",0,""),
                new AssistiveDevice(104300503,"ƽ̨������","λ��ת��","781ƽ̨����������ͼƬ.jpg",0,""),
                new AssistiveDevice(104300504,"б��ʽ��������ƽ̨","λ��ת��","782б��ʽ��������ƽ̨����ͼƬ.jpg",0,""),
                new AssistiveDevice(104300505,"��ֱʽ��������ƽ̨","λ��ת��","783��ֱʽ��������ƽ̨����ͼƬ.jpg",0,""),
                new AssistiveDevice(104300801,"��Яʽ����������","λ��ת��","784��Яʽ��������������ͼƬ.jpg",0,""),
                new AssistiveDevice(104301001,"����ʽ¥�ݻ�","λ��ת��","785����ʽ¥�ݻ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(104301101,"������¥��������","λ��ת��","786������¥������������ͼƬ.jpg",0,""),
                new AssistiveDevice(104301102,"�����ù���","λ��ת��","787�����ù�������ͼƬ.jpg",0,""),
                new AssistiveDevice(104301501,"�ɲ�װ�ļ����µ�","λ��ת��","788�ɲ�װ�ļ����µ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(104301502,"��Яʽб�°�","λ��ת��","789��Яʽб�°�.jpg",0,""),
                new AssistiveDevice(104301503,"ģ��ʽ����µ�","λ��ת��","790ģ��ʽ����µ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(104301801,"��ͨ�̶��µ���","λ��ת��","791��ͨ�̶��µ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(104301802,"��ȫ��̨","λ��ת��","792��ȫ��̨����ͼƬ.jpg",0,""),
                new AssistiveDevice(104301803,"���λ���ش�","λ��ת��","793���λ���ش�����ͼƬ.jpg",0,""),
                new AssistiveDevice(104301901,"���ò���","λ��ת��","794���ò���.png",0,""),
                new AssistiveDevice(107330901,"���������","λ��ת��","1194���������.jpg",0,""),
                new AssistiveDevice(107330902,"�����Ƴ˴�","λ��ת��","1195�����Ƴ˴�.png",0,""),
                new AssistiveDevice(107330903,"˫���Ƴ˴�","λ��ת��","1196˫���Ƴ˴�.jpg",0,""),
                new AssistiveDevice(107330904,"��������","λ��ת��","1197��������.jpg",0,""),
                new AssistiveDevice(107330905,"������","λ��ת��","1198������.jpg",0,""),
                new AssistiveDevice(107330906,"�Ƴ˰�","λ��ת��","1199�Ƴ˰�.jpg",0,""),
                new AssistiveDevice(107330907,"��������","λ��ת��","1200��������.png",0,""),
                #endregion
                
                #region ��������
                new AssistiveDevice(10409,"��ʽ�Ҿ�","��������"),

                new AssistiveDevice(1040921,"��������","��������"),

                new AssistiveDevice(104092101,"��ͯ������","��������","747��ͯ������.png",0,""),
                new AssistiveDevice(104092102,"��ͯ���ƽ�����","��������","748��ͯ���ƽ�����.jpg",0,""),
                new AssistiveDevice(104092103,"��ͯ�ݱ�ѵ����","��������","749��ͯ�ݱ�ѵ����.jpg",0,""),
                new AssistiveDevice(104092104,"��ͯ��ȫ��","��������","750��ͯ��ȫ��.jpg",0,""),
                new AssistiveDevice(104092105,"��ͯ����ҡ��","��������","751��ͯ����ҡ��.jpg",0,""),
                new AssistiveDevice(104092106,"��ͯ���Ϳɵ�����","��������","752��ͯ���Ϳɵ�����.jpg",0,""),
                #endregion

                #region ��֫
                new AssistiveDevice(10118,"��֫��֫","��֫"),
                new AssistiveDevice(10124,"��֫��֫","��֫"),
                new AssistiveDevice(10130,"��ͬ�ڼ�֫�ļ���","��֫"),

                new AssistiveDevice(1011803,"�����ּ�֫","��֫"),
                new AssistiveDevice(1011806,"����ϼ�֫","��֫"),
                new AssistiveDevice(1011809,"ǰ�ۼ�֫","��֫"),
                new AssistiveDevice(1011812,"����ϼ�֫","��֫"),
                new AssistiveDevice(1011815,"�ϱۼ�֫","��֫"),
                new AssistiveDevice(1011818,"����ϼ�֫","��֫"),
                new AssistiveDevice(1011821,"����������֫","��֫"),
                new AssistiveDevice(1011824,"����","��֫"),
                new AssistiveDevice(1011825,"��״��","��֫"),
                new AssistiveDevice(1011826,"�����ּ�����","��֫"),
                new AssistiveDevice(1011830,"��ؽ�","��֫"),
                new AssistiveDevice(1011833,"��ؽ�","��֫"),
                new AssistiveDevice(1011836,"��ؽ�","��֫"),
                new AssistiveDevice(1011840,"�Ź���תװ��","��֫"),
                new AssistiveDevice(1011841,"���ⱶ����","��֫"),
                new AssistiveDevice(1012403,"�������֫","��֫"),
                new AssistiveDevice(1012406,"�ײ���֫","��֫"),
                new AssistiveDevice(1012409,"С�ȼ�֫","��֫"),
                new AssistiveDevice(1012412,"ϥ��ϼ�֫","��֫"),
                new AssistiveDevice(1012415,"���ȼ�֫","��֫"),
                new AssistiveDevice(1012418,"����ϼ�֫","��֫"),
                new AssistiveDevice(1012421,"������г���֫","��֫"),
                new AssistiveDevice(1012424,"�����֫","��֫"),
                new AssistiveDevice(1012427,"����װ��","��֫"),
                new AssistiveDevice(1012430,"Ť�ػ�����","��֫"),
                new AssistiveDevice(1012431,"������","��֫"),
                new AssistiveDevice(1012433,"ϥ�ؽ�","��֫"),
                new AssistiveDevice(1012436,"�Źؽ�","��֫"),
                new AssistiveDevice(1012440,"�ڳ���","��֫"),
                new AssistiveDevice(1012441,"Ԥ�ƽ���ǻ","��֫"),
                new AssistiveDevice(1012445,"��֫��֫�Ķ���װ��","��֫"),
                new AssistiveDevice(1012448,"��֫��ʱ��֫","��֫"),
                new AssistiveDevice(1013003,"�ٷ�","��֫"),
                new AssistiveDevice(1013018,"���鷿","��֫"),
                new AssistiveDevice(1013021,"����","��֫"),
                new AssistiveDevice(1013024,"�ٶ�","��֫"),
                new AssistiveDevice(1013027,"�ٱ�","��֫"),
                new AssistiveDevice(1013030,"�沿�ϳɼ���","��֫"),
                new AssistiveDevice(1013033,"����","��֫"),
                new AssistiveDevice(1013036,"����","��֫"),

                new AssistiveDevice(101180301,"�ƹǽ�֫��֫","��֫","208�ƹǽ�֫��֫.jpg",0,""),
                new AssistiveDevice(101180302,"�ƹǽ�֫������","��֫","209�ƹǽ�֫������.jpg",0,""),
                new AssistiveDevice(101180303,"װ���Բ����ּ�֫","��֫","210װ���Բ����ּ�֫.jpg",0,""),
                new AssistiveDevice(101180304,"װ���Լ���ָ","��֫","211װ���Լ���ָ.jpg",0,""),
                new AssistiveDevice(101180601,"����������ϼ�֫","��֫","212����������ϼ�֫.jpg",0,""),
                new AssistiveDevice(101180602,"�����ɶȼ���������ϼ�֫","��֫","213�����ɶȼ���������ϼ�.jpg",0,""),
                new AssistiveDevice(101180603,"����������ϼ�֫","��֫","214����������ϼ�֫.jpg",0,""),
                new AssistiveDevice(101180604,"װ��������ϼ�֫","��֫","215װ��������ϼ�֫.jpg",0,""),
                new AssistiveDevice(101180901,"������ǰ�ۼ�֫","��֫","216������ǰ�ۼ�֫.jpg",0,""),
                new AssistiveDevice(101180902,"�����ɶȼ�����ǰ�ۼ�֫","��֫","217�����ɶȼ�����ǰ�ۼ�֫.jpg",0,""),
                new AssistiveDevice(101180903,"˫���ɶȼ�����ǰ�ۼ�֫","��֫","218˫���ɶȼ�����ǰ�ۼ�֫.jpg",0,""),
                new AssistiveDevice(101180904,"������ǰ�ۼ�֫","��֫","219������ǰ�ۼ�֫.jpg",0,""),
                new AssistiveDevice(101180905,"װ����ǰ�ۼ�֫","��֫","220װ����ǰ�ۼ�֫.jpg",0,""),
                new AssistiveDevice(101181201,"����������ϼ�֫","��֫","221����������ϼ�֫.jpg",0,""),
                new AssistiveDevice(101181202,"�����ɶȼ���������ϼ�֫","��֫","222�����ɶȼ���������ϼ�.jpg",0,""),
                new AssistiveDevice(101181203,"˫���ɶȼ���������ϼ�֫","��֫","223˫���ɶȼ���������ϼ�֫.jpg",0,""),
                new AssistiveDevice(101181204,"����������ϼ�֫","��֫","224����������ϼ�֫.jpg",0,""),
                new AssistiveDevice(101181205,"װ��������ϼ�֫","��֫","225װ��������ϼ�֫.jpg",0,""),
                new AssistiveDevice(101181501,"�������ϱۼ�֫","��֫","226�������ϱۼ�֫.jpg",0,""),
                new AssistiveDevice(101181502,"�����ɶȼ������ϱۼ�֫","��֫","227�����ɶȼ������ϱۼ�֫.jpg",0,""),
                new AssistiveDevice(101181503,"˫���ɶȼ������ϱۼ�֫","��֫","228˫���ɶȼ������ϱۼ�֫.jpg",0,""),
                new AssistiveDevice(101181504,"˫���ɶȻ��ʽ�綯���ϱۼ�֫","��֫","229˫���ɶȻ��ʽ�綯���ϱۼ�֫.jpg",0,""),
                new AssistiveDevice(101181505,"�����ɶȼ������ϱۼ�֫","��֫","230�����ɶȼ������ϱۼ�֫.jpg",0,""),
                new AssistiveDevice(101181506,"�������ϱۼ�֫","��֫","231�������ϱۼ�֫.jpg",0,""),
                new AssistiveDevice(101181507,"װ�����ϱۼ�֫","��֫","232װ�����ϱۼ�֫.jpg",0,""),
                new AssistiveDevice(101181801,"�����ּ���ϼ�֫","��֫","233�����ּ���ϼ�֫.jpg",0,""),
                new AssistiveDevice(101181802,"˫���ɶȼ����ּ���ϼ�֫","��֫","234˫���ɶȼ����ּ���ϼ�֫.jpg",0,""),
                new AssistiveDevice(101181803,"װ���Լ���ϼ�֫","��֫","235װ���Լ���ϼ�֫.jpg",0,""),
                new AssistiveDevice(101182101,"װ���Լ���������֫","��֫","236װ���Լ���������֫.jpg",0,""),
                new AssistiveDevice(101182401,"��ʽ������","��֫","237��ʽ������.jpg",0,""),
                new AssistiveDevice(101182402,"�Ǽ�ʽ������","��֫","238�Ǽ�ʽ������.jpg",0,""),
                new AssistiveDevice(101182403,"�����ɶȼ�����","��֫","239�����ɶȼ�����.jpg",0,""),
                new AssistiveDevice(101182404,"˫���ɶȼ�����","��֫","240˫���ɶȼ�����.jpg",0,""),
                new AssistiveDevice(101182405,"װ����","��֫","241װ����.jpg",0,""),
                new AssistiveDevice(101182406,"�ƹǽ�֫������","��֫","242�ƹǽ�֫������.jpg",0,""),
                new AssistiveDevice(101182501,"�����͹�״��","��֫","243�����͹�״��.jpg",0,""),
                new AssistiveDevice(101182502,"�๳�͹�״��","��֫","244�๳�͹�״��.jpg",0,""),
                new AssistiveDevice(101182601,"�Ͷ��ù�״������","��֫","245�Ͷ��ù�״������.jpg",0,""),
                new AssistiveDevice(101182602,"�Ͷ��üгֹ�����","��֫","246�Ͷ��üгֹ�����.jpg",0,""),
                new AssistiveDevice(101182603,"ר�ù���","��֫","247ר�ù���.jpg",0,""),
                new AssistiveDevice(101183001,"Ħ��ʽ������ؽ�","��֫","248Ħ��ʽ������ؽ�.jpg",0,""),
                new AssistiveDevice(101183002,"����ʽ��ؽ�","��֫","249����ʽ��ؽ�.jpg",0,""),
                new AssistiveDevice(101183003,"��װ��ͷʽ��ؽ�","��֫","250��װ��ͷʽ��ؽ�.jpg",0,""),
                new AssistiveDevice(101183004,"������������","��֫","251������������.jpg",0,""),
                new AssistiveDevice(101183301,"����������ؽڽ���","��֫","252����������ؽڽ���.jpg",0,""),
                new AssistiveDevice(101183302,"˫��������ؽڽ���","��֫","253˫��������ؽڽ���.jpg",0,""),
                new AssistiveDevice(101183303,"����ʽ��ؽڽ���","��֫","254����ʽ��ؽڽ���.jpg",0,""),
                new AssistiveDevice(101183304,"������ؽڽ���","��֫","255������ؽڽ���.jpg",0,""),
                new AssistiveDevice(101183305,"�綯��ؽ�","��֫","256�綯��ؽ�.jpg",0,""),
                new AssistiveDevice(101183601,"����ʽ��ؽ�","��֫","257����ʽ��ؽ�.jpg",0,""),
                new AssistiveDevice(101183602,"��չʽ��ؽ�","��֫","258��չʽ��ؽ�.jpg",0,""),
                new AssistiveDevice(101183603,"�����ؽ�","��֫","259�����ؽ�.jpg",0,""),
                new AssistiveDevice(101184001,"�Ź���תװ��","��֫","260�Ź���תװ��.jpg",0,""),
                new AssistiveDevice(101184101,"���˽ṹ����ʽ�����","��֫","261���˽ṹ����ʽ��������ޣ�.jpg",0,""),
                new AssistiveDevice(101184102,"�ĸ˽ṹ����ʽ�����","��֫","262�ĸ˽ṹ����ʽ��������ޣ�.jpg",0,""),
                new AssistiveDevice(101240301,"Ƥ��ʽ����ֺ","��֫","263Ƥ��ʽ����ֺ���ޣ�.jpg",0,""),
                new AssistiveDevice(101240302,"�轺��ʽ����ֺ","��֫","264�轺��ʽ����ֺ���ޣ�.jpg",0,""),
                new AssistiveDevice(101240303,"�轺����ʽ�ٰ���","��֫","265�轺����ʽ�ٰ��㣨�ޣ�.jpg",0,""),
                new AssistiveDevice(101240304,"��֬����С��ʽ�ٰ���","��֫","266��֬����С��ʽ�ٰ��㣨�ޣ�.jpg",0,""),
                new AssistiveDevice(101240601,"Ƥ����ķ��֫","��֫","267Ƥ����ķ��֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101240602,"��֬������ķ��֫","��֫","268��֬������ķ��֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101240901,"��ʽС�ȼ�֫","��֫","269��ʽС�ȼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101240902,"���ʽ�����С�ȼ�֫","��֫","270���ʽ�����С�ȼ�֫�ޣ�.jpg",0,""),
                new AssistiveDevice(101240903,"���ʽSACH ��С�ȼ�֫","��֫","271���ʽSACH ��С�ȼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101240904,"���ʽ�����׵����С�ȼ�֫","��֫","272���ʽ�����׵����С�ȼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101240905,"���ʽ���ܽ�С�ȼ�֫","��֫","273���ʽ���ܽ�С�ȼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101241201,"��������ϥ��ϼ�֫","��֫","274��������ϥ��ϼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101241202,"���Ͻ����ϥ��ϼ�֫","��֫","275���Ͻ����ϥ��ϼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101241203,"�ѺϽ����ϥ��ϼ�֫","��֫","276�ѺϽ����ϥ��ϼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101241204,"��ѹ����ϥ��ϼ�֫","��֫","277��ѹ����ϥ��ϼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101241205,"Һѹ����ϥ��ϼ�֫","��֫","278Һѹ����ϥ��ϼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101241206,"���ܿ���ϥ��ϼ�֫","��֫","279���ܿ���ϥ��ϼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101241501,"�����������ȼ�֫","��֫","280�����������ȼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101241502,"���Ͻ�������ȼ�֫","��֫","281���Ͻ�������ȼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101241503,"�ѺϽ�������ȼ�֫","��֫","282�ѺϽ�������ȼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101241504,"��ѹ���ƴ��ȼ�֫","��֫","283��ѹ���ƴ��ȼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101241505,"Һѹ���ƴ��ȼ�֫","��֫","284Һѹ���ƴ��ȼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101241506,"���ܿ��ƴ��ȼ�֫","��֫","285���ܿ��ƴ��ȼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101241801,"������������ϼ�֫","��֫","286������������ϼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101241802,"���Ͻ��������ϼ�֫","��֫","287���Ͻ��������ϼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101241803,"�ѺϽ��������ϼ�֫","��֫","288�ѺϽ��������ϼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101241804,"��ѹ��������ϼ�֫","��֫","289��ѹ��������ϼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101241805,"Һѹ��������ϼ�֫","��֫","290Һѹ��������ϼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101242101,"������г���֫","��֫","291������г���֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101242102,"���ư�����г���֫","��֫","292���ư�����г���֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101242401,"��׮�����֫","��֫","293��׮�����֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101242402,"���ư����֫","��֫","294���ư����֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101242701,"�����","��֫","295����ţ��ޣ�.jpg",0,""),
                new AssistiveDevice(101242702,"������׽�","��֫","296������׽ţ��ޣ�.jpg",0,""),
                new AssistiveDevice(101242703,"���׽�","��֫","297���׽ţ��ޣ�.jpg",0,""),
                new AssistiveDevice(101242704,"�����","��֫","298�ѺϽ��������ϼ�֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101242705,"���ܽ�","��֫","299���ܽţ��ޣ�.jpg",0,""),
                new AssistiveDevice(101242706,"��׶����","��֫","300��׶���ף��ޣ�.jpg",0,""),
                new AssistiveDevice(101242707,"���ᶯ��","��֫","301���ᶯ�ף��ޣ�.jpg",0,""),
                new AssistiveDevice(101242708,"������","��֫","302�����ף��ޣ�.jpg",0,""),
                new AssistiveDevice(101243001,"����Ť�ػ�����","��֫","303����Ť�ػ��������ޣ�.jpg",0,""),
                new AssistiveDevice(101243002,"��Ť�ػ�����","��֫","304��Ť�ػ��������ޣ�.jpg",0,""),
                new AssistiveDevice(101243101,"ϥ��չ������","��֫","305ϥ��չ���������ޣ�.jpg",0,""),
                new AssistiveDevice(101243102,"��ǰ������","��֫","306��ǰ���������ޣ�.jpg",0,""),
                new AssistiveDevice(101243103,"��󻺳���","��֫","307��󻺳������ޣ�.jpg",0,""),
                new AssistiveDevice(101243301,"����ϥ�ؽ�","��֫","308����ϥ�ؽڣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101243302,"��������ϥ�ؽ�","��֫","309��������ϥ�ؽڣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101243303,"�ֶ�������ϥ�ؽ�","��֫","310�ֶ�������ϥ�ؽڣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101243304,"������ϥ�ؽ�","��֫","311������ϥ�ؽڣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101243305,"��ѹϥ�ؽ�","��֫","312��ѹϥ�ؽڣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101243306,"Һѹϥ�ؽ�","��֫","313Һѹϥ�ؽڣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101243307,"����ϥ�ؽ�","��֫","314����ϥ�ؽڣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101243308,"������ϥ���ϥ�ؽ�","��֫","315������ϥ���ϥ�ؽڣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101243309,"��ѹϥ���ϥ�ؽ�","��֫","316��ѹϥ���ϥ�ؽڣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101243310,"Һѹϥ���ϥ�ؽ�","��֫","317Һѹϥ���ϥ�ؽڣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101243601,"ǰ��ʽ�����Źؽ�","��֫","318ǰ��ʽ�����Źؽڣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101243602,"����ʽ�����Źؽ�","��֫","319����ʽ�����Źؽڣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101243603,"�������Źؽ�","��֫","320�������Źؽڣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101244001,"����ǻ�ڳ���","��֫","321����ǻ�ڳ��ף��ޣ�.jpg",0,""),
                new AssistiveDevice(101244002,"����������֫��","��֫","322����������֫�ף��ޣ�.jpg",0,""),
                new AssistiveDevice(101244003,"����������֫��","��֫","323����������֫�ף��ޣ�.jpg",0,""),
                new AssistiveDevice(101244004,"�����轺��֫��","��֫","324�����轺��֫�ף��ޣ�.jpg",0,""),
                new AssistiveDevice(101244005,"�����轺��֫��","��֫","325�����轺��֫�ף��ޣ�.jpg",0,""),
                new AssistiveDevice(101244101,"Ԥ�ƽ���ǻ","��֫","326Ԥ�ƽ���ǻ���ޣ�.jpg",0,""),
                new AssistiveDevice(101244501,"С�ȼ�֫װ�����������","��֫","327С�ȼ�֫װ����������̣��ޣ�.jpg",0,""),
                new AssistiveDevice(101244502,"��ʱ����ǻ�ɵ����Ӽ�","��֫","328��ʱ����ǻ�ɵ����Ӽܣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101244503,"�ɵ�������","��֫","329�ɵ������̣��ޣ�.jpg",0,""),
                new AssistiveDevice(101244504,"��צ������","��֫","330��צ�����̣��ޣ�.jpg",0,""),
                new AssistiveDevice(101244505,"��צ������","��֫","331��צ�����̣��ޣ�.jpg",0,""),
                new AssistiveDevice(101244506,"�����ܽ�ͷ","��֫","332�����ܽ�ͷ���ޣ�.jpg",0,""),
                new AssistiveDevice(101244507,"˫���ͷ","��֫","333˫���ͷ���ޣ�.jpg",0,""),
                new AssistiveDevice(101244801,"ʯ�����ǻ��ʱ��֫","��֫","334ʯ�����ǻ��ʱ��֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101244802,"���ý���ǻ���ڼܵ���ʱ��֫","��֫","335���ý���ǻ���ڼܵ���ʱ��֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101244803,"��֬����ǻ��ʱ��֫","��֫","336��֬����ǻ��ʱ��֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101244804,"��׮��ʱ��֫","��֫","337��׮��ʱ��֫���ޣ�.jpg",0,""),
                new AssistiveDevice(101300301,"�ٷ�","��֫","338�ٷ����ޣ�.jpg",0,""),
                new AssistiveDevice(101301801,"����ʽ���鷿","��֫","339����ʽ���鷿���ޣ�.jpg",0,""),
                new AssistiveDevice(101301802,"������鷿","��֫","340������鷿���ޣ�.jpg",0,""),
                new AssistiveDevice(101302101,"����Ӳ�Լ���","��֫","341����Ӳ�Լ��ۣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101302102,"����Ӳ�Լ���","��֫","342����Ӳ�Լ��ۣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101302103,"���Լ���","��֫","343���Լ��ۣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101302104,"�������","��֫","344������ۣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101302105,"���ƻ����","��֫","345���ƻ���ۣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101302401,"�轺�ٶ�","��֫","346�轺�ٶ����ޣ�.jpg",0,""),
                new AssistiveDevice(101302701,"�轺�ٱ�","��֫","347�轺�ٱǣ��ޣ�.jpg",0,""),
                new AssistiveDevice(101303001,"�沿�ϳɼ���","��֫","348�沿�ϳɼ��壨�ޣ�.jpg",0,""),
                new AssistiveDevice(101303301,"����","��֫","349�����ޣ�.jpg",0,""),
                new AssistiveDevice(101303601,"������","��֫","350���������ޣ�.jpg",0,""),
                new AssistiveDevice(101303602,"ȫ����","��֫","351ȫ�������ޣ�.jpg",0,""),
                #endregion

                #region ������
                new AssistiveDevice(10103,"������­��������","������"),
                new AssistiveDevice(10104,"����������","������"),
                new AssistiveDevice(10106,"��֫������ϵͳ","������"),
                new AssistiveDevice(10112,"��֫������","������"),
                new AssistiveDevice(10133,"����Ь","������"),

                new AssistiveDevice(1010303,"���Ľ�����","������"),
                new AssistiveDevice(1010304,"����������","������"),
                new AssistiveDevice(1010306,"����������","������"),
                new AssistiveDevice(1010307,"�ز�������","������"),
                new AssistiveDevice(1010308,"����������","������"),
                new AssistiveDevice(1010309,"������������","������"),
                new AssistiveDevice(1010312,"����������","������"),
                new AssistiveDevice(1010315,"���ؽ�����","������"),
                new AssistiveDevice(1010318,"��������������","������"),
                new AssistiveDevice(1010321,"­��������","������"),
                new AssistiveDevice(1010326,"�������������","������"),
                new AssistiveDevice(1010327,"��������������","������"),
                new AssistiveDevice(1010403,"������","������"),
                new AssistiveDevice(1010404,"θ���´�����","������"),
                new AssistiveDevice(1010405,"�����´�����","������"),
                new AssistiveDevice(1010603,"ָ������","������"),
                new AssistiveDevice(1010606,"�ֽ�����","������"),
                new AssistiveDevice(1010607,"��-ָ������","������"),
                new AssistiveDevice(1010612,"���ֽ�����","������"),
                new AssistiveDevice(1010613,"����-��ָ������","������"),
                new AssistiveDevice(1010614,"�гֽ�����","������"),
                new AssistiveDevice(1010615,"�������","������"),
                new AssistiveDevice(1010619,"�����ֽ�����","������"),
                new AssistiveDevice(1010620,"ǰ�۽�����","������"),
                new AssistiveDevice(1010621,"�������","������"),
                new AssistiveDevice(1010624,"���������","������"),
                new AssistiveDevice(1010625,"�ϱ۽�����","������"),
                new AssistiveDevice(1010630,"�������ֽ�����","������"),
                new AssistiveDevice(1010631,"��-ָ�ؽڽ���","������"),
                new AssistiveDevice(1010633,"�����","������"),
                new AssistiveDevice(1010636,"�����","������"),
                new AssistiveDevice(1010639,"�����","������"),
                new AssistiveDevice(1011203,"�������","������"),
                new AssistiveDevice(1011206,"���������","������"),
                new AssistiveDevice(1011209,"ϥ������","������"),
                new AssistiveDevice(1011212,"ϥ���������","������"),
                new AssistiveDevice(1011213,"С�Ƚ�����","������"),
                new AssistiveDevice(1011215,"�Ž�����","������"),
                new AssistiveDevice(1011216,"��ϥ������","������"),
                new AssistiveDevice(1011217,"���Ƚ�����","������"),
                new AssistiveDevice(1011218,"��ϥ���������","������"),
                new AssistiveDevice(1011219,"����(��)����ϥ���������","������"),
                new AssistiveDevice(1011220,"��-ֺ����","������"),
                new AssistiveDevice(1011221,"�׹ؽڽ���","������"),
                new AssistiveDevice(1011224,"ϥ�ؽڽ���","������"),
                new AssistiveDevice(1011227,"�Źؽڽ���","������"),
                new AssistiveDevice(1013307,"���ƻ��εĽ���Ь","������"),
                new AssistiveDevice(1013318,"����Ь","������"),
                new AssistiveDevice(1013321,"��ȱЬ","������"),
                new AssistiveDevice(1013330,"���Ь","������"),
                new AssistiveDevice(1013333,"�����ý���Ь","������"),

                new AssistiveDevice(101030301,"��ģ�������Ľ�����","������","1��ģ�������Ľ�����.jpg",0,""),
                new AssistiveDevice(101030302,"���Ĵ�","������","2���Ĵ�.jpg",0,""),
                new AssistiveDevice(101030303,"��ת�Ӵ�","������","3��ת�Ӵ�.jpg",0,""),
                new AssistiveDevice(101030401,"������Χ","������","4������Χ.jpg",0,""),
                new AssistiveDevice(101030402,"��ǿ�͵�����Χ","������","5��ǿ�͵�����Χ.jpg",0,""),
                new AssistiveDevice(101030403,"����֧��ʽ������Χ","������","6����֧��ʽ������Χ.jpg",0,""),
                new AssistiveDevice(101030404,"Ӳ��ʽ��Χ","������","7Ӳ��ʽ��Χ.jpg",0,""),
                new AssistiveDevice(101030405,"Ƥ��Χ","������","8Ƥ��Χ.jpg",0,""),
                new AssistiveDevice(101030406,"������Χ","������","9������Χ.jpg",0,""),
                new AssistiveDevice(101030407,"��������Χ","������","10��������Χ.jpg",0,""),
                new AssistiveDevice(101030408,"Ӳ����Χ","������","11Ӳ����Χ.JPG",0,""),
                new AssistiveDevice(101030601,"��ģ��������������","������","12��ģ��������������.jpg",0,""),
                new AssistiveDevice(101030602,"������������չ���ƽ�������","������","13������������չ���ƽ�������.jpg",0,""),
                new AssistiveDevice(101030603,"��׵ǣ����","������","14��׵ǣ����.jpg",0,""),
                new AssistiveDevice(101030604,"������׵ǣ����","������","15������׵ǣ����.jpg",0,""),
                new AssistiveDevice(101030701,"�ز�������","������","16�ز�������.jpg",0,""),
                new AssistiveDevice(101030801,"����֧����������Χ��","������","17����֧����������Χ��.jpg",0,""),
                new AssistiveDevice(101030802,"���÷�����������Χ��","������","18���÷�����������Χ��.jpg",0,""),
                new AssistiveDevice(101030803,"����֧��Ƥ�����Χ��","������","19����֧��Ƥ�����Χ��.jpg",0,""),
                new AssistiveDevice(101030804,"������ʽ����Χ��","������","20������ʽ����Χ��.jpg",0,""),
                new AssistiveDevice(101030805,"���˽��δ�","������","21���˽�����.jpg",0,""),
                new AssistiveDevice(101030901,"̩����������������","������","22̩����������������.jpg",0,""),
                new AssistiveDevice(101030902,"����-̩����������������","������","23����-̩����������������.jpg",0,""),
                new AssistiveDevice(101030903,"�������������","������","24�������������.jpg",0,""),
                new AssistiveDevice(101030904,"֧���̶�ʽ������������","������","25֧���̶�ʽ������������.jpg",0,""),
                new AssistiveDevice(101030905,"ģ�ܼп�ʽ������������","������","26ģ�ܼп�ʽ������������.jpg",0,""),
                new AssistiveDevice(101030906,"�ɵ��п�ʽ������������","������","27�ɵ��п�ʽ������������.jpg",0,""),
                new AssistiveDevice(101030907,"���ر��пɵ��п�ʽ������������","������","28���ر��пɵ��п�ʽ������������.jpg",0,""),
                new AssistiveDevice(101030908,"������Χ��ʽ������������","������","29������Χ��ʽ������������.jpg",0,""),
                new AssistiveDevice(101031201,"Χ��ʽ����","������","30Χ��ʽ����.JPG",0,""),
                new AssistiveDevice(101031202,"�ѳǾ���","������","31�ѳǾ���.jpg",0,""),
                new AssistiveDevice(101031203,"ģ�ܳ��͹̶�ʽ����","������","32ģ�ܳ��͹̶�ʽ����.jpg",0,""),
                new AssistiveDevice(101031204,"�߶ȿɵ�ʽ����","������","33�߶ȿɵ�ʽ����.JPG",0,""),
                new AssistiveDevice(101031205,"����ʽ����","������","34����ʽ����.jpg",0,""),
                new AssistiveDevice(101031206,"��Ƭ���ʽ����","������","35��Ƭ���ʽ����.jpg",0,""),
                new AssistiveDevice(101031207,"��׵ǣ����","������","36��׵ǣ����.jpg",0,""),
                new AssistiveDevice(101031501,"�����;��ؽ�����","������","37�����;��ؽ�����.jpg",0,""),
                new AssistiveDevice(101031502,"֧�˼�ǿ�;��ؽ�����","������","38֧�˼�ǿ�;��ؽ�����.jpg",0,""),
                new AssistiveDevice(101031503,"ͷ��ʽ���ؽ�����","������","39ͷ��ʽ���ؽ�����.jpg",0,""),
                new AssistiveDevice(101031504,"ͷ��ʽ���ؽ�����","������","40ͷ��ʽ���ؽ�����.jpg",0,""),
                new AssistiveDevice(101031505,"ģ�ܳ��;��ؽ�����","������","41ģ�ܳ��;��ؽ�����.jpg",0,""),
                new AssistiveDevice(101031506,"���ʽ���ؽ�����","������","42���ʽ���ؽ�����.jpg",0,""),
                new AssistiveDevice(101031801,"ģ�ܳ���������������","������","43ģ�ܳ���������������.jpg",0,""),
                new AssistiveDevice(101031802,"���ʽ������������","������","44���ʽ������������.jpg",0,""),
                new AssistiveDevice(101031803,"����׵ǣ����","������","45����׵ǣ����.jpg",0,""),
                new AssistiveDevice(101032101,"������ͷ��","������","46������ͷ�� .JPG",0,""),
                new AssistiveDevice(101032102,"­�ǻ���","������","47­�ǻ���.jpg",0,""),
                new AssistiveDevice(101032601,"�ܶ��ֻ��Ͳ�͹������","������","48�ܶ��ֻ��Ͳ�͹������.jpg",0,""),
                new AssistiveDevice(101032602,"��ʿ���Ͳ�͹������","������","49��ʿ���Ͳ�͹������.jpg",0,""),
                new AssistiveDevice(101032603,"�ﰺ�Ͳ�͹������","������","50�ﰺ�Ͳ�͹������.jpg",0,""),
                new AssistiveDevice(101032604,"ɫŬ�Ͳ�͹������","������","51ɫŬ�Ͳ�͹������.png",0,""),
                new AssistiveDevice(101032605,"CBW �Ͳ�͹������","������","52CBW �Ͳ�͹������.jpg",0,""),
                new AssistiveDevice(101032606,"OMC������ҽ���Ͳ�͹������","������","53OMC������ҽ���Ͳ�͹������.jpg",0,""),
                new AssistiveDevice(101032701,"��������������","������","54��������������.jpg",0,""),
                new AssistiveDevice(101040301,"������","������","55������.jpg",0,""),
                new AssistiveDevice(101040401,"��ͨθ��","������","56��ͨθ��.jpg",0,""),
                new AssistiveDevice(101040402,"�ɵ�ʽθ��","������","57�ɵ�ʽθ��.jpg",0,""),
                new AssistiveDevice(101040501,"��������","������","58��������.jpg",0,""),
                new AssistiveDevice(101040502,"˫������","������","59˫������.jpg",0,""),
                new AssistiveDevice(101060301,"ָ��ؽڹ̶���","������","60ָ��ؽڹ̶���.jpg",0,""),
                new AssistiveDevice(101060302,"�״ָ������","������","61�״ָ������.jpg",0,""),
                new AssistiveDevice(101060303,"�쾱����ָ������","������","62�쾱����ָ������.jpg",0,""),
                new AssistiveDevice(101060304,"���۱���ָ������","������","63���۱���ָ������.jpg",0,""),
                new AssistiveDevice(101060305,"Ӳ��ָ��","������","64Ӳ��ָ��.jpg",0,""),
                new AssistiveDevice(101060306,"ָ����","������","65ָ����.jpg",0,""),
                new AssistiveDevice(101060307,"������ָ��","������","66������ָ��.jpg",0,""),
                new AssistiveDevice(101060308,"������ָ��","������","67������ָ��.jpg",0,""),
                new AssistiveDevice(101060601,"��ָ�ؽڹ̶�������","������","68��ָ�ؽڹ̶�������.jpg",0,""),
                new AssistiveDevice(101060602,"��ָ�ؽ���չ����������","������","69��ָ�ؽ���չ����������.jpg",0,""),
                new AssistiveDevice(101060603,"������Խ�����","������","70������Խ�����.jpg",0,""),
                new AssistiveDevice(101060604,"�̶��ƽ�����","������","71�̶��ƽ�����.jpg",0,""),
                new AssistiveDevice(101060701,"�ɵ���ָ��","������","72�ɵ���ָ��.jpg",0,""),
                new AssistiveDevice(101060702,"���Ƽ�Ĥ����������","������","73���Ƽ�Ĥ����������.jpg",0,""),
                new AssistiveDevice(101060703,"����������ý�����","������","74����������ý�����.jpg",0,""),
                new AssistiveDevice(101061201,"��������","������","75��������.jpg",0,""),
                new AssistiveDevice(101061202,"�ӹ��ͻ���","������","76�ӹ��ͻ���.jpg",0,""),
                new AssistiveDevice(101061203,"��ؽڶ�λ�а�","������","77��ؽڶ�λ�а�.jpg",0,""),
                new AssistiveDevice(101061204,"ģ�ܳ������̶ֹ�������","������","78ģ�ܳ������̶ֹ�������.jpg",0,""),
                new AssistiveDevice(101061205,"���������ֽ�����","������","79���������ֽ�����.jpg",0,""),
                new AssistiveDevice(101061206,"��̬���ֽ�����","������","80��̬���ֽ�����.jpg",0,""),
                new AssistiveDevice(101061207,"�����ƽ�����","������","81�����ƽ�����.jpg",0,""),
                new AssistiveDevice(101061301,"��MP��չ��λ�ĳ����ƽ�����","������","82��MP��չ��λ�ĳ����ƽ�����.jpg",0,""),
                new AssistiveDevice(101061302,"��IP��չ������MP��չ��λ�ĳ����ƽ�����","������","83��IP��չ������MP��չ��λ�ĳ����ƽ�����.jpg",0,""),
                new AssistiveDevice(101061303,"��MP���������ĳ����ƽ�����","������","84��MP���������ĳ����ƽ�����.jpg",0,""),
                new AssistiveDevice(101061304,"��MP��չ�����ĳ����ƽ�����","������","85��MP��չ�����ĳ����ƽ�����.jpg",0,""),
                new AssistiveDevice(101061305,"��IP��չ�����ĳ����ƽ�����","������","86��IP��չ�����ĳ����ƽ�����.jpg",0,""),
                new AssistiveDevice(101061401,"�����ͼгֽ�����","������","87�����ͼгֽ�����.jpg",0,""),
                new AssistiveDevice(101061402,"�����ͼгֽ�����","������","88�����ͼгֽ�����.jpg",0,""),
                new AssistiveDevice(101061501,"��������","������","89��������.jpg",0,""),
                new AssistiveDevice(101061502,"�����⻤��","������","90�����⻤��.jpg",0,""),
                new AssistiveDevice(101061503,"��������ƽ�����","������","91�������λ������.jpg",0,""),
                new AssistiveDevice(101061504,"��̶�������","������","92��̶�������.jpg",0,""),
                new AssistiveDevice(101061505,"�ɵ��������","������","93�ɵ��������.jpg",0,""),
                new AssistiveDevice(101061901,"ǰ�ۣ������֣�������","������","94ǰ�ۣ������֣�������.jpg",0,""),
                new AssistiveDevice(101062001,"ǰ�۹̶�����","������","95ģ�ܳ���ǰ�۹̶���.jpg",0,""),
                new AssistiveDevice(101062002,"ģ�ܳ���ǰ�۹̶���","������","96ǰ�۹̶�����.jpg",0,""),
                new AssistiveDevice(101062101,"��������","������","97��������.jpg",0,""),
                new AssistiveDevice(101062102,"���Ǵ�","������","98���Ǵ�.jpg",0,""),
                new AssistiveDevice(101062103,"��ؽڹ̶�������","������","99��ؽڹ̶�������.jpg",0,""),
                new AssistiveDevice(101062104,"����չ������","������","100����չ������.jpg",0,""),
                new AssistiveDevice(101062105,"��ؽ���λ������","������","101��ؽ���λ������.jpg",0,""),
                new AssistiveDevice(101062106,"�����ؽ���λ������","������","102�����ؽ���λ������.jpg",0,""),
                new AssistiveDevice(101062107,"�۵���","������","103���Ǵ�.jpg",0,""),
                new AssistiveDevice(101062401,"����̶���","������","104����̶���.jpg",0,""),
                new AssistiveDevice(101062402,"���⸨������ʽ��̬���������","������","105���⸨������ʽ��̬���������.jpg",0,""),
                new AssistiveDevice(101062501,"�ϱ۹̶�����","������","106�ϱ۹̶�����.jpg",0,""),
                new AssistiveDevice(101062502,"ģ�ܳ����ϱ۹̶���","������","107ģ�ܳ����ϱ۹̶���.jpg",0,""),
                new AssistiveDevice(101063001,"��������֫������","������","108��������֫������.jpg",0,""),
                new AssistiveDevice(101063002,"ƽ��ʽǰ�۽�����(BFO)","������","109ƽ��ʽǰ�۽�����.jpg",0,""),
                new AssistiveDevice(101063101,"��-ָ�ؽڽ���","������","110��-ָ�ؽڽ���.jpg",0,""),
                new AssistiveDevice(101063301,"�����","������","111�����.jpg",0,""),
                new AssistiveDevice(101063601,"������ؽڽ���","������","112������ؽڽ���.jpg",0,""),
                new AssistiveDevice(101063602,"��λ������ʽ��ؽڽ���","������","113��λ������ʽ��ؽڽ���.jpg",0,""),
                new AssistiveDevice(101063603,"��������ʽ��ؽڽ���","������","114��������ʽ��ؽڽ���.jpg",0,""),
                new AssistiveDevice(101063604,"������ؽڽ���","������","115������ؽڽ���.jpg",0,""),
                new AssistiveDevice(101063901,"���Լ�ؽڽ���","������","116���Լ�ؽڽ���.jpg",0,""),
                new AssistiveDevice(101120301,"Ĵָ�ⷭ���������棩","������","117Ĵָ�ⷭ���������棩.jpg",0,""),
                new AssistiveDevice(101120302,"�轺��ֺ��","������","118�轺��ֺ��.jpg",0,""),
                new AssistiveDevice(101120303,"�״ֺ��","������","119�״ֺ��.jpg",0,""),
                new AssistiveDevice(101120304,"���۵�","������","120���۵�.jpg",0,""),
                new AssistiveDevice(101120305,"�Źǵ�","������","121�Źǵ�.jpg",0,""),
                new AssistiveDevice(101120306,"���Ƶ�","������","122���Ƶ�.jpg",0,""),
                new AssistiveDevice(101120307,"���ǵ�","������","123���ǵ�.jpg",0,""),
                new AssistiveDevice(101120308,"���ǹǴ̵�","������","124���ǹǴ̵�.jpg",0,""),
                new AssistiveDevice(101120309,"�ṭ��","������","125�ṭ��.jpg",0,""),
                new AssistiveDevice(101120310,"ƽ���","������","126ƽ���.jpg",0,""),
                new AssistiveDevice(101120311,"�������","������","127�������.jpg",0,""),
                new AssistiveDevice(101120312,"����/�ⷭ������","������","128���ڡ��ⷭ������.jpg",0,""),
                new AssistiveDevice(101120313,"�㹭��","������","129�㹭��.jpg",0,""),
                new AssistiveDevice(101120314,"���ߵ�","������","130���ߵ�.jpg",0,""),
                new AssistiveDevice(101120315,"�����Ш�ε�","������","131�����Ш�ε�.jpg",0,""),
                new AssistiveDevice(101120316,"������Ь��","������","132������Ь��.jpg",0,""),
                new AssistiveDevice(101120601,"��������","������","133��������.jpg",0,""),
                new AssistiveDevice(101120602,"�ʹ��ͻ���","������","134�ʹ��ͻ���.jpg",0,""),
                new AssistiveDevice(101120603,"����̶�������","������","135����̶�������.jpg",0,""),
                new AssistiveDevice(101120604,"ѥ�����������","������","136ѥ�����������.jpg",0,""),
                new AssistiveDevice(101120605,"��̬���������","������","137��̬���������.jpg",0,""),
                new AssistiveDevice(101120606,"�������������","������","138�������������.jpg",0,""),
                new AssistiveDevice(101120607,"����ʽ���������","������","139����ʽ���������.jpg",0,""),
                new AssistiveDevice(101120608,"������ʽ���������","������","140������ʽ���������.jpg",0,""),
                new AssistiveDevice(101120609,"ȫ���PTB���������","������","141ȫ���PTB���������.jpg",0,""),
                new AssistiveDevice(101120610,"�������PTB���������","������","142�������PTB���������.jpg",0,""),
                new AssistiveDevice(101120611,"����˹������֧��","������","143����˹������֧��.jpg",0,""),
                new AssistiveDevice(101120901,"���Ի�ϥ","������","144���Ի�ϥ.jpg",0,""),
                new AssistiveDevice(101120902,"��ϥ������ϥ","������","145��ϥ������ϥ.jpg",0,""),
                new AssistiveDevice(101120903,"�ƹǻ���","������","146�ƹǻ���.jpg",0,""),
                new AssistiveDevice(101120904,"�ƹ��Ѿʽ�����","������","147�ƹ��Ѿʽ�����.jpg",0,""),
                new AssistiveDevice(101120905,"���ʽϥ����������","������","148���ʽϥ����������.jpg",0,""),
                new AssistiveDevice(101120906,"ǰ����ʮ���ʹ������ý�����","������","149ǰ����ʮ���ʹ������ý�����.jpg",0,""),
                new AssistiveDevice(101120907,"����ั�ʹ������û�ϥ","������","150����ั�ʹ������û�ϥ.jpg",0,""),
                new AssistiveDevice(101120908,"ϥ�ؽڹ̶�������","������","151ϥ�ؽڹ̶�������.jpg",0,""),
                new AssistiveDevice(101120909,"�ɵ�ϥ������","������","152�ɵ�ϥ������.jpg",0,""),
                new AssistiveDevice(101120910,"��ϥѹ�����֧����ϥ������","������","153��ϥѹ�����֧����ϥ������.jpg",0,""),
                new AssistiveDevice(101120911,"ģ��ϥ������","������","154ģ��ϥ������.jpg",0,""),
                new AssistiveDevice(101121201,"ϥ����̶�������","������","155ϥ����̶�������.jpg",0,""),
                new AssistiveDevice(101121202,"����֧��ʽϥ���������","������","156����֧��ʽϥ���������.jpg",0,""),
                new AssistiveDevice(101121203,"X���Ƚ�����","������","157X���Ƚ�����.jpg",0,""),
                new AssistiveDevice(101121204,"O���Ƚ�����","������","158O���Ƚ�����.jpg",0,""),
                new AssistiveDevice(101121205,"ȫ������ǳ��ش��Ƚ�����","������","159������ǳ��ش��Ƚ�����.jpg",0,""),
                new AssistiveDevice(101121206,"����������ǳ��ش��Ƚ�����","������","160����������ǳ��ش��Ƚ�����.jpg",0,""),
                new AssistiveDevice(101121207,"�����Ȳ��ý�����","������","161�����Ȳ��ý�����.jpg",0,""),
                new AssistiveDevice(101121301,"����С�Ȼ���","������","162����С�Ȼ���.jpg",0,""),
                new AssistiveDevice(101121302,"С�ȹ̶�����","������","163С�ȹ̶�����.jpg",0,""),
                new AssistiveDevice(101121303,"ģ�ܳ���С�ȹ̶���","������","164ģ�ܳ���С�ȹ̶���.jpg",0,""),
                new AssistiveDevice(101121501,"�Ź̶�������","������","165�ɵ�������չ���Ź̶�������.jpg",0,""),
                new AssistiveDevice(101121502,"����ʽ����չ������","������","166��ʽ֧��.jpg",0,""),
                new AssistiveDevice(101121503,"�ɵ�������չ���Ź̶�������","������","167��ͯ����������λ������.jpg",0,""),
                new AssistiveDevice(101121504,"��ʽ֧��","������","168�Ź̶�������.jpg",0,""),
                new AssistiveDevice(101121505,"��ͯ����������λ������","������","169����ʽ����չ������.jpg",0,""),
                new AssistiveDevice(101121601,"��ϥ������","������","170��ϥ������.jpg",0,""),
                new AssistiveDevice(101121701,"�������Ȼ���","������","171�������Ȼ���.jpg",0,""),
                new AssistiveDevice(101121702,"���ȹ̶�����","������","172���ȹ̶�����.jpg",0,""),
                new AssistiveDevice(101121703,"ģ�ܳ��ʹ��ȹ̶���","������","173ģ�ܳ��ʹ��ȹ̶���.jpg",0,""),
                new AssistiveDevice(101121801,"����֧��ʽ�Ŵ��Ƚ�����","������","174����֧��ʽ�Ŵ��Ƚ�����.jpg",0,""),
                new AssistiveDevice(101121802,"ģ�ܳ����Ŵ��Ƚ�����","������","175ģ�ܳ����Ŵ��Ƚ�����.jpg",0,""),
                new AssistiveDevice(101121803,"���ǳ����Ŵ��Ƚ�����","������","176���ǳ����Ŵ��Ƚ�����.jpg",0,""),
                new AssistiveDevice(101121901,"���������������Ŵ��Ƚ�����","������","177���������������Ŵ��Ƚ�����.jpg",0,""),
                new AssistiveDevice(101121902,"�����������������Ŵ��Ƚ�����","������","178�����������������Ŵ��Ƚ�����.jpg",0,""),
                new AssistiveDevice(101121903,"��֫Ťת������","������","179��֫Ťת������.jpg",0,""),
                new AssistiveDevice(101121904,"����ڶ�ʽ��̱���߽�������RGO��","������","180����ڶ�ʽ��̱���߽�����.jpg",0,""),
                new AssistiveDevice(101121905,"��λ��̱���߽�������ARGO��","������","181��λ��̱���߽�������ARGO��.jpg",0,""),
                new AssistiveDevice(101122001,"��-ֺ����","������","182��-ֺ����.jpg",0,""),
                new AssistiveDevice(101122101,"���������ʽ�׽���","������","183���������ʽ�׽���.jpg",0,""),
                new AssistiveDevice(101122102,"����ŵ���ɵ��׽���","������","184����ŵ���ɵ��׽���.jpg",0,""),
                new AssistiveDevice(101122103,"����ŵ�������ʽ�׽���","������","185����ŵ�������ʽ�׽���.jpg",0,""),
                new AssistiveDevice(101122104,"�����˫��ɵ��⣨�ڣ���֧��ʽ�׽���","������","186�����˫��ɵ��⣨�ڣ���֧��ʽ�׽���.jpg",0,""),
                new AssistiveDevice(101122401,"����ʽ����ϥ����","������","187����ʽ����ϥ����.jpg",0,""),
                new AssistiveDevice(101122402,"�价��ϥ����","������","188�价��ϥ����.jpg",0,""),
                new AssistiveDevice(101122403,"��צ��ϥ����","������","189��צ��ϥ����.jpg",0,""),
                new AssistiveDevice(101122404,"��λ��ʽ��ϥ����","������","190��λ��ʽ��ϥ����.jpg",0,""),
                new AssistiveDevice(101122701,"����ʽ�����Ž���","������","191����ʽ�����Ž���.jpg",0,""),
                new AssistiveDevice(101122702,"�价���Ž���","������","192�价���Ž���.jpg",0,""),
                new AssistiveDevice(101122703,"��צ���Ž���","������","193��צ���Ž���.jpg",0,""),
                new AssistiveDevice(101330701,"���и��ֽ��θ��Ľ���Ь","������","194���и��ֽ��θ��Ľ���Ь.jpg",0,""),
                new AssistiveDevice(101330702,"���и��ֽ����ƵĽ���Ь","������","195���и��ֽ����ƵĽ���Ь.jpg",0,""),
                new AssistiveDevice(101330703,"��ƽ�����Ь","������","196��ƽ�����Ь.jpg",0,""),
                new AssistiveDevice(101330704,"���������Ь","������","197���������Ь.jpg",0,""),
                new AssistiveDevice(101330705,"�ڣ��⣩�������Ь","������","198�ڣ��⣩�������Ь.jpg",0,""),
                new AssistiveDevice(101330706,"���������Ь","������","199���������Ь.jpg",0,""),
                new AssistiveDevice(101331801,"����Ь����Ь��","������","200����Ь����Ь��.jpg",0,""),
                new AssistiveDevice(101331802,"����Ь����Ь��","������","201����Ь����Ь).jpg",0,""),
                new AssistiveDevice(101332101,"������ȱЬ","������","202������ȱЬ.jpg",0,""),
                new AssistiveDevice(101332102,"������ȱЬ","������","203������ȱЬ.jpg",0,""),
                new AssistiveDevice(101333001,"�Ź�Сͷ���Ь","������","204�Ź�Сͷ���Ь.jpg",0,""),
                new AssistiveDevice(101333002,"���Ǵ����Ь","������","205���Ǵ����Ь.jpg",0,""),
                new AssistiveDevice(101333301,"���Ь","������","206���Ь.jpg",0,""),
                new AssistiveDevice(101333302,"����Ь","������","207����Ь.jpg",0,""),
                #endregion

                #region ������
                new AssistiveDevice(10506,"������","������"),

                new AssistiveDevice(1050606,"���ʽ����ʽ��������","������"),
                new AssistiveDevice(1050609,"�۾�ʽ������","������"),
                new AssistiveDevice(1050615,"����ʽ������","������"),
                new AssistiveDevice(1050612,"����ʽ������","������"),
                new AssistiveDevice(1050613,"����ʽ������","������"),
                new AssistiveDevice(1050614,"�����ʽ������","������"),
                new AssistiveDevice(1050617,"�˹�����","������"),
                new AssistiveDevice(1050618,"�ǵ�ʽ������","������"),
                new AssistiveDevice(1050627,"���������","������"),

                new AssistiveDevice(105060601,"��ʽ������","������","836��ʽ������.jpg",0,""),
                new AssistiveDevice(105060901,"�۾�ʽ������","������","837�۾�ʽ������.jpg",0,""),
                new AssistiveDevice(105061201,"����ʽ������","������","839����ʽ������.jpg",0,""),
                new AssistiveDevice(105061301,"����ʽ������","������","840����ʽ������.jpg",0,""),
                new AssistiveDevice(105061401,"�����ʽ������","������","841�����ʽ������.jpg",0,""),
                new AssistiveDevice(105061501,"����ʽ������","������","838����ʽ������.jpg",0,""),
                new AssistiveDevice(105061701,"�˹�����","������","842�˹�����.jpg",0,""),
                new AssistiveDevice(105061801,"�ǵ�ʽ������","������","843�ǵ�ʽ������.jpg",0,""),
                new AssistiveDevice(105062701,"���������","������","844���������.jpg",0,""),
                #endregion

                #region ������
                new AssistiveDevice(10503,"������������","������"),
                new AssistiveDevice(10512,"�滭����д��������","������"),

                new AssistiveDevice(1050303,"�˹���","������"),
                new AssistiveDevice(1050306,"�۾��������۾�","������"),
                new AssistiveDevice(1050309,"���зŴ��ܵ��۾�����Ƭ������ϵͳ","������"),
                new AssistiveDevice(1050312,"˫Ͳ��Զ���͵�Ͳ��Զ��","������"),
                new AssistiveDevice(1051203,"�ֶ�ʽ�滭����д����","������"),
                new AssistiveDevice(1051206,"��д�塢��ͼ��ͻ滭��","������"),
                new AssistiveDevice(1051209,"ǩ�ֵ���ۡ�ӡ�º���д��","������"),
                new AssistiveDevice(1051212,"��дä����дװ��","������"),
                new AssistiveDevice(1051215,"���ֻ�","������"),
                new AssistiveDevice(1051218,"������дֽ����Ĥ��","������"),
                new AssistiveDevice(1051221,"��Яʽä�ļ�¼װ��","������"),
                new AssistiveDevice(1051224,"���ִ������","������"),
                new AssistiveDevice(1051227,"��ͼ�ͻ滭���","������"),

                new AssistiveDevice(105030301,"������ר���˹⾵","������","800������ר���˹⾵.jpg",0,""),
                new AssistiveDevice(105030302,"�˹���","������","801�˹�������ͼƬ.jpg",0,""),
                new AssistiveDevice(105030601,"�۾��������۾�","������","802�۾��������۾�.jpg",0,""),
                new AssistiveDevice(105030901,"�ֳ�ʽ�Ŵ�","������","803�ֳ�ʽ�Ŵ�.jpg",0,""),
                new AssistiveDevice(105030902,"̨��ʽ�Ŵ�","������","804̨��ʽ�Ŵ�.jpg",0,""),
                new AssistiveDevice(105030903,"�۵�ʽ�Ŵ�","������","805�۵�ʽ�Ŵ�.jpg",0,""),
                new AssistiveDevice(105030904,"��Яʽ�Ŵ�","������","806��Яʽ�Ŵ�.jpg",0,""),
                new AssistiveDevice(105030905,"��ֽʽ������","������","807��ֽʽ������.jpg",0,""),
                new AssistiveDevice(105030906,"�ɵ���ʽ�Ŵ�","������","808�ɵ���ʽ�Ŵ�.jpg",0,""),
                new AssistiveDevice(105030907,"����ʽ�Ŵ�","������","809����ʽ�Ŵ�.jpg",0,""),
                new AssistiveDevice(105030908,"����Ŵ�","������","810����Ŵ�.jpg",0,""),
                new AssistiveDevice(105030909,"�����Ŵ�","������","811�����Ŵ�.jpg",0,""),
                new AssistiveDevice(105030910,"�����澵Ƭ��ʽ�Ŵ�","������","812�����澵Ƭ��ʽ�Ŵ󾵣�Ӣ����.jpg",0,""),
                new AssistiveDevice(105030911,"��ʽ�Ŵ�","������","813��ʽ�Ŵ�.jpg",0,""),
                new AssistiveDevice(105030912,"��Ͳ�Ŵ�","������","814��Ͳ�Ŵ�����ͼƬ.jpg",0,""),
                new AssistiveDevice(105030913,"˫Ŀ�۾�","������","815˫Ŀ�۾�.jpg",0,""),
                new AssistiveDevice(105030914,"����Ƭ��ʽ�Ŵ� ","������","816����Ƭ��ʽ�Ŵ�.jpg",0,""),
                new AssistiveDevice(105030915,"���α�Яʽ�Ӿ���д�Ŵ�","������","817���α�Яʽ�Ӿ���д�Ŵ�.jpg",0,""),
                new AssistiveDevice(105030916,"��ʽ��д����ʽ�Ŵ�","������","818��ʽ��д����ʽ�Ŵ�.jpg",0,""),
                new AssistiveDevice(105030917,"��������Ŵ�","������","819��������Ŵ󾵣�Ӣ����.jpg",0,""),
                new AssistiveDevice(105030918,"�ع�ʽ���ƷŴ�","������","820�ع�ʽ���ƷŴ�.jpg",0,""),
                new AssistiveDevice(105030919,"��Яʽ����������","������","821��Яʽ����������.jpg",0,""),
                new AssistiveDevice(105030920,"�ֳ�ʽ����������","������","822�ֳ�ʽ����������.jpg",0,""),
                new AssistiveDevice(105030921,"�ֳ�ʽԶ�����õ���������","������","823�ֳ�ʽԶ�����õ���������.jpg",0,""),
                new AssistiveDevice(105030922,"����","������","824����.jpg",0,""),
                new AssistiveDevice(105030923,"��ЯʽԶ�����õ���������","������","825��ЯʽԶ�����õ���������.jpg",0,""),
                new AssistiveDevice(105030924,"̨ʽ��ЯԶ�����õ���������","������","826̨ʽ��ЯԶ�����õ���������.jpg",0,""),
                new AssistiveDevice(105030925,"̨ʽ����������","������","827̨ʽ����������.jpg",0,""),
                new AssistiveDevice(105030926,"һ��ʽ�����Ķ���","������","828һ��ʽ�����Ķ���.jpg",0,""),
                new AssistiveDevice(105030927,"�г���Ƭ�۾�ʽ�Ŵ�","������","829�г���Ƭ�۾�ʽ�Ŵ�.jpg",0,""),
                new AssistiveDevice(105030928,"�۾�ʽ������","������","830�۾�ʽ����������֬Ƭ��.jpg",0,""),
                new AssistiveDevice(105030929,"��Яʽ�۾����ӷŴ�","������","831��Яʽ�۾����ӷŴ�.jpg",0,""),
                new AssistiveDevice(105031201,"�۾�ʽ��Զ��","������","832�۾�ʽ��Զ��.jpg",0,""),
                new AssistiveDevice(105031202,"ָ����Զ��","������","833ָ����Զ��.jpg",0,""),
                new AssistiveDevice(105031203,"��Ͳ��Զ��","������","834��Ͳ��Զ��.jpg",0,""),
                new AssistiveDevice(105031204,"˫Ͳ��Զ��","������","835˫Ͳ��Զ��.jpg",0,""),
                new AssistiveDevice(105120301,"ä��ר���ľ�","������","847ä��ר���ľ�.jpg",0,""),
                new AssistiveDevice(105120302,"ä��ѧϰ��ֱ��","������","848ä��ѧϰ��ֱ��.jpg",0,""),
                new AssistiveDevice(105120303,"ä��ѧϰ�����ǳ�","������","849ä��ѧϰ�����ǳ�45��.jpg",0,""),
                new AssistiveDevice(105120304,"ä��ѧϰ��������(���ʽ)","������","850ä��ѧϰ��������(���ʽ).jpg",0,""),
                new AssistiveDevice(105120305,"ä��ѧϰ��Բ��","������","851ä��ѧϰ��Բ��.jpg",0,""),
                new AssistiveDevice(105120306,"Сд�ֱ�","������","852Сд�ֱ�.jpg",0,""),
                new AssistiveDevice(105120307,"ä�ļ��±�","������","853ä�ļ��±�����ͼƬ.jpg",0,""),
                new AssistiveDevice(105120601,"��������д��","������","854��������д��.jpg",0,""),
                new AssistiveDevice(105120602,"ä���û�ͼ��","������","855ä���û�ͼ������ͼƬ.jpg",0,""),
                new AssistiveDevice(105120603,"ä���û滭��","������","856ä���û滭������ͼƬ.jpg",0,""),
                new AssistiveDevice(105120901,"ä������д��","������","857ä������д������ͼƬ.jpg",0,""),
                new AssistiveDevice(105120902,"ä����ӡ��","������","858ä����ӡ������ͼƬ.jpg",0,""),
                new AssistiveDevice(105120903,"ä����ǩ�ֵ����","������","859ǩ�ֵ���ۡ�ӡ�º���д��.jpg",0,""),
                new AssistiveDevice(105121201,"��������д�ְ�4��","������","860��������д�ְ�4��.jpg",0,""),
                new AssistiveDevice(105121202,"���Ͻ�д�ְ�6��","������","861���Ͻ�д�ְ�6��.jpg",0,""),
                new AssistiveDevice(105121203,"����д�ְ�27��","������","862����д�ְ�27��.jpg",0,""),
                new AssistiveDevice(105121204,"ä�˿��ֵ��","������","863ä�˿��ֵ��.jpg",0,""),
                new AssistiveDevice(105121501,"ä���ֶ����ֻ�","������","864ä�˴��ֻ�.jpg",0,""),
                new AssistiveDevice(105121801,"������дֽ����Ĥ��","������","865������дֽ����Ĥ��.jpg",0,""),
                new AssistiveDevice(105122101,"��Яʽä�ļ�¼װ��","������","866��Яʽä�ļ�¼װ��.jpeg",0,""),
                new AssistiveDevice(105122401,"ä�ļ�����༭�Ű����","������","867ä�ļ�����༭�Ű����.jpg",0,""),
                new AssistiveDevice(105122402,"�Ӿ����Ƽ�������","������","868�Ӿ����Ƽ�����������ͼƬ.jpg",0,""),
                new AssistiveDevice(105122701,"ä�Ļ�ͼ����","������","869ä�Ļ�ͼ����.jpg",0,""),
                #endregion

                #region ϴ����
                new AssistiveDevice(10333,"��ϴ����ԡ����ԡ��������","ϴ����"),

                new AssistiveDevice(1033303,"��ԡ����ԡ�Ρ�ԡ�����塢���ӡ���������","ϴ����"),
                new AssistiveDevice(1033306,"������ԡ��桢��ԡ��ʹ���","ϴ����"),
                new AssistiveDevice(1033309,"��ԡ������Ԫ��","ϴ����"),
                new AssistiveDevice(1033312,"ϴԡ������ԡ���͸�������","ϴ����"),
                new AssistiveDevice(1033315,"ϴ��","ϴ����"),
                new AssistiveDevice(1033318,"��ԡ��","ϴ����"),
                new AssistiveDevice(1033321,"ԡ��","ϴ����"),
                new AssistiveDevice(1033322,"ϴԡ����","ϴ����"),
                new AssistiveDevice(1033327,"���ڼ���ԡ�׵ĳ��Ȼ���ȵĸ�������","ϴ����"),
                new AssistiveDevice(1033330,"���а��֡��ֱ����հѵ�ϴ�貼�������ˢ��","ϴ����"),
                new AssistiveDevice(1033345,"ԡ���¶ȼ�","ϴ����"),

                new AssistiveDevice(103330301,"ϴԡ����","ϴ����","681ϴԡ����.jpg",0,""),
                new AssistiveDevice(103330302,"�޷���ϴԡ��","ϴ����","682�޷���ϴԡ��.jpg",0,""),
                new AssistiveDevice(103330303,"������ϴԡ��","ϴ����","683������ϴԡ��.jpg",0,""),
                new AssistiveDevice(103330304,"����ϴԡ��","ϴ����","684����ϴԡ��.jpg",0,""),
                new AssistiveDevice(103330305,"����ϴԡ��","ϴ����","685����ϴԡ��.jpg",0,""),
                new AssistiveDevice(103330401,"�޷���ϴԡ��","ϴ����","686�޷���ϴԡ��.jpg",0,""),
                new AssistiveDevice(103330402,"������ϴԡ��","ϴ����","687������ϴԡ��.jpg",0,""),
                new AssistiveDevice(103330501,"ϴԡ��","ϴ����","688��ԡ��.jpg",0,""),
                new AssistiveDevice(103330601,"���������","ϴ����","689���������.jpg",0,""),
                new AssistiveDevice(103330701,"ԡ�׷�����","ϴ����","690ԡ�׷�����.jpg",0,""),
                new AssistiveDevice(103330901,"������ԡͷλ�õĹ̶�Ԫ��","ϴ����","691������ԡͷλ�õĹ̶�Ԫ��.jpg",0,""),
                new AssistiveDevice(103331201,"ϴԡ��","ϴ����","692ϴԡ��.jpg",0,""),
                new AssistiveDevice(103331202,"ϴԡ̨","ϴ����","693ϴԡ̨.jpg",0,""),
                new AssistiveDevice(103331501,"����ʽϴͷ��","ϴ����","694����ʽϴͷ��.jpg",0,""),
                new AssistiveDevice(103331502,"�̶�ʽϴ��","ϴ����","695�̶�ʽϴ������ͼƬ.jpg",0,""),
                new AssistiveDevice(103331503,"��Яʽϴ��","ϴ����","696��Яʽϴ������ͼƬ.jpg",0,""),
                new AssistiveDevice(103331504,"�߶ȿɵ��ڵ�ϴ��֧��","ϴ����","697�߶ȿɵ��ڵ�ϴ��֧������ͼƬ.jpg",0,""),
                new AssistiveDevice(103331505,"�߶ȿɵ��ڵ�ϴ�������֧��","ϴ����","698�߶ȿɵ��ڵ�ϴ�������֧������ͼƬ.jpg",0,""),
                new AssistiveDevice(103331801,"�̶���ԡ��","ϴ����","699�̶���ԡ������ͼƬ.jpg",0,""),
                new AssistiveDevice(103331802,"��Яʽ��ԡ��","ϴ����","700��Яʽ��ԡ������ͼƬ.jpg",0,""),
                new AssistiveDevice(103332101,"����ԡ��","ϴ����","701����ԡ��.jpg",0,""),
                new AssistiveDevice(103332201,"ϴԡ����","ϴ����","702ϴԡ����.jpg",0,""),
                new AssistiveDevice(103332701,"ԡ����һ��̤��","ϴ����","703ԡ����һ��̤��.jpg",0,""),
                new AssistiveDevice(103332702,"ԡ���ö���̤��","ϴ����","704ԡ���ö���̤��.jpg",0,""),
                new AssistiveDevice(103333001,"���а��ֵĺ���","ϴ����","705���а��ֵĺ���.jpg",0,""),
                new AssistiveDevice(103333002,"����ʽϴԡ����","ϴ����","706����ʽϴԡ����.jpg",0,""),
                new AssistiveDevice(103333003,"����ϴ��ˢ","ϴ����","707����ϴԡˢ.jpg",0,""),
                new AssistiveDevice(103333004,"�������ˢ","ϴ����","708���ϴԡˢ.jpg",0,""),
                new AssistiveDevice(103333005,"������ԡˢ","ϴ����","709������ԡˢ.jpg",0,""),
                new AssistiveDevice(103333006,"���а��ֵ�ϴ�貼","ϴ����","710���а��ֵ�ϴ�貼.jpg",0,""),
                new AssistiveDevice(103334501,"ԡ���¶ȼ�","ϴ����","711ԡ���¶ȼ�����ͼƬ.jpg",0,""),
                #endregion

                #region ������
                new AssistiveDevice(10303,"�·���Ь","������"),
                new AssistiveDevice(10306,"����ʽ���������������","������"),
                new AssistiveDevice(10307,"�ȶ�����ĸ�������","������"),
                new AssistiveDevice(10309,"�����·��ĸ�������","������"),

                new AssistiveDevice(1030305,"����","������"),
                new AssistiveDevice(1030309,"ñ��","������"),
                new AssistiveDevice(1030312,"��ָ���׺Ͳ���ָ����","������"),
                new AssistiveDevice(1030315,"�����׺ͳ���","������"),
                new AssistiveDevice(1030318,"�п����ͳ���","������"),
                new AssistiveDevice(1030321,"����ȹ������ȹ","������"),
                new AssistiveDevice(1030324,"����","������"),
                new AssistiveDevice(1030327,"��Ͳ��Ͷ���","������"),
                new AssistiveDevice(1030330,"˯��","������"),
                new AssistiveDevice(1030333,"ԡ��","������"),
                new AssistiveDevice(1030339,"Χ���Χȹ","������"),
                new AssistiveDevice(1030342,"Ь��ѥ","������"),
                new AssistiveDevice(1030345,"Ь��ѥ�ķ�����������","������"),
                new AssistiveDevice(1030348,"����װ�ú�Ŧ��","������"),
                new AssistiveDevice(1030351,"����ϵ����ʽ�����","������"),
                new AssistiveDevice(1030603,"ͷ��������������","������"),
                new AssistiveDevice(1030606,"�۾��������沿������������","������"),
                new AssistiveDevice(1030609,"������������������������","������"),
                new AssistiveDevice(1030612,"�������۷�����������","������"),
                new AssistiveDevice(1030615,"�ֲ�������������","������"),
                new AssistiveDevice(1030618,"ϥ�������ȷ�����������","������"),
                new AssistiveDevice(1030621,"�����������ֺ�������㲿������������","������"),
                new AssistiveDevice(1030624,"���ɷ�����ȫ�������������","������"),
                new AssistiveDevice(1030627,"����������������","������"),
                new AssistiveDevice(1030701,"�ȶ�����ĸ�������","������"),
                new AssistiveDevice(1030903,"������ʹ�������ĸ�������","������"),
                new AssistiveDevice(1030906,"Ь�κ���ѥ��","������"),
                new AssistiveDevice(1030909,"���¼�","������"),
                new AssistiveDevice(1030912,"�����¹������¹�","������"),
                new AssistiveDevice(1030915,"����������װ��","������"),
                new AssistiveDevice(1030918,"ϵ�۹�","������"),

                new AssistiveDevice(103030501,"�������ε�����","������","518�������ε�����.jpg",0,""),
                new AssistiveDevice(103030502,"����ʽ����","������","519����ʽ����.jpg",0,""),
                new AssistiveDevice(103030901,"ñ��","������","520ñ��.png",0,""),
                new AssistiveDevice(103031201,"��ָ����","������","521��ָ����.jpg",0,""),
                new AssistiveDevice(103031202,"����ָ����","������","522����ָ����.jpg",0,""),
                new AssistiveDevice(103031501,"�࿪����ʽ��࿪���ʽ����","������","523�࿪����ʽ�п���.jpg",0,""),
                new AssistiveDevice(103031502,"�࿪����ʽ��࿪���ʽ����","������","524�࿪����ʽ��࿪���ʽ����.jpg",0,""),
                new AssistiveDevice(103031801,"�࿪����ʽ�п���","������","525�࿪����ʽ�п���.jpg",0,""),
                new AssistiveDevice(103031802,"�࿪����ʽ����","������","526�࿪����ʽ����.jpg",0,""),
                new AssistiveDevice(103031803,"�࿪���ʽ�п���","������","527�࿪���ʽ�п���.jpg",0,""),
                new AssistiveDevice(103031804,"�࿪���ʽ����","������","528�࿪���ʽ����.jpg",0,""),
                new AssistiveDevice(103031805,"�࿪����ʽ����","������","529�࿪����ʽ����.jpg",0,""),
                new AssistiveDevice(103032101,"����ȹ","������","530����ȹ.jpg",0,""),
                new AssistiveDevice(103032102,"����ȹ","������","531����ȹ.jpg",0,""),
                new AssistiveDevice(103032401,"һ�����ڿ�","������","532һ�����ڿ�.jpg",0,""),
                new AssistiveDevice(103032402,"�����������","������","533�����������.jpg",0,""),
                new AssistiveDevice(103032701,"��Ͳ��","������","534��Ͳ��.jpg",0,""),
                new AssistiveDevice(103032702,"����","������","535����.jpg",0,""),
                new AssistiveDevice(103033001,"˯��","������","536˯��.jpg",0,""),
                new AssistiveDevice(103033301,"ԡ��","������","537ԡ��.jpg",0,""),
                new AssistiveDevice(103033901,"Χ��","������","538Χ��.jpg",0,""),
                new AssistiveDevice(103033902,"Χȹ","������","539Χȹ.jpg",0,""),
                new AssistiveDevice(103034201,"����Ь","������","540����Ь.jpg",0,""),
                new AssistiveDevice(103034202,"���㴩��Ь","������","541���㴩��Ь.png",0,""),
                new AssistiveDevice(103034501,"Ь��ѥ�ķ�����������","������","542Ь��ѥ�ķ�����������.jpg",0,""),
                new AssistiveDevice(103034801,"����װ�ú�Ŧ��","������","543����װ�ú�Ŧ��.jpg",0,""),
                new AssistiveDevice(103035101,"����ϵ����ʽ�����","������","544����ϵ����ʽ�����.jpg",0,""),
                new AssistiveDevice(103060301,"����ͷ��","������","545����ͷ��.jpg",0,""),
                new AssistiveDevice(103060601,"��������","������","546��������.jpg",0,""),
                new AssistiveDevice(103060602,"��Ŀ��","������","547��Ŀ��.jpg",0,""),
                new AssistiveDevice(103060901,"����","������","548����.jpg",0,""),
                new AssistiveDevice(103060902,"����","������","549����.jpg",0,""),
                new AssistiveDevice(103060903,"�������","������","550�������.jpg",0,""),
                new AssistiveDevice(103061201,"�������۷�����������","������","551�������۷�����������.jpg",0,""),
                new AssistiveDevice(103061501,"�������ε�����","������","552�������ε�����.jpg",0,""),
                new AssistiveDevice(103061801,"�Ӻ�Ͳ��","������","553�Ӻ�Ͳ��.jpg",0,""),
                new AssistiveDevice(103062101,"Ӳ��Ь","������","554Ӳ��Ь.jpg",0,""),
                new AssistiveDevice(103062102,"�Ӻ���","������","555�Ӻ���.jpg",0,""),
                new AssistiveDevice(103062401,"���ɷ�����ȫ�������������","������","556���ɷ�����ȫ�������������.jpg",0,""),
                new AssistiveDevice(103062701,"������","������","557������.jpg",0,""),
                new AssistiveDevice(103070101,"�ȶ�����ĸ�������","������","558�ȶ�����ĸ�������.jpg",0,""),
                new AssistiveDevice(103090301,"������","������","559������.png",0,""),
                new AssistiveDevice(103090302,"�๦�ܴ��¡���Ь������","������","560�๦�ܴ��¡���Ь������.jpg",0,""),
                new AssistiveDevice(103090601,"��ѥ��","������","561��ѥ��.jpg",0,""),
                new AssistiveDevice(103090602,"����Ь��","������","562����Ь��.png",0,""),
                new AssistiveDevice(103090901,"���¼�","������","563���¼�.jpg",0,""),
                new AssistiveDevice(103091201,"���¸�","������","564���¸�.jpg",0,""),
                new AssistiveDevice(103091202,"��Ь�δ��¸�","������","565��Ь�δ��¸�.png",0,""),
                new AssistiveDevice(103091203,"�����¹�","������","566�����¹�.png",0,""),
                new AssistiveDevice(103091501,"������","������","567������.png",0,""),
                new AssistiveDevice(103091801,"ϵ����","������","568ϵ����.png",0,""),
                #endregion
                
            };
            #endregion
            db.AssistiveDevices.AddRange(AssistiveDevices);
            db.SaveChanges();
            //����

            #region ��������
            List<Question> questions1 = new List<Question> {
                new Question("1", "�����м��ȼ�", 1,
                    new List<Option>{
                        new Option("A","һ��", "1-1-1",0),
                        new Option("B","����", "1-1-1",0),
                        new Option("C","����", "1-2",0),
                        new Option("D","�ļ�", "1-2",0),
                        new Option("E","δ������ȼ���׼", "������",0),
                    }
                ),
                new Question("������", "�ܷ񿴼�",1,
                    new List<Option>{
                        new Option("A", "���ܣ��൱��һ��������", "1-1",0),
                        new Option("B", "�ܣ��൱�������ļ���", "1-2",0),
                    }
                ),
                new Question("1-1", "�ܷ�����",1,
                    new List<Option>{
                        new Option("A", "��", "1-1-1",0),
                        new Option("B", "����", "1-1-2",0),
                    }
                ),
                new Question("1-1-1", "ϣ��ʵ�ֺ��ֹ��ܣ���ѡ��", 2,
                    new List<Option>{
                        //02 39 03ä��
                        new Option("A", "��������", "2",0,1023903),
                        //05 18 03������¼�Ͳ����豸(�����)
                        new Option("B", "��������", "2",0,105180301),
                        //05 27 12ʱ�Ӻͼ�ʱ��(������/���ֱ�)
                        new Option("C", "ʱ������", "2",0,105271204,105271205),
                        //05 24 06�ƶ�����绰(ä�����ֻ�) 05 33 15���������͹�ͨ���
                        new Option("D", "ͨѶ����", "2",0, 105240601,105331501,105331502),
                        //05 27 06���ź�ָʾ��
                        new Option("E", "������", "2",0, 1052706),
                        //03�ֶ�ʽ�滭����д���ߣ�05 12 12��дä����дװ�ã�05 12 18������дֽ����Ĥ��
                        new Option("F", "ѧϰ��д", "2",0, 1051203, 1051212,105121801),
                    }
                ),
                new Question("1-1-2", "ϣ��ʵ�ֺ��ֹ��ܣ���ѡ��", 2,
                    new List<Option>{
                        //02 39 03ä��
                        new Option("A", "��������", "2",0, 1023903),
                        //05 27 12ʱ�Ӻͼ�ʱ��(������/���ֱ�)
                        new Option("B", "ʱ������", "2",0, 105271204,105271205),
                    }
                ),
                new Question("1-2", "ϣ�������ﻹ�ǿ�Զ������ѡ��", 2,
                    new List<Option>{
                        //05 03 12˫Ͳ��Զ���͵�Ͳ��Զ��
                        new Option("A", "��Զ", "1-3",0,1050312),
                        new Option("B", "����", "1-2-1",0),
                    }
                ),
                new Question("1-2-1", "��Ҫ��ѧ���������ǵ���������",1,
                    new List<Option>{
                        //05 03 09���зŴ��ܵ��۾�����Ƭ������ϵͳ��ֻѡ���й�ѧ�ࣩ
                        new Option("A", "��ѧ", "1-3",0, 105030901,105030903,105030904,105030905,105030906,105030907,105030908,105030909,105030910,105030911,105030912,105030913,105030914,105030915,105030916,105030917,105030927,105030928,105030929),
                        //05 03 09���зŴ��ܵ��۾�����Ƭ������ϵͳ��ֻѡ���е����ࣩ
                        new Option("B", "����", "1-3",0, 105030902,105030918,105030919,105030920,105030921,105030922,105030923,105030924,105030925,105030926),
                    }
                ),
                new Question("1-3", "ϣ��ʵ�ֺ��ֹ��ܣ���ѡ��", 2,
                    new List<Option>{
                        //05 30 21 �ַ��Ķ�����05 30 18�Ķ���Ͱ����޶�����05 12 06��д�塢��ͼ��ͻ滭�壻05 12 15���ֻ�
                        new Option("A", "�Ķ�ѧϰ", "2", 0,1053021,1053018,1051206,1051215),
                        //05 24 03��ͨ����绰
                        new Option("B", "����ͨѶ", "2",0, 1052403),
                        //05 15 03�ֶ���������05 15 06�����豸
                        new Option("C", "��ѧ����", "2",0, 1051503,1051506),
                        //05 21 03��ĸ�ͷ��ſ�����
                        new Option("D", "��������", "2",0, 1052103),
                        //05 33 18 ���ڼ����������ĸ���
                        new Option("E", "�����ʹ��", "2",0, 1053318),
                    }
                ),
                new Question("2", "�Ƿ����ѣ������",1,
                    new List<Option>{
                        //05 03 03�˹�����������ר���˹⾵
                        new Option("A", "��", "3",0, 105030301),
                        new Option("B", "��", "3",0),
                    }
                ),
                new Question("3", "�Ƿ�������˵��", 1,
                    new List<Option>{
                        new Option("A", "��",null),
                        new Option("B", "����", "3-1"),
                    }
                ),
                new Question("3-1", "�Ƿ��д��",1,
                    new List<Option>{
                        //05 12 12��дä����дװ�ã�05 09 03����������
                        new Option("A", "��", null,0,1051212,1050903),
                        new Option("B", "����",null),
                    }
                ),
            };
            Exam exam1 = new Exam(1, "FuJuPingGu", "����", questions1);
            db.Exams.AddOrUpdate(exam1);
            #endregion

            #region ��������
            List<Question> questions2 = new List<Question> {
                new Question("1", "�����м��ȼ�", 1,
                    new List<Option>{
                        ////ѡAʱ��������䣬ϵͳ����
                        //6�����£�05 06 ������-�˹�����
                        //6��-60�꣺05 06 ������(����/����/����/�����ʽ������)
                        //60�����ϣ�05 06 06���ʽ����ʽ��������
                        new Option("A", "һ��","2",0, 105061501,105061201,105061301,105061401,105061701,105060601),
                        new Option("B", "����","2",0,105061501,105061201,105061301,105061401),
                        new Option("C", "����","2",0, 105061501,105061201,105061301,105061401),
                        new Option("D", "�ļ�","2",0,105061501,105061201,105061301,105061401),
                        new Option("E", "δ������ȼ���׼","1-1"),
                    }
                ),
                new Question("1-1", "�ڰ��������£����������豸ʱ��������",1,
                    new List<Option>{
                        //ѡAʱ��������䣬ϵͳ����
                        new Option("A", "�����������κ���������ͬ��һ����","2",0,105061701,105061501,105061201,105061301,105061401,105060601),
                        new Option("B", "ֻ���������ڡ��ùġ���������������������ͬ�ڶ�����","2",0,105061501,105061201,105061301,105061401),
                        new Option("C", "ֻ����������˵������ͬ��������","2",0,105061501,105061201,105061301,105061401),
                        new Option("D", "��������̸ͨ��������ͬ���ļ���","2",0, 105061501,105061201,105061301,105061401),
                        new Option("E", "����һ������ֱܷ���������丨�����ߣ�","2"),
                    }
                ),
                new Question("2", "�������⣬ϣ��ʵ�ֺ��ֹ���", 1,
                    new List<Option>{
                        //05 21 09�Ի�װ��(������д������/��ͨ��)
                        new Option("A", "���Խ������������ߣ�",null,0, 105210906),
                        //05 27 03�Ӿ��ź�ָʾ��(��������)
                        new Option("B", "����Ӧ��", null,0,1052703),
                        //05 27 12ʱ�Ӻͼ�ʱ��(������)
                        new Option("C", "������", null,0,105271204)
                    }
                )
            };
            Exam exam2 = new Exam(2, "FuJuPingGu", "����", questions2);
            db.Exams.AddOrUpdate(exam2);
            #endregion

            #region ƫ̱����
            List<Question> questions3 = new List<Question>
            {
                new Question("1", "�Ƿ��Դ�", 1,
                    new List<Option>{
                         new Option("A", "��","1-1-1",0, 105271801),
                         new Option("B", "��","1-2-1"),
                    }
                ),
                new Question("1-1-1", "�ܷ���", 1,
                    new List<Option>{
                        //04��ͥ�ͼҾ�-��ʽ�Ҿߣ���������06 33 06������֯�����Ե����Ը������ߣ���ѹ�����棩��07 33 09�����ƶ�ѵ���������ߣ�����������06 33 04������֯�����ԵĿ������С�����棨��λ�棩
                        new Option("A", "����","1-1-2",0, 1040801,1063306,107330905,106330401),
                        //04��ͥ�ͼҾ�-��ʽ�Ҿߣ���������06 33 06������֯�����Ե����Ը������ߣ���ѹ�����棩��06 33 04������֯�����ԵĿ������С�����棨��λ�棩��04 10 09���֣����Ի�����
                        new Option("B", "��","1-1-2", 0,1040801,1063306,106330401,104100901),
                    }
                ),
                new Question("1-1-2", "�ܷ�����", 1,
                    new List<Option>{
                         new Option("A", "����","1-1-3"),
                         //04 10 03������02 22 18�����߲��ݵ����Σ��߿������Σ�
                         new Option("B", "��","1-1-3",0,1041003,102221801),
                    }
                ),
                new Question("1-1-3", "�ܷ���ƴ�С��", 1,
                    new List<Option>{
                         //07 09 03ʧ����������03 30 21����һ�����򲼣�03 30 18����һ���Գĵ棻03 27 18���ռ�ϵͳ��03 31 06����������Ų�����
                         new Option("A", "����","2",0, 1070903,1033021,1033018,1032718,103310602),
                         //03 24����װ��(03 24 15Ů�ô���ʽ�����/03 24 21���ô���ʽ�����)��03 12 33���裨��Яʽ��������/���ϴ���裩
                         new Option("B", "��","2",0,1032415,1032421,103123301,103123302),
                    }
                ),
                new Question("1-2-1", "�ܷ�����", 1,
                    new List<Option>{
                        new Option("A", "����","1-2-1-1"),
                        new Option("B", "��","1-2-2"),
                    }
                ),
                new Question("1-2-1-1", "�ܷ������ƶ����", 1,
                    new List<Option>{
                        //02 22 18�����߲��ݵ����Σ��������Σ�
                        new Option("A", "����","1-2-1-2",0, 102221805),
                        //02 22 03˫���������γ����������Σ�����02 22 09�����������γ�(��������������/ƫ̱����)����02 23 03�綯���γ��������͵綯���Σ�
                        new Option("B", "��","1-2-1-2",0, 102220302,102220901,102230301),
                    }
                ),
                new Question("1-2-1-2", "�Ƿ���ѹ��", 1,
                    new List<Option>{
                         new Option("A", "��","1-2-1-3"),
                         //06 33 03������֯�����Ե�����ͳĵ棨��ѹ�����棩
                         new Option("B", "�����У�������","1-2-1-3",0, 1063303),
                         new Option("C", "��","1-2-1-3",0, 1063303),
                    }
                ),
                new Question("1-2-1-3", "�ܷ�վ�����д�-��ת��", 1,
                    new List<Option>{
                        //07 33 09�����ƶ�ѵ���������ߣ��Ƴ˴����Ƴ˰壩
                         new Option("A", "����","2",0, 1073309),
                         //04 10 09���֣���02 03 03���ȣ�ֱ���Ľ����ȣ��̶�/�ɵ�����
                         new Option("B", "��Ҫ����","2",0,1041009,102030307),
                         new Option("C", "����վ��ת��","2"),
                    }
                ),
                new Question("1-2-2", "����ʱ�Ƿ���Ҫ���", 1,
                    new List<Option>{
                         new Option("A", "ȫ�̲��","1-2-2-1"),
                         //02 03 03���ȣ��������ȣ�
                         new Option("B", "���ֲ��","2", 0,102030301,102030302,102030303),
                         new Option("C", "������","2"),
                    }
                ),
                new Question("1-2-2-1", "����ʱ�Ƿ���Ҫ���", 1,
                    new List<Option>{
                        //02 03 03���ȣ�S���Ľ����ȣ��̶�/�ɵ��������� 02 38 19����������м�
                         new Option("A", "��Ҫ","2",0,102030309,102381901),
                         //02 03 03���ȣ�ֱ���Ľ����ȣ��̶�/�ɵ�����
                         new Option("B", "����Ҫ","2",0,102030307),
                    }
                ),
                new Question("2", "����֫�����״������ѡ��", 2,
                    new List<Option>{
                         //01 06 21�������-�粿����
                         new Option("A", "����³�","3",0, 101062107),
                         //01 06��֫����������01 06 07��-ָ������-��ָ��
                         new Option("B", "��ָ������չ","3",0, 10106,101060701),
                         //01 12��֫������
                         new Option("C", "����ʱ���ϵ�","3", 0,10112),
                    }
                ),
                new Question("3", "�ܷ����н�ʳ", 1,
                    new List<Option>{
                        //04 30 ��ֱ���͸�������-���ࣨ���ò�������������
                         new Option("A", "����","4",0,104301901),
                         //08 18 03ץ��װ�ã������������10 09 18���Ӻ��루��ͨ������/�ײ������̲;ߣ���10 09 21ʳ�ﵲ��(���Ϸ�����)��10 09ʳ����������-���ӣ�б�ڱ�����10 09ʳ����������(�桢�ס�����)
                         new Option("B", "��Ҫ����","4", 0,108180301,110091801,110091803,110092102,110092502,1100922,1100923,1100924),
                         new Option("C", "������ʳ","4"),
                    }
                ),
                new Question("4", "�ܷ�����ϴԡ", 1,
                    new List<Option>{
                        //03 33 12ϴԡ������ԡ���͸���������ϴԡ������03 33 22��ϴ����ԡ����ԡ�������ߣ�ϴԡ��������ϴԡ���Σ�03 33 15ϴ�裨����ʽϴͷ�أ�
                         new Option("A", "����","5",0, 103331201,103332201,103330301,103331501),
                         new Option("B", "��","4-1"),
                    }
                ),
                new Question("4-1", "�Ƿ�վ��ϴԡ", 1,
                    new List<Option>{
                         //03 33 06������ԡ��桢��ԡ��ʹ��ӣ���������棩
                         new Option("A", "��","4-2",0,103330601),
                         //03 33 03��ԡ����ԡ�Ρ�ԡ�����塢���ӡ���������
                         new Option("B", "��","4-2",0, 1033303),
                    }
                ),
                new Question("4-2", "�Ƿ���Ҫϴԡ��������", 1,
                    new List<Option>{
                        //03 33 30���а��֡��ֱ����հѵ�ϴ�貼�������ˢ�ӣ�03 36 06ָ��ﱺ�ɰֽ�壻03 36 09ָ�׼���ָ�׵�
                         new Option("A", "��Ҫ","5",0,1033330,1033606,1033609),
                         new Option("B", "����Ҫ","5"),
                    }
                ),
                new Question("5", "�������ʱ���Ƿ��¶�", 1,
                    new List<Option>{
                         new Option("A", "��","6"),
                         new Option("B", "����","5-1"),
                    }
                ),
                new Question("5-1", "�����Ƿ���������", 1,
                    new List<Option>{
                         new Option("A", "�У��Ҹ߶Ⱥ���","6"),
                         //03 12 18��װ���������ϼӸߵ�������������03 12 21���ð����������µ�����������������������04 10 09���֣�03 12 12����ͼӸߵ���������
                         new Option("B", "�У��߶Ƚϵ�","6", 0,1031218,1031221,1041009,1031212),
                         //03 12 03������
                         new Option("C", "��","6",0, 1031203),
                    }
                ),
                new Question("6", "�ܷ����д�������", 1,
                    new List<Option>{
                        //03 03 18�п����ͳ��㣻03 03 42Ь��ѥ�����㴩��Ь��
                         new Option("A", "���ܣ��Ҹ߶Ⱥ���","7",0, 1030318,1030342),
                        //03 09 12�����¹������¹���03 09 03������ʹ�������ĸ������ߣ�03 09 06Ь�κ���ѥ��������Ь�Σ�
                         new Option("B", "���������","7",0, 1030912,1030903,103090602),
                         new Option("C", "�������","7"),
                    }
                ),
                new Question("7", "�Ƿ񾭳���Ҫ��ʰԶ����Ʒ", 1,
                    new List<Option>{
                         new Option("A", "��","8"),
                         //08 21 03�ֶ�ץȡǯ���۵�ʽ����ȡ����/���۵�ʽ����ȡ������
                         new Option("B", "��","8",0,108210301,108210302),
                    }
                ),
                new Question("8", "�Ƿ������������м�", 1,
                    new List<Option>{
                         new Option("A", "��","9"),
                         new Option("B", "����",1,"9"),
                         new Option("C", "����",2,"9"),
                         new Option("D", "����","9"),
                    }
                ),
                new Question("9", "��ϣ�����ʲô���⣨���ѡ��������", 8,
                    new List<Option>{
                         new Option("A", "���δ���",null),
                         new Option("B", "��������",null),
                         new Option("C", "��ʳ",null),
                         new Option("D", "���˻���",null),
                         new Option("E", "���",null),
                         new Option("F", "��Ϣ����",null),
                         new Option("G", "����ѵ��",null),
                         new Option("H", "��������",null),
                         new Option("I", "���ϰ�����",8,null),
                         new Option("J", "������ʹ��",null),
                         new Option("K", "λ��ת��",null),
                         new Option("L", "��������",null),
                         new Option("M", "��֫",7,null),
                         new Option("N", "������",null),
                         new Option("O", "������",null),
                         new Option("P", "������",null),
                         new Option("Q", "ϴ����",null),
                         new Option("R", "������",null),
                    }
                ),
            };
            Exam exam3 = new Exam(3, "FuJuPingGu", "ƫ̱", questions3);
            db.Exams.AddOrUpdate(exam3);
            #endregion

            #region ��̱����
            List<Question> questions4 = new List<Question>
            {
                new Question("1", "����", 1,
                    new List<Option>{
                         new Option("A", "��7��","2-1"),
                         new Option("B", ">7��","3-1"),
                    }
                ),
                #region ���䣨<= 7����
                new Question("2-1", "�ܷ���ɡ����𡱶���", 1,
                    new List<Option>{
                         new Option("A", "��ȫ����","2-1-1"),
                         new Option("B", "��Ҫ�������","2-1-2"),
                         new Option("C", "���踨���ܶ������","2-1-2"),
                    }
                ),
                new Question("2-1-1", "�ܷ���", 1,
                    new List<Option>{
                         new Option("A", "��ȫ����","2-1-1-1"),
                         //06 33 04������֯�����ԵĿ������С������(Ш�ε�)��02 22 18�����߲��ݵ����γ�(0-3��Ϊ��ͯ���Σ�4-7��Ϊ��ͯ��̱����)
                         new Option("B", "��Ҫ����","2-2",0,106330402,1022218),
                         //04 09 21�������ߣ�0-3��Ϊ��ͯ�����Σ�4-7��Ϊ��ͯ�����Σ���02 22 18�����߲��ݵ����γ�(0-3��Ϊ��ͯ���Σ�4-7��Ϊ��ͯ��̱����)
                         new Option("C", "���踨���������","2-2",0,1040921,102218),
                    }
                ),
                new Question("2-1-1-1", "�ܷ�̧ͷ", 1,
                    new List<Option>{
                         //06 33 04������֯�����ԵĿ������С�����棨��λ�任��ϵ棩
                         new Option("A", "��ȫ����","2-2",0,106330401),
                         //06 33 04������֯�����ԵĿ������С������(Ш�ε�)��02 22 18�����߲��ݵ����γ�(0-3��Ϊ��ͯ���Σ�4-7��Ϊ��ͯ��̱����)
                         new Option("B", "����̧ͷ������ά��","2-2",0,106330402,1022218),
                         //06 33 04������֯�����ԵĿ������С������(Ш�ε�)��02 22 18�����߲��ݵ����γ�(0-3��Ϊ��ͯ���Σ�4-7��Ϊ��ͯ��̱����)
                         new Option("C", "��̧ͷ����ά��","2-2",0,106330402,1022218),
                    }
                ),
                new Question("2-1-2", "�ܷ�ά����λ", 1,
                    new List<Option>{
                        //04 09 21��������(0-3��Ϊ�����Σ�4-7��Ϊ��ͯ������)��02 22 18�����߲��ݵ����γ�(0-3��Ϊ��ͯ���Σ�4-7��Ϊ��ͯ��̱����)
                         new Option("A", "��ȫ����","2-2",0,1040921,1022218),
                         //04 09 21��������(0-3��Ϊ�����Σ�4-7��Ϊ��ͯ������)��02 22 18�����߲��ݵ����γ�(0-3��Ϊ��ͯ���Σ�4-7��Ϊ��ͯ��̱����)
                         new Option("B", "�����¿�ά��","2-2",0,1040921,1022218),
                         new Option("C", "���踨���ɶ���","2-1-2-1"),
                    }
                ),
                new Question("2-1-2-1", "�ܷ�����", 1,
                    new List<Option>{
                         new Option("A", "��ȫ����","2-1-2-1-1"),
                         new Option("B", "���������� ","2-1-2-1-1"),
                         new Option("C", "�������� ","2-2"),
                    }
                ),
                new Question("2-1-2-1-1", "�ܷ�����֡���֧��", 1,
                    new List<Option>{
                         //01 06 19�����ֽ�������06 48����ѵ����������(��ͯ���м�)
                         new Option("A", "��ȫ����","2-2",0,1010619,106483101),
                         //01 06 19�����ֽ�������06 48����ѵ����������(��ͯ���м�)
                         new Option("B", "����֧�ţ�����ά��","2-2",0,1010619,106483101),
                         new Option("C", "��֧������ά��","2-1-2-1-1-1"),
                    }
                ),
                new Question("2-1-2-1-1-1", "�ܷ���ɡ�վ�𡱶���", 1,
                    new List<Option>{
                         //06 48 15��֫ѵ����е������ѵ����е����֫ѵ����е(��ľ)
                         new Option("A", "��ȫ����","2-2",0,1064815),
                         //02 06 03��ʽ���м�(���ݿ�ʽ������)
                         new Option("B", "��Ҫ����","2-2",0,102060303),
                         new Option("C", "���踨���������","2-1-2-1-1-1-1"),
                    }
                ),
                new Question("2-1-2-1-1-1-1", "�ܷ�ά��վ��", 1,
                    new List<Option>{
                         //06 48 08վ���ܺ�վ��֧��̨(��ͯ������ʽվ����)
                         new Option("A", "��ȫ����","2-2",0,106480802),
                         //06 48 08վ���ܺ�վ��֧��̨(��ͯ��ֱ��ʽվ����)����ͯ���м�
                         new Option("B", "��Ҫ����","2-2",0,106480801),
                         //02 06 06��ʽ������(��������������)
                         new Option("C", "���踨���ɶ�վ","2-2",0,102060607),
                    }
                ),
                new Question("2-2", "�Ƿ���ڻ���", 1,
                    new List<Option>{
                         new Option("A", "�����ڻ���","2-3"),
                         new Option("B", "���ڻ���","2-2-1"),
                    }
                ),
                new Question("2-2-1", "���ڻ��β�λ����ѡ��", 2,
                    new List<Option>{
                         //��֫������
                         new Option("A", "��֫����","2-3",0,10106),
                         //���ɽ�����
                         new Option("B", "���ɻ���","2-3",0,10103,10104),
                         //��֫������
                         new Option("C", "��֫����","2-3",0,10112,10133),
                    }
                ),
                new Question("2-3", "�ܷ񹻶�����ʳ����ˮ", 1,
                    new List<Option>{
                         new Option("A", "����","2-3-1"),
                         new Option("B", "��","2-4"),
                    }
                ),
                new Question("2-3-1", "˫���Ƿ��ܹ�ץ��", 1,
                    new List<Option>{
                         //08 18 03ץ��װ��(�������)��10 09����(���������Ϊ�������)��10 09 18��(������)��10 09 21ʳ�ﵲ��(���Ϸ�����)��10 09�棨�ֱ��棩����(�ֱ���)
                         new Option("A", "��ȫ����","2-4",0,108180301,110092503,1100918,110092102,110092201,110092303),
                         //08 18 03ץ��װ��(�������)��10 09����(���������Ϊ�������)��10 09 18��(������)��10 09 21ʳ�ﵲ��(���Ϸ�����)��10 09�棨�ֱ��棩����(�ֱ���)
                         new Option("B", "����ץ�գ�����ά��","2-4",0,108180301,110092503,1100918,110092102,110092201,110092303),
                         new Option("C", "��ץ����ά��","2-4"),
                    }
                ),
                new Question("2-4", "�ܷ�����ϲ���", 1,
                    new List<Option>{
                         //03 30 12��ͯ��һ����ʧ����Ʒ(��ͯ��ʪ)��03 12 33����
                         new Option("A", "����","6",0,103301201,1031233),
                         new Option("B", "��","6"),
                    }
                ),
                #endregion
                #region ���䣨>7����
                new Question("3-1", "�ܷ���ɡ����𡱶���", 1,
                    new List<Option>{
                         new Option("A", "��ȫ����","3-1-1"),
                         new Option("B", "��Ҫ�������","3-1-2"),
                         new Option("C", "���踨���ܶ������","3-1-2"),
                    }
                ),
                new Question("3-1-1", "�ܷ���", 1,
                    new List<Option>{
                         new Option("A", "��ȫ����","3-1-1-1"),
                         //06 33 04������֯�����ԵĿ������С������(Ш�ε�)��02 22 18�����߲��ݵ����γ�(��̱����)��04��ͥ�ͼҾ�-��ʽ�Ҿߣ���������06 33 06������֯�����Ե����Ը������ߣ���ѹ�����棩
                         new Option("B", "��Ҫ����","3-2",0,106330402,1022218,1040801,1063306),
                         //02 22 18�����߲��ݵ����γ�-�߿������Σ�������/����������
                         new Option("C", "���踨���������","3-2",0,102221801),
                    }
                ),
                new Question("3-1-1-1", "�Ƿ���̧ͷ", 1,
                    new List<Option>{
                         //06 33 04������֯�����ԵĿ������С�����棨��λ�任��ϵ棩��04��ͥ�ͼҾ�-��ʽ�Ҿߣ���������06 33 06������֯�����Ե����Ը������ߣ���ѹ�����棩
                         new Option("A", "��ȫ����","3-2",0,106330401,1040801,1063306),
                         //06 33 04������֯�����ԵĿ������С������(Ш�ε�)��02 22 18�����߲��ݵ����γ�(��̱����)��04��ͥ�ͼҾ�-��ʽ�Ҿߣ���������06 33 06������֯�����Ե����Ը������ߣ���ѹ�����棩��04 10 09����(���Ի���)
                         new Option("B", "����̧ͷ������ά��","3-2",0,106330402,1022218,1040801,1063306,104100901),
                         //06 33 04������֯�����ԵĿ������С������(Ш�ε�)��02 22 18�����߲��ݵ����γ�(��̱����)��04��ͥ�ͼҾ�-��ʽ�Ҿߣ���������06 33 06������֯�����Ե����Ը������ߣ���ѹ�����棩��04 10 09����(���Ի���)
                         new Option("C", "��̧ͷ����ά��","3-2",0,106330402,1022218,1040801,1063306,104100901),
                    }
                ),
                new Question("3-1-2", "�ܷ�ά����λ", 1,
                    new List<Option>{
                         //02 22 18�����߲��ݵ����γ�(��̱����)��04 10 03�������ɵ�������
                         new Option("A", "��ȫ����","3-2",0,1022218,104100301),
                         //02 22 18�����߲��ݵ����γ�(��̱����)��04 10 03�������ɵ�������
                         new Option("B", "�����¿�ά��","3-2",0,1022218,104100301),
                         new Option("C", "���踨���ɶ���","3-1-2-1"),
                    }
                ),
                new Question("3-1-2-1", "�ܷ���ɡ�վ�𡱶���", 1,
                    new List<Option>{
                        //02 22 03˫���������γ�(��ͨ����)��07 33 09�����ƶ�ѵ���������ߣ�ת���������Ƴ˴�����Ϊ�Ƴ˴���
                         new Option("A", "��ȫ����","3-2",0,102220301,1073309),
                         //06 48 08վ���ܺ�վ��֧��̨(վ����)��02 06 03��ʽ���м�(���ݿ�ʽ������)��07 33 09�����ƶ�ѵ���������ߣ�ת���������Ƴ˴�����Ϊ�Ƴ˴���
                         new Option("B", "��Ҫ����","3-2",0,1064808,102060303,1073309),
                         new Option("C", "���踨���������","3-1-2-1-1"),
                    }
                ),
                new Question("3-1-2-1-1", "�ܷ�ά��վ��", 1,
                    new List<Option>{
                        //06 48 08վ���ܺ�վ��֧��̨(վ����)
                         new Option("A", "��ȫ����","3-2",0,1064808),
                         //06 48 08վ���ܺ�վ��֧��̨(վ����)��02 06 06��ʽ������(��������������)
                         new Option("B", "��Ҫ����","3-2",0,1064808,102060607),
                         new Option("C", "���踨���ɶ�վ","3-1-2-1-1-1"),
                    }
                ),
                new Question("3-1-2-1-1-1", "�ܷ�����", 1,
                    new List<Option>{
                         new Option("A", "��ȫ����","3-2"),
                         //02 06 06��ʽ������(��������������)
                         new Option("B", "��Ҫ�϶ศ��","3-2",0,102060607),
                         //02 03 12Ҹ��(��ͯҸ��)
                         new Option("C", "��Ҫ���ٸ���","3-2",0,102031207),
                         new Option("D", "���踨����������","3-2"),
                    }
                ),
                new Question("3-2", "�Ƿ���ڻ���", 1,
                    new List<Option>{
                         new Option("A", "�����ڻ���","3-3"),
                         new Option("B", "���ڻ���","3-2-1"),
                    }
                ),
                new Question("3-2-1", "���ڻ��β�λ����ѡ��", 2,
                    new List<Option>{
                         //��֫������
                         new Option("A", "��֫����","3-3",0,10106),
                         //���ɽ�����
                         new Option("B", "���ɻ���","3-3",0,10103,10104),
                         //��֫������
                         new Option("B", "��֫����","3-3",0,10112,10133),
                    }
                ),
                new Question("3-3", "�ܷ񹻶�����ʳ����ˮ", 1,
                    new List<Option>{
                         new Option("A", "����","3-3-1"),
                         new Option("B", "��","3-4"),
                    }
                ),
                new Question("3-3-1", "˫���Ƿ��ܹ�ץ�գ���ѡ��", 1,
                    new List<Option>{
                        //08 18 03ץ��װ��(�������)��10 09����(���������Ϊ�������)��10 09 18��(������)��10 09 21ʳ�ﵲ��(���Ϸ�����)��10 09�棨�ֱ��棩����(�ֱ���)
                         new Option("A", "��ȫ����","3-4",0,108180301,110092503,1100918,110092102,110092201,110092303),
                         //08 18 03ץ��װ��(�������)��10 09����(���������Ϊ�������)��10 09 18��(������)��10 09 21ʳ�ﵲ��(���Ϸ�����)��10 09�棨�ֱ��棩����(�ֱ���)
                         new Option("B", "����ץ�գ�����ά��","3-4",0,108180301,110092503,1100918,110092102,110092201,110092303),
                         new Option("C", "��ץ����ά��","3-4"),
                    }
                ),
                new Question("3-4", "�ܷ�����ϲ���", 1,
                    new List<Option>{
                        //03 30 21����һ������(����ֽ���)��03 30 18����һ���Գĵ�(ֽ����ĵ�)��03 12 33���裻
                         new Option("A", "����","3-5",0,103302101,103301801,1031233),
                         new Option("B", "��","3-5"),
                    }
                ),
                new Question("3-5", "ϴԡʱ�Ƿ���վ��", 1,
                    new List<Option>{
                        //03 33 03��ԡ����ԡ�Σ����ֺ�����)-ϴԡ��
                         new Option("A", "����","6",0,103330302,103330303,103330304,103330305),
                         new Option("B", "��","6"),
                    }
                ),
                #endregion
                new Question("6", "�Ƿ������������м�", 1,
                    new List<Option>{
                         new Option("A", "��","7"),
                         new Option("B", "����",1,"7"),
                         new Option("C", "����",2,"7"),
                         new Option("D", "����","7"),
                    }
                ),
                 new Question("7", "��ϣ�����ʲô���⣨���ѡ��������",8,
                    new List<Option>{
                         new Option("A", "���δ���",null),
                         new Option("B", "��������",null),
                         new Option("C", "��ʳ",null),
                         new Option("D", "���˻���",null),
                         new Option("E", "���",null),
                         new Option("F", "��Ϣ����",null),
                         new Option("G", "����ѵ��",null),
                         new Option("H", "��������",null),
                         new Option("I", "���ϰ�����",8,null),
                         new Option("J", "������ʹ��",null),
                         new Option("K", "λ��ת��",null),
                         new Option("L", "��������",null),
                         new Option("M", "��֫",7,null),
                         new Option("N", "������",null),
                         new Option("O", "������",null),
                         new Option("P", "������",null),
                         new Option("Q", "ϴ����",null),
                         new Option("R", "������",null),
                    }
                ),
            };
            Exam exam4 = new Exam(4, "FuJuPingGu", "��̱", questions4);
            db.Exams.AddOrUpdate(exam4);
            #endregion

            #region ��������
            List<Question> questions5 = new List<Question>
            {
                new Question("1", "�Ƿ��Դ�", 1,
                    new List<Option>{
                        //04��ͥ�ͼҾ�-��ʽ�Ҿߣ���������06 33 06������֯�����Ե����Ը������ߣ���ѹ�����棩��06 33 04������֯�����ԵĿ������С�����棨��λ�棩��07 33 09�����ƶ�ѵ���������ߣ�����������05 27 18 ���˽�������ϵͳ������������03 03 18�п����ͳ���
                         new Option("A", "��","1-1",0,1040801,1063306,106330401,107330905,105271801,1030318),
                         //02 22 03˫���������γ����������Σ���ѡ��02 23 03�綯���γ�����ͨ�綯���Σ���06 33 03������֯�����Ե�����ͳĵ棨��ѹ�����棩08 21 03�ֶ�ץȡǯ���۵�ʽ����ȡ����/���۵�ʽ����ȡ������
                         new Option("B", "��","1-4",0,102220302,102230304,1063303,108210301,108210302),
                    }
                ),
                new Question("1-1", "˫���Ƿ����ץ������", 1,
                    new List<Option>{
                        //04 10 09���֣���������/���Ի�������07 33 09�����ƶ�ѵ���������ߣ��������ݣ���08 21 03�ֶ�ץȡǯ���۵�ʽ����ȡ����/���۵�ʽ����ȡ������
                         new Option("A", "��","1-2",0,104100901,107330907,108210301,108210302),
                         new Option("B", "��","1-2"),
                    }
                ),
                new Question("1-2", "�ܷ񱣳���λ", 1,
                    new List<Option>{
                        //02 22 18�����߲��ݵ����γ�-�߿������Σ�������/������������ѡ�䣨��ѡ��������£���04 10 03�������ɵ�����/�ܣ���04 30 ��ֱ���͸�������-���ࣨ���ò�����
                         new Option("A", "��","1-3",0,102221801,104100301,104301901),
                         new Option("B", "����","1-3"),
                    }
                ),
                new Question("1-3", "�ܷ���ƴ�С��", 1,
                    new List<Option>{
                        //03 24����װ��(03 24 15Ů�ô���ʽ�����/03 24 21���ô���ʽ�����)��03 12 33����
                         new Option("A", "��","2",0,1032415,1032421,1031233),
                         //07 09 03ʧ����������03 30 21����һ�����򲼻�03 30 18����һ���Գĵ棻03 27 18���ռ�ϵͳ��03 31 06����������Ų�����
                         new Option("B", "����","2",0,1070903,1033021,1033018,1032718,103310602),
                    }
                ),
                new Question("1-4", "˫��֧���ܷ�ʹ�β��뿪����", 1,
                    new List<Option>{
                         new Option("A", "��","1-5"),
                         //07 33 09�����ƶ�ѵ���������ߣ��Ƴ˰���Ƴ˴���
                         new Option("B", "����","1-5",0,1073309),
                    }
                ),
               new Question("1-5", "�ܷ񾭳�����Զ�������", 1,
                    new List<Option>{
                         //02 18 09��ҡ���ֳ���ѡ��02 23 09�������γ�
                         new Option("A", "��","1-6",0,1021809,1022309),
                         new Option("B", "����","1-6"),
                    }
                ),
               new Question("1-6", "�Ƿ���վ������", 1,
                    new List<Option>{
                        //����������
                         new Option("A", "��","1-6-1",0,1010327),
                         new Option("B", "��","1-7"),
                    }
                ),
               new Question("1-6-1", "�ܷ�����վ��", 1,
                    new List<Option>{
                        //��֫������
                         new Option("A", "��","1-6-1-1",0,10112),
                         //ѡ��02 23 03�綯���γ���վ���綯���Σ�
                         new Option("B", "��","1-7",0,102230305),
                    }
                ),
               new Question("1-6-1-1", "�Ƿ�������", 1,
                    new List<Option>{
                        //02 06 03��ʽ���мܣ���02 03 12Ҹ�գ�ѡ��02 03 06���
                         new Option("A", "��","1-7",0,1020603,1020312,1020306),
                         //02 06 03��ʽ���м�
                         new Option("B", "����","1-7",0,1020603),
                    }
                ),
               new Question("1-7", "�ܷ���ƴ�С��", 1,
                    new List<Option>{
                         new Option("A", "��","1-7-1"),
                         //03 30 21����һ������(����ֽ���)��03 27 18���ռ�ϵͳ
                         new Option("B", "����","2",0,103302101,1032718),
                    }
                ),
               new Question("1-7-1", "�ܷ��������", 1,
                    new List<Option>{
                         new Option("A", "��","1-7-1-1"),
                         //03 12 03������
                         new Option("B", "����","2",0,1031203),
                    }
                ),
               new Question("1-7-1-1", "�����Ƿ�������������ѡ��", 1,
                    new List<Option>{
                         new Option("A", "��","2"),
                         //03 12 03������
                         new Option("B", "��","2",0,1031203),
                    }
                ),
               new Question("2", "�ܷ�������ʳ", 1,
                    new List<Option>{
                        //ѡ��10 09 27ιʳ��е���綯ιʳ����
                         new Option("A", "����","3",0,110092701),
                         //08 18 03ץ��װ�ã������������ѡ��10 09ʳ����������(�桢�ס�����)��10 09 18���Ӻ��룻10 09ʳ����������-����(б�ڱ�/���ܱ�/�����)��10 09 21ʳ�ﵲ��(���Ϸ�����)
                         new Option("B", "���������","2-1",0,108180301,1100922,1100923,1100924,1100918,110092502,110092503,110092504,110092102),
                         new Option("C", "�������","3"),
                    }
                ),
               new Question("2-1", "�ֲ��Ƿ��л���", 1,
                    new List<Option>{
                        //��֫������
                         new Option("A", "��","3",0,10106),
                         new Option("B", "��","3"),
                    }
                ),
               new Question("3", "�ܷ�����ϴԡ", 1,
                    new List<Option>{
                        //03 33 03��ԡ����ԡ�Σ����ֺ����֣�-ϴԡ���Σ�ѡ��03 33 12ϴԡ����ϴԡ������03 33��ϴ����ԡ����ԡ��������-ϴԡ������ϴԡ��������03 33 15ϴ�裨����ʽϴͷ�أ�
                         new Option("A", "����","4",0,103330301,103331201,103332201,103331501),
                         //03 33 03��ԡ����ԡ�Σ����ֺ�����)-ϴԡ�Σ�ѡ��03 33 06��������ԡ��ʹ��ӣ���������棩��03 33 30���а��֡��ֱ����հѵ�ϴ�貼�������ˢ��
                         new Option("B", "���������","4",0,103330302,103330303,103330304,103330305,103330601,1033330),
                         //03 33 03��ԡ����ԡ�Σ����ֺ�����)-ϴԡ�Σ�ѡ��03 33 06��������ԡ��ʹ��ӣ���������棩
                         new Option("C", "�������","4",0,103330302,103330303,103330304,103330305,103330601),
                    }
                ),
               new Question("4", "�ܷ����д�������", 1,
                    new List<Option>{
                        //ѡ��03 03 18�п����ͳ���
                         new Option("A", "����","5",0,1030318),
                         //ѡ��03 09 18ϵ�۹���ϵ��������03 09 03������ʹ�������ĸ������ߣ�����������03 09 15����������װ�ã���������
                         new Option("B", "���������","5",0,103091801,103090301,103091501),
                         new Option("C", "�������","5"),
                    }
                ),
                new Question("5", "�Ƿ������������м�", 1,
                    new List<Option>{
                         new Option("A", "��","6"),
                         new Option("B", "����",1,"6"),
                         new Option("C", "����",2,"6"),
                         new Option("D", "����","6"),
                    }
                ),
                 new Question("6", "��ϣ�����ʲô���⣨���ѡ��������", 8,
                    new List<Option>{
                         new Option("A", "���δ���",null),
                         new Option("B", "��������",null),
                         new Option("C", "��ʳ",null),
                         new Option("D", "���˻���",null),
                         new Option("E", "���",null),
                         new Option("F", "��Ϣ����",null),
                         new Option("G", "����ѵ��",null),
                         new Option("H", "��������",null),
                         new Option("I", "���ϰ�����",8,null),
                         new Option("J", "������ʹ��",null),
                         new Option("K", "λ��ת��",null),
                         new Option("L", "��������",null),
                         new Option("M", "��֫",7,null),
                         new Option("N", "������",null),
                         new Option("O", "������",null),
                         new Option("P", "������",null),
                         new Option("Q", "ϴ����",null),
                         new Option("R", "������",null),
                    }
                ),
            };
            Exam exam5 = new Exam(5, "FuJuPingGu", "����", questions5);
            db.Exams.AddOrUpdate(exam5);
            #endregion

            #region ֫������
            List<Question> questions6 = new List<Question>
            {
                new Question("1", "֫���Ƿ��в�ȱ", 1,
                    new List<Option>{
                         new Option("A", "��","2"),
                         new Option("B", "��","2"),
                    }
                ),
                new Question("2", "�Ƿ���ڻ���", 1,
                    new List<Option>{
                         new Option("A", "��","2-1"),
                         new Option("B", "��","3"),
                    }
                ),
               new Question("2-1", "�����ܷ����ֽ���", 1,
                    new List<Option>{
                         new Option("A", "��","3"),
                         new Option("B", "����","3"),
                    }
                ),
               new Question("3", "�Ƿ��Դ�", 1,
                    new List<Option>{
                        //04��ͥ�ͼҾ�-��ʽ�Ҿߣ���������06 33 06������֯�����Ե����Ը������ߣ���ѹ�����棩��06 33 04������֯�����ԵĿ������С�����棨��λ�棩��07 33 09�����ƶ�ѵ���������ߣ�����������05 27 18 ���˽�������ϵͳ������������03 03 18�п����ͳ���
                         new Option("A", "��","3-1"),
                         new Option("B", "��","3-4"),
                    }
                ),
               new Question("3-1", "���ܷ�ץ��", 1,
                    new List<Option>{
                         new Option("A", "˫�־���","3-2"),
                         //04 10 09���֣����Ի�������08 21 03�ֶ�ץȡǯ������ȡ������
                         new Option("B", "������","3-2",0,104100901,108210301),
                         //04 10 09���֣����Ի�������07 33 09�����ƶ�ѵ���������ߣ��������ݣ���08 21 03�ֶ�ץȡǯ���۵�ʽ����ȡ����/���۵�ʽ����ȡ������
                         new Option("C", "˫�־���","3-2",0,104100901,107330907,108210301,108210302),
                    }
                ),
               new Question("3-2", "�ܷ񱣳���λ", 1,
                    new List<Option>{
                        //02 22 18�����߲��ݵ����γ�-�߿������Σ�������/������������ѡ�䣨��ѡ��������£���04 10 03�������ɵ����ܣ���04 30 ��ֱ���͸�������-���ࣨ���ò�������03 33 03ϴԡ����
                         new Option("A", "��","3-3",0,102221801,104100301,104301901,1033303),
                         //03 33 12ϴԡ������ԡ���͸���������ϴԡ������03 33��ϴ����ԡ����ԡ�������ߣ�ϴԡ��������03 33 15ϴ�裨����ʽϴͷ�أ�
                         new Option("B", "����","3-3",0,103331201,103332201,103331501),
                    }
                ),

               //3-1ѡA��3-2ѡA����3-2-1
               //3-1ѡB��3-2ѡA��10 09 18���Ӻ��루1100918����10 09 21ʳ�ﵲ��(���Ϸ�����)��110092102��
                new Question("3-2-1", "�ܷ�����ֵ���Ķ���", 1,
                    new List<Option>{
                        //08 18 03ץ��װ�ã������������ѡ��10 09ʳ����������(�桢�ס�����)��10 09 18���Ӻ��룻10 09ʳ����������-����(б�ڱ�/���ܱ�/�����)��10 09 21ʳ�ﵲ��(���Ϸ�����)
                         new Option("A", "��","3-3",0,108180301,1100922,1100923,1100924,1100918,110092502,110092503,110092504,110092102),
                         new Option("B", "����","3-3"),
                    }
                ),

                new Question("3-3", "�ܷ���ƴ�С��", 1,
                    new List<Option>{
                        //03 24����װ��(03 24 15Ů�ô���ʽ�����/03 24 21���ô���ʽ�����)��03 12 33����
                         new Option("A", "��","4",0,1032415,1032421,1031233),
                         //07 09 03ʧ����������03 30 21����һ�����򲼻�03 30 18����һ���Գĵ棻03 27����������ռ�ϵͳ��03 31 06����������Ų�����
                         new Option("B", "����","4",0,1070903,1033021,1033018,10327,103310602),
                    }
                ),
                new Question("3-4", "�ܷ�����", 1,
                    new List<Option>{
                        //02 22 03˫���������γ����������Σ���ѡ��02 23 03�綯���γ�����ͨ�綯���Σ���06 33 03������֯�����Ե�����ͳĵ棨��ѹ�����棩��03 33 03��ԡ����ԡ�Σ����ֺ�����)-ϴԡ��
                         new Option("A", "����","3-4-1",0,102220302,102230304,1063303,103330302,103330303,103330304,103330305),
                         new Option("B", "��","3-4-7"),
                    }
                ),
                new Question("3-4-1", "˫���ܷ��β�֧���뿪����", 1,
                    new List<Option>{
                         new Option("A", "��","3-4-2"),
                         //07 33 09�����ƶ�ѵ���������ߣ��Ƴ˰���Ƴ˴���
                         new Option("B", "����","3-4-2",0,107330902,107330903),
                    }
                ),
                new Question("3-4-2", "�Ƿ񾭳�����Զ�������", 1,
                    new List<Option>{
                        //02 18 09��ҡ���ֳ���ѡ��02 23 09�������γ�
                         new Option("A", "��","3-4-3",0,1021809,1022309),
                         new Option("B", "��","3-4-3"),
                    }
                ),
                new Question("3-4-3", "�Ƿ���վ������", 1,
                    new List<Option>{
                         new Option("A", "��","3-4-3-1"),
                         new Option("B", "��","3-4-4"),
                    }
                ),
                new Question("3-4-3-1", "�ܷ�����վ��", 1,
                    new List<Option>{
                        //��3-4-1ѡA��02 06 03��ʽ���мܣ����ݿ�ʽ���мܣ�
                        //��3-4-1ѡB��ѡ��02 23 03�綯���γ���վ���綯���Σ�
                         new Option("A", "��","3-4-4"),
                         new Option("B", "��","3-4-4"),
                    }
                ),
                new Question("3-4-4", "�ܷ���ƴ�С��", 1,
                    new List<Option>{
                        //03 30 21����һ������(����ֽ���)��03 27 18���ռ�ϵͳ
                         new Option("A", "����","3-4-5",0,103302101,1032718),
                         new Option("B", "��","3-4-4-1"),
                    }
                ),
                new Question("3-4-4-1", "�ܷ��������", 1,
                    new List<Option>{
                         new Option("A", "��","3-4-4-1-1"),
                         //03 12 03������
                         new Option("B", "����","3-4-5",0,1031203),
                    }
                ),
                new Question("3-4-4-1-1", "�����Ƿ���������", 1,
                    new List<Option>{
                         new Option("A", "��","3-4-5"),
                         //03 12 03������
                         new Option("B", "��","3-4-5",0,1031203),
                    }
                ),
                new Question("3-4-5", "���ܷ�ץ��", 1,
                    new List<Option>{
                         new Option("A", "˫�־���","3-4-5-1"),
                         //10 09 18���Ӻ��룻10 09 21ʳ�ﵲ��(���Ϸ�����)��08 21 03�ֶ�ץȡǯ������ȡ��������03 33 30���а��֡��ֱ����հѵ�ϴ�貼�������ˢ��
                         new Option("B", "������","3-4-6",0,1100918,110092102,108210301,1033330),
                         //08 21 03�ֶ�ץȡǯ������ȡ������
                         new Option("C", "˫�־���","3-4-6",0,108210301),
                    }
                ),
                new Question("3-4-5-1", "�ܷ�����ֵ���Ķ���", 1,
                    new List<Option>{
                        //08 18 03ץ��װ�ã������������ѡ��10 09ʳ����������(�桢�ס�����)��10 09 18���Ӻ��룻10 09ʳ����������-����(б�ڱ�/���ܱ�/�����)��10 09 21ʳ�ﵲ��(���Ϸ�����)��03 33 30���а��֡��ֱ����հѵ�ϴ�貼�������ˢ��
                         new Option("A", "��","3-4-6",0,108180301,1100922,1100923,1100924,1100918,110092502,110092503,110092504,110092102,1033330),
                         new Option("B", "����","3-4-6"),
                    }
                ),
                new Question("3-4-6", "�ܷ����д�������", 1,
                    new List<Option>{
                        //ѡ��03 03 18�п����ͳ���
                         new Option("A", "����","4",0,1030318),
                         //ѡ��03 09 18ϵ�۹���ϵ��������03 09 03������ʹ�������ĸ������ߣ�����������03 09 15����������װ�ã���������
                         new Option("B", "���������","4",0,103091801,103090301,103091501),
                         new Option("C", "�������","4"),
                    }
                ),
                new Question("3-4-7", "�ܷ�ʱ������", 1,
                    new List<Option>{
                         new Option("A", "��","3-4-7-1"),
                         new Option("B", "��","3-4-7-3"),
                    }
                ),
                new Question("3-4-7-1", "���ܷ�ץ��", 1,
                    new List<Option>{
                        //07 33 09�����ƶ�ѵ���������ߣ��Ƴ˴���
                         new Option("A", "˫�־���","3-4-7-2",0,1073309),
                         //02 03 03���ȣ��Ľ����Ȼ򵥲�������мܣ�
                         new Option("B", "������","3-4-7-2",0,102030307,102030308,102030309,1023819),
                         //02 06 03��ʽ���мܣ����ݿ�ʽ���мܣ�
                         new Option("C", "˫�־���","3-4-7-2",0,1020603),
                    }
                ),
                new Question("3-4-7-2", "�Ƿ���Ҫ��������", 1,
                    new List<Option>{
                        //02 22 18�����߲��ݵ����γ����������Σ�
                         new Option("A", "��","3-4-8",0,102221802),
                         //02 22 03˫���������γ�����ͨ���Σ���ѡ��02 23 03�綯���γ�����ͨ�綯���Σ�
                         new Option("B", "��","3-4-8",0,102220301,102230304),
                    }
                ),
                new Question("3-4-7-3", "����ʱ�Ƿ���Ҫ�˲��", 1,
                    new List<Option>{
                         new Option("A", "ȫ�̲��","3-4-7-3-1"),
                         //02 03���۲������������������ȣ�ѡ����գ��������ã�
                         new Option("B", "���ֲ��","3-4-8",0,10203),
                         new Option("C", "������","3-4-7-3-2"),
                    }
                ),
                new Question("3-4-7-3-1", "�ֵ�ץ������", 1,
                    new List<Option>{
                        //02 06 12̨ʽ������
                         new Option("A", "˫�־���","3-4-8",0,1020612),
                         //02 03 03���ȣ��Ľ����Ȼ򵥲�������мܣ�
                         new Option("B", "������","3-4-8",0,102030307,102030308,102030309,1023819),
                         //02 06 03��ʽ���мܣ�02 03 12Ҹ��
                         new Option("C", "˫�־���","3-4-8",0,1020603,1020312),
                    }
                ),
                new Question("3-4-7-3-2", "���������Ƿ���Ҫ֧��", 1,
                    new List<Option>{
                        //02 06 06��ʽ������
                         new Option("A", "�϶�֧��","3-4-8",0,1020606),
                         //02 03 18��������
                         new Option("B", "����֧��","3-4-8",0,1020318),
                         new Option("C", "����֧��","3-4-8"),
                    }
                ),
                new Question("3-4-8", "�����Ƿ���������", 1,
                    new List<Option>{
                         new Option("A", "��","3-4-8-1"),
                         new Option("B", "��","3-4-8-2"),
                    }
                ),
                new Question("3-4-8-1", "���ʱ�ܷ����", 1,
                    new List<Option>{
                        //03 12 03������
                         new Option("A", "����","3-4-9",0,1031203),
                         new Option("B", "��","3-4-9"),
                    }
                ),
                new Question("3-4-8-2", "���ʱ�����Ƿ�����", 1,
                    new List<Option>{
                        //04 10 09���֣��Ϸ�ʽǰ�۷��֡��̶�ʽǰ�۷��֣���ѡ��03 12 12����ͼӸߵ�������������03 12 18��װ���������ϼӸߵ���������
                         new Option("A", "����","3-4-9",0,104100902,104100903,1031212,1031218),
                         new Option("B", "������","3-4-9"),
                    }
                ),
                new Question("3-4-9", "ϴԡʱ���ܷ�ʱ��վ��", 1,
                    new List<Option>{
                        //03 33 06������ԡ��桢��ԡ��ʹ��ӣ���������棩��04 10 09���֣��Ϸ�ʽǰ�۷��֡��̶�ʽǰ�۷��֣�
                         new Option("A", "��","3-4-10",0,103330601,104100902,104100903),
                         //03 33 03��ԡ����ԡ�Σ�03 33 06������ԡ��桢��ԡ��ʹ��ӣ���������棩
                         new Option("B", "����","3-4-10",0,1033303,103330601),
                    }
                ),
                new Question("3-4-10", "��ʳʱ���ܷ�˫��Э����ͬ��ʳ", 1,
                    new List<Option>{
                         new Option("A", "��","3-4-10-1"),
                         //10 09 18���Ӻ��룻10 09 21ʳ�ﵲ��(���Ϸ�����)
                         new Option("B", "����","3-4-11",0,1100918,110092102),
                    }
                ),
                new Question("3-4-10-1", "˫���ܷ��ս�����", 1,
                    new List<Option>{
                         new Option("A", "��","3-4-11"),
                         //08 18 03ץ��װ�ã������������ѡ��10 09ʳ����������(�桢�ס�����)��10 09 18���Ӻ��룻10 09ʳ����������-����(б�ڱ�/���ܱ�/�����)��10 09 21ʳ�ﵲ��(���Ϸ�����)
                         new Option("B", "����","3-4-11",0,108180301,1100922,1100923,1100924,1100918,110092502,110092503,110092504,110092102),
                    }
                ),
                new Question("3-4-11", "�ܷ����д�������", 1,
                    new List<Option>{
                        //ѡ��03 03 18�п����ͳ���
                         new Option("A", "����","4",0,1030318),
                         //ѡ��03 09 18ϵ�۹���ϵ��������03 09 03������ʹ�������ĸ������ߣ�����������03 09 15����������װ�ã�����������03 03 42Ь��ѥ�����㴩��Ь����03 09 06Ь�κ���ѥ��������Ь�Σ�
                         new Option("B", "���������","4",0,103091801,103090301,103091501,103034202,103090602),
                         new Option("C", "�������","4"),
                    }
                ),
                new Question("4", "�Ƿ������������м�", 1,
                    new List<Option>{
                         new Option("A", "��","5"),
                         new Option("B", "����",1,"5"),
                         new Option("C", "����",2,"5"),
                         new Option("D", "����","5"),
                    }
                ),
                 new Question("5", "��ϣ�����ʲô���⣨���ѡ��������", 8,
                    new List<Option>{
                         new Option("A", "���δ���",null),
                         new Option("B", "��������",null),
                         new Option("C", "��ʳ",null),
                         new Option("D", "���˻���",null),
                         new Option("E", "���",null),
                         new Option("F", "��Ϣ����",null),
                         new Option("G", "����ѵ��",null),
                         new Option("H", "��������",null),
                         new Option("I", "���ϰ�����",8,null),
                         new Option("J", "������ʹ��",null),
                         new Option("K", "λ��ת��",null),
                         new Option("L", "��������",null),
                         new Option("M", "��֫",7,null),
                         new Option("N", "������",null),
                         new Option("O", "������",null),
                         new Option("P", "������",null),
                         new Option("Q", "ϴ����",null),
                         new Option("R", "������",null),
                    }
                ),

            };
            Exam exam6 = new Exam(6, "FuJuPingGu", "֫��", questions6);
            db.Exams.AddOrUpdate(exam6);
            #endregion

            #region ��֫����
            List<Question> questions7 = new List<Question>
            {
                new Question("1", "������װ���޼�֫����", 1,
                    new List<Option>{
                         new Option("A", "��װ������",null),
                         new Option("B", "��װ������","2"),
                    }
                ),
                //���岿λѡ��
                 new Question("2", "��ͼ�б����֫��λ���ɶ�ѡ��", 6,
                    new List<Option>{
                         //��֫���֣�100-60��
                         new Option("A", "��ؽ�","3",100),
                         new Option("B", "�ϱ��м�","3",90),
                         new Option("C", "��ؽ�","3",80),
                         new Option("D", "ǰ���м�","3",70),
                         new Option("E", "��ؽ�","3",60),
                         //��֫���֣�50-10��
                         new Option("F", "�Źؽ�","3",50),
                         new Option("G", "�����м�","3",40),
                         new Option("H", "ϥ�ؽ�","3",30),
                         new Option("I", "С���м�","3",20),
                         new Option("J", "�׹ؽ�","3",10),
                    }
                ),

                new Question("3", "����״����", 1,
                    new List<Option>{
                         new Option("A", "����","4"),
                         new Option("B", "���ʼ���˥��","4"),
                         new Option("C", "ƽ���Э�����������ϰ�","4"),
                         new Option("D", "ѪҺ�����Ѫ�Լ���","4"),
                         new Option("E", "�������ಡ","4"),
                         new Option("F", "���ظ�Ѫѹ����Ѫѹ","4"),
                         new Option("G", "��ʶ�ϰ�","4"),
                         new Option("H", "���������ϰ�","4"),
                         new Option("I", "���صľ������Լ���","4"),
                         new Option("J", "�޷�ȷ��","4"),
                    }
                ),
                new Question("4", "��֫��״����", 1,
                    new List<Option>{
                         new Option("A", "����","5"),
                         new Option("B", "ĩ��Ѫ��ѭ������","5"),
                         new Option("C", "��֢","5"),
                         new Option("D", "����","5"),
                         new Option("E", "��ʹ","5"),
                         new Option("F", "����","5"),
                         new Option("G", "����","5"),
                         new Option("H", "Ƥ������","5"),
                         new Option("I", "�ؽ�����","5"),
                         new Option("J", "�޷�ȷ��","5"),
                    }
                ),
                //ͼƬ�ϴ�
                new Question("5", "ֱ�����ջ��ϴ���֫��λ����Ƭ����һ�ţ�Ϊ��ȱһ��֫�����д��Ƭ����ȱ��λ��¶��", 7,null),

            };
            Exam exam7 = new Exam(7, "FuJuPingGu", "��֫", questions7);
            db.Exams.AddOrUpdate(exam7);
            #endregion

            #region ���ϰ�����
            List<Question> questions8 = new List<Question>
            {
                 new Question("1", "���ھ�ס����?", 1,
                    new List<Option>{
                         new Option("A", "����","2"),
                         new Option("B", "���","2"),
                         new Option("C", "����","2"),
                    }
                ),
                 new Question("2", "�־�ס�����������?", 1,
                    new List<Option>{
                         new Option("A", "����","3"),
                         new Option("B", "���","3"),
                         new Option("C", "����","3"),
                    }
                ),
                 new Question("3", "�־�ס¥��?", 1,
                    new List<Option>{
                         new Option("A", "������","4"),
                         new Option("B", "һ��","4"),
                         new Option("C", "���㼰����","4"),
                    }
                ),
                 new Question("4", "�־�ס���?", 1,
                    new List<Option>{
                         new Option("A", "����","5"),
                         new Option("B", "�����ͬס","5"),
                         new Option("C", "������ͬס","5"),
                         new Option("D", "����","5"),
                    }
                ),
                 new Question("5", "��ͥ����Ҫ�������(��ѡ)", 2,
                    new List<Option>{
                         new Option("A", "����","6"),
                         new Option("B", "������","6"),
                         new Option("C", "����","6"),
                         new Option("D", "����","6"),
                         new Option("E", "����","6"),
                    }
                ),
                new Question("6", "����Ϊ�ڼ�ͥ�����д������ѽ϶�����򣨶�ѡ��", 2,
                    new List<Option>{
                         new Option("A", "�뻧ͨ��","7"),
                         new Option("B", "����","8"),
                         new Option("C", "������","9"),
                         new Option("D", "����","10"),
                         new Option("E", "����","11"),
                         new Option("F", "����¥��","12"),
                         new Option("G", "����","13"),
                         new Option("H", "��",null),
                    }
                ),
                new Question("7", "����Ϊ�뻧ͨ�����ڵ����⣨��ѡ��", 4,
                    new List<Option>{
                         new Option("A", "����ѷŻ�ռ䲻��","7-A"),
                         new Option("B", "�ſ��㣬�����ż���ߵ����","7-B"),
                         new Option("C", "�ſ�������","7-C"),
                         new Option("D", "���߲���","7-D"),
                         new Option("E", "�޷��ֻ���ֲ�����","7-E"),
                         new Option("F", "���Ű��֡����塢�����Ȼ�ʹ������","7-F"),
                         new Option("G", "����","7-G"),
                    }
                ),
                new Question("7-A", null, 2,
                    new List<Option>{
                         new Option("A", "��������",null),
                         new Option("B", "�������ŷ�ʽ�����˳������Σ�����ȣ�",null),
                         new Option("C", "�ſ�����ƽ̨",null),
                    }
                ),
                new Question("7-B", null, 2,
                    new List<Option>{
                         new Option("A", "�ı���ŷ�ʽ�������Ϊ��������Σ�����С�֣����̽��ż��ɡ������ν��š��̹��ż����ɵȣ�",null),
                         new Option("B", "�����ſ�",null),
                         new Option("C", "ͨ���̶��µ�������µ������ߵͲ�",null),
                         new Option("D", "ȥ���ż�",null),
                    }
                ),
                new Question("7-C", null, 2,
                    new List<Option>{
                         new Option("A", "�������ŷ�ʽ��������Э���ȣ�",null),
                         new Option("B", "�����׿�����",null),
                    }
                ),
                new Question("7-D", null, 2,
                    new List<Option>{
                         new Option("A", "���ӹ���",null),
                         new Option("B", "������ص�",null),
                    }
                ),
                new Question("7-E", null, 2,
                    new List<Option>{
                         new Option("A", "���ӷ���",null),
                         new Option("B", "��������",null),
                    }
                ),
                new Question("7-F", null, 2,
                    new List<Option>{
                         new Option("A", "���Ӱ���",null),
                         new Option("B", "��������",null),
                         new Option("C", "��������",null),
                         new Option("D", "�������壨�ɸ��������壨�����ϰ�����",null),
                         new Option("E", "��������",null),
                         new Option("F", "������Ŀ��־�������ϰ���",null),
                    }
                ),
                new Question("7-G", "����",5,null),

                new Question("8", "����Ϊ�������ڵ����⣨��ѡ��", 4,
                    new List<Option>{
                         new Option("A", "�������ҡ��Ҿ߰ڷŲ�����ռ䲻��","8-A"),
                         new Option("B", "���治ƽ���򲻷���","8-B"),
                         new Option("C", "���߲���","8-C"),
                         new Option("D", "ʹ�ÿ���/��������","8-D"),
                         new Option("E", "�޷��ֻ���ֲ�����","8-E"),
                         new Option("F", "����","8-F"),
                    }
                ),

                 new Question("8-A", null, 2,
                    new List<Option>{
                         new Option("A", "���������Ʒ",null),
                         new Option("B", "�Ҿߺ���Ʒ���°ڷ�",null),
                    }
                ),
                 new Question("8-B", null, 2,
                    new List<Option>{
                         new Option("A", "ƽ�����棨���е�̺ȥ����̺��",null),
                         new Option("B", "ʹ�÷�����",null),
                         new Option("C", "�����������",null),
                    }
                ),
                 new Question("8-C", null, 2,
                    new List<Option>{
                         new Option("A", "�ӵƹ�",null),
                         new Option("B", "����Ҫ��Ʒ����Ŀ��־",null),
                    }
                ),
                 new Question("8-D", null, 2,
                    new List<Option>{
                         new Option("A", "���Ŀ���/����λ��",null),
                         new Option("B", "�ı�ʹ�ÿ���/������ʽ�����ó���ȡ�������صȣ�",null),
                         new Option("C", "������Ŀ��־",null),
                    }
                ),
                 new Question("8-E", null, 2,
                    new List<Option>{
                         new Option("A", "���ӷ���",null),
                         new Option("B", "��������",null),
                         new Option("C", "�����мܻ�����ศ��",null),
                    }
                ),
                new Question("8-F", "����",5,null),

                new Question("9", "����Ϊ��������ڵ����⣨��ѡ��", 4,
                    new List<Option>{
                         new Option("A", "�������ң���ռ䲻��","9-A"),
                         new Option("B", "�ſ��㣬�����ż���ߵ����","9-B"),
                         new Option("C", "�ſ�������","9-C"),
                         new Option("D", "�����ԡ�ײ�����","9-D"),
                         new Option("E", "ʹ�ÿ���/��������","9-E"),
                         new Option("F", "���ߡ�վ������ʹ�ñ�������","9-F"),
                         new Option("G", "ϴԡ����","9-G"),
                         new Option("H", "����","9-H"),
                    }
                ),
                new Question("9-A", null, 2,
                    new List<Option>{
                         new Option("A", "���������Ʒ",null),
                         new Option("B", "������Ʒ�ڷſռ��λ��",null),
                         new Option("C", "�����޷�����ʱ���������˳������Σ�������룬��ʹ��������",null),
                    }
                ),
                 new Question("9-B", null, 2,
                    new List<Option>{
                         new Option("A", "�ı���ŷ�ʽ�������Ϊ��������Σ�����С�֣����̽��ż��ɡ������ν��š��̹��ż����ɵȣ�",null),
                         new Option("B", "�����ſ�",null),
                         new Option("C", "ͨ���̶��µ�������µ������ߵͲ�",null),
                         new Option("D", "ȥ���ż�",null),
                    }
                ),
                new Question("9-C", null, 2,
                    new List<Option>{
                         new Option("A", "�������ŷ�ʽ��������Э��",null),
                         new Option("B", "ȥ���ţ���Ϊ�������ڱ�",null),
                         new Option("C", "�����׿�����",null),
                    }
                ),
                new Question("9-D", null, 2,
                    new List<Option>{
                         new Option("A", "������",null),
                         new Option("B", "�����������",null),
                    }
                ),
                new Question("9-E", null, 2,
                    new List<Option>{
                         new Option("A", "�ı�ʹ�ÿ���/������ʽ�����ó���ȡ�������صȣ�",null),
                         new Option("B", "������Ŀ��־",null),
                         new Option("C", "���Ŀ���/����λ��",null),
                    }
                ),
                new Question("9-F", null, 2,
                    new List<Option>{
                         new Option("A", "���ӷ���",null),
                         new Option("B", "�ý������мܻ�����ศ��",null),
                         new Option("C", "���������λ�ϴԡ��",null),
                    }
                ),
                new Question("9-G", null, 2,
                    new List<Option>{
                         new Option("A", "ϴԡ��������",null),
                    }
                ),
                new Question("9-H", "����",5,null),

                new Question("10", "����Ϊ�������ڵ����⣨��ѡ��", 4,
                    new List<Option>{
                         new Option("A", "�������һ�Ҿ߰ڷŲ���","10-A"),
                         new Option("B", "�ſ��㣬�����ż���ߵ����","10-B"),
                         new Option("C", "�ſ�������","10-C"),
                         new Option("D", "���治ƽ���򲻷���","10-D"),
                         new Option("E", "���߲���","10-E"),
                         new Option("F", "ʹ�ÿ���/��������","10-F"),
                         new Option("G", "����̨�����������¯̨��ˮ�أ�ʹ������","10-G"),
                         new Option("H", "����","10-H"),
                    }
                ),
                new Question("10-A", null, 2,
                    new List<Option>{
                         new Option("A", "���������Ʒ",null),
                         new Option("B", "�����ͥ��Ʒ�ڷſռ��λ��",null),
                    }
                ),
                new Question("10-B", null, 2,
                    new List<Option>{
                         new Option("A", "�ı���ŷ�ʽ�������Ϊ��������Σ�����С�֣����̽��ż��ɡ������ν��š��̹��ż����ɵȣ�",null),
                         new Option("B", "�����ſ�",null),
                         new Option("C", "ͨ���̶��µ�������µ������ߵͲ�",null),
                         new Option("D", "ȥ���ż�",null),
                    }
                ),
                new Question("10-C", null, 2,
                    new List<Option>{
                         new Option("A", "�������ŷ�ʽ��������Э��",null),
                         new Option("B", "ȥ���ţ���Ϊ�������ڱ�",null),
                         new Option("C", "�����׿�����",null),
                    }
                ),
                new Question("10-D", null, 2,
                    new List<Option>{
                         new Option("A", "ƽ�����棨���е�̺ȥ����̺��",null),
                         new Option("B", "ʹ�÷�����",null),
                         new Option("C", "�������",null),
                    }
                ),
                new Question("10-E", null, 2,
                    new List<Option>{
                         new Option("A", "�ӵƹ�",null),
                         new Option("B", "����Ҫ��Ʒ����Ŀ��־",null),
                    }
                ),
                new Question("10-F", null, 2,
                    new List<Option>{
                         new Option("A", "�ı�ʹ�ÿ���/������ʽ�����ó���ȡ�������صȣ�",null),
                         new Option("B", "������Ŀ��־",null),
                         new Option("C", "���Ŀ���/����λ��",null),
                    }
                ),
                new Question("10-G", null, 2,
                    new List<Option>{
                         new Option("A", "�������̨��������°ڷ�",null),
                         new Option("B", "�䱸����������",null),
                         new Option("C", "������Ŀ��־",null),
                         new Option("D", "��������̨�����������¯̨��ˮ�أ�",null),
                    }
                ),
                new Question("10-H", "����",5,null),

                new Question("11", "����Ϊ���Ҵ��ڵ����⣨��ѡ��", 4,
                    new List<Option>{
                         new Option("A", "�������һ�Ҿ߰ڷŲ���","11-A"),
                         new Option("B", "�ſ��㣬�����ż����иߵ����","11-B"),
                         new Option("C", "�ſ�������","11-C"),
                         new Option("D", "���治ƽ���򲻷���","11-D"),
                         new Option("E", "���߲���","11-E"),
                         new Option("F", "ʹ�ÿ���/��������","11-F"),
                         new Option("G", "���ߡ���������","11-G"),
                         new Option("H", "����","11-H"),
                    }
                ),
                new Question("11-A", null, 2,
                    new List<Option>{
                         new Option("A", "���������Ʒ",null),
                         new Option("B", "������ͥ��Ʒ�ڷſռ��λ��",null),
                    }
                ),
                new Question("11-B", null, 2,
                    new List<Option>{
                         new Option("A", "�ı���ŷ�ʽ�������Ϊ��������Σ�����С�֣����̽��ż��ɡ������ν��š��̹��ż����ɵȣ�",null),
                         new Option("B", "�����ſ�",null),
                         new Option("C", "ͨ���̶��µ�������µ������ߵͲ�",null),
                         new Option("D", "ȥ���ż�",null),
                    }
                ),
                new Question("11-C", null, 2,
                    new List<Option>{
                         new Option("A", "�������ŷ�ʽ��������Э��",null),
                         new Option("B", "ȥ���ţ���Ϊ�������ڱ�",null),
                         new Option("C", "�����׿�����",null),
                    }
                ),
                new Question("11-D", null, 2,
                    new List<Option>{
                         new Option("A", "ƽ�����棨���е�̺ȥ����̺��",null),
                         new Option("B", "ʹ�÷�����",null),
                         new Option("C", "�������",null),
                    }
                ),
                new Question("11-E", null, 2,
                    new List<Option>{
                         new Option("A", "�ӵƹ�",null),
                         new Option("B", "��Ҫ��Ʒ����Ŀ��־",null),
                    }
                ),
                new Question("11-F", null, 2,
                    new List<Option>{
                         new Option("A", "���Ŀ���/����λ��",null),
                         new Option("B", "�ı�ʹ�ÿ���/������ʽ�����ó���ȡ�������صȣ�",null),
                         new Option("C", "������Ŀ��־",null),
                    }
                ),
                new Question("11-G", null, 2,
                    new List<Option>{
                         new Option("A", "���ӷ���",null),
                         new Option("B", "�������мܻ�����ศ�ߣ�������������������",null),
                    }
                ),
                new Question("11-H", "����",5,null),

                new Question("12", "����Ϊ����¥�ݴ��ڵ����⣨��ѡ��", 4,
                    new List<Option>{
                         new Option("A", "�޷��ֻ���ֲ�����","12-A"),
                         new Option("B", "�޷�ͨ����������¥��","12-B"),
                         new Option("C", "�����޷�����","12-C"),
                         new Option("D", "����","12-D"),
                    }
                ),
                new Question("12-A", null, 2,
                    new List<Option>{
                         new Option("A", "���ӷ���",null),
                         new Option("B", "��������",null),
                    }
                ),
                new Question("12-B", null, 2,
                    new List<Option>{
                         new Option("A", "ʹ������ʽ��¥��",null),
                    }
                ),
                new Question("12-C", null, 2,
                    new List<Option>{
                         new Option("A", "ʹ����������¥��",null),
                         new Option("B", "ѧϰ��������¥����",null),
                    }
                ),
                new Question("12-D", "����",5,null),

               new Question("13", "����",5,null),
            };
            Exam exam8 = new Exam(8, "FuJuPingGu", "���ϰ�", questions8);
            db.Exams.AddOrUpdate(exam8);
            #endregion

            #region ���߻ط�1
            List<Question> questions9 = new List<Question>
            {
                new Question("1", "�Ƿ��յ�����", 1,
                    new List<Option>{
                         new Option("A", "�յ�","2"),
                         new Option("B", "δ�յ�","5"),
                    }
                ),
                new Question("2", "����ʹ�����", 1,
                    new List<Option>{
                         new Option("A", "��δʹ��","3"),
                         new Option("B", "�Ѿ�ʹ��","3"),
                    }
                ),
                new Question("3", "���յ������Ƿ�����", 1,
                    new List<Option>{
                         new Option("A", "����","4"),
                         new Option("B", "������","4"),
                         new Option("C", "������","4"),
                    }
                ),
                new Question("4", "�Ƿ���Ҫ����ʹ����ѵ", 1,
                    new List<Option>{
                         new Option("A", "��Ҫ","5"),
                         new Option("B", "����Ҫ","5"),
                    }
                ),
                new Question("5", "�ط÷�ʽ", 1,
                    new List<Option>{
                         new Option("A", "�뻧",null),
                         new Option("B", "�绰",null),
                         new Option("C", "΢��",null),
                         new Option("D", "QQ",null),
                         new Option("E", "����",null),
                    }
                ),
            };
            Exam exam9 = new Exam(9, "FuJuFuWuHuiFang", "���߷���ط�1", questions9);
            db.Exams.AddOrUpdate(exam9);
            #endregion

            #region ���߻ط�2
            List<Question> questions10 = new List<Question>
            {
                 new Question("1", "����ʹ�����", 1,
                    new List<Option>{
                         new Option("A", "�Ӳ�","2"),
                         new Option("B", "ż��","2"),
                         new Option("C", "����","2"),
                    }
                ),
                new Question("2", "�Ը����Ƿ�����", 1,
                    new List<Option>{
                         new Option("A", "����","4"),
                         new Option("B", "������","4"),
                         new Option("C", "������","3"),
                    }
                ),
                new Question("3", "�Ը��߲������ԭ��", 1,
                    new List<Option>{
                         new Option("A", "������","4"),
                         new Option("B", "������","4"),
                         new Option("C", "����Ҫ","4"),
                         new Option("D", "����","4"),
                    }
                ),
                new Question("4", "�Ƿ���Ҫ���߷�������ṩָ��", 1,
                    new List<Option>{
                         new Option("A", "��Ҫ","5"),
                         new Option("B", "����Ҫ","5"),
                    }
                ),
                new Question("5", "�Ƿ���Ҫ�Ը��߽���ά��", 1,
                    new List<Option>{
                         new Option("A", "��Ҫ","6"),
                         new Option("B", "����Ҫ","6"),
                    }
                ),
                new Question("6", "�ط÷�ʽ", 3,
                    new List<Option>{
                         new Option("A", "�뻧",null),
                         new Option("B", "�绰",null),
                         new Option("C", "΢��",null),
                         new Option("D", "QQ",null),
                         new Option("E", "����","6-A"),
                    }
                ),
                new Question("6-A", "����",5,null),
            };
            Exam exam10 = new Exam(10, "FuJuFuWuHuiFang", "���߷���ط�2", questions10);
            db.Exams.AddOrUpdate(exam10);
            #endregion

            #region �����ط�
            List<Question> questions11 = new List<Question>
            {
                new Question("1", "�Ƿ�����˿�������", 1,
                    new List<Option>{
                         new Option("A", "�ѽ���","2"),
                         new Option("B", "δ����","3"),
                    }
                ),
                new Question("2", "���ṩ�Ŀ��������Ƿ�����", 1,
                    new List<Option>{
                         new Option("A", "����","3"),
                         new Option("B", "������","3"),
                         new Option("C", "������","3"),
                    }
                ),
                new Question("3", "�ط÷�ʽ", 1,
                    new List<Option>{
                         new Option("A", "�뻧",null),
                         new Option("B", "�绰",null),
                         new Option("C", "΢�Ż�QQ",null),
                         new Option("D", "����",null),
                    }
                ),
            };
            Exam exam11 = new Exam(11, "KangFuFuWuHuiFang", "��������ط�", questions11);
            db.Exams.AddOrUpdate(exam11);
            #endregion

            #region ������¼
            List<ExamRecord> examRecords = new List<ExamRecord>
            {

            };
            db.ExamRecords.AddRange(examRecords);
            #endregion
            db.SaveChanges();
        }
    }
}

