using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class LevelDisplay : MonoBehaviour
{
    public TextMeshProUGUI levelText;
    private int contador;

    private void OnEnable()
    {
        // Suscribirse al evento de cambio de nivel
        LevelManager.levelChange += UpdateLevelDisplay;
    }

    private void OnDisable()
    {
        // Desuscribirse del evento de cambio de nivel
        LevelManager.levelChange -= UpdateLevelDisplay;
    }

    void UpdateLevelDisplay()
    {

        contador++;
        levelText.text = "Nivel: " + contador;
    }

}
