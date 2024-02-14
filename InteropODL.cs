using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace COM_InteropDoorsLibrary
{
    [Guid("4DE233F4-F3CA-44BE-B8CF-8D4721A2964F")]
    public interface IInteropODL : IODL { }
    [Guid("364AC433-DBBB-4832-9337-C7A1F58C8AE4"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IEInteropODL : IEODL { }
    [Guid("E4F2BAAB-0BB8-4BC1-BAFF-696AE78FB56D"), ClassInterface(ClassInterfaceType.None), ComSourceInterfaces(typeof(IEInteropODL))]
    public class InteropODL : IInteropODL
    {
        private readonly ODL odl;
        public InteropODL() : base() 
        {
            odl = new ODL();
        }

        public string Errors { get => odl.Errors; set => odl.Errors = value; }
        public string Problems { get => odl.Problems; set => odl.Problems = value; }
        public int Row { get => odl.Row; }
        public string Num { get => odl.Num; }
        public Otkrivanie Otkrivanie { get => odl.Otkrivanie; }
        public bool IsPassivka { get => odl.IsPassivka; }
        public short LicevoyList_Height { get => odl.LicevoyList_Height; }
        public short LicevoyList_OtPola { get => odl.LicevoyList_OtPola; }
        public short ZamkovoyProfil_OtPola { get => odl.ZamkovoyProfil_OtPola; }
        public short VertStoyka_Height { get => odl.VertStoyka_Height; }
        public double GorStoyka_Height { get => odl.GorStoyka_Height; }
        public short Zamok_OtPola { get => odl.Zamok_OtPola; }
        public short Ruchka { get => odl.Ruchka; }
        public short Ruchka_OtPola { get => odl.Ruchka_OtPola; }
        public short RastDo3Ankera { get => odl.RastDo3Ankera; }
        public double Anker_Diametr { get => odl.Anker_Diametr; }

        public double Anker2_Diametr(Raspolozhenie pos)
        {
            return odl.Anker2_Diametr(pos);
        }
        public void Init(ODLParam data)
        {
            odl.Init(data);
        }
        public short LicevoyList_Width(Stvorka stvorka)
        {
            return odl.LicevoyList_Width(stvorka);
        }
        public short Nalichnik(Raspolozhenie pos)
        {
            return odl.Nalichnik(pos);
        }
        public double Nalichnik_Raz(short conf)
        {
            return odl.Nalichnik_Raz(conf);
        }
        public string Name(short index)
        {
            return odl.Name(index);
        }
        public double Stvorka_Width(Stvorka stvorka)
        {
            return odl.Stvorka_Width(stvorka);
        }
        public short ZamkovoyProfil_Height(Stvorka stvorka)
        {
            return odl.ZamkovoyProfil_Height(stvorka);
        }
        public short ZamkovoyProfil_Razvertka(Stvorka stvorka)
        {
            return odl.ZamkovoyProfil_Razvertka(stvorka);
        }
        public short Zamok(short index)
        {
            return odl.Zamok(index);
        }
    }
}
