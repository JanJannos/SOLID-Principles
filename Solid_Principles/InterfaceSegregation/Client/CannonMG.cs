using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_Principles.InterfaceSegregation.Client
{
    public class CannonMG : IPrintTask
    {
        public bool PrintContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool ScanContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool FaxContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PhotoCopyContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PrintDuplexContent(string content)
        {
            throw new NotImplementedException();
        }
    }
}
