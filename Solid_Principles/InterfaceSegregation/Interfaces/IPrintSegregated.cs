using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_Principles.InterfaceSegregation.Interfaces
{
    public interface IPrintScanContent
    {
        bool PrintContent(String content);
        bool ScanContent(String content);
        bool PhotoCopyContent(String content);
    }

    public interface FaxContent
    {
        bool FaxContent(String content);
    }

    public interface IPrintDuplex
    {
        bool PrintDuplexContent(String content);

    }
}
