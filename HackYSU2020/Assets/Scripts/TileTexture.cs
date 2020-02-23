using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileTexture : MonoBehaviour
{

    private Renderer _re;
    
    // Start is called before the first frame update
    void Start()
    {
        _re = this.gameObject.GetComponent<Renderer>();

        var localScale = this.transform.localScale;
        _re.material.mainTextureScale = new Vector2(localScale.x, localScale.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
