using System.IO;

namespace OMP.LSWTSS;

public static class GetCFuncHook1DistDirPath
{
    public static string Execute()
    {
        return Path.Combine(
            GetDistDirPath.Execute(),
            "c-func-hook1"
        );
    }
}