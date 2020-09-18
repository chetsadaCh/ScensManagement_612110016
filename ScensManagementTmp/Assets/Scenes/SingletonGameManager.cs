using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonGameManager : Singleton<SingletonGameManager>
{
    protected SingletonGameManager() { }
   
    public string ClassName { get; } = "SingletonGameManager";
    public string playername { get; set; } = "Jade";
    public int GameScore { get; set; } = 0;
    
}
