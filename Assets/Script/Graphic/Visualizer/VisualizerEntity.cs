using UnityEngine;
using System.Collections.Generic;

namespace NGraphic{
	public class VisualizerEntity : MonoBehaviour
	{
		public Entity P_Entity;
		public List<Entity> entities;

		public VisualizerEntity Display(NWorld.World world){
			return this;
		}
		public VisualizerEntity Display(NWorld.NEntity.Entity entity){
			var entityNew = Instantiate (P_Entity);
			entityNew.transform.parent = this.transform;
			entityNew.Init (entity);
			this.entities.Add (entityNew);
			return this;
		}
	}
}
