using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Interaccion()
    {
        Debug.Log("Interaccion con NPC");
    }

    private void OnEnable()
    {
        NPC.npcInteract += Interaccion;
    }

    private void OnDisable()
    {
        NPC.npcInteract -= Interaccion;
    }
}
