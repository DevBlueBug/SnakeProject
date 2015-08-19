using UnityEngine;
using System.Collections;

namespace NGraphic{
	
	public class GraphicManager : MonoBehaviour
	{
		public VisualizerWorld visualWorld;
		public VisualizerEntity visualEntity;

		public void Init(NWorld.World world){
			visualWorld.Dispaly (world);
			visualEntity.Display (world);
			world.E_EntityAdded += H_EntityAdded;
		}
		public void  H_EntityAdded(NWorld.World world, NWorld.NEntity.Entity entity){
			visualEntity.Display (entity);
		}
	}

}
