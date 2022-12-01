using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject SubMenuImage, WindowImage, InventoryImage, WeaponInventoryImage, ExitImage;
    public GameObject FistBtn, SwordBtn, GunBtn;

    public Button[] OffButton;

    bool Sub, Wind = false;

    int Wea, ChangeInv = 0;

    public void SubOnOff()
    {
        Sub = !Sub;
        SubMenuImage.SetActive(Sub);
    }

    public void WindowOnOff()
    {
        Wind = !Wind;
        WindowImage.SetActive(Wind);
        for (int i = 0; i < OffButton.Length; i++)
        {
            OffButton[i].interactable = !Wind;
        }
        
    }

    public void WindowOff()
    {
        Wind = !Wind;
        WindowImage.SetActive(Wind);
    }

    public void ChangeInventory()
    {
        if (ChangeInv < 1)
        {
            ChangeInv++;
        }
        else
        {
            ChangeInv = 0;
        }
        if (ChangeInv == 0)
        {
            InventoryImage.SetActive(true);
            WeaponInventoryImage.SetActive(false);
        }
        if (ChangeInv == 1)
        {
            InventoryImage.SetActive(false);
            WeaponInventoryImage.SetActive(true);
        }
    }

    public void WeaponChangeBtn()
    {
        if (Wea < 2)
        {
            Wea++;
        }
        else
        {
            Wea = 0;
        }
        if (Wea == 0)
        {
            FistBtn.SetActive(true);
            SwordBtn.SetActive(false);
            GunBtn.SetActive(false);
        }
        else if (Wea == 1)
        {
            FistBtn.SetActive(false);
            SwordBtn.SetActive(true);
            GunBtn.SetActive(false);
        }
        else if (Wea == 2)
        {
            FistBtn.SetActive(false);
            SwordBtn.SetActive(false);
            GunBtn.SetActive(true);
        }
    }

    public void ExitImageOnBtn()
    {
        ExitImage.SetActive(true);
    }

    public void ExitImageOffBtn()
    {
        ExitImage.SetActive(false);
    }

    public void ExitBtn()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void StartBtn()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitBtn()
    {
        Application.Quit();
    }
}
