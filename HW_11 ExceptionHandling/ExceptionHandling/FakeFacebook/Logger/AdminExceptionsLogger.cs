using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FakeFacebook.Logger
{
    class AdminExceptionsLogger
    {
        private string FilePath { get; set; } = @"D:\Ognen\SEDC\C#\DOMASNI C#\HW_11 Exception\ExceptionHandling\AdminExceptionLogger.txt";
        public void LogException(Exception ex)
        {
            StreamWriter sw = new StreamWriter(FilePath);
            sw.WriteLine($"{ex.GetType().Name} {ex.Message} {ex.StackTrace}");
            sw.Close();
        }
    }
}
