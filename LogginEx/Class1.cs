using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace LogginEx
{
    public class Class1
    {
        public void WriteDown()
        {
            var enviromentConstants = new EnvironmentConstants();
            string objectSerialized  = JsonSerializer.Serialize(enviromentConstants);
            File.WriteAllText("EnviromentConstants.json", objectSerialized);
        } 
    }
}
