using System.Collections.Generic;

namespace OMP.LSWTSS.CApi1;

public sealed class RawClassSchema : IRawClassSchema
{
    public required string? Namespace { get; set; }

    public required string Name { get; set; }

    public required ClassRefSchema? ParentClassRef { get; set; }

    public required uint NativeDataSize { get; set; }

    public required List<ClassFieldSchema>? Fields { get; set; }

    public required List<IClassMethodSchema> Methods { get; set; }
}