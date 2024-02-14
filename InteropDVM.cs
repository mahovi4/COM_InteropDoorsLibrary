using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace COM_InteropDoorsLibrary
{
    [Guid("06F63AA2-E343-4061-8F76-67DD274CCF3E")]
    public interface IInteropDVM : IDVM { }
    [Guid("528AE21F-359C-4D23-A704-8200D7561EF3"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IEInteropDVM : IEDVM { }
    [Guid("163ACB24-DA2C-4143-9003-8E7B395B1207"), ClassInterface(ClassInterfaceType.None), ComSourceInterfaces(typeof(IEInteropDVM))]
    public class InteropDVM : IInteropDVM
    {
        private readonly DVM dvm;
        public InteropDVM() : base()
        {
            dvm = new DVM();
        }

        public bool NulDobors { get => dvm.NulDobors; }
        public string Errors { get => dvm.Errors; }
        public string Problems { get => dvm.Problems; }
        public int Row { get => dvm.Row; }
        public string Num { get => dvm.Num; }
        public short Height { get => dvm.Height; }
        public short Width { get => dvm.Width; }
        public bool IsPassivka { get => dvm.IsPassivka; }
        public short LicevoyList_OtPola { get => dvm.LicevoyList_OtPola; }
        public short VnutrenniyList_OtPola { get => dvm.VnutrenniyList_OtPola; }
        public bool IsEnyDobor { get => dvm.IsEnyDobor; }
        public short VertProf_Height { get => dvm.VertProf_Height; }
        public short VertProf_Dobor_Height { get => dvm.VertProf_Dobor_Height; }
        public short VertProf_OtPola { get => dvm.VertProf_OtPola; }
        public short Stoyka_Height { get => dvm.Stoyka_Height; }
        public short Stoyka_Dobor_Height { get => dvm.Stoyka_Dobor_Height; }
        public short Pritoloka_Height { get => dvm.Pritoloka_Height; }
        public short Pritoloka_Dobor_Height { get => dvm.Pritoloka_Dobor_Height; }
        public bool IsPorog { get => dvm.IsPorog; }
        public short Porog_Height { get => dvm.Porog_Height; }
        public short Porog_Dobor_Height { get => dvm.Porog_Dobor_Height; }
        public short Porog_Razvertka { get => dvm.Porog_Razvertka; }
        public double Porog_Anker { get => dvm.Porog_Anker; }
        public short Porog_Virez_Height { get => dvm.Porog_Virez_Height; }
        public short Porog_Num { get => dvm.Porog_Num; }
        public bool Korobka_IsRazbornaya { get => dvm.Korobka_IsRazbornaya; }
        public bool IsKalitka { get => dvm.IsKalitka; }
        public short Kalitka_Height { get => dvm.Kalitka_Height; }
        public short Kalitka_Width { get => dvm.Kalitka_Width; }
        public short Kalitka_OtPola { get => dvm.Kalitka_OtPola; }
        public short Kalitka_OtZamkovogoProf { get => dvm.Kalitka_OtZamkovogoProf; }
        public short Kalitka_LicList_Hight { get => dvm.Kalitka_LicList_Hight; }
        public short Kalitka_VnutList_Hight { get => dvm.Kalitka_VnutList_Hight; }
        public short Kalitka_LicList_Width { get => dvm.Kalitka_LicList_Width; }
        public short Kalitka_VnutList_Width { get => dvm.Kalitka_VnutList_Width; }
        public short Kalitka_VertProf { get => dvm.Kalitka_VertProf; }
        public short Kalitka_VertProf_OtPola { get => dvm.Kalitka_VertProf_OtPola; }
        public short Kalitka_GorProf { get => dvm.Kalitka_GorProf; }
        public short Kalitka_Obramlenie_VertProf { get => dvm.Kalitka_Obramlenie_VertProf; }
        public short Kalitka_Obramlenie_GorProf { get => dvm.Kalitka_Obramlenie_GorProf; }
        public short Kalitka_LicList_OtPola { get => dvm.Kalitka_LicList_OtPola; }
        public short Kalitka_VnutList_OtPola { get => dvm.Kalitka_VnutList_OtPola; }
        public short Kalitka_LicList_Virez_Height { get => dvm.Kalitka_LicList_Virez_Height; }
        public short Kalitka_LicList_Virez_Width { get => dvm.Kalitka_LicList_Virez_Width; }
        public short Kalitka_VnutList_Virez_Height { get => dvm.Kalitka_VnutList_Virez_Height; }
        public short Kalitka_VnutList_Virez_Width { get => dvm.Kalitka_VnutList_Virez_Width; }
        public short Kalitka_LicList_VIrez_OtPola { get => dvm.Kalitka_LicList_VIrez_OtPola; }
        public short Kalitka_LicList_VIrez_OtZamkProf { get => dvm.Kalitka_LicList_VIrez_OtZamkProf; }
        public short Kalitka_VnutList_VIrez_OtPola { get => dvm.Kalitka_VnutList_VIrez_OtPola; }
        public short Kalitka_VnutList_VIrez_OtZamkProf { get => dvm.Kalitka_VnutList_VIrez_OtZamkProf; }
        public short Zamok { get => dvm.Zamok; }
        public short Zadvizhka { get => dvm.Zadvizhka; }

        public short GorProf_Dobor_Height(Stvorka stvorka)
        {
            return dvm.GorProf_Dobor_Height(stvorka);
        }
        public short GorProf_Height(Stvorka stvorka)
        {
            return dvm.GorProf_Height(stvorka);
        }
        public void Init(DVMParam data)
        {
            dvm.Init(data);
        }
        public short LicevoyList_Height(Stvorka stvorka)
        {
            return dvm.LicevoyList_Height(stvorka);
        }
        public short LicevoyList_Width(Stvorka stvorka)
        {
            return dvm.LicevoyList_Width(stvorka);
        }
        public short LicList_DopDobor_Height(Stvorka stvorka)
        {
            return dvm.LicList_DopDobor_Height(stvorka);
        }
        public short LicList_DopDobor_Width(Stvorka stvorka)
        {
            return dvm.LicList_DopDobor_Width(stvorka);
        }
        public short LicList_GorDobor_Height(Stvorka stvorka)
        {
            return dvm.LicList_GorDobor_Height(stvorka);
        }
        public short LicList_GorDobor_Width(Stvorka stvorka)
        {
            return dvm.LicList_GorDobor_Width(stvorka);
        }
        public bool LicList_IsDopDobor(Stvorka stvorka)
        {
            return dvm.LicList_IsDopDobor(stvorka);
        }
        public bool LicList_IsGorDobor(Stvorka stvorka)
        {
            return dvm.LicList_IsGorDobor(stvorka);
        }
        public bool LicList_IsVertDobor(Stvorka stvorka)
        {
            return dvm.LicList_IsVertDobor(stvorka);
        }
        public short LicList_VertDobor_Height(Stvorka stvorka)
        {
            return dvm.LicList_VertDobor_Height(stvorka);
        }
        public short LicList_VertDobor_Width(Stvorka stvorka)
        {
            return dvm.LicList_VertDobor_Width(stvorka);
        }
        public string Name(short conf)
        {
            return dvm.Name(conf);
        }
        public short Stvorka_Height(Stvorka stvorka)
        {
            return dvm.Stvorka_Height(stvorka);
        }
        public short Stvorka_Width(Stvorka stvorka)
        {
            return dvm.Stvorka_Width(stvorka);
        }
        public short VnutList_DopDobor_Height(Stvorka stvorka)
        {
            return dvm.VnutList_DopDobor_Height(stvorka);
        }
        public short VnutList_DopDobor_Width(Stvorka stvorka)
        {
            return dvm.VnutList_DopDobor_Width(stvorka);
        }
        public short VnutList_GorDobor_Height(Stvorka stvorka)
        {
            return dvm.VnutList_GorDobor_Height(stvorka);
        }
        public short VnutList_GorDobor_Width(Stvorka stvorka)
        {
            return dvm.VnutList_GorDobor_Width(stvorka);
        }
        public bool VnutList_IsDopDobor(Stvorka stvorka)
        {
            return dvm.VnutList_IsDopDobor(stvorka);
        }
        public bool VnutList_IsGorDobor(Stvorka stvorka)
        {
            return dvm.VnutList_IsGorDobor(stvorka);
        }
        public bool VnutList_IsVertDobor(Stvorka stvorka)
        {
            return dvm.VnutList_IsVertDobor(stvorka);
        }
        public short VnutList_VertDobor_Height(Stvorka stvorka)
        {
            return dvm.VnutList_VertDobor_Height(stvorka);
        }
        public short VnutList_VertDobor_Width(Stvorka stvorka)
        {
            return dvm.VnutList_VertDobor_Width(stvorka);
        }
        public short VnutrenniyList_Height(Stvorka stvorka)
        {
            return dvm.VnutrenniyList_Height(stvorka);
        }
        public short VnutrenniyList_Width(Stvorka stvorka)
        {
            return dvm.VnutrenniyList_Width(stvorka);
        }
    }
}
