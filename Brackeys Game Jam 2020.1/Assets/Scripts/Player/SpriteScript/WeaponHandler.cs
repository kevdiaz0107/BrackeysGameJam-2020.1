﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : MonoBehaviour
{
    public SpriteRenderer weaponSpriteRenderer;
    public GameObject groundPortal;

    public void HideWeapon()
    {
        weaponSpriteRenderer.enabled = false;
    }

    public void ShowWeapon()
    {
        weaponSpriteRenderer.enabled = true;
    }

    public void HidePortal()
    {
        groundPortal.SetActive(false);
    }

    public void ShowPortal()
    {
        groundPortal.SetActive(true);
    }
}
