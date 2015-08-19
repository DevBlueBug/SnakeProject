using UnityEngine;
using System.Collections;

namespace NGame{

	public class PlayerManager
	{
		public NWorld.NEntity.Entity entity;
		public PlayerManager(){
		}
		public PlayerManager Init(NWorld.World world,int x,int y){
			this.entity = new NWorld.NEntity.Entity (x,y);
			world.AddEntity (entity);
			return this;
		}
		public void MovePlayer(NWorld.World world, int dirX, int dirY){
			entity.MoveDir (world,dirX, dirY);
		}
	}
	

}