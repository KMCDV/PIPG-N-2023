using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using DG.Tweening;
using UnityEngine.Rendering.HighDefinition;

public class DotweenMexicoTransition : MonoBehaviour
{

    public VolumeProfile volumeProfile;


    // Start is called before the first frame update
    void Start()
    {
        DOVirtual.Float(0, 100, 2f, UpdatePost).SetLoops(-1, LoopType.Yoyo);
    }

    private void UpdatePost(float x)
    {
        if(volumeProfile.TryGet(out WhiteBalance whiteBalance))
        {
            whiteBalance.temperature.Override(x);
        }
    }

}
