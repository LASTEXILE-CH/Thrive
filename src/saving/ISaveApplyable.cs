/// <summary>
///   Interface for types that need to be freshly created on loading a save but
///   can apply the state of a save loaded object
/// </summary>
public interface ISaveApplyable
{
    bool IsLoadedFromSave { get; set; }

    void ApplySave(object loaded, ISaveContext context);
}
