namespace Sweeft.Enums;

public sealed class GenderEnum : SmartEnum<GenderEnum>
{
    public static readonly GenderEnum Male = new GenderEnum(nameof(Male), 1);
    public static readonly GenderEnum Female = new GenderEnum(nameof(Female), 2);
    public static readonly GenderEnum Other = new GenderEnum(nameof(Other), 3);

    private GenderEnum(string name, int value) : base(name, value)
    {
    }
}
