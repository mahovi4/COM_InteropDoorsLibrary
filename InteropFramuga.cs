using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace COM_InteropDoorsLibrary
{
    [Guid("4D6D0BED-CB7A-43B2-8FBA-C32437D59805")]
    public interface IInteropFramuga : IFramuga { }
    [Guid("A4C7AFC1-BB72-4D0B-A045-BDC4A8656F0B"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IEInteropFramuga : IEFramuga { }
    [Guid("229038DC-2154-4FC8-9200-D51FF39298B8"), ClassInterface(ClassInterfaceType.None), ComSourceInterfaces(typeof(IEInteropFramuga))]
    public class InteropFramuga : IInteropFramuga
    {
        private readonly Framuga fr;
        public InteropFramuga() : base()
        {
            fr = new Framuga();
        }

        public string Num { get => fr.Num; }
        public string Errors { get => fr.Errors; }
        public string Problems { get => fr.Problems; }
        public short TorcZaglushka_Length { get => fr.TorcZaglushka_Length; }
        public short TorcZaglushka_Width { get => fr.TorcZaglushka_Width; }
        public short Zprofil_Razvertka { get => fr.Zprofil_Razvertka; }
        public short Porog_Razvertka { get => fr.Porog_Razvertka; }
        public short Steklo_Hight { get => fr.Steklo_Hight; }
        public short Steklo_Width { get => fr.Steklo_Width; }

        public void Init(FramugaParam param, bool VM)
        {
            fr.Init(param, VM);
        }
        public double List_Height(short pos)
        {
            return fr.List_Height(pos);
        }
        public double List_Width(short pos)
        {
            return fr.List_Width(pos);
        }
        public short Nalichnik_Length(Raspolozhenie pos)
        {
            return fr.Nalichnik_Length(pos);
        }
        public short Nalichnik_Razvertka(Raspolozhenie pos)
        {
            return fr.Nalichnik_Razvertka(pos);
        }
        public short Stoyka_Length(Raspolozhenie pos)
        {
            return fr.Stoyka_Length(pos);
        }
        public short Stoyka_Type(Raspolozhenie pos)
        {
            return fr.Stoyka_Type(pos);
        }
        public short Zprofil_Length(Raspolozhenie pos)
        {
            return fr.Zprofil_Length(pos);
        }
    }
}
