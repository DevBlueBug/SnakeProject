using UnityEngine;
using System.Collections;

namespace NWorld.NEntity{
	
	public class Tail : Entity
	{
		Entity entityFollow;
		public Tail(int x, int y, Entity follow):base(x,y){
			this.entityFollow = follow;
			if (follow == null) return;
			follow.E_Moved += H_FollowingEntityMoved;

		}
		void H_FollowingEntityMoved(World world, Entity entity, int fromX, int fromY, int toX, int toY){

			Move (world, fromX,fromY);
		}

	}


}
