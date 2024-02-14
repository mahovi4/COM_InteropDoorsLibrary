using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace COM_InteropDoorsLibrary
{
    [Guid("0C36EA20-5CE7-4ECA-89D5-B697F88EF9F5")]
    public interface IInteropCtor : IConstructor { }
    [Guid("AB7FEF8E-C6A9-4D75-87D7-4860126F604D"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IEInteropCtor : IEConstructor { }
    [Guid("1B7409BE-FCDA-47A8-BEDD-1B3856D26B2E"), ClassInterface(ClassInterfaceType.None), ComSourceInterfaces(typeof(IEInteropCtor))]
    public class InteropCtor : IInteropCtor
    {
        private readonly Constructor ctor;
        public InteropCtor() : base()
        {
            ctor = new Constructor();
        }

        public DM[] DMs
        {
            get
            {
                return ctor.DMs;
            }
        }
        public LM[] LMs
        {
            get
            {
                return ctor.LMs;
            }
        }
        public DVM[] VMs 
        {
            get
            {
                return ctor.VMs;
            }
        }
        public ODL[] ODLs 
        {
            get
            {
                return ctor.ODLs;
            }
        }
        public Framuga[] Framugs 
        {
            get
            {
                return ctor.Framugs;
            }
        }

        public string Add(TableData param)
        {
            return ctor.Add(param);
        }
        public short AddFromFile(string fileName)
        {
            return ctor.AddFromFile(fileName);
        }
        public string CheckingForErrors(TableData param)
        {
            return ctor.CheckingForErrors(param);
        }
        public string CheckingForProblems(TableData param)
        {
            return ctor.CheckingForProblems(param);
        }
        public DM GetDMByNum(string num)
        {
            return ctor.GetDMByNum(num);
        }
        public short GetDMIndexByNum(string num)
        {
            return ctor.GetDMIndexByNum(num);
        }
        public Framuga GetFrByNum(string num)
        {
            return ctor.GetFrByNum(num);
        }
        public short GetFrIndexByNum(string num)
        {
            return ctor.GetFrIndexByNum(num);
        }
        public LM GetLMByNum(string num)
        {
            return ctor.GetLMByNum(num);
        }
        public short GetLMIndexByNum(string num)
        {
            return ctor.GetLMIndexByNum(num);
        }
        public ODL GetODLByNum(string num)
        {
            return ctor.GetODLByNum(num);
        }
        public short GetODLIndexByNum(string num)
        {
            return ctor.GetODLIndexByNum(num);
        }
        public DVM GetVMByNum(string num)
        {
            return ctor.GetVMByNum(num);
        }
        public short GetVMIndexByNum(string num)
        {
            return ctor.GetVMIndexByNum(num);
        }
        public bool Remove(string num)
        {
            return ctor.Remove(num);
        }
        public TableData[] TDatasInFile(string fileName)
        {
            return ctor.TDatasInFile(fileName);
        }
    }
}
