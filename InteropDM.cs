using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace COM_InteropDoorsLibrary
{
    [Guid("AD862C10-4C75-488E-8BA3-FE6030D353D5")]
    public interface IInteropDM : IDM { }
    [Guid("8FBB8F89-BD3E-4F08-8934-0780371163BE"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IEInteropDM : IEDM { }
    [Guid("27F6180B-7D85-439F-935A-B0107A7058D0"), ClassInterface(ClassInterfaceType.None), ComSourceInterfaces(typeof(IEInteropDM))]
    public class InteropDM : IInteropDM
    {
        private readonly DM dm;
        public InteropDM() : base()
        {
            dm = new DM();
        }

        public int Row { get => dm.Row; }
        public string Num { get => dm.Num; }
        public short Kod { get => dm.Kod; }
        public string Errors { get => dm.Errors; }
        public string Problems { get => dm.Problems; }
        public short Height { get => dm.Height; }
        public short Width { get => dm.Width; }
        public bool IsDobor { get => dm.IsDobor; }
        public short Dobor_Glubina { get => dm.Dobor_Glubina; }
        public short[] Dobor_Nalichnik { get => dm.Dobor_Nalichnik; }
        public Otkrivanie Otkrivanie { get => dm.Otkrivanie; }
        public short LicevoyList_OtPola { get => dm.LicevoyList_OtPola; }
        public short VnutrenniyList_OtPola { get => dm.VnutrenniyList_OtPola; }
        public bool IsPassivka { get => dm.IsPassivka; }
        public bool IsUpTShpingalet { get => dm.IsUpTShpingalet; }
        public bool IsDownTShpingalet { get => dm.IsDownTShpingalet; }
        public short VirezPodKvadrat_Count { get => dm.VirezPodKvadrat_Count; }
        public bool IsDownPritvor { get => dm.IsDownPritvor; }
        public bool IsPorogNestandart { get => dm.IsPorogNestandart; }
        public bool IsVipadPorog { get => dm.IsVipadPorog; }
        public double[] Dobor_Nalichnik_Razv { get => dm.Dobor_Nalichnik_Razv; }

        public short Dobor_Length(Raspolozhenie pos)
        {
            return dm.Dobor_Length(pos);
        }
        public Framuga Framuga(Raspolozhenie pos)
        {
            return dm.Framuga(pos);
        }
        public short HeightStoyki(Raspolozhenie pos)
        {
            return dm.HeightStoyki(pos);
        }
        public void Init(DMParam data)
        {
            dm.Init(data);
        }
        public bool IsFramuga(Raspolozhenie pos)
        {
            return dm.IsFramuga(pos);
        }
        public bool IsGND(short index)
        {
            return dm.IsGND(index);
        }
        public bool IsKabelKanal(short index)
        {
            return dm.IsKabelKanal(index);
        }
        public bool IsOkno(short num)
        {
            return dm.IsOkno(num);
        }
        public bool IsOtvetkaTorcShpin(Raspolozhenie pos)
        {
            return dm.IsOtvetkaTorcShpin(pos);
        }
        public bool IsReshetka(short num)
        {
            return dm.IsReshetka(num);
        }
        public double LicevoyList_Height(Stvorka stvorka)
        {
            return dm.LicevoyList_Height(stvorka);
        }
        public double LicevoyList_Width(Stvorka stvorka)
        {
            return dm.LicevoyList_Width(stvorka);
        }
        public short Nalichnik(Raspolozhenie pos)
        {
            return dm.Nalichnik(pos);
        }
        public string Name(short index)
        {
            return dm.Name(index);
        }
        public eReshetka Reshetka_Type(short num)
        {
            return dm.Reshetka_Type(num);
        }
        public short Stoyka_Type(Raspolozhenie pos)
        {
            return dm.Stoyka_Type(pos);
        }
        public double Stvorka_Height(Stvorka stvorka)
        {
            return dm.Stvorka_Height(stvorka);
        }
        public double Stvorka_Width(Stvorka stvorka)
        {
            return dm.Stvorka_Width(stvorka);
        }
        public double VnutrenniyList_Height(Stvorka stvorka)
        {
            return dm.VnutrenniyList_Height(stvorka);
        }
        public double VnutrenniyList_Width(Stvorka stvorka)
        {
            return dm.VnutrenniyList_Width(stvorka);
        }
    }
}
