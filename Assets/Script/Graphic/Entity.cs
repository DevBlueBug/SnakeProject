using UnityEngine;
using System.Collections;

namespace NGraphic{

	public class Entity : MonoBehaviour
	{
		NWorld.NEntity.Entity entity; //entity this is visualizing
		public void Init(NWorld.NEntity.Entity entity){
			this.entity = entity;
			this.transform.localPosition = new Vector3 (entity.X, 0, entity.Y);
			Link (entity);

		}
		void Link(NWorld.NEntity.Entity entity){
			entity.E_Moved = H_Moved;
		}
		void H_Moved(NWorld.World world, NWorld.NEntity.Entity entity, int fromX, int fromY, int toX,int toY){
			transform.localPosition = new Vector3 (toX, 0, toY);
		}
	}
}