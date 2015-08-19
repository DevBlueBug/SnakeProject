using UnityEngine;
using System.Collections;

namespace NWorld.NEntity{

	public class Entity
	{
		public delegate void D_World_Me_INT_INT_INT_INT(World world, Entity me, int fromX,int fromY, int toX,int toY);
		public D_World_Me_INT_INT_INT_INT E_Moved = delegate {	};
		int x,y;
		public Entity(int x, int y){
			this.x = x;
			this.y = y;
		}
		public int X{get{ return x;}}
		public int Y{get{ return y;}}

		public virtual bool IsMoveTo(World world, int x, int y){
			//TODO implement false condition later
			return true;
		}
		
		public virtual bool Move(World world, int x, int y){
			if (!IsMoveTo (world, x, y))
				return false;
			E_Moved (world,this, this.x, this.y,x,y);
			this.x = x;
			this.y = y;
			return true;
		}
		public virtual bool MoveDir(World world, int x, int y){
			if (!IsMoveTo (world, this.x + x,this.y + y))
				return false;
			E_Moved (world,this, this.x, this.y,this.x + x, this.y +y);
			this.x += x;
			this.y += y;
			return true;
		}


	}
}