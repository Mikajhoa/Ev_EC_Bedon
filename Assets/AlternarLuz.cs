using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ToggleLuz : MonoBehaviour
{
    public Light luz;
    public void Alternar() { luz.enabled = !luz.enabled; }
}