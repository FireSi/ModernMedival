
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InventoryOpner : MonoBehaviour
{
    public GameObject UILink, OBJspawner, gamerCamera;

    public List<ItemInfo> ObjectInfo = new();
    public TextMeshProUGUI OBJname, OBJdescription;

    private int TempID=256;

    public void CloseMyself()
    {
        OBJname.text = "";
        OBJdescription.text = "";
        OBJspawner.gameObject.SetActive(false);
        UILink.SetActive(false);
    }

    public void ObjSelected(int id)
    {
        TempID = id;
        OBJname.text = ObjectInfo[id].Name;
        OBJdescription.text = ObjectInfo[id].Description;
        OBJspawner.SetActive(true);
    }

    public void ObjSpawn()
    {
        Instantiate(ObjectInfo[TempID].link, new Vector3(0, 0, ((gamerCamera.transform.position.z) + 10)), Quaternion.identity);
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&&Input.GetKey(KeyCode.LeftShift))
        {
            UILink.SetActive(true);
        }
    }
}


