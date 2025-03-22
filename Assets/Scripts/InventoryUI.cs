using UnityEngine;
using TMPro;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    private TextMeshProUGUI sphereText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sphereText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateSphereText(PlayerInventory playerInventory)
    {
        sphereText.text = playerInventory.NumberOfSpheres.ToString(); 
    }

   
}
