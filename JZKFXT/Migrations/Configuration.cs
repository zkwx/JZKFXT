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
                new User("admin","ySZJqoX9n","����",1,"13200000000","","", 12, DateTime.Now,""),
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
                new AssistiveDevice(102170301,"��¥������","���δ���",440),

                new AssistiveDevice(102170302,"��¥���������ع���","���δ���",441),
                new AssistiveDevice(102170601,"վ��ʽ������","���δ���",442),
                new AssistiveDevice(102180601,"��ҡ��̤����ʽ���ֳ�","���δ���",443),
                new AssistiveDevice(102180602,"��ҡ��̤����ʽ���ֳ�","���δ���",444),
                new AssistiveDevice(102180901,"��ҡ��������ʽ���ֳ�","���δ���",445),
                new AssistiveDevice(102180902,"��ҡ����ǰ��ʽ���ֳ�","���δ���",446),
                new AssistiveDevice(102180903,"ƽҡʽ��ҡ���ֳ�","���δ���",447),
                new AssistiveDevice(102180904,"����ʽ��ҡ���ֳ�","���δ���",448),
                new AssistiveDevice(102220301,"��ͨ���Σ������������Σ�","���δ���",449),
                new AssistiveDevice(102220302,"��������","���δ���",450),
                new AssistiveDevice(102220303,"ϴԡ����","���δ���",451),
                new AssistiveDevice(102220304,"ǰ����������","���δ���",452),
                new AssistiveDevice(102220305,"վ��ʽ�ֶ�����","���δ���",453),
                new AssistiveDevice(102220306,"б��ʽ�ֶ�����","���δ���",454),
                new AssistiveDevice(102220307,"��бʽ�ֶ�����","���δ���",455),
                new AssistiveDevice(102220308,"��������","���δ���",456),
                new AssistiveDevice(102220309,"�˶�����","���δ���",457),
                new AssistiveDevice(102220310,"��������","���δ���",458),
                new AssistiveDevice(102220311,"ƹ��������","���δ���",459),
                new AssistiveDevice(102220312,"���������","���δ���",460),
                new AssistiveDevice(102220313,"��������","���δ���",461),
                new AssistiveDevice(102220314,"�赸����","���δ���",462),
                new AssistiveDevice(102220315,"��������","���δ���",463),
                new AssistiveDevice(102220316,"ɳ̲����","���δ���",464),
                new AssistiveDevice(102220317,"Ӿ������","���δ���",465),
                new AssistiveDevice(102220318,"ѩ������","���δ���",466),
                new AssistiveDevice(102220319,"��������","���δ���",467),
                new AssistiveDevice(102220601,"˫�ְڸ���������","���δ���",468),
                new AssistiveDevice(102220602,"�ܸ���������","���δ���",469),
                new AssistiveDevice(102220901,"��������������","���δ���",470),
                new AssistiveDevice(102220902,"���ְڸ���������","���δ���",471),
                new AssistiveDevice(102221201,"���������ֶ����γ�","���δ���",472),
                new AssistiveDevice(102221501,"����������","���δ���",473),
                new AssistiveDevice(102221801,"�߿������Σ������㣩","���δ���",474),
                new AssistiveDevice(102221802,"��������","���δ���",475),
                new AssistiveDevice(102221803,"����ʽ����","���δ���",476),
                new AssistiveDevice(102221804,"����ʽ����","���δ���",477),
                new AssistiveDevice(102221805,"��������","���δ���",478),
                new AssistiveDevice(102221806,"վ��ʽ����","���δ���",479),
                new AssistiveDevice(102221807,"��������̱��ͯ����","���δ���",480),
                new AssistiveDevice(102221808,"ƽ������̱��ͯ����","���δ���",481),
                new AssistiveDevice(102221809,"��ͨ��ͯ����","���δ���",482),
                new AssistiveDevice(102230301,"�����͵綯����","���δ���",483),
                new AssistiveDevice(102230302,"�����͵綯����","���δ���",484),
                new AssistiveDevice(102230303,"��·�͵綯����","���δ���",485),
                new AssistiveDevice(102230304,"��ͨ�綯����","���δ���",486),
                new AssistiveDevice(102230305,"վ���綯����","���δ���",487),
                new AssistiveDevice(102230306,"б��ʽ�綯����","���δ���",488),
                new AssistiveDevice(102230307,"��бʽ�綯����","���δ���",489),
                new AssistiveDevice(102230308,"�綯��������","���δ���",490),
                new AssistiveDevice(102230309,"�綯��������","���δ���",491),
                new AssistiveDevice(102230310,"�綯���ֳ�","���δ���",492),
                new AssistiveDevice(102230311,"��ͯ�綯����","���δ���",493),
                new AssistiveDevice(102231501,"������ϵ��¥����","���δ���",494),
                new AssistiveDevice(102231502,"�Ĵ�ʽ��¥����","���δ���",495),
                new AssistiveDevice(102230901,"���ֻ������γ�","���δ���",496),
                new AssistiveDevice(102230902,"���ֻ������γ�","���δ���",497),
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

                new AssistiveDevice(102030301,"����ֱ�����ȣ��̶�/�ɵ���","��������",352),
                new AssistiveDevice(102030302,"�����������ȣ��̶�/�ɵ���","��������",353),
                new AssistiveDevice(102030303,"����S�����ȣ��̶�/�ɵ���","��������",354),
                new AssistiveDevice(102030304,"ֱ���������ȣ��̶�/�ɵ���","��������",355),
                new AssistiveDevice(102030305,"�����������ȣ��̶�/�ɵ���","��������",356),
                new AssistiveDevice(102030306,"S���������ȣ��̶�/�ɵ���","��������",357),
                new AssistiveDevice(102030307,"ֱ���Ľ����ȣ��̶�/�ɵ���","��������",358),
                new AssistiveDevice(102030308,"�����Ľ����ȣ��̶�/�ɵ���","��������",359),
                new AssistiveDevice(102030309,"S���Ľ����ȣ��̶�/�ɵ���","��������",360),
                new AssistiveDevice(102030310,"�۵�����","��������",361),
                new AssistiveDevice(102030311,"��������","��������",362),
                new AssistiveDevice(102030312,"��ɽ��","��������",363),
                new AssistiveDevice(102030601,"�̶�ʽ���","��������",364),
                new AssistiveDevice(102030602,"����ʽ���","��������",365),
                new AssistiveDevice(102030603,"������","��������",366),
                new AssistiveDevice(102030901,"����ǰ��֧�Ź�","��������",367),
                new AssistiveDevice(102030902,"����ǰ��֧�Ź�","��������",368),
                new AssistiveDevice(102030903,"�Ľ�ǰ��֧�Ź�","��������",369),
                new AssistiveDevice(102030904,"����ǰ���а��","��������",370),
                new AssistiveDevice(102030905,"ǰ���ж�Ű��","��������",371),
                new AssistiveDevice(102031201,"��ͨҸ�գ����ţ�","��������",372),
                new AssistiveDevice(102031202,"����Ҹ��","��������",373),
                new AssistiveDevice(102031203,"����Ҹ��","��������",374),
                new AssistiveDevice(102031204,"���Ҹ��","��������",375),
                new AssistiveDevice(102031205,"��֧��Ҹ��","��������",376),
                new AssistiveDevice(102031206,"ǰ���а�Ҹ��","��������",377),
                new AssistiveDevice(102031207,"��ͯҸ��","��������",378),
                new AssistiveDevice(102031801,"������������","��������",379),
                new AssistiveDevice(102381901,"����������м�","��������",380),
                new AssistiveDevice(102060301,"���ſ�ʽ������","��������",381),
                new AssistiveDevice(102060302,"�Ľſ�ʽ������","��������",382),
                new AssistiveDevice(102060303,"���ݿ�ʽ������","��������",383),
                new AssistiveDevice(102060304,"�����ʽ������������ʽ/�ʽ��","��������",384),
                new AssistiveDevice(102060305,"�ɵ�ʽ������","��������",385),
                new AssistiveDevice(102060306,"ƽ̨ʽ������","��������",386),
                new AssistiveDevice(102060307,"�ֳ�����ʽ������","��������",387),
                new AssistiveDevice(102060601,"�ַ�����������","��������",388),
                new AssistiveDevice(102060602,"�ַ�����������","��������",389),
                new AssistiveDevice(102060603,"�ַ�����������","��������",390),
                new AssistiveDevice(102060604,"�ַ��๦��������","��������",391),
                new AssistiveDevice(102060605,"��ʽ����������","��������",392),
                new AssistiveDevice(102060606,"��ʽ����������","��������",393),
                new AssistiveDevice(102060607,"��������������","��������",394),
                new AssistiveDevice(102060608,"Ҹ������������","��������",395),
                new AssistiveDevice(102060609,"��ѹ�ƶ�����������","��������",396),
                new AssistiveDevice(102060610,"������ʽ����������","��������",397),
                new AssistiveDevice(102060901,"�̶�֧����ʽ������","��������",398),
                new AssistiveDevice(102060902,"����֧����ʽ������","��������",399),
                new AssistiveDevice(102061201,"ƽ̨֧��̨ʽ������","��������",400),
                new AssistiveDevice(102061202,"ǰ��֧��̨ʽ������","��������",401),
                new AssistiveDevice(102061203,"�̶�ʽ������","��������",402),
                new AssistiveDevice(102061204,"�ɵ�ʽ������","��������",403),
                new AssistiveDevice(102061205,"���ִ���������","��������",404),
                new AssistiveDevice(102061206,"���ִ����۵�������","��������",405),
                new AssistiveDevice(102061207,"���ִ�ɲ������������","��������",406),
                new AssistiveDevice(102070501,"�ӷ������ϵ�֧��","��������",407),
                new AssistiveDevice(102070502,"����֧��","��������",408),
                new AssistiveDevice(102070503,"֧�ŵ�","��������",409),
                new AssistiveDevice(102071201,"�ɵ�����","��������",410),
                new AssistiveDevice(102071202,"��������","��������",411),
                new AssistiveDevice(102071203,"�ֱ���","��������",412),
                new AssistiveDevice(102071204,"����װ��","��������",413),
                new AssistiveDevice(102071501,"Ҹ��","��������",414),
                new AssistiveDevice(102071502,"����","��������",415),
                new AssistiveDevice(102071503,"ͷ��","��������",416),
                new AssistiveDevice(102071504,"��ȫ��","��������",417),
                new AssistiveDevice(102071801,"���ȵ�","��������",418),
                new AssistiveDevice(102071802,"���мܵ�","��������",419),
                new AssistiveDevice(102072101,"Ӳ������","��������",420),
                new AssistiveDevice(102072102,"����������","��������",421),
                new AssistiveDevice(102072103,"���۵�����","��������",422),
                new AssistiveDevice(102072401,"�����","��������",423),
                new AssistiveDevice(102072402,"�ҹ�","��������",424),
                new AssistiveDevice(102072403,"���","��������",425),
                new AssistiveDevice(102072404,"ɡ�̶���","��������",426),
                new AssistiveDevice(102072405,"���ȹ̶���","��������",427),
                new AssistiveDevice(102072406,"ǰ���а�","��������",428),
                new AssistiveDevice(102072407,"֧�ŵ���","��������",429),
                new AssistiveDevice(102072701,"������ͣ���ƶ�װ��","��������",430),
                new AssistiveDevice(102073001,"���Ƹ�","��������",431),
                new AssistiveDevice(102073002,"����ת��","��������",432),
                new AssistiveDevice(102073003,"���ż���·�ص�װ��","��������",433),
                new AssistiveDevice(102073004,"�����ƶ���","��������",434),
                new AssistiveDevice(102073301,"�߶�������","��������",435),
                new AssistiveDevice(102073601,"������","��������",436),
                new AssistiveDevice(102073602,"��ȫ�ź�װ��","��������",437),
                new AssistiveDevice(102073603,"���⾵","��������",438),
                new AssistiveDevice(102073901,"С����","��������",439),
                new AssistiveDevice(102390301,"���Ͻ���ͨä�ȣ�ֱ�ˣ�","��������",508),
                new AssistiveDevice(102390302,"����ä������","��������",509),
                new AssistiveDevice(102390303,"�����۵�����ä��","��������",510),
                new AssistiveDevice(102390304,"���Ͻ�����ä��","��������",511),
                new AssistiveDevice(102390305,"���Ͻ�����ä��","��������",512),
                new AssistiveDevice(102390306,"����������ä��","��������",513),
                new AssistiveDevice(102390307,"������ää��","��������",514),
                new AssistiveDevice(102390308,"����ʽä��","��������",515),
                new AssistiveDevice(102390309,"ä����","��������",516),
                new AssistiveDevice(102390601,"���ӵ�ä��","��������",517),
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

                new AssistiveDevice(110030601,"�����в���","��ʳ",1260),
                new AssistiveDevice(110030602,"���̶��в˰�","��ʳ",1261),
                new AssistiveDevice(110030603,"�๦�ܵ����в���","��ʳ",1262),
                new AssistiveDevice(110030701,"������ä�ĵ��¯","��ʳ",1263),
                new AssistiveDevice(110030702,"΢����ä��������ѹ����","��ʳ",1264),
                new AssistiveDevice(110030703,"ä������΢��¯","��ʳ",1265),
                new AssistiveDevice(110030704,"΢����ä��������ʩ��","��ʳ",1266),
                new AssistiveDevice(110030705,"������ä�ĵ緹��","��ʳ",1267),
                new AssistiveDevice(110030706,"������ä�ĵ�ѹ����","��ʳ",1268),
                new AssistiveDevice(110030707,"΢����ä���������¯","��ʳ",1269),
                new AssistiveDevice(110030901,"��������Ƥ��","��ʳ",1270),
                new AssistiveDevice(110030902,"�̶���ʽ��Ƥ��","��ʳ",1271),
                new AssistiveDevice(110030903,"�����̲�ˢ","��ʳ",1272),
                new AssistiveDevice(110030904,"�ں˵ĵ���","��ʳ",1273),
                new AssistiveDevice(110031201, "�濾��", "��ʳ",1274),
                new AssistiveDevice(110031202, "�濾��", "��ʳ",1275),
                new AssistiveDevice(110031203, "�濾��", "��ʳ",1276),
                new AssistiveDevice(110031501, "����", "��ʳ",1277),
                new AssistiveDevice(110031801, "������ͼ帨������", "��ʳ",1278),
                new AssistiveDevice(110031901, "�����ͺ�", "��ʳ",1279),
                new AssistiveDevice(110032001, "�Զ���ҩ��", "��ʳ",1280),
                new AssistiveDevice(110060601, "��������ˢ", "��ʳ",1281),
                new AssistiveDevice(110060602, "������ƿˢ", "��ʳ",1282),
                new AssistiveDevice(110060901, "�����˸���", "��ʳ",1283),
                new AssistiveDevice(110061501, "Ĩ���ʸɻ�", "��ʳ",1284),
                new AssistiveDevice(110090301,"��Ӧʳ������ϵĸ�������","��ʳ",1285),
                new AssistiveDevice(110091801, "��ͨ������", "��ʳ",1286),
                new AssistiveDevice(110091802, "���·�����", "��ʳ",1287),
                new AssistiveDevice(110091803, "�ײ������̲;�", "��ʳ",1288),
                new AssistiveDevice(110091804, "����", "��ʳ",1289),
                new AssistiveDevice(110092101, "�̵�", "��ʳ",1290),
                new AssistiveDevice(110092102, "���Ϸ�����", "��ʳ",1291),
                new AssistiveDevice(110092201, "�ֱ���", "��ʳ",1292),
                new AssistiveDevice(110092202, "�����", "��ʳ",1293),
                new AssistiveDevice(110092203, "�����", "��ʳ",1294),
                new AssistiveDevice(110092204, "����ʽ��", "��ʳ",1295),
                new AssistiveDevice(110092301, "�������ף�2֧װ��", "��ʳ",1296),
                new AssistiveDevice(110092302, "���������ͷ��", "��ʳ",1297),
                new AssistiveDevice(110092303, "�ֱ���", "��ʳ",1298),
                new AssistiveDevice(110092304, "����ʽ��", "��ʳ",1299),
                new AssistiveDevice(110092305, "���ܼ�����", "��ʳ",1300),
                new AssistiveDevice(110092401, "����ѵ��������", "��ʳ",1301),
                new AssistiveDevice(110092402, "������������", "��ʳ",1302),
                new AssistiveDevice(110092403, "�������Ͽ���", "��ʳ",1303),
                new AssistiveDevice(110092404, "�����Ϳ�", "��ʳ",1304),
                new AssistiveDevice(110092501, "��©ˮ����С�ţ�", "��ʳ",1305),
                new AssistiveDevice(110092502, "б�ڱ�", "��ʳ",1306),
                new AssistiveDevice(110092503, "�����", "��ʳ",1307),
                new AssistiveDevice(110092504, "���ܱ�", "��ʳ",1308),
                new AssistiveDevice(110092701, "�綯ιʳ��", "��ʳ",1309),
                new AssistiveDevice(110093001, "ιʳ��", "��ʳ",1310),
                new AssistiveDevice(110093101, "����������", "��ʳ",1311),
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

                new AssistiveDevice(103150301,"��ͨ�����ܲ��","���˻���",592),
                new AssistiveDevice(103150302,"��ǿ�����ܲ��","���˻���",593),
                new AssistiveDevice(103150601,"�����п���������","���˻���",594),
                new AssistiveDevice(103150602,"���ܲ�ܼ�ʪ������","���˻���",595),
                new AssistiveDevice(103150603, "���ܲ�ܷ��籣����", "���˻���",596),
                new AssistiveDevice(103180401, "һ��ʽ�����ڴ�", "���˻���",597),
                new AssistiveDevice(103180501, "����ʽ�����ڴ�", "���˻���",598),
                new AssistiveDevice(103180701,"������������һ��ʽ������ڴ�","���˻���",599),
                new AssistiveDevice(103180801,"����������������ʽ������ڴ�","���˻���",600),
                new AssistiveDevice(103180901, "��ڴ�֧�ź�ѹ�̸�������", "���˻���",601),
                new AssistiveDevice(103181301, "��ڻ���ѹ��ʹ���", "���˻���",602),
                new AssistiveDevice(103181401, "��ڻ���ճ����", "���˻���",603),
                new AssistiveDevice(103181501, "��ڴ��ܷ��", "���˻���",604),
                new AssistiveDevice(103181801,"��ڻ�����ζ�������ͳ�����","���˻���",605),
                new AssistiveDevice(103182101, "���η�ڼ�", "���˻���",606),
                new AssistiveDevice(103182102, "Բ�η�ڼ�", "���˻���",607),
                new AssistiveDevice(103182401, "Ͳʽ�೦��", "���˻���",608),
                new AssistiveDevice(103182402, "��ʽ�೦��", "���˻���",609),
                new AssistiveDevice(103182403,"��ҡ�೦��","���˻���",610),
                new AssistiveDevice(103182404, "ȫ�Զ��೦��", "���˻���",611),
                new AssistiveDevice(103182405,"һ���Թ೦��","���˻���",612),
                new AssistiveDevice(103183001, "ͨ���ͷ�����", "���˻���",613),
                new AssistiveDevice(103183002, "�����ͷ�����", "���˻���",614),
                new AssistiveDevice(103183003,"�����ͷ�����","���˻���",615),
                new AssistiveDevice(103183301, "���ڵ�Һ��", "���˻���",616),
                new AssistiveDevice(103183601, "��ڻ����ó�ϴע����", "���˻���",617),
                new AssistiveDevice(103183901, "����һ��ʽ��ڴ�", "���˻���",618),
                new AssistiveDevice(103183902,"��ͯһ��ʽ��ڴ�","���˻���",619),
                new AssistiveDevice(103183903, "������������һ��ʽ��ڴ�", "���˻���",620),
                new AssistiveDevice(103184201, "Ƕ��ʽ����ʽ��ڴ�", "���˻���",621),
                new AssistiveDevice(103184202,"ճ��ʽ����ʽ��ڴ�","���˻���",622),
                new AssistiveDevice(103184203,"����������������ʽ��ڴ�","���˻���",623),
                new AssistiveDevice(103184501, "��ڻ���Ƥ���ڸǲ�", "���˻���",624),
                new AssistiveDevice(103184801, "������ڴ������", "���˻���",625),
                new AssistiveDevice(103210301, "�ʽ���", "���˻���",626),
                new AssistiveDevice(103210601, "�����", "���˻���",627),
                new AssistiveDevice(103210901, "������", "���˻���",628),
                new AssistiveDevice(103211201, "ɴ������", "���˻���",629),
                new AssistiveDevice(103211202, "��Ĥ����", "���˻���",630),
                new AssistiveDevice(103211203, "ˮ�������", "���˻���",631),
                new AssistiveDevice(103211204, "����", "���˻���",632),
                new AssistiveDevice(103211501, "�ܷ����", "���˻���",633),
                new AssistiveDevice(103211801, "������", "���˻���",634),
                new AssistiveDevice(103360301, "ָ��ˢ", "���˻���",712),
                new AssistiveDevice(103360601, "������ָ���", "���˻���",713),
                new AssistiveDevice(103360602, "������ɰֽ��", "���˻���",714),
                new AssistiveDevice(103360901, "���Ŵ�ָ�׼�", "���˻���",715),
                new AssistiveDevice(103360902, "������ָ�׼�", "���˻���",716),
                new AssistiveDevice(103360903, "�Ŵ�ָ�׵�", "���˻���",717),
                new AssistiveDevice(103361201, "�ֶ���Ƥ�޼���", "���˻���",718),
                new AssistiveDevice(103390301,"��ϴ����ϴͷ���ĸ�������","���˻���",719),
                new AssistiveDevice(103390701, "����ͷ��", "���˻���",720),
                new AssistiveDevice(103390601, "������ˢ", "���˻���",721),
                new AssistiveDevice(103390602, "�ֱ���ˢ", "���˻���",722),
                new AssistiveDevice(103390603, "�����ˢ", "���˻���",723),
                new AssistiveDevice(103390604, "����ʽ��ˢ", "���˻���",724),
                new AssistiveDevice(103390901, "�����", "���˻���",725),
                new AssistiveDevice(103420301, "�����ˢ", "���˻���",726),
                new AssistiveDevice(103420302, "�ֱ���ˢ", "���˻���",727),
                new AssistiveDevice(103420303, "����ʽ��ˢ", "���˻���",728),
                new AssistiveDevice(103420304, "������ˢ", "���˻���",729),
                new AssistiveDevice(103420601, "��ͨ�綯��ˢ", "���˻���",730),
                new AssistiveDevice(103420602, "����ʽ�綯��ˢ", "���˻���",731),
                new AssistiveDevice(103420603, "�ֱ��綯��ˢ", "���˻���",732),
                new AssistiveDevice(103450301, "����ˢ", "���˻���",733),
                new AssistiveDevice(103450302, "�굶", "���˻���",734),
                new AssistiveDevice(103450303, "�ֶ����뵶", "���˻���",735),
                new AssistiveDevice(103450304, "�綯���뵶", "���˻���",736),
                new AssistiveDevice(103450601, "��ױƷʹ�ø�������", "���˻���",737),
                new AssistiveDevice(103450901, "���������õľ���", "���˻���",738),
                new AssistiveDevice(104080101, "��ֱͨ�廤��", "���˻���",739),
                new AssistiveDevice(104080102, "��ͨ�����۵�����", "���˻���",740),
                new AssistiveDevice(104080103, "�ֶ���ҡ����", "���˻���",741),
                new AssistiveDevice(104080104, "�ֶ�˫ҡ����", "���˻���",742),
                new AssistiveDevice(104080105, "�ֶ���ҡ�������ɷ���", "���˻���",743),
                new AssistiveDevice(104080106, "��ͨ�綯����", "���˻���",744),
                new AssistiveDevice(104080107, "�����綯����", "���˻���",745),
                new AssistiveDevice(104080108, "����綯����", "���˻���",746),
                new AssistiveDevice(104100301, "�ɵ��������ܣ�", "���˻���",753),
                new AssistiveDevice(104100302, "��ͨ����", "���˻���",754),
                new AssistiveDevice(104100303, "�����Ϳ���", "���˻���",755),
                new AssistiveDevice(104100601, "��¨����ĭ����", "���˻���",756),
                new AssistiveDevice(104100602,"�䳲�;�����������","���˻���",757),
                new AssistiveDevice(104100603, "Һ̬����������", "���˻���",758),
                new AssistiveDevice(104100604,"����ʽ����","���˻���",759),
                new AssistiveDevice(104100605, "����ʽ����", "���˻���",760),
                new AssistiveDevice(104100606, "������", "���˻���",761),
                new AssistiveDevice(104100607, "��׵��", "���˻���",762),
                new AssistiveDevice(104100901, "�������ˣ����Ի�����", "���˻���",763),
                new AssistiveDevice(104100902, "�Ϸ�ʽǰ�۷���", "���˻���",764),
                new AssistiveDevice(104100903, "�̶�ʽǰ�۷���", "���˻���",765),
                new AssistiveDevice(104100904, "���Է���", "���˻���",766),
                new AssistiveDevice(104100905, "ԡ�׷���", "���˻���",767),
                new AssistiveDevice(104101201, "������ͷ��", "���˻���",768),
                new AssistiveDevice(104101202, "�����Ͼ���", "���˻���",769),
                new AssistiveDevice(104101203, "����", "���˻���",770),
                new AssistiveDevice(104101204,"�Ͼ���","���˻���",771),
                new AssistiveDevice(104101501, "����������", "���˻���",772),
                new AssistiveDevice(104101502, "����������", "���˻���",773),
                new AssistiveDevice(104101503, "��������λ��Ű�", "���˻���",774),
                new AssistiveDevice(104101801, "�����Ϲ�����", "���˻���",775),
                new AssistiveDevice(104101802, "������������", "���˻���",776),
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

                new AssistiveDevice(103120301,"�۵�������","���",569),
                new AssistiveDevice(103120302,"�̶�������","���",570),
                new AssistiveDevice(103120303,"����������","���",571),
                new AssistiveDevice(103120304,"����������","���",572),
                new AssistiveDevice(103120305,"������������","���",573),
                new AssistiveDevice(103120306,"��������������","���",574),
                new AssistiveDevice(103120307,"��ͯ������","���",575),
                new AssistiveDevice(103120601,"����������","���",576),
                new AssistiveDevice(103120602,"����������","���",577),
                new AssistiveDevice(103120603,"���ó�ϴ����������","���",578),
                new AssistiveDevice(103120901,"��������","���",579),
                new AssistiveDevice(103121201,"�����ּӸ�����������","���",580),
                new AssistiveDevice(103121501,"Ƕ���ͼӸߵ���������","���",581),
                new AssistiveDevice(103121801,"��װ���������ϼӸߵ���������","���",582),
                new AssistiveDevice(103122101,"����������������","���",583),
                new AssistiveDevice(103122401,"�̶����������ϵ�����֧�ż�","���",584),
                new AssistiveDevice(103122501,"���ʽ�������ķ��ֿ���","���",585),
                new AssistiveDevice(103122701,"�̱���ֽ��","���",586),
                new AssistiveDevice(103122702,"������ֽ��","���",587),
                new AssistiveDevice(103123301,"��Яʽ��������","���",588),
                new AssistiveDevice(103123302,"���ϴ����","���",589),
                new AssistiveDevice(103123601,"��������ϴ��","���",590),
                new AssistiveDevice(103123602,"�������ȷ������","���",591),
                new AssistiveDevice(103240301,"�������õ����","���",635),
                new AssistiveDevice(103240302,"Ů�����õ����","���",636),
                new AssistiveDevice(103240303,"С�����õ����","���",637),
                new AssistiveDevice(103240601,"���ü�Ъ�Ե����","���",638),
                new AssistiveDevice(103240602,"Ů�ü�Ъ�Ե����","���",639),
                new AssistiveDevice(103240603,"С����Ъ�Ե����","���",640),
                new AssistiveDevice(103240901,"��������������","���",641),
                new AssistiveDevice(103240902,"С������������","���",642),
                new AssistiveDevice(103241501,"��ͨŮ�����","���",643),
                new AssistiveDevice(103241502,"����Ů�����","���",644),
                new AssistiveDevice(103241503,"���̶�Ů�����","���",645),
                new AssistiveDevice(103242101, "��ͨ�������", "���",646),
                new AssistiveDevice(103242102, "�����������", "���",647),
                new AssistiveDevice(103242103,"���̶��������","���",648),
                new AssistiveDevice(103270401, "����ʽ���Է�ڼ�����", "���",649),
                new AssistiveDevice(103270402, "�뵼���һͬʹ�õĴ���", "���",650),
                new AssistiveDevice(103270501, "����ʽ���Կ��ڼ�����", "���",651),
                new AssistiveDevice(103270502, "�뵼���һͬʹ�õĴ���", "���",652),
                new AssistiveDevice(103270901, "�Ǵ���ʽ���������ƿ", "���",653),
                new AssistiveDevice(103271301, "����������", "���",654),
                new AssistiveDevice(103271302, "���������̴�", "���",655),
                new AssistiveDevice(103271801, "�齺������", "���",656),
                new AssistiveDevice(103271802, "��ͨ������", "���",657),
                new AssistiveDevice(103271803, "���ʽ������", "���",658),
                new AssistiveDevice(103271804, "������", "���",659),
                new AssistiveDevice(103272101, "һ���Է���ռ���", "���",660),
                new AssistiveDevice(103272102, "�ɳ�ϴ����ռ���", "���",661),
                new AssistiveDevice(103301201, "��ͯ��ʪ", "���",662),
                new AssistiveDevice(103301202, "��ͯ��ĵ�", "���",663),
                new AssistiveDevice(103301501, "��ͯ����̺", "���",664),
                new AssistiveDevice(103301801, "ֽ����ĵ�", "���",665),
                new AssistiveDevice(103302101, "����ֽ���", "���",666),
                new AssistiveDevice(103304201, "һ���Բ���", "���",667),
                new AssistiveDevice(103304202, "һ����������", "���",668),
                new AssistiveDevice(103304203,"һ���Դ���","���",669),
                new AssistiveDevice(103304204, "һ���Դ���", "���",670),
                new AssistiveDevice(103304501, "������", "���",671),
                new AssistiveDevice(103304502, "����", "���",672),
                new AssistiveDevice(103304503, "����", "���",673),
                new AssistiveDevice(103310301, "������Ʋ���", "���",674),
                new AssistiveDevice(103310302, "�������", "���",675),
                new AssistiveDevice(103310303, "������", "���",676),
                new AssistiveDevice(103310304, "������", "���",677),
                new AssistiveDevice(103310305, "�����͵ļн�����ܵ�����", "���",678),
                new AssistiveDevice(103310601, "���Ų���", "���",679),
                new AssistiveDevice(103310602, "���Ų���", "���",680),
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

                new AssistiveDevice(105272101,"���Ժ�����","��Ϣ����",798),
                new AssistiveDevice(105272102,"���籨����","��Ϣ����",799),
                new AssistiveDevice(105090301,"���Խ�����","��Ϣ����",845),
                new AssistiveDevice(105090601,"�����������Ŵ���","��Ϣ����",846),
                new AssistiveDevice(105150301,"����ä��ѧϰ������","��Ϣ����",870),
                new AssistiveDevice(105150601,"�������Ӽ�����","��Ϣ����",871),
                new AssistiveDevice(105150901,"�����������","��Ϣ����",872),
                new AssistiveDevice(105180301,"�����","��Ϣ����",873),
                new AssistiveDevice(105180601,"��̱��ͯѧϰ��","��Ϣ����",874),
                new AssistiveDevice(105180901,"����������","��Ϣ����",875),
                new AssistiveDevice(105181201,"˫�����߶Խ���","��Ϣ����",876),
                new AssistiveDevice(105181501,"���ӻ�","��Ϣ����",877),
                new AssistiveDevice(105181801,"��·����ϵͳ","��Ϣ����",878),
                new AssistiveDevice(105182101,"ͼ�ĺ��ı����ӽ�����","��Ϣ����",879),
                new AssistiveDevice(105182401,"���ߵ�Ƶ�ʴ���ϵͳ","��Ϣ����",880),
                new AssistiveDevice(105182701,"������Ϣ�������ϵͳ","��Ϣ����",881),
                new AssistiveDevice(105210301,"ä��ר������","��Ϣ����",882),
                new AssistiveDevice(105210302,"ä���˿�","��Ϣ����",883),
                new AssistiveDevice(105210303,"�����������˿�","��Ϣ����",884),
                new AssistiveDevice(105210901,"˫�����߶Խ�����","��Ϣ����",885),
                new AssistiveDevice(105210902,"�������߶Խ�����","��Ϣ����",886),
                new AssistiveDevice(105210903,"���߶Խ�����","��Ϣ����",887),
                new AssistiveDevice(105210904,"USB ������д������","��Ϣ����",888),
                new AssistiveDevice(105210905,"��ɫ��д������","��Ϣ����",889),
                new AssistiveDevice(105210906,"������д������","��Ϣ����",890),
                new AssistiveDevice(105210907,"E��ͨ","��Ϣ����",891),
                new AssistiveDevice(105210908,"΢�������ǹ�ͨ�ǣ�7�磩","��Ϣ����",892),
                new AssistiveDevice(105211201,"��֪��ͨ����","��Ϣ����",893),
                new AssistiveDevice(105211202,"���﹵ͨ����","��Ϣ����",894),
                new AssistiveDevice(105211203,"���﹵ͨ����","��Ϣ����",895),
                new AssistiveDevice(105240301, "ä�������绰��", "��Ϣ����",896),
                new AssistiveDevice(105240302, "��ä�ĵ绰��", "��Ϣ����",897),
                new AssistiveDevice(105240303, "����������̵绰", "��Ϣ����",898),
                new AssistiveDevice(105240304, "���ӵ绰��", "��Ϣ����",899),
                new AssistiveDevice(105240601, "ä�����ֻ�", "��Ϣ����",900),
                new AssistiveDevice(105240901, "��ͨͼ�ĵ绰��", "��Ϣ����",901),
                new AssistiveDevice(105240902, "ä�ķ��ŵ绰��", "��Ϣ����",902),
                new AssistiveDevice(105241501, "�绰Ӧ���", "��Ϣ����",903),
                new AssistiveDevice(105241801, "�绰������", "��Ϣ����",904),
                new AssistiveDevice(105242401,"Զ�̽�����Զ����Ϣ�������","��Ϣ����",905),
                new AssistiveDevice(105242701, "�ڲ�ͨ��װ��", "��Ϣ����",906),
                new AssistiveDevice(105243001, "Ӧ�ŶԽ��绰", "��Ϣ����",907),
                new AssistiveDevice(105270301, "������������", "��Ϣ����",908),
                new AssistiveDevice(105270302, "������������", "��Ϣ����",909),
                new AssistiveDevice(105270303, "��ͨ��������", "��Ϣ����",910),
                new AssistiveDevice(105270304, "ң����������", "��Ϣ����",911),
                new AssistiveDevice(105270601, "ä�˵㳮��", "��Ϣ����",912),
                new AssistiveDevice(105270602, "��ʽȫ�Զ�Ѫѹ��", "��Ϣ����",913),
                new AssistiveDevice(105270603, "������ӳӣ�������", "��Ϣ����",914),
                new AssistiveDevice(105270604, "������ӳӣ�������", "��Ϣ����",915),
                new AssistiveDevice(105270605, "���籨����", "��Ϣ����",916),
                new AssistiveDevice(105270606, "������ʾ��", "��Ϣ����",917),
                new AssistiveDevice(105270607, "�����������¼�", "��Ϣ����",918),
                new AssistiveDevice(105270608, "��ʽȫ�Զ�Ѫѹ�ƣ�������", "��Ϣ����",919),
                new AssistiveDevice(105270609, "���ܼҾӰ�ȫԤ����", "��Ϣ����",920),
                new AssistiveDevice(105270610, "��������ȼ��ʽ������", "��Ϣ����",921),
                new AssistiveDevice(105270611, "���������ˮ��", "��Ϣ����",922),
                new AssistiveDevice(105270612, "����Ѱ����", "��Ϣ����",923),
                new AssistiveDevice(105270613, "΢��������������", "��Ϣ����",924),
                new AssistiveDevice(105270614, "�����������ʽ������", "��Ϣ����",925),
                new AssistiveDevice(105270615, "����ָ����", "��Ϣ����",926),
                new AssistiveDevice(105270901, "ä��ֽ��ʶ����", "��Ϣ����",927),
                new AssistiveDevice(105270902, "�๦�������ֱ�", "��Ϣ����",928),
                new AssistiveDevice(105271201, "��������ä��", "��Ϣ����",929),
                new AssistiveDevice(105271202, "ʵ�ô���ä��", "��Ϣ����",930),
                new AssistiveDevice(105271203, "��ʱ��", "��Ϣ����",931),
                new AssistiveDevice(105271204, "������", "��Ϣ����",932),
                new AssistiveDevice(105271205, "���ֱ�", "��Ϣ����",933),
                new AssistiveDevice(105271206, "���ܶ�λ�ֱ�", "��Ϣ����",934),
                new AssistiveDevice(105271501, "ä��������", "��Ϣ����",935),
                new AssistiveDevice(105271601, "��������Ĳ�Ʒ", "��Ϣ����",936),
                new AssistiveDevice(105271801, "������", "��Ϣ����",937),
                new AssistiveDevice(105272103, "ˮ������", "��Ϣ����",938),
                new AssistiveDevice(105272401, "���Ͷ�λϵͳ", "��Ϣ����",939),
                new AssistiveDevice(105272701, "��ʶ���Ϻͱ�ǹ���", "��Ϣ����",940),
                new AssistiveDevice(105300301, "������������Ķ�����", "��Ϣ����",941),
                new AssistiveDevice(105300601, "�������ӡˢ���Ķ�����", "��Ϣ����",942),
                new AssistiveDevice(105300901, "���˼��������̲�", "��Ϣ����",943),
                new AssistiveDevice(105300902, "�����ճ��Ự�̲�", "��Ϣ����",944),
                new AssistiveDevice(105300903, "��������ʻ�̲�", "��Ϣ����",945),
                new AssistiveDevice(105300904, "����������Ƶ��ѵ�̲�", "��Ϣ����",946),
                new AssistiveDevice(105301201, "������", "��Ϣ����",947),
                new AssistiveDevice(105301501, "���ʽ��֧�ż�", "��Ϣ����",948),
                new AssistiveDevice(105301502, "���ʽ��̶���", "��Ϣ����",949),
                new AssistiveDevice(105302101, "��Яʽ�๦���Ķ���", "��Ϣ����",950),
                new AssistiveDevice(105302102, "����������֪�����ǣ�32cm)", "��Ϣ����",951),
                new AssistiveDevice(105302103, "���������֪��ͼ��װ��������ʣ�", "��Ϣ����",952),
                new AssistiveDevice(105302104, "�����й�����������ͼ", "��Ϣ����",953),
                new AssistiveDevice(105302105, "ä��������", "��Ϣ����",954),
                new AssistiveDevice(105302106, "һ��ʽ�����Ķ���", "��Ϣ����",955),
                new AssistiveDevice(105302107, "�����", "��Ϣ����",958),
                new AssistiveDevice(105301801, "�Ķ����", "��Ϣ����",956),
                new AssistiveDevice(105301802, "���ʽ�����޶���", "��Ϣ����",957),
                new AssistiveDevice(105302401, "ä�Ľ̲�", "��Ϣ����",959),
                new AssistiveDevice(105302701, "�����ϰ����ö�ý��������", "��Ϣ����",960),
                new AssistiveDevice(105302702,"�Ӿ��ϰ����ö�ý��������","��Ϣ����",961),
                new AssistiveDevice(105330301, "����ʽ�����", "��Ϣ����",962),
                new AssistiveDevice(105330302, "ä�������������", "��Ϣ����",963),
                new AssistiveDevice(105330601, "��Яʽ������͸�����������PDA��", "��Ϣ����",964),
                new AssistiveDevice(105330901, "������Ϣ�������ն�", "��Ϣ����",965),
                new AssistiveDevice(105331201, "�������", "��Ϣ����",966),
                new AssistiveDevice(105331501, "����Ҷ�������", "��Ϣ����",967),
                new AssistiveDevice(105331502, "�����׼���������", "��Ϣ����",968),
                new AssistiveDevice(105331801, "�������ô��������", "��Ϣ����",969),
                new AssistiveDevice(105331802, "�������", "��Ϣ����",970),
                new AssistiveDevice(105331803, "�ֲ�����֧��", "��Ϣ����",971),
                new AssistiveDevice(105360301, "ä���ü���", "��Ϣ����",972),
                new AssistiveDevice(105360302, "���ּ���", "��Ϣ����",973),
                new AssistiveDevice(105361201, "����ʽ�����û���", "��Ϣ����",974),
                new AssistiveDevice(105361202,"����ʽ�����û���","��Ϣ����",975),
                new AssistiveDevice(105361203, "����ʽ�����û���", "��Ϣ����",976),
                new AssistiveDevice(105361501, "�������", "��Ϣ����",977),
                new AssistiveDevice(105361801, "�������", "��Ϣ����",978),
                new AssistiveDevice(105362101, "��켣�����", "��Ϣ����",979),
                new AssistiveDevice(105362102, "�ſ����", "��Ϣ����",980),
                new AssistiveDevice(105390401, "��Ļ�Ŵ���", "��Ϣ����",981),
                new AssistiveDevice(105390501, "40 ��������", "��Ϣ����",982),
                new AssistiveDevice(105390502, "80 ��������", "��Ϣ����",983),
                new AssistiveDevice(105390601, "ä�Ĵ�ӡ��", "��Ϣ����",984),
                new AssistiveDevice(105390701, "�����������ʾ��", "��Ϣ����",985),
                new AssistiveDevice(105391201, "��궨λ����Ļ�Ŵ����", "��Ϣ����",986),
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

                new AssistiveDevice(106360301,"����ѵ����","����ѵ��",1053),
                new AssistiveDevice(106360302,"��й������Э���������ѵ����","����ѵ��",1054),
                new AssistiveDevice(106360303, "��������", "����ѵ��",1055),
                new AssistiveDevice(106360304,"��״���ѵ����","����ѵ��",1056),
                new AssistiveDevice(106360305, "���ѵ����", "����ѵ��",1057),
                new AssistiveDevice(106360601, "����Э��������Ϸ���", "����ѵ��",1058),
                new AssistiveDevice(106360901, "���", "����ѵ��",1059),
                new AssistiveDevice(106360902, "������", "����ѵ��",1060),
                new AssistiveDevice(106360903, "������", "����ѵ��",1061),
                new AssistiveDevice(106360904,"S ��ƽ��ľ","����ѵ��",1062),
                new AssistiveDevice(106360905, "�����", "����ѵ��",1063),
                new AssistiveDevice(106360906, "ƽ��̨", "����ѵ��",1064),
                new AssistiveDevice(106360907, "ԲͲ����", "����ѵ��",1065),
                new AssistiveDevice(106360908, "Բľ�����", "����ѵ��",1066),
                new AssistiveDevice(106360909, "�Ľǻζ�ƽ���", "����ѵ��",1067),
                new AssistiveDevice(106360910,"�ζ�ƽ��ľ","����ѵ��",1068),
                new AssistiveDevice(106360911, "ſ������", "����ѵ��",1069),
                new AssistiveDevice(106360912,"������","����ѵ��",1070),
                new AssistiveDevice(106360913, "����", "����ѵ��",1071),
                new AssistiveDevice(106450301, "��׵ǣ����", "����ѵ��",1072),
                new AssistiveDevice(106450601, "��׵ǣ����", "����ѵ��",1073),
                new AssistiveDevice(106480301, "��ʽ�������г�", "����ѵ��",1074),
                new AssistiveDevice(106480302, "��ʽ�������г�", "����ѵ��",1075),
                new AssistiveDevice(106480701, "���ز���ѵ����", "����ѵ��",1076),
                new AssistiveDevice(106480702, "����ѵ����ƽ�иܺ�����֧��̨", "����ѵ��",1077),
                new AssistiveDevice(106480703, "���н���", "����ѵ��",1078),
                new AssistiveDevice(106480801, "��ͯ��ֱ��ʽվ����", "����ѵ��",1079),
                new AssistiveDevice(106480802, "��ͯ������ʽվ����", "����ѵ��",1080),
                new AssistiveDevice(106480803, "��ͯ�ø���ʽվ����", "����ѵ��",1081),
                new AssistiveDevice(106480804, "������ֱ����վ����", "����ѵ��",1082),
                new AssistiveDevice(106480805, "����������ʽվ����", "����ѵ��",1083),
                new AssistiveDevice(106480806, "�����ø���ʽվ����", "����ѵ��",1084),
                new AssistiveDevice(106481201, "�ش�ʽ��ָ����ѵ����", "����ѵ��",1085),
                new AssistiveDevice(106481202, "��ָ��", "����ѵ��",1086),
                new AssistiveDevice(106481501, "��֫�ۺ�ѵ����", "����ѵ��",1087),
                new AssistiveDevice(106481502, "��֫������", "����ѵ��",1088),
                new AssistiveDevice(106481503,"ѵ����","����ѵ��",1089),
                new AssistiveDevice(106481504, "��֫�յ��˶�ѵ����", "����ѵ��",1090),
                new AssistiveDevice(106481505,"��ؽ���תѵ����","����ѵ��",1091),
                new AssistiveDevice(106481506,"ǰ���������˶���","����ѵ��",1092),
                new AssistiveDevice(106481507, "��ؽ��˶���", "����ѵ��",1093),
                new AssistiveDevice(106481508, "��ؽ��˶���", "����ѵ��",1094),
                new AssistiveDevice(106481509, "��֫�ۺ�ѵ����", "����ѵ��",1095),
                new AssistiveDevice(106481510, "�׹ؽ�ѵ����", "����ѵ��",1096),
                new AssistiveDevice(106481511, "ϥ�ؽ��˶���", "����ѵ��",1097),
                new AssistiveDevice(106481512, "�Źؽ��˶���", "����ѵ��",1098),
                new AssistiveDevice(106481513,"�ۺϲ�̬ѵ����","����ѵ��",1099),
                new AssistiveDevice(106481514, "����ѵ����", "����ѵ��",1100),
                new AssistiveDevice(106481515,"����ȫ���˶�װ��","����ѵ��",1101),
                new AssistiveDevice(106481516, "�����ش��˶���", "����ѵ��",1102),
                new AssistiveDevice(106481517, "�����˶���", "����ѵ��",1103),
                new AssistiveDevice(106481518, "��ľ", "����ѵ��",1104),
                new AssistiveDevice(106481519, "�ݱ���", "����ѵ��",1105),
                new AssistiveDevice(106481520, "ѵ����", "����ѵ��",1106),
                new AssistiveDevice(106481801, "��ʽϵ��ɳ��", "����ѵ��",1107),
                new AssistiveDevice(106482101, "��ҡվ����", "����ѵ��",1108),
                new AssistiveDevice(106482102, "�綯վ����", "����ѵ��",1109),
                new AssistiveDevice(106482401, "ƽ�⹦�ܼ��ѵ��ϵͳ", "����ѵ��",1110),
                new AssistiveDevice(106482402, "������", "����ѵ��",1111),
                new AssistiveDevice(106482701, "�ֶ�����̨", "����ѵ��",1112),
                new AssistiveDevice(106483001, "�ѵ������", "����ѵ��",1113),
                new AssistiveDevice(106483101, "��ͯ���м�", "����ѵ��",1114),
                new AssistiveDevice(107030301, "����ѵ����Ƭ", "����ѵ��",1115),
                new AssistiveDevice(107030302, "�����ϰ�������", "����ѵ��",1116),
                new AssistiveDevice(107030303, "��������ѵ����", "����ѵ��",1117),
                new AssistiveDevice(107030304,"��������ѵ����","����ѵ��",1118),
                new AssistiveDevice(107030601, "�Ķ����ܿ���ѵ������", "����ѵ��",1119),
                new AssistiveDevice(107030901, "ѧǰ�˱���ϰ", "����ѵ��",1120),
                new AssistiveDevice(107030902,"�ֹ����ϰ����ձ��� * ","����ѵ��",1121),
                new AssistiveDevice(107060301, "��ָ��ĸ��", "����ѵ��",1122),
                new AssistiveDevice(107060302, "���й����", "����ѵ��",1123),
                new AssistiveDevice(107060601, "������ѵ����������", "����ѵ��",1124),
                new AssistiveDevice(107060901, "����ͼƬ", "����ѵ��",1125),
                new AssistiveDevice(107061201, "��ʾ����ѵ����������", "����ѵ��",1126),
                new AssistiveDevice(107061501, "����ѧϰ��", "����ѵ��",1127),
                new AssistiveDevice(107061801, "����ѵ���÷��ź�ͼ��", "����ѵ��",1128),
                new AssistiveDevice(107062101, "ͼ��ͷ���ѵ����������", "����ѵ��",1129),
                new AssistiveDevice(107062401,"����˹���Թ�ͨѵ����������","����ѵ��",1130),
                new AssistiveDevice(107062701,"ͼƬ�ͻ滭��ͨѵ����������","����ѵ��",1131),
                new AssistiveDevice(107063001, "Ī��˹���������", "����ѵ��",1132),
                new AssistiveDevice(107063002,"����ʽĪ��˹���������","����ѵ��",1133),
                new AssistiveDevice(107090301, "��ʧ��������", "����ѵ��",1134),
                new AssistiveDevice(107090302, "�ű�ʧ��������", "����ѵ��",1135),
                new AssistiveDevice(107090303, "��С��ʧ��������", "����ѵ��",1136),
                new AssistiveDevice(107120301, "��֪����ѵ������", "����ѵ��",1137),
                new AssistiveDevice(107120302, "������Ϸ��", "����ѵ��",1138),
                new AssistiveDevice(107120601, "˳��ͼƬ", "����ѵ��",1139),
                new AssistiveDevice(107120901, "�𳵻�ľ", "����ѵ��",1140),
                new AssistiveDevice(107120902, "��ͯͼ����֪���", "����ѵ��",1141),
                new AssistiveDevice(107120903, "��������", "����ѵ��",1142),
                new AssistiveDevice(107120904, "���ݶԱȻ�ľ", "����ѵ��",1143),
                new AssistiveDevice(107120905, "̨ʽ��������", "����ѵ��",1144),
                new AssistiveDevice(107120906, "������Ȧ", "����ѵ��",1145),
                new AssistiveDevice(107120907, "��֪ƴװͼƬ", "����ѵ��",1146),
                new AssistiveDevice(107120908, "�ձ����п�", "����ѵ��",1147),
                new AssistiveDevice(107120909, "��״��", "����ѵ��",1148),
                new AssistiveDevice(107120910, "��ľ��", "����ѵ��",1149),
                new AssistiveDevice(107120911, "�����װ�����", "����ѵ��",1150),
                new AssistiveDevice(107120912, "���β��", "����ѵ��",1151),
                new AssistiveDevice(107120913, "�ʺ�����", "����ѵ��",1152),
                new AssistiveDevice(107120914, "˫�����������", "����ѵ��",1153),
                new AssistiveDevice(107120915, "1+1�����", "����ѵ��",1154),
                new AssistiveDevice(107120916, "���������", "����ѵ��",1155),
                new AssistiveDevice(107120917, "�����ҿ����ﲻһ����ɫ��Ƭ��", "����ѵ��",1156),
                new AssistiveDevice(107121201, "�����״��", "����ѵ��",1157),
                new AssistiveDevice(107121501, "��״����ɫ���࿨Ƭ", "����ѵ��",1158),
                new AssistiveDevice(107121801, "��������ľ", "����ѵ��",1159),
                new AssistiveDevice(107121802, "����������ͼƬ", "����ѵ��",1160),
                new AssistiveDevice(107122101, "����", "����ѵ��",1161),
                new AssistiveDevice(107122102, "����ͼƬ��", "����ѵ��",1162),
                new AssistiveDevice(107122401, "�����ϵͼ��", "����ѵ��",1163),
                new AssistiveDevice(107150301,"ѧϰ��ѧƴͼ�桢����ѧ�����г���Ϸ�����","����ѵ��",1164),
                new AssistiveDevice(107150601, "ľ�ƴ�������ĸ��", "����ѵ��",1165),
                new AssistiveDevice(107150901, "��ľʱ��ƴͼ��", "����ѵ��",1166),
                new AssistiveDevice(107150902,"ʱ�似��ѵ������","����ѵ��",1167),
                new AssistiveDevice(107151201, "Ǯ��ֽ�����", "����ѵ��",1168),
                new AssistiveDevice(107151501, "ä�õ��ֳ߼����������", "����ѵ��",1169),
                new AssistiveDevice(107151801, "����ͼ����Կ�Ƭ", "����ѵ��",1170),
                new AssistiveDevice(107180301,"���к���ƴ���ͺ��ֵ�����Сͼ��","����ѵ��",1171),
                new AssistiveDevice(107180601, "��ĸ��ͼ��", "����ѵ��",1172),
                new AssistiveDevice(107180901, "�����Ľ������顷", "����ѵ��",1173),
                new AssistiveDevice(107181201,"����ѧ�γ�ѵ����������","����ѵ��",1174),
                new AssistiveDevice(107181501, "����ѧ���ɡ���Сѧ���꼶��", "����ѵ��",1175),
                new AssistiveDevice(107240301, "�о������������", "����ѵ��",1176),
                new AssistiveDevice(107240601, "����ͯѧ����ȫ��", "����ѵ��",1177),
                new AssistiveDevice(107240901, "Ϸ����赸ѵ����������", "����ѵ��",1178),
                new AssistiveDevice(107270301, "��ʽ����ѵ���̾�", "����ѵ��",1179),
                new AssistiveDevice(107270601, "�����Ϊѵ����������", "����ѵ��",1180),
                new AssistiveDevice(107270901, "���˰�ȫѵ����������", "����ѵ��",1181),
                new AssistiveDevice(107271201, "�л����񹲺͹�������ͼ", "����ѵ��",1182),
                new AssistiveDevice(107300301, "�����ϰ������ѵ����", "����ѵ��",1183),
                new AssistiveDevice(107300601, "���ݸ���Ϸ���", "����ѵ��",1184),
                new AssistiveDevice(107300901, "ѵ�����ƿ��ص����", "����ѵ��",1185),
                new AssistiveDevice(107301201,"�Ӿ��ϰ��ߺ������ϰ��ߴ���ѵ������","����ѵ��",1186),
                new AssistiveDevice(107301202,"֫���ϰ�����ָ����ָ������","����ѵ��",1187),
                new AssistiveDevice(107301501, "��ͼѡ��ѵ�����", "����ѵ��",1188),
                new AssistiveDevice(107330301,"�������ͼ�֫ʹ��ѵ����������","����ѵ��",1189),
                new AssistiveDevice(107330601, "�����Ӽ�", "����ѵ��",1190),
                new AssistiveDevice(107330602, "����Ь����", "����ѵ��",1191),
                new AssistiveDevice(107330603,"����ˢ����","����ѵ��",1192),
                new AssistiveDevice(107330604, "ѵ��šʪë����", "����ѵ��",1193),
                new AssistiveDevice(107331201, "�����þ�ʹ��ѵ������", "����ѵ��",1201),
                new AssistiveDevice(107331202,"��ʳ�þ�ʹ��ѵ������","����ѵ��",1202),
                new AssistiveDevice(107331203,"��ɨ�þ�ʹ��ѵ������","����ѵ��",1203),
                new AssistiveDevice(107331204, "��ͥ����ʹ��ѵ������", "����ѵ��",1204),
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

                new AssistiveDevice(106030301,"Ԥ����������װ��","��������",987),
                new AssistiveDevice(106030601,"��������","��������",988),
                new AssistiveDevice(106030602,"��ҩ��������","��������",989),
                new AssistiveDevice(106030603,"һ������������","��������",990),
                new AssistiveDevice(106031201,"���̺�����","��������",991),
                new AssistiveDevice(106031801,"��������ƿ","��������",992),
                new AssistiveDevice(106031802,"��Яʽ������","��������",993),
                new AssistiveDevice(106031803,"��������","��������",994),
                new AssistiveDevice(106032101,"�綯��̵��","��������",995),
                new AssistiveDevice(106032102,"�ֶ���̵��","��������",996),
                new AssistiveDevice(106032103,"��̤��̵��","��������",997),
                new AssistiveDevice(106032701,"�ֳ�ʽ������ѵ����","��������",998),
                new AssistiveDevice(106032702,"��������ѵ����","��������",999),
                new AssistiveDevice(106032703,"��������ѵ����","��������",1000),
                new AssistiveDevice(106032704,"�շ�����ѵ����","��������",1001),
                new AssistiveDevice(106033001,"�λ������Ӳ�����","��������",1002),
                new AssistiveDevice(106060601,"��ˮ������","��������",1003),
                new AssistiveDevice(106060901,"����ѹ����","��������",1004),
                new AssistiveDevice(106070301,"��ճ�Թ轺Ƭ","��������",1005),
                new AssistiveDevice(106070601,"������","��������",1006),
                new AssistiveDevice(106080301,"С�Ⱦ���������","��������",1007),
                new AssistiveDevice(106080302,"���Ⱦ���������","��������",1008),
                new AssistiveDevice(106090301,"������A �ε�315nm��","��������",1009),
                new AssistiveDevice(106090302,"������A �ε�340nm","��������",1010),
                new AssistiveDevice(106090303, "������A �ε�365nm", "��������",1011),
                new AssistiveDevice(106090304,"������A �ε�385nm","��������",1012),
                new AssistiveDevice(106090305,"������A �ε�400nm","��������",1013),
                new AssistiveDevice(106090601, "������B �ε�280nm", "��������",1014),
                new AssistiveDevice(106090901, "UV ��Ŀ��", "��������",1015),
                new AssistiveDevice(106240901, "��������Ѫѹ��", "��������",1016),
                new AssistiveDevice(106241201, "Ѫ����", "��������",1017),
                new AssistiveDevice(106241801, "�ּ���������", "��������",1018),
                new AssistiveDevice(106242101,"����������������ԵĲ�����������","��������",1019),
                new AssistiveDevice(106242401, "�������¼�", "��������",1020),
                new AssistiveDevice(106242701, "�������س�", "��������",1021),
                new AssistiveDevice(106243001, "����Ƥ��״���ĸ�������", "��������",1022),
                new AssistiveDevice(106250301,"ʧ��֢���������������ϵͳ��� * ","��������",1023),
                new AssistiveDevice(106250601, "����ҽѧ�������ϵͳ���", "��������",1024),
                new AssistiveDevice(106250901, "Τ����������", "��������",1025),
                new AssistiveDevice(106270601, "�����͵�Ƶ�̼��ǣ���ʹ��", "��������",1026),
                new AssistiveDevice(106270901, "����̼���", "��������",1027),
                new AssistiveDevice(106271201, "����̵��", "��������",1028),
                new AssistiveDevice(106271501, "�����̼���", "��������",1029),
                new AssistiveDevice(106271801,"�̼��о��������ȵĸ�������","��������",1030),
                new AssistiveDevice(106272101, "�̼�ϸ�������ĸ�������", "��������",1031),
                new AssistiveDevice(106300301, "�����ߵ�", "��������",1032),
                new AssistiveDevice(106300601, "������̼����������", "��������",1033),
                new AssistiveDevice(106300602, "����", "��������",1034),
                new AssistiveDevice(106330301, "��ͨ�����ѹ������", "��������",1035),
                new AssistiveDevice(106330302, "���ص������ѹ������", "��������",1036),
                new AssistiveDevice(106330303, "Һ��������ѹ������", "��������",1037),
                new AssistiveDevice(106330304, "����������ѹ������", "��������",1038),
                new AssistiveDevice(106330305, "���ϳ�����ѹ������", "��������",1039),
                new AssistiveDevice(106330306, "�𽺳�����ѹ������", "��������",1040),
                new AssistiveDevice(106330307, "�������ิ�Ϸ�ѹ������", "��������",1041),
                new AssistiveDevice(106330308, "�����ҷ�ѹ������", "��������",1042),
                new AssistiveDevice(106330401, "��λ�任��ϵ�", "��������",1043),
                new AssistiveDevice(106330402, "Ш�ε�", "��������",1044),
                new AssistiveDevice(106330601, "�ֶ�PVC������ѹ������", "��������",1045),
                new AssistiveDevice(106330602, "�綯PVC������ѹ������", "��������",1046),
                new AssistiveDevice(106330603, "���亣���ѹ������", "��������",1047),
                new AssistiveDevice(106330604, "�ֶ��𽺳�����ѹ������", "��������",1048),
                new AssistiveDevice(106330605, "�綯�𽺳�����ѹ������", "��������",1049),
                new AssistiveDevice(106330606, "�������ิ�Ϸ�ѹ������", "��������",1050),
                new AssistiveDevice(106330901, "ѹ����������", "��������",1051),
                new AssistiveDevice(106330902, "���촯��������", "��������",1052),
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

                new AssistiveDevice(104200101,"�ŵĸ���","���ϰ�����",777),
                new AssistiveDevice(104200102,"���������","���ϰ�����",778),
                new AssistiveDevice(104331501,"����ä��ש","���ϰ�����",795),
                new AssistiveDevice(104331502,"ת�Ƿ�����","���ϰ�����",796),
                new AssistiveDevice(104331503,"ǽ�ڷ�����","���ϰ�����",797),
                new AssistiveDevice(109030901, "����������", "���ϰ�����",1252),
                new AssistiveDevice(109030902, "�������հ�", "���ϰ�����",1253),
                new AssistiveDevice(109030903, "������", "���ϰ�����",1254),
                new AssistiveDevice(109031201, "������", "���ϰ�����",1255),
                new AssistiveDevice(109031202, "�����", "���ϰ�����",1256),
                new AssistiveDevice(109031501, "�������Ƹ�������", "���ϰ�����",1257),
                new AssistiveDevice(109031801, "ˮ������", "���ϰ�����",1258),
                new AssistiveDevice(109031802, "ˮ����", "���ϰ�����",1259),
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

                new AssistiveDevice(108060301,"��ƿ��","������ʹ��",1205),
                new AssistiveDevice(108060601,"�Զ����༷ѹ��","������ʹ��",1206),
                new AssistiveDevice(108090301,"��ťʽˮ��ͷ","������ʹ��",1207),
                new AssistiveDevice(108090601,"���Ϲ̶�����","������ʹ��",1208),
                new AssistiveDevice(108090602,"���������ֱ�","������ʹ��",1209),
                new AssistiveDevice(108090901,"L���Ű���","������ʹ��",1210),
                new AssistiveDevice(108090902,"���ܰ���","������ʹ��",1211),
                new AssistiveDevice(108091201,"�������г���̤��","������ʹ��",1212),
                new AssistiveDevice(108091202,"��̤����","������ʹ��",1213),
                new AssistiveDevice(108091501,"���ֺ���������","������ʹ��",1214),
                new AssistiveDevice(108091801,"������ʱ����","������ʹ��",1215),
                new AssistiveDevice(108091802,"�ۿؿ���","������ʹ��",1216),
                new AssistiveDevice(108092401,"�����","������ʹ��",1217),
                new AssistiveDevice(108092801,"�ɵ���Դ","������ʹ��",1218),
                new AssistiveDevice(108093001,"�����Ѷ�ʱ��","������ʹ��",1219),
                new AssistiveDevice(108130301,"�źž�ʾϵͳ","������ʹ��",1220),
                new AssistiveDevice(108130302,"��������װ��","������ʹ��",1221),
                new AssistiveDevice(108130601,"��������װ�ó���","������ʹ��",1222),
                new AssistiveDevice(108180301,"�������","������ʹ��",1223),
                new AssistiveDevice(108180601,"ִ�ʸ�����","������ʹ��",1224),
                new AssistiveDevice(108180602,"���ճ���","������ʹ��",1225),
                new AssistiveDevice(108180901,"�绰��Ͳץ����","������ʹ��",1226),
                new AssistiveDevice(108181201,"�����ȶ���","������ʹ��",1227),
                new AssistiveDevice(108181202,"ä���ú�װ��ͷ��","������ʹ��",1228),
                new AssistiveDevice(108181203,"�������","������ʹ��",1229),
                new AssistiveDevice(108181204,"����ʽ����","������ʹ��",1230),
                new AssistiveDevice(108181501,"ͷ�����Ƹ�","������ʹ��",1231),
                new AssistiveDevice(108181502,"�ں���","������ʹ��",1232),
                new AssistiveDevice(108181801,"ͷ��ָ���","������ʹ��",1233),
                new AssistiveDevice(108182101,"��ֽ��","������ʹ��",1234),
                new AssistiveDevice(108182401,"�ĸ�̶���","������ʹ��",1235),
                new AssistiveDevice(108182701,"ǰ��֧�ż�","������ʹ��",1236),
                new AssistiveDevice(108182801,"�����ɼ���","������ʹ��",1237),
                new AssistiveDevice(108210301,"�۵�ʽ����ȡ����","������ʹ��",1238),
                new AssistiveDevice(108210302,"���۵�ʽ����ȡ����","������ʹ��",1239),
                new AssistiveDevice(108210901,"��ץ�չ��ܵ�������","������ʹ��",1240),
                new AssistiveDevice(108240301,"�̶�λ��ϵͳ","������ʹ��",1241),
                new AssistiveDevice(108240601,"ת���ͻ���ϵͳ","������ʹ��",1242),
                new AssistiveDevice(108240901,"��������бϵͳ","������ʹ��",1243),
                new AssistiveDevice(108270301,"����","������ʹ��",1244),
                new AssistiveDevice(108270601,"������","������ʹ��",1245),
                new AssistiveDevice(108271201,"���Ӻ͵��ɼ�","������ʹ��",1246),
                new AssistiveDevice(108271801,"������","������ʹ��",1247),
                new AssistiveDevice(108360301,"���˸�������","������ʹ��",1248),
                new AssistiveDevice(108360601,"����װ��","������ʹ��",1249),
                new AssistiveDevice(108360901,"����͹����Ƴ�","������ʹ��",1250),
                new AssistiveDevice(108361501,"���γ�����","������ʹ��",1251),
                new AssistiveDevice(111030301,"������","������ʹ��",1312),
                new AssistiveDevice(111030601,"��ҵ̨","������ʹ��",1313),
                new AssistiveDevice(111031201,"����","������ʹ��",1314),
                new AssistiveDevice(111031202,"վ����","������ʹ��",1315),
                new AssistiveDevice(111031801,"���������õ���","������ʹ��",1316),
                new AssistiveDevice(111120301,"�ֳ�ʽ����","������ʹ��",1317),
                new AssistiveDevice(111120302,"ץ��ʽ����","������ʹ��",1318),
                new AssistiveDevice(111120601,"���ɼ�","������ʹ��",1319),
                new AssistiveDevice(111120602,"����̨�÷�����","������ʹ��",1320),
                new AssistiveDevice(111120603,"�����ӵ���ת��","������ʹ��",1321),
                new AssistiveDevice(111240301, "��ȫѥ", "������ʹ��",1322),
                new AssistiveDevice(111240302, "����������", "������ʹ��",1323),
                new AssistiveDevice(111241801, "�����ذ�", "������ʹ��",1324),
                new AssistiveDevice(111241802, "��·��ʶ", "������ʹ��",1325),
                new AssistiveDevice(112030301, "��ѧ�������������", "������ʹ��",1326),
                new AssistiveDevice(112030302, "���������", "������ʹ��",1327),
                new AssistiveDevice(112030303, "������������", "������ʹ��",1328),
                new AssistiveDevice(112030304, "��ͨ�����", "������ʹ��",1329),
                new AssistiveDevice(112030901, "����", "������ʹ��",1330),
                new AssistiveDevice(112090301, "��������", "������ʹ��",1331),
                new AssistiveDevice(112090302, "ä������", "������ʹ��",1332),
                new AssistiveDevice(112090303, "��ʽ����", "������ʹ��",1333),
                new AssistiveDevice(112090304, "����ƹ����", "������ʹ��",1334),
                new AssistiveDevice(112090601, "������������", "������ʹ��",1335),
                new AssistiveDevice(112090901, "������������", "������ʹ��",1336),
                new AssistiveDevice(112091201, "������������", "������ʹ��",1337),
                new AssistiveDevice(112091801, "������������", "������ʹ��",1338),
                new AssistiveDevice(112092701, "������", "������ʹ��",1339),
                new AssistiveDevice(112092702, "ƹ������", "������ʹ��",1340),
                new AssistiveDevice(112092703, "��ë����", "������ʹ��",1341),
                new AssistiveDevice(112093001, "�����������", "������ʹ��",1342),
                new AssistiveDevice(112093301, "��Ӿ��ˮ���˶���������", "������ʹ��",1343),
                new AssistiveDevice(112093601, "�����˶���������", "������ʹ��",1344),
                new AssistiveDevice(112093901, "�����˶���������", "������ʹ��",1345),
                new AssistiveDevice(112180301, "������", "������ʹ��",1346),
                new AssistiveDevice(112180302, "������", "������ʹ��",1347),
                new AssistiveDevice(112180303, "���", "������ʹ��",1348),
                new AssistiveDevice(112180304,"�����֯ģ��","������ʹ��",1349),
                new AssistiveDevice(112180601,"���չ��չ��ߡ����Ϻ��豸","������ʹ��",1350),
                new AssistiveDevice(112180901,"ľ�����չ��ߡ����Ϻ��豸","������ʹ��",1351),
                new AssistiveDevice(112181201,"�����ӹ����ߡ����Ϻ��豸","������ʹ��",1352),
                new AssistiveDevice(112181501, "����", "������ʹ��",1353),
                new AssistiveDevice(112181502, "����", "������ʹ��",1354),
                new AssistiveDevice(112181503, "����", "������ʹ��",1355),
                new AssistiveDevice(112181504, "��ɫ��", "������ʹ��",1356),
                new AssistiveDevice(112181505,"��ɫ��","������ʹ��",1357),
                new AssistiveDevice(112181506, "��ϴ", "������ʹ��",1358),
                new AssistiveDevice(112181507, "��ֽ", "������ʹ��",1359),
                new AssistiveDevice(112181801,"�������ϵ��ֹ����յĹ��ߡ����Ϻ��豸","������ʹ��",1360),
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

                new AssistiveDevice(102360301,"�������ʽ��λ��","λ��ת��",498),
                new AssistiveDevice(102360302,"������װ�õĵ���ʽ��λ��","λ��ת��",499),
                new AssistiveDevice(102360303, "վ��ʽ��λ��", "λ��ת��",500),
                new AssistiveDevice(102360601, "��Ӳ������λ��", "λ��ת��",501),
                new AssistiveDevice(102361201, "����ʽ��λ��", "λ��ת��",502),
                new AssistiveDevice(102361501, "ԡ����λ��", "λ��ת��",503),
                new AssistiveDevice(102361502, "ˮ������װ��", "λ��ת��",504),
                new AssistiveDevice(102361801, "��ֱƽ̨", "λ��ת��",505),
                new AssistiveDevice(102362101, "����", "λ��ת��",506),
                new AssistiveDevice(102362102, "����", "λ��ת��",507),
                new AssistiveDevice(104300501, "��������̨", "λ��ת��",779),
                new AssistiveDevice(104300502, "�̶�ʽ����̨", "λ��ת��",780),
                new AssistiveDevice(104300503,"ƽ̨������","λ��ת��",781),
                new AssistiveDevice(104300504, "б��ʽ��������ƽ̨", "λ��ת��",782),
                new AssistiveDevice(104300505,"��ֱʽ��������ƽ̨","λ��ת��",783),
                new AssistiveDevice(104300801, "��Яʽ����������", "λ��ת��",784),
                new AssistiveDevice(104301001, "����ʽ¥�ݻ�", "λ��ת��",785),
                new AssistiveDevice(104301101, "������¥��������", "λ��ת��",786),
                new AssistiveDevice(104301102, "�����ù���", "λ��ת��",787),
                new AssistiveDevice(104301501, "�ɲ�װ�ļ����µ�", "λ��ת��",788),
                new AssistiveDevice(104301502, "��Яʽб�°�", "λ��ת��",789),
                new AssistiveDevice(104301503, "ģ��ʽ����µ�", "λ��ת��",790),
                new AssistiveDevice(104301801, "��ͨ�̶��µ���", "λ��ת��",791),
                new AssistiveDevice(104301802,"��ȫ��̨","λ��ת��",792),
                new AssistiveDevice(104301803, "���λ���ش�", "λ��ת��",793),
                new AssistiveDevice(104301901, "���ò���", "λ��ת��",794),
                new AssistiveDevice(107330901, "���������", "λ��ת��",1194),
                new AssistiveDevice(107330902, "�����Ƴ˴�", "λ��ת��",1195),
                new AssistiveDevice(107330903, "˫���Ƴ˴�", "λ��ת��",1196),
                new AssistiveDevice(107330904, "��������", "λ��ת��",1197),
                new AssistiveDevice(107330905, "������", "λ��ת��",1198),
                new AssistiveDevice(107330906, "�Ƴ˰�", "λ��ת��",1199),
                new AssistiveDevice(107330907, "��������", "λ��ת��",1200),
                #endregion
                
                #region ��������
                new AssistiveDevice(10409,"��ʽ�Ҿ�","��������"),

                new AssistiveDevice(1040921,"��������","��������"),

                new AssistiveDevice(104092101,"��ͯ������","��������",747),
                new AssistiveDevice(104092102,"��ͯ���ƽ�����","��������",748),
                new AssistiveDevice(104092103,"��ͯ�ݱ�ѵ����","��������",749),
                new AssistiveDevice(104092104,"��ͯ��ȫ��","��������",750),
                new AssistiveDevice(104092105,"��ͯ����ҡ��","��������",751),
                new AssistiveDevice(104092106,"��ͯ���Ϳɵ�����","��������",752),
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

                new AssistiveDevice(101180301,"�ƹǽ�֫��֫","��֫",208),
                new AssistiveDevice(101180302,"�ƹǽ�֫������","��֫",209),
                new AssistiveDevice(101180303,"װ���Բ����ּ�֫","��֫",210),
                new AssistiveDevice(101180304,"װ���Լ���ָ","��֫",211),
                new AssistiveDevice(101180601,"����������ϼ�֫","��֫",212),
                new AssistiveDevice(101180602,"�����ɶȼ���������ϼ�֫","��֫",213),
                new AssistiveDevice(101180603, "����������ϼ�֫", "��֫",214),
                new AssistiveDevice(101180604, "װ��������ϼ�֫", "��֫",215),
                new AssistiveDevice(101180901, "������ǰ�ۼ�֫", "��֫",216),
                new AssistiveDevice(101180902, "�����ɶȼ�����ǰ�ۼ�֫", "��֫",217),
                new AssistiveDevice(101180903, "˫���ɶȼ�����ǰ�ۼ�֫", "��֫",218),
                new AssistiveDevice(101180904, "������ǰ�ۼ�֫", "��֫",219),
                new AssistiveDevice(101180905, "װ����ǰ�ۼ�֫", "��֫",220),
                new AssistiveDevice(101181201, "����������ϼ�֫", "��֫",221),
                new AssistiveDevice(101181202,"�����ɶȼ���������ϼ�֫","��֫",222),
                new AssistiveDevice(101181203, "˫���ɶȼ���������ϼ�֫", "��֫",223),
                new AssistiveDevice(101181204,"����������ϼ�֫","��֫",224),
                new AssistiveDevice(101181205, "װ��������ϼ�֫", "��֫",225),
                new AssistiveDevice(101181501, "�������ϱۼ�֫", "��֫",226),
                new AssistiveDevice(101181502, "�����ɶȼ������ϱۼ�֫", "��֫",227),
                new AssistiveDevice(101181503, "˫���ɶȼ������ϱۼ�֫", "��֫",228),
                new AssistiveDevice(101181504,"˫���ɶȻ��ʽ�綯���ϱۼ�֫","��֫",229),
                new AssistiveDevice(101181505, "�����ɶȼ������ϱۼ�֫", "��֫",230),
                new AssistiveDevice(101181506,"�������ϱۼ�֫","��֫",231),
                new AssistiveDevice(101181507, "װ�����ϱۼ�֫", "��֫",232),
                new AssistiveDevice(101181801, "�����ּ���ϼ�֫", "��֫",233),
                new AssistiveDevice(101181802,"˫���ɶȼ����ּ���ϼ�֫","��֫",234),
                new AssistiveDevice(101181803, "װ���Լ���ϼ�֫", "��֫",235),
                new AssistiveDevice(101182101, "װ���Լ���������֫", "��֫",236),
                new AssistiveDevice(101182401, "��ʽ������", "��֫",237),
                new AssistiveDevice(101182402, "�Ǽ�ʽ������", "��֫",238),
                new AssistiveDevice(101182403, "�����ɶȼ�����", "��֫",239),
                new AssistiveDevice(101182404, "˫���ɶȼ�����", "��֫",240),
                new AssistiveDevice(101182405, "װ����", "��֫",241),
                new AssistiveDevice(101182406, "�ƹǽ�֫������", "��֫",242),
                new AssistiveDevice(101182501, "�����͹�״��", "��֫",243),
                new AssistiveDevice(101182502, "�๳�͹�״��", "��֫",244),
                new AssistiveDevice(101182601, "�Ͷ��ù�״������", "��֫",245),
                new AssistiveDevice(101182602, "�Ͷ��üгֹ�����", "��֫",246),
                new AssistiveDevice(101182603,"ר�ù���","��֫",247),
                new AssistiveDevice(101183001, "Ħ��ʽ������ؽ�", "��֫",248),
                new AssistiveDevice(101183002, "����ʽ��ؽ�", "��֫",249),
                new AssistiveDevice(101183003,"��װ��ͷʽ��ؽ�","��֫",250),
                new AssistiveDevice(101183004, "������������", "��֫",251),
                new AssistiveDevice(101183301, "����������ؽڽ���", "��֫",252),
                new AssistiveDevice(101183302, "˫��������ؽڽ���", "��֫",253),
                new AssistiveDevice(101183303, "����ʽ��ؽڽ���", "��֫",254),
                new AssistiveDevice(101183304, "������ؽڽ���", "��֫",255),
                new AssistiveDevice(101183305,"�綯��ؽ�","��֫",256),
                new AssistiveDevice(101183601, "����ʽ��ؽ�", "��֫",257),
                new AssistiveDevice(101183602, "��չʽ��ؽ�", "��֫",258),
                new AssistiveDevice(101183603, "�����ؽ�", "��֫",259),
                new AssistiveDevice(101184001, "�Ź���תװ��", "��֫",260),
                new AssistiveDevice(101184101, "���˽ṹ����ʽ�����", "��֫",261),
                new AssistiveDevice(101184102,"�ĸ˽ṹ����ʽ�����","��֫",262),
                new AssistiveDevice(101240301, "Ƥ��ʽ����ֺ", "��֫",263),
                new AssistiveDevice(101240302, "�轺��ʽ����ֺ", "��֫",264),
                new AssistiveDevice(101240303,"�轺����ʽ�ٰ���","��֫",265),
                new AssistiveDevice(101240304, "��֬����С��ʽ�ٰ���", "��֫",266),
                new AssistiveDevice(101240601, "Ƥ����ķ��֫", "��֫",267),
                new AssistiveDevice(101240602, "��֬������ķ��֫", "��֫",268),
                new AssistiveDevice(101240901, "��ʽС�ȼ�֫", "��֫",269),
                new AssistiveDevice(101240902, "���ʽ�����С�ȼ�֫", "��֫",270),
                new AssistiveDevice(101240903,"���ʽSACH ��С�ȼ�֫","��֫",271),
                new AssistiveDevice(101240904,"���ʽ�����׵����С�ȼ�֫","��֫",272),
                new AssistiveDevice(101240905, "���ʽ���ܽ�С�ȼ�֫", "��֫",273),
                new AssistiveDevice(101241201, "��������ϥ��ϼ�֫", "��֫",274),
                new AssistiveDevice(101241202,"���Ͻ����ϥ��ϼ�֫","��֫",275),
                new AssistiveDevice(101241203, "�ѺϽ����ϥ��ϼ�֫", "��֫",276),
                new AssistiveDevice(101241204,"��ѹ����ϥ��ϼ�֫","��֫",277),
                new AssistiveDevice(101241205, "Һѹ����ϥ��ϼ�֫", "��֫",278),
                new AssistiveDevice(101241206,"���ܿ���ϥ��ϼ�֫","��֫",279),
                new AssistiveDevice(101241501, "�����������ȼ�֫", "��֫",280),
                new AssistiveDevice(101241502, "���Ͻ�������ȼ�֫", "��֫",281),
                new AssistiveDevice(101241503, "�ѺϽ�������ȼ�֫", "��֫",282),
                new AssistiveDevice(101241504, "��ѹ���ƴ��ȼ�֫", "��֫",283),
                new AssistiveDevice(101241505,"Һѹ���ƴ��ȼ�֫","��֫",284),
                new AssistiveDevice(101241506, "���ܿ��ƴ��ȼ�֫", "��֫",285),
                new AssistiveDevice(101241801, "������������ϼ�֫", "��֫",286),
                new AssistiveDevice(101241802,"���Ͻ��������ϼ�֫","��֫",287),
                new AssistiveDevice(101241803, "�ѺϽ��������ϼ�֫", "��֫",288),
                new AssistiveDevice(101241804,"��ѹ��������ϼ�֫","��֫",289),
                new AssistiveDevice(101241805, "Һѹ��������ϼ�֫", "��֫",290),
                new AssistiveDevice(101242101, "������г���֫", "��֫",291),
                new AssistiveDevice(101242102, "���ư�����г���֫", "��֫",292),
                new AssistiveDevice(101242401, "��׮�����֫", "��֫",293),
                new AssistiveDevice(101242402, "���ư����֫", "��֫",294),
                new AssistiveDevice(101242701, "�����", "��֫",295),
                new AssistiveDevice(101242702, "������׽�", "��֫",296),
                new AssistiveDevice(101242703, "���׽�", "��֫",297),
                new AssistiveDevice(101242704, "�����", "��֫",298),
                new AssistiveDevice(101242705,"���ܽ�","��֫",299),
                new AssistiveDevice(101242706, "��׶����", "��֫",300),
                new AssistiveDevice(101242707, "���ᶯ��", "��֫",301),
                new AssistiveDevice(101242708, "������", "��֫",302),
                new AssistiveDevice(101243001, "����Ť�ػ�����", "��֫",303),
                new AssistiveDevice(101243002, "��Ť�ػ�����", "��֫",304),
                new AssistiveDevice(101243101, "ϥ��չ������", "��֫",305),
                new AssistiveDevice(101243102, "��ǰ������", "��֫",306),
                new AssistiveDevice(101243103, "��󻺳���", "��֫",307),
                new AssistiveDevice(101243301, "����ϥ�ؽ�", "��֫",308),
                new AssistiveDevice(101243302, "��������ϥ�ؽ�", "��֫",309),
                new AssistiveDevice(101243303,"�ֶ�������ϥ�ؽ�","��֫",310),
                new AssistiveDevice(101243304, "������ϥ�ؽ�", "��֫",311),
                new AssistiveDevice(101243305, "��ѹϥ�ؽ�", "��֫",312),
                new AssistiveDevice(101243306,"Һѹϥ�ؽ�","��֫",313),
                new AssistiveDevice(101243307, "����ϥ�ؽ�", "��֫",314),
                new AssistiveDevice(101243308, "������ϥ���ϥ�ؽ�", "��֫",315),
                new AssistiveDevice(101243309,"��ѹϥ���ϥ�ؽ�","��֫",316),
                new AssistiveDevice(101243310, "Һѹϥ���ϥ�ؽ�", "��֫",317),
                new AssistiveDevice(101243601, "ǰ��ʽ�����Źؽ�", "��֫",318),
                new AssistiveDevice(101243602, "����ʽ�����Źؽ�", "��֫",319),
                new AssistiveDevice(101243603,"�������Źؽ�","��֫",320),
                new AssistiveDevice(101244001, "����ǻ�ڳ���", "��֫",321),
                new AssistiveDevice(101244002, "����������֫��", "��֫",322),
                new AssistiveDevice(101244003,"����������֫��","��֫",323),
                new AssistiveDevice(101244004, "�����轺��֫��", "��֫",324),
                new AssistiveDevice(101244005, "�����轺��֫��", "��֫",325),
                new AssistiveDevice(101244101, "Ԥ�ƽ���ǻ", "��֫",326),
                new AssistiveDevice(101244501, "С�ȼ�֫װ�����������", "��֫",327),
                new AssistiveDevice(101244502,"��ʱ����ǻ�ɵ����Ӽ�","��֫",328),
                new AssistiveDevice(101244503, "�ɵ�������", "��֫",329),
                new AssistiveDevice(101244504, "��צ������", "��֫",330),
                new AssistiveDevice(101244505, "��צ������", "��֫",331),
                new AssistiveDevice(101244506, "�����ܽ�ͷ", "��֫",332),
                new AssistiveDevice(101244507, "˫���ͷ", "��֫",333),
                new AssistiveDevice(101244801, "ʯ�����ǻ��ʱ��֫", "��֫",334),
                new AssistiveDevice(101244802,"���ý���ǻ���ڼܵ���ʱ��֫","��֫",335),
                new AssistiveDevice(101244803, "��֬����ǻ��ʱ��֫", "��֫",336),
                new AssistiveDevice(101244804, "��׮��ʱ��֫", "��֫",337),
                new AssistiveDevice(101300301, "�ٷ�", "��֫",338),
                new AssistiveDevice(101301801, "����ʽ���鷿", "��֫",339),
                new AssistiveDevice(101301802, "������鷿", "��֫",340),
                new AssistiveDevice(101302101, "����Ӳ�Լ���", "��֫",341),
                new AssistiveDevice(101302102, "����Ӳ�Լ���", "��֫",342),
                new AssistiveDevice(101302103, "���Լ���", "��֫",343),
                new AssistiveDevice(101302104,"�������","��֫",344),
                new AssistiveDevice(101302105, "���ƻ����", "��֫",345),
                new AssistiveDevice(101302401, "�轺�ٶ�", "��֫",346),
                new AssistiveDevice(101302701, "�轺�ٱ�", "��֫",347),
                new AssistiveDevice(101303001, "�沿�ϳɼ���", "��֫",348),
                new AssistiveDevice(101303301, "����", "��֫",349),
                new AssistiveDevice(101303601, "������", "��֫",350),
                new AssistiveDevice(101303602, "ȫ����", "��֫",351),
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

                new AssistiveDevice(101030301,"��ģ�������Ľ�����","������",1),
                new AssistiveDevice(101030302,"���Ĵ�","������",2),
                new AssistiveDevice(101030303,"��ת�Ӵ�","������",3),
                new AssistiveDevice(101030401,"������Χ","������",4),
                new AssistiveDevice(101030402,"��ǿ�͵�����Χ","������",5),
                new AssistiveDevice(101030403,"����֧��ʽ������Χ","������",6),
                new AssistiveDevice(101030404,"Ӳ��ʽ��Χ","������",7),
                new AssistiveDevice(101030405,"Ƥ��Χ","������",8),
                new AssistiveDevice(101030406,"������Χ","������",9),
                new AssistiveDevice(101030407,"��������Χ","������",10),
                new AssistiveDevice(101030408,"Ӳ����Χ","������",11),
                new AssistiveDevice(101030601,"��ģ��������������","������",12),
                new AssistiveDevice(101030602,"������������չ���ƽ�������","������",13),
                new AssistiveDevice(101030603,"��׵ǣ����","������",14),
                new AssistiveDevice(101030604,"������׵ǣ����","������",15),
                new AssistiveDevice(101030701,"�ز�������","������",16),
                new AssistiveDevice(101030801,"����֧����������Χ��","������",17),
                new AssistiveDevice(101030802,"���÷�����������Χ��","������",18),
                new AssistiveDevice(101030803,"����֧��Ƥ�����Χ��","������",19),
                new AssistiveDevice(101030804,"������ʽ����Χ��","������",20),
                new AssistiveDevice(101030805,"���˽��δ�","������",21),
                new AssistiveDevice(101030901,"̩����������������","������",22),
                new AssistiveDevice(101030902,"����-̩����������������","������",23),
                new AssistiveDevice(101030903,"�������������","������",24),
                new AssistiveDevice(101030904,"֧���̶�ʽ������������","������",25),
                new AssistiveDevice(101030905,"ģ�ܼп�ʽ������������","������",26),
                new AssistiveDevice(101030906,"�ɵ��п�ʽ������������","������",27),
                new AssistiveDevice(101030907,"���ر��пɵ��п�ʽ������������","������",28),
                new AssistiveDevice(101030908,"������Χ��ʽ������������","������",29),
                new AssistiveDevice(101031201,"Χ��ʽ����","������",30),
                new AssistiveDevice(101031202,"�ѳǾ���","������",31),
                new AssistiveDevice(101031203,"ģ�ܳ��͹̶�ʽ����","������",32),
                new AssistiveDevice(101031204,"�߶ȿɵ�ʽ����","������",33),
                new AssistiveDevice(101031205,"����ʽ����","������",34),
                new AssistiveDevice(101031206,"��Ƭ���ʽ����","������",35),
                new AssistiveDevice(101031207,"��׵ǣ����","������",36),
                new AssistiveDevice(101031501,"�����;��ؽ�����","������",37),
                new AssistiveDevice(101031502,"֧�˼�ǿ�;��ؽ�����","������",38),
                new AssistiveDevice(101031503,"ͷ��ʽ���ؽ�����","������",39),
                new AssistiveDevice(101031504,"ͷ��ʽ���ؽ�����","������",40),
                new AssistiveDevice(101031505,"ģ�ܳ��;��ؽ�����","������",41),
                new AssistiveDevice(101031506,"���ʽ���ؽ�����","������",42),
                new AssistiveDevice(101031801,"ģ�ܳ���������������","������",43),
                new AssistiveDevice(101031802,"���ʽ������������","������",44),
                new AssistiveDevice(101031803,"����׵ǣ����","������",45),
                new AssistiveDevice(101032101,"������ͷ��","������",46),
                new AssistiveDevice(101032102,"­�ǻ���","������",47),
                new AssistiveDevice(101032601,"�ܶ��ֻ��Ͳ�͹������","������",48),
                new AssistiveDevice(101032602,"��ʿ���Ͳ�͹������","������",49),
                new AssistiveDevice(101032603,"�ﰺ�Ͳ�͹������","������",50),
                new AssistiveDevice(101032604,"ɫŬ�Ͳ�͹������","������",51),
                new AssistiveDevice(101032605,"CBW �Ͳ�͹������","������",52),
                new AssistiveDevice(101032606,"OMC������ҽ���Ͳ�͹������","������",53),
                new AssistiveDevice(101032701,"��������������","������",54),
                new AssistiveDevice(101040301,"������","������",55),
                new AssistiveDevice(101040401,"��ͨθ��","������",56),
                new AssistiveDevice(101040402,"�ɵ�ʽθ��","������",57),
                new AssistiveDevice(101040501,"��������","������",58),
                new AssistiveDevice(101040502,"˫������","������",59),
                new AssistiveDevice(101060301,"ָ��ؽڹ̶���","������",60),
                new AssistiveDevice(101060302,"�״ָ������","������",61),
                new AssistiveDevice(101060303,"�쾱����ָ������","������",62),
                new AssistiveDevice(101060304,"���۱���ָ������","������",63),
                new AssistiveDevice(101060305,"Ӳ��ָ��","������",64),
                new AssistiveDevice(101060306,"ָ����","������",65),
                new AssistiveDevice(101060307,"������ָ��","������",66),
                new AssistiveDevice(101060308,"������ָ��","������",67),
                new AssistiveDevice(101060601,"��ָ�ؽڹ̶�������","������",68),
                new AssistiveDevice(101060602,"��ָ�ؽ���չ����������","������",69),
                new AssistiveDevice(101060603,"������Խ�����","������",70),
                new AssistiveDevice(101060604,"�̶��ƽ�����","������",71),
                new AssistiveDevice(101060701,"�ɵ���ָ��","������",72),
                new AssistiveDevice(101060702,"���Ƽ�Ĥ����������","������",73),
                new AssistiveDevice(101060703,"����������ý�����","������",74),
                new AssistiveDevice(101061201,"��������","������",75),
                new AssistiveDevice(101061202,"�ӹ��ͻ���","������",76),
                new AssistiveDevice(101061203,"��ؽڶ�λ�а�","������",77),
                new AssistiveDevice(101061204,"ģ�ܳ������̶ֹ�������","������",78),
                new AssistiveDevice(101061205,"���������ֽ�����","������",79),
                new AssistiveDevice(101061206,"��̬���ֽ�����","������",80),
                new AssistiveDevice(101061207,"�����ƽ�����","������",81),
                new AssistiveDevice(101061301,"��MP��չ��λ�ĳ����ƽ�����","������",82),
                new AssistiveDevice(101061302,"��IP��չ������MP��չ��λ�ĳ����ƽ�����","������",83),
                new AssistiveDevice(101061303,"��MP���������ĳ����ƽ�����","������",84),
                new AssistiveDevice(101061304,"��MP��չ�����ĳ����ƽ�����","������",85),
                new AssistiveDevice(101061305,"��IP��չ�����ĳ����ƽ�����","������",86),
                new AssistiveDevice(101061401,"�����ͼгֽ�����","������",87),
                new AssistiveDevice(101061402,"�����ͼгֽ�����","������",88),
                new AssistiveDevice(101061501,"��������","������",89),
                new AssistiveDevice(101061502,"�����⻤��","������",90),
                new AssistiveDevice(101061503,"��������ƽ�����","������",91),
                new AssistiveDevice(101061504,"��̶�������","������",92),
                new AssistiveDevice(101061505,"�ɵ��������","������",93),
                new AssistiveDevice(101061901,"ǰ�ۣ������֣�������","������",94),
                new AssistiveDevice(101062001,"ǰ�۹̶�����","������",95),
                new AssistiveDevice(101062002,"ģ�ܳ���ǰ�۹̶���","������",96),
                new AssistiveDevice(101062101,"��������","������",97),
                new AssistiveDevice(101062102,"���Ǵ�","������",98),
                new AssistiveDevice(101062103,"��ؽڹ̶�������","������",99),
                new AssistiveDevice(101062104,"����չ������","������",100),
                new AssistiveDevice(101062105,"��ؽ���λ������","������",101),
                new AssistiveDevice(101062106,"�����ؽ���λ������","������",102),
                new AssistiveDevice(101062107,"�۵���","������",103),
                new AssistiveDevice(101062401,"����̶���","������",104),
                new AssistiveDevice(101062402,"���⸨������ʽ��̬���������","������",105),
                new AssistiveDevice(101062501,"�ϱ۹̶�����","������",106),
                new AssistiveDevice(101062502,"ģ�ܳ����ϱ۹̶���","������",107),
                new AssistiveDevice(101063001,"��������֫������","������",108),
                new AssistiveDevice(101063002,"ƽ��ʽǰ�۽�����(BFO)","������",109),
                new AssistiveDevice(101063101,"��-ָ�ؽڽ���","������",110),
                new AssistiveDevice(101063301,"�����","������",111),
                new AssistiveDevice(101063601,"������ؽڽ���","������",112),
                new AssistiveDevice(101063602,"��λ������ʽ��ؽڽ���","������",113),
                new AssistiveDevice(101063603,"��������ʽ��ؽڽ���","������",114),
                new AssistiveDevice(101063604,"������ؽڽ���","������",115),
                new AssistiveDevice(101063901,"���Լ�ؽڽ���","������",116),
                new AssistiveDevice(101120301,"Ĵָ�ⷭ���������棩","������",117),
                new AssistiveDevice(101120302,"�轺��ֺ��","������",118),
                new AssistiveDevice(101120303,"�״ֺ��","������",119),
                new AssistiveDevice(101120304,"���۵�","������",120),
                new AssistiveDevice(101120305,"�Źǵ�","������",121),
                new AssistiveDevice(101120306,"���Ƶ�","������",122),
                new AssistiveDevice(101120307,"���ǵ�","������",123),
                new AssistiveDevice(101120308,"���ǹǴ̵�","������",124),
                new AssistiveDevice(101120309,"�ṭ��","������",125),
                new AssistiveDevice(101120310,"ƽ���","������",126),
                new AssistiveDevice(101120311,"�������","������",127),
                new AssistiveDevice(101120312,"����/�ⷭ������","������",128),
                new AssistiveDevice(101120313,"�㹭��","������",129),
                new AssistiveDevice(101120314,"���ߵ�","������",130),
                new AssistiveDevice(101120315,"�����Ш�ε�","������",131),
                new AssistiveDevice(101120316,"������Ь��","������",132),
                new AssistiveDevice(101120601,"��������","������",133),
                new AssistiveDevice(101120602,"�ʹ��ͻ���","������",134),
                new AssistiveDevice(101120603,"����̶�������","������",135),
                new AssistiveDevice(101120604,"ѥ�����������","������",136),
                new AssistiveDevice(101120605,"��̬���������","������",137),
                new AssistiveDevice(101120606,"�������������","������",138),
                new AssistiveDevice(101120607,"����ʽ���������","������",139),
                new AssistiveDevice(101120608,"������ʽ���������","������",140),
                new AssistiveDevice(101120609,"ȫ���PTB���������","������",141),
                new AssistiveDevice(101120610,"�������PTB���������","������",142),
                new AssistiveDevice(101120611,"����˹������֧��","������",143),
                new AssistiveDevice(101120901,"���Ի�ϥ","������",144),
                new AssistiveDevice(101120902,"��ϥ������ϥ","������",145),
                new AssistiveDevice(101120903,"�ƹǻ���","������",146),
                new AssistiveDevice(101120904,"�ƹ��Ѿʽ�����","������",147),
                new AssistiveDevice(101120905,"���ʽϥ����������","������",148),
                new AssistiveDevice(101120906,"ǰ����ʮ���ʹ������ý�����","������",149),
                new AssistiveDevice(101120907,"����ั�ʹ������û�ϥ","������",150),
                new AssistiveDevice(101120908,"ϥ�ؽڹ̶�������","������",151),
                new AssistiveDevice(101120909,"�ɵ�ϥ������","������",152),
                new AssistiveDevice(101120910,"��ϥѹ�����֧����ϥ������","������",153),
                new AssistiveDevice(101120911,"ģ��ϥ������","������",154),
                new AssistiveDevice(101121201,"ϥ����̶�������","������",155),
                new AssistiveDevice(101121202,"����֧��ʽϥ���������","������",156),
                new AssistiveDevice(101121203,"X���Ƚ�����","������",157),
                new AssistiveDevice(101121204,"O���Ƚ�����","������",158),
                new AssistiveDevice(101121205,"ȫ������ǳ��ش��Ƚ�����","������",159),
                new AssistiveDevice(101121206,"����������ǳ��ش��Ƚ�����","������",160),
                new AssistiveDevice(101121207,"�����Ȳ��ý�����","������",161),
                new AssistiveDevice(101121301,"����С�Ȼ���","������",162),
                new AssistiveDevice(101121302,"С�ȹ̶�����","������",163),
                new AssistiveDevice(101121303,"ģ�ܳ���С�ȹ̶���","������",164),
                new AssistiveDevice(101121501,"�Ź̶�������","������",165),
                new AssistiveDevice(101121502,"����ʽ����չ������","������",166),
                new AssistiveDevice(101121503,"�ɵ�������չ���Ź̶�������","������",167),
                new AssistiveDevice(101121504,"��ʽ֧��","������",168),
                new AssistiveDevice(101121505,"��ͯ����������λ������","������",169),
                new AssistiveDevice(101121601,"��ϥ������","������",170),
                new AssistiveDevice(101121701,"�������Ȼ���","������",171),
                new AssistiveDevice(101121702,"���ȹ̶�����","������",172),
                new AssistiveDevice(101121703,"ģ�ܳ��ʹ��ȹ̶���","������",173),
                new AssistiveDevice(101121801,"����֧��ʽ�Ŵ��Ƚ�����","������",174),
                new AssistiveDevice(101121802,"ģ�ܳ����Ŵ��Ƚ�����","������",175),
                new AssistiveDevice(101121803,"���ǳ����Ŵ��Ƚ�����","������",176),
                new AssistiveDevice(101121901,"���������������Ŵ��Ƚ�����","������",177),
                new AssistiveDevice(101121902,"�����������������Ŵ��Ƚ�����","������",178),
                new AssistiveDevice(101121903,"��֫Ťת������","������",179),
                new AssistiveDevice(101121904,"����ڶ�ʽ��̱���߽�������RGO��","������",180),
                new AssistiveDevice(101121905,"��λ��̱���߽�������ARGO��","������",181),
                new AssistiveDevice(101122001,"��-ֺ����","������",182),
                new AssistiveDevice(101122101,"���������ʽ�׽���","������",183),
                new AssistiveDevice(101122102,"����ŵ���ɵ��׽���","������",184),
                new AssistiveDevice(101122103,"����ŵ�������ʽ�׽���","������",185),
                new AssistiveDevice(101122104,"�����˫��ɵ��⣨�ڣ���֧��ʽ�׽���","������",186),
                new AssistiveDevice(101122401,"����ʽ����ϥ����","������",187),
                new AssistiveDevice(101122402,"�价��ϥ����","������",188),
                new AssistiveDevice(101122403,"��צ��ϥ����","������",189),
                new AssistiveDevice(101122404,"��λ��ʽ��ϥ����","������",190),
                new AssistiveDevice(101122701,"����ʽ�����Ž���","������",191),
                new AssistiveDevice(101122702,"�价���Ž���","������",192),
                new AssistiveDevice(101122703,"��צ���Ž���","������",193),
                new AssistiveDevice(101330701,"���и��ֽ��θ��Ľ���Ь","������",194),
                new AssistiveDevice(101330702,"���и��ֽ����ƵĽ���Ь","������",195),
                new AssistiveDevice(101330703,"��ƽ�����Ь","������",196),
                new AssistiveDevice(101330704,"���������Ь","������",197),
                new AssistiveDevice(101330705,"�ڣ��⣩�������Ь","������",198),
                new AssistiveDevice(101330706,"���������Ь","������",199),
                new AssistiveDevice(101331801,"����Ь����Ь��","������",200),
                new AssistiveDevice(101331802,"����Ь����Ь��","������",201),
                new AssistiveDevice(101332101,"������ȱЬ","������",202),
                new AssistiveDevice(101332102,"������ȱЬ","������",203),
                new AssistiveDevice(101333001,"�Ź�Сͷ���Ь","������",204),
                new AssistiveDevice(101333002,"���Ǵ����Ь","������",205),
                new AssistiveDevice(101333301,"���Ь","������",206),
                new AssistiveDevice(101333302,"����Ь","������",207),
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

                new AssistiveDevice(105060601,"��ʽ������","������",836),
                new AssistiveDevice(105060901,"�۾�ʽ������","������",837),
                new AssistiveDevice(105061501,"����ʽ������","������",838),
                new AssistiveDevice(105061201,"����ʽ������","������",839),
                new AssistiveDevice(105061301,"����ʽ������","������",840),
                new AssistiveDevice(105061401,"�����ʽ������","������",841),
                new AssistiveDevice(105061701,"�˹�����","������",842),
                new AssistiveDevice(105061801,"�ǵ�ʽ������","������",843),
                new AssistiveDevice(105062701,"���������","������",844),
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

                new AssistiveDevice(105030301,"������ר���˹⾵","������",800),
                new AssistiveDevice(105030302,"�˹���","������",801),
                new AssistiveDevice(105030601,"�۾��������۾�","������",802),
                new AssistiveDevice(105030901,"�ֳ�ʽ�Ŵ�","������",803),
                new AssistiveDevice(105030902,"̨��ʽ�Ŵ�","������",804),
                new AssistiveDevice(105030903,"�۵�ʽ�Ŵ�","������",805),
                new AssistiveDevice(105030904,"��Яʽ�Ŵ�","������",806),
                new AssistiveDevice(105030905,"��ֽʽ������","������",807),
                new AssistiveDevice(105030906,"�ɵ���ʽ�Ŵ�","������",808),
                new AssistiveDevice(105030907,"����ʽ�Ŵ�","������",809),
                new AssistiveDevice(105030908,"����Ŵ�","������",810),
                new AssistiveDevice(105030909,"�����Ŵ�","������",811),
                new AssistiveDevice(105030910,"�����澵Ƭ��ʽ�Ŵ�","������",812),
                new AssistiveDevice(105030911,"��ʽ�Ŵ�","������",813),
                new AssistiveDevice(105030912,"��Ͳ�Ŵ�","������",814),
                new AssistiveDevice(105030913,"˫Ŀ�۾�","������",815),
                new AssistiveDevice(105030914,"����Ƭ��ʽ�Ŵ� ","������",816),
                new AssistiveDevice(105030915,"���α�Яʽ�Ӿ���д�Ŵ�","������",817),
                new AssistiveDevice(105030916,"��ʽ��д����ʽ�Ŵ�","������",818),
                new AssistiveDevice(105030917,"��������Ŵ�","������",819),
                new AssistiveDevice(105030918,"�ع�ʽ���ƷŴ�","������",820),
                new AssistiveDevice(105030919,"��Яʽ����������","������",821),
                new AssistiveDevice(105030920,"�ֳ�ʽ����������","������",822),
                new AssistiveDevice(105030921,"�ֳ�ʽԶ�����õ���������","������",823),
                new AssistiveDevice(105030922,"����","������",824),
                new AssistiveDevice(105030923,"��ЯʽԶ�����õ���������","������",825),
                new AssistiveDevice(105030924,"̨ʽ��ЯԶ�����õ���������","������",826),
                new AssistiveDevice(105030925,"̨ʽ����������","������",827),
                new AssistiveDevice(105030926,"һ��ʽ�����Ķ���","������",828),
                new AssistiveDevice(105030927,"�г���Ƭ�۾�ʽ�Ŵ�","������",829),
                new AssistiveDevice(105030928,"�۾�ʽ������","������",830),
                new AssistiveDevice(105030929,"��Яʽ�۾����ӷŴ�","������",831),
                new AssistiveDevice(105031201,"�۾�ʽ��Զ��","������",832),
                new AssistiveDevice(105031202,"ָ����Զ��","������",833),
                new AssistiveDevice(105031203,"��Ͳ��Զ��","������",834),
                new AssistiveDevice(105031204,"˫Ͳ��Զ��","������",835),
                new AssistiveDevice(105120301,"ä��ר���ľ�","������",847),
                new AssistiveDevice(105120302,"ä��ѧϰ��ֱ��","������",848),
                new AssistiveDevice(105120303,"ä��ѧϰ�����ǳ�","������",849),
                new AssistiveDevice(105120304,"ä��ѧϰ��������(���ʽ)","������",850),
                new AssistiveDevice(105120305,"ä��ѧϰ��Բ��","������",851),
                new AssistiveDevice(105120306,"Сд�ֱ�","������",852),
                new AssistiveDevice(105120307,"ä�ļ��±�","������",853),
                new AssistiveDevice(105120601,"��������д��","������",854),
                new AssistiveDevice(105120602,"ä���û�ͼ��","������",855),
                new AssistiveDevice(105120603,"ä���û滭��","������",856),
                new AssistiveDevice(105120901,"ä������д��","������",857),
                new AssistiveDevice(105120902, "ä����ӡ��", "������",858),
                new AssistiveDevice(105120903, "ä����ǩ�ֵ����", "������",859),
                new AssistiveDevice(105121201, "��������д�ְ�4��", "������",860),
                new AssistiveDevice(105121202, "���Ͻ�д�ְ�6��", "������",861),
                new AssistiveDevice(105121203, "����д�ְ�27��", "������",862),
                new AssistiveDevice(105121204, "ä�˿��ֵ��", "������",863),
                new AssistiveDevice(105121501, "ä���ֶ����ֻ�", "������",864),
                new AssistiveDevice(105121801, "������дֽ����Ĥ��", "������",865),
                new AssistiveDevice(105122101, "��Яʽä�ļ�¼װ��", "������",866),
                new AssistiveDevice(105122401, "ä�ļ�����༭�Ű����", "������",867),
                new AssistiveDevice(105122402,"�Ӿ����Ƽ�������","������",868),
                new AssistiveDevice(105122701, "ä�Ļ�ͼ����", "������",869),
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

                new AssistiveDevice(103330301,"ϴԡ����","ϴ����",681),
                new AssistiveDevice(103330302,"�޷���ϴԡ��","ϴ����",682),
                new AssistiveDevice(103330303,"������ϴԡ��","ϴ����",683),
                new AssistiveDevice(103330304,"����ϴԡ��","ϴ����",684),
                new AssistiveDevice(103330305,"����ϴԡ��","ϴ����",685),
                new AssistiveDevice(103330401,"�޷���ϴԡ��","ϴ����",686),
                new AssistiveDevice(103330402,"������ϴԡ��","ϴ����",687),
                new AssistiveDevice(103330501,"ϴԡ��","ϴ����",688),
                new AssistiveDevice(103330601,"���������","ϴ����",689),
                new AssistiveDevice(103330701,"ԡ�׷�����","ϴ����",690),
                new AssistiveDevice(103330901,"������ԡͷλ�õĹ̶�Ԫ��","ϴ����",691),
                new AssistiveDevice(103331201,"ϴԡ��","ϴ����",692),
                new AssistiveDevice(103331202,"ϴԡ̨","ϴ����",693),
                new AssistiveDevice(103331501,"����ʽϴͷ��","ϴ����",694),
                new AssistiveDevice(103331502,"�̶�ʽϴ��","ϴ����",695),
                new AssistiveDevice(103331503,"��Яʽϴ��","ϴ����",696),
                new AssistiveDevice(103331504,"�߶ȿɵ��ڵ�ϴ��֧��","ϴ����",697),
                new AssistiveDevice(103331505,"�߶ȿɵ��ڵ�ϴ�������֧��","ϴ����",698),
                new AssistiveDevice(103331801, "�̶���ԡ��", "ϴ����",699),
                new AssistiveDevice(103331802, "��Яʽ��ԡ��", "ϴ����",700),
                new AssistiveDevice(103332101, "����ԡ��", "ϴ����",701),
                new AssistiveDevice(103332201, "ϴԡ����", "ϴ����",702),
                new AssistiveDevice(103332701, "ԡ����һ��̤��", "ϴ����",703),
                new AssistiveDevice(103332702, "ԡ���ö���̤��", "ϴ����",704),
                new AssistiveDevice(103333001, "���а��ֵĺ���", "ϴ����",705),
                new AssistiveDevice(103333002, "����ʽϴԡ����", "ϴ����",706),
                new AssistiveDevice(103333003, "����ϴ��ˢ", "ϴ����",707),
                new AssistiveDevice(103333004, "�������ˢ", "ϴ����",708),
                new AssistiveDevice(103333005, "������ԡˢ", "ϴ����",709),
                new AssistiveDevice(103333006, "���а��ֵ�ϴ�貼", "ϴ����",710),
                new AssistiveDevice(103334501, "ԡ���¶ȼ�", "ϴ����",711),
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

                new AssistiveDevice(103030501,"�������ε�����","������",518),
                new AssistiveDevice(103030502,"����ʽ����","������",519),
                new AssistiveDevice(103030901,"ñ��","������",520),
                new AssistiveDevice(103031201,"��ָ����","������",521),
                new AssistiveDevice(103031202,"����ָ����","������",522),
                new AssistiveDevice(103031501, "�࿪����ʽ��࿪���ʽ����", "������",523),
                new AssistiveDevice(103031502,"�࿪����ʽ��࿪���ʽ����","������",524),
                new AssistiveDevice(103031801, "�࿪����ʽ�п���", "������",525),
                new AssistiveDevice(103031802, "�࿪����ʽ����", "������",526),
                new AssistiveDevice(103031803,"�࿪���ʽ�п���","������",527),
                new AssistiveDevice(103031804, "�࿪���ʽ����", "������",528),
                new AssistiveDevice(103031805, "�࿪����ʽ����", "������",529),
                new AssistiveDevice(103032101, "����ȹ", "������",530),
                new AssistiveDevice(103032102, "����ȹ", "������",531),
                new AssistiveDevice(103032401, "һ�����ڿ�", "������",532),
                new AssistiveDevice(103032402, "�����������", "������",533),
                new AssistiveDevice(103032701, "��Ͳ��", "������",534),
                new AssistiveDevice(103032702, "����", "������",535),
                new AssistiveDevice(103033001, "˯��", "������",536),
                new AssistiveDevice(103033301, "ԡ��", "������",537),
                new AssistiveDevice(103033901, "Χ��", "������",538),
                new AssistiveDevice(103033902, "Χȹ", "������",539),
                new AssistiveDevice(103034201, "����Ь", "������",540),
                new AssistiveDevice(103034202, "���㴩��Ь", "������",541),
                new AssistiveDevice(103034501,"Ь��ѥ�ķ�����������","������",542),
                new AssistiveDevice(103034801, "����װ�ú�Ŧ��", "������",543),
                new AssistiveDevice(103035101,"����ϵ����ʽ�����","������",544),
                new AssistiveDevice(103060301, "����ͷ��", "������",545),
                new AssistiveDevice(103060601, "��������", "������",546),
                new AssistiveDevice(103060602, "��Ŀ��", "������",547),
                new AssistiveDevice(103060901, "����", "������",548),
                new AssistiveDevice(103060902, "����", "������",549),
                new AssistiveDevice(103060903, "�������", "������",550),
                new AssistiveDevice(103061201,"�������۷�����������","������",551),
                new AssistiveDevice(103061501, "�������ε�����", "������",552),
                new AssistiveDevice(103061801, "�Ӻ�Ͳ��", "������",553),
                new AssistiveDevice(103062101, "Ӳ��Ь", "������",554),
                new AssistiveDevice(103062102, "�Ӻ���", "������",555),
                new AssistiveDevice(103062401,"���ɷ�����ȫ�������������","������",556),
                new AssistiveDevice(103062701, "������", "������",557),
                new AssistiveDevice(103070101, "�ȶ�����ĸ�������", "������",558),
                new AssistiveDevice(103090301, "������", "������",559),
                new AssistiveDevice(103090302, "�๦�ܴ��¡���Ь������", "������",560),
                new AssistiveDevice(103090601, "��ѥ��", "������",561),
                new AssistiveDevice(103090602, "����Ь��", "������",562),
                new AssistiveDevice(103090901, "���¼�", "������",563),
                new AssistiveDevice(103091201, "���¸�", "������",564),
                new AssistiveDevice(103091202, "��Ь�δ��¸�", "������",565),
                new AssistiveDevice(103091203, "�����¹�", "������",566),
                new AssistiveDevice(103091501, "������", "������",567),
                new AssistiveDevice(103091801, "ϵ����", "������",568),
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
                        new Option("D", "ͨѶ����", "2",0, 105240601,1053315),
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

