using OSIsoft.AF.Asset;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AFTransfer_Reference
{
    [Description("AFTransferReference; Creates AFTransfer frames")]
    [Guid("9C71029E-D00F-4047-98D4-05BCCA3D0161")]
    public class AFTransferReference : AFDataReference
    {
        public override Type EditorType => typeof(Configuration);
        public override AFDataReferenceMethod SupportedMethods =>
            AFDataReferenceMethod.SetValue |
            AFDataReferenceMethod.GetValue |
            AFDataReferenceMethod.GetValues;

        public override AFDataReferenceContext SupportedContexts => AFDataReferenceContext.Time | AFDataReferenceContext.TimeRange;

        public override void SetValue(object context, AFValue newValue)
        {
            base.SetValue(context, newValue);
        }
        public override string ConfigString
        {
            get
            {
                return "";
            }
            set
            {

                SaveConfigChanges();  // save the change to PI AF Server

            }
        }
    }
}