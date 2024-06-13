using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Invertory : MonoBehaviour
{

    public TextMeshProUGUI recolectablesText;

    private int contador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Inventory()
    {
        contador++;
        recolectablesText.text = "objetos recolectados: " + contador;
    }

    private void OnEnable()
    {
        Collectible.colllectibleEvent += Inventory;
    }

    private void OnDisable()
    {
        Collectible.colllectibleEvent -= Inventory;
    }
}
