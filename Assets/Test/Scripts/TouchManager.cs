using TMPro;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    public EffectManager effectManager;
    public TextMeshProUGUI touchState;

    public void UpdateTouchState(bool isTouching)
    {
        if (isTouching)
        {
            touchState.text = "Touching";
            touchState.color = Color.red;

            if (effectManager != null)
            {
                
                effectManager.TriggerEffect(true); 
            }
        }
        else
        {
            touchState.text = "Not Touching";
            touchState.color = Color.white;

            if (effectManager != null)
            {

                effectManager.TriggerEffect(false);
            }
        }
    }

}
