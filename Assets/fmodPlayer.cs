using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fmodPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void JumpingSFX()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/sfx/jump", transform.position);
    }
}
