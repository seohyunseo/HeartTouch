using System.Collections;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    public Material outlineMaterial;
    public Animation heartbeatAnim;

    [Header("Effect Settings")]
    [Range(0f, 1f)] public float outlineThickness = 0.005f;

    [Header("Parameter for test")]
    [Range(0f, 200f)] public float bpm = 60f;

    public void TriggerEffect(bool isTouching)
    {
        //if (isTouching)
        //{
        //    SetOutlineEffect(bpm);
        //    //SetImageEffect(bpm);
        //}
        //else
        //{
        //    ResetOutlineEffect();
        //    //ResetImageEffect();
        //}
    }

    private void SetOutlineEffect(float bpm)
    {
        float outlinePulse = bpm * Mathf.PI / 30f;

        if (outlineMaterial != null)
        {
            outlineMaterial.SetFloat("_Outline_Thickness", 0.005f);
            outlineMaterial.SetFloat("_Outline_Pulse", outlinePulse);
        }
    }

    private void ResetOutlineEffect()
    {
        if (outlineMaterial != null)
        {
            outlineMaterial.SetFloat("_Outline_Thickness", 0f);
            outlineMaterial.SetFloat("_Outline_Pulse", 0f);
        }
    }

    private void SetImageEffect(float bpm)
    {
        heartbeatAnim.gameObject.SetActive(true);
        heartbeatAnim["HeartBeat"].speed = bpm / 60f;
        heartbeatAnim["HeartBeat"].wrapMode = WrapMode.Loop;
        heartbeatAnim.Play("HeartBeat");
    }

    private void ResetImageEffect()
    {
        heartbeatAnim.gameObject.SetActive(false);
        heartbeatAnim["HeartBeat"].wrapMode = WrapMode.Once;
        heartbeatAnim.Stop("HeartBeat");
    }


    private void OnDestroy()
    {
        ResetOutlineEffect();
    }
}
