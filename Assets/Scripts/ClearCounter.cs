using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;
    public void Interact()
    {
        Debug.Log("Interact!");
        Transform KitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
        KitchenObjectTransform.localPosition = Vector3.zero;

        Debug.Log(KitchenObjectTransform.GetComponent<KitchenObject>().GetKitchenObjectSO().objectName);
    }
}
