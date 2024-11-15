using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public ParticleSystem muzzleFlash;
    public static Action shootInput;
    public static Action reloadInput;

    [SerializeField] private KeyCode reloadKey = KeyCode.R;

    private void Start()
    {
        // Ensure the muzzle flash is stopped at the beginning
        muzzleFlash.Stop();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            shootInput?.Invoke();
            muzzleFlash.Play();
        }

        if (Input.GetKeyDown(reloadKey))
        {
            reloadInput?.Invoke();
        }
    }
}
