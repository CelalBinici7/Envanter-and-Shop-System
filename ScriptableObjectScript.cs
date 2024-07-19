using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "car", menuName = "CarObject")]
public class ScriptableObjectScript : ScriptableObject
{
    public string cname;
    public shopObjectType type;
    public int id;
    public int price;
    public bool isUsing;
    public bool isBought;
    public Sprite image;
    public Sprite isUsingimage;
    public Sprite isNotsUsingimage;
    public GameObject existPrefab;
    public GameObject uiPrefab;
    public GameObject carObject;
    public GameObject carShopObject;
    public int maxSpeed;
    public int acceleration;
}


[CreateAssetMenu(fileName = "Weapon", menuName = "WeaponObject")]
public class ScriptableObjectScript2 : ScriptableObject
{
    public string wname;
    public shopObjectType type;
    public int id;
    public int price;
    public bool isBought;
    public bool isUsing;
    public Sprite image;
    public Sprite isUsingimage;
    public Sprite iNotsUsingimage;
    public GameObject existPrefab;
    public GameObject weaponObject;
    public GameObject uiPrefab;
    public int damage;

}

[CreateAssetMenu(fileName = "Character", menuName = "CharacterObject")]
public class ScriptableObjectScript3 : ScriptableObject
{
    public string chname;
    public shopObjectType type;
    public int id;
    public int price;
    public bool isUsing;
    public Sprite image;
    public GameObject existPrefab;
    public GameObject uiPrefab;
    public int health;
    public int speed;
}