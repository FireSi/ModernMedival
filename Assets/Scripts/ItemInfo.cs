
using UnityEngine;
[System.Serializable]
public class ItemInfo 
{
    public string Name;
    public string Description;
    public GameObject link;

    public ItemInfo(string name, string description, GameObject link)
    {
        Name = name;
        Description = description;
        this.link = link;
    }   
}
