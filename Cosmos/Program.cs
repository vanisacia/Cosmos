using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CosmosLib;
namespace Cosmos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CosmoProgram> prog = new List<CosmoProgram>();
            CosmoProgram cp = new CosmoProgram();
            cp.CosmoID = 1;
            cp.Name = "GDSPAF";

            List<CosmosProgramData> p = new List<CosmosProgramData>
            {
                new CosmosProgramData
                {
                    CategoryName = "Memory Infor",
                    CategoryValue="23er"
                },
                new CosmosProgramData
                {
                    CategoryName = "DSP",
                    CategoryValue="3453"
                }
               
            };

            cp.Data = p;
            prog.Add(cp);
            Cosmo.CreateProgram(prog);
        }
    }
}
