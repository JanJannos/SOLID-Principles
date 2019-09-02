using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_Principles.InterfaceSegregation
{

    /**
     * The problem is that the client don't need to implement
     * all the methods below , so we'll create Interfaces for them
     */

    public interface IPrintTask
    {
        bool PrintContent(String content);
        bool ScanContent(String content);
        bool FaxContent(String content);
        bool PhotoCopyContent(String content);
        bool PrintDuplexContent(String content);
    }

    
}
