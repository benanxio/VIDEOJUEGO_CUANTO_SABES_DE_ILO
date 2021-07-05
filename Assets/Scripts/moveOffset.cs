using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOffset : MonoBehaviour
{
    private Material materialActual;
    public float velocidad;
    private float offset;
    // Start is called before the first frame update
    void Start()
    {
        materialActual = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        offset += 0.001f;
        materialActual.SetTextureOffset("_MainTex", new Vector2(offset * velocidad, 0));
    }
}
