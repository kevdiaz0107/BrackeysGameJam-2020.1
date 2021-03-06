﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMODSkeleton : MonoBehaviour
{
    void PlayFootsteps(string path)
    {
        FMOD.Studio.EventInstance Footsteps = FMODUnity.RuntimeManager.CreateInstance(path);
        Footsteps.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));
        Footsteps.start();
        Footsteps.release();
    }
    void PlayRanged(string path)
    {
        FMOD.Studio.EventInstance Ranged = FMODUnity.RuntimeManager.CreateInstance(path);
        Ranged.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));
        Ranged.start();
        Ranged.release();
    }
    void PlayDamage(string path)
    {
        FMOD.Studio.EventInstance Damage = FMODUnity.RuntimeManager.CreateInstance(path);
        Damage.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));
        Damage.start();
        Damage.release();
    }
    void PlayDeath(string path)
    {
        FMOD.Studio.EventInstance Death = FMODUnity.RuntimeManager.CreateInstance(path);
        Death.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));
        Death.start();
        Death.release();
    }
}
