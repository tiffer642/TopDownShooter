using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootONClick : MonoBehaviour
{
    //Projectile
    public GameObject Projectile;

    //spawnpos
    public Transform SpawnPos;

    //Rate of Fire
    public float ROF = 1.5f;
    private bool CanFire = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && CanFire)
        {
            CanFire = false;
            FireProjectile();
        }
    }

    public void FireProjectile()
    {
        var I = Instantiate(Projectile, SpawnPos.position, transform.rotation);
        StartCoroutine(ReChamber());
    }

    IEnumerator ReChamber()
    {
        yield return new WaitForSeconds(ROF);
        CanFire = true;
    }


}
