using System.Collections.Generic;

namespace OMP.LSWTSS.CApi1;

public sealed class GlobalNativeFuncSchema : IGlobalNativeFuncSchema
{
    public required string Name { get; set; }

    public required string? Namespace { get; set; }

    public required uint? SteamOffset { get; set; }

    public required uint? EGSOffset { get; set; }

    public required List<IFuncParamSchema> Params { get; set; }

    public required ITypeSchema? ReturnType { get; set; }
}