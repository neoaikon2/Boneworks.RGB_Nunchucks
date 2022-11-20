using System;
using MelonLoader;
using ModThatIsNotMod.MonoBehaviours;

namespace NunchakuMod
{
    public class NunchakuLoader : MelonMod
    {
        public override void OnInitializeMelon()
        {
#if DEBUG
            MelonLogger.Msg("Injecting NunchakuManager class...");
#endif
            CustomMonoBehaviourHandler.RegisterMonoBehaviourInIl2Cpp<NunchakuManager>();
#if DEBUG
            MelonLogger.Msg("Success!");
#endif
        }
    }
}