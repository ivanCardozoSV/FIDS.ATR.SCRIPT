using Config2Json;
using McMaster.Extensions.CommandLineUtils;
using System;
using System.Threading.Tasks;

namespace FIDS.ATR.SCRIPT.Core
{
    public class IvanCustomCore
    {
        public static async Task<int> IvansRunCustom(string[] args)
        {
            try
            {
                return await CommandLineApplication.ExecuteAsync<Migrator>(args);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Error.WriteLine("Unexpected error: " + ex.ToString());
                Console.ResetColor();
                return -1;
            }
        }
    }
}
