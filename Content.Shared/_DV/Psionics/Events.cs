using Content.Shared.DoAfter;
using Robust.Shared.Serialization;

namespace Content.Shared.Psionics.Events;

[Serializable, NetSerializable]
public sealed partial class PrecognitionDoAfterEvent : SimpleDoAfterEvent;

[Serializable, NetSerializable]
public sealed partial class GlimmerWispDrainDoAfterEvent : SimpleDoAfterEvent;

[Serializable, NetSerializable]
public sealed partial class MassSleepDoAfterEvent : SimpleDoAfterEvent;

[Serializable, NetSerializable]
public sealed partial class PsionicEruptionDoAfterEvent : SimpleDoAfterEvent;
