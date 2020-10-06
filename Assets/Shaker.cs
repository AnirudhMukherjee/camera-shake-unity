using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaker : MonoBehaviour
{
    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;
        float timeElapsed = 0.0f;
        

        while (timeElapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;
            //Generate random x,y values and shake the camera based on the same
            transform.localPosition = new Vector3(x, y, originalPos.z);
            timeElapsed += Time.deltaTime;

            //Wait for the next frame before running the loop once again
            yield return null;

        }
        //Return to original Camera position
        transform.localPosition = originalPos;
    }
}
