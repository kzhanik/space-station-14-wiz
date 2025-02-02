using Robust.Shared.GameStates;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;

namespace Content.Shared.Sound.Components;

[RegisterComponent, NetworkedComponent]
public sealed class EmitSoundOnCollideComponent : BaseEmitSoundComponent
{
    public static readonly TimeSpan CollideCooldown = TimeSpan.FromSeconds(0.2);

    /// <summary>
    /// Minimum velocity required for the sound to play.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite), DataField("minVelocity")]
    public float MinimumVelocity = 0.25f;

    /// <summary>
    /// To avoid sound spam add a cooldown to it.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite), DataField("nextSound", customTypeSerializer:typeof(TimeOffsetSerializer))]
    public TimeSpan NextSound;
}
