using UnityEngine;
using System.Collections.Generic;

public class Main : MonoBehaviour
{
	//temporary initial class for prototype purpose
	public NGraphic.GraphicManager gManager;
	NWorld.World world;
	NGame.PlayerManager pManager;
	Dictionary<KeyCode,Vector3> dicMove;

	//for testing purpose, remove the following later
	NWorld.NEntity.Entity tailEnd;

	void Awake(){
		dicMove = new Dictionary<KeyCode, Vector3> (){
			{KeyCode.A, new Vector2(-1,0) },
			{KeyCode.D, new Vector2(1,0) },
			{KeyCode.W, new Vector2(0,1) },
			{KeyCode.S, new Vector2(0,-1) }
		};
		world = new NWorld.World (10,10);
		pManager = new NGame.PlayerManager ();
	
		gManager.Init(world);
		pManager.Init (world, 0, 0);
		AwakeTest ();
	}
	// for testing purpose remove later
	void AwakeTest(){
		
		tailEnd = pManager.entity; 
	}
	void Start(){
	}

	void LinkEvents(NWorld.World world){
	}

	void Update(){
		foreach(var pair in dicMove){
			if(Input.GetKeyDown(pair.Key) ) {
				pManager.MovePlayer(world, (int)pair.Value.x, (int)pair.Value.y);
			}
		}
		UpdateTest ();
	}
	// FTP(For Testing Purpose)
	void UpdateTest(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			var tailNew = new NWorld.NEntity.Tail(0,0,this.tailEnd);
			this.tailEnd = tailNew;
			this.world.AddEntity(tailNew);
		}
	}
}

