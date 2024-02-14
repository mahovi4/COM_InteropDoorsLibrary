using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace COM_InteropDoorsLibrary
{
    [Guid("254000A3-4543-40AB-9E50-91F22270F6B6")]
    public interface IInteropTData : ITableData { }
    [Guid("4230D2BF-865E-4F0D-809B-89ADD7400426"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IEInteropTData : IETableData { }
    [Guid("56452381-759A-455F-8B33-51EDF12849B4"), ClassInterface(ClassInterfaceType.None), ComSourceInterfaces(typeof(IEInteropTData))]
    public class InteropTData : IInteropTData
    {
        private readonly TableData tData;
        public InteropTData() : base()
        {
            tData = new TableData();
        }

        public int Row { get => tData.Row; set => tData.Row = value; }
        public string Num { get => tData.Num; set => tData.Num = value; }
        public short Kod { get => tData.Kod; set => tData.Kod = value; }
        public short Height { get => tData.Height; set => tData.Height = value; }
        public short Width { get => tData.Width; set => tData.Width = value; }
        public Otkrivanie Otkrivanie { get => tData.Otkrivanie; set => tData.Otkrivanie = value; }
        public double WAktiv { get => tData.WAktiv; set => tData.WAktiv = value; }
        public bool Pritvor { get => tData.Pritvor; set => tData.Pritvor = value; }
        public bool ST { get => tData.ST; set => tData.ST = value; }
        public bool EI { get => tData.EI; set => tData.EI = value; }
        public bool EIS { get => tData.EIS; set => tData.EIS = value; }
        public bool DPM { get => tData.DPM; set => tData.DPM = value; }
        public bool Kalit { get => tData.Kalit; set => tData.Kalit = value; }
        public short HKalit { get => tData.HKalit; set => tData.HKalit = value; }
        public short WKalit { get => tData.WKalit; set => tData.WKalit = value; }
        public short KalitOtPola { get => tData.KalitOtPola; set => tData.KalitOtPola = value; }
        public short KalitOtZamka { get => tData.KalitOtZamka; set => tData.KalitOtZamka = value; }
        public KalitkaParam KalitParam { get => tData.KalitParam; set => tData.KalitParam = value; }
        public short Porog { get => tData.Porog; set => tData.Porog = value; }
        public short[] Nalichniki { get => tData.Nalichniki; set => tData.Nalichniki = value; }
        public bool Intek { get => tData.Intek; set => tData.Intek = value; }
        public bool Razbor { get => tData.Razbor; set => tData.Razbor = value; }
        public bool AMak { get => tData.AMak; set => tData.AMak = value; }
        public ZamokParam[] Zamok { get => tData.Zamok; set => tData.Zamok = value; }
        public GlazokParam[] Glazok { get => tData.Glazok; set => tData.Glazok = value; }
        public GlazokParam AddGlazok { set => tData.AddGlazok = value; }
        public ZadvizhkaParam Zadvizhka { get => tData.Zadvizhka; set => tData.Zadvizhka = value; }
        public short Protivos { get => tData.Protivos; set => tData.Protivos = value; }
        public VirezKvadrat Kvadrat { get => tData.Kvadrat; set => tData.Kvadrat = value; }
        public KabelRaspolozhenie Kabel { get => tData.Kabel; set => tData.Kabel = value; }
        public GNDRaspolozhenie GND { get => tData.GND; set => tData.GND = value; }
        public KodoviyParam Kodoviy { get => tData.Kodoviy; set => tData.Kodoviy = value; }
        public short KodoviyOtPola { get => tData.KodoviyOtPola; set => tData.KodoviyOtPola = value; }
        public bool TSpingalet { get => tData.TSpingalet; set => tData.TSpingalet = value; }
        public double Thick_LL { get => tData.Thick_LL; set => tData.Thick_LL = value; }
        public double Thick_VL { get => tData.Thick_VL; set => tData.Thick_VL = value; }
        public OknoParam[] OknoArr { get => tData.OknoArr; set => tData.OknoArr = value; }
        public ZashResh ZResh { get => tData.ZResh; set => tData.ZResh = value; }
        public bool Dobor { get => tData.Dobor; set => tData.Dobor = value; }
        public short[] Dobor_Nal { get => tData.Dobor_Nal; set => tData.Dobor_Nal = value; }
        public short Dobor_Glub { get => tData.Dobor_Glub; set => tData.Dobor_Glub = value; }
        public FramugaType[] FrmugaArr { get => tData.FrmugaArr; set => tData.FrmugaArr = value; }
        public FramugaParam[] FramugaParArr { get => tData.FramugaParArr; set => tData.FramugaParArr = value; }
        public DoborParam DoborParam { get => tData.DoborParam; set => tData.DoborParam = value; }
        public string ER { get => tData.ER; set => tData.ER = value; }
        public bool Bronya { get => tData.Bronya; set => tData.Bronya = value; }
        public bool Termoblock { get => tData.Termoblock; set => tData.Termoblock = value; }
        public bool EIW { get => tData.EIW; set => tData.EIW = value; }
        public bool EIWS { get => tData.EIWS; set => tData.EIWS = value; }

        public DM CreateDM { get => tData.CreateDM; }
        public LM CreateLM { get => tData.CreateLM; }
        public ODL CreateODL { get => tData.CreateODL; }
        public DVM CreateDVM { get => tData.CreateDVM; }
        public Framuga CreateFramugaDM(Raspolozhenie pos)
        {
            return tData.CreateFramugaDM(pos);
        }
        public Framuga CreateFramugaVM(Raspolozhenie pos)
        {
            return tData.CreateFramugaVM(pos);
        }

        public FramugaType GetFramuga(short num)
        {
            return tData.GetFramuga(num);
        }
        public FramugaParam GetFramugaPar(short num)
        {
            return tData.GetFramugaPar(num);
        }
        public short GetNalichnik(short index)
        {
            return tData.GetNalichnik(index);
        }
        public OknoParam GetOkno(short num)
        {
            return tData.GetOkno(num);
        }
        public eReshetka GetResh(short num)
        {
            return tData.GetResh(num);
        }
        public ReshParam GetReshPar(short num)
        {
            return tData.GetReshPar(num);
        }
        public RuchkaParam GetRuchka(short stvorka, short num)
        {
            return tData.GetRuchka(stvorka, num);
        }
        public RuchkaParam[] GetRuchki(short stvorka)
        {
            return tData.GetRuchki(stvorka);
        }
        public StekloParam[] GetStekloFramugiArr(short numFr)
        {
            return tData.GetStekloFramugiArr(numFr);
        }
        public StekloParam GetStekloFramugiByNum(short numFr, short numSt)
        {
            return tData.GetStekloFramugiByNum(numFr, numSt);
        }
        public short GetZamok(short num)
        {
            return tData.GetZamok(num);
        }
        public bool IsFramuga(short num)
        {
            return tData.IsFramuga(num);
        }
        public bool IsOkno(short num)
        {
            return tData.IsOkno(num);
        }
        public bool IsResh(short num)
        {
            return tData.IsResh(num);
        }
        public bool IsRuchka(short stvorka, short num)
        {
            return tData.IsRuchka(stvorka, num);
        }
        public bool IsStekloFramugi(short numFr)
        {
            return tData.IsStekloFramugi(numFr);
        }
        public bool IsStekloFramugiByNum(short numFr, short numSt)
        {
            return tData.IsStekloFramugiByNum(numFr, numSt);
        }
        public bool IsValidKod(string kod)
        {
            return tData.IsValidKod(kod);
        }
        public bool IsValidPorog(string namePorog)
        {
            return tData.IsValidPorog(namePorog);
        }
        public void SetFramuga(short num, FramugaType value)
        {
            tData.SetFramuga(num, value);
        }
        public void SetFramugaPar(short num, FramugaParam value)
        {
            tData.SetFramugaPar(num, value);
        }
        public void SetNalichnik(short index, short val)
        {
            tData.SetNalichnik(index, val);
        }
        public void SetOkno(short num, OknoParam value)
        {
            tData.SetOkno(num, value);
        }
        public void SetResh(short num, eReshetka value)
        {
            tData.SetResh(num, value);
        }
        public void SetReshPar(short num, ReshParam value)
        {
            tData.SetReshPar(num, value);
        }
        public void SetRuchka(short stvorka, short num, RuchkaParam val)
        {
            tData.SetRuchka(stvorka, num, val);
        }
        public void SetStekloFramugiArr(short numFr, StekloParam[] value)
        {
            tData.SetStekloFramugiArr(numFr, value);
        }
        public void SetStekloFramugiByNum(short numFr, short numSt, StekloParam value)
        {
            tData.SetStekloFramugiByNum(numFr, numSt, value);
        }
        public void SetZamok(short num, short val)
        {
            tData.SetZamok(num, val);
        }
    }
}
