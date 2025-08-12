using UnityEngine;

public class TouchTrigger : MonoBehaviour
{
    public TouchManager touchManager;
    private bool isTouching = false;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Touch_Hand"))
        {
            isTouching = true;

            if (touchManager != null)
            {
                touchManager.UpdateTouchState(isTouching);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Touch_Hand"))
        {
            isTouching = false;
        }

        if (touchManager != null)
        {
            touchManager.UpdateTouchState(isTouching);
        }
    }
}
