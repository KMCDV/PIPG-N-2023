using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DotweenAnimation : MonoBehaviour
{

    public AnimationCurve curve;
    public MeshRenderer meshRenderer;

    void Start()
    {
        transform.DOMoveY(5f, 1f)
            .SetRelative(true)
            .SetLoops(-1, LoopType.Yoyo)
            .OnStepComplete(foo)
            .SetEase(Ease.InOutElastic);

        transform.DORotate(new Vector3(0, 360, 0), 2f, RotateMode.LocalAxisAdd).SetLoops(-1);
        meshRenderer.material.DOColor(Color.red, 2f).SetLoops(-1, LoopType.Yoyo);
    }

    public void foo()
    {
        Debug.Log("TestESt");
    }
}
