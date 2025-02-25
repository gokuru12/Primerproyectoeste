using UnityEngine;

public class ClickLink : MonoBehaviour
{
    [SerializeField] string link;
    public GameObject imagenInterfaz;
    public GameObject[] objetos;
    public GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnMouseDown()
    {
        // Llamar a SetActiveObjetos con el valor 'false' para desactivar los objetos
        SetActiveObjetos(false);

        // Alternar el estado de imagenInterfaz
        if (imagenInterfaz.activeSelf)
        {
            imagenInterfaz.SetActive(false);  // Si ya está activa, desactivarla
        }
        else
        {
            imagenInterfaz.SetActive(true);   // Si está desactivada, activarla
        }
    }

    public void SetActiveObjetos(bool value)
    {
        // Cambiar el estado de todos los objetos en el arreglo 'objetos'
        foreach (GameObject obj in objetos)
        {
            obj.SetActive(value);
        }
    }

    public void DesactivarImagen()
    {
        imagenInterfaz.SetActive(false);
        //Necesito que esta función vuelva a activar el arreglo de objetos
        SetActiveObjetos(true);
        gameManager.desactivarinterfacez();
    }
}
