using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMaterial : MonoBehaviour
{
    private Color[] colors = new Color[] { Color.green, Color.red, Color.blue };
    private IEnumerator Start()
    {
        int i = 0;

        while (true)
        {
            GetComponent<Renderer>().material.color = colors[i];
            i++;

            if (i == colors.Length)
            {
                i = 0;
            }

            // Pausamos el método durante dos segundos
            yield return new WaitForSeconds(2f);
        }
    }
}