using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using CustomExtensions;

public class GameBehavior : MonoBehaviour, IManager
{
    public string labelText = "Collect all 4 items and win your freedom!";
    public int maxItems = 4;
    public bool showWinScreen = false;
    public bool showLossScreen = false;
    public Stack<string> lootStack = new Stack<string>();

    private int _itemsCollected = 0;
    private int _playerHP = 10;
    private string _state;


    public string State
    {
        get { return _state;  } 
        set { _state = value; }
    
    }


    public int Items
    {
        get { return _itemsCollected; }
        set 
        { 
            _itemsCollected = value;

            if (_itemsCollected >= maxItems)
            {
                labelText = "You've found all the items!";
                showWinScreen = true;
                Time.timeScale = 0f;
            }
            else
            {
                labelText = "Item found, only " + (maxItems - _itemsCollected) + " more to go!";
            }
        
        }
    }

    public int HP
    {
        get { return _playerHP; }
        set { 
            _playerHP = value;
            if(_playerHP <= 0)
            {
                labelText = "Wanna try again?";
                showLossScreen = true;
                Time.timeScale = 0;
            }
            else
            {
                labelText = "Ouch! that's gotta hurt";
            }
        }
    }

    private void Start()
    {
        Initialize();

        InvnetoryList<string> inventoryList = new InvnetoryList<string>();

        inventoryList.SetItem("Potion"); ;
        Debug.Log(inventoryList.item);
    }

    public void Initialize()
    {
        _state = "Manager Initialized..";
        Debug.Log(_state);
        _state.FancyDebug();

        debug(_state);

        LogWithDelegate(debug);

        lootStack.Push("Sword of doom");
        lootStack.Push("HP+");
        lootStack.Push("Golden Key");
        lootStack.Push("Winged Boot");
        lootStack.Push("Mythril Bracers");

        GameObject player = GameObject.Find("Player");
        PlayerBehavior playerBehavior = player.GetComponent<PlayerBehavior>();
        playerBehavior.playerJump += HandlePlayerJump;

    }

    public void HandlePlayerJump()
    {
        debug("Player has jumped");
    }
    public static void Print(string newText)
    {
        Debug.Log(newText);
    }

    public void LogWithDelegate(DebugDelegate del)
    {
        del("Delegating the debug task");
    }

    public void PrintLootReport()
    {
        var currentItem = lootStack.Pop();
        var nextItem = lootStack.Peek();

        Debug.LogFormat("You goy a {0}! you've got a good change of finding a {1} next!", currentItem, nextItem);

        Debug.LogFormat("There are {0} random loot items waiting for you!", lootStack.Count);
    }

    void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 150, 25), "Player Health:" + _playerHP);
        GUI.Box(new Rect(20, 50, 150, 25), "Items Collected:" + _itemsCollected);
        GUI.Box(new Rect(Screen.width/2 - 100, Screen.height- 50, 300, 50), labelText);

        if (showWinScreen)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "You WON!!"))
            {
                Utilities.RestartLevel(0);

            }
        }

        if (showLossScreen)
        {
            if(GUI.Button(new Rect(Screen.width / 2 -100, Screen.height / 2 -50, 200, 100), "You Lose..."))
            {
                try
                {
                    Utilities.RestartLevel(-1);
                    debug("Level restarted succesfully...");
                }
                catch (System.ArgumentException e)
                {
                    Utilities.RestartLevel(0);
                    debug("Restart to scene 0: " + e.ToString());
                }
                finally
                {
                    debug("Restart Handled");
                }
            }
        }
    }

    public delegate void DebugDelegate(string newText);

    public DebugDelegate debug = Print;
}
