using UnityEngine;
//using System.Collections;
using UnityEngine.Networking;

public class MenuControl : MonoBehaviour
{

    public void StartLocalGame()
    {
        NetworkManager.singleton.StartHost();
    }

    public void JoinLocalGame()
    {
        if (hostNameInputIP.text != "Hostname")
        {
            NetworkManager.singleton.networkAddress = hostNameInputIP.text;
        }
        NetworkManager.singleton.StartClient();
    }

    public void StartMatchMaker()
    {
        NetworkManager.singleton.StartMatchMaker();
    }

    public UnityEngine.UI.Text hostNameInputIP;


    void Start()
    {
        hostNameInputIP.text = NetworkManager.singleton.networkAddress;

    }

}
