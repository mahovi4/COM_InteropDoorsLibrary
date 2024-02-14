using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace COM_InteropDoorsLibrary
{
    [Guid("707FBAFF-0024-4585-86E4-1D60505EC962")]
    public interface IInteropLM : ILM { }
    [Guid("8D68821F-358B-4FF2-A87C-0A77F3C5AA52"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IEInteropLM : IELM { }
    [Guid("2D484DE3-3319-4356-8104-8790B3F34EEF"), ClassInterface(ClassInterfaceType.None), ComSourceInterfaces(typeof(IEInteropLM))]
    public class InteropLM : IInteropLM
    {
        private readonly LM lm;
        public InteropLM() : base()
        {
            lm = new LM();
        }

        public int Row { get => lm.Row; }
        public string Num { get => lm.Num; }
        public string Errors { get => lm.Errors; set => lm.Errors = value; }
        public string Problems { get => lm.Problems; set => lm.Problems = value; }
        public short Kod { get => lm.Kod; }
        public short Height { get => lm.Height; }
        public short Width { get => lm.Width; }
        public Otkrivanie Otkrivanie { get => lm.Otkrivanie; }
        public bool IsPassivka { get => lm.IsPassivka; }
        public short LicevoyList_Height { get => lm.LicevoyList_Height; }
        public short VnutrenniyList_Height { get => lm.VnutrenniyList_Height; }
        public short Zamok_Kod { get => lm.Zamok_Kod; }
        public short Ruchka_Kod { get => lm.Ruchka_Kod; }
        public short Zadvizhka_Kod { get => lm.Zadvizhka_Kod; }
        public ZamokDatas Zamok { get => lm.Zamok; }
        public ZadvizhkaDatas Zadvizhka { get => lm.Zadvizhka; }

        public void Init(DMParam data)
        {
            lm.Init(data);
        }
        public short LicevoyList_Width(Stvorka stvorka)
        {
            return lm.LicevoyList_Width(stvorka);
        }
        public string Name(short index)
        {
            return lm.Name(index);
        }
        public short Stoyka_Height(Raspolozhenie pos)
        {
            return lm.Stoyka_Height(pos);
        }
        public double Stoyka_Razvertka(Raspolozhenie pos)
        {
            return lm.Stoyka_Razvertka(pos);
        }
        public short Stvorka_Width(Stvorka stvorka)
        {
            return lm.Stvorka_Width(stvorka);
        }
        public short VnutrenniyList_Width(Stvorka stvorka)
        {
            return lm.VnutrenniyList_Width(stvorka);
        }
    }
}
