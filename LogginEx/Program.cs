using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace LogginEx
{
    public class Program
    {
        public void LoginAsUser_Standart_Logined()
        {
            EnviromentConstantWriter enviromentConstantWriter = new EnviromentConstantWriter();
            enviromentConstantWriter.WriteDown();
        }
    }
}
