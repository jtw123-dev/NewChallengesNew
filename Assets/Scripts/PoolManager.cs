using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PoolManager : MonoSingleton<PoolManager>
{
    [SerializeField] private GameObject _bulletContainer;
    [SerializeField] private List<GameObject> _bullets;
    [SerializeField] private GameObject _bulletPrefab;

    // public void GenerateBullets()
    /// {
    //  foreach(var bullet in _bullets)
    //  {
    //     Instantiate(bullet, transform.position, Quaternion.identity);
    //   }
    //  }

    private void Start()
    {
        _bullets = BulletGenerator(10);
    }

    private List <GameObject> BulletGenerator(int amountOfBullets)
    {
        for (int i =0; i<amountOfBullets;i++)
        {
            GameObject bullet = Instantiate(_bulletPrefab);
            bullet.transform.parent = _bulletContainer.transform;
            _bullets.Add(bullet);
            bullet.SetActive(false);
        }     
        return _bullets;
    }

    public GameObject RequestBullet() //make gameobject method to keep reference to bullet
    {     
        foreach(var bullet in _bullets)
        {
            if(bullet.activeInHierarchy==false)
            {
                bullet.SetActive(true);
                return bullet;
            }
        }
        GameObject newBullet = Instantiate(_bulletPrefab);
        newBullet.transform.parent = _bulletContainer.transform;
        _bullets.Add(newBullet);
        return newBullet;
       /* for (int i =_bullets.Count-1;i>=0;i--)
        {
            var unit = _bullets[i];
            if (unit.activeSelf==false)
            {
                unit.SetActive(true);
            }
            else if (unit.activeSelf==true)
            {
                BulletGenerator(1);
            }
        }*/
        /* foreach(var bullet in _bullets.ToArray())
         {
             if (bullet.activeSelf==false)
             {
                 bullet.SetActive(true);//return to player               
             }
             else if (bullet.activeSelf==true)
            {          
                 BulletGenerator(1);
            }
         }*/
    }
}
