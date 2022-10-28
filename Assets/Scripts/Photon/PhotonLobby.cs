using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class PhotonLobby : MonoBehaviourPunCallbacks
{
    public static PhotonLobby lobby;
    public GameObject battleButton;
    public GameObject cancleBUutton;
    void Awake()
    {
        lobby = this;
    }
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

  public override void OnConnectedToMaster() 
    {
        Debug.Log("Player has Connected to Master Server");
        battleButton.SetActive(true);
       
    }

    public void OnBattleButton()
    {
        battleButton.SetActive(false);
        cancleBUutton.SetActive(true);
        PhotonNetwork.JoinRandomRoom();

    }
    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log("Tried to join a random Room nut failed");
        CreateRoom();
    }
    void CreateRoom()
    {
        int randomRoomName = Random.Range(0, 10000);
        RoomOptions roomOps = new RoomOptions() { IsVisible = true, IsOpen = true };
        PhotonNetwork.CreateRoom("Room" + randomRoomName, roomOps);
    }
  public override void OnJoinedRoom()
    {
        Debug.Log("JoinedRoom");
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Tried to Create a new Room but failed");
        CreateRoom();
    }
    public void OnCancleButton()
    {
        battleButton.SetActive(true);
        cancleBUutton.SetActive(false);
        PhotonNetwork.LeaveRoom();
    }

}
