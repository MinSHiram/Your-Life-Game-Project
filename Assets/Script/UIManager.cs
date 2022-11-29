using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject SubMenuImage, WindowImage, InventoryImage, WeaponInventoryImage;

    bool Sub, Wind, Inv, WeaponInv = false;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SubOnOff()
    {
        Sub = !Sub;
        SubMenuImage.SetActive(Sub);
    }

    public void WindowOnOff()
    {
        Wind = !Wind;
        InventoryImage.SetActive(Wind);
    }

    public void ChangeInventory()
    {
        Inv = !WeaponInv;
        WeaponInv = !Inv;
        InventoryImage.SetActive(Inv);
        WeaponInventoryImage.SetActive(WeaponInv);
    }

    public void QuitBtn()
    {
        Application.Quit();
    }
}
