using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_Principles.SingleResponsibility
{
    interface IUser
    {
        bool Login(String username, String password);
        bool Register(String username, String password, string email);
        
        // So we have too much responsibilities in IUser 
        // Let's create two more interfaces and put there the 
        // other methods

        //bool SendEmail(string emailContent);
        //void LogError(string error);
    }

    interface ILogger
    {
        void LogError(string error);
    }

    interface IEmail
    {
        bool SendEmail(string emailContent);
    }
}
